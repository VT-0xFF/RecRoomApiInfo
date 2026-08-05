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

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class DLMIHHHGJPN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D27120", Offset = "0x6D26320", VA = "0x186D27120")]
	public static bool JHNELJPNKNF(this TypeInfo HHJOOHJDNNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class DJMKJFKJLHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DHCBIJNMECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] ODJAMDOMGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
	public DJMKJFKJLHH(Type ELDLCFKLOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class JDPMCAMACCF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NIDMMKALCNK<T>(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T MLHEIDONAGP<T>(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD MPHDDJAMFDH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DIGEJECCEIM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EALLCKLMLAA<T> : DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DCIBAAGBONL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NDLBDHLBNDL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class PODCILKPCPL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B19B50", Offset = "0x2B18D50", VA = "0x182B19B50")]
	public static string DPBHLKMJJGO<T>(this EALLCKLMLAA<T> NKMMLJBBJFF, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EALLCKLMLAA<T> LBPBIKGKEGG<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DNAHOHMEDJB
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2809840", Offset = "0x2808A40", VA = "0x182809840")]
	public static EALLCKLMLAA<T> ACBCOODGBAM<T>(this DLKMGGPEHOD MPHDDJAMFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D27150", Offset = "0x6D26350", VA = "0x186D27150")]
	public static object FEIIINOLCHM(this DLKMGGPEHOD MPHDDJAMFDH, Type HHJOOHJDNNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NHGLAPIHBIE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BF60", Offset = "0x6D3B160", VA = "0x186D3BF60")]
	public NHGLAPIHBIE(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DOMGOGFMLMG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class MHBBIADLACF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] OPMKPGEDLGD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] MBPDNNJAKHO;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D39F20", Offset = "0x6D39120", VA = "0x186D39F20")]
		public static byte[] FBCGGKAGOAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D39FC0", Offset = "0x6D391C0", VA = "0x186D39FC0")]
		public static char[] PEPEDGKNFJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> ABCGKDCJJPD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] GGDBOCCHOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] PGPEJDBBJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CFPEDCFCDGK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JPLFGAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D295C0", Offset = "0x6D287C0", VA = "0x186D295C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A700", Offset = "0x6D29900", VA = "0x186D2A700")]
	public DOMGOGFMLMG(byte[] PGPEJDBBJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A5A0", Offset = "0x6D297A0", VA = "0x186D2A5A0")]
	public DOMGOGFMLMG(byte[] PGPEJDBBJED, int CFPEDCFCDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D29D60", Offset = "0x6D28F60", VA = "0x186D29D60")]
	private CKPPDDEIICF OFNFEHNLDLO(string PIKKHJJOOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D27B30", Offset = "0x6D26D30", VA = "0x186D27B30")]
	private CKPPDDEIICF BGELCJNKJMI(string PPGBBBOBJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D29C30", Offset = "0x6D28E30", VA = "0x186D29C30")]
	public void OCDFADCPANP(int CFPEDCFCDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public byte[] BJHIBIJIKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
	public int GDBCGHNJDHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D29A80", Offset = "0x6D28C80", VA = "0x186D29A80")]
	public HFOMDHMCGNJ NMFKLNJBIKO()
	{
		return default(HFOMDHMCGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D27710", Offset = "0x6D26910", VA = "0x186D27710")]
	public void ALDOEHIEDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D29C40", Offset = "0x6D28E40", VA = "0x186D29C40")]
	public bool ODEHKDELCDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D29280", Offset = "0x6D28480", VA = "0x186D29280")]
	public bool HJJLMEJAEOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D284D0", Offset = "0x6D276D0", VA = "0x186D284D0")]
	public void ELMAJCLOEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D27F20", Offset = "0x6D27120", VA = "0x186D27F20")]
	public bool DKBLHBHGEGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D29750", Offset = "0x6D28950", VA = "0x186D29750")]
	public bool MFDEDINHPED(int BIFLOKBJAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D27840", Offset = "0x6D26A40", VA = "0x186D27840")]
	public bool AOECOPEMANM(int BIFLOKBJAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D29310", Offset = "0x6D28510", VA = "0x186D29310")]
	public bool HLJLLILBCGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D28430", Offset = "0x6D27630", VA = "0x186D28430")]
	public void EHBIFNMECPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D291F0", Offset = "0x6D283F0", VA = "0x186D291F0")]
	public bool HAKJILMDKEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D28730", Offset = "0x6D27930", VA = "0x186D28730")]
	public bool GBOICMFJOFH(int BIFLOKBJAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D27580", Offset = "0x6D26780", VA = "0x186D27580")]
	public bool AIEKKLBCJLK(int BIFLOKBJAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D27AA0", Offset = "0x6D26CA0", VA = "0x186D27AA0")]
	public bool BFGEHHOJDEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D299E0", Offset = "0x6D28BE0", VA = "0x186D299E0")]
	public void NKHCFCGBOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D27CA0", Offset = "0x6D26EA0", VA = "0x186D27CA0")]
	public bool BLJHEKJJOKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D294A0", Offset = "0x6D286A0", VA = "0x186D294A0")]
	public void JFOCKKOENDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D28A50", Offset = "0x6D27C50", VA = "0x186D28A50")]
	private void GGNHPJOOJHG([Out] byte[] EKGGEFPBHBE, [Out] int ECMMPHAFMPL, [Out] int KJFCOLAGLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D27D30", Offset = "0x6D26F30", VA = "0x186D27D30")]
	private static int CBIFBHJAGEO(char BPOHBPAMNLC, char NOIIDJMAOFK, char HHHFIGOCAOB, char PIKGAJBAGIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A3A0", Offset = "0x6D295A0", VA = "0x186D2A3A0")]
	private static int PKFHHEMEAOF(char DCHJALFCEJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D27980", Offset = "0x6D26B80", VA = "0x186D27980")]
	public ArraySegment<byte> BBGALKDBDGC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A2C0", Offset = "0x6D294C0", VA = "0x186D2A2C0")]
	public string PEFLMIKGMJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D27910", Offset = "0x6D26B10", VA = "0x186D27910")]
	public string AOEEGCKEKOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D28210", Offset = "0x6D27410", VA = "0x186D28210")]
	public ArraySegment<byte> EDAAAILJMAP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D28570", Offset = "0x6D27770", VA = "0x186D28570")]
	public ArraySegment<byte> ENHOLFJLPAA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D28800", Offset = "0x6D27A00", VA = "0x186D28800")]
	public bool GGEIIJKGINH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D29820", Offset = "0x6D28A20", VA = "0x186D29820")]
	private static bool NAPOIIDBPDL(byte HHHFIGOCAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D272B0", Offset = "0x6D264B0", VA = "0x186D272B0")]
	private void ADGLBANBLIG(HFOMDHMCGNJ CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D286E0", Offset = "0x6D278E0", VA = "0x186D286E0")]
	public void GBEMEGBBADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D280B0", Offset = "0x6D272B0", VA = "0x186D280B0")]
	private void DOALHCDCAJM(int NONACBNAPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D293A0", Offset = "0x6D285A0", VA = "0x186D293A0")]
	public sbyte ICPPJAHDKIC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D29540", Offset = "0x6D28740", VA = "0x186D29540")]
	public short KICPGDHPPLL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D29420", Offset = "0x6D28620", VA = "0x186D29420")]
	public int IMPDBPFBCAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D27DE0", Offset = "0x6D26FE0", VA = "0x186D27DE0")]
	public long CGLJCACHKIP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D27500", Offset = "0x6D26700", VA = "0x186D27500")]
	public byte AFCCFFHKPMK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D27C20", Offset = "0x6D26E20", VA = "0x186D27C20")]
	public ushort BLDOBOGDEHA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D27EA0", Offset = "0x6D270A0", VA = "0x186D27EA0")]
	public uint CPIGNGLLHCK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D27650", Offset = "0x6D26850", VA = "0x186D27650")]
	public ulong AIOPHCNJHAJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D298E0", Offset = "0x6D28AE0", VA = "0x186D298E0")]
	public float NBHFNCGIJDM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D27FB0", Offset = "0x6D271B0", VA = "0x186D27FB0")]
	public double DLBFIMILPPO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D285E0", Offset = "0x6D277E0", VA = "0x186D285E0")]
	public ArraySegment<byte> FJLJIGGBLCK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D295E0", Offset = "0x6D287E0", VA = "0x186D295E0")]
	private static int LBMMMIICLFO(byte[] PGPEJDBBJED, int CFPEDCFCDGK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKPPDDEIICF : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference NAJMFBIAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int DEIJIDNENIH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DJNLHOOGNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD0ECD0", Offset = "0xD0DED0", VA = "0x180D0ECD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IFBLJHILJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x919440", Offset = "0x918640", VA = "0x180919440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D26E50", Offset = "0x6D26050", VA = "0x186D26E50")]
	public CKPPDDEIICF(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D26EB0", Offset = "0x6D260B0", VA = "0x186D26EB0")]
	public CKPPDDEIICF(string PPGBBBOBJLN, byte[] PMNGDNIJNEK, int CFPEDCFCDGK, int DEIJIDNENIH, string BNDOBCIJCMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FDOFHLHNCCK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class MFEOGPKAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] OPMKPGEDLGD;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D39E80", Offset = "0x6D39080", VA = "0x186D39E80")]
		public static byte[] FBCGGKAGOAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HAABMAKEDNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void HELCDEOEKIF(NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object MHONLODPEAH(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD MPHDDJAMFDH);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class GIIDGDJNFDH
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class NCIFDKCCEDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
				public NCIFDKCCEDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x4A543C0", Offset = "0x4A535C0", VA = "0x184A543C0")]
				internal bool OIFAOIPEFFP(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6D3BCA0", Offset = "0x6D3AEA0", VA = "0x186D3BCA0")]
				internal bool EFDFEDJDFHA(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, DLKMGGPEHOD, byte[]> IHAFEPLDBPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, DLKMGGPEHOD> JHBKHHDNODO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly HELCDEOEKIF OLPLLHKCOON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, DLKMGGPEHOD, ArraySegment<byte>> HIPKALDFMPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, DLKMGGPEHOD, string> MMLAFOFEPAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, DLKMGGPEHOD, object> FLBJCMABGPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, DLKMGGPEHOD, object> CDEMBOPECCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, DLKMGGPEHOD, object> KGKLAHHOIIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly MHONLODPEAH MIAFODDPJID;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6D352C0", Offset = "0x6D344C0", VA = "0x186D352C0")]
			public GIIDGDJNFDH(Type HHJOOHJDNNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2FAD9F0", Offset = "0x2FACBF0", VA = "0x182FAD9F0")]
			private static T CBIAEELNLPJ<T>(DynamicMethod OACGDCHFLJK)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6D35070", Offset = "0x6D34270", VA = "0x186D35070")]
			private static MethodInfo NJDBEDMCPEE(Type HHJOOHJDNNM, string IIADHBOODBK, Type[] GLLBHCKJGCM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, GIIDGDJNFDH> LANGGHKNBIM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly GENCCANBDFF<GIIDGDJNFDH> ONPFEAMIFDK;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D37D20", Offset = "0x6D36F20", VA = "0x186D37D20")]
		static HAABMAKEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D37CA0", Offset = "0x6D36EA0", VA = "0x186D37CA0")]
		private static GIIDGDJNFDH MNADKEBFJLE(Type HHJOOHJDNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D37B20", Offset = "0x6D36D20", VA = "0x186D37B20")]
		public static void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D37A10", Offset = "0x6D36C10", VA = "0x186D37A10")]
		public static void GKNEHCEDNDE(Type HHJOOHJDNNM, NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static DLKMGGPEHOD DHIGPDCIKCI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BBKMFHGMLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] LEIDCAFPBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static DLKMGGPEHOD MOPGMCBNAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B620", Offset = "0x6D2A820", VA = "0x186D2B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2BB50", Offset = "0x6D2AD50", VA = "0x186D2BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B130", Offset = "0x6D2A330", VA = "0x186D2B130")]
	public static void BMBKMCJOPGK(DLKMGGPEHOD MPHDDJAMFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2956470", Offset = "0x2955670", VA = "0x182956470")]
	public static byte[] GKNEHCEDNDE<T>(T CDJAKLIPEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2956300", Offset = "0x2955500", VA = "0x182956300")]
	public static byte[] GKNEHCEDNDE<T>(T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2956580", Offset = "0x2955780", VA = "0x182956580")]
	public static void GKNEHCEDNDE<T>(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2956940", Offset = "0x2955B40", VA = "0x182956940")]
	public static void GKNEHCEDNDE<T>(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29564F0", Offset = "0x29556F0", VA = "0x1829564F0")]
	public static void GKNEHCEDNDE<T>(Stream GBJPNMMPFPH, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2956610", Offset = "0x2955810", VA = "0x182956610")]
	public static void GKNEHCEDNDE<T>(Stream GBJPNMMPFPH, T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2957B40", Offset = "0x2956D40", VA = "0x182957B40")]
	public static ArraySegment<byte> IJNJKODPJOB<T>(T CDJAKLIPEBF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2957BD0", Offset = "0x2956DD0", VA = "0x182957BD0")]
	public static ArraySegment<byte> IJNJKODPJOB<T>(T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2956110", Offset = "0x2955310", VA = "0x182956110")]
	public static string DPBHLKMJJGO<T>(T HLCKBKFCMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2956190", Offset = "0x2955390", VA = "0x182956190")]
	public static string DPBHLKMJJGO<T>(T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2957A30", Offset = "0x2956C30", VA = "0x182957A30")]
	public static T IHPADLGFHBL<T>(string AJHNIBIOLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956B60", VA = "0x182957960")]
	public static T IHPADLGFHBL<T>(string AJHNIBIOLIF, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29572D0", Offset = "0x29564D0", VA = "0x1829572D0")]
	public static T IHPADLGFHBL<T>(byte[] PGPEJDBBJED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2957360", Offset = "0x2956560", VA = "0x182957360")]
	public static T IHPADLGFHBL<T>(byte[] PGPEJDBBJED, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2957AB0", Offset = "0x2956CB0", VA = "0x182957AB0")]
	public static T IHPADLGFHBL<T>(byte[] PGPEJDBBJED, int CFPEDCFCDGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2957140", Offset = "0x2956340", VA = "0x182957140")]
	public static T IHPADLGFHBL<T>(byte[] PGPEJDBBJED, int CFPEDCFCDGK, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29573F0", Offset = "0x29565F0", VA = "0x1829573F0")]
	public static T IHPADLGFHBL<T>(DOMGOGFMLMG LAAOMLILGHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2957570", Offset = "0x2956770", VA = "0x182957570")]
	public static T IHPADLGFHBL<T>(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29574F0", Offset = "0x29566F0", VA = "0x1829574F0")]
	public static T IHPADLGFHBL<T>(Stream GBJPNMMPFPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2957640", Offset = "0x2956840", VA = "0x182957640")]
	public static T IHPADLGFHBL<T>(Stream GBJPNMMPFPH, DLKMGGPEHOD MPHDDJAMFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B9F0", Offset = "0x6D2ABF0", VA = "0x186D2B9F0")]
	public static string EPHCGEKOIHB(byte[] AJHNIBIOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B720", Offset = "0x6D2A920", VA = "0x186D2B720")]
	public static string EPHCGEKOIHB(byte[] AJHNIBIOLIF, int CFPEDCFCDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B860", Offset = "0x6D2AA60", VA = "0x186D2B860")]
	public static string EPHCGEKOIHB(string AJHNIBIOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B1A0", Offset = "0x6D2A3A0", VA = "0x186D2B1A0")]
	public static byte[] CAGBJMLECOC(byte[] AJHNIBIOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B320", Offset = "0x6D2A520", VA = "0x186D2B320")]
	public static byte[] CAGBJMLECOC(byte[] AJHNIBIOLIF, int CFPEDCFCDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B470", Offset = "0x6D2A670", VA = "0x186D2B470")]
	public static byte[] CAGBJMLECOC(string AJHNIBIOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BC50", Offset = "0x6D2AE50", VA = "0x186D2BC50")]
	private static void NGMLNACKMAM(DOMGOGFMLMG LAAOMLILGHH, NKHADIMENKO AELHGGJOBCK, int CHGLFFFCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BBB0", Offset = "0x6D2ADB0", VA = "0x186D2BBB0")]
	private static int HPIJKENFIPH(Stream NBFGFAAMIMJ, byte[] OPMKPGEDLGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HFOMDHMCGNJ : byte
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
public struct NKHADIMENKO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PAIEJAMKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] OPMKPGEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CFPEDCFCDGK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HPOPNCNINLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D29C30", Offset = "0x6D28E30", VA = "0x186D29C30")]
	public void OCDFADCPANP(int CFPEDCFCDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D340", Offset = "0x6D3C540", VA = "0x186D3D340")]
	public static byte[] OOAHIAIFOGL(string HFIBFDNGBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C700", Offset = "0x6D3B900", VA = "0x186D3C700")]
	public static byte[] EIEAHPHPMEN(string HFIBFDNGBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C290", Offset = "0x6D3B490", VA = "0x186D3C290")]
	public static byte[] BPPHEPMCPAL(string HFIBFDNGBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C4C0", Offset = "0x6D3B6C0", VA = "0x186D3C4C0")]
	public static byte[] DLAEBDAKDGD(string HFIBFDNGBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58AE1F0", Offset = "0x58AD3F0", VA = "0x1858AE1F0")]
	public NKHADIMENKO(byte[] KNMAPOGHAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C920", Offset = "0x6D3BB20", VA = "0x186D3C920")]
	public ArraySegment<byte> FBCGGKAGOAC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C8B0", Offset = "0x6D3BAB0", VA = "0x186D3C8B0")]
	public byte[] EPMEIKHIKCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D540", Offset = "0x6D3C740", VA = "0x186D3D540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CEB0", Offset = "0x6D3C0B0", VA = "0x186D3CEB0")]
	public void JBFDHDHPFLB(int DADCJHNFIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CDF0", Offset = "0x6D3BFF0", VA = "0x186D3CDF0")]
	public void IGCIOOOFCAH(byte GBELGNAOJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CE50", Offset = "0x6D3C050", VA = "0x186D3CE50")]
	public void IGCIOOOFCAH(byte[] GBELGNAOJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C870", Offset = "0x6D3BA70", VA = "0x186D3C870")]
	public void ELIMDDFJAFC(byte GBELGNAOJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C9C0", Offset = "0x6D3BBC0", VA = "0x186D3C9C0")]
	public void FGNKAKDBKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D1E0", Offset = "0x6D3C3E0", VA = "0x186D3D1E0")]
	public void NCMCCBFEGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D4F0", Offset = "0x6D3C6F0", VA = "0x186D3D4F0")]
	public void PMBMMKAPEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CEC0", Offset = "0x6D3C0C0", VA = "0x186D3CEC0")]
	public void JHMMDPEAJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C6B0", Offset = "0x6D3B8B0", VA = "0x186D3C6B0")]
	public void ECKNGOMJIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CA10", Offset = "0x6D3BC10", VA = "0x186D3CA10")]
	public void GBDAFFBFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D2A0", Offset = "0x6D3C4A0", VA = "0x186D3D2A0")]
	public void NOMCOLOFLHD(string HFIBFDNGBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C470", Offset = "0x6D3B670", VA = "0x186D3C470")]
	public void DDADNADAEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CF10", Offset = "0x6D3C110", VA = "0x186D3CF10")]
	public void KLBGMLGMLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C130", Offset = "0x6D3B330", VA = "0x186D3C130")]
	public void ABAJDLODGIM(bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D020", Offset = "0x6D3C220", VA = "0x186D3D020")]
	public void LLKMIGGECIA(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D470", Offset = "0x6D3C670", VA = "0x186D3D470")]
	public void PLJDLCONMBG(double HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D0D0", Offset = "0x6D3C2D0", VA = "0x186D3D0D0")]
	public void MBNCFOFBNNL(byte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D170", Offset = "0x6D3C370", VA = "0x186D3D170")]
	public void MGGJPENGJLH(ushort HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C400", Offset = "0x6D3B600", VA = "0x186D3C400")]
	public void CLPJJIIAFIA(uint HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D0A0", Offset = "0x6D3C2A0", VA = "0x186D3D0A0")]
	public void LOLEAMEGJNK(ulong HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D230", Offset = "0x6D3C430", VA = "0x186D3D230")]
	public void NGFNBOKMCGF(sbyte HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CFB0", Offset = "0x6D3C1B0", VA = "0x186D3CFB0")]
	public void KNGBMJBHJOB(short HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C640", Offset = "0x6D3B840", VA = "0x186D3C640")]
	public void DOFOFINNHOL(int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D140", Offset = "0x6D3C340", VA = "0x186D3D140")]
	public void MELBDJIDKBE(long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CA60", Offset = "0x6D3BC60", VA = "0x186D3CA60")]
	public void HKEHOMHKBOI(string HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class OBCAKEGMGMF : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class FKLLHLMACMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3915880", Offset = "0x3914A80", VA = "0x183915880")]
		static FKLLHLMACMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private OBCAKEGMGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PMFNPENCAPB : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class CGGCKOANELB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4F86530", Offset = "0x4F85730", VA = "0x184F86530")]
		static CGGCKOANELB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class NPCOCPLEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> FDICHMELGAD;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D8A0", Offset = "0x6D3CAA0", VA = "0x186D3D8A0")]
		internal static object LBPBIKGKEGG(Type GIHFGGLMPDC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private PMFNPENCAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HAJAHEDPBGG : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class PMELJODPHEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x43C0280", Offset = "0x43BF480", VA = "0x1843C0280")]
		static PMELJODPHEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly HAJAHEDPBGG LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool PBHHJIBKGML;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static DIGEJECCEIM[] EMDEJDONBBK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static DLKMGGPEHOD[] KLBEPPLJPMG;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private HAJAHEDPBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D38100", Offset = "0x6D37300", VA = "0x186D38100")]
	public static void FLGJIGKCNJL(params DLKMGGPEHOD[] KLBEPPLJPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D381E0", Offset = "0x6D373E0", VA = "0x186D381E0")]
	public static void FLGJIGKCNJL(params DIGEJECCEIM[] EMDEJDONBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D37E70", Offset = "0x6D37070", VA = "0x186D37E70")]
	public static void AGBCALMLBCN(DIGEJECCEIM[] EMDEJDONBBK, DLKMGGPEHOD[] KLBEPPLJPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IBFACKEABCM : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class HFHBKHEMCKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A32390", Offset = "0x3A31590", VA = "0x183A32390")]
		static HFHBKHEMCKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private IBFACKEABCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PBIKMMLODNM
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly DLKMGGPEHOD DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DLKMGGPEHOD CIANEJPAKEA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly DLKMGGPEHOD MFIOJIPBNIK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly DLKMGGPEHOD HAPLPIMIAPF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly DLKMGGPEHOD DIPHLNMEIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DLKMGGPEHOD OBIFAECCADG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly DLKMGGPEHOD DOBLCDOBFHO;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly DLKMGGPEHOD MLDBCLOJNKF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly DLKMGGPEHOD PCLFMFIIJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly DLKMGGPEHOD MLILMFEPFBF;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DLKMGGPEHOD DIDJEIEJFGO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly DLKMGGPEHOD DFEOHJEIMKN;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class EMOBHKCJCFK
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly DLKMGGPEHOD DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly DLKMGGPEHOD JLDALLNBOGB;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EDIHKPIOHAO
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly DLKMGGPEHOD DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly DLKMGGPEHOD CIANEJPAKEA;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly DLKMGGPEHOD MFIOJIPBNIK;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly DLKMGGPEHOD HAPLPIMIAPF;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly DLKMGGPEHOD DIPHLNMEIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly DLKMGGPEHOD OBIFAECCADG;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly DLKMGGPEHOD DOBLCDOBFHO;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly DLKMGGPEHOD MLDBCLOJNKF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly DLKMGGPEHOD PCLFMFIIJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly DLKMGGPEHOD MLILMFEPFBF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly DLKMGGPEHOD DIDJEIEJFGO;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly DLKMGGPEHOD DFEOHJEIMKN;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class PEDBANHGHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> FDICHMELGAD;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D3FBE0", Offset = "0x6D3EDE0", VA = "0x186D3FBE0")]
	internal static object LBPBIKGKEGG(Type GIHFGGLMPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D41370", Offset = "0x6D40570", VA = "0x186D41370")]
	private static object MKBJNJIHLLL(Type LGFNOGNEOKO, Type[] PEIKPCNHIFK, params object[] GLLBHCKJGCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LJJCEJCGGGL : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class HBDJDIOBNJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A1EC80", Offset = "0x3A1DE80", VA = "0x183A1EC80")]
		static HBDJDIOBNJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D39D10", Offset = "0x6D38F10", VA = "0x186D39D10")]
	static LJJCEJCGGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private LJJCEJCGGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JGDNOHPOEIL : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class AOJADKAEGNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D85F80", Offset = "0x3D85180", VA = "0x183D85F80")]
		static AOJADKAEGNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D38A50", Offset = "0x6D37C50", VA = "0x186D38A50")]
	static JGDNOHPOEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private JGDNOHPOEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FAMJJMDIDFA : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class ECBDNIIPHKH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x35639C0", Offset = "0x3562BC0", VA = "0x1835639C0")]
		static ECBDNIIPHKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AFC0", Offset = "0x6D2A1C0", VA = "0x186D2AFC0")]
	static FAMJJMDIDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private FAMJJMDIDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NIDMLDOCIAN : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class BGEOGEKGAJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4A55D90", Offset = "0x4A54F90", VA = "0x184A55D90")]
		static BGEOGEKGAJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BFC0", Offset = "0x6D3B1C0", VA = "0x186D3BFC0")]
	static NIDMLDOCIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private NIDMLDOCIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FIOGCLJPHLN : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class CMBGGJPGDDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5153280", Offset = "0x5152480", VA = "0x185153280")]
		static CMBGGJPGDDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C6B0", Offset = "0x6D2B8B0", VA = "0x186D2C6B0")]
	static FIOGCLJPHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private FIOGCLJPHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BHMIKBMINHL : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class JBBPGFPDFLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CE70A0", Offset = "0x3CE62A0", VA = "0x183CE70A0")]
		static JBBPGFPDFLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly MIGKCMOCKBF KJEHFDBPOLG;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D26CE0", Offset = "0x6D25EE0", VA = "0x186D26CE0")]
	static BHMIKBMINHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private BHMIKBMINHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class EILCLBGJPFB : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class PPOPEJHNDPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x43EC5D0", Offset = "0x43EB7D0", VA = "0x1843EC5D0")]
		static PPOPEJHNDPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public EILCLBGJPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HIGFBIFPJMC : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class FDFGDFLBJNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38FCFB0", Offset = "0x38FC1B0", VA = "0x1838FCFB0")]
		static FDFGDFLBJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HIGFBIFPJMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class FOOBFNJNCNF : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class DLCNMJHOLAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x533E2E0", Offset = "0x533D4E0", VA = "0x18533E2E0")]
		static DLCNMJHOLAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FOOBFNJNCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class NDCAKCAIBGO : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class HLFBGOJMFNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A4BA20", Offset = "0x3A4AC20", VA = "0x183A4BA20")]
		static HLFBGOJMFNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NDCAKCAIBGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class DKAJEJGJPDH : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class ANFEOEAFCND<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D81440", Offset = "0x3D80640", VA = "0x183D81440")]
		static ANFEOEAFCND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DKAJEJGJPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class FLOKMPAGDNA : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class GNGNDBIFGOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x39E5550", Offset = "0x39E4750", VA = "0x1839E5550")]
		static GNGNDBIFGOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> GABJKDNHOKK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool IHGNEEEEKJA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FLOKMPAGDNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class GCNPEDHHKFK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct LNFLDEMIMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LIMGCBBNMEL CIGAMBAFCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder LLACEAEBEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder IJJHBFBFHEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class MKMCNBBAMLE
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class KLNHGJIGJMF
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo BPPHEPMCPAL;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo EIEAHPHPMEN;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo DLAEBDAKDGD;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo OOAHIAIFOGL;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo KLBGMLGMLDO;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo IGCIOOOFCAH;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo PMBMMKAPEHO;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo JHMMDPEAJJD;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo ECKNGOMJIAF;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6D38BF0", Offset = "0x6D37DF0", VA = "0x186D38BF0")]
			static KLNHGJIGJMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class GJMFFIHLGPM
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo ODEHKDELCDM;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo EHBIFNMECPE;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo GBOICMFJOFH;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo HMNPIMMDHJE;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo GBEMEGBBADN;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo BJHIBIJIKNP;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo GDBCGHNJDHM;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6D36E30", Offset = "0x6D36030", VA = "0x186D36E30")]
			static GJMFFIHLGPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class AIPFGGHDAMI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo DHCBIJNMECC;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo ODJAMDOMGOG;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo DKAFAEIADJK;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo ACBCOODGBAM;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo DMPLCMEBLEP;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo HAPNEHGMLNB;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo BONINIJKMOF;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo LOBDCPDLAOL;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo LJCKEHGDODJ;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo JPODBIHBIAA;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo MEDPLJNBLAG;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo ABCPBDALEIO;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo IIADGGCJDBH;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo OBGLDOFACHC;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A1A0", Offset = "0x6D393A0", VA = "0x186D3A1A0")]
		public static MethodInfo GKNEHCEDNDE(Type HHJOOHJDNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A430", Offset = "0x6D39630", VA = "0x186D3A430")]
		public static MethodInfo IHPADLGFHBL(Type HHJOOHJDNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A060", Offset = "0x6D39260", VA = "0x186D3A060")]
		public static MethodInfo EHFGHCBAFLE(Type HHJOOHJDNNM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class OOAHBDHMOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<LIMGCBBNMEL, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public OOAHBDHMOAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class AENJMNJOELK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public OOAHBDHMOAO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AENJMNJOELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D268E0", Offset = "0x6D25AE0", VA = "0x186D268E0")]
		internal void LNJIKJOGDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D26840", Offset = "0x6D25A40", VA = "0x186D26840")]
		internal bool GNIMDNKAJDK(int index, LIMGCBBNMEL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JEGEABELOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public OOAHBDHMOAO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JEGEABELOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D389B0", Offset = "0x6D37BB0", VA = "0x186D389B0")]
		internal bool LFLPENCIMHM(int index, LIMGCBBNMEL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OABHNMLJDED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public OABHNMLJDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x41AA470", Offset = "0x41A9670", VA = "0x1841AA470")]
		internal string KCAGNMLLGDK(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EFPJONGDKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EFPJONGDKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2ABF0", Offset = "0x6D29DF0", VA = "0x186D2ABF0")]
		internal bool EPDMMEDEDPA(LIMGCBBNMEL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class EGHLLCDLNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public OABHNMLJDED CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EGHLLCDLNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AC50", Offset = "0x6D29E50", VA = "0x186D2AC50")]
		internal void EBIPOONFFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AC60", Offset = "0x6D29E60", VA = "0x186D2AC60")]
		internal bool EELNBPJHHPA(int index, LIMGCBBNMEL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GGOPMNELLJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OABHNMLJDED CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GGOPMNELLJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D34EF0", Offset = "0x6D340F0", VA = "0x186D34EF0")]
		internal bool KIFBHKCEJEF(int index, LIMGCBBNMEL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JICIOHCFPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JICIOHCFPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6D38BC0", Offset = "0x6D37DC0", VA = "0x186D38BC0")]
		internal Label JDLNJLJBOKB(LIMGCBBNMEL _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HGIJFPMDGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LNFLDEMIMOH[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, LIMGCBBNMEL, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public HHENBCDLGDC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public HHENBCDLGDC argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HGIJFPMDGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D38710", Offset = "0x6D37910", VA = "0x186D38710")]
		internal LNFLDEMIMOH KEANHPMECJL(LIMGCBBNMEL item)
		{
			return default(LNFLDEMIMOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HCBGEDKGKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public HGIJFPMDGNG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HCBGEDKGKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D383E0", Offset = "0x6D375E0", VA = "0x186D383E0")]
		internal void BGOLKNNGIBI(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D38670", Offset = "0x6D37870", VA = "0x186D38670")]
		internal void NEKAMPBKFCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AOKDIPHAJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public LIMGCBBNMEL item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AOKDIPHAJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xC7A500", Offset = "0xC79700", VA = "0x180C7A500")]
		internal bool NIMPJKDPAJP(LNFLDEMIMOH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GNOOKDAACCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public LIMGCBBNMEL item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GNOOKDAACCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xC7A500", Offset = "0xC79700", VA = "0x180C7A500")]
		internal bool IKFGFBAMIKB(LNFLDEMIMOH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex ONBHEOHEHCG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int PLEIKELGMPE;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> JHBIIFMPFHK;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> HFFJMCFALDD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x297A9B0", Offset = "0x2979BB0", VA = "0x18297A9B0")]
	public static object MJHOGEIOIJH<T>(MIGKCMOCKBF KJEHFDBPOLG, DLKMGGPEHOD NKBOLLDCNPB, Func<string, string> GABJKDNHOKK, bool IHGNEEEEKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2971B00", Offset = "0x2970D00", VA = "0x182971B00")]
	public static object HNGEJKEDHAM<T>(DLKMGGPEHOD NKBOLLDCNPB, Func<string, string> GABJKDNHOKK, bool IHGNEEEEKJA, bool LIKFOIGBBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D31E60", Offset = "0x6D31060", VA = "0x186D31E60")]
	private static TypeInfo JIKPPCNAKKO(MIGKCMOCKBF KJEHFDBPOLG, Type HHJOOHJDNNM, Func<string, string> GABJKDNHOKK, bool IHGNEEEEKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D7F0", Offset = "0x6D2C9F0", VA = "0x186D2D7F0")]
	public static object AINMNOPFHGC(Type HHJOOHJDNNM, Func<string, string> GABJKDNHOKK, bool IHGNEEEEKJA, bool LIKFOIGBBNG, bool GJANHIFLLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F350", Offset = "0x6D2E550", VA = "0x186D2F350")]
	private static Dictionary<LIMGCBBNMEL, FieldInfo> DPHLEHKOEJL(TypeBuilder GBGNAICFODC, KEBDJGHMPOD MBDIAFEJCBP, ConstructorInfo IAFFDCPPJFN, FieldBuilder OFAKDNBJDLJ, ILGenerator KOJMLALGPKG, bool IHGNEEEEKJA, bool PMDAKDEMDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FA80", Offset = "0x6D2EC80", VA = "0x186D2FA80")]
	private static Dictionary<LIMGCBBNMEL, FieldInfo> EEHOIEMEOFL(TypeBuilder GBGNAICFODC, KEBDJGHMPOD MBDIAFEJCBP, ILGenerator KOJMLALGPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D32890", Offset = "0x6D31A90", VA = "0x186D32890")]
	private static void MPHCKOEMGFN(Type HHJOOHJDNNM, KEBDJGHMPOD MBDIAFEJCBP, ILGenerator KOJMLALGPKG, Action MLBPMDIDJHM, Func<int, LIMGCBBNMEL, bool> JPLLLEAKNNC, bool IHGNEEEEKJA, bool PMDAKDEMDLH, int CBEGDLMHPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D34340", Offset = "0x6D33540", VA = "0x186D34340")]
	private static void PBDMAPNLFGA(TypeInfo HHJOOHJDNNM, LIMGCBBNMEL BBJPEFKCNKK, ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ, Func<int, LIMGCBBNMEL, bool> JPLLLEAKNNC, HHENBCDLGDC AELHGGJOBCK, HHENBCDLGDC LJEHFHAIFEO, HHENBCDLGDC OJNAGDDKLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D30160", Offset = "0x6D2F360", VA = "0x186D30160")]
	private static void EHKBFOLGJJA(Type HHJOOHJDNNM, KEBDJGHMPOD MBDIAFEJCBP, ILGenerator KOJMLALGPKG, Func<int, LIMGCBBNMEL, bool> JPLLLEAKNNC, bool GNMFPMDJNDH, int CBEGDLMHPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D33ED0", Offset = "0x6D330D0", VA = "0x186D33ED0")]
	private static void NOPAJMCBEKO(ILGenerator KOJMLALGPKG, LNFLDEMIMOH MBDIAFEJCBP, int PMNHOLIPOMJ, Func<int, LIMGCBBNMEL, bool> JPLLLEAKNNC, HHENBCDLGDC LAAOMLILGHH, HHENBCDLGDC OJNAGDDKLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D2CAA0", Offset = "0x6D2BCA0", VA = "0x186D2CAA0")]
	private static LocalBuilder ABPNJAIIAKA(ILGenerator KOJMLALGPKG, Type HHJOOHJDNNM, KEBDJGHMPOD MBDIAFEJCBP, LNFLDEMIMOH[] PPBJCJCHOBC, bool HJCJLMGBOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D31780", Offset = "0x6D30980", VA = "0x186D31780")]
	private static bool IJAKCELLFBF(ConstructorInfo DEPADONIIAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D31600", Offset = "0x6D30800", VA = "0x186D31600")]
	private static bool GBOBNEBJADH(Type HHJOOHJDNNM, [Out] Type DPILMIKFNPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void DOMNFFFFHFF<T>(byte[][] OFAKDNBJDLJ, object[] EKBKEHOHGPE, NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD MPHDDJAMFDH);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T HJCFCAIDAGH<T>(object[] EKBKEHOHGPE, DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD MPHDDJAMFDH);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class AFBJJKKJLDG<T> : EALLCKLMLAA<T>, DIGEJECCEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] OFAKDNBJDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] IOBMGFILAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] FALLMMBEADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly DOMNFFFFHFF<T> BGLDKMEILJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly HJCFCAIDAGH<T> LFBMCJGJLLM;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1E74C90", Offset = "0x1E73E90", VA = "0x181E74C90")]
	public AFBJJKKJLDG(byte[][] OFAKDNBJDLJ, object[] IOBMGFILAFL, object[] FALLMMBEADD, DOMNFFFFHFF<T> BGLDKMEILJB, HJCFCAIDAGH<T> LFBMCJGJLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9740", Offset = "0x3BA8940", VA = "0x183BA9740", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9830", Offset = "0x3BA8A30", VA = "0x183BA9830", Slot = "5")]
	public T IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DFKJHEMKFIN : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class PNIKCIOAKFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x43D4790", Offset = "0x43D3990", VA = "0x1843D4790")]
		static PNIKCIOAKFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private DFKJHEMKFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class GCAIEHLFCIC : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class KPBIMONMOEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6550", Offset = "0x3EC5750", VA = "0x183EC6550")]
		static KPBIMONMOEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private GCAIEHLFCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class NLJJAFEAMFC
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly DLKMGGPEHOD[] OAMHGEBNONH;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class PMMCCLKGHLA : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class LJHFDKJHNLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E290", Offset = "0x3F5D490", VA = "0x183F5E290")]
		static LJHFDKJHNLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class LDAGFHJHIGG : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class IPKIEIFNHCD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3B3ADB0", Offset = "0x3B39FB0", VA = "0x183B3ADB0")]
			static IPKIEIFNHCD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private LDAGFHJHIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private PMMCCLKGHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class LHOGGMBPHBM : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class DFGLKANBHNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x532C620", Offset = "0x532B820", VA = "0x18532C620")]
		static DFGLKANBHNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class PMLJPCGIIDJ : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class KNKMLFCDMNN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3EC21A0", Offset = "0x3EC13A0", VA = "0x183EC21A0")]
			static KNKMLFCDMNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private PMLJPCGIIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private LHOGGMBPHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class MJOJHLPKHOO : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class KCEKKMDDOJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3E42AD0", Offset = "0x3E41CD0", VA = "0x183E42AD0")]
		static KCEKKMDDOJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class NFMHFLCEMGB : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class JBLILAHLENF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3CEA120", Offset = "0x3CE9320", VA = "0x183CEA120")]
			static JBLILAHLENF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private NFMHFLCEMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private MJOJHLPKHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class IOFJONGCFAI : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class FLEEBKIKFMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x391C060", Offset = "0x391B260", VA = "0x18391C060")]
		static FLEEBKIKFMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class ABIKBGONIPD : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class PMCDIGFMJDP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x43BE640", Offset = "0x43BD840", VA = "0x1843BE640")]
			static PMCDIGFMJDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private ABIKBGONIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private IOFJONGCFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class KIFMCFBOCFC : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class GGFECLGGAON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x39CF0B0", Offset = "0x39CE2B0", VA = "0x1839CF0B0")]
		static GGFECLGGAON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class CKIHBLFHMPF : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class OEIOCECACBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4289D40", Offset = "0x4288F40", VA = "0x184289D40")]
			static OEIOCECACBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private CKIHBLFHMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private KIFMCFBOCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class OBHABEKADBL : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class LMAOKEPPJHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B370", Offset = "0x3F6A570", VA = "0x183F6B370")]
		static LMAOKEPPJHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class HJKHMFBPILK : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class JDDEHNIJCGI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3CEF140", Offset = "0x3CEE340", VA = "0x183CEF140")]
			static JDDEHNIJCGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private HJKHMFBPILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private OBHABEKADBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class KMABOFLAGOE : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class HBNLOFFEHEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3A23960", Offset = "0x3A22B60", VA = "0x183A23960")]
		static HBNLOFFEHEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class EPKMLDMPDGF : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class MOAIIPPFBGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x414C4A0", Offset = "0x414B6A0", VA = "0x18414C4A0")]
			static MOAIIPPFBGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private EPKMLDMPDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private KMABOFLAGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class MHCDNCPNDFK : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class ANDNONLAHEB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D78E90", Offset = "0x3D78090", VA = "0x183D78E90")]
		static ANDNONLAHEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class LJEOAHCALPE : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class ECMEBIOOKOI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x356E0B0", Offset = "0x356D2B0", VA = "0x18356E0B0")]
			static ECMEBIOOKOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private LJEOAHCALPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private MHCDNCPNDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class OAJEPEJMLFE : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class EIPHDHHNNHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x357E330", Offset = "0x357D530", VA = "0x18357E330")]
		static EIPHDHHNNHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class APEOJNABHJH : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class IKDMNIHOAMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3B1DC10", Offset = "0x3B1CE10", VA = "0x183B1DC10")]
			static IKDMNIHOAMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private APEOJNABHJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private OAJEPEJMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class HMMGEEIOEPE : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class HHKHJFDPOLB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3A39AC0", Offset = "0x3A38CC0", VA = "0x183A39AC0")]
		static HHKHJFDPOLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class LLKMNGKGACP : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class FCFLLNHLPIH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x38F4ED0", Offset = "0x38F40D0", VA = "0x1838F4ED0")]
			static FCFLLNHLPIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private LLKMNGKGACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private HMMGEEIOEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class LDKOHAPBAJM : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class NMCDIIMFHBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x41C6EA0", Offset = "0x41C60A0", VA = "0x1841C6EA0")]
		static NMCDIIMFHBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class JGFCHMFIFIE : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class LHGNCKKHOIH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3F47640", Offset = "0x3F46840", VA = "0x183F47640")]
			static LHGNCKKHOIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private JGFCHMFIFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private LDKOHAPBAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class KLEINHBIOAK : DLKMGGPEHOD
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class MJKBFJNPGDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x413E730", Offset = "0x413D930", VA = "0x18413E730")]
		static MJKBFJNPGDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class ABECHKHAKEK : DLKMGGPEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class ENDKKKGNLJF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly EALLCKLMLAA<T> NKMMLJBBJFF;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x359D350", Offset = "0x359C550", VA = "0x18359D350")]
			static ENDKKKGNLJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly DLKMGGPEHOD LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly DLKMGGPEHOD[] KLBEPPLJPMG;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private ABECHKHAKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
		public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly DLKMGGPEHOD LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly EALLCKLMLAA<object> HMDDPDFPOFD;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	private KLEINHBIOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2775880", Offset = "0x2774A80", VA = "0x182775880", Slot = "4")]
	public EALLCKLMLAA<T> LBPBIKGKEGG<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct BPBCOCOJEAK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] PACNKBDBCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int BGCPNAGJMOC;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6EB0", Offset = "0x4BF60B0", VA = "0x184BF6EB0")]
	public BPBCOCOJEAK(int NPNCPALHHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4BF6A80", Offset = "0x4BF5C80", VA = "0x184BF6A80")]
	public void LGLNKEHGBKE(T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4BF69F0", Offset = "0x4BF5BF0", VA = "0x184BF69F0")]
	public T[] GGDBFILMOFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class MHFAJOAEKGN : OLDLMONIPAM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly MHFAJOAEKGN DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D542E0", Offset = "0x6D534E0", VA = "0x186D542E0")]
	public MHFAJOAEKGN(int HIEMAHJLELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class OLDLMONIPAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int HIEMAHJLELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object PINBKGABJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int PMNHOLIPOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] OPKIGHLCDPK;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x42A1440", Offset = "0x42A0640", VA = "0x1842A1440")]
	public OLDLMONIPAM(int HIEMAHJLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x42A1150", Offset = "0x42A0350", VA = "0x1842A1150")]
	public T[] OMNJDNKHEOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x42A0E50", Offset = "0x42A0050", VA = "0x1842A0E50")]
	public void IEIKPBFFPGO(T[] HPGKNFECNHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class BKAAABBIKJO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class DKKEFGDJBIE : IComparable<DKKEFGDJBIE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class JKLHELMICIM : IEnumerable<DKKEFGDJBIE>, IEnumerable, IEnumerator<DKKEFGDJBIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private DKKEFGDJBIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public DKKEFGDJBIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private DKKEFGDJBIE System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x828B00", Offset = "0x827D00", VA = "0x180828B00")]
			[DebuggerHidden]
			public JKLHELMICIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6D4CDC0", Offset = "0x6D4BFC0", VA = "0x186D4CDC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6D4CEF0", Offset = "0x6D4C0F0", VA = "0x186D4CEF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6D4CE40", Offset = "0x6D4C040", VA = "0x186D4CE40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DKKEFGDJBIE> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6D4CE40", Offset = "0x6D4C040", VA = "0x186D4CE40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class ICICIIOGNBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ICICIIOGNBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6D38BC0", Offset = "0x6D37DC0", VA = "0x186D38BC0")]
			internal Label HDELGONIFGF(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6D38BC0", Offset = "0x6D37DC0", VA = "0x186D38BC0")]
			internal Label IGGDEJNNOPP(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly DKKEFGDJBIE[] KHMAOGEFLIH;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] GPPDNLIJCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong HCJOAPEDCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int OGADOHBOMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string FBBDMCNMKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private DKKEFGDJBIE[] BCDNLAFEHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] LKCKECMFFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int BIFLOKBJAPK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JLJLOEPNGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x55C1950", Offset = "0x55C0B50", VA = "0x1855C1950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D47630", Offset = "0x6D46830", VA = "0x186D47630")]
		public DKKEFGDJBIE(ulong MNOIAMGNLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D46520", Offset = "0x6D45720", VA = "0x186D46520")]
		public DKKEFGDJBIE LGLNKEHGBKE(ulong MNOIAMGNLNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D464C0", Offset = "0x6D456C0", VA = "0x186D464C0")]
		public DKKEFGDJBIE LGLNKEHGBKE(ulong MNOIAMGNLNL, int HLCKBKFCMPI, string FBBDMCNMKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D47400", Offset = "0x6D46600", VA = "0x186D47400")]
		public DKKEFGDJBIE PFJMLCLIFNK(byte[] DBMDKHEIDNF, int CFPEDCFCDGK, int EJECOBGNBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D46000", Offset = "0x6D45200", VA = "0x186D46000")]
		internal static int ADLDMMJNIFI(ulong[] HPGKNFECNHG, int PMNHOLIPOMJ, int MKCBFIBLIDD, ulong HLCKBKFCMPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D46090", Offset = "0x6D45290", VA = "0x186D46090", Slot = "4")]
		public int CompareTo(DKKEFGDJBIE JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D46440", Offset = "0x6D45640", VA = "0x186D46440")]
		[IteratorStateMachine(typeof(JKLHELMICIM))]
		public IEnumerable<DKKEFGDJBIE> KHKKEKIDMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D460C0", Offset = "0x6D452C0", VA = "0x186D460C0")]
		public void IGLJEHPGJKC(ILGenerator KOJMLALGPKG, LocalBuilder DBMDKHEIDNF, LocalBuilder EJECOBGNBNG, LocalBuilder MNOIAMGNLNL, Action<KeyValuePair<string, int>> NEICHCJMNOP, Action CLGEBDHOFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D46720", Offset = "0x6D45920", VA = "0x186D46720")]
		private static void NAHGOMEMLAF(ILGenerator KOJMLALGPKG, LocalBuilder DBMDKHEIDNF, LocalBuilder EJECOBGNBNG, LocalBuilder MNOIAMGNLNL, Action<KeyValuePair<string, int>> NEICHCJMNOP, Action CLGEBDHOFKD, DKKEFGDJBIE[] BCDNLAFEHFN, int BIFLOKBJAPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class GGGCCNHCOEP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IEnumerable<DKKEFGDJBIE> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<DKKEFGDJBIE> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<DKKEFGDJBIE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private DKKEFGDJBIE <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D498A0", Offset = "0x6D48AA0", VA = "0x186D498A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D97D30", Offset = "0x1D96F30", VA = "0x181D97D30")]
		[DebuggerHidden]
		public GGGCCNHCOEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D498F0", Offset = "0x6D48AF0", VA = "0x186D498F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D492F0", Offset = "0x6D484F0", VA = "0x186D492F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D492A0", Offset = "0x6D484A0", VA = "0x186D492A0")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D49750", Offset = "0x6D48950", VA = "0x186D49750")]
		private void NFKGCPGOKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D49850", Offset = "0x6D48A50", VA = "0x186D49850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D497A0", Offset = "0x6D489A0", VA = "0x186D497A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D497A0", Offset = "0x6D489A0", VA = "0x186D497A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly DKKEFGDJBIE LNOFAKNEFAA;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D43140", Offset = "0x6D42340", VA = "0x186D43140")]
	public BKAAABBIKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D42E10", Offset = "0x6D42010", VA = "0x186D42E10")]
	public void LGLNKEHGBKE(byte[] PGPEJDBBJED, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D42FD0", Offset = "0x6D421D0", VA = "0x186D42FD0")]
	public bool OPJEIHECLMJ(ArraySegment<byte> MNOIAMGNLNL, [Out] int HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D430B0", Offset = "0x6D422B0", VA = "0x186D430B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D42B30", Offset = "0x6D41D30", VA = "0x186D42B30")]
	private static void JMGDOBEFPIC(IEnumerable<DKKEFGDJBIE> BCDNLAFEHFN, StringBuilder CNBHEHKJHAN, int CHGLFFFCFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D42AD0", Offset = "0x6D41CD0", VA = "0x186D42AD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D42AD0", Offset = "0x6D41CD0", VA = "0x186D42AD0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D42F50", Offset = "0x6D42150", VA = "0x186D42F50")]
	[IteratorStateMachine(typeof(GGGCCNHCOEP))]
	private static IEnumerable<KeyValuePair<string, int>> OJGDFHKELCE(IEnumerable<DKKEFGDJBIE> BCDNLAFEHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D42F20", Offset = "0x6D42120", VA = "0x186D42F20")]
	public void LOMOEANDLJF(ILGenerator KOJMLALGPKG, LocalBuilder DBMDKHEIDNF, LocalBuilder EJECOBGNBNG, LocalBuilder MNOIAMGNLNL, Action<KeyValuePair<string, int>> NEICHCJMNOP, Action CLGEBDHOFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LDBGHCNNIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo BINOLBANIHH;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D4F480", Offset = "0x6D4E680", VA = "0x186D4F480")]
	public static ulong LCOGFAPIIOC(byte[] PGPEJDBBJED, int CFPEDCFCDGK, int EJECOBGNBNG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PPAMIIBCFOI
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D58DA0", Offset = "0x6D57FA0", VA = "0x186D58DA0")]
	public static void JBFDHDHPFLB(byte[] PGPEJDBBJED, int CFPEDCFCDGK, int DADCJHNFIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D58C80", Offset = "0x6D57E80", VA = "0x186D58C80")]
	public static void CENMHMPIGNE(byte[] HPGKNFECNHG, int AEEIDPFNOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D58EE0", Offset = "0x6D580E0", VA = "0x186D58EE0")]
	public static byte[] OEGIKNELDDL(byte[] NAKAAHDEHKM, int AEEIDPFNOMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MPOHBCMAEKC
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D571B0", Offset = "0x6D563B0", VA = "0x186D571B0")]
	public static bool LEKGILNOIAO(byte[] KMOEEPGKJCE, int PMIJCLPEAMH, int FMGDDGBAOPH, byte[] ANLHJDJCJDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class IOHDICCOJCP<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct KBDFIGLCONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] HCJOAPEDCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T OGADOHBOMGE;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E39C50", Offset = "0x3E38E50", VA = "0x183E39C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class HPGMGFKCOMM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public IOHDICCOJCP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private KBDFIGLCONJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KBDFIGLCONJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x395ADC0", Offset = "0x3959FC0", VA = "0x18395ADC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public HPGMGFKCOMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B9C0", Offset = "0x3A5ABC0", VA = "0x183A5B9C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CD70", Offset = "0x3A5BF70", VA = "0x183A5CD70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly KBDFIGLCONJ[][] DIAMPAFHNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong JCHGIMCPKMC;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B388F0", Offset = "0x3B37AF0", VA = "0x183B388F0")]
	public IOHDICCOJCP(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3B38910", Offset = "0x3B37B10", VA = "0x183B38910")]
	public IOHDICCOJCP(int EFDILNFHNJD, float JMJGCIGNGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B38150", Offset = "0x3B37350", VA = "0x183B38150")]
	public void LGLNKEHGBKE(byte[] MNOIAMGNLNL, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3B333C0", Offset = "0x3B325C0", VA = "0x183B333C0")]
	private bool JLGBEAKCNEE(byte[] MNOIAMGNLNL, T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D840", Offset = "0x3B2CA40", VA = "0x183B2D840")]
	public bool GMADCLHMMHE(ArraySegment<byte> MNOIAMGNLNL, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BE00", Offset = "0x3B2B000", VA = "0x183B2BE00")]
	private static ulong GFBFFIOMJCE(byte[] DCHJALFCEJF, int CFPEDCFCDGK, int BIFLOKBJAPK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x39C69C0", Offset = "0x39C5BC0", VA = "0x1839C69C0")]
	private static int FNAJFNGCKIP(int FMHBDNHJCLO, float JMJGCIGNGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3B30150", Offset = "0x3B2F350", VA = "0x183B30150", Slot = "4")]
	[IteratorStateMachine(typeof(IOHDICCOJCP<>.HPGMGFKCOMM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3885640", Offset = "0x3884840", VA = "0x183885640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class ICPENBLALGL : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] DEHKIAJPLJB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] HDCOFJIAPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int NNHKJDEFALA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FDCKLAGGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D4C200", Offset = "0x6D4B400", VA = "0x186D4C200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C250", Offset = "0x6D4B450", VA = "0x186D4C250")]
	static ICPENBLALGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C4B0", Offset = "0x6D4B6B0", VA = "0x186D4C4B0")]
	public ICPENBLALGL(byte[] HGHJPINEGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C100", Offset = "0x6D4B300", VA = "0x186D4C100")]
	public OpCode ILPIKLMBOHF()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct MPNCMJLJBFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid OGADOHBOMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte FMLCCMHMKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte PKLEPIKMGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte KGIIPGDDCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte DGICGIFLLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte DJHHNICBGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte JCCBCOACDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte HCKIGABLKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte FOFPJAMNEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte PNIBLPJLPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte DGNAENIJKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte DHPNHALILCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte HPJDDMGNOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte HKJONGEIBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte CDDIDEAFJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte GBNFHBMCENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte IHLFKPAPCKM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] HCBAHFLEBGH;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] HPHGGLCEHFK;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D571A0", Offset = "0x6D563A0", VA = "0x186D571A0")]
	public MPNCMJLJBFC(Guid HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D55A50", Offset = "0x6D54C50", VA = "0x186D55A50")]
	public MPNCMJLJBFC(ArraySegment<byte> DOOGNKHKKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D558C0", Offset = "0x6D54AC0", VA = "0x186D558C0")]
	private static byte DFEFNCOHKFC(byte[] PGPEJDBBJED, int BKEBEIPGMOH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D54AF0", Offset = "0x6D53CF0", VA = "0x186D54AF0")]
	private static byte BGMOGHNKDFJ(byte NOIIDJMAOFK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D54C10", Offset = "0x6D53E10", VA = "0x186D54C10")]
	public void CBGODNINDBA(byte[] OPMKPGEDLGD, int CFPEDCFCDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class CJMCDDOHCFE
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D434F0", Offset = "0x6D426F0", VA = "0x186D434F0")]
	public static bool DANDMAELBGI(byte HHHFIGOCAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D43810", Offset = "0x6D42A10", VA = "0x186D43810")]
	public static bool HCAMGMGOMLO(byte HHHFIGOCAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D43880", Offset = "0x6D42A80", VA = "0x186D43880")]
	public static sbyte ICPPJAHDKIC(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D43A50", Offset = "0x6D42C50", VA = "0x186D43A50")]
	public static short KICPGDHPPLL(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6D43960", Offset = "0x6D42B60", VA = "0x186D43960")]
	public static int IMPDBPFBCAM(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6D433D0", Offset = "0x6D425D0", VA = "0x186D433D0")]
	public static long CGLJCACHKIP(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6D431C0", Offset = "0x6D423C0", VA = "0x186D431C0")]
	public static byte AFCCFFHKPMK(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6D43350", Offset = "0x6D42550", VA = "0x186D43350")]
	public static ushort BLDOBOGDEHA(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6D43470", Offset = "0x6D42670", VA = "0x186D43470")]
	public static uint CPIGNGLLHCK(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6D43240", Offset = "0x6D42440", VA = "0x186D43240")]
	public static ulong AIOPHCNJHAJ(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D44BA0", Offset = "0x6D43DA0", VA = "0x186D44BA0")]
	public static float NBHFNCGIJDM(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6D43500", Offset = "0x6D42700", VA = "0x186D43500")]
	public static double DLBFIMILPPO(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6D43B40", Offset = "0x6D42D40", VA = "0x186D43B40")]
	public static int LOLEAMEGJNK(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, ulong HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D441E0", Offset = "0x6D433E0", VA = "0x186D441E0")]
	public static int MELBDJIDKBE(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, long HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D435E0", Offset = "0x6D427E0", VA = "0x186D435E0")]
	public static bool GGEIIJKGINH(byte[] PGPEJDBBJED, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class MKNFIJELCLK
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LLPFKBHFFFO : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x828B00", Offset = "0x827D00", VA = "0x180828B00")]
		[DebuggerHidden]
		public LLPFKBHFFFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6D51380", Offset = "0x6D50580", VA = "0x186D51380", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6D50DF0", Offset = "0x6D4FFF0", VA = "0x186D50DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6D50DA0", Offset = "0x6D4FFA0", VA = "0x186D50DA0")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6D51220", Offset = "0x6D50420", VA = "0x186D51220")]
		private void NFKGCPGOKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6D51330", Offset = "0x6D50530", VA = "0x186D51330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6D51270", Offset = "0x6D50470", VA = "0x186D51270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6D51270", Offset = "0x6D50470", VA = "0x186D51270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class LPAIAMFKHMJ : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x828B00", Offset = "0x827D00", VA = "0x180828B00")]
		[DebuggerHidden]
		public LPAIAMFKHMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6D53CA0", Offset = "0x6D52EA0", VA = "0x186D53CA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6D53710", Offset = "0x6D52910", VA = "0x186D53710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6D536C0", Offset = "0x6D528C0", VA = "0x186D536C0")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6D53B40", Offset = "0x6D52D40", VA = "0x186D53B40")]
		private void NFKGCPGOKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6D53C50", Offset = "0x6D52E50", VA = "0x186D53C50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6D53B90", Offset = "0x6D52D90", VA = "0x186D53B90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6D53B90", Offset = "0x6D52D90", VA = "0x186D53B90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6D54A30", Offset = "0x6D53C30", VA = "0x186D54A30")]
	public static bool MNMKGBGFFHC(this TypeInfo HHJOOHJDNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6D54880", Offset = "0x6D53A80", VA = "0x186D54880")]
	public static bool JPJMEBAGCNB(this TypeInfo HHJOOHJDNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6D549B0", Offset = "0x6D53BB0", VA = "0x186D549B0")]
	public static IEnumerable<PropertyInfo> LBCAPGNDAFI(this Type HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6D54760", Offset = "0x6D53960", VA = "0x186D54760")]
	[IteratorStateMachine(typeof(LLPFKBHFFFO))]
	private static IEnumerable<PropertyInfo> CDLNMIAOHGP(Type HHJOOHJDNNM, HashSet<string> CGDHAFNJHHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6D54800", Offset = "0x6D53A00", VA = "0x186D54800")]
	public static IEnumerable<FieldInfo> FGNPLPEPBOD(this Type HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6D546C0", Offset = "0x6D538C0", VA = "0x186D546C0")]
	[IteratorStateMachine(typeof(LPAIAMFKHMJ))]
	private static IEnumerable<FieldInfo> AEHFPPNABEH(Type HHJOOHJDNNM, HashSet<string> CGDHAFNJHHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class DKIOKDPELFJ
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding HBKKNNFAKGJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class LANGCLDKKDJ
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static string PCMPJABMBLL(string JFPGFMAHEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4F210", Offset = "0x6D4E410", VA = "0x186D4F210")]
	public static string ABBOLENDNCN(string JFPGFMAHEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4F2F0", Offset = "0x6D4E4F0", VA = "0x186D4F2F0")]
	public static string LDFKENAEOAN(string JFPGFMAHEJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class GENCCANBDFF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class ENNIDMBIDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type HCJOAPEDCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue OGADOHBOMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int ILGAOBANMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public ENNIDMBIDIN DNHMKPKJANF;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x35A04D0", Offset = "0x359F6D0", VA = "0x1835A04D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x35A0380", Offset = "0x359F580", VA = "0x1835A0380")]
		private int HJGLMCCDDEF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public ENNIDMBIDIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class HGPDBMOIHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HGPDBMOIHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
		internal TValue LEIGJCDHDDJ(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private ENNIDMBIDIN[] DIAMPAFHNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int AGHIAPEPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object CCLMDPEDIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float JMJGCIGNGJL;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x39C7E10", Offset = "0x39C7010", VA = "0x1839C7E10")]
	public GENCCANBDFF(int EFDILNFHNJD = 4, float JMJGCIGNGJL = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x39C7410", Offset = "0x39C6610", VA = "0x1839C7410")]
	public bool KINNJEDKJAM(Type MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x39C7530", Offset = "0x39C6730", VA = "0x1839C7530")]
	public bool KINNJEDKJAM(Type MNOIAMGNLNL, Func<Type, TValue> CPLJONOEKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x39C6F90", Offset = "0x39C6190", VA = "0x1839C6F90")]
	private bool JLGBEAKCNEE(Type MNOIAMGNLNL, Func<Type, TValue> CPLJONOEKLJ, [Out] TValue NLPDBOODJNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x39C7900", Offset = "0x39C6B00", VA = "0x1839C7900")]
	private bool LPDBOGGGMHD(ENNIDMBIDIN[] DIAMPAFHNOE, Type HADBOJNFDMG, ENNIDMBIDIN CBHIINCBLJL, Func<Type, TValue> CPLJONOEKLJ, [Out] TValue NLPDBOODJNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x39C6B20", Offset = "0x39C5D20", VA = "0x1839C6B20")]
	public bool GMADCLHMMHE(Type MNOIAMGNLNL, [Out] TValue HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x39C7D60", Offset = "0x39C6F60", VA = "0x1839C7D60")]
	public TValue MNADKEBFJLE(Type MNOIAMGNLNL, Func<Type, TValue> CPLJONOEKLJ)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x39C69C0", Offset = "0x39C5BC0", VA = "0x1839C69C0")]
	private static int FNAJFNGCKIP(int FMHBDNHJCLO, float JMJGCIGNGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x39C6990", Offset = "0x39C5B90", VA = "0x1839C6990")]
	private static void CFBKMCJCEBH(ENNIDMBIDIN OLHAMAODFJK, ENNIDMBIDIN HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x39C6990", Offset = "0x39C5B90", VA = "0x1839C6990")]
	private static void CFBKMCJCEBH(ENNIDMBIDIN[] OLHAMAODFJK, ENNIDMBIDIN[] HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class MIGKCMOCKBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder NIFFDLNAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder MLIKHPHPDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object PINBKGABJKM;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6D54330", Offset = "0x6D53530", VA = "0x186D54330")]
	public TypeBuilder PEBEOJPPLHH(string IIADHBOODBK, TypeAttributes NLEHIIJOJEF, Type BGILIGANMHA, Type[] PIHMJEGCMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6D54430", Offset = "0x6D53630", VA = "0x186D54430")]
	public MIGKCMOCKBF(string MNCCJCLHHBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class BCEHEKAJEAC
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6D429F0", Offset = "0x6D41BF0", VA = "0x186D429F0")]
	private static MethodInfo IMMKOKFGFPJ(LambdaExpression BCOHJJFKPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x27728A0", Offset = "0x2771AA0", VA = "0x1827728A0")]
	public static MethodInfo OLDLKAFJPGC<T>(Expression<Func<T>> BCOHJJFKPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x27728A0", Offset = "0x2771AA0", VA = "0x1827728A0")]
	public static MethodInfo OLDLKAFJPGC<T, TR>(Expression<Func<T, TR>> BCOHJJFKPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x27728A0", Offset = "0x2771AA0", VA = "0x1827728A0")]
	public static MethodInfo OLDLKAFJPGC<T>(Expression<Action<T>> BCOHJJFKPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x27728A0", Offset = "0x2771AA0", VA = "0x1827728A0")]
	public static MethodInfo OLDLKAFJPGC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> BCOHJJFKPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2772720", Offset = "0x2771920", VA = "0x182772720")]
	private static MemberInfo CPKECADHHPE<T>(Expression<T> GNIGPOPNBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2772800", Offset = "0x2771A00", VA = "0x182772800")]
	public static PropertyInfo FOMKPGOMFLL<T, TR>(Expression<Func<T, TR>> BCOHJJFKPJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct HHENBCDLGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int BJOOMLAOBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool PPBAEMJMONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator KOJMLALGPKG;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B730", Offset = "0x6D4A930", VA = "0x186D4B730")]
	public HHENBCDLGDC(ILGenerator KOJMLALGPKG, int BJOOMLAOBEG, bool PPBAEMJMONO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B6A0", Offset = "0x6D4A8A0", VA = "0x186D4B6A0")]
	public HHENBCDLGDC(ILGenerator KOJMLALGPKG, int BJOOMLAOBEG, Type HHJOOHJDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B5A0", Offset = "0x6D4A7A0", VA = "0x186D4B5A0")]
	public void EJPGNAMKABM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class DEJEEDKEFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6D45B00", Offset = "0x6D44D00", VA = "0x186D45B00")]
	public static void OKGLCEPPJJO(this ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6D45AC0", Offset = "0x6D44CC0", VA = "0x186D45AC0")]
	public static void OKGLCEPPJJO(this ILGenerator KOJMLALGPKG, LocalBuilder BJDDCMIOEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6D44E90", Offset = "0x6D44090", VA = "0x186D44E90")]
	public static void ABCKHCEKHEF(this ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6D44E50", Offset = "0x6D44050", VA = "0x186D44E50")]
	public static void ABCKHCEKHEF(this ILGenerator KOJMLALGPKG, LocalBuilder BJDDCMIOEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6D458E0", Offset = "0x6D44AE0", VA = "0x186D458E0")]
	public static void LNKCCPCCPMH(this ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6D459C0", Offset = "0x6D44BC0", VA = "0x186D459C0")]
	public static void LNKCCPCCPMH(this ILGenerator KOJMLALGPKG, LocalBuilder BJDDCMIOEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6D45380", Offset = "0x6D44580", VA = "0x186D45380")]
	public static void HOJDOEMBEMA(this ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6D45370", Offset = "0x6D44570", VA = "0x186D45370")]
	public static void HLJOAGBLIDJ(this ILGenerator KOJMLALGPKG, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6D45500", Offset = "0x6D44700", VA = "0x186D45500")]
	public static void JGPGDOMJDIF(this ILGenerator KOJMLALGPKG, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6D451A0", Offset = "0x6D443A0", VA = "0x186D451A0")]
	public static void GGLHGLNJHHN(this ILGenerator KOJMLALGPKG, Type HHJOOHJDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6D45100", Offset = "0x6D44300", VA = "0x186D45100")]
	public static void DEBLNHMCIDK(this ILGenerator KOJMLALGPKG, Type HHJOOHJDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6D45CF0", Offset = "0x6D44EF0", VA = "0x186D45CF0")]
	public static void PAMLAELAMLL(this ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6D45080", Offset = "0x6D44280", VA = "0x186D45080")]
	public static void BONHHHDBMKE(this ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6D45420", Offset = "0x6D44620", VA = "0x186D45420")]
	public static void IDLIJKGPEPF(this ILGenerator KOJMLALGPKG, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6D45280", Offset = "0x6D44480", VA = "0x186D45280")]
	public static void GNHIOOJMFDP(this ILGenerator KOJMLALGPKG, MethodInfo LGELAMCHOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6D45EE0", Offset = "0x6D450E0", VA = "0x186D45EE0")]
	public static void PFHKAJAAAKN(this ILGenerator KOJMLALGPKG, FieldInfo OFNIEFAMDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6D45390", Offset = "0x6D44590", VA = "0x186D45390")]
	public static void HPOAJEPONPP(this ILGenerator KOJMLALGPKG, ulong HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class LIMGCBBNMEL
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class MBJLMNJDIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MBJLMNJDIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6D53FB0", Offset = "0x6D531B0", VA = "0x186D53FB0")]
		internal bool OMEMJPHMJCP(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo AKJCJEBOIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo EIGJGCODHKD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string MCELKPOPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LEHGJMBMBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6D50530", Offset = "0x6D4F730", VA = "0x186D50530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AHBCMDJHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA50", Offset = "0x7CDC50", VA = "0x1807CEA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8B0", Offset = "0x7CDAB0", VA = "0x1807CE8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MGLCABNHCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9EBBD0", Offset = "0x9EADD0", VA = "0x1809EBBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9EB760", Offset = "0x9EA960", VA = "0x1809EB760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type GADMEDLKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo FOIPODPPHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo IMHGEGCDJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7CE970", Offset = "0x7CDB70", VA = "0x1807CE970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo APCDLEPKFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7CE870", Offset = "0x7CDA70", VA = "0x1807CE870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6D507C0", Offset = "0x6D4F9C0", VA = "0x186D507C0")]
	protected LIMGCBBNMEL(Type HHJOOHJDNNM, string IIADHBOODBK, string PPEEEMDPEJN, bool DEPEODCHKDF, bool NNIHDJIDKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6D506B0", Offset = "0x6D4F8B0", VA = "0x186D506B0")]
	public LIMGCBBNMEL(FieldInfo MBDIAFEJCBP, string IIADHBOODBK, bool LIKFOIGBBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6D50840", Offset = "0x6D4FA40", VA = "0x186D50840")]
	public LIMGCBBNMEL(PropertyInfo MBDIAFEJCBP, string IIADHBOODBK, bool LIKFOIGBBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6D50540", Offset = "0x6D4F740", VA = "0x186D50540")]
	private static MethodInfo OLONMAEFPKF(MemberInfo MBDIAFEJCBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2A35B10", Offset = "0x2A34D10", VA = "0x182A35B10")]
	public T DFLGHNELJIJ<T>(bool DJOKFCAOMGG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6D50230", Offset = "0x6D4F430", VA = "0x186D50230", Slot = "4")]
	public virtual void AIAMEPOAPGK(ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6D503B0", Offset = "0x6D4F5B0", VA = "0x186D503B0", Slot = "5")]
	public virtual void BGMGHOIEJKD(ILGenerator KOJMLALGPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class NFKJNKIJOII : LIMGCBBNMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string CDGEEIAJPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6D57320", Offset = "0x6D56520", VA = "0x186D57320")]
	public NFKJNKIJOII(string IIADHBOODBK, string CDGEEIAJPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6D57220", Offset = "0x6D56420", VA = "0x186D57220", Slot = "4")]
	public override void AIAMEPOAPGK(ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6D572D0", Offset = "0x6D564D0", VA = "0x186D572D0", Slot = "5")]
	public override void BGMGHOIEJKD(ILGenerator KOJMLALGPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class KFHEOMOLNLE : LIMGCBBNMEL
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo NLLDECOFDGL;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo PHHFAIDNHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal HHENBCDLGDC CPLGAEJKEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal HHENBCDLGDC LJEHFHAIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal HHENBCDLGDC OJNAGDDKLIF;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6D4ECD0", Offset = "0x6D4DED0", VA = "0x186D4ECD0")]
	public KFHEOMOLNLE(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6D4E4E0", Offset = "0x6D4D6E0", VA = "0x186D4E4E0", Slot = "4")]
	public override void AIAMEPOAPGK(ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6D4E5A0", Offset = "0x6D4D7A0", VA = "0x186D4E5A0", Slot = "5")]
	public override void BGMGHOIEJKD(ILGenerator KOJMLALGPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6D4E5F0", Offset = "0x6D4D7F0", VA = "0x186D4E5F0")]
	public void JLGAFGKGHAO(ILGenerator KOJMLALGPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class KEBDJGHMPOD
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type GADMEDLKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NAKPHAEGNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7CC960", Offset = "0x7CBB60", VA = "0x1807CC960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HJOBHNODBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4120", Offset = "0x8D3320", VA = "0x1808D4120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9E9FA0", Offset = "0x9E91A0", VA = "0x1809E9FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo OGHKNOPMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LIMGCBBNMEL[] PNIHPADDHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LIMGCBBNMEL[] LGMONLDBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6D4D020", Offset = "0x6D4C220", VA = "0x186D4D020")]
	public KEBDJGHMPOD(Type HHJOOHJDNNM, Func<string, string> ONMDAELEFFC, bool LIKFOIGBBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CF40", Offset = "0x6D4C140", VA = "0x186D4CF40")]
	private static bool CPDACGPHIIP(IEnumerator<ConstructorInfo> NMEAIMHNJFA, ConstructorInfo NEJPIPKCDBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct HDMFLEAFPKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong ADMHPDFFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int NJNKMHCCCIB;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA090", Offset = "0x1EA9290", VA = "0x181EAA090")]
	public HDMFLEAFPKE(ulong OHOEBLPBKIP, int BPPEENPDDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B450", Offset = "0x6D4A650", VA = "0x186D4B450")]
	public void CDEPBLAHDLN(HDMFLEAFPKE JPLJHFMPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B460", Offset = "0x6D4A660", VA = "0x186D4B460")]
	public static HDMFLEAFPKE LNHKPMAADBG(HDMFLEAFPKE BPOHBPAMNLC, HDMFLEAFPKE NOIIDJMAOFK)
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B470", Offset = "0x6D4A670", VA = "0x186D4B470")]
	public void NLHOABNHOJF(HDMFLEAFPKE JPLJHFMPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B500", Offset = "0x6D4A700", VA = "0x186D4B500")]
	public static HDMFLEAFPKE PJIMNLAAHJC(HDMFLEAFPKE BPOHBPAMNLC, HDMFLEAFPKE NOIIDJMAOFK)
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B410", Offset = "0x6D4A610", VA = "0x186D4B410")]
	public void BNMKEGMLGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6D4B3C0", Offset = "0x6D4A5C0", VA = "0x186D4B3C0")]
	public static HDMFLEAFPKE BNMKEGMLGON(HDMFLEAFPKE BPOHBPAMNLC)
	{
		return default(HDMFLEAFPKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct JEAMFBDHIGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] OPMKPGEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int CFPEDCFCDGK;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x19E1BA0", Offset = "0x19E0DA0", VA = "0x1819E1BA0")]
	public JEAMFBDHIGH(byte[] OPMKPGEDLGD, int CAOOPLKANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CDF0", Offset = "0x6D3BFF0", VA = "0x186D3CDF0")]
	public void FPJDMOCHPCI(byte DIDBPNGGKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CB70", Offset = "0x6D4BD70", VA = "0x186D4CB70")]
	public void NKLJHDMOPKC(byte[] DIDBPNGGKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C950", Offset = "0x6D4BB50", VA = "0x186D4C950")]
	public void FHFHKBEODPI(byte[] DIDBPNGGKDB, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C9D0", Offset = "0x6D4BBD0", VA = "0x186D4C9D0")]
	public void FHFHKBEODPI(byte[] DIDBPNGGKDB, int IFNAKMJKBID, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C8D0", Offset = "0x6D4BAD0", VA = "0x186D4C8D0")]
	public void EDMBKPLEIEL(byte HHHFIGOCAOB, int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CA70", Offset = "0x6D4BC70", VA = "0x186D4CA70")]
	public void LFJLJPKJICA(string DIDBPNGGKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class LMOPAIHDEBH
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum EGIEJFBPDDP
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum GDAGECMMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum NGPMNGCEHFN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ThreadStatic]
	private static byte[] CHLBOHIDKAG;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] DNKAFJMBHLL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] IEAOEFDJEHI;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] NDPHBMBLJFI;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly NGPMNGCEHFN MBEKPFADOFJ;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char LIBJMCPENDG;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int MDPHJEDGOML;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int LACKIBELIIA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] JBMFOEENHML;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6D532B0", Offset = "0x6D524B0", VA = "0x186D532B0")]
	private static byte[] MILDIDBHEAF(int AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D52DE0", Offset = "0x6D51FE0", VA = "0x186D52DE0")]
	private static byte[] JMAJCGFEMCL(int AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D51D70", Offset = "0x6D50F70", VA = "0x186D51D70")]
	public static int DPMDMOPEJHG(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, float HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D51E90", Offset = "0x6D51090", VA = "0x186D51E90")]
	public static int DPMDMOPEJHG(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, double HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D514C0", Offset = "0x6D506C0", VA = "0x186D514C0")]
	private static bool ADEOHGGJHIK(byte[] OPMKPGEDLGD, int MKCBFIBLIDD, ulong LGNNJBINMKI, ulong FCEMGFBGOLJ, ulong EJECOBGNBNG, ulong KHILABPEGAG, ulong NHBFGGOGNGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D53380", Offset = "0x6D52580", VA = "0x186D53380")]
	private static void PEGGOFHJIOK(uint HCAEMJDNKJE, int MKCPMBABDMH, [Out] uint GCKAAECGBKD, [Out] int LBDGGEJJNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D52EC0", Offset = "0x6D520C0", VA = "0x186D52EC0")]
	private static bool LHOLKIHENFC(HDMFLEAFPKE LKPCPGMPJKJ, HDMFLEAFPKE EDEGHDPMPJM, HDMFLEAFPKE EEHCAJPHAGA, byte[] OPMKPGEDLGD, [Out] int MKCBFIBLIDD, [Out] int AJBBHGNPDGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D51FB0", Offset = "0x6D511B0", VA = "0x186D51FB0")]
	private static bool FJDDCEOJHDH(double HCFEJGBILDB, EGIEJFBPDDP CKIGLEMFOLA, byte[] OPMKPGEDLGD, [Out] int MKCBFIBLIDD, [Out] int LJOKFKJBJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D52600", Offset = "0x6D51800", VA = "0x186D52600")]
	private static bool IAEHOPHLGEG(double HCFEJGBILDB, EGIEJFBPDDP CKIGLEMFOLA, byte[] OPMKPGEDLGD, [Out] int MKCBFIBLIDD, [Out] int KKHMNLJKOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D52430", Offset = "0x6D51630", VA = "0x186D52430")]
	private static bool HOGIBFDLHLC(double HLCKBKFCMPI, JEAMFBDHIGH HDBNDDONGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D52710", Offset = "0x6D51910", VA = "0x186D52710")]
	private static bool IBEGGGKENGB(double HLCKBKFCMPI, JEAMFBDHIGH HDBNDDONGFO, GDAGECMMJBJ CKIGLEMFOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D519E0", Offset = "0x6D50BE0", VA = "0x186D519E0")]
	private static void BLACLKHCPFH(byte[] BOAIFDOOICN, int MKCBFIBLIDD, int KKHMNLJKOLJ, int BNDCEHAPJAK, JEAMFBDHIGH HDBNDDONGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D515B0", Offset = "0x6D507B0", VA = "0x186D515B0")]
	private static void BFLDJNPOJIC(byte[] BOAIFDOOICN, int MKCBFIBLIDD, int BPPEENPDDDA, JEAMFBDHIGH HDBNDDONGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D52BF0", Offset = "0x6D51DF0", VA = "0x186D52BF0")]
	private static bool JELCFLNBAEG(double HCFEJGBILDB, GDAGECMMJBJ CKIGLEMFOLA, int BMKNJBNNPNN, byte[] IKBGLNDNGBH, [Out] bool HPHPNEPPEEP, [Out] int MKCBFIBLIDD, [Out] int OGPMBFEEKPH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct FKBNOPCBGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double PIKGAJBAGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong NGAPOMLDCNM;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct NIBHOJKIKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float ADMHPDFFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint GEAGBKCKPIB;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct IAAPHLKBBAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong ACLFOGDOPLE;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C050", Offset = "0x6D4B250", VA = "0x186D4C050")]
	public IAAPHLKBBAE(double PIKGAJBAGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C060", Offset = "0x6D4B260", VA = "0x186D4C060")]
	public IAAPHLKBBAE(HDMFLEAFPKE PIKGAJBAGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BDA0", Offset = "0x6D4AFA0", VA = "0x186D4BDA0")]
	public HDMFLEAFPKE HEJAPDCKOKE()
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BFD0", Offset = "0x6D4B1D0", VA = "0x186D4BFD0")]
	public HDMFLEAFPKE PLILAFLOPBF()
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public ulong PMCKKCKKBPL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BAE0", Offset = "0x6D4ACE0", VA = "0x186D4BAE0")]
	public double BALOLNIKIGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BE70", Offset = "0x6D4B070", VA = "0x186D4BE70")]
	public double IKAAJLAGNDD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BE10", Offset = "0x6D4B010", VA = "0x186D4BE10")]
	public int IDADCNFNLDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BE40", Offset = "0x6D4B040", VA = "0x186D4BE40")]
	public ulong IIGHBLNFPPH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BD80", Offset = "0x6D4AF80", VA = "0x186D4BD80")]
	public bool HBNBICBANBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BF30", Offset = "0x6D4B130", VA = "0x186D4BF30")]
	public bool LHEBMDFFHEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BB60", Offset = "0x6D4AD60", VA = "0x186D4BB60")]
	public bool EIPDKDHGGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BFA0", Offset = "0x6D4B1A0", VA = "0x186D4BFA0")]
	public bool PJEKJJADPPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BAC0", Offset = "0x6D4ACC0", VA = "0x186D4BAC0")]
	public int AFDEEODOCDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BC20", Offset = "0x6D4AE20", VA = "0x186D4BC20")]
	public void FPPHHKHMNHN([Out] HDMFLEAFPKE AHAGIPNMIFN, [Out] HDMFLEAFPKE OBHEJOBCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BF50", Offset = "0x6D4B150", VA = "0x186D4BF50")]
	public bool PAMJNHMKENL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AD90", Offset = "0x2F79F90", VA = "0x182F7AD90")]
	public double HLCKBKFCMPI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BF10", Offset = "0x6D4B110", VA = "0x186D4BF10")]
	public static int KNDBAGEBHBD(int FOKMPHMHJPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BD70", Offset = "0x6D4AF70", VA = "0x186D4BD70")]
	public static double GOBAKAMHJID()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D4BB90", Offset = "0x6D4AD90", VA = "0x186D4BB90")]
	public static ulong FHDJBDBIIIN(HDMFLEAFPKE HMOPDDKNKLB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct INNMIEHPMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint MCHLIFHFHEE;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x205C060", Offset = "0x205B260", VA = "0x18205C060")]
	public INNMIEHPMPG(float ADMHPDFFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C680", Offset = "0x6D4B880", VA = "0x186D4C680")]
	public HDMFLEAFPKE HEJAPDCKOKE()
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
	public uint JKBFEKKOFFH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C6D0", Offset = "0x6D4B8D0", VA = "0x186D4C6D0")]
	public int IDADCNFNLDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C6F0", Offset = "0x6D4B8F0", VA = "0x186D4C6F0")]
	public uint IIGHBLNFPPH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C670", Offset = "0x6D4B870", VA = "0x186D4C670")]
	public bool HBNBICBANBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C540", Offset = "0x6D4B740", VA = "0x186D4C540")]
	public void FPPHHKHMNHN([Out] HDMFLEAFPKE AHAGIPNMIFN, [Out] HDMFLEAFPKE OBHEJOBCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C710", Offset = "0x6D4B910", VA = "0x186D4C710")]
	public bool PAMJNHMKENL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct LMIBAOOOHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong OHOEBLPBKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short LJFPMLGACCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short LJOKFKJBJMN;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D514B0", Offset = "0x6D506B0", VA = "0x186D514B0")]
	public LMIBAOOOHEG(ulong OHOEBLPBKIP, short LJFPMLGACCN, short LJOKFKJBJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class NNOLDMNCCIO
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly LMIBAOOOHEG[] ABODPIFJKKG;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D575D0", Offset = "0x6D567D0", VA = "0x186D575D0")]
	public static void BKODEOKPGOM(int NNDLLCPCEOM, int OEPBCJFJHAJ, [Out] HDMFLEAFPKE GCKAAECGBKD, [Out] int LJOKFKJBJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D576E0", Offset = "0x6D568E0", VA = "0x186D576E0")]
	public static void MNBHMFMEMMA(int CKOGNDBECBK, [Out] HDMFLEAFPKE GCKAAECGBKD, [Out] int GBMNNPLANCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct OGKGBNIIADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] PGPEJDBBJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int IFNAKMJKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int GAJFIAEFKBO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D58A10", Offset = "0x6D57C10", VA = "0x186D58A10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x38F97A0", Offset = "0x38F89A0", VA = "0x1838F97A0")]
	public OGKGBNIIADC(byte[] PGPEJDBBJED, int IFNAKMJKBID, int MKCBFIBLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x20C2550", Offset = "0x20C1750", VA = "0x1820C2550")]
	public int MKCBFIBLIDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D58A50", Offset = "0x6D57C50", VA = "0x186D58A50")]
	public OGKGBNIIADC ENAJIFOJMLF(int CMOEDDFMDJD, int GIDMHIMFIHF)
	{
		return default(OGKGBNIIADC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class HBOAOACHJCM
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] JCJDJKIMOBE;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] PANOGFBHICK;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int JGIHIMGLHCF;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A0D0", Offset = "0x6D492D0", VA = "0x186D4A0D0")]
	private static byte[] GOPOEOONPBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D49A40", Offset = "0x6D48C40", VA = "0x186D49A40")]
	private static OGKGBNIIADC BMJEDNNGBGO(OGKGBNIIADC OPMKPGEDLGD)
	{
		return default(OGKGBNIIADC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A1B0", Offset = "0x6D493B0", VA = "0x186D4A1B0")]
	private static OGKGBNIIADC HBFOLICJBAA(OGKGBNIIADC OPMKPGEDLGD)
	{
		return default(OGKGBNIIADC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A850", Offset = "0x6D49A50", VA = "0x186D4A850")]
	private static void OOMLNBELDLK(OGKGBNIIADC OPMKPGEDLGD, int BPPEENPDDDA, byte[] HILGHNEEHJP, [Out] int FHPACAPEILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A3B0", Offset = "0x6D495B0", VA = "0x186D4A3B0")]
	private static void IJIGDHFACJF(OGKGBNIIADC OPMKPGEDLGD, int BPPEENPDDDA, byte[] PGCHKEIPOAO, int ANLBOIDAONK, [Out] OGKGBNIIADC JIHFGGECPIF, [Out] int EHNLNEFDAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A6A0", Offset = "0x6D498A0", VA = "0x186D4A6A0")]
	private static ulong KNOEJHCAIAE(OGKGBNIIADC OPMKPGEDLGD, [Out] int NNJPCNPILHM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D49B20", Offset = "0x6D48D20", VA = "0x186D49B20")]
	private static void CPJPMIBEIDG(OGKGBNIIADC OPMKPGEDLGD, [Out] HDMFLEAFPKE JBENFHJBMMN, [Out] int HHAFHJJILKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A8E0", Offset = "0x6D49AE0", VA = "0x186D4A8E0")]
	private static bool PFDMJPNFMMD(OGKGBNIIADC JIHFGGECPIF, int BPPEENPDDDA, [Out] double JBENFHJBMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D49C60", Offset = "0x6D48E60", VA = "0x186D49C60")]
	private static HDMFLEAFPKE EIBOJEOHJJN(int BPPEENPDDDA)
	{
		return default(HDMFLEAFPKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D4ACB0", Offset = "0x6D49EB0", VA = "0x186D4ACB0")]
	private static bool PFHLIDDOMOA(OGKGBNIIADC OPMKPGEDLGD, int BPPEENPDDDA, [Out] double JBENFHJBMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A730", Offset = "0x6D49930", VA = "0x186D4A730")]
	private static bool MAAGCNDJEDE(OGKGBNIIADC JIHFGGECPIF, int BPPEENPDDDA, [Out] double JALCFOOECDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D4A290", Offset = "0x6D49490", VA = "0x186D4A290")]
	public static double? HDICNGDBHGK(OGKGBNIIADC OPMKPGEDLGD, int BPPEENPDDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D49E00", Offset = "0x6D49000", VA = "0x186D49E00")]
	public static float? GKLILECDJMH(OGKGBNIIADC OPMKPGEDLGD, int BPPEENPDDDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MBDFEAEBJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] OPMKPGEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int CFPEDCFCDGK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D53F00", Offset = "0x6D53100", VA = "0x186D53F00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x19E1BA0", Offset = "0x19E0DA0", VA = "0x1819E1BA0")]
	public MBDFEAEBJAE(byte[] OPMKPGEDLGD, int CFPEDCFCDGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D53FA0", Offset = "0x6D531A0", VA = "0x186D53FA0")]
	public static MBDFEAEBJAE MJMHAKDNFJM(MBDFEAEBJAE CJKIBFNGPNM)
	{
		return default(MBDFEAEBJAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D53DD0", Offset = "0x6D52FD0", VA = "0x186D53DD0")]
	public static MBDFEAEBJAE CJEHLBODIDA(MBDFEAEBJAE CJKIBFNGPNM, int MKCBFIBLIDD)
	{
		return default(MBDFEAEBJAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D53EB0", Offset = "0x6D530B0", VA = "0x186D53EB0")]
	public static int HFGNJBDEAKI(MBDFEAEBJAE GFINPEICFEL, MBDFEAEBJAE ENBAOKALGHB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D53F30", Offset = "0x6D53130", VA = "0x186D53F30")]
	public static bool LOAKJDDAMKI(MBDFEAEBJAE GFINPEICFEL, MBDFEAEBJAE ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D53EF0", Offset = "0x6D530F0", VA = "0x186D53EF0")]
	public static bool IICOCCMJGPI(MBDFEAEBJAE GFINPEICFEL, MBDFEAEBJAE ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D53F40", Offset = "0x6D53140", VA = "0x186D53F40")]
	public static bool LOAKJDDAMKI(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D53EC0", Offset = "0x6D530C0", VA = "0x186D53EC0")]
	public static bool IICOCCMJGPI(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D53EC0", Offset = "0x6D530C0", VA = "0x186D53EC0")]
	public static bool IICOCCMJGPI(MBDFEAEBJAE GFINPEICFEL, byte ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D53E20", Offset = "0x6D53020", VA = "0x186D53E20")]
	public static bool EOLLEGKBGAH(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D53E50", Offset = "0x6D53050", VA = "0x186D53E50")]
	public static bool FKGMFEDPIKG(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D53E80", Offset = "0x6D53080", VA = "0x186D53E80")]
	public static bool GDFFKPOOHOO(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D53F70", Offset = "0x6D53170", VA = "0x186D53F70")]
	public static bool MEKLKLAELJI(MBDFEAEBJAE GFINPEICFEL, char ENBAOKALGHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class EOOGMLOCAEC
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] GJPDAEDNLMJ;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] HFAOPMANJHL;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] IEAOEFDJEHI;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] NDPHBMBLJFI;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] LFAKPPOFELB;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int EAMEOKBINND;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] NAACOLMEELC;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int IDMPBKELDAC;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D479B0", Offset = "0x6D46BB0", VA = "0x186D479B0")]
	private static byte[] FBCGGKAGOAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D47C10", Offset = "0x6D46E10", VA = "0x186D47C10")]
	private static byte[] LBGKADBPJEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D47A90", Offset = "0x6D46C90", VA = "0x186D47A90")]
	public static double GMCILGONOLH(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D47B40", Offset = "0x6D46D40", VA = "0x186D47B40")]
	public static float HCOGCBEGKGP(byte[] OPMKPGEDLGD, int CFPEDCFCDGK, [Out] int GDNMMMLACIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D48C90", Offset = "0x6D47E90", VA = "0x186D48C90")]
	private static bool NOACAEHNBGE(int DCHJALFCEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D477C0", Offset = "0x6D469C0", VA = "0x186D477C0")]
	private static bool CPFCLAPEMPE(MBDFEAEBJAE LPANOKJIEKD, MBDFEAEBJAE AADBIEHCAOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D476F0", Offset = "0x6D468F0", VA = "0x186D476F0")]
	private static bool CIMGLDDGJCJ(MBDFEAEBJAE LPANOKJIEKD, MBDFEAEBJAE AADBIEHCAOJ, byte[] HHCBFOOJNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D48DD0", Offset = "0x6D47FD0", VA = "0x186D48DD0")]
	private static bool PKCHODPHMDF(MBDFEAEBJAE KLOLAGMEJEK, byte[] DIDBPNGGKDB, int CFPEDCFCDGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D47BF0", Offset = "0x6D46DF0", VA = "0x186D47BF0")]
	private static double LABKNCPFCKK(bool HPHPNEPPEEP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D47CF0", Offset = "0x6D46EF0", VA = "0x186D47CF0")]
	private static double LKKNCJPMGBB(MBDFEAEBJAE NBFGFAAMIMJ, int MKCBFIBLIDD, bool BILMDKDCAHH, [Out] int KONFJGCBOEH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class HGFHEEFJEGM<T> : EALLCKLMLAA<T[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly OLDLMONIPAM<T> LBJBBKHHFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly NDLBDHLBNDL KJPOKOKMEHK;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E00", Offset = "0x3A36000", VA = "0x183A36E00")]
	public HGFHEEFJEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
	public HGFHEEFJEGM(NDLBDHLBNDL KJPOKOKMEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A366E0", Offset = "0x3A358E0", VA = "0x183A366E0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A36920", Offset = "0x3A35B20", VA = "0x183A36920", Slot = "5")]
	public T[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class EFNFOMIIDOI<T> : EALLCKLMLAA<ArraySegment<T>>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly OLDLMONIPAM<T> LBJBBKHHFPO;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3571C20", Offset = "0x3570E20", VA = "0x183571C20", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ArraySegment<T> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3571F20", Offset = "0x3571120", VA = "0x183571F20", Slot = "5")]
	public ArraySegment<T> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class KAFFLLBLFMG<T> : EALLCKLMLAA<List<T>>, DIGEJECCEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly NDLBDHLBNDL KJPOKOKMEHK;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E00", Offset = "0x3A36000", VA = "0x183A36E00")]
	public KAFFLLBLFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
	public KAFFLLBLFMG(NDLBDHLBNDL KJPOKOKMEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C790", Offset = "0x3E2B990", VA = "0x183E2C790", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, List<T> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3E30170", Offset = "0x3E2F370", VA = "0x183E30170", Slot = "5")]
	public List<T> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class LHMIKPCAGKG<TElement, TIntermediate, TEnumerator, TCollection> : EALLCKLMLAA<TCollection>, DIGEJECCEIM where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3F49280", Offset = "0x3F48480", VA = "0x183F49280", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, TCollection HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B850", Offset = "0x3F4AA50", VA = "0x183F4B850", Slot = "5")]
	public TCollection IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JHKFEAEDKHK(TCollection GNIGPOPNBEB);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate ADOMMGOMPJC();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void LGLNKEHGBKE(TIntermediate IANBIIFLGNN, int PMNHOLIPOMJ, TElement HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection JDPAOPOAJJL(TIntermediate EDFBMIKNPNF);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected LHMIKPCAGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class FDMMEBIDEHK<TElement, TIntermediate, TCollection> : LHMIKPCAGKG<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3902F60", Offset = "0x3902160", VA = "0x183902F60", Slot = "6")]
	protected override IEnumerator<TElement> JHKFEAEDKHK(TCollection GNIGPOPNBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3546860", Offset = "0x3545A60", VA = "0x183546860")]
	protected FDMMEBIDEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class GOJKFBAAPFA<TElement, TCollection> : FDMMEBIDEHK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected sealed override TCollection JDPAOPOAJJL(TCollection EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class DFHKLFNMCCD<TElement, TCollection> : GOJKFBAAPFA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x532EAE0", Offset = "0x532DCE0", VA = "0x18532EAE0", Slot = "7")]
	protected override TCollection ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x532EB00", Offset = "0x532DD00", VA = "0x18532EB00", Slot = "8")]
	protected override void LGLNKEHGBKE(TCollection IANBIIFLGNN, int PMNHOLIPOMJ, TElement HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class JJHAKKCDOCF<T> : LHMIKPCAGKG<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3982A60", Offset = "0x3981C60", VA = "0x183982A60", Slot = "8")]
	protected override void LGLNKEHGBKE(LinkedList<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override LinkedList<T> JDPAOPOAJJL(LinkedList<T> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override LinkedList<T> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3D5B340", Offset = "0x3D5A540", VA = "0x183D5B340", Slot = "6")]
	protected override LinkedList<T>.Enumerator JHKFEAEDKHK(LinkedList<T> GNIGPOPNBEB)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class CDKABCGCGHF<T> : LHMIKPCAGKG<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3982A60", Offset = "0x3981C60", VA = "0x183982A60", Slot = "8")]
	protected override void LGLNKEHGBKE(Queue<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override Queue<T> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3A35D10", Offset = "0x3A34F10", VA = "0x183A35D10", Slot = "6")]
	protected override Queue<T>.Enumerator JHKFEAEDKHK(Queue<T> GNIGPOPNBEB)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override Queue<T> JDPAOPOAJJL(Queue<T> EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class LLHGOHHCIEH<T> : LHMIKPCAGKG<T, BPBCOCOJEAK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3F66770", Offset = "0x3F65970", VA = "0x183F66770", Slot = "8")]
	protected override void LGLNKEHGBKE(BPBCOCOJEAK<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3F66600", Offset = "0x3F65800", VA = "0x183F66600", Slot = "7")]
	protected override BPBCOCOJEAK<T> ADOMMGOMPJC()
	{
		return default(BPBCOCOJEAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3F66710", Offset = "0x3F65910", VA = "0x183F66710", Slot = "6")]
	protected override Stack<T>.Enumerator JHKFEAEDKHK(Stack<T> GNIGPOPNBEB)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3F66630", Offset = "0x3F65830", VA = "0x183F66630", Slot = "9")]
	protected override Stack<T> JDPAOPOAJJL(BPBCOCOJEAK<T> EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class HFMEIODPAKL<T> : LHMIKPCAGKG<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3982A60", Offset = "0x3981C60", VA = "0x183982A60", Slot = "8")]
	protected override void LGLNKEHGBKE(HashSet<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override HashSet<T> JDPAOPOAJJL(HashSet<T> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override HashSet<T> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3A35D10", Offset = "0x3A34F10", VA = "0x183A35D10", Slot = "6")]
	protected override HashSet<T>.Enumerator JHKFEAEDKHK(HashSet<T> GNIGPOPNBEB)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class NLAPIECKJLC<T> : FDMMEBIDEHK<T, BPBCOCOJEAK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3F66770", Offset = "0x3F65970", VA = "0x183F66770", Slot = "8")]
	protected override void LGLNKEHGBKE(BPBCOCOJEAK<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x41BD000", Offset = "0x41BC200", VA = "0x1841BD000", Slot = "9")]
	protected override ReadOnlyCollection<T> JDPAOPOAJJL(BPBCOCOJEAK<T> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x41BCFD0", Offset = "0x41BC1D0", VA = "0x1841BCFD0", Slot = "7")]
	protected override BPBCOCOJEAK<T> ADOMMGOMPJC()
	{
		return default(BPBCOCOJEAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class AAKKPACOMAJ<T> : FDMMEBIDEHK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3982A60", Offset = "0x3981C60", VA = "0x183982A60", Slot = "8")]
	protected override void LGLNKEHGBKE(List<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override List<T> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override IList<T> JDPAOPOAJJL(List<T> EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class OHPFKNMDKNF<T> : FDMMEBIDEHK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3982A60", Offset = "0x3981C60", VA = "0x183982A60", Slot = "8")]
	protected override void LGLNKEHGBKE(List<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override List<T> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override ICollection<T> JDPAOPOAJJL(List<T> EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class NDJKMDLCDIH<T> : FDMMEBIDEHK<T, BPBCOCOJEAK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3F66770", Offset = "0x3F65970", VA = "0x183F66770", Slot = "8")]
	protected override void LGLNKEHGBKE(BPBCOCOJEAK<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3F66600", Offset = "0x3F65800", VA = "0x183F66600", Slot = "7")]
	protected override BPBCOCOJEAK<T> ADOMMGOMPJC()
	{
		return default(BPBCOCOJEAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x419CC60", Offset = "0x419BE60", VA = "0x18419CC60", Slot = "9")]
	protected override IEnumerable<T> JDPAOPOAJJL(BPBCOCOJEAK<T> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x35545B0", Offset = "0x35537B0", VA = "0x1835545B0")]
	public NDJKMDLCDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class JGJCCMEBDPG<TKey, TElement> : EALLCKLMLAA<IGrouping<TKey, TElement>>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EBF0", Offset = "0x3D4DDF0", VA = "0x183D4EBF0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, IGrouping<TKey, TElement> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EE50", Offset = "0x3D4E050", VA = "0x183D4EE50", Slot = "5")]
	public IGrouping<TKey, TElement> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class CNBAGKOFKBP<TKey, TElement> : EALLCKLMLAA<ILookup<TKey, TElement>>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5157430", Offset = "0x5156630", VA = "0x185157430", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ILookup<TKey, TElement> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x51575B0", Offset = "0x51567B0", VA = "0x1851575B0", Slot = "5")]
	public ILookup<TKey, TElement> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class JPJLBHBPHKP<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey MNOIAMGNLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> JMAHFBFPIEP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey HCJOAPEDCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
	public JPJLBHBPHKP(TKey MNOIAMGNLNL, IEnumerable<TElement> JMAHFBFPIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0A20", Offset = "0x3D9FC20", VA = "0x183DA0A20", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3572A20", Offset = "0x3571C20", VA = "0x183572A20", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class KDHGBFMMBLJ<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> JJECNBOELNB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3927740", Offset = "0x3926940", VA = "0x183927740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public KDHGBFMMBLJ(Dictionary<TKey, IGrouping<TKey, TElement>> JJECNBOELNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x355E430", Offset = "0x355D630", VA = "0x18355E430", Slot = "5")]
	public bool Contains(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BDA0", Offset = "0x3E4AFA0", VA = "0x183E4BDA0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BDA0", Offset = "0x3E4AFA0", VA = "0x183E4BDA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LFLNDMANMON<T> : EALLCKLMLAA<T>, DIGEJECCEIM where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3F420E0", Offset = "0x3F412E0", VA = "0x183F420E0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3F423F0", Offset = "0x3F415F0", VA = "0x183F423F0", Slot = "5")]
	public T IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public LFLNDMANMON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NNHGCNBLNMN : EALLCKLMLAA<IEnumerable>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly EALLCKLMLAA<IEnumerable> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6D67530", Offset = "0x6D66730", VA = "0x186D67530", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, IEnumerable HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6D677E0", Offset = "0x6D669E0", VA = "0x186D677E0", Slot = "5")]
	public IEnumerable IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NNHGCNBLNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class LKBHIOFJCAI : EALLCKLMLAA<ICollection>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly EALLCKLMLAA<ICollection> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6D65330", Offset = "0x6D64530", VA = "0x186D65330", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ICollection HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6D656D0", Offset = "0x6D648D0", VA = "0x186D656D0", Slot = "5")]
	public ICollection IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public LKBHIOFJCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BPPEOFMMAEH : EALLCKLMLAA<IList>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly EALLCKLMLAA<IList> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A230", Offset = "0x6D59430", VA = "0x186D5A230", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, IList HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A540", Offset = "0x6D59740", VA = "0x186D5A540", Slot = "5")]
	public IList IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BPPEOFMMAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NHIHLKHLBAB<T> : FDMMEBIDEHK<T, BPBCOCOJEAK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x41ABA70", Offset = "0x41AAC70", VA = "0x1841ABA70", Slot = "8")]
	protected override void LGLNKEHGBKE(BPBCOCOJEAK<T> IANBIIFLGNN, int PMNHOLIPOMJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3F66600", Offset = "0x3F65800", VA = "0x183F66600", Slot = "7")]
	protected override BPBCOCOJEAK<T> ADOMMGOMPJC()
	{
		return default(BPBCOCOJEAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x41ABA20", Offset = "0x41AAC20", VA = "0x1841ABA20", Slot = "9")]
	protected override IReadOnlyList<T> JDPAOPOAJJL(BPBCOCOJEAK<T> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3553F80", Offset = "0x3553180", VA = "0x183553F80")]
	public NHIHLKHLBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class CJAFEHENJAL
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B790", Offset = "0x6D5A990", VA = "0x186D5B790")]
	public static DateTime DICNDLMOFHC(DateTime IGFAIIEGNDI)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GOPMHICOCGA : EALLCKLMLAA<DateTime>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly EALLCKLMLAA<DateTime> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6D61870", Offset = "0x6D60A70", VA = "0x186D61870", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, DateTime HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6D62020", Offset = "0x6D61220", VA = "0x186D62020", Slot = "5")]
	public DateTime IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GOPMHICOCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class DDOEGCBOIAN : EALLCKLMLAA<DateTimeOffset>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly EALLCKLMLAA<DateTimeOffset> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B850", Offset = "0x6D5AA50", VA = "0x186D5B850", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, DateTimeOffset HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BEF0", Offset = "0x6D5B0F0", VA = "0x186D5BEF0", Slot = "5")]
	public DateTimeOffset IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DDOEGCBOIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class EDFHNEJIIJP : EALLCKLMLAA<TimeSpan>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly EALLCKLMLAA<TimeSpan> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] MOEFJDOKMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D5F0", Offset = "0x6D5C7F0", VA = "0x186D5D5F0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, TimeSpan HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D9D0", Offset = "0x6D5CBD0", VA = "0x186D5D9D0", Slot = "5")]
	public TimeSpan IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public EDFHNEJIIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class JHHEBDFNBFB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : EALLCKLMLAA<TDictionary>, DIGEJECCEIM where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3D51E20", Offset = "0x3D51020", VA = "0x183D51E20", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, TDictionary HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3D532B0", Offset = "0x3D524B0", VA = "0x183D532B0", Slot = "5")]
	public TDictionary IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JHKFEAEDKHK(TDictionary GNIGPOPNBEB);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate ADOMMGOMPJC();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void LGLNKEHGBKE(TIntermediate IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary JDPAOPOAJJL(TIntermediate EDFBMIKNPNF);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected JHHEBDFNBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class OJOOKCFBEDA<TKey, TValue, TIntermediate, TDictionary> : JHHEBDFNBFB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3902F60", Offset = "0x3902160", VA = "0x183902F60", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JHKFEAEDKHK(TDictionary GNIGPOPNBEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class NAALBOINGGM<TKey, TValue, TDictionary> : OJOOKCFBEDA<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override TDictionary JDPAOPOAJJL(TDictionary EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KGPAKFDHCPG<TKey, TValue> : JHHEBDFNBFB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E3F0", Offset = "0x3E9D5F0", VA = "0x183E9E3F0", Slot = "8")]
	protected override void LGLNKEHGBKE(Dictionary<TKey, TValue> IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override Dictionary<TKey, TValue> JDPAOPOAJJL(Dictionary<TKey, TValue> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override Dictionary<TKey, TValue> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E2A0", Offset = "0x3E9D4A0", VA = "0x183E9E2A0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JHKFEAEDKHK(Dictionary<TKey, TValue> GNIGPOPNBEB)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3545B60", Offset = "0x3544D60", VA = "0x183545B60")]
	public KGPAKFDHCPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OHPOBDEMIEA<TKey, TValue, TDictionary> : NAALBOINGGM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x42964E0", Offset = "0x42956E0", VA = "0x1842964E0", Slot = "8")]
	protected override void LGLNKEHGBKE(TDictionary IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3350DC0", Offset = "0x334FFC0", VA = "0x183350DC0", Slot = "7")]
	protected override TDictionary ADOMMGOMPJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class LLLFCCIIPPI<TKey, TValue> : OJOOKCFBEDA<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x390F1E0", Offset = "0x390E3E0", VA = "0x18390F1E0", Slot = "8")]
	protected override void LGLNKEHGBKE(Dictionary<TKey, TValue> IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override Dictionary<TKey, TValue> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override IDictionary<TKey, TValue> JDPAOPOAJJL(Dictionary<TKey, TValue> EDFBMIKNPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class NGCMNPHGOCK<TKey, TValue> : NAALBOINGGM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x390F1E0", Offset = "0x390E3E0", VA = "0x18390F1E0", Slot = "8")]
	protected override void LGLNKEHGBKE(SortedList<TKey, TValue> IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override SortedList<TKey, TValue> ADOMMGOMPJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class FJNJKAPAJEF<TKey, TValue> : JHHEBDFNBFB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x390F1E0", Offset = "0x390E3E0", VA = "0x18390F1E0", Slot = "8")]
	protected override void LGLNKEHGBKE(SortedDictionary<TKey, TValue> IANBIIFLGNN, int PMNHOLIPOMJ, TKey MNOIAMGNLNL, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> JDPAOPOAJJL(SortedDictionary<TKey, TValue> EDFBMIKNPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x390F110", Offset = "0x390E310", VA = "0x18390F110", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> ADOMMGOMPJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x390F180", Offset = "0x390E380", VA = "0x18390F180", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JHKFEAEDKHK(SortedDictionary<TKey, TValue> GNIGPOPNBEB)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class GPNCEIMPFDI<T> : EALLCKLMLAA<T>, DIGEJECCEIM where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x39F1910", Offset = "0x39F0B10", VA = "0x1839F1910", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x39F1DF0", Offset = "0x39F0FF0", VA = "0x1839F1DF0", Slot = "5")]
	public T IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GPNCEIMPFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class GAHMBKNHABJ : EALLCKLMLAA<IDictionary>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly EALLCKLMLAA<IDictionary> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F750", Offset = "0x6D5E950", VA = "0x186D5F750", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, IDictionary HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FC30", Offset = "0x6D5EE30", VA = "0x186D5FC30", Slot = "5")]
	public IDictionary IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GAHMBKNHABJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class CHPFJMAJNKA : EALLCKLMLAA<object>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void ECFGFCCLGAD(object GBAKOKHIKCA, NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly GENCCANBDFF<KeyValuePair<object, ECFGFCCLGAD>> BCKHGABHJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly DLKMGGPEHOD[] FNHKPJIFFEI;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B4D0", Offset = "0x6D5A6D0", VA = "0x186D5B4D0")]
	public CHPFJMAJNKA(params DLKMGGPEHOD[] FNHKPJIFFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AA70", Offset = "0x6D59C70", VA = "0x186D5AA70", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B440", Offset = "0x6D5A640", VA = "0x186D5B440", Slot = "5")]
	public object IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class GMKCNHCMMOF
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6D60F80", Offset = "0x6D60180", VA = "0x186D60F80")]
	public static object HDGPGACPCPF(Type HHJOOHJDNNM, [Out] bool AKEMHNBDCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6D60690", Offset = "0x6D5F890", VA = "0x186D60690")]
	public static object EJHDGONCIDD(Type HHJOOHJDNNM, [Out] bool AKEMHNBDCML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class ONOBLPDLHOD<T> : EALLCKLMLAA<T>, DIGEJECCEIM, DCIBAAGBONL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class AJHBGEDJGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AJHBGEDJGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3D61D70", Offset = "0x3D60F70", VA = "0x183D61D70")]
		internal bool BECCMJIEEFD(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class BFJLJBJAODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public BFJLJBJAODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A543C0", Offset = "0x4A535C0", VA = "0x184A543C0")]
		internal bool JJNPECMCAEP(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class HMNNCDKENNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public NIDMMKALCNK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HMNNCDKENNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A561E0", Offset = "0x3A553E0", VA = "0x183A561E0")]
		internal void GDOBDCKOBMO(NKHADIMENKO writer, T value, DLKMGGPEHOD _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class FLELKCNKLON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public MLHEIDONAGP<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public FLELKCNKLON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x39202D0", Offset = "0x391F4D0", VA = "0x1839202D0")]
		internal T MJDFFINIMEG(DOMGOGFMLMG reader, DLKMGGPEHOD _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly IOHDICCOJCP<T> MHKBCHBMOKM;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> BKKFCIMNNJJ;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly NIDMMKALCNK<T> GGJPNEGFJOF;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly MLHEIDONAGP<T> LLAIBJFKNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool ACAPFCGLKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly NIDMMKALCNK<T> NFJBJKFACGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly MLHEIDONAGP<T> EEIJODCOGGK;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x42B9550", Offset = "0x42B8750", VA = "0x1842B9550")]
	static ONOBLPDLHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x42BDDE0", Offset = "0x42BCFE0", VA = "0x1842BDDE0")]
	public ONOBLPDLHOD(bool ACAPFCGLKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x42B3150", Offset = "0x42B2350", VA = "0x1842B3150", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x42B4CE0", Offset = "0x42B3EE0", VA = "0x1842B4CE0", Slot = "5")]
	public T IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x42B2C00", Offset = "0x42B1E00", VA = "0x1842B2C00", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, T HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x42B5860", Offset = "0x42B4A60", VA = "0x1842B5860", Slot = "7")]
	public T ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class DNEKKALJHKF<T> : EALLCKLMLAA<T[,]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5348630", Offset = "0x5347830", VA = "0x185348630", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T[,] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x53488A0", Offset = "0x5347AA0", VA = "0x1853488A0", Slot = "5")]
	public T[,] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DNEKKALJHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class NENDGDNIPAM<T> : EALLCKLMLAA<T[,,]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x419E190", Offset = "0x419D390", VA = "0x18419E190", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T[,,] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x419E4B0", Offset = "0x419D6B0", VA = "0x18419E4B0", Slot = "5")]
	public T[,,] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NENDGDNIPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class FLKFDLBHJHP<T> : EALLCKLMLAA<T[,,,]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3920A90", Offset = "0x391FC90", VA = "0x183920A90", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T[,,,] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3920E60", Offset = "0x3920060", VA = "0x183920E60", Slot = "5")]
	public T[,,,] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FLKFDLBHJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class BFEEICNHKPD<T> : EALLCKLMLAA<T?>, DIGEJECCEIM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A51800", Offset = "0x4A50A00", VA = "0x184A51800", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A51970", Offset = "0x4A50B70", VA = "0x184A51970", Slot = "5")]
	public T? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BFEEICNHKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class OEJFPJGKCHI<T> : EALLCKLMLAA<T?>, DIGEJECCEIM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly EALLCKLMLAA<T> MHKNHEJFANE;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public OEJFPJGKCHI(EALLCKLMLAA<T> MHKNHEJFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x428D6C0", Offset = "0x428C8C0", VA = "0x18428D6C0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, T? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x428E0A0", Offset = "0x428D2A0", VA = "0x18428E0A0", Slot = "5")]
	public T? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class AHKEGOFIDEK : EALLCKLMLAA<sbyte>, DIGEJECCEIM, DCIBAAGBONL<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly AHKEGOFIDEK DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D592D0", Offset = "0x6D584D0", VA = "0x186D592D0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, sbyte HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D59330", Offset = "0x6D58530", VA = "0x186D59330", Slot = "5")]
	public sbyte IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D59260", Offset = "0x6D58460", VA = "0x186D59260", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, sbyte HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D59380", Offset = "0x6D58580", VA = "0x186D59380", Slot = "7")]
	public sbyte ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AHKEGOFIDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class NOHOGIGLGKI : EALLCKLMLAA<sbyte?>, DIGEJECCEIM, DCIBAAGBONL<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly NOHOGIGLGKI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D67B70", Offset = "0x6D66D70", VA = "0x186D67B70", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, sbyte? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D67C30", Offset = "0x6D66E30", VA = "0x186D67C30", Slot = "5")]
	public sbyte? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D67AB0", Offset = "0x6D66CB0", VA = "0x186D67AB0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, sbyte? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D67CE0", Offset = "0x6D66EE0", VA = "0x186D67CE0", Slot = "7")]
	public sbyte? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NOHOGIGLGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class NKBBICOCFMI : EALLCKLMLAA<sbyte[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly NKBBICOCFMI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D66F90", Offset = "0x6D66190", VA = "0x186D66F90", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, sbyte[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D670C0", Offset = "0x6D662C0", VA = "0x186D670C0", Slot = "5")]
	public sbyte[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NKBBICOCFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class NAFFBFFNIBE : EALLCKLMLAA<short>, DIGEJECCEIM, DCIBAAGBONL<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly NAFFBFFNIBE DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D669D0", Offset = "0x6D65BD0", VA = "0x186D669D0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, short HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D66A30", Offset = "0x6D65C30", VA = "0x186D66A30", Slot = "5")]
	public short IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D66960", Offset = "0x6D65B60", VA = "0x186D66960", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, short HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D66A80", Offset = "0x6D65C80", VA = "0x186D66A80", Slot = "7")]
	public short ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NAFFBFFNIBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class NEDLMAJBJFK : EALLCKLMLAA<short?>, DIGEJECCEIM, DCIBAAGBONL<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly NEDLMAJBJFK DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D66C80", Offset = "0x6D65E80", VA = "0x186D66C80", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, short? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D66D40", Offset = "0x6D65F40", VA = "0x186D66D40", Slot = "5")]
	public short? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D66BC0", Offset = "0x6D65DC0", VA = "0x186D66BC0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, short? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D66DF0", Offset = "0x6D65FF0", VA = "0x186D66DF0", Slot = "7")]
	public short? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NEDLMAJBJFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class EKENHACJHHA : EALLCKLMLAA<short[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly EKENHACJHHA DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E790", Offset = "0x6D5D990", VA = "0x186D5E790", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, short[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E8C0", Offset = "0x6D5DAC0", VA = "0x186D5E8C0", Slot = "5")]
	public short[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public EKENHACJHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class NNALOFKJNOH : EALLCKLMLAA<int>, DIGEJECCEIM, DCIBAAGBONL<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly NNALOFKJNOH DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D67340", Offset = "0x6D66540", VA = "0x186D67340", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, int HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D673A0", Offset = "0x6D665A0", VA = "0x186D673A0", Slot = "5")]
	public int IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D672D0", Offset = "0x6D664D0", VA = "0x186D672D0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, int HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D673F0", Offset = "0x6D665F0", VA = "0x186D673F0", Slot = "7")]
	public int ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public NNALOFKJNOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class KBEFADHPMFC : EALLCKLMLAA<int?>, DIGEJECCEIM, DCIBAAGBONL<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly KBEFADHPMFC DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D64A40", Offset = "0x6D63C40", VA = "0x186D64A40", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, int? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D64B00", Offset = "0x6D63D00", VA = "0x186D64B00", Slot = "5")]
	public int? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D64980", Offset = "0x6D63B80", VA = "0x186D64980", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, int? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D64BB0", Offset = "0x6D63DB0", VA = "0x186D64BB0", Slot = "7")]
	public int? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KBEFADHPMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class ONKCGHNOKJO : EALLCKLMLAA<int[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly ONKCGHNOKJO DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D680E0", Offset = "0x6D672E0", VA = "0x186D680E0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, int[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6D68210", Offset = "0x6D67410", VA = "0x186D68210", Slot = "5")]
	public int[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public ONKCGHNOKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GGCPPGPJNAF : EALLCKLMLAA<long>, DIGEJECCEIM, DCIBAAGBONL<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GGCPPGPJNAF DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D604A0", Offset = "0x6D5F6A0", VA = "0x186D604A0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, long HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D60500", Offset = "0x6D5F700", VA = "0x186D60500", Slot = "5")]
	public long IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D60430", Offset = "0x6D5F630", VA = "0x186D60430", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, long HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D60550", Offset = "0x6D5F750", VA = "0x186D60550", Slot = "7")]
	public long ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GGCPPGPJNAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class JGGOHEJEFNI : EALLCKLMLAA<long?>, DIGEJECCEIM, DCIBAAGBONL<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly JGGOHEJEFNI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D64640", Offset = "0x6D63840", VA = "0x186D64640", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, long? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D64700", Offset = "0x6D63900", VA = "0x186D64700", Slot = "5")]
	public long? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D64580", Offset = "0x6D63780", VA = "0x186D64580", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, long? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D647C0", Offset = "0x6D639C0", VA = "0x186D647C0", Slot = "7")]
	public long? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public JGGOHEJEFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class IIKKKBHPLPB : EALLCKLMLAA<long[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly IIKKKBHPLPB DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D63B80", Offset = "0x6D62D80", VA = "0x186D63B80", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, long[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D63CB0", Offset = "0x6D62EB0", VA = "0x186D63CB0", Slot = "5")]
	public long[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IIKKKBHPLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class BDOHFGPHLCA : EALLCKLMLAA<byte>, DIGEJECCEIM, DCIBAAGBONL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly BDOHFGPHLCA DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D59530", Offset = "0x6D58730", VA = "0x186D59530", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, byte HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D59590", Offset = "0x6D58790", VA = "0x186D59590", Slot = "5")]
	public byte IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D594C0", Offset = "0x6D586C0", VA = "0x186D594C0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, byte HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D595E0", Offset = "0x6D587E0", VA = "0x186D595E0", Slot = "7")]
	public byte ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BDOHFGPHLCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class FLGLONAGGBC : EALLCKLMLAA<byte?>, DIGEJECCEIM, DCIBAAGBONL<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly FLGLONAGGBC DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F1A0", Offset = "0x6D5E3A0", VA = "0x186D5F1A0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, byte? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F260", Offset = "0x6D5E460", VA = "0x186D5F260", Slot = "5")]
	public byte? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F0E0", Offset = "0x6D5E2E0", VA = "0x186D5F0E0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, byte? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F310", Offset = "0x6D5E510", VA = "0x186D5F310", Slot = "7")]
	public byte? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FLGLONAGGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class IJILBGMECKJ : EALLCKLMLAA<ushort>, DIGEJECCEIM, DCIBAAGBONL<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly IJILBGMECKJ DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6D63F30", Offset = "0x6D63130", VA = "0x186D63F30", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ushort HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6D63F90", Offset = "0x6D63190", VA = "0x186D63F90", Slot = "5")]
	public ushort IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6D63EC0", Offset = "0x6D630C0", VA = "0x186D63EC0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, ushort HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6D63FE0", Offset = "0x6D631E0", VA = "0x186D63FE0", Slot = "7")]
	public ushort ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IJILBGMECKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class GPCMNNGACNM : EALLCKLMLAA<ushort?>, DIGEJECCEIM, DCIBAAGBONL<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly GPCMNNGACNM DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6D62E70", Offset = "0x6D62070", VA = "0x186D62E70", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ushort? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6D62F30", Offset = "0x6D62130", VA = "0x186D62F30", Slot = "5")]
	public ushort? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6D62DB0", Offset = "0x6D61FB0", VA = "0x186D62DB0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, ushort? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6D62FE0", Offset = "0x6D621E0", VA = "0x186D62FE0", Slot = "7")]
	public ushort? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GPCMNNGACNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IHLMJLFDAIF : EALLCKLMLAA<ushort[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly IHLMJLFDAIF DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6D63840", Offset = "0x6D62A40", VA = "0x186D63840", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ushort[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6D63970", Offset = "0x6D62B70", VA = "0x186D63970", Slot = "5")]
	public ushort[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IHLMJLFDAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CHEDJAFPFFO : EALLCKLMLAA<uint>, DIGEJECCEIM, DCIBAAGBONL<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly CHEDJAFPFFO DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A880", Offset = "0x6D59A80", VA = "0x186D5A880", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, uint HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A8E0", Offset = "0x6D59AE0", VA = "0x186D5A8E0", Slot = "5")]
	public uint IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A810", Offset = "0x6D59A10", VA = "0x186D5A810", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, uint HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A930", Offset = "0x6D59B30", VA = "0x186D5A930", Slot = "7")]
	public uint ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CHEDJAFPFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class PJLHMOPADIP : EALLCKLMLAA<uint?>, DIGEJECCEIM, DCIBAAGBONL<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly PJLHMOPADIP DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A510", Offset = "0x6D69710", VA = "0x186D6A510", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, uint? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A5D0", Offset = "0x6D697D0", VA = "0x186D6A5D0", Slot = "5")]
	public uint? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A450", Offset = "0x6D69650", VA = "0x186D6A450", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, uint? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A680", Offset = "0x6D69880", VA = "0x186D6A680", Slot = "7")]
	public uint? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PJLHMOPADIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class BMDNIIPJCOB : EALLCKLMLAA<uint[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BMDNIIPJCOB DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6D59AF0", Offset = "0x6D58CF0", VA = "0x186D59AF0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, uint[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6D59C20", Offset = "0x6D58E20", VA = "0x186D59C20", Slot = "5")]
	public uint[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BMDNIIPJCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class DLABMLMAJPM : EALLCKLMLAA<ulong>, DIGEJECCEIM, DCIBAAGBONL<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly DLABMLMAJPM DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D0D0", Offset = "0x6D5C2D0", VA = "0x186D5D0D0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ulong HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D130", Offset = "0x6D5C330", VA = "0x186D5D130", Slot = "5")]
	public ulong IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D060", Offset = "0x6D5C260", VA = "0x186D5D060", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, ulong HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D180", Offset = "0x6D5C380", VA = "0x186D5D180", Slot = "7")]
	public ulong ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DLABMLMAJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class BMGFFPLLOEJ : EALLCKLMLAA<ulong?>, DIGEJECCEIM, DCIBAAGBONL<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly BMGFFPLLOEJ DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6D59EF0", Offset = "0x6D590F0", VA = "0x186D59EF0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ulong? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6D59FB0", Offset = "0x6D591B0", VA = "0x186D59FB0", Slot = "5")]
	public ulong? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6D59E30", Offset = "0x6D59030", VA = "0x186D59E30", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, ulong? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A070", Offset = "0x6D59270", VA = "0x186D5A070", Slot = "7")]
	public ulong? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BMGFFPLLOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class GBHFEDCLDKD : EALLCKLMLAA<ulong[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly GBHFEDCLDKD DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FEE0", Offset = "0x6D5F0E0", VA = "0x186D5FEE0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ulong[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6D60010", Offset = "0x6D5F210", VA = "0x186D60010", Slot = "5")]
	public ulong[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GBHFEDCLDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class MINGMOJPCOK : EALLCKLMLAA<float>, DIGEJECCEIM, DCIBAAGBONL<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MINGMOJPCOK DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6D66160", Offset = "0x6D65360", VA = "0x186D66160", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, float HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6D661C0", Offset = "0x6D653C0", VA = "0x186D661C0", Slot = "5")]
	public float IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6D660F0", Offset = "0x6D652F0", VA = "0x186D660F0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, float HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6D66210", Offset = "0x6D65410", VA = "0x186D66210", Slot = "7")]
	public float ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MINGMOJPCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MGNKJNAEBFM : EALLCKLMLAA<float?>, DIGEJECCEIM, DCIBAAGBONL<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly MGNKJNAEBFM DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6D65DE0", Offset = "0x6D64FE0", VA = "0x186D65DE0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, float? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6D65EA0", Offset = "0x6D650A0", VA = "0x186D65EA0", Slot = "5")]
	public float? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6D65D20", Offset = "0x6D64F20", VA = "0x186D65D20", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, float? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6D65F50", Offset = "0x6D65150", VA = "0x186D65F50", Slot = "7")]
	public float? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MGNKJNAEBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class FKEAKEOIIDJ : EALLCKLMLAA<float[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FKEAKEOIIDJ DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5ED90", Offset = "0x6D5DF90", VA = "0x186D5ED90", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, float[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EED0", Offset = "0x6D5E0D0", VA = "0x186D5EED0", Slot = "5")]
	public float[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FKEAKEOIIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class OFDABKOHMNI : EALLCKLMLAA<double>, DIGEJECCEIM, DCIBAAGBONL<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly OFDABKOHMNI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6D67EF0", Offset = "0x6D670F0", VA = "0x186D67EF0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, double HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6D67F50", Offset = "0x6D67150", VA = "0x186D67F50", Slot = "5")]
	public double IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6D67E80", Offset = "0x6D67080", VA = "0x186D67E80", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, double HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6D67FA0", Offset = "0x6D671A0", VA = "0x186D67FA0", Slot = "7")]
	public double ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public OFDABKOHMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class KEPEHHKKJID : EALLCKLMLAA<double?>, DIGEJECCEIM, DCIBAAGBONL<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KEPEHHKKJID DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6D64FF0", Offset = "0x6D641F0", VA = "0x186D64FF0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, double? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6D650B0", Offset = "0x6D642B0", VA = "0x186D650B0", Slot = "5")]
	public double? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6D64F30", Offset = "0x6D64130", VA = "0x186D64F30", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, double? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6D65170", Offset = "0x6D64370", VA = "0x186D65170", Slot = "7")]
	public double? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KEPEHHKKJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class PIOFOBMPING : EALLCKLMLAA<double[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly PIOFOBMPING DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A100", Offset = "0x6D69300", VA = "0x186D6A100", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, double[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A240", Offset = "0x6D69440", VA = "0x186D6A240", Slot = "5")]
	public double[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PIOFOBMPING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class JBHDFACKCDI : EALLCKLMLAA<bool>, DIGEJECCEIM, DCIBAAGBONL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly JBHDFACKCDI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6D64390", Offset = "0x6D63590", VA = "0x186D64390", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, bool HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6D643F0", Offset = "0x6D635F0", VA = "0x186D643F0", Slot = "5")]
	public bool IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6D64320", Offset = "0x6D63520", VA = "0x186D64320", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, bool HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6D64440", Offset = "0x6D63640", VA = "0x186D64440", Slot = "7")]
	public bool ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public JBHDFACKCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class BJFGFFGKMII : EALLCKLMLAA<bool?>, DIGEJECCEIM, DCIBAAGBONL<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly BJFGFFGKMII DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6D597E0", Offset = "0x6D589E0", VA = "0x186D597E0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, bool? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6D598A0", Offset = "0x6D58AA0", VA = "0x186D598A0", Slot = "5")]
	public bool? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6D59720", Offset = "0x6D58920", VA = "0x186D59720", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, bool? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6D59950", Offset = "0x6D58B50", VA = "0x186D59950", Slot = "7")]
	public bool? ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public BJFGFFGKMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class EJFLHFDDGBI : EALLCKLMLAA<bool[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EJFLHFDDGBI DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E440", Offset = "0x6D5D640", VA = "0x186D5E440", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, bool[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E580", Offset = "0x6D5D780", VA = "0x186D5E580", Slot = "5")]
	public bool[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public EJFLHFDDGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class PAKDAAMDBKI : EALLCKLMLAA<object>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly EALLCKLMLAA<object> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> MBJPDMGIONP;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6D68790", Offset = "0x6D67990", VA = "0x186D68790", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, object HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6D69490", Offset = "0x6D68690", VA = "0x186D69490", Slot = "5")]
	public object IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PAKDAAMDBKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class IFNMLFJBBNF : EALLCKLMLAA<byte[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly EALLCKLMLAA<byte[]> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6D63650", Offset = "0x6D62850", VA = "0x186D63650", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, byte[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6D63710", Offset = "0x6D62910", VA = "0x186D63710", Slot = "5")]
	public byte[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IFNMLFJBBNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FDAENEFMPHA : EALLCKLMLAA<ArraySegment<byte>>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly EALLCKLMLAA<ArraySegment<byte>> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EAD0", Offset = "0x6D5DCD0", VA = "0x186D5EAD0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, ArraySegment<byte> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EC00", Offset = "0x6D5DE00", VA = "0x186D5EC00", Slot = "5")]
	public ArraySegment<byte> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FDAENEFMPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class KCGIIPPMOHD : EALLCKLMLAA<string>, DIGEJECCEIM, DCIBAAGBONL<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EALLCKLMLAA<string> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6D64DB0", Offset = "0x6D63FB0", VA = "0x186D64DB0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, string HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6D64E10", Offset = "0x6D64010", VA = "0x186D64E10", Slot = "5")]
	public string IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6D64D50", Offset = "0x6D63F50", VA = "0x186D64D50", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, string HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6D64E60", Offset = "0x6D64060", VA = "0x186D64E60", Slot = "7")]
	public string ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KCGIIPPMOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class MFLPDBGMHOM : EALLCKLMLAA<string[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly MFLPDBGMHOM DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6D659A0", Offset = "0x6D64BA0", VA = "0x186D659A0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, string[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6D65AD0", Offset = "0x6D64CD0", VA = "0x186D65AD0", Slot = "5")]
	public string[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MFLPDBGMHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HJCPLAHGIMM : EALLCKLMLAA<char>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly HJCPLAHGIMM DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6D63180", Offset = "0x6D62380", VA = "0x186D63180", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, char HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6D63240", Offset = "0x6D62440", VA = "0x186D63240", Slot = "5")]
	public char IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HJCPLAHGIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class FOKIAMLFLLF : EALLCKLMLAA<char?>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly FOKIAMLFLLF DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F4B0", Offset = "0x6D5E6B0", VA = "0x186D5F4B0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, char? HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F5B0", Offset = "0x6D5E7B0", VA = "0x186D5F5B0", Slot = "5")]
	public char? IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FOKIAMLFLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class MNNALNHLIBN : EALLCKLMLAA<char[]>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly MNNALNHLIBN DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6D66350", Offset = "0x6D65550", VA = "0x186D66350", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, char[] HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6D66500", Offset = "0x6D65700", VA = "0x186D66500", Slot = "5")]
	public char[] IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MNNALNHLIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class PIFKJBBGNAC : EALLCKLMLAA<Guid>, DIGEJECCEIM, DCIBAAGBONL<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly EALLCKLMLAA<Guid> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6D69E20", Offset = "0x6D69020", VA = "0x186D69E20", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, Guid HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6D69F50", Offset = "0x6D69150", VA = "0x186D69F50", Slot = "5")]
	public Guid IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6D69CE0", Offset = "0x6D68EE0", VA = "0x186D69CE0", Slot = "6")]
	public void FPIFDOBMLCM(NKHADIMENKO AELHGGJOBCK, Guid HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6D69FE0", Offset = "0x6D691E0", VA = "0x186D69FE0", Slot = "7")]
	public Guid ODKLELFEIAN(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public PIFKJBBGNAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DIMDFGBGKAM : EALLCKLMLAA<decimal>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly EALLCKLMLAA<decimal> DNJMIDOFPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool BMKPPNDDDJG;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5530E60", Offset = "0x5530060", VA = "0x185530E60")]
	public DIMDFGBGKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1980060", Offset = "0x197F260", VA = "0x181980060")]
	public DIMDFGBGKAM(bool BMKPPNDDDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CB90", Offset = "0x6D5BD90", VA = "0x186D5CB90", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, decimal HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CD40", Offset = "0x6D5BF40", VA = "0x186D5CD40", Slot = "5")]
	public decimal IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class MOCCJGBJBOD : EALLCKLMLAA<Uri>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly EALLCKLMLAA<Uri> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6D66740", Offset = "0x6D65940", VA = "0x186D66740", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, Uri HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6D66820", Offset = "0x6D65A20", VA = "0x186D66820", Slot = "5")]
	public Uri IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MOCCJGBJBOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class IMIGLCIOGOH : EALLCKLMLAA<Version>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly EALLCKLMLAA<Version> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6D64120", Offset = "0x6D63320", VA = "0x186D64120", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, Version HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6D641E0", Offset = "0x6D633E0", VA = "0x186D641E0", Slot = "5")]
	public Version IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IMIGLCIOGOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HHOKEHAFOEM<TKey, TValue> : EALLCKLMLAA<KeyValuePair<TKey, TValue>>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E750", Offset = "0x3A3D950", VA = "0x183A3E750", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, KeyValuePair<TKey, TValue> HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E930", Offset = "0x3A3DB30", VA = "0x183A3E930", Slot = "5")]
	public KeyValuePair<TKey, TValue> IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DPABFJNIEJC : EALLCKLMLAA<StringBuilder>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly EALLCKLMLAA<StringBuilder> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D2C0", Offset = "0x6D5C4C0", VA = "0x186D5D2C0", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, StringBuilder HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D360", Offset = "0x6D5C560", VA = "0x186D5D360", Slot = "5")]
	public StringBuilder IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DPABFJNIEJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class IBIMJOOMPJO : EALLCKLMLAA<BitArray>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EALLCKLMLAA<BitArray> DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6D63330", Offset = "0x6D62530", VA = "0x186D63330", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, BitArray HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6D63450", Offset = "0x6D62650", VA = "0x186D63450", Slot = "5")]
	public BitArray IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IBIMJOOMPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class PADLPPDMNAF : EALLCKLMLAA<Type>, DIGEJECCEIM
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly PADLPPDMNAF DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex ONBHEOHEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool LFGLOMDEEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool DKPCJKKOAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool FHAALBJOKIP;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6D68770", Offset = "0x6D67970", VA = "0x186D68770")]
	public PADLPPDMNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x62E7C40", Offset = "0x62E6E40", VA = "0x1862E7C40")]
	public PADLPPDMNAF(bool LFGLOMDEEED, bool DKPCJKKOAJC, bool FHAALBJOKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D68420", Offset = "0x6D67620", VA = "0x186D68420", Slot = "4")]
	public void GKNEHCEDNDE(NKHADIMENKO AELHGGJOBCK, Type HLCKBKFCMPI, DLKMGGPEHOD NGNDADAGAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D68530", Offset = "0x6D67730", VA = "0x186D68530", Slot = "5")]
	public Type IHPADLGFHBL(DOMGOGFMLMG LAAOMLILGHH, DLKMGGPEHOD NGNDADAGAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class GEOKPLINPAM
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] CEFONIOHEON;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly BKAAABBIKJO BMJPAHGPOML;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D60220", Offset = "0x6D5F420", VA = "0x186D60220")]
	static GEOKPLINPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class CIMBKFEPPDH
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] CLBAHDOBFBE;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly BKAAABBIKJO LABDMCKNEDA;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B580", Offset = "0x6D5A780", VA = "0x186D5B580")]
	static CIMBKFEPPDH()
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
