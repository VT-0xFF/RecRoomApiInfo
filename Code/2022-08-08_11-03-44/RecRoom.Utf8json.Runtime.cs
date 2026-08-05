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
public class LDENEBFHKCJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public LDENEBFHKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CMHICFAFNBA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public CMHICFAFNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AFGLBEPMKBK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public AFGLBEPMKBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class KNGJGBOLAKM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E5480", Offset = "0x5E4480", VA = "0x1805E5480")]
	public KNGJGBOLAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class GHLPGMECJMN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x340DB20", Offset = "0x340CB20", VA = "0x18340DB20")]
	public static bool FGHBGJGLNGA(this TypeInfo GLKKDGLKBMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class HLLNGFIIEKL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type BPPLFIGHALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] IJHBLECNIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x726AD0", Offset = "0x725AD0", VA = "0x180726AD0")]
	public HLLNGFIIEKL(Type CDDKDBNECNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BJGLHGEFOIO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void PHPMEOAGLHK<T>(ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T JJDPBBPLMGE<T>(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO CAGBIMKLMBM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OONIALJDMLO
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPNEMBPIJOL<T> : OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NMCJNPEAHKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CLNKJBBLIJM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KCKBKANOJLH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1C60", Offset = "0x2DE0C60", VA = "0x182DE1C60")]
	public static global::NPNEMBPIJOL<T> CCGNICDIDKK<T>(this JMAAFANLPGO CAGBIMKLMBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34190A0", Offset = "0x34180A0", VA = "0x1834190A0")]
	public static object OCPPEEAOPAL(this JMAAFANLPGO CAGBIMKLMBM, Type GLKKDGLKBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MFIPILDBOJB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F41180", Offset = "0x4F40180", VA = "0x184F41180")]
	public MFIPILDBOJB(string LPDLECBMBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AFHKAOHPCCD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class MNMOOINNLJD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] AIKEPJOBOJF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] JBGKJKDGKIC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x396E970", Offset = "0x396D970", VA = "0x18396E970")]
		public static byte[] PFFOBMHLDIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x396E8E0", Offset = "0x396D8E0", VA = "0x18396E8E0")]
		public static char[] FHAHDKKGCPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LHBIMHNMFKN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KMCOHHINPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FCLFFFPNPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int KDGOCEAMMLM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GFALDODHHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x395D690", Offset = "0x395C690", VA = "0x18395D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x395F260", Offset = "0x395E260", VA = "0x18395F260")]
	public AFHKAOHPCCD(byte[] FCLFFFPNPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x395F080", Offset = "0x395E080", VA = "0x18395F080")]
	public AFHKAOHPCCD(byte[] FCLFFFPNPCK, int KDGOCEAMMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x395D1F0", Offset = "0x395C1F0", VA = "0x18395D1F0")]
	private PJDHDLLOCOL BBEFECNJBMN(string CGNOHBLIFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x395DC40", Offset = "0x395CC40", VA = "0x18395DC40")]
	private PJDHDLLOCOL GLAPNPNMDKB(string LPDLECBMBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x395EEE0", Offset = "0x395DEE0", VA = "0x18395EEE0")]
	public void PADGCLAIJBJ(int KDGOCEAMMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0")]
	public byte[] FJHGDBCMGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8A44B0", Offset = "0x8A34B0", VA = "0x1808A44B0")]
	public int JEKGGFEDANH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x395EC80", Offset = "0x395DC80", VA = "0x18395EC80")]
	public EGDLMGPPECA OJLJGGEBDAD()
	{
		return default(EGDLMGPPECA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x395C790", Offset = "0x395B790", VA = "0x18395C790")]
	public void AHGGCPBHLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x395D6B0", Offset = "0x395C6B0", VA = "0x18395D6B0")]
	public bool CLPMEJHGGFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x395DA60", Offset = "0x395CA60", VA = "0x18395DA60")]
	public bool FIALPKBONOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x395D7D0", Offset = "0x395C7D0", VA = "0x18395D7D0")]
	public void CMBBFADECIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x395DEA0", Offset = "0x395CEA0", VA = "0x18395DEA0")]
	public bool HLCDMFAFOAN(ref int FBKJALIBHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x395E5E0", Offset = "0x395D5E0", VA = "0x18395E5E0")]
	public bool KJHONLKAKKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x395E7F0", Offset = "0x395D7F0", VA = "0x18395E7F0")]
	public void NAAINJHDKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x395E4A0", Offset = "0x395D4A0", VA = "0x18395E4A0")]
	public bool JBDLNKNDHLG(ref int FBKJALIBHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x395C990", Offset = "0x395B990", VA = "0x18395C990")]
	public bool AKHHGENFANG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x395C6F0", Offset = "0x395B6F0", VA = "0x18395C6F0")]
	public void AAELJLAICCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x395E780", Offset = "0x395D780", VA = "0x18395E780")]
	public bool MIFIDOEKABL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x395DF30", Offset = "0x395CF30", VA = "0x18395DF30")]
	public void HMAAADNCDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x395CA60", Offset = "0x395BA60", VA = "0x18395CA60")]
	private void ANJJINEFIBH(out byte[] CPJPEBDFDID, out int PPJNOPCGJFG, out int JLOGDHNDJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x395EEF0", Offset = "0x395DEF0", VA = "0x18395EEF0")]
	private static int PIJJKJFBFPA(char KKHMNCLOHHK, char GMPKOOIGMDG, char ADHKGFCOILB, char COCNKFFEBDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x395DB10", Offset = "0x395CB10", VA = "0x18395DB10")]
	private static int GEJFLENEKEO(char JIOINDMBNBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x395EA60", Offset = "0x395DA60", VA = "0x18395EA60")]
	public ArraySegment<byte> NCFDEGCGFOK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x395E650", Offset = "0x395D650", VA = "0x18395E650")]
	public string KPPHJKOFCMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x395E6F0", Offset = "0x395D6F0", VA = "0x18395E6F0")]
	public string LINMBHCPKFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x395E2F0", Offset = "0x395D2F0", VA = "0x18395E2F0")]
	public ArraySegment<byte> ICDLIELNIBO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x395DAD0", Offset = "0x395CAD0", VA = "0x18395DAD0")]
	public ArraySegment<byte> FLGHFCICNJH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x395E090", Offset = "0x395D090", VA = "0x18395E090")]
	public bool IANHEMNMPEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x395EB50", Offset = "0x395DB50", VA = "0x18395EB50")]
	private static bool NCGDPLBKAMG(byte ADHKGFCOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x395E890", Offset = "0x395D890", VA = "0x18395E890")]
	private void NAFOHANDEPG(EGDLMGPPECA KGJPBGICHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x395EC70", Offset = "0x395DC70", VA = "0x18395EC70")]
	public void OHAIBJPNPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x395EE10", Offset = "0x395DE10", VA = "0x18395EE10")]
	private void OOPMDIECABJ(int DEHLNNDNHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x395E530", Offset = "0x395D530", VA = "0x18395E530")]
	public sbyte JDCCLDJAAEO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x395E720", Offset = "0x395D720", VA = "0x18395E720")]
	public short LPGBGHHAKGI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x395DBE0", Offset = "0x395CBE0", VA = "0x18395DBE0")]
	public int GJLBLLINLNA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x395D870", Offset = "0x395C870", VA = "0x18395D870")]
	public long DHPFGKFCJMI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x395E580", Offset = "0x395D580", VA = "0x18395E580")]
	public byte KBFFNECEBOK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x395EC10", Offset = "0x395DC10", VA = "0x18395EC10")]
	public ushort OBDDFJKPDKE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x395CA00", Offset = "0x395BA00", VA = "0x18395CA00")]
	public uint ANCDNFPPDHA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x395D8F0", Offset = "0x395C8F0", VA = "0x18395D8F0")]
	public ulong DMAPMKJBFCH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x395DFD0", Offset = "0x395CFD0", VA = "0x18395DFD0")]
	public float HONKCPGCEHB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x395C8D0", Offset = "0x395B8D0", VA = "0x18395C8D0")]
	public double AKELMHGJIOE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x395D970", Offset = "0x395C970", VA = "0x18395D970")]
	public ArraySegment<byte> EFDCICBACJO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x395DD20", Offset = "0x395CD20", VA = "0x18395DD20")]
	private static int HINLPAMDLAM(byte[] FCLFFFPNPCK, int KDGOCEAMMLM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PJDHDLLOCOL : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference OMPKGKMLLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int KOOOLJDBHII;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FCPLFNPIMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1483F40", Offset = "0x1482F40", VA = "0x181483F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KKHOCLKKKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67FE10", Offset = "0x67EE10", VA = "0x18067FE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C960", Offset = "0x4F4B960", VA = "0x184F4C960")]
	public PJDHDLLOCOL(string LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C890", Offset = "0x4F4B890", VA = "0x184F4C890")]
	public PJDHDLLOCOL(string LPDLECBMBMG, byte[] AHJPNAMEDNJ, int KDGOCEAMMLM, int KOOOLJDBHII, string IAGLAODJNFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GFCLCCCLLND
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KFPGACHIADN
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void LCJCFDMDAFM(ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object MDKEBKHHOHL(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO CAGBIMKLMBM);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NPLNJPJGGML
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class NAAIHIDDLCG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
				public NAAIHIDDLCG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3424840", Offset = "0x3423840", VA = "0x183424840")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x3424880", Offset = "0x3423880", VA = "0x183424880")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, JMAAFANLPGO, byte[]> NDNAGFMLHGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, JMAAFANLPGO> NGFLGBHNFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LCJCFDMDAFM FOCCFMIJJOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, JMAAFANLPGO, ArraySegment<byte>> IEKGJIPCNPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, JMAAFANLPGO, string> JILHBHPHGJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, JMAAFANLPGO, object> KELLFFPLBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, JMAAFANLPGO, object> FGELHHNPDIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, JMAAFANLPGO, object> EJLEDAMJCME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly MDKEBKHHOHL FIHGIBHJPBM;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3424C70", Offset = "0x3423C70", VA = "0x183424C70")]
			public NPLNJPJGGML(Type GLKKDGLKBMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x20C4630", Offset = "0x20C3630", VA = "0x1820C4630")]
			private static T NPAOLEIKMHC<T>(DynamicMethod HOJEIAJMKBJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3424A80", Offset = "0x3423A80", VA = "0x183424A80")]
			private static MethodInfo JAFDHOHGNAK(Type GLKKDGLKBMK, string MBHNCPMPIFB, Type[] FDHPMHLBFEO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, NPLNJPJGGML> MNAHDGIIGBN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::PLFGLOIOOAG<NPLNJPJGGML> MIAKHEFHEHO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x34196B0", Offset = "0x34186B0", VA = "0x1834196B0")]
		static KFPGACHIADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x34193B0", Offset = "0x34183B0", VA = "0x1834193B0")]
		private static NPLNJPJGGML LKIJIOFJOLK(Type GLKKDGLKBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3419540", Offset = "0x3418540", VA = "0x183419540")]
		public static void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3419430", Offset = "0x3418430", VA = "0x183419430")]
		public static void NJADPKHDAEC(Type GLKKDGLKBMK, ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class GFNBBAOPFOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] AIKEPJOBOJF;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x340D460", Offset = "0x340C460", VA = "0x18340D460")]
		public static byte[] PFFOBMHLDIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JMAAFANLPGO ECHMIANMFKK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] NNCKAHEEGDH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] MNBIDDLABFA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JMAAFANLPGO EANMLDHLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x340D1C0", Offset = "0x340C1C0", VA = "0x18340D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x340D2D0", Offset = "0x340C2D0", VA = "0x18340D2D0")]
	public static void LNILCEODBPP(JMAAFANLPGO CAGBIMKLMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x215A1E0", Offset = "0x21591E0", VA = "0x18215A1E0")]
	public static string HEGENFLLLPF<T>(T JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x215A080", Offset = "0x2159080", VA = "0x18215A080")]
	public static string HEGENFLLLPF<T>(T JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20B2230", Offset = "0x20B1230", VA = "0x1820B2230")]
	public static T HIDKAFCIGIB<T>(string GDMANBCEBLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20B2160", Offset = "0x20B1160", VA = "0x1820B2160")]
	public static T HIDKAFCIGIB<T>(string GDMANBCEBLD, JMAAFANLPGO CAGBIMKLMBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20B2400", Offset = "0x20B1400", VA = "0x1820B2400")]
	public static T HIDKAFCIGIB<T>(byte[] FCLFFFPNPCK, JMAAFANLPGO CAGBIMKLMBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20B22B0", Offset = "0x20B12B0", VA = "0x1820B22B0")]
	public static T HIDKAFCIGIB<T>(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, JMAAFANLPGO CAGBIMKLMBM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EGDLMGPPECA : byte
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
public struct DLCIAKEHIIK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] HJMELACAEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] AIKEPJOBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KDGOCEAMMLM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MHAIGDONIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A44B0", Offset = "0x8A34B0", VA = "0x1808A44B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x395EEE0", Offset = "0x395DEE0", VA = "0x18395EEE0")]
	public void PADGCLAIJBJ(int KDGOCEAMMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x39693B0", Offset = "0x39683B0", VA = "0x1839693B0")]
	public static byte[] KOPAMEAGEMG(string JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3968F90", Offset = "0x3967F90", VA = "0x183968F90")]
	public static byte[] HJFAHDBEFMG(string JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39690C0", Offset = "0x39680C0", VA = "0x1839690C0")]
	public static byte[] ICFKBFGNEFD(string JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3969690", Offset = "0x3968690", VA = "0x183969690")]
	public static byte[] MHBLHFMOAOC(string JPOEBAHCHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD7C2A0", Offset = "0xD7B2A0", VA = "0x180D7C2A0")]
	public DLCIAKEHIIK(byte[] CGOPEJPEADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3969970", Offset = "0x3968970", VA = "0x183969970")]
	public ArraySegment<byte> PFFOBMHLDIK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3968B00", Offset = "0x3967B00", VA = "0x183968B00")]
	public byte[] GOIKPCPFMLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3969A70", Offset = "0x3968A70", VA = "0x183969A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3969490", Offset = "0x3968490", VA = "0x183969490")]
	public void LLEKFFHMMIL(int ODFOLPGMGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3968920", Offset = "0x3967920", VA = "0x183968920")]
	public void FFJLJLHPAFE(byte[] BMMDPAJNECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3968F50", Offset = "0x3967F50", VA = "0x183968F50")]
	public void HDEHBCOIEGJ(byte BMMDPAJNECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3969A20", Offset = "0x3968A20", VA = "0x183969A20")]
	public void PIPPGGLBGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3969920", Offset = "0x3968920", VA = "0x183969920")]
	public void OLFDABILCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3969220", Offset = "0x3968220", VA = "0x183969220")]
	public void JMFMFODOKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3968980", Offset = "0x3967980", VA = "0x183968980")]
	public void FHFOJHMCNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x39697F0", Offset = "0x39687F0", VA = "0x1839697F0")]
	public void MNKLMMJDFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x39698A0", Offset = "0x39688A0", VA = "0x1839698A0")]
	public void OABFCFIGBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3968840", Offset = "0x3967840", VA = "0x183968840")]
	public void BMHFOBFDOIO(string JPOEBAHCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x39688D0", Offset = "0x39678D0", VA = "0x1839688D0")]
	public void EFGDOAOPKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3968A30", Offset = "0x3967A30", VA = "0x183968A30")]
	public void GKNANKHGDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x39694A0", Offset = "0x39684A0", VA = "0x1839694A0")]
	public void LPMNGFAFPGG(bool JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x39686C0", Offset = "0x39676C0", VA = "0x1839686C0")]
	public void AABFNKKLHLO(float JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3969270", Offset = "0x3968270", VA = "0x183969270")]
	public void KLPPLPKCKLO(double JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3969840", Offset = "0x3968840", VA = "0x183969840")]
	public void NDLJIKKFFFI(byte JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x39689D0", Offset = "0x39679D0", VA = "0x1839689D0")]
	public void FMJBFPIDIJK(ushort JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3968810", Offset = "0x3967810", VA = "0x183968810")]
	public void BCIFJHPIJKH(uint JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x39698F0", Offset = "0x39688F0", VA = "0x1839698F0")]
	public void OEEBPPOJDNL(ulong JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3969870", Offset = "0x3968870", VA = "0x183969870")]
	public void NMCCDAHINNJ(sbyte JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x39688A0", Offset = "0x39678A0", VA = "0x1839688A0")]
	public void BMIMPFJPAPO(short JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x39691F0", Offset = "0x39681F0", VA = "0x1839691F0")]
	public void ILCANOCHHCA(int JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3968A00", Offset = "0x3967A00", VA = "0x183968A00")]
	public void GAMFFBNICOP(long JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3968B80", Offset = "0x3967B80", VA = "0x183968B80")]
	public void HALNEEJDFPC(string JNLOLNFALGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KJIPGJDNJPK : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class POPMMCNPFDE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3E07590", Offset = "0x3E06590", VA = "0x183E07590")]
		static POPMMCNPFDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private KJIPGJDNJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class IBHLGDMLHPL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BPFIPMJJKJB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3413040", Offset = "0x3412040", VA = "0x183413040")]
	static IBHLGDMLHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3412AE0", Offset = "0x3411AE0", VA = "0x183412AE0")]
	internal static object HAOFLCFOCGA(Type JBJIMKKMMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BPJLLIEPEGG : global::NPNEMBPIJOL<Vector2>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3964640", Offset = "0x3963640", VA = "0x183964640")]
	public BPJLLIEPEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x39644D0", Offset = "0x39634D0", VA = "0x1839644D0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Vector2 JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x39641E0", Offset = "0x39631E0", VA = "0x1839641E0", Slot = "5")]
	public Vector2 HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HDPILDCECAJ : global::NPNEMBPIJOL<Vector3>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3410E50", Offset = "0x340FE50", VA = "0x183410E50")]
	public HDPILDCECAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3410D30", Offset = "0x340FD30", VA = "0x183410D30", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Vector3 JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3410B40", Offset = "0x340FB40", VA = "0x183410B40", Slot = "5")]
	public Vector3 HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IBFHHDDMCGP : global::NPNEMBPIJOL<Vector4>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34127F0", Offset = "0x34117F0", VA = "0x1834127F0")]
	public IBFHHDDMCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34126A0", Offset = "0x34116A0", VA = "0x1834126A0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Vector4 JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3412470", Offset = "0x3411470", VA = "0x183412470", Slot = "5")]
	public Vector4 HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class AJJDOGOCHIE : global::NPNEMBPIJOL<Quaternion>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x395FFB0", Offset = "0x395EFB0", VA = "0x18395FFB0")]
	public AJJDOGOCHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x395FD40", Offset = "0x395ED40", VA = "0x18395FD40", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Quaternion JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x395F9C0", Offset = "0x395E9C0", VA = "0x18395F9C0", Slot = "5")]
	public Quaternion HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BBDBOPAGMCK : global::NPNEMBPIJOL<Color>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39618D0", Offset = "0x39608D0", VA = "0x1839618D0")]
	public BBDBOPAGMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x395FD40", Offset = "0x395ED40", VA = "0x18395FD40", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Color JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3961550", Offset = "0x3960550", VA = "0x183961550", Slot = "5")]
	public Color HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class MMACECCAJAN : global::NPNEMBPIJOL<Bounds>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F439A0", Offset = "0x4F429A0", VA = "0x184F439A0")]
	public MMACECCAJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F43730", Offset = "0x4F42730", VA = "0x184F43730", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Bounds JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F43490", Offset = "0x4F42490", VA = "0x184F43490", Slot = "5")]
	public Bounds HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class ABNAOAOLCJD : global::NPNEMBPIJOL<Rect>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AHLMAGAEFKO BMLEIMFBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] PIHHMGLLIBG;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x395A000", Offset = "0x3959000", VA = "0x18395A000")]
	public ABNAOAOLCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3959D70", Offset = "0x3958D70", VA = "0x183959D70", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Rect JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x39599C0", Offset = "0x39589C0", VA = "0x1839599C0", Slot = "5")]
	public Rect HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BBIEMJIAKPH : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class GMMEKDCOHMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x24D3870", Offset = "0x24D2870", VA = "0x1824D3870")]
		static GMMEKDCOHMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private BBIEMJIAKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CCALCHNOIFB : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class EFLAPLANOOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2889EF0", Offset = "0x2888EF0", VA = "0x182889EF0")]
		static EFLAPLANOOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class PFMPCJLHLHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JJJIGDHACHB;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x396FED0", Offset = "0x396EED0", VA = "0x18396FED0")]
		internal static object HAOFLCFOCGA(Type JBJIMKKMMPN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private CCALCHNOIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class AEAMMFPHKEL : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class FIBOLAAJHJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x30A7F40", Offset = "0x30A6F40", VA = "0x1830A7F40")]
		static FIBOLAAJHJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AEAMMFPHKEL CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool DCOOLFOAMPL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static OONIALJDMLO[] GCJGPKLLIHK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static JMAAFANLPGO[] NIBJEKFACAD;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private AEAMMFPHKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x395BFA0", Offset = "0x395AFA0", VA = "0x18395BFA0")]
	public static void HCCDLMMPDLB(params JMAAFANLPGO[] NIBJEKFACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x395BEE0", Offset = "0x395AEE0", VA = "0x18395BEE0")]
	public static void HCCDLMMPDLB(params OONIALJDMLO[] GCJGPKLLIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x395C060", Offset = "0x395B060", VA = "0x18395C060")]
	public static void PMBLICHBCPD(OONIALJDMLO[] GCJGPKLLIHK, JMAAFANLPGO[] NIBJEKFACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FEHHABMBELD : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class NBDIGNPBBHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7C20", Offset = "0x4BB6C20", VA = "0x184BB7C20")]
		static NBDIGNPBBHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private FEHHABMBELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MHJPKCHJOCF
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly JMAAFANLPGO CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly JMAAFANLPGO IMDOADDBBGD;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly JMAAFANLPGO FKANDJPEIEI;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly JMAAFANLPGO MBIMIOPKKMI;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly JMAAFANLPGO OMKEFAPCAEP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly JMAAFANLPGO JBKLBEAJNFE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly JMAAFANLPGO JGDPKOAGHPC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly JMAAFANLPGO PFHJLEBIOAA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly JMAAFANLPGO DHFIMKLCDIK;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly JMAAFANLPGO APKHEMJGFAP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly JMAAFANLPGO ABKBPPAICOK;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JMAAFANLPGO FJKMJALJMOO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ECLOFHFJECI
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly JMAAFANLPGO CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JMAAFANLPGO IJEHKBCEINE;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AAEAENMKJMB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly JMAAFANLPGO CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly JMAAFANLPGO IMDOADDBBGD;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly JMAAFANLPGO FKANDJPEIEI;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly JMAAFANLPGO MBIMIOPKKMI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly JMAAFANLPGO OMKEFAPCAEP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly JMAAFANLPGO JBKLBEAJNFE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly JMAAFANLPGO JGDPKOAGHPC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly JMAAFANLPGO PFHJLEBIOAA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JMAAFANLPGO DHFIMKLCDIK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly JMAAFANLPGO APKHEMJGFAP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly JMAAFANLPGO ABKBPPAICOK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly JMAAFANLPGO FJKMJALJMOO;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class BHHMMAHFCHM
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JJJIGDHACHB;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3962140", Offset = "0x3961140", VA = "0x183962140")]
	internal static object HAOFLCFOCGA(Type JBJIMKKMMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3962100", Offset = "0x3961100", VA = "0x183962100")]
	private static object GILBGHIFMJJ(Type NBAAGGFINKJ, Type[] IPEJCNGAFDB, params object[] FDHPMHLBFEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OCBHLCOAHHG : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class FHGDBHEDFGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4817A80", Offset = "0x4816A80", VA = "0x184817A80")]
		static FHGDBHEDFGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F47A40", Offset = "0x4F46A40", VA = "0x184F47A40")]
	static OCBHLCOAHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private OCBHLCOAHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MIOGEGMLNKC : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class KIFBPOPKINH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3714370", Offset = "0x3713370", VA = "0x183714370")]
		static KIFBPOPKINH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F41800", Offset = "0x4F40800", VA = "0x184F41800")]
	static MIOGEGMLNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private MIOGEGMLNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class HDLHMGOHNOI : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class KKGPECJPAHE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x432C990", Offset = "0x432B990", VA = "0x18432C990")]
		static KKGPECJPAHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3410970", Offset = "0x340F970", VA = "0x183410970")]
	static HDLHMGOHNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private HDLHMGOHNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class POFIFPCICDA : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class NFFADDDMBKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x30C2910", Offset = "0x30C1910", VA = "0x1830C2910")]
		static NFFADDDMBKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D3B0", Offset = "0x4F4C3B0", VA = "0x184F4D3B0")]
	static POFIFPCICDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private POFIFPCICDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class OADOBJGLHKM : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class PLDFOCOMJBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x481E9E0", Offset = "0x481D9E0", VA = "0x18481E9E0")]
		static PLDFOCOMJBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F47950", Offset = "0x4F46950", VA = "0x184F47950")]
	static OADOBJGLHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private OADOBJGLHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NIPNJHCONOL : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MJBLGCIGFJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x26E9410", Offset = "0x26E8410", VA = "0x1826E9410")]
		static MJBLGCIGFJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly HHMBJMBCPGD ABDOLMOHHJK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F456E0", Offset = "0x4F446E0", VA = "0x184F456E0")]
	static NIPNJHCONOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private NIPNJHCONOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GPINAIBHILJ : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class ANBBCOACLNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2FBE640", Offset = "0x2FBD640", VA = "0x182FBE640")]
		static ANBBCOACLNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GPINAIBHILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LPOLGBCHBFJ : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class ECONANINIAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A8BA40", Offset = "0x3A8AA40", VA = "0x183A8BA40")]
		static ECONANINIAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LPOLGBCHBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LMCHJNOJIJH : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class GAMHIIDCEGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A076A0", Offset = "0x3A066A0", VA = "0x183A076A0")]
		static GAMHIIDCEGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LMCHJNOJIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class BPMDECKLGPL : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class EJKGIKGLJDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E300A0", Offset = "0x3E2F0A0", VA = "0x183E300A0")]
		static EJKGIKGLJDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public BPMDECKLGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class KPJJGPNNILB : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class NKDFNDOKCPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E050D0", Offset = "0x3E040D0", VA = "0x183E050D0")]
		static NKDFNDOKCPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KPJJGPNNILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IGDAGOANHEE : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class LCCFADKILDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x251DB20", Offset = "0x251CB20", VA = "0x18251DB20")]
		static LCCFADKILDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> LHGHDFHEHKE;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool EAAOOGIBHFL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IGDAGOANHEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class LDBFNIJPCAI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct EBNHMPEJPHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PCJMKFENHGO PMIECDOJFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder CBNBAFCOALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PNNLEJIMKAB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class MCGPPEIIAID
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class JBGMEMKGKOM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo ICFKBFGNEFD;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo HJFAHDBEFMG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MHBLHFMOAOC;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo KOPAMEAGEMG;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo GKNANKHGDOB;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo FFJLJLHPAFE;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo JMFMFODOKEL;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo FHFOJHMCNEL;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo MNKLMMJDFDH;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x34160E0", Offset = "0x34150E0", VA = "0x1834160E0")]
			static JBGMEMKGKOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class KANCMHMMNBF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo CLPMEJHGGFC;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo NAAINJHDKDO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JBDLNKNDHLG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo FDAJFNKJFAL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo OHAIBJPNPAG;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo FJHGDBCMGGG;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo JEKGGFEDANH;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x34185A0", Offset = "0x34175A0", VA = "0x1834185A0")]
			static KANCMHMMNBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GHHFNPKIDLO
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo BPPLFIGHALF;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo IJHBLECNIKH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MEGOGBJOFPF;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CCGNICDIDKK;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo NDLOCHIEMCO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo OLOHBKFPCFK;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo NCOHOGEAAON;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo CFLEKOIGHJM;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo BKNPDHIDBDM;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo IMDGKDDFLEG;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo MLCGOFONDJD;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo EEGNMIIGKJC;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo ILBEAJIBNNE;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo MHDJFLNKPGE;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3422E40", Offset = "0x3421E40", VA = "0x183422E40")]
		public static MethodInfo NJADPKHDAEC(Type GLKKDGLKBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3422AF0", Offset = "0x3421AF0", VA = "0x183422AF0")]
		public static MethodInfo HIDKAFCIGIB(Type GLKKDGLKBMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3422D20", Offset = "0x3421D20", VA = "0x183422D20")]
		public static MethodInfo HKPPPAHODOA(Type GLKKDGLKBMK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LFPPCAPOJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<PCJMKFENHGO, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LFPPCAPOJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PNIPONCBAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LFPPCAPOJNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PNIPONCBAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D2D0", Offset = "0x4F4C2D0", VA = "0x184F4D2D0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D310", Offset = "0x4F4C310", VA = "0x184F4D310")]
		internal bool <BuildType>b__2(int index, PCJMKFENHGO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BEDKLOANHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LFPPCAPOJNK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public BEDKLOANHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x340CBF0", Offset = "0x340BBF0", VA = "0x18340CBF0")]
		internal bool <BuildType>b__3(int index, PCJMKFENHGO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LKAKKMIBABP
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
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LKAKKMIBABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3422A90", Offset = "0x3421A90", VA = "0x183422A90")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IACBDHHHCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IACBDHHHCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3412410", Offset = "0x3411410", VA = "0x183412410")]
		internal bool <BuildAnonymousFormatter>b__2(PCJMKFENHGO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GLGLIJJDEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LKAKKMIBABP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public GLGLIJJDEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x340DB50", Offset = "0x340CB50", VA = "0x18340DB50")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x340DBD0", Offset = "0x340CBD0", VA = "0x18340DBD0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, PCJMKFENHGO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EKPDNGJDGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LKAKKMIBABP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public EKPDNGJDGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x340CE80", Offset = "0x340BE80", VA = "0x18340CE80")]
		internal bool <BuildAnonymousFormatter>b__7(int index, PCJMKFENHGO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KDIFCFCNCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public KDIFCFCNCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCC0", Offset = "0x5ECCC0", VA = "0x1805EDCC0")]
		internal Label <BuildSerialize>b__1(PCJMKFENHGO _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LBCDCGLFKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EBNHMPEJPHP[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, PCJMKFENHGO, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IOKEJFMHLBO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IOKEJFMHLBO argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public LBCDCGLFKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x341A4E0", Offset = "0x34194E0", VA = "0x18341A4E0")]
		internal EBNHMPEJPHP <BuildDeserialize>b__0(PCJMKFENHGO item)
		{
			return default(EBNHMPEJPHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IDODOGGGEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LBCDCGLFKNO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public IDODOGGGEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3413400", Offset = "0x3412400", VA = "0x183413400")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x34136E0", Offset = "0x34126E0", VA = "0x1834136E0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PACBHKGNJHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public PCJMKFENHGO item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public PACBHKGNJHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1458770", Offset = "0x1457770", VA = "0x181458770")]
		internal bool <EmitNewObject>b__0(EBNHMPEJPHP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HJLFDFGMALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PCJMKFENHGO item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public HJLFDFGMALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1458770", Offset = "0x1457770", VA = "0x181458770")]
		internal bool <EmitNewObject>b__2(EBNHMPEJPHP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex CHMDMHFOJLL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int DFAMBHNFGIJ;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JFOFGMLNNEG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> PIDFMFKMDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AAD0", Offset = "0x2C49AD0", VA = "0x182C4AAD0")]
	public static object PLIFKAEICLH<T>(HHMBJMBCPGD ABDOLMOHHJK, JMAAFANLPGO BHMIACGLCEG, Func<string, string> LHGHDFHEHKE, bool EAAOOGIBHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C44B00", Offset = "0x2C43B00", VA = "0x182C44B00")]
	public static object OPJHAGFKKFE<T>(JMAAFANLPGO BHMIACGLCEG, Func<string, string> LHGHDFHEHKE, bool EAAOOGIBHFL, bool PLFFEEJJANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x341CDE0", Offset = "0x341BDE0", VA = "0x18341CDE0")]
	private static TypeInfo KBPLLDNAAJD(HHMBJMBCPGD ABDOLMOHHJK, Type GLKKDGLKBMK, Func<string, string> LHGHDFHEHKE, bool EAAOOGIBHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x341AE90", Offset = "0x3419E90", VA = "0x18341AE90")]
	public static object DOMMBKOBCMG(Type GLKKDGLKBMK, Func<string, string> LHGHDFHEHKE, bool EAAOOGIBHFL, bool PLFFEEJJANC, bool NIEPGENENIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x341D880", Offset = "0x341C880", VA = "0x18341D880")]
	private static Dictionary<PCJMKFENHGO, FieldInfo> KFKMEDFBCPP(TypeBuilder KMGLBNAFPPP, CMJJINEBEBP APJDICMKPPA, ConstructorInfo KKLMGGNHHPK, FieldBuilder IHIJIMCJFIG, ILGenerator MFPKEMLEICB, bool EAAOOGIBHFL, bool LKJJNPCGMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3421FB0", Offset = "0x3420FB0", VA = "0x183421FB0")]
	private static Dictionary<PCJMKFENHGO, FieldInfo> PMDCFGCBGAF(TypeBuilder KMGLBNAFPPP, CMJJINEBEBP APJDICMKPPA, ILGenerator MFPKEMLEICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34209D0", Offset = "0x341F9D0", VA = "0x1834209D0")]
	private static void PHAJCJJBLFG(Type GLKKDGLKBMK, CMJJINEBEBP APJDICMKPPA, ILGenerator MFPKEMLEICB, Action EKLPGHCFOIN, Func<int, PCJMKFENHGO, bool> NGEOKJCNFCK, bool EAAOOGIBHFL, bool LKJJNPCGMHM, int KOJGLAEIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x341C830", Offset = "0x341B830", VA = "0x18341C830")]
	private static void HLFKCFCENDJ(TypeInfo GLKKDGLKBMK, PCJMKFENHGO APKBHOGIEIO, ILGenerator MFPKEMLEICB, int IIHEDPBOLFE, Func<int, PCJMKFENHGO, bool> NGEOKJCNFCK, IOKEJFMHLBO FDGBHFMGIPL, IOKEJFMHLBO NHFDFEPHEJN, IOKEJFMHLBO DNMNHFOCFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x341F630", Offset = "0x341E630", VA = "0x18341F630")]
	private static void OGKLFKOHOME(Type GLKKDGLKBMK, CMJJINEBEBP APJDICMKPPA, ILGenerator MFPKEMLEICB, Func<int, PCJMKFENHGO, bool> NGEOKJCNFCK, bool FLJMLJHNDLL, int KOJGLAEIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x341AA70", Offset = "0x3419A70", VA = "0x18341AA70")]
	private static void DJHOEBOKFMJ(ILGenerator MFPKEMLEICB, EBNHMPEJPHP APJDICMKPPA, int IIHEDPBOLFE, Func<int, PCJMKFENHGO, bool> NGEOKJCNFCK, IOKEJFMHLBO FDKCNEJMANN, IOKEJFMHLBO DNMNHFOCFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x341DF80", Offset = "0x341CF80", VA = "0x18341DF80")]
	private static LocalBuilder KIHDJDJGCCB(ILGenerator MFPKEMLEICB, Type GLKKDGLKBMK, CMJJINEBEBP APJDICMKPPA, EBNHMPEJPHP[] ACFIJCNLEEG, bool BAGFJMEJKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x341EE00", Offset = "0x341DE00", VA = "0x18341EE00")]
	private static bool NONGAHCPCFP(ConstructorInfo OCEGGGIBOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x341EC60", Offset = "0x341DC60", VA = "0x18341EC60")]
	private static bool MBCNNHKNEIF(Type GLKKDGLKBMK, out Type LIJEAOFLGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void NBFICDPKBOL<T>(byte[][] IHIJIMCJFIG, object[] KDNEHOBBMAE, ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO CAGBIMKLMBM);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T IHHDMPHECML<T>(object[] KDNEHOBBMAE, ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO CAGBIMKLMBM);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class LAPLKEJDMOJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class JNMFCOFIIME : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class HOKFENPONOE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3D797E0", Offset = "0x3D787E0", VA = "0x183D797E0")]
		static HOKFENPONOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private JNMFCOFIIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class KMEEBBABEKF : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class FKGMBENCHEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5480", Offset = "0x3DF4480", VA = "0x183DF5480")]
		static FKGMBENCHEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private KMEEBBABEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HEAKIGNMFBI
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly JMAAFANLPGO[] FJOCAALKHPO;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class CJPLJEOFBAD : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class LFDONBJFPCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2723D10", Offset = "0x2722D10", VA = "0x182723D10")]
		static LFDONBJFPCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class HKPCECHJIJP : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class EBALEECPIIE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x271EC70", Offset = "0x271DC70", VA = "0x18271EC70")]
			static EBALEECPIIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private HKPCECHJIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private CJPLJEOFBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class GBLKNKLFPLG : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class HGBELAEFHMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x44904E0", Offset = "0x448F4E0", VA = "0x1844904E0")]
		static HGBELAEFHMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class JAADCNMMCNO : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class HKFDABMAGBG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x44969C0", Offset = "0x44959C0", VA = "0x1844969C0")]
			static HKFDABMAGBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private JAADCNMMCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private GBLKNKLFPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class EDFEFKFHDEM : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class PCNKDONPDMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C194B0", Offset = "0x3C184B0", VA = "0x183C194B0")]
		static PCNKDONPDMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class ODOEHDDOBGA : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class BFGJIIPKIMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3C09510", Offset = "0x3C08510", VA = "0x183C09510")]
			static BFGJIIPKIMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private ODOEHDDOBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private EDFEFKFHDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class CBNALACKGII : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class BPCDCHMIHGE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2879320", Offset = "0x2878320", VA = "0x182879320")]
		static BPCDCHMIHGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class KHNJCAINLHP : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class ABLKDCLJMNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2875330", Offset = "0x2874330", VA = "0x182875330")]
			static ABLKDCLJMNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private KHNJCAINLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private CBNALACKGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class IPMAEGFIJGC : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class JCIBCLJIHJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x33487D0", Offset = "0x33477D0", VA = "0x1833487D0")]
		static JCIBCLJIHJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class COIAEBDHFMB : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class LMMGLKFAFIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3352560", Offset = "0x3351560", VA = "0x183352560")]
			static LMMGLKFAFIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private COIAEBDHFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private IPMAEGFIJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class CGLIONAFBHO : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class LLNDJGJHMBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x42C7BE0", Offset = "0x42C6BE0", VA = "0x1842C7BE0")]
		static LLNDJGJHMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class KEBDGOHPCEJ : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class ELCHMHEABNN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42C5020", Offset = "0x42C4020", VA = "0x1842C5020")]
			static ELCHMHEABNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private KEBDGOHPCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private CGLIONAFBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class GEGPOMMEHGB : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class BOFGBMGLODF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x40324F0", Offset = "0x40314F0", VA = "0x1840324F0")]
		static BOFGBMGLODF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class NPOMHFIDHNF : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class BBLKDOHBEDB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x402E590", Offset = "0x402D590", VA = "0x18402E590")]
			static BBLKDOHBEDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private NPOMHFIDHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private GEGPOMMEHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class EMCEPEKLENE : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class JBCPBCHIKCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x336DE60", Offset = "0x336CE60", VA = "0x18336DE60")]
		static JBCPBCHIKCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class HLKKADBOCFO : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class BLMLOEBFJDG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3355750", Offset = "0x3354750", VA = "0x183355750")]
			static BLMLOEBFJDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private HLKKADBOCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private EMCEPEKLENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class NNBAMPICHKL : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class EGMBPJNHKNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x26E6650", Offset = "0x26E5650", VA = "0x1826E6650")]
		static EGMBPJNHKNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class IINNPOFHOFG : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class DJIHODBACPC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x26E1DD0", Offset = "0x26E0DD0", VA = "0x1826E1DD0")]
			static DJIHODBACPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private IINNPOFHOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private NNBAMPICHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class ANIAGNPAJME : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class APIHDNKJJPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4521110", Offset = "0x4520110", VA = "0x184521110")]
		static APIHDNKJJPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KKIDEFENPII : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DCHPEPDJOMA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4537890", Offset = "0x4536890", VA = "0x184537890")]
			static DCHPEPDJOMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private KKIDEFENPII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private ANIAGNPAJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class KFMMAODMKFI : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class DKCJLPIHDDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x22433C0", Offset = "0x22423C0", VA = "0x1822433C0")]
		static DKCJLPIHDDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class HFFFDAHCGNL : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class LGNOPHCEPAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2253830", Offset = "0x2252830", VA = "0x182253830")]
			static LGNOPHCEPAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private HFFFDAHCGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private KFMMAODMKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class EJDAKCFONAM : JMAAFANLPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class IKDKPBFBGGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x33671B0", Offset = "0x33661B0", VA = "0x1833671B0")]
		static IKDKPBFBGGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class IIHEBHJACMD : JMAAFANLPGO
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class GGCPIIINGMJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::NPNEMBPIJOL<T> ALKHDLPOLJH;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x33632D0", Offset = "0x33622D0", VA = "0x1833632D0")]
			static GGCPIIINGMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly JMAAFANLPGO CEPBJDBANMN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly JMAAFANLPGO[] NIBJEKFACAD;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		private IIHEBHJACMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
		public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly JMAAFANLPGO CEPBJDBANMN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::NPNEMBPIJOL<object> AFHFGBCMNPM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	private EJDAKCFONAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2607A80", Offset = "0x2606A80", VA = "0x182607A80", Slot = "4")]
	public global::NPNEMBPIJOL<T> HAOFLCFOCGA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct GDEHINOINHB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] OJCFJAINDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int GFEAMCLPGON;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x403BB00", Offset = "0x403AB00", VA = "0x18403BB00")]
	public GDEHINOINHB(int FHKAJCFILHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x403B960", Offset = "0x403A960", VA = "0x18403B960")]
	public void PPCBFHPPBHE(T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x403B7F0", Offset = "0x403A7F0", VA = "0x18403B7F0")]
	public T[] EMJOBPCJJFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class NDFDLMEBJPC : global::CEKFDKLOEBB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly NDFDLMEBJPC CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4F44200", Offset = "0x4F43200", VA = "0x184F44200")]
	public NDFDLMEBJPC(int PFDPOADPOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class CEKFDKLOEBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int PFDPOADPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object BAANHGHNLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int IIHEDPBOLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] IMOKGOPKDOC;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x42C06C0", Offset = "0x42BF6C0", VA = "0x1842C06C0")]
	public CEKFDKLOEBB(int PFDPOADPOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x42BF040", Offset = "0x42BE040", VA = "0x1842BF040")]
	public T[] MOAHPMAJAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x42BFF40", Offset = "0x42BEF40", VA = "0x1842BFF40")]
	public void NLKNNJPLKHE(T[] DNAEDFOPGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class AHLMAGAEFKO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class ONKMABHAOKC : IComparable<ONKMABHAOKC>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class MHHFCOFDDNE : IEnumerable<ONKMABHAOKC>, IEnumerable, IEnumerator<ONKMABHAOKC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private ONKMABHAOKC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public ONKMABHAOKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private ONKMABHAOKC System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
			[DebuggerHidden]
			public MHHFCOFDDNE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x396E760", Offset = "0x396D760", VA = "0x18396E760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x396E890", Offset = "0x396D890", VA = "0x18396E890", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x396E7F0", Offset = "0x396D7F0", VA = "0x18396E7F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ONKMABHAOKC> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x396E7F0", Offset = "0x396D7F0", VA = "0x18396E7F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class EEDICNOOBGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public EEDICNOOBGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCC0", Offset = "0x5ECCC0", VA = "0x1805EDCC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5EDCC0", Offset = "0x5ECCC0", VA = "0x1805EDCC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly ONKMABHAOKC[] GBFIMPKCIFB;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] MGGHKILKAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong CLPKDAIHDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int GFNFCEIHNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CAMJJKLMKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ONKMABHAOKC[] MJMIDPNJIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] MIBFMBLFMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int FBKJALIBHGM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GFGOGBEALGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xC6E0F0", Offset = "0xC6D0F0", VA = "0x180C6E0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x396FE10", Offset = "0x396EE10", VA = "0x18396FE10")]
		public ONKMABHAOKC(ulong GGLJFLNJABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x396FBA0", Offset = "0x396EBA0", VA = "0x18396FBA0")]
		public ONKMABHAOKC PPCBFHPPBHE(ulong GGLJFLNJABJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x396FB50", Offset = "0x396EB50", VA = "0x18396FB50")]
		public ONKMABHAOKC PPCBFHPPBHE(ulong GGLJFLNJABJ, int JNLOLNFALGF, string CAMJJKLMKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x396F920", Offset = "0x396E920", VA = "0x18396F920")]
		public ONKMABHAOKC JJMIBFEBNGO(byte[] BKLFBAMHBAG, ref int KDGOCEAMMLM, ref int OEOCKLPIDLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x396FAD0", Offset = "0x396EAD0", VA = "0x18396FAD0")]
		internal static int NPKCIMOBLNI(ulong[] DNAEDFOPGEJ, int IIHEDPBOLFE, int BPGPLFOLHKN, ulong JNLOLNFALGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x396EB70", Offset = "0x396DB70", VA = "0x18396EB70", Slot = "4")]
		public int CompareTo(ONKMABHAOKC IJDAJAEAAKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x396F8B0", Offset = "0x396E8B0", VA = "0x18396F8B0")]
		[IteratorStateMachine(typeof(MHHFCOFDDNE))]
		public IEnumerable<ONKMABHAOKC> JHKGNLIBNPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x396F780", Offset = "0x396E780", VA = "0x18396F780")]
		public void GJHLEIFJHHB(ILGenerator MFPKEMLEICB, LocalBuilder BKLFBAMHBAG, LocalBuilder OEOCKLPIDLD, LocalBuilder GGLJFLNJABJ, Action<KeyValuePair<string, int>> BPAJOGGAKLG, Action PJHCMPDKBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x396EBA0", Offset = "0x396DBA0", VA = "0x18396EBA0")]
		private static void DADDLIBAFHF(ILGenerator MFPKEMLEICB, LocalBuilder BKLFBAMHBAG, LocalBuilder OEOCKLPIDLD, LocalBuilder GGLJFLNJABJ, Action<KeyValuePair<string, int>> BPAJOGGAKLG, Action PJHCMPDKBEH, ONKMABHAOKC[] MJMIDPNJIOE, int FBKJALIBHGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class BIHKFNIKFMJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<ONKMABHAOKC> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<ONKMABHAOKC> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<ONKMABHAOKC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ONKMABHAOKC <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3963F50", Offset = "0x3962F50", VA = "0x183963F50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7D0", Offset = "0xA0D7D0", VA = "0x180A0E7D0")]
		[DebuggerHidden]
		public BIHKFNIKFMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3963FA0", Offset = "0x3962FA0", VA = "0x183963FA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3963AE0", Offset = "0x3962AE0", VA = "0x183963AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x39640A0", Offset = "0x39630A0", VA = "0x1839640A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x39640F0", Offset = "0x39630F0", VA = "0x1839640F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3963F00", Offset = "0x3962F00", VA = "0x183963F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3963E60", Offset = "0x3962E60", VA = "0x183963E60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3963E60", Offset = "0x3962E60", VA = "0x183963E60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ONKMABHAOKC JJKPMHEEPII;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x395F950", Offset = "0x395E950", VA = "0x18395F950")]
	public AHLMAGAEFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x395F740", Offset = "0x395E740", VA = "0x18395F740")]
	public void PPCBFHPPBHE(byte[] FCLFFFPNPCK, int JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x395F690", Offset = "0x395E690", VA = "0x18395F690")]
	public bool OGGNFDKFLDB(ArraySegment<byte> GGLJFLNJABJ, out int JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x395F860", Offset = "0x395E860", VA = "0x18395F860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x395F410", Offset = "0x395E410", VA = "0x18395F410")]
	private static void JGEADHOIHLA(IEnumerable<ONKMABHAOKC> MJMIDPNJIOE, StringBuilder ILMCDOLEKBC, int OAHGKINJMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x395F2E0", Offset = "0x395E2E0", VA = "0x18395F2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x395F2E0", Offset = "0x395E2E0", VA = "0x18395F2E0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x395F270", Offset = "0x395E270", VA = "0x18395F270")]
	[IteratorStateMachine(typeof(BIHKFNIKFMJ))]
	private static IEnumerable<KeyValuePair<string, int>> FOMGLJIONCH(IEnumerable<ONKMABHAOKC> MJMIDPNJIOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x395F3E0", Offset = "0x395E3E0", VA = "0x18395F3E0")]
	public void HIFBNKGANNF(ILGenerator MFPKEMLEICB, LocalBuilder BKLFBAMHBAG, LocalBuilder OEOCKLPIDLD, LocalBuilder GGLJFLNJABJ, Action<KeyValuePair<string, int>> BPAJOGGAKLG, Action PJHCMPDKBEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class NDOMIOOFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo NOPLJODJMAA;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4F44250", Offset = "0x4F43250", VA = "0x184F44250")]
	public static ulong ABNMOCEACOP(byte[] FCLFFFPNPCK, ref int KDGOCEAMMLM, ref int OEOCKLPIDLD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class GGFPJOEPCDE
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x340D5D0", Offset = "0x340C5D0", VA = "0x18340D5D0")]
	public static void LLEKFFHMMIL(ref byte[] FCLFFFPNPCK, int KDGOCEAMMLM, int ODFOLPGMGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x340D6F0", Offset = "0x340C6F0", VA = "0x18340D6F0")]
	public static void PGNHEJKGHLM(ref byte[] DNAEDFOPGEJ, int GJIKPEJODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x340D4E0", Offset = "0x340C4E0", VA = "0x18340D4E0")]
	public static byte[] LKACGDODEPC(byte[] LCEEDPEAPOI, int GJIKPEJODHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JJBHPDNMPKK
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x34184B0", Offset = "0x34174B0", VA = "0x1834184B0")]
	public static bool MHJPJGBBFJN(byte[] GMNNKPAFGCK, int NGEMJJBJBGN, int PNAIFFNDBME, byte[] BMMFLJNECAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HJNLBDDJJDN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct APLLINODOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] CLPKDAIHDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T GFNFCEIHNLL;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x23A9260", Offset = "0x23A8260", VA = "0x1823A9260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HOMCOLLGCPH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::HJNLBDDJJDN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private APLLINODOOM[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private APLLINODOOM[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1A74060", Offset = "0x1A73060", VA = "0x181A74060", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x23B4250", Offset = "0x23B3250", VA = "0x1823B4250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1CB98B0", Offset = "0x1CB88B0", VA = "0x181CB98B0")]
		[DebuggerHidden]
		public HOMCOLLGCPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x23B3420", Offset = "0x23B2420", VA = "0x1823B3420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x23B3F30", Offset = "0x23B2F30", VA = "0x1823B3F30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly APLLINODOOM[][] FEFIBJKDNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong AEEHKHHOHGL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4348830", Offset = "0x4347830", VA = "0x184348830")]
	public HJNLBDDJJDN(int FANLILHFAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4348860", Offset = "0x4347860", VA = "0x184348860")]
	public HJNLBDDJJDN(int FANLILHFAFO, float NILGNNGCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x43482A0", Offset = "0x43472A0", VA = "0x1843482A0")]
	public void PPCBFHPPBHE(byte[] GGLJFLNJABJ, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4343B90", Offset = "0x4342B90", VA = "0x184343B90")]
	private bool HBBAMMGKCOI(byte[] GGLJFLNJABJ, T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x433EB80", Offset = "0x433DB80", VA = "0x18433EB80")]
	public bool DCDCMBICKAB(ArraySegment<byte> GGLJFLNJABJ, out T JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x433FAA0", Offset = "0x433EAA0", VA = "0x18433FAA0")]
	private static ulong GLJCBFIMFEG(byte[] JIOINDMBNBK, int KDGOCEAMMLM, int FBKJALIBHGM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x30C7D80", Offset = "0x30C6D80", VA = "0x1830C7D80")]
	private static int ACCCEKLKLAG(int CLLBNENDDAI, float NILGNNGCMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x433FB00", Offset = "0x433EB00", VA = "0x18433FB00", Slot = "4")]
	[IteratorStateMachine(typeof(global::HJNLBDDJJDN<>.HOMCOLLGCPH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x25F8AE0", Offset = "0x25F7AE0", VA = "0x1825F8AE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class KGIMMBLNIMP : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] PJHCJAELGEP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] NLPODANJJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int LJHPHEJFPDI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FNJABIMEINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x34197A0", Offset = "0x34187A0", VA = "0x1834197A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3419900", Offset = "0x3418900", VA = "0x183419900")]
	static KGIMMBLNIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3419B50", Offset = "0x3418B50", VA = "0x183419B50")]
	public KGIMMBLNIMP(byte[] KBKLCPBEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x34197F0", Offset = "0x34187F0", VA = "0x1834197F0")]
	public OpCode MFLIBMLBEII()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DBCNNCEGBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid GFNFCEIHNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte FGDNJDIFEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte LGBDFJKBGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte NFOEOFBCOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte OBIHKKMDCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte DCABMPFAKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte FHFAKIAFDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte COPABECLDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte FHGKMDPMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CFLJNGNCFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FPEKCIFHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte OLLMJJDHDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CNCFALAHBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte PBFANIJGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte GEPMJONPBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte HFOCOGFELFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte MDNCGGGBJEN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] PAEIMIFLNCL;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] BKFHBLMMHAD;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3967DD0", Offset = "0x3966DD0", VA = "0x183967DD0")]
	public DBCNNCEGBKB(ref Guid JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3967DE0", Offset = "0x3966DE0", VA = "0x183967DE0")]
	public DBCNNCEGBKB(ref ArraySegment<byte> PPAIOFOKDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3967C60", Offset = "0x3966C60", VA = "0x183967C60")]
	private static byte GOCEPGNGHCC(byte[] FCLFFFPNPCK, int KHNIHFIHNMB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3966810", Offset = "0x3965810", VA = "0x183966810")]
	private static byte BIJILLOGEEF(byte GMPKOOIGMDG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3966920", Offset = "0x3965920", VA = "0x183966920")]
	public void BOFGKMKKGCI(byte[] AIKEPJOBOJF, int KDGOCEAMMLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class ODGCKJLLAAM
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4F49850", Offset = "0x4F48850", VA = "0x184F49850")]
	public static bool OFBEBJGDDFD(byte ADHKGFCOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4F47CA0", Offset = "0x4F46CA0", VA = "0x184F47CA0")]
	public static bool BLKNABNKLKJ(byte ADHKGFCOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4F48EC0", Offset = "0x4F47EC0", VA = "0x184F48EC0")]
	public static sbyte JDCCLDJAAEO(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4F48FA0", Offset = "0x4F47FA0", VA = "0x184F48FA0")]
	public static short LPGBGHHAKGI(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4F48B10", Offset = "0x4F47B10", VA = "0x184F48B10")]
	public static int GJLBLLINLNA(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4F47D10", Offset = "0x4F46D10", VA = "0x184F47D10")]
	public static long DHPFGKFCJMI(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4F48F30", Offset = "0x4F47F30", VA = "0x184F48F30")]
	public static byte KBFFNECEBOK(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4F49010", Offset = "0x4F48010", VA = "0x184F49010")]
	public static ushort OBDDFJKPDKE(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4F47C20", Offset = "0x4F46C20", VA = "0x184F47C20")]
	public static uint ANCDNFPPDHA(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4F47DC0", Offset = "0x4F46DC0", VA = "0x184F47DC0")]
	public static ulong DMAPMKJBFCH(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4F48B80", Offset = "0x4F47B80", VA = "0x184F48B80")]
	public static float HONKCPGCEHB(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4F47B30", Offset = "0x4F46B30", VA = "0x184F47B30")]
	public static double AKELMHGJIOE(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4F49080", Offset = "0x4F48080", VA = "0x184F49080")]
	public static int OEEBPPOJDNL(ref byte[] AIKEPJOBOJF, int KDGOCEAMMLM, ulong JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4F47ED0", Offset = "0x4F46ED0", VA = "0x184F47ED0")]
	public static int GAMFFBNICOP(ref byte[] AIKEPJOBOJF, int KDGOCEAMMLM, long JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4F48C70", Offset = "0x4F47C70", VA = "0x184F48C70")]
	public static bool IANHEMNMPEL(byte[] FCLFFFPNPCK, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class MEKNJMDGLNE
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LEHGCIELHOC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public LEHGCIELHOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FF50", Offset = "0x4F3EF50", VA = "0x184F3FF50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FAF0", Offset = "0x4F3EAF0", VA = "0x184F3FAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4F40070", Offset = "0x4F3F070", VA = "0x184F40070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4F400C0", Offset = "0x4F3F0C0", VA = "0x184F400C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FF00", Offset = "0x4F3EF00", VA = "0x184F3FF00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FE50", Offset = "0x4F3EE50", VA = "0x184F3FE50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FE50", Offset = "0x4F3EE50", VA = "0x184F3FE50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PEFGNJOFNCN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6F63E0", Offset = "0x6F53E0", VA = "0x1806F63E0")]
		[DebuggerHidden]
		public PEFGNJOFNCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C6D0", Offset = "0x4F4B6D0", VA = "0x184F4C6D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C270", Offset = "0x4F4B270", VA = "0x184F4C270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C7F0", Offset = "0x4F4B7F0", VA = "0x184F4C7F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C840", Offset = "0x4F4B840", VA = "0x184F4C840")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C680", Offset = "0x4F4B680", VA = "0x184F4C680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C5D0", Offset = "0x4F4B5D0", VA = "0x184F4C5D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C5D0", Offset = "0x4F4B5D0", VA = "0x184F4C5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4F40E80", Offset = "0x4F3FE80", VA = "0x184F40E80")]
	public static bool MBOILECCPAO(this TypeInfo GLKKDGLKBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4F40C00", Offset = "0x4F3FC00", VA = "0x184F40C00")]
	public static bool BACLNJOJFKA(this TypeInfo GLKKDGLKBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4F40E20", Offset = "0x4F3FE20", VA = "0x184F40E20")]
	public static IEnumerable<PropertyInfo> HMJINGNKOMH(this Type GLKKDGLKBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4F40D90", Offset = "0x4F3FD90", VA = "0x184F40D90")]
	[IteratorStateMachine(typeof(LEHGCIELHOC))]
	private static IEnumerable<PropertyInfo> EEOBGKAFPDO(Type GLKKDGLKBMK, HashSet<string> AINOBDHAJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4F40F30", Offset = "0x4F3FF30", VA = "0x184F40F30")]
	public static IEnumerable<FieldInfo> OKCBBAMBEBC(this Type GLKKDGLKBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4F40D00", Offset = "0x4F3FD00", VA = "0x184F40D00")]
	[IteratorStateMachine(typeof(PEFGNJOFNCN))]
	private static IEnumerable<FieldInfo> DACLODFJCGM(Type GLKKDGLKBMK, HashSet<string> AINOBDHAJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class FGHLPOAEGAA
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding NAHPBDKHNKG;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class BEJOIODHFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x69AF60", Offset = "0x699F60", VA = "0x18069AF60")]
	public static string BKPMFNMNJBB(string MHLMNJMBPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3961FF0", Offset = "0x3960FF0", VA = "0x183961FF0")]
	public static string EBFCFFLEFEA(string MHLMNJMBPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3961E20", Offset = "0x3960E20", VA = "0x183961E20")]
	public static string AHKLJAKAMAM(string MHLMNJMBPPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PLFGLOIOOAG<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class KJLLDEEIJCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type CLPKDAIHDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue GFNFCEIHNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int CMNJOFOIAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public KJLLDEEIJCJ LNJGJEHKCIC;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x30C0010", Offset = "0x30BF010", VA = "0x1830C0010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x30BFF90", Offset = "0x30BEF90", VA = "0x1830BFF90")]
		private int HJCHDLKJEJK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public KJLLDEEIJCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class DANDHGEBDGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public DANDHGEBDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private KJLLDEEIJCJ[] FEFIBJKDNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int CCDDIFMMPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object MFLCCPNBAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float NILGNNGCMEO;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x30C91D0", Offset = "0x30C81D0", VA = "0x1830C91D0")]
	public PLFGLOIOOAG(int FANLILHFAFO = 4, float NILGNNGCMEO = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x30C8E60", Offset = "0x30C7E60", VA = "0x1830C8E60")]
	public bool IOLPAJPCMFB(Type GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x30C8E20", Offset = "0x30C7E20", VA = "0x1830C8E20")]
	public bool IOLPAJPCMFB(Type GGLJFLNJABJ, Func<Type, TValue> AGHHMABOLEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x30C8AB0", Offset = "0x30C7AB0", VA = "0x1830C8AB0")]
	private bool HBBAMMGKCOI(Type GGLJFLNJABJ, Func<Type, TValue> AGHHMABOLEG, out TValue EANFFBNNPEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x30C83F0", Offset = "0x30C73F0", VA = "0x1830C83F0")]
	private bool DPNFEJBOFGM(KJLLDEEIJCJ[] FEFIBJKDNAM, Type DJOMMODINHA, KJLLDEEIJCJ IDBCHBENGPF, Func<Type, TValue> AGHHMABOLEG, out TValue EANFFBNNPEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x30C7DB0", Offset = "0x30C6DB0", VA = "0x1830C7DB0")]
	public bool DCDCMBICKAB(Type GGLJFLNJABJ, out TValue JNLOLNFALGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x30C9130", Offset = "0x30C8130", VA = "0x1830C9130")]
	public TValue LKIJIOFJOLK(Type GGLJFLNJABJ, Func<Type, TValue> AGHHMABOLEG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x30C7D80", Offset = "0x30C6D80", VA = "0x1830C7D80")]
	private static int ACCCEKLKLAG(int CLLBNENDDAI, float NILGNNGCMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x30C8DB0", Offset = "0x30C7DB0", VA = "0x1830C8DB0")]
	private static void ILMPKCOFHGF(ref KJLLDEEIJCJ CNIFFDPABKP, KJLLDEEIJCJ JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x30C8DB0", Offset = "0x30C7DB0", VA = "0x1830C8DB0")]
	private static void ILMPKCOFHGF(ref KJLLDEEIJCJ[] CNIFFDPABKP, KJLLDEEIJCJ[] JNLOLNFALGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HHMBJMBCPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder NGPMGDCNIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder EEDNOOKJNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object BAANHGHNLCJ;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3411540", Offset = "0x3410540", VA = "0x183411540")]
	public TypeBuilder LFFCAFEEIMO(string MBHNCPMPIFB, TypeAttributes IGCDMGMNALC, Type ACNNFDIAAFM, Type[] HNKAABIGIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3411630", Offset = "0x3410630", VA = "0x183411630")]
	public HHMBJMBCPGD(string PBKEIPMDJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class LNGFLIEMNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4F40740", Offset = "0x4F3F740", VA = "0x184F40740")]
	private static MethodInfo KJPHENFMCDE(LambdaExpression NCELONEAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x21677A0", Offset = "0x21667A0", VA = "0x1821677A0")]
	public static MethodInfo KIOPIAECJJE<T>(Expression<Func<T>> NCELONEAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x21677A0", Offset = "0x21667A0", VA = "0x1821677A0")]
	public static MethodInfo KIOPIAECJJE<T, TR>(Expression<Func<T, TR>> NCELONEAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x21677A0", Offset = "0x21667A0", VA = "0x1821677A0")]
	public static MethodInfo KIOPIAECJJE<T>(Expression<Action<T>> NCELONEAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x21677A0", Offset = "0x21667A0", VA = "0x1821677A0")]
	public static MethodInfo KIOPIAECJJE<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> NCELONEAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2167700", Offset = "0x2166700", VA = "0x182167700")]
	private static MemberInfo JODOIELPOOJ<T>(Expression<T> LAAFNHPNJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x21677B0", Offset = "0x21667B0", VA = "0x1821677B0")]
	public static PropertyInfo PPOMAINAMAF<T, TR>(Expression<Func<T, TR>> NCELONEAGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct IOKEJFMHLBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int BJNKEHJJEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool JDDCFIDHDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator MFPKEMLEICB;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3415620", Offset = "0x3414620", VA = "0x183415620")]
	public IOKEJFMHLBO(ILGenerator MFPKEMLEICB, int BJNKEHJJEBP, bool JDDCFIDHDAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3415590", Offset = "0x3414590", VA = "0x183415590")]
	public IOKEJFMHLBO(ILGenerator MFPKEMLEICB, int BJNKEHJJEBP, Type GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3415480", Offset = "0x3414480", VA = "0x183415480")]
	public void JHKICLKJDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class JGBNAACFBOL
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3417E50", Offset = "0x3416E50", VA = "0x183417E50")]
	public static void KOPAENIEJEE(this ILGenerator MFPKEMLEICB, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3418080", Offset = "0x3417080", VA = "0x183418080")]
	public static void KOPAENIEJEE(this ILGenerator MFPKEMLEICB, LocalBuilder JOJIFCPCGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x34172D0", Offset = "0x34162D0", VA = "0x1834172D0")]
	public static void CBJPCALNIPD(this ILGenerator MFPKEMLEICB, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3417290", Offset = "0x3416290", VA = "0x183417290")]
	public static void CBJPCALNIPD(this ILGenerator MFPKEMLEICB, LocalBuilder JOJIFCPCGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x34181D0", Offset = "0x34171D0", VA = "0x1834181D0")]
	public static void MNMBBODAOGN(this ILGenerator MFPKEMLEICB, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x34180C0", Offset = "0x34170C0", VA = "0x1834180C0")]
	public static void MNMBBODAOGN(this ILGenerator MFPKEMLEICB, LocalBuilder JOJIFCPCGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x34182C0", Offset = "0x34172C0", VA = "0x1834182C0")]
	public static void PBIFABBLHHE(this ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3417D40", Offset = "0x3416D40", VA = "0x183417D40")]
	public static void KJLBFHGADFD(this ILGenerator MFPKEMLEICB, bool JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3417730", Offset = "0x3416730", VA = "0x183417730")]
	public static void DBMNDJJMPHG(this ILGenerator MFPKEMLEICB, int JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x34183C0", Offset = "0x34173C0", VA = "0x1834183C0")]
	public static void PLMNOGEGINJ(this ILGenerator MFPKEMLEICB, Type GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3417CA0", Offset = "0x3416CA0", VA = "0x183417CA0")]
	public static void KDHFPEFIIDA(this ILGenerator MFPKEMLEICB, Type GLKKDGLKBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3417500", Offset = "0x3416500", VA = "0x183417500")]
	public static void CELBECEOOJM(this ILGenerator MFPKEMLEICB, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3417210", Offset = "0x3416210", VA = "0x183417210")]
	public static void BDPEOBIJFPE(this ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x34182D0", Offset = "0x34172D0", VA = "0x1834182D0")]
	public static void PKDDFGGLHDB(this ILGenerator MFPKEMLEICB, int IIHEDPBOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3417D50", Offset = "0x3416D50", VA = "0x183417D50")]
	public static void KNOOMOCCAKH(this ILGenerator MFPKEMLEICB, MethodInfo AMIHGNOLLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3417C10", Offset = "0x3416C10", VA = "0x183417C10")]
	public static void JMFFINJJLOK(this ILGenerator MFPKEMLEICB, FieldInfo MNKDMCHMGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3417B80", Offset = "0x3416B80", VA = "0x183417B80")]
	public static void DMKFOAMJKFL(this ILGenerator MFPKEMLEICB, ulong JNLOLNFALGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class PCJMKFENHGO
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MJFLAFBBOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
		public MJFLAFBBOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x4F42FC0", Offset = "0x4F41FC0", VA = "0x184F42FC0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo JJCBLOLKDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo NMMEGAENAKE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string CNNFDLMHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string OMCGADGECEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5E54A0", Offset = "0x5E44A0", VA = "0x1805E54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NKGNIMADPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4F4BE60", Offset = "0x4F4AE60", VA = "0x184F4BE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JNNEBNMBPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5E5190", Offset = "0x5E4190", VA = "0x1805E5190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x740180", Offset = "0x73F180", VA = "0x180740180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IEAKHGFFNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5E51A0", Offset = "0x5E41A0", VA = "0x1805E51A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x804500", Offset = "0x803500", VA = "0x180804500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type NLKEOENNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo CPHODOJKDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo GFAMICLMIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5E6010", Offset = "0x5E5010", VA = "0x1805E6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5E6020", Offset = "0x5E5020", VA = "0x1805E6020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo KLAMPGMMPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5F8D70", Offset = "0x5F7D70", VA = "0x1805F8D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x67FFC0", Offset = "0x67EFC0", VA = "0x18067FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C0E0", Offset = "0x4F4B0E0", VA = "0x184F4C0E0")]
	protected PCJMKFENHGO(Type GLKKDGLKBMK, string MBHNCPMPIFB, string ODKANHNKPIL, bool JOEFELOEPAI, bool HPOCAHENBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C160", Offset = "0x4F4B160", VA = "0x184F4C160")]
	public PCJMKFENHGO(FieldInfo APJDICMKPPA, string MBHNCPMPIFB, bool PLFFEEJJANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4F4BF30", Offset = "0x4F4AF30", VA = "0x184F4BF30")]
	public PCJMKFENHGO(PropertyInfo APJDICMKPPA, string MBHNCPMPIFB, bool PLFFEEJJANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4F4BD40", Offset = "0x4F4AD40", VA = "0x184F4BD40")]
	private static MethodInfo DPLBALOBMBG(MemberInfo APJDICMKPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x20C4F90", Offset = "0x20C3F90", VA = "0x1820C4F90")]
	public T FKKCBCHJLDL<T>(bool EOPFCDLLLMF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4F4BE70", Offset = "0x4F4AE70", VA = "0x184F4BE70", Slot = "4")]
	public virtual void LCAKPLHCKII(ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4F4BC80", Offset = "0x4F4AC80", VA = "0x184F4BC80", Slot = "5")]
	public virtual void AIFCFGKLEID(ILGenerator MFPKEMLEICB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class ANIHOCIAOAO : PCJMKFENHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string LGAGCOHDAPC;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x3960A70", Offset = "0x395FA70", VA = "0x183960A70")]
	public ANIHOCIAOAO(string MBHNCPMPIFB, string LGAGCOHDAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x39609B0", Offset = "0x395F9B0", VA = "0x1839609B0", Slot = "4")]
	public override void LCAKPLHCKII(ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3960960", Offset = "0x395F960", VA = "0x183960960", Slot = "5")]
	public override void AIFCFGKLEID(ILGenerator MFPKEMLEICB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class HNPCENDGCEC : PCJMKFENHGO
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo HKGJCIBONAL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo KIJKNMLDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal IOKEJFMHLBO NNGAILDLMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal IOKEJFMHLBO NHFDFEPHEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal IOKEJFMHLBO DNMNHFOCFLI;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3412370", Offset = "0x3411370", VA = "0x183412370")]
	public HNPCENDGCEC(string MBHNCPMPIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3411E10", Offset = "0x3410E10", VA = "0x183411E10", Slot = "4")]
	public override void LCAKPLHCKII(ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3411CB0", Offset = "0x3410CB0", VA = "0x183411CB0", Slot = "5")]
	public override void AIFCFGKLEID(ILGenerator MFPKEMLEICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3411D00", Offset = "0x3410D00", VA = "0x183411D00")]
	public void FOGGHHBNGBM(ILGenerator MFPKEMLEICB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class CMJJINEBEBP
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type NLKEOENNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GEKPKFJFFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x713FE0", Offset = "0x712FE0", VA = "0x180713FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CD0", Offset = "0x7B8CD0", VA = "0x1807B9CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HNLPGPOMNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8F10", Offset = "0x7A7F10", VA = "0x1807A8F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE49F00", Offset = "0xE48F00", VA = "0x180E49F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo BIMNBHNBPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PCJMKFENHGO[] EIBIMGDBOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x60E0C0", Offset = "0x60D0C0", VA = "0x18060E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x709440", Offset = "0x708440", VA = "0x180709440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public PCJMKFENHGO[] EAGICHHJJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x60DA30", Offset = "0x60CA30", VA = "0x18060DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x71D880", Offset = "0x71C880", VA = "0x18071D880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x3965590", Offset = "0x3964590", VA = "0x183965590")]
	public CMJJINEBEBP(Type GLKKDGLKBMK, Func<string, string> JLNOBIMFEPG, bool PLFFEEJJANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x39654C0", Offset = "0x39644C0", VA = "0x1839654C0")]
	private static bool FKLGEANOOMO(IEnumerator<ConstructorInfo> AMFFBPJDBKC, ref ConstructorInfo HOGLDAHPMPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct OIOGHANEKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong FHGEGKGNIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int MKAEFGDNMHM;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2739910", Offset = "0x2738910", VA = "0x182739910")]
	public OIOGHANEKII(ulong KJBGEJIGGDO, int LKPNJIEGFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4F498F0", Offset = "0x4F488F0", VA = "0x184F498F0")]
	public void DIIAEMDGCCB(ref OIOGHANEKII IJDAJAEAAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4F49A50", Offset = "0x4F48A50", VA = "0x184F49A50")]
	public static OIOGHANEKII JGNGBDAKCIJ(ref OIOGHANEKII KKHMNCLOHHK, ref OIOGHANEKII GMPKOOIGMDG)
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4F49860", Offset = "0x4F48860", VA = "0x184F49860")]
	public void DGOMCAAILBM(ref OIOGHANEKII IJDAJAEAAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F49900", Offset = "0x4F48900", VA = "0x184F49900")]
	public static OIOGHANEKII EAJNFBPMIHF(ref OIOGHANEKII KKHMNCLOHHK, ref OIOGHANEKII GMPKOOIGMDG)
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F49A10", Offset = "0x4F48A10", VA = "0x184F49A10")]
	public void HMLOJNIFLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F499B0", Offset = "0x4F489B0", VA = "0x184F499B0")]
	public static OIOGHANEKII HMLOJNIFLKP(ref OIOGHANEKII KKHMNCLOHHK)
	{
		return default(OIOGHANEKII);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MLOAHAGIOPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] AIKEPJOBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int KDGOCEAMMLM;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA26A90", Offset = "0xA25A90", VA = "0x180A26A90")]
	public MLOAHAGIOPH(byte[] AIKEPJOBOJF, int IPACGOANALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4F43140", Offset = "0x4F42140", VA = "0x184F43140")]
	public void CNPAGLFNIDH(byte KHODCOPPDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F432F0", Offset = "0x4F422F0", VA = "0x184F432F0")]
	public void IIJDCCGKAKF(byte[] KHODCOPPDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F43250", Offset = "0x4F42250", VA = "0x184F43250")]
	public void GDJFPOLJLDK(byte[] KHODCOPPDOK, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F431A0", Offset = "0x4F421A0", VA = "0x184F431A0")]
	public void GDJFPOLJLDK(byte[] KHODCOPPDOK, int HNIIDPMJKFI, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F430C0", Offset = "0x4F420C0", VA = "0x184F430C0")]
	public void AGOMBFJFCHI(byte ADHKGFCOILB, int FBKJALIBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F43390", Offset = "0x4F42390", VA = "0x184F43390")]
	public void LKIBIDDKMCJ(string KHODCOPPDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class FOKPPMMPKLC
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum IPMJMLONGHE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum CLNNIEDKGNE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum PKEPMLIINBD
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
	private static byte[] MBDMCFICAMG;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] OCPANIJEBDC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] LHICAPPJEEL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] NAOGNEMEHHD;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly PKEPMLIINBD ODNHIOAOGBI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char NAKBPDEIEFH;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int HECJBHFPAFD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int MIBGOKANBCB;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] LOAOKANLFGB;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x396C7D0", Offset = "0x396B7D0", VA = "0x18396C7D0")]
	private static byte[] KPDFIJCMJLG(int CCDDIFMMPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x396BAC0", Offset = "0x396AAC0", VA = "0x18396BAC0")]
	private static byte[] DFKFPHHDHKP(int CCDDIFMMPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x396BC90", Offset = "0x396AC90", VA = "0x18396BC90")]
	public static int DNEJPJOOJDP(ref byte[] AIKEPJOBOJF, int KDGOCEAMMLM, float JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x396BDA0", Offset = "0x396ADA0", VA = "0x18396BDA0")]
	public static int DNEJPJOOJDP(ref byte[] AIKEPJOBOJF, int KDGOCEAMMLM, double JNLOLNFALGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x396CF80", Offset = "0x396BF80", VA = "0x18396CF80")]
	private static bool ONIBBGMHEGJ(byte[] AIKEPJOBOJF, int BPGPLFOLHKN, ulong GJNEBHEBICF, ulong OABANCENOOB, ulong OEOCKLPIDLD, ulong NFNFLLHNBMP, ulong DICNLHCDPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x396CE60", Offset = "0x396BE60", VA = "0x18396CE60")]
	private static void NPIHEKNKILD(uint GMEHEHNEEIN, int DHDIPFEPOOF, out uint ELMELEPOIAP, out int FAFFPEPJKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x396D080", Offset = "0x396C080", VA = "0x18396D080")]
	private static bool PAJOBECCKOL(OIOGHANEKII CDOFMDOEMOI, OIOGHANEKII AMGKGKNGBFO, OIOGHANEKII EEDLAFFCBOF, byte[] AIKEPJOBOJF, out int BPGPLFOLHKN, out int EKCPHNHNNFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x396C8A0", Offset = "0x396B8A0", VA = "0x18396C8A0")]
	private static bool LAAIKCMENAL(double PHCLDIDKELI, IPMJMLONGHE DJPEOPIHMGD, byte[] AIKEPJOBOJF, out int BPGPLFOLHKN, out int GKAGFLFGEND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x396BBA0", Offset = "0x396ABA0", VA = "0x18396BBA0")]
	private static bool DJMBNNMOIBE(double PHCLDIDKELI, IPMJMLONGHE DJPEOPIHMGD, byte[] AIKEPJOBOJF, out int BPGPLFOLHKN, out int DAKAMMOAHCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x396CB10", Offset = "0x396BB10", VA = "0x18396CB10")]
	private static bool LEFBMKNGLMB(double JNLOLNFALGF, ref MLOAHAGIOPH HBHAMKIMFLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x396BEB0", Offset = "0x396AEB0", VA = "0x18396BEB0")]
	private static bool IHOACNGFLKA(double JNLOLNFALGF, ref MLOAHAGIOPH HBHAMKIMFLB, CLNNIEDKGNE DJPEOPIHMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x396CCA0", Offset = "0x396BCA0", VA = "0x18396CCA0")]
	private static void LHPNLNOBEMB(byte[] GDDOHCKIDCO, int BPGPLFOLHKN, int DAKAMMOAHCN, int PBEGGAECLDP, ref MLOAHAGIOPH HBHAMKIMFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x396C4E0", Offset = "0x396B4E0", VA = "0x18396C4E0")]
	private static void KFANGCEKEHI(byte[] GDDOHCKIDCO, int BPGPLFOLHKN, int LKPNJIEGFEH, ref MLOAHAGIOPH HBHAMKIMFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x396D4D0", Offset = "0x396C4D0", VA = "0x18396D4D0")]
	private static bool POOGJKICMLN(double PHCLDIDKELI, CLNNIEDKGNE DJPEOPIHMGD, int ILEMKNAJEKE, byte[] CMAIBHGDDNB, out bool PKGOCCPAJFF, out int BPGPLFOLHKN, out int EAKNLHDPPEJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct LOBOHFPCMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double COCNKFFEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong EJDMIBAECII;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct BBDJCPEDBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float FHGEGKGNIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint EJFEHOJAPGN;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct JBEKFCINGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong KBJNIJCBPFB;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x34160D0", Offset = "0x34150D0", VA = "0x1834160D0")]
	public JBEKFCINGIJ(double COCNKFFEBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3416030", Offset = "0x3415030", VA = "0x183416030")]
	public JBEKFCINGIJ(OIOGHANEKII COCNKFFEBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3415FA0", Offset = "0x3414FA0", VA = "0x183415FA0")]
	public OIOGHANEKII NFOOEEJFMAF()
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3415E00", Offset = "0x3414E00", VA = "0x183415E00")]
	public OIOGHANEKII IPFKDNFBNLM()
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3E0", Offset = "0x7BA3E0", VA = "0x1807BB3E0")]
	public ulong EKEDKNGMJCC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3415EB0", Offset = "0x3414EB0", VA = "0x183415EB0")]
	public double LHAFEDKFGJK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3415D50", Offset = "0x3414D50", VA = "0x183415D50")]
	public double FJEOEOIKIKD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3415DD0", Offset = "0x3414DD0", VA = "0x183415DD0")]
	public int FJKJKAOGIFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3415F50", Offset = "0x3414F50", VA = "0x183415F50")]
	public ulong LLNMGPPBGEF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3415C70", Offset = "0x3414C70", VA = "0x183415C70")]
	public bool DEKICMCNJHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3415F80", Offset = "0x3414F80", VA = "0x183415F80")]
	public bool MGJOEGHLKPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3415AB0", Offset = "0x3414AB0", VA = "0x183415AB0")]
	public bool BPLEEAPEPNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3415F20", Offset = "0x3414F20", VA = "0x183415F20")]
	public bool LHKCGKIHMGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3415D30", Offset = "0x3414D30", VA = "0x183415D30")]
	public int EAOOFHENPMH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x3415AE0", Offset = "0x3414AE0", VA = "0x183415AE0")]
	public void COOEINEFFAO(out OIOGHANEKII IAHGPAGALKN, out OIOGHANEKII FFJAMPOEHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3415A40", Offset = "0x3414A40", VA = "0x183415A40")]
	public bool AIJMKPODAPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3415EA0", Offset = "0x3414EA0", VA = "0x183415EA0")]
	public double JNLOLNFALGF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3415A90", Offset = "0x3414A90", VA = "0x183415A90")]
	public static int BAELEGCLFHE(int POBHFHHHMPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x3416020", Offset = "0x3415020", VA = "0x183416020")]
	public static double POHHBMJONCJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3415C90", Offset = "0x3414C90", VA = "0x183415C90")]
	public static ulong EAOIDNAMJCM(OIOGHANEKII PIBKGAFLKBP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct CILIJMKMMAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint JEBOLCDPOEI;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2089FF0", Offset = "0x2088FF0", VA = "0x182089FF0")]
	public CILIJMKMMAH(float FHGEGKGNIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3965310", Offset = "0x3964310", VA = "0x183965310")]
	public OIOGHANEKII NFOOEEJFMAF()
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A4500", Offset = "0x8A3500", VA = "0x1808A4500")]
	public uint DJFAIEEEALC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x39652D0", Offset = "0x39642D0", VA = "0x1839652D0")]
	public int FJKJKAOGIFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x39652F0", Offset = "0x39642F0", VA = "0x1839652F0")]
	public uint LLNMGPPBGEF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x39652C0", Offset = "0x39642C0", VA = "0x1839652C0")]
	public bool DEKICMCNJHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3965150", Offset = "0x3964150", VA = "0x183965150")]
	public void COOEINEFFAO(out OIOGHANEKII IAHGPAGALKN, out OIOGHANEKII FFJAMPOEHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3965110", Offset = "0x3964110", VA = "0x183965110")]
	public bool AIJMKPODAPP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct GOAKDHJBDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong KJBGEJIGGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short FLBMEKNOINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short GKAGFLFGEND;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x340F0A0", Offset = "0x340E0A0", VA = "0x18340F0A0")]
	public GOAKDHJBDCD(ulong KJBGEJIGGDO, short FLBMEKNOINF, short GKAGFLFGEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class IMPGNLNMJNE
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly GOAKDHJBDCD[] PNBKMLOGOAD;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3413B30", Offset = "0x3412B30", VA = "0x183413B30")]
	public static void DAPCOPNDHIK(int NFABNHKMHML, int GJLNBEJKELD, out OIOGHANEKII ELMELEPOIAP, out int GKAGFLFGEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3413C60", Offset = "0x3412C60", VA = "0x183413C60")]
	public static void EDHMLBOAJDE(int AFEAJGEPBBO, out OIOGHANEKII ELMELEPOIAP, out int NFPBOGPLNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct BOCGCFAMIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] FCLFFFPNPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int HNIIDPMJKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int JFPOCJGGLNH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte AGGGNHPHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3964140", Offset = "0x3963140", VA = "0x183964140")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F29E0", Offset = "0x9F19E0", VA = "0x1809F29E0")]
	public BOCGCFAMIPJ(byte[] FCLFFFPNPCK, int HNIIDPMJKFI, int BPGPLFOLHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8A44C0", Offset = "0x8A34C0", VA = "0x1808A44C0")]
	public int BPGPLFOLHKN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3964180", Offset = "0x3963180", VA = "0x183964180")]
	public BOCGCFAMIPJ PJMMFDDJPBE(int AEOBOJAAIBB, int FFCIKCOFOFK)
	{
		return default(BOCGCFAMIPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class MJDBGBOOPIJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] ODEAKMDEBDF;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] DKMPODMMJFF;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int LBDKNPHAEID;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F42850", Offset = "0x4F41850", VA = "0x184F42850")]
	private static byte[] JCCPFCJLNDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F42B20", Offset = "0x4F41B20", VA = "0x184F42B20")]
	private static BOCGCFAMIPJ MHBANDAMDKF(BOCGCFAMIPJ AIKEPJOBOJF)
	{
		return default(BOCGCFAMIPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F41A30", Offset = "0x4F40A30", VA = "0x184F41A30")]
	private static BOCGCFAMIPJ DHJDKEHGMIL(BOCGCFAMIPJ AIKEPJOBOJF)
	{
		return default(BOCGCFAMIPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F42930", Offset = "0x4F41930", VA = "0x184F42930")]
	private static void JGKFDJNOENK(BOCGCFAMIPJ AIKEPJOBOJF, int LKPNJIEGFEH, byte[] OCBEJMJNJIB, out int AJDOKEKEBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F423C0", Offset = "0x4F413C0", VA = "0x184F423C0")]
	private static void EPHEHMHBJIK(BOCGCFAMIPJ AIKEPJOBOJF, int LKPNJIEGFEH, byte[] MCBMDLNCNOC, int EODDEDADEMN, out BOCGCFAMIPJ MPPFIOJKNGH, out int NEMICKBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F42EA0", Offset = "0x4F41EA0", VA = "0x184F42EA0")]
	private static ulong OOHJPCLCDPC(BOCGCFAMIPJ AIKEPJOBOJF, out int CGHFLAAGPLG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F429F0", Offset = "0x4F419F0", VA = "0x184F429F0")]
	private static void MGCKGBIKLPN(BOCGCFAMIPJ AIKEPJOBOJF, out OIOGHANEKII HCBFPGACPND, out int EFHNAKIIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F42010", Offset = "0x4F41010", VA = "0x184F42010")]
	private static bool ENJAGILJPIK(BOCGCFAMIPJ MPPFIOJKNGH, int LKPNJIEGFEH, out double HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F42BD0", Offset = "0x4F41BD0", VA = "0x184F42BD0")]
	private static OIOGHANEKII NGAKDONNPPG(int LKPNJIEGFEH)
	{
		return default(OIOGHANEKII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F41AE0", Offset = "0x4F40AE0", VA = "0x184F41AE0")]
	private static bool EKFPCKDONFG(BOCGCFAMIPJ AIKEPJOBOJF, int LKPNJIEGFEH, out double HCBFPGACPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4F418F0", Offset = "0x4F408F0", VA = "0x184F418F0")]
	private static bool AMPBEFLHECB(BOCGCFAMIPJ MPPFIOJKNGH, int LKPNJIEGFEH, out double EEBGGKGNDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4F42D70", Offset = "0x4F41D70", VA = "0x184F42D70")]
	public static double? OGEBNFAKJCL(BOCGCFAMIPJ AIKEPJOBOJF, int LKPNJIEGFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4F42670", Offset = "0x4F41670", VA = "0x184F42670")]
	public static float? FHKOHFHPDDN(BOCGCFAMIPJ AIKEPJOBOJF, int LKPNJIEGFEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct NBPLOKFECJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] AIKEPJOBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int KDGOCEAMMLM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte GFNFCEIHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F44030", Offset = "0x4F43030", VA = "0x184F44030")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA26A90", Offset = "0xA25A90", VA = "0x180A26A90")]
	public NBPLOKFECJA(byte[] AIKEPJOBOJF, int KDGOCEAMMLM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F44070", Offset = "0x4F43070", VA = "0x184F44070")]
	public static NBPLOKFECJA HBOKFHLFEPJ(NBPLOKFECJA AMPFEINIDNM)
	{
		return default(NBPLOKFECJA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4F440E0", Offset = "0x4F430E0", VA = "0x184F440E0")]
	public static NBPLOKFECJA JCNGAANMENI(NBPLOKFECJA AMPFEINIDNM, int BPGPLFOLHKN)
	{
		return default(NBPLOKFECJA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F44080", Offset = "0x4F43080", VA = "0x184F44080")]
	public static int HIHEDOPKOFD(NBPLOKFECJA EPLBIHGPPPN, NBPLOKFECJA PLMIDHOPDAL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4F43EF0", Offset = "0x4F42EF0", VA = "0x184F43EF0")]
	public static bool ABFAIBNGIFN(NBPLOKFECJA EPLBIHGPPPN, NBPLOKFECJA PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4F43FD0", Offset = "0x4F42FD0", VA = "0x184F43FD0")]
	public static bool BHAIMGMLJDO(NBPLOKFECJA EPLBIHGPPPN, NBPLOKFECJA PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4F43F10", Offset = "0x4F42F10", VA = "0x184F43F10")]
	public static bool ABFAIBNGIFN(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F43F90", Offset = "0x4F42F90", VA = "0x184F43F90")]
	public static bool BHAIMGMLJDO(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F43F90", Offset = "0x4F42F90", VA = "0x184F43F90")]
	public static bool BHAIMGMLJDO(NBPLOKFECJA EPLBIHGPPPN, byte PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F43FF0", Offset = "0x4F42FF0", VA = "0x184F43FF0")]
	public static bool DHOCABLIFLB(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F44140", Offset = "0x4F43140", VA = "0x184F44140")]
	public static bool PFHLCCEJDNO(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F43F50", Offset = "0x4F42F50", VA = "0x184F43F50")]
	public static bool AGEDPHEBKHL(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F440A0", Offset = "0x4F430A0", VA = "0x184F440A0")]
	public static bool INPOFLOKLDE(NBPLOKFECJA EPLBIHGPPPN, char PLMIDHOPDAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class NOPOOBFNLBF
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CKNFNKNEBIO;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] KPOJEEBLIJH;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] LHICAPPJEEL;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] NAOGNEMEHHD;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] DGECKOEEAOD;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int IIGAMNPHEGF;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] FGNDHLHHKNN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int JKMIIAFDIKI;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F47230", Offset = "0x4F46230", VA = "0x184F47230")]
	private static byte[] PFFOBMHLDIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F45C40", Offset = "0x4F44C40", VA = "0x184F45C40")]
	private static byte[] DJAGAAICDIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F47170", Offset = "0x4F46170", VA = "0x184F47170")]
	public static double NAIMMPOAIAH(byte[] AIKEPJOBOJF, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F45D20", Offset = "0x4F44D20", VA = "0x184F45D20")]
	public static float GKINGNNILLD(byte[] AIKEPJOBOJF, int KDGOCEAMMLM, out int LFOGPLPOHCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F47310", Offset = "0x4F46310", VA = "0x184F47310")]
	private static bool PHPKJDDEHOK(int JIOINDMBNBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F45DE0", Offset = "0x4F44DE0", VA = "0x184F45DE0")]
	private static bool HEBLFCKJFPC(ref NBPLOKFECJA KFPPFLMHIFD, NBPLOKFECJA MOCOMOOJDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F47050", Offset = "0x4F46050", VA = "0x184F47050")]
	private static bool LEEFHNEFFPG(ref NBPLOKFECJA KFPPFLMHIFD, NBPLOKFECJA MOCOMOOJDJI, byte[] EIBFPCADFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4F45BE0", Offset = "0x4F44BE0", VA = "0x184F45BE0")]
	private static bool CIBFDDOGNKD(ref NBPLOKFECJA BKELFNDFIMP, byte[] KHODCOPPDOK, int KDGOCEAMMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xF7CB40", Offset = "0xF7BB40", VA = "0x180F7CB40")]
	private static double OIHGNHCMNHM(bool PKGOCCPAJFF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4F45F10", Offset = "0x4F44F10", VA = "0x184F45F10")]
	private static double IIPFAAMDFJP(NBPLOKFECJA LDNCLHBDEMA, int BPGPLFOLHKN, bool KLJOOBLPHDC, out int JGFKAEFONJP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class GGPLLDBCDOI<T> : global::NPNEMBPIJOL<T[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::CEKFDKLOEBB<T> CBNICBNABKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly CLNKJBBLIJM FLDMNBJPAEB;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x210E040", Offset = "0x210D040", VA = "0x18210E040")]
	public GGPLLDBCDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1CB98B0", Offset = "0x1CB88B0", VA = "0x181CB98B0")]
	public GGPLLDBCDOI(CLNKJBBLIJM FLDMNBJPAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x40444A0", Offset = "0x40434A0", VA = "0x1840444A0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, T[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x40420A0", Offset = "0x40410A0", VA = "0x1840420A0", Slot = "5")]
	public T[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class BLCMENGGBAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::CEKFDKLOEBB<T> CBNICBNABKO;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class AKLBPNPBLKB<T> : global::NPNEMBPIJOL<List<T>>, OONIALJDMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly CLNKJBBLIJM FLDMNBJPAEB;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x210E040", Offset = "0x210D040", VA = "0x18210E040")]
	public AKLBPNPBLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB98B0", Offset = "0x1CB88B0", VA = "0x181CB98B0")]
	public AKLBPNPBLKB(CLNKJBBLIJM FLDMNBJPAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x210D380", Offset = "0x210C380", VA = "0x18210D380", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, List<T> JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x210CA70", Offset = "0x210BA70", VA = "0x18210CA70", Slot = "5")]
	public List<T> HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class MPLDJDACGLE<TElement, TIntermediate, TEnumerator, TCollection> : global::NPNEMBPIJOL<TCollection>, OONIALJDMLO where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7ED30", Offset = "0x3A7DD30", VA = "0x183A7ED30", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, TCollection JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D430", Offset = "0x3A7C430", VA = "0x183A7D430", Slot = "5")]
	public TCollection HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OECBHAPKPDL(TCollection LAAFNHPNJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBMLCAAKPML();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void PPCBFHPPBHE(ref TIntermediate HOJBOBADEDG, int IIHEDPBOLFE, TElement JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection BNBCPKDPKEK(ref TIntermediate JPDGJJGBBHD);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected MPLDJDACGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class DLBPLFMKKGG<TElement, TIntermediate, TCollection> : global::MPLDJDACGLE<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2179AE0", Offset = "0x2178AE0", VA = "0x182179AE0", Slot = "6")]
	protected override IEnumerator<TElement> OECBHAPKPDL(TCollection LAAFNHPNJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x200DC00", Offset = "0x200CC00", VA = "0x18200DC00")]
	protected DLBPLFMKKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class ENFAFBCHNOG<TElement, TCollection> : global::DLBPLFMKKGG<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected sealed override TCollection BNBCPKDPKEK(ref TCollection JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class PFPNOPOIDHH<TElement, TCollection> : global::ENFAFBCHNOG<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x44D47C0", Offset = "0x44D37C0", VA = "0x1844D47C0", Slot = "7")]
	protected override TCollection FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x44D47E0", Offset = "0x44D37E0", VA = "0x1844D47E0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref TCollection HOJBOBADEDG, int IIHEDPBOLFE, TElement JNLOLNFALGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ANGJHKIEECK<T> : global::MPLDJDACGLE<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED640", VA = "0x1826EE640", Slot = "8")]
	protected override void PPCBFHPPBHE(ref LinkedList<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override LinkedList<T> BNBCPKDPKEK(ref LinkedList<T> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override LinkedList<T> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x37EFFE0", Offset = "0x37EEFE0", VA = "0x1837EFFE0", Slot = "6")]
	protected override LinkedList<T>.Enumerator OECBHAPKPDL(LinkedList<T> LAAFNHPNJCJ)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CFCEIGLCMNI<T> : global::MPLDJDACGLE<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED640", VA = "0x1826EE640", Slot = "8")]
	protected override void PPCBFHPPBHE(ref Queue<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override Queue<T> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x23AF180", Offset = "0x23AE180", VA = "0x1823AF180", Slot = "6")]
	protected override Queue<T>.Enumerator OECBHAPKPDL(Queue<T> LAAFNHPNJCJ)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override Queue<T> BNBCPKDPKEK(ref Queue<T> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class HHOAEOFDJLG<T> : global::MPLDJDACGLE<T, global::GDEHINOINHB<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1D0", Offset = "0x23AE1D0", VA = "0x1823AF1D0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref global::GDEHINOINHB<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x23AF130", Offset = "0x23AE130", VA = "0x1823AF130", Slot = "7")]
	protected override global::GDEHINOINHB<T> FBMLCAAKPML()
	{
		return default(global::GDEHINOINHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x23AF180", Offset = "0x23AE180", VA = "0x1823AF180", Slot = "6")]
	protected override Stack<T>.Enumerator OECBHAPKPDL(Stack<T> LAAFNHPNJCJ)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x23AF050", Offset = "0x23AE050", VA = "0x1823AF050", Slot = "9")]
	protected override Stack<T> BNBCPKDPKEK(ref global::GDEHINOINHB<T> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NFMGHEKNCPM<T> : global::MPLDJDACGLE<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED640", VA = "0x1826EE640", Slot = "8")]
	protected override void PPCBFHPPBHE(ref HashSet<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override HashSet<T> BNBCPKDPKEK(ref HashSet<T> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override HashSet<T> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x23AF180", Offset = "0x23AE180", VA = "0x1823AF180", Slot = "6")]
	protected override HashSet<T>.Enumerator OECBHAPKPDL(HashSet<T> LAAFNHPNJCJ)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class JJCCKBHMLKP<T> : global::DLBPLFMKKGG<T, global::GDEHINOINHB<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1D0", Offset = "0x23AE1D0", VA = "0x1823AF1D0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref global::GDEHINOINHB<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x348CEC0", Offset = "0x348BEC0", VA = "0x18348CEC0", Slot = "9")]
	protected override ReadOnlyCollection<T> BNBCPKDPKEK(ref global::GDEHINOINHB<T> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x348CF50", Offset = "0x348BF50", VA = "0x18348CF50", Slot = "7")]
	protected override global::GDEHINOINHB<T> FBMLCAAKPML()
	{
		return default(global::GDEHINOINHB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class DMKCDLCDMJH<T> : global::DLBPLFMKKGG<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED640", VA = "0x1826EE640", Slot = "8")]
	protected override void PPCBFHPPBHE(ref List<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override List<T> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override IList<T> BNBCPKDPKEK(ref List<T> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BADIIKKGFLB<T> : global::DLBPLFMKKGG<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x26EE640", Offset = "0x26ED640", VA = "0x1826EE640", Slot = "8")]
	protected override void PPCBFHPPBHE(ref List<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override List<T> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override ICollection<T> BNBCPKDPKEK(ref List<T> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class EHGDKOKCGLN<T> : global::DLBPLFMKKGG<T, global::GDEHINOINHB<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x23AF1D0", Offset = "0x23AE1D0", VA = "0x1823AF1D0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref global::GDEHINOINHB<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x23AF130", Offset = "0x23AE130", VA = "0x1823AF130", Slot = "7")]
	protected override global::GDEHINOINHB<T> FBMLCAAKPML()
	{
		return default(global::GDEHINOINHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3359BA0", Offset = "0x3358BA0", VA = "0x183359BA0", Slot = "9")]
	protected override IEnumerable<T> BNBCPKDPKEK(ref global::GDEHINOINHB<T> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class CMDNFDLDOBM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class ANCGCMCDIHE<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class KJCJKIPOILK<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GPAPNNMPCNF : global::NPNEMBPIJOL<IEnumerable>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::NPNEMBPIJOL<IEnumerable> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x340F230", Offset = "0x340E230", VA = "0x18340F230", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, IEnumerable JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x340F0B0", Offset = "0x340E0B0", VA = "0x18340F0B0", Slot = "5")]
	public IEnumerable HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GPAPNNMPCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OMGJJLDMJBK : global::NPNEMBPIJOL<ICollection>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::NPNEMBPIJOL<ICollection> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4F49C00", Offset = "0x4F48C00", VA = "0x184F49C00", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ICollection JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4F49A80", Offset = "0x4F48A80", VA = "0x184F49A80", Slot = "5")]
	public ICollection HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OMGJJLDMJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class KPGFEANKPOE : global::NPNEMBPIJOL<IList>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::NPNEMBPIJOL<IList> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x341A130", Offset = "0x3419130", VA = "0x18341A130", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, IList JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3419FB0", Offset = "0x3418FB0", VA = "0x183419FB0", Slot = "5")]
	public IList HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KPGFEANKPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class BPLMAIMFLNK<T> : global::DLBPLFMKKGG<T, global::GDEHINOINHB<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DE50", Offset = "0x3E2CE50", VA = "0x183E2DE50", Slot = "8")]
	protected override void PPCBFHPPBHE(ref global::GDEHINOINHB<T> HOJBOBADEDG, int IIHEDPBOLFE, T JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x23AF130", Offset = "0x23AE130", VA = "0x1823AF130", Slot = "7")]
	protected override global::GDEHINOINHB<T> FBMLCAAKPML()
	{
		return default(global::GDEHINOINHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DE10", Offset = "0x3E2CE10", VA = "0x183E2DE10", Slot = "9")]
	protected override IReadOnlyList<T> BNBCPKDPKEK(ref global::GDEHINOINHB<T> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1CBEA70", Offset = "0x1CBDA70", VA = "0x181CBEA70")]
	public BPLMAIMFLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class IJCCLIKAHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3413A90", Offset = "0x3412A90", VA = "0x183413A90")]
	public static DateTime DBPHMDHNKGB(DateTime MGKGELPGLHM)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class HCFBFODJNIK : global::NPNEMBPIJOL<DateTime>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::NPNEMBPIJOL<DateTime> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x34104C0", Offset = "0x340F4C0", VA = "0x1834104C0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, DateTime JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x340F530", Offset = "0x340E530", VA = "0x18340F530", Slot = "5")]
	public DateTime HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HCFBFODJNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class ACJCAAPABFK : global::NPNEMBPIJOL<DateTimeOffset>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::NPNEMBPIJOL<DateTimeOffset> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x395B2C0", Offset = "0x395A2C0", VA = "0x18395B2C0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, DateTimeOffset JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x395A320", Offset = "0x3959320", VA = "0x18395A320", Slot = "5")]
	public DateTimeOffset HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public ACJCAAPABFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class OODECAJDFDK : global::NPNEMBPIJOL<TimeSpan>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::NPNEMBPIJOL<TimeSpan> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] KCIMCLPECEE;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4F4A770", Offset = "0x4F49770", VA = "0x184F4A770", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, TimeSpan JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4F49F00", Offset = "0x4F48F00", VA = "0x184F49F00", Slot = "5")]
	public TimeSpan HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OODECAJDFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class CJBANNEELJC<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::NPNEMBPIJOL<TDictionary>, OONIALJDMLO where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2717F10", Offset = "0x2716F10", VA = "0x182717F10", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, TDictionary JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x27167D0", Offset = "0x27157D0", VA = "0x1827167D0", Slot = "5")]
	public TDictionary HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OECBHAPKPDL(TDictionary LAAFNHPNJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBMLCAAKPML();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void PPCBFHPPBHE(ref TIntermediate HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary BNBCPKDPKEK(ref TIntermediate JPDGJJGBBHD);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	protected CJBANNEELJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class PDOKCHAMCMG<TKey, TValue, TIntermediate, TDictionary> : global::CJBANNEELJC<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2179AE0", Offset = "0x2178AE0", VA = "0x182179AE0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> OECBHAPKPDL(TDictionary LAAFNHPNJCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class LAFIBOBKCPH<TKey, TValue, TDictionary> : global::PDOKCHAMCMG<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override TDictionary BNBCPKDPKEK(ref TDictionary JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PBNDHBOMBEI<TKey, TValue> : global::CJBANNEELJC<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x37F0090", Offset = "0x37EF090", VA = "0x1837F0090", Slot = "8")]
	protected override void PPCBFHPPBHE(ref Dictionary<TKey, TValue> HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override Dictionary<TKey, TValue> BNBCPKDPKEK(ref Dictionary<TKey, TValue> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x37F0040", Offset = "0x37EF040", VA = "0x1837F0040", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator OECBHAPKPDL(Dictionary<TKey, TValue> LAAFNHPNJCJ)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1CC4AA0", Offset = "0x1CC3AA0", VA = "0x181CC4AA0")]
	public PBNDHBOMBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class KBGEOAEENFP<TKey, TValue, TDictionary> : global::LAFIBOBKCPH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x32F2EB0", Offset = "0x32F1EB0", VA = "0x1832F2EB0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref TDictionary HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A820", Offset = "0x2B79820", VA = "0x182B7A820", Slot = "7")]
	protected override TDictionary FBMLCAAKPML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class CDBMNFKLFIF<TKey, TValue> : global::PDOKCHAMCMG<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x28853B0", Offset = "0x28843B0", VA = "0x1828853B0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref Dictionary<TKey, TValue> HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override IDictionary<TKey, TValue> BNBCPKDPKEK(ref Dictionary<TKey, TValue> JPDGJJGBBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class GBFFKIMEGPK<TKey, TValue> : global::LAFIBOBKCPH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x28853B0", Offset = "0x28843B0", VA = "0x1828853B0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref SortedList<TKey, TValue> HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override SortedList<TKey, TValue> FBMLCAAKPML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class KOOGNAJFOEH<TKey, TValue> : global::CJBANNEELJC<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x28853B0", Offset = "0x28843B0", VA = "0x1828853B0", Slot = "8")]
	protected override void PPCBFHPPBHE(ref SortedDictionary<TKey, TValue> HOJBOBADEDG, int IIHEDPBOLFE, TKey GGLJFLNJABJ, TValue JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x10CB9E0", Offset = "0x10CA9E0", VA = "0x1810CB9E0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> BNBCPKDPKEK(ref SortedDictionary<TKey, TValue> JPDGJJGBBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x26EE5E0", Offset = "0x26ED5E0", VA = "0x1826EE5E0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> FBMLCAAKPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3E004E0", Offset = "0x3DFF4E0", VA = "0x183E004E0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator OECBHAPKPDL(SortedDictionary<TKey, TValue> LAAFNHPNJCJ)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class FACPGDMNOID<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class LMFKNJJMKCA : global::NPNEMBPIJOL<IDictionary>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::NPNEMBPIJOL<IDictionary> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x4F40360", Offset = "0x4F3F360", VA = "0x184F40360", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, IDictionary JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4F401C0", Offset = "0x4F3F1C0", VA = "0x184F401C0", Slot = "5")]
	public IDictionary HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LMFKNJJMKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class PKEACHLAAOH : global::NPNEMBPIJOL<object>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void DCHPAMILNMM(object JINLJDFLLJI, ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::PLFGLOIOOAG<KeyValuePair<object, DCHPAMILNMM>> NOJKDGAOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly JMAAFANLPGO[] AECKHDMFPPD;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D230", Offset = "0x4F4C230", VA = "0x184F4D230")]
	public PKEACHLAAOH(params JMAAFANLPGO[] AECKHDMFPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4F4CA60", Offset = "0x4F4BA60", VA = "0x184F4CA60", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C9D0", Offset = "0x4F4B9D0", VA = "0x184F4C9D0", Slot = "5")]
	public object HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class PCFNBDAOEDI
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4F4B4A0", Offset = "0x4F4A4A0", VA = "0x184F4B4A0")]
	public static object KKJIEGHFMNP(Type GLKKDGLKBMK, out bool EAONNDBOCBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4F4ACC0", Offset = "0x4F49CC0", VA = "0x184F4ACC0")]
	public static object CEBDOEEBAGM(Type GLKKDGLKBMK, out bool EAONNDBOCBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class BMOJPMAGENI<T> : global::NPNEMBPIJOL<T>, OONIALJDMLO, global::NMCJNPEAHKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AEJPBHBJJJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public AEJPBHBJJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x45BA610", Offset = "0x45B9610", VA = "0x1845BA610")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DHLDOKPOFAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::PHPMEOAGLHK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public DHLDOKPOFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x45D2640", Offset = "0x45D1640", VA = "0x1845D2640")]
		internal void <.cctor>b__1(ref DLCIAKEHIIK writer, T value, JMAAFANLPGO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class IECGHMGAFIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::JJDPBBPLMGE<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		public IECGHMGAFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x45D4160", Offset = "0x45D3160", VA = "0x1845D4160")]
		internal T <.cctor>b__2(ref AFHKAOHPCCD reader, JMAAFANLPGO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::HJNLBDDJJDN<T> COMLNHANGCK;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> IPIJBKLJFBI;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::PHPMEOAGLHK<T> ILEHPGNDDNB;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::JJDPBBPLMGE<T> CDPMJEILCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool LGMDMKFLIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::PHPMEOAGLHK<T> EBFKJPOPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::JJDPBBPLMGE<T> CJLBHJNDJHG;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x45C86E0", Offset = "0x45C76E0", VA = "0x1845C86E0")]
	static BMOJPMAGENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3E2DCB0", Offset = "0x3E2CCB0", VA = "0x183E2DCB0")]
	public BMOJPMAGENI(bool LGMDMKFLIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x45C1080", Offset = "0x45C0080", VA = "0x1845C1080", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x45BC7D0", Offset = "0x45BB7D0", VA = "0x1845BC7D0", Slot = "5")]
	public T HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3E1A730", Offset = "0x3E19730", VA = "0x183E1A730", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, T JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x45BBB50", Offset = "0x45BAB50", VA = "0x1845BBB50", Slot = "7")]
	public T CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GFIMAOPPPMH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MOLNBNMGCLJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class NGLFJOCEIEL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CKMJMJOGHGC<T> : global::NPNEMBPIJOL<T?>, OONIALJDMLO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2719BA0", Offset = "0x2718BA0", VA = "0x182719BA0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, T? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2719910", Offset = "0x2718910", VA = "0x182719910", Slot = "5")]
	public T? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
	public CKMJMJOGHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GDAPMHJGHHD<T> : global::NPNEMBPIJOL<T?>, OONIALJDMLO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::NPNEMBPIJOL<T> FOCGJAODCCG;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
	public GDAPMHJGHHD(global::NPNEMBPIJOL<T> FOCGJAODCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x403A990", Offset = "0x4039990", VA = "0x18403A990", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, T? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x403A690", Offset = "0x4039690", VA = "0x18403A690", Slot = "5")]
	public T? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class DNLOKJNCDMP : global::NPNEMBPIJOL<sbyte>, OONIALJDMLO, global::NMCJNPEAHKA<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly DNLOKJNCDMP CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3969CA0", Offset = "0x3968CA0", VA = "0x183969CA0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, sbyte JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3969C50", Offset = "0x3968C50", VA = "0x183969C50", Slot = "5")]
	public sbyte HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3969B90", Offset = "0x3968B90", VA = "0x183969B90", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, sbyte JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3969B20", Offset = "0x3968B20", VA = "0x183969B20", Slot = "7")]
	public sbyte CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DNLOKJNCDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NPDJNLEFFMN : global::NPNEMBPIJOL<sbyte?>, OONIALJDMLO, global::NMCJNPEAHKA<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly NPDJNLEFFMN CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F47880", Offset = "0x4F46880", VA = "0x184F47880", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, sbyte? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F47810", Offset = "0x4F46810", VA = "0x184F47810", Slot = "5")]
	public sbyte? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F47790", Offset = "0x4F46790", VA = "0x184F47790", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, sbyte? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F476B0", Offset = "0x4F466B0", VA = "0x184F476B0", Slot = "7")]
	public sbyte? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NPDJNLEFFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class FEGBNBALEMF : global::NPNEMBPIJOL<sbyte[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly FEGBNBALEMF CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x396B160", Offset = "0x396A160", VA = "0x18396B160", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, sbyte[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x396AFC0", Offset = "0x3969FC0", VA = "0x18396AFC0", Slot = "5")]
	public sbyte[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public FEGBNBALEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class DHKOJGMACAI : global::NPNEMBPIJOL<short>, OONIALJDMLO, global::NMCJNPEAHKA<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly DHKOJGMACAI CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3968620", Offset = "0x3967620", VA = "0x183968620", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, short JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x39685C0", Offset = "0x39675C0", VA = "0x1839685C0", Slot = "5")]
	public short HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3968500", Offset = "0x3967500", VA = "0x183968500", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, short JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3968490", Offset = "0x3967490", VA = "0x183968490", Slot = "7")]
	public short CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DHKOJGMACAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class GDCPIHFEAHH : global::NPNEMBPIJOL<short?>, OONIALJDMLO, global::NMCJNPEAHKA<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly GDCPIHFEAHH CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x396DC00", Offset = "0x396CC00", VA = "0x18396DC00", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, short? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x396DB50", Offset = "0x396CB50", VA = "0x18396DB50", Slot = "5")]
	public short? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x396DA50", Offset = "0x396CA50", VA = "0x18396DA50", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, short? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x396D9B0", Offset = "0x396C9B0", VA = "0x18396D9B0", Slot = "7")]
	public short? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GDCPIHFEAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HJJFLBHPHAL : global::NPNEMBPIJOL<short[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly HJJFLBHPHAL CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x34119A0", Offset = "0x34109A0", VA = "0x1834119A0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, short[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x3411860", Offset = "0x3410860", VA = "0x183411860", Slot = "5")]
	public short[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HJJFLBHPHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class NHJNBLEJBNK : global::NPNEMBPIJOL<int>, OONIALJDMLO, global::NMCJNPEAHKA<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NHJNBLEJBNK CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F45670", Offset = "0x4F44670", VA = "0x184F45670", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, int JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F45660", Offset = "0x4F44660", VA = "0x184F45660", Slot = "5")]
	public int HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F45620", Offset = "0x4F44620", VA = "0x184F45620", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, int JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F45580", Offset = "0x4F44580", VA = "0x184F45580", Slot = "7")]
	public int CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NHJNBLEJBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class EKNLIDGGGEC : global::NPNEMBPIJOL<int?>, OONIALJDMLO, global::NMCJNPEAHKA<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly EKNLIDGGGEC CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x396A7D0", Offset = "0x39697D0", VA = "0x18396A7D0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, int? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x396A720", Offset = "0x3969720", VA = "0x18396A720", Slot = "5")]
	public int? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x396A620", Offset = "0x3969620", VA = "0x18396A620", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, int? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x396A580", Offset = "0x3969580", VA = "0x18396A580", Slot = "7")]
	public int? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EKNLIDGGGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class JCHBMFEMKPB : global::NPNEMBPIJOL<int[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly JCHBMFEMKPB CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3416F60", Offset = "0x3415F60", VA = "0x183416F60", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, int[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3416E20", Offset = "0x3415E20", VA = "0x183416E20", Slot = "5")]
	public int[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JCHBMFEMKPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class LCBPIAIPIKN : global::NPNEMBPIJOL<long>, OONIALJDMLO, global::NMCJNPEAHKA<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly LCBPIAIPIKN CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x341A6D0", Offset = "0x34196D0", VA = "0x18341A6D0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, long JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x341A6C0", Offset = "0x34196C0", VA = "0x18341A6C0", Slot = "5")]
	public long HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x341A680", Offset = "0x3419680", VA = "0x18341A680", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, long JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x341A610", Offset = "0x3419610", VA = "0x18341A610", Slot = "7")]
	public long CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LCBPIAIPIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JACKLGEJAND : global::NPNEMBPIJOL<long?>, OONIALJDMLO, global::NMCJNPEAHKA<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly JACKLGEJAND CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x3415970", Offset = "0x3414970", VA = "0x183415970", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, long? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x34158E0", Offset = "0x34148E0", VA = "0x1834158E0", Slot = "5")]
	public long? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3415860", Offset = "0x3414860", VA = "0x183415860", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, long? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x34157A0", Offset = "0x34147A0", VA = "0x1834157A0", Slot = "7")]
	public long? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JACKLGEJAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class AMOEGEDOBLM : global::NPNEMBPIJOL<long[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly AMOEGEDOBLM CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3960620", Offset = "0x395F620", VA = "0x183960620", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, long[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3960480", Offset = "0x395F480", VA = "0x183960480", Slot = "5")]
	public long[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AMOEGEDOBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class BBAEODECCIG : global::NPNEMBPIJOL<byte>, OONIALJDMLO, global::NMCJNPEAHKA<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly BBAEODECCIG CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x39614B0", Offset = "0x39604B0", VA = "0x1839614B0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, byte JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3961450", Offset = "0x3960450", VA = "0x183961450", Slot = "5")]
	public byte HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3961390", Offset = "0x3960390", VA = "0x183961390", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, byte JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3961320", Offset = "0x3960320", VA = "0x183961320", Slot = "7")]
	public byte CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public BBAEODECCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class FALGMDIHNKI : global::NPNEMBPIJOL<byte?>, OONIALJDMLO, global::NMCJNPEAHKA<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly FALGMDIHNKI CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x396AEE0", Offset = "0x3969EE0", VA = "0x18396AEE0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, byte? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x396AE30", Offset = "0x3969E30", VA = "0x18396AE30", Slot = "5")]
	public byte? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x396AD30", Offset = "0x3969D30", VA = "0x18396AD30", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, byte? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x396AC80", Offset = "0x3969C80", VA = "0x18396AC80", Slot = "7")]
	public byte? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public FALGMDIHNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class PPJHFKCFPEA : global::NPNEMBPIJOL<ushort>, OONIALJDMLO, global::NMCJNPEAHKA<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly PPJHFKCFPEA CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D590", Offset = "0x4F4C590", VA = "0x184F4D590", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ushort JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D580", Offset = "0x4F4C580", VA = "0x184F4D580", Slot = "5")]
	public ushort HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D540", Offset = "0x4F4C540", VA = "0x184F4D540", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, ushort JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4F4D4A0", Offset = "0x4F4C4A0", VA = "0x184F4D4A0", Slot = "7")]
	public ushort CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public PPJHFKCFPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class DPPAKPDFLOE : global::NPNEMBPIJOL<ushort?>, OONIALJDMLO, global::NMCJNPEAHKA<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly DPPAKPDFLOE CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3969F90", Offset = "0x3968F90", VA = "0x183969F90", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ushort? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3969EE0", Offset = "0x3968EE0", VA = "0x183969EE0", Slot = "5")]
	public ushort? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3969DE0", Offset = "0x3968DE0", VA = "0x183969DE0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, ushort? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3969D40", Offset = "0x3968D40", VA = "0x183969D40", Slot = "7")]
	public ushort? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DPPAKPDFLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class MFPHMJCGJIE : global::NPNEMBPIJOL<ushort[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly MFPHMJCGJIE CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F41330", Offset = "0x4F40330", VA = "0x184F41330", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ushort[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F411F0", Offset = "0x4F401F0", VA = "0x184F411F0", Slot = "5")]
	public ushort[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MFPHMJCGJIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class OPJEOIFLHEJ : global::NPNEMBPIJOL<uint>, OONIALJDMLO, global::NMCJNPEAHKA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly OPJEOIFLHEJ CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F4AC50", Offset = "0x4F49C50", VA = "0x184F4AC50", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, uint JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F4AC40", Offset = "0x4F49C40", VA = "0x184F4AC40", Slot = "5")]
	public uint HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F4AC00", Offset = "0x4F49C00", VA = "0x184F4AC00", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, uint JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F4AB60", Offset = "0x4F49B60", VA = "0x184F4AB60", Slot = "7")]
	public uint CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public OPJEOIFLHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class GNOKCBCENBL : global::NPNEMBPIJOL<uint?>, OONIALJDMLO, global::NMCJNPEAHKA<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly GNOKCBCENBL CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x340EFD0", Offset = "0x340DFD0", VA = "0x18340EFD0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, uint? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x340EF60", Offset = "0x340DF60", VA = "0x18340EF60", Slot = "5")]
	public uint? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x340EEE0", Offset = "0x340DEE0", VA = "0x18340EEE0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, uint? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x340EE40", Offset = "0x340DE40", VA = "0x18340EE40", Slot = "7")]
	public uint? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GNOKCBCENBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class NNHJBHDKMOE : global::NPNEMBPIJOL<uint[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly NNHJBHDKMOE CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4F45AC0", Offset = "0x4F44AC0", VA = "0x184F45AC0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, uint[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x4F45980", Offset = "0x4F44980", VA = "0x184F45980", Slot = "5")]
	public uint[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NNHJBHDKMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class BCOAEGKGLMP : global::NPNEMBPIJOL<ulong>, OONIALJDMLO, global::NMCJNPEAHKA<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly BCOAEGKGLMP CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x3961D90", Offset = "0x3960D90", VA = "0x183961D90", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ulong JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3961D80", Offset = "0x3960D80", VA = "0x183961D80", Slot = "5")]
	public ulong HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3961CC0", Offset = "0x3960CC0", VA = "0x183961CC0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, ulong JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3961C50", Offset = "0x3960C50", VA = "0x183961C50", Slot = "7")]
	public ulong CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public BCOAEGKGLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class NFLALLOLKIK : global::NPNEMBPIJOL<ulong?>, OONIALJDMLO, global::NMCJNPEAHKA<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly NFLALLOLKIK CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4F454B0", Offset = "0x4F444B0", VA = "0x184F454B0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ulong? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4F45420", Offset = "0x4F44420", VA = "0x184F45420", Slot = "5")]
	public ulong? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4F453A0", Offset = "0x4F443A0", VA = "0x184F453A0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, ulong? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F442E0", VA = "0x184F452E0", Slot = "7")]
	public ulong? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public NFLALLOLKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class CGLNGGPDNFG : global::NPNEMBPIJOL<ulong[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly CGLNGGPDNFG CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3964D80", Offset = "0x3963D80", VA = "0x183964D80", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ulong[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3964BE0", Offset = "0x3963BE0", VA = "0x183964BE0", Slot = "5")]
	public ulong[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public CGLNGGPDNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class HIIAPNEBHCE : global::NPNEMBPIJOL<float>, OONIALJDMLO, global::NMCJNPEAHKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly HIIAPNEBHCE CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x34117F0", Offset = "0x34107F0", VA = "0x1834117F0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, float JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x34117E0", Offset = "0x34107E0", VA = "0x1834117E0", Slot = "5")]
	public float HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x34117A0", Offset = "0x34107A0", VA = "0x1834117A0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, float JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3411730", Offset = "0x3410730", VA = "0x183411730", Slot = "7")]
	public float CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HIIAPNEBHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LDLCODNGKBH : global::NPNEMBPIJOL<float?>, OONIALJDMLO, global::NMCJNPEAHKA<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly LDLCODNGKBH CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FA20", Offset = "0x4F3EA20", VA = "0x184F3FA20", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, float? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F9B0", Offset = "0x4F3E9B0", VA = "0x184F3F9B0", Slot = "5")]
	public float? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F930", Offset = "0x4F3E930", VA = "0x184F3F930", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, float? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F7C0", Offset = "0x4F3E7C0", VA = "0x184F3F7C0", Slot = "7")]
	public float? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public LDLCODNGKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IOBCDNCBGNK : global::NPNEMBPIJOL<float[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IOBCDNCBGNK CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x3415360", Offset = "0x3414360", VA = "0x183415360", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, float[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x3415220", Offset = "0x3414220", VA = "0x183415220", Slot = "5")]
	public float[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IOBCDNCBGNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class MFCJEBEGEIP : global::NPNEMBPIJOL<double>, OONIALJDMLO, global::NMCJNPEAHKA<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly MFCJEBEGEIP CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F41110", Offset = "0x4F40110", VA = "0x184F41110", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, double JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4F41100", Offset = "0x4F40100", VA = "0x184F41100", Slot = "5")]
	public double HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4F410C0", Offset = "0x4F400C0", VA = "0x184F410C0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, double JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x4F40F90", Offset = "0x4F3FF90", VA = "0x184F40F90", Slot = "7")]
	public double CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MFCJEBEGEIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FINBNFFHBFN : global::NPNEMBPIJOL<double?>, OONIALJDMLO, global::NMCJNPEAHKA<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FINBNFFHBFN CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x396B670", Offset = "0x396A670", VA = "0x18396B670", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, double? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x396B5E0", Offset = "0x396A5E0", VA = "0x18396B5E0", Slot = "5")]
	public double? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x396B4E0", Offset = "0x396A4E0", VA = "0x18396B4E0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, double? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x396B420", Offset = "0x396A420", VA = "0x18396B420", Slot = "7")]
	public double? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public FINBNFFHBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IICKOMMKFIF : global::NPNEMBPIJOL<double[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly IICKOMMKFIF CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3413970", Offset = "0x3412970", VA = "0x183413970", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, double[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x3413830", Offset = "0x3412830", VA = "0x183413830", Slot = "5")]
	public double[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public IICKOMMKFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class ALAHKHEJNIC : global::NPNEMBPIJOL<bool>, OONIALJDMLO, global::NMCJNPEAHKA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly ALAHKHEJNIC CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x3960400", Offset = "0x395F400", VA = "0x183960400", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, bool JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x39603F0", Offset = "0x395F3F0", VA = "0x1839603F0", Slot = "5")]
	public bool HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x3960340", Offset = "0x395F340", VA = "0x183960340", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, bool JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x39602D0", Offset = "0x395F2D0", VA = "0x1839602D0", Slot = "7")]
	public bool CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public ALAHKHEJNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class MNEBJDPMHEG : global::NPNEMBPIJOL<bool?>, OONIALJDMLO, global::NMCJNPEAHKA<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly MNEBJDPMHEG CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4F43E20", Offset = "0x4F42E20", VA = "0x184F43E20", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, bool? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4F43DB0", Offset = "0x4F42DB0", VA = "0x184F43DB0", Slot = "5")]
	public bool? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4F43D30", Offset = "0x4F42D30", VA = "0x184F43D30", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, bool? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4F43C80", Offset = "0x4F42C80", VA = "0x184F43C80", Slot = "7")]
	public bool? CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MNEBJDPMHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class AEIKJCFKDCF : global::NPNEMBPIJOL<bool[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly AEIKJCFKDCF CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x395C510", Offset = "0x395B510", VA = "0x18395C510", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, bool[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x395C370", Offset = "0x395B370", VA = "0x18395C370", Slot = "5")]
	public bool[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public AEIKJCFKDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GMDHONGLCDJ : global::NPNEMBPIJOL<object>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::NPNEMBPIJOL<object> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> OJNOJKGMKFK;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x340E070", Offset = "0x340D070", VA = "0x18340E070", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, object JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x340DDD0", Offset = "0x340CDD0", VA = "0x18340DDD0", Slot = "5")]
	public object HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GMDHONGLCDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class GNNCLIKOHNG : global::NPNEMBPIJOL<byte[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::NPNEMBPIJOL<byte[]> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x340ED50", Offset = "0x340DD50", VA = "0x18340ED50", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, byte[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x340ECD0", Offset = "0x340DCD0", VA = "0x18340ECD0", Slot = "5")]
	public byte[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public GNNCLIKOHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EADKKOJOKDH : global::NPNEMBPIJOL<ArraySegment<byte>>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::NPNEMBPIJOL<ArraySegment<byte>> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x396A140", Offset = "0x3969140", VA = "0x18396A140", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, ArraySegment<byte> JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x396A070", Offset = "0x3969070", VA = "0x18396A070", Slot = "5")]
	public ArraySegment<byte> HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EADKKOJOKDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class KEEONCDOIJN : global::NPNEMBPIJOL<string>, OONIALJDMLO, global::NMCJNPEAHKA<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::NPNEMBPIJOL<string> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x34191F0", Offset = "0x34181F0", VA = "0x1834191F0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, string JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x34191E0", Offset = "0x34181E0", VA = "0x1834191E0", Slot = "5")]
	public string HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x34191F0", Offset = "0x34181F0", VA = "0x1834191F0", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, string JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x34191E0", Offset = "0x34181E0", VA = "0x1834191E0", Slot = "7")]
	public string CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KEEONCDOIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class FJNDPHBLBBA : global::NPNEMBPIJOL<string[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly FJNDPHBLBBA CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x396B8E0", Offset = "0x396A8E0", VA = "0x18396B8E0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, string[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x396B740", Offset = "0x396A740", VA = "0x18396B740", Slot = "5")]
	public string[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public FJNDPHBLBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class MMOMNOLGADA : global::NPNEMBPIJOL<char>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly MMOMNOLGADA CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x4F43BA0", Offset = "0x4F42BA0", VA = "0x184F43BA0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, char JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4F43B70", Offset = "0x4F42B70", VA = "0x184F43B70", Slot = "5")]
	public char HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public MMOMNOLGADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class KPEIOOJEHDP : global::NPNEMBPIJOL<char?>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly KPEIOOJEHDP CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x3419E80", Offset = "0x3418E80", VA = "0x183419E80", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, char? JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3419DC0", Offset = "0x3418DC0", VA = "0x183419DC0", Slot = "5")]
	public char? HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KPEIOOJEHDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class BAKLIMIJPFG : global::NPNEMBPIJOL<char[]>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly BAKLIMIJPFG CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x3961080", Offset = "0x3960080", VA = "0x183961080", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, char[] JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x3960EA0", Offset = "0x395FEA0", VA = "0x183960EA0", Slot = "5")]
	public char[] HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public BAKLIMIJPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class EOHFCOHANAN : global::NPNEMBPIJOL<Guid>, OONIALJDMLO, global::NMCJNPEAHKA<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::NPNEMBPIJOL<Guid> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x396AA40", Offset = "0x3969A40", VA = "0x18396AA40", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Guid JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x396ABD0", Offset = "0x3969BD0", VA = "0x18396ABD0", Slot = "5")]
	public Guid HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x396AA40", Offset = "0x3969A40", VA = "0x18396AA40", Slot = "6")]
	public void EGBOGEEDLHL(ref DLCIAKEHIIK FDGBHFMGIPL, Guid JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x396A9F0", Offset = "0x39699F0", VA = "0x18396A9F0", Slot = "7")]
	public Guid CDKBIJOBICN(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EOHFCOHANAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class BABNJLLLHFD : global::NPNEMBPIJOL<decimal>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::NPNEMBPIJOL<decimal> CDLKEADKJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool MFPIBMHBDEC;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xBCAF40", Offset = "0xBC9F40", VA = "0x180BCAF40")]
	public BABNJLLLHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1AF15C0", Offset = "0x1AF05C0", VA = "0x181AF15C0")]
	public BABNJLLLHFD(bool MFPIBMHBDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x3960CD0", Offset = "0x395FCD0", VA = "0x183960CD0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, decimal JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x3960B20", Offset = "0x395FB20", VA = "0x183960B20", Slot = "5")]
	public decimal HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class JDLGIMDOCJN : global::NPNEMBPIJOL<Uri>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::NPNEMBPIJOL<Uri> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x3417100", Offset = "0x3416100", VA = "0x183417100", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Uri JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x3417080", Offset = "0x3416080", VA = "0x183417080", Slot = "5")]
	public Uri HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JDLGIMDOCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class CHBPHCLMFGC : global::NPNEMBPIJOL<Version>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::NPNEMBPIJOL<Version> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3965000", Offset = "0x3964000", VA = "0x183965000", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Version JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3964F80", Offset = "0x3963F80", VA = "0x183964F80", Slot = "5")]
	public Version HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public CHBPHCLMFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class KKKOMNBCGMN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class KOECOBBBOIK : global::NPNEMBPIJOL<StringBuilder>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::NPNEMBPIJOL<StringBuilder> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x3419D10", Offset = "0x3418D10", VA = "0x183419D10", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, StringBuilder JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x3419C90", Offset = "0x3418C90", VA = "0x183419C90", Slot = "5")]
	public StringBuilder HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public KOECOBBBOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HNIFEPJCBOH : global::NPNEMBPIJOL<BitArray>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::NPNEMBPIJOL<BitArray> CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x3411BC0", Offset = "0x3410BC0", VA = "0x183411BC0", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, BitArray JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x3411AC0", Offset = "0x3410AC0", VA = "0x183411AC0", Slot = "5")]
	public BitArray HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public HNIFEPJCBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class MCJLCHLJPFO : global::NPNEMBPIJOL<Type>, OONIALJDMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly MCJLCHLJPFO CDLKEADKJFL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex CHMDMHFOJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool JLLNFHFGCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool KJANBOMCIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool MJOIOIHNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F40BE0", Offset = "0x4F3FBE0", VA = "0x184F40BE0")]
	public MCJLCHLJPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F40B90", Offset = "0x4F3FB90", VA = "0x184F40B90")]
	public MCJLCHLJPFO(bool JLLNFHFGCNH, bool KJANBOMCIGL, bool MJOIOIHNJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x4F40A00", Offset = "0x4F3FA00", VA = "0x184F40A00", Slot = "4")]
	public void NJADPKHDAEC(ref DLCIAKEHIIK FDGBHFMGIPL, Type JNLOLNFALGF, JMAAFANLPGO JHLIKPFLLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x4F408E0", Offset = "0x4F3F8E0", VA = "0x184F408E0", Slot = "5")]
	public Type HIDKAFCIGIB(ref AFHKAOHPCCD FDKCNEJMANN, JMAAFANLPGO JHLIKPFLLHJ)
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
