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
public class CFJIKIOLGGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526680", VA = "0x180527480")]
	public CFJIKIOLGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class MLOHEPDNCCN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526680", VA = "0x180527480")]
	public MLOHEPDNCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DCKKEHFKDFH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526680", VA = "0x180527480")]
	public DCKKEHFKDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class IPMLHGMGJEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526680", VA = "0x180527480")]
	public IPMLHGMGJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BDDMFMKEOMK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3084160", Offset = "0x3083360", VA = "0x183084160")]
	public static bool KJGOOAEDNIK(this TypeInfo OMCCJKNHBML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class LDJBNAGGKPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LAFMJLPHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] GDEKFFNCNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x694EB0", Offset = "0x6940B0", VA = "0x180694EB0")]
	public LDJBNAGGKPP(Type NCNMILCLELC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BMGAMLCDPEO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NGGJIPACEFH<T>(ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T OBNHHKECGPD<T>(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA JPCLGONAHME);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BNLFGEJDIDK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ANGGPBBBOPJ<T> : BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHEOENCCDHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KGEGEEEBEGL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DAJINOBGMNK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2689D00", Offset = "0x2688F00", VA = "0x182689D00")]
	public static global::ANGGPBBBOPJ<T> IEPAELEDCHK<T>(this FAPMHGNPHBA JPCLGONAHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x308D2C0", Offset = "0x308C4C0", VA = "0x18308D2C0")]
	public static object PNPDKPACACJ(this FAPMHGNPHBA JPCLGONAHME, Type OMCCJKNHBML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LOLDPBBMMKJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A32C40", Offset = "0x4A31E40", VA = "0x184A32C40")]
	public LOLDPBBMMKJ(string KJPKEJBABNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FNJBADGOFFA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class AHDKJAOMCAE
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] ODGBLHHLGCK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] EGAEAGDHLMC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x330FDD0", Offset = "0x330EFD0", VA = "0x18330FDD0")]
		public static byte[] LCBFKEIBEFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x330FD40", Offset = "0x330EF40", VA = "0x18330FD40")]
		public static char[] FIPOEMGOMOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> HPMCAHEGFPD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] IIBJJHGGBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] GMBNEFEOHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int KPMCEIEAINM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool PEDIHDJHJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x30992E0", Offset = "0x30984E0", VA = "0x1830992E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3099FB0", Offset = "0x30991B0", VA = "0x183099FB0")]
	public FNJBADGOFFA(byte[] GMBNEFEOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3099DD0", Offset = "0x3098FD0", VA = "0x183099DD0")]
	public FNJBADGOFFA(byte[] GMBNEFEOHLO, int KPMCEIEAINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30984D0", Offset = "0x30976D0", VA = "0x1830984D0")]
	private HPLKKEAHMDH EGJBMHFGNGA(string EGFEOAKHCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3097660", Offset = "0x3096860", VA = "0x183097660")]
	private HPLKKEAHMDH BIOCPECFPGA(string KJPKEJBABNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30903D0", Offset = "0x308F5D0", VA = "0x1830903D0")]
	public void MDHFPAEIAJB(int KPMCEIEAINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7631B0", Offset = "0x7623B0", VA = "0x1807631B0")]
	public byte[] GALDHDGLLGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D34A0", Offset = "0x7D26A0", VA = "0x1807D34A0")]
	public int NEKPEJLJLMN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3099A60", Offset = "0x3098C60", VA = "0x183099A60")]
	public NAOCCJBCPFM PGEEDJNBHFM()
	{
		return default(NAOCCJBCPFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3099770", Offset = "0x3098970", VA = "0x183099770")]
	public void ONONACNAHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3098F80", Offset = "0x3098180", VA = "0x183098F80")]
	public bool KLGKHPMMJJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3098CB0", Offset = "0x3097EB0", VA = "0x183098CB0")]
	public bool IIHOEJIKLBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3098970", Offset = "0x3097B70", VA = "0x183098970")]
	public void EOIEMLHOEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3099BF0", Offset = "0x3098DF0", VA = "0x183099BF0")]
	public bool PKOPKBGDNFM(ref int LMEIKANBNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3097450", Offset = "0x3096650", VA = "0x183097450")]
	public bool AJDEIOBNIAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3098430", Offset = "0x3097630", VA = "0x183098430")]
	public void EBLHONIPGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30974C0", Offset = "0x30966C0", VA = "0x1830974C0")]
	public bool AKMPMMLJFDH(ref int LMEIKANBNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3099C80", Offset = "0x3098E80", VA = "0x183099C80")]
	public bool PMIMLJEENEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30982F0", Offset = "0x30974F0", VA = "0x1830982F0")]
	public void EAJAGEDFDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3099680", Offset = "0x3098880", VA = "0x183099680")]
	public bool NJFMIOLDAHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3098390", Offset = "0x3097590", VA = "0x183098390")]
	public void EBJCIAPCDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30978D0", Offset = "0x3096AD0", VA = "0x1830978D0")]
	private void CLNJNBLHLCH(out byte[] NLDAJAHGMHJ, out int EHNDLLLAEME, out int AGGKIACFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3098E80", Offset = "0x3098080", VA = "0x183098E80")]
	private static int JHFPMPLMAKM(char LIEOABMIJDJ, char DCOPGELFIOF, char DFLGAKHACHA, char NEHIPNHHDCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3098060", Offset = "0x3097260", VA = "0x183098060")]
	private static int CNMKCLNLMGJ(char GGMEAHKJCJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3098200", Offset = "0x3097400", VA = "0x183098200")]
	public ArraySegment<byte> DJCFDMCPDIP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3098D20", Offset = "0x3097F20", VA = "0x183098D20")]
	public string IJIOOOKBHEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30978A0", Offset = "0x3096AA0", VA = "0x1830978A0")]
	public string CLCLDOIFKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30998B0", Offset = "0x3098AB0", VA = "0x1830998B0")]
	public ArraySegment<byte> PCPGABIBFNC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3097860", Offset = "0x3096A60", VA = "0x183097860")]
	public ArraySegment<byte> CHGMIJOPFDA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3099420", Offset = "0x3098620", VA = "0x183099420")]
	public bool NCDNHOFIPFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30977A0", Offset = "0x30969A0", VA = "0x1830977A0")]
	private static bool CHCIHLABMCF(byte DFLGAKHACHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3098A10", Offset = "0x3097C10", VA = "0x183098A10")]
	private void FMDLELEAFBH(NAOCCJBCPFM DKLKDEENFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3098CA0", Offset = "0x3097EA0", VA = "0x183098CA0")]
	public void HGGLGFHJLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3098130", Offset = "0x3097330", VA = "0x183098130")]
	private void DGGLBBOBLMO(int KDNFFDLNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3098F30", Offset = "0x3098130", VA = "0x183098F30")]
	public sbyte KHMOFHBJMMC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3099100", Offset = "0x3098300", VA = "0x183099100")]
	public short LADAEEFLILC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3098E20", Offset = "0x3098020", VA = "0x183098E20")]
	public int JEPFPJPPBGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3097550", Offset = "0x3096750", VA = "0x183097550")]
	public long APPLOIJHENF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3097740", Offset = "0x3096940", VA = "0x183097740")]
	public byte CGBDBKGOJEE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3098DC0", Offset = "0x3097FC0", VA = "0x183098DC0")]
	public ushort JCBGEABOHDE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30990A0", Offset = "0x30982A0", VA = "0x1830990A0")]
	public uint LABELGGKJOD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30996F0", Offset = "0x30988F0", VA = "0x1830996F0")]
	public ulong OBKLAOBKLDG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3097390", Offset = "0x3096590", VA = "0x183097390")]
	public float ADLOMPCGLEA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3098BE0", Offset = "0x3097DE0", VA = "0x183098BE0")]
	public double HABCJEFFPPG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3099300", Offset = "0x3098500", VA = "0x183099300")]
	public ArraySegment<byte> MPDJEFKCJPE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3099160", Offset = "0x3098360", VA = "0x183099160")]
	private static int LNIPOPDOMOP(byte[] GMBNEFEOHLO, int KPMCEIEAINM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HPLKKEAHMDH : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference PHPFHFGAELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PDPBMCDEBOD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FDLNBJOEKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x138B6D0", Offset = "0x138A8D0", VA = "0x18138B6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NCDJMIEBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5C1E10", Offset = "0x5C1010", VA = "0x1805C1E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33201E0", Offset = "0x331F3E0", VA = "0x1833201E0")]
	public HPLKKEAHMDH(string KJPKEJBABNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3320110", Offset = "0x331F310", VA = "0x183320110")]
	public HPLKKEAHMDH(string KJPKEJBABNE, byte[] LIDDHIAADNG, int KPMCEIEAINM, int PDPBMCDEBOD, string KHAJKFIGPON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JCNPPGNLHHO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ICCLMICAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void BMOIAFNKGEL(ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object ADMCONHCFCP(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA JPCLGONAHME);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class FDIMJMLJJGM
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class LKLFGMGAOJP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
				public LKLFGMGAOJP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3325A60", Offset = "0x3324C60", VA = "0x183325A60")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x3325AA0", Offset = "0x3324CA0", VA = "0x183325AA0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, FAPMHGNPHBA, byte[]> ONIGDAJHIKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, FAPMHGNPHBA> HOJAJOKCLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly BMOIAFNKGEL NMHOEMBKKBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, FAPMHGNPHBA, ArraySegment<byte>> AENGAJDKABD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, FAPMHGNPHBA, string> GLMEONMBADM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, FAPMHGNPHBA, object> OKHGDGPIEGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, FAPMHGNPHBA, object> BPILHBDJJKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, FAPMHGNPHBA, object> JGPFDMLNDLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly ADMCONHCFCP HAGLBCEIBEO;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3311300", Offset = "0x3310500", VA = "0x183311300")]
			public FDIMJMLJJGM(Type OMCCJKNHBML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1E4B500", Offset = "0x1E4A700", VA = "0x181E4B500")]
			private static T HNGHCNICCCH<T>(DynamicMethod OHFLHPLDNKG)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3311110", Offset = "0x3310310", VA = "0x183311110")]
			private static MethodInfo COHGMMMHNNF(Type OMCCJKNHBML, string OJIMLEPHDJI, Type[] IDAPEEEKEMC)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, FDIMJMLJJGM> LIHMEGPHDPH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::EDNNPJMGCPM<FDIMJMLJJGM> LDGGDIHAGOG;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3320600", Offset = "0x331F800", VA = "0x183320600")]
		static ICCLMICAEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3320300", Offset = "0x331F500", VA = "0x183320300")]
		private static FDIMJMLJJGM KEJLDCNKCHA(Type OMCCJKNHBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3320490", Offset = "0x331F690", VA = "0x183320490")]
		public static void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3320380", Offset = "0x331F580", VA = "0x183320380")]
		public static void NOCAHNNOEGM(Type OMCCJKNHBML, ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class HFMKEGHLPFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] ODGBLHHLGCK;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x331FD20", Offset = "0x331EF20", VA = "0x18331FD20")]
		public static byte[] LCBFKEIBEFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FAPMHGNPHBA CDCFIENCKOI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] IFIKLIJKLAA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] OJHCIJMAHNN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FAPMHGNPHBA NHCKBCKBCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3323E20", Offset = "0x3323020", VA = "0x183323E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3323F30", Offset = "0x3323130", VA = "0x183323F30")]
	public static void OGJIBMAGMNH(FAPMHGNPHBA JPCLGONAHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBAB0", Offset = "0x3ABACB0", VA = "0x183ABBAB0")]
	public static string HHCGGPHLFGO<T>(T EOEMKDLOAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB30", Offset = "0x3ABAD30", VA = "0x183ABBB30")]
	public static string HHCGGPHLFGO<T>(T EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D670", Offset = "0x1E4C870", VA = "0x181E4D670")]
	public static T KOBBCLPENCC<T>(string JIECCACEDJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D5A0", Offset = "0x1E4C7A0", VA = "0x181E4D5A0")]
	public static T KOBBCLPENCC<T>(string JIECCACEDJG, FAPMHGNPHBA JPCLGONAHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D520", Offset = "0x1E4C720", VA = "0x181E4D520")]
	public static T KOBBCLPENCC<T>(byte[] GMBNEFEOHLO, FAPMHGNPHBA JPCLGONAHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D3D0", Offset = "0x1E4C5D0", VA = "0x181E4D3D0")]
	public static T KOBBCLPENCC<T>(byte[] GMBNEFEOHLO, int KPMCEIEAINM, FAPMHGNPHBA JPCLGONAHME)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NAOCCJBCPFM : byte
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
public struct ENIPHNEFEPK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] IFGCEODPPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] ODGBLHHLGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KPMCEIEAINM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PFHEMOMBCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D34A0", Offset = "0x7D26A0", VA = "0x1807D34A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x30903D0", Offset = "0x308F5D0", VA = "0x1830903D0")]
	public void MDHFPAEIAJB(int KPMCEIEAINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x308FF80", Offset = "0x308F180", VA = "0x18308FF80")]
	public static byte[] FDOBFFPFCKP(string LBDKOOIPDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x30903E0", Offset = "0x308F5E0", VA = "0x1830903E0")]
	public static byte[] MFDJKHPJJMG(string LBDKOOIPDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3090070", Offset = "0x308F270", VA = "0x183090070")]
	public static byte[] IJBMEHBAJOA(string LBDKOOIPDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3090C10", Offset = "0x308FE10", VA = "0x183090C10")]
	public static byte[] PJNFFMFLKBO(string LBDKOOIPDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCA3920", Offset = "0xCA2B20", VA = "0x180CA3920")]
	public ENIPHNEFEPK(byte[] MEOAKLLCJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x30901D0", Offset = "0x308F3D0", VA = "0x1830901D0")]
	public ArraySegment<byte> LCBFKEIBEFK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3090D70", Offset = "0x308FF70", VA = "0x183090D70")]
	public byte[] PKCIMEHKJJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3090F20", Offset = "0x3090120", VA = "0x183090F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3090030", Offset = "0x308F230", VA = "0x183090030")]
	public void HABMFGBOHHL(int NFEINLAHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3090EC0", Offset = "0x30900C0", VA = "0x183090EC0")]
	public void PLCHOBONKLG(byte[] GICJHCNLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x308FF40", Offset = "0x308F140", VA = "0x18308FF40")]
	public void EMEKMODHINM(byte GICJHCNLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x308FBB0", Offset = "0x308EDB0", VA = "0x18308FBB0")]
	public void AFDJEOILKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3090970", Offset = "0x308FB70", VA = "0x183090970")]
	public void OEHIBOHDHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x308FEF0", Offset = "0x308F0F0", VA = "0x18308FEF0")]
	public void EHLLEBDHFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3090920", Offset = "0x308FB20", VA = "0x183090920")]
	public void NKNHCGPOKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3090500", Offset = "0x308F700", VA = "0x183090500")]
	public void NFFFBHEPKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30904B0", Offset = "0x308F6B0", VA = "0x1830904B0")]
	public void MGDKHPEMKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x30909C0", Offset = "0x308FBC0", VA = "0x1830909C0")]
	public void OJKFGAKHOLJ(string LBDKOOIPDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x308FEA0", Offset = "0x308F0A0", VA = "0x18308FEA0")]
	public void EALBBIONONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x308FC00", Offset = "0x308EE00", VA = "0x18308FC00")]
	public void AODJHKMKLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3090A20", Offset = "0x308FC20", VA = "0x183090A20")]
	public void PJCNICDKFLP(bool EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3090280", Offset = "0x308F480", VA = "0x183090280")]
	public void MBDPNOJDEHK(float EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x308FD60", Offset = "0x308EF60", VA = "0x18308FD60")]
	public void DNKKGCBPKIE(double EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3090000", Offset = "0x308F200", VA = "0x183090000")]
	public void GBDJDGMDCJF(byte EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3090170", Offset = "0x308F370", VA = "0x183090170")]
	public void JLCIKJIMJJH(ushort EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3090040", Offset = "0x308F240", VA = "0x183090040")]
	public void HNIBCAMPFOH(uint EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x308FCD0", Offset = "0x308EED0", VA = "0x18308FCD0")]
	public void CDJJCOLNGKC(ulong EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x308FD00", Offset = "0x308EF00", VA = "0x18308FD00")]
	public void CMFMNBFGHPA(sbyte EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3090140", Offset = "0x308F340", VA = "0x183090140")]
	public void JJDMHLCOLOO(short EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x308FD30", Offset = "0x308EF30", VA = "0x18308FD30")]
	public void DJGHIECHMOP(int EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x30901A0", Offset = "0x308F3A0", VA = "0x1830901A0")]
	public void KDNCBMEJDOH(long EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3090550", Offset = "0x308F750", VA = "0x183090550")]
	public void NJEKPAIDOKB(string EOEMKDLOAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LKBHKHEFEDH : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class BDOJBLJABOO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2793E50", Offset = "0x2793050", VA = "0x182793E50")]
		static BDOJBLJABOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private LKBHKHEFEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class CHONEBMBEEG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> IHEKJNIBKGF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3089D20", Offset = "0x3088F20", VA = "0x183089D20")]
	static CHONEBMBEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x30897C0", Offset = "0x30889C0", VA = "0x1830897C0")]
	internal static object OEICOLMJCFO(Type PAHPKCDHOGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FKPLLDACCEP : global::ANGGPBBBOPJ<Vector2>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3096E10", Offset = "0x3096010", VA = "0x183096E10")]
	public FKPLLDACCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3096CA0", Offset = "0x3095EA0", VA = "0x183096CA0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Vector2 EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3096A00", Offset = "0x3095C00", VA = "0x183096A00", Slot = "5")]
	public Vector2 KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MCLLMOBBLOF : global::ANGGPBBBOPJ<Vector3>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4A33B30", Offset = "0x4A32D30", VA = "0x184A33B30")]
	public MCLLMOBBLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4A33A10", Offset = "0x4A32C10", VA = "0x184A33A10", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Vector3 EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A33820", Offset = "0x4A32A20", VA = "0x184A33820", Slot = "5")]
	public Vector3 KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ADHAEAELMEP : global::ANGGPBBBOPJ<Vector4>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3082C90", Offset = "0x3081E90", VA = "0x183082C90")]
	public ADHAEAELMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3082A20", Offset = "0x3081C20", VA = "0x183082A20", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Vector4 EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x30826E0", Offset = "0x30818E0", VA = "0x1830826E0", Slot = "5")]
	public Vector4 KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DAJAFEJIANN : global::ANGGPBBBOPJ<Quaternion>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x308CFD0", Offset = "0x308C1D0", VA = "0x18308CFD0")]
	public DAJAFEJIANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3082A20", Offset = "0x3081C20", VA = "0x183082A20", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Quaternion EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x308CC90", Offset = "0x308BE90", VA = "0x18308CC90", Slot = "5")]
	public Quaternion KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KLFAHLMHNNH : global::ANGGPBBBOPJ<Color>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A2EBC0", Offset = "0x4A2DDC0", VA = "0x184A2EBC0")]
	public KLFAHLMHNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4A2EA70", Offset = "0x4A2DC70", VA = "0x184A2EA70", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Color EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E840", Offset = "0x4A2DA40", VA = "0x184A2E840", Slot = "5")]
	public Color KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GFLGLFPJPIL : global::ANGGPBBBOPJ<Bounds>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x331E0D0", Offset = "0x331D2D0", VA = "0x18331E0D0")]
	public GFLGLFPJPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x331DE60", Offset = "0x331D060", VA = "0x18331DE60", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Bounds EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x331DB60", Offset = "0x331CD60", VA = "0x18331DB60", Slot = "5")]
	public Bounds KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FGKLIDCKAIH : global::ANGGPBBBOPJ<Rect>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FOCBCONPBGM GKHELMFEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] MCCIKDKGDOM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3095E00", Offset = "0x3095000", VA = "0x183095E00")]
	public FGKLIDCKAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3095B70", Offset = "0x3094D70", VA = "0x183095B70", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Rect EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3095800", Offset = "0x3094A00", VA = "0x183095800", Slot = "5")]
	public Rect KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MLHIOFKCAAG : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class DHADHAHEBEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EC66D0", Offset = "0x3EC58D0", VA = "0x183EC66D0")]
		static DHADHAHEBEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private MLHIOFKCAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class COPOMFKLEHC : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class GHFBOCKLDDA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3051FB0", Offset = "0x30511B0", VA = "0x183051FB0")]
		static GHFBOCKLDDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GDOMOMLIDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> LMLKKNNIKCJ;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3099FC0", Offset = "0x30991C0", VA = "0x183099FC0")]
		internal static object OEICOLMJCFO(Type PAHPKCDHOGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private COPOMFKLEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class NEJHADEFFJF : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LCAHLPFOCFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x32709A0", Offset = "0x326FBA0", VA = "0x1832709A0")]
		static LCAHLPFOCFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NEJHADEFFJF AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool GHEGAFFEIIM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BNLFGEJDIDK[] JNLEPENCELP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static FAPMHGNPHBA[] NHDAIFKAACO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private NEJHADEFFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A362C0", Offset = "0x4A354C0", VA = "0x184A362C0")]
	public static void ABJIMAALACO(params FAPMHGNPHBA[] NHDAIFKAACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A36380", Offset = "0x4A35580", VA = "0x184A36380")]
	public static void ABJIMAALACO(params BNLFGEJDIDK[] JNLEPENCELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A36440", Offset = "0x4A35640", VA = "0x184A36440")]
	public static void JNGMLCPOOAP(BNLFGEJDIDK[] JNLEPENCELP, FAPMHGNPHBA[] NHDAIFKAACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FHLEMPMAALF : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class LHJEDADPMFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B960", Offset = "0x3B9AB60", VA = "0x183B9B960")]
		static LHJEDADPMFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private FHLEMPMAALF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FNIBBOFLEJI
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FAPMHGNPHBA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly FAPMHGNPHBA GEPLNOPOBMK;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FAPMHGNPHBA OAPDFJCNPNK;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FAPMHGNPHBA JCIMINOJCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly FAPMHGNPHBA GGDPLEFLHGP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FAPMHGNPHBA CDOALCCMKMK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FAPMHGNPHBA AJLDMENJALD;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FAPMHGNPHBA HCOLKHNEEGP;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FAPMHGNPHBA HPAOCIINEFL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FAPMHGNPHBA NCCAOJJEPNF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FAPMHGNPHBA NBBJCAEHENH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FAPMHGNPHBA GEBMBKFJDIN;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DAAAPABDPDA
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FAPMHGNPHBA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FAPMHGNPHBA BMKLMAFIFKL;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MBBFINFHJDB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly FAPMHGNPHBA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FAPMHGNPHBA GEPLNOPOBMK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly FAPMHGNPHBA OAPDFJCNPNK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FAPMHGNPHBA JCIMINOJCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly FAPMHGNPHBA GGDPLEFLHGP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly FAPMHGNPHBA CDOALCCMKMK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly FAPMHGNPHBA AJLDMENJALD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly FAPMHGNPHBA HCOLKHNEEGP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly FAPMHGNPHBA HPAOCIINEFL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FAPMHGNPHBA NCCAOJJEPNF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly FAPMHGNPHBA NBBJCAEHENH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly FAPMHGNPHBA GEBMBKFJDIN;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class MKNFMDGNDEE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> LMLKKNNIKCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A34030", Offset = "0x4A33230", VA = "0x184A34030")]
	internal static object OEICOLMJCFO(Type PAHPKCDHOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A33FF0", Offset = "0x4A331F0", VA = "0x184A33FF0")]
	private static object MFEBIOPLGNH(Type KNBOIACFDAO, Type[] LDHMPJNBCLC, params object[] IDAPEEEKEMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MPOIFHNHEMA : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class HHGPFGMBJAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0230", Offset = "0x3ECF430", VA = "0x183ED0230")]
		static HHGPFGMBJAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4A35E80", Offset = "0x4A35080", VA = "0x184A35E80")]
	static MPOIFHNHEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private MPOIFHNHEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class BKFGEECJGFL : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class ECJEFCBIHGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7CF0", Offset = "0x2DC6EF0", VA = "0x182DC7CF0")]
		static ECJEFCBIHGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3085F60", Offset = "0x3085160", VA = "0x183085F60")]
	static BKFGEECJGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private BKFGEECJGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PBIGENKHNPA : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class GJHFIKAEGFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x355E820", Offset = "0x355DA20", VA = "0x18355E820")]
		static GJHFIKAEGFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A790", Offset = "0x4A39990", VA = "0x184A3A790")]
	static PBIGENKHNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private PBIGENKHNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ADPKKJGHFIG : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class BOJHNNJLJJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AC00", Offset = "0x3A29E00", VA = "0x183A2AC00")]
		static BOJHNNJLJJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3082F80", Offset = "0x3082180", VA = "0x183082F80")]
	static ADPKKJGHFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private ADPKKJGHFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class BIEIDHIKHFE : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class AOBOCINABOE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DB87C0", Offset = "0x2DB79C0", VA = "0x182DB87C0")]
		static AOBOCINABOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3085DC0", Offset = "0x3084FC0", VA = "0x183085DC0")]
	static BIEIDHIKHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private BIEIDHIKHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class JFIJGHNOFBF : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class FHONPONMDPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1D57FF0", Offset = "0x1D571F0", VA = "0x181D57FF0")]
		static FHONPONMDPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly LEMCGBEMEHI OCBDIEGMHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x33256F0", Offset = "0x33248F0", VA = "0x1833256F0")]
	static JFIJGHNOFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private JFIJGHNOFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class IBBJJEADNND : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class IOKHFEPPKCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x363CAA0", Offset = "0x363BCA0", VA = "0x18363CAA0")]
		static IOKHFEPPKCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public IBBJJEADNND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class BIGDGPPPELL : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class GBDKNAGCKHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2DCEA20", Offset = "0x2DCDC20", VA = "0x182DCEA20")]
		static GBDKNAGCKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BIGDGPPPELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JBALKDCNBAL : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class DNHKKFAMJKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D55650", Offset = "0x1D54850", VA = "0x181D55650")]
		static DNHKKFAMJKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public JBALKDCNBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class PDODPMALCCK : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class BKONILJDEOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3556DA0", Offset = "0x3555FA0", VA = "0x183556DA0")]
		static BKONILJDEOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PDODPMALCCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LAOHEJDKLFA : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KOKGMDCKEBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2798A70", Offset = "0x2797C70", VA = "0x182798A70")]
		static KOKGMDCKEBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public LAOHEJDKLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class FELCFLLOLAG : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class PKHGEKCJJCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x389A040", Offset = "0x3899240", VA = "0x18389A040")]
		static PKHGEKCJJCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> AAOFDFNLCGM;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool EPNOCFFHBPG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public FELCFLLOLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class FNNLDPHEDJF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HGOMBFIJPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FBHLLOJEBCK GAOFLPIIEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder AADFLJBLADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder EHGNEBAEOOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class NKBEKDDDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class INEOOALKEON
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo IJBMEHBAJOA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo MFDJKHPJJMG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo PJNFFMFLKBO;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo FDOBFFPFCKP;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo AODJHKMKLIL;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PLCHOBONKLG;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo EHLLEBDHFCA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo NKNHCGPOKOI;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo NFFFBHEPKPO;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x33217E0", Offset = "0x33209E0", VA = "0x1833217E0")]
			static INEOOALKEON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class BFCPHAELLMO
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo KLGKHPMMJJP;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo EBLHONIPGNJ;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo AKMPMMLJFDH;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo LPAPJHLGOCI;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo HGGLGFHJLGI;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo GALDHDGLLGN;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NEKPEJLJLMN;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x330FF50", Offset = "0x330F150", VA = "0x18330FF50")]
			static BFCPHAELLMO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class EABHCGNMKJE
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo LAFMJLPHICJ;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo GDEKFFNCNCF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo CBIMMKMOBPB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo IEPAELEDCHK;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo FKGIOCGAKHF;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo BOFMDEINCMH;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo HEKLDAAKBKO;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo FGAHFMCDBHK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo FPEOBAKLDLH;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo DKJFNBCIHPI;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo OLMHLOPECKK;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo JEGBHGKGPKP;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FDCOBHCAOEJ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo EGDBNHHGEOO;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3325ED0", Offset = "0x33250D0", VA = "0x183325ED0")]
		public static MethodInfo NOCAHNNOEGM(Type OMCCJKNHBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3325CA0", Offset = "0x3324EA0", VA = "0x183325CA0")]
		public static MethodInfo KOBBCLPENCC(Type OMCCJKNHBML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3326160", Offset = "0x3325360", VA = "0x183326160")]
		public static MethodInfo PELFELCLMJA(Type OMCCJKNHBML)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IOBMAMOPALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<FBHLLOJEBCK, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public IOBMAMOPALP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LBHAMAEMELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public IOBMAMOPALP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public LBHAMAEMELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3325980", Offset = "0x3324B80", VA = "0x183325980")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x33259C0", Offset = "0x3324BC0", VA = "0x1833259C0")]
		internal bool <BuildType>b__2(int index, FBHLLOJEBCK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AHEHMFGNFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IOBMAMOPALP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public AHEHMFGNFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x330FE50", Offset = "0x330F050", VA = "0x18330FE50")]
		internal bool <BuildType>b__3(int index, FBHLLOJEBCK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BDCLDABCECC
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
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public BDCLDABCECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x330FEF0", Offset = "0x330F0F0", VA = "0x18330FEF0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CHLGBMDHLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public CHLGBMDHLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3310D70", Offset = "0x330FF70", VA = "0x183310D70")]
		internal bool <BuildAnonymousFormatter>b__2(FBHLLOJEBCK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class ACLKFDDIMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BDCLDABCECC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public ACLKFDDIMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x330F870", Offset = "0x330EA70", VA = "0x18330F870")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x330F880", Offset = "0x330EA80", VA = "0x18330F880")]
		internal bool <BuildAnonymousFormatter>b__6(int index, FBHLLOJEBCK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JLHDPGLJHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BDCLDABCECC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public JLHDPGLJHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x33257E0", Offset = "0x33249E0", VA = "0x1833257E0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, FBHLLOJEBCK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LGPKKKAKNPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public LGPKKKAKNPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x52FCC0", Offset = "0x52EEC0", VA = "0x18052FCC0")]
		internal Label <BuildSerialize>b__1(FBHLLOJEBCK _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class IMDCIGPBGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HGOMBFIJPCF[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, FBHLLOJEBCK, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JOOFALBJEMJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public JOOFALBJEMJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public IMDCIGPBGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x33216B0", Offset = "0x33208B0", VA = "0x1833216B0")]
		internal HGOMBFIJPCF <BuildDeserialize>b__0(FBHLLOJEBCK item)
		{
			return default(HGOMBFIJPCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GDMNLMHHJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IMDCIGPBGDK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public GDMNLMHHJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x331D5A0", Offset = "0x331C7A0", VA = "0x18331D5A0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x331D850", Offset = "0x331CA50", VA = "0x18331D850")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LPJPIHEJBAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FBHLLOJEBCK item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public LPJPIHEJBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x19BDC10", Offset = "0x19BCE10", VA = "0x1819BDC10")]
		internal bool <EmitNewObject>b__0(HGOMBFIJPCF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DIIINGDKKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FBHLLOJEBCK item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public DIIINGDKKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x19BDC10", Offset = "0x19BCE10", VA = "0x1819BDC10")]
		internal bool <EmitNewObject>b__2(HGOMBFIJPCF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex CGDKCPKKCGH;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KGBFPBGHCJI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GIAOIBCBJKA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NKAFOADOGLP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6E30", Offset = "0x3AB6030", VA = "0x183AB6E30")]
	public static object PPLPFDHGHKD<T>(LEMCGBEMEHI OCBDIEGMHLJ, FAPMHGNPHBA HLJJPMHNIOB, Func<string, string> AAOFDFNLCGM, bool EPNOCFFHBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC320", Offset = "0x3AAB520", VA = "0x183AAC320")]
	public static object GNMMLHDHLJP<T>(FAPMHGNPHBA HLJJPMHNIOB, Func<string, string> AAOFDFNLCGM, bool EPNOCFFHBPG, bool MBNAFODKDIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33171C0", Offset = "0x33163C0", VA = "0x1833171C0")]
	private static TypeInfo EKJBBDLOJBK(LEMCGBEMEHI OCBDIEGMHLJ, Type OMCCJKNHBML, Func<string, string> AAOFDFNLCGM, bool EPNOCFFHBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3317C60", Offset = "0x3316E60", VA = "0x183317C60")]
	public static object FADMPEIEAID(Type OMCCJKNHBML, Func<string, string> AAOFDFNLCGM, bool EPNOCFFHBPG, bool MBNAFODKDIO, bool FALGKMOBDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3319B60", Offset = "0x3318D60", VA = "0x183319B60")]
	private static Dictionary<FBHLLOJEBCK, FieldInfo> HBLEKABNHOD(TypeBuilder FIAFHHEJNEI, NFIKJCCFCBP GPLDLIFCHLE, ConstructorInfo JIJOLLBGIHH, FieldBuilder MFDLFPBBLEK, ILGenerator PGFJIKIMDKA, bool EPNOCFFHBPG, bool NOKGOELBOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x33195A0", Offset = "0x33187A0", VA = "0x1833195A0")]
	private static Dictionary<FBHLLOJEBCK, FieldInfo> FOGHPGEMKPC(TypeBuilder FIAFHHEJNEI, NFIKJCCFCBP GPLDLIFCHLE, ILGenerator PGFJIKIMDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3315C60", Offset = "0x3314E60", VA = "0x183315C60")]
	private static void EJHCCACMMDM(Type OMCCJKNHBML, NFIKJCCFCBP GPLDLIFCHLE, ILGenerator PGFJIKIMDKA, Action BMAGDMLCNGP, Func<int, FBHLLOJEBCK, bool> PMHOGBAJAOF, bool EPNOCFFHBPG, bool NOKGOELBOHN, int PEBOHDNHPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x331A350", Offset = "0x3319550", VA = "0x18331A350")]
	private static void MONJGHLDKAO(TypeInfo OMCCJKNHBML, FBHLLOJEBCK ICDCPGHBCBO, ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG, Func<int, FBHLLOJEBCK, bool> PMHOGBAJAOF, JOOFALBJEMJ NJHDOODAJCH, JOOFALBJEMJ EACNEENNMGD, JOOFALBJEMJ GDPCCFEEKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3313D40", Offset = "0x3312F40", VA = "0x183313D40")]
	private static void DOFIMKHPFCI(Type OMCCJKNHBML, NFIKJCCFCBP GPLDLIFCHLE, ILGenerator PGFJIKIMDKA, Func<int, FBHLLOJEBCK, bool> PMHOGBAJAOF, bool CMDAEDMHAAN, int PEBOHDNHPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3313930", Offset = "0x3312B30", VA = "0x183313930")]
	private static void DNNKKDIOKBL(ILGenerator PGFJIKIMDKA, HGOMBFIJPCF GPLDLIFCHLE, int NCBDKCDKIIG, Func<int, FBHLLOJEBCK, bool> PMHOGBAJAOF, JOOFALBJEMJ GIFABBPOCAN, JOOFALBJEMJ GDPCCFEEKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3314FF0", Offset = "0x33141F0", VA = "0x183314FF0")]
	private static LocalBuilder ECHOEABECPD(ILGenerator PGFJIKIMDKA, Type OMCCJKNHBML, NFIKJCCFCBP GPLDLIFCHLE, HGOMBFIJPCF[] EEGGEHJJNAP, bool MDEHNFJKDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3313260", Offset = "0x3312460", VA = "0x183313260")]
	private static bool DGALFDNFPAC(ConstructorInfo KLGONGNDCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x331A1B0", Offset = "0x33193B0", VA = "0x18331A1B0")]
	private static bool JAEGPNGMOKL(Type OMCCJKNHBML, out Type INMCAKDAKHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void AFNDFMCGEOJ<T>(byte[][] MFDLFPBBLEK, object[] NLJDFAGAPOI, ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA JPCLGONAHME);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T EJLNKBOJFGA<T>(object[] NLJDFAGAPOI, ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA JPCLGONAHME);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class LKHNGMNOAAI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class NGPJKHJBKDM : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class JBIMHIPBLBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x325F310", Offset = "0x325E510", VA = "0x18325F310")]
		static JBIMHIPBLBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private NGPJKHJBKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class FDAOMCDOMKK : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class BIDDJJABAAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3880D80", Offset = "0x387FF80", VA = "0x183880D80")]
		static BIDDJJABAAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private FDAOMCDOMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class MMLKHAFDNOF
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly FAPMHGNPHBA[] NGHEMINCACC;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DIOFJDIAELB : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class BKDNJDIFJKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2D39520", Offset = "0x2D38720", VA = "0x182D39520")]
		static BKDNJDIFJKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class HOAKFIHFOOM : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class KKACBJGLGGO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2D4B120", Offset = "0x2D4A320", VA = "0x182D4B120")]
			static KKACBJGLGGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private HOAKFIHFOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private DIOFJDIAELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class FCKDMIOJLMC : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class OCMNEPBHLAJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x38930E0", Offset = "0x38922E0", VA = "0x1838930E0")]
		static OCMNEPBHLAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class KAOINDLHLIA : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class GFPJDIKBNNP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x38906F0", Offset = "0x388F8F0", VA = "0x1838906F0")]
			static GFPJDIKBNNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private KAOINDLHLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private FCKDMIOJLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class DBOPCLCCCNG : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class NIMAEGOPGHN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2D51F40", Offset = "0x2D51140", VA = "0x182D51F40")]
		static NIMAEGOPGHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class ICKCAPEPNEL : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class NEKGAICHLEP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2D4D570", Offset = "0x2D4C770", VA = "0x182D4D570")]
			static NEKGAICHLEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private ICKCAPEPNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private DBOPCLCCCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class AMODLLNHNDL : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class AMGOCFPAHMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x37D0E00", Offset = "0x37D0000", VA = "0x1837D0E00")]
		static AMGOCFPAHMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class FEIOEKIDPIK : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class JDPNAPPLGDN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x37DAC90", Offset = "0x37D9E90", VA = "0x1837DAC90")]
			static JDPNAPPLGDN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private FEIOEKIDPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private AMODLLNHNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class FABAHLNAPLO : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AFKMFPNHINE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x37E6920", Offset = "0x37E5B20", VA = "0x1837E6920")]
		static AFKMFPNHINE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class BNABMDDAGJK : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class BLFBEFHJBJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x37EC010", Offset = "0x37EB210", VA = "0x1837EC010")]
			static BLFBEFHJBJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private BNABMDDAGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private FABAHLNAPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class MMGJAEMBCEA : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class GMEAAKNEHGB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC0E0", Offset = "0x3ECB2E0", VA = "0x183ECC0E0")]
		static GMEAAKNEHGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class IBGKCCDFCPD : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class PPMDCAGCDOJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3ED8DB0", Offset = "0x3ED7FB0", VA = "0x183ED8DB0")]
			static PPMDCAGCDOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private IBGKCCDFCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private MMGJAEMBCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class BCIDFKILFMC : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class ENEEMCEOPDE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD0E0", Offset = "0x2DCC2E0", VA = "0x182DCD0E0")]
		static ENEEMCEOPDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GHMBBAPMLDJ : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class BGJBFCAJAKK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2680", Offset = "0x2DC1880", VA = "0x182DC2680")]
			static BGJBFCAJAKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private GHMBBAPMLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private BCIDFKILFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class NNEGCGAONCN : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class PLLLOHPPCIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2DEB590", Offset = "0x2DEA790", VA = "0x182DEB590")]
		static PLLLOHPPCIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class AENGNEHOCCD : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class GGAPEGPMLGI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2DE1680", Offset = "0x2DE0880", VA = "0x182DE1680")]
			static GGAPEGPMLGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private AENGNEHOCCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private NNEGCGAONCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class CKBNKKOPFIC : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class OICAINKKGCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x37CB610", Offset = "0x37CA810", VA = "0x1837CB610")]
		static OICAINKKGCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class EBBLBOGKMKB : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class HJEGDNOHPAA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x37C7B20", Offset = "0x37C6D20", VA = "0x1837C7B20")]
			static HJEGDNOHPAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private EBBLBOGKMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private CKBNKKOPFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class CCGFDEBDHCB : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class ODEJIHFDAML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C75510", Offset = "0x3C74710", VA = "0x183C75510")]
		static ODEJIHFDAML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KBDKMPIBFKH : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DPJAMKLGAOD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C69250", Offset = "0x3C68450", VA = "0x183C69250")]
			static DPJAMKLGAOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private KBDKMPIBFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private CCGFDEBDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class AKEBPDKPNPD : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class PJOOFJIPNOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37E2610", Offset = "0x37E1810", VA = "0x1837E2610")]
		static PJOOFJIPNOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class OAEPJBEBKLO : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NOLJMGJAEIJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x37DE190", Offset = "0x37DD390", VA = "0x1837DE190")]
			static NOLJMGJAEIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private OAEPJBEBKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private AKEBPDKPNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class JBEEMDLHODH : FAPMHGNPHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class MKIJAPDBBGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C520", Offset = "0x1D6B720", VA = "0x181D6C520")]
		static MKIJAPDBBGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GGLJFHHCHGP : FAPMHGNPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class MHEEJLLEAFK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::ANGGPBBBOPJ<T> CPGFGKJJIAD;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1D6BDE0", Offset = "0x1D6AFE0", VA = "0x181D6BDE0")]
			static MHEEJLLEAFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly FAPMHGNPHBA AACNHMOEADN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly FAPMHGNPHBA[] NHDAIFKAACO;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		private GGLJFHHCHGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
		public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly FAPMHGNPHBA AACNHMOEADN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::ANGGPBBBOPJ<object> PDLHLNNNJCF;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	private JBEEMDLHODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1CE0", Offset = "0x1EC0EE0", VA = "0x181EC1CE0", Slot = "4")]
	public global::ANGGPBBBOPJ<T> OEICOLMJCFO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct HPLBLCNKEPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] MGLJCKHIMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int GEADDIGJHCF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x23A1040", Offset = "0x23A0240", VA = "0x1823A1040")]
	public HPLBLCNKEPO(int EOFAEIKMNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x23A0DC0", Offset = "0x239FFC0", VA = "0x1823A0DC0")]
	public void JPGLGPDLMNH(T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x23A0C50", Offset = "0x239FE50", VA = "0x1823A0C50")]
	public T[] HJOEPMDKIKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class CHBFFIHMDJJ : global::CCDHAJKAEHE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly CHBFFIHMDJJ NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3088430", Offset = "0x3087630", VA = "0x183088430")]
	public CHBFFIHMDJJ(int BPFEECGHFON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class CCDHAJKAEHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int BPFEECGHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object JPEMDGNLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int NCBDKCDKIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] JDPIACDDOAP;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3C650D0", Offset = "0x3C642D0", VA = "0x183C650D0")]
	public CCDHAJKAEHE(int BPFEECGHFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3C63210", Offset = "0x3C62410", VA = "0x183C63210")]
	public T[] BLFKONEPBFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C64410", Offset = "0x3C63610", VA = "0x183C64410")]
	public void KPCNFLILDKG(T[] ANMIADPHPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FOCBCONPBGM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class JAJGJBODEGC : IComparable<JAJGJBODEGC>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class NNOEJMLKFCJ : IEnumerable<JAJGJBODEGC>, IEnumerable, IEnumerator<JAJGJBODEGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private JAJGJBODEGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public JAJGJBODEGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JAJGJBODEGC System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
			[DebuggerHidden]
			public NNOEJMLKFCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x33276D0", Offset = "0x33268D0", VA = "0x1833276D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3327800", Offset = "0x3326A00", VA = "0x183327800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3327760", Offset = "0x3326960", VA = "0x183327760", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JAJGJBODEGC> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3327760", Offset = "0x3326960", VA = "0x183327760", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class JLLFNJODJLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public JLLFNJODJLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x52FCC0", Offset = "0x52EEC0", VA = "0x18052FCC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x52FCC0", Offset = "0x52EEC0", VA = "0x18052FCC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly JAJGJBODEGC[] BJJFMDEEKEJ;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] DFIKHPMGOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong MHHPHCDMEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int LLFECFNJIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string OPBJIOHLADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private JAJGJBODEGC[] MGPEOPIEEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] GHNNBOHGLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int LMEIKANBNGK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IGEDIDJAMLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA56F20", Offset = "0xA56120", VA = "0x180A56F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x33237C0", Offset = "0x33229C0", VA = "0x1833237C0")]
		public JAJGJBODEGC(ulong FOOEPPOEAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3323220", Offset = "0x3322420", VA = "0x183323220")]
		public JAJGJBODEGC JPGLGPDLMNH(ulong FOOEPPOEAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3323410", Offset = "0x3322610", VA = "0x183323410")]
		public JAJGJBODEGC JPGLGPDLMNH(ulong FOOEPPOEAPA, int EOEMKDLOAGI, string OPBJIOHLADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3323590", Offset = "0x3322790", VA = "0x183323590")]
		public JAJGJBODEGC MLHKEACMBMK(byte[] NMOAGJKPHMO, ref int KPMCEIEAINM, ref int FNLMIDIDDAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x33225C0", Offset = "0x33217C0", VA = "0x1833225C0")]
		internal static int HDMKIGEHDOO(ulong[] ANMIADPHPAJ, int NCBDKCDKIIG, int COAENFJIMCK, ulong EOEMKDLOAGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3322590", Offset = "0x3321790", VA = "0x183322590", Slot = "4")]
		public int CompareTo(JAJGJBODEGC CDPFMCDBFNL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3322520", Offset = "0x3321720", VA = "0x183322520")]
		[IteratorStateMachine(typeof(NNOEJMLKFCJ))]
		public IEnumerable<JAJGJBODEGC> CFAEDOKCLNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3323460", Offset = "0x3322660", VA = "0x183323460")]
		public void MCGALJGEOFK(ILGenerator PGFJIKIMDKA, LocalBuilder NMOAGJKPHMO, LocalBuilder FNLMIDIDDAF, LocalBuilder FOOEPPOEAPA, Action<KeyValuePair<string, int>> GICMBKGGKFB, Action LMELDFCHHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3322640", Offset = "0x3321840", VA = "0x183322640")]
		private static void IGOMLMDDJCB(ILGenerator PGFJIKIMDKA, LocalBuilder NMOAGJKPHMO, LocalBuilder FNLMIDIDDAF, LocalBuilder FOOEPPOEAPA, Action<KeyValuePair<string, int>> GICMBKGGKFB, Action LMELDFCHHMC, JAJGJBODEGC[] MGPEOPIEEEH, int LMEIKANBNGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class PAAINFFIPDP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<JAJGJBODEGC> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<JAJGJBODEGC> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<JAJGJBODEGC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private JAJGJBODEGC <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x528000", Offset = "0x527200", VA = "0x180528000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3327CC0", Offset = "0x3326EC0", VA = "0x183327CC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x956440", Offset = "0x955640", VA = "0x180956440")]
		[DebuggerHidden]
		public PAAINFFIPDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3327D10", Offset = "0x3326F10", VA = "0x183327D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3327850", Offset = "0x3326A50", VA = "0x183327850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3327E10", Offset = "0x3327010", VA = "0x183327E10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3327E60", Offset = "0x3327060", VA = "0x183327E60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3327C70", Offset = "0x3326E70", VA = "0x183327C70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3327BD0", Offset = "0x3326DD0", VA = "0x183327BD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3327BD0", Offset = "0x3326DD0", VA = "0x183327BD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly JAJGJBODEGC AOFPBKDCBAI;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x331B430", Offset = "0x331A630", VA = "0x18331B430")]
	public FOCBCONPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x331B100", Offset = "0x331A300", VA = "0x18331B100")]
	public void JPGLGPDLMNH(byte[] GMBNEFEOHLO, int EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x331B220", Offset = "0x331A420", VA = "0x18331B220")]
	public bool KGNPJPKKPKE(ArraySegment<byte> FOOEPPOEAPA, out int EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x331B340", Offset = "0x331A540", VA = "0x18331B340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x331AE80", Offset = "0x331A080", VA = "0x18331AE80")]
	private static void HGKBFDOHNCL(IEnumerable<JAJGJBODEGC> MGPEOPIEEEH, StringBuilder PDLLIKHCHPF, int LGBNPMIFAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x331AD80", Offset = "0x3319F80", VA = "0x18331AD80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x331AD80", Offset = "0x3319F80", VA = "0x18331AD80", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x331B2D0", Offset = "0x331A4D0", VA = "0x18331B2D0")]
	[IteratorStateMachine(typeof(PAAINFFIPDP))]
	private static IEnumerable<KeyValuePair<string, int>> NPANCIKCDPF(IEnumerable<JAJGJBODEGC> MGPEOPIEEEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x331AD50", Offset = "0x3319F50", VA = "0x18331AD50")]
	public void AJKGAMIMDKB(ILGenerator PGFJIKIMDKA, LocalBuilder NMOAGJKPHMO, LocalBuilder FNLMIDIDDAF, LocalBuilder FOOEPPOEAPA, Action<KeyValuePair<string, int>> GICMBKGGKFB, Action LMELDFCHHMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class DDDDPBOJLPN
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo JAALOGBFOGA;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x308D540", Offset = "0x308C740", VA = "0x18308D540")]
	public static ulong FGNGJBIIEHJ(byte[] GMBNEFEOHLO, ref int KPMCEIEAINM, ref int FNLMIDIDDAF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class AMOKPFAPDLJ
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3083550", Offset = "0x3082750", VA = "0x183083550")]
	public static void HABMFGBOHHL(ref byte[] GMBNEFEOHLO, int KPMCEIEAINM, int NFEINLAHJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3083670", Offset = "0x3082870", VA = "0x183083670")]
	public static void MICALMPDKAJ(ref byte[] ANMIADPHPAJ, int DDANNMMBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3083760", Offset = "0x3082960", VA = "0x183083760")]
	public static byte[] ONFCBOCHDML(byte[] FOOLMFMAHCB, int DDANNMMBAKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class LOGPPPGAGCM
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A32BB0", Offset = "0x4A31DB0", VA = "0x184A32BB0")]
	public static bool HFPOKAFCGJI(byte[] IECBGFKLNEG, int JGJKDKNAMKF, int KLHJDPOFOIB, byte[] IALMIOIPJLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class POIFPFPKEBM<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct BBGECMKHMDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] MHHPHCDMEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T LLFECFNJIDG;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A00", Offset = "0x3D25C00", VA = "0x183D26A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class ADHEJKBCLJB : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::POIFPFPKEBM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private BBGECMKHMDJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private BBGECMKHMDJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFD18A0", Offset = "0xFD0AA0", VA = "0x180FD18A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A5D510", Offset = "0x3A5C710", VA = "0x183A5D510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1BB7B60", Offset = "0x1BB6D60", VA = "0x181BB7B60")]
		[DebuggerHidden]
		public ADHEJKBCLJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D05E80", Offset = "0x3D05080", VA = "0x183D05E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D06AC0", Offset = "0x3D05CC0", VA = "0x183D06AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BBGECMKHMDJ[][] COGDGJGKILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong BCGDPOBOPJL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D35300", Offset = "0x3D34500", VA = "0x183D35300")]
	public POIFPFPKEBM(int FMBBHGJJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3D35330", Offset = "0x3D34530", VA = "0x183D35330")]
	public POIFPFPKEBM(int FMBBHGJJFDP, float FKNBPKNIFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D34A50", Offset = "0x3D33C50", VA = "0x183D34A50")]
	public void JPGLGPDLMNH(byte[] FOOEPPOEAPA, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D30870", Offset = "0x3D2FA70", VA = "0x183D30870")]
	private bool IMKKKKFCIOP(byte[] FOOEPPOEAPA, T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DB40", Offset = "0x3D2CD40", VA = "0x183D2DB40")]
	public bool CMEBCMBDPDA(ArraySegment<byte> FOOEPPOEAPA, out T EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DEB0", Offset = "0x3D2D0B0", VA = "0x183D2DEB0")]
	private static ulong DHMBMDNGBHM(byte[] GGMEAHKJCJC, int KPMCEIEAINM, int LMEIKANBNGK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3CB81F0", Offset = "0x3CB73F0", VA = "0x183CB81F0")]
	private static int NFFMECGDPHC(int BEMKKPBBGBK, float FKNBPKNIFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DF10", Offset = "0x3D2D110", VA = "0x183D2DF10", Slot = "4")]
	[IteratorStateMachine(typeof(global::POIFPFPKEBM<>.ADHEJKBCLJB))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1BC0CA0", Offset = "0x1BBFEA0", VA = "0x181BC0CA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class BBOAHOGPEHF : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] JJKGPJLGHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] EOJPEICGDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int GMHHBNIPMIB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NHEOLDJMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3083BF0", Offset = "0x3082DF0", VA = "0x183083BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3083D50", Offset = "0x3082F50", VA = "0x183083D50")]
	static BBOAHOGPEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3083FA0", Offset = "0x30831A0", VA = "0x183083FA0")]
	public BBOAHOGPEHF(byte[] AHMCHGDIIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3083C40", Offset = "0x3082E40", VA = "0x183083C40")]
	public OpCode EELLDDKHOII()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct FONFNPGOAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid LLFECFNJIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte ELBJIKJNFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte CIOKFAINKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte HAALNAOIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte FJPDEIPBLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte KBDECIEHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JMOHJBJJEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte ANEOPOLGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KBFNEJKCLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte KLPNDDPPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte MNFIDLCHFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte GKHNBIKLKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte IKIHDPEFMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte CGMOKKLDMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte HBCJADLHFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GLKABHMALGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte GHNMCICOJKN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] KEGGECGPGKA;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] CFFKDMCFGDE;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x331CA60", Offset = "0x331BC60", VA = "0x18331CA60")]
	public FONFNPGOAIP(ref Guid EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x331CA70", Offset = "0x331BC70", VA = "0x18331CA70")]
	public FONFNPGOAIP(ref ArraySegment<byte> GHJJEIICHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x331C8F0", Offset = "0x331BAF0", VA = "0x18331C8F0")]
	private static byte PGHKANMCDAB(byte[] GMBNEFEOHLO, int FEAGDLNAPOI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x331C7E0", Offset = "0x331B9E0", VA = "0x18331C7E0")]
	private static byte MHLCJPAIFDA(byte DCOPGELFIOF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x331B4A0", Offset = "0x331A6A0", VA = "0x18331B4A0")]
	public void GDHBKGDCJKH(byte[] ODGBLHHLGCK, int KPMCEIEAINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class FAOHJHOKOJP
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3093B70", Offset = "0x3092D70", VA = "0x183093B70")]
	public static bool GDMBFOOJNEK(byte DFLGAKHACHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3093B80", Offset = "0x3092D80", VA = "0x183093B80")]
	public static bool GNGHHIOEHHL(byte DFLGAKHACHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3094980", Offset = "0x3093B80", VA = "0x183094980")]
	public static sbyte KHMOFHBJMMC(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3094A70", Offset = "0x3093C70", VA = "0x183094A70")]
	public static short LADAEEFLILC(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3093CD0", Offset = "0x3092ED0", VA = "0x183093CD0")]
	public static int JEPFPJPPBGE(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3093280", Offset = "0x3092480", VA = "0x183093280")]
	public static long APPLOIJHENF(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3093B00", Offset = "0x3092D00", VA = "0x183093B00")]
	public static byte CGBDBKGOJEE(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3093C60", Offset = "0x3092E60", VA = "0x183093C60")]
	public static ushort JCBGEABOHDE(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x30949F0", Offset = "0x3093BF0", VA = "0x1830949F0")]
	public static uint LABELGGKJOD(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3094D30", Offset = "0x3093F30", VA = "0x183094D30")]
	public static ulong OBKLAOBKLDG(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3093210", Offset = "0x3092410", VA = "0x183093210")]
	public static float ADLOMPCGLEA(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3093BF0", Offset = "0x3092DF0", VA = "0x183093BF0")]
	public static double HABCJEFFPPG(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3093330", Offset = "0x3092530", VA = "0x183093330")]
	public static int CDJJCOLNGKC(ref byte[] ODGBLHHLGCK, int KPMCEIEAINM, ulong EOEMKDLOAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3093D40", Offset = "0x3092F40", VA = "0x183093D40")]
	public static int KDNCBMEJDOH(ref byte[] ODGBLHHLGCK, int KPMCEIEAINM, long EOEMKDLOAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3094AE0", Offset = "0x3093CE0", VA = "0x183094AE0")]
	public static bool NCDNHOFIPFK(byte[] GMBNEFEOHLO, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class BDFFNNGHKGP
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class JDIGIKFHCDM : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public JDIGIKFHCDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x309C060", Offset = "0x309B260", VA = "0x18309C060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x309BC00", Offset = "0x309AE00", VA = "0x18309BC00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x309C180", Offset = "0x309B380", VA = "0x18309C180")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x309C1D0", Offset = "0x309B3D0", VA = "0x18309C1D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x309C010", Offset = "0x309B210", VA = "0x18309C010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x309BF60", Offset = "0x309B160", VA = "0x18309BF60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x309BF60", Offset = "0x309B160", VA = "0x18309BF60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PGJIDDJHIKN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6383E0", Offset = "0x6375E0", VA = "0x1806383E0")]
		[DebuggerHidden]
		public PGJIDDJHIKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x309CB00", Offset = "0x309BD00", VA = "0x18309CB00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x309C6A0", Offset = "0x309B8A0", VA = "0x18309C6A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x309CC20", Offset = "0x309BE20", VA = "0x18309CC20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x309CC70", Offset = "0x309BE70", VA = "0x18309CC70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x309CAB0", Offset = "0x309BCB0", VA = "0x18309CAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x309CA00", Offset = "0x309BC00", VA = "0x18309CA00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x309CA00", Offset = "0x309BC00", VA = "0x18309CA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3084250", Offset = "0x3083450", VA = "0x183084250")]
	public static bool CMIHNIPJFIM(this TypeInfo OMCCJKNHBML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3084420", Offset = "0x3083620", VA = "0x183084420")]
	public static bool PGBCLJEMGFG(this TypeInfo OMCCJKNHBML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x30841F0", Offset = "0x30833F0", VA = "0x1830841F0")]
	public static IEnumerable<PropertyInfo> CGNGAMOKBNI(this Type OMCCJKNHBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3084390", Offset = "0x3083590", VA = "0x183084390")]
	[IteratorStateMachine(typeof(JDIGIKFHCDM))]
	private static IEnumerable<PropertyInfo> IEMDEADHLCI(Type OMCCJKNHBML, HashSet<string> FMAEMFBGJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3084190", Offset = "0x3083390", VA = "0x183084190")]
	public static IEnumerable<FieldInfo> BMNBDMEOCAG(this Type OMCCJKNHBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3084300", Offset = "0x3083500", VA = "0x183084300")]
	[IteratorStateMachine(typeof(PGJIDDJHIKN))]
	private static IEnumerable<FieldInfo> GECLHOKIGPM(Type OMCCJKNHBML, HashSet<string> FMAEMFBGJIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class JJBCEMHIPFA
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding FIBHPHDKLLD;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class MCIKFDFBCEM
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF60", Offset = "0x5DC160", VA = "0x1805DCF60")]
	public static string NDHKFBDCANL(string GDHCMJKCBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4A33710", Offset = "0x4A32910", VA = "0x184A33710")]
	public static string BIMHJAFJCPG(string GDHCMJKCBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4A33540", Offset = "0x4A32740", VA = "0x184A33540")]
	public static string AOPPGEOKKJC(string GDHCMJKCBDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class EDNNPJMGCPM<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GHKMOEBLLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type MHHPHCDMEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue LLFECFNJIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LEJDNIINBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public GHKMOEBLLJC PHEGDNLHPGL;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBF30", Offset = "0x3CBB130", VA = "0x183CBBF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBC90", Offset = "0x3CBAE90", VA = "0x183CBBC90")]
		private int OJDAKNNCCNA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public GHKMOEBLLJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class DPBOEBDMKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public DPBOEBDMKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85B4E0", Offset = "0x85A6E0", VA = "0x18085B4E0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private GHKMOEBLLJC[] COGDGJGKILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int AADFONHDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object MLPJCOCAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float FKNBPKNIFFD;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8340", Offset = "0x3CB7540", VA = "0x183CB8340")]
	public EDNNPJMGCPM(int FMBBHGJJFDP = 4, float FKNBPKNIFFD = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7F90", Offset = "0x3CB7190", VA = "0x183CB7F90")]
	public bool IOKIDCPFCCG(Type FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7E00", Offset = "0x3CB7000", VA = "0x183CB7E00")]
	public bool IOKIDCPFCCG(Type FOOEPPOEAPA, Func<Type, TValue> ANADPEJBJNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7800", Offset = "0x3CB6A00", VA = "0x183CB7800")]
	private bool IMKKKKFCIOP(Type FOOEPPOEAPA, Func<Type, TValue> ANADPEJBJNN, out TValue MGNLIGMKJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7440", Offset = "0x3CB6640", VA = "0x183CB7440")]
	private bool HGFLJCLILFB(GHKMOEBLLJC[] COGDGJGKILE, Type ANGDKDKHNDG, GHKMOEBLLJC AGELBMNNIDN, Func<Type, TValue> ANADPEJBJNN, out TValue MGNLIGMKJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6E00", Offset = "0x3CB6000", VA = "0x183CB6E00")]
	public bool CMEBCMBDPDA(Type FOOEPPOEAPA, out TValue EOEMKDLOAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8150", Offset = "0x3CB7350", VA = "0x183CB8150")]
	public TValue KEJLDCNKCHA(Type FOOEPPOEAPA, Func<Type, TValue> ANADPEJBJNN)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB81F0", Offset = "0x3CB73F0", VA = "0x183CB81F0")]
	private static int NFFMECGDPHC(int BEMKKPBBGBK, float FKNBPKNIFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8220", Offset = "0x3CB7420", VA = "0x183CB8220")]
	private static void NGLGJGIGKEH(ref GHKMOEBLLJC NIBNIDLNLKK, GHKMOEBLLJC EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8220", Offset = "0x3CB7420", VA = "0x183CB8220")]
	private static void NGLGJGIGKEH(ref GHKMOEBLLJC[] NIBNIDLNLKK, GHKMOEBLLJC[] EOEMKDLOAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class LEMCGBEMEHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder FGDMELBDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder POPOHGBJCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object JPEMDGNLGPJ;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4A30550", Offset = "0x4A2F750", VA = "0x184A30550")]
	public TypeBuilder HDNECKLALHO(string OJIMLEPHDJI, TypeAttributes IBNCKGJMIMI, Type KJAPOBPIAAM, Type[] DKIKKPLCLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4A30640", Offset = "0x4A2F840", VA = "0x184A30640")]
	public LEMCGBEMEHI(string CMEJLNOIOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class OADPEEIFOPF
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4A38500", Offset = "0x4A37700", VA = "0x184A38500")]
	private static MethodInfo GKPPIOEHGPB(LambdaExpression GFOCDBFAEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEEF0", Offset = "0x3ABE0F0", VA = "0x183ABEEF0")]
	public static MethodInfo BLGHPCGFFKI<T>(Expression<Func<T>> GFOCDBFAEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEEF0", Offset = "0x3ABE0F0", VA = "0x183ABEEF0")]
	public static MethodInfo BLGHPCGFFKI<T, TR>(Expression<Func<T, TR>> GFOCDBFAEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEEF0", Offset = "0x3ABE0F0", VA = "0x183ABEEF0")]
	public static MethodInfo BLGHPCGFFKI<T>(Expression<Action<T>> GFOCDBFAEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEEF0", Offset = "0x3ABE0F0", VA = "0x183ABEEF0")]
	public static MethodInfo BLGHPCGFFKI<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GFOCDBFAEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEF00", Offset = "0x3ABE100", VA = "0x183ABEF00")]
	private static MemberInfo EEOAPNCKBOP<T>(Expression<T> JNBAACFJGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEFA0", Offset = "0x3ABE1A0", VA = "0x183ABEFA0")]
	public static PropertyInfo IIFMAFKDJJK<T, TR>(Expression<Func<T, TR>> GFOCDBFAEGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct JOOFALBJEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int JBMKKAKPADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool FPEAHJFEFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator PGFJIKIMDKA;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DFF0", Offset = "0x4A2D1F0", VA = "0x184A2DFF0")]
	public JOOFALBJEMJ(ILGenerator PGFJIKIMDKA, int JBMKKAKPADN, bool FPEAHJFEFLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E030", Offset = "0x4A2D230", VA = "0x184A2E030")]
	public JOOFALBJEMJ(ILGenerator PGFJIKIMDKA, int JBMKKAKPADN, Type OMCCJKNHBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DFD0", Offset = "0x4A2D1D0", VA = "0x184A2DFD0")]
	public void MCIOKCENFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class CHIOOEHCDCM
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x30885B0", Offset = "0x30877B0", VA = "0x1830885B0")]
	public static void APKBAFICKIH(this ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3088570", Offset = "0x3087770", VA = "0x183088570")]
	public static void APKBAFICKIH(this ILGenerator PGFJIKIMDKA, LocalBuilder MJJKCHIBJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3089060", Offset = "0x3088260", VA = "0x183089060")]
	public static void MKHONOIAEGA(this ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3089290", Offset = "0x3088490", VA = "0x183089290")]
	public static void MKHONOIAEGA(this ILGenerator PGFJIKIMDKA, LocalBuilder MJJKCHIBJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3088970", Offset = "0x3087B70", VA = "0x183088970")]
	public static void CGBEEINMAMO(this ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3088A60", Offset = "0x3087C60", VA = "0x183088A60")]
	public static void CGBEEINMAMO(this ILGenerator PGFJIKIMDKA, LocalBuilder MJJKCHIBJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3089050", Offset = "0x3088250", VA = "0x183089050")]
	public static void LJCFJFHOGLA(this ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3089040", Offset = "0x3088240", VA = "0x183089040")]
	public static void IJAGDFBDBNG(this ILGenerator PGFJIKIMDKA, bool EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x30892D0", Offset = "0x30884D0", VA = "0x1830892D0")]
	public static void MLLHJPJDEBL(this ILGenerator PGFJIKIMDKA, int EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3088480", Offset = "0x3087680", VA = "0x183088480")]
	public static void ANBBNLCIMCI(this ILGenerator PGFJIKIMDKA, Type OMCCJKNHBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x30888D0", Offset = "0x3087AD0", VA = "0x1830888D0")]
	public static void BNPJCPBNGCI(this ILGenerator PGFJIKIMDKA, Type OMCCJKNHBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3088E10", Offset = "0x3088010", VA = "0x183088E10")]
	public static void HNAIKDHMDLA(this ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3088D00", Offset = "0x3087F00", VA = "0x183088D00")]
	public static void FEFADFDCPIB(this ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x30887E0", Offset = "0x30879E0", VA = "0x1830887E0")]
	public static void BMACHPMIGLH(this ILGenerator PGFJIKIMDKA, int NCBDKCDKIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3088C00", Offset = "0x3087E00", VA = "0x183088C00")]
	public static void DJLKPPOLHLM(this ILGenerator PGFJIKIMDKA, MethodInfo HCJHDBFOCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3088D80", Offset = "0x3087F80", VA = "0x183088D80")]
	public static void HJEGKDILMFL(this ILGenerator PGFJIKIMDKA, FieldInfo LHIBHLHOHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3088B70", Offset = "0x3087D70", VA = "0x183088B70")]
	public static void DGJMMPFBFOI(this ILGenerator PGFJIKIMDKA, ulong EOEMKDLOAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class FBHLLOJEBCK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class BHHCPBOBIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
		public BHHCPBOBIKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3085CC0", Offset = "0x3084EC0", VA = "0x183085CC0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo KCEBFGKLEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo KLJLMMNMPMI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string ODPLKINLCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string OIBAEMHHHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5271C0", Offset = "0x5263C0", VA = "0x1805271C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5266A0", VA = "0x1805274A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool COJEDEMDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3094F60", Offset = "0x3094160", VA = "0x183094F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PPMJONECKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x527190", Offset = "0x526390", VA = "0x180527190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE560", Offset = "0x6AD760", VA = "0x1806AE560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LHIKDCOCINO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5271A0", Offset = "0x5263A0", VA = "0x1805271A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x664B70", Offset = "0x663D70", VA = "0x180664B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type CADPECKBHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5500C0", Offset = "0x54F2C0", VA = "0x1805500C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x64AA90", Offset = "0x649C90", VA = "0x18064AA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JCKGOFBNKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo IEBOKNEADLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x528010", Offset = "0x527210", VA = "0x180528010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x528020", Offset = "0x527220", VA = "0x180528020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo CCLPFMLGPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x53AD70", Offset = "0x539F70", VA = "0x18053AD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5C1FC0", Offset = "0x5C11C0", VA = "0x1805C1FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3095200", Offset = "0x3094400", VA = "0x183095200")]
	protected FBHLLOJEBCK(Type OMCCJKNHBML, string OJIMLEPHDJI, string IMCHJLNMCKL, bool EMPLNENAMIC, bool OCLNMAKJBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x30950F0", Offset = "0x30942F0", VA = "0x1830950F0")]
	public FBHLLOJEBCK(FieldInfo GPLDLIFCHLE, string OJIMLEPHDJI, bool MBNAFODKDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3095280", Offset = "0x3094480", VA = "0x183095280")]
	public FBHLLOJEBCK(PropertyInfo GPLDLIFCHLE, string OJIMLEPHDJI, bool MBNAFODKDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3094E40", Offset = "0x3094040", VA = "0x183094E40")]
	private static MethodInfo BJIOHCNIJCO(MemberInfo GPLDLIFCHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1F64A80", Offset = "0x1F63C80", VA = "0x181F64A80")]
	public T ICJKIGIEDHF<T>(bool BOICHCMOGAN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3094F70", Offset = "0x3094170", VA = "0x183094F70", Slot = "4")]
	public virtual void KBMKFPGKNCO(ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3095030", Offset = "0x3094230", VA = "0x183095030", Slot = "5")]
	public virtual void OEDPFLGPLNB(ILGenerator PGFJIKIMDKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class BFHMAHDHMNN : FBHLLOJEBCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string KDJBOHNEJMI;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x30847A0", Offset = "0x30839A0", VA = "0x1830847A0")]
	public BFHMAHDHMNN(string OJIMLEPHDJI, string KDJBOHNEJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x3084690", Offset = "0x3083890", VA = "0x183084690", Slot = "4")]
	public override void KBMKFPGKNCO(ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3084750", Offset = "0x3083950", VA = "0x183084750", Slot = "5")]
	public override void OEDPFLGPLNB(ILGenerator PGFJIKIMDKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CKHGNOONILC : FBHLLOJEBCK
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo BEKCOFPPPEM;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo PCJIMKGDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal JOOFALBJEMJ CFHMMCHNACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal JOOFALBJEMJ EACNEENNMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal JOOFALBJEMJ GDPCCFEEKDI;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x308C740", Offset = "0x308B940", VA = "0x18308C740")]
	public CKHGNOONILC(string OJIMLEPHDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x308C080", Offset = "0x308B280", VA = "0x18308C080", Slot = "4")]
	public override void KBMKFPGKNCO(ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x308C250", Offset = "0x308B450", VA = "0x18308C250", Slot = "5")]
	public override void OEDPFLGPLNB(ILGenerator PGFJIKIMDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x308C140", Offset = "0x308B340", VA = "0x18308C140")]
	public void MDFGEHIDFDL(ILGenerator PGFJIKIMDKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class NFIKJCCFCBP
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type CADPECKBHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5271D0", Offset = "0x5263D0", VA = "0x1805271D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x527490", Offset = "0x526690", VA = "0x180527490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FHJEOKNKAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x655BA0", Offset = "0x654DA0", VA = "0x180655BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6E8AD0", Offset = "0x6E7CD0", VA = "0x1806E8AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ODBPDIFKJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x666190", Offset = "0x665390", VA = "0x180666190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD6A4B0", Offset = "0xD696B0", VA = "0x180D6A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo AKFPKEHOBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FBHLLOJEBCK[] PNBLNOHNPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5500C0", Offset = "0x54F2C0", VA = "0x1805500C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x64AA90", Offset = "0x649C90", VA = "0x18064AA90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FBHLLOJEBCK[] EAHLJAHPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EC30", VA = "0x18054FA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x66B3A0", Offset = "0x66A5A0", VA = "0x18066B3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4A36820", Offset = "0x4A35A20", VA = "0x184A36820")]
	public NFIKJCCFCBP(Type OMCCJKNHBML, Func<string, string> MNJDHKDIFKH, bool MBNAFODKDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4A36750", Offset = "0x4A35950", VA = "0x184A36750")]
	private static bool OHAOHBHNKJK(IEnumerator<ConstructorInfo> FKMNCAENNOF, ref ConstructorInfo JCNAJBKHGDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct BPDCLNBCABI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong JFNJCPELJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int FFEJELOBLMN;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x22955A0", Offset = "0x22947A0", VA = "0x1822955A0")]
	public BPDCLNBCABI(ulong HNBLHONJKDB, int OIFIMMIMFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3086B00", Offset = "0x3085D00", VA = "0x183086B00")]
	public void IOGLNMHLOEL(ref BPDCLNBCABI CDPFMCDBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3086AD0", Offset = "0x3085CD0", VA = "0x183086AD0")]
	public static BPDCLNBCABI ICGCNKDNAEB(ref BPDCLNBCABI LIEOABMIJDJ, ref BPDCLNBCABI DCOPGELFIOF)
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3086A40", Offset = "0x3085C40", VA = "0x183086A40")]
	public void CNBKIEPIDFK(ref BPDCLNBCABI CDPFMCDBFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3086BB0", Offset = "0x3085DB0", VA = "0x183086BB0")]
	public static BPDCLNBCABI OKCFDDPHFFL(ref BPDCLNBCABI LIEOABMIJDJ, ref BPDCLNBCABI DCOPGELFIOF)
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3086B70", Offset = "0x3085D70", VA = "0x183086B70")]
	public void KNDJBHGBJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3086B10", Offset = "0x3085D10", VA = "0x183086B10")]
	public static BPDCLNBCABI KNDJBHGBJBE(ref BPDCLNBCABI LIEOABMIJDJ)
	{
		return default(BPDCLNBCABI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct JGNHHGICMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] ODGBLHHLGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int KPMCEIEAINM;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x80E030", Offset = "0x80D230", VA = "0x18080E030")]
	public JGNHHGICMAK(byte[] ODGBLHHLGCK, int OBHFOKDOECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DF10", Offset = "0x4A2D110", VA = "0x184A2DF10")]
	public void PKMAEOJPHDN(byte FLKAGPMANPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DDF0", Offset = "0x4A2CFF0", VA = "0x184A2DDF0")]
	public void MEJHPEPIDFO(byte[] FLKAGPMANPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DD50", Offset = "0x4A2CF50", VA = "0x184A2DD50")]
	public void IDPCENGCPHP(byte[] FLKAGPMANPM, int COAENFJIMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DCA0", Offset = "0x4A2CEA0", VA = "0x184A2DCA0")]
	public void IDPCENGCPHP(byte[] FLKAGPMANPM, int PGDHNMNFPNO, int COAENFJIMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DE90", Offset = "0x4A2D090", VA = "0x184A2DE90")]
	public void OCOEJHHBBGB(byte DFLGAKHACHA, int LMEIKANBNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4A2DBA0", Offset = "0x4A2CDA0", VA = "0x184A2DBA0")]
	public void CGAGGJIFHGK(string FLKAGPMANPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class EOPGLFGHHDM
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum BCACCPAPOKP
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum JAKIEOIFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum KDFGEBJDODO
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
	private static byte[] DBHIGJKKPOA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] BJMBKNGPLAG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] BDJILCNBMJC;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] KLCAGAAIOLH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly KDFGEBJDODO KGLMDPPBHFG;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char IABPHPEBCPK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int OOOCAFEDBBC;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int MFOCJHGJLAG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] CNLKCAJDJDE;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x30926F0", Offset = "0x30918F0", VA = "0x1830926F0")]
	private static byte[] LJLEKDGCOCD(int AADFONHDDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3091740", Offset = "0x3090940", VA = "0x183091740")]
	private static byte[] BJNKCDABHLE(int AADFONHDDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3091D00", Offset = "0x3090F00", VA = "0x183091D00")]
	public static int FPCMKJPNKBJ(ref byte[] ODGBLHHLGCK, int KPMCEIEAINM, float EOEMKDLOAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3091BF0", Offset = "0x3090DF0", VA = "0x183091BF0")]
	public static int FPCMKJPNKBJ(ref byte[] ODGBLHHLGCK, int KPMCEIEAINM, double EOEMKDLOAGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3091E10", Offset = "0x3091010", VA = "0x183091E10")]
	private static bool GPCFAKDACEO(byte[] ODGBLHHLGCK, int COAENFJIMCK, ulong MLEKNAEGHAO, ulong DICEADBMMAG, ulong FNLMIDIDDAF, ulong ONFHJHBHNME, ulong KCAGLKCDJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3092DF0", Offset = "0x3091FF0", VA = "0x183092DF0")]
	private static void NCPMGJJCMGH(uint JPJNFOFKHNA, int KPFDIEKPIJA, out uint CBNCDEFOBIO, out int PJMENICBPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3091820", Offset = "0x3090A20", VA = "0x183091820")]
	private static bool EBHMAJCLMCJ(BPDCLNBCABI EAAJOBJMBOC, BPDCLNBCABI AGHNKENFEOL, BPDCLNBCABI IMAILOHKJPF, byte[] ODGBLHHLGCK, out int COAENFJIMCK, out int HCGINMIFGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x30913A0", Offset = "0x30905A0", VA = "0x1830913A0")]
	private static bool APAPBPMAPFJ(double FMBAOAOLBAA, BCACCPAPOKP HCOKEIGPOLO, byte[] ODGBLHHLGCK, out int COAENFJIMCK, out int DEEAKPLMJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x30912B0", Offset = "0x30904B0", VA = "0x1830912B0")]
	private static bool AMDADHJLJOM(double FMBAOAOLBAA, BCACCPAPOKP HCOKEIGPOLO, byte[] ODGBLHHLGCK, out int COAENFJIMCK, out int DEPCLHMLKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3092200", Offset = "0x3091400", VA = "0x183092200")]
	private static bool JBANDPIDJPM(double EOEMKDLOAGI, ref JGNHHGICMAK ABCJEFLJCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x30927C0", Offset = "0x30919C0", VA = "0x1830927C0")]
	private static bool MOJBIGHFPPF(double EOEMKDLOAGI, ref JGNHHGICMAK ABCJEFLJCAI, JAKIEOIFHFN HCOKEIGPOLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3092530", Offset = "0x3091730", VA = "0x183092530")]
	private static void LGDEILEFJON(byte[] JMPACJOMGOA, int COAENFJIMCK, int DEPCLHMLKFP, int HDHAGBDFEIF, ref JGNHHGICMAK ABCJEFLJCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3091F10", Offset = "0x3091110", VA = "0x183091F10")]
	private static void HIHCKGDFMLC(byte[] JMPACJOMGOA, int COAENFJIMCK, int OIFIMMIMFBF, ref JGNHHGICMAK ABCJEFLJCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3092390", Offset = "0x3091590", VA = "0x183092390")]
	private static bool KODJKKEFBIJ(double FMBAOAOLBAA, JAKIEOIFHFN HCOKEIGPOLO, int OGGEHJLJPOL, byte[] ONIBFMEMMNK, out bool OOMAIPGGAMI, out int COAENFJIMCK, out int EMBNAEFNEME)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct KCKPJKKBDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double NEHIPNHHDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong AIABICOIOGO;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct EBMCFIKIAHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float JFNJCPELJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint PDEKGLKNGGK;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct OHBMCINJBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong AKMPHLHCOLG;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A38D10", Offset = "0x4A37F10", VA = "0x184A38D10")]
	public OHBMCINJBGH(double NEHIPNHHDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A38D20", Offset = "0x4A37F20", VA = "0x184A38D20")]
	public OHBMCINJBGH(BPDCLNBCABI NEHIPNHHDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A38BA0", Offset = "0x4A37DA0", VA = "0x184A38BA0")]
	public BPDCLNBCABI LKNOIKEDNCO()
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A38AB0", Offset = "0x4A37CB0", VA = "0x184A38AB0")]
	public BPDCLNBCABI JDNAEFBMAPJ()
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7631B0", Offset = "0x7623B0", VA = "0x1807631B0")]
	public ulong PBEFOJOLJOK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A38C70", Offset = "0x4A37E70", VA = "0x184A38C70")]
	public double NBEAPKLOLKF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A38900", Offset = "0x4A37B00", VA = "0x184A38900")]
	public double CPBPGCPDLFK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A38CE0", Offset = "0x4A37EE0", VA = "0x184A38CE0")]
	public int OJECNIKMMGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A38C20", Offset = "0x4A37E20", VA = "0x184A38C20")]
	public ulong LOPECLAKIEA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A38B50", Offset = "0x4A37D50", VA = "0x184A38B50")]
	public bool KKBDGPHGHDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A38A90", Offset = "0x4A37C90", VA = "0x184A38A90")]
	public bool IKDHPMCLJJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A38B70", Offset = "0x4A37D70", VA = "0x184A38B70")]
	public bool LAGMMEBCIGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A38720", Offset = "0x4A37920", VA = "0x184A38720")]
	public bool ABNPOBEEIPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A38C50", Offset = "0x4A37E50", VA = "0x184A38C50")]
	public int MDIIFIAKACB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A38750", Offset = "0x4A37950", VA = "0x184A38750")]
	public void BKLOMNGEJLC(out BPDCLNBCABI PMEFMAJGJMK, out BPDCLNBCABI KCBHMHBFNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A389A0", Offset = "0x4A37BA0", VA = "0x184A389A0")]
	public bool HJKDHHHHILP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A38990", Offset = "0x4A37B90", VA = "0x184A38990")]
	public double EOEMKDLOAGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4A388E0", Offset = "0x4A37AE0", VA = "0x184A388E0")]
	public static int BNMAAJKKNPJ(int GCJJAIIIHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4A38980", Offset = "0x4A37B80", VA = "0x184A38980")]
	public static double EJCPFCMOAKF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4A389F0", Offset = "0x4A37BF0", VA = "0x184A389F0")]
	public static ulong IECOKHNLPPM(BPDCLNBCABI MEEDONBCPFH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct IIMIJPLHLLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint KHLOKKLBKOA;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB520", Offset = "0x1DAA720", VA = "0x181DAB520")]
	public IIMIJPLHLLL(float JFNJCPELJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3321600", Offset = "0x3320800", VA = "0x183321600")]
	public BPDCLNBCABI LKNOIKEDNCO()
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D34F0", Offset = "0x7D26F0", VA = "0x1807D34F0")]
	public uint OJMKCAILCFE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3321690", Offset = "0x3320890", VA = "0x183321690")]
	public int OJECNIKMMGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3321670", Offset = "0x3320870", VA = "0x183321670")]
	public uint LOPECLAKIEA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x33215F0", Offset = "0x33207F0", VA = "0x1833215F0")]
	public bool KKBDGPHGHDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3321440", Offset = "0x3320640", VA = "0x183321440")]
	public void BKLOMNGEJLC(out BPDCLNBCABI PMEFMAJGJMK, out BPDCLNBCABI KCBHMHBFNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x33215B0", Offset = "0x33207B0", VA = "0x1833215B0")]
	public bool HJKDHHHHILP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct CIDIGPMFFOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong HNBLHONJKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short GABLMNGEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short DEEAKPLMJJH;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x308A0E0", Offset = "0x30892E0", VA = "0x18308A0E0")]
	public CIDIGPMFFOK(ulong HNBLHONJKDB, short GABLMNGEOMI, short DEEAKPLMJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class LMHINJLFOCG
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly CIDIGPMFFOK[] DHHJPIPENKH;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A30B00", Offset = "0x4A2FD00", VA = "0x184A30B00")]
	public static void KDCHOJHNPGC(int OODJKJDIKGG, int MELCIHCGPBF, out BPDCLNBCABI CBNCDEFOBIO, out int DEEAKPLMJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A30A00", Offset = "0x4A2FC00", VA = "0x184A30A00")]
	public static void DOICPMGEEJA(int CCCMAIGBLPF, out BPDCLNBCABI CBNCDEFOBIO, out int FAIPHNGDLFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct CHNDKBHHOLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] GMBNEFEOHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int PGDHNMNFPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int LLMFMHMJJKG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte HPLHDJPGHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3089780", Offset = "0x3088980", VA = "0x183089780")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x93A650", Offset = "0x939850", VA = "0x18093A650")]
	public CHNDKBHHOLD(byte[] GMBNEFEOHLO, int PGDHNMNFPNO, int COAENFJIMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D34B0", Offset = "0x7D26B0", VA = "0x1807D34B0")]
	public int COAENFJIMCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3089720", Offset = "0x3088920", VA = "0x183089720")]
	public CHNDKBHHOLD AECAKEGIGJD(int OPIAKAOFCJP, int BAFHPHJFPFA)
	{
		return default(CHNDKBHHOLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class CJHDCLILILJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] AJBABEKOBKE;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] PPMGKAHCOBH;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int HEFMPLABBAP;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x308ADC0", Offset = "0x3089FC0", VA = "0x18308ADC0")]
	private static byte[] KPMHPNKIEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x308A6B0", Offset = "0x30898B0", VA = "0x18308A6B0")]
	private static CHNDKBHHOLD FOLLLPDAJKC(CHNDKBHHOLD ODGBLHHLGCK)
	{
		return default(CHNDKBHHOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x308A430", Offset = "0x3089630", VA = "0x18308A430")]
	private static CHNDKBHHOLD EIMGNPKDLLE(CHNDKBHHOLD ODGBLHHLGCK)
	{
		return default(CHNDKBHHOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x308BA60", Offset = "0x308AC60", VA = "0x18308BA60")]
	private static void PJMJMKFAHOF(CHNDKBHHOLD ODGBLHHLGCK, int OIFIMMIMFBF, byte[] AMHCBMFFFGM, out int KJBMCPLGJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x308AEA0", Offset = "0x308A0A0", VA = "0x18308AEA0")]
	private static void MHAHMEIBHLI(CHNDKBHHOLD ODGBLHHLGCK, int OIFIMMIMFBF, byte[] LMDPCAOLFON, int PKNGPABBDEH, out CHNDKBHHOLD HMFJGODJLDO, out int DALKIOMNJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x308B8A0", Offset = "0x308AAA0", VA = "0x18308B8A0")]
	private static ulong NNCJMBHMAEM(CHNDKBHHOLD ODGBLHHLGCK, out int ECHAJBOIBDO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x308A2C0", Offset = "0x30894C0", VA = "0x18308A2C0")]
	private static void BHDMDEFPDFF(CHNDKBHHOLD ODGBLHHLGCK, out BPDCLNBCABI BKIAMPODCNE, out int IFIPMIKLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x308A790", Offset = "0x3089990", VA = "0x18308A790")]
	private static bool GHMFFAKIKOE(CHNDKBHHOLD HMFJGODJLDO, int OIFIMMIMFBF, out double BKIAMPODCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x308A510", Offset = "0x3089710", VA = "0x18308A510")]
	private static BPDCLNBCABI FBDOCABGGMI(int OIFIMMIMFBF)
	{
		return default(BPDCLNBCABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x308B1C0", Offset = "0x308A3C0", VA = "0x18308B1C0")]
	private static bool MMFCBNIBDGO(CHNDKBHHOLD ODGBLHHLGCK, int OIFIMMIMFBF, out double BKIAMPODCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x308B760", Offset = "0x308A960", VA = "0x18308B760")]
	private static bool NCMHOGDKBEE(CHNDKBHHOLD HMFJGODJLDO, int OIFIMMIMFBF, out double OHAKJLMEIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x308B930", Offset = "0x308AB30", VA = "0x18308B930")]
	public static double? OADNLBNDBBD(CHNDKBHHOLD ODGBLHHLGCK, int OIFIMMIMFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x308ABE0", Offset = "0x3089DE0", VA = "0x18308ABE0")]
	public static float? KFMEOGCKLBP(CHNDKBHHOLD ODGBLHHLGCK, int OIFIMMIMFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct AAKJHNDCOKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] ODGBLHHLGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int KPMCEIEAINM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte LLFECFNJIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3082600", Offset = "0x3081800", VA = "0x183082600")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x80E030", Offset = "0x80D230", VA = "0x18080E030")]
	public AAKJHNDCOKH(byte[] ODGBLHHLGCK, int KPMCEIEAINM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3082450", Offset = "0x3081650", VA = "0x183082450")]
	public static AAKJHNDCOKH DBHKBGLNGGH(AAKJHNDCOKH JCFDJGMDKKL)
	{
		return default(AAKJHNDCOKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3082680", Offset = "0x3081880", VA = "0x183082680")]
	public static AAKJHNDCOKH OLJHOBLBIKO(AAKJHNDCOKH JCFDJGMDKKL, int COAENFJIMCK)
	{
		return default(AAKJHNDCOKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x30825E0", Offset = "0x30817E0", VA = "0x1830825E0")]
	public static int MJIBNMDJPKD(AAKJHNDCOKH NIFHNIMLIIM, AAKJHNDCOKH LPCOLAIDHBK)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x3082500", Offset = "0x3081700", VA = "0x183082500")]
	public static bool LAFABLDEECH(AAKJHNDCOKH NIFHNIMLIIM, AAKJHNDCOKH LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3082460", Offset = "0x3081660", VA = "0x183082460")]
	public static bool JPMDEKHNLAD(AAKJHNDCOKH NIFHNIMLIIM, AAKJHNDCOKH LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3082520", Offset = "0x3081720", VA = "0x183082520")]
	public static bool LAFABLDEECH(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3082480", Offset = "0x3081680", VA = "0x183082480")]
	public static bool JPMDEKHNLAD(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3082480", Offset = "0x3081680", VA = "0x183082480")]
	public static bool JPMDEKHNLAD(AAKJHNDCOKH NIFHNIMLIIM, byte LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3082640", Offset = "0x3081840", VA = "0x183082640")]
	public static bool OJOFJHIEFMB(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x30825A0", Offset = "0x30817A0", VA = "0x1830825A0")]
	public static bool LKICHFEMGEI(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x30824C0", Offset = "0x30816C0", VA = "0x1830824C0")]
	public static bool KOPGBFFFEHI(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3082560", Offset = "0x3081760", VA = "0x183082560")]
	public static bool LBPKADFHDLL(AAKJHNDCOKH NIFHNIMLIIM, char LPCOLAIDHBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class OOMNEOAKBEB
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CKBCCCJMIAP;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] ANAEKGKAOFD;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] BDJILCNBMJC;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] KLCAGAAIOLH;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] OBAKAPMHMBD;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int KGCNEAJECFL;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] DFGIONFIBDM;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int DFFKOFKFFAI;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A1E0", Offset = "0x4A393E0", VA = "0x184A3A1E0")]
	private static byte[] LCBFKEIBEFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4A38F40", Offset = "0x4A38140", VA = "0x184A38F40")]
	private static byte[] EHPNJINNONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A490", Offset = "0x4A39690", VA = "0x184A3A490")]
	public static double PIKEJEDIDJJ(byte[] ODGBLHHLGCK, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A3D0", Offset = "0x4A395D0", VA = "0x184A3A3D0")]
	public static float OKPCJDCHGGP(byte[] ODGBLHHLGCK, int KPMCEIEAINM, out int KIBACPBHCMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A38DC0", Offset = "0x4A37FC0", VA = "0x184A38DC0")]
	private static bool DONACLKJMKD(int GGMEAHKJCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A0C0", Offset = "0x4A392C0", VA = "0x184A3A0C0")]
	private static bool GNPCCMLKCLA(ref AAKJHNDCOKH EMGCBCDKOLA, AAKJHNDCOKH NPDPHCNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A2C0", Offset = "0x4A394C0", VA = "0x184A3A2C0")]
	private static bool OIPGGLNOKBP(ref AAKJHNDCOKH EMGCBCDKOLA, AAKJHNDCOKH NPDPHCNLMFM, byte[] AENGICJEAEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A550", Offset = "0x4A39750", VA = "0x184A3A550")]
	private static bool PMELALCCGMB(ref AAKJHNDCOKH MCDMPFBHLKD, byte[] FLKAGPMANPM, int KPMCEIEAINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xD8D780", Offset = "0xD8C980", VA = "0x180D8D780")]
	private static double DFBIPCBDFCK(bool OOMAIPGGAMI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4A39020", Offset = "0x4A38220", VA = "0x184A39020")]
	private static double FJOOGFNAGEI(AAKJHNDCOKH PMMAJMNJHJP, int COAENFJIMCK, bool KNIGFKEFHKN, out int PHNONGDAGCP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class DLDPCCOFHAB<T> : global::ANGGPBBBOPJ<T[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::CCDHAJKAEHE<T> GODHFPHDHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly KGEGEEEBEGL DKGOOFIPLMF;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2A277C0", Offset = "0x2A269C0", VA = "0x182A277C0")]
	public DLDPCCOFHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1BB7B60", Offset = "0x1BB6D60", VA = "0x181BB7B60")]
	public DLDPCCOFHAB(KGEGEEEBEGL DKGOOFIPLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2D42AB0", Offset = "0x2D41CB0", VA = "0x182D42AB0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, T[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2D417C0", Offset = "0x2D409C0", VA = "0x182D417C0", Slot = "5")]
	public T[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class HBOJJIMMMKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::CCDHAJKAEHE<T> GODHFPHDHPE;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class OOKDLMADLAL<T> : global::ANGGPBBBOPJ<List<T>>, BNLFGEJDIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly KGEGEEEBEGL DKGOOFIPLMF;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2A277C0", Offset = "0x2A269C0", VA = "0x182A277C0")]
	public OOKDLMADLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1BB7B60", Offset = "0x1BB6D60", VA = "0x181BB7B60")]
	public OOKDLMADLAL(KGEGEEEBEGL DKGOOFIPLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2A27160", Offset = "0x2A26360", VA = "0x182A27160", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, List<T> EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2A26710", Offset = "0x2A25910", VA = "0x182A26710", Slot = "5")]
	public List<T> KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EEPMAPIJNDP<TElement, TIntermediate, TEnumerator, TCollection> : global::ANGGPBBBOPJ<TCollection>, BNLFGEJDIDK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB7E0", Offset = "0x3CBA9E0", VA = "0x183CBB7E0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, TCollection EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9EE0", Offset = "0x3CB90E0", VA = "0x183CB9EE0", Slot = "5")]
	public TCollection KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DMLHPBOEMMB(TCollection JNBAACFJGCO);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JOBPNILIBDA();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JPGLGPDLMNH(ref TIntermediate FHNDJDEJPDL, int NCBDKCDKIIG, TElement EOEMKDLOAGI);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection LLIICMGDJCE(ref TIntermediate AHCBEOBLPMB);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
	protected EEPMAPIJNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class APDAOGFHPNP<TElement, TIntermediate, TCollection> : global::EEPMAPIJNDP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x37D66C0", Offset = "0x37D58C0", VA = "0x1837D66C0", Slot = "6")]
	protected override IEnumerator<TElement> DMLHPBOEMMB(TCollection JNBAACFJGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CA10", Offset = "0x1D5BC10", VA = "0x181D5CA10")]
	protected APDAOGFHPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class HLOLOLABEGJ<TElement, TCollection> : global::APDAOGFHPNP<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected sealed override TCollection LLIICMGDJCE(ref TCollection AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class CCEOBKBOAPJ<TElement, TCollection> : global::HLOLOLABEGJ<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3C653D0", Offset = "0x3C645D0", VA = "0x183C653D0", Slot = "7")]
	protected override TCollection JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3C653F0", Offset = "0x3C645F0", VA = "0x183C653F0", Slot = "8")]
	protected override void JPGLGPDLMNH(ref TCollection FHNDJDEJPDL, int NCBDKCDKIIG, TElement EOEMKDLOAGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GDEFKBCLAMH<T> : global::EEPMAPIJNDP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243C70", VA = "0x182244A70", Slot = "8")]
	protected override void JPGLGPDLMNH(ref LinkedList<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override LinkedList<T> LLIICMGDJCE(ref LinkedList<T> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override LinkedList<T> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x22449B0", Offset = "0x2243BB0", VA = "0x1822449B0", Slot = "6")]
	protected override LinkedList<T>.Enumerator DMLHPBOEMMB(LinkedList<T> JNBAACFJGCO)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CAFALFLMHLI<T> : global::EEPMAPIJNDP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243C70", VA = "0x182244A70", Slot = "8")]
	protected override void JPGLGPDLMNH(ref Queue<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override Queue<T> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x304E440", Offset = "0x304D640", VA = "0x18304E440", Slot = "6")]
	protected override Queue<T>.Enumerator DMLHPBOEMMB(Queue<T> JNBAACFJGCO)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override Queue<T> LLIICMGDJCE(ref Queue<T> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CPNLGGGDOBK<T> : global::EEPMAPIJNDP<T, global::HPLBLCNKEPO<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2E69960", Offset = "0x2E68B60", VA = "0x182E69960", Slot = "8")]
	protected override void JPGLGPDLMNH(ref global::HPLBLCNKEPO<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2E69910", Offset = "0x2E68B10", VA = "0x182E69910", Slot = "7")]
	protected override global::HPLBLCNKEPO<T> JOBPNILIBDA()
	{
		return default(global::HPLBLCNKEPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x304E440", Offset = "0x304D640", VA = "0x18304E440", Slot = "6")]
	protected override Stack<T>.Enumerator DMLHPBOEMMB(Stack<T> JNBAACFJGCO)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x304E490", Offset = "0x304D690", VA = "0x18304E490", Slot = "9")]
	protected override Stack<T> LLIICMGDJCE(ref global::HPLBLCNKEPO<T> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FEKEJNEKBBA<T> : global::EEPMAPIJNDP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243C70", VA = "0x182244A70", Slot = "8")]
	protected override void JPGLGPDLMNH(ref HashSet<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override HashSet<T> LLIICMGDJCE(ref HashSet<T> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override HashSet<T> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x304E440", Offset = "0x304D640", VA = "0x18304E440", Slot = "6")]
	protected override HashSet<T>.Enumerator DMLHPBOEMMB(HashSet<T> JNBAACFJGCO)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class CDIMGKFAAGH<T> : global::APDAOGFHPNP<T, global::HPLBLCNKEPO<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2E69960", Offset = "0x2E68B60", VA = "0x182E69960", Slot = "8")]
	protected override void JPGLGPDLMNH(ref global::HPLBLCNKEPO<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x35B3F20", Offset = "0x35B3120", VA = "0x1835B3F20", Slot = "9")]
	protected override ReadOnlyCollection<T> LLIICMGDJCE(ref global::HPLBLCNKEPO<T> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x35B3ED0", Offset = "0x35B30D0", VA = "0x1835B3ED0", Slot = "7")]
	protected override global::HPLBLCNKEPO<T> JOBPNILIBDA()
	{
		return default(global::HPLBLCNKEPO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PIBAHHBBGAH<T> : global::APDAOGFHPNP<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243C70", VA = "0x182244A70", Slot = "8")]
	protected override void JPGLGPDLMNH(ref List<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override List<T> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override IList<T> LLIICMGDJCE(ref List<T> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class DJILNGEFHCH<T> : global::APDAOGFHPNP<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243C70", VA = "0x182244A70", Slot = "8")]
	protected override void JPGLGPDLMNH(ref List<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override List<T> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override ICollection<T> LLIICMGDJCE(ref List<T> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class OGLLHHDKKJJ<T> : global::APDAOGFHPNP<T, global::HPLBLCNKEPO<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2E69960", Offset = "0x2E68B60", VA = "0x182E69960", Slot = "8")]
	protected override void JPGLGPDLMNH(ref global::HPLBLCNKEPO<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2E69910", Offset = "0x2E68B10", VA = "0x182E69910", Slot = "7")]
	protected override global::HPLBLCNKEPO<T> JOBPNILIBDA()
	{
		return default(global::HPLBLCNKEPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2E69990", Offset = "0x2E68B90", VA = "0x182E69990", Slot = "9")]
	protected override IEnumerable<T> LLIICMGDJCE(ref global::HPLBLCNKEPO<T> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class AGLCDMCNDIM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class AHJNDINGDJF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class FFOOMLPNKHH<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class FNKPLODGBDK : global::ANGGPBBBOPJ<IEnumerable>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::ANGGPBBBOPJ<IEnumerable> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3313010", Offset = "0x3312210", VA = "0x183313010", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, IEnumerable EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3312E90", Offset = "0x3312090", VA = "0x183312E90", Slot = "5")]
	public IEnumerable KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public FNKPLODGBDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class GCJMHINBNEE : global::ANGGPBBBOPJ<ICollection>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::ANGGPBBBOPJ<ICollection> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x331D2A0", Offset = "0x331C4A0", VA = "0x18331D2A0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ICollection EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x331D120", Offset = "0x331C320", VA = "0x18331D120", Slot = "5")]
	public ICollection KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public GCJMHINBNEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class HFFEILHBKAM : global::ANGGPBBBOPJ<IList>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::ANGGPBBBOPJ<IList> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x331FA20", Offset = "0x331EC20", VA = "0x18331FA20", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, IList EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x331F8A0", Offset = "0x331EAA0", VA = "0x18331F8A0", Slot = "5")]
	public IList KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public HFFEILHBKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class BKPIAFEHDNN<T> : global::APDAOGFHPNP<T, global::HPLBLCNKEPO<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3C62370", Offset = "0x3C61570", VA = "0x183C62370", Slot = "8")]
	protected override void JPGLGPDLMNH(ref global::HPLBLCNKEPO<T> FHNDJDEJPDL, int NCBDKCDKIIG, T EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E69910", Offset = "0x2E68B10", VA = "0x182E69910", Slot = "7")]
	protected override global::HPLBLCNKEPO<T> JOBPNILIBDA()
	{
		return default(global::HPLBLCNKEPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3C623B0", Offset = "0x3C615B0", VA = "0x183C623B0", Slot = "9")]
	protected override IReadOnlyList<T> LLIICMGDJCE(ref global::HPLBLCNKEPO<T> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1BBC8C0", Offset = "0x1BBBAC0", VA = "0x181BBC8C0")]
	public BKPIAFEHDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class HOFKGAGKPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3320070", Offset = "0x331F270", VA = "0x183320070")]
	public static DateTime PAOFBLHLFEH(DateTime HIFPDBIHPPN)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class GGBNEPGCGAN : global::ANGGPBBBOPJ<DateTime>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::ANGGPBBBOPJ<DateTime> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x331F270", Offset = "0x331E470", VA = "0x18331F270", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, DateTime EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x331E2E0", Offset = "0x331D4E0", VA = "0x18331E2E0", Slot = "5")]
	public DateTime KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public GGBNEPGCGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class JFBOODGJLOA : global::ANGGPBBBOPJ<DateTimeOffset>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::ANGGPBBBOPJ<DateTimeOffset> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x33252C0", Offset = "0x33244C0", VA = "0x1833252C0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, DateTimeOffset EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3324320", Offset = "0x3323520", VA = "0x183324320", Slot = "5")]
	public DateTimeOffset KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public JFBOODGJLOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class IILOPPIFANE : global::ANGGPBBBOPJ<TimeSpan>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::ANGGPBBBOPJ<TimeSpan> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] NAFDCDJLFHB;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3321050", Offset = "0x3320250", VA = "0x183321050", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, TimeSpan EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x33206F0", Offset = "0x331F8F0", VA = "0x1833206F0", Slot = "5")]
	public TimeSpan KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public IILOPPIFANE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AHDJFGOPGLD<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::ANGGPBBBOPJ<TDictionary>, BNLFGEJDIDK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1E5E7E0", Offset = "0x1E5D9E0", VA = "0x181E5E7E0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, TDictionary EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B900", Offset = "0x1E5AB00", VA = "0x181E5B900", Slot = "5")]
	public TDictionary KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DMLHPBOEMMB(TDictionary JNBAACFJGCO);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JOBPNILIBDA();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JPGLGPDLMNH(ref TIntermediate FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary LLIICMGDJCE(ref TIntermediate AHCBEOBLPMB);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
	protected AHDJFGOPGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class IMBIIGHKIBH<TKey, TValue, TIntermediate, TDictionary> : global::AHDJFGOPGLD<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x37D66C0", Offset = "0x37D58C0", VA = "0x1837D66C0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> DMLHPBOEMMB(TDictionary JNBAACFJGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class HMOMIAEPOAL<TKey, TValue, TDictionary> : global::IMBIIGHKIBH<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override TDictionary LLIICMGDJCE(ref TDictionary AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LFMBGGDJFLL<TKey, TValue> : global::AHDJFGOPGLD<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x279CF60", Offset = "0x279C160", VA = "0x18279CF60", Slot = "8")]
	protected override void JPGLGPDLMNH(ref Dictionary<TKey, TValue> FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override Dictionary<TKey, TValue> LLIICMGDJCE(ref Dictionary<TKey, TValue> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override Dictionary<TKey, TValue> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x279CF10", Offset = "0x279C110", VA = "0x18279CF10", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator DMLHPBOEMMB(Dictionary<TKey, TValue> JNBAACFJGCO)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1BBFFB0", Offset = "0x1BBF1B0", VA = "0x181BBFFB0")]
	public LFMBGGDJFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PNHDMKGDIIN<TKey, TValue, TDictionary> : global::HMOMIAEPOAL<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3D09640", Offset = "0x3D08840", VA = "0x183D09640", Slot = "8")]
	protected override void JPGLGPDLMNH(ref TDictionary FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3D09620", Offset = "0x3D08820", VA = "0x183D09620", Slot = "7")]
	protected override TDictionary JOBPNILIBDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class MKNBABNCHNB<TKey, TValue> : global::IMBIIGHKIBH<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x279CFA0", Offset = "0x279C1A0", VA = "0x18279CFA0", Slot = "8")]
	protected override void JPGLGPDLMNH(ref Dictionary<TKey, TValue> FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override Dictionary<TKey, TValue> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override IDictionary<TKey, TValue> LLIICMGDJCE(ref Dictionary<TKey, TValue> AHCBEOBLPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class LHBOHOMDMKM<TKey, TValue> : global::HMOMIAEPOAL<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x279CFA0", Offset = "0x279C1A0", VA = "0x18279CFA0", Slot = "8")]
	protected override void JPGLGPDLMNH(ref SortedList<TKey, TValue> FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override SortedList<TKey, TValue> JOBPNILIBDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class HAMBIJGHLMC<TKey, TValue> : global::AHDJFGOPGLD<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x279CFA0", Offset = "0x279C1A0", VA = "0x18279CFA0", Slot = "8")]
	protected override void JPGLGPDLMNH(ref SortedDictionary<TKey, TValue> FHNDJDEJPDL, int NCBDKCDKIIG, TKey FOOEPPOEAPA, TValue EOEMKDLOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xE05610", Offset = "0xE04810", VA = "0x180E05610", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> LLIICMGDJCE(ref SortedDictionary<TKey, TValue> AHCBEOBLPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2244A10", Offset = "0x2243C10", VA = "0x182244A10", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> JOBPNILIBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDC1B0", Offset = "0x3CDB3B0", VA = "0x183CDC1B0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator DMLHPBOEMMB(SortedDictionary<TKey, TValue> JNBAACFJGCO)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class OFOAMICJAHN<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class BFNIPOKKIGO : global::ANGGPBBBOPJ<IDictionary>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::ANGGPBBBOPJ<IDictionary> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3084B90", Offset = "0x3083D90", VA = "0x183084B90", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, IDictionary EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x3084870", Offset = "0x3083A70", VA = "0x183084870", Slot = "5")]
	public IDictionary KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BFNIPOKKIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class BGCICJNBOAB : global::ANGGPBBBOPJ<object>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void EFDKCOPLAFH(object KHCPHFDBMEE, ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::EDNNPJMGCPM<KeyValuePair<object, EFDKCOPLAFH>> ADKFJJCPIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly FAPMHGNPHBA[] MADMIFCKCIC;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3085C20", Offset = "0x3084E20", VA = "0x183085C20")]
	public BGCICJNBOAB(params FAPMHGNPHBA[] MADMIFCKCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x3085110", Offset = "0x3084310", VA = "0x183085110", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3085080", Offset = "0x3084280", VA = "0x183085080", Slot = "5")]
	public object KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class LAMKGEHOLDO
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F110", Offset = "0x4A2E310", VA = "0x184A2F110")]
	public static object JMPEGJGIOCG(Type OMCCJKNHBML, out bool FLDLFHFIHHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F8F0", Offset = "0x4A2EAF0", VA = "0x184A2F8F0")]
	public static object PLKIOIFJBIK(Type OMCCJKNHBML, out bool FLDLFHFIHHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class CIEHIMMPLCA<T> : global::ANGGPBBBOPJ<T>, BNLFGEJDIDK, global::MHEOENCCDHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FGCIGNMMKPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public FGCIGNMMKPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x35BCD60", Offset = "0x35BBF60", VA = "0x1835BCD60")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class IDMPLFJCGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::NGGJIPACEFH<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public IDMPLFJCGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x35BE400", Offset = "0x35BD600", VA = "0x1835BE400")]
		internal void <.cctor>b__1(ref ENIPHNEFEPK writer, T value, FAPMHGNPHBA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class JFBAKIPBHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::OBNHHKECGPD<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
		public JFBAKIPBHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x35C0050", Offset = "0x35BF250", VA = "0x1835C0050")]
		internal T <.cctor>b__2(ref FNJBADGOFFA reader, FAPMHGNPHBA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::POIFPFPKEBM<T> CHAHEFOBEHP;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> HEMFHGKJKME;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::NGGJIPACEFH<T> AHOEABPOFNB;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::OBNHHKECGPD<T> EFNFOMGDHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool DGMBOHNMEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::NGGJIPACEFH<T> PCKFAOIKPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::OBNHHKECGPD<T> PHNLPPGAEIE;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x35B7530", Offset = "0x35B6730", VA = "0x1835B7530")]
	static CIEHIMMPLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x35B83B0", Offset = "0x35B75B0", VA = "0x1835B83B0")]
	public CIEHIMMPLCA(bool DGMBOHNMEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x35B6310", Offset = "0x35B5510", VA = "0x1835B6310", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x35B5FD0", Offset = "0x35B51D0", VA = "0x1835B5FD0", Slot = "5")]
	public T KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x35B5840", Offset = "0x35B4A40", VA = "0x1835B5840", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, T EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x35B59E0", Offset = "0x35B4BE0", VA = "0x1835B59E0", Slot = "7")]
	public T FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class EBPGODOEJAI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class GKBNOFOCJAH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class GKAGENIHDBL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class IMNOJNCMNED<T> : global::ANGGPBBBOPJ<T?>, BNLFGEJDIDK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EE50", Offset = "0x3A4E050", VA = "0x183A4EE50", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, T? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ECA0", Offset = "0x3A4DEA0", VA = "0x183A4ECA0", Slot = "5")]
	public T? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1BB4F60", Offset = "0x1BB4160", VA = "0x181BB4F60")]
	public IMNOJNCMNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class OILNGINIHGD<T> : global::ANGGPBBBOPJ<T?>, BNLFGEJDIDK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::ANGGPBBBOPJ<T> KDMCBJKLPMD;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2243CC0", Offset = "0x2242EC0", VA = "0x182243CC0")]
	public OILNGINIHGD(global::ANGGPBBBOPJ<T> KDMCBJKLPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B320", Offset = "0x2E6A520", VA = "0x182E6B320", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, T? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2E69C20", Offset = "0x2E68E20", VA = "0x182E69C20", Slot = "5")]
	public T? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class HJMLMFPLOOD : global::ANGGPBBBOPJ<sbyte>, BNLFGEJDIDK, global::MHEOENCCDHL<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly HJMLMFPLOOD NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x331FE60", Offset = "0x331F060", VA = "0x18331FE60", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, sbyte EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x331FE50", Offset = "0x331F050", VA = "0x18331FE50", Slot = "5")]
	public sbyte KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x331FDA0", Offset = "0x331EFA0", VA = "0x18331FDA0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, sbyte EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x331FDE0", Offset = "0x331EFE0", VA = "0x18331FDE0", Slot = "7")]
	public sbyte FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public HJMLMFPLOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class GFBKPCPILNI : global::ANGGPBBBOPJ<sbyte?>, BNLFGEJDIDK, global::MHEOENCCDHL<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly GFBKPCPILNI NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x331DA90", Offset = "0x331CC90", VA = "0x18331DA90", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, sbyte? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x331DA20", Offset = "0x331CC20", VA = "0x18331DA20", Slot = "5")]
	public sbyte? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x331D8F0", Offset = "0x331CAF0", VA = "0x18331D8F0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, sbyte? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x331D970", Offset = "0x331CB70", VA = "0x18331D970", Slot = "7")]
	public sbyte? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public GFBKPCPILNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class MHLMALPOCKK : global::ANGGPBBBOPJ<sbyte[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly MHLMALPOCKK NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4A33ED0", Offset = "0x4A330D0", VA = "0x184A33ED0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, sbyte[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4A33D90", Offset = "0x4A32F90", VA = "0x184A33D90", Slot = "5")]
	public sbyte[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public MHLMALPOCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class PHODIPDKMHP : global::ANGGPBBBOPJ<short>, BNLFGEJDIDK, global::MHEOENCCDHL<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PHODIPDKMHP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AB20", Offset = "0x4A39D20", VA = "0x184A3AB20", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, short EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AB10", Offset = "0x4A39D10", VA = "0x184A3AB10", Slot = "5")]
	public short KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AA60", Offset = "0x4A39C60", VA = "0x184A3AA60", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, short EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AAA0", Offset = "0x4A39CA0", VA = "0x184A3AAA0", Slot = "7")]
	public short FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PHODIPDKMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class BLDMMDPOKPF : global::ANGGPBBBOPJ<short?>, BNLFGEJDIDK, global::MHEOENCCDHL<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly BLDMMDPOKPF NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3086630", Offset = "0x3085830", VA = "0x183086630", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, short? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3086580", Offset = "0x3085780", VA = "0x183086580", Slot = "5")]
	public short? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x30863B0", Offset = "0x30855B0", VA = "0x1830863B0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, short? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x30864B0", Offset = "0x30856B0", VA = "0x1830864B0", Slot = "7")]
	public short? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BLDMMDPOKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CJKFMNAELHA : global::ANGGPBBBOPJ<short[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly CJKFMNAELHA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x308BD40", Offset = "0x308AF40", VA = "0x18308BD40", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, short[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x308BBA0", Offset = "0x308ADA0", VA = "0x18308BBA0", Slot = "5")]
	public short[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CJKFMNAELHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LBBEEIOINMA : global::ANGGPBBBOPJ<int>, BNLFGEJDIDK, global::MHEOENCCDHL<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LBBEEIOINMA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A30240", Offset = "0x4A2F440", VA = "0x184A30240", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, int EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A30230", Offset = "0x4A2F430", VA = "0x184A30230", Slot = "5")]
	public int KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A30180", Offset = "0x4A2F380", VA = "0x184A30180", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, int EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A301C0", Offset = "0x4A2F3C0", VA = "0x184A301C0", Slot = "7")]
	public int FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public LBBEEIOINMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class PPEKNGEHCFA : global::ANGGPBBBOPJ<int?>, BNLFGEJDIDK, global::MHEOENCCDHL<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly PPEKNGEHCFA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AD30", Offset = "0x4A39F30", VA = "0x184A3AD30", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, int? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A3ACC0", Offset = "0x4A39EC0", VA = "0x184A3ACC0", Slot = "5")]
	public int? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A3ABA0", Offset = "0x4A39DA0", VA = "0x184A3ABA0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, int? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AC20", Offset = "0x4A39E20", VA = "0x184A3AC20", Slot = "7")]
	public int? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PPEKNGEHCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class KDJFDKKNJIO : global::ANGGPBBBOPJ<int[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KDJFDKKNJIO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E200", Offset = "0x4A2D400", VA = "0x184A2E200", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, int[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E0C0", Offset = "0x4A2D2C0", VA = "0x184A2E0C0", Slot = "5")]
	public int[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public KDJFDKKNJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class JCGBKHGBGDK : global::ANGGPBBBOPJ<long>, BNLFGEJDIDK, global::MHEOENCCDHL<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly JCGBKHGBGDK NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3323DA0", Offset = "0x3322FA0", VA = "0x183323DA0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, long EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3323D90", Offset = "0x3322F90", VA = "0x183323D90", Slot = "5")]
	public long KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3323CE0", Offset = "0x3322EE0", VA = "0x183323CE0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, long EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3323D20", Offset = "0x3322F20", VA = "0x183323D20", Slot = "7")]
	public long FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public JCGBKHGBGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class EKGLJOOOOBP : global::ANGGPBBBOPJ<long?>, BNLFGEJDIDK, global::MHEOENCCDHL<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly EKGLJOOOOBP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x308F940", Offset = "0x308EB40", VA = "0x18308F940", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, long? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x308F8B0", Offset = "0x308EAB0", VA = "0x18308F8B0", Slot = "5")]
	public long? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x308F6F0", Offset = "0x308E8F0", VA = "0x18308F6F0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, long? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x308F7F0", Offset = "0x308E9F0", VA = "0x18308F7F0", Slot = "7")]
	public long? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public EKGLJOOOOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class ANDFABIOFPO : global::ANGGPBBBOPJ<long[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly ANDFABIOFPO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x30839F0", Offset = "0x3082BF0", VA = "0x1830839F0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, long[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3083850", Offset = "0x3082A50", VA = "0x183083850", Slot = "5")]
	public long[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public ANDFABIOFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class FIHGDGPONAO : global::ANGGPBBBOPJ<byte>, BNLFGEJDIDK, global::MHEOENCCDHL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly FIHGDGPONAO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3096310", Offset = "0x3095510", VA = "0x183096310", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, byte EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x30962B0", Offset = "0x30954B0", VA = "0x1830962B0", Slot = "5")]
	public byte KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3096150", Offset = "0x3095350", VA = "0x183096150", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, byte EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3096210", Offset = "0x3095410", VA = "0x183096210", Slot = "7")]
	public byte FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public FIHGDGPONAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class JAKFPLPGBBF : global::ANGGPBBBOPJ<byte?>, BNLFGEJDIDK, global::MHEOENCCDHL<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JAKFPLPGBBF NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3323A20", Offset = "0x3322C20", VA = "0x183323A20", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, byte? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x33239B0", Offset = "0x3322BB0", VA = "0x1833239B0", Slot = "5")]
	public byte? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3323880", Offset = "0x3322A80", VA = "0x183323880", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, byte? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3323900", Offset = "0x3322B00", VA = "0x183323900", Slot = "7")]
	public byte? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public JAKFPLPGBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class AKFHKNKDBBO : global::ANGGPBBBOPJ<ushort>, BNLFGEJDIDK, global::MHEOENCCDHL<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly AKFHKNKDBBO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3083370", Offset = "0x3082570", VA = "0x183083370", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ushort EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3083310", Offset = "0x3082510", VA = "0x183083310", Slot = "5")]
	public ushort KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x30831B0", Offset = "0x30823B0", VA = "0x1830831B0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, ushort EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3083270", Offset = "0x3082470", VA = "0x183083270", Slot = "7")]
	public ushort FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public AKFHKNKDBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class BKKKLKMCEHO : global::ANGGPBBBOPJ<ushort?>, BNLFGEJDIDK, global::MHEOENCCDHL<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly BKKKLKMCEHO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x30862D0", Offset = "0x30854D0", VA = "0x1830862D0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ushort? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3086220", Offset = "0x3085420", VA = "0x183086220", Slot = "5")]
	public ushort? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3086050", Offset = "0x3085250", VA = "0x183086050", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, ushort? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3086150", Offset = "0x3085350", VA = "0x183086150", Slot = "7")]
	public ushort? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BKKKLKMCEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class CBHBCMPKECA : global::ANGGPBBBOPJ<ushort[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly CBHBCMPKECA NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3086E00", Offset = "0x3086000", VA = "0x183086E00", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ushort[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3086C60", Offset = "0x3085E60", VA = "0x183086C60", Slot = "5")]
	public ushort[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CBHBCMPKECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class CDAFKDFJOIL : global::ANGGPBBBOPJ<uint>, BNLFGEJDIDK, global::MHEOENCCDHL<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CDAFKDFJOIL NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3087300", Offset = "0x3086500", VA = "0x183087300", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, uint EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x30872A0", Offset = "0x30864A0", VA = "0x1830872A0", Slot = "5")]
	public uint KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3087140", Offset = "0x3086340", VA = "0x183087140", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, uint EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3087200", Offset = "0x3086400", VA = "0x183087200", Slot = "7")]
	public uint FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CDAFKDFJOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class JEFEMJBALMG : global::ANGGPBBBOPJ<uint?>, BNLFGEJDIDK, global::MHEOENCCDHL<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JEFEMJBALMG NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3324250", Offset = "0x3323450", VA = "0x183324250", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, uint? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x33241E0", Offset = "0x33233E0", VA = "0x1833241E0", Slot = "5")]
	public uint? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x33240C0", Offset = "0x33232C0", VA = "0x1833240C0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, uint? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3324140", Offset = "0x3323340", VA = "0x183324140", Slot = "7")]
	public uint? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public JEFEMJBALMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class DOMNGGJLDKG : global::ANGGPBBBOPJ<uint[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly DOMNGGJLDKG NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x308EE00", Offset = "0x308E000", VA = "0x18308EE00", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, uint[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x308EC60", Offset = "0x308DE60", VA = "0x18308EC60", Slot = "5")]
	public uint[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public DOMNGGJLDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class CIEOBBFFOON : global::ANGGPBBBOPJ<ulong>, BNLFGEJDIDK, global::MHEOENCCDHL<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly CIEOBBFFOON NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x308A230", Offset = "0x3089430", VA = "0x18308A230", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ulong EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x308A220", Offset = "0x3089420", VA = "0x18308A220", Slot = "5")]
	public ulong KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x308A0F0", Offset = "0x30892F0", VA = "0x18308A0F0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, ulong EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x308A1B0", Offset = "0x30893B0", VA = "0x18308A1B0", Slot = "7")]
	public ulong FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CIEOBBFFOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LBLBEIJBLGP : global::ANGGPBBBOPJ<ulong?>, BNLFGEJDIDK, global::MHEOENCCDHL<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly LBLBEIJBLGP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4A30480", Offset = "0x4A2F680", VA = "0x184A30480", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ulong? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4A303F0", Offset = "0x4A2F5F0", VA = "0x184A303F0", Slot = "5")]
	public ulong? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4A302B0", Offset = "0x4A2F4B0", VA = "0x184A302B0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, ulong? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4A30330", Offset = "0x4A2F530", VA = "0x184A30330", Slot = "7")]
	public ulong? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public LBLBEIJBLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MCEJFDOHJPO : global::ANGGPBBBOPJ<ulong[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly MCEJFDOHJPO NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4A33420", Offset = "0x4A32620", VA = "0x184A33420", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ulong[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x4A332E0", Offset = "0x4A324E0", VA = "0x184A332E0", Slot = "5")]
	public ulong[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public MCEJFDOHJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class PBPIMOAPCOM : global::ANGGPBBBOPJ<float>, BNLFGEJDIDK, global::MHEOENCCDHL<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly PBPIMOAPCOM NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A940", Offset = "0x4A39B40", VA = "0x184A3A940", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, float EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A930", Offset = "0x4A39B30", VA = "0x184A3A930", Slot = "5")]
	public float KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A880", Offset = "0x4A39A80", VA = "0x184A3A880", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, float EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3A8C0", Offset = "0x4A39AC0", VA = "0x184A3A8C0", Slot = "7")]
	public float FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PBPIMOAPCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LINMEKOCAFP : global::ANGGPBBBOPJ<float?>, BNLFGEJDIDK, global::MHEOENCCDHL<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly LINMEKOCAFP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4A308D0", Offset = "0x4A2FAD0", VA = "0x184A308D0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, float? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4A30860", Offset = "0x4A2FA60", VA = "0x184A30860", Slot = "5")]
	public float? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4A30740", Offset = "0x4A2F940", VA = "0x184A30740", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, float? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4A307C0", Offset = "0x4A2F9C0", VA = "0x184A307C0", Slot = "7")]
	public float? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public LINMEKOCAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class DNJJILEJAHI : global::ANGGPBBBOPJ<float[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly DNJJILEJAHI NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x308EA80", Offset = "0x308DC80", VA = "0x18308EA80", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, float[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x308E8E0", Offset = "0x308DAE0", VA = "0x18308E8E0", Slot = "5")]
	public float[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public DNJJILEJAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class DLFMKDOCIIM : global::ANGGPBBBOPJ<double>, BNLFGEJDIDK, global::MHEOENCCDHL<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly DLFMKDOCIIM NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x308E870", Offset = "0x308DA70", VA = "0x18308E870", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, double EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x308E860", Offset = "0x308DA60", VA = "0x18308E860", Slot = "5")]
	public double KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x308E710", Offset = "0x308D910", VA = "0x18308E710", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, double EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x308E7C0", Offset = "0x308D9C0", VA = "0x18308E7C0", Slot = "7")]
	public double FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public DLFMKDOCIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class KGNMHLCICJC : global::ANGGPBBBOPJ<double?>, BNLFGEJDIDK, global::MHEOENCCDHL<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly KGNMHLCICJC NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E770", Offset = "0x4A2D970", VA = "0x184A2E770", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, double? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E6E0", Offset = "0x4A2D8E0", VA = "0x184A2E6E0", Slot = "5")]
	public double? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E5A0", Offset = "0x4A2D7A0", VA = "0x184A2E5A0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, double? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E620", Offset = "0x4A2D820", VA = "0x184A2E620", Slot = "7")]
	public double? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public KGNMHLCICJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KMEHKAFJAPP : global::ANGGPBBBOPJ<double[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly KMEHKAFJAPP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4A2EFF0", Offset = "0x4A2E1F0", VA = "0x184A2EFF0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, double[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4A2EEB0", Offset = "0x4A2E0B0", VA = "0x184A2EEB0", Slot = "5")]
	public double[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public KMEHKAFJAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class BOAMNLGCKEN : global::ANGGPBBBOPJ<bool>, BNLFGEJDIDK, global::MHEOENCCDHL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly BOAMNLGCKEN NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x30869C0", Offset = "0x3085BC0", VA = "0x1830869C0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, bool EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x30869B0", Offset = "0x3085BB0", VA = "0x1830869B0", Slot = "5")]
	public bool KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x3086890", Offset = "0x3085A90", VA = "0x183086890", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, bool EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x3086940", Offset = "0x3085B40", VA = "0x183086940", Slot = "7")]
	public bool FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BOAMNLGCKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EOAHPGENKJP : global::ANGGPBBBOPJ<bool?>, BNLFGEJDIDK, global::MHEOENCCDHL<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly EOAHPGENKJP NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x30911E0", Offset = "0x30903E0", VA = "0x1830911E0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, bool? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3091170", Offset = "0x3090370", VA = "0x183091170", Slot = "5")]
	public bool? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3090FD0", Offset = "0x30901D0", VA = "0x183090FD0", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, bool? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x30910C0", Offset = "0x30902C0", VA = "0x1830910C0", Slot = "7")]
	public bool? FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public EOAHPGENKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class CPMDBIJBBLB : global::ANGGPBBBOPJ<bool[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly CPMDBIJBBLB NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x308C9F0", Offset = "0x308BBF0", VA = "0x18308C9F0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, bool[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x308C850", Offset = "0x308BA50", VA = "0x18308C850", Slot = "5")]
	public bool[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CPMDBIJBBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class CEDDFJDNPFA : global::ANGGPBBBOPJ<object>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::ANGGPBBBOPJ<object> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> GMEHFHBJPGN;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x30876F0", Offset = "0x30868F0", VA = "0x1830876F0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, object EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3087390", Offset = "0x3086590", VA = "0x183087390", Slot = "5")]
	public object KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public CEDDFJDNPFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class BEIMDHLPBMO : global::ANGGPBBBOPJ<byte[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::ANGGPBBBOPJ<byte[]> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x30845A0", Offset = "0x30837A0", VA = "0x1830845A0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, byte[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3084520", Offset = "0x3083720", VA = "0x183084520", Slot = "5")]
	public byte[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public BEIMDHLPBMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class FKKHEDPOIKB : global::ANGGPBBBOPJ<ArraySegment<byte>>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::ANGGPBBBOPJ<ArraySegment<byte>> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3096900", Offset = "0x3095B00", VA = "0x183096900", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, ArraySegment<byte> EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3096830", Offset = "0x3095A30", VA = "0x183096830", Slot = "5")]
	public ArraySegment<byte> KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public FKKHEDPOIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MCCPMNGBMNK : global::ANGGPBBBOPJ<string>, BNLFGEJDIDK, global::MHEOENCCDHL<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::ANGGPBBBOPJ<string> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4A33250", Offset = "0x4A32450", VA = "0x184A33250", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, string EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4A33270", Offset = "0x4A32470", VA = "0x184A33270", Slot = "5")]
	public string KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4A33250", Offset = "0x4A32450", VA = "0x184A33250", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, string EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4A33270", Offset = "0x4A32470", VA = "0x184A33270", Slot = "7")]
	public string FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public MCCPMNGBMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NGKDGBHPIPI : global::ANGGPBBBOPJ<string[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly NGKDGBHPIPI NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4A37BE0", Offset = "0x4A36DE0", VA = "0x184A37BE0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, string[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4A37AA0", Offset = "0x4A36CA0", VA = "0x184A37AA0", Slot = "5")]
	public string[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public NGKDGBHPIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class NINIPABNPPB : global::ANGGPBBBOPJ<char>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly NINIPABNPPB NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x4A37FC0", Offset = "0x4A371C0", VA = "0x184A37FC0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, char EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4A37F90", Offset = "0x4A37190", VA = "0x184A37F90", Slot = "5")]
	public char KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public NINIPABNPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class NGMEIIENBCM : global::ANGGPBBBOPJ<char?>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly NGMEIIENBCM NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4A37DC0", Offset = "0x4A36FC0", VA = "0x184A37DC0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, char? EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4A37D00", Offset = "0x4A36F00", VA = "0x184A37D00", Slot = "5")]
	public char? KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public NGMEIIENBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class FINGJCKOKLM : global::ANGGPBBBOPJ<char[]>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly FINGJCKOKLM NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x3096590", Offset = "0x3095790", VA = "0x183096590", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, char[] EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x30963B0", Offset = "0x30955B0", VA = "0x1830963B0", Slot = "5")]
	public char[] KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public FINGJCKOKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class KEDLGMPAPLJ : global::ANGGPBBBOPJ<Guid>, BNLFGEJDIDK, global::MHEOENCCDHL<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::ANGGPBBBOPJ<Guid> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E460", Offset = "0x4A2D660", VA = "0x184A2E460", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Guid EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E400", Offset = "0x4A2D600", VA = "0x184A2E400", Slot = "5")]
	public Guid KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E320", Offset = "0x4A2D520", VA = "0x184A2E320", Slot = "6")]
	public void DCNBKDKAKBI(ref ENIPHNEFEPK NJHDOODAJCH, Guid EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4A2E400", Offset = "0x4A2D600", VA = "0x184A2E400", Slot = "7")]
	public Guid FAFKIJHHNLI(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public KEDLGMPAPLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class NEDPDCMIKDK : global::ANGGPBBBOPJ<decimal>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::ANGGPBBBOPJ<decimal> NGDBMKAAJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool FBDNFEHFPNI;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xB05570", Offset = "0xB04770", VA = "0x180B05570")]
	public NEDPDCMIKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x17A5150", Offset = "0x17A4350", VA = "0x1817A5150")]
	public NEDPDCMIKDK(bool FBDNFEHFPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4A36120", Offset = "0x4A35320", VA = "0x184A36120", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, decimal EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4A35F70", Offset = "0x4A35170", VA = "0x184A35F70", Slot = "5")]
	public decimal KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class EMEIGBODEOG : global::ANGGPBBBOPJ<Uri>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::ANGGPBBBOPJ<Uri> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x308FAA0", Offset = "0x308ECA0", VA = "0x18308FAA0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Uri EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x308FA20", Offset = "0x308EC20", VA = "0x18308FA20", Slot = "5")]
	public Uri KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public EMEIGBODEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class HMFJPKFFACB : global::ANGGPBBBOPJ<Version>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::ANGGPBBBOPJ<Version> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x331FF60", Offset = "0x331F160", VA = "0x18331FF60", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Version EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x331FEE0", Offset = "0x331F0E0", VA = "0x18331FEE0", Slot = "5")]
	public Version KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public HMFJPKFFACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class FGLNOEONDHK<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class OFFMLBMHEHF : global::ANGGPBBBOPJ<StringBuilder>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::ANGGPBBBOPJ<StringBuilder> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4A38670", Offset = "0x4A37870", VA = "0x184A38670", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, StringBuilder EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4A385F0", Offset = "0x4A377F0", VA = "0x184A385F0", Slot = "5")]
	public StringBuilder KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public OFFMLBMHEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class LPDPPCOEMDD : global::ANGGPBBBOPJ<BitArray>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::ANGGPBBBOPJ<BitArray> NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4A32DB0", Offset = "0x4A31FB0", VA = "0x184A32DB0", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, BitArray EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x4A32CB0", Offset = "0x4A31EB0", VA = "0x184A32CB0", Slot = "5")]
	public BitArray KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public LPDPPCOEMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class NNEOLAHIBPI : global::ANGGPBBBOPJ<Type>, BNLFGEJDIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly NNEOLAHIBPI NGDBMKAAJLD;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex CGDKCPKKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool PFFNIBEIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool DENFJEEFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool GLGHKIPPJLE;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4A384E0", Offset = "0x4A376E0", VA = "0x184A384E0")]
	public NNEOLAHIBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4A38490", Offset = "0x4A37690", VA = "0x184A38490")]
	public NNEOLAHIBPI(bool PFFNIBEIOOM, bool DENFJEEFIDM, bool GLGHKIPPJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x4A38300", Offset = "0x4A37500", VA = "0x184A38300", Slot = "4")]
	public void NOCAHNNOEGM(ref ENIPHNEFEPK NJHDOODAJCH, Type EOEMKDLOAGI, FAPMHGNPHBA IIOOGHAKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x4A381E0", Offset = "0x4A373E0", VA = "0x184A381E0", Slot = "5")]
	public Type KOBBCLPENCC(ref FNJBADGOFFA GIFABBPOCAN, FAPMHGNPHBA IIOOGHAKJGF)
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
