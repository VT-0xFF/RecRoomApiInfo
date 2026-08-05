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
internal static class AGGEOBHDBPH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6548860", Offset = "0x6547860", VA = "0x186548860")]
	public static bool INGGHDKJEKC(this TypeInfo CFGJPNBLNDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class KOMIJBNAEJL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type NDPBHIGNFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] KGNDPEDGAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
	public KOMIJBNAEJL(Type KJBENNHCGPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class FMOCENGJPBH : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HIDJCIIGAHK<T>(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T LBPGPJMGOHK<T>(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF CAEANFNPHME);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MFLDAMIDLGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DFIHLHFFLJJ<T> : MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FKAHDAKOENB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OJFNKMFJJKC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class COONAIHAAKJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2330A50", Offset = "0x232FA50", VA = "0x182330A50")]
	public static string LDIJGDOMDNM<T>(this DFIHLHFFLJJ<T> AKIBHMLIFCF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFIHLHFFLJJ<T> KGJIIHNMKFL<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NAJGJFAACEH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25F58E0", Offset = "0x25F48E0", VA = "0x1825F58E0")]
	public static DFIHLHFFLJJ<T> ACPLGJDPEMI<T>(this NKGJGOEJJEF CAEANFNPHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6560790", Offset = "0x655F790", VA = "0x186560790")]
	public static object DKJFDJBJMLH(this NKGJGOEJJEF CAEANFNPHME, Type CFGJPNBLNDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ANGHECIEACB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x654A5E0", Offset = "0x65495E0", VA = "0x18654A5E0")]
	public ANGHECIEACB(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EDCKLMDDAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class COMLAAPOGGC
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DOAIHCCMJDP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] HOJAGOCHKMH;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6555A30", Offset = "0x6554A30", VA = "0x186555A30")]
		public static byte[] MIADJIPFNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6555AD0", Offset = "0x6554AD0", VA = "0x186555AD0")]
		public static char[] MIGMPFKOOGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> CAGCMHBGEOD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] FNNDFBGHHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] BKCOILCKNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int ODJLNMBFCPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GNPHFGPOOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6558500", Offset = "0x6557500", VA = "0x186558500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x655A1F0", Offset = "0x65591F0", VA = "0x18655A1F0")]
	public EDCKLMDDAAM(byte[] BKCOILCKNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x655A250", Offset = "0x6559250", VA = "0x18655A250")]
	public EDCKLMDDAAM(byte[] BKCOILCKNDC, int ODJLNMBFCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6558F30", Offset = "0x6557F30", VA = "0x186558F30")]
	private FCEPFIIDEKD MIPHBALJDIA(string NDHJFMDGDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65574F0", Offset = "0x65564F0", VA = "0x1865574F0")]
	private FCEPFIIDEKD DHFNABDAMOH(string NCBOINMNCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65585E0", Offset = "0x65575E0", VA = "0x1865585E0")]
	public void KCIFHOGFBOP(int ODJLNMBFCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
	public byte[] KHBEPGCPLGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC140", Offset = "0x1CCB140", VA = "0x181CCC140")]
	public int ENHKONBIGBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65570C0", Offset = "0x65560C0", VA = "0x1865570C0")]
	public FMNAPPCPNGK BEMLIPLIFKM()
	{
		return default(FMNAPPCPNGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6557C10", Offset = "0x6556C10", VA = "0x186557C10")]
	public void FCHJMPCNDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6556F10", Offset = "0x6555F10", VA = "0x186556F10")]
	public bool AAPIBGOMCPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6557730", Offset = "0x6556730", VA = "0x186557730")]
	public bool EIGHIAEKJLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6559680", Offset = "0x6558680", VA = "0x186559680")]
	public void NGHHPDGHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65595F0", Offset = "0x65585F0", VA = "0x1865595F0")]
	public bool MPNPOKEKGDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65575E0", Offset = "0x65565E0", VA = "0x1865575E0")]
	public bool EEOPIJONDLI(int AGLAJIDEGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65582F0", Offset = "0x65572F0", VA = "0x1865582F0")]
	public bool INPFNKJGNMN(int AGLAJIDEGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6558BD0", Offset = "0x6557BD0", VA = "0x186558BD0")]
	public bool LHEGKDEHHKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x65583C0", Offset = "0x65573C0", VA = "0x1865583C0")]
	public void JBGHLMHFMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6559560", Offset = "0x6558560", VA = "0x186559560")]
	public bool MPIAAEKFKAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6557E80", Offset = "0x6556E80", VA = "0x186557E80")]
	public bool HEPELACAOAG(int AGLAJIDEGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6557B40", Offset = "0x6556B40", VA = "0x186557B40")]
	public bool FCAFMNKHDCN(int AGLAJIDEGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6557030", Offset = "0x6556030", VA = "0x186557030")]
	public bool APFGABJHKAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6558460", Offset = "0x6557460", VA = "0x186558460")]
	public void JEKIPGNCPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65598A0", Offset = "0x65588A0", VA = "0x1865598A0")]
	public bool ODCBLDKDMBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65585F0", Offset = "0x65575F0", VA = "0x1865585F0")]
	public void KNGOKJBHFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6559930", Offset = "0x6558930", VA = "0x186559930")]
	private void OFFJHBELFGF([Out] byte[] FFMFIPCLHJI, [Out] int OELKDDDGLOE, [Out] int POBHMGCHHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6557440", Offset = "0x6556440", VA = "0x186557440")]
	private static int DBHHIPBBIEN(char HMDDIJJDAIK, char NDOJJCKFJID, char APEENPEFHEI, char JAFPDGGIPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65577C0", Offset = "0x65567C0", VA = "0x1865577C0")]
	private static int EOADKMBOJMB(char LNKHMLIBJEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6558110", Offset = "0x6557110", VA = "0x186558110")]
	public ArraySegment<byte> IGDHBPNBFHH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6559480", Offset = "0x6558480", VA = "0x186559480")]
	public string MOLBCPFNKHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65573D0", Offset = "0x65563D0", VA = "0x1865573D0")]
	public string COBFMLPKDPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6557920", Offset = "0x6556920", VA = "0x186557920")]
	public ArraySegment<byte> EPABLFMIGEK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6557DC0", Offset = "0x6556DC0", VA = "0x186557DC0")]
	public ArraySegment<byte> FHBGENPMGHI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6558810", Offset = "0x6557810", VA = "0x186558810")]
	public bool LGPHLNMJEKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6557F50", Offset = "0x6556F50", VA = "0x186557F50")]
	private static bool HLCPJBKAEGM(byte APEENPEFHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6558C60", Offset = "0x6557C60", VA = "0x186558C60")]
	private void LKHMANPNHJO(FMNAPPCPNGK PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6557E30", Offset = "0x6556E30", VA = "0x186557E30")]
	public void GHOBAINMJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6557270", Offset = "0x6556270", VA = "0x186557270")]
	private void CEKODIMDAFP(int OHJAHGFFJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65578A0", Offset = "0x65568A0", VA = "0x1865578A0")]
	public sbyte EOEPAADFDEK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6557D40", Offset = "0x6556D40", VA = "0x186557D40")]
	public short FDFHLHMPENF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6558690", Offset = "0x6557690", VA = "0x186558690")]
	public int LANHMPAGHLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6558520", Offset = "0x6557520", VA = "0x186558520")]
	public long JOEOGCLIOLP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6558EB0", Offset = "0x6557EB0", VA = "0x186558EB0")]
	public byte MBBJHJAPIBG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6559820", Offset = "0x6558820", VA = "0x186559820")]
	public ushort OCDGMOAELLD()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65576B0", Offset = "0x65566B0", VA = "0x1865576B0")]
	public uint EGJKJFLBGPD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6558230", Offset = "0x6557230", VA = "0x186558230")]
	public ulong INMIDGCBPFK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6559720", Offset = "0x6558720", VA = "0x186559720")]
	public float NHEMNCHKIJJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6558710", Offset = "0x6557710", VA = "0x186558710")]
	public double LEODNHMJADE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6558010", Offset = "0x6557010", VA = "0x186558010")]
	public ArraySegment<byte> HPAEIOIEAAC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6558A60", Offset = "0x6557A60", VA = "0x186558A60")]
	private static int LHAICHJAFLF(byte[] BKCOILCKNDC, int ODJLNMBFCPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FCEPFIIDEKD : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference JOCEIJACPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int KFNDJPCFEMM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LHJLBNLNFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB63DE0", Offset = "0xB62DE0", VA = "0x180B63DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IKIJCFJGKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x806B70", Offset = "0x805B70", VA = "0x180806B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x655A810", Offset = "0x6559810", VA = "0x18655A810")]
	public FCEPFIIDEKD(string NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x655A870", Offset = "0x6559870", VA = "0x18655A870")]
	public FCEPFIIDEKD(string NCBOINMNCHO, byte[] NMNEALNKEAO, int ODJLNMBFCPC, int KFNDJPCFEMM, string GNKMHFJLPBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CLBEPHAPNFP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class FJJNEMIGHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] DOAIHCCMJDP;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x655A960", Offset = "0x6559960", VA = "0x18655A960")]
		public static byte[] MIADJIPFNMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BACAIFPPAAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void AKNGPGIAIBP(FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object ADBBJKJCFCM(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF CAEANFNPHME);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class AMJPEEMGCIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class LLKBHGLLCMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
				public LLKBHGLLCMP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3607AC0", Offset = "0x3606AC0", VA = "0x183607AC0")]
				internal bool HJDDCIOGKLF(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x65600C0", Offset = "0x655F0C0", VA = "0x1865600C0")]
				internal bool CENIOKMMJPH(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, NKGJGOEJJEF, byte[]> IONAHEGCKPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, NKGJGOEJJEF> LGGKLAFOHBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly AKNGPGIAIBP HJLHEPEGEKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, NKGJGOEJJEF, ArraySegment<byte>> CKMOFPLFPAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, NKGJGOEJJEF, string> EGDGMKPNMGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, NKGJGOEJJEF, object> CCGGAIBNJGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, NKGJGOEJJEF, object> OALOIIAOGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, NKGJGOEJJEF, object> GGJJDJNIIKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly ADBBJKJCFCM DELCNDAIADP;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6548AE0", Offset = "0x6547AE0", VA = "0x186548AE0")]
			public AMJPEEMGCIP(Type CFGJPNBLNDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AC9F70", Offset = "0x2AC8F70", VA = "0x182AC9F70")]
			private static T PEJNKIHPKMB<T>(DynamicMethod FJJCGGKMIHH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6548890", Offset = "0x6547890", VA = "0x186548890")]
			private static MethodInfo CDOHLONPOPK(Type CFGJPNBLNDJ, string JNMEJDHMADI, Type[] EGMMODCNAPA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, AMJPEEMGCIP> LFOMJFJOJHL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly FEBBGICKJJF<AMJPEEMGCIP> PFNCEDLMKGA;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x654A950", Offset = "0x6549950", VA = "0x18654A950")]
		static BACAIFPPAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x654A640", Offset = "0x6549640", VA = "0x18654A640")]
		private static AMJPEEMGCIP FMJJIOKNAFJ(Type CFGJPNBLNDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x654A6C0", Offset = "0x65496C0", VA = "0x18654A6C0")]
		public static void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x654A840", Offset = "0x6549840", VA = "0x18654A840")]
		public static void KJONJHMMAMK(Type CFGJPNBLNDJ, FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NKGJGOEJJEF EOLCCINPNDA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] APBDKPBNOBD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] DCELACKFIJD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NKGJGOEJJEF MOEACBIJEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6554520", Offset = "0x6553520", VA = "0x186554520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6554F70", Offset = "0x6553F70", VA = "0x186554F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x65544B0", Offset = "0x65534B0", VA = "0x1865544B0")]
	public static void BEPCOFKINBG(NKGJGOEJJEF CAEANFNPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x232DCB0", Offset = "0x232CCB0", VA = "0x18232DCB0")]
	public static byte[] KJONJHMMAMK<T>(T GPCHHCACPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x232DD30", Offset = "0x232CD30", VA = "0x18232DD30")]
	public static byte[] KJONJHMMAMK<T>(T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x232DEB0", Offset = "0x232CEB0", VA = "0x18232DEB0")]
	public static void KJONJHMMAMK<T>(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x232DA90", Offset = "0x232CA90", VA = "0x18232DA90")]
	public static void KJONJHMMAMK<T>(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x232DF40", Offset = "0x232CF40", VA = "0x18232DF40")]
	public static void KJONJHMMAMK<T>(Stream EODNJPIMPGN, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x232DB70", Offset = "0x232CB70", VA = "0x18232DB70")]
	public static void KJONJHMMAMK<T>(Stream EODNJPIMPGN, T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x232D870", Offset = "0x232C870", VA = "0x18232D870")]
	public static ArraySegment<byte> JEHANKMJGHF<T>(T GPCHHCACPPJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x232D900", Offset = "0x232C900", VA = "0x18232D900")]
	public static ArraySegment<byte> JEHANKMJGHF<T>(T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x232DFD0", Offset = "0x232CFD0", VA = "0x18232DFD0")]
	public static string LDIJGDOMDNM<T>(T APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x232E050", Offset = "0x232D050", VA = "0x18232E050")]
	public static string LDIJGDOMDNM<T>(T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x232CEF0", Offset = "0x232BEF0", VA = "0x18232CEF0")]
	public static T AJBPOCIDFHA<T>(string LGADAKPOIFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x232CD70", Offset = "0x232BD70", VA = "0x18232CD70")]
	public static T AJBPOCIDFHA<T>(string LGADAKPOIFF, NKGJGOEJJEF CAEANFNPHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x232D110", Offset = "0x232C110", VA = "0x18232D110")]
	public static T AJBPOCIDFHA<T>(byte[] BKCOILCKNDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x232CE60", Offset = "0x232BE60", VA = "0x18232CE60")]
	public static T AJBPOCIDFHA<T>(byte[] BKCOILCKNDC, NKGJGOEJJEF CAEANFNPHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x232D210", Offset = "0x232C210", VA = "0x18232D210")]
	public static T AJBPOCIDFHA<T>(byte[] BKCOILCKNDC, int ODJLNMBFCPC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x232CF80", Offset = "0x232BF80", VA = "0x18232CF80")]
	public static T AJBPOCIDFHA<T>(byte[] BKCOILCKNDC, int ODJLNMBFCPC, NKGJGOEJJEF CAEANFNPHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x232D530", Offset = "0x232C530", VA = "0x18232D530")]
	public static T AJBPOCIDFHA<T>(EDCKLMDDAAM JPPGFPLOJCL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x232D7A0", Offset = "0x232C7A0", VA = "0x18232D7A0")]
	public static T AJBPOCIDFHA<T>(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF CAEANFNPHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x232D190", Offset = "0x232C190", VA = "0x18232D190")]
	public static T AJBPOCIDFHA<T>(Stream EODNJPIMPGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x232D2A0", Offset = "0x232C2A0", VA = "0x18232D2A0")]
	public static T AJBPOCIDFHA<T>(Stream EODNJPIMPGN, NKGJGOEJJEF CAEANFNPHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x65546C0", Offset = "0x65536C0", VA = "0x1865546C0")]
	public static string DLPKJJDCFAO(byte[] LGADAKPOIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65549B0", Offset = "0x65539B0", VA = "0x1865549B0")]
	public static string DLPKJJDCFAO(byte[] LGADAKPOIFF, int ODJLNMBFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6554820", Offset = "0x6553820", VA = "0x186554820")]
	public static string DLPKJJDCFAO(string LGADAKPOIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6554DF0", Offset = "0x6553DF0", VA = "0x186554DF0")]
	public static byte[] FIPFBFKMHFJ(byte[] LGADAKPOIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6554CA0", Offset = "0x6553CA0", VA = "0x186554CA0")]
	public static byte[] FIPFBFKMHFJ(byte[] LGADAKPOIFF, int ODJLNMBFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6554AF0", Offset = "0x6553AF0", VA = "0x186554AF0")]
	public static byte[] FIPFBFKMHFJ(string LGADAKPOIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6554FD0", Offset = "0x6553FD0", VA = "0x186554FD0")]
	private static void OJBCCJNMIIC(EDCKLMDDAAM JPPGFPLOJCL, FMIKPDPOMJO BBENPAOCMIF, int JAGDEKNJOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6554620", Offset = "0x6553620", VA = "0x186554620")]
	private static int DBHIMFCLONF(Stream JPKFBEJOHFJ, byte[] DOAIHCCMJDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FMNAPPCPNGK : byte
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
public struct FMIKPDPOMJO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FIPOMPBPKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DOAIHCCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ODJLNMBFCPC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KDCGKEENKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CCC140", Offset = "0x1CCB140", VA = "0x181CCC140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x65585E0", Offset = "0x65575E0", VA = "0x1865585E0")]
	public void KCIFHOGFBOP(int ODJLNMBFCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x655AFE0", Offset = "0x6559FE0", VA = "0x18655AFE0")]
	public static byte[] ECOMOLJLPLO(string PNEABPKDNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x655AD00", Offset = "0x6559D00", VA = "0x18655AD00")]
	public static byte[] DOEPNANIMDA(string PNEABPKDNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x655AE70", Offset = "0x6559E70", VA = "0x18655AE70")]
	public static byte[] DPPALDOHKPE(string PNEABPKDNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x655AB20", Offset = "0x6559B20", VA = "0x18655AB20")]
	public static byte[] BDGIHACFLFK(string PNEABPKDNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5376170", Offset = "0x5375170", VA = "0x185376170")]
	public FMIKPDPOMJO(byte[] OPALHDKJEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x655BBE0", Offset = "0x655ABE0", VA = "0x18655BBE0")]
	public ArraySegment<byte> MIADJIPFNMM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x655B110", Offset = "0x655A110", VA = "0x18655B110")]
	public byte[] EODGEMNCNCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x655BE10", Offset = "0x655AE10", VA = "0x18655BE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x655ACA0", Offset = "0x6559CA0", VA = "0x18655ACA0")]
	public void CHBAAAELDJD(int OKGGEKDJGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x655B250", Offset = "0x655A250", VA = "0x18655B250")]
	public void FPDOJJONILJ(byte BHELDFJFLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x655B1F0", Offset = "0x655A1F0", VA = "0x18655B1F0")]
	public void FPDOJJONILJ(byte[] BHELDFJFLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x655AA00", Offset = "0x6559A00", VA = "0x18655AA00")]
	public void ABBHAKBBAKB(byte BHELDFJFLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x655BA70", Offset = "0x655AA70", VA = "0x18655BA70")]
	public void KMOHIFKBIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x655BD70", Offset = "0x655AD70", VA = "0x18655BD70")]
	public void OFABCOKGNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x655BC80", Offset = "0x655AC80", VA = "0x18655BC80")]
	public void MOABKDJCLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x655BDC0", Offset = "0x655ADC0", VA = "0x18655BDC0")]
	public void OMNFNMBIJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x655BA20", Offset = "0x655AA20", VA = "0x18655BA20")]
	public void KJBOMFPAEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x655BAC0", Offset = "0x655AAC0", VA = "0x18655BAC0")]
	public void KPJEPILBPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x655B320", Offset = "0x655A320", VA = "0x18655B320")]
	public void GLAADPNEEEH(string PNEABPKDNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x655ACB0", Offset = "0x6559CB0", VA = "0x18655ACB0")]
	public void CIHDOIDFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x655BB10", Offset = "0x655AB10", VA = "0x18655BB10")]
	public void LOGEGEFAGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x655B8C0", Offset = "0x655A8C0", VA = "0x18655B8C0")]
	public void JDIMCPFICJC(bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x655B7D0", Offset = "0x655A7D0", VA = "0x18655B7D0")]
	public void HPJIGOPEOPG(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x655B750", Offset = "0x655A750", VA = "0x18655B750")]
	public void HEPAGHFGGPI(double APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x655BCD0", Offset = "0x655ACD0", VA = "0x18655BCD0")]
	public void NANEBBKKJOG(byte APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x655AA40", Offset = "0x6559A40", VA = "0x18655AA40")]
	public void AGJEACEACLD(ushort APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x655B850", Offset = "0x655A850", VA = "0x18655B850")]
	public void IHJOJGNIMMO(uint APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x655BD40", Offset = "0x655AD40", VA = "0x18655BD40")]
	public void NOMKEMDODOJ(ulong APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x655B180", Offset = "0x655A180", VA = "0x18655B180")]
	public void FFJAGJBMDDK(sbyte APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x655B2B0", Offset = "0x655A2B0", VA = "0x18655B2B0")]
	public void GJHFAKJHLII(short APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x655AAB0", Offset = "0x6559AB0", VA = "0x18655AAB0")]
	public void AOCLIJPDBIN(int APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x655BBB0", Offset = "0x655ABB0", VA = "0x18655BBB0")]
	public void MGPLCNHKIHD(long APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x655B3C0", Offset = "0x655A3C0", VA = "0x18655B3C0")]
	public void HCKONAHMHCM(string APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MLCMOGLMECF : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class EHKDJIOMDBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3102270", Offset = "0x3101270", VA = "0x183102270")]
		static EHKDJIOMDBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private MLCMOGLMECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class ONAMOBHKPFB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> CBMAEOJEENC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6564750", Offset = "0x6563750", VA = "0x186564750")]
	static ONAMOBHKPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6563F60", Offset = "0x6562F60", VA = "0x186563F60")]
	internal static object KGJIIHNMKFL(Type CDBKGKHLPJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class ADFJKJNLNLN : DFIHLHFFLJJ<Vector2>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6548680", Offset = "0x6547680", VA = "0x186548680")]
	public ADFJKJNLNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6548490", Offset = "0x6547490", VA = "0x186548490", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Vector2 APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x65481A0", Offset = "0x65471A0", VA = "0x1865481A0", Slot = "5")]
	public Vector2 AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DJHCLJICPDN : DFIHLHFFLJJ<Vector3>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6556B20", Offset = "0x6555B20", VA = "0x186556B20")]
	public DJHCLJICPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6556880", Offset = "0x6555880", VA = "0x186556880", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Vector3 APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6556530", Offset = "0x6555530", VA = "0x186556530", Slot = "5")]
	public Vector3 AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CIMFPNMKNKH : DFIHLHFFLJJ<Vector4>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x65541C0", Offset = "0x65531C0", VA = "0x1865541C0")]
	public CIMFPNMKNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6553E80", Offset = "0x6552E80", VA = "0x186553E80", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Vector4 APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6553AF0", Offset = "0x6552AF0", VA = "0x186553AF0", Slot = "5")]
	public Vector4 AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NAPONMIFELP : DFIHLHFFLJJ<Quaternion>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6560FC0", Offset = "0x655FFC0", VA = "0x186560FC0")]
	public NAPONMIFELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6560C80", Offset = "0x655FC80", VA = "0x186560C80", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Quaternion APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65608F0", Offset = "0x655F8F0", VA = "0x1865608F0", Slot = "5")]
	public Quaternion AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DBCEONPLGNC : DFIHLHFFLJJ<Color>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6556240", Offset = "0x6555240", VA = "0x186556240")]
	public DBCEONPLGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6555F00", Offset = "0x6554F00", VA = "0x186555F00", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Color APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6555B70", Offset = "0x6554B70", VA = "0x186555B70", Slot = "5")]
	public Color AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CDDECEBIMAO : DFIHLHFFLJJ<Bounds>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6553910", Offset = "0x6552910", VA = "0x186553910")]
	public CDDECEBIMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x65535F0", Offset = "0x65525F0", VA = "0x1865535F0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Bounds APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6553210", Offset = "0x6552210", VA = "0x186553210", Slot = "5")]
	public Bounds AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NEENMLKECAP : DFIHLHFFLJJ<Rect>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BLCFLOFFADD ANJLGBDIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] MBICDHAKLBF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6561A10", Offset = "0x6560A10", VA = "0x186561A10")]
	public NEENMLKECAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x65616A0", Offset = "0x65606A0", VA = "0x1865616A0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Rect APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65612B0", Offset = "0x65602B0", VA = "0x1865612B0", Slot = "5")]
	public Rect AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DOLKJAPNECB : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class KDHJMOAIHFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3958740", Offset = "0x3957740", VA = "0x183958740")]
		static KDHJMOAIHFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private DOLKJAPNECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class PHJIIDPBMGC : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class GGIPGKMNPGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3515450", Offset = "0x3514450", VA = "0x183515450")]
		static GGIPGKMNPGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class JJGOMDKPDJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JHGDIGBBAMB;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x655E190", Offset = "0x655D190", VA = "0x18655E190")]
		internal static object KGJIIHNMKFL(Type CDBKGKHLPJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private PHJIIDPBMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class OMKJPFCNFIH : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class AJIHEKLGPHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x356ED60", Offset = "0x356DD60", VA = "0x18356ED60")]
		static AJIHEKLGPHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OMKJPFCNFIH NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool LJAFMLDHBIC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MFLDAMIDLGH[] CPCCKJKIKMA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static NKGJGOEJJEF[] IBJLELAINAK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private OMKJPFCNFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6563C80", Offset = "0x6562C80", VA = "0x186563C80")]
	public static void NOIKFHNFAKL(params NKGJGOEJJEF[] IBJLELAINAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6563D60", Offset = "0x6562D60", VA = "0x186563D60")]
	public static void NOIKFHNFAKL(params MFLDAMIDLGH[] CPCCKJKIKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65639F0", Offset = "0x65629F0", VA = "0x1865639F0")]
	public static void ALHIOIAIIEC(MFLDAMIDLGH[] CPCCKJKIKMA, NKGJGOEJJEF[] IBJLELAINAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class ELBCDIODENI : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class JJMEFBLPLMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x38EB8A0", Offset = "0x38EA8A0", VA = "0x1838EB8A0")]
		static JJMEFBLPLMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private ELBCDIODENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LOGADPGGBCA
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NKGJGOEJJEF ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly NKGJGOEJJEF NKFGDFNEDMK;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NKGJGOEJJEF HJJAFOOFFPA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly NKGJGOEJJEF ECNBNDLDCJL;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly NKGJGOEJJEF HGKPDFKOEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly NKGJGOEJJEF HJCLLFIKEHI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly NKGJGOEJJEF LDNAIOGDEAH;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly NKGJGOEJJEF BCCEBKGIJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NKGJGOEJJEF JCLHPPNALEI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly NKGJGOEJJEF NMHOJOEIJEH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly NKGJGOEJJEF IJEEPJFGMFJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly NKGJGOEJJEF FACFBJEEFOC;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JCCFFKDKJOK
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly NKGJGOEJJEF ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NKGJGOEJJEF MNANENKABNI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BFKDFKALAAD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly NKGJGOEJJEF ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly NKGJGOEJJEF NKFGDFNEDMK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NKGJGOEJJEF HJJAFOOFFPA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NKGJGOEJJEF ECNBNDLDCJL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly NKGJGOEJJEF HGKPDFKOEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly NKGJGOEJJEF HJCLLFIKEHI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly NKGJGOEJJEF LDNAIOGDEAH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly NKGJGOEJJEF BCCEBKGIJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NKGJGOEJJEF JCLHPPNALEI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NKGJGOEJJEF NMHOJOEIJEH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly NKGJGOEJJEF IJEEPJFGMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NKGJGOEJJEF FACFBJEEFOC;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class OBPCKBOABOJ
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JHGDIGBBAMB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6561D40", Offset = "0x6560D40", VA = "0x186561D40")]
	internal static object KGJIIHNMKFL(Type CDBKGKHLPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6561D00", Offset = "0x6560D00", VA = "0x186561D00")]
	private static object AFIIPEEBINM(Type MPJEOALCILA, Type[] DEOEHHLNOHI, params object[] EGMMODCNAPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GELIMHBICKH : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class FEEFBCCKLIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3453920", Offset = "0x3452920", VA = "0x183453920")]
		static FEEFBCCKLIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x655BFE0", Offset = "0x655AFE0", VA = "0x18655BFE0")]
	static GELIMHBICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private GELIMHBICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class EPIDHFIGALO : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class HKCBCMMIMGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x36257A0", Offset = "0x36247A0", VA = "0x1836257A0")]
		static HKCBCMMIMGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x655A530", Offset = "0x6559530", VA = "0x18655A530")]
	static EPIDHFIGALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private EPIDHFIGALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class ADFEKABHKHA : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class LJAGLJAJEKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A85DF0", Offset = "0x3A84DF0", VA = "0x183A85DF0")]
		static LJAGLJAJEKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6548030", Offset = "0x6547030", VA = "0x186548030")]
	static ADFEKABHKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private ADFEKABHKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class FBJBCGCAMJF : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class ONELMJDBDLB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A360", Offset = "0x3E09360", VA = "0x183E0A360")]
		static ONELMJDBDLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x655A6A0", Offset = "0x65596A0", VA = "0x18655A6A0")]
	static FBJBCGCAMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private FBJBCGCAMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OPINKNMNAFI : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class BEKHPCGEAJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4532050", Offset = "0x4531050", VA = "0x184532050")]
		static BEKHPCGEAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6564C40", Offset = "0x6563C40", VA = "0x186564C40")]
	static OPINKNMNAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private OPINKNMNAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class IFGFDKPLJOA : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class PPKANMMALHN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F16E80", Offset = "0x3F15E80", VA = "0x183F16E80")]
		static PPKANMMALHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly KMJNMPONGBM HBMPHCCKEBE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x655DE40", Offset = "0x655CE40", VA = "0x18655DE40")]
	static IFGFDKPLJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private IFGFDKPLJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class DKHFOJIGPEB : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class GNNIAPHAPPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x359C2D0", Offset = "0x359B2D0", VA = "0x18359C2D0")]
		static GNNIAPHAPPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DKHFOJIGPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class ELGINIGAEHK : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class CANKMLFBDPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47E6CE0", Offset = "0x47E5CE0", VA = "0x1847E6CE0")]
		static CANKMLFBDPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ELGINIGAEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class IMHNHKEEJGP : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class MFDILLKOEMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C2D0", Offset = "0x3C7B2D0", VA = "0x183C7C2D0")]
		static MFDILLKOEMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public IMHNHKEEJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class GOCGPKLCDII : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class KPGDBNFECLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x39DF0A0", Offset = "0x39DE0A0", VA = "0x1839DF0A0")]
		static KPGDBNFECLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GOCGPKLCDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class FOMFCODDOMM : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class CNOCCKMDLKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x48E7DA0", Offset = "0x48E6DA0", VA = "0x1848E7DA0")]
		static CNOCCKMDLKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FOMFCODDOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KCNECFLIAPO : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class LDJBJFHNJHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3A728F0", Offset = "0x3A718F0", VA = "0x183A728F0")]
		static LDJBJFHNJHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> IPNLGKOOMBO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool JDEJEENNIAL;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KCNECFLIAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class BKFPDKIFKOL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FLAKANIDAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BNIFPJJLCON NNBFBAJAJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder EHBFMFNMLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PINEKDFADGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class IEDPIIACNAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class MGAEPKDKGAB
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo DPPALDOHKPE;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo DOEPNANIMDA;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo BDGIHACFLFK;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ECOMOLJLPLO;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo LOGEGEFAGCE;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo FPDOJJONILJ;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo MOABKDJCLOO;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo OMNFNMBIJCN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo KJBOMFPAEGO;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6575420", Offset = "0x6574420", VA = "0x186575420")]
			static MGAEPKDKGAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class OPBAPOKABHE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo AAPIBGOMCPM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo JBGHLMHFMLD;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HEPELACAOAG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo NBKLEJKPLMO;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo GHOBAINMJPB;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo KHBEPGCPLGH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo ENHKONBIGBB;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x657B5E0", Offset = "0x657A5E0", VA = "0x18657B5E0")]
			static OPBAPOKABHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class FFNHHMOJKMM
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo NDPBHIGNFED;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo KGNDPEDGAKF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo LOPHLGIAGFG;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ACPLGJDPEMI;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo DPAHJNMKFPA;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo JFMOMNIPHNE;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo PMAMAMFPODK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo PGLHBEHIJFG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo DEBOJMELDCG;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo DMDBAHPKJBL;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo KADIKFHGNPJ;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo IFEBHFBACFI;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo HLPJDIDFMJN;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo JIKOEMLOMBM;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x655C5C0", Offset = "0x655B5C0", VA = "0x18655C5C0")]
		public static MethodInfo KJONJHMMAMK(Type CFGJPNBLNDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x655C250", Offset = "0x655B250", VA = "0x18655C250")]
		public static MethodInfo AJBPOCIDFHA(Type CFGJPNBLNDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x655C490", Offset = "0x655B490", VA = "0x18655C490")]
		public static MethodInfo FNAPHMJPPCH(Type CFGJPNBLNDJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ONIBJKCPGLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BNIFPJJLCON, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public ONIBJKCPGLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class KNAMNOFGDEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public ONIBJKCPGLP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KNAMNOFGDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6574950", Offset = "0x6573950", VA = "0x186574950")]
		internal void NIAALPCOCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x65747F0", Offset = "0x65737F0", VA = "0x1865747F0")]
		internal bool JJCMNBNEDBJ(int index, BNIFPJJLCON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GONGMCDNHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public ONIBJKCPGLP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GONGMCDNHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6572C70", Offset = "0x6571C70", VA = "0x186572C70")]
		internal bool AIIOCNKPEAM(int index, BNIFPJJLCON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KPIJJJAHDCP
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
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KPIJJJAHDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x311EBB0", Offset = "0x311DBB0", VA = "0x18311EBB0")]
		internal string OPLFFHEIPCI(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FGANNLCIFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FGANNLCIFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x656EE60", Offset = "0x656DE60", VA = "0x18656EE60")]
		internal bool AHOIEIDJMAE(BNIFPJJLCON x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class EPPHFIPEHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KPIJJJAHDCP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EPPHFIPEHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x656CA70", Offset = "0x656BA70", VA = "0x18656CA70")]
		internal void IEGBKBKIMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x656C890", Offset = "0x656B890", VA = "0x18656C890")]
		internal bool BHKOKAMOMEI(int index, BNIFPJJLCON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CGLGPLAGPGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public KPIJJJAHDCP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CGLGPLAGPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6569630", Offset = "0x6568630", VA = "0x186569630")]
		internal bool EGIHHECHNFM(int index, BNIFPJJLCON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IGNGLBCHAAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IGNGLBCHAAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x65740B0", Offset = "0x65730B0", VA = "0x1865740B0")]
		internal Label LHHGCDCCLJA(BNIFPJJLCON _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class HGBFHCDNCCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public FLAKANIDAAN[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BNIFPJJLCON, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public ICCOKFAJNEA argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public ICCOKFAJNEA argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HGBFHCDNCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6573A90", Offset = "0x6572A90", VA = "0x186573A90")]
		internal FLAKANIDAAN MMPKCICCBPG(BNIFPJJLCON item)
		{
			return default(FLAKANIDAAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KPODFKJLCNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HGBFHCDNCCG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KPODFKJLCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6574B60", Offset = "0x6573B60", VA = "0x186574B60")]
		internal void MCPMIKIEDJH(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6574AC0", Offset = "0x6573AC0", VA = "0x186574AC0")]
		internal void CJNAIPMNIBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NPNENBNINNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BNIFPJJLCON item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public NPNENBNINNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAC7FE0", Offset = "0xAC6FE0", VA = "0x180AC7FE0")]
		internal bool IGGPLOBLLIE(FLAKANIDAAN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JDOGLODMACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BNIFPJJLCON item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JDOGLODMACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAC7FE0", Offset = "0xAC6FE0", VA = "0x180AC7FE0")]
		internal bool LLONEAPOPEE(FLAKANIDAAN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex BJPIELCKLFL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int OALMKDDMDFN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> CDPCFAIPFOM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> OLKKLAHMLBA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x22BCB50", Offset = "0x22BBB50", VA = "0x1822BCB50")]
	public static object POOJMKPMFCN<T>(KMJNMPONGBM HBMPHCCKEBE, NKGJGOEJJEF NKLGFJLHGLM, Func<string, string> IPNLGKOOMBO, bool JDEJEENNIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x22B1E50", Offset = "0x22B0E50", VA = "0x1822B1E50")]
	public static object KDNMFBLIFJJ<T>(NKGJGOEJJEF NKLGFJLHGLM, Func<string, string> IPNLGKOOMBO, bool JDEJEENNIAL, bool FDGACEJDMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x654B3A0", Offset = "0x654A3A0", VA = "0x18654B3A0")]
	private static TypeInfo DADPIEFEGKH(KMJNMPONGBM HBMPHCCKEBE, Type CFGJPNBLNDJ, Func<string, string> IPNLGKOOMBO, bool JDEJEENNIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6551070", Offset = "0x6550070", VA = "0x186551070")]
	public static object LEPIIDFNBBI(Type CFGJPNBLNDJ, Func<string, string> IPNLGKOOMBO, bool JDEJEENNIAL, bool FDGACEJDMOE, bool NOPPGIPCCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x654C4A0", Offset = "0x654B4A0", VA = "0x18654C4A0")]
	private static Dictionary<BNIFPJJLCON, FieldInfo> EHKEIDPIILF(TypeBuilder OAJKIDDEHEI, FBKMBAPLACJ NMPKCMJCPLB, ConstructorInfo NPDIMKCGEJL, FieldBuilder EJOLNJMIPKI, ILGenerator PBEBLGCKIFO, bool JDEJEENNIAL, bool GNHBEBHHAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6550990", Offset = "0x654F990", VA = "0x186550990")]
	private static Dictionary<BNIFPJJLCON, FieldInfo> KBBAJEEFLMD(TypeBuilder OAJKIDDEHEI, FBKMBAPLACJ NMPKCMJCPLB, ILGenerator PBEBLGCKIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x654CBD0", Offset = "0x654BBD0", VA = "0x18654CBD0")]
	private static void ELGGCOENIPK(Type CFGJPNBLNDJ, FBKMBAPLACJ NMPKCMJCPLB, ILGenerator PBEBLGCKIFO, Action KJAELEEPDKA, Func<int, BNIFPJJLCON, bool> LOENGDGABDJ, bool JDEJEENNIAL, bool GNHBEBHHAFP, int HGFJNOMDMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6550450", Offset = "0x654F450", VA = "0x186550450")]
	private static void JLHKPEBOHPG(TypeInfo CFGJPNBLNDJ, BNIFPJJLCON CKEECHIMBMD, ILGenerator PBEBLGCKIFO, int NFJIPMHILEL, Func<int, BNIFPJJLCON, bool> LOENGDGABDJ, ICCOKFAJNEA BBENPAOCMIF, ICCOKFAJNEA BBFDDLKKJML, ICCOKFAJNEA PMNBGIDJHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x654F120", Offset = "0x654E120", VA = "0x18654F120")]
	private static void IOGDEHHEHKN(Type CFGJPNBLNDJ, FBKMBAPLACJ NMPKCMJCPLB, ILGenerator PBEBLGCKIFO, Func<int, BNIFPJJLCON, bool> LOENGDGABDJ, bool OBLHMDDHNNL, int HGFJNOMDMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x654AF30", Offset = "0x6549F30", VA = "0x18654AF30")]
	private static void AHAFFBLPJKP(ILGenerator PBEBLGCKIFO, FLAKANIDAAN NMPKCMJCPLB, int NFJIPMHILEL, Func<int, BNIFPJJLCON, bool> LOENGDGABDJ, ICCOKFAJNEA JPPGFPLOJCL, ICCOKFAJNEA PMNBGIDJHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x654E210", Offset = "0x654D210", VA = "0x18654E210")]
	private static LocalBuilder FFAJHCIBEMJ(ILGenerator PBEBLGCKIFO, Type CFGJPNBLNDJ, FBKMBAPLACJ NMPKCMJCPLB, FLAKANIDAAN[] PHNNLDOAGEB, bool EECIHFHIFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x654BDC0", Offset = "0x654ADC0", VA = "0x18654BDC0")]
	private static bool DJOEDEENLJP(ConstructorInfo HKILOPMLBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x654EFA0", Offset = "0x654DFA0", VA = "0x18654EFA0")]
	private static bool HKNLNGIFKIM(Type CFGJPNBLNDJ, [Out] Type JGCODBBKJHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void KOJBELDLFMM<T>(byte[][] EJOLNJMIPKI, object[] FMKKCECIMFL, FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF CAEANFNPHME);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T DGICAMEIMGH<T>(object[] FMKKCECIMFL, EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF CAEANFNPHME);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class ALAMPAHLBCD<T> : DFIHLHFFLJJ<T>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] EJOLNJMIPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] IKGLDCOMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] KIKBGJPKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly KOJBELDLFMM<T> BOOLOBGCEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly DGICAMEIMGH<T> PABKMJIGAGD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C9F670", Offset = "0x1C9E670", VA = "0x181C9F670")]
	public ALAMPAHLBCD(byte[][] EJOLNJMIPKI, object[] IKGLDCOMAIO, object[] KIKBGJPKDLE, KOJBELDLFMM<T> BOOLOBGCEGF, DGICAMEIMGH<T> PABKMJIGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3574E30", Offset = "0x3573E30", VA = "0x183574E30", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3574D40", Offset = "0x3573D40", VA = "0x183574D40", Slot = "5")]
	public T AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KLEPHKLLHNP : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class LDHFHJKCODP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3A66D10", Offset = "0x3A65D10", VA = "0x183A66D10")]
		static LDHFHJKCODP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private KLEPHKLLHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class HKCMLONIKCL : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class GCEMOHCDGKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3504E90", Offset = "0x3503E90", VA = "0x183504E90")]
		static GCEMOHCDGKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private HKCMLONIKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class KAEJMHAEDPI
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly NKGJGOEJJEF[] GCBONMOIGBN;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class MJPDLCNCPCC : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class DIGLKHIPFIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4DABEA0", Offset = "0x4DAAEA0", VA = "0x184DABEA0")]
		static DIGLKHIPFIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class NINFDMEPGOJ : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class JPBFJEABDCC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x390AD50", Offset = "0x3909D50", VA = "0x18390AD50")]
			static JPBFJEABDCC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private NINFDMEPGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private MJPDLCNCPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class CJFEDCKMEEA : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class KELHBNBCNDD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x39619E0", Offset = "0x39609E0", VA = "0x1839619E0")]
		static KELHBNBCNDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class NHEPKFAGOHN : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class LPGNLMPFEEJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3A9C7A0", Offset = "0x3A9B7A0", VA = "0x183A9C7A0")]
			static LPGNLMPFEEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private NHEPKFAGOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private CJFEDCKMEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class HDPFNIMDLJE : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class DBPPJDPPFOE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4D8CB10", Offset = "0x4D8BB10", VA = "0x184D8CB10")]
		static DBPPJDPPFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class LMECHMCOLBF : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class AGEHNAIIEDC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x35564D0", Offset = "0x35554D0", VA = "0x1835564D0")]
			static AGEHNAIIEDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private LMECHMCOLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private HDPFNIMDLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class CBKIGGMPODH : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class LAGNNFENCCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3A595C0", Offset = "0x3A585C0", VA = "0x183A595C0")]
		static LAGNNFENCCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class ICCLPIFJFHO : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class MCONPOFNFCF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3C5ED00", Offset = "0x3C5DD00", VA = "0x183C5ED00")]
			static MCONPOFNFCF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private ICCLPIFJFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private CBKIGGMPODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class BDLPFJGDHPH : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class IIAGIALCAJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3740180", Offset = "0x373F180", VA = "0x183740180")]
		static IIAGIALCAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class OOCNFGONDAB : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class HLNLJDKOPAG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3652EC0", Offset = "0x3651EC0", VA = "0x183652EC0")]
			static HLNLJDKOPAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private OOCNFGONDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private BDLPFJGDHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class LCGHPOHJJOE : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class HIGAKCGPOHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3614C40", Offset = "0x3613C40", VA = "0x183614C40")]
		static HIGAKCGPOHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class GDEDEEKPLCO : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class MBBALBEFFED<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3C54BC0", Offset = "0x3C53BC0", VA = "0x183C54BC0")]
			static MBBALBEFFED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private GDEDEEKPLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private LCGHPOHJJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class MOHPNKPLJLF : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class CMGMFCEEKOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x48DD970", Offset = "0x48DC970", VA = "0x1848DD970")]
		static CMGMFCEEKOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class NELEPLCJIKP : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class HEBCKEMIGME<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x35EED60", Offset = "0x35EDD60", VA = "0x1835EED60")]
			static HEBCKEMIGME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private NELEPLCJIKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private MOHPNKPLJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class EFJDCPPEDIC : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class DDFALBLKHPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4D96390", Offset = "0x4D95390", VA = "0x184D96390")]
		static DDFALBLKHPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class PLIKDPANJAI : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class DOKGAJDELNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4DD4190", Offset = "0x4DD3190", VA = "0x184DD4190")]
			static DOKGAJDELNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private PLIKDPANJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private EFJDCPPEDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class CLCDBGBBKEL : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class DKAAFPGMBPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4DBA920", Offset = "0x4DB9920", VA = "0x184DBA920")]
		static DKAAFPGMBPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class LLAKGPCGHHO : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class EMJJCINICEP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x311C670", Offset = "0x311B670", VA = "0x18311C670")]
			static EMJJCINICEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private LLAKGPCGHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private CLCDBGBBKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class ENOAAJLANGE : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class GIIEAFEGBMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x35278C0", Offset = "0x35268C0", VA = "0x1835278C0")]
		static GIIEAFEGBMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class DAANGLOAKNA : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class JGJLJJELONN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x38DBD40", Offset = "0x38DAD40", VA = "0x1838DBD40")]
			static JGJLJJELONN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private DAANGLOAKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private ENOAAJLANGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class DNBEKJEJFIP : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class MJFNBGFBCHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F450", Offset = "0x3C9E450", VA = "0x183C9F450")]
		static MJFNBGFBCHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class PGELAOOJEFM : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class PENIEEPIMAL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3EAD6B0", Offset = "0x3EAC6B0", VA = "0x183EAD6B0")]
			static PENIEEPIMAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private PGELAOOJEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private DNBEKJEJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class BFKAFLKNAKL : NKGJGOEJJEF
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class MJMCNNKNNMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB46A0", Offset = "0x3CB36A0", VA = "0x183CB46A0")]
		static MJMCNNKNNMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class FCFLFBLPAAH : NKGJGOEJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class HHJNGDCFGMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly DFIHLHFFLJJ<T> AKIBHMLIFCF;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x36100F0", Offset = "0x360F0F0", VA = "0x1836100F0")]
			static HHJNGDCFGMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly NKGJGOEJJEF NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly NKGJGOEJJEF[] IBJLELAINAK;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private FCFLFBLPAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
		public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NKGJGOEJJEF NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly DFIHLHFFLJJ<object> EAENJIGKGIL;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	private BFKAFLKNAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	public DFIHLHFFLJJ<T> KGJIIHNMKFL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MKHOBMMGGLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] DMACGICNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int FJPPAJJFFPO;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA270", Offset = "0x3CB9270", VA = "0x183CBA270")]
	public MKHOBMMGGLM(int FJNCEIECJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA020", Offset = "0x3CB9020", VA = "0x183CBA020")]
	public void GPDFOMDKBKK(T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CBA1E0", Offset = "0x3CB91E0", VA = "0x183CBA1E0")]
	public T[] KBGEFIJPOPN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class LPBBPOAJBGG : OBAHDDGMLHI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly LPBBPOAJBGG ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x65753D0", Offset = "0x65743D0", VA = "0x1865753D0")]
	public LPBBPOAJBGG(int HJEFDOFKDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class OBAHDDGMLHI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int HJEFDOFKDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object DCKCIBNKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NFJIPMHILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] LIOGJJEDOLK;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0F10", Offset = "0x3DEFF10", VA = "0x183DF0F10")]
	public OBAHDDGMLHI(int HJEFDOFKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFF50", Offset = "0x3DEEF50", VA = "0x183DEFF50")]
	public T[] IJGMCEHCDHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0610", Offset = "0x3DEF610", VA = "0x183DF0610")]
	public void NHDPIKELKMK(T[] FHOLKIOOKFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class BLCFLOFFADD : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class BPFMFFHGMOJ : IComparable<BPFMFFHGMOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class IMDMBBAEIDB : IEnumerable<BPFMFFHGMOJ>, IEnumerable, IEnumerator<BPFMFFHGMOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private BPFMFFHGMOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public BPFMFFHGMOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private BPFMFFHGMOJ System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
			[DebuggerHidden]
			public IMDMBBAEIDB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x65740E0", Offset = "0x65730E0", VA = "0x1865740E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6574210", Offset = "0x6573210", VA = "0x186574210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6574160", Offset = "0x6573160", VA = "0x186574160", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BPFMFFHGMOJ> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6574160", Offset = "0x6573160", VA = "0x186574160", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class JKHBGMELPCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public JKHBGMELPCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x65740B0", Offset = "0x65730B0", VA = "0x1865740B0")]
			internal Label LHLEKODFFJC(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x65740B0", Offset = "0x65730B0", VA = "0x1865740B0")]
			internal Label FCLPCOHJPGJ(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly BPFMFFHGMOJ[] GBGNPJBAPFM;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] DFOMPMBLPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong NNFEBNLDCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int INAJMIAKCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string ABOMGPOJEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private BPFMFFHGMOJ[] PHCCFCBBHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] FDEBDIAFPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int AGLAJIDEGHD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GNEPDMBFIND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50A6690", Offset = "0x50A5690", VA = "0x1850A6690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x65693F0", Offset = "0x65683F0", VA = "0x1865693F0")]
		public BPFMFFHGMOJ(ulong BGNGIHJEFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6568CD0", Offset = "0x6567CD0", VA = "0x186568CD0")]
		public BPFMFFHGMOJ GPDFOMDKBKK(ulong BGNGIHJEFLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6568ED0", Offset = "0x6567ED0", VA = "0x186568ED0")]
		public BPFMFFHGMOJ GPDFOMDKBKK(ulong BGNGIHJEFLM, int APPJEOKOGAK, string ABOMGPOJEOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6567DC0", Offset = "0x6566DC0", VA = "0x186567DC0")]
		public BPFMFFHGMOJ CPLDOAEBHFL(byte[] KLACNNEOMHG, int ODJLNMBFCPC, int MOJJMOIPLNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6568F30", Offset = "0x6567F30", VA = "0x186568F30")]
		internal static int MGJDIHFLOHC(ulong[] FHOLKIOOKFG, int NFJIPMHILEL, int EHBIPHOJPOK, ulong APPJEOKOGAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6567F40", Offset = "0x6566F40", VA = "0x186567F40", Slot = "4")]
		public int CompareTo(BPFMFFHGMOJ EJEDDDCGMMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6567F70", Offset = "0x6566F70", VA = "0x186567F70")]
		[IteratorStateMachine(typeof(IMDMBBAEIDB))]
		public IEnumerable<BPFMFFHGMOJ> EKNILBIGJKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6568FC0", Offset = "0x6567FC0", VA = "0x186568FC0")]
		public void PEFCHLLJIAO(ILGenerator PBEBLGCKIFO, LocalBuilder KLACNNEOMHG, LocalBuilder MOJJMOIPLNO, LocalBuilder BGNGIHJEFLM, Action<KeyValuePair<string, int>> KDOFOAAIFIL, Action IGCMNDPPPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6567FF0", Offset = "0x6566FF0", VA = "0x186567FF0")]
		private static void FGCJFNLLIAH(ILGenerator PBEBLGCKIFO, LocalBuilder KLACNNEOMHG, LocalBuilder MOJJMOIPLNO, LocalBuilder BGNGIHJEFLM, Action<KeyValuePair<string, int>> KDOFOAAIFIL, Action IGCMNDPPPPK, BPFMFFHGMOJ[] PHCCFCBBHAI, int AGLAJIDEGHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class DCPLJKPBHPJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<BPFMFFHGMOJ> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<BPFMFFHGMOJ> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<BPFMFFHGMOJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private BPFMFFHGMOJ <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9C95B0", Offset = "0x9C85B0", VA = "0x1809C95B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x656BA00", Offset = "0x656AA00", VA = "0x18656BA00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BBB210", Offset = "0x1BBA210", VA = "0x181BBB210")]
		[DebuggerHidden]
		public DCPLJKPBHPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x656BA50", Offset = "0x656AA50", VA = "0x18656BA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x656B4A0", Offset = "0x656A4A0", VA = "0x18656B4A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x656B450", Offset = "0x656A450", VA = "0x18656B450")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x656B400", Offset = "0x656A400", VA = "0x18656B400")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x656B9B0", Offset = "0x656A9B0", VA = "0x18656B9B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x656B900", Offset = "0x656A900", VA = "0x18656B900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x656B900", Offset = "0x656A900", VA = "0x18656B900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly BPFMFFHGMOJ GLACNLFCFNI;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6567390", Offset = "0x6566390", VA = "0x186567390")]
	public BLCFLOFFADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6566DA0", Offset = "0x6565DA0", VA = "0x186566DA0")]
	public void GPDFOMDKBKK(byte[] BKCOILCKNDC, int APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6566F40", Offset = "0x6565F40", VA = "0x186566F40")]
	public bool NOBPENCGBFJ(ArraySegment<byte> BGNGIHJEFLM, [Out] int APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6567300", Offset = "0x6566300", VA = "0x186567300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6567020", Offset = "0x6566020", VA = "0x186567020")]
	private static void PHDPMLPPANH(IEnumerable<BPFMFFHGMOJ> PHCCFCBBHAI, StringBuilder GJCIPBLLCPK, int JAGDEKNJOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6566EB0", Offset = "0x6565EB0", VA = "0x186566EB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6566EB0", Offset = "0x6565EB0", VA = "0x186566EB0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6566D20", Offset = "0x6565D20", VA = "0x186566D20")]
	[IteratorStateMachine(typeof(DCPLJKPBHPJ))]
	private static IEnumerable<KeyValuePair<string, int>> CEPIIKCPIDE(IEnumerable<BPFMFFHGMOJ> PHCCFCBBHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6566F10", Offset = "0x6565F10", VA = "0x186566F10")]
	public void MFADFBFNDFA(ILGenerator PBEBLGCKIFO, LocalBuilder KLACNNEOMHG, LocalBuilder MOJJMOIPLNO, LocalBuilder BGNGIHJEFLM, Action<KeyValuePair<string, int>> KDOFOAAIFIL, Action IGCMNDPPPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class AJGALOGBCID
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo CIDAGMMDCPA;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x65654C0", Offset = "0x65644C0", VA = "0x1865654C0")]
	public static ulong NDAFAPOHJKB(byte[] BKCOILCKNDC, int ODJLNMBFCPC, int MOJJMOIPLNO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class CNDDAEBKADI
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6569D80", Offset = "0x6568D80", VA = "0x186569D80")]
	public static void CHBAAAELDJD(byte[] BKCOILCKNDC, int ODJLNMBFCPC, int OKGGEKDJGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6569EC0", Offset = "0x6568EC0", VA = "0x186569EC0")]
	public static void IAIGGNECNND(byte[] FHOLKIOOKFG, int MKLIJLKCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6569FE0", Offset = "0x6568FE0", VA = "0x186569FE0")]
	public static byte[] ICKMOAJKDOD(byte[] AEMKIPDFHEB, int MKLIJLKCMLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class KPLGENMGBAC
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6574A50", Offset = "0x6573A50", VA = "0x186574A50")]
	public static bool LPMLFOEBJLB(byte[] GCAHHOEFNDF, int JFJJGMFACLB, int HGJCBPKEKKJ, byte[] DINPBJBEBHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class MDMKJJIBAAE<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct MOOEJKOMCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] NNFEBNLDCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T INAJMIAKCCF;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3860", Offset = "0x3CC2860", VA = "0x183CC3860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class HJEFDIHCCNI : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public MDMKJJIBAAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MOOEJKOMCOA[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MOOEJKOMCOA[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9C95B0", Offset = "0x9C85B0", VA = "0x1809C95B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AAF40", Offset = "0x34A9F40", VA = "0x1834AAF40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
		[DebuggerHidden]
		public HJEFDIHCCNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x361E1C0", Offset = "0x361D1C0", VA = "0x18361E1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x361F310", Offset = "0x361E310", VA = "0x18361F310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MOOEJKOMCOA[][] MFCPKOILCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong LDGMNNEAHKO;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3C704C0", Offset = "0x3C6F4C0", VA = "0x183C704C0")]
	public MDMKJJIBAAE(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3C704E0", Offset = "0x3C6F4E0", VA = "0x183C704E0")]
	public MDMKJJIBAAE(int IKHECAIEEHO, float LHCPFCGEIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A800", Offset = "0x3C69800", VA = "0x183C6A800")]
	public void GPDFOMDKBKK(byte[] BGNGIHJEFLM, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3C65530", Offset = "0x3C64530", VA = "0x183C65530")]
	private bool FEAAONCKIFO(byte[] BGNGIHJEFLM, T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F130", Offset = "0x3C6E130", VA = "0x183C6F130")]
	public bool KMJKDBDGJFH(ArraySegment<byte> BGNGIHJEFLM, [Out] T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3C63C70", Offset = "0x3C62C70", VA = "0x183C63C70")]
	private static ulong ACADKMDPGCK(byte[] LNKHMLIBJEP, int ODJLNMBFCPC, int AGLAJIDEGHD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x344CE40", Offset = "0x344BE40", VA = "0x18344CE40")]
	private static int AFOIKMAGCIC(int LEJBMGCBCHL, float LHCPFCGEIPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3C6C050", Offset = "0x3C6B050", VA = "0x183C6C050", Slot = "4")]
	[IteratorStateMachine(typeof(MDMKJJIBAAE<>.HJEFDIHCCNI))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33C0F20", Offset = "0x33BFF20", VA = "0x1833C0F20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class DHECDCIBDLF : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] ONBMGFJEEDB;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] HNPCAKKAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int EBBAAOHFBFM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool GAHDEMDBNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x656BBA0", Offset = "0x656ABA0", VA = "0x18656BBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x656BCF0", Offset = "0x656ACF0", VA = "0x18656BCF0")]
	static DHECDCIBDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x656BF50", Offset = "0x656AF50", VA = "0x18656BF50")]
	public DHECDCIBDLF(byte[] PHMIFBHHFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x656BBF0", Offset = "0x656ABF0", VA = "0x18656BBF0")]
	public OpCode INCFHGHPOMN()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct NBMBLGFPKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid INAJMIAKCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte BMKIAHOEKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte LBGLOLBBMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte LFEELFMNJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte MNBPMNMIFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte LCPGLDLGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte KLJFAAENELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CBCNDCJAGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte PELDPBBGBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte EGKFHHDNDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte PFPMGGHMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte OJAEFKHEPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte DADGBFIICCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte KHHGIGIPNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte JDHFNJHJCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte JEPJNEOMCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte EEAAAKGHCAM;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] DPGMLLFPLFO;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] FMPBNAONGLG;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x657A500", Offset = "0x6579500", VA = "0x18657A500")]
	public NBMBLGFPKDB(Guid APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6578DB0", Offset = "0x6577DB0", VA = "0x186578DB0")]
	public NBMBLGFPKDB(ArraySegment<byte> MBGEDEAHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6577E50", Offset = "0x6576E50", VA = "0x186577E50")]
	private static byte BIDDMLBPAED(byte[] BKCOILCKNDC, int CLHMGEDHHAI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6578BA0", Offset = "0x6577BA0", VA = "0x186578BA0")]
	private static byte PMHIDPNNGOH(byte NDOJJCKFJID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6577EF0", Offset = "0x6576EF0", VA = "0x186577EF0")]
	public void KOLMFBJFGAN(byte[] DOAIHCCMJDP, int ODJLNMBFCPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class GMOLMPIKAPE
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x65717F0", Offset = "0x65707F0", VA = "0x1865717F0")]
	public static bool LEKLEBLCGPJ(byte APEENPEFHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6571290", Offset = "0x6570290", VA = "0x186571290")]
	public static bool BCGAECAAHJF(byte APEENPEFHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6571380", Offset = "0x6570380", VA = "0x186571380")]
	public static sbyte EOEPAADFDEK(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6571460", Offset = "0x6570460", VA = "0x186571460")]
	public static short FDFHLHMPENF(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6571700", Offset = "0x6570700", VA = "0x186571700")]
	public static int LANHMPAGHLD(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6571660", Offset = "0x6570660", VA = "0x186571660")]
	public static long JOEOGCLIOLP(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6571AA0", Offset = "0x6570AA0", VA = "0x186571AA0")]
	public static byte MBBJHJAPIBG(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6572BF0", Offset = "0x6571BF0", VA = "0x186572BF0")]
	public static ushort OCDGMOAELLD(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6571300", Offset = "0x6570300", VA = "0x186571300")]
	public static uint EGJKJFLBGPD(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6571550", Offset = "0x6570550", VA = "0x186571550")]
	public static ulong INMIDGCBPFK(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x65724E0", Offset = "0x65714E0", VA = "0x1865724E0")]
	public static float NHEMNCHKIJJ(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6571800", Offset = "0x6570800", VA = "0x186571800")]
	public static double LEODNHMJADE(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6572550", Offset = "0x6571550", VA = "0x186572550")]
	public static int NOMKEMDODOJ(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, ulong APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6571B20", Offset = "0x6570B20", VA = "0x186571B20")]
	public static int MGPLCNHKIHD(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, long APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6571870", Offset = "0x6570870", VA = "0x186571870")]
	public static bool LGPHLNMJEKE(byte[] BKCOILCKNDC, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class EJLNCMLPOEB
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class OOGAPMOIEOC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public OOGAPMOIEOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x657B4B0", Offset = "0x657A4B0", VA = "0x18657B4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x657AF70", Offset = "0x6579F70", VA = "0x18657AF70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x657AF20", Offset = "0x6579F20", VA = "0x18657AF20")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x657AED0", Offset = "0x6579ED0", VA = "0x18657AED0")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x657B460", Offset = "0x657A460", VA = "0x18657B460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x657B3A0", Offset = "0x657A3A0", VA = "0x18657B3A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x657B3A0", Offset = "0x657A3A0", VA = "0x18657B3A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class HEAKCDIBJJC : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public HEAKCDIBJJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6573960", Offset = "0x6572960", VA = "0x186573960", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6573420", Offset = "0x6572420", VA = "0x186573420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x65733D0", Offset = "0x65723D0", VA = "0x1865733D0")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6573380", Offset = "0x6572380", VA = "0x186573380")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6573910", Offset = "0x6572910", VA = "0x186573910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6573850", Offset = "0x6572850", VA = "0x186573850", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6573850", Offset = "0x6572850", VA = "0x186573850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x656C4A0", Offset = "0x656B4A0", VA = "0x18656C4A0")]
	public static bool HGLODMCMIHN(this TypeInfo CFGJPNBLNDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x656C5E0", Offset = "0x656B5E0", VA = "0x18656C5E0")]
	public static bool OBCBIOCODFB(this TypeInfo CFGJPNBLNDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x656C560", Offset = "0x656B560", VA = "0x18656C560")]
	public static IEnumerable<PropertyInfo> JFHGIHDKBAI(this Type CFGJPNBLNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x656C2E0", Offset = "0x656B2E0", VA = "0x18656C2E0")]
	[IteratorStateMachine(typeof(OOGAPMOIEOC))]
	private static IEnumerable<PropertyInfo> CBBCDGJBBJB(Type CFGJPNBLNDJ, HashSet<string> GHKLDNJHJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x656C380", Offset = "0x656B380", VA = "0x18656C380")]
	public static IEnumerable<FieldInfo> FADIOLAMNGH(this Type CFGJPNBLNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x656C400", Offset = "0x656B400", VA = "0x18656C400")]
	[IteratorStateMachine(typeof(HEAKCDIBJJC))]
	private static IEnumerable<FieldInfo> FLMPIGDKBLP(Type CFGJPNBLNDJ, HashSet<string> GHKLDNJHJBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OLAHNEKMJNI
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding PIPGGBJOBJM;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class CHFMEONKCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static string IOCNLMKDPCM(string PCPFOKAIBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6569810", Offset = "0x6568810", VA = "0x186569810")]
	public static string BNFIIOFFEEE(string PCPFOKAIBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x65698F0", Offset = "0x65688F0", VA = "0x1865698F0")]
	public static string HALGGPHIOLO(string PCPFOKAIBEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class FEBBGICKJJF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class FNNHJPINEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type NNFEBNLDCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue INAJMIAKCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int HBHMHFJIPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public FNNHJPINEHA CLAGMKDPLCC;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3471A90", Offset = "0x3470A90", VA = "0x183471A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3471940", Offset = "0x3470940", VA = "0x183471940")]
		private int PLKFCNLILAN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FNNHJPINEHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LPGJIKPDPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LPGJIKPDPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		internal TValue PPCKDCMGLKB(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private FNNHJPINEHA[] MFCPKOILCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int LHAIIFMNPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object DBIKJHDODCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float LHCPFCGEIPD;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x344E4D0", Offset = "0x344D4D0", VA = "0x18344E4D0")]
	public FEBBGICKJJF(int IKHECAIEEHO = 4, float LHCPFCGEIPD = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x344D700", Offset = "0x344C700", VA = "0x18344D700")]
	public bool KBPGNNBKMBB(Type BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x344D960", Offset = "0x344C960", VA = "0x18344D960")]
	public bool KBPGNNBKMBB(Type BGNGIHJEFLM, Func<Type, TValue> CBGLJKMMNGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x344D200", Offset = "0x344C200", VA = "0x18344D200")]
	private bool FEAAONCKIFO(Type BGNGIHJEFLM, Func<Type, TValue> CBGLJKMMNGB, [Out] TValue IEMHFBNHDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x344DC10", Offset = "0x344CC10", VA = "0x18344DC10")]
	private bool PPENNJPIKPP(FNNHJPINEHA[] MFCPKOILCBC, Type MHJLPKOGMEK, FNNHJPINEHA GBIEKADHAFG, Func<Type, TValue> CBGLJKMMNGB, [Out] TValue IEMHFBNHDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x344DAD0", Offset = "0x344CAD0", VA = "0x18344DAD0")]
	public bool KMJKDBDGJFH(Type BGNGIHJEFLM, [Out] TValue APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x344D600", Offset = "0x344C600", VA = "0x18344D600")]
	public TValue FMJJIOKNAFJ(Type BGNGIHJEFLM, Func<Type, TValue> CBGLJKMMNGB)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x344CE40", Offset = "0x344BE40", VA = "0x18344CE40")]
	private static int AFOIKMAGCIC(int LEJBMGCBCHL, float LHCPFCGEIPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x344CE70", Offset = "0x344BE70", VA = "0x18344CE70")]
	private static void EFOFDDBPLJK(FNNHJPINEHA ICBEPPBBIKE, FNNHJPINEHA APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x344CE70", Offset = "0x344BE70", VA = "0x18344CE70")]
	private static void EFOFDDBPLJK(FNNHJPINEHA[] ICBEPPBBIKE, FNNHJPINEHA[] APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KMJNMPONGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder KPGCLECKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder IDPMMLIBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object DCKCIBNKFHD;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x65745E0", Offset = "0x65735E0", VA = "0x1865745E0")]
	public TypeBuilder ELGCCFBIEGC(string JNMEJDHMADI, TypeAttributes PKCEBMCCFGF, Type IGPIMCJILMM, Type[] FIPPOKHHHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x65746E0", Offset = "0x65736E0", VA = "0x1865746E0")]
	public KMJNMPONGBM(string HPMEDNLGKNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class HKLIKDDAEPB
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6573C30", Offset = "0x6572C30", VA = "0x186573C30")]
	private static MethodInfo OODCIIBMDFG(LambdaExpression FPLIBOLHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x24FC680", Offset = "0x24FB680", VA = "0x1824FC680")]
	public static MethodInfo GEFCICOFKJI<T>(Expression<Func<T>> FPLIBOLHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x24FC680", Offset = "0x24FB680", VA = "0x1824FC680")]
	public static MethodInfo GEFCICOFKJI<T, TR>(Expression<Func<T, TR>> FPLIBOLHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x24FC680", Offset = "0x24FB680", VA = "0x1824FC680")]
	public static MethodInfo GEFCICOFKJI<T>(Expression<Action<T>> FPLIBOLHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x24FC680", Offset = "0x24FB680", VA = "0x1824FC680")]
	public static MethodInfo GEFCICOFKJI<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> FPLIBOLHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x24FC5A0", Offset = "0x24FB5A0", VA = "0x1824FC5A0")]
	private static MemberInfo AKFGFABIELN<T>(Expression<T> ONDDMEPBDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x24FC690", Offset = "0x24FB690", VA = "0x1824FC690")]
	public static PropertyInfo NBACKCBPDHJ<T, TR>(Expression<Func<T, TR>> FPLIBOLHKKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct ICCOKFAJNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int LNBKADIBNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool NODFGMFMBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator PBEBLGCKIFO;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6573FE0", Offset = "0x6572FE0", VA = "0x186573FE0")]
	public ICCOKFAJNEA(ILGenerator PBEBLGCKIFO, int LNBKADIBNBM, bool NODFGMFMBCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6574020", Offset = "0x6573020", VA = "0x186574020")]
	public ICCOKFAJNEA(ILGenerator PBEBLGCKIFO, int LNBKADIBNBM, Type CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6573EE0", Offset = "0x6572EE0", VA = "0x186573EE0")]
	public void JADGPENIHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class CODJNJJEACM
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x656A6A0", Offset = "0x65696A0", VA = "0x18656A6A0")]
	public static void HMMNBLAMBGN(this ILGenerator PBEBLGCKIFO, int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x656A660", Offset = "0x6569660", VA = "0x18656A660")]
	public static void HMMNBLAMBGN(this ILGenerator PBEBLGCKIFO, LocalBuilder OOODOPJBBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x656B040", Offset = "0x656A040", VA = "0x18656B040")]
	public static void PBNNHHFKPMA(this ILGenerator PBEBLGCKIFO, int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x656B000", Offset = "0x656A000", VA = "0x18656B000")]
	public static void PBNNHHFKPMA(this ILGenerator PBEBLGCKIFO, LocalBuilder OOODOPJBBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x656AE90", Offset = "0x6569E90", VA = "0x18656AE90")]
	public static void LOJNACJMADA(this ILGenerator PBEBLGCKIFO, int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x656AD90", Offset = "0x6569D90", VA = "0x18656AD90")]
	public static void LOJNACJMADA(this ILGenerator PBEBLGCKIFO, LocalBuilder OOODOPJBBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x656A650", Offset = "0x6569650", VA = "0x18656A650")]
	public static void HKALFAEMKLM(this ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x656A370", Offset = "0x6569370", VA = "0x18656A370")]
	public static void EAKGIJCEAHN(this ILGenerator PBEBLGCKIFO, bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x656A9B0", Offset = "0x65699B0", VA = "0x18656A9B0")]
	public static void KBPFLGDPIAD(this ILGenerator PBEBLGCKIFO, int APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x656A290", Offset = "0x6569290", VA = "0x18656A290")]
	public static void DFKFKCGAFHP(this ILGenerator PBEBLGCKIFO, Type CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x656A910", Offset = "0x6569910", VA = "0x18656A910")]
	public static void JEODOPLPAAM(this ILGenerator PBEBLGCKIFO, Type CFGJPNBLNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x656A380", Offset = "0x6569380", VA = "0x18656A380")]
	public static void ELEFEKCIAPA(this ILGenerator PBEBLGCKIFO, int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x656A890", Offset = "0x6569890", VA = "0x18656A890")]
	public static void IPKFPAIJOPA(this ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x656A570", Offset = "0x6569570", VA = "0x18656A570")]
	public static void GFFKEAOGCML(this ILGenerator PBEBLGCKIFO, int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x656A1A0", Offset = "0x65691A0", VA = "0x18656A1A0")]
	public static void DBPKJFPNEJM(this ILGenerator PBEBLGCKIFO, MethodInfo OEBOPIBGPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x656AF70", Offset = "0x6569F70", VA = "0x18656AF70")]
	public static void MFAPAKOGKJG(this ILGenerator PBEBLGCKIFO, FieldInfo HGLDDLNIECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x656A110", Offset = "0x6569110", VA = "0x18656A110")]
	public static void AEDEADKCLDK(this ILGenerator PBEBLGCKIFO, ulong APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class BNIFPJJLCON
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class HCBEDFEJMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HCBEDFEJMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x65730F0", Offset = "0x65720F0", VA = "0x1865730F0")]
		internal bool FJDIPLCLECF(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo PGKIPNBNCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo FHFFOBCJMIG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string FAMLEFPOHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OAGNHJHAOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6567A60", Offset = "0x6566A60", VA = "0x186567A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DDANHCBEGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x774F30", Offset = "0x773F30", VA = "0x180774F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x774F00", Offset = "0x773F00", VA = "0x180774F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JFMIPNIOODF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x84F320", Offset = "0x84E320", VA = "0x18084F320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x84ED10", Offset = "0x84DD10", VA = "0x18084ED10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type AMBPOKEJAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo KHAGKHFENNA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo BDHKAPHPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773F80", VA = "0x180774F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NHLJEGNIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x779C40", Offset = "0x778C40", VA = "0x180779C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x774F70", Offset = "0x773F70", VA = "0x180774F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6567C30", Offset = "0x6566C30", VA = "0x186567C30")]
	protected BNIFPJJLCON(Type CFGJPNBLNDJ, string JNMEJDHMADI, string ALKIFJFDIAO, bool HMKJPFBGBCJ, bool CAIAIDGBBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6567CB0", Offset = "0x6566CB0", VA = "0x186567CB0")]
	public BNIFPJJLCON(FieldInfo NMPKCMJCPLB, string JNMEJDHMADI, bool FDGACEJDMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6567A70", Offset = "0x6566A70", VA = "0x186567A70")]
	public BNIFPJJLCON(PropertyInfo NMPKCMJCPLB, string JNMEJDHMADI, bool FDGACEJDMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65678F0", Offset = "0x65668F0", VA = "0x1865678F0")]
	private static MethodInfo FFJHJLDOBMJ(MemberInfo NMPKCMJCPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x22C5280", Offset = "0x22C4280", VA = "0x1822C5280")]
	public T EDOCNAHKLCB<T>(bool JAGADEPKAJN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6567770", Offset = "0x6566770", VA = "0x186567770", Slot = "4")]
	public virtual void DFNKEPDKCNJ(ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x65675F0", Offset = "0x65665F0", VA = "0x1865675F0", Slot = "5")]
	public virtual void AJPBAHJADGK(ILGenerator PBEBLGCKIFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class BMKDJFJOJEP : BNIFPJJLCON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string JOMOJLCJPFN;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6567510", Offset = "0x6566510", VA = "0x186567510")]
	public BMKDJFJOJEP(string JNMEJDHMADI, string JOMOJLCJPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6567460", Offset = "0x6566460", VA = "0x186567460", Slot = "4")]
	public override void DFNKEPDKCNJ(ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6567410", Offset = "0x6566410", VA = "0x186567410", Slot = "5")]
	public override void AJPBAHJADGK(ILGenerator PBEBLGCKIFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class BFCLGJNDCCO : BNIFPJJLCON
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo FGHMFJLJCJP;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo ANMLNBMAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal ICCOKFAJNEA LBMIIMKLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal ICCOKFAJNEA BBFDDLKKJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal ICCOKFAJNEA PMNBGIDJHHC;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6566AE0", Offset = "0x6565AE0", VA = "0x186566AE0")]
	public BFCLGJNDCCO(string JNMEJDHMADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6566350", Offset = "0x6565350", VA = "0x186566350", Slot = "4")]
	public override void DFNKEPDKCNJ(ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6566300", Offset = "0x6565300", VA = "0x186566300", Slot = "5")]
	public override void AJPBAHJADGK(ILGenerator PBEBLGCKIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6566410", Offset = "0x6565410", VA = "0x186566410")]
	public void HNKOHMAELOM(ILGenerator PBEBLGCKIFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class FBKMBAPLACJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type AMBPOKEJAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HNEEODIEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7775F0", Offset = "0x7765F0", VA = "0x1807775F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LKBDKJPOEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x847DF0", Offset = "0x846DF0", VA = "0x180847DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x846E10", Offset = "0x845E10", VA = "0x180846E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo EGILKDJAABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BNIFPJJLCON[] KHFBBBOHAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BNIFPJJLCON[] INNDKGEBBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x656CBD0", Offset = "0x656BBD0", VA = "0x18656CBD0")]
	public FBKMBAPLACJ(Type CFGJPNBLNDJ, Func<string, string> EFMLGOJPNKF, bool FDGACEJDMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x656CAF0", Offset = "0x656BAF0", VA = "0x18656CAF0")]
	private static bool HMKHPAHEMOJ(IEnumerator<ConstructorInfo> PCKICEFMLMI, ConstructorInfo JEMCGPGJHED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct OGFGKAJFGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong EOCLDJPGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int BALOPCFMODO;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3890", Offset = "0x1CE2890", VA = "0x181CE3890")]
	public OGFGKAJFGAM(ulong DFKLIABDFEF, int BOADFOCDLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x657AAA0", Offset = "0x6579AA0", VA = "0x18657AAA0")]
	public void FBAEPOMLHBK(OGFGKAJFGAM EJEDDDCGMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x657AA90", Offset = "0x6579A90", VA = "0x18657AA90")]
	public static OGFGKAJFGAM BPBMBLGJNNB(OGFGKAJFGAM HMDDIJJDAIK, OGFGKAJFGAM NDOJJCKFJID)
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x657AB40", Offset = "0x6579B40", VA = "0x18657AB40")]
	public void JLLDHPGDAIB(OGFGKAJFGAM EJEDDDCGMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x657ABD0", Offset = "0x6579BD0", VA = "0x18657ABD0")]
	public static OGFGKAJFGAM MBADEMCJGPM(OGFGKAJFGAM HMDDIJJDAIK, OGFGKAJFGAM NDOJJCKFJID)
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x657AB00", Offset = "0x6579B00", VA = "0x18657AB00")]
	public void HCHHFPJLCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x657AAB0", Offset = "0x6579AB0", VA = "0x18657AAB0")]
	public static OGFGKAJFGAM HCHHFPJLCAP(OGFGKAJFGAM HMDDIJJDAIK)
	{
		return default(OGFGKAJFGAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct HAOEMBIJOEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] DOAIHCCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int ODJLNMBFCPC;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1717410", Offset = "0x1716410", VA = "0x181717410")]
	public HAOEMBIJOEB(byte[] DOAIHCCMJDP, int LPGLCEHEHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x655B250", Offset = "0x655A250", VA = "0x18655B250")]
	public void FHEPIJKLOCP(byte CINODLDMGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6572DD0", Offset = "0x6571DD0", VA = "0x186572DD0")]
	public void MDHPMFNMHDI(byte[] CINODLDMGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6572E50", Offset = "0x6571E50", VA = "0x186572E50")]
	public void NBMJFIODKNA(byte[] CINODLDMGAP, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6572ED0", Offset = "0x6571ED0", VA = "0x186572ED0")]
	public void NBMJFIODKNA(byte[] CINODLDMGAP, int CEJJMMEOKPD, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6573070", Offset = "0x6572070", VA = "0x186573070")]
	public void PIBJHEJJKBP(byte APEENPEFHEI, int AGLAJIDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6572F70", Offset = "0x6571F70", VA = "0x186572F70")]
	public void PDBNLBFIEIK(string CINODLDMGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class GIHJLCHKFID
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum OOHLLLMDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum OADFHKDLCMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum IEAPKMPMMMO
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
	private static byte[] PJBLBGIPAFN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] EACOHGLPPBO;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] PHNKFEOICKD;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] EBONCHHMMFG;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly IEAPKMPMMMO CFDHLICCIHB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char IPOPCBKNGCF;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int AFEDIEEEFPH;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int MMKIANGDJKF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] LOKHGFADOMO;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6570040", Offset = "0x656F040", VA = "0x186570040")]
	private static byte[] EKJMJNIPCAH(int LHAIIFMNPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6570960", Offset = "0x656F960", VA = "0x186570960")]
	private static byte[] LJNKAEEPDHJ(int LHAIIFMNPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x656F1B0", Offset = "0x656E1B0", VA = "0x18656F1B0")]
	public static int BPBOIBPNPGF(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, float APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x656F090", Offset = "0x656E090", VA = "0x18656F090")]
	public static int BPBOIBPNPGF(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, double APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6570870", Offset = "0x656F870", VA = "0x186570870")]
	private static bool IOFMCGCFIFB(byte[] DOAIHCCMJDP, int EHBIPHOJPOK, ulong KDNEOKFMIIF, ulong AEFCJOHEAHJ, ulong MOJJMOIPLNO, ulong EIDLGMMCOME, ulong LBPANMPBGNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6570110", Offset = "0x656F110", VA = "0x186570110")]
	private static void FBDNKGOHJBC(uint CDOOMMABEBM, int IMBMAMFMIME, [Out] uint ABBNHDDDAGH, [Out] int NMHLBDPOBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x656FC50", Offset = "0x656EC50", VA = "0x18656FC50")]
	private static bool EGAOHFAJCKH(OGFGKAJFGAM GELEPGBMPPO, OGFGKAJFGAM JBMDKHMBEKD, OGFGKAJFGAM MAIBMOCGHBJ, byte[] DOAIHCCMJDP, [Out] int EHBIPHOJPOK, [Out] int ADCLLHNPDKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6570200", Offset = "0x656F200", VA = "0x186570200")]
	private static bool FOILGDLPOKO(double DKPNOEEKPBJ, OOHLLLMDBCA PMFIIBOFEAB, byte[] DOAIHCCMJDP, [Out] int EHBIPHOJPOK, [Out] int FNEMIHBOPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x656F2D0", Offset = "0x656E2D0", VA = "0x18656F2D0")]
	private static bool CKOKNHEINGO(double DKPNOEEKPBJ, OOHLLLMDBCA PMFIIBOFEAB, byte[] DOAIHCCMJDP, [Out] int EHBIPHOJPOK, [Out] int PFOGCHKJBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6570A40", Offset = "0x656FA40", VA = "0x186570A40")]
	private static bool OEEFIEIAJDJ(double APPJEOKOGAK, HAOEMBIJOEB JBDLCPDHCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x656F770", Offset = "0x656E770", VA = "0x18656F770")]
	private static bool DDMIMJPFJAD(double APPJEOKOGAK, HAOEMBIJOEB JBDLCPDHCAB, OADFHKDLCMG PMFIIBOFEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x656F3E0", Offset = "0x656E3E0", VA = "0x18656F3E0")]
	private static void CNKIOBIJKFL(byte[] LEDGKAAANHG, int EHBIPHOJPOK, int PFOGCHKJBCN, int MEJOMPLOBMC, HAOEMBIJOEB JBDLCPDHCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6570C10", Offset = "0x656FC10", VA = "0x186570C10")]
	private static void PCOBIMIPLGE(byte[] LEDGKAAANHG, int EHBIPHOJPOK, int BOADFOCDLAN, HAOEMBIJOEB JBDLCPDHCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6570680", Offset = "0x656F680", VA = "0x186570680")]
	private static bool GIPHCOHAEAM(double DKPNOEEKPBJ, OADFHKDLCMG PMFIIBOFEAB, int OHJHLNPLKBH, byte[] HFDEBOALMMF, [Out] bool MIGPGIMLCEH, [Out] int EHBIPHOJPOK, [Out] int MIELJCMDEKP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct MHIILBMINJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double JAFPDGGIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong BENHFCHIGPA;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct BCMFBMMJOGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float EOCLDJPGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint FHENMFEOOFA;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct FDBEIMGFNJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong PCMDHFNPLEA;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x656E7F0", Offset = "0x656D7F0", VA = "0x18656E7F0")]
	public FDBEIMGFNJI(double JAFPDGGIPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x656E800", Offset = "0x656D800", VA = "0x18656E800")]
	public FDBEIMGFNJI(OGFGKAJFGAM JAFPDGGIPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x656E410", Offset = "0x656D410", VA = "0x18656E410")]
	public OGFGKAJFGAM IAOHGMCFFPE()
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x656E770", Offset = "0x656D770", VA = "0x18656E770")]
	public OGFGKAJFGAM NHODEJBPCDF()
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
	public ulong AHMJPDFLCJG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x656E360", Offset = "0x656D360", VA = "0x18656E360")]
	public double GFBIOFLCFFJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x656E2A0", Offset = "0x656D2A0", VA = "0x18656E2A0")]
	public double CMCAFECCKMK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x656E740", Offset = "0x656D740", VA = "0x18656E740")]
	public int MMIKIHNFDMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x656E6F0", Offset = "0x656D6F0", VA = "0x18656E6F0")]
	public ulong LODCDHOOHLA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x656E340", Offset = "0x656D340", VA = "0x18656E340")]
	public bool COHLLNGILFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x656E4F0", Offset = "0x656D4F0", VA = "0x18656E4F0")]
	public bool KHPIBLECBLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x656E270", Offset = "0x656D270", VA = "0x18656E270")]
	public bool BFGGLEMCJFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x656E3E0", Offset = "0x656D3E0", VA = "0x18656E3E0")]
	public bool HGCACAEOLNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x656E720", Offset = "0x656D720", VA = "0x18656E720")]
	public int MBAKJNJHGEA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x656E5A0", Offset = "0x656D5A0", VA = "0x18656E5A0")]
	public void LNCIBFIGJGM([Out] OGFGKAJFGAM BOAECJPPALK, [Out] OGFGKAJFGAM ILDHCPCPMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x656E480", Offset = "0x656D480", VA = "0x18656E480")]
	public bool IMFKCAICDNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9510", Offset = "0x2AA8510", VA = "0x182AA9510")]
	public double APPJEOKOGAK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x656E4D0", Offset = "0x656D4D0", VA = "0x18656E4D0")]
	public static int IPCJHLLMLGO(int KAEBGANGLLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x656E260", Offset = "0x656D260", VA = "0x18656E260")]
	public static double AKLNAJBFHLG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x656E510", Offset = "0x656D510", VA = "0x18656E510")]
	public static ulong LENNONHLLCM(OGFGKAJFGAM IFLPBNIOKJL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct FEDGBHCMNHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint PNFOMBPDLKB;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2011770", Offset = "0x2010770", VA = "0x182011770")]
	public FEDGBHCMNHJ(float EOCLDJPGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x656E8B0", Offset = "0x656D8B0", VA = "0x18656E8B0")]
	public OGFGKAJFGAM IAOHGMCFFPE()
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
	public uint PCPNFDDMLHN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x656EA90", Offset = "0x656DA90", VA = "0x18656EA90")]
	public int MMIKIHNFDMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x656EA70", Offset = "0x656DA70", VA = "0x18656EA70")]
	public uint LODCDHOOHLA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x656E8A0", Offset = "0x656D8A0", VA = "0x18656E8A0")]
	public bool COHLLNGILFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x656E940", Offset = "0x656D940", VA = "0x18656E940")]
	public void LNCIBFIGJGM([Out] OGFGKAJFGAM BOAECJPPALK, [Out] OGFGKAJFGAM ILDHCPCPMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x656E900", Offset = "0x656D900", VA = "0x18656E900")]
	public bool IMFKCAICDNH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct OELJBKEDKFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong DFKLIABDFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short AHGCDFOEEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short FNEMIHBOPHJ;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x657AA80", Offset = "0x6579A80", VA = "0x18657AA80")]
	public OELJBKEDKFF(ulong DFKLIABDFEF, short AHGCDFOEEDN, short FNEMIHBOPHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class PFPBOPGEOON
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly OELJBKEDKFF[] COGCLDIGPOF;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x657C1A0", Offset = "0x657B1A0", VA = "0x18657C1A0")]
	public static void CPOOPGMJABJ(int BECKNKELICL, int ANLCNKDGGIL, [Out] OGFGKAJFGAM ABBNHDDDAGH, [Out] int FNEMIHBOPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x657C2B0", Offset = "0x657B2B0", VA = "0x18657C2B0")]
	public static void IOHCJMILLAI(int FOLOHCAMCAL, [Out] OGFGKAJFGAM ABBNHDDDAGH, [Out] int MDAMOKMHBOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct BEBENIDDDFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] BKCOILCKNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int CEJJMMEOKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int NKLCMJEMKGF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6566260", Offset = "0x6565260", VA = "0x186566260")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4A40", Offset = "0x3CF3A40", VA = "0x183CF4A40")]
	public BEBENIDDDFC(byte[] BKCOILCKNDC, int CEJJMMEOKPD, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2042FA0", Offset = "0x2041FA0", VA = "0x182042FA0")]
	public int EHBIPHOJPOK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x65662A0", Offset = "0x65652A0", VA = "0x1865662A0")]
	public BEBENIDDDFC OHHIFFJMANO(int PJBEBHJINOD, int BANPOACJNJH)
	{
		return default(BEBENIDDDFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class MJNLNPHLGGA
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] JOEJCECAANH;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] DKAAJKAGJFP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int OCCHLEFAIJD;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6577430", Offset = "0x6576430", VA = "0x186577430")]
	private static byte[] MFCJIEFJINB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x65765A0", Offset = "0x65755A0", VA = "0x1865765A0")]
	private static BEBENIDDDFC DEPGNIJCOGD(BEBENIDDDFC DOAIHCCMJDP)
	{
		return default(BEBENIDDDFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x65761D0", Offset = "0x65751D0", VA = "0x1865761D0")]
	private static BEBENIDDDFC AMNFJECEIDC(BEBENIDDDFC DOAIHCCMJDP)
	{
		return default(BEBENIDDDFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6577510", Offset = "0x6576510", VA = "0x186577510")]
	private static void MOOIEDMKEBA(BEBENIDDDFC DOAIHCCMJDP, int BOADFOCDLAN, byte[] LGCNCFPFDFA, [Out] int DINHGPLBJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x65762B0", Offset = "0x65752B0", VA = "0x1865762B0")]
	private static void CKBJKIGHMKP(BEBENIDDDFC DOAIHCCMJDP, int BOADFOCDLAN, byte[] JMBGNOKHINL, int KBMGLCGAJPJ, [Out] BEBENIDDDFC EDPPMCEDPBC, [Out] int MHACINMKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6576940", Offset = "0x6575940", VA = "0x186576940")]
	private static ulong GABCHIEJLMP(BEBENIDDDFC DOAIHCCMJDP, [Out] int GNDKJBNONGP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6576CA0", Offset = "0x6575CA0", VA = "0x186576CA0")]
	private static void IIIBIHLCGPJ(BEBENIDDDFC DOAIHCCMJDP, [Out] OGFGKAJFGAM BBMBCGDLBEE, [Out] int GAPECBGKDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x65776C0", Offset = "0x65766C0", VA = "0x1865776C0")]
	private static bool NEIOBOPNJHE(BEBENIDDDFC EDPPMCEDPBC, int BOADFOCDLAN, [Out] double BBMBCGDLBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x65767A0", Offset = "0x65757A0", VA = "0x1865767A0")]
	private static OGFGKAJFGAM FLMKDDIFFAP(int BOADFOCDLAN)
	{
		return default(OGFGKAJFGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6576DE0", Offset = "0x6575DE0", VA = "0x186576DE0")]
	private static bool KOCNMOIGCID(BEBENIDDDFC DOAIHCCMJDP, int BOADFOCDLAN, [Out] double BBMBCGDLBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6576680", Offset = "0x6575680", VA = "0x186576680")]
	private static bool FADHEBJKKOF(BEBENIDDDFC EDPPMCEDPBC, int BOADFOCDLAN, [Out] double NJCBJIHBBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x65775A0", Offset = "0x65765A0", VA = "0x1865775A0")]
	public static double? NDFAPHGEGHJ(BEBENIDDDFC DOAIHCCMJDP, int BOADFOCDLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65769D0", Offset = "0x65759D0", VA = "0x1865769D0")]
	public static float? GMPPKGLNAOP(BEBENIDDDFC DOAIHCCMJDP, int BOADFOCDLAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct CPMOFFPKNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] DOAIHCCMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int ODJLNMBFCPC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6580B10", Offset = "0x657FB10", VA = "0x186580B10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1717410", Offset = "0x1716410", VA = "0x181717410")]
	public CPMOFFPKNBE(byte[] DOAIHCCMJDP, int ODJLNMBFCPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6580BF0", Offset = "0x657FBF0", VA = "0x186580BF0")]
	public static CPMOFFPKNBE NFCNEJGMONE(CPMOFFPKNBE IEOMMHOPOKN)
	{
		return default(CPMOFFPKNBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6580AC0", Offset = "0x657FAC0", VA = "0x186580AC0")]
	public static CPMOFFPKNBE EGKJMLDOOLE(CPMOFFPKNBE IEOMMHOPOKN, int EHBIPHOJPOK)
	{
		return default(CPMOFFPKNBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6580C00", Offset = "0x657FC00", VA = "0x186580C00")]
	public static int NMDCPAPKCIE(CPMOFFPKNBE LJNLOLDLJAJ, CPMOFFPKNBE AHGDCNHHAHG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6580BB0", Offset = "0x657FBB0", VA = "0x186580BB0")]
	public static bool LICIMLDMCMN(CPMOFFPKNBE LJNLOLDLJAJ, CPMOFFPKNBE AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6580BA0", Offset = "0x657FBA0", VA = "0x186580BA0")]
	public static bool JNBEKHIMJBJ(CPMOFFPKNBE LJNLOLDLJAJ, CPMOFFPKNBE AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6580BC0", Offset = "0x657FBC0", VA = "0x186580BC0")]
	public static bool LICIMLDMCMN(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6580B70", Offset = "0x657FB70", VA = "0x186580B70")]
	public static bool JNBEKHIMJBJ(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6580B70", Offset = "0x657FB70", VA = "0x186580B70")]
	public static bool JNBEKHIMJBJ(CPMOFFPKNBE LJNLOLDLJAJ, byte AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6580A90", Offset = "0x657FA90", VA = "0x186580A90")]
	public static bool CDOANEKCJEF(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6580A60", Offset = "0x657FA60", VA = "0x186580A60")]
	public static bool BPFMKMBKMBG(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6580A30", Offset = "0x657FA30", VA = "0x186580A30")]
	public static bool AJODONENPII(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6580B40", Offset = "0x657FB40", VA = "0x186580B40")]
	public static bool JJKNDINFLFH(CPMOFFPKNBE LJNLOLDLJAJ, char AHGDCNHHAHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class LCOHIDGAALK
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] ADJIAOLOGCN;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] IBLOLMEOLJA;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] PHNKFEOICKD;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] EBONCHHMMFG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] BFLMEKNJJFD;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int BOKJNAJDOHI;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] LIFNIFIEMDK;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int AAEIHFBMPLK;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x658A950", Offset = "0x6589950", VA = "0x18658A950")]
	private static byte[] MIADJIPFNMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x658A560", Offset = "0x6589560", VA = "0x18658A560")]
	private static byte[] CACKCLOFIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x658A8A0", Offset = "0x65898A0", VA = "0x18658A8A0")]
	public static double LIAAMBGHKDH(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x658A7F0", Offset = "0x65897F0", VA = "0x18658A7F0")]
	public static float KAPNOJOOJPO(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, [Out] int IIHADFNNOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x658A690", Offset = "0x6589690", VA = "0x18658A690")]
	private static bool FCIMONIBPBC(int LNKHMLIBJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x658AB00", Offset = "0x6589B00", VA = "0x18658AB00")]
	private static bool PNNJBLJCCDL(CPMOFFPKNBE APFFGFDJGLJ, CPMOFFPKNBE HGIJPKEDKIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x658AA30", Offset = "0x6589A30", VA = "0x18658AA30")]
	private static bool OLLKJMALAKE(CPMOFFPKNBE APFFGFDJGLJ, CPMOFFPKNBE HGIJPKEDKIN, byte[] CEPOCHMMHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x658A640", Offset = "0x6589640", VA = "0x18658A640")]
	private static bool DAMNIHMIEOF(CPMOFFPKNBE JPHNCHLPBGD, byte[] CINODLDMGAP, int ODJLNMBFCPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x658A7D0", Offset = "0x65897D0", VA = "0x18658A7D0")]
	private static double FLKBAMDFJCB(bool MIGPGIMLCEH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65896E0", Offset = "0x65886E0", VA = "0x1865896E0")]
	private static double AGBEKHMMGEE(CPMOFFPKNBE JPKFBEJOHFJ, int EHBIPHOJPOK, bool GOPCECLJOEF, [Out] int MPEHANGKCJH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class HPMHNLNMOND<T> : DFIHLHFFLJJ<T[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly OBAHDDGMLHI<T> GIJOGFJOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly OJFNKMFJJKC NNKDBDDHPKP;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x345E0B0", Offset = "0x345D0B0", VA = "0x18345E0B0")]
	public HPMHNLNMOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
	public HPMHNLNMOND(OJFNKMFJJKC NNKDBDDHPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x36A2920", Offset = "0x36A1920", VA = "0x1836A2920", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x36A0E70", Offset = "0x369FE70", VA = "0x1836A0E70", Slot = "5")]
	public T[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class JCGOKPGJDKL<T> : DFIHLHFFLJJ<ArraySegment<T>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly OBAHDDGMLHI<T> GIJOGFJOPIF;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x38CE640", Offset = "0x38CD640", VA = "0x1838CE640", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ArraySegment<T> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x38CE220", Offset = "0x38CD220", VA = "0x1838CE220", Slot = "5")]
	public ArraySegment<T> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class BEPOMIHJAJM<T> : DFIHLHFFLJJ<List<T>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly OJFNKMFJJKC NNKDBDDHPKP;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x345E0B0", Offset = "0x345D0B0", VA = "0x18345E0B0")]
	public BEPOMIHJAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
	public BEPOMIHJAJM(OJFNKMFJJKC NNKDBDDHPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x453AAC0", Offset = "0x4539AC0", VA = "0x18453AAC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, List<T> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4537A50", Offset = "0x4536A50", VA = "0x184537A50", Slot = "5")]
	public List<T> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class KELKKNDBKNB<TElement, TIntermediate, TEnumerator, TCollection> : DFIHLHFFLJJ<TCollection>, MFLDAMIDLGH where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3966A60", Offset = "0x3965A60", VA = "0x183966A60", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, TCollection APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x39654E0", Offset = "0x39644E0", VA = "0x1839654E0", Slot = "5")]
	public TCollection AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator MBDGDOAMMHF(TCollection ONDDMEPBDDI);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BJANKEDJCNP();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GPDFOMDKBKK(TIntermediate AJJNJLOIDBF, int NFJIPMHILEL, TElement APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection FAMMDIJKGAD(TIntermediate CDFMOMKELDI);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected KELKKNDBKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GEEMIAJHCOG<TElement, TIntermediate, TCollection> : KELKKNDBKNB<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x350C430", Offset = "0x350B430", VA = "0x18350C430", Slot = "6")]
	protected override IEnumerator<TElement> MBDGDOAMMHF(TCollection ONDDMEPBDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30B65C0", Offset = "0x30B55C0", VA = "0x1830B65C0")]
	protected GEEMIAJHCOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class GCDAKNPDDHA<TElement, TCollection> : GEEMIAJHCOG<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected sealed override TCollection FAMMDIJKGAD(TCollection CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class IOAGPCIEEPO<TElement, TCollection> : GCDAKNPDDHA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3755180", Offset = "0x3754180", VA = "0x183755180", Slot = "7")]
	protected override TCollection BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x37551B0", Offset = "0x37541B0", VA = "0x1837551B0", Slot = "8")]
	protected override void GPDFOMDKBKK(TCollection AJJNJLOIDBF, int NFJIPMHILEL, TElement APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class CBLKDIAEBPJ<T> : KELKKNDBKNB<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE90", Offset = "0x30FAE90", VA = "0x1830FBE90", Slot = "8")]
	protected override void GPDFOMDKBKK(LinkedList<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override LinkedList<T> FAMMDIJKGAD(LinkedList<T> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override LinkedList<T> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x360A7D0", Offset = "0x36097D0", VA = "0x18360A7D0", Slot = "6")]
	protected override LinkedList<T>.Enumerator MBDGDOAMMHF(LinkedList<T> ONDDMEPBDDI)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class OBPDJNJCBOL<T> : KELKKNDBKNB<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE90", Offset = "0x30FAE90", VA = "0x1830FBE90", Slot = "8")]
	protected override void GPDFOMDKBKK(Queue<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override Queue<T> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3DF59C0", Offset = "0x3DF49C0", VA = "0x183DF59C0", Slot = "6")]
	protected override Queue<T>.Enumerator MBDGDOAMMHF(Queue<T> ONDDMEPBDDI)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override Queue<T> FAMMDIJKGAD(Queue<T> CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class DJDDLHOJOBA<T> : KELKKNDBKNB<T, MKHOBMMGGLM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8830", Offset = "0x3CC7830", VA = "0x183CC8830", Slot = "8")]
	protected override void GPDFOMDKBKK(MKHOBMMGGLM<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87D0", Offset = "0x3CC77D0", VA = "0x183CC87D0", Slot = "7")]
	protected override MKHOBMMGGLM<T> BJANKEDJCNP()
	{
		return default(MKHOBMMGGLM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4FA0", Offset = "0x4DB3FA0", VA = "0x184DB4FA0", Slot = "6")]
	protected override Stack<T>.Enumerator MBDGDOAMMHF(Stack<T> ONDDMEPBDDI)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4EC0", Offset = "0x4DB3EC0", VA = "0x184DB4EC0", Slot = "9")]
	protected override Stack<T> FAMMDIJKGAD(MKHOBMMGGLM<T> CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class BMLNOCEPOHE<T> : KELKKNDBKNB<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE90", Offset = "0x30FAE90", VA = "0x1830FBE90", Slot = "8")]
	protected override void GPDFOMDKBKK(HashSet<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override HashSet<T> FAMMDIJKGAD(HashSet<T> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override HashSet<T> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF59C0", Offset = "0x3DF49C0", VA = "0x183DF59C0", Slot = "6")]
	protected override HashSet<T>.Enumerator MBDGDOAMMHF(HashSet<T> ONDDMEPBDDI)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class MPLNLABPBCN<T> : GEEMIAJHCOG<T, MKHOBMMGGLM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8830", Offset = "0x3CC7830", VA = "0x183CC8830", Slot = "8")]
	protected override void GPDFOMDKBKK(MKHOBMMGGLM<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD450", Offset = "0x3CCC450", VA = "0x183CCD450", Slot = "9")]
	protected override ReadOnlyCollection<T> FAMMDIJKGAD(MKHOBMMGGLM<T> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD410", Offset = "0x3CCC410", VA = "0x183CCD410", Slot = "7")]
	protected override MKHOBMMGGLM<T> BJANKEDJCNP()
	{
		return default(MKHOBMMGGLM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class EFCLPHPBHPE<T> : GEEMIAJHCOG<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE90", Offset = "0x30FAE90", VA = "0x1830FBE90", Slot = "8")]
	protected override void GPDFOMDKBKK(List<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override List<T> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override IList<T> FAMMDIJKGAD(List<T> CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AGNLPBAJCLC<T> : GEEMIAJHCOG<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE90", Offset = "0x30FAE90", VA = "0x1830FBE90", Slot = "8")]
	protected override void GPDFOMDKBKK(List<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override List<T> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override ICollection<T> FAMMDIJKGAD(List<T> CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MPBHDNGDIDK<T> : GEEMIAJHCOG<T, MKHOBMMGGLM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8830", Offset = "0x3CC7830", VA = "0x183CC8830", Slot = "8")]
	protected override void GPDFOMDKBKK(MKHOBMMGGLM<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87D0", Offset = "0x3CC77D0", VA = "0x183CC87D0", Slot = "7")]
	protected override MKHOBMMGGLM<T> BJANKEDJCNP()
	{
		return default(MKHOBMMGGLM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8810", Offset = "0x3CC7810", VA = "0x183CC8810", Slot = "9")]
	protected override IEnumerable<T> FAMMDIJKGAD(MKHOBMMGGLM<T> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30C3FC0", Offset = "0x30C2FC0", VA = "0x1830C3FC0")]
	public MPBHDNGDIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class LIGMJCDEJAJ<TKey, TElement> : DFIHLHFFLJJ<IGrouping<TKey, TElement>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3A81940", Offset = "0x3A80940", VA = "0x183A81940", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, IGrouping<TKey, TElement> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3A81640", Offset = "0x3A80640", VA = "0x183A81640", Slot = "5")]
	public IGrouping<TKey, TElement> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class LFMGFAOLDDM<TKey, TElement> : DFIHLHFFLJJ<ILookup<TKey, TElement>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B5E0", Offset = "0x3A7A5E0", VA = "0x183A7B5E0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ILookup<TKey, TElement> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B290", Offset = "0x3A7A290", VA = "0x183A7B290", Slot = "5")]
	public ILookup<TKey, TElement> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class PBICPBGEDDD<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey BGNGIHJEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> DHAGBOIMPBD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey NNFEBNLDCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public PBICPBGEDDD(TKey BGNGIHJEFLM, IEnumerable<TElement> DHAGBOIMPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F240", Offset = "0x3E9E240", VA = "0x183E9F240", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3162080", Offset = "0x3161080", VA = "0x183162080", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class IDNEBIMGJFH<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> ALEABGHDIGG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x311EF70", Offset = "0x311DF70", VA = "0x18311EF70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public IDNEBIMGJFH(Dictionary<TKey, IGrouping<TKey, TElement>> ALEABGHDIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x372B970", Offset = "0x372A970", VA = "0x18372B970", Slot = "5")]
	public bool Contains(TKey BGNGIHJEFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x372B9B0", Offset = "0x372A9B0", VA = "0x18372B9B0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x372B9B0", Offset = "0x372A9B0", VA = "0x18372B9B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class AAIOIIIPFGI<T> : DFIHLHFFLJJ<T>, MFLDAMIDLGH where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x34D8DC0", Offset = "0x34D7DC0", VA = "0x1834D8DC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x34D8B40", Offset = "0x34D7B40", VA = "0x1834D8B40", Slot = "5")]
	public T AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AAIOIIIPFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class POAAJCDDNAM : DFIHLHFFLJJ<IEnumerable>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly DFIHLHFFLJJ<IEnumerable> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65908A0", Offset = "0x658F8A0", VA = "0x1865908A0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, IEnumerable APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6590650", Offset = "0x658F650", VA = "0x186590650", Slot = "5")]
	public IEnumerable AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public POAAJCDDNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class DBNOIOGAEJH : DFIHLHFFLJJ<ICollection>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly DFIHLHFFLJJ<ICollection> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6580E60", Offset = "0x657FE60", VA = "0x186580E60", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ICollection APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6580C10", Offset = "0x657FC10", VA = "0x186580C10", Slot = "5")]
	public ICollection AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DBNOIOGAEJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NDPCFMFGPAH : DFIHLHFFLJJ<IList>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly DFIHLHFFLJJ<IList> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x658DFC0", Offset = "0x658CFC0", VA = "0x18658DFC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, IList APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x658DD70", Offset = "0x658CD70", VA = "0x18658DD70", Slot = "5")]
	public IList AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NDPCFMFGPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class MPNCECCHBPN<T> : GEEMIAJHCOG<T, MKHOBMMGGLM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD540", Offset = "0x3CCC540", VA = "0x183CCD540", Slot = "8")]
	protected override void GPDFOMDKBKK(MKHOBMMGGLM<T> AJJNJLOIDBF, int NFJIPMHILEL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87D0", Offset = "0x3CC77D0", VA = "0x183CC87D0", Slot = "7")]
	protected override MKHOBMMGGLM<T> BJANKEDJCNP()
	{
		return default(MKHOBMMGGLM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD4F0", Offset = "0x3CCC4F0", VA = "0x183CCD4F0", Slot = "9")]
	protected override IReadOnlyList<T> FAMMDIJKGAD(MKHOBMMGGLM<T> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30C3960", Offset = "0x30C2960", VA = "0x1830C3960")]
	public MPNCECCHBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class PGGKFOECJJE
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x658FB90", Offset = "0x658EB90", VA = "0x18658FB90")]
	public static DateTime PKPIIGIPAEL(DateTime MPECECPAIGG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class HENJHLBLFAH : DFIHLHFFLJJ<DateTime>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly DFIHLHFFLJJ<DateTime> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6585D50", Offset = "0x6584D50", VA = "0x186585D50", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, DateTime APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6585040", Offset = "0x6584040", VA = "0x186585040", Slot = "5")]
	public DateTime AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HENJHLBLFAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class LFMCLHKHEDG : DFIHLHFFLJJ<DateTimeOffset>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly DFIHLHFFLJJ<DateTimeOffset> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x658C2D0", Offset = "0x658B2D0", VA = "0x18658C2D0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, DateTimeOffset APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x658B6B0", Offset = "0x658A6B0", VA = "0x18658B6B0", Slot = "5")]
	public DateTimeOffset AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LFMCLHKHEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class NMHILOLNHHC : DFIHLHFFLJJ<TimeSpan>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly DFIHLHFFLJJ<TimeSpan> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] LPEMILIOCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x658EDD0", Offset = "0x658DDD0", VA = "0x18658EDD0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, TimeSpan APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x658E4C0", Offset = "0x658D4C0", VA = "0x18658E4C0", Slot = "5")]
	public TimeSpan AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NMHILOLNHHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class NLEAACKPNAB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : DFIHLHFFLJJ<TDictionary>, MFLDAMIDLGH where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B8E0", Offset = "0x3D2A8E0", VA = "0x183D2B8E0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, TDictionary APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B4B0", Offset = "0x3D2A4B0", VA = "0x183D2B4B0", Slot = "5")]
	public TDictionary AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator MBDGDOAMMHF(TDictionary ONDDMEPBDDI);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate BJANKEDJCNP();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GPDFOMDKBKK(TIntermediate AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary FAMMDIJKGAD(TIntermediate CDFMOMKELDI);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected NLEAACKPNAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class CDMIAGOAEBG<TKey, TValue, TIntermediate, TDictionary> : NLEAACKPNAB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x350C430", Offset = "0x350B430", VA = "0x18350C430", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> MBDGDOAMMHF(TDictionary ONDDMEPBDDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class DLIAMNLFKJF<TKey, TValue, TDictionary> : CDMIAGOAEBG<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override TDictionary FAMMDIJKGAD(TDictionary CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class HEKDGFCJHMP<TKey, TValue> : NLEAACKPNAB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x360A6E0", Offset = "0x36096E0", VA = "0x18360A6E0", Slot = "8")]
	protected override void GPDFOMDKBKK(Dictionary<TKey, TValue> AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override Dictionary<TKey, TValue> FAMMDIJKGAD(Dictionary<TKey, TValue> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override Dictionary<TKey, TValue> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x360A840", Offset = "0x3609840", VA = "0x18360A840", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator MBDGDOAMMHF(Dictionary<TKey, TValue> ONDDMEPBDDI)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30B58B0", Offset = "0x30B48B0", VA = "0x1830B58B0")]
	public HEKDGFCJHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class GEDDICDLELE<TKey, TValue, TDictionary> : DLIAMNLFKJF<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x350C000", Offset = "0x350B000", VA = "0x18350C000", Slot = "8")]
	protected override void GPDFOMDKBKK(TDictionary AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F69C50", Offset = "0x2F68C50", VA = "0x182F69C50", Slot = "7")]
	protected override TDictionary BJANKEDJCNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BHEHLONIIDN<TKey, TValue> : CDMIAGOAEBG<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x311EFB0", Offset = "0x311DFB0", VA = "0x18311EFB0", Slot = "8")]
	protected override void GPDFOMDKBKK(Dictionary<TKey, TValue> AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override Dictionary<TKey, TValue> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override IDictionary<TKey, TValue> FAMMDIJKGAD(Dictionary<TKey, TValue> CDFMOMKELDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EONAMOKNGJC<TKey, TValue> : DLIAMNLFKJF<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x311EFB0", Offset = "0x311DFB0", VA = "0x18311EFB0", Slot = "8")]
	protected override void GPDFOMDKBKK(SortedList<TKey, TValue> AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override SortedList<TKey, TValue> BJANKEDJCNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class BPPJCBIOKDB<TKey, TValue> : NLEAACKPNAB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x311EFB0", Offset = "0x311DFB0", VA = "0x18311EFB0", Slot = "8")]
	protected override void GPDFOMDKBKK(SortedDictionary<TKey, TValue> AJJNJLOIDBF, int NFJIPMHILEL, TKey BGNGIHJEFLM, TValue APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xCD2F70", Offset = "0xCD1F70", VA = "0x180CD2F70", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> FAMMDIJKGAD(SortedDictionary<TKey, TValue> CDFMOMKELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x30FBE20", Offset = "0x30FAE20", VA = "0x1830FBE20", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> BJANKEDJCNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x360A840", Offset = "0x3609840", VA = "0x18360A840", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator MBDGDOAMMHF(SortedDictionary<TKey, TValue> ONDDMEPBDDI)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class MFDACFKENEJ<T> : DFIHLHFFLJJ<T>, MFLDAMIDLGH where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3C78EB0", Offset = "0x3C77EB0", VA = "0x183C78EB0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3C78C10", Offset = "0x3C77C10", VA = "0x183C78C10", Slot = "5")]
	public T AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MFDACFKENEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class EKJNGFOIGFG : DFIHLHFFLJJ<IDictionary>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly DFIHLHFFLJJ<IDictionary> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65838D0", Offset = "0x65828D0", VA = "0x1865838D0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, IDictionary APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65836A0", Offset = "0x65826A0", VA = "0x1865836A0", Slot = "5")]
	public IDictionary AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EKJNGFOIGFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class GEDEFHPJODO : DFIHLHFFLJJ<object>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void NICGICBKOII(object LIDNCBMFFFL, FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly FEBBGICKJJF<KeyValuePair<object, NICGICBKOII>> GGCHFFJPINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly NKGJGOEJJEF[] EMKEGCFFFCH;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6584BC0", Offset = "0x6583BC0", VA = "0x186584BC0")]
	public GEDEFHPJODO(params NKGJGOEJJEF[] EMKEGCFFFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6584200", Offset = "0x6583200", VA = "0x186584200", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6584170", Offset = "0x6583170", VA = "0x186584170", Slot = "5")]
	public object AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class AHNANMDIOJL
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x657DBC0", Offset = "0x657CBC0", VA = "0x18657DBC0")]
	public static object FJPFPKEDDOC(Type CFGJPNBLNDJ, [Out] bool HLHAACMLPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x657E4B0", Offset = "0x657D4B0", VA = "0x18657E4B0")]
	public static object OKMEGCIOKBJ(Type CFGJPNBLNDJ, [Out] bool HLHAACMLPFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class PONEKODBLAC<T> : DFIHLHFFLJJ<T>, MFLDAMIDLGH, FKAHDAKOENB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class AHELKLHHHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public AHELKLHHHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x355CF60", Offset = "0x355BF60", VA = "0x18355CF60")]
		internal bool PPMBJGADDJN(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class HEEAOJAAOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HEEAOJAAOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3607AC0", Offset = "0x3606AC0", VA = "0x183607AC0")]
		internal bool KLMFGDGBLJJ(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class EGCKDDIBLMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public HIDJCIIGAHK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public EGCKDDIBLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x30FC610", Offset = "0x30FB610", VA = "0x1830FC610")]
		internal void MLMJBNBPGAM(FMIKPDPOMJO writer, T value, NKGJGOEJJEF _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class DJGDEHKEEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LBPGPJMGOHK<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public DJGDEHKEEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DB5A90", Offset = "0x4DB4A90", VA = "0x184DB5A90")]
		internal T DBLGDCOEOBB(EDCKLMDDAAM reader, NKGJGOEJJEF _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly MDMKJJIBAAE<T> INMHLMDLJFF;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> NDGCNKJDNAK;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly HIDJCIIGAHK<T> CLGMCJJDDIP;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly LBPGPJMGOHK<T> DAFCAMNIDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool BMHFJIGAKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly HIDJCIIGAHK<T> AFOBHOOJGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly LBPGPJMGOHK<T> HJFADOJIEKJ;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EDCAE0", Offset = "0x3EDBAE0", VA = "0x183EDCAE0")]
	static PONEKODBLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EEDD30", Offset = "0x3EECD30", VA = "0x183EEDD30")]
	public PONEKODBLAC(bool BMHFJIGAKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4E40", Offset = "0x3ED3E40", VA = "0x183ED4E40", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1520", Offset = "0x3ED0520", VA = "0x183ED1520", Slot = "5")]
	public T AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3EC0", Offset = "0x3ED2EC0", VA = "0x183ED3EC0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, T APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3410", Offset = "0x3ED2410", VA = "0x183ED3410", Slot = "7")]
	public T DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GJFCGNKPEDK<T> : DFIHLHFFLJJ<T[,]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x35310B0", Offset = "0x35300B0", VA = "0x1835310B0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T[,] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3530D80", Offset = "0x352FD80", VA = "0x183530D80", Slot = "5")]
	public T[,] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GJFCGNKPEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class ALIHMENOPPE<T> : DFIHLHFFLJJ<T[,,]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x365C8E0", Offset = "0x365B8E0", VA = "0x18365C8E0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T[,,] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x365C4A0", Offset = "0x365B4A0", VA = "0x18365C4A0", Slot = "5")]
	public T[,,] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ALIHMENOPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class PBNEOFLACDP<T> : DFIHLHFFLJJ<T[,,,]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E9FD60", Offset = "0x3E9ED60", VA = "0x183E9FD60", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T[,,,] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F810", Offset = "0x3E9E810", VA = "0x183E9F810", Slot = "5")]
	public T[,,,] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PBNEOFLACDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class KOMJPBKBNOI<T> : DFIHLHFFLJJ<T?>, MFLDAMIDLGH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x39DAEC0", Offset = "0x39D9EC0", VA = "0x1839DAEC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x39DAD40", Offset = "0x39D9D40", VA = "0x1839DAD40", Slot = "5")]
	public T? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KOMJPBKBNOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class MFJEPKLABCH<T> : DFIHLHFFLJJ<T?>, MFLDAMIDLGH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly DFIHLHFFLJJ<T> DPENIAELOPC;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public MFJEPKLABCH(DFIHLHFFLJJ<T> DPENIAELOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3C81C30", Offset = "0x3C80C30", VA = "0x183C81C30", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, T? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C80B10", Offset = "0x3C7FB10", VA = "0x183C80B10", Slot = "5")]
	public T? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class AIICCNIKGFG : DFIHLHFFLJJ<sbyte>, MFLDAMIDLGH, FKAHDAKOENB<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly AIICCNIKGFG ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x657EF20", Offset = "0x657DF20", VA = "0x18657EF20", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, sbyte APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x657EDA0", Offset = "0x657DDA0", VA = "0x18657EDA0", Slot = "5")]
	public sbyte AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x657EEB0", Offset = "0x657DEB0", VA = "0x18657EEB0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, sbyte APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x657EDF0", Offset = "0x657DDF0", VA = "0x18657EDF0", Slot = "7")]
	public sbyte DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AIICCNIKGFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class PNGACPGEELA : DFIHLHFFLJJ<sbyte?>, MFLDAMIDLGH, FKAHDAKOENB<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly PNGACPGEELA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6590510", Offset = "0x658F510", VA = "0x186590510", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, sbyte? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6590280", Offset = "0x658F280", VA = "0x186590280", Slot = "5")]
	public sbyte? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6590450", Offset = "0x658F450", VA = "0x186590450", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, sbyte? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6590330", Offset = "0x658F330", VA = "0x186590330", Slot = "7")]
	public sbyte? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PNGACPGEELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class EBICNGHFFPI : DFIHLHFFLJJ<sbyte[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly EBICNGHFFPI ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6582840", Offset = "0x6581840", VA = "0x186582840", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, sbyte[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65826B0", Offset = "0x65816B0", VA = "0x1865826B0", Slot = "5")]
	public sbyte[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EBICNGHFFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class OOHDPJKBAFK : DFIHLHFFLJJ<short>, MFLDAMIDLGH, FKAHDAKOENB<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly OOHDPJKBAFK ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x658FAB0", Offset = "0x658EAB0", VA = "0x18658FAB0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, short APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x658F930", Offset = "0x658E930", VA = "0x18658F930", Slot = "5")]
	public short AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x658FA40", Offset = "0x658EA40", VA = "0x18658FA40", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, short APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x658F980", Offset = "0x658E980", VA = "0x18658F980", Slot = "7")]
	public short DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OOHDPJKBAFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class LENGMHNDPJO : DFIHLHFFLJJ<short?>, MFLDAMIDLGH, FKAHDAKOENB<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly LENGMHNDPJO ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x658B570", Offset = "0x658A570", VA = "0x18658B570", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, short? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x658B2E0", Offset = "0x658A2E0", VA = "0x18658B2E0", Slot = "5")]
	public short? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x658B4B0", Offset = "0x658A4B0", VA = "0x18658B4B0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, short? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x658B390", Offset = "0x658A390", VA = "0x18658B390", Slot = "7")]
	public short? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LENGMHNDPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CPALHCMNMLA : DFIHLHFFLJJ<short[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly CPALHCMNMLA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6580880", Offset = "0x657F880", VA = "0x186580880", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, short[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65806F0", Offset = "0x657F6F0", VA = "0x1865806F0", Slot = "5")]
	public short[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public CPALHCMNMLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class OBEENKIFNMK : DFIHLHFFLJJ<int>, MFLDAMIDLGH, FKAHDAKOENB<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly OBEENKIFNMK ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x658F490", Offset = "0x658E490", VA = "0x18658F490", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, int APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x658F310", Offset = "0x658E310", VA = "0x18658F310", Slot = "5")]
	public int AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x658F420", Offset = "0x658E420", VA = "0x18658F420", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, int APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x658F360", Offset = "0x658E360", VA = "0x18658F360", Slot = "7")]
	public int DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OBEENKIFNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class LJMCGCAMIJN : DFIHLHFFLJJ<int?>, MFLDAMIDLGH, FKAHDAKOENB<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LJMCGCAMIJN ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x658D080", Offset = "0x658C080", VA = "0x18658D080", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, int? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x658CDF0", Offset = "0x658BDF0", VA = "0x18658CDF0", Slot = "5")]
	public int? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x658CFC0", Offset = "0x658BFC0", VA = "0x18658CFC0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, int? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x658CEA0", Offset = "0x658BEA0", VA = "0x18658CEA0", Slot = "7")]
	public int? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LJMCGCAMIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class EAOBKHIBDAG : DFIHLHFFLJJ<int[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EAOBKHIBDAG ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6582500", Offset = "0x6581500", VA = "0x186582500", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, int[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6582370", Offset = "0x6581370", VA = "0x186582370", Slot = "5")]
	public int[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EAOBKHIBDAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class ALCACAILGBE : DFIHLHFFLJJ<long>, MFLDAMIDLGH, FKAHDAKOENB<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly ALCACAILGBE ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x657F180", Offset = "0x657E180", VA = "0x18657F180", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, long APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x657F000", Offset = "0x657E000", VA = "0x18657F000", Slot = "5")]
	public long AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x657F110", Offset = "0x657E110", VA = "0x18657F110", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, long APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x657F050", Offset = "0x657E050", VA = "0x18657F050", Slot = "7")]
	public long DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ALCACAILGBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class CJBMCIPEPOA : DFIHLHFFLJJ<long?>, MFLDAMIDLGH, FKAHDAKOENB<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CJBMCIPEPOA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65805B0", Offset = "0x657F5B0", VA = "0x1865805B0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, long? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65802F0", Offset = "0x657F2F0", VA = "0x1865802F0", Slot = "5")]
	public long? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65804F0", Offset = "0x657F4F0", VA = "0x1865804F0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, long? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65803B0", Offset = "0x657F3B0", VA = "0x1865803B0", Slot = "7")]
	public long? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public CJBMCIPEPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class MPMBFOGLBDM : DFIHLHFFLJJ<long[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MPMBFOGLBDM ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x658DBC0", Offset = "0x658CBC0", VA = "0x18658DBC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, long[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x658DA30", Offset = "0x658CA30", VA = "0x18658DA30", Slot = "5")]
	public long[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MPMBFOGLBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class ECCOJEEEAFB : DFIHLHFFLJJ<byte>, MFLDAMIDLGH, FKAHDAKOENB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly ECCOJEEEAFB ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6582EE0", Offset = "0x6581EE0", VA = "0x186582EE0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, byte APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6582D60", Offset = "0x6581D60", VA = "0x186582D60", Slot = "5")]
	public byte AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6582E70", Offset = "0x6581E70", VA = "0x186582E70", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, byte APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6582DB0", Offset = "0x6581DB0", VA = "0x186582DB0", Slot = "7")]
	public byte DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public ECCOJEEEAFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PIICFKCCOBG : DFIHLHFFLJJ<byte?>, MFLDAMIDLGH, FKAHDAKOENB<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PIICFKCCOBG ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6590140", Offset = "0x658F140", VA = "0x186590140", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, byte? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x658FEB0", Offset = "0x658EEB0", VA = "0x18658FEB0", Slot = "5")]
	public byte? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6590080", Offset = "0x658F080", VA = "0x186590080", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, byte? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x658FF60", Offset = "0x658EF60", VA = "0x18658FF60", Slot = "7")]
	public byte? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PIICFKCCOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class AOODMCEHLKF : DFIHLHFFLJJ<ushort>, MFLDAMIDLGH, FKAHDAKOENB<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly AOODMCEHLKF ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x657F640", Offset = "0x657E640", VA = "0x18657F640", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ushort APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x657F4C0", Offset = "0x657E4C0", VA = "0x18657F4C0", Slot = "5")]
	public ushort AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x657F5D0", Offset = "0x657E5D0", VA = "0x18657F5D0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, ushort APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x657F510", Offset = "0x657E510", VA = "0x18657F510", Slot = "7")]
	public ushort DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AOODMCEHLKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KPCFHLFKAEJ : DFIHLHFFLJJ<ushort?>, MFLDAMIDLGH, FKAHDAKOENB<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly KPCFHLFKAEJ ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6588F10", Offset = "0x6587F10", VA = "0x186588F10", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ushort? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6588C80", Offset = "0x6587C80", VA = "0x186588C80", Slot = "5")]
	public ushort? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6588E50", Offset = "0x6587E50", VA = "0x186588E50", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, ushort? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x6588D30", Offset = "0x6587D30", VA = "0x186588D30", Slot = "7")]
	public ushort? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KPCFHLFKAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class JKLMIOAMHCE : DFIHLHFFLJJ<ushort[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly JKLMIOAMHCE ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6586EE0", Offset = "0x6585EE0", VA = "0x186586EE0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ushort[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6586D50", Offset = "0x6585D50", VA = "0x186586D50", Slot = "5")]
	public ushort[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public JKLMIOAMHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class AMGBAGFNIGE : DFIHLHFFLJJ<uint>, MFLDAMIDLGH, FKAHDAKOENB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly AMGBAGFNIGE ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x657F3E0", Offset = "0x657E3E0", VA = "0x18657F3E0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, uint APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x657F260", Offset = "0x657E260", VA = "0x18657F260", Slot = "5")]
	public uint AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x657F370", Offset = "0x657E370", VA = "0x18657F370", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, uint APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x657F2B0", Offset = "0x657E2B0", VA = "0x18657F2B0", Slot = "7")]
	public uint DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AMGBAGFNIGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class DHFHGHNPDGB : DFIHLHFFLJJ<uint?>, MFLDAMIDLGH, FKAHDAKOENB<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly DHFHGHNPDGB ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6581930", Offset = "0x6580930", VA = "0x186581930", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, uint? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65816A0", Offset = "0x65806A0", VA = "0x1865816A0", Slot = "5")]
	public uint? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6581870", Offset = "0x6580870", VA = "0x186581870", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, uint? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6581750", Offset = "0x6580750", VA = "0x186581750", Slot = "7")]
	public uint? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DHFHGHNPDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class FBCMICILMAM : DFIHLHFFLJJ<uint[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FBCMICILMAM ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6583FC0", Offset = "0x6582FC0", VA = "0x186583FC0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, uint[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6583E30", Offset = "0x6582E30", VA = "0x186583E30", Slot = "5")]
	public uint[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FBCMICILMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class BHHJNKIAOBN : DFIHLHFFLJJ<ulong>, MFLDAMIDLGH, FKAHDAKOENB<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BHHJNKIAOBN ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x657FE10", Offset = "0x657EE10", VA = "0x18657FE10", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ulong APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x657FC90", Offset = "0x657EC90", VA = "0x18657FC90", Slot = "5")]
	public ulong AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x657FDA0", Offset = "0x657EDA0", VA = "0x18657FDA0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, ulong APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x657FCE0", Offset = "0x657ECE0", VA = "0x18657FCE0", Slot = "7")]
	public ulong DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BHHJNKIAOBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LHJJILLKBJE : DFIHLHFFLJJ<ulong?>, MFLDAMIDLGH, FKAHDAKOENB<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LHJJILLKBJE ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x658CCB0", Offset = "0x658BCB0", VA = "0x18658CCB0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ulong? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x658C9F0", Offset = "0x658B9F0", VA = "0x18658C9F0", Slot = "5")]
	public ulong? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x658CBF0", Offset = "0x658BBF0", VA = "0x18658CBF0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, ulong? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x658CAB0", Offset = "0x658BAB0", VA = "0x18658CAB0", Slot = "7")]
	public ulong? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LHJJILLKBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class LEDNIOPFLAE : DFIHLHFFLJJ<ulong[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly LEDNIOPFLAE ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x658B130", Offset = "0x658A130", VA = "0x18658B130", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ulong[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x658AFA0", Offset = "0x6589FA0", VA = "0x18658AFA0", Slot = "5")]
	public ulong[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LEDNIOPFLAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class MHIEEJIMGKI : DFIHLHFFLJJ<float>, MFLDAMIDLGH, FKAHDAKOENB<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly MHIEEJIMGKI ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x658D600", Offset = "0x658C600", VA = "0x18658D600", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, float APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x658D480", Offset = "0x658C480", VA = "0x18658D480", Slot = "5")]
	public float AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x658D590", Offset = "0x658C590", VA = "0x18658D590", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, float APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x658D4D0", Offset = "0x658C4D0", VA = "0x18658D4D0", Slot = "7")]
	public float DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MHIEEJIMGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class DNCPAOIBPBC : DFIHLHFFLJJ<float?>, MFLDAMIDLGH, FKAHDAKOENB<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly DNCPAOIBPBC ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6582020", Offset = "0x6581020", VA = "0x186582020", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, float? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6581D90", Offset = "0x6580D90", VA = "0x186581D90", Slot = "5")]
	public float? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6581F60", Offset = "0x6580F60", VA = "0x186581F60", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, float? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6581E40", Offset = "0x6580E40", VA = "0x186581E40", Slot = "7")]
	public float? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DNCPAOIBPBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class MNHFCDLPIGH : DFIHLHFFLJJ<float[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly MNHFCDLPIGH ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x658D870", Offset = "0x658C870", VA = "0x18658D870", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, float[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x658D6E0", Offset = "0x658C6E0", VA = "0x18658D6E0", Slot = "5")]
	public float[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MNHFCDLPIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PHKIALIPJAB : DFIHLHFFLJJ<double>, MFLDAMIDLGH, FKAHDAKOENB<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly PHKIALIPJAB ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x658FDD0", Offset = "0x658EDD0", VA = "0x18658FDD0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, double APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x658FC50", Offset = "0x658EC50", VA = "0x18658FC50", Slot = "5")]
	public double AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x658FD60", Offset = "0x658ED60", VA = "0x18658FD60", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, double APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x658FCA0", Offset = "0x658ECA0", VA = "0x18658FCA0", Slot = "7")]
	public double DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PHKIALIPJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BOIDGGCIMPP : DFIHLHFFLJJ<double?>, MFLDAMIDLGH, FKAHDAKOENB<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly BOIDGGCIMPP ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x65801B0", Offset = "0x657F1B0", VA = "0x1865801B0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, double? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x657FEF0", Offset = "0x657EEF0", VA = "0x18657FEF0", Slot = "5")]
	public double? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65800F0", Offset = "0x657F0F0", VA = "0x1865800F0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, double? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x657FFB0", Offset = "0x657EFB0", VA = "0x18657FFB0", Slot = "7")]
	public double? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BOIDGGCIMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KIKOADIDKIA : DFIHLHFFLJJ<double[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly KIKOADIDKIA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6587420", Offset = "0x6586420", VA = "0x186587420", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, double[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6587290", Offset = "0x6586290", VA = "0x186587290", Slot = "5")]
	public double[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KIKOADIDKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class JKBFDLOGOBK : DFIHLHFFLJJ<bool>, MFLDAMIDLGH, FKAHDAKOENB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly JKBFDLOGOBK ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6586C70", Offset = "0x6585C70", VA = "0x186586C70", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, bool APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6586AF0", Offset = "0x6585AF0", VA = "0x186586AF0", Slot = "5")]
	public bool AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6586C00", Offset = "0x6585C00", VA = "0x186586C00", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, bool APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6586B40", Offset = "0x6585B40", VA = "0x186586B40", Slot = "7")]
	public bool DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public JKBFDLOGOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class GFNCEFPNBIP : DFIHLHFFLJJ<bool?>, MFLDAMIDLGH, FKAHDAKOENB<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly GFNCEFPNBIP ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6584F00", Offset = "0x6583F00", VA = "0x186584F00", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, bool? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6584C70", Offset = "0x6583C70", VA = "0x186584C70", Slot = "5")]
	public bool? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6584E40", Offset = "0x6583E40", VA = "0x186584E40", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, bool? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6584D20", Offset = "0x6583D20", VA = "0x186584D20", Slot = "7")]
	public bool? DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GFNCEFPNBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class IOEDJMBPEIA : DFIHLHFFLJJ<bool[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly IOEDJMBPEIA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6586930", Offset = "0x6585930", VA = "0x186586930", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, bool[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65867A0", Offset = "0x65857A0", VA = "0x1865867A0", Slot = "5")]
	public bool[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public IOEDJMBPEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class KOAKHEHKIFE : DFIHLHFFLJJ<object>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly DFIHLHFFLJJ<object> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> IKADEPCLNBC;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6587A20", Offset = "0x6586A20", VA = "0x186587A20", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, object APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65875E0", Offset = "0x65865E0", VA = "0x1865875E0", Slot = "5")]
	public object AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KOAKHEHKIFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class BGKBPALNOFD : DFIHLHFFLJJ<byte[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly DFIHLHFFLJJ<byte[]> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x657FB50", Offset = "0x657EB50", VA = "0x18657FB50", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, byte[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x657FAA0", Offset = "0x657EAA0", VA = "0x18657FAA0", Slot = "5")]
	public byte[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BGKBPALNOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LNFDIBMAKKE : DFIHLHFFLJJ<ArraySegment<byte>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly DFIHLHFFLJJ<ArraySegment<byte>> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x658D2D0", Offset = "0x658C2D0", VA = "0x18658D2D0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, ArraySegment<byte> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x658D1C0", Offset = "0x658C1C0", VA = "0x18658D1C0", Slot = "5")]
	public ArraySegment<byte> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LNFDIBMAKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class OIEJOFHDMAH : DFIHLHFFLJJ<string>, MFLDAMIDLGH, FKAHDAKOENB<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly DFIHLHFFLJJ<string> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x658F850", Offset = "0x658E850", VA = "0x18658F850", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, string APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x658F750", Offset = "0x658E750", VA = "0x18658F750", Slot = "5")]
	public string AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x658F7F0", Offset = "0x658E7F0", VA = "0x18658F7F0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, string APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x658F7A0", Offset = "0x658E7A0", VA = "0x18658F7A0", Slot = "7")]
	public string DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OIEJOFHDMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class BFOJJDEACCN : DFIHLHFFLJJ<string[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly BFOJJDEACCN ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x657F8F0", Offset = "0x657E8F0", VA = "0x18657F8F0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, string[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x657F720", Offset = "0x657E720", VA = "0x18657F720", Slot = "5")]
	public string[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BFOJJDEACCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class KOELKIHEMAD : DFIHLHFFLJJ<char>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly KOELKIHEMAD ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6588B40", Offset = "0x6587B40", VA = "0x186588B40", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, char APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6588AD0", Offset = "0x6587AD0", VA = "0x186588AD0", Slot = "5")]
	public char AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KOELKIHEMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class LBODEOEHPFI : DFIHLHFFLJJ<char?>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly LBODEOEHPFI ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6589170", Offset = "0x6588170", VA = "0x186589170", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, char? APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6589050", Offset = "0x6588050", VA = "0x186589050", Slot = "5")]
	public char? AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LBODEOEHPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class LCFDLOHIOFJ : DFIHLHFFLJJ<char[]>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly LCFDLOHIOFJ ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x65894B0", Offset = "0x65884B0", VA = "0x1865894B0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, char[] APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65892F0", Offset = "0x65882F0", VA = "0x1865892F0", Slot = "5")]
	public char[] AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LCFDLOHIOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class DGBAANKBGGD : DFIHLHFFLJJ<Guid>, MFLDAMIDLGH, FKAHDAKOENB<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly DFIHLHFFLJJ<Guid> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x65814F0", Offset = "0x65804F0", VA = "0x1865814F0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Guid APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6581280", Offset = "0x6580280", VA = "0x186581280", Slot = "5")]
	public Guid AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65813B0", Offset = "0x65803B0", VA = "0x1865813B0", Slot = "6")]
	public void JEFLDMAFIAI(FMIKPDPOMJO BBENPAOCMIF, Guid APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6581310", Offset = "0x6580310", VA = "0x186581310", Slot = "7")]
	public Guid DEIGCMIGADO(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DGBAANKBGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class EINCEHDGMIM : DFIHLHFFLJJ<decimal>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly DFIHLHFFLJJ<decimal> ENPBEGLBBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool EGLBJBEJBGD;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5015EC0", Offset = "0x5014EC0", VA = "0x185015EC0")]
	public EINCEHDGMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16A1E70", Offset = "0x16A0E70", VA = "0x1816A1E70")]
	public EINCEHDGMIM(bool EGLBJBEJBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6583260", Offset = "0x6582260", VA = "0x186583260", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, decimal APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6582FC0", Offset = "0x6581FC0", VA = "0x186582FC0", Slot = "5")]
	public decimal AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class HOBGBDFPGBM : DFIHLHFFLJJ<Uri>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly DFIHLHFFLJJ<Uri> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6586640", Offset = "0x6585640", VA = "0x186586640", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Uri APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6586580", Offset = "0x6585580", VA = "0x186586580", Slot = "5")]
	public Uri AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HOBGBDFPGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class KIFJEKNAKHN : DFIHLHFFLJJ<Version>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly DFIHLHFFLJJ<Version> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6587150", Offset = "0x6586150", VA = "0x186587150", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Version APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6587090", Offset = "0x6586090", VA = "0x186587090", Slot = "5")]
	public Version AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KIFJEKNAKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class KLGJIEANMEC<TKey, TValue> : DFIHLHFFLJJ<KeyValuePair<TKey, TValue>>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x39D3160", Offset = "0x39D2160", VA = "0x1839D3160", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, KeyValuePair<TKey, TValue> APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x39D2E30", Offset = "0x39D1E30", VA = "0x1839D2E30", Slot = "5")]
	public KeyValuePair<TKey, TValue> AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class OFKIKOLJCEN : DFIHLHFFLJJ<StringBuilder>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly DFIHLHFFLJJ<StringBuilder> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x658F630", Offset = "0x658E630", VA = "0x18658F630", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, StringBuilder APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x658F570", Offset = "0x658E570", VA = "0x18658F570", Slot = "5")]
	public StringBuilder AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OFKIKOLJCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class DIOIOHFACCE : DFIHLHFFLJJ<BitArray>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly DFIHLHFFLJJ<BitArray> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6581BF0", Offset = "0x6580BF0", VA = "0x186581BF0", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, BitArray APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6581A70", Offset = "0x6580A70", VA = "0x186581A70", Slot = "5")]
	public BitArray AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DIOIOHFACCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class ECAAELHMGIA : DFIHLHFFLJJ<Type>, MFLDAMIDLGH
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly ECAAELHMGIA ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex BJPIELCKLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool BEDMHFMLACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool FLGCKNABFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool EMGJGEHHNPA;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6582D40", Offset = "0x6581D40", VA = "0x186582D40")]
	public ECAAELHMGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D19660", Offset = "0x5D18660", VA = "0x185D19660")]
	public ECAAELHMGIA(bool BEDMHFMLACF, bool FLGCKNABFEK, bool EMGJGEHHNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6582B40", Offset = "0x6581B40", VA = "0x186582B40", Slot = "4")]
	public void KJONJHMMAMK(FMIKPDPOMJO BBENPAOCMIF, Type APPJEOKOGAK, NKGJGOEJJEF NNOODDJJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65829F0", Offset = "0x65819F0", VA = "0x1865829F0", Slot = "5")]
	public Type AJBPOCIDFHA(EDCKLMDDAAM JPPGFPLOJCL, NKGJGOEJJEF NNOODDJJEKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class EJILBMJOMGK
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] LMJIBMLGDKN;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly BLCFLOFFADD MNJKFEIGGHK;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6583490", Offset = "0x6582490", VA = "0x186583490")]
	static EJILBMJOMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class DNFBADHLONH
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] EEGAGIACGOM;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly BLCFLOFFADD PMLCEJIIJFG;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6582160", Offset = "0x6581160", VA = "0x186582160")]
	static DNFBADHLONH()
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
