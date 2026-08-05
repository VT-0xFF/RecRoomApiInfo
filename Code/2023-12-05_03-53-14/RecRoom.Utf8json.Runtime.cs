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
	[Cpp2IlInjected.Address(RVA = "0x65884C0", Offset = "0x65878C0", VA = "0x1865884C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2629260", Offset = "0x2628660", VA = "0x182629260")]
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
	[Cpp2IlInjected.Address(RVA = "0x250FF70", Offset = "0x250F370", VA = "0x18250FF70")]
	public static HIPKPDINGJD<T> ELPKGPJOIHC<T>(this PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x657E450", Offset = "0x657D850", VA = "0x18657E450")]
	public static object FCFDAFMAECB(this PMECKIJLNID MOJAODNPEME, Type LFLAEPCPMDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CPEOCIIEJPM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x656E260", Offset = "0x656D660", VA = "0x18656E260")]
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
		[Cpp2IlInjected.Address(RVA = "0x656C740", Offset = "0x656BB40", VA = "0x18656C740")]
		public static byte[] FNHNFNKCDEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x656C7E0", Offset = "0x656BBE0", VA = "0x18656C7E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6580EA0", Offset = "0x65802A0", VA = "0x186580EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65830F0", Offset = "0x65824F0", VA = "0x1865830F0")]
	public JPNKIGBGADK(byte[] HPGJIANHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6582F90", Offset = "0x6582390", VA = "0x186582F90")]
	public JPNKIGBGADK(byte[] HPGJIANHJNN, int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6580EC0", Offset = "0x65802C0", VA = "0x186580EC0")]
	private DGCODCIMAKM HFIBJHGDOGE(string KOGDJLCHGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6582580", Offset = "0x6581980", VA = "0x186582580")]
	private DGCODCIMAKM LGPOAMBKKHP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6582440", Offset = "0x6581840", VA = "0x186582440")]
	public void KGIENMGJOBJ(int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910")]
	public byte[] FBHINBGKODI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CDD080", Offset = "0x1CDC480", VA = "0x181CDD080")]
	public int JCJGPPEAHJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x657FCB0", Offset = "0x657F0B0", VA = "0x18657FCB0")]
	public EKIGEAKEDAG AAGFNBBNOPD()
	{
		return default(EKIGEAKEDAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6582450", Offset = "0x6581850", VA = "0x186582450")]
	public void KNEPFCDOMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65820D0", Offset = "0x65814D0", VA = "0x1865820D0")]
	public bool KDPEGEIONLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6580AA0", Offset = "0x657FEA0", VA = "0x186580AA0")]
	public bool FFMHAKABIKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6580820", Offset = "0x657FC20", VA = "0x186580820")]
	public void CPHIGBLGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6580E10", Offset = "0x6580210", VA = "0x186580E10")]
	public bool GIJHMKCHDIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65801A0", Offset = "0x657F5A0", VA = "0x1865801A0")]
	public bool BJLMAHJDDIP(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65802F0", Offset = "0x657F6F0", VA = "0x1865802F0")]
	public bool BNDKHCAPBIL(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6580940", Offset = "0x657FD40", VA = "0x186580940")]
	public bool DJLFGEGAIDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6580C50", Offset = "0x6580050", VA = "0x186580C50")]
	public void GBACMBBLGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6580CF0", Offset = "0x65800F0", VA = "0x186580CF0")]
	public bool GFNIEPNIOOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65809D0", Offset = "0x657FDD0", VA = "0x1865809D0")]
	public bool EFKOIHCNNIN(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x657FE60", Offset = "0x657F260", VA = "0x18657FE60")]
	public bool AFDNFMEGPPE(int APAKJDHFMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6580110", Offset = "0x657F510", VA = "0x186580110")]
	public bool BCILFHLJAPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65816B0", Offset = "0x6580AB0", VA = "0x1865816B0")]
	public void IFNKKJMFNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6580D80", Offset = "0x6580180", VA = "0x186580D80")]
	public bool GHCJIHAECOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6582DD0", Offset = "0x65821D0", VA = "0x186582DD0")]
	public void PNPIGIENLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65818B0", Offset = "0x6580CB0", VA = "0x1865818B0")]
	private void JOOHGEKOJGP([Out] byte[] BJKOMJCFGBK, [Out] int OIGPOEPCHHE, [Out] int BGICFPJGBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6580B30", Offset = "0x657FF30", VA = "0x186580B30")]
	private static int FFMHEBFLFAD(char JMHOJIPAIMC, char MLKGDIFPGGI, char CPHKPECCMOM, char IIPNDJEHBDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6581410", Offset = "0x6580810", VA = "0x186581410")]
	private static int HGKDGENPDOH(char OPHKAEHAFCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65804C0", Offset = "0x657F8C0", VA = "0x1865804C0")]
	public ArraySegment<byte> CABJPDIFFKH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6582CF0", Offset = "0x65820F0", VA = "0x186582CF0")]
	public string PLCMDNJNAJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6580BE0", Offset = "0x657FFE0", VA = "0x186580BE0")]
	public string GADEHHEPAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x65827B0", Offset = "0x6581BB0", VA = "0x1865827B0")]
	public ArraySegment<byte> MHOBLNHMCNJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65800A0", Offset = "0x657F4A0", VA = "0x1865800A0")]
	public ArraySegment<byte> BALCGCLGNGP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65821F0", Offset = "0x65815F0", VA = "0x1865821F0")]
	public bool KGGCMIHBMBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65815F0", Offset = "0x65809F0", VA = "0x1865815F0")]
	private static bool IEGOIINAIHP(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6582A50", Offset = "0x6581E50", VA = "0x186582A50")]
	private void OPJCAJEFOCC(EKIGEAKEDAG NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6582CA0", Offset = "0x65820A0", VA = "0x186582CA0")]
	public void PIBKHGECPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6581750", Offset = "0x6580B50", VA = "0x186581750")]
	private void IMOKPCEKEPO(int KMJODCHIJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6582050", Offset = "0x6581450", VA = "0x186582050")]
	public sbyte KBFMJOGABOF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6580270", Offset = "0x657F670", VA = "0x186580270")]
	public short BKNGJENCFCH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6582730", Offset = "0x6581B30", VA = "0x186582730")]
	public int MCMNIGONMKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6582670", Offset = "0x6581A70", VA = "0x186582670")]
	public long LHMCMHDJEID()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x65805E0", Offset = "0x657F9E0", VA = "0x1865805E0")]
	public byte CCJANAADGKD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65829D0", Offset = "0x6581DD0", VA = "0x1865829D0")]
	public ushort NJLHMKLFJKH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65808C0", Offset = "0x657FCC0", VA = "0x1865808C0")]
	public uint DCEHLEOPJHI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6580660", Offset = "0x657FA60", VA = "0x186580660")]
	public ulong CIBJNOKILNF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65803C0", Offset = "0x657F7C0", VA = "0x1865803C0")]
	public float BPAILFIOIGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65814F0", Offset = "0x65808F0", VA = "0x1865814F0")]
	public double IANMBMAHIAA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6580720", Offset = "0x657FB20", VA = "0x186580720")]
	public ArraySegment<byte> CJDEKMNLPNO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x657FF30", Offset = "0x657F330", VA = "0x18657FF30")]
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
		[Cpp2IlInjected.Address(RVA = "0xB98190", Offset = "0xB97590", VA = "0x180B98190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DEPJKBGFJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x837310", Offset = "0x836710", VA = "0x180837310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x656E750", Offset = "0x656DB50", VA = "0x18656E750")]
	public DGCODCIMAKM(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x656E7B0", Offset = "0x656DBB0", VA = "0x18656E7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x656E8A0", Offset = "0x656DCA0", VA = "0x18656E8A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x35E07F0", Offset = "0x35DFBF0", VA = "0x1835E07F0")]
				internal bool GIJEDGDJCFA(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x65887C0", Offset = "0x6587BC0", VA = "0x1865887C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6572F70", Offset = "0x6572370", VA = "0x186572F70")]
			public FCFDLGADEBF(Type LFLAEPCPMDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2AE6A20", Offset = "0x2AE5E20", VA = "0x182AE6A20")]
			private static T IJCDLJEOHBJ<T>(DynamicMethod NPOAEGCCCDJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6572D20", Offset = "0x6572120", VA = "0x186572D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x65861B0", Offset = "0x65855B0", VA = "0x1865861B0")]
		static NFFMPGJPFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6586130", Offset = "0x6585530", VA = "0x186586130")]
		private static FCFDLGADEBF FNLFIKFJFDE(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6585EA0", Offset = "0x65852A0", VA = "0x186585EA0")]
		public static void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6586020", Offset = "0x6585420", VA = "0x186586020")]
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
		[Cpp2IlInjected.Address(RVA = "0x657D200", Offset = "0x657C600", VA = "0x18657D200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x657D300", Offset = "0x657C700", VA = "0x18657D300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x657E150", Offset = "0x657D550", VA = "0x18657E150")]
	public static void PIAKPELHHMN(PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2508760", Offset = "0x2507B60", VA = "0x182508760")]
	public static byte[] ALIOEPOJFBC<T>(T ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2508550", Offset = "0x2507950", VA = "0x182508550")]
	public static byte[] ALIOEPOJFBC<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25084C0", Offset = "0x25078C0", VA = "0x1825084C0")]
	public static void ALIOEPOJFBC<T>(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25087E0", Offset = "0x2507BE0", VA = "0x1825087E0")]
	public static void ALIOEPOJFBC<T>(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25086D0", Offset = "0x2507AD0", VA = "0x1825086D0")]
	public static void ALIOEPOJFBC<T>(Stream LOEGNCGHNOB, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25088C0", Offset = "0x2507CC0", VA = "0x1825088C0")]
	public static void ALIOEPOJFBC<T>(Stream LOEGNCGHNOB, T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2508A00", Offset = "0x2507E00", VA = "0x182508A00")]
	public static ArraySegment<byte> IDNDCOFADCE<T>(T ECLCDMJMICA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2508A90", Offset = "0x2507E90", VA = "0x182508A90")]
	public static ArraySegment<byte> IDNDCOFADCE<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x250A260", Offset = "0x2509660", VA = "0x18250A260")]
	public static string OMIDOABPJOC<T>(T NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x250A0E0", Offset = "0x25094E0", VA = "0x18250A0E0")]
	public static string OMIDOABPJOC<T>(T NMENOOMOOJP, PMECKIJLNID MOJAODNPEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2509860", Offset = "0x2508C60", VA = "0x182509860")]
	public static T JKMDPBEAKHM<T>(string PPOIIGFJLOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25095E0", Offset = "0x25089E0", VA = "0x1825095E0")]
	public static T JKMDPBEAKHM<T>(string PPOIIGFJLOA, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2509FE0", Offset = "0x25093E0", VA = "0x182509FE0")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25098F0", Offset = "0x2508CF0", VA = "0x1825098F0")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2509A50", Offset = "0x2508E50", VA = "0x182509A50")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, int ELJAGIMMLLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25096D0", Offset = "0x2508AD0", VA = "0x1825096D0")]
	public static T JKMDPBEAKHM<T>(byte[] HPGJIANHJNN, int ELJAGIMMLLH, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x250A060", Offset = "0x2509460", VA = "0x18250A060")]
	public static T JKMDPBEAKHM<T>(JPNKIGBGADK PCDAGGPDBLK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2509E90", Offset = "0x2509290", VA = "0x182509E90")]
	public static T JKMDPBEAKHM<T>(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2509F60", Offset = "0x2509360", VA = "0x182509F60")]
	public static T JKMDPBEAKHM<T>(Stream LOEGNCGHNOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2509AE0", Offset = "0x2508EE0", VA = "0x182509AE0")]
	public static T JKMDPBEAKHM<T>(Stream LOEGNCGHNOB, PMECKIJLNID MOJAODNPEME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x657CF60", Offset = "0x657C360", VA = "0x18657CF60")]
	public static string AIGFECBEMJL(byte[] PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x657D0C0", Offset = "0x657C4C0", VA = "0x18657D0C0")]
	public static string AIGFECBEMJL(byte[] PPOIIGFJLOA, int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x657CDD0", Offset = "0x657C1D0", VA = "0x18657CDD0")]
	public static string AIGFECBEMJL(string PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x657D550", Offset = "0x657C950", VA = "0x18657D550")]
	public static byte[] LOMBAAHNANA(byte[] PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x657D400", Offset = "0x657C800", VA = "0x18657D400")]
	public static byte[] LOMBAAHNANA(byte[] PPOIIGFJLOA, int ELJAGIMMLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x657D6D0", Offset = "0x657CAD0", VA = "0x18657D6D0")]
	public static byte[] LOMBAAHNANA(string PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x657D880", Offset = "0x657CC80", VA = "0x18657D880")]
	private static void OHHBPGIKNNP(JPNKIGBGADK PCDAGGPDBLK, NLPBBJFEPIL EKCFHKIKCOP, int KPHHMKNGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x657D360", Offset = "0x657C760", VA = "0x18657D360")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CDD080", Offset = "0x1CDC480", VA = "0x181CDD080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6582440", Offset = "0x6581840", VA = "0x186582440")]
	public void KGIENMGJOBJ(int ELJAGIMMLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6586C70", Offset = "0x6586070", VA = "0x186586C70")]
	public static byte[] HNHCIIHLLAO(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6586DA0", Offset = "0x65861A0", VA = "0x186586DA0")]
	public static byte[] IJPEDONMEBF(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65872E0", Offset = "0x65866E0", VA = "0x1865872E0")]
	public static byte[] MFDIEHJKDPK(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6587480", Offset = "0x6586880", VA = "0x186587480")]
	public static byte[] OLFOFAMGOIM(string JJOBNGACPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x538E490", Offset = "0x538D890", VA = "0x18538E490")]
	public NLPBBJFEPIL(byte[] PDDLJJJGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x65865B0", Offset = "0x65859B0", VA = "0x1865865B0")]
	public ArraySegment<byte> FNHNFNKCDEH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6586F60", Offset = "0x6586360", VA = "0x186586F60")]
	public byte[] JKMJKCAMAAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6587710", Offset = "0x6586B10", VA = "0x186587710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6586B40", Offset = "0x6585F40", VA = "0x186586B40")]
	public void GJBFFPEHKBH(int OIMKKCAHKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6587160", Offset = "0x6586560", VA = "0x186587160")]
	public void KEKOJNJKDEF(byte NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65871C0", Offset = "0x65865C0", VA = "0x1865871C0")]
	public void KEKOJNJKDEF(byte[] NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6586520", Offset = "0x6585920", VA = "0x186586520")]
	public void FBPACBDJPJC(byte NBPAJGPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6586C20", Offset = "0x6586020", VA = "0x186586C20")]
	public void HNFALCALCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6586F10", Offset = "0x6586310", VA = "0x186586F10")]
	public void JJMIIDNPCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6587290", Offset = "0x6586690", VA = "0x186587290")]
	public void LGGAKCFIDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6586560", Offset = "0x6585960", VA = "0x186586560")]
	public void FFNGMMENIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x65870A0", Offset = "0x65864A0", VA = "0x1865870A0")]
	public void KDIKKHODPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6586FD0", Offset = "0x65863D0", VA = "0x186586FD0")]
	public void KAPJAPGAMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6587670", Offset = "0x6586A70", VA = "0x186587670")]
	public void PKIFPLHPCOP(string JJOBNGACPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6586300", Offset = "0x6585700", VA = "0x186586300")]
	public void AMHFDEKHNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6586B80", Offset = "0x6585F80", VA = "0x186586B80")]
	public void HNDLNAKFHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6586650", Offset = "0x6585A50", VA = "0x186586650")]
	public void FNNDOMNMACI(bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6586350", Offset = "0x6585750", VA = "0x186586350")]
	public void BILIPEMGNHO(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6587020", Offset = "0x6586420", VA = "0x186587020")]
	public void KCAGLOBFNMM(double NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65870F0", Offset = "0x65864F0", VA = "0x1865870F0")]
	public void KEHNLLMPHPO(byte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6587220", Offset = "0x6586620", VA = "0x186587220")]
	public void KIHNMBNFFKB(ushort NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x65863D0", Offset = "0x65857D0", VA = "0x1865863D0")]
	public void CFLPAALJGNE(uint NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6587450", Offset = "0x6586850", VA = "0x186587450")]
	public void NMHGFFKKICL(ulong NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x65864B0", Offset = "0x65858B0", VA = "0x1865864B0")]
	public void DGAHFLCEMHE(sbyte NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6587600", Offset = "0x6586A00", VA = "0x186587600")]
	public void PBPKLEOMHDE(short NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6586440", Offset = "0x6585840", VA = "0x186586440")]
	public void CMHNNGIECPN(int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6586B50", Offset = "0x6585F50", VA = "0x186586B50")]
	public void HCLKEMNIMIJ(long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65867B0", Offset = "0x6585BB0", VA = "0x1865867B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3521590", Offset = "0x3520990", VA = "0x183521590")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6587FD0", Offset = "0x65873D0", VA = "0x186587FD0")]
	static NNBKHHGOCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65877E0", Offset = "0x6586BE0", VA = "0x1865877E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x656D5C0", Offset = "0x656C9C0", VA = "0x18656D5C0")]
	public BNLDAAJDJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x656D0E0", Offset = "0x656C4E0", VA = "0x18656D0E0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector2 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x656D2D0", Offset = "0x656C6D0", VA = "0x18656D2D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x656CE70", Offset = "0x656C270", VA = "0x18656CE70")]
	public BLNBFKGDDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x656C880", Offset = "0x656BC80", VA = "0x18656C880", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector3 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x656CB20", Offset = "0x656BF20", VA = "0x18656CB20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6572A30", Offset = "0x6571E30", VA = "0x186572A30")]
	public EOGLKEBDAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6572360", Offset = "0x6571760", VA = "0x186572360", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Vector4 NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x65726A0", Offset = "0x6571AA0", VA = "0x1865726A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x656C450", Offset = "0x656B850", VA = "0x18656C450")]
	public BCHEKPOOLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x656BD80", Offset = "0x656B180", VA = "0x18656BD80", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Quaternion NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x656C0C0", Offset = "0x656B4C0", VA = "0x18656C0C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x656DE70", Offset = "0x656D270", VA = "0x18656DE70")]
	public CBCIAEKEMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x656D7A0", Offset = "0x656CBA0", VA = "0x18656D7A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Color NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x656DAE0", Offset = "0x656CEE0", VA = "0x18656DAE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65856C0", Offset = "0x6584AC0", VA = "0x1865856C0")]
	public LNBMKCEHCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6584FC0", Offset = "0x65843C0", VA = "0x186584FC0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Bounds NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65852E0", Offset = "0x65846E0", VA = "0x1865852E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x657F9C0", Offset = "0x657EDC0", VA = "0x18657F9C0")]
	public JPLDBMMLCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x657F260", Offset = "0x657E660", VA = "0x18657F260", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Rect NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x657F5D0", Offset = "0x657E9D0", VA = "0x18657F5D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x36C29C0", Offset = "0x36C1DC0", VA = "0x1836C29C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4909300", Offset = "0x4908700", VA = "0x184909300")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570530", Offset = "0x656F930", VA = "0x186570530")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3670180", Offset = "0x366F580", VA = "0x183670180")]
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
	[Cpp2IlInjected.Address(RVA = "0x657ED90", Offset = "0x657E190", VA = "0x18657ED90")]
	public static void CNJGKMHEDKP(params PMECKIJLNID[] FOFJFOLNDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x657EE70", Offset = "0x657E270", VA = "0x18657EE70")]
	public static void CNJGKMHEDKP(params BOILAFIIEAN[] HHNHEIJACMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x657EB00", Offset = "0x657DF00", VA = "0x18657EB00")]
	public static void AMGBMEHHIDP(BOILAFIIEAN[] HHNHEIJACMJ, PMECKIJLNID[] FOFJFOLNDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D9DE00", Offset = "0x4D9D200", VA = "0x184D9DE00")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6583150", Offset = "0x6582550", VA = "0x186583150")]
	internal static object HFHHHJNIJAI(Type AINBOEMJDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65848B0", Offset = "0x6583CB0", VA = "0x1865848B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3527620", Offset = "0x3526A20", VA = "0x183527620")]
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
	[Cpp2IlInjected.Address(RVA = "0x657E720", Offset = "0x657DB20", VA = "0x18657E720")]
	static IAELOJBODAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private IAELOJBODAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36C8D90", Offset = "0x36C8190", VA = "0x1836C8D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x657E5B0", Offset = "0x657D9B0", VA = "0x18657E5B0")]
	static HDBBLOOJHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private HDBBLOOJHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CA70E0", Offset = "0x3CA64E0", VA = "0x183CA70E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x657F0F0", Offset = "0x657E4F0", VA = "0x18657F0F0")]
	static JMPKBKNKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private JMPKBKNKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35452C0", Offset = "0x35446C0", VA = "0x1835452C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6588650", Offset = "0x6587A50", VA = "0x186588650")]
	static PGAAOBKEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private PGAAOBKEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE32F0", Offset = "0x3EE26F0", VA = "0x183EE32F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6585D30", Offset = "0x6585130", VA = "0x186585D30")]
	static NDFOCJNJBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private NDFOCJNJBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F134E0", Offset = "0x3F128E0", VA = "0x183F134E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x657E990", Offset = "0x657DD90", VA = "0x18657E990")]
	static IFCNGHGGFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	private IFCNGHGGFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4541700", Offset = "0x4540B00", VA = "0x184541700")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A96710", Offset = "0x3A95B10", VA = "0x183A96710")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3902970", Offset = "0x3901D70", VA = "0x183902970")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3969030", Offset = "0x3968430", VA = "0x183969030")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4910EC0", Offset = "0x49102C0", VA = "0x184910EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x360E460", Offset = "0x360D860", VA = "0x18360E460")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x65894B0", Offset = "0x65888B0", VA = "0x1865894B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658F240", Offset = "0x658E640", VA = "0x18658F240")]
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
		[Cpp2IlInjected.Address(RVA = "0x656E940", Offset = "0x656DD40", VA = "0x18656E940")]
		public static MethodInfo ALIOEPOJFBC(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x656ED00", Offset = "0x656E100", VA = "0x18656ED00")]
		public static MethodInfo JKMDPBEAKHM(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x656EBD0", Offset = "0x656DFD0", VA = "0x18656EBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B230", Offset = "0x658A630", VA = "0x18658B230")]
		internal void CJFDJFIMNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x658B330", Offset = "0x658A730", VA = "0x18658B330")]
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
		[Cpp2IlInjected.Address(RVA = "0x659E1D0", Offset = "0x659D5D0", VA = "0x18659E1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DBA580", Offset = "0x4DB9980", VA = "0x184DBA580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6595CA0", Offset = "0x65950A0", VA = "0x186595CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A02D0", Offset = "0x659F6D0", VA = "0x1865A02D0")]
		internal void DCHMAPKNPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65A0350", Offset = "0x659F750", VA = "0x1865A0350")]
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
		[Cpp2IlInjected.Address(RVA = "0x6592190", Offset = "0x6591590", VA = "0x186592190")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AB70", Offset = "0x6589F70", VA = "0x18658AB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6597C90", Offset = "0x6597090", VA = "0x186597C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6592410", Offset = "0x6591810", VA = "0x186592410")]
		internal void MFFBJGENFKG(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6592370", Offset = "0x6591770", VA = "0x186592370")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF39E0", Offset = "0xAF2DE0", VA = "0x180AF39E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF39E0", Offset = "0xAF2DE0", VA = "0x180AF39E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x24EBFB0", Offset = "0x24EB3B0", VA = "0x1824EBFB0")]
	public static object IFEDDKJLMKP<T>(EDGFJJCKCKN DMEBGPNMPEC, PMECKIJLNID GBOLHIPMMPE, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x24F7230", Offset = "0x24F6630", VA = "0x1824F7230")]
	public static object JJMECMKGBAN<T>(PMECKIJLNID GBOLHIPMMPE, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII, bool MEBCNCCFLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6578780", Offset = "0x6577B80", VA = "0x186578780")]
	private static TypeInfo MKKELNFLGBN(EDGFJJCKCKN DMEBGPNMPEC, Type LFLAEPCPMDG, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x657ABB0", Offset = "0x6579FB0", VA = "0x18657ABB0")]
	public static object PICDDEABMBF(Type LFLAEPCPMDG, Func<string, string> ABNPFLFJCCM, bool GGIOGBPFFII, bool MEBCNCCFLCP, bool OALPMIPJGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6574FB0", Offset = "0x65743B0", VA = "0x186574FB0")]
	private static Dictionary<GPLPOGHBDHO, FieldInfo> DOKAPNKDIBP(TypeBuilder CGKICNDNAJN, JNCDAPNGHKD PPPGPJEJFAJ, ConstructorInfo EHEJGNENLFE, FieldBuilder EONNDJAPOKA, ILGenerator LDKPHNBJGBA, bool GGIOGBPFFII, bool ADPMOGLGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x657A4D0", Offset = "0x65798D0", VA = "0x18657A4D0")]
	private static Dictionary<GPLPOGHBDHO, FieldInfo> PHOIIDBOPAB(TypeBuilder CGKICNDNAJN, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65756E0", Offset = "0x6574AE0", VA = "0x1865756E0")]
	private static void GGJNDCGOGAC(Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA, Action CMJIBOANKCP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, bool GGIOGBPFFII, bool ADPMOGLGOOF, int GGKBKBKBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6574A70", Offset = "0x6573E70", VA = "0x186574A70")]
	private static void BAGEBAOBAIN(TypeInfo LFLAEPCPMDG, GPLPOGHBDHO BAELLAPOEPH, ILGenerator LDKPHNBJGBA, int DIENMHDGFGP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, BFFGOOHOALI EKCFHKIKCOP, BFFGOOHOALI HOCMDHEFHJM, BFFGOOHOALI CFKKMPPKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65791A0", Offset = "0x65785A0", VA = "0x1865791A0")]
	private static void MLLCEIMDEBP(Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, ILGenerator LDKPHNBJGBA, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, bool KDNIMLLEBKF, int GGKBKBKBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6576D20", Offset = "0x6576120", VA = "0x186576D20")]
	private static void JMKDHNBHOEF(ILGenerator LDKPHNBJGBA, DKHPDJHOKAC PPPGPJEJFAJ, int DIENMHDGFGP, Func<int, GPLPOGHBDHO, bool> MELJKJDMKAA, BFFGOOHOALI PCDAGGPDBLK, BFFGOOHOALI CFKKMPPKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6577870", Offset = "0x6576C70", VA = "0x186577870")]
	private static LocalBuilder KGGPCPEBIHO(ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG, JNCDAPNGHKD PPPGPJEJFAJ, DKHPDJHOKAC[] LMHILKLGKCE, bool PNFFDMMCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6577190", Offset = "0x6576590", VA = "0x186577190")]
	private static bool KFMIDBLCGFM(ConstructorInfo BDOJPKLABJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6578600", Offset = "0x6577A00", VA = "0x186578600")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CA43B0", Offset = "0x1CA37B0", VA = "0x181CA43B0")]
	public HPNCCBELLPK(byte[][] EONNDJAPOKA, object[] KLCMJNOOHOI, object[] FIAIHLIOFLG, IHPCLBDMMFP<T> ECDIACCCOLK, IFIAHGANEOC<T> BIMCAOIGJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3621970", Offset = "0x3620D70", VA = "0x183621970", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3621A60", Offset = "0x3620E60", VA = "0x183621A60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x39700F0", Offset = "0x396F4F0", VA = "0x1839700F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4815AB0", Offset = "0x4814EB0", VA = "0x184815AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x366B960", Offset = "0x366AD60", VA = "0x18366B960")]
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
			[Cpp2IlInjected.Address(RVA = "0x480DFC0", Offset = "0x480D3C0", VA = "0x18480DFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x356F3F0", Offset = "0x356E7F0", VA = "0x18356F3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x35D32F0", Offset = "0x35D26F0", VA = "0x1835D32F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3448C10", Offset = "0x3448010", VA = "0x183448C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x458A360", Offset = "0x4589760", VA = "0x18458A360")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E00230", Offset = "0x3DFF630", VA = "0x183E00230")]
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
			[Cpp2IlInjected.Address(RVA = "0x38DE410", Offset = "0x38DD810", VA = "0x1838DE410")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4555C40", Offset = "0x4555040", VA = "0x184555C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x361F120", Offset = "0x361E520", VA = "0x18361F120")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DC35D0", Offset = "0x4DC29D0", VA = "0x184DC35D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E1A4B0", Offset = "0x3E198B0", VA = "0x183E1A4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x391BD60", Offset = "0x391B160", VA = "0x18391BD60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3969C80", Offset = "0x3969080", VA = "0x183969C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35D6070", Offset = "0x35D5470", VA = "0x1835D6070")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ABC230", Offset = "0x3ABB630", VA = "0x183ABC230")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EBE5A0", Offset = "0x3EBD9A0", VA = "0x183EBE5A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DDE020", Offset = "0x4DDD420", VA = "0x184DDE020")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x390D660", Offset = "0x390CA60", VA = "0x18390D660")]
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
			[Cpp2IlInjected.Address(RVA = "0x3734170", Offset = "0x3733570", VA = "0x183734170")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3536B60", Offset = "0x3535F60", VA = "0x183536B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AA8100", Offset = "0x3AA7500", VA = "0x183AA8100")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EAE0D0", Offset = "0x3EAD4D0", VA = "0x183EAE0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0ABE0", Offset = "0x3E09FE0", VA = "0x183E0ABE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x22B7C50", Offset = "0x22B7050", VA = "0x1822B7C50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3562CC0", Offset = "0x35620C0", VA = "0x183562CC0")]
	public AJGGMHIIHMM(int LJFEOIBMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3562990", Offset = "0x3561D90", VA = "0x183562990")]
	public void BKKEPFPDOJH(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3562C30", Offset = "0x3562030", VA = "0x183562C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6592140", Offset = "0x6591540", VA = "0x186592140")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D30760", Offset = "0x3D2FB60", VA = "0x183D30760")]
	public NJLGHCBJBBJ(int OBBMNEKDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F260", Offset = "0x3D2E660", VA = "0x183D2F260")]
	public T[] BEAKOFMCJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F620", Offset = "0x3D2EA20", VA = "0x183D2F620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8ECB00", Offset = "0x8EBF00", VA = "0x1808ECB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6598150", Offset = "0x6597550", VA = "0x186598150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6598280", Offset = "0x6597680", VA = "0x186598280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x65981D0", Offset = "0x65975D0", VA = "0x1865981D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NILPNLJFDCA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x65981D0", Offset = "0x65975D0", VA = "0x1865981D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x658AB70", Offset = "0x6589F70", VA = "0x18658AB70")]
			internal Label KDINAPEFFLL(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x658AB70", Offset = "0x6589F70", VA = "0x18658AB70")]
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
			[Cpp2IlInjected.Address(RVA = "0x50BE9B0", Offset = "0x50BDDB0", VA = "0x1850BE9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x659E110", Offset = "0x659D510", VA = "0x18659E110")]
		public NILPNLJFDCA(ulong MIMFBLPNKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x659CAE0", Offset = "0x659BEE0", VA = "0x18659CAE0")]
		public NILPNLJFDCA BKKEPFPDOJH(ulong MIMFBLPNKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x659CCE0", Offset = "0x659C0E0", VA = "0x18659CCE0")]
		public NILPNLJFDCA BKKEPFPDOJH(ulong MIMFBLPNKOG, int NMENOOMOOJP, string GAGCMCLOJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x659DEE0", Offset = "0x659D2E0", VA = "0x18659DEE0")]
		public NILPNLJFDCA PFEFBKFPJAA(byte[] ENFHPFLKGCP, int ELJAGIMMLLH, int EHBDDHCIDOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x659DAD0", Offset = "0x659CED0", VA = "0x18659DAD0")]
		internal static int IHIOLPIFOAD(ulong[] NCABOBFFNFK, int DIENMHDGFGP, int HKIFHAEDDHO, ulong NMENOOMOOJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x659DA20", Offset = "0x659CE20", VA = "0x18659DA20", Slot = "4")]
		public int CompareTo(NILPNLJFDCA LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x659DA50", Offset = "0x659CE50", VA = "0x18659DA50")]
		[IteratorStateMachine(typeof(MGBDJDMBNLM))]
		public IEnumerable<NILPNLJFDCA> FJCDHJJAOPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x659DB60", Offset = "0x659CF60", VA = "0x18659DB60")]
		public void OLCMMPLKPAK(ILGenerator LDKPHNBJGBA, LocalBuilder ENFHPFLKGCP, LocalBuilder EHBDDHCIDOJ, LocalBuilder MIMFBLPNKOG, Action<KeyValuePair<string, int>> NEICLJJFLOI, Action MHKFEFBBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x659CD40", Offset = "0x659C140", VA = "0x18659CD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x659F700", Offset = "0x659EB00", VA = "0x18659F700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1BCCA90", Offset = "0x1BCBE90", VA = "0x181BCCA90")]
		[DebuggerHidden]
		public OFKEDOMHONL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x659F750", Offset = "0x659EB50", VA = "0x18659F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x659F150", Offset = "0x659E550", VA = "0x18659F150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x659F5B0", Offset = "0x659E9B0", VA = "0x18659F5B0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x659F100", Offset = "0x659E500", VA = "0x18659F100")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x659F6B0", Offset = "0x659EAB0", VA = "0x18659F6B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x659F600", Offset = "0x659EA00", VA = "0x18659F600", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x659F600", Offset = "0x659EA00", VA = "0x18659F600", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6594680", Offset = "0x6593A80", VA = "0x186594680")]
	public JGOCJFKOPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6594010", Offset = "0x6593410", VA = "0x186594010")]
	public void BKKEPFPDOJH(byte[] HPGJIANHJNN, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6594480", Offset = "0x6593880", VA = "0x186594480")]
	public bool GILOFHELLPF(ArraySegment<byte> MIMFBLPNKOG, [Out] int NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x65945F0", Offset = "0x65939F0", VA = "0x1865945F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x65941A0", Offset = "0x65935A0", VA = "0x1865941A0")]
	private static void EGBHCHBPEJD(IEnumerable<NILPNLJFDCA> LOLCCPIJNGJ, StringBuilder EPCOKKKGDLF, int KPHHMKNGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6594560", Offset = "0x6593960", VA = "0x186594560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6594560", Offset = "0x6593960", VA = "0x186594560", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6594120", Offset = "0x6593520", VA = "0x186594120")]
	[IteratorStateMachine(typeof(OFKEDOMHONL))]
	private static IEnumerable<KeyValuePair<string, int>> CABCDCALKDB(IEnumerable<NILPNLJFDCA> LOLCCPIJNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x65945C0", Offset = "0x65939C0", VA = "0x1865945C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A0530", Offset = "0x659F930", VA = "0x1865A0530")]
	public static ulong CBACLHHCEGH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, int EHBDDHCIDOJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class DKLBPDICPMA
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x658B730", Offset = "0x658AB30", VA = "0x18658B730")]
	public static void GJBFFPEHKBH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, int OIMKKCAHKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x658B610", Offset = "0x658AA10", VA = "0x18658B610")]
	public static void ELMLDGPLMGK(byte[] NCABOBFFNFK, int KPPJFIPBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x658B870", Offset = "0x658AC70", VA = "0x18658B870")]
	public static byte[] GNJJIDKAPNI(byte[] BPLFEJNHBNI, int KPPJFIPBECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class EOBKGMBMODO
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x658EC90", Offset = "0x658E090", VA = "0x18658EC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EB3770", Offset = "0x3EB2B70", VA = "0x183EB3770", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34B5150", Offset = "0x34B4550", VA = "0x1834B5150", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x4826AC0", Offset = "0x4825EC0", VA = "0x184826AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4827220", Offset = "0x4826620", VA = "0x184827220", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CD8260", Offset = "0x3CD7660", VA = "0x183CD8260")]
	public MMANBIJFINJ(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3CD81A0", Offset = "0x3CD75A0", VA = "0x183CD81A0")]
	public MMANBIJFINJ(int EKJEIMGCNCB, float FAAAHIGDABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4060", Offset = "0x3CD3460", VA = "0x183CD4060")]
	public void BKKEPFPDOJH(byte[] MIMFBLPNKOG, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E90", Offset = "0x3CD5290", VA = "0x183CD5E90")]
	private bool NNKBFDGLJEL(byte[] MIMFBLPNKOG, T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1ED0", Offset = "0x3CD12D0", VA = "0x183CD1ED0")]
	public bool AFCHMNEGHNL(ArraySegment<byte> MIMFBLPNKOG, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4940", Offset = "0x3CD3D40", VA = "0x183CD4940")]
	private static ulong JDOBNLIGKMD(byte[] OPHKAEHAFCM, int ELJAGIMMLLH, int APAKJDHFMCK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8170", Offset = "0x3CD7570", VA = "0x183CD8170")]
	private static int PFDONLOKHBE(int DOAIFFFJHLC, float FAAAHIGDABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4790", Offset = "0x3CD3B90", VA = "0x183CD4790", Slot = "4")]
	[IteratorStateMachine(typeof(MMANBIJFINJ<>.CKCJMJAOLIF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33C5AD0", Offset = "0x33C4ED0", VA = "0x1833C5AD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658A430", Offset = "0x6589830", VA = "0x18658A430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x658A580", Offset = "0x6589980", VA = "0x18658A580")]
	static CAHAIDLONMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x658A7E0", Offset = "0x6589BE0", VA = "0x18658A7E0")]
	public CAHAIDLONMA(byte[] IPBHAAFOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x658A480", Offset = "0x6589880", VA = "0x18658A480")]
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
	[Cpp2IlInjected.Address(RVA = "0x658D360", Offset = "0x658C760", VA = "0x18658D360")]
	public ELAPGJBGCPL(Guid NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x658D370", Offset = "0x658C770", VA = "0x18658D370")]
	public ELAPGJBGCPL(ArraySegment<byte> GMLGMJPHPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x658C520", Offset = "0x658B920", VA = "0x18658C520")]
	private static byte BMGCABDGNEC(byte[] HPGJIANHJNN, int LNJDIGOPEHP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x658C400", Offset = "0x658B800", VA = "0x18658C400")]
	private static byte BBOKJEIDDMK(byte MLKGDIFPGGI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x658C5C0", Offset = "0x658B9C0", VA = "0x18658C5C0")]
	public void OMAJEIBBGKE(byte[] PNJHGINLCID, int ELJAGIMMLLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class KPFBALMEHKC
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6596FE0", Offset = "0x65963E0", VA = "0x186596FE0")]
	public static bool INMHGMDEIJG(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x65964C0", Offset = "0x65958C0", VA = "0x1865964C0")]
	public static bool DBEJGFBKDBL(byte CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6596FF0", Offset = "0x65963F0", VA = "0x186596FF0")]
	public static sbyte KBFMJOGABOF(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x65961D0", Offset = "0x65955D0", VA = "0x1865961D0")]
	public static short BKNGJENCFCH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x65973A0", Offset = "0x65967A0", VA = "0x1865973A0")]
	public static int MCMNIGONMKJ(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6597300", Offset = "0x6596700", VA = "0x186597300")]
	public static long LHMCMHDJEID(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6596330", Offset = "0x6595730", VA = "0x186596330")]
	public static byte CCJANAADGKD(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6597490", Offset = "0x6596890", VA = "0x186597490")]
	public static ushort NJLHMKLFJKH(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6596530", Offset = "0x6595930", VA = "0x186596530")]
	public static uint DCEHLEOPJHI(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x65963B0", Offset = "0x65957B0", VA = "0x1865963B0")]
	public static ulong CIBJNOKILNF(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x65962C0", Offset = "0x65956C0", VA = "0x1865962C0")]
	public static float BPAILFIOIGE(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6596F70", Offset = "0x6596370", VA = "0x186596F70")]
	public static double IANMBMAHIAA(byte[] HPGJIANHJNN, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6597510", Offset = "0x6596910", VA = "0x186597510")]
	public static int NMHGFFKKICL(byte[] PNJHGINLCID, int ELJAGIMMLLH, ulong NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x65965B0", Offset = "0x65959B0", VA = "0x1865965B0")]
	public static int HCLKEMNIMIJ(byte[] PNJHGINLCID, int ELJAGIMMLLH, long NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x65970D0", Offset = "0x65964D0", VA = "0x1865970D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ECB00", Offset = "0x8EBF00", VA = "0x1808ECB00")]
		[DebuggerHidden]
		public GCJLJDOFIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6591F70", Offset = "0x6591370", VA = "0x186591F70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x65919E0", Offset = "0x6590DE0", VA = "0x1865919E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6591E10", Offset = "0x6591210", VA = "0x186591E10")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6591990", Offset = "0x6590D90", VA = "0x186591990")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6591F20", Offset = "0x6591320", VA = "0x186591F20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6591E60", Offset = "0x6591260", VA = "0x186591E60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6591E60", Offset = "0x6591260", VA = "0x186591E60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ECB00", Offset = "0x8EBF00", VA = "0x1808ECB00")]
		[DebuggerHidden]
		public PFMBCLIIION(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x65A01A0", Offset = "0x659F5A0", VA = "0x1865A01A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x659FC10", Offset = "0x659F010", VA = "0x18659FC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x65A0040", Offset = "0x659F440", VA = "0x1865A0040")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x659FBC0", Offset = "0x659EFC0", VA = "0x18659FBC0")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x65A0150", Offset = "0x659F550", VA = "0x1865A0150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x65A0090", Offset = "0x659F490", VA = "0x1865A0090", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x65A0090", Offset = "0x659F490", VA = "0x1865A0090", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6592E90", Offset = "0x6592290", VA = "0x186592E90")]
	public static bool AICPMDKKPOA(this TypeInfo LFLAEPCPMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6592F50", Offset = "0x6592350", VA = "0x186592F50")]
	public static bool CHPCDFAFLGE(this TypeInfo LFLAEPCPMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6593240", Offset = "0x6592640", VA = "0x186593240")]
	public static IEnumerable<PropertyInfo> OAKBGEIOJCH(this Type LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x65931A0", Offset = "0x65925A0", VA = "0x1865931A0")]
	[IteratorStateMachine(typeof(GCJLJDOFIJD))]
	private static IEnumerable<PropertyInfo> MDEPCJJONAJ(Type LFLAEPCPMDG, HashSet<string> DDLBGGEFPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6593120", Offset = "0x6592520", VA = "0x186593120")]
	public static IEnumerable<FieldInfo> KPMAKLOOPCC(this Type LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6593080", Offset = "0x6592480", VA = "0x186593080")]
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
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static string MEECKKNBILE(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x658AD30", Offset = "0x658A130", VA = "0x18658AD30")]
	public static string JFLDPKEKOCI(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x658ABA0", Offset = "0x6589FA0", VA = "0x18658ABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EBADC0", Offset = "0x3EBA1C0", VA = "0x183EBADC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3EBAC70", Offset = "0x3EBA070", VA = "0x183EBAC70")]
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
		[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x48238F0", Offset = "0x4822CF0", VA = "0x1848238F0")]
	public CJHBBAIALEN(int EKJEIMGCNCB = 4, float FAAAHIGDABH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x48227D0", Offset = "0x4821BD0", VA = "0x1848227D0")]
	public bool BMPLIEBGIDJ(Type MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x4822790", Offset = "0x4821B90", VA = "0x184822790")]
	public bool BMPLIEBGIDJ(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x4823590", Offset = "0x4822990", VA = "0x184823590")]
	private bool NNKBFDGLJEL(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM, [Out] TValue BPHGAIHGBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x4822E40", Offset = "0x4822240", VA = "0x184822E40")]
	private bool JFGPNNLJBFJ(PBIEAJDIGKK[] MJDBLPFGMGF, Type KGHLDIHJPKE, PBIEAJDIGKK HKHABHOFFNJ, Func<Type, TValue> FHBCEADFDBM, [Out] TValue BPHGAIHGBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x48223A0", Offset = "0x48217A0", VA = "0x1848223A0")]
	public bool AFCHMNEGHNL(Type MIMFBLPNKOG, [Out] TValue NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x4822930", Offset = "0x4821D30", VA = "0x184822930")]
	public TValue FNLFIKFJFDE(Type MIMFBLPNKOG, Func<Type, TValue> FHBCEADFDBM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD8170", Offset = "0x3CD7570", VA = "0x183CD8170")]
	private static int PFDONLOKHBE(int DOAIFFFJHLC, float FAAAHIGDABH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4822900", Offset = "0x4821D00", VA = "0x184822900")]
	private static void EANACHGPNCB(PBIEAJDIGKK IKHOJOLHDEK, PBIEAJDIGKK NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4822900", Offset = "0x4821D00", VA = "0x184822900")]
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
	[Cpp2IlInjected.Address(RVA = "0x658BFF0", Offset = "0x658B3F0", VA = "0x18658BFF0")]
	public TypeBuilder GKPHNACHPON(string MDFAJJKMBAI, TypeAttributes KNBDCDCCHPE, Type ECLIMLPEPIL, Type[] AIHMGABFDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x658C0F0", Offset = "0x658B4F0", VA = "0x18658C0F0")]
	public EDGFJJCKCKN(string LDGEODIDJLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class LEBKJJFMNNA
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6597BB0", Offset = "0x6596FB0", VA = "0x186597BB0")]
	private static MethodInfo KLBONDCGEJL(LambdaExpression LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x25817E0", Offset = "0x2580BE0", VA = "0x1825817E0")]
	public static MethodInfo DPOCEHNPBHH<T>(Expression<Func<T>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25817E0", Offset = "0x2580BE0", VA = "0x1825817E0")]
	public static MethodInfo DPOCEHNPBHH<T, TR>(Expression<Func<T, TR>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x25817E0", Offset = "0x2580BE0", VA = "0x1825817E0")]
	public static MethodInfo DPOCEHNPBHH<T>(Expression<Action<T>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x25817E0", Offset = "0x2580BE0", VA = "0x1825817E0")]
	public static MethodInfo DPOCEHNPBHH<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> LFCMKINGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2581890", Offset = "0x2580C90", VA = "0x182581890")]
	private static MemberInfo OHCIAECFPJL<T>(Expression<T> HFLNDIDMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x25817F0", Offset = "0x2580BF0", VA = "0x1825817F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6589470", Offset = "0x6588870", VA = "0x186589470")]
	public BFFGOOHOALI(ILGenerator LDKPHNBJGBA, int JNJOJJJELGE, bool AOKEMINNDOP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x65893E0", Offset = "0x65887E0", VA = "0x1865893E0")]
	public BFFGOOHOALI(ILGenerator LDKPHNBJGBA, int JNJOJJJELGE, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x65892E0", Offset = "0x65886E0", VA = "0x1865892E0")]
	public void IGCEKMDBMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class MJBEDGENHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x659AA40", Offset = "0x6599E40", VA = "0x18659AA40")]
	public static void HCFNLIOJNDA(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x659AA00", Offset = "0x6599E00", VA = "0x18659AA00")]
	public static void HCFNLIOJNDA(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x659B010", Offset = "0x659A410", VA = "0x18659B010")]
	public static void JEJANMHCBDL(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x659B200", Offset = "0x659A600", VA = "0x18659B200")]
	public static void JEJANMHCBDL(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x659B410", Offset = "0x659A810", VA = "0x18659B410")]
	public static void OMFALJGHEEN(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x659B4F0", Offset = "0x659A8F0", VA = "0x18659B4F0")]
	public static void OMFALJGHEEN(this ILGenerator LDKPHNBJGBA, LocalBuilder JLNANGOIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x659B2E0", Offset = "0x659A6E0", VA = "0x18659B2E0")]
	public static void MGIHBJLIAOK(this ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x659A910", Offset = "0x6599D10", VA = "0x18659A910")]
	public static void ENBDEHFFDKK(this ILGenerator LDKPHNBJGBA, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x659AC30", Offset = "0x659A030", VA = "0x18659AC30")]
	public static void HOPNPJBDHFL(this ILGenerator LDKPHNBJGBA, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x659A920", Offset = "0x6599D20", VA = "0x18659A920")]
	public static void GCGFDKBPMHF(this ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x659B240", Offset = "0x659A640", VA = "0x18659B240")]
	public static void KIPHEANDELJ(this ILGenerator LDKPHNBJGBA, Type LFLAEPCPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x659A4D0", Offset = "0x65998D0", VA = "0x18659A4D0")]
	public static void AEOKCIAJMMJ(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x659A890", Offset = "0x6599C90", VA = "0x18659A890")]
	public static void DDMDFLPGOAP(this ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x659A7B0", Offset = "0x6599BB0", VA = "0x18659A7B0")]
	public static void AJIFCMBBNCH(this ILGenerator LDKPHNBJGBA, int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x659A6C0", Offset = "0x6599AC0", VA = "0x18659A6C0")]
	public static void AHPEOJGLMCD(this ILGenerator LDKPHNBJGBA, MethodInfo BFEODAFDFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x659B380", Offset = "0x659A780", VA = "0x18659B380")]
	public static void OJFIIFGIJNL(this ILGenerator LDKPHNBJGBA, FieldInfo KBHJNOPKNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x659B2F0", Offset = "0x659A6F0", VA = "0x18659B2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x659FAB0", Offset = "0x659EEB0", VA = "0x18659FAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6592B30", Offset = "0x6591F30", VA = "0x186592B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8838A0", Offset = "0x882CA0", VA = "0x1808838A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x883590", Offset = "0x882990", VA = "0x180883590")]
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
	[Cpp2IlInjected.Address(RVA = "0x6592B40", Offset = "0x6591F40", VA = "0x186592B40")]
	protected GPLPOGHBDHO(Type LFLAEPCPMDG, string MDFAJJKMBAI, string CADJHIEGOKJ, bool CFEKLNBCHKF, bool EFBHNJNLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6592D80", Offset = "0x6592180", VA = "0x186592D80")]
	public GPLPOGHBDHO(FieldInfo PPPGPJEJFAJ, string MDFAJJKMBAI, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6592BC0", Offset = "0x6591FC0", VA = "0x186592BC0")]
	public GPLPOGHBDHO(PropertyInfo PPPGPJEJFAJ, string MDFAJJKMBAI, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65926C0", Offset = "0x6591AC0", VA = "0x1865926C0")]
	private static MethodInfo DPOHGHHJHDN(MemberInfo PPPGPJEJFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2529A90", Offset = "0x2528E90", VA = "0x182529A90")]
	public T HIOFJGKGPKJ<T>(bool OKKEPLFBDBF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6592830", Offset = "0x6591C30", VA = "0x186592830", Slot = "4")]
	public virtual void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x65929B0", Offset = "0x6591DB0", VA = "0x1865929B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6593760", Offset = "0x6592B60", VA = "0x186593760")]
	public HJOPBPGHPLH(string MDFAJJKMBAI, string FFOEBKJHLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6593660", Offset = "0x6592A60", VA = "0x186593660", Slot = "4")]
	public override void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6593710", Offset = "0x6592B10", VA = "0x186593710", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x659EEC0", Offset = "0x659E2C0", VA = "0x18659EEC0")]
	public OBNPLNHFGGM(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x659E6E0", Offset = "0x659DAE0", VA = "0x18659E6E0", Slot = "4")]
	public override void FOPOBGHLNMD(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x659E7A0", Offset = "0x659DBA0", VA = "0x18659E7A0", Slot = "5")]
	public override void MNDBKFFJKNI(ILGenerator LDKPHNBJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x659E7F0", Offset = "0x659DBF0", VA = "0x18659E7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C370", Offset = "0x87B770", VA = "0x18087C370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87C190", Offset = "0x87B590", VA = "0x18087C190")]
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
	[Cpp2IlInjected.Address(RVA = "0x65947E0", Offset = "0x6593BE0", VA = "0x1865947E0")]
	public JNCDAPNGHKD(Type LFLAEPCPMDG, Func<string, string> CPNKKEMBDLA, bool MEBCNCCFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6594700", Offset = "0x6593B00", VA = "0x186594700")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CFD4A0", Offset = "0x1CFC8A0", VA = "0x181CFD4A0")]
	public NNPGNDBKKGD(ulong LJLDAGOJCHJ, int KHOKKOOKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x659E330", Offset = "0x659D730", VA = "0x18659E330")]
	public void APEPFHHKOGL(NNPGNDBKKGD LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x659E340", Offset = "0x659D740", VA = "0x18659E340")]
	public static NNPGNDBKKGD EEBKPIMJOIN(NNPGNDBKKGD JMHOJIPAIMC, NNPGNDBKKGD MLKGDIFPGGI)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x659E3E0", Offset = "0x659D7E0", VA = "0x18659E3E0")]
	public void NOOBKPOBMLO(NNPGNDBKKGD LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x659E470", Offset = "0x659D870", VA = "0x18659E470")]
	public static NNPGNDBKKGD OOJJMOPCDBN(NNPGNDBKKGD JMHOJIPAIMC, NNPGNDBKKGD MLKGDIFPGGI)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x659E3A0", Offset = "0x659D7A0", VA = "0x18659E3A0")]
	public void FHLNPMFHEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x659E350", Offset = "0x659D750", VA = "0x18659E350")]
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
	[Cpp2IlInjected.Address(RVA = "0x17501B0", Offset = "0x174F5B0", VA = "0x1817501B0")]
	public FAGFICEFCKP(byte[] PNJHGINLCID, int JCADPOBEOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6587160", Offset = "0x6586560", VA = "0x186587160")]
	public void AMAAIHMBIBF(byte DFBAIJNHOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x658F040", Offset = "0x658E440", VA = "0x18658F040")]
	public void NAIAJFMCFDN(byte[] DFBAIJNHOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x658EDA0", Offset = "0x658E1A0", VA = "0x18658EDA0")]
	public void CHMPKMBEMMM(byte[] DFBAIJNHOKM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x658EE20", Offset = "0x658E220", VA = "0x18658EE20")]
	public void CHMPKMBEMMM(byte[] DFBAIJNHOKM, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x658EFC0", Offset = "0x658E3C0", VA = "0x18658EFC0")]
	public void KLOLGOJKFCG(byte CPHKPECCMOM, int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x658EEC0", Offset = "0x658E2C0", VA = "0x18658EEC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6598510", Offset = "0x6597910", VA = "0x186598510")]
	private static byte[] CAKOONCMPAC(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x65987B0", Offset = "0x6597BB0", VA = "0x1865987B0")]
	private static byte[] CMOLCDJHAIO(int PEGIIHFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x65982D0", Offset = "0x65976D0", VA = "0x1865982D0")]
	public static int BKJAGJEBDAE(byte[] PNJHGINLCID, int ELJAGIMMLLH, float NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65983F0", Offset = "0x65977F0", VA = "0x1865983F0")]
	public static int BKJAGJEBDAE(byte[] PNJHGINLCID, int ELJAGIMMLLH, double NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6599D60", Offset = "0x6599160", VA = "0x186599D60")]
	private static bool MDAGGPAIDKL(byte[] PNJHGINLCID, int HKIFHAEDDHO, ulong JNFHMIJCCBA, ulong KNBKPMDEAHN, ulong EHBDDHCIDOJ, ulong HNAACHDEIJA, ulong HINJBFJJDNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6598890", Offset = "0x6597C90", VA = "0x186598890")]
	private static void DAFEDPNALKG(uint LJGBMIIMMGB, int CDIEFGMHAIC, [Out] uint OKFMFLEOHED, [Out] int NLLCODEPOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6599860", Offset = "0x6598C60", VA = "0x186599860")]
	private static bool KOPOFGNDGNF(NNPGNDBKKGD KBJEEPCDFIB, NNPGNDBKKGD IKENEDAFBLJ, NNPGNDBKKGD DDHOAELOJIH, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int JLGMFCJGFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6598E60", Offset = "0x6598260", VA = "0x186598E60")]
	private static bool HCMJEIDBJOO(double JEEPLNLHGDO, POKEKIFFKMI LEIDKMNBCMF, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int GNIGBAHGLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6599C50", Offset = "0x6599050", VA = "0x186599C50")]
	private static bool LJGICJCFBEJ(double JEEPLNLHGDO, POKEKIFFKMI LEIDKMNBCMF, byte[] PNJHGINLCID, [Out] int HKIFHAEDDHO, [Out] int CPCMMEDMAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x65985E0", Offset = "0x65979E0", VA = "0x1865985E0")]
	private static bool CBFIBOKLGON(double NMENOOMOOJP, FAGFICEFCKP KIOPOHNNGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6598980", Offset = "0x6597D80", VA = "0x186598980")]
	private static bool DDCGMNNKNHC(double NMENOOMOOJP, FAGFICEFCKP KIOPOHNNGHC, LIMNCGIHBLH LEIDKMNBCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x65992E0", Offset = "0x65986E0", VA = "0x1865992E0")]
	private static void KLOBBLBJKCN(byte[] IPMIEKNDOBH, int HKIFHAEDDHO, int CPCMMEDMAGN, int COGFKPGAIPJ, FAGFICEFCKP KIOPOHNNGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6599E50", Offset = "0x6599250", VA = "0x186599E50")]
	private static void PCPHKFKHPNO(byte[] IPMIEKNDOBH, int HKIFHAEDDHO, int KHOKKOOKFDN, FAGFICEFCKP KIOPOHNNGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6599670", Offset = "0x6598A70", VA = "0x186599670")]
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
	[Cpp2IlInjected.Address(RVA = "0x6593DD0", Offset = "0x65931D0", VA = "0x186593DD0")]
	public HLBLOLPMKEA(double IIPNDJEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6593DE0", Offset = "0x65931E0", VA = "0x186593DE0")]
	public HLBLOLPMKEA(NNPGNDBKKGD IIPNDJEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6593B20", Offset = "0x6592F20", VA = "0x186593B20")]
	public NNPGNDBKKGD IADNIKBMMHF()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6593B90", Offset = "0x6592F90", VA = "0x186593B90")]
	public NNPGNDBKKGD KBADHHDGICG()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910")]
	public ulong OOFKFCGJPLA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6593D50", Offset = "0x6593150", VA = "0x186593D50")]
	public double PIKCJKIODHH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6593C10", Offset = "0x6593010", VA = "0x186593C10")]
	public double KDKBFFGCOEN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6593840", Offset = "0x6592C40", VA = "0x186593840")]
	public int ANDKPDFCAOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x65939C0", Offset = "0x6592DC0", VA = "0x1865939C0")]
	public ulong FBIJMOIHNJA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6593CE0", Offset = "0x65930E0", VA = "0x186593CE0")]
	public bool LMPEGMGMKNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6593D30", Offset = "0x6593130", VA = "0x186593D30")]
	public bool OLFOPLMIGGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6593D00", Offset = "0x6593100", VA = "0x186593D00")]
	public bool OGHIINEOJKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x65939F0", Offset = "0x6592DF0", VA = "0x1865939F0")]
	public bool FCCDOBDHMOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6593CB0", Offset = "0x65930B0", VA = "0x186593CB0")]
	public int KIAIIJENGBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6593870", Offset = "0x6592C70", VA = "0x186593870")]
	public void CLEGLPLLGKF([Out] NNPGNDBKKGD MJCFLIHBNPM, [Out] NNPGNDBKKGD MLHPGJOLIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6593AB0", Offset = "0x6592EB0", VA = "0x186593AB0")]
	public bool GOKCJEGNDLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AC52C0", Offset = "0x2AC46C0", VA = "0x182AC52C0")]
	public double NMENOOMOOJP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6593B00", Offset = "0x6592F00", VA = "0x186593B00")]
	public static int HONMLMDNIBD(int KNKCFCGHKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6593CD0", Offset = "0x65930D0", VA = "0x186593CD0")]
	public static double KKGCBAGDGGD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6593A20", Offset = "0x6592E20", VA = "0x186593A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x201FD30", Offset = "0x201F130", VA = "0x18201FD30")]
	public OHFFINHFDFN(float FJJLEFEGIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x659FA50", Offset = "0x659EE50", VA = "0x18659FA50")]
	public NNPGNDBKKGD IADNIKBMMHF()
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0")]
	public uint BIGAKNEOFPF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x659F8A0", Offset = "0x659ECA0", VA = "0x18659F8A0")]
	public int ANDKPDFCAOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x659F9F0", Offset = "0x659EDF0", VA = "0x18659F9F0")]
	public uint FBIJMOIHNJA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x659FAA0", Offset = "0x659EEA0", VA = "0x18659FAA0")]
	public bool LMPEGMGMKNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x659F8C0", Offset = "0x659ECC0", VA = "0x18659F8C0")]
	public void CLEGLPLLGKF([Out] NNPGNDBKKGD MJCFLIHBNPM, [Out] NNPGNDBKKGD MLHPGJOLIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x659FA10", Offset = "0x659EE10", VA = "0x18659FA10")]
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
	[Cpp2IlInjected.Address(RVA = "0x6594000", Offset = "0x6593400", VA = "0x186594000")]
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
	[Cpp2IlInjected.Address(RVA = "0x659B5F0", Offset = "0x659A9F0", VA = "0x18659B5F0")]
	public static void BDOGFLLIHGD(int IBALNNMOLCL, int GIKJCHKLCJL, [Out] NNPGNDBKKGD OKFMFLEOHED, [Out] int GNIGBAHGLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x659B700", Offset = "0x659AB00", VA = "0x18659B700")]
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
		[Cpp2IlInjected.Address(RVA = "0x658ED60", Offset = "0x658E160", VA = "0x18658ED60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x376DCC0", Offset = "0x376D0C0", VA = "0x18376DCC0")]
	public FADMEACGLJJ(byte[] HPGJIANHJNN, int DFOEGCCLIEM, int HKIFHAEDDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x20503F0", Offset = "0x204F7F0", VA = "0x1820503F0")]
	public int HKIFHAEDDHO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x658ED00", Offset = "0x658E100", VA = "0x18658ED00")]
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
	[Cpp2IlInjected.Address(RVA = "0x6590450", Offset = "0x658F850", VA = "0x186590450")]
	private static byte[] FJKBHNCCLCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6590010", Offset = "0x658F410", VA = "0x186590010")]
	private static FADMEACGLJJ BCGAKLGCCLJ(FADMEACGLJJ PNJHGINLCID)
	{
		return default(FADMEACGLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x65915B0", Offset = "0x65909B0", VA = "0x1865915B0")]
	private static FADMEACGLJJ KGAJNFLONCF(FADMEACGLJJ PNJHGINLCID)
	{
		return default(FADMEACGLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x65903C0", Offset = "0x658F7C0", VA = "0x1865903C0")]
	private static void CNLJFLJFBJM(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, byte[] PDHHOPLLMPB, [Out] int CNFONGLDFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6590D20", Offset = "0x6590120", VA = "0x186590D20")]
	private static void GMIJLOJMIJP(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, byte[] KFPBEKILNIP, int GEOCPBEPAOI, [Out] FADMEACGLJJ FLHKDFHONLD, [Out] int PBIHIPAMKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6591010", Offset = "0x6590410", VA = "0x186591010")]
	private static ulong HHDLAGJCIFP(FADMEACGLJJ PNJHGINLCID, [Out] int BJKCCKPJMOA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6591470", Offset = "0x6590870", VA = "0x186591470")]
	private static void KDGPGPLFJCH(FADMEACGLJJ PNJHGINLCID, [Out] NNPGNDBKKGD KHFCBCPBAFG, [Out] int EABAPDMKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x65910A0", Offset = "0x65904A0", VA = "0x1865910A0")]
	private static bool HNCLOCGOINK(FADMEACGLJJ FLHKDFHONLD, int KHOKKOOKFDN, [Out] double KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6590530", Offset = "0x658F930", VA = "0x186590530")]
	private static NNPGNDBKKGD GGDBBGJPODO(int KHOKKOOKFDN)
	{
		return default(NNPGNDBKKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x65906D0", Offset = "0x658FAD0", VA = "0x1865906D0")]
	private static bool GGGHJPHMIPP(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN, [Out] double KHFCBCPBAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x65917B0", Offset = "0x6590BB0", VA = "0x1865917B0")]
	private static bool MNIBFGPAGHC(FADMEACGLJJ FLHKDFHONLD, int KHOKKOOKFDN, [Out] double PJMNDIEKGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6591690", Offset = "0x6590A90", VA = "0x186591690")]
	public static double? KPJIALFBGHK(FADMEACGLJJ PNJHGINLCID, int KHOKKOOKFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65900F0", Offset = "0x658F4F0", VA = "0x1865900F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65AB060", Offset = "0x65AA460", VA = "0x1865AB060")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x17501B0", Offset = "0x174F5B0", VA = "0x1817501B0")]
	public GELMIKFEDCF(byte[] PNJHGINLCID, int ELJAGIMMLLH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x65AAF40", Offset = "0x65AA340", VA = "0x1865AAF40")]
	public static GELMIKFEDCF DJCHIPEGFMB(GELMIKFEDCF EAODMOEAJOC)
	{
		return default(GELMIKFEDCF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65AAF50", Offset = "0x65AA350", VA = "0x1865AAF50")]
	public static GELMIKFEDCF EHMNDHCEEPM(GELMIKFEDCF EAODMOEAJOC, int HKIFHAEDDHO)
	{
		return default(GELMIKFEDCF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65AB020", Offset = "0x65AA420", VA = "0x1865AB020")]
	public static int HNODHDMLJNN(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFD0", Offset = "0x65AA3D0", VA = "0x1865AAFD0")]
	public static bool FCHDBNDMOOD(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65AB010", Offset = "0x65AA410", VA = "0x1865AB010")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, GELMIKFEDCF EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFA0", Offset = "0x65AA3A0", VA = "0x1865AAFA0")]
	public static bool FCHDBNDMOOD(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFE0", Offset = "0x65AA3E0", VA = "0x1865AAFE0")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFE0", Offset = "0x65AA3E0", VA = "0x1865AAFE0")]
	public static bool HAGCGOPJDDN(GELMIKFEDCF CGOLGFILFFA, byte EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65AB030", Offset = "0x65AA430", VA = "0x1865AB030")]
	public static bool JKIFMIBKGAF(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65AAF10", Offset = "0x65AA310", VA = "0x1865AAF10")]
	public static bool CCPAOAGPDNI(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65AB090", Offset = "0x65AA490", VA = "0x1865AB090")]
	public static bool PIEBNEDGCNB(GELMIKFEDCF CGOLGFILFFA, char EFDLLCLEIOO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x65AAEE0", Offset = "0x65AA2E0", VA = "0x1865AAEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A9810", Offset = "0x65A8C10", VA = "0x1865A9810")]
	private static byte[] FNHNFNKCDEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65AA770", Offset = "0x65A9B70", VA = "0x1865AA770")]
	private static byte[] HFGMHJBCOAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65AA970", Offset = "0x65A9D70", VA = "0x1865AA970")]
	public static double KONPEDFKFNP(byte[] PNJHGINLCID, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65AAA20", Offset = "0x65A9E20", VA = "0x1865AAA20")]
	public static float LLGLGCALBFI(byte[] PNJHGINLCID, int ELJAGIMMLLH, [Out] int PAPFIKHFHBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65AAAD0", Offset = "0x65A9ED0", VA = "0x1865AAAD0")]
	private static bool PNPOKGKHHLG(int OPHKAEHAFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65A9620", Offset = "0x65A8A20", VA = "0x1865A9620")]
	private static bool BLKPNKIILJP(GELMIKFEDCF KANFMCPNFBA, GELMIKFEDCF CBMPBFEPCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65AA8A0", Offset = "0x65A9CA0", VA = "0x1865AA8A0")]
	private static bool JHKACCHOOGL(GELMIKFEDCF KANFMCPNFBA, GELMIKFEDCF CBMPBFEPCHD, byte[] PHKOMDAOFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x65AA850", Offset = "0x65A9C50", VA = "0x1865AA850")]
	private static bool JAFNEFKNNEB(GELMIKFEDCF FBAAIOOIDIH, byte[] DFBAIJNHOKM, int ELJAGIMMLLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65AAC10", Offset = "0x65AA010", VA = "0x1865AAC10")]
	private static double PPLJGCHDEJN(bool BCAIDCNGNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65A98F0", Offset = "0x65A8CF0", VA = "0x1865A98F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x30F87D0", Offset = "0x30F7BD0", VA = "0x1830F87D0")]
	public KLKACGBBKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
	public KLKACGBBKPJ(EIDNECPPKDC NIOIDOPMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x39C7EF0", Offset = "0x39C72F0", VA = "0x1839C7EF0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x39C9CD0", Offset = "0x39C90D0", VA = "0x1839C9CD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x39C4700", Offset = "0x39C3B00", VA = "0x1839C4700", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ArraySegment<T> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x39C4A20", Offset = "0x39C3E20", VA = "0x1839C4A20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x30F87D0", Offset = "0x30F7BD0", VA = "0x1830F87D0")]
	public BCPGKEMLOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
	public BCPGKEMLOJI(EIDNECPPKDC NIOIDOPMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4549D30", Offset = "0x4549130", VA = "0x184549D30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, List<T> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x454CF50", Offset = "0x454C350", VA = "0x18454CF50", Slot = "5")]
	public List<T> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class NJDJNOJNAMD<TElement, TIntermediate, TEnumerator, TCollection> : HIPKPDINGJD<TCollection>, BOILAFIIEAN where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3D2CE00", Offset = "0x3D2C200", VA = "0x183D2CE00", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TCollection NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E310", Offset = "0x3D2D710", VA = "0x183D2E310", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x30E6590", Offset = "0x30E5990", VA = "0x1830E6590", Slot = "6")]
	protected override IEnumerator<TElement> MADGBDLPDLO(TCollection HFLNDIDMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x30CA480", Offset = "0x30C9880", VA = "0x1830CA480")]
	protected PGHECINOOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class JCLMOGPPCGH<TElement, TCollection> : PGHECINOOHO<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected sealed override TCollection GIIIEODFHFB(TCollection KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NCJJDAFDMDJ<TElement, TCollection> : JCLMOGPPCGH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C250", Offset = "0x3D1B650", VA = "0x183D1C250", Slot = "7")]
	protected override TCollection EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1C1F0", Offset = "0x3D1B5F0", VA = "0x183D1C1F0", Slot = "8")]
	protected override void BKKEPFPDOJH(TCollection NNCDPJOIJPE, int DIENMHDGFGP, TElement NMENOOMOOJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class BFHEEOAODEC<T> : NJDJNOJNAMD<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x355A010", Offset = "0x3559410", VA = "0x18355A010", Slot = "8")]
	protected override void BKKEPFPDOJH(LinkedList<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override LinkedList<T> GIIIEODFHFB(LinkedList<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override LinkedList<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3760740", Offset = "0x375FB40", VA = "0x183760740", Slot = "6")]
	protected override LinkedList<T>.Enumerator MADGBDLPDLO(LinkedList<T> HFLNDIDMJFD)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class JFKOLGKAJAM<T> : NJDJNOJNAMD<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x355A010", Offset = "0x3559410", VA = "0x18355A010", Slot = "8")]
	protected override void BKKEPFPDOJH(Queue<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override Queue<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x38F2360", Offset = "0x38F1760", VA = "0x1838F2360", Slot = "6")]
	protected override Queue<T>.Enumerator MADGBDLPDLO(Queue<T> HFLNDIDMJFD)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override Queue<T> GIIIEODFHFB(Queue<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class IOFGHFJGHLJ<T> : NJDJNOJNAMD<T, AJGGMHIIHMM<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x376BBD0", Offset = "0x376AFD0", VA = "0x18376BBD0", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x376BC00", Offset = "0x376B000", VA = "0x18376BC00", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x376BD20", Offset = "0x376B120", VA = "0x18376BD20", Slot = "6")]
	protected override Stack<T>.Enumerator MADGBDLPDLO(Stack<T> HFLNDIDMJFD)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x376BC40", Offset = "0x376B040", VA = "0x18376BC40", Slot = "9")]
	protected override Stack<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NLOMDMGGECN<T> : NJDJNOJNAMD<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x355A010", Offset = "0x3559410", VA = "0x18355A010", Slot = "8")]
	protected override void BKKEPFPDOJH(HashSet<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override HashSet<T> GIIIEODFHFB(HashSet<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override HashSet<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x38F2360", Offset = "0x38F1760", VA = "0x1838F2360", Slot = "6")]
	protected override HashSet<T>.Enumerator MADGBDLPDLO(HashSet<T> HFLNDIDMJFD)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CJFJAKLOCJB<T> : PGHECINOOHO<T, AJGGMHIIHMM<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x376BBD0", Offset = "0x376AFD0", VA = "0x18376BBD0", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4822300", Offset = "0x4821700", VA = "0x184822300", Slot = "9")]
	protected override ReadOnlyCollection<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x48222C0", Offset = "0x48216C0", VA = "0x1848222C0", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IOOHHEPNPKD<T> : PGHECINOOHO<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x355A010", Offset = "0x3559410", VA = "0x18355A010", Slot = "8")]
	protected override void BKKEPFPDOJH(List<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override List<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override IList<T> GIIIEODFHFB(List<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AGJKFPKDCGI<T> : PGHECINOOHO<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x355A010", Offset = "0x3559410", VA = "0x18355A010", Slot = "8")]
	protected override void BKKEPFPDOJH(List<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override List<T> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override ICollection<T> GIIIEODFHFB(List<T> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NDCPLIABNHI<T> : PGHECINOOHO<T, AJGGMHIIHMM<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x376BBD0", Offset = "0x376AFD0", VA = "0x18376BBD0", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x376BC00", Offset = "0x376B000", VA = "0x18376BC00", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3D1CFD0", Offset = "0x3D1C3D0", VA = "0x183D1CFD0", Slot = "9")]
	protected override IEnumerable<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x30D7E40", Offset = "0x30D7240", VA = "0x1830D7E40")]
	public NDCPLIABNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class LFOAMHLOFFE<TKey, TElement> : HIPKPDINGJD<IGrouping<TKey, TElement>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E220", Offset = "0x3A8D620", VA = "0x183A8E220", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IGrouping<TKey, TElement> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E500", Offset = "0x3A8D900", VA = "0x183A8E500", Slot = "5")]
	public IGrouping<TKey, TElement> JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HPHPPPPIIAH<TKey, TElement> : HIPKPDINGJD<ILookup<TKey, TElement>>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3621450", Offset = "0x3620850", VA = "0x183621450", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ILookup<TKey, TElement> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3621590", Offset = "0x3620990", VA = "0x183621590", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CD1030", Offset = "0x3CD0430", VA = "0x183CD1030", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3154BD0", Offset = "0x3153FD0", VA = "0x183154BD0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x30F9850", Offset = "0x30F8C50", VA = "0x1830F9850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30F9750", Offset = "0x30F8B50", VA = "0x1830F9750", Slot = "5")]
	public bool Contains(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x30F9790", Offset = "0x30F8B90", VA = "0x1830F9790", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x30F9790", Offset = "0x30F8B90", VA = "0x1830F9790", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class JNDOEANMJGK<T> : HIPKPDINGJD<T>, BOILAFIIEAN where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x39142E0", Offset = "0x39136E0", VA = "0x1839142E0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3914610", Offset = "0x3913A10", VA = "0x183914610", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A85A0", Offset = "0x65A79A0", VA = "0x1865A85A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IEnumerable NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x65A8850", Offset = "0x65A7C50", VA = "0x1865A8850", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A1F20", Offset = "0x65A1320", VA = "0x1865A1F20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ICollection NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65A22C0", Offset = "0x65A16C0", VA = "0x1865A22C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B09F0", Offset = "0x65AFDF0", VA = "0x1865B09F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IList NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65B0D20", Offset = "0x65B0120", VA = "0x1865B0D20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3557630", Offset = "0x3556A30", VA = "0x183557630", Slot = "8")]
	protected override void BKKEPFPDOJH(AJGGMHIIHMM<T> NNCDPJOIJPE, int DIENMHDGFGP, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3557690", Offset = "0x3556A90", VA = "0x183557690", Slot = "7")]
	protected override AJGGMHIIHMM<T> EBILOFOJHAE()
	{
		return default(AJGGMHIIHMM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3557710", Offset = "0x3556B10", VA = "0x183557710", Slot = "9")]
	protected override IReadOnlyList<T> GIIIEODFHFB(AJGGMHIIHMM<T> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30D77E0", Offset = "0x30D6BE0", VA = "0x1830D77E0")]
	public AEHPCCAKJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class BDLLFFCJFOK
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65A4890", Offset = "0x65A3C90", VA = "0x1865A4890")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A2990", Offset = "0x65A1D90", VA = "0x1865A2990", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, DateTime NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x65A3140", Offset = "0x65A2540", VA = "0x1865A3140", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD550", Offset = "0x65AC950", VA = "0x1865AD550", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, DateTimeOffset NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65ADBF0", Offset = "0x65ACFF0", VA = "0x1865ADBF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AFBA0", Offset = "0x65AEFA0", VA = "0x1865AFBA0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TimeSpan NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65AFF80", Offset = "0x65AF380", VA = "0x1865AFF80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x357DC00", Offset = "0x357D000", VA = "0x18357DC00", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, TDictionary NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x35811E0", Offset = "0x35805E0", VA = "0x1835811E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x30E6590", Offset = "0x30E5990", VA = "0x1830E6590", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> MADGBDLPDLO(TDictionary HFLNDIDMJFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class EGKGFBMNPII<TKey, TValue, TDictionary> : EDEBODLJNFC<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override TDictionary GIIIEODFHFB(TDictionary KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class IMFOMKKPIII<TKey, TValue> : GOCMKHPAHFH<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3760650", Offset = "0x375FA50", VA = "0x183760650", Slot = "8")]
	protected override void BKKEPFPDOJH(Dictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override Dictionary<TKey, TValue> GIIIEODFHFB(Dictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override Dictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3760880", Offset = "0x375FC80", VA = "0x183760880", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator MADGBDLPDLO(Dictionary<TKey, TValue> HFLNDIDMJFD)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30C9770", Offset = "0x30C8B70", VA = "0x1830C9770")]
	public IMFOMKKPIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class HEKKLDOPCKK<TKey, TValue, TDictionary> : EGKGFBMNPII<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x35E05A0", Offset = "0x35DF9A0", VA = "0x1835E05A0", Slot = "8")]
	protected override void BKKEPFPDOJH(TDictionary NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C830", Offset = "0x2F7BC30", VA = "0x182F7C830", Slot = "7")]
	protected override TDictionary EBILOFOJHAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class OHIFKLGNFHA<TKey, TValue> : EDEBODLJNFC<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3103950", Offset = "0x3102D50", VA = "0x183103950", Slot = "8")]
	protected override void BKKEPFPDOJH(Dictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override Dictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override IDictionary<TKey, TValue> GIIIEODFHFB(Dictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EKNOPEBCGCE<TKey, TValue> : EGKGFBMNPII<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3103950", Offset = "0x3102D50", VA = "0x183103950", Slot = "8")]
	protected override void BKKEPFPDOJH(SortedList<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override SortedList<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KDOJKGMFIJJ<TKey, TValue> : GOCMKHPAHFH<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3103950", Offset = "0x3102D50", VA = "0x183103950", Slot = "8")]
	protected override void BKKEPFPDOJH(SortedDictionary<TKey, TValue> NNCDPJOIJPE, int DIENMHDGFGP, TKey MIMFBLPNKOG, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x80F020", Offset = "0x80E420", VA = "0x18080F020", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GIIIEODFHFB(SortedDictionary<TKey, TValue> KAAKDKHPBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3103990", Offset = "0x3102D90", VA = "0x183103990", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> EBILOFOJHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3760810", Offset = "0x375FC10", VA = "0x183760810", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator MADGBDLPDLO(SortedDictionary<TKey, TValue> HFLNDIDMJFD)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class NFNGIPBPFKM<T> : HIPKPDINGJD<T>, BOILAFIIEAN where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3D254A0", Offset = "0x3D248A0", VA = "0x183D254A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3D25980", Offset = "0x3D24D80", VA = "0x183D25980", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A6A30", Offset = "0x65A5E30", VA = "0x1865A6A30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, IDictionary NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65A6F10", Offset = "0x65A6310", VA = "0x1865A6F10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A9570", Offset = "0x65A8970", VA = "0x1865A9570")]
	public GBJOPGJGCMM(params PMECKIJLNID[] KAODAHMOELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65A8B20", Offset = "0x65A7F20", VA = "0x1865A8B20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65A94E0", Offset = "0x65A88E0", VA = "0x1865A94E0", Slot = "5")]
	public object JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class MJDBGDGCGJC
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65B18E0", Offset = "0x65B0CE0", VA = "0x1865B18E0")]
	public static object ELCHEJDLJDM(Type LFLAEPCPMDG, [Out] bool DMDMJGPLNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65B0FF0", Offset = "0x65B03F0", VA = "0x1865B0FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3109D40", Offset = "0x3109140", VA = "0x183109D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x35E07F0", Offset = "0x35DFBF0", VA = "0x1835E07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F1C760", Offset = "0x3F1BB60", VA = "0x183F1C760")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CE6970", Offset = "0x3CE5D70", VA = "0x183CE6970")]
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
	[Cpp2IlInjected.Address(RVA = "0x399D1F0", Offset = "0x399C5F0", VA = "0x18399D1F0")]
	static KIAGPEMMDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x39B75E0", Offset = "0x39B69E0", VA = "0x1839B75E0")]
	public KIAGPEMMDBC(bool NDKBNDMPEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3986710", Offset = "0x3985B10", VA = "0x183986710", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x398FB30", Offset = "0x398EF30", VA = "0x18398FB30", Slot = "5")]
	public T JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x398E3F0", Offset = "0x398D7F0", VA = "0x18398E3F0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, T NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x398B660", Offset = "0x398AA60", VA = "0x18398B660", Slot = "7")]
	public T AOBCBCBIIDA(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class LFKMJHKPHPJ<T> : HIPKPDINGJD<T[,]>, BOILAFIIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DC80", Offset = "0x3A8D080", VA = "0x183A8DC80", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DEF0", Offset = "0x3A8D2F0", VA = "0x183A8DEF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x361C630", Offset = "0x361BA30", VA = "0x18361C630", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x361C950", Offset = "0x361BD50", VA = "0x18361C950", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DD6BB0", Offset = "0x4DD5FB0", VA = "0x184DD6BB0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T[,,,] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6F90", Offset = "0x4DD6390", VA = "0x184DD6F90", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x352B0A0", Offset = "0x352A4A0", VA = "0x18352B0A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x352B5D0", Offset = "0x352A9D0", VA = "0x18352B5D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x31069A0", Offset = "0x3105DA0", VA = "0x1831069A0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, T? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3108410", Offset = "0x3107810", VA = "0x183108410", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF530", Offset = "0x65AE930", VA = "0x1865AF530", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65AF6C0", Offset = "0x65AEAC0", VA = "0x1865AF6C0", Slot = "5")]
	public sbyte JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65AF650", Offset = "0x65AEA50", VA = "0x1865AF650", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, sbyte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65AF590", Offset = "0x65AE990", VA = "0x1865AF590", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A1810", Offset = "0x65A0C10", VA = "0x1865A1810", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65A1AB0", Offset = "0x65A0EB0", VA = "0x1865A1AB0", Slot = "5")]
	public sbyte? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65A19F0", Offset = "0x65A0DF0", VA = "0x1865A19F0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, sbyte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x65A18D0", Offset = "0x65A0CD0", VA = "0x1865A18D0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A4B30", Offset = "0x65A3F30", VA = "0x1865A4B30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, sbyte[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x65A4C60", Offset = "0x65A4060", VA = "0x1865A4C60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B23F0", Offset = "0x65B17F0", VA = "0x1865B23F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x65B2580", Offset = "0x65B1980", VA = "0x1865B2580", Slot = "5")]
	public short JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x65B2510", Offset = "0x65B1910", VA = "0x1865B2510", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, short NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x65B2450", Offset = "0x65B1850", VA = "0x1865B2450", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B4450", Offset = "0x65B3850", VA = "0x1865B4450", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x65B46F0", Offset = "0x65B3AF0", VA = "0x1865B46F0", Slot = "5")]
	public short? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x65B4630", Offset = "0x65B3A30", VA = "0x1865B4630", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, short? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x65B4510", Offset = "0x65B3910", VA = "0x1865B4510", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ABCB0", Offset = "0x65AB0B0", VA = "0x1865ABCB0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, short[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65ABDE0", Offset = "0x65AB1E0", VA = "0x1865ABDE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC3C0", Offset = "0x65AB7C0", VA = "0x1865AC3C0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65AC550", Offset = "0x65AB950", VA = "0x1865AC550", Slot = "5")]
	public int JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65AC4E0", Offset = "0x65AB8E0", VA = "0x1865AC4E0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, int NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65AC420", Offset = "0x65AB820", VA = "0x1865AC420", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ACF20", Offset = "0x65AC320", VA = "0x1865ACF20", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65AD1C0", Offset = "0x65AC5C0", VA = "0x1865AD1C0", Slot = "5")]
	public int? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65AD100", Offset = "0x65AC500", VA = "0x1865AD100", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, int? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x65ACFE0", Offset = "0x65AC3E0", VA = "0x1865ACFE0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A5270", Offset = "0x65A4670", VA = "0x1865A5270", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, int[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x65A53A0", Offset = "0x65A47A0", VA = "0x1865A53A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A55B0", Offset = "0x65A49B0", VA = "0x1865A55B0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x65A5740", Offset = "0x65A4B40", VA = "0x1865A5740", Slot = "5")]
	public long JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x65A56D0", Offset = "0x65A4AD0", VA = "0x1865A56D0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, long NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x65A5610", Offset = "0x65A4A10", VA = "0x1865A5610", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A2590", Offset = "0x65A1990", VA = "0x1865A2590", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x65A2850", Offset = "0x65A1C50", VA = "0x1865A2850", Slot = "5")]
	public long? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x65A2790", Offset = "0x65A1B90", VA = "0x1865A2790", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, long? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x65A2650", Offset = "0x65A1A50", VA = "0x1865A2650", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7EE0", Offset = "0x65A72E0", VA = "0x1865A7EE0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, long[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x65A8010", Offset = "0x65A7410", VA = "0x1865A8010", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF790", Offset = "0x65AEB90", VA = "0x1865AF790", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x65AF920", Offset = "0x65AED20", VA = "0x1865AF920", Slot = "5")]
	public byte JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65AF8B0", Offset = "0x65AECB0", VA = "0x1865AF8B0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, byte NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x65AF7F0", Offset = "0x65AEBF0", VA = "0x1865AF7F0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B4080", Offset = "0x65B3480", VA = "0x1865B4080", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x65B4320", Offset = "0x65B3720", VA = "0x1865B4320", Slot = "5")]
	public byte? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x65B4260", Offset = "0x65B3660", VA = "0x1865B4260", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, byte? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x65B4140", Offset = "0x65B3540", VA = "0x1865B4140", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AD2F0", Offset = "0x65AC6F0", VA = "0x1865AD2F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x65AD480", Offset = "0x65AC880", VA = "0x1865AD480", Slot = "5")]
	public ushort JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x65AD410", Offset = "0x65AC810", VA = "0x1865AD410", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ushort NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x65AD350", Offset = "0x65AC750", VA = "0x1865AD350", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A44C0", Offset = "0x65A38C0", VA = "0x1865A44C0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x65A4760", Offset = "0x65A3B60", VA = "0x1865A4760", Slot = "5")]
	public ushort? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x65A46A0", Offset = "0x65A3AA0", VA = "0x1865A46A0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ushort? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x65A4580", Offset = "0x65A3980", VA = "0x1865A4580", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A1BE0", Offset = "0x65A0FE0", VA = "0x1865A1BE0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ushort[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x65A1D10", Offset = "0x65A1110", VA = "0x1865A1D10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ACAE0", Offset = "0x65ABEE0", VA = "0x1865ACAE0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65ACC70", Offset = "0x65AC070", VA = "0x1865ACC70", Slot = "5")]
	public uint JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65ACC00", Offset = "0x65AC000", VA = "0x1865ACC00", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, uint NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65ACB40", Offset = "0x65ABF40", VA = "0x1865ACB40", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF160", Offset = "0x65AE560", VA = "0x1865AF160", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65AF400", Offset = "0x65AE800", VA = "0x1865AF400", Slot = "5")]
	public uint? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65AF340", Offset = "0x65AE740", VA = "0x1865AF340", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, uint? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65AF220", Offset = "0x65AE620", VA = "0x1865AF220", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A6000", Offset = "0x65A5400", VA = "0x1865A6000", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, uint[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65A6130", Offset = "0x65A5530", VA = "0x1865A6130", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A6340", Offset = "0x65A5740", VA = "0x1865A6340", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65A64D0", Offset = "0x65A58D0", VA = "0x1865A64D0", Slot = "5")]
	public ulong JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65A6460", Offset = "0x65A5860", VA = "0x1865A6460", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ulong NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65A63A0", Offset = "0x65A57A0", VA = "0x1865A63A0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AED60", Offset = "0x65AE160", VA = "0x1865AED60", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65AF020", Offset = "0x65AE420", VA = "0x1865AF020", Slot = "5")]
	public ulong? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65AEF60", Offset = "0x65AE360", VA = "0x1865AEF60", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, ulong? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x65AEE20", Offset = "0x65AE220", VA = "0x1865AEE20", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A66F0", Offset = "0x65A5AF0", VA = "0x1865A66F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ulong[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x65A6820", Offset = "0x65A5C20", VA = "0x1865A6820", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC880", Offset = "0x65ABC80", VA = "0x1865AC880", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x65ACA10", Offset = "0x65ABE10", VA = "0x1865ACA10", Slot = "5")]
	public float JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC9A0", Offset = "0x65ABDA0", VA = "0x1865AC9A0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, float NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC8E0", Offset = "0x65ABCE0", VA = "0x1865AC8E0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ABFF0", Offset = "0x65AB3F0", VA = "0x1865ABFF0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x65AC290", Offset = "0x65AB690", VA = "0x1865AC290", Slot = "5")]
	public float? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x65AC1D0", Offset = "0x65AB5D0", VA = "0x1865AC1D0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, float? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x65AC0B0", Offset = "0x65AB4B0", VA = "0x1865AC0B0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7420", Offset = "0x65A6820", VA = "0x1865A7420", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, float[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x65A7560", Offset = "0x65A6960", VA = "0x1865A7560", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A71C0", Offset = "0x65A65C0", VA = "0x1865A71C0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x65A7350", Offset = "0x65A6750", VA = "0x1865A7350", Slot = "5")]
	public double JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65A72E0", Offset = "0x65A66E0", VA = "0x1865A72E0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, double NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65A7220", Offset = "0x65A6620", VA = "0x1865A7220", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A4E70", Offset = "0x65A4270", VA = "0x1865A4E70", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65A5130", Offset = "0x65A4530", VA = "0x1865A5130", Slot = "5")]
	public double? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65A5070", Offset = "0x65A4470", VA = "0x1865A5070", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, double? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65A4F30", Offset = "0x65A4330", VA = "0x1865A4F30", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AB960", Offset = "0x65AAD60", VA = "0x1865AB960", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, double[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65ABAA0", Offset = "0x65AAEA0", VA = "0x1865ABAA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AC620", Offset = "0x65ABA20", VA = "0x1865AC620", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC7B0", Offset = "0x65ABBB0", VA = "0x1865AC7B0", Slot = "5")]
	public bool JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x65AC740", Offset = "0x65ABB40", VA = "0x1865AC740", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, bool NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x65AC680", Offset = "0x65ABA80", VA = "0x1865AC680", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A5C30", Offset = "0x65A5030", VA = "0x1865A5C30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65A5ED0", Offset = "0x65A52D0", VA = "0x1865A5ED0", Slot = "5")]
	public bool? JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65A5E10", Offset = "0x65A5210", VA = "0x1865A5E10", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, bool? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65A5CF0", Offset = "0x65A50F0", VA = "0x1865A5CF0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B3D30", Offset = "0x65B3130", VA = "0x1865B3D30", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, bool[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65B3E70", Offset = "0x65B3270", VA = "0x1865B3E70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B2650", Offset = "0x65B1A50", VA = "0x1865B2650", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, object NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65B32F0", Offset = "0x65B26F0", VA = "0x1865B32F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B3B40", Offset = "0x65B2F40", VA = "0x1865B3B40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, byte[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x65B3C00", Offset = "0x65B3000", VA = "0x1865B3C00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7770", Offset = "0x65A6B70", VA = "0x1865A7770", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, ArraySegment<byte> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65A78A0", Offset = "0x65A6CA0", VA = "0x1865A78A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65ACD40", Offset = "0x65AC140", VA = "0x1865ACD40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, string NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE50", Offset = "0x65AC250", VA = "0x1865ACE50", Slot = "5")]
	public string JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x65ACDF0", Offset = "0x65AC1F0", VA = "0x1865ACDF0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, string NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65ACDA0", Offset = "0x65AC1A0", VA = "0x1865ACDA0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A8220", Offset = "0x65A7620", VA = "0x1865A8220", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, string[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65A8350", Offset = "0x65A7750", VA = "0x1865A8350", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AF9F0", Offset = "0x65AEDF0", VA = "0x1865AF9F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65AFAB0", Offset = "0x65AEEB0", VA = "0x1865AFAB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7C40", Offset = "0x65A7040", VA = "0x1865A7C40", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char? NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65A7D40", Offset = "0x65A7140", VA = "0x1865A7D40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A40D0", Offset = "0x65A34D0", VA = "0x1865A40D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, char[] NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65A4280", Offset = "0x65A3680", VA = "0x1865A4280", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A5810", Offset = "0x65A4C10", VA = "0x1865A5810", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Guid NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x65A5B20", Offset = "0x65A4F20", VA = "0x1865A5B20", Slot = "5")]
	public Guid JKMDPBEAKHM(JPNKIGBGADK PCDAGGPDBLK, PMECKIJLNID LBPJJOGOOIA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x65A59E0", Offset = "0x65A4DE0", VA = "0x1865A59E0", Slot = "6")]
	public void FPBCCDGLAAF(NLPBBJFEPIL EKCFHKIKCOP, Guid NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x65A5940", Offset = "0x65A4D40", VA = "0x1865A5940", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x502E1E0", Offset = "0x502D5E0", VA = "0x18502E1E0")]
	public KDOJDEPMFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x16CC4F0", Offset = "0x16CB8F0", VA = "0x1816CC4F0")]
	public KDOJDEPMFLC(bool OLDOGDJFKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x65AE890", Offset = "0x65ADC90", VA = "0x1865AE890", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, decimal NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x65AEA40", Offset = "0x65ADE40", VA = "0x1865AEA40", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65B21D0", Offset = "0x65B15D0", VA = "0x1865B21D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Uri NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65B22B0", Offset = "0x65B16B0", VA = "0x1865B22B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A3ED0", Offset = "0x65A32D0", VA = "0x1865A3ED0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Version NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65A3F90", Offset = "0x65A3390", VA = "0x1865A3F90", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x34E9E90", Offset = "0x34E9290", VA = "0x1834E9E90", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, KeyValuePair<TKey, TValue> NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x34EA080", Offset = "0x34E9480", VA = "0x1834EA080", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A4950", Offset = "0x65A3D50", VA = "0x1865A4950", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, StringBuilder NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65A49F0", Offset = "0x65A3DF0", VA = "0x1865A49F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AB2D0", Offset = "0x65AA6D0", VA = "0x1865AB2D0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, BitArray NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65AB3F0", Offset = "0x65AA7F0", VA = "0x1865AB3F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AB940", Offset = "0x65AAD40", VA = "0x1865AB940")]
	public IAEHBHPIMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D36F80", Offset = "0x5D36380", VA = "0x185D36F80")]
	public IAEHBHPIMCG(bool OGOOEAIJKHF, bool EBMBDHNOLMH, bool PONHDANDFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65AB5F0", Offset = "0x65AA9F0", VA = "0x1865AB5F0", Slot = "4")]
	public void ALIOEPOJFBC(NLPBBJFEPIL EKCFHKIKCOP, Type NMENOOMOOJP, PMECKIJLNID LBPJJOGOOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65AB700", Offset = "0x65AAB00", VA = "0x1865AB700", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x65A7A30", Offset = "0x65A6E30", VA = "0x1865A7A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x65AB0C0", Offset = "0x65AA4C0", VA = "0x1865AB0C0")]
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
