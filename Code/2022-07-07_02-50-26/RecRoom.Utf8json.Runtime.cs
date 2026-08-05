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
public class PGKAFFKEEMJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58A480", Offset = "0x589680", VA = "0x18058A480")]
	public PGKAFFKEEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class DIEAIDFBCNG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58A480", Offset = "0x589680", VA = "0x18058A480")]
	public DIEAIDFBCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IAPCJMCAJGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58A480", Offset = "0x589680", VA = "0x18058A480")]
	public IAPCJMCAJGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JHMOIAJBJFA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58A480", Offset = "0x589680", VA = "0x18058A480")]
	public JHMOIAJBJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NKGDPDDEMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4811A10", Offset = "0x4810C10", VA = "0x184811A10")]
	public static bool IDFPODGGCIO(this TypeInfo ALJEFDPBPKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class GBFJBNIFIJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type JBFJMHLIALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] JOJMDEEKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7D0", Offset = "0x6CA9D0", VA = "0x1806CB7D0")]
	public GBFJBNIFIJA(Type CKKJBDGADNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class KCPMNONEJKA : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NKJAGJGCPIN<T>(ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T IHKEBIIAECE<T>(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB FEAPEFKDNBD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DOCJLNHANHK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CMLDAFIIOAH<T> : DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OFANMGKEMBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ACMGGDIBBBG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CMLDAFIIOAH<T> FGKKBFENJNC<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ACGCGGGJJIL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E280", Offset = "0x2D0D480", VA = "0x182D0E280")]
	public static global::CMLDAFIIOAH<T> MCAFENOIBLC<T>(this PGDAFACPPLB FEAPEFKDNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37E1F10", Offset = "0x37E1110", VA = "0x1837E1F10")]
	public static object DLMDOJAOHFI(this PGDAFACPPLB FEAPEFKDNBD, Type ALJEFDPBPKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DDHAOLJOCNO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37EB0D0", Offset = "0x37EA2D0", VA = "0x1837EB0D0")]
	public DDHAOLJOCNO(string NJKILBPPEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NMBHIAJGIPN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CGLKHLMBJAD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] OHNDJLPLBEI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] BBFMIFHCIFA;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x480A930", Offset = "0x4809B30", VA = "0x18480A930")]
		public static byte[] OKCCJFKENMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x480A8A0", Offset = "0x4809AA0", VA = "0x18480A8A0")]
		public static char[] AKIEFAACBHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NHOIHFMPMDM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] FCKECIOHFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] NGIBJOEMFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int NAPMMJBBFDN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool IHJDNEHIABP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4811B00", Offset = "0x4810D00", VA = "0x184811B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4814660", Offset = "0x4813860", VA = "0x184814660")]
	public NMBHIAJGIPN(byte[] NGIBJOEMFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4814480", Offset = "0x4813680", VA = "0x184814480")]
	public NMBHIAJGIPN(byte[] NGIBJOEMFPL, int NAPMMJBBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48132F0", Offset = "0x48124F0", VA = "0x1848132F0")]
	private NBMCCMEFFNN LNELEPELOPL(string GAIHPFFBNBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4812050", Offset = "0x4811250", VA = "0x184812050")]
	private NBMCCMEFFNN HCOMKMJABOB(string NJKILBPPEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37F20A0", Offset = "0x37F12A0", VA = "0x1837F20A0")]
	public void HLJPOOEBKPC(int NAPMMJBBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7600E0", Offset = "0x75F2E0", VA = "0x1807600E0")]
	public byte[] DMBANCFMCEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8491B0", Offset = "0x8483B0", VA = "0x1808491B0")]
	public int KLLOKEOBMDA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4812A30", Offset = "0x4811C30", VA = "0x184812A30")]
	public ECAGCNCBCBB JEMNFGLAOKG()
	{
		return default(ECAGCNCBCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4813B60", Offset = "0x4812D60", VA = "0x184813B60")]
	public void NJEOBPIBNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4813F40", Offset = "0x4813140", VA = "0x184813F40")]
	public bool OLNLCLKHLGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48130E0", Offset = "0x48122E0", VA = "0x1848130E0")]
	public bool KMNNMGHEBGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4813AC0", Offset = "0x4812CC0", VA = "0x184813AC0")]
	public void MHIJLDFDEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4813830", Offset = "0x4812A30", VA = "0x184813830")]
	public bool MCDAJNFKENK(ref int NAOLJMJHENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4811B20", Offset = "0x4810D20", VA = "0x184811B20")]
	public bool BHDEPMFJPCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4813790", Offset = "0x4812990", VA = "0x184813790")]
	public void MAPHIGFLKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4811EA0", Offset = "0x48110A0", VA = "0x184811EA0")]
	public bool GLJFDFOJIAN(ref int NAOLJMJHENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4811D40", Offset = "0x4810F40", VA = "0x184811D40")]
	public bool FHDLDOEPEHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4814230", Offset = "0x4813430", VA = "0x184814230")]
	public void ONFKIINPLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4812E10", Offset = "0x4812010", VA = "0x184812E10")]
	public bool KEDNKIIADJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48131F0", Offset = "0x48123F0", VA = "0x1848131F0")]
	public void LDKNCOADPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4812140", Offset = "0x4811340", VA = "0x184812140")]
	private void HIIJAKLMBNP(out byte[] GCDLKDMLNEP, out int FNCMJCDEHMF, out int IJKEOFMFBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4811DF0", Offset = "0x4810FF0", VA = "0x184811DF0")]
	private static int GGMAMNJNJBG(char KICBFMPMNBH, char DLFOEJDCAKP, char DIHFAACINDK, char EPKEDIDPMKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4812BC0", Offset = "0x4811DC0", VA = "0x184812BC0")]
	private static int JNNELCJFGHO(char CNMHAFPCMJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4811B90", Offset = "0x4810D90", VA = "0x184811B90")]
	public ArraySegment<byte> BPKPDEALPEL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4813150", Offset = "0x4812350", VA = "0x184813150")]
	public string LAACINIKPJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4812020", Offset = "0x4811220", VA = "0x184812020")]
	public string HBLFMJDDNCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4813910", Offset = "0x4812B10", VA = "0x184813910")]
	public ArraySegment<byte> MHDOFNEOJCJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4811DB0", Offset = "0x4810FB0", VA = "0x184811DB0")]
	public ArraySegment<byte> FPFAGAJAPBC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4812E80", Offset = "0x4812080", VA = "0x184812E80")]
	public bool KGNPLNOMOBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4813E80", Offset = "0x4813080", VA = "0x184813E80")]
	private static bool OKJKABHGNMK(byte DIHFAACINDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4814060", Offset = "0x4813260", VA = "0x184814060")]
	private void ONADPPDIPAJ(ECAGCNCBCBB OLHNGKKAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4812130", Offset = "0x4811330", VA = "0x184812130")]
	public void HGINMPAGEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48142D0", Offset = "0x48134D0", VA = "0x1848142D0")]
	private void PCFLEFOJMLE(int AMKHODMDOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48138C0", Offset = "0x4812AC0", VA = "0x1848138C0")]
	public sbyte MFPHIANJBGJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4811CE0", Offset = "0x4810EE0", VA = "0x184811CE0")]
	public short EKPKABDJAKL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4811C80", Offset = "0x4810E80", VA = "0x184811C80")]
	public int CHGBDLPMLDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x48128D0", Offset = "0x4811AD0", VA = "0x1848128D0")]
	public long HKLJLCMCPJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4813290", Offset = "0x4812490", VA = "0x184813290")]
	public byte LIKDBKAGOAO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4813D60", Offset = "0x4812F60", VA = "0x184813D60")]
	public ushort OAJJGOMJBOH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4812950", Offset = "0x4811B50", VA = "0x184812950")]
	public uint HODPEMIMEFK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48129B0", Offset = "0x4811BB0", VA = "0x1848129B0")]
	public ulong IJHMPNGIEOF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4813DC0", Offset = "0x4812FC0", VA = "0x184813DC0")]
	public float OHGFMMIFNME()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4813CA0", Offset = "0x4812EA0", VA = "0x184813CA0")]
	public double NNDJJGKFCKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4811F30", Offset = "0x4811130", VA = "0x184811F30")]
	public ArraySegment<byte> GPCMHKAEMIL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4812C90", Offset = "0x4811E90", VA = "0x184812C90")]
	private static int KBLLAMDENFA(byte[] NGIBJOEMFPL, int NAPMMJBBFDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NBMCCMEFFNN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HIHCCDLOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FAMKJOJDKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FBDEKLDFPND
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1473260", Offset = "0x1472460", VA = "0x181473260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EGBKKEPFJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x624E10", Offset = "0x624010", VA = "0x180624E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4811040", Offset = "0x4810240", VA = "0x184811040")]
	public NBMCCMEFFNN(string NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x48110B0", Offset = "0x48102B0", VA = "0x1848110B0")]
	public NBMCCMEFFNN(string NJKILBPPEMD, byte[] OHOEJAPJFNK, int NAPMMJBBFDN, int FAMKJOJDKMJ, string KPLMOCMPEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class INDAFLBMAFC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EEBPHECFCAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void OIJHNGFBEIG(ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object PFKMLPACGIA(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB FEAPEFKDNBD);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class AMFIDEOOEDA
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class LAGFDAHLGBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
				public LAGFDAHLGBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x352CB10", Offset = "0x352BD10", VA = "0x18352CB10")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x352CB50", Offset = "0x352BD50", VA = "0x18352CB50")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, PGDAFACPPLB, byte[]> LLLGDMNAPJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, PGDAFACPPLB> MHAJNBIEJJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly OIJHNGFBEIG MJAOJHKOPPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, PGDAFACPPLB, ArraySegment<byte>> CGCIDBOIKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, PGDAFACPPLB, string> KFPBMFFGPMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, PGDAFACPPLB, object> GPOEPKANAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, PGDAFACPPLB, object> GJGPHAMBNPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, PGDAFACPPLB, object> CBLLOFNNHLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly PFKMLPACGIA MCDAIABBNFO;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x35181F0", Offset = "0x35173F0", VA = "0x1835181F0")]
			public AMFIDEOOEDA(Type ALJEFDPBPKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2434400", Offset = "0x2433600", VA = "0x182434400")]
			private static T AHBMGAHCNGB<T>(DynamicMethod GPCBAOMJHJH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3518000", Offset = "0x3517200", VA = "0x183518000")]
			private static MethodInfo DCKAGBKGOFJ(Type ALJEFDPBPKG, string KFCJDHCECCC, Type[] DEEKPPLHNPF)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, AMFIDEOOEDA> NJDLDPFMPGB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::MDKPJEMIGJL<AMFIDEOOEDA> PKJMABNCCJO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x351B2D0", Offset = "0x351A4D0", VA = "0x18351B2D0")]
		static EEBPHECFCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x351B250", Offset = "0x351A450", VA = "0x18351B250")]
		private static AMFIDEOOEDA FKMLAAHCPLI(Type ALJEFDPBPKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x351B0E0", Offset = "0x351A2E0", VA = "0x18351B0E0")]
		public static void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x351AFD0", Offset = "0x351A1D0", VA = "0x18351AFD0")]
		public static void ABGFPJIPAOE(Type ALJEFDPBPKG, ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BHAGIANJINJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] OHNDJLPLBEI;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3519E30", Offset = "0x3519030", VA = "0x183519E30")]
		public static byte[] OKCCJFKENMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PGDAFACPPLB GLLECCHFGNA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] FFDFHKHNKMD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] BPNDCNIPHBG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static PGDAFACPPLB JNFNOFGAAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3528EE0", Offset = "0x35280E0", VA = "0x183528EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3528FF0", Offset = "0x35281F0", VA = "0x183528FF0")]
	public static void IOPEBILGLCL(PGDAFACPPLB FEAPEFKDNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x374F0D0", Offset = "0x374E2D0", VA = "0x18374F0D0")]
	public static string BJHFLEMGONH<T>(T LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x374EF70", Offset = "0x374E170", VA = "0x18374EF70")]
	public static string BJHFLEMGONH<T>(T LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2440C10", Offset = "0x243FE10", VA = "0x182440C10")]
	public static T BAADAAGNJID<T>(string HKKOPJIJNMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2440DE0", Offset = "0x243FFE0", VA = "0x182440DE0")]
	public static T BAADAAGNJID<T>(string HKKOPJIJNMI, PGDAFACPPLB FEAPEFKDNBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2440B90", Offset = "0x243FD90", VA = "0x182440B90")]
	public static T BAADAAGNJID<T>(byte[] NGIBJOEMFPL, PGDAFACPPLB FEAPEFKDNBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2440C90", Offset = "0x243FE90", VA = "0x182440C90")]
	public static T BAADAAGNJID<T>(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, PGDAFACPPLB FEAPEFKDNBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ECAGCNCBCBB : byte
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
public struct FLKJBKMANKH
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PLDKDMGHPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] OHNDJLPLBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int NAPMMJBBFDN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int DCMLIAIJFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8491B0", Offset = "0x8483B0", VA = "0x1808491B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37F20A0", Offset = "0x37F12A0", VA = "0x1837F20A0")]
	public void HLJPOOEBKPC(int NAPMMJBBFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37F2E40", Offset = "0x37F2040", VA = "0x1837F2E40")]
	public static byte[] ONIOIIKHGMC(string AOBGEIHOBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37F1DF0", Offset = "0x37F0FF0", VA = "0x1837F1DF0")]
	public static byte[] CLEJMHMFNJG(string AOBGEIHOBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37F2810", Offset = "0x37F1A10", VA = "0x1837F2810")]
	public static byte[] MJDPHHDFIAM(string AOBGEIHOBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x37F24A0", Offset = "0x37F16A0", VA = "0x1837F24A0")]
	public static byte[] JNODNADOMLA(string AOBGEIHOBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD06A90", Offset = "0xD05C90", VA = "0x180D06A90")]
	public FLKJBKMANKH(byte[] IPOKELNALON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x37F2980", Offset = "0x37F1B80", VA = "0x1837F2980")]
	public ArraySegment<byte> OKCCJFKENMF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x37F1B80", Offset = "0x37F0D80", VA = "0x1837F1B80")]
	public byte[] AONIBGMNLEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x37F2EC0", Offset = "0x37F20C0", VA = "0x1837F2EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x37F2800", Offset = "0x37F1A00", VA = "0x1837F2800")]
	public void MCOJLDDDGFI(int FPMDJEBHHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x37F20B0", Offset = "0x37F12B0", VA = "0x1837F20B0")]
	public void HMEJFPAIKKO(byte[] ELPMCMCFOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37F2E00", Offset = "0x37F2000", VA = "0x1837F2E00")]
	public void OKMEECGMGJO(byte ELPMCMCFOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x37F1D50", Offset = "0x37F0F50", VA = "0x1837F1D50")]
	public void BPMBHJMOIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x37F27B0", Offset = "0x37F19B0", VA = "0x1837F27B0")]
	public void LKEAAIOOIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37F28E0", Offset = "0x37F1AE0", VA = "0x1837F28E0")]
	public void MJJIBLCBPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37F2930", Offset = "0x37F1B30", VA = "0x1837F2930")]
	public void NILMHDKDFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37F1CD0", Offset = "0x37F0ED0", VA = "0x1837F1CD0")]
	public void BDBLAIABLNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37F1F20", Offset = "0x37F1120", VA = "0x1837F1F20")]
	public void EHDBBKMGLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37F2110", Offset = "0x37F1310", VA = "0x1837F2110")]
	public void HPJAFJBBNOG(string AOBGEIHOBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37F1DA0", Offset = "0x37F0FA0", VA = "0x1837F1DA0")]
	public void CKCJKFCAAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37F1FA0", Offset = "0x37F11A0", VA = "0x1837F1FA0")]
	public void GFANGCMHIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37F22B0", Offset = "0x37F14B0", VA = "0x1837F22B0")]
	public void IOPGABHGOGG(bool LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37F2660", Offset = "0x37F1860", VA = "0x1837F2660")]
	public void KJCDKDBFGLC(float LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37F2170", Offset = "0x37F1370", VA = "0x1837F2170")]
	public void IGJLJHMDHPE(double LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37F1EC0", Offset = "0x37F10C0", VA = "0x1837F1EC0")]
	public void DINANNLNFNI(byte LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37F1EF0", Offset = "0x37F10F0", VA = "0x1837F1EF0")]
	public void DPDMNPBEJFK(ushort LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37F2630", Offset = "0x37F1830", VA = "0x1837F2630")]
	public void KECKLCIMOJD(uint LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37F1B50", Offset = "0x37F0D50", VA = "0x1837F1B50")]
	public void AMDFNEJGEKL(ulong LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37F1F70", Offset = "0x37F1170", VA = "0x1837F1F70")]
	public void FDPFOBGEGHI(sbyte LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37F1D20", Offset = "0x37F0F20", VA = "0x1837F1D20")]
	public void BFOAFGKOLJA(short LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x37F2070", Offset = "0x37F1270", VA = "0x1837F2070")]
	public void GIKMIGMAJEF(int LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37F2600", Offset = "0x37F1800", VA = "0x1837F2600")]
	public void KDAFHDELAOG(long LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37F2A30", Offset = "0x37F1C30", VA = "0x1837F2A30")]
	public void OKGAGJPALHO(string LDPMPDNIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class COHMGLEONLO : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class KDNKNHIPFEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB520", Offset = "0x2BAA720", VA = "0x182BAB520")]
		static KDNKNHIPFEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private COHMGLEONLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class LFIHEAPKEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> DGABJFPOCDG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x480D700", Offset = "0x480C900", VA = "0x18480D700")]
	static LFIHEAPKEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x480D1A0", Offset = "0x480C3A0", VA = "0x18480D1A0")]
	internal static object FGKKBFENJNC(Type INOBBCFLJOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OJMOJODIAIO : global::CMLDAFIIOAH<Vector2>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48174E0", Offset = "0x48166E0", VA = "0x1848174E0")]
	public OJMOJODIAIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4817190", Offset = "0x4816390", VA = "0x184817190", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Vector2 LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4817240", Offset = "0x4816440", VA = "0x184817240", Slot = "5")]
	public Vector2 BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BCDFBLIDGAJ : global::CMLDAFIIOAH<Vector3>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x37E3990", Offset = "0x37E2B90", VA = "0x1837E3990")]
	public BCDFBLIDGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37E3590", Offset = "0x37E2790", VA = "0x1837E3590", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Vector3 LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x37E37A0", Offset = "0x37E29A0", VA = "0x1837E37A0", Slot = "5")]
	public Vector3 BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KKINAMPHIJE : global::CMLDAFIIOAH<Vector4>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x480CA30", Offset = "0x480BC30", VA = "0x18480CA30")]
	public KKINAMPHIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3527180", Offset = "0x3526380", VA = "0x183527180", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Vector4 LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x480C6F0", Offset = "0x480B8F0", VA = "0x18480C6F0", Slot = "5")]
	public Vector4 BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IEMFJFGDCKN : global::CMLDAFIIOAH<Quaternion>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3527560", Offset = "0x3526760", VA = "0x183527560")]
	public IEMFJFGDCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3527180", Offset = "0x3526380", VA = "0x183527180", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Quaternion LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35272D0", Offset = "0x35264D0", VA = "0x1835272D0", Slot = "5")]
	public Quaternion BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class OAAJGMDPEMD : global::CMLDAFIIOAH<Color>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4816630", Offset = "0x4815830", VA = "0x184816630")]
	public OAAJGMDPEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3527180", Offset = "0x3526380", VA = "0x183527180", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Color LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x48162F0", Offset = "0x48154F0", VA = "0x1848162F0", Slot = "5")]
	public Color BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class AFOOKKEMHJJ : global::CMLDAFIIOAH<Bounds>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37E2910", Offset = "0x37E1B10", VA = "0x1837E2910")]
	public AFOOKKEMHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37E2370", Offset = "0x37E1570", VA = "0x1837E2370", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Bounds LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37E2670", Offset = "0x37E1870", VA = "0x1837E2670", Slot = "5")]
	public Bounds BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DPHCPLDHHBA : global::CMLDAFIIOAH<Rect>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GPMEJDGBIIL LHGHBKCHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HINPLLPNEHP;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37EBF70", Offset = "0x37EB170", VA = "0x1837EBF70")]
	public DPHCPLDHHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37EBA80", Offset = "0x37EAC80", VA = "0x1837EBA80", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Rect LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x37EBD10", Offset = "0x37EAF10", VA = "0x1837EBD10", Slot = "5")]
	public Rect BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NLECLLHCNCJ : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class OLKEPLAPHMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x411B1D0", Offset = "0x411A3D0", VA = "0x18411B1D0")]
		static OLKEPLAPHMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private NLECLLHCNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CPBMCLCKPHN : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class CEMGDGMMELF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4085830", Offset = "0x4084A30", VA = "0x184085830")]
		static CEMGDGMMELF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class GGOHEAKOPMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> IECGJCJNDHL;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x37F6110", Offset = "0x37F5310", VA = "0x1837F6110")]
		internal static object FGKKBFENJNC(Type INOBBCFLJOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private CPBMCLCKPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FPILPMELKAG : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LFFHOEHBCBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0440", Offset = "0x3C9F640", VA = "0x183CA0440")]
		static LFFHOEHBCBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FPILPMELKAG LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool ILENFCKNDBE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static DOCJLNHANHK[] POGGMBNKJMN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static PGDAFACPPLB[] AICIMPCCGLK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private FPILPMELKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x37F4890", Offset = "0x37F3A90", VA = "0x1837F4890")]
	public static void DJPAOFCCGHI(params PGDAFACPPLB[] AICIMPCCGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37F47D0", Offset = "0x37F39D0", VA = "0x1837F47D0")]
	public static void DJPAOFCCGHI(params DOCJLNHANHK[] POGGMBNKJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x37F4950", Offset = "0x37F3B50", VA = "0x1837F4950")]
	public static void NHIAMBPNAIG(DOCJLNHANHK[] POGGMBNKJMN, PGDAFACPPLB[] AICIMPCCGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NLDFJJHBCIM : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class PNMIHBDIFNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4124610", Offset = "0x4123810", VA = "0x184124610")]
		static PNMIHBDIFNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private NLDFJJHBCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DBIBADCDKLA
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly PGDAFACPPLB GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly PGDAFACPPLB HJCGKPMPKAL;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PGDAFACPPLB INHFDPBIBOK;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly PGDAFACPPLB CFLAFKDBEBA;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly PGDAFACPPLB KOCKGHIAHNN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly PGDAFACPPLB NOMGOBCJJHC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly PGDAFACPPLB KCNHMLHLHNB;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly PGDAFACPPLB NGLHENNPGMI;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly PGDAFACPPLB MFKHMFCLAJC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly PGDAFACPPLB BHBNHNAJAKC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly PGDAFACPPLB APEPMMCBLFC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly PGDAFACPPLB JPCEOBPABAA;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CEDGGNKJHKA
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly PGDAFACPPLB GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PGDAFACPPLB EKMJKDGMMAO;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KJBPKFBGCJD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly PGDAFACPPLB GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly PGDAFACPPLB HJCGKPMPKAL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly PGDAFACPPLB INHFDPBIBOK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly PGDAFACPPLB CFLAFKDBEBA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly PGDAFACPPLB KOCKGHIAHNN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly PGDAFACPPLB NOMGOBCJJHC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PGDAFACPPLB KCNHMLHLHNB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly PGDAFACPPLB NGLHENNPGMI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly PGDAFACPPLB MFKHMFCLAJC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly PGDAFACPPLB BHBNHNAJAKC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly PGDAFACPPLB APEPMMCBLFC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PGDAFACPPLB JPCEOBPABAA;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class DABMMMMAODE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> IECGJCJNDHL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x37E7160", Offset = "0x37E6360", VA = "0x1837E7160")]
	internal static object FGKKBFENJNC(Type INOBBCFLJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x37E87E0", Offset = "0x37E79E0", VA = "0x1837E87E0")]
	private static object GKGADGACCEN(Type FEJLHCKMDDA, Type[] DECGOPEGMNP, params object[] DEEKPPLHNPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class AJKLEOJJGII : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class ONFFFHFBAMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C85870", Offset = "0x2C84A70", VA = "0x182C85870")]
		static ONFFFHFBAMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37E2C60", Offset = "0x37E1E60", VA = "0x1837E2C60")]
	static AJKLEOJJGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private AJKLEOJJGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class ILJFKENIAOA : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class CHMOBEBNPHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2692CC0", Offset = "0x2691EC0", VA = "0x182692CC0")]
		static CHMOBEBNPHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3527A20", Offset = "0x3526C20", VA = "0x183527A20")]
	static ILJFKENIAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private ILJFKENIAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PFFOOKGPKLP : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FKJFOGLCNIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3815E20", Offset = "0x3815020", VA = "0x183815E20")]
		static FKJFOGLCNIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4817D00", Offset = "0x4816F00", VA = "0x184817D00")]
	static PFFOOKGPKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private PFFOOKGPKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class MMNLLHDBBAE : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class DNOHKPPPAEM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x37921D0", Offset = "0x37913D0", VA = "0x1837921D0")]
		static DNOHKPPPAEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x48105D0", Offset = "0x480F7D0", VA = "0x1848105D0")]
	static MMNLLHDBBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private MMNLLHDBBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class PFGJCEGHNMG : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class GHEIJBAMGBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x381B410", Offset = "0x381A610", VA = "0x18381B410")]
		static GHEIJBAMGBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4817DF0", Offset = "0x4816FF0", VA = "0x184817DF0")]
	static PFGJCEGHNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private PFGJCEGHNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class JAIBFKEHKGO : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class MMBFCELJMLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F630", Offset = "0x3A2E830", VA = "0x183A2F630")]
		static MMBFCELJMLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly MAKJPJHIFIG IBJALEHBMDE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3529180", Offset = "0x3528380", VA = "0x183529180")]
	static JAIBFKEHKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private JAIBFKEHKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class JGMKDMKEKKO : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class PJMHEMHPOIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A329B0", Offset = "0x3A31BB0", VA = "0x183A329B0")]
		static PJMHEMHPOIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JGMKDMKEKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class OLLNGCFELEA : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class FDNFMPEJLOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3672FD0", Offset = "0x36721D0", VA = "0x183672FD0")]
		static FDNFMPEJLOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OLLNGCFELEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class NFLOAGJHKLK : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class HLBEPICPEHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x43CD110", Offset = "0x43CC310", VA = "0x1843CD110")]
		static HLBEPICPEHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public NFLOAGJHKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class BCFAPJMGLPK : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class GKNBJLOKMLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x36B2620", Offset = "0x36B1820", VA = "0x1836B2620")]
		static GKNBJLOKMLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BCFAPJMGLPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class FJJDCJBFBJG : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KIPGDPAJNHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x34FEF20", Offset = "0x34FE120", VA = "0x1834FEF20")]
		static KIPGDPAJNHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public FJJDCJBFBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IBJCAKHPCEC : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class DICKNNCMIAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x39EC020", Offset = "0x39EB220", VA = "0x1839EC020")]
		static DICKNNCMIAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> NNGHHBMCFCI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DPPPIKDNPFC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IBJCAKHPCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class IAGDMDLKNBI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HEEDAIIFHAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GDIGMJEPGFJ EHLFLBOEPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder PBMBFMNLLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder CJEADOIFJPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class MAMBCGKKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class BNAOPHDBHMN
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo MJDPHHDFIAM;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo CLEJMHMFNJG;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo JNODNADOMLA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ONIOIIKHGMC;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo GFANGCMHIHK;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo HMEJFPAIKKO;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo MJJIBLCBPIF;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo NILMHDKDFJB;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo BDBLAIABLNL;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3519F50", Offset = "0x3519150", VA = "0x183519F50")]
			static BNAOPHDBHMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class JEENMABCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo OLNLCLKHLGF;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo MAPHIGFLKBN;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo GLJFDFOJIAN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo BPCJKMCKFKO;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo HGINMPAGEIB;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo DMBANCFMCEO;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo KLLOKEOBMDA;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x352AAA0", Offset = "0x3529CA0", VA = "0x18352AAA0")]
			static JEENMABCCDD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class EEBOOHKDAGA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo JBFJMHLIALJ;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo JOJMDEEKIKL;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo OFGPACFELBK;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo MCAFENOIBLC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo AHPNAEJDEFG;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo PPNBOFBOJHH;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GJIBJKANBNK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo LLJOMOPGOCI;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo KNPIPGNHIKP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo LMHCABLMNLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo DIJOBLNJGMP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo PMDHEDHAEIJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo CKPGDMCNABD;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo ONIBPBFAIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x352CDB0", Offset = "0x352BFB0", VA = "0x18352CDB0")]
		public static MethodInfo ABGFPJIPAOE(Type ALJEFDPBPKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x352D160", Offset = "0x352C360", VA = "0x18352D160")]
		public static MethodInfo BAADAAGNJID(Type ALJEFDPBPKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x352D040", Offset = "0x352C240", VA = "0x18352D040")]
		public static MethodInfo AFAGLLKEMFD(Type ALJEFDPBPKG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GGLMEPDPODI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<GDIGMJEPGFJ, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public GGLMEPDPODI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class NCFDPABLHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public GGLMEPDPODI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public NCFDPABLHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x352EE40", Offset = "0x352E040", VA = "0x18352EE40")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x352EE80", Offset = "0x352E080", VA = "0x18352EE80")]
		internal bool <BuildType>b__2(int index, GDIGMJEPGFJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BIPPBGJLAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GGLMEPDPODI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public BIPPBGJLAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3519EB0", Offset = "0x35190B0", VA = "0x183519EB0")]
		internal bool <BuildType>b__3(int index, GDIGMJEPGFJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LBLBGGHEPLN
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
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public LBLBGGHEPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x352CD50", Offset = "0x352BF50", VA = "0x18352CD50")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KGIBCKIAJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public KGIBCKIAJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x352CAB0", Offset = "0x352BCB0", VA = "0x18352CAB0")]
		internal bool <BuildAnonymousFormatter>b__2(GDIGMJEPGFJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KDGFHFHGFDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LBLBGGHEPLN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public KDGFHFHGFDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x352C900", Offset = "0x352BB00", VA = "0x18352C900")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x352C910", Offset = "0x352BB10", VA = "0x18352C910")]
		internal bool <BuildAnonymousFormatter>b__6(int index, GDIGMJEPGFJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ILDAEOKPIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LBLBGGHEPLN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ILDAEOKPIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3527880", Offset = "0x3526A80", VA = "0x183527880")]
		internal bool <BuildAnonymousFormatter>b__7(int index, GDIGMJEPGFJ member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class MGBAIEIHKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public MGBAIEIHKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x592CC0", Offset = "0x591EC0", VA = "0x180592CC0")]
		internal Label <BuildSerialize>b__1(GDIGMJEPGFJ _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class HLHPHIABJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HEEDAIIFHAC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, GDIGMJEPGFJ, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NCMEBGHPNFE argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NCMEBGHPNFE argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public HLHPHIABJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x351CCA0", Offset = "0x351BEA0", VA = "0x18351CCA0")]
		internal HEEDAIIFHAC <BuildDeserialize>b__0(GDIGMJEPGFJ item)
		{
			return default(HEEDAIIFHAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PMKJCLNFEFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public HLHPHIABJIG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public PMKJCLNFEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x352F7D0", Offset = "0x352E9D0", VA = "0x18352F7D0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x352FA80", Offset = "0x352EC80", VA = "0x18352FA80")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class GJIKKGENBLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GDIGMJEPGFJ item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public GJIKKGENBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1482220", Offset = "0x1481420", VA = "0x181482220")]
		internal bool <EmitNewObject>b__0(HEEDAIIFHAC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MMBFKEDMMIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GDIGMJEPGFJ item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public MMBFKEDMMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1482220", Offset = "0x1481420", VA = "0x181482220")]
		internal bool <EmitNewObject>b__2(HEEDAIIFHAC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex PDINEADLMOE;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int NMGBOEAMIDP;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> ELNFJEHEEFJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> PCCABCAFBKA;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x374A410", Offset = "0x3749610", VA = "0x18374A410")]
	public static object OOHAABODFLN<T>(MAKJPJHIFIG IBJALEHBMDE, PGDAFACPPLB DAHOFPOOFKK, Func<string, string> NNGHHBMCFCI, bool DPPPIKDNPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x282AA00", Offset = "0x2829C00", VA = "0x18282AA00")]
	public static object EGCBKCADNHM<T>(PGDAFACPPLB DAHOFPOOFKK, Func<string, string> NNGHHBMCFCI, bool DPPPIKDNPFC, bool PCJOBBPFIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x351F410", Offset = "0x351E610", VA = "0x18351F410")]
	private static TypeInfo CBKMKCNALKM(MAKJPJHIFIG IBJALEHBMDE, Type ALJEFDPBPKG, Func<string, string> NNGHHBMCFCI, bool DPPPIKDNPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3520A20", Offset = "0x351FC20", VA = "0x183520A20")]
	public static object KAECOIACPAE(Type ALJEFDPBPKG, Func<string, string> NNGHHBMCFCI, bool DPPPIKDNPFC, bool PCJOBBPFIHE, bool JIGIEAKDOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35238C0", Offset = "0x3522AC0", VA = "0x1835238C0")]
	private static Dictionary<GDIGMJEPGFJ, FieldInfo> MEIPNOGOELG(TypeBuilder ANJCKBCBAMB, MHEKHLNPICH CHAANBAMFED, ConstructorInfo JLFMEHNCONN, FieldBuilder GGJMMAMDCHG, ILGenerator DPHPGJKLHFF, bool DPPPIKDNPFC, bool GIMDAGHIEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x351FEB0", Offset = "0x351F0B0", VA = "0x18351FEB0")]
	private static Dictionary<GDIGMJEPGFJ, FieldInfo> FHJHCIPPFOF(TypeBuilder ANJCKBCBAMB, MHEKHLNPICH CHAANBAMFED, ILGenerator DPHPGJKLHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3522360", Offset = "0x3521560", VA = "0x183522360")]
	private static void LHIGFPNOOOO(Type ALJEFDPBPKG, MHEKHLNPICH CHAANBAMFED, ILGenerator DPHPGJKLHFF, Action BAJFCPLBCPO, Func<int, GDIGMJEPGFJ, bool> LEHLNKAGOBB, bool DPPPIKDNPFC, bool GIMDAGHIEPA, int KLLBPBFENLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x35251C0", Offset = "0x35243C0", VA = "0x1835251C0")]
	private static void OCGDKKCKKJK(TypeInfo ALJEFDPBPKG, GDIGMJEPGFJ FMFGDDJNJNE, ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG, Func<int, GDIGMJEPGFJ, bool> LEHLNKAGOBB, NCMEBGHPNFE IECKPLOJOMK, NCMEBGHPNFE JFCFNCLPAFM, NCMEBGHPNFE LMOGBDHPINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3523F10", Offset = "0x3523110", VA = "0x183523F10")]
	private static void MLDAMMCGLIE(Type ALJEFDPBPKG, MHEKHLNPICH CHAANBAMFED, ILGenerator DPHPGJKLHFF, Func<int, GDIGMJEPGFJ, bool> LEHLNKAGOBB, bool JCPHIPOBEHC, int KLLBPBFENLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3520610", Offset = "0x351F810", VA = "0x183520610")]
	private static void JFGMALLIKFA(ILGenerator DPHPGJKLHFF, HEEDAIIFHAC CHAANBAMFED, int OHJLAHMBLMG, Func<int, GDIGMJEPGFJ, bool> LEHLNKAGOBB, NCMEBGHPNFE MGBNMNINNDM, NCMEBGHPNFE LMOGBDHPINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35256B0", Offset = "0x35248B0", VA = "0x1835256B0")]
	private static LocalBuilder POOOPHMMJEA(ILGenerator DPHPGJKLHFF, Type ALJEFDPBPKG, MHEKHLNPICH CHAANBAMFED, HEEDAIIFHAC[] EIOGKGGFMLB, bool FPJLPKNPFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x351ED40", Offset = "0x351DF40", VA = "0x18351ED40")]
	private static bool BCBPOPGIJGA(ConstructorInfo EBIAJHKLJNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3520470", Offset = "0x351F670", VA = "0x183520470")]
	private static bool HHNIMDEOHAJ(Type ALJEFDPBPKG, out Type FCFCHMLCEGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void MIBFNICFGGE<T>(byte[][] GGJMMAMDCHG, object[] OGNMNADKFCB, ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB FEAPEFKDNBD);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T FBHJOKMMJMJ<T>(object[] OGNMNADKFCB, ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB FEAPEFKDNBD);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class HDIHAAKBMNL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class EMPHBKMIJAA : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class JKPFHIDPEDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x296DAB0", Offset = "0x296CCB0", VA = "0x18296DAB0")]
		static JKPFHIDPEDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private EMPHBKMIJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class OEMGAGMBGAP : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class GNPDDHCFECO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4319910", Offset = "0x4318B10", VA = "0x184319910")]
		static GNPDDHCFECO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private OEMGAGMBGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class JAPENOPIOBN
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly PGDAFACPPLB[] GCODBGLFHPM;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class JMMNPMEALNP : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class AGJJPKFOFKC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x32163A0", Offset = "0x32155A0", VA = "0x1832163A0")]
		static AGJJPKFOFKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class EFBDPGPIOLJ : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class KGKBCHNEINC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3229BD0", Offset = "0x3228DD0", VA = "0x183229BD0")]
			static KGKBCHNEINC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private EFBDPGPIOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private JMMNPMEALNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class JIEPGNBKNJC : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class BLOHMJJNJGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3A1E150", Offset = "0x3A1D350", VA = "0x183A1E150")]
		static BLOHMJJNJGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class FBNJEFILHOM : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class FBLDELEFLPE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3A21570", Offset = "0x3A20770", VA = "0x183A21570")]
			static FBLDELEFLPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private FBNJEFILHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private JIEPGNBKNJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class BBKFHKIDDGG : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class MDBGIOCPCKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x36BDCB0", Offset = "0x36BCEB0", VA = "0x1836BDCB0")]
		static MDBGIOCPCKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class ALMJNEANOEE : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class HBKOABNHDGG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x36B62A0", Offset = "0x36B54A0", VA = "0x1836B62A0")]
			static HBKOABNHDGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private ALMJNEANOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private BBKFHKIDDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class ECNAPEKEGNI : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class KILACONMOFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3665800", Offset = "0x3664A00", VA = "0x183665800")]
		static KILACONMOFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class GACGGNFIMDB : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class PEBBBGLIJAF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3669410", Offset = "0x3668610", VA = "0x183669410")]
			static PEBBBGLIJAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private GACGGNFIMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private ECNAPEKEGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OECMNCGIIJN : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AMECNMPDGBC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x43085F0", Offset = "0x43077F0", VA = "0x1843085F0")]
		static AMECNMPDGBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class KPBFEFGEEJE : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class GAAGFEGKKBF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4314CC0", Offset = "0x4313EC0", VA = "0x184314CC0")]
			static GAAGFEGKKBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private KPBFEFGEEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private OECMNCGIIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class DFMBOKHFCEH : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class EOODDCOGILH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x389B350", Offset = "0x389A550", VA = "0x18389B350")]
		static EOODDCOGILH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class FOAMADONFOC : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GBBLKGKNPAD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x389F430", Offset = "0x389E630", VA = "0x18389F430")]
			static GBBLKGKNPAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private FOAMADONFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private DFMBOKHFCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class OFFMBBEBCNG : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class PGNKEJJFNOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4323CD0", Offset = "0x4322ED0", VA = "0x184323CD0")]
		static PGNKEJJFNOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class CKJNCIBCKFO : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class AMOKJOJGABG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x430BAF0", Offset = "0x430ACF0", VA = "0x18430BAF0")]
			static AMOKJOJGABG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private CKJNCIBCKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private OFFMBBEBCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class BCLNMHJFLEK : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class FAANLAOLBMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36AD800", Offset = "0x36ACA00", VA = "0x1836AD800")]
		static FAANLAOLBMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class GAMIAGPMFON : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class HHEBOFCDIGF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x36B95D0", Offset = "0x36B87D0", VA = "0x1836B95D0")]
			static HHEBOFCDIGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private GAMIAGPMFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private BCLNMHJFLEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GGKAOJGNODH : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class BLNEMBBKBIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A470", Offset = "0x1E49670", VA = "0x181E4A470")]
		static BLNEMBBKBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class GEHAKHDCILP : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class ILHEFFIFODH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1E5CB60", Offset = "0x1E5BD60", VA = "0x181E5CB60")]
			static ILHEFFIFODH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private GEHAKHDCILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private GGKAOJGNODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class GODNKGAIOHB : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class OAOGKMBKDHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x30E4B20", Offset = "0x30E3D20", VA = "0x1830E4B20")]
		static OAOGKMBKDHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OEJBJGPOCFF : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class GLBAHFGADKD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x30CB9B0", Offset = "0x30CABB0", VA = "0x1830CB9B0")]
			static GLBAHFGADKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private OEJBJGPOCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private GODNKGAIOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class ANALBPDDOOD : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class OAFJIKIIGBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C82350", Offset = "0x2C81550", VA = "0x182C82350")]
		static OAFJIKIIGBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class AJIPGKLJBOB : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class DJGCHNFBDFN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C79F30", Offset = "0x2C79130", VA = "0x182C79F30")]
			static DJGCHNFBDFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private AJIPGKLJBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private ANALBPDDOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class BNACKGHLFMM : PGDAFACPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class IKMGCDININC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x40C6490", Offset = "0x40C5690", VA = "0x1840C6490")]
		static IKMGCDININC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class HLADFPHMHHP : PGDAFACPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class BAHBKEAFBIE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::CMLDAFIIOAH<T> FNCCCNKAOMJ;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x40B9C00", Offset = "0x40B8E00", VA = "0x1840B9C00")]
			static BAHBKEAFBIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly PGDAFACPPLB LHIDCGAAEOA;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly PGDAFACPPLB[] AICIMPCCGLK;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		private HLADFPHMHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
		public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly PGDAFACPPLB LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::CMLDAFIIOAH<object> HPPHJMPAAKO;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	private BNACKGHLFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1C96AA0", Offset = "0x1C95CA0", VA = "0x181C96AA0", Slot = "4")]
	public global::CMLDAFIIOAH<T> FGKKBFENJNC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct AJIAPMNFGPH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] BCPCOIPHMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int FNLLLKNNJJL;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EB40", Offset = "0x2C6DD40", VA = "0x182C6EB40")]
	public AJIAPMNFGPH(int HGCCHLNDEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E9E0", Offset = "0x2C6DBE0", VA = "0x182C6E9E0")]
	public void FKEGKEHNDJG(T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EAB0", Offset = "0x2C6DCB0", VA = "0x182C6EAB0")]
	public T[] NJJCPOKIIFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class BFFGAEAAPJL : global::NOECIIOLHHE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly BFFGAEAAPJL GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x37E5340", Offset = "0x37E4540", VA = "0x1837E5340")]
	public BFFGAEAAPJL(int PLAEAEHOOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class NOECIIOLHHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int PLAEAEHOOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object FHFABGOEBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int OHJLAHMBLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] KALMJILLAHN;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4119EE0", Offset = "0x41190E0", VA = "0x184119EE0")]
	public NOECIIOLHHE(int PLAEAEHOOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4118B60", Offset = "0x4117D60", VA = "0x184118B60")]
	public T[] KCMABKCHHCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4119760", Offset = "0x4118960", VA = "0x184119760")]
	public void OBJJOKIMOEO(T[] BFDPPDNMBIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GPMEJDGBIIL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class ADIEOAGNCFF : IComparable<ADIEOAGNCFF>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class PFKBBODMLKH : IEnumerable<ADIEOAGNCFF>, IEnumerable, IEnumerator<ADIEOAGNCFF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private ADIEOAGNCFF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public ADIEOAGNCFF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private ADIEOAGNCFF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
			[DebuggerHidden]
			public PFKBBODMLKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x352F330", Offset = "0x352E530", VA = "0x18352F330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x352F460", Offset = "0x352E660", VA = "0x18352F460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x352F3C0", Offset = "0x352E5C0", VA = "0x18352F3C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ADIEOAGNCFF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x352F3C0", Offset = "0x352E5C0", VA = "0x18352F3C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class ACBABJDGMAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public ACBABJDGMAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x592CC0", Offset = "0x591EC0", VA = "0x180592CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x592CC0", Offset = "0x591EC0", VA = "0x180592CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly ADIEOAGNCFF[] AHOEKMNFDAL;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] BIIBGOEMFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong CHPMOLLJLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int JDIGBEFEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string MAAODHJOFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ADIEOAGNCFF[] DICNEBPBFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] IPLPIKLBNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int NAOLJMJHENM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DKEANJEODHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xBF88E0", Offset = "0xBF7AE0", VA = "0x180BF88E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3517F40", Offset = "0x3517140", VA = "0x183517F40")]
		public ADIEOAGNCFF(ulong ICIBGJCBOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x35179A0", Offset = "0x3516BA0", VA = "0x1835179A0")]
		public ADIEOAGNCFF FKEGKEHNDJG(ulong ICIBGJCBOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3517B90", Offset = "0x3516D90", VA = "0x183517B90")]
		public ADIEOAGNCFF FKEGKEHNDJG(ulong ICIBGJCBOAM, int LDPMPDNIHLJ, string MAAODHJOFCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3517BE0", Offset = "0x3516DE0", VA = "0x183517BE0")]
		public ADIEOAGNCFF NFEEKGOELFD(byte[] JHOEPOKBOJG, ref int NAPMMJBBFDN, ref int LMGMNIANAHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3516D10", Offset = "0x3515F10", VA = "0x183516D10")]
		internal static int BHICIHGFOID(ulong[] BFDPPDNMBIM, int OHJLAHMBLMG, int FDPDKPGBLAK, ulong LDPMPDNIHLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3516D90", Offset = "0x3515F90", VA = "0x183516D90", Slot = "4")]
		public int CompareTo(ADIEOAGNCFF MKCNOIKIBCA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3516CA0", Offset = "0x3515EA0", VA = "0x183516CA0")]
		[IteratorStateMachine(typeof(PFKBBODMLKH))]
		public IEnumerable<ADIEOAGNCFF> BDOPADDKBBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3517D90", Offset = "0x3516F90", VA = "0x183517D90")]
		public void OOMLGBHGPBD(ILGenerator DPHPGJKLHFF, LocalBuilder JHOEPOKBOJG, LocalBuilder LMGMNIANAHA, LocalBuilder ICIBGJCBOAM, Action<KeyValuePair<string, int>> NJFLDAMIGMF, Action JAHKEKKHGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3516DC0", Offset = "0x3515FC0", VA = "0x183516DC0")]
		private static void FFDGGHNONIJ(ILGenerator DPHPGJKLHFF, LocalBuilder JHOEPOKBOJG, LocalBuilder LMGMNIANAHA, LocalBuilder ICIBGJCBOAM, Action<KeyValuePair<string, int>> NJFLDAMIGMF, Action JAHKEKKHGGL, ADIEOAGNCFF[] DICNEBPBFPH, int NAOLJMJHENM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class MEMPDHKBJKK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<ADIEOAGNCFF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<ADIEOAGNCFF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<ADIEOAGNCFF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ADIEOAGNCFF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x58B000", Offset = "0x58A200", VA = "0x18058B000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x352EC50", Offset = "0x352DE50", VA = "0x18352EC50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B34D0", Offset = "0x9B26D0", VA = "0x1809B34D0")]
		[DebuggerHidden]
		public MEMPDHKBJKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x352ECA0", Offset = "0x352DEA0", VA = "0x18352ECA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x352E7E0", Offset = "0x352D9E0", VA = "0x18352E7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x352EDA0", Offset = "0x352DFA0", VA = "0x18352EDA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x352EDF0", Offset = "0x352DFF0", VA = "0x18352EDF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x352EC00", Offset = "0x352DE00", VA = "0x18352EC00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x352EB60", Offset = "0x352DD60", VA = "0x18352EB60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x352EB60", Offset = "0x352DD60", VA = "0x18352EB60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ADIEOAGNCFF EEOPLFIHJMP;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x351BEE0", Offset = "0x351B0E0", VA = "0x18351BEE0")]
	public GPMEJDGBIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x351B800", Offset = "0x351AA00", VA = "0x18351B800")]
	public void FKEGKEHNDJG(byte[] NGIBJOEMFPL, int LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x351BCD0", Offset = "0x351AED0", VA = "0x18351BCD0")]
	public bool MILFNGCABBG(ArraySegment<byte> ICIBGJCBOAM, out int LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x351BDF0", Offset = "0x351AFF0", VA = "0x18351BDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x351BA50", Offset = "0x351AC50", VA = "0x18351BA50")]
	private static void MBANPOGFLIP(IEnumerable<ADIEOAGNCFF> DICNEBPBFPH, StringBuilder BIJFLIINDDK, int MJDCBDAMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x351B920", Offset = "0x351AB20", VA = "0x18351B920", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x351B920", Offset = "0x351AB20", VA = "0x18351B920", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x351BD80", Offset = "0x351AF80", VA = "0x18351BD80")]
	[IteratorStateMachine(typeof(MEMPDHKBJKK))]
	private static IEnumerable<KeyValuePair<string, int>> MPFNEHFGLAI(IEnumerable<ADIEOAGNCFF> DICNEBPBFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x351BA20", Offset = "0x351AC20", VA = "0x18351BA20")]
	public void JFNEPKHFLKH(ILGenerator DPHPGJKLHFF, LocalBuilder JHOEPOKBOJG, LocalBuilder LMGMNIANAHA, LocalBuilder ICIBGJCBOAM, Action<KeyValuePair<string, int>> NJFLDAMIGMF, Action JAHKEKKHGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class BENLILDKKCA
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo OMDEKMDMKGM;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x37E4230", Offset = "0x37E3430", VA = "0x1837E4230")]
	public static ulong NCKOOENMFBC(byte[] NGIBJOEMFPL, ref int NAPMMJBBFDN, ref int LMGMNIANAHA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class DIBKOCHMMBK
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x37EB640", Offset = "0x37EA840", VA = "0x1837EB640")]
	public static void MCOJLDDDGFI(ref byte[] NGIBJOEMFPL, int NAPMMJBBFDN, int FPMDJEBHHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x37EB550", Offset = "0x37EA750", VA = "0x1837EB550")]
	public static void LLFIOMFKCHJ(ref byte[] BFDPPDNMBIM, int EKHBMEJDNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x37EB460", Offset = "0x37EA660", VA = "0x1837EB460")]
	public static byte[] JNBKCAALJGD(byte[] AHAJHEEFGLF, int EKHBMEJDNBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class PFABONPHJJH
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4817C70", Offset = "0x4816E70", VA = "0x184817C70")]
	public static bool ICHDBJIAOKL(byte[] ICJMNGNKMEN, int HODGEFBJELG, int BOAMIIEBLKL, byte[] ALMMENGAKMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class NGHFLFCOJMD<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct NOGKACBFCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] CHPMOLLJLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T JDIGBEFEDMD;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4050E00", Offset = "0x4050000", VA = "0x184050E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class INODLAGEGDE : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::NGHFLFCOJMD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private NOGKACBFCKP[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private NOGKACBFCKP[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1853BD0", Offset = "0x1852DD0", VA = "0x181853BD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89BA0", Offset = "0x3B88DA0", VA = "0x183B89BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DC10", Offset = "0x1D6CE10", VA = "0x181D6DC10")]
		[DebuggerHidden]
		public INODLAGEGDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4045CA0", Offset = "0x4044EA0", VA = "0x184045CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4046980", Offset = "0x4045B80", VA = "0x184046980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NOGKACBFCKP[][] DFDLHFLDHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong OLKAOHJAHKO;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x404F490", Offset = "0x404E690", VA = "0x18404F490")]
	public NGHFLFCOJMD(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x404F3D0", Offset = "0x404E5D0", VA = "0x18404F3D0")]
	public NGHFLFCOJMD(int FDMAMJMNCKL, float DBAFPHLHGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x404AAC0", Offset = "0x4049CC0", VA = "0x18404AAC0")]
	public void FKEGKEHNDJG(byte[] ICIBGJCBOAM, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x404C8E0", Offset = "0x404BAE0", VA = "0x18404C8E0")]
	private bool ODHFAPPMELJ(byte[] ICIBGJCBOAM, T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x40482A0", Offset = "0x40474A0", VA = "0x1840482A0")]
	public bool FINJNPJEIIJ(ArraySegment<byte> ICIBGJCBOAM, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x404AE10", Offset = "0x404A010", VA = "0x18404AE10")]
	private static ulong LCPPABFOPAG(byte[] CNMHAFPCMJK, int NAPMMJBBFDN, int NAOLJMJHENM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x240E650", Offset = "0x240D850", VA = "0x18240E650")]
	private static int MJBCGECIJKA(int EHPFPGHNAEB, float DBAFPHLHGOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x404AD80", Offset = "0x4049F80", VA = "0x18404AD80", Slot = "4")]
	[IteratorStateMachine(typeof(global::NGHFLFCOJMD<>.INODLAGEGDE))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E94580", Offset = "0x1E93780", VA = "0x181E94580", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class MMOIDLIIMBA : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] IAEMKNOEEAG;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] MANIMPKOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int GEEHFPAJCCH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MNPFDFMFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x48107D0", Offset = "0x480F9D0", VA = "0x1848107D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4810820", Offset = "0x480FA20", VA = "0x184810820")]
	static MMOIDLIIMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4810A70", Offset = "0x480FC70", VA = "0x184810A70")]
	public MMOIDLIIMBA(byte[] GPHNMOEHGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x48106C0", Offset = "0x480F8C0", VA = "0x1848106C0")]
	public OpCode HANGICHKJGI()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct NPOPBHHGNAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid JDIGBEFEDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte EKNLPACCECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte FFMCJMMKFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte EPGLCKNKLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte KPAOHFMFKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte PBLMGEJLJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte CDCEMIGLNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte NAFKOFAJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DEAPNALGMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte PGKDMMDPDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte NEEFHOAFCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte PLFPHIPHJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte GDIIONKJCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte CGGLDOAEBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CPHDMBHJAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte BEGGHNNFCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte APLLMAANPAN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] LNOOKEKHFLC;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] LLKPBHHNHFA;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4815C30", Offset = "0x4814E30", VA = "0x184815C30")]
	public NPOPBHHGNAL(ref Guid LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4815C40", Offset = "0x4814E40", VA = "0x184815C40")]
	public NPOPBHHGNAL(ref ArraySegment<byte> KBBOAGEDCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4814670", Offset = "0x4813870", VA = "0x184814670")]
	private static byte BPFJKHBJLFE(byte[] NGIBJOEMFPL, int GMJIDAKOCCB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4815A70", Offset = "0x4814C70", VA = "0x184815A70")]
	private static byte MAGBLEHJDGP(byte DLFOEJDCAKP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4814730", Offset = "0x4813930", VA = "0x184814730")]
	public void KNFGPIHCBKM(byte[] OHNDJLPLBEI, int NAPMMJBBFDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class EFHLFBMEIBM
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD20", Offset = "0x37EBF20", VA = "0x1837ECD20")]
	public static bool BDJFFKMKOIK(byte DIHFAACINDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x37EE210", Offset = "0x37ED410", VA = "0x1837EE210")]
	public static bool PBBNPOKNEBD(byte DIHFAACINDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x37EDF50", Offset = "0x37ED150", VA = "0x1837EDF50")]
	public static sbyte MFPHIANJBGJ(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x37ECDA0", Offset = "0x37EBFA0", VA = "0x1837ECDA0")]
	public static short EKPKABDJAKL(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD30", Offset = "0x37EBF30", VA = "0x1837ECD30")]
	public static int CHGBDLPMLDO(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE10", Offset = "0x37EC010", VA = "0x1837ECE10")]
	public static long HKLJLCMCPJH(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x37EDEE0", Offset = "0x37ED0E0", VA = "0x1837EDEE0")]
	public static byte LIKDBKAGOAO(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x37EE0B0", Offset = "0x37ED2B0", VA = "0x1837EE0B0")]
	public static ushort OAJJGOMJBOH(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x37ECEC0", Offset = "0x37EC0C0", VA = "0x1837ECEC0")]
	public static uint HODPEMIMEFK(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x37ECF40", Offset = "0x37EC140", VA = "0x1837ECF40")]
	public static ulong IJHMPNGIEOF(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x37EE120", Offset = "0x37ED320", VA = "0x1837EE120")]
	public static float OHGFMMIFNME(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x37EDFC0", Offset = "0x37ED1C0", VA = "0x1837EDFC0")]
	public static double NNDJJGKFCKP(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x37EC550", Offset = "0x37EB750", VA = "0x1837EC550")]
	public static int AMDFNEJGEKL(ref byte[] OHNDJLPLBEI, int NAPMMJBBFDN, ulong LDPMPDNIHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x37ED050", Offset = "0x37EC250", VA = "0x1837ED050")]
	public static int KDAFHDELAOG(ref byte[] OHNDJLPLBEI, int NAPMMJBBFDN, long LDPMPDNIHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC90", Offset = "0x37ECE90", VA = "0x1837EDC90")]
	public static bool KGNPLNOMOBN(byte[] NGIBJOEMFPL, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class DCAIAHHNNBG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NGPJGIAJMNL : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public NGPJGIAJMNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x37F8B80", Offset = "0x37F7D80", VA = "0x1837F8B80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x37F8720", Offset = "0x37F7920", VA = "0x1837F8720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x37F8CA0", Offset = "0x37F7EA0", VA = "0x1837F8CA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x37F8CF0", Offset = "0x37F7EF0", VA = "0x1837F8CF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x37F8B30", Offset = "0x37F7D30", VA = "0x1837F8B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x37F8A80", Offset = "0x37F7C80", VA = "0x1837F8A80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x37F8A80", Offset = "0x37F7C80", VA = "0x1837F8A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FAPBHGCHDPB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69B3E0", Offset = "0x69A5E0", VA = "0x18069B3E0")]
		[DebuggerHidden]
		public FAPBHGCHDPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x37F15A0", Offset = "0x37F07A0", VA = "0x1837F15A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x37F1140", Offset = "0x37F0340", VA = "0x1837F1140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x37F16C0", Offset = "0x37F08C0", VA = "0x1837F16C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x37F1710", Offset = "0x37F0910", VA = "0x1837F1710")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x37F1550", Offset = "0x37F0750", VA = "0x1837F1550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x37F14A0", Offset = "0x37F06A0", VA = "0x1837F14A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x37F14A0", Offset = "0x37F06A0", VA = "0x1837F14A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x37EABA0", Offset = "0x37E9DA0", VA = "0x1837EABA0")]
	public static bool GBPJHEANEPI(this TypeInfo ALJEFDPBPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x37EACB0", Offset = "0x37E9EB0", VA = "0x1837EACB0")]
	public static bool LLEDGDBPHEA(this TypeInfo ALJEFDPBPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x37EAC50", Offset = "0x37E9E50", VA = "0x1837EAC50")]
	public static IEnumerable<PropertyInfo> ICPNEEAKDDN(this Type ALJEFDPBPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x37EAAB0", Offset = "0x37E9CB0", VA = "0x1837EAAB0")]
	[IteratorStateMachine(typeof(NGPJGIAJMNL))]
	private static IEnumerable<PropertyInfo> DDAAODIDKDE(Type ALJEFDPBPKG, HashSet<string> HFCKBCAAJGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x37EAB40", Offset = "0x37E9D40", VA = "0x1837EAB40")]
	public static IEnumerable<FieldInfo> FFJKLPKOPMA(this Type ALJEFDPBPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x37EADB0", Offset = "0x37E9FB0", VA = "0x1837EADB0")]
	[IteratorStateMachine(typeof(FAPBHGCHDPB))]
	private static IEnumerable<FieldInfo> NIMMBLNEMKH(Type ALJEFDPBPKG, HashSet<string> HFCKBCAAJGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class LBIECLFNJLF
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding DGBALNDLPCE;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class OAFHPIFJGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63FF60", Offset = "0x63F160", VA = "0x18063FF60")]
	public static string GDKFCDEMMIA(string JJPOEPNDEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4816AF0", Offset = "0x4815CF0", VA = "0x184816AF0")]
	public static string HFOMMKGOAIG(string JJPOEPNDEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4816920", Offset = "0x4815B20", VA = "0x184816920")]
	public static string HBAAJCHOCNP(string JJPOEPNDEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class MDKPJEMIGJL<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class LJLJHCIGMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type CHPMOLLJLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue JDIGBEFEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int KKCDOFHEILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public LJLJHCIGMNL CHLDIPCPHDH;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2405FC0", Offset = "0x24051C0", VA = "0x182405FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2405F40", Offset = "0x2405140", VA = "0x182405F40")]
		private int HKOLKDAEOPE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public LJLJHCIGMNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class HCPIIHCPBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public HCPIIHCPBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x89B740", Offset = "0x89A940", VA = "0x18089B740")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private LJLJHCIGMNL[] DFDLHFLDHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int FECFCKEKGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object LBOACHHAGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float DBAFPHLHGOF;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x240F3E0", Offset = "0x240E5E0", VA = "0x18240F3E0")]
	public MDKPJEMIGJL(int FDMAMJMNCKL = 4, float DBAFPHLHGOF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x240E540", Offset = "0x240D740", VA = "0x18240E540")]
	public bool HOLPEDBHFBN(Type ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x240E3F0", Offset = "0x240D5F0", VA = "0x18240E3F0")]
	public bool HOLPEDBHFBN(Type ICIBGJCBOAM, Func<Type, TValue> MKIAOILACPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x240F0E0", Offset = "0x240E2E0", VA = "0x18240F0E0")]
	private bool ODHFAPPMELJ(Type ICIBGJCBOAM, Func<Type, TValue> MKIAOILACPM, out TValue NEHNCBDKDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x240E680", Offset = "0x240D880", VA = "0x18240E680")]
	private bool NEIAODDBMBK(LJLJHCIGMNL[] DFDLHFLDHFG, Type KPHBPCKGMGA, LJLJHCIGMNL MLMLNCBIHID, Func<Type, TValue> MKIAOILACPM, out TValue NEHNCBDKDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x240DFC0", Offset = "0x240D1C0", VA = "0x18240DFC0")]
	public bool FINJNPJEIIJ(Type ICIBGJCBOAM, out TValue LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x240E260", Offset = "0x240D460", VA = "0x18240E260")]
	public TValue FKMLAAHCPLI(Type ICIBGJCBOAM, Func<Type, TValue> MKIAOILACPM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x240E650", Offset = "0x240D850", VA = "0x18240E650")]
	private static int MJBCGECIJKA(int EHPFPGHNAEB, float DBAFPHLHGOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x240DF90", Offset = "0x240D190", VA = "0x18240DF90")]
	private static void APPMBCFDGIN(ref LJLJHCIGMNL PMNEDOCNBGG, LJLJHCIGMNL LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x240DF90", Offset = "0x240D190", VA = "0x18240DF90")]
	private static void APPMBCFDGIN(ref LJLJHCIGMNL[] PMNEDOCNBGG, LJLJHCIGMNL[] LDPMPDNIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class MAKJPJHIFIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder DODPLGPACIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder KKEPOMEHHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object FHFABGOEBIP;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x480E360", Offset = "0x480D560", VA = "0x18480E360")]
	public TypeBuilder LPOBNPGJAIC(string KFCJDHCECCC, TypeAttributes JNKNCHENDKE, Type DBICPFPGAAP, Type[] GDCLHLOJBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x480E450", Offset = "0x480D650", VA = "0x18480E450")]
	public MAKJPJHIFIG(string GGPHMPABMHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class EOOHBHAPKAA
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x37F0E80", Offset = "0x37F0080", VA = "0x1837F0E80")]
	private static MethodInfo AJPIJEFHLAH(LambdaExpression IPMKFLAIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x373A270", Offset = "0x3739470", VA = "0x18373A270")]
	public static MethodInfo OLAEFIDCKAD<T>(Expression<Func<T>> IPMKFLAIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x373A270", Offset = "0x3739470", VA = "0x18373A270")]
	public static MethodInfo OLAEFIDCKAD<T, TR>(Expression<Func<T, TR>> IPMKFLAIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x373A270", Offset = "0x3739470", VA = "0x18373A270")]
	public static MethodInfo OLAEFIDCKAD<T>(Expression<Action<T>> IPMKFLAIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x373A270", Offset = "0x3739470", VA = "0x18373A270")]
	public static MethodInfo OLAEFIDCKAD<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> IPMKFLAIFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x373A170", Offset = "0x3739370", VA = "0x18373A170")]
	private static MemberInfo BEPHHJFANDL<T>(Expression<T> GKDMFJGFBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x373A210", Offset = "0x3739410", VA = "0x18373A210")]
	public static PropertyInfo HLIKIDAMOBJ<T, TR>(Expression<Func<T, TR>> IPMKFLAIFJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct NCMEBGHPNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int PJEHDDODHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool IIKKDINFMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator DPHPGJKLHFF;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x48115C0", Offset = "0x48107C0", VA = "0x1848115C0")]
	public NCMEBGHPNFE(ILGenerator DPHPGJKLHFF, int PJEHDDODHBJ, bool IIKKDINFMPG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4811530", Offset = "0x4810730", VA = "0x184811530")]
	public NCMEBGHPNFE(ILGenerator DPHPGJKLHFF, int PJEHDDODHBJ, Type ALJEFDPBPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4811420", Offset = "0x4810620", VA = "0x184811420")]
	public void INFPKCDHFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class KKGBHBFAHMH
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x480C090", Offset = "0x480B290", VA = "0x18480C090")]
	public static void IJMLHMCHDJP(this ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x480C050", Offset = "0x480B250", VA = "0x18480C050")]
	public static void IJMLHMCHDJP(this ILGenerator DPHPGJKLHFF, LocalBuilder GOAFGOMNKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x480BA30", Offset = "0x480AC30", VA = "0x18480BA30")]
	public static void EAGIFJEDJFJ(this ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x480BC60", Offset = "0x480AE60", VA = "0x18480BC60")]
	public static void EAGIFJEDJFJ(this ILGenerator DPHPGJKLHFF, LocalBuilder GOAFGOMNKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x480C370", Offset = "0x480B570", VA = "0x18480C370")]
	public static void OINNIFHHCHG(this ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x480C460", Offset = "0x480B660", VA = "0x18480C460")]
	public static void OINNIFHHCHG(this ILGenerator DPHPGJKLHFF, LocalBuilder GOAFGOMNKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x480B4D0", Offset = "0x480A6D0", VA = "0x18480B4D0")]
	public static void CJAEIPDFLON(this ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x480C2C0", Offset = "0x480B4C0", VA = "0x18480C2C0")]
	public static void KEEGPPCIGGB(this ILGenerator DPHPGJKLHFF, bool LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x480B5E0", Offset = "0x480A7E0", VA = "0x18480B5E0")]
	public static void DKFKCFFHGPO(this ILGenerator DPHPGJKLHFF, int LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x480BCA0", Offset = "0x480AEA0", VA = "0x18480BCA0")]
	public static void FBFBNCGJIBK(this ILGenerator DPHPGJKLHFF, Type ALJEFDPBPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x480C2D0", Offset = "0x480B4D0", VA = "0x18480C2D0")]
	public static void MFOLKBNKMKN(this ILGenerator DPHPGJKLHFF, Type ALJEFDPBPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x480BD90", Offset = "0x480AF90", VA = "0x18480BD90")]
	public static void FNOOOCEJIIB(this ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x480B450", Offset = "0x480A650", VA = "0x18480B450")]
	public static void ABIPMNOLKBF(this ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x480C600", Offset = "0x480B800", VA = "0x18480C600")]
	public static void PDPLCCBGGKN(this ILGenerator DPHPGJKLHFF, int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x480B4E0", Offset = "0x480A6E0", VA = "0x18480B4E0")]
	public static void DKEEICMANFG(this ILGenerator DPHPGJKLHFF, MethodInfo MJPKJCNMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x480C570", Offset = "0x480B770", VA = "0x18480C570")]
	public static void OIPLEHECJMF(this ILGenerator DPHPGJKLHFF, FieldInfo GMIJKFBHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x480BFC0", Offset = "0x480B1C0", VA = "0x18480BFC0")]
	public static void HAFBHLEFIDP(this ILGenerator DPHPGJKLHFF, ulong LDPMPDNIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class GDIGMJEPGFJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class JCAJGEDPFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public JCAJGEDPFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x37F8620", Offset = "0x37F7820", VA = "0x1837F8620")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo IHBCFKGMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo KBMAOCKJMOC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LLFKKACAPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AJCKGDHGKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x37F5500", Offset = "0x37F4700", VA = "0x1837F5500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LDDNFJFJOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x58A190", Offset = "0x589390", VA = "0x18058A190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E80", Offset = "0x6E4080", VA = "0x1806E4E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool INLJJFOOBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x58A1A0", Offset = "0x5893A0", VA = "0x18058A1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A8400", VA = "0x1807A9200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type HOCDCBPEMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCC0", Offset = "0x6ACEC0", VA = "0x1806ADCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JMILLLACGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo FHLGLEIBFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x58B010", Offset = "0x58A210", VA = "0x18058B010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x58B020", Offset = "0x58A220", VA = "0x18058B020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo MKENAMDLDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x59DD70", Offset = "0x59CF70", VA = "0x18059DD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x624FC0", Offset = "0x6241C0", VA = "0x180624FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x37F57E0", Offset = "0x37F49E0", VA = "0x1837F57E0")]
	protected GDIGMJEPGFJ(Type ALJEFDPBPKG, string KFCJDHCECCC, string ABOCOFHGJDB, bool APJJAMHFKFL, bool DBAKBNINCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x37F5860", Offset = "0x37F4A60", VA = "0x1837F5860")]
	public GDIGMJEPGFJ(FieldInfo CHAANBAMFED, string KFCJDHCECCC, bool PCJOBBPFIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x37F5630", Offset = "0x37F4830", VA = "0x1837F5630")]
	public GDIGMJEPGFJ(PropertyInfo CHAANBAMFED, string KFCJDHCECCC, bool PCJOBBPFIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x37F5510", Offset = "0x37F4710", VA = "0x1837F5510")]
	private static MethodInfo JILPMPNJEJE(MemberInfo CHAANBAMFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x243DDF0", Offset = "0x243CFF0", VA = "0x18243DDF0")]
	public T AJAGGKNOAHL<T>(bool OBLBGDEOCIG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x37F5440", Offset = "0x37F4640", VA = "0x1837F5440", Slot = "4")]
	public virtual void ALOLEAKIKFA(ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x37F5380", Offset = "0x37F4580", VA = "0x1837F5380", Slot = "5")]
	public virtual void ADIJMFOFKPH(ILGenerator DPHPGJKLHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class DENBOIEIIGD : GDIGMJEPGFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string MCHMGGBPIHH;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x37EB250", Offset = "0x37EA450", VA = "0x1837EB250")]
	public DENBOIEIIGD(string KFCJDHCECCC, string MCHMGGBPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x37EB190", Offset = "0x37EA390", VA = "0x1837EB190", Slot = "4")]
	public override void ALOLEAKIKFA(ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x37EB140", Offset = "0x37EA340", VA = "0x1837EB140", Slot = "5")]
	public override void ADIJMFOFKPH(ILGenerator DPHPGJKLHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CNHONBIBFDM : GDIGMJEPGFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo BHKECMBKPFD;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo LONAIPPAOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal NCMEBGHPNFE HNJNMKFNAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal NCMEBGHPNFE JFCFNCLPAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal NCMEBGHPNFE LMOGBDHPINB;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x37E6FF0", Offset = "0x37E61F0", VA = "0x1837E6FF0")]
	public CNHONBIBFDM(string KFCJDHCECCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x37E6980", Offset = "0x37E5B80", VA = "0x1837E6980", Slot = "4")]
	public override void ALOLEAKIKFA(ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x37E6930", Offset = "0x37E5B30", VA = "0x1837E6930", Slot = "5")]
	public override void ADIJMFOFKPH(ILGenerator DPHPGJKLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x37E6A40", Offset = "0x37E5C40", VA = "0x1837E6A40")]
	public void HEMBFBCHJBD(ILGenerator DPHPGJKLHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class MHEKHLNPICH
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type HOCDCBPEMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IKPIALODOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C80", Offset = "0x6B7E80", VA = "0x1806B8C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x75E9D0", Offset = "0x75DBD0", VA = "0x18075E9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ECMMFPEBMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x74DC10", Offset = "0x74CE10", VA = "0x18074DC10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xDCF2F0", Offset = "0xDCE4F0", VA = "0x180DCF2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo IGHDFALGBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D70", Offset = "0x5B3F70", VA = "0x1805B4D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GDIGMJEPGFJ[] JJJMCCOOIID
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCC0", Offset = "0x6ACEC0", VA = "0x1806ADCC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GDIGMJEPGFJ[] HCKELEHDNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x480F1C0", Offset = "0x480E3C0", VA = "0x18480F1C0")]
	public MHEKHLNPICH(Type ALJEFDPBPKG, Func<string, string> JMKKOCPHNIK, bool PCJOBBPFIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x480F0F0", Offset = "0x480E2F0", VA = "0x18480F0F0")]
	private static bool HOHHKEOKDFA(IEnumerator<ConstructorInfo> GMHFCHGADFI, ref ConstructorInfo BCDKINIPENJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct GLBGMJHFHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong MENHNDLOJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int NBMFBMPPBLJ;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2433220", Offset = "0x2432420", VA = "0x182433220")]
	public GLBGMJHFHJC(ulong HPHGCIDMIDE, int JOOPGOJGOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x37F7C20", Offset = "0x37F6E20", VA = "0x1837F7C20")]
	public void AICOJJBJOKA(ref GLBGMJHFHJC MKCNOIKIBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x37F7D70", Offset = "0x37F6F70", VA = "0x1837F7D70")]
	public static GLBGMJHFHJC JDGFOKNNBNM(ref GLBGMJHFHJC KICBFMPMNBH, ref GLBGMJHFHJC DLFOEJDCAKP)
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x37F7C30", Offset = "0x37F6E30", VA = "0x1837F7C30")]
	public void HIPIBGHFFPL(ref GLBGMJHFHJC MKCNOIKIBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x37F7CC0", Offset = "0x37F6EC0", VA = "0x1837F7CC0")]
	public static GLBGMJHFHJC HJPHDLHMGPN(ref GLBGMJHFHJC KICBFMPMNBH, ref GLBGMJHFHJC DLFOEJDCAKP)
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x37F7E00", Offset = "0x37F7000", VA = "0x1837F7E00")]
	public void OFJHDGEKLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x37F7DA0", Offset = "0x37F6FA0", VA = "0x1837F7DA0")]
	public static GLBGMJHFHJC OFJHDGEKLBP(ref GLBGMJHFHJC KICBFMPMNBH)
	{
		return default(GLBGMJHFHJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MACBFFFHKJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] OHNDJLPLBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int NAPMMJBBFDN;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9CB790", Offset = "0x9CA990", VA = "0x1809CB790")]
	public MACBFFFHKJH(byte[] OHNDJLPLBEI, int PNBJGABNCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x480E200", Offset = "0x480D400", VA = "0x18480E200")]
	public void KLMJJMGEODK(byte IDFBJHKLGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x480E160", Offset = "0x480D360", VA = "0x18480E160")]
	public void JJNKMMHHBHH(byte[] IDFBJHKLGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x480E010", Offset = "0x480D210", VA = "0x18480E010")]
	public void GOFIHCCOMEO(byte[] IDFBJHKLGEA, int FDPDKPGBLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x480E0B0", Offset = "0x480D2B0", VA = "0x18480E0B0")]
	public void GOFIHCCOMEO(byte[] IDFBJHKLGEA, int NDIGKIEANGO, int FDPDKPGBLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x480DF90", Offset = "0x480D190", VA = "0x18480DF90")]
	public void DPHDAFIGBAM(byte DIHFAACINDK, int NAOLJMJHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x480E260", Offset = "0x480D460", VA = "0x18480E260")]
	public void LECKJCGBHJL(string IDFBJHKLGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class EJFLFLHPGHI
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum HIOJDGOHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum DGFMDNKHJJK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum MGBAJDMPALC
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
	private static byte[] CCFJPJKBLNF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] MPKOINBGKEM;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] ABHFOCOFEIO;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] EKMLGABDEGI;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly MGBAJDMPALC OJPPKPANMJJ;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char DODNIKDPAKP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int OKFIEFMNKPL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int OOLJJDPFCOG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] IFMMGLOHGCM;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x37EECD0", Offset = "0x37EDED0", VA = "0x1837EECD0")]
	private static byte[] EHOEPDBODIG(int FECFCKEKGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x37EE5C0", Offset = "0x37ED7C0", VA = "0x1837EE5C0")]
	private static byte[] CBKOGDELLMG(int FECFCKEKGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x37EF0A0", Offset = "0x37EE2A0", VA = "0x1837EF0A0")]
	public static int IELEPPKGFBL(ref byte[] OHNDJLPLBEI, int NAPMMJBBFDN, float LDPMPDNIHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x37EEF90", Offset = "0x37EE190", VA = "0x1837EEF90")]
	public static int IELEPPKGFBL(ref byte[] OHNDJLPLBEI, int NAPMMJBBFDN, double LDPMPDNIHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x37EEE90", Offset = "0x37EE090", VA = "0x1837EEE90")]
	private static bool GBGKGIEOOLG(byte[] OHNDJLPLBEI, int FDPDKPGBLAK, ulong HKJJMMJONBG, ulong APEJPEEFBMO, ulong LMGMNIANAHA, ulong PMGNPHBEEFF, ulong CIHFGKIMCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x37EF4A0", Offset = "0x37EE6A0", VA = "0x1837EF4A0")]
	private static void MACKBKIDMAK(uint IKPDDHNCNEC, int GDDHCADKBIA, out uint GDDHMMKKEKL, out int MFLDAJBDPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x37EF910", Offset = "0x37EEB10", VA = "0x1837EF910")]
	private static bool PEFFCJCDKAI(GLBGMJHFHJC DLGONNNNFNI, GLBGMJHFHJC OPOOFMFPPJH, GLBGMJHFHJC LMPKBHPIEAB, byte[] OHNDJLPLBEI, out int FDPDKPGBLAK, out int NJHNDFBGHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x37EFCE0", Offset = "0x37EEEE0", VA = "0x1837EFCE0")]
	private static bool PIJIDAJIPCB(double DKNLKMNLNPI, HIOJDGOHKJK POGDHLEGDPD, byte[] OHNDJLPLBEI, out int FDPDKPGBLAK, out int OEJFPAFMMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x37EEDA0", Offset = "0x37EDFA0", VA = "0x1837EEDA0")]
	private static bool FBDBOFNKOBB(double DKNLKMNLNPI, HIOJDGOHKJK POGDHLEGDPD, byte[] OHNDJLPLBEI, out int FDPDKPGBLAK, out int DNPOCFABLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x37EF780", Offset = "0x37EE980", VA = "0x1837EF780")]
	private static bool PCMJJPLCFGK(double LDPMPDNIHLJ, ref MACBFFFHKJH HCIBLNODOCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x37EE6A0", Offset = "0x37ED8A0", VA = "0x1837EE6A0")]
	private static bool EBCNPEMILPB(double LDPMPDNIHLJ, ref MACBFFFHKJH HCIBLNODOCE, DGFMDNKHJJK POGDHLEGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x37EF5C0", Offset = "0x37EE7C0", VA = "0x1837EF5C0")]
	private static void NIGINMECCGO(byte[] DJCHHIJCLBA, int FDPDKPGBLAK, int DNPOCFABLBD, int NCFCPJBNOCI, ref MACBFFFHKJH HCIBLNODOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x37EF1B0", Offset = "0x37EE3B0", VA = "0x1837EF1B0")]
	private static void JNKEOBOBJMH(byte[] DJCHHIJCLBA, int FDPDKPGBLAK, int JOOPGOJGOHA, ref MACBFFFHKJH HCIBLNODOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x37F0150", Offset = "0x37EF350", VA = "0x1837F0150")]
	private static bool PLKNDAGONEB(double DKNLKMNLNPI, DGFMDNKHJJK POGDHLEGDPD, int DDHDNECDGEI, byte[] LKKHNIHDFDP, out bool PGNKMMLNJPM, out int FDPDKPGBLAK, out int FHCGDMNCODD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct MIOIMAJPOMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double EPKEDIDPMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong GILBPNLBJLD;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct KPMKHJMKPHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float MENHNDLOJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint GLJGFEMBPFC;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct MGPFAAJJIFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong IGAAFNANNJE;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x480F0E0", Offset = "0x480E2E0", VA = "0x18480F0E0")]
	public MGPFAAJJIFK(double EPKEDIDPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x480F040", Offset = "0x480E240", VA = "0x18480F040")]
	public MGPFAAJJIFK(GLBGMJHFHJC EPKEDIDPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x480EBB0", Offset = "0x480DDB0", VA = "0x18480EBB0")]
	public GLBGMJHFHJC DPCBKBDHNLN()
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x480EC30", Offset = "0x480DE30", VA = "0x18480EC30")]
	public GLBGMJHFHJC EBDGHBEONPA()
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7600E0", Offset = "0x75F2E0", VA = "0x1807600E0")]
	public ulong OHMKJLPAKKG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x480EAF0", Offset = "0x480DCF0", VA = "0x18480EAF0")]
	public double CHJKIGGKBAD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x480EF50", Offset = "0x480E150", VA = "0x18480EF50")]
	public double KFIFLGNLAHA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x480EAA0", Offset = "0x480DCA0", VA = "0x18480EAA0")]
	public int BLKAIGHJFCM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x480EFD0", Offset = "0x480E1D0", VA = "0x18480EFD0")]
	public ulong LDGMMOLKJNG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x480ED00", Offset = "0x480DF00", VA = "0x18480ED00")]
	public bool FMOPAIGGDAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x480F020", Offset = "0x480E220", VA = "0x18480F020")]
	public bool PDOENNLEGGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x480ECD0", Offset = "0x480DED0", VA = "0x18480ECD0")]
	public bool EPAHOEGMIHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x480EB60", Offset = "0x480DD60", VA = "0x18480EB60")]
	public bool CPAFDLJHGKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x480EAD0", Offset = "0x480DCD0", VA = "0x18480EAD0")]
	public int CGBJOPPIPFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x480EDC0", Offset = "0x480DFC0", VA = "0x18480EDC0")]
	public void JIIBICJFEME(out GLBGMJHFHJC FCDIPAIAPMO, out GLBGMJHFHJC LAOALENPNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x480EA50", Offset = "0x480DC50", VA = "0x18480EA50")]
	public bool BEOKKPAALKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x480F000", Offset = "0x480E200", VA = "0x18480F000")]
	public double LDPMPDNIHLJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x480EB90", Offset = "0x480DD90", VA = "0x18480EB90")]
	public static int DFOIKNBDOBJ(int JFLOPBFOOEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x480F010", Offset = "0x480E210", VA = "0x18480F010")]
	public static double NDCOEEAJANC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x480ED20", Offset = "0x480DF20", VA = "0x18480ED20")]
	public static ulong GOFCJMMAPAJ(GLBGMJHFHJC BFIIJIPHHCL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct IDANNKFELPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint NIMPDDANGMH;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F3CC50", Offset = "0x1F3BE50", VA = "0x181F3CC50")]
	public IDANNKFELPM(float MENHNDLOJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3526D10", Offset = "0x3525F10", VA = "0x183526D10")]
	public GLBGMJHFHJC DPCBKBDHNLN()
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x849200", Offset = "0x848400", VA = "0x180849200")]
	public uint EFDEANHAMIH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3526CF0", Offset = "0x3525EF0", VA = "0x183526CF0")]
	public int BLKAIGHJFCM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3526F00", Offset = "0x3526100", VA = "0x183526F00")]
	public uint LDGMMOLKJNG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3526D80", Offset = "0x3525F80", VA = "0x183526D80")]
	public bool FMOPAIGGDAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3526D90", Offset = "0x3525F90", VA = "0x183526D90")]
	public void JIIBICJFEME(out GLBGMJHFHJC FCDIPAIAPMO, out GLBGMJHFHJC LAOALENPNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3526CB0", Offset = "0x3525EB0", VA = "0x183526CB0")]
	public bool BEOKKPAALKM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct GHNHJFKBKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong HPHGCIDMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short OOOFDLENOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short OEJFPAFMMFF;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x37F7C10", Offset = "0x37F6E10", VA = "0x1837F7C10")]
	public GHNHJFKBKPI(ulong HPHGCIDMIDE, short OOOFDLENOAG, short OEJFPAFMMFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class FOMBJKLNAEP
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly GHNHJFKBKPI[] HEOPIBNLADN;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x37F30F0", Offset = "0x37F22F0", VA = "0x1837F30F0")]
	public static void JGKCOHDFLFH(int PLMLDFAJCNE, int HFFKFKHGBNG, out GLBGMJHFHJC GDDHMMKKEKL, out int OEJFPAFMMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x37F3220", Offset = "0x37F2420", VA = "0x1837F3220")]
	public static void LMKMFMBCBPN(int EPOEBEENGGJ, out GLBGMJHFHJC GDDHMMKKEKL, out int LLCCLEJFDOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct BNBCEHLOABP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] NGIBJOEMFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int NDIGKIEANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int DGNBIHNPHOM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x37E57F0", Offset = "0x37E49F0", VA = "0x1837E57F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x9976E0", Offset = "0x9968E0", VA = "0x1809976E0")]
	public BNBCEHLOABP(byte[] NGIBJOEMFPL, int NDIGKIEANGO, int FDPDKPGBLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8491C0", Offset = "0x8483C0", VA = "0x1808491C0")]
	public int FDPDKPGBLAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x37E5830", Offset = "0x37E4A30", VA = "0x1837E5830")]
	public BNBCEHLOABP IJAKEAABDKF(int HOPJNOKJAMO, int HDKOIFJJLOP)
	{
		return default(BNBCEHLOABP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class JAOEIKMGONF
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] COLBBDAEMHJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] PBLBIGCNGPO;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int FEFIBCMHGGP;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3529A20", Offset = "0x3528C20", VA = "0x183529A20")]
	private static byte[] IHNNNNJBAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3529BB0", Offset = "0x3528DB0", VA = "0x183529BB0")]
	private static BNBCEHLOABP KADNBOGDFMD(BNBCEHLOABP OHNDJLPLBEI)
	{
		return default(BNBCEHLOABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3529B00", Offset = "0x3528D00", VA = "0x183529B00")]
	private static BNBCEHLOABP IKDAMNDDLLJ(BNBCEHLOABP OHNDJLPLBEI)
	{
		return default(BNBCEHLOABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3529960", Offset = "0x3528B60", VA = "0x183529960")]
	private static void FHAHGJOOBLI(BNBCEHLOABP OHNDJLPLBEI, int JOOPGOJGOHA, byte[] GKLJOBHCMPG, out int OGDMJADIMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x352A270", Offset = "0x3529470", VA = "0x18352A270")]
	private static void LLJKNJMOFLK(BNBCEHLOABP OHNDJLPLBEI, int JOOPGOJGOHA, byte[] OFKGJFNPNEO, int EPBIIAMHPAL, out BNBCEHLOABP DOOLPFKMLAF, out int NFLFKKANCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x352A670", Offset = "0x3529870", VA = "0x18352A670")]
	private static ulong OCIBBEALAPI(BNBCEHLOABP OHNDJLPLBEI, out int ECFHIKEFLPP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x352A520", Offset = "0x3529720", VA = "0x18352A520")]
	private static void NICBHLLOKCK(BNBCEHLOABP OHNDJLPLBEI, out GLBGMJHFHJC KCKMKGJDDEH, out int CFJCEABODEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x35295B0", Offset = "0x35287B0", VA = "0x1835295B0")]
	private static bool CIMKHINBEOJ(BNBCEHLOABP DOOLPFKMLAF, int JOOPGOJGOHA, out double KCKMKGJDDEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3529450", Offset = "0x3528650", VA = "0x183529450")]
	private static GLBGMJHFHJC CBGIDMGFCCM(int JOOPGOJGOHA)
	{
		return default(GLBGMJHFHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3529C60", Offset = "0x3528E60", VA = "0x183529C60")]
	private static bool KJEPBGDNCKK(BNBCEHLOABP OHNDJLPLBEI, int JOOPGOJGOHA, out double KCKMKGJDDEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x352A130", Offset = "0x3529330", VA = "0x18352A130")]
	private static bool LEOFHAPDDNA(BNBCEHLOABP DOOLPFKMLAF, int JOOPGOJGOHA, out double ODBHJEGAEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x352A000", Offset = "0x3529200", VA = "0x18352A000")]
	public static double? KKLGJGBCDCO(BNBCEHLOABP OHNDJLPLBEI, int JOOPGOJGOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3529270", Offset = "0x3528470", VA = "0x183529270")]
	public static float? BCBCKNBFCIF(BNBCEHLOABP OHNDJLPLBEI, int JOOPGOJGOHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct DCCAHCCCNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] OHNDJLPLBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int NAPMMJBBFDN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x37EAEC0", Offset = "0x37EA0C0", VA = "0x1837EAEC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9CB790", Offset = "0x9CA990", VA = "0x1809CB790")]
	public DCCAHCCCNFK(byte[] OHNDJLPLBEI, int NAPMMJBBFDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x37EAF00", Offset = "0x37EA100", VA = "0x1837EAF00")]
	public static DCCAHCCCNFK DGGJJMJKLMA(DCCAHCCCNFK EAHKFBMKAPP)
	{
		return default(DCCAHCCCNFK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x37EAF90", Offset = "0x37EA190", VA = "0x1837EAF90")]
	public static DCCAHCCCNFK HHCFMGIIAPI(DCCAHCCCNFK EAHKFBMKAPP, int FDPDKPGBLAK)
	{
		return default(DCCAHCCCNFK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x37EB0B0", Offset = "0x37EA2B0", VA = "0x1837EB0B0")]
	public static int PLIDCHNJEHM(DCCAHCCCNFK NFJBKPPLFPO, DCCAHCCCNFK PDNCJCJLEPL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x37EB030", Offset = "0x37EA230", VA = "0x1837EB030")]
	public static bool HNEKNABIJKP(DCCAHCCCNFK NFJBKPPLFPO, DCCAHCCCNFK PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x37EB090", Offset = "0x37EA290", VA = "0x1837EB090")]
	public static bool NPHBJLINCLE(DCCAHCCCNFK NFJBKPPLFPO, DCCAHCCCNFK PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x37EAFF0", Offset = "0x37EA1F0", VA = "0x1837EAFF0")]
	public static bool HNEKNABIJKP(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x37EB050", Offset = "0x37EA250", VA = "0x1837EB050")]
	public static bool NPHBJLINCLE(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x37EB050", Offset = "0x37EA250", VA = "0x1837EB050")]
	public static bool NPHBJLINCLE(DCCAHCCCNFK NFJBKPPLFPO, byte PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE80", Offset = "0x37EA080", VA = "0x1837EAE80")]
	public static bool CPHPCEDAPEI(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x37EAF50", Offset = "0x37EA150", VA = "0x1837EAF50")]
	public static bool HBBHAPPHNAG(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x37EAF10", Offset = "0x37EA110", VA = "0x1837EAF10")]
	public static bool EDDDFNOCBMC(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE40", Offset = "0x37EA040", VA = "0x1837EAE40")]
	public static bool ANIIMGMAJHG(DCCAHCCCNFK NFJBKPPLFPO, char PDNCJCJLEPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class AAIJKNEFECM
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] EOPCMMINAMI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] KCPECHGKJBB;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] ABHFOCOFEIO;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] EKMLGABDEGI;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] DBDHIOEKOCP;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int HGODOOJIJMM;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] KLGJDDFIBFN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int BCJJCLDCNBI;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x37E1A90", Offset = "0x37E0C90", VA = "0x1837E1A90")]
	private static byte[] OKCCJFKENMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x37E0540", Offset = "0x37DF740", VA = "0x1837E0540")]
	private static byte[] AJJIPPDECHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x37E1970", Offset = "0x37E0B70", VA = "0x1837E1970")]
	public static double MLEMKHHEKCJ(byte[] OHNDJLPLBEI, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x37E1660", Offset = "0x37E0860", VA = "0x1837E1660")]
	public static float BNMEGAGCLIB(byte[] OHNDJLPLBEI, int NAPMMJBBFDN, out int BAAOFICDIBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x37E1B70", Offset = "0x37E0D70", VA = "0x1837E1B70")]
	private static bool PPFGMEJLOKH(int CNMHAFPCMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x37E1840", Offset = "0x37E0A40", VA = "0x1837E1840")]
	private static bool LFKONCJEAMP(ref DCCAHCCCNFK KHLECJDLIMH, DCCAHCCCNFK EGKHKAOEMCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x37E1720", Offset = "0x37E0920", VA = "0x1837E1720")]
	private static bool KPJOMDKHNEH(ref DCCAHCCCNFK KHLECJDLIMH, DCCAHCCCNFK EGKHKAOEMCJ, byte[] FOIMLIIFHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x37E1A30", Offset = "0x37E0C30", VA = "0x1837E1A30")]
	private static bool OJDMCOPIKFJ(ref DCCAHCCCNFK BLPGAGKHJBI, byte[] IDFBJHKLGEA, int NAPMMJBBFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1138A10", Offset = "0x1137C10", VA = "0x181138A10")]
	private static double LAKKBHPEKIC(bool PGNKMMLNJPM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x37E0620", Offset = "0x37DF820", VA = "0x1837E0620")]
	private static double BDPPDHHAIAJ(DCCAHCCCNFK FHJMOAJFJEG, int FDPDKPGBLAK, bool EAJJMCJFHCF, out int PGNPIOMNGDO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class ADCAPJAOLLE<T> : global::CMLDAFIIOAH<T[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::NOECIIOLHHE<T> FCEFMALGMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly ACMGGDIBBBG JCBJACHIDMM;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2E38CE0", Offset = "0x2E37EE0", VA = "0x182E38CE0")]
	public ADCAPJAOLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DC10", Offset = "0x1D6CE10", VA = "0x181D6DC10")]
	public ADCAPJAOLLE(ACMGGDIBBBG JCBJACHIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2E36810", Offset = "0x2E35A10", VA = "0x182E36810", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, T[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2E37280", Offset = "0x2E36480", VA = "0x182E37280", Slot = "5")]
	public T[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class KELCAHKAICL<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::NOECIIOLHHE<T> FCEFMALGMIJ;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class JMLMHIIBBBJ<T> : global::CMLDAFIIOAH<List<T>>, DOCJLNHANHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly ACMGGDIBBBG JCBJACHIDMM;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2E38CE0", Offset = "0x2E37EE0", VA = "0x182E38CE0")]
	public JMLMHIIBBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DC10", Offset = "0x1D6CE10", VA = "0x181D6DC10")]
	public JMLMHIIBBBJ(ACMGGDIBBBG JCBJACHIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3220230", Offset = "0x321F430", VA = "0x183220230", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, List<T> LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3221630", Offset = "0x3220830", VA = "0x183221630", Slot = "5")]
	public List<T> BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class CKEOBDDADMI<TElement, TIntermediate, TEnumerator, TCollection> : global::CMLDAFIIOAH<TCollection>, DOCJLNHANHK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA46C0", Offset = "0x2BA38C0", VA = "0x182BA46C0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, TCollection LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA56E0", Offset = "0x2BA48E0", VA = "0x182BA56E0", Slot = "5")]
	public TCollection BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HHALJECIAGI(TCollection GKDMFJGFBLN);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFDAKPCHIOJ();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void FKEGKEHNDJG(ref TIntermediate MJLFANGMNMK, int OHJLAHMBLMG, TElement LDPMPDNIHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NEIHCBLCFCI(ref TIntermediate DMKNPLIKANG);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	protected CKEOBDDADMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class HIBOBIOKPHD<TElement, TIntermediate, TCollection> : global::CKEOBDDADMI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2BA29D0", Offset = "0x2BA1BD0", VA = "0x182BA29D0", Slot = "6")]
	protected override IEnumerator<TElement> HHALJECIAGI(TCollection GKDMFJGFBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2314460", Offset = "0x2313660", VA = "0x182314460")]
	protected HIBOBIOKPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class FFLHMOLNHCC<TElement, TCollection> : global::HIBOBIOKPHD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected sealed override TCollection NEIHCBLCFCI(ref TCollection DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ILINELDPJNB<TElement, TCollection> : global::FFLHMOLNHCC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x26A2530", Offset = "0x26A1730", VA = "0x1826A2530", Slot = "7")]
	protected override TCollection MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x26A24C0", Offset = "0x26A16C0", VA = "0x1826A24C0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref TCollection MJLFANGMNMK, int OHJLAHMBLMG, TElement LDPMPDNIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class LGDFEGFCBAB<T> : global::CKEOBDDADMI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FED0", Offset = "0x2C6F0D0", VA = "0x182C6FED0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref LinkedList<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override LinkedList<T> NEIHCBLCFCI(ref LinkedList<T> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override LinkedList<T> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2E556F0", Offset = "0x2E548F0", VA = "0x182E556F0", Slot = "6")]
	protected override LinkedList<T>.Enumerator HHALJECIAGI(LinkedList<T> GKDMFJGFBLN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class IPELOIACLEH<T> : global::CKEOBDDADMI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FED0", Offset = "0x2C6F0D0", VA = "0x182C6FED0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref Queue<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override Queue<T> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FF10", Offset = "0x2C6F110", VA = "0x182C6FF10", Slot = "6")]
	protected override Queue<T>.Enumerator HHALJECIAGI(Queue<T> GKDMFJGFBLN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override Queue<T> NEIHCBLCFCI(ref Queue<T> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class PCLHABKNLPB<T> : global::CKEOBDDADMI<T, global::AJIAPMNFGPH<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA60", Offset = "0x2E4CC60", VA = "0x182E4DA60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref global::AJIAPMNFGPH<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA90", Offset = "0x2E4CC90", VA = "0x182E4DA90", Slot = "7")]
	protected override global::AJIAPMNFGPH<T> MFDAKPCHIOJ()
	{
		return default(global::AJIAPMNFGPH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FF10", Offset = "0x2C6F110", VA = "0x182C6FF10", Slot = "6")]
	protected override Stack<T>.Enumerator HHALJECIAGI(Stack<T> GKDMFJGFBLN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x31FB660", Offset = "0x31FA860", VA = "0x1831FB660", Slot = "9")]
	protected override Stack<T> NEIHCBLCFCI(ref global::AJIAPMNFGPH<T> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AOFMCJCJIPN<T> : global::CKEOBDDADMI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FED0", Offset = "0x2C6F0D0", VA = "0x182C6FED0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref HashSet<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override HashSet<T> NEIHCBLCFCI(ref HashSet<T> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override HashSet<T> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FF10", Offset = "0x2C6F110", VA = "0x182C6FF10", Slot = "6")]
	protected override HashSet<T>.Enumerator HHALJECIAGI(HashSet<T> GKDMFJGFBLN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NPHPINHOIEJ<T> : global::HIBOBIOKPHD<T, global::AJIAPMNFGPH<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA60", Offset = "0x2E4CC60", VA = "0x182E4DA60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref global::AJIAPMNFGPH<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x43C3810", Offset = "0x43C2A10", VA = "0x1843C3810", Slot = "9")]
	protected override ReadOnlyCollection<T> NEIHCBLCFCI(ref global::AJIAPMNFGPH<T> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x43C37C0", Offset = "0x43C29C0", VA = "0x1843C37C0", Slot = "7")]
	protected override global::AJIAPMNFGPH<T> MFDAKPCHIOJ()
	{
		return default(global::AJIAPMNFGPH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class HJLKCPLEPKO<T> : global::HIBOBIOKPHD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FED0", Offset = "0x2C6F0D0", VA = "0x182C6FED0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref List<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override List<T> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override IList<T> NEIHCBLCFCI(ref List<T> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MHBAJGLJDOE<T> : global::HIBOBIOKPHD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FED0", Offset = "0x2C6F0D0", VA = "0x182C6FED0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref List<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override List<T> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override ICollection<T> NEIHCBLCFCI(ref List<T> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JGKICOKGMNG<T> : global::HIBOBIOKPHD<T, global::AJIAPMNFGPH<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA60", Offset = "0x2E4CC60", VA = "0x182E4DA60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref global::AJIAPMNFGPH<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA90", Offset = "0x2E4CC90", VA = "0x182E4DA90", Slot = "7")]
	protected override global::AJIAPMNFGPH<T> MFDAKPCHIOJ()
	{
		return default(global::AJIAPMNFGPH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3A2AEA0", Offset = "0x3A2A0A0", VA = "0x183A2AEA0", Slot = "9")]
	protected override IEnumerable<T> NEIHCBLCFCI(ref global::AJIAPMNFGPH<T> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class IKLBDDKBIBP<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class BGILBINAKDC<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class LDCHENEALNM<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class ALCLGKOKLNA : global::CMLDAFIIOAH<IEnumerable>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::CMLDAFIIOAH<IEnumerable> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x37E2D50", Offset = "0x37E1F50", VA = "0x1837E2D50", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, IEnumerable LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x37E2FB0", Offset = "0x37E21B0", VA = "0x1837E2FB0", Slot = "5")]
	public IEnumerable BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public ALCLGKOKLNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class CKLMMFJPFKJ : global::CMLDAFIIOAH<ICollection>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::CMLDAFIIOAH<ICollection> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x37E63F0", Offset = "0x37E55F0", VA = "0x1837E63F0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ICollection LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x37E6750", Offset = "0x37E5950", VA = "0x1837E6750", Slot = "5")]
	public ICollection BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public CKLMMFJPFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CJANIANHAOJ : global::CMLDAFIIOAH<IList>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::CMLDAFIIOAH<IList> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x37E5C70", Offset = "0x37E4E70", VA = "0x1837E5C70", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, IList LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x37E5FB0", Offset = "0x37E51B0", VA = "0x1837E5FB0", Slot = "5")]
	public IList BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public CJANIANHAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KILJFONIJAL<T> : global::HIBOBIOKPHD<T, global::AJIAPMNFGPH<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA30", Offset = "0x2E4CC30", VA = "0x182E4DA30", Slot = "8")]
	protected override void FKEGKEHNDJG(ref global::AJIAPMNFGPH<T> MJLFANGMNMK, int OHJLAHMBLMG, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DA90", Offset = "0x2E4CC90", VA = "0x182E4DA90", Slot = "7")]
	protected override global::AJIAPMNFGPH<T> MFDAKPCHIOJ()
	{
		return default(global::AJIAPMNFGPH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DAE0", Offset = "0x2E4CCE0", VA = "0x182E4DAE0", Slot = "9")]
	protected override IReadOnlyList<T> NEIHCBLCFCI(ref global::AJIAPMNFGPH<T> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1D73A90", Offset = "0x1D72C90", VA = "0x181D73A90")]
	public KILJFONIJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JNFJLAIJIJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x352B960", Offset = "0x352AB60", VA = "0x18352B960")]
	public static DateTime BEJJJBBCJBH(DateTime IDEECEJCPGH)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class DAPNBFIJDGJ : global::CMLDAFIIOAH<DateTime>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::CMLDAFIIOAH<DateTime> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x37E8BD0", Offset = "0x37E7DD0", VA = "0x1837E8BD0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, DateTime LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x37E9860", Offset = "0x37E8A60", VA = "0x1837E9860", Slot = "5")]
	public DateTime BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public DAPNBFIJDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class IMLCLBJAKDE : global::CMLDAFIIOAH<DateTimeOffset>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::CMLDAFIIOAH<DateTimeOffset> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3527B10", Offset = "0x3526D10", VA = "0x183527B10", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, DateTimeOffset LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3527EE0", Offset = "0x35270E0", VA = "0x183527EE0", Slot = "5")]
	public DateTimeOffset BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IMLCLBJAKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HLNJMIHDIGG : global::CMLDAFIIOAH<TimeSpan>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::CMLDAFIIOAH<TimeSpan> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] HOKMALNGBAC;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x351CDD0", Offset = "0x351BFD0", VA = "0x18351CDD0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, TimeSpan LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x351D090", Offset = "0x351C290", VA = "0x18351D090", Slot = "5")]
	public TimeSpan BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public HLNJMIHDIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AEJDGILGNIO<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CMLDAFIIOAH<TDictionary>, DOCJLNHANHK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A800", Offset = "0x2E39A00", VA = "0x182E3A800", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, TDictionary LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C0E0", Offset = "0x2E3B2E0", VA = "0x182E3C0E0", Slot = "5")]
	public TDictionary BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HHALJECIAGI(TDictionary GKDMFJGFBLN);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFDAKPCHIOJ();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void FKEGKEHNDJG(ref TIntermediate MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NEIHCBLCFCI(ref TIntermediate DMKNPLIKANG);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	protected AEJDGILGNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class CIKMPFCIPPD<TKey, TValue, TIntermediate, TDictionary> : global::AEJDGILGNIO<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA29D0", Offset = "0x2BA1BD0", VA = "0x182BA29D0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HHALJECIAGI(TDictionary GKDMFJGFBLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class BKECIOFFILB<TKey, TValue, TDictionary> : global::CIKMPFCIPPD<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override TDictionary NEIHCBLCFCI(ref TDictionary DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class FONBNGJBMMK<TKey, TValue> : global::AEJDGILGNIO<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3C951C0", Offset = "0x3C943C0", VA = "0x183C951C0", Slot = "8")]
	protected override void FKEGKEHNDJG(ref Dictionary<TKey, TValue> MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override Dictionary<TKey, TValue> NEIHCBLCFCI(ref Dictionary<TKey, TValue> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3C95200", Offset = "0x3C94400", VA = "0x183C95200", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HHALJECIAGI(Dictionary<TKey, TValue> GKDMFJGFBLN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1D76D60", Offset = "0x1D75F60", VA = "0x181D76D60")]
	public FONBNGJBMMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PKLLNMGOHOE<TKey, TValue, TDictionary> : global::BKECIOFFILB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3829510", Offset = "0x3828710", VA = "0x183829510", Slot = "8")]
	protected override void FKEGKEHNDJG(ref TDictionary MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2A77AE0", Offset = "0x2A76CE0", VA = "0x182A77AE0", Slot = "7")]
	protected override TDictionary MFDAKPCHIOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class AHAGKDJEJIA<TKey, TValue> : global::CIKMPFCIPPD<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1F09B60", Offset = "0x1F08D60", VA = "0x181F09B60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref Dictionary<TKey, TValue> MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override IDictionary<TKey, TValue> NEIHCBLCFCI(ref Dictionary<TKey, TValue> DMKNPLIKANG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class CKMDPDIAJPD<TKey, TValue> : global::BKECIOFFILB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x1F09B60", Offset = "0x1F08D60", VA = "0x181F09B60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref SortedList<TKey, TValue> MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override SortedList<TKey, TValue> MFDAKPCHIOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class EPJEKDHBNLB<TKey, TValue> : global::AEJDGILGNIO<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x1F09B60", Offset = "0x1F08D60", VA = "0x181F09B60", Slot = "8")]
	protected override void FKEGKEHNDJG(ref SortedDictionary<TKey, TValue> MJLFANGMNMK, int OHJLAHMBLMG, TKey ICIBGJCBOAM, TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DF0", Offset = "0x10C7FF0", VA = "0x1810C8DF0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NEIHCBLCFCI(ref SortedDictionary<TKey, TValue> DMKNPLIKANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1F09BA0", Offset = "0x1F08DA0", VA = "0x181F09BA0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> MFDAKPCHIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x273EF10", Offset = "0x273E110", VA = "0x18273EF10", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HHALJECIAGI(SortedDictionary<TKey, TValue> GKDMFJGFBLN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class ONDGIGIMCCB<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class AADMICLDBFH : global::CMLDAFIIOAH<IDictionary>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::CMLDAFIIOAH<IDictionary> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x37DFEB0", Offset = "0x37DF0B0", VA = "0x1837DFEB0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, IDictionary LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x37E0340", Offset = "0x37DF540", VA = "0x1837E0340", Slot = "5")]
	public IDictionary BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public AADMICLDBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class HIAADCIIJJD : global::CMLDAFIIOAH<object>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void BBEKBPGBIFB(object CDELFIGEFFA, ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::MDKPJEMIGJL<KeyValuePair<object, BBEKBPGBIFB>> FLBDHJAMGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly PGDAFACPPLB[] DKBGLHDECII;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x351CC00", Offset = "0x351BE00", VA = "0x18351CC00")]
	public HIAADCIIJJD(params PGDAFACPPLB[] DKBGLHDECII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x351C3A0", Offset = "0x351B5A0", VA = "0x18351C3A0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x351CB70", Offset = "0x351BD70", VA = "0x18351CB70", Slot = "5")]
	public object BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class HPPDNCEMIHE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x351DB20", Offset = "0x351CD20", VA = "0x18351DB20")]
	public static object BKBGCLHAIMM(Type ALJEFDPBPKG, out bool HONOIHJOFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x351E300", Offset = "0x351D500", VA = "0x18351E300")]
	public static object DHNPJKIIANP(Type ALJEFDPBPKG, out bool HONOIHJOFLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class NCMCLOGLFGF<T> : global::CMLDAFIIOAH<T>, DOCJLNHANHK, global::OFANMGKEMBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class PLMGBHADNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public PLMGBHADNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3FD08B0", Offset = "0x3FCFAB0", VA = "0x183FD08B0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class DOGBMDNJOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::NKJAGJGCPIN<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public DOGBMDNJOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7250", Offset = "0x3FB6450", VA = "0x183FB7250")]
		internal void <.cctor>b__1(ref FLKJBKMANKH writer, T value, PGDAFACPPLB _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class PEAPKOHAMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::IHKEBIIAECE<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public PEAPKOHAMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF230", Offset = "0x3FCE430", VA = "0x183FCF230")]
		internal T <.cctor>b__2(ref NMBHIAJGIPN reader, PGDAFACPPLB _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::NGHFLFCOJMD<T> KEDJLDNDHMF;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> FJBHAAMCGFP;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::NKJAGJGCPIN<T> JEDHKDGOLAO;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::IHKEBIIAECE<T> MADHBBJKFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool DNOLAOCIIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::NKJAGJGCPIN<T> KMBLDAIOMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::IHKEBIIAECE<T> BKBLMFNALAF;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC9560", Offset = "0x3FC8760", VA = "0x183FC9560")]
	static NCMCLOGLFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEC50", Offset = "0x3FCDE50", VA = "0x183FCEC50")]
	public NCMCLOGLFGF(bool DNOLAOCIIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9B70", Offset = "0x3FB8D70", VA = "0x183FB9B70", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE2B0", Offset = "0x3FBD4B0", VA = "0x183FBE2B0", Slot = "5")]
	public T BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3FBF120", Offset = "0x3FBE320", VA = "0x183FBF120", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, T LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB380", Offset = "0x3FBA580", VA = "0x183FBB380", Slot = "7")]
	public T AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class HKNLAMMPPPB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class EJLFCHLCHAK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class PDLBHIEADIC<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PJNGKHLNOOH<T> : global::CMLDAFIIOAH<T?>, DOCJLNHANHK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3828F80", Offset = "0x3828180", VA = "0x183828F80", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, T? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3829210", Offset = "0x3828410", VA = "0x183829210", Slot = "5")]
	public T? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	public PJNGKHLNOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class LIOMFIECLAI<T> : global::CMLDAFIIOAH<T?>, DOCJLNHANHK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::CMLDAFIIOAH<T> IJBGBMNEAEL;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
	public LIOMFIECLAI(global::CMLDAFIIOAH<T> IJBGBMNEAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7DD40", Offset = "0x2D7CF40", VA = "0x182D7DD40", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, T? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7DFE0", Offset = "0x2D7D1E0", VA = "0x182D7DFE0", Slot = "5")]
	public T? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class NBIIHLGADFC : global::CMLDAFIIOAH<sbyte>, DOCJLNHANHK, global::OFANMGKEMBP<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly NBIIHLGADFC GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4810EC0", Offset = "0x48100C0", VA = "0x184810EC0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, sbyte LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4810F50", Offset = "0x4810150", VA = "0x184810F50", Slot = "5")]
	public sbyte BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4810FA0", Offset = "0x48101A0", VA = "0x184810FA0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, sbyte LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4810EE0", Offset = "0x48100E0", VA = "0x184810EE0", Slot = "7")]
	public sbyte AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public NBIIHLGADFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class GMFDKKMGLAN : global::CMLDAFIIOAH<sbyte?>, DOCJLNHANHK, global::OFANMGKEMBP<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly GMFDKKMGLAN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x37F8170", Offset = "0x37F7370", VA = "0x1837F8170", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, sbyte? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x37F82D0", Offset = "0x37F74D0", VA = "0x1837F82D0", Slot = "5")]
	public sbyte? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x37F8340", Offset = "0x37F7540", VA = "0x1837F8340", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, sbyte? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x37F81F0", Offset = "0x37F73F0", VA = "0x1837F81F0", Slot = "7")]
	public sbyte? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GMFDKKMGLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class EKONIKELNDP : global::CMLDAFIIOAH<sbyte[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly EKONIKELNDP GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x37F04F0", Offset = "0x37EF6F0", VA = "0x1837F04F0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, sbyte[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x37F0690", Offset = "0x37EF890", VA = "0x1837F0690", Slot = "5")]
	public sbyte[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public EKONIKELNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GCGECDLDFPP : global::CMLDAFIIOAH<short>, DOCJLNHANHK, global::OFANMGKEMBP<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly GCGECDLDFPP GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x37F5170", Offset = "0x37F4370", VA = "0x1837F5170", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, short LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x37F5250", Offset = "0x37F4450", VA = "0x1837F5250", Slot = "5")]
	public short BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x37F5260", Offset = "0x37F4460", VA = "0x1837F5260", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, short LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x37F51B0", Offset = "0x37F43B0", VA = "0x1837F51B0", Slot = "7")]
	public short AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GCGECDLDFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class MGEGCCNBELA : global::CMLDAFIIOAH<short?>, DOCJLNHANHK, global::OFANMGKEMBP<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly MGEGCCNBELA GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x480E7B0", Offset = "0x480D9B0", VA = "0x18480E7B0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, short? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x480E8C0", Offset = "0x480DAC0", VA = "0x18480E8C0", Slot = "5")]
	public short? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x480E970", Offset = "0x480DB70", VA = "0x18480E970", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, short? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x480E820", Offset = "0x480DA20", VA = "0x18480E820", Slot = "7")]
	public short? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public MGEGCCNBELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class FEHJMCCJGEL : global::CMLDAFIIOAH<short[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly FEHJMCCJGEL GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x37F1760", Offset = "0x37F0960", VA = "0x1837F1760", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, short[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x37F1900", Offset = "0x37F0B00", VA = "0x1837F1900", Slot = "5")]
	public short[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public FEHJMCCJGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class LKGLIEMJDND : global::CMLDAFIIOAH<int>, DOCJLNHANHK, global::OFANMGKEMBP<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LKGLIEMJDND GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x480DE10", Offset = "0x480D010", VA = "0x18480DE10", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, int LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x480DE90", Offset = "0x480D090", VA = "0x18480DE90", Slot = "5")]
	public int BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x480DEF0", Offset = "0x480D0F0", VA = "0x18480DEF0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, int LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x480DE20", Offset = "0x480D020", VA = "0x18480DE20", Slot = "7")]
	public int AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public LKGLIEMJDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class DNAKKJNAHKF : global::CMLDAFIIOAH<int?>, DOCJLNHANHK, global::OFANMGKEMBP<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly DNAKKJNAHKF GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x37EB760", Offset = "0x37EA960", VA = "0x1837EB760", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, int? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x37EB8B0", Offset = "0x37EAAB0", VA = "0x1837EB8B0", Slot = "5")]
	public int? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x37EB920", Offset = "0x37EAB20", VA = "0x1837EB920", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, int? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x37EB7E0", Offset = "0x37EA9E0", VA = "0x1837EB7E0", Slot = "7")]
	public int? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public DNAKKJNAHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class ELCNDIBGBNO : global::CMLDAFIIOAH<int[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ELCNDIBGBNO GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x37F0830", Offset = "0x37EFA30", VA = "0x1837F0830", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, int[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x37F09D0", Offset = "0x37EFBD0", VA = "0x1837F09D0", Slot = "5")]
	public int[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public ELCNDIBGBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class OEODIOOLNFN : global::CMLDAFIIOAH<long>, DOCJLNHANHK, global::OFANMGKEMBP<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly OEODIOOLNFN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4816DA0", Offset = "0x4815FA0", VA = "0x184816DA0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, long LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4816E30", Offset = "0x4816030", VA = "0x184816E30", Slot = "5")]
	public long BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4816E40", Offset = "0x4816040", VA = "0x184816E40", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, long LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4816DC0", Offset = "0x4815FC0", VA = "0x184816DC0", Slot = "7")]
	public long AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OEODIOOLNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class LBIKNHHMILP : global::CMLDAFIIOAH<long?>, DOCJLNHANHK, global::OFANMGKEMBP<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LBIKNHHMILP GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x480CF00", Offset = "0x480C100", VA = "0x18480CF00", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, long? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x480D030", Offset = "0x480C230", VA = "0x18480D030", Slot = "5")]
	public long? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x480D0C0", Offset = "0x480C2C0", VA = "0x18480D0C0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, long? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x480CF70", Offset = "0x480C170", VA = "0x18480CF70", Slot = "7")]
	public long? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public LBIKNHHMILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class GFBMCMDDBLO : global::CMLDAFIIOAH<long[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly GFBMCMDDBLO GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x37F5AF0", Offset = "0x37F4CF0", VA = "0x1837F5AF0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, long[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x37F5C90", Offset = "0x37F4E90", VA = "0x1837F5C90", Slot = "5")]
	public long[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GFBMCMDDBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class NHKAMLEEGNN : global::CMLDAFIIOAH<byte>, DOCJLNHANHK, global::OFANMGKEMBP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly NHKAMLEEGNN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4811880", Offset = "0x4810A80", VA = "0x184811880", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, byte LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4811910", Offset = "0x4810B10", VA = "0x184811910", Slot = "5")]
	public byte BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4811970", Offset = "0x4810B70", VA = "0x184811970", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, byte LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x48118A0", Offset = "0x4810AA0", VA = "0x1848118A0", Slot = "7")]
	public byte AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public NHKAMLEEGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class GLELDDIKHFE : global::CMLDAFIIOAH<byte?>, DOCJLNHANHK, global::OFANMGKEMBP<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly GLELDDIKHFE GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x37F7E40", Offset = "0x37F7040", VA = "0x1837F7E40", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, byte? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x37F7FA0", Offset = "0x37F71A0", VA = "0x1837F7FA0", Slot = "5")]
	public byte? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x37F8010", Offset = "0x37F7210", VA = "0x1837F8010", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, byte? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x37F7EC0", Offset = "0x37F70C0", VA = "0x1837F7EC0", Slot = "7")]
	public byte? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GLELDDIKHFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class GAINMFIPOAA : global::CMLDAFIIOAH<ushort>, DOCJLNHANHK, global::OFANMGKEMBP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly GAINMFIPOAA GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x37F4DE0", Offset = "0x37F3FE0", VA = "0x1837F4DE0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ushort LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x37F4EC0", Offset = "0x37F40C0", VA = "0x1837F4EC0", Slot = "5")]
	public ushort BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x37F4ED0", Offset = "0x37F40D0", VA = "0x1837F4ED0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, ushort LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x37F4E20", Offset = "0x37F4020", VA = "0x1837F4E20", Slot = "7")]
	public ushort AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GAINMFIPOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class NCAFIOHCLJI : global::CMLDAFIIOAH<ushort?>, DOCJLNHANHK, global::OFANMGKEMBP<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NCAFIOHCLJI GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4811180", Offset = "0x4810380", VA = "0x184811180", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ushort? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4811290", Offset = "0x4810490", VA = "0x184811290", Slot = "5")]
	public ushort? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4811340", Offset = "0x4810540", VA = "0x184811340", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, ushort? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x48111F0", Offset = "0x48103F0", VA = "0x1848111F0", Slot = "7")]
	public ushort? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public NCAFIOHCLJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class IDJLCOEEALJ : global::CMLDAFIIOAH<ushort[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IDJLCOEEALJ GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3526F20", Offset = "0x3526120", VA = "0x183526F20", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ushort[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3526FE0", Offset = "0x35261E0", VA = "0x183526FE0", Slot = "5")]
	public ushort[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IDJLCOEEALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class IBOLCEEBOPN : global::CMLDAFIIOAH<uint>, DOCJLNHANHK, global::OFANMGKEMBP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IBOLCEEBOPN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3526B80", Offset = "0x3525D80", VA = "0x183526B80", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, uint LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3526C00", Offset = "0x3525E00", VA = "0x183526C00", Slot = "5")]
	public uint BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3526C10", Offset = "0x3525E10", VA = "0x183526C10", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, uint LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3526B90", Offset = "0x3525D90", VA = "0x183526B90", Slot = "7")]
	public uint AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IBOLCEEBOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KDEKFKPEJOP : global::CMLDAFIIOAH<uint?>, DOCJLNHANHK, global::OFANMGKEMBP<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KDEKFKPEJOP GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x480AB30", Offset = "0x4809D30", VA = "0x18480AB30", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, uint? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x480AC40", Offset = "0x4809E40", VA = "0x18480AC40", Slot = "5")]
	public uint? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x480ACF0", Offset = "0x4809EF0", VA = "0x18480ACF0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, uint? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x480ABA0", Offset = "0x4809DA0", VA = "0x18480ABA0", Slot = "7")]
	public uint? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public KDEKFKPEJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class GHCGIGICIEC : global::CMLDAFIIOAH<uint[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GHCGIGICIEC GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x37F78D0", Offset = "0x37F6AD0", VA = "0x1837F78D0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, uint[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x37F7A70", Offset = "0x37F6C70", VA = "0x1837F7A70", Slot = "5")]
	public uint[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GHCGIGICIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class FAAFGMICMMN : global::CMLDAFIIOAH<ulong>, DOCJLNHANHK, global::OFANMGKEMBP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly FAAFGMICMMN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x37F0F70", Offset = "0x37F0170", VA = "0x1837F0F70", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ulong LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x37F1010", Offset = "0x37F0210", VA = "0x1837F1010", Slot = "5")]
	public ulong BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x37F1020", Offset = "0x37F0220", VA = "0x1837F1020", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, ulong LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x37F0FA0", Offset = "0x37F01A0", VA = "0x1837F0FA0", Slot = "7")]
	public ulong AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public FAAFGMICMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class IAHNKBEJOPM : global::CMLDAFIIOAH<ulong?>, DOCJLNHANHK, global::OFANMGKEMBP<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly IAHNKBEJOPM GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x3526830", Offset = "0x3525A30", VA = "0x183526830", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ulong? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x3526960", Offset = "0x3525B60", VA = "0x183526960", Slot = "5")]
	public ulong? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x35269F0", Offset = "0x3525BF0", VA = "0x1835269F0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, ulong? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x35268A0", Offset = "0x3525AA0", VA = "0x1835268A0", Slot = "7")]
	public ulong? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IAHNKBEJOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EHGKNNNKANJ : global::CMLDAFIIOAH<ulong[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EHGKNNNKANJ GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x37EE280", Offset = "0x37ED480", VA = "0x1837EE280", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ulong[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x37EE420", Offset = "0x37ED620", VA = "0x1837EE420", Slot = "5")]
	public ulong[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public EHGKNNNKANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BENKHLFOCHB : global::CMLDAFIIOAH<float>, DOCJLNHANHK, global::OFANMGKEMBP<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly BENKHLFOCHB GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x37E3FD0", Offset = "0x37E31D0", VA = "0x1837E3FD0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, float LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x37E4110", Offset = "0x37E3310", VA = "0x1837E4110", Slot = "5")]
	public float BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x37E4120", Offset = "0x37E3320", VA = "0x1837E4120", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, float LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x37E3FE0", Offset = "0x37E31E0", VA = "0x1837E3FE0", Slot = "7")]
	public float AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BENKHLFOCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class MCKKCLCODJC : global::CMLDAFIIOAH<float?>, DOCJLNHANHK, global::OFANMGKEMBP<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MCKKCLCODJC GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x480E550", Offset = "0x480D750", VA = "0x18480E550", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, float? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x480E660", Offset = "0x480D860", VA = "0x18480E660", Slot = "5")]
	public float? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x480E6D0", Offset = "0x480D8D0", VA = "0x18480E6D0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, float? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x480E5C0", Offset = "0x480D7C0", VA = "0x18480E5C0", Slot = "7")]
	public float? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public MCKKCLCODJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IAGCLIFIKDN : global::CMLDAFIIOAH<float[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IAGCLIFIKDN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x351EAE0", Offset = "0x351DCE0", VA = "0x18351EAE0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, float[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x351EBA0", Offset = "0x351DDA0", VA = "0x18351EBA0", Slot = "5")]
	public float[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IAGCLIFIKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GGODPINCGKE : global::CMLDAFIIOAH<double>, DOCJLNHANHK, global::OFANMGKEMBP<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GGODPINCGKE GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x37F5F70", Offset = "0x37F5170", VA = "0x1837F5F70", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, double LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x37F5FF0", Offset = "0x37F51F0", VA = "0x1837F5FF0", Slot = "5")]
	public double BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x37F6000", Offset = "0x37F5200", VA = "0x1837F6000", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, double LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x37F5F80", Offset = "0x37F5180", VA = "0x1837F5F80", Slot = "7")]
	public double AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public GGODPINCGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BPPLOOADHAE : global::CMLDAFIIOAH<double?>, DOCJLNHANHK, global::OFANMGKEMBP<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly BPPLOOADHAE GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x37E5890", Offset = "0x37E4A90", VA = "0x1837E5890", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, double? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x37E59C0", Offset = "0x37E4BC0", VA = "0x1837E59C0", Slot = "5")]
	public double? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x37E5A50", Offset = "0x37E4C50", VA = "0x1837E5A50", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, double? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x37E5900", Offset = "0x37E4B00", VA = "0x1837E5900", Slot = "7")]
	public double? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BPPLOOADHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class BMIDFFPJODD : global::CMLDAFIIOAH<double[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BMIDFFPJODD GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x37E5390", Offset = "0x37E4590", VA = "0x1837E5390", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, double[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x37E5510", Offset = "0x37E4710", VA = "0x1837E5510", Slot = "5")]
	public double[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BMIDFFPJODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class ECJGDIJLINA : global::CMLDAFIIOAH<bool>, DOCJLNHANHK, global::OFANMGKEMBP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly ECJGDIJLINA GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x37EC260", Offset = "0x37EB460", VA = "0x1837EC260", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, bool LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x37EC2F0", Offset = "0x37EB4F0", VA = "0x1837EC2F0", Slot = "5")]
	public bool BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x37EC300", Offset = "0x37EB500", VA = "0x1837EC300", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, bool LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x37EC280", Offset = "0x37EB480", VA = "0x1837EC280", Slot = "7")]
	public bool AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public ECJGDIJLINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class OOOIMKKHMEJ : global::CMLDAFIIOAH<bool?>, DOCJLNHANHK, global::OFANMGKEMBP<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly OOOIMKKHMEJ GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4817A00", Offset = "0x4816C00", VA = "0x184817A00", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, bool? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4817B20", Offset = "0x4816D20", VA = "0x184817B20", Slot = "5")]
	public bool? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4817B90", Offset = "0x4816D90", VA = "0x184817B90", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, bool? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4817A70", Offset = "0x4816C70", VA = "0x184817A70", Slot = "7")]
	public bool? AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OOOIMKKHMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class KJAICIIIIBL : global::CMLDAFIIOAH<bool[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly KJAICIIIIBL GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x480ADD0", Offset = "0x4809FD0", VA = "0x18480ADD0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, bool[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x480AEA0", Offset = "0x480A0A0", VA = "0x18480AEA0", Slot = "5")]
	public bool[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public KJAICIIIIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JNKMFINOIOL : global::CMLDAFIIOAH<object>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::CMLDAFIIOAH<object> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> CLMCNJLFBGB;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x352BA00", Offset = "0x352AC00", VA = "0x18352BA00", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, object LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x352C350", Offset = "0x352B550", VA = "0x18352C350", Slot = "5")]
	public object BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JNKMFINOIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class OEOHNDFEHLH : global::CMLDAFIIOAH<byte[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::CMLDAFIIOAH<byte[]> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4816EE0", Offset = "0x48160E0", VA = "0x184816EE0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, byte[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4816F70", Offset = "0x4816170", VA = "0x184816F70", Slot = "5")]
	public byte[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OEOHNDFEHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class NDGECBAMOCJ : global::CMLDAFIIOAH<ArraySegment<byte>>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::CMLDAFIIOAH<ArraySegment<byte>> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4811600", Offset = "0x4810800", VA = "0x184811600", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, ArraySegment<byte> LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x48116A0", Offset = "0x48108A0", VA = "0x1848116A0", Slot = "5")]
	public ArraySegment<byte> BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public NDGECBAMOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JMFBCOCHJBG : global::CMLDAFIIOAH<string>, DOCJLNHANHK, global::OFANMGKEMBP<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::CMLDAFIIOAH<string> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x352B790", Offset = "0x352A990", VA = "0x18352B790", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, string LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x352B7B0", Offset = "0x352A9B0", VA = "0x18352B7B0", Slot = "5")]
	public string BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x352B790", Offset = "0x352A990", VA = "0x18352B790", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, string LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x352B7B0", Offset = "0x352A9B0", VA = "0x18352B7B0", Slot = "7")]
	public string AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JMFBCOCHJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class AEBFFBOCFDD : global::CMLDAFIIOAH<string[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly AEBFFBOCFDD GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x37E2050", Offset = "0x37E1250", VA = "0x1837E2050", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, string[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x37E21D0", Offset = "0x37E13D0", VA = "0x1837E21D0", Slot = "5")]
	public string[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public AEBFFBOCFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class OOMGHJCAABG : global::CMLDAFIIOAH<char>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly OOMGHJCAABG GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x48178F0", Offset = "0x4816AF0", VA = "0x1848178F0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, char LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4817970", Offset = "0x4816B70", VA = "0x184817970", Slot = "5")]
	public char BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OOMGHJCAABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class BDPDJMNCIFN : global::CMLDAFIIOAH<char?>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly BDPDJMNCIFN GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x37E3DE0", Offset = "0x37E2FE0", VA = "0x1837E3DE0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, char? LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x37E3EB0", Offset = "0x37E30B0", VA = "0x1837E3EB0", Slot = "5")]
	public char? BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BDPDJMNCIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class MPHNPJDCDHH : global::CMLDAFIIOAH<char[]>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly MPHNPJDCDHH GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4810AF0", Offset = "0x480FCF0", VA = "0x184810AF0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, char[] LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4810C70", Offset = "0x480FE70", VA = "0x184810C70", Slot = "5")]
	public char[] BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public MPHNPJDCDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class ENIEAMDLBED : global::CMLDAFIIOAH<Guid>, DOCJLNHANHK, global::OFANMGKEMBP<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::CMLDAFIIOAH<Guid> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x37F0BD0", Offset = "0x37EFDD0", VA = "0x1837F0BD0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Guid LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x37F0D90", Offset = "0x37EFF90", VA = "0x1837F0D90", Slot = "5")]
	public Guid BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x37F0DF0", Offset = "0x37EFFF0", VA = "0x1837F0DF0", Slot = "6")]
	public void BMLKIDPFIFM(ref FLKJBKMANKH IECKPLOJOMK, Guid LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x37F0D90", Offset = "0x37EFF90", VA = "0x1837F0D90", Slot = "7")]
	public Guid AIIBMLDJEJG(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public ENIEAMDLBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LGBDPHBGLLG : global::CMLDAFIIOAH<decimal>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::CMLDAFIIOAH<decimal> GCMDIACLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool DONKJAMNADG;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xB6FC40", Offset = "0xB6EE40", VA = "0x180B6FC40")]
	public LGBDPHBGLLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1788710", Offset = "0x1787910", VA = "0x181788710")]
	public LGBDPHBGLLG(bool DONKJAMNADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x480DAC0", Offset = "0x480CCC0", VA = "0x18480DAC0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, decimal LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x480DC00", Offset = "0x480CE00", VA = "0x18480DC00", Slot = "5")]
	public decimal BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class MHNFLCKEKKI : global::CMLDAFIIOAH<Uri>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::CMLDAFIIOAH<Uri> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4810440", Offset = "0x480F640", VA = "0x184810440", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Uri LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x48104F0", Offset = "0x480F6F0", VA = "0x1848104F0", Slot = "5")]
	public Uri BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public MHNFLCKEKKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class OKNBOPPMEHF : global::CMLDAFIIOAH<Version>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::CMLDAFIIOAH<Version> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x48176B0", Offset = "0x48168B0", VA = "0x1848176B0", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Version LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x4817760", Offset = "0x4816960", VA = "0x184817760", Slot = "5")]
	public Version BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public OKNBOPPMEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class JMLCLJGAHJM<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class HFKAFIKMEAB : global::CMLDAFIIOAH<StringBuilder>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::CMLDAFIIOAH<StringBuilder> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x351C270", Offset = "0x351B470", VA = "0x18351C270", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, StringBuilder LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x351C2C0", Offset = "0x351B4C0", VA = "0x18351C2C0", Slot = "5")]
	public StringBuilder BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public HFKAFIKMEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class CJNOHCKLDAB : global::CMLDAFIIOAH<BitArray>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::CMLDAFIIOAH<BitArray> GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x37E6190", Offset = "0x37E5390", VA = "0x1837E6190", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, BitArray LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x37E6290", Offset = "0x37E5490", VA = "0x1837E6290", Slot = "5")]
	public BitArray BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public CJNOHCKLDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class HECOLCHDOBO : global::CMLDAFIIOAH<Type>, DOCJLNHANHK
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly HECOLCHDOBO GCMDIACLNPO;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex PDINEADLMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool DMIJBIICKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool FDCGHLHEGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool HJJBAMOKFKB;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x351C250", Offset = "0x351B450", VA = "0x18351C250")]
	public HECOLCHDOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x351C200", Offset = "0x351B400", VA = "0x18351C200")]
	public HECOLCHDOBO(bool DMIJBIICKNF, bool FDCGHLHEGON, bool HJJBAMOKFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x351BF50", Offset = "0x351B150", VA = "0x18351BF50", Slot = "4")]
	public void ABGFPJIPAOE(ref FLKJBKMANKH IECKPLOJOMK, Type LDPMPDNIHLJ, PGDAFACPPLB EMOPOJHLLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x351C040", Offset = "0x351B240", VA = "0x18351C040", Slot = "5")]
	public Type BAADAAGNJID(ref NMBHIAJGIPN MGBNMNINNDM, PGDAFACPPLB EMOPOJHLLNH)
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
