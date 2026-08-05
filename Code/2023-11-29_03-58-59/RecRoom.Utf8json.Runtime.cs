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
internal static class NOKDBJLFJPI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65885A0", Offset = "0x65879A0", VA = "0x1865885A0")]
	public static bool PAJNKOGAOCC(this TypeInfo LFLAEPCPMDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class BPLBAJCPDCP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type BMGHNPIJENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] ODCCKKIIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
	public BPLBAJCPDCP(Type HCHJMPCDKNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class EOEIJJBNALM : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PNOGCIHEHOK<T>(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T ANFNECEGDEF<T>(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID MOJAODNPEME);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BOILAFIIEAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HIPKPDINGJD<T> : BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EOADGIMIJAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EIDNECPPKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NIGMGBHPFCF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26291D0", Offset = "0x26285D0", VA = "0x1826291D0")]
	public static string OMIDOABPJOC<T>(this HIPKPDINGJD<T> JFLLJFBEPAB, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIPKPDINGJD<T> HFHHHJNIJAI<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GGMODACHFAN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x250FEE0", Offset = "0x250F2E0", VA = "0x18250FEE0")]
	public static HIPKPDINGJD<T> ELPKGPJOIHC<T>(this PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x657E530", Offset = "0x657D930", VA = "0x18657E530")]
	public static object FCFDAFMAECB(this PMECKIJLNID MOJAODNPEME, Type LFLAEPCPMDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CPEOCIIEJPM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x656E340", Offset = "0x656D740", VA = "0x18656E340")]
	public CPEOCIIEJPM(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JPNKIGBGADK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class BGENBLDIJPN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] PNJHGINLCID;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] GHBIHGBMGLJ;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x656C820", Offset = "0x656BC20", VA = "0x18656C820")]
		public static byte[] FNHNFNKCDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x656C8C0", Offset = "0x656BCC0", VA = "0x18656C8C0")]
		public static char[] LEDAFMDCBME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NNOPJNLBMOM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] LANDPEPFOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] HPGJIANHJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int ELJAGIMMLLH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NEAMONIKPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6580F80", Offset = "0x6580380", VA = "0x186580F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65831D0", Offset = "0x65825D0", VA = "0x1865831D0")]
	public JPNKIGBGADK(byte[] HPGJIANHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6583070", Offset = "0x6582470", VA = "0x186583070")]
	public JPNKIGBGADK(byte[] HPGJIANHJNN, int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6580FA0", Offset = "0x65803A0", VA = "0x186580FA0")]
	private DGCODCIMAKM HFIBJHGDOGE(string KOGDJLCHGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6582660", Offset = "0x6581A60", VA = "0x186582660")]
	private DGCODCIMAKM LGPOAMBKKHP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6582520", Offset = "0x6581920", VA = "0x186582520")]
	public void KGIENMGJOBJ(int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBD40", VA = "0x1807DC940")]
	public byte[] FBHINBGKODI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CDCE90", Offset = "0x1CDC290", VA = "0x181CDCE90")]
	public int JCJGPPEAHJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x657FD90", Offset = "0x657F190", VA = "0x18657FD90")]
	public EKIGEAKEDAG AAGFNBBNOPD()
	{
		return default(EKIGEAKEDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6582530", Offset = "0x6581930", VA = "0x186582530")]
	public void KNEPFCDOMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65821B0", Offset = "0x65815B0", VA = "0x1865821B0")]
	public bool KDPEGEIONLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6580B80", Offset = "0x657FF80", VA = "0x186580B80")]
	public bool FFMHAKABIKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6580900", Offset = "0x657FD00", VA = "0x186580900")]
	public void CPHIGBLGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6580EF0", Offset = "0x65802F0", VA = "0x186580EF0")]
	public bool GIJHMKCHDIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6580280", Offset = "0x657F680", VA = "0x186580280")]
	public bool BJLMAHJDDIP(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65803D0", Offset = "0x657F7D0", VA = "0x1865803D0")]
	public bool BNDKHCAPBIL(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6580A20", Offset = "0x657FE20", VA = "0x186580A20")]
	public bool DJLFGEGAIDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6580D30", Offset = "0x6580130", VA = "0x186580D30")]
	public void GBACMBBLGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6580DD0", Offset = "0x65801D0", VA = "0x186580DD0")]
	public bool GFNIEPNIOOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6580AB0", Offset = "0x657FEB0", VA = "0x186580AB0")]
	public bool EFKOIHCNNIN(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x657FF40", Offset = "0x657F340", VA = "0x18657FF40")]
	public bool AFDNFMEGPPE(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65801F0", Offset = "0x657F5F0", VA = "0x1865801F0")]
	public bool BCILFHLJAPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6581790", Offset = "0x6580B90", VA = "0x186581790")]
	public void IFNKKJMFNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6580E60", Offset = "0x6580260", VA = "0x186580E60")]
	public bool GHCJIHAECOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6582EB0", Offset = "0x65822B0", VA = "0x186582EB0")]
	public void PNPIGIENLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6581990", Offset = "0x6580D90", VA = "0x186581990")]
	private void JOOHGEKOJGP([Out] byte[] BJKOMJCFGBK, [Out] int OIGPOEPCHHE, [Out] int BGICFPJGBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6580C10", Offset = "0x6580010", VA = "0x186580C10")]
	private static int FFMHEBFLFAD(char JMHOJIPAIMC, char MLKGDIFPGGI, char CPHKPECCMOM, char IIPNDJEHBDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65814F0", Offset = "0x65808F0", VA = "0x1865814F0")]
	private static int HGKDGENPDOH(char OPHKAEHAFCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65805A0", Offset = "0x657F9A0", VA = "0x1865805A0")]
	public ArraySegment<byte> CABJPDIFFKH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6582DD0", Offset = "0x65821D0", VA = "0x186582DD0")]
	public string PLCMDNJNAJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6580CC0", Offset = "0x65800C0", VA = "0x186580CC0")]
	public string GADEHHEPAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6582890", Offset = "0x6581C90", VA = "0x186582890")]
	public ArraySegment<byte> MHOBLNHMCNJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6580180", Offset = "0x657F580", VA = "0x186580180")]
	public ArraySegment<byte> BALCGCLGNGP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65822D0", Offset = "0x65816D0", VA = "0x1865822D0")]
	public bool KGGCMIHBMBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65816D0", Offset = "0x6580AD0", VA = "0x1865816D0")]
	private static bool IEGOIINAIHP(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6582B30", Offset = "0x6581F30", VA = "0x186582B30")]
	private void OPJCAJEFOCC(EKIGEAKEDAG NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6582D80", Offset = "0x6582180", VA = "0x186582D80")]
	public void PIBKHGECPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6581830", Offset = "0x6580C30", VA = "0x186581830")]
	private void IMOKPCEKEPO(int KMJODCHIJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6582130", Offset = "0x6581530", VA = "0x186582130")]
	public sbyte KBFMJOGABOF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6580350", Offset = "0x657F750", VA = "0x186580350")]
	public short BKNGJENCFCH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6582810", Offset = "0x6581C10", VA = "0x186582810")]
	public int MCMNIGONMKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6582750", Offset = "0x6581B50", VA = "0x186582750")]
	public long LHMCMHDJEID()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x65806C0", Offset = "0x657FAC0", VA = "0x1865806C0")]
	public byte CCJANAADGKD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6582AB0", Offset = "0x6581EB0", VA = "0x186582AB0")]
	public ushort NJLHMKLFJKH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65809A0", Offset = "0x657FDA0", VA = "0x1865809A0")]
	public uint DCEHLEOPJHI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6580740", Offset = "0x657FB40", VA = "0x186580740")]
	public ulong CIBJNOKILNF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65804A0", Offset = "0x657F8A0", VA = "0x1865804A0")]
	public float BPAILFIOIGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65815D0", Offset = "0x65809D0", VA = "0x1865815D0")]
	public double IANMBMAHIAA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6580800", Offset = "0x657FC00", VA = "0x186580800")]
	public ArraySegment<byte> CJDEKMNLPNO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6580010", Offset = "0x657F410", VA = "0x186580010")]
	private static int AMHCHFDMLCO(byte[] HPGJIANHJNN, int ELJAGIMMLLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DGCODCIMAKM : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference FNJHDINLPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FLLHACJOMKO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int ABGKMLNHNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB980E0", Offset = "0xB974E0", VA = "0x180B980E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DEPJKBGFJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8372D0", Offset = "0x8366D0", VA = "0x1808372D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x656E830", Offset = "0x656DC30", VA = "0x18656E830")]
	public DGCODCIMAKM(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x656E890", Offset = "0x656DC90", VA = "0x18656E890")]
	public DGCODCIMAKM(string KCFFPPIEBHH, byte[] LHILNCGPOLN, int ELJAGIMMLLH, int FLLHACJOMKO, string ALKFBKDMJPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GCLKBLDCNEK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class DJAEFOBCNFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] PNJHGINLCID;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x656E980", Offset = "0x656DD80", VA = "0x18656E980")]
		public static byte[] FNHNFNKCDEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NFFMPGJPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void MHNIJGPHJFI(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID MOJAODNPEME);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object ABFDGPEHNGP(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID MOJAODNPEME);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class FCFDLGADEBF
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class PJIEKMOEJBG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
				public PJIEKMOEJBG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x35DF180", Offset = "0x35DE580", VA = "0x1835DF180")]
				internal bool GIJEDGDJCFA(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x65888A0", Offset = "0x6587CA0", VA = "0x1865888A0")]
				internal bool EHEFOKMDMFF(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, PMECKIJLNID, byte[]> LELEOCKGHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, PMECKIJLNID> JKMHILNDMBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly MHNIJGPHJFI LKPNHFJELOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, PMECKIJLNID, ArraySegment<byte>> KECGDBNPEGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, PMECKIJLNID, string> EEIGNCGDCNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, PMECKIJLNID, object> BPIBFNPIAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, PMECKIJLNID, object> EJGGPNHIFEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, PMECKIJLNID, object> MGBDOIFMPLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly ABFDGPEHNGP NCFFPIJPGGF;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6573050", Offset = "0x6572450", VA = "0x186573050")]
			public FCFDLGADEBF(Type LFLAEPCPMDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6990", Offset = "0x2AE5D90", VA = "0x182AE6990")]
			private static T IJCDLJEOHBJ<T>(DynamicMethod NPOAEGCCCDJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6572E00", Offset = "0x6572200", VA = "0x186572E00")]
			private static MethodInfo HGOLKFMFOMC(Type LFLAEPCPMDG, string MDFAJJKMBAI, Type[] PNEFFIHJBBK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, FCFDLGADEBF> LMGBKBIAJNI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly CJHBBAIALEN<FCFDLGADEBF> HDOMOFLEJLM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6586290", Offset = "0x6585690", VA = "0x186586290")]
		static NFFMPGJPFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6586210", Offset = "0x6585610", VA = "0x186586210")]
		private static FCFDLGADEBF FNLFIKFJFDE(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6585F80", Offset = "0x6585380", VA = "0x186585F80")]
		public static void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6586100", Offset = "0x6585500", VA = "0x186586100")]
		public static void ALIOEPOJFBC(Type LFLAEPCPMDG, NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PMECKIJLNID OONJFEPGDCD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] JIMANCBDAFN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] GKJABPAPBKG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static PMECKIJLNID LIPEFCAMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x657D2E0", Offset = "0x657C6E0", VA = "0x18657D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x657D3E0", Offset = "0x657C7E0", VA = "0x18657D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x657E230", Offset = "0x657D630", VA = "0x18657E230")]
	public static void PIAKPELHHMN(PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25086D0", Offset = "0x2507AD0", VA = "0x1825086D0")]
	public static byte[] ALIOEPOJFBC<T>(T ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25084C0", Offset = "0x25078C0", VA = "0x1825084C0")]
	public static byte[] ALIOEPOJFBC<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2508430", Offset = "0x2507830", VA = "0x182508430")]
	public static void ALIOEPOJFBC<T>(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2508750", Offset = "0x2507B50", VA = "0x182508750")]
	public static void ALIOEPOJFBC<T>(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2508640", Offset = "0x2507A40", VA = "0x182508640")]
	public static void ALIOEPOJFBC<T>(Stream LOEGNCGHNOB, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2508830", Offset = "0x2507C30", VA = "0x182508830")]
	public static void ALIOEPOJFBC<T>(Stream LOEGNCGHNOB, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2508970", Offset = "0x2507D70", VA = "0x182508970")]
	public static ArraySegment<byte> IDNDCOFADCE<T>(T ECLCDMJMICA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2508A00", Offset = "0x2507E00", VA = "0x182508A00")]
	public static ArraySegment<byte> IDNDCOFADCE<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x250A1D0", Offset = "0x25095D0", VA = "0x18250A1D0")]
	public static string OMIDOABPJOC<T>(T NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x250A050", Offset = "0x2509450", VA = "0x18250A050")]
	public static string OMIDOABPJOC<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25097D0", Offset = "0x2508BD0", VA = "0x1825097D0")]
	public static T JKMDPBEAKHM<T>(string PPOIIGFJLOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2509550", Offset = "0x2508950", VA = "0x182509550")]
	public static T JKMDPBEAKHM<T>(string PPOIIGFJLOA, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2509F50", Offset = "0x2509350", VA = "0x182509F50")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2509860", Offset = "0x2508C60", VA = "0x182509860")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25099C0", Offset = "0x2508DC0", VA = "0x1825099C0")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, int ELJAGIMMLLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2509640", Offset = "0x2508A40", VA = "0x182509640")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, int ELJAGIMMLLH, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2509FD0", Offset = "0x25093D0", VA = "0x182509FD0")]
	public static T JKMDPBEAKHM<T>(JPNKIGBGADK PCDAGGPDBLK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2509E00", Offset = "0x2509200", VA = "0x182509E00")]
	public static T JKMDPBEAKHM<T>(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2509ED0", Offset = "0x25092D0", VA = "0x182509ED0")]
	public static T JKMDPBEAKHM<T>(Stream LOEGNCGHNOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2509A50", Offset = "0x2508E50", VA = "0x182509A50")]
	public static T JKMDPBEAKHM<T>(Stream LOEGNCGHNOB, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657D040", Offset = "0x657C440", VA = "0x18657D040")]
	public static string AIGFECBEMJL(byte[] PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x657D1A0", Offset = "0x657C5A0", VA = "0x18657D1A0")]
	public static string AIGFECBEMJL(byte[] PPOIIGFJLOA, int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x657CEB0", Offset = "0x657C2B0", VA = "0x18657CEB0")]
	public static string AIGFECBEMJL(string PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x657D630", Offset = "0x657CA30", VA = "0x18657D630")]
	public static byte[] LOMBAAHNANA(byte[] PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x657D4E0", Offset = "0x657C8E0", VA = "0x18657D4E0")]
	public static byte[] LOMBAAHNANA(byte[] PPOIIGFJLOA, int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x657D7B0", Offset = "0x657CBB0", VA = "0x18657D7B0")]
	public static byte[] LOMBAAHNANA(string PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x657D960", Offset = "0x657CD60", VA = "0x18657D960")]
	private static void OHHBPGIKNNP(JPNKIGBGADK PCDAGGPDBLK, NLPBBJFEPIL EKCFHKIKCOP, int KPHHMKNGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x657D440", Offset = "0x657C840", VA = "0x18657D440")]
	private static int CNAEKLNJNKI(Stream CGOLCEEBMBE, byte[] PNJHGINLCID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum EKIGEAKEDAG : byte
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
public struct NLPBBJFEPIL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] HBFPNJDGEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] PNJHGINLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ELJAGIMMLLH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EGLFGDIOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CDCE90", Offset = "0x1CDC290", VA = "0x181CDCE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6582520", Offset = "0x6581920", VA = "0x186582520")]
	public void KGIENMGJOBJ(int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6586D50", Offset = "0x6586150", VA = "0x186586D50")]
	public static byte[] HNHCIIHLLAO(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6586E80", Offset = "0x6586280", VA = "0x186586E80")]
	public static byte[] IJPEDONMEBF(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65873C0", Offset = "0x65867C0", VA = "0x1865873C0")]
	public static byte[] MFDIEHJKDPK(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6587560", Offset = "0x6586960", VA = "0x186587560")]
	public static byte[] OLFOFAMGOIM(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x538E570", Offset = "0x538D970", VA = "0x18538E570")]
	public NLPBBJFEPIL(byte[] PDDLJJJGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6586690", Offset = "0x6585A90", VA = "0x186586690")]
	public ArraySegment<byte> FNHNFNKCDEH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6587040", Offset = "0x6586440", VA = "0x186587040")]
	public byte[] JKMJKCAMAAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x65877F0", Offset = "0x6586BF0", VA = "0x1865877F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6586C20", Offset = "0x6586020", VA = "0x186586C20")]
	public void GJBFFPEHKBH(int OIMKKCAHKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6587240", Offset = "0x6586640", VA = "0x186587240")]
	public void KEKOJNJKDEF(byte NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65872A0", Offset = "0x65866A0", VA = "0x1865872A0")]
	public void KEKOJNJKDEF(byte[] NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6586600", Offset = "0x6585A00", VA = "0x186586600")]
	public void FBPACBDJPJC(byte NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6586D00", Offset = "0x6586100", VA = "0x186586D00")]
	public void HNFALCALCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6586FF0", Offset = "0x65863F0", VA = "0x186586FF0")]
	public void JJMIIDNPCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6587370", Offset = "0x6586770", VA = "0x186587370")]
	public void LGGAKCFIDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6586640", Offset = "0x6585A40", VA = "0x186586640")]
	public void FFNGMMENIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6587180", Offset = "0x6586580", VA = "0x186587180")]
	public void KDIKKHODPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65870B0", Offset = "0x65864B0", VA = "0x1865870B0")]
	public void KAPJAPGAMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6587750", Offset = "0x6586B50", VA = "0x186587750")]
	public void PKIFPLHPCOP(string JJOBNGACPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x65863E0", Offset = "0x65857E0", VA = "0x1865863E0")]
	public void AMHFDEKHNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6586C60", Offset = "0x6586060", VA = "0x186586C60")]
	public void HNDLNAKFHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6586730", Offset = "0x6585B30", VA = "0x186586730")]
	public void FNNDOMNMACI(bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6586430", Offset = "0x6585830", VA = "0x186586430")]
	public void BILIPEMGNHO(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6587100", Offset = "0x6586500", VA = "0x186587100")]
	public void KCAGLOBFNMM(double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65871D0", Offset = "0x65865D0", VA = "0x1865871D0")]
	public void KEHNLLMPHPO(byte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6587300", Offset = "0x6586700", VA = "0x186587300")]
	public void KIHNMBNFFKB(ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x65864B0", Offset = "0x65858B0", VA = "0x1865864B0")]
	public void CFLPAALJGNE(uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6587530", Offset = "0x6586930", VA = "0x186587530")]
	public void NMHGFFKKICL(ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6586590", Offset = "0x6585990", VA = "0x186586590")]
	public void DGAHFLCEMHE(sbyte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65876E0", Offset = "0x6586AE0", VA = "0x1865876E0")]
	public void PBPKLEOMHDE(short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6586520", Offset = "0x6585920", VA = "0x186586520")]
	public void CMHNNGIECPN(int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6586C30", Offset = "0x6586030", VA = "0x186586C30")]
	public void HCLKEMNIMIJ(long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6586890", Offset = "0x6585C90", VA = "0x186586890")]
	public void FNOLPNMGEPE(string NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OKCABBHIPIA : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class GBLEKKMFMJI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x351FEA0", Offset = "0x351F2A0", VA = "0x18351FEA0")]
		static GBLEKKMFMJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private OKCABBHIPIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class NNBKHHGOCHP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> PNHECFPDBFA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x65880B0", Offset = "0x65874B0", VA = "0x1865880B0")]
	static NNBKHHGOCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65878C0", Offset = "0x6586CC0", VA = "0x1865878C0")]
	internal static object HFHHHJNIJAI(Type AINBOEMJDAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BNLDAAJDJOL : HIPKPDINGJD<Vector2>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x656D6A0", Offset = "0x656CAA0", VA = "0x18656D6A0")]
	public BNLDAAJDJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x656D1C0", Offset = "0x656C5C0", VA = "0x18656D1C0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector2 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x656D3B0", Offset = "0x656C7B0", VA = "0x18656D3B0", Slot = "5")]
	public Vector2 JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class BLNBFKGDDAN : HIPKPDINGJD<Vector3>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x656CF50", Offset = "0x656C350", VA = "0x18656CF50")]
	public BLNBFKGDDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x656C960", Offset = "0x656BD60", VA = "0x18656C960", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector3 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x656CC00", Offset = "0x656C000", VA = "0x18656CC00", Slot = "5")]
	public Vector3 JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EOGLKEBDAED : HIPKPDINGJD<Vector4>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6572B10", Offset = "0x6571F10", VA = "0x186572B10")]
	public EOGLKEBDAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6572440", Offset = "0x6571840", VA = "0x186572440", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector4 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6572780", Offset = "0x6571B80", VA = "0x186572780", Slot = "5")]
	public Vector4 JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BCHEKPOOLCJ : HIPKPDINGJD<Quaternion>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x656C530", Offset = "0x656B930", VA = "0x18656C530")]
	public BCHEKPOOLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x656BE60", Offset = "0x656B260", VA = "0x18656BE60", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Quaternion NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x656C1A0", Offset = "0x656B5A0", VA = "0x18656C1A0", Slot = "5")]
	public Quaternion JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CBCIAEKEMDJ : HIPKPDINGJD<Color>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x656DF50", Offset = "0x656D350", VA = "0x18656DF50")]
	public CBCIAEKEMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x656D880", Offset = "0x656CC80", VA = "0x18656D880", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Color NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x656DBC0", Offset = "0x656CFC0", VA = "0x18656DBC0", Slot = "5")]
	public Color JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LNBMKCEHCEK : HIPKPDINGJD<Bounds>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x65857A0", Offset = "0x6584BA0", VA = "0x1865857A0")]
	public LNBMKCEHCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x65850A0", Offset = "0x65844A0", VA = "0x1865850A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Bounds NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65853C0", Offset = "0x65847C0", VA = "0x1865853C0", Slot = "5")]
	public Bounds JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JPLDBMMLCOD : HIPKPDINGJD<Rect>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JGOCJFKOPOG LHGADCKDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] GDBKJLDFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x657FAA0", Offset = "0x657EEA0", VA = "0x18657FAA0")]
	public JPLDBMMLCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x657F340", Offset = "0x657E740", VA = "0x18657F340", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Rect NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x657F6B0", Offset = "0x657EAB0", VA = "0x18657F6B0", Slot = "5")]
	public Rect JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KEFFCHDNOPM : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class IBEJBKMKBIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x36C13B0", Offset = "0x36C07B0", VA = "0x1836C13B0")]
		static IBEJBKMKBIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private KEFFCHDNOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class JLNBPKKNNNM : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class CNJJKGFAKKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4909440", Offset = "0x4908840", VA = "0x184909440")]
		static CNJJKGFAKKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class EMIOCLPEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> IHIECFBKEHO;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6570610", Offset = "0x656FA10", VA = "0x186570610")]
		internal static object HFHHHJNIJAI(Type AINBOEMJDAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private JLNBPKKNNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JHKFBOMPPGK : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class APANEDFIDEE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x36725B0", Offset = "0x36719B0", VA = "0x1836725B0")]
		static APANEDFIDEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JHKFBOMPPGK NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool IBCECDOBBJF;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BOILAFIIEAN[] HHNHEIJACMJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static PMECKIJLNID[] FOFJFOLNDBG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private JHKFBOMPPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x657EE70", Offset = "0x657E270", VA = "0x18657EE70")]
	public static void CNJGKMHEDKP(params PMECKIJLNID[] FOFJFOLNDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x657EF50", Offset = "0x657E350", VA = "0x18657EF50")]
	public static void CNJGKMHEDKP(params BOILAFIIEAN[] HHNHEIJACMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x657EBE0", Offset = "0x657DFE0", VA = "0x18657EBE0")]
	public static void AMGBMEHHIDP(BOILAFIIEAN[] HHNHEIJACMJ, PMECKIJLNID[] FOFJFOLNDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class FJIAONIOIGM : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class DBEHHFMPCOF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4D9DEE0", Offset = "0x4D9D2E0", VA = "0x184D9DEE0")]
		static DBEHHFMPCOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private FJIAONIOIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NBPKLKGDMCL
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly PMECKIJLNID LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly PMECKIJLNID JCKCMOEIICA;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PMECKIJLNID KKMFFEGEIJL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly PMECKIJLNID HGHCBMNBJMN;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly PMECKIJLNID GMPBNHIAEJN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly PMECKIJLNID GAEAKAFALLD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly PMECKIJLNID BCEADODBOCO;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly PMECKIJLNID NFCKOKMELIJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly PMECKIJLNID NMMOBCADCKK;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly PMECKIJLNID DHCNAPFLJIJ;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly PMECKIJLNID ADNANKFFINE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly PMECKIJLNID BNHFIJLBLDE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OEJADKNOHLJ
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly PMECKIJLNID LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PMECKIJLNID BEGHDANIAPH;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DABCBNDDCBP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly PMECKIJLNID LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly PMECKIJLNID JCKCMOEIICA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly PMECKIJLNID KKMFFEGEIJL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly PMECKIJLNID HGHCBMNBJMN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly PMECKIJLNID GMPBNHIAEJN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly PMECKIJLNID GAEAKAFALLD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PMECKIJLNID BCEADODBOCO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly PMECKIJLNID NFCKOKMELIJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly PMECKIJLNID NMMOBCADCKK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly PMECKIJLNID DHCNAPFLJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly PMECKIJLNID ADNANKFFINE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PMECKIJLNID BNHFIJLBLDE;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KDMFMKOCMGJ
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> IHIECFBKEHO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6583230", Offset = "0x6582630", VA = "0x186583230")]
	internal static object HFHHHJNIJAI(Type AINBOEMJDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6584990", Offset = "0x6583D90", VA = "0x186584990")]
	private static object IDLIFFHLBPB(Type AHNPIIALEFB, Type[] OKAIPOMNHLA, params object[] PNEFFIHJBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class IAELOJBODAA : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class GCAPBDAHLON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3525F30", Offset = "0x3525330", VA = "0x183525F30")]
		static GCAPBDAHLON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x657E800", Offset = "0x657DC00", VA = "0x18657E800")]
	static IAELOJBODAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private IAELOJBODAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HDBBLOOJHJI : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class IBKJONIFFJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x36C7780", Offset = "0x36C6B80", VA = "0x1836C7780")]
		static IBKJONIFFJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x657E690", Offset = "0x657DA90", VA = "0x18657E690")]
	static HDBBLOOJHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private HDBBLOOJHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class JMPKBKNKKEF : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class MFFICKLMDBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5C40", Offset = "0x3CA5040", VA = "0x183CA5C40")]
		static MFFICKLMDBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x657F1D0", Offset = "0x657E5D0", VA = "0x18657F1D0")]
	static JMPKBKNKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private JMPKBKNKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class PGAAOBKEIHC : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class GIJMDGMNDGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3543BD0", Offset = "0x3542FD0", VA = "0x183543BD0")]
		static GIJMDGMNDGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6588730", Offset = "0x6587B30", VA = "0x186588730")]
	static PGAAOBKEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private PGAAOBKEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class NDFOCJNJBNP : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class PFJLHHCMEPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1ED0", Offset = "0x3EE12D0", VA = "0x183EE1ED0")]
		static PFJLHHCMEPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6585E10", Offset = "0x6585210", VA = "0x186585E10")]
	static NDFOCJNJBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private NDFOCJNJBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class IFCNGHGGFOB : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class PHHKEDFJIMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F120C0", Offset = "0x3F114C0", VA = "0x183F120C0")]
		static PHHKEDFJIMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly EDGFJJCKCKN DMEBGPNMPEC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x657EA70", Offset = "0x657DE70", VA = "0x18657EA70")]
	static IFCNGHGGFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private IFCNGHGGFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class IDCCGDBPIOB : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class BBLGGOMCFPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x45402E0", Offset = "0x453F6E0", VA = "0x1845402E0")]
		static BBLGGOMCFPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IDCCGDBPIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class AEOBIIMINLH : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class LIFKDPAJDIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A952A0", Offset = "0x3A946A0", VA = "0x183A952A0")]
		static LIFKDPAJDIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public AEOBIIMINLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class KFNBCLKNGGH : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class JJJKAENFOKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x39013C0", Offset = "0x39007C0", VA = "0x1839013C0")]
		static JJJKAENFOKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public KFNBCLKNGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class GFMNIIGDJPD : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class KDAIKNMNEOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3967B40", Offset = "0x3966F40", VA = "0x183967B40")]
		static KDAIKNMNEOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public GFMNIIGDJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class POKGPNOPFPJ : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class CNMKLFKKLMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4911000", Offset = "0x4910400", VA = "0x184911000")]
		static CNMKLFKKLMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public POKGPNOPFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class COHGBAACGCO : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class HKKPCAFFHGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x360CE50", Offset = "0x360C250", VA = "0x18360CE50")]
		static HKKPCAFFHGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> ABNPFLFJCCM;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool GGIOGBPFFII;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public COHGBAACGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class FFDDILCPCJI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct DKHPDJHOKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GPLPOGHBDHO LDCFGOPELNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder PDDLPLIBBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder DEIPDDLNLEB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class ECJDAGFJCNM
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class BKODNOCGPPC
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MFDIEHJKDPK;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IJPEDONMEBF;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OLFOFAMGOIM;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo HNHCIIHLLAO;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo HNDLNAKFHDA;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo KEKOJNJKDEF;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo LGGAKCFIDOK;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo FFNGMMENIBE;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo KDIKKHODPCA;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6589590", Offset = "0x6588990", VA = "0x186589590")]
			static BKODNOCGPPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class FBONBHBDADM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo KDPEGEIONLN;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo GBACMBBLGMO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo EFKOIHCNNIN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo FFJMJMAKBFH;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo PIBKHGECPBF;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo FBHINBGKODI;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo JCJGPPEAHJJ;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x658F320", Offset = "0x658E720", VA = "0x18658F320")]
			static FBONBHBDADM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class MNJGMPOFEPI
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo BMGHNPIJENF;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo ODCCKKIIFNL;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo OPPELCKJLMO;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ELPKGPJOIHC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EOLABHEJJDO;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo ANKOBFDEKLA;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo IMGDDBFBJOH;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo MMMIEJIEJJA;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo PLOFLBDDDPA;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo ABLLKIPAAAE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo BLKIOAOMPBE;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo CFOBLBBPMOI;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DKNELIANGPG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo FHINFOCOHEJ;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x656EA20", Offset = "0x656DE20", VA = "0x18656EA20")]
		public static MethodInfo ALIOEPOJFBC(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x656EDE0", Offset = "0x656E1E0", VA = "0x18656EDE0")]
		public static MethodInfo JKMDPBEAKHM(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x656ECB0", Offset = "0x656E0B0", VA = "0x18656ECB0")]
		public static MethodInfo FHDEOMAGEBG(Type LFLAEPCPMDG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KMDDAOIODON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<GPLPOGHBDHO, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KMDDAOIODON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class DDLHHFLHEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public KMDDAOIODON CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public DDLHHFLHEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x658B310", Offset = "0x658A710", VA = "0x18658B310")]
		internal void CJFDJFIMNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x658B410", Offset = "0x658A810", VA = "0x18658B410")]
		internal bool HJNJDBNKPKF(int index, GPLPOGHBDHO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NLBHFENAJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public KMDDAOIODON CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public NLBHFENAJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x659E2B0", Offset = "0x659D6B0", VA = "0x18659E2B0")]
		internal bool GGECAPLOMMF(int index, GPLPOGHBDHO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JEDGPCBFNOK
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
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JEDGPCBFNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4DBA660", Offset = "0x4DB9A60", VA = "0x184DBA660")]
		internal string MCHEGHOPIFM(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KFKJCGLGNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KFKJCGLGNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6595D80", Offset = "0x6595180", VA = "0x186595D80")]
		internal bool LEBNIACIPPD(GPLPOGHBDHO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PGFKJHOIDHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public JEDGPCBFNOK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PGFKJHOIDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x65A03B0", Offset = "0x659F7B0", VA = "0x1865A03B0")]
		internal void DCHMAPKNPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65A0430", Offset = "0x659F830", VA = "0x1865A0430")]
		internal bool OPGFOCGLAOE(int index, GPLPOGHBDHO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class GFAPFEOBFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JEDGPCBFNOK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GFAPFEOBFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6592270", Offset = "0x6591670", VA = "0x186592270")]
		internal bool AOOBKBPABFK(int index, GPLPOGHBDHO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CFOBAHBNKAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public CFOBAHBNKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x658AC50", Offset = "0x658A050", VA = "0x18658AC50")]
		internal Label ENKAJCIBLHO(GPLPOGHBDHO _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LMBJKDFNNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DKHPDJHOKAC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, GPLPOGHBDHO, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BFFGOOHOALI argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public BFFGOOHOALI argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public LMBJKDFNNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6597D70", Offset = "0x6597170", VA = "0x186597D70")]
		internal DKHPDJHOKAC HLKBGMNGIJE(GPLPOGHBDHO item)
		{
			return default(DKHPDJHOKAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GKEPHDGIEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LMBJKDFNNPM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GKEPHDGIEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x65924F0", Offset = "0x65918F0", VA = "0x1865924F0")]
		internal void MFFBJGENFKG(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6592450", Offset = "0x6591850", VA = "0x186592450")]
		internal void JFCJEPBAMHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LNNEGOMGNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GPLPOGHBDHO item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public LNNEGOMGNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAF3930", Offset = "0xAF2D30", VA = "0x180AF3930")]
		internal bool IPPBBMFLOOK(DKHPDJHOKAC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JEJLHNADKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GPLPOGHBDHO item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JEJLHNADKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAF3930", Offset = "0xAF2D30", VA = "0x180AF3930")]
		internal bool DGPEDNGIGJC(DKHPDJHOKAC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex OJHIBFNOJDL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int ILPIECLMMEF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> PLFJEGMPODD;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> PPDIHIOKIEF;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x24EBF20", Offset = "0x24EB320", VA = "0x1824EBF20")]
	public static object IFEDDKJLMKP<T>(EDGFJJCKCKN DMEBGPNMPEC, PMECKIJLNID GBOLHIPMMPE, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x24F71A0", Offset = "0x24F65A0", VA = "0x1824F71A0")]
	public static object JJMECMKGBAN<T>(PMECKIJLNID GBOLHIPMMPE, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII, bool MEBCNCCFLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6578860", Offset = "0x6577C60", VA = "0x186578860")]
	private static TypeInfo MKKELNFLGBN(EDGFJJCKCKN DMEBGPNMPEC, Type LFLAEPCPMDG, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x657AC90", Offset = "0x657A090", VA = "0x18657AC90")]
	public static object PICDDEABMBF(Type LFLAEPCPMDG, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII, bool MEBCNCCFLCP, bool OALPMIPJGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6575090", Offset = "0x6574490", VA = "0x186575090")]
	private static Dictionary<GPLPOGHBDHO, FieldInfo> DOKAPNKDIBP(TypeBuilder CGKICNDNAJN, JNCDAPNGHKD PPPGPJEJFAJ, ConstructorInfo EHEJGNENLFE, FieldBuilder EONNDJAPOKA, ILGenerator LDKPHNBJGBA, bool GGIOGBPFFII, bool ADPMOGLGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x657A5B0", Offset = "0x65799B0", VA = "0x18657A5B0")]
	private static Dictionary<GPLPOGHBDHO, FieldInfo> PHOIIDBOPAB(TypeBuilder CGKICNDNAJN, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65757C0", Offset = "0x6574BC0", VA = "0x1865757C0")]
	private static void GGJNDCGOGAC(Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA, Action CMJIBOANKCP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, bool GGIOGBPFFII, bool ADPMOGLGOOF, int GGKBKBKBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6574B50", Offset = "0x6573F50", VA = "0x186574B50")]
	private static void BAGEBAOBAIN(TypeInfo LFLAEPCPMDG, GPLPOGHBDHO BAELLAPOEPH, ILGenerator LDKPHNBJGBA, int DIENMHDGFGP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, BFFGOOHOALI EKCFHKIKCOP, BFFGOOHOALI HOCMDHEFHJM, BFFGOOHOALI CFKKMPPKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6579280", Offset = "0x6578680", VA = "0x186579280")]
	private static void MLLCEIMDEBP(Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, bool KDNIMLLEBKF, int GGKBKBKBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6576E00", Offset = "0x6576200", VA = "0x186576E00")]
	private static void JMKDHNBHOEF(ILGenerator LDKPHNBJGBA, DKHPDJHOKAC PPPGPJEJFAJ, int DIENMHDGFGP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, BFFGOOHOALI PCDAGGPDBLK, BFFGOOHOALI CFKKMPPKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6577950", Offset = "0x6576D50", VA = "0x186577950")]
	private static LocalBuilder KGGPCPEBIHO(ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, DKHPDJHOKAC[] LMHILKLGKCE, bool PNFFDMMCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6577270", Offset = "0x6576670", VA = "0x186577270")]
	private static bool KFMIDBLCGFM(ConstructorInfo BDOJPKLABJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65786E0", Offset = "0x6577AE0", VA = "0x1865786E0")]
	private static bool LAPODLNEFHL(Type LFLAEPCPMDG, [Out] Type BNICIAIMKNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void IHPCLBDMMFP<T>(byte[][] EONNDJAPOKA, object[] OIAGJDKPIII, NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T IFIAHGANEOC<T>(object[] OIAGJDKPIII, JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID MOJAODNPEME);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class HPNCCBELLPK<T> : HIPKPDINGJD<T>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] EONNDJAPOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] KLCMJNOOHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] FIAIHLIOFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly IHPCLBDMMFP<T> ECDIACCCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly IFIAHGANEOC<T> BIMCAOIGJHK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA41C0", Offset = "0x1CA35C0", VA = "0x181CA41C0")]
	public HPNCCBELLPK(byte[][] EONNDJAPOKA, object[] KLCMJNOOHOI, object[] FIAIHLIOFLG, IHPCLBDMMFP<T> ECDIACCCOLK, IFIAHGANEOC<T> BIMCAOIGJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3620360", Offset = "0x361F760", VA = "0x183620360", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3620450", Offset = "0x361F850", VA = "0x183620450", Slot = "5")]
	public T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class CMNHFBNFNHD : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class KELCJADKFAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x396EC00", Offset = "0x396E000", VA = "0x18396EC00")]
		static KELCJADKFAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private CMNHFBNFNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class EDPPEIJGMJL : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class CIOOJLKNACH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4815BF0", Offset = "0x4814FF0", VA = "0x184815BF0")]
		static CIOOJLKNACH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private EDPPEIJGMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class KMLGOPBANCG
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly PMECKIJLNID[] OEECGDIIOEB;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class CCJNBBHGEHC : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class ANHKLNKKMFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x366DD90", Offset = "0x366D190", VA = "0x18366DD90")]
		static ANHKLNKKMFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class HJFCJEPLOCL : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class CHIABNCJGKA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x480E100", Offset = "0x480D500", VA = "0x18480E100")]
			static CHIABNCJGKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private HJFCJEPLOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private CCJNBBHGEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class DMJGFPKIEEN : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class AMJKABMCBOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3571950", Offset = "0x3570D50", VA = "0x183571950")]
		static AMJKABMCBOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class DCNPDBAKMCF : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class HCHDNJADHFM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x35D1C80", Offset = "0x35D1080", VA = "0x1835D1C80")]
			static HCHDNJADHFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private DCNPDBAKMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private DMJGFPKIEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class DFMALGOAOJK : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class FCNPEKLGLCH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x34474C0", Offset = "0x34468C0", VA = "0x1834474C0")]
		static FCNPEKLGLCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class BPAINKGLFJJ : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class BPKJKCANNBK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4588F40", Offset = "0x4588340", VA = "0x184588F40")]
			static BPKJKCANNBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private BPAINKGLFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private DFMALGOAOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class EAGMGOHLMOO : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class OGLHKGFGBJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEDE0", Offset = "0x3DFE1E0", VA = "0x183DFEDE0")]
		static OGLHKGFGBJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class AIBMAHIOGGO : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class JAFJCIEHDPP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x38DCE60", Offset = "0x38DC260", VA = "0x1838DCE60")]
			static JAFJCIEHDPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private AIBMAHIOGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private EAGMGOHLMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class EJCHENAMEKB : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class BENGHKIIEII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4554820", Offset = "0x4553C20", VA = "0x184554820")]
		static BENGHKIIEII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class ELBEMDAMPBH : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class HOKHGEOJALD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x361DB10", Offset = "0x361CF10", VA = "0x18361DB10")]
			static HOKHGEOJALD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private ELBEMDAMPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private EJCHENAMEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class FBJAPPCLPDH : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class DFPDHPDMGPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4DC36B0", Offset = "0x4DC2AB0", VA = "0x184DC36B0")]
		static DFPDHPDMGPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class LPACPMMCGCC : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class ONCFEEBHPJE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3E19090", Offset = "0x3E18490", VA = "0x183E19090")]
			static ONCFEEBHPJE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private LPACPMMCGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private FBJAPPCLPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class CEPFECHDHHI : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class JPGLLDFPPGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x391A840", Offset = "0x3919C40", VA = "0x18391A840")]
		static JPGLLDFPPGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class NOHCPIHMLAA : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class KDFKHJALDIL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3968790", Offset = "0x3967B90", VA = "0x183968790")]
			static KDFKHJALDIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private NOHCPIHMLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private CEPFECHDHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class FIENPHFHNAH : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class HCHFBMLFHEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x35D4A00", Offset = "0x35D3E00", VA = "0x1835D4A00")]
		static HCHFBMLFHEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class MEENOCHCAHI : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class LPKOBOCIMNE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3ABAD30", Offset = "0x3ABA130", VA = "0x183ABAD30")]
			static LPKOBOCIMNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private MEENOCHCAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private FIENPHFHNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class OEBOAPFFIGO : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class PBLNFEOEGDD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD180", Offset = "0x3EBC580", VA = "0x183EBD180")]
		static PBLNFEOEGDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class KKMPJONILFD : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class DKFMFDPKOHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x4DDE100", Offset = "0x4DDD500", VA = "0x184DDE100")]
			static DKFMFDPKOHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private KKMPJONILFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private OEBOAPFFIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class PPIHHCLPOHJ : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class JMDAAIMNDBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x390C0F0", Offset = "0x390B4F0", VA = "0x18390C0F0")]
		static JMDAAIMNDBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class HDBMNAOPMCC : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class IDAAIPJCPMK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3732C80", Offset = "0x3732080", VA = "0x183732C80")]
			static IDAAIPJCPMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private HDBMNAOPMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private PPIHHCLPOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class DMNIOCGAOLO : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class GENJFAOIGJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3534480", Offset = "0x3533880", VA = "0x183534480")]
		static GENJFAOIGJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class DKNGKENJCIN : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class LKIMDJFNEAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3AA6C90", Offset = "0x3AA6090", VA = "0x183AA6C90")]
			static LKIMDJFNEAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private DKNGKENJCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private DMNIOCGAOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class IBELHIDPPMH : PMECKIJLNID
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class PAGBPDIOHKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EACCB0", Offset = "0x3EAC0B0", VA = "0x183EACCB0")]
		static PAGBPDIOHKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class CPIMEKNDBJK : PMECKIJLNID
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class OICFKPCEIMK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly HIPKPDINGJD<T> JFLLJFBEPAB;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3E09790", Offset = "0x3E08B90", VA = "0x183E09790")]
			static OICFKPCEIMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly PMECKIJLNID NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly PMECKIJLNID[] FOFJFOLNDBG;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private CPIMEKNDBJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
		public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly PMECKIJLNID NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly HIPKPDINGJD<object> KLDGFAKGFCH;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private IBELHIDPPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x22B7B90", Offset = "0x22B6F90", VA = "0x1822B7B90", Slot = "4")]
	public HIPKPDINGJD<T> HFHHHJNIJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct AJGGMHIIHMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] ADMOGDGDEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int DIHNPGKKGFH;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3565220", Offset = "0x3564620", VA = "0x183565220")]
	public AJGGMHIIHMM(int LJFEOIBMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3564EF0", Offset = "0x35642F0", VA = "0x183564EF0")]
	public void BKKEPFPDOJH(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3565190", Offset = "0x3564590", VA = "0x183565190")]
	public T[] KIENKEKMOOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class GCNIKOCBBJN : NJLGHCBJBBJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly GCNIKOCBBJN LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6592220", Offset = "0x6591620", VA = "0x186592220")]
	public GCNIKOCBBJN(int OBBMNEKDKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class NJLGHCBJBBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int OBBMNEKDKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object ECPKABAPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int DIENMHDGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] IPPBFGMGLKN;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F310", Offset = "0x3D2E710", VA = "0x183D2F310")]
	public NJLGHCBJBBJ(int OBBMNEKDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DE10", Offset = "0x3D2D210", VA = "0x183D2DE10")]
	public T[] BEAKOFMCJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E1D0", Offset = "0x3D2D5D0", VA = "0x183D2E1D0")]
	public void EHFGMMLCFOM(T[] NCABOBFFNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class JGOCJFKOPOG : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class NILPNLJFDCA : IComparable<NILPNLJFDCA>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class MGBDJDMBNLM : IEnumerable<NILPNLJFDCA>, IEnumerable, IEnumerator<NILPNLJFDCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private NILPNLJFDCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public NILPNLJFDCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private NILPNLJFDCA System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8ECA50", Offset = "0x8EBE50", VA = "0x1808ECA50")]
			[DebuggerHidden]
			public MGBDJDMBNLM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6598230", Offset = "0x6597630", VA = "0x186598230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6598360", Offset = "0x6597760", VA = "0x186598360", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x65982B0", Offset = "0x65976B0", VA = "0x1865982B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NILPNLJFDCA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x65982B0", Offset = "0x65976B0", VA = "0x1865982B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class DLKLHIHBCOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DLKLHIHBCOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x658AC50", Offset = "0x658A050", VA = "0x18658AC50")]
			internal Label KDINAPEFFLL(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x658AC50", Offset = "0x658A050", VA = "0x18658AC50")]
			internal Label PFMNLLKLBOK(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly NILPNLJFDCA[] MMGFPCFIMHB;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] IHBAIKMFEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong BOGLOOJGMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int ILNPCEAPFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string GAGCMCLOJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private NILPNLJFDCA[] LOLCCPIJNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] IECFGAAMDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int APAKJDHFMCK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CDFNJMBBKAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x50BEA90", Offset = "0x50BDE90", VA = "0x1850BEA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x659E1F0", Offset = "0x659D5F0", VA = "0x18659E1F0")]
		public NILPNLJFDCA(ulong MIMFBLPNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x659CBC0", Offset = "0x659BFC0", VA = "0x18659CBC0")]
		public NILPNLJFDCA BKKEPFPDOJH(ulong MIMFBLPNKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x659CDC0", Offset = "0x659C1C0", VA = "0x18659CDC0")]
		public NILPNLJFDCA BKKEPFPDOJH(ulong MIMFBLPNKOG, int NMENOOMOOJP, string GAGCMCLOJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x659DFC0", Offset = "0x659D3C0", VA = "0x18659DFC0")]
		public NILPNLJFDCA PFEFBKFPJAA(byte[] ENFHPFLKGCP, int ELJAGIMMLLH, int EHBDDHCIDOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x659DBB0", Offset = "0x659CFB0", VA = "0x18659DBB0")]
		internal static int IHIOLPIFOAD(ulong[] NCABOBFFNFK, int DIENMHDGFGP, int HKIFHAEDDHO, ulong NMENOOMOOJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x659DB00", Offset = "0x659CF00", VA = "0x18659DB00", Slot = "4")]
		public int CompareTo(NILPNLJFDCA LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x659DB30", Offset = "0x659CF30", VA = "0x18659DB30")]
		[IteratorStateMachine(typeof(MGBDJDMBNLM))]
		public IEnumerable<NILPNLJFDCA> FJCDHJJAOPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x659DC40", Offset = "0x659D040", VA = "0x18659DC40")]
		public void OLCMMPLKPAK(ILGenerator LDKPHNBJGBA, LocalBuilder ENFHPFLKGCP, LocalBuilder EHBDDHCIDOJ, LocalBuilder MIMFBLPNKOG, Action<KeyValuePair<string, int>> NEICLJJFLOI, Action MHKFEFBBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x659CE20", Offset = "0x659C220", VA = "0x18659CE20")]
		private static void CMOKLABFONN(ILGenerator LDKPHNBJGBA, LocalBuilder ENFHPFLKGCP, LocalBuilder EHBDDHCIDOJ, LocalBuilder MIMFBLPNKOG, Action<KeyValuePair<string, int>> NEICLJJFLOI, Action MHKFEFBBKHE, NILPNLJFDCA[] LOLCCPIJNGJ, int APAKJDHFMCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class OFKEDOMHONL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<NILPNLJFDCA> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<NILPNLJFDCA> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<NILPNLJFDCA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NILPNLJFDCA <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x659F7E0", Offset = "0x659EBE0", VA = "0x18659F7E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BCC8A0", Offset = "0x1BCBCA0", VA = "0x181BCC8A0")]
		[DebuggerHidden]
		public OFKEDOMHONL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x659F830", Offset = "0x659EC30", VA = "0x18659F830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x659F230", Offset = "0x659E630", VA = "0x18659F230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x659F690", Offset = "0x659EA90", VA = "0x18659F690")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x659F1E0", Offset = "0x659E5E0", VA = "0x18659F1E0")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x659F790", Offset = "0x659EB90", VA = "0x18659F790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x659F6E0", Offset = "0x659EAE0", VA = "0x18659F6E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x659F6E0", Offset = "0x659EAE0", VA = "0x18659F6E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly NILPNLJFDCA AFFGDBELLLE;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6594760", Offset = "0x6593B60", VA = "0x186594760")]
	public JGOCJFKOPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x65940F0", Offset = "0x65934F0", VA = "0x1865940F0")]
	public void BKKEPFPDOJH(byte[] HPGJIANHJNN, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6594560", Offset = "0x6593960", VA = "0x186594560")]
	public bool GILOFHELLPF(ArraySegment<byte> MIMFBLPNKOG, [Out] int NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x65946D0", Offset = "0x6593AD0", VA = "0x1865946D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6594280", Offset = "0x6593680", VA = "0x186594280")]
	private static void EGBHCHBPEJD(IEnumerable<NILPNLJFDCA> LOLCCPIJNGJ, StringBuilder EPCOKKKGDLF, int KPHHMKNGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6594640", Offset = "0x6593A40", VA = "0x186594640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6594640", Offset = "0x6593A40", VA = "0x186594640", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6594200", Offset = "0x6593600", VA = "0x186594200")]
	[IteratorStateMachine(typeof(OFKEDOMHONL))]
	private static IEnumerable<KeyValuePair<string, int>> CABCDCALKDB(IEnumerable<NILPNLJFDCA> LOLCCPIJNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x65946A0", Offset = "0x6593AA0", VA = "0x1865946A0")]
	public void PCHCIPCJEAN(ILGenerator LDKPHNBJGBA, LocalBuilder ENFHPFLKGCP, LocalBuilder EHBDDHCIDOJ, LocalBuilder MIMFBLPNKOG, Action<KeyValuePair<string, int>> NEICLJJFLOI, Action MHKFEFBBKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class PPCLBJOPMBB
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo LEAPALOLMPE;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x65A0610", Offset = "0x659FA10", VA = "0x1865A0610")]
	public static ulong CBACLHHCEGH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, int EHBDDHCIDOJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class DKLBPDICPMA
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x658B810", Offset = "0x658AC10", VA = "0x18658B810")]
	public static void GJBFFPEHKBH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, int OIMKKCAHKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x658B6F0", Offset = "0x658AAF0", VA = "0x18658B6F0")]
	public static void ELMLDGPLMGK(byte[] NCABOBFFNFK, int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x658B950", Offset = "0x658AD50", VA = "0x18658B950")]
	public static byte[] GNJJIDKAPNI(byte[] BPLFEJNHBNI, int KPPJFIPBECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EOBKGMBMODO
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x658ED70", Offset = "0x658E170", VA = "0x18658ED70")]
	public static bool NLKGOGGMNPH(byte[] LJINICFNPBB, int CJOGKEJMAHA, int HAEBGDIKJBP, byte[] JJDIFFHLICK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class MMANBIJFINJ<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct PBCKPIHPKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] BOGLOOJGMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T ILNPCEAPFCH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2350", Offset = "0x3EB1750", VA = "0x183EB2350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class CKCJMJAOLIF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public MMANBIJFINJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private PBCKPIHPKNK[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private PBCKPIHPKNK[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34B3A60", Offset = "0x34B2E60", VA = "0x1834B3A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public CKCJMJAOLIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4826A40", Offset = "0x4825E40", VA = "0x184826A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4827010", Offset = "0x4826410", VA = "0x184827010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly PBCKPIHPKNK[][] MJDBLPFGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong IKKKCLPDBNF;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3CD94C0", Offset = "0x3CD88C0", VA = "0x183CD94C0")]
	public MMANBIJFINJ(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9400", Offset = "0x3CD8800", VA = "0x183CD9400")]
	public MMANBIJFINJ(int EKJEIMGCNCB, float FAAAHIGDABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3A40", Offset = "0x3CD2E40", VA = "0x183CD3A40")]
	public void BKKEPFPDOJH(byte[] MIMFBLPNKOG, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3CD62F0", Offset = "0x3CD56F0", VA = "0x183CD62F0")]
	private bool NNKBFDGLJEL(byte[] MIMFBLPNKOG, T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1090", Offset = "0x3CD0490", VA = "0x183CD1090")]
	public bool AFCHMNEGHNL(ArraySegment<byte> MIMFBLPNKOG, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3CD46B0", Offset = "0x3CD3AB0", VA = "0x183CD46B0")]
	private static ulong JDOBNLIGKMD(byte[] OPHKAEHAFCM, int ELJAGIMMLLH, int APAKJDHFMCK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3CD93D0", Offset = "0x3CD87D0", VA = "0x183CD93D0")]
	private static int PFDONLOKHBE(int DOAIFFFJHLC, float FAAAHIGDABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4500", Offset = "0x3CD3900", VA = "0x183CD4500", Slot = "4")]
	[IteratorStateMachine(typeof(MMANBIJFINJ<>.CKCJMJAOLIF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33C59A0", Offset = "0x33C4DA0", VA = "0x1833C59A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class CAHAIDLONMA : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] IIPEGCPLBIE;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] EEAOOADBFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int ILDNNJIOMDG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IJPLHLFNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x658A510", Offset = "0x6589910", VA = "0x18658A510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x658A660", Offset = "0x6589A60", VA = "0x18658A660")]
	static CAHAIDLONMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x658A8C0", Offset = "0x6589CC0", VA = "0x18658A8C0")]
	public CAHAIDLONMA(byte[] IPBHAAFOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x658A560", Offset = "0x6589960", VA = "0x18658A560")]
	public OpCode FEDAPCIBMEM()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct ELAPGJBGCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid ILNPCEAPFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JPEMDLDNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte FELLGHLMPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JBFABMJMOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte ONLHNFAMPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte GONDHEBHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte DKCNDAILFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte MPFMAOFEMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte PECIIBIJEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte BGLDLGLOAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GLLGJAHDMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte IKKNPHOCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte AKEPLDECIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte GKMEJMKNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte MMFKCOANPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HKDKCIKLIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte DGEBCCJIAIC;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] BCOKAOLIAFJ;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] EICMCIKKOIC;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x658D440", Offset = "0x658C840", VA = "0x18658D440")]
	public ELAPGJBGCPL(Guid NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x658D450", Offset = "0x658C850", VA = "0x18658D450")]
	public ELAPGJBGCPL(ArraySegment<byte> GMLGMJPHPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x658C600", Offset = "0x658BA00", VA = "0x18658C600")]
	private static byte BMGCABDGNEC(byte[] HPGJIANHJNN, int LNJDIGOPEHP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x658C4E0", Offset = "0x658B8E0", VA = "0x18658C4E0")]
	private static byte BBOKJEIDDMK(byte MLKGDIFPGGI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x658C6A0", Offset = "0x658BAA0", VA = "0x18658C6A0")]
	public void OMAJEIBBGKE(byte[] PNJHGINLCID, int ELJAGIMMLLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class KPFBALMEHKC
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x65970C0", Offset = "0x65964C0", VA = "0x1865970C0")]
	public static bool INMHGMDEIJG(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x65965A0", Offset = "0x65959A0", VA = "0x1865965A0")]
	public static bool DBEJGFBKDBL(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x65970D0", Offset = "0x65964D0", VA = "0x1865970D0")]
	public static sbyte KBFMJOGABOF(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x65962B0", Offset = "0x65956B0", VA = "0x1865962B0")]
	public static short BKNGJENCFCH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6597480", Offset = "0x6596880", VA = "0x186597480")]
	public static int MCMNIGONMKJ(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x65973E0", Offset = "0x65967E0", VA = "0x1865973E0")]
	public static long LHMCMHDJEID(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6596410", Offset = "0x6595810", VA = "0x186596410")]
	public static byte CCJANAADGKD(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6597570", Offset = "0x6596970", VA = "0x186597570")]
	public static ushort NJLHMKLFJKH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6596610", Offset = "0x6595A10", VA = "0x186596610")]
	public static uint DCEHLEOPJHI(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6596490", Offset = "0x6595890", VA = "0x186596490")]
	public static ulong CIBJNOKILNF(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x65963A0", Offset = "0x65957A0", VA = "0x1865963A0")]
	public static float BPAILFIOIGE(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6597050", Offset = "0x6596450", VA = "0x186597050")]
	public static double IANMBMAHIAA(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x65975F0", Offset = "0x65969F0", VA = "0x1865975F0")]
	public static int NMHGFFKKICL(byte[] PNJHGINLCID, int ELJAGIMMLLH, ulong NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6596690", Offset = "0x6595A90", VA = "0x186596690")]
	public static int HCLKEMNIMIJ(byte[] PNJHGINLCID, int ELJAGIMMLLH, long NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x65971B0", Offset = "0x65965B0", VA = "0x1865971B0")]
	public static bool KGGCMIHBMBK(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class HBFOFKHNMBM
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class GCJLJDOFIJD : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA50", Offset = "0x8EBE50", VA = "0x1808ECA50")]
		[DebuggerHidden]
		public GCJLJDOFIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6592050", Offset = "0x6591450", VA = "0x186592050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6591AC0", Offset = "0x6590EC0", VA = "0x186591AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6591EF0", Offset = "0x65912F0", VA = "0x186591EF0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6591A70", Offset = "0x6590E70", VA = "0x186591A70")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6592000", Offset = "0x6591400", VA = "0x186592000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6591F40", Offset = "0x6591340", VA = "0x186591F40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6591F40", Offset = "0x6591340", VA = "0x186591F40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class PFMBCLIIION : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA50", Offset = "0x8EBE50", VA = "0x1808ECA50")]
		[DebuggerHidden]
		public PFMBCLIIION(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x65A0280", Offset = "0x659F680", VA = "0x1865A0280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x659FCF0", Offset = "0x659F0F0", VA = "0x18659FCF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x65A0120", Offset = "0x659F520", VA = "0x1865A0120")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x659FCA0", Offset = "0x659F0A0", VA = "0x18659FCA0")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x65A0230", Offset = "0x659F630", VA = "0x1865A0230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x65A0170", Offset = "0x659F570", VA = "0x1865A0170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x65A0170", Offset = "0x659F570", VA = "0x1865A0170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6592F70", Offset = "0x6592370", VA = "0x186592F70")]
	public static bool AICPMDKKPOA(this TypeInfo LFLAEPCPMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6593030", Offset = "0x6592430", VA = "0x186593030")]
	public static bool CHPCDFAFLGE(this TypeInfo LFLAEPCPMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6593320", Offset = "0x6592720", VA = "0x186593320")]
	public static IEnumerable<PropertyInfo> OAKBGEIOJCH(this Type LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6593280", Offset = "0x6592680", VA = "0x186593280")]
	[IteratorStateMachine(typeof(GCJLJDOFIJD))]
	private static IEnumerable<PropertyInfo> MDEPCJJONAJ(Type LFLAEPCPMDG, HashSet<string> DDLBGGEFPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6593200", Offset = "0x6592600", VA = "0x186593200")]
	public static IEnumerable<FieldInfo> KPMAKLOOPCC(this Type LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6593160", Offset = "0x6592560", VA = "0x186593160")]
	[IteratorStateMachine(typeof(PFMBCLIIION))]
	private static IEnumerable<FieldInfo> JCCDHLPOGHG(Type LFLAEPCPMDG, HashSet<string> DDLBGGEFPDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class FHHLLBKCPMI
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding PFCGNMADHHP;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class CIHHCCKNJPH
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60")]
	public static string MEECKKNBILE(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x658AE10", Offset = "0x658A210", VA = "0x18658AE10")]
	public static string JFLDPKEKOCI(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x658AC80", Offset = "0x658A080", VA = "0x18658AC80")]
	public static string ECHPOBANOIH(string BCMGDCDFIPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class CJHBBAIALEN<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class PBIEAJDIGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type BOGLOOJGMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue ILNPCEAPFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int KPFJHGNEGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public PBIEAJDIGKK JGBDDJFAKIG;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3EB99A0", Offset = "0x3EB8DA0", VA = "0x183EB99A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9850", Offset = "0x3EB8C50", VA = "0x183EB9850")]
		private int AEFHJLMLIJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PBIEAJDIGKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class PJGNNGPOPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PJGNNGPOPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90")]
		internal TValue NHKHJILIFFG(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private PBIEAJDIGKK[] MJDBLPFGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int PEGIIHFIAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object CDFPEKJOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float FAAAHIGDABH;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4823A30", Offset = "0x4822E30", VA = "0x184823A30")]
	public CJHBBAIALEN(int EKJEIMGCNCB = 4, float FAAAHIGDABH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4822910", Offset = "0x4821D10", VA = "0x184822910")]
	public bool BMPLIEBGIDJ(Type MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x48228D0", Offset = "0x4821CD0", VA = "0x1848228D0")]
	public bool BMPLIEBGIDJ(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x48236D0", Offset = "0x4822AD0", VA = "0x1848236D0")]
	private bool NNKBFDGLJEL(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM, [Out] TValue BPHGAIHGBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x4822F80", Offset = "0x4822380", VA = "0x184822F80")]
	private bool JFGPNNLJBFJ(PBIEAJDIGKK[] MJDBLPFGMGF, Type KGHLDIHJPKE, PBIEAJDIGKK HKHABHOFFNJ, Func<Type, TValue> FHBCEADFDBM, [Out] TValue BPHGAIHGBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x48224E0", Offset = "0x48218E0", VA = "0x1848224E0")]
	public bool AFCHMNEGHNL(Type MIMFBLPNKOG, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x4822A70", Offset = "0x4821E70", VA = "0x184822A70")]
	public TValue FNLFIKFJFDE(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD93D0", Offset = "0x3CD87D0", VA = "0x183CD93D0")]
	private static int PFDONLOKHBE(int DOAIFFFJHLC, float FAAAHIGDABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4822A40", Offset = "0x4821E40", VA = "0x184822A40")]
	private static void EANACHGPNCB(PBIEAJDIGKK IKHOJOLHDEK, PBIEAJDIGKK NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4822A40", Offset = "0x4821E40", VA = "0x184822A40")]
	private static void EANACHGPNCB(PBIEAJDIGKK[] IKHOJOLHDEK, PBIEAJDIGKK[] NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class EDGFJJCKCKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder NKNOFGLLIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder CKHPHCCNLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object ECPKABAPMNH;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x658C0D0", Offset = "0x658B4D0", VA = "0x18658C0D0")]
	public TypeBuilder GKPHNACHPON(string MDFAJJKMBAI, TypeAttributes KNBDCDCCHPE, Type ECLIMLPEPIL, Type[] AIHMGABFDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x658C1D0", Offset = "0x658B5D0", VA = "0x18658C1D0")]
	public EDGFJJCKCKN(string LDGEODIDJLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class LEBKJJFMNNA
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6597C90", Offset = "0x6597090", VA = "0x186597C90")]
	private static MethodInfo KLBONDCGEJL(LambdaExpression LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2581750", Offset = "0x2580B50", VA = "0x182581750")]
	public static MethodInfo DPOCEHNPBHH<T>(Expression<Func<T>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2581750", Offset = "0x2580B50", VA = "0x182581750")]
	public static MethodInfo DPOCEHNPBHH<T, TR>(Expression<Func<T, TR>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2581750", Offset = "0x2580B50", VA = "0x182581750")]
	public static MethodInfo DPOCEHNPBHH<T>(Expression<Action<T>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2581750", Offset = "0x2580B50", VA = "0x182581750")]
	public static MethodInfo DPOCEHNPBHH<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2581800", Offset = "0x2580C00", VA = "0x182581800")]
	private static MemberInfo OHCIAECFPJL<T>(Expression<T> HFLNDIDMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2581760", Offset = "0x2580B60", VA = "0x182581760")]
	public static PropertyInfo JEADEHNNHAI<T, TR>(Expression<Func<T, TR>> LFCMKINGPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct BFFGOOHOALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int JNJOJJJELGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool AOKEMINNDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator LDKPHNBJGBA;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6589550", Offset = "0x6588950", VA = "0x186589550")]
	public BFFGOOHOALI(ILGenerator LDKPHNBJGBA, int JNJOJJJELGE, bool AOKEMINNDOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x65894C0", Offset = "0x65888C0", VA = "0x1865894C0")]
	public BFFGOOHOALI(ILGenerator LDKPHNBJGBA, int JNJOJJJELGE, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x65893C0", Offset = "0x65887C0", VA = "0x1865893C0")]
	public void IGCEKMDBMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class MJBEDGENHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x659AB20", Offset = "0x6599F20", VA = "0x18659AB20")]
	public static void HCFNLIOJNDA(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x659AAE0", Offset = "0x6599EE0", VA = "0x18659AAE0")]
	public static void HCFNLIOJNDA(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x659B0F0", Offset = "0x659A4F0", VA = "0x18659B0F0")]
	public static void JEJANMHCBDL(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x659B2E0", Offset = "0x659A6E0", VA = "0x18659B2E0")]
	public static void JEJANMHCBDL(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x659B4F0", Offset = "0x659A8F0", VA = "0x18659B4F0")]
	public static void OMFALJGHEEN(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x659B5D0", Offset = "0x659A9D0", VA = "0x18659B5D0")]
	public static void OMFALJGHEEN(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x659B3C0", Offset = "0x659A7C0", VA = "0x18659B3C0")]
	public static void MGIHBJLIAOK(this ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x659A9F0", Offset = "0x6599DF0", VA = "0x18659A9F0")]
	public static void ENBDEHFFDKK(this ILGenerator LDKPHNBJGBA, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x659AD10", Offset = "0x659A110", VA = "0x18659AD10")]
	public static void HOPNPJBDHFL(this ILGenerator LDKPHNBJGBA, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x659AA00", Offset = "0x6599E00", VA = "0x18659AA00")]
	public static void GCGFDKBPMHF(this ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x659B320", Offset = "0x659A720", VA = "0x18659B320")]
	public static void KIPHEANDELJ(this ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x659A5B0", Offset = "0x65999B0", VA = "0x18659A5B0")]
	public static void AEOKCIAJMMJ(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x659A970", Offset = "0x6599D70", VA = "0x18659A970")]
	public static void DDMDFLPGOAP(this ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x659A890", Offset = "0x6599C90", VA = "0x18659A890")]
	public static void AJIFCMBBNCH(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x659A7A0", Offset = "0x6599BA0", VA = "0x18659A7A0")]
	public static void AHPEOJGLMCD(this ILGenerator LDKPHNBJGBA, MethodInfo BFEODAFDFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x659B460", Offset = "0x659A860", VA = "0x18659B460")]
	public static void OJFIIFGIJNL(this ILGenerator LDKPHNBJGBA, FieldInfo KBHJNOPKNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x659B3D0", Offset = "0x659A7D0", VA = "0x18659B3D0")]
	public static void OGLOKNAGNJI(this ILGenerator LDKPHNBJGBA, ulong NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class GPLPOGHBDHO
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class PDAPLECJNIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PDAPLECJNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x659FB90", Offset = "0x659EF90", VA = "0x18659FB90")]
		internal bool KENMCEKNHBN(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo OCMFCGPEJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MKFMMFFKLPJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NNPGDGNCDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OCLIECDLGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6592C10", Offset = "0x6592010", VA = "0x186592C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FIFNGFKPHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772C20", VA = "0x180773820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x773870", Offset = "0x772C70", VA = "0x180773870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KNHDMNBIEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x883860", Offset = "0x882C60", VA = "0x180883860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x883550", Offset = "0x882950", VA = "0x180883550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MELBEGGEDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo MAEDOGAMFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo DCPNDHNNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DDADJHJHDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x775860", Offset = "0x774C60", VA = "0x180775860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6592C20", Offset = "0x6592020", VA = "0x186592C20")]
	protected GPLPOGHBDHO(Type LFLAEPCPMDG, string MDFAJJKMBAI, string CADJHIEGOKJ, bool CFEKLNBCHKF, bool EFBHNJNLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6592E60", Offset = "0x6592260", VA = "0x186592E60")]
	public GPLPOGHBDHO(FieldInfo PPPGPJEJFAJ, string MDFAJJKMBAI, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6592CA0", Offset = "0x65920A0", VA = "0x186592CA0")]
	public GPLPOGHBDHO(PropertyInfo PPPGPJEJFAJ, string MDFAJJKMBAI, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65927A0", Offset = "0x6591BA0", VA = "0x1865927A0")]
	private static MethodInfo DPOHGHHJHDN(MemberInfo PPPGPJEJFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2529A00", Offset = "0x2528E00", VA = "0x182529A00")]
	public T HIOFJGKGPKJ<T>(bool OKKEPLFBDBF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6592910", Offset = "0x6591D10", VA = "0x186592910", Slot = "4")]
	public virtual void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6592A90", Offset = "0x6591E90", VA = "0x186592A90", Slot = "5")]
	public virtual void MNDBKFFJKNI(ILGenerator LDKPHNBJGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class HJOPBPGHPLH : GPLPOGHBDHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string FFOEBKJHLKM;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6593840", Offset = "0x6592C40", VA = "0x186593840")]
	public HJOPBPGHPLH(string MDFAJJKMBAI, string FFOEBKJHLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6593740", Offset = "0x6592B40", VA = "0x186593740", Slot = "4")]
	public override void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x65937F0", Offset = "0x6592BF0", VA = "0x1865937F0", Slot = "5")]
	public override void MNDBKFFJKNI(ILGenerator LDKPHNBJGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class OBNPLNHFGGM : GPLPOGHBDHO
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo NFOHPDJOFCF;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo JFILAKGIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal BFFGOOHOALI GDONJOPBCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal BFFGOOHOALI HOCMDHEFHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal BFFGOOHOALI CFKKMPPKIAC;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x659EFA0", Offset = "0x659E3A0", VA = "0x18659EFA0")]
	public OBNPLNHFGGM(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x659E7C0", Offset = "0x659DBC0", VA = "0x18659E7C0", Slot = "4")]
	public override void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x659E880", Offset = "0x659DC80", VA = "0x18659E880", Slot = "5")]
	public override void MNDBKFFJKNI(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x659E8D0", Offset = "0x659DCD0", VA = "0x18659E8D0")]
	public void POBGFEMNHGF(ILGenerator LDKPHNBJGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class JNCDAPNGHKD
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MELBEGGEDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HDACJPCCHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F2620", VA = "0x1807F3220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x77FF70", Offset = "0x77F370", VA = "0x18077FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KPJAJBBKEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x87C330", Offset = "0x87B730", VA = "0x18087C330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87C150", Offset = "0x87B550", VA = "0x18087C150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo ACKDLPCDDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GPLPOGHBDHO[] OIKNIBNAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GPLPOGHBDHO[] JFCJIOFANAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x65948C0", Offset = "0x6593CC0", VA = "0x1865948C0")]
	public JNCDAPNGHKD(Type LFLAEPCPMDG, Func<string, string> CPNKKEMBDLA, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x65947E0", Offset = "0x6593BE0", VA = "0x1865947E0")]
	private static bool PFECHHEAPMA(IEnumerator<ConstructorInfo> KDHPCAFBCIL, ConstructorInfo DJPOOBIDDKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct NNPGNDBKKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong FJJLEFEGIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int GAFOFJBHEBN;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD2B0", Offset = "0x1CFC6B0", VA = "0x181CFD2B0")]
	public NNPGNDBKKGD(ulong LJLDAGOJCHJ, int KHOKKOOKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x659E410", Offset = "0x659D810", VA = "0x18659E410")]
	public void APEPFHHKOGL(NNPGNDBKKGD LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x659E420", Offset = "0x659D820", VA = "0x18659E420")]
	public static NNPGNDBKKGD EEBKPIMJOIN(NNPGNDBKKGD JMHOJIPAIMC, NNPGNDBKKGD MLKGDIFPGGI)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x659E4C0", Offset = "0x659D8C0", VA = "0x18659E4C0")]
	public void NOOBKPOBMLO(NNPGNDBKKGD LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x659E550", Offset = "0x659D950", VA = "0x18659E550")]
	public static NNPGNDBKKGD OOJJMOPCDBN(NNPGNDBKKGD JMHOJIPAIMC, NNPGNDBKKGD MLKGDIFPGGI)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x659E480", Offset = "0x659D880", VA = "0x18659E480")]
	public void FHLNPMFHEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x659E430", Offset = "0x659D830", VA = "0x18659E430")]
	public static NNPGNDBKKGD FHLNPMFHEJE(NNPGNDBKKGD JMHOJIPAIMC)
	{
		return default(NNPGNDBKKGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct FAGFICEFCKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] PNJHGINLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int ELJAGIMMLLH;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1750100", Offset = "0x174F500", VA = "0x181750100")]
	public FAGFICEFCKP(byte[] PNJHGINLCID, int JCADPOBEOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6587240", Offset = "0x6586640", VA = "0x186587240")]
	public void AMAAIHMBIBF(byte DFBAIJNHOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x658F120", Offset = "0x658E520", VA = "0x18658F120")]
	public void NAIAJFMCFDN(byte[] DFBAIJNHOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x658EE80", Offset = "0x658E280", VA = "0x18658EE80")]
	public void CHMPKMBEMMM(byte[] DFBAIJNHOKM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x658EF00", Offset = "0x658E300", VA = "0x18658EF00")]
	public void CHMPKMBEMMM(byte[] DFBAIJNHOKM, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x658F0A0", Offset = "0x658E4A0", VA = "0x18658F0A0")]
	public void KLOLGOJKFCG(byte CPHKPECCMOM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x658EFA0", Offset = "0x658E3A0", VA = "0x18658EFA0")]
	public void KFNPPGKEEOD(string DFBAIJNHOKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class MIBOHDFBPDA
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum POKEKIFFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum LIMNCGIHBLH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum MHHENHNDADD
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
	private static byte[] DHGBHNHIDJD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] PDBBGEHBPHO;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] EACBBHGIKGD;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] BCMEFKJIODP;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly MHHENHNDADD EDFCHMHBMII;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char FFLIGFFNGEI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int PILGHIKBMDH;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int PHEHMILJEJF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] DPNHHAILONL;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x65985F0", Offset = "0x65979F0", VA = "0x1865985F0")]
	private static byte[] CAKOONCMPAC(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6598890", Offset = "0x6597C90", VA = "0x186598890")]
	private static byte[] CMOLCDJHAIO(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x65983B0", Offset = "0x65977B0", VA = "0x1865983B0")]
	public static int BKJAGJEBDAE(byte[] PNJHGINLCID, int ELJAGIMMLLH, float NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65984D0", Offset = "0x65978D0", VA = "0x1865984D0")]
	public static int BKJAGJEBDAE(byte[] PNJHGINLCID, int ELJAGIMMLLH, double NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6599E40", Offset = "0x6599240", VA = "0x186599E40")]
	private static bool MDAGGPAIDKL(byte[] PNJHGINLCID, int HKIFHAEDDHO, ulong JNFHMIJCCBA, ulong KNBKPMDEAHN, ulong EHBDDHCIDOJ, ulong HNAACHDEIJA, ulong HINJBFJJDNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6598970", Offset = "0x6597D70", VA = "0x186598970")]
	private static void DAFEDPNALKG(uint LJGBMIIMMGB, int CDIEFGMHAIC, [Out] uint OKFMFLEOHED, [Out] int NLLCODEPOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6599940", Offset = "0x6598D40", VA = "0x186599940")]
	private static bool KOPOFGNDGNF(NNPGNDBKKGD KBJEEPCDFIB, NNPGNDBKKGD IKENEDAFBLJ, NNPGNDBKKGD DDHOAELOJIH, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int JLGMFCJGFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6598F40", Offset = "0x6598340", VA = "0x186598F40")]
	private static bool HCMJEIDBJOO(double JEEPLNLHGDO, POKEKIFFKMI LEIDKMNBCMF, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int GNIGBAHGLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6599D30", Offset = "0x6599130", VA = "0x186599D30")]
	private static bool LJGICJCFBEJ(double JEEPLNLHGDO, POKEKIFFKMI LEIDKMNBCMF, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int CPCMMEDMAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x65986C0", Offset = "0x6597AC0", VA = "0x1865986C0")]
	private static bool CBFIBOKLGON(double NMENOOMOOJP, FAGFICEFCKP KIOPOHNNGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6598A60", Offset = "0x6597E60", VA = "0x186598A60")]
	private static bool DDCGMNNKNHC(double NMENOOMOOJP, FAGFICEFCKP KIOPOHNNGHC, LIMNCGIHBLH LEIDKMNBCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x65993C0", Offset = "0x65987C0", VA = "0x1865993C0")]
	private static void KLOBBLBJKCN(byte[] IPMIEKNDOBH, int HKIFHAEDDHO, int CPCMMEDMAGN, int COGFKPGAIPJ, FAGFICEFCKP KIOPOHNNGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6599F30", Offset = "0x6599330", VA = "0x186599F30")]
	private static void PCPHKFKHPNO(byte[] IPMIEKNDOBH, int HKIFHAEDDHO, int KHOKKOOKFDN, FAGFICEFCKP KIOPOHNNGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6599750", Offset = "0x6598B50", VA = "0x186599750")]
	private static bool KMOBEDFENJE(double JEEPLNLHGDO, LIMNCGIHBLH LEIDKMNBCMF, int OEGBHFDBKIF, byte[] HGPHGPPDDCM, [Out] bool BCAIDCNGNOP, [Out] int HKIFHAEDDHO, [Out] int GGCAPAPOAOA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct NMKGGMLLOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double IIPNDJEHBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong NIMEFJPHIEH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct MNHACPJGLIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float FJJLEFEGIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint BAGJDFIKBAN;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct HLBLOLPMKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong ICBAAMDDODJ;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6593EB0", Offset = "0x65932B0", VA = "0x186593EB0")]
	public HLBLOLPMKEA(double IIPNDJEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6593EC0", Offset = "0x65932C0", VA = "0x186593EC0")]
	public HLBLOLPMKEA(NNPGNDBKKGD IIPNDJEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6593C00", Offset = "0x6593000", VA = "0x186593C00")]
	public NNPGNDBKKGD IADNIKBMMHF()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6593C70", Offset = "0x6593070", VA = "0x186593C70")]
	public NNPGNDBKKGD KBADHHDGICG()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBD40", VA = "0x1807DC940")]
	public ulong OOFKFCGJPLA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6593E30", Offset = "0x6593230", VA = "0x186593E30")]
	public double PIKCJKIODHH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6593CF0", Offset = "0x65930F0", VA = "0x186593CF0")]
	public double KDKBFFGCOEN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6593920", Offset = "0x6592D20", VA = "0x186593920")]
	public int ANDKPDFCAOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6593AA0", Offset = "0x6592EA0", VA = "0x186593AA0")]
	public ulong FBIJMOIHNJA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6593DC0", Offset = "0x65931C0", VA = "0x186593DC0")]
	public bool LMPEGMGMKNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6593E10", Offset = "0x6593210", VA = "0x186593E10")]
	public bool OLFOPLMIGGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6593DE0", Offset = "0x65931E0", VA = "0x186593DE0")]
	public bool OGHIINEOJKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6593AD0", Offset = "0x6592ED0", VA = "0x186593AD0")]
	public bool FCCDOBDHMOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6593D90", Offset = "0x6593190", VA = "0x186593D90")]
	public int KIAIIJENGBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6593950", Offset = "0x6592D50", VA = "0x186593950")]
	public void CLEGLPLLGKF([Out] NNPGNDBKKGD MJCFLIHBNPM, [Out] NNPGNDBKKGD MLHPGJOLIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6593B90", Offset = "0x6592F90", VA = "0x186593B90")]
	public bool GOKCJEGNDLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5230", Offset = "0x2AC4630", VA = "0x182AC5230")]
	public double NMENOOMOOJP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6593BE0", Offset = "0x6592FE0", VA = "0x186593BE0")]
	public static int HONMLMDNIBD(int KNKCFCGHKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6593DB0", Offset = "0x65931B0", VA = "0x186593DB0")]
	public static double KKGCBAGDGGD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6593B00", Offset = "0x6592F00", VA = "0x186593B00")]
	public static ulong FLNLAICFBFE(NNPGNDBKKGD AMJGHMAOOJF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct OHFFINHFDFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint KFCHKANCGPL;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x201FB40", Offset = "0x201EF40", VA = "0x18201FB40")]
	public OHFFINHFDFN(float FJJLEFEGIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x659FB30", Offset = "0x659EF30", VA = "0x18659FB30")]
	public NNPGNDBKKGD IADNIKBMMHF()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x86A070", Offset = "0x869470", VA = "0x18086A070")]
	public uint BIGAKNEOFPF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x659F980", Offset = "0x659ED80", VA = "0x18659F980")]
	public int ANDKPDFCAOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x659FAD0", Offset = "0x659EED0", VA = "0x18659FAD0")]
	public uint FBIJMOIHNJA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x659FB80", Offset = "0x659EF80", VA = "0x18659FB80")]
	public bool LMPEGMGMKNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x659F9A0", Offset = "0x659EDA0", VA = "0x18659F9A0")]
	public void CLEGLPLLGKF([Out] NNPGNDBKKGD MJCFLIHBNPM, [Out] NNPGNDBKKGD MLHPGJOLIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x659FAF0", Offset = "0x659EEF0", VA = "0x18659FAF0")]
	public bool GOKCJEGNDLC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct JGJOPNMIBID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong LJLDAGOJCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short PMLLOPDPBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short GNIGBAHGLKN;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x65940E0", Offset = "0x65934E0", VA = "0x1865940E0")]
	public JGJOPNMIBID(ulong LJLDAGOJCHJ, short PMLLOPDPBLL, short GNIGBAHGLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class MLPHPPLCHOM
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly JGJOPNMIBID[] EJDOAOIDBNH;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x659B6D0", Offset = "0x659AAD0", VA = "0x18659B6D0")]
	public static void BDOGFLLIHGD(int IBALNNMOLCL, int GIKJCHKLCJL, [Out] NNPGNDBKKGD OKFMFLEOHED, [Out] int GNIGBAHGLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x659B7E0", Offset = "0x659ABE0", VA = "0x18659B7E0")]
	public static void LFIBEDGHEML(int ELAPNHNFDIM, [Out] NNPGNDBKKGD OKFMFLEOHED, [Out] int DOBLLPKNILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct FADMEACGLJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] HPGJIANHJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int DFOEGCCLIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int CJGMBOOLLBO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x658EE40", Offset = "0x658E240", VA = "0x18658EE40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x376C710", Offset = "0x376BB10", VA = "0x18376C710")]
	public FADMEACGLJJ(byte[] HPGJIANHJNN, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2050330", Offset = "0x204F730", VA = "0x182050330")]
	public int HKIFHAEDDHO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x658EDE0", Offset = "0x658E1E0", VA = "0x18658EDE0")]
	public FADMEACGLJJ FKPLCAKHOKH(int LCCHDAEMOKL, int DNLOCNBCDGI)
	{
		return default(FADMEACGLJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class FNCPKMIAKDO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] HPDOOLLACMK;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] JNONFDDKKAM;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int EAGDNKMCDKC;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6590530", Offset = "0x658F930", VA = "0x186590530")]
	private static byte[] FJKBHNCCLCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x65900F0", Offset = "0x658F4F0", VA = "0x1865900F0")]
	private static FADMEACGLJJ BCGAKLGCCLJ(FADMEACGLJJ PNJHGINLCID)
	{
		return default(FADMEACGLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6591690", Offset = "0x6590A90", VA = "0x186591690")]
	private static FADMEACGLJJ KGAJNFLONCF(FADMEACGLJJ PNJHGINLCID)
	{
		return default(FADMEACGLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x65904A0", Offset = "0x658F8A0", VA = "0x1865904A0")]
	private static void CNLJFLJFBJM(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, byte[] PDHHOPLLMPB, [Out] int CNFONGLDFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6590E00", Offset = "0x6590200", VA = "0x186590E00")]
	private static void GMIJLOJMIJP(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, byte[] KFPBEKILNIP, int GEOCPBEPAOI, [Out] FADMEACGLJJ FLHKDFHONLD, [Out] int PBIHIPAMKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x65910F0", Offset = "0x65904F0", VA = "0x1865910F0")]
	private static ulong HHDLAGJCIFP(FADMEACGLJJ PNJHGINLCID, [Out] int BJKCCKPJMOA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6591550", Offset = "0x6590950", VA = "0x186591550")]
	private static void KDGPGPLFJCH(FADMEACGLJJ PNJHGINLCID, [Out] NNPGNDBKKGD KHFCBCPBAFG, [Out] int EABAPDMKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6591180", Offset = "0x6590580", VA = "0x186591180")]
	private static bool HNCLOCGOINK(FADMEACGLJJ FLHKDFHONLD, int KHOKKOOKFDN, [Out] double KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6590610", Offset = "0x658FA10", VA = "0x186590610")]
	private static NNPGNDBKKGD GGDBBGJPODO(int KHOKKOOKFDN)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x65907B0", Offset = "0x658FBB0", VA = "0x1865907B0")]
	private static bool GGGHJPHMIPP(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, [Out] double KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6591890", Offset = "0x6590C90", VA = "0x186591890")]
	private static bool MNIBFGPAGHC(FADMEACGLJJ FLHKDFHONLD, int KHOKKOOKFDN, [Out] double PJMNDIEKGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6591770", Offset = "0x6590B70", VA = "0x186591770")]
	public static double? KPJIALFBGHK(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65901D0", Offset = "0x658F5D0", VA = "0x1865901D0")]
	public static float? BJIHNGOLDAE(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct GELMIKFEDCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] PNJHGINLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int ELJAGIMMLLH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x65AB140", Offset = "0x65AA540", VA = "0x1865AB140")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1750100", Offset = "0x174F500", VA = "0x181750100")]
	public GELMIKFEDCF(byte[] PNJHGINLCID, int ELJAGIMMLLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x65AB020", Offset = "0x65AA420", VA = "0x1865AB020")]
	public static GELMIKFEDCF DJCHIPEGFMB(GELMIKFEDCF EAODMOEAJOC)
	{
		return default(GELMIKFEDCF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65AB030", Offset = "0x65AA430", VA = "0x1865AB030")]
	public static GELMIKFEDCF EHMNDHCEEPM(GELMIKFEDCF EAODMOEAJOC, int HKIFHAEDDHO)
	{
		return default(GELMIKFEDCF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65AB100", Offset = "0x65AA500", VA = "0x1865AB100")]
	public static int HNODHDMLJNN(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65AB0B0", Offset = "0x65AA4B0", VA = "0x1865AB0B0")]
	public static bool FCHDBNDMOOD(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65AB0F0", Offset = "0x65AA4F0", VA = "0x1865AB0F0")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65AB080", Offset = "0x65AA480", VA = "0x1865AB080")]
	public static bool FCHDBNDMOOD(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65AB0C0", Offset = "0x65AA4C0", VA = "0x1865AB0C0")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65AB0C0", Offset = "0x65AA4C0", VA = "0x1865AB0C0")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, byte EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65AB110", Offset = "0x65AA510", VA = "0x1865AB110")]
	public static bool JKIFMIBKGAF(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFF0", Offset = "0x65AA3F0", VA = "0x1865AAFF0")]
	public static bool CCPAOAGPDNI(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65AB170", Offset = "0x65AA570", VA = "0x1865AB170")]
	public static bool PIEBNEDGCNB(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFC0", Offset = "0x65AA3C0", VA = "0x1865AAFC0")]
	public static bool BHJJKDKPHAP(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class GEGHNNCDHLB
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] JEFMPBEOLIG;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] EFPKJDOCNED;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] EACBBHGIKGD;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] BCMEFKJIODP;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] HHHBLHOJKMH;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int BFJDMHJPICK;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] PKFCANHGNMG;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int AEEOBIKKKFK;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x65A98F0", Offset = "0x65A8CF0", VA = "0x1865A98F0")]
	private static byte[] FNHNFNKCDEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65AA850", Offset = "0x65A9C50", VA = "0x1865AA850")]
	private static byte[] HFGMHJBCOAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65AAA50", Offset = "0x65A9E50", VA = "0x1865AAA50")]
	public static double KONPEDFKFNP(byte[] PNJHGINLCID, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65AAB00", Offset = "0x65A9F00", VA = "0x1865AAB00")]
	public static float LLGLGCALBFI(byte[] PNJHGINLCID, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65AABB0", Offset = "0x65A9FB0", VA = "0x1865AABB0")]
	private static bool PNPOKGKHHLG(int OPHKAEHAFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65A9700", Offset = "0x65A8B00", VA = "0x1865A9700")]
	private static bool BLKPNKIILJP(GELMIKFEDCF KANFMCPNFBA, GELMIKFEDCF CBMPBFEPCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65AA980", Offset = "0x65A9D80", VA = "0x1865AA980")]
	private static bool JHKACCHOOGL(GELMIKFEDCF KANFMCPNFBA, GELMIKFEDCF CBMPBFEPCHD, byte[] PHKOMDAOFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x65AA930", Offset = "0x65A9D30", VA = "0x1865AA930")]
	private static bool JAFNEFKNNEB(GELMIKFEDCF FBAAIOOIDIH, byte[] DFBAIJNHOKM, int ELJAGIMMLLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65AACF0", Offset = "0x65AA0F0", VA = "0x1865AACF0")]
	private static double PPLJGCHDEJN(bool BCAIDCNGNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65A99D0", Offset = "0x65A8DD0", VA = "0x1865A99D0")]
	private static double HEOOILNIDIG(GELMIKFEDCF CGOLCEEBMBE, int HKIFHAEDDHO, bool GCDKHOAHBFL, [Out] int HJEHDODLKBL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class KLKACGBBKPJ<T> : HIPKPDINGJD<T[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly NJLGHCBJBBJ<T> DICHKDGEBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly EIDNECPPKDC NIOIDOPMDFA;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x30F71E0", Offset = "0x30F65E0", VA = "0x1830F71E0")]
	public KLKACGBBKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
	public KLKACGBBKPJ(EIDNECPPKDC NIOIDOPMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x39C6990", Offset = "0x39C5D90", VA = "0x1839C6990", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x39C8770", Offset = "0x39C7B70", VA = "0x1839C8770", Slot = "5")]
	public T[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class KIGFGHNOBKF<T> : HIPKPDINGJD<ArraySegment<T>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly NJLGHCBJBBJ<T> DICHKDGEBPC;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x39C31A0", Offset = "0x39C25A0", VA = "0x1839C31A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ArraySegment<T> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x39C34C0", Offset = "0x39C28C0", VA = "0x1839C34C0", Slot = "5")]
	public ArraySegment<T> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class BCPGKEMLOJI<T> : HIPKPDINGJD<List<T>>, BOILAFIIEAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly EIDNECPPKDC NIOIDOPMDFA;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x30F71E0", Offset = "0x30F65E0", VA = "0x1830F71E0")]
	public BCPGKEMLOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
	public BCPGKEMLOJI(EIDNECPPKDC NIOIDOPMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4548910", Offset = "0x4547D10", VA = "0x184548910", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, List<T> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x454BB30", Offset = "0x454AF30", VA = "0x18454BB30", Slot = "5")]
	public List<T> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class NJDJNOJNAMD<TElement, TIntermediate, TEnumerator, TCollection> : HIPKPDINGJD<TCollection>, BOILAFIIEAN where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B9B0", Offset = "0x3D2ADB0", VA = "0x183D2B9B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TCollection NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3D2CEC0", Offset = "0x3D2C2C0", VA = "0x183D2CEC0", Slot = "5")]
	public TCollection JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator MADGBDLPDLO(TCollection HFLNDIDMJFD);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EBILOFOJHAE();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BKKEPFPDOJH(TIntermediate NNCDPJOIJPE, int DIENMHDGFGP, TElement NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection GIIIEODFHFB(TIntermediate KAAKDKHPBEI);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected NJDJNOJNAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class PGHECINOOHO<TElement, TIntermediate, TCollection> : NJDJNOJNAMD<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x30E6500", Offset = "0x30E5900", VA = "0x1830E6500", Slot = "6")]
	protected override IEnumerator<TElement> MADGBDLPDLO(TCollection HFLNDIDMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30CA3F0", Offset = "0x30C97F0", VA = "0x1830CA3F0")]
	protected PGHECINOOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class JCLMOGPPCGH<TElement, TCollection> : PGHECINOOHO<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected sealed override TCollection GIIIEODFHFB(TCollection KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NCJJDAFDMDJ<TElement, TCollection> : JCLMOGPPCGH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AE00", Offset = "0x3D1A200", VA = "0x183D1AE00", Slot = "7")]
	protected override TCollection EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1ADA0", Offset = "0x3D1A1A0", VA = "0x183D1ADA0", Slot = "8")]
	protected override void BKKEPFPDOJH(TCollection NNCDPJOIJPE, int DIENMHDGFGP, TElement NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class BFHEEOAODEC<T> : NJDJNOJNAMD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B970", VA = "0x18355C570", Slot = "8")]
	protected override void BKKEPFPDOJH(LinkedList<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override LinkedList<T> GIIIEODFHFB(LinkedList<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override LinkedList<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x375F190", Offset = "0x375E590", VA = "0x18375F190", Slot = "6")]
	protected override LinkedList<T>.Enumerator MADGBDLPDLO(LinkedList<T> HFLNDIDMJFD)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class JFKOLGKAJAM<T> : NJDJNOJNAMD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B970", VA = "0x18355C570", Slot = "8")]
	protected override void BKKEPFPDOJH(Queue<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override Queue<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x38F0DB0", Offset = "0x38F01B0", VA = "0x1838F0DB0", Slot = "6")]
	protected override Queue<T>.Enumerator MADGBDLPDLO(Queue<T> HFLNDIDMJFD)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override Queue<T> GIIIEODFHFB(Queue<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IOFGHFJGHLJ<T> : NJDJNOJNAMD<T, AJGGMHIIHMM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x376A620", Offset = "0x3769A20", VA = "0x18376A620", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x376A650", Offset = "0x3769A50", VA = "0x18376A650", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x376A770", Offset = "0x3769B70", VA = "0x18376A770", Slot = "6")]
	protected override Stack<T>.Enumerator MADGBDLPDLO(Stack<T> HFLNDIDMJFD)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x376A690", Offset = "0x3769A90", VA = "0x18376A690", Slot = "9")]
	protected override Stack<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NLOMDMGGECN<T> : NJDJNOJNAMD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B970", VA = "0x18355C570", Slot = "8")]
	protected override void BKKEPFPDOJH(HashSet<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override HashSet<T> GIIIEODFHFB(HashSet<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override HashSet<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x38F0DB0", Offset = "0x38F01B0", VA = "0x1838F0DB0", Slot = "6")]
	protected override HashSet<T>.Enumerator MADGBDLPDLO(HashSet<T> HFLNDIDMJFD)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CJFJAKLOCJB<T> : PGHECINOOHO<T, AJGGMHIIHMM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x376A620", Offset = "0x3769A20", VA = "0x18376A620", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4822440", Offset = "0x4821840", VA = "0x184822440", Slot = "9")]
	protected override ReadOnlyCollection<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4822400", Offset = "0x4821800", VA = "0x184822400", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IOOHHEPNPKD<T> : PGHECINOOHO<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B970", VA = "0x18355C570", Slot = "8")]
	protected override void BKKEPFPDOJH(List<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override List<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override IList<T> GIIIEODFHFB(List<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AGJKFPKDCGI<T> : PGHECINOOHO<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x355C570", Offset = "0x355B970", VA = "0x18355C570", Slot = "8")]
	protected override void BKKEPFPDOJH(List<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override List<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override ICollection<T> GIIIEODFHFB(List<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NDCPLIABNHI<T> : PGHECINOOHO<T, AJGGMHIIHMM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x376A620", Offset = "0x3769A20", VA = "0x18376A620", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x376A650", Offset = "0x3769A50", VA = "0x18376A650", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3D1BB80", Offset = "0x3D1AF80", VA = "0x183D1BB80", Slot = "9")]
	protected override IEnumerable<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30D7DB0", Offset = "0x30D71B0", VA = "0x1830D7DB0")]
	public NDCPLIABNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class LFOAMHLOFFE<TKey, TElement> : HIPKPDINGJD<IGrouping<TKey, TElement>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CDB0", Offset = "0x3A8C1B0", VA = "0x183A8CDB0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IGrouping<TKey, TElement> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D090", Offset = "0x3A8C490", VA = "0x183A8D090", Slot = "5")]
	public IGrouping<TKey, TElement> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HPHPPPPIIAH<TKey, TElement> : HIPKPDINGJD<ILookup<TKey, TElement>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x361FE40", Offset = "0x361F240", VA = "0x18361FE40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ILookup<TKey, TElement> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x361FF80", Offset = "0x361F380", VA = "0x18361FF80", Slot = "5")]
	public ILookup<TKey, TElement> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class MLMJGNCIGOK<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey MIMFBLPNKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> OHFHGCFJPNC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey BOGLOOJGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x77CB20", Offset = "0x77BF20", VA = "0x18077CB20")]
	public MLMJGNCIGOK(TKey MIMFBLPNKOG, IEnumerable<TElement> OHFHGCFJPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFB90", Offset = "0x3CCEF90", VA = "0x183CCFB90", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x31535E0", Offset = "0x31529E0", VA = "0x1831535E0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class EJMNJIALCAE<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> KHLHGPFILOP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x30F8260", Offset = "0x30F7660", VA = "0x1830F8260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public EJMNJIALCAE(Dictionary<TKey, IGrouping<TKey, TElement>> KHLHGPFILOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x30F8160", Offset = "0x30F7560", VA = "0x1830F8160", Slot = "5")]
	public bool Contains(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x30F81A0", Offset = "0x30F75A0", VA = "0x1830F81A0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x30F81A0", Offset = "0x30F75A0", VA = "0x1830F81A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class JNDOEANMJGK<T> : HIPKPDINGJD<T>, BOILAFIIEAN where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3912DC0", Offset = "0x39121C0", VA = "0x183912DC0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x39130F0", Offset = "0x39124F0", VA = "0x1839130F0", Slot = "5")]
	public T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JNDOEANMJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class GBHBGFBHBNH : HIPKPDINGJD<IEnumerable>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly HIPKPDINGJD<IEnumerable> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65A8680", Offset = "0x65A7A80", VA = "0x1865A8680", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IEnumerable NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A8930", Offset = "0x65A7D30", VA = "0x1865A8930", Slot = "5")]
	public IEnumerable JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public GBHBGFBHBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class ADKOEDGOMFJ : HIPKPDINGJD<ICollection>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly HIPKPDINGJD<ICollection> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x65A2000", Offset = "0x65A1400", VA = "0x1865A2000", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ICollection NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65A23A0", Offset = "0x65A17A0", VA = "0x1865A23A0", Slot = "5")]
	public ICollection JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public ADKOEDGOMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class MIIEPHMNPPL : HIPKPDINGJD<IList>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly HIPKPDINGJD<IList> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x65B0AD0", Offset = "0x65AFED0", VA = "0x1865B0AD0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IList NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65B0E00", Offset = "0x65B0200", VA = "0x1865B0E00", Slot = "5")]
	public IList JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MIIEPHMNPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AEHPCCAKJGP<T> : PGHECINOOHO<T, AJGGMHIIHMM<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3559B90", Offset = "0x3558F90", VA = "0x183559B90", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3559BF0", Offset = "0x3558FF0", VA = "0x183559BF0", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3559C70", Offset = "0x3559070", VA = "0x183559C70", Slot = "9")]
	protected override IReadOnlyList<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30D7750", Offset = "0x30D6B50", VA = "0x1830D7750")]
	public AEHPCCAKJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class BDLLFFCJFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65A4970", Offset = "0x65A3D70", VA = "0x1865A4970")]
	public static DateTime HJIMGNPIHBI(DateTime FGIPPEJBGDB)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class BAPKAOEBKJK : HIPKPDINGJD<DateTime>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly HIPKPDINGJD<DateTime> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x65A2A70", Offset = "0x65A1E70", VA = "0x1865A2A70", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, DateTime NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65A3220", Offset = "0x65A2620", VA = "0x1865A3220", Slot = "5")]
	public DateTime JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BAPKAOEBKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class JMOGJEDJIAO : HIPKPDINGJD<DateTimeOffset>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly HIPKPDINGJD<DateTimeOffset> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x65AD630", Offset = "0x65ACA30", VA = "0x1865AD630", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, DateTimeOffset NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65ADCD0", Offset = "0x65AD0D0", VA = "0x1865ADCD0", Slot = "5")]
	public DateTimeOffset JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JMOGJEDJIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class MHPEJJFFFCF : HIPKPDINGJD<TimeSpan>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly HIPKPDINGJD<TimeSpan> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] ECFBBGEEPCF;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC80", Offset = "0x65AF080", VA = "0x1865AFC80", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TimeSpan NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65B0060", Offset = "0x65AF460", VA = "0x1865B0060", Slot = "5")]
	public TimeSpan JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MHPEJJFFFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class GOCMKHPAHFH<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : HIPKPDINGJD<TDictionary>, BOILAFIIEAN where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x357C510", Offset = "0x357B910", VA = "0x18357C510", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TDictionary NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x357FAF0", Offset = "0x357EEF0", VA = "0x18357FAF0", Slot = "5")]
	public TDictionary JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator MADGBDLPDLO(TDictionary HFLNDIDMJFD);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EBILOFOJHAE();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BKKEPFPDOJH(TIntermediate NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary GIIIEODFHFB(TIntermediate KAAKDKHPBEI);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected GOCMKHPAHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class EDEBODLJNFC<TKey, TValue, TIntermediate, TDictionary> : GOCMKHPAHFH<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x30E6500", Offset = "0x30E5900", VA = "0x1830E6500", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> MADGBDLPDLO(TDictionary HFLNDIDMJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class EGKGFBMNPII<TKey, TValue, TDictionary> : EDEBODLJNFC<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override TDictionary GIIIEODFHFB(TDictionary KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class IMFOMKKPIII<TKey, TValue> : GOCMKHPAHFH<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x375F0A0", Offset = "0x375E4A0", VA = "0x18375F0A0", Slot = "8")]
	protected override void BKKEPFPDOJH(Dictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override Dictionary<TKey, TValue> GIIIEODFHFB(Dictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x375F2D0", Offset = "0x375E6D0", VA = "0x18375F2D0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator MADGBDLPDLO(Dictionary<TKey, TValue> HFLNDIDMJFD)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30C96E0", Offset = "0x30C8AE0", VA = "0x1830C96E0")]
	public IMFOMKKPIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class HEKKLDOPCKK<TKey, TValue, TDictionary> : EGKGFBMNPII<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x35DEF30", Offset = "0x35DE330", VA = "0x1835DEF30", Slot = "8")]
	protected override void BKKEPFPDOJH(TDictionary NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C7A0", Offset = "0x2F7BBA0", VA = "0x182F7C7A0", Slot = "7")]
	protected override TDictionary EBILOFOJHAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class OHIFKLGNFHA<TKey, TValue> : EDEBODLJNFC<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3102360", Offset = "0x3101760", VA = "0x183102360", Slot = "8")]
	protected override void BKKEPFPDOJH(Dictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override IDictionary<TKey, TValue> GIIIEODFHFB(Dictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EKNOPEBCGCE<TKey, TValue> : EGKGFBMNPII<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3102360", Offset = "0x3101760", VA = "0x183102360", Slot = "8")]
	protected override void BKKEPFPDOJH(SortedList<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override SortedList<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KDOJKGMFIJJ<TKey, TValue> : GOCMKHPAHFH<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3102360", Offset = "0x3101760", VA = "0x183102360", Slot = "8")]
	protected override void BKKEPFPDOJH(SortedDictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80EFF0", Offset = "0x80E3F0", VA = "0x18080EFF0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GIIIEODFHFB(SortedDictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x31023A0", Offset = "0x31017A0", VA = "0x1831023A0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x375F260", Offset = "0x375E660", VA = "0x18375F260", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator MADGBDLPDLO(SortedDictionary<TKey, TValue> HFLNDIDMJFD)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class NFNGIPBPFKM<T> : HIPKPDINGJD<T>, BOILAFIIEAN where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3D24050", Offset = "0x3D23450", VA = "0x183D24050", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3D24530", Offset = "0x3D23930", VA = "0x183D24530", Slot = "5")]
	public T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public NFNGIPBPFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class DMNFEOBNFMJ : HIPKPDINGJD<IDictionary>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly HIPKPDINGJD<IDictionary> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65A6B10", Offset = "0x65A5F10", VA = "0x1865A6B10", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IDictionary NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65A6FF0", Offset = "0x65A63F0", VA = "0x1865A6FF0", Slot = "5")]
	public IDictionary JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DMNFEOBNFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class GBJOPGJGCMM : HIPKPDINGJD<object>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void DFOKPHEGAKF(object EILELMCOCAL, NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly CJHBBAIALEN<KeyValuePair<object, DFOKPHEGAKF>> CPJKDNEAKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly PMECKIJLNID[] KAODAHMOELB;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x65A9650", Offset = "0x65A8A50", VA = "0x1865A9650")]
	public GBJOPGJGCMM(params PMECKIJLNID[] KAODAHMOELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65A8C00", Offset = "0x65A8000", VA = "0x1865A8C00", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65A95C0", Offset = "0x65A89C0", VA = "0x1865A95C0", Slot = "5")]
	public object JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class MJDBGDGCGJC
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65B19C0", Offset = "0x65B0DC0", VA = "0x1865B19C0")]
	public static object ELCHEJDLJDM(Type LFLAEPCPMDG, [Out] bool DMDMJGPLNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65B10D0", Offset = "0x65B04D0", VA = "0x1865B10D0")]
	public static object BKFJGABPMGG(Type LFLAEPCPMDG, [Out] bool DMDMJGPLNHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class KIAGPEMMDBC<T> : HIPKPDINGJD<T>, BOILAFIIEAN, EOADGIMIJAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EMMKOJHCAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public EMMKOJHCAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3108750", Offset = "0x3107B50", VA = "0x183108750")]
		internal bool KBJKDFNOLEE(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class HFACDMBGLKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public HFACDMBGLKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x35DF180", Offset = "0x35DE580", VA = "0x1835DF180")]
		internal bool BIIPPNJPNFC(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class PJADAMAIMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public PNOGCIHEHOK<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PJADAMAIMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B340", Offset = "0x3F1A740", VA = "0x183F1B340")]
		internal void ANBGPOJPOEO(NLPBBJFEPIL writer, T value, PMECKIJLNID _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class MPKDBLICAOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ANFNECEGDEF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MPKDBLICAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CE54D0", Offset = "0x3CE48D0", VA = "0x183CE54D0")]
		internal T AIAFAADGIBD(JPNKIGBGADK reader, PMECKIJLNID _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly MMANBIJFINJ<T> NNCMEONKPIH;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> AKGHGGKDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly PNOGCIHEHOK<T> ALOCDPLAKEB;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly ANFNECEGDEF<T> GJJPHOJJHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool NDKBNDMPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly PNOGCIHEHOK<T> DIINHNKHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly ANFNECEGDEF<T> CJBMONOAKKP;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3988B50", Offset = "0x3987F50", VA = "0x183988B50")]
	static KIAGPEMMDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x398D4B0", Offset = "0x398C8B0", VA = "0x18398D4B0")]
	public KIAGPEMMDBC(bool NDKBNDMPEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x39851B0", Offset = "0x39845B0", VA = "0x1839851B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3986E00", Offset = "0x3986200", VA = "0x183986E00", Slot = "5")]
	public T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x39864D0", Offset = "0x39858D0", VA = "0x1839864D0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3985D00", Offset = "0x3985100", VA = "0x183985D00", Slot = "7")]
	public T AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class LFKMJHKPHPJ<T> : HIPKPDINGJD<T[,]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C810", Offset = "0x3A8BC10", VA = "0x183A8C810", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CA80", Offset = "0x3A8BE80", VA = "0x183A8CA80", Slot = "5")]
	public T[,] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public LFKMJHKPHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HNNNNOPGOII<T> : HIPKPDINGJD<T[,,]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x361B020", Offset = "0x361A420", VA = "0x18361B020", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x361B340", Offset = "0x361A740", VA = "0x18361B340", Slot = "5")]
	public T[,,] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HNNNNOPGOII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DIPIGEDGPKI<T> : HIPKPDINGJD<T[,,,]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6C90", Offset = "0x4DD6090", VA = "0x184DD6C90", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,,,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DD7070", Offset = "0x4DD6470", VA = "0x184DD7070", Slot = "5")]
	public T[,,,] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DIPIGEDGPKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class GDDOMOJBPOA<T> : HIPKPDINGJD<T?>, BOILAFIIEAN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x35299B0", Offset = "0x3528DB0", VA = "0x1835299B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3529EE0", Offset = "0x35292E0", VA = "0x183529EE0", Slot = "5")]
	public T? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public GDDOMOJBPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class EMFBCDBJENH<T> : HIPKPDINGJD<T?>, BOILAFIIEAN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly HIPKPDINGJD<T> CJABJFJMLNN;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public EMFBCDBJENH(HIPKPDINGJD<T> CJABJFJMLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x31053B0", Offset = "0x31047B0", VA = "0x1831053B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3106E20", Offset = "0x3106220", VA = "0x183106E20", Slot = "5")]
	public T? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class LILIGKLMCOL : HIPKPDINGJD<sbyte>, BOILAFIIEAN, EOADGIMIJAP<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LILIGKLMCOL LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65AF610", Offset = "0x65AEA10", VA = "0x1865AF610", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65AF7A0", Offset = "0x65AEBA0", VA = "0x1865AF7A0", Slot = "5")]
	public sbyte JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65AF730", Offset = "0x65AEB30", VA = "0x1865AF730", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, sbyte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65AF670", Offset = "0x65AEA70", VA = "0x1865AF670", Slot = "7")]
	public sbyte AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public LILIGKLMCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ABAPGMFLKKE : HIPKPDINGJD<sbyte?>, BOILAFIIEAN, EOADGIMIJAP<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly ABAPGMFLKKE LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x65A18F0", Offset = "0x65A0CF0", VA = "0x1865A18F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65A1B90", Offset = "0x65A0F90", VA = "0x1865A1B90", Slot = "5")]
	public sbyte? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65A1AD0", Offset = "0x65A0ED0", VA = "0x1865A1AD0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, sbyte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x65A19B0", Offset = "0x65A0DB0", VA = "0x1865A19B0", Slot = "7")]
	public sbyte? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public ABAPGMFLKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class BLCDHIMKLLF : HIPKPDINGJD<sbyte[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BLCDHIMKLLF LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x65A4C10", Offset = "0x65A4010", VA = "0x1865A4C10", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A4D40", Offset = "0x65A4140", VA = "0x1865A4D40", Slot = "5")]
	public sbyte[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BLCDHIMKLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class MNGIBKBHEEB : HIPKPDINGJD<short>, BOILAFIIEAN, EOADGIMIJAP<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly MNGIBKBHEEB LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x65B24D0", Offset = "0x65B18D0", VA = "0x1865B24D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x65B2660", Offset = "0x65B1A60", VA = "0x1865B2660", Slot = "5")]
	public short JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x65B25F0", Offset = "0x65B19F0", VA = "0x1865B25F0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, short NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x65B2530", Offset = "0x65B1930", VA = "0x1865B2530", Slot = "7")]
	public short AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MNGIBKBHEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class OKLNKPHMKMD : HIPKPDINGJD<short?>, BOILAFIIEAN, EOADGIMIJAP<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OKLNKPHMKMD LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x65B4530", Offset = "0x65B3930", VA = "0x1865B4530", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65B47D0", Offset = "0x65B3BD0", VA = "0x1865B47D0", Slot = "5")]
	public short? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x65B4710", Offset = "0x65B3B10", VA = "0x1865B4710", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, short? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65B45F0", Offset = "0x65B39F0", VA = "0x1865B45F0", Slot = "7")]
	public short? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OKLNKPHMKMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class IGCCNBCHLKO : HIPKPDINGJD<short[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly IGCCNBCHLKO LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x65ABD90", Offset = "0x65AB190", VA = "0x1865ABD90", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65ABEC0", Offset = "0x65AB2C0", VA = "0x1865ABEC0", Slot = "5")]
	public short[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IGCCNBCHLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IIDFJDKCCGD : HIPKPDINGJD<int>, BOILAFIIEAN, EOADGIMIJAP<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IIDFJDKCCGD LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x65AC4A0", Offset = "0x65AB8A0", VA = "0x1865AC4A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65AC630", Offset = "0x65ABA30", VA = "0x1865AC630", Slot = "5")]
	public int JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65AC5C0", Offset = "0x65AB9C0", VA = "0x1865AC5C0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, int NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65AC500", Offset = "0x65AB900", VA = "0x1865AC500", Slot = "7")]
	public int AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IIDFJDKCCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JFGAFOFBJIN : HIPKPDINGJD<int?>, BOILAFIIEAN, EOADGIMIJAP<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JFGAFOFBJIN LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x65AD000", Offset = "0x65AC400", VA = "0x1865AD000", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD2A0", Offset = "0x65AC6A0", VA = "0x1865AD2A0", Slot = "5")]
	public int? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD1E0", Offset = "0x65AC5E0", VA = "0x1865AD1E0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, int? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x65AD0C0", Offset = "0x65AC4C0", VA = "0x1865AD0C0", Slot = "7")]
	public int? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JFGAFOFBJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class CBAFDJKEDMI : HIPKPDINGJD<int[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly CBAFDJKEDMI LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x65A5350", Offset = "0x65A4750", VA = "0x1865A5350", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x65A5480", Offset = "0x65A4880", VA = "0x1865A5480", Slot = "5")]
	public int[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CBAFDJKEDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class CIGNMDLKOKL : HIPKPDINGJD<long>, BOILAFIIEAN, EOADGIMIJAP<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CIGNMDLKOKL LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x65A5690", Offset = "0x65A4A90", VA = "0x1865A5690", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x65A5820", Offset = "0x65A4C20", VA = "0x1865A5820", Slot = "5")]
	public long JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x65A57B0", Offset = "0x65A4BB0", VA = "0x1865A57B0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, long NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x65A56F0", Offset = "0x65A4AF0", VA = "0x1865A56F0", Slot = "7")]
	public long AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CIGNMDLKOKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class APAJKJMENKK : HIPKPDINGJD<long?>, BOILAFIIEAN, EOADGIMIJAP<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly APAJKJMENKK LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x65A2670", Offset = "0x65A1A70", VA = "0x1865A2670", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65A2930", Offset = "0x65A1D30", VA = "0x1865A2930", Slot = "5")]
	public long? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65A2870", Offset = "0x65A1C70", VA = "0x1865A2870", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, long? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65A2730", Offset = "0x65A1B30", VA = "0x1865A2730", Slot = "7")]
	public long? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public APAJKJMENKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class FFPDCDMNGOM : HIPKPDINGJD<long[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FFPDCDMNGOM LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x65A7FC0", Offset = "0x65A73C0", VA = "0x1865A7FC0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x65A80F0", Offset = "0x65A74F0", VA = "0x1865A80F0", Slot = "5")]
	public long[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public FFPDCDMNGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class LPMGBBOEKGI : HIPKPDINGJD<byte>, BOILAFIIEAN, EOADGIMIJAP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly LPMGBBOEKGI LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x65AF870", Offset = "0x65AEC70", VA = "0x1865AF870", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65AFA00", Offset = "0x65AEE00", VA = "0x1865AFA00", Slot = "5")]
	public byte JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65AF990", Offset = "0x65AED90", VA = "0x1865AF990", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, byte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65AF8D0", Offset = "0x65AECD0", VA = "0x1865AF8D0", Slot = "7")]
	public byte AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public LPMGBBOEKGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class OGHHPFFBMCO : HIPKPDINGJD<byte?>, BOILAFIIEAN, EOADGIMIJAP<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OGHHPFFBMCO LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x65B4160", Offset = "0x65B3560", VA = "0x1865B4160", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65B4400", Offset = "0x65B3800", VA = "0x1865B4400", Slot = "5")]
	public byte? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x65B4340", Offset = "0x65B3740", VA = "0x1865B4340", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, byte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65B4220", Offset = "0x65B3620", VA = "0x1865B4220", Slot = "7")]
	public byte? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OGHHPFFBMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class JKJMOKKGIHA : HIPKPDINGJD<ushort>, BOILAFIIEAN, EOADGIMIJAP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly JKJMOKKGIHA LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x65AD3D0", Offset = "0x65AC7D0", VA = "0x1865AD3D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x65AD560", Offset = "0x65AC960", VA = "0x1865AD560", Slot = "5")]
	public ushort JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65AD4F0", Offset = "0x65AC8F0", VA = "0x1865AD4F0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ushort NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65AD430", Offset = "0x65AC830", VA = "0x1865AD430", Slot = "7")]
	public ushort AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JKJMOKKGIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class BDHOBGIPMPD : HIPKPDINGJD<ushort?>, BOILAFIIEAN, EOADGIMIJAP<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly BDHOBGIPMPD LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x65A45A0", Offset = "0x65A39A0", VA = "0x1865A45A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x65A4840", Offset = "0x65A3C40", VA = "0x1865A4840", Slot = "5")]
	public ushort? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x65A4780", Offset = "0x65A3B80", VA = "0x1865A4780", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ushort? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65A4660", Offset = "0x65A3A60", VA = "0x1865A4660", Slot = "7")]
	public ushort? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BDHOBGIPMPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class ACMKAEHJNOI : HIPKPDINGJD<ushort[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly ACMKAEHJNOI LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x65A1CC0", Offset = "0x65A10C0", VA = "0x1865A1CC0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65A1DF0", Offset = "0x65A11F0", VA = "0x1865A1DF0", Slot = "5")]
	public ushort[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public ACMKAEHJNOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JBCFPCEIBAP : HIPKPDINGJD<uint>, BOILAFIIEAN, EOADGIMIJAP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly JBCFPCEIBAP LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x65ACBC0", Offset = "0x65ABFC0", VA = "0x1865ACBC0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65ACD50", Offset = "0x65AC150", VA = "0x1865ACD50", Slot = "5")]
	public uint JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCE0", Offset = "0x65AC0E0", VA = "0x1865ACCE0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, uint NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20", Slot = "7")]
	public uint AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JBCFPCEIBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class LHBAJJDKGDP : HIPKPDINGJD<uint?>, BOILAFIIEAN, EOADGIMIJAP<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly LHBAJJDKGDP LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x65AF240", Offset = "0x65AE640", VA = "0x1865AF240", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65AF4E0", Offset = "0x65AE8E0", VA = "0x1865AF4E0", Slot = "5")]
	public uint? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65AF420", Offset = "0x65AE820", VA = "0x1865AF420", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, uint? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65AF300", Offset = "0x65AE700", VA = "0x1865AF300", Slot = "7")]
	public uint? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public LHBAJJDKGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CMILAFIMLFH : HIPKPDINGJD<uint[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CMILAFIMLFH LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x65A60E0", Offset = "0x65A54E0", VA = "0x1865A60E0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65A6210", Offset = "0x65A5610", VA = "0x1865A6210", Slot = "5")]
	public uint[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CMILAFIMLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class DCLBBJKIMOP : HIPKPDINGJD<ulong>, BOILAFIIEAN, EOADGIMIJAP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly DCLBBJKIMOP LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x65A6420", Offset = "0x65A5820", VA = "0x1865A6420", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65A65B0", Offset = "0x65A59B0", VA = "0x1865A65B0", Slot = "5")]
	public ulong JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65A6540", Offset = "0x65A5940", VA = "0x1865A6540", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ulong NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65A6480", Offset = "0x65A5880", VA = "0x1865A6480", Slot = "7")]
	public ulong AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DCLBBJKIMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LCAIBCPPMFE : HIPKPDINGJD<ulong?>, BOILAFIIEAN, EOADGIMIJAP<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LCAIBCPPMFE LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x65AEE40", Offset = "0x65AE240", VA = "0x1865AEE40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65AF100", Offset = "0x65AE500", VA = "0x1865AF100", Slot = "5")]
	public ulong? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65AF040", Offset = "0x65AE440", VA = "0x1865AF040", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ulong? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65AEF00", Offset = "0x65AE300", VA = "0x1865AEF00", Slot = "7")]
	public ulong? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public LCAIBCPPMFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class DICGNMNIBFA : HIPKPDINGJD<ulong[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly DICGNMNIBFA LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x65A67D0", Offset = "0x65A5BD0", VA = "0x1865A67D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65A6900", Offset = "0x65A5D00", VA = "0x1865A6900", Slot = "5")]
	public ulong[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DICGNMNIBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class JAPOFCOJAKC : HIPKPDINGJD<float>, BOILAFIIEAN, EOADGIMIJAP<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly JAPOFCOJAKC LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x65AC960", Offset = "0x65ABD60", VA = "0x1865AC960", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x65ACAF0", Offset = "0x65ABEF0", VA = "0x1865ACAF0", Slot = "5")]
	public float JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x65ACA80", Offset = "0x65ABE80", VA = "0x1865ACA80", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, float NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC9C0", Offset = "0x65ABDC0", VA = "0x1865AC9C0", Slot = "7")]
	public float AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JAPOFCOJAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class IHDICBJFIND : HIPKPDINGJD<float?>, BOILAFIIEAN, EOADGIMIJAP<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly IHDICBJFIND LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x65AC0D0", Offset = "0x65AB4D0", VA = "0x1865AC0D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x65AC370", Offset = "0x65AB770", VA = "0x1865AC370", Slot = "5")]
	public float? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x65AC2B0", Offset = "0x65AB6B0", VA = "0x1865AC2B0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, float? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x65AC190", Offset = "0x65AB590", VA = "0x1865AC190", Slot = "7")]
	public float? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IHDICBJFIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class EHEGMDBNAMH : HIPKPDINGJD<float[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly EHEGMDBNAMH LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x65A7500", Offset = "0x65A6900", VA = "0x1865A7500", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65A7640", Offset = "0x65A6A40", VA = "0x1865A7640", Slot = "5")]
	public float[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public EHEGMDBNAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class DOOOFOEEAPJ : HIPKPDINGJD<double>, BOILAFIIEAN, EOADGIMIJAP<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly DOOOFOEEAPJ LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x65A72A0", Offset = "0x65A66A0", VA = "0x1865A72A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65A7430", Offset = "0x65A6830", VA = "0x1865A7430", Slot = "5")]
	public double JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65A73C0", Offset = "0x65A67C0", VA = "0x1865A73C0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, double NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65A7300", Offset = "0x65A6700", VA = "0x1865A7300", Slot = "7")]
	public double AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DOOOFOEEAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BMKMGDBHFPE : HIPKPDINGJD<double?>, BOILAFIIEAN, EOADGIMIJAP<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly BMKMGDBHFPE LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x65A4F50", Offset = "0x65A4350", VA = "0x1865A4F50", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65A5210", Offset = "0x65A4610", VA = "0x1865A5210", Slot = "5")]
	public double? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65A5150", Offset = "0x65A4550", VA = "0x1865A5150", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, double? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65A5010", Offset = "0x65A4410", VA = "0x1865A5010", Slot = "7")]
	public double? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BMKMGDBHFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IFGHJNGLALD : HIPKPDINGJD<double[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly IFGHJNGLALD LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x65ABA40", Offset = "0x65AAE40", VA = "0x1865ABA40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65ABB80", Offset = "0x65AAF80", VA = "0x1865ABB80", Slot = "5")]
	public double[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IFGHJNGLALD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class IMPGFCGPDFG : HIPKPDINGJD<bool>, BOILAFIIEAN, EOADGIMIJAP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly IMPGFCGPDFG LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x65AC700", Offset = "0x65ABB00", VA = "0x1865AC700", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC890", Offset = "0x65ABC90", VA = "0x1865AC890", Slot = "5")]
	public bool JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC820", Offset = "0x65ABC20", VA = "0x1865AC820", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, bool NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC760", Offset = "0x65ABB60", VA = "0x1865AC760", Slot = "7")]
	public bool AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IMPGFCGPDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class CLBFNEKBPEI : HIPKPDINGJD<bool?>, BOILAFIIEAN, EOADGIMIJAP<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly CLBFNEKBPEI LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x65A5D10", Offset = "0x65A5110", VA = "0x1865A5D10", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65A5FB0", Offset = "0x65A53B0", VA = "0x1865A5FB0", Slot = "5")]
	public bool? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65A5EF0", Offset = "0x65A52F0", VA = "0x1865A5EF0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, bool? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65A5DD0", Offset = "0x65A51D0", VA = "0x1865A5DD0", Slot = "7")]
	public bool? AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CLBFNEKBPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class OBOLICEOHAC : HIPKPDINGJD<bool[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly OBOLICEOHAC LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x65B3E10", Offset = "0x65B3210", VA = "0x1865B3E10", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F50", Offset = "0x65B3350", VA = "0x1865B3F50", Slot = "5")]
	public bool[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OBOLICEOHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class NAMEHKOPHBL : HIPKPDINGJD<object>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly HIPKPDINGJD<object> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> FHPIHKACGIG;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x65B2730", Offset = "0x65B1B30", VA = "0x1865B2730", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65B33D0", Offset = "0x65B27D0", VA = "0x1865B33D0", Slot = "5")]
	public object JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public NAMEHKOPHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class NIDIPHLIHLK : HIPKPDINGJD<byte[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly HIPKPDINGJD<byte[]> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x65B3C20", Offset = "0x65B3020", VA = "0x1865B3C20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x65B3CE0", Offset = "0x65B30E0", VA = "0x1865B3CE0", Slot = "5")]
	public byte[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public NIDIPHLIHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EKOKOPKOMAC : HIPKPDINGJD<ArraySegment<byte>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly HIPKPDINGJD<ArraySegment<byte>> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x65A7850", Offset = "0x65A6C50", VA = "0x1865A7850", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ArraySegment<byte> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65A7980", Offset = "0x65A6D80", VA = "0x1865A7980", Slot = "5")]
	public ArraySegment<byte> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public EKOKOPKOMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JBHCJHIFAKN : HIPKPDINGJD<string>, BOILAFIIEAN, EOADGIMIJAP<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly HIPKPDINGJD<string> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE20", Offset = "0x65AC220", VA = "0x1865ACE20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, string NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF30", Offset = "0x65AC330", VA = "0x1865ACF30", Slot = "5")]
	public string JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x65ACED0", Offset = "0x65AC2D0", VA = "0x1865ACED0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, string NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE80", Offset = "0x65AC280", VA = "0x1865ACE80", Slot = "7")]
	public string AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JBHCJHIFAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class FOJFFEIHFOF : HIPKPDINGJD<string[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly FOJFFEIHFOF LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x65A8300", Offset = "0x65A7700", VA = "0x1865A8300", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, string[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65A8430", Offset = "0x65A7830", VA = "0x1865A8430", Slot = "5")]
	public string[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public FOJFFEIHFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class MDFNHLDCLMK : HIPKPDINGJD<char>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly MDFNHLDCLMK LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65AFAD0", Offset = "0x65AEED0", VA = "0x1865AFAD0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65AFB90", Offset = "0x65AEF90", VA = "0x1865AFB90", Slot = "5")]
	public char JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MDFNHLDCLMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class FELHDLNGPHF : HIPKPDINGJD<char?>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly FELHDLNGPHF LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65A7D20", Offset = "0x65A7120", VA = "0x1865A7D20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65A7E20", Offset = "0x65A7220", VA = "0x1865A7E20", Slot = "5")]
	public char? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public FELHDLNGPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class BDHFMLCFENJ : HIPKPDINGJD<char[]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly BDHFMLCFENJ LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x65A41B0", Offset = "0x65A35B0", VA = "0x1865A41B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65A4360", Offset = "0x65A3760", VA = "0x1865A4360", Slot = "5")]
	public char[] JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BDHFMLCFENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class CKIIIPFDEIF : HIPKPDINGJD<Guid>, BOILAFIIEAN, EOADGIMIJAP<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly HIPKPDINGJD<Guid> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x65A58F0", Offset = "0x65A4CF0", VA = "0x1865A58F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Guid NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65A5C00", Offset = "0x65A5000", VA = "0x1865A5C00", Slot = "5")]
	public Guid JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65A5AC0", Offset = "0x65A4EC0", VA = "0x1865A5AC0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, Guid NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65A5A20", Offset = "0x65A4E20", VA = "0x1865A5A20", Slot = "7")]
	public Guid AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CKIIIPFDEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class KDOJDEPMFLC : HIPKPDINGJD<decimal>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly HIPKPDINGJD<decimal> LHECNHAABJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool OLDOGDJFKPD;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x502E2C0", Offset = "0x502D6C0", VA = "0x18502E2C0")]
	public KDOJDEPMFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16CC440", Offset = "0x16CB840", VA = "0x1816CC440")]
	public KDOJDEPMFLC(bool OLDOGDJFKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65AE970", Offset = "0x65ADD70", VA = "0x1865AE970", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, decimal NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x65AEB20", Offset = "0x65ADF20", VA = "0x1865AEB20", Slot = "5")]
	public decimal JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class MKJAPELBANC : HIPKPDINGJD<Uri>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly HIPKPDINGJD<Uri> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x65B22B0", Offset = "0x65B16B0", VA = "0x1865B22B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Uri NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65B2390", Offset = "0x65B1790", VA = "0x1865B2390", Slot = "5")]
	public Uri JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MKJAPELBANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class BCACPAIDOOJ : HIPKPDINGJD<Version>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly HIPKPDINGJD<Version> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x65A3FB0", Offset = "0x65A33B0", VA = "0x1865A3FB0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Version NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65A4070", Offset = "0x65A3470", VA = "0x1865A4070", Slot = "5")]
	public Version JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BCACPAIDOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class AAIJMLAECCK<TKey, TValue> : HIPKPDINGJD<KeyValuePair<TKey, TValue>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x34E87A0", Offset = "0x34E7BA0", VA = "0x1834E87A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, KeyValuePair<TKey, TValue> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x34E8990", Offset = "0x34E7D90", VA = "0x1834E8990", Slot = "5")]
	public KeyValuePair<TKey, TValue> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class BENGOFFOGIJ : HIPKPDINGJD<StringBuilder>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly HIPKPDINGJD<StringBuilder> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65A4A30", Offset = "0x65A3E30", VA = "0x1865A4A30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, StringBuilder NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65A4AD0", Offset = "0x65A3ED0", VA = "0x1865A4AD0", Slot = "5")]
	public StringBuilder JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public BENGOFFOGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HLICPDLGIFI : HIPKPDINGJD<BitArray>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly HIPKPDINGJD<BitArray> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65AB3B0", Offset = "0x65AA7B0", VA = "0x1865AB3B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, BitArray NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65AB4D0", Offset = "0x65AA8D0", VA = "0x1865AB4D0", Slot = "5")]
	public BitArray JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HLICPDLGIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class IAEHBHPIMCG : HIPKPDINGJD<Type>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly IAEHBHPIMCG LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex OJHIBFNOJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool OGOOEAIJKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool EBMBDHNOLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool PONHDANDFFL;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65ABA20", Offset = "0x65AAE20", VA = "0x1865ABA20")]
	public IAEHBHPIMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D37060", Offset = "0x5D36460", VA = "0x185D37060")]
	public IAEHBHPIMCG(bool OGOOEAIJKHF, bool EBMBDHNOLMH, bool PONHDANDFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65AB6D0", Offset = "0x65AAAD0", VA = "0x1865AB6D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Type NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65AB7E0", Offset = "0x65AABE0", VA = "0x1865AB7E0", Slot = "5")]
	public Type JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class EMCFINHCENB
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] PDGFFOFCGIC;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly JGOCJFKOPOG GIPNMEGJEFI;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65A7B10", Offset = "0x65A6F10", VA = "0x1865A7B10")]
	static EMCFINHCENB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class GOMKFLHPIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] FHBDNNDNDOK;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly JGOCJFKOPOG NBGBGJHJEHH;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1A0", Offset = "0x65AA5A0", VA = "0x1865AB1A0")]
	static GOMKFLHPIEP()
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
