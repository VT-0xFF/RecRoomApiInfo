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
public class HOCFPFMIJIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551830", VA = "0x180552C30")]
	public HOCFPFMIJIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NPHCGCOEHHI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551830", VA = "0x180552C30")]
	public NPHCGCOEHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GLGOKEHFODJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551830", VA = "0x180552C30")]
	public GLGOKEHFODJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class KKFCJHFDMEC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x552C30", Offset = "0x551830", VA = "0x180552C30")]
	public KKFCJHFDMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class CJKFNMGKJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE935A0", Offset = "0xE921A0", VA = "0x180E935A0")]
	public static bool JNIHGFDLKIO(this TypeInfo IONHFMDGLFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class BIDBEJIIEHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type MKFDJBLNKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] OHBKFLEADIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7159F0", Offset = "0x7145F0", VA = "0x1807159F0")]
	public BIDBEJIIEHP(Type DIHDBJOHAHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class NNOJAMMEGKL : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void OFIOLFIFINJ<T>(ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T ILGICHNCKDC<T>(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP CEOJHHGIAAG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KKIBEEPOENK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FLDEMIEJACD<T> : KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OEGOIJEKHMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DGAIANJENCK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::FLDEMIEJACD<T> DLLBLGNCHLF<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FJPGELCDJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3122860", Offset = "0x3121460", VA = "0x183122860")]
	public static global::FLDEMIEJACD<T> NECGNDLCLGC<T>(this NHMDIGGKGCP CEOJHHGIAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB45D70", Offset = "0xB44970", VA = "0x180B45D70")]
	public static object ANBLJEPEKJH(this NHMDIGGKGCP CEOJHHGIAAG, Type IONHFMDGLFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BKPGPAKKAAI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xE8F4C0", Offset = "0xE8E0C0", VA = "0x180E8F4C0")]
	public BKPGPAKKAAI(string MCDGHKDLPFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MFJNBHDPLKH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DFPJANAJHHK
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] KPKLOHHPHLJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LAEEJKLNGEG;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x15DDDE0", Offset = "0x15DC9E0", VA = "0x1815DDDE0")]
		public static byte[] DFKDKBCAOHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x15DDE60", Offset = "0x15DCA60", VA = "0x1815DDE60")]
		public static char[] NBJLHKMJCAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LBHMCOIJPPL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] EIECJINOHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] GLAICJAMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BHFOGLICCMI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool OBGPAPAOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x15E0840", Offset = "0x15DF440", VA = "0x1815E0840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x15E0F00", Offset = "0x15DFB00", VA = "0x1815E0F00")]
	public MFJNBHDPLKH(byte[] GLAICJAMEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x15E0D20", Offset = "0x15DF920", VA = "0x1815E0D20")]
	public MFJNBHDPLKH(byte[] GLAICJAMEED, int BHFOGLICCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x15DF9F0", Offset = "0x15DE5F0", VA = "0x1815DF9F0")]
	private HBBKHAMEDNK NCJLCFFOAAO(string AHMBCIKHLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x15DF180", Offset = "0x15DDD80", VA = "0x1815DF180")]
	private HBBKHAMEDNK HGBDFMDPBCO(string MCDGHKDLPFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xB507E0", Offset = "0xB4F3E0", VA = "0x180B507E0")]
	public void IAODCAICHDG(int BHFOGLICCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60B990", Offset = "0x60A590", VA = "0x18060B990")]
	public byte[] BNPBHGMPCMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A70E0", Offset = "0x6A5CE0", VA = "0x1806A70E0")]
	public int MECLLLKJHNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x15DEB60", Offset = "0x15DD760", VA = "0x1815DEB60")]
	public LCDLGLIDPKO CMAEIFDGKDB()
	{
		return default(LCDLGLIDPKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x15DFF30", Offset = "0x15DEB30", VA = "0x1815DFF30")]
	public void NHEJIOPKGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x15DE4F0", Offset = "0x15DD0F0", VA = "0x1815DE4F0")]
	public bool BANPMMIMAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15DF260", Offset = "0x15DDE60", VA = "0x1815DF260")]
	public bool HHGPMEFKIIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15E0860", Offset = "0x15DF460", VA = "0x1815E0860")]
	public void OCPPDBMDDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x15DF7E0", Offset = "0x15DE3E0", VA = "0x1815DF7E0")]
	public bool MOFEGMFGKLC(ref int PMKGCDLMBFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x15DEA90", Offset = "0x15DD690", VA = "0x1815DEA90")]
	public bool BNLCEGCIEHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x15DF2D0", Offset = "0x15DDED0", VA = "0x1815DF2D0")]
	public void HOFJMDAMCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15DF0F0", Offset = "0x15DDCF0", VA = "0x1815DF0F0")]
	public bool HDPPNACCCDE(ref int PMKGCDLMBFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x15DF370", Offset = "0x15DDF70", VA = "0x1815DF370")]
	public bool IFOKHDCBFAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x15DF5F0", Offset = "0x15DE1F0", VA = "0x1815DF5F0")]
	public void JHNOALGOADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x15DF3E0", Offset = "0x15DDFE0", VA = "0x1815DF3E0")]
	public bool INMINGIMIKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x15DE990", Offset = "0x15DD590", VA = "0x1815DE990")]
	public void BDCLOBPCENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x15E0070", Offset = "0x15DEC70", VA = "0x1815E0070")]
	private void NONILIBONMI(out byte[] EGEMBIFNJDE, out int GLKONAEBIBH, out int JGMPIIIOBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x15DED70", Offset = "0x15DD970", VA = "0x1815DED70")]
	private static int COGDPMMALBC(char FIJKOPICOJA, char JCHDICMDCKL, char DILCHLNKBGI, char KOLFADHHADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15DF450", Offset = "0x15DE050", VA = "0x1815DF450")]
	private static int JDELONAGGCC(char PKLHFCEKMJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15DE400", Offset = "0x15DD000", VA = "0x1815DE400")]
	public ArraySegment<byte> BACGIKGKJBF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x15DFE90", Offset = "0x15DEA90", VA = "0x1815DFE90")]
	public string NCNFEADJHGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x15DF750", Offset = "0x15DE350", VA = "0x1815DF750")]
	public string LFINGKBEFLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x15DE7E0", Offset = "0x15DD3E0", VA = "0x1815DE7E0")]
	public ArraySegment<byte> BCJJPIMDKCM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x15E0800", Offset = "0x15DF400", VA = "0x1815E0800")]
	public ArraySegment<byte> NPAGAHFJGIG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15E0960", Offset = "0x15DF560", VA = "0x1815E0960")]
	public bool PKKMKLKEIKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15DF690", Offset = "0x15DE290", VA = "0x1815DF690")]
	private static bool KNMONNPDIIM(byte DILCHLNKBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x15DE610", Offset = "0x15DD210", VA = "0x1815DE610")]
	private void BBJPJHBFEHA(LCDLGLIDPKO BCFIBCIPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x15DE3F0", Offset = "0x15DCFF0", VA = "0x1815DE3F0")]
	public void BAAFJGKELCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x15DF520", Offset = "0x15DE120", VA = "0x1815DF520")]
	private void JEHLHPBDIJH(int HNAJEIOGLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x15DEF70", Offset = "0x15DDB70", VA = "0x1815DEF70")]
	public sbyte DOCFBOGHELL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15DF780", Offset = "0x15DE380", VA = "0x1815DF780")]
	public short MADCGCBIKDC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x15DEA30", Offset = "0x15DD630", VA = "0x1815DEA30")]
	public int BECIHFKJAHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x15E0BC0", Offset = "0x15DF7C0", VA = "0x1815E0BC0")]
	public long PLIANJKNCJP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x15DEB00", Offset = "0x15DD700", VA = "0x1815DEB00")]
	public byte CFIMDABBAOG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x15DEE20", Offset = "0x15DDA20", VA = "0x1815DEE20")]
	public ushort DGHNDCKLKKM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x15E0900", Offset = "0x15DF500", VA = "0x1815E0900")]
	public uint PCBLIPHCEKA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x15DECF0", Offset = "0x15DD8F0", VA = "0x1815DECF0")]
	public ulong CNCMDAIPBFM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x15DE2B0", Offset = "0x15DCEB0", VA = "0x1815DE2B0")]
	public float AALEGGLCMLI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x15DEFC0", Offset = "0x15DDBC0", VA = "0x1815DEFC0")]
	public double EMNLFIJHNJP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x15DEE80", Offset = "0x15DDA80", VA = "0x1815DEE80")]
	public ArraySegment<byte> DLFJILIKIBP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15DF870", Offset = "0x15DE470", VA = "0x1815DF870")]
	private static int NBJAAHGOCEN(byte[] GLAICJAMEED, int BHFOGLICCMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HBBKHAMEDNK : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference GANNIOBCFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FGKEFLFCAIL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BNGJPACKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB4A320", Offset = "0xB48F20", VA = "0x180B4A320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string BIDFOMAMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65F860", Offset = "0x65E460", VA = "0x18065F860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49000", VA = "0x180B4A400")]
	public HBBKHAMEDNK(string MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xB4A330", Offset = "0xB48F30", VA = "0x180B4A330")]
	public HBBKHAMEDNK(string MCDGHKDLPFF, byte[] LABPBCGLIIB, int BHFOGLICCMI, int FGKEFLFCAIL, string LHMJEKPHKPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FENMGGLLKAH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OPDFAGDBFKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void DMODMCPJEFI(ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object PELFLEHGLLA(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP CEOJHHGIAAG);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class BDKHAMGLFCK
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class JCFPOKHLLAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public JCFPOKHLLAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xB4E960", Offset = "0xB4D560", VA = "0x180B4E960")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4D5A0", VA = "0x180B4E9A0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, NHMDIGGKGCP, byte[]> HNNFCGHPCMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, NHMDIGGKGCP> ODKLDIAGHAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly DMODMCPJEFI IJFFBAADCBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, NHMDIGGKGCP, ArraySegment<byte>> JHEDGKPNMIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, NHMDIGGKGCP, string> HAMECAHJIAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, NHMDIGGKGCP, object> PFHHGIDLJOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, NHMDIGGKGCP, object> FFIMIJOAHDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, NHMDIGGKGCP, object> CFLAGJLBKAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly PELFLEHGLLA PKHHNJAHKEF;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB3F930", Offset = "0xB3E530", VA = "0x180B3F930")]
			public BDKHAMGLFCK(Type IONHFMDGLFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2C0D1A0", Offset = "0x2C0BDA0", VA = "0x182C0D1A0")]
			private static T NJOFKAEPIIH<T>(DynamicMethod NJLHMDEDAEH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB3F740", Offset = "0xB3E340", VA = "0x180B3F740")]
			private static MethodInfo ELOMFBIEJKC(Type IONHFMDGLFB, string FFOAIHIIDHB, Type[] DAMDGCGMKHJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, BDKHAMGLFCK> CHLPHLFOCIF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::MNOLNEKJABF<BDKHAMGLFCK> JHLCLOPANBO;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB59570", Offset = "0xB58170", VA = "0x180B59570")]
		static OPDFAGDBFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB59270", Offset = "0xB57E70", VA = "0x180B59270")]
		private static BDKHAMGLFCK AEMBJBABLKG(Type IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xB592F0", Offset = "0xB57EF0", VA = "0x180B592F0")]
		public static void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB59460", Offset = "0xB58060", VA = "0x180B59460")]
		public static void FIHFIFAJGAF(Type IONHFMDGLFB, ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class HFFCPMEAIJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] KPKLOHHPHLJ;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB4A5B0", Offset = "0xB491B0", VA = "0x180B4A5B0")]
		public static byte[] DFKDKBCAOHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NHMDIGGKGCP BJKBHJMDMIF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] JGJOMJGHBOD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] PCIBJALDLBI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NHMDIGGKGCP KCIEIFFDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xB45660", Offset = "0xB44260", VA = "0x180B45660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB45770", Offset = "0xB44370", VA = "0x180B45770")]
	public static void OFCNNGPKKJO(NHMDIGGKGCP CEOJHHGIAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3515990", Offset = "0x3514590", VA = "0x183515990")]
	public static string PBPGMKBAHKO<T>(T JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3515A10", Offset = "0x3514610", VA = "0x183515A10")]
	public static string PBPGMKBAHKO<T>(T JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C11E40", Offset = "0x2C10A40", VA = "0x182C11E40")]
	public static T CIMMFEHKACI<T>(string MJNNCPLFPGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C11C20", Offset = "0x2C10820", VA = "0x182C11C20")]
	public static T CIMMFEHKACI<T>(string MJNNCPLFPGN, NHMDIGGKGCP CEOJHHGIAAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C11EC0", Offset = "0x2C10AC0", VA = "0x182C11EC0")]
	public static T CIMMFEHKACI<T>(byte[] GLAICJAMEED, NHMDIGGKGCP CEOJHHGIAAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C11CF0", Offset = "0x2C108F0", VA = "0x182C11CF0")]
	public static T CIMMFEHKACI<T>(byte[] GLAICJAMEED, int BHFOGLICCMI, NHMDIGGKGCP CEOJHHGIAAG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LCDLGLIDPKO : byte
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
public struct KIIEHHNNHHA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NKNHNJFLCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] KPKLOHHPHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BHFOGLICCMI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GDOPDLLCJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A70E0", Offset = "0x6A5CE0", VA = "0x1806A70E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xB507E0", Offset = "0xB4F3E0", VA = "0x180B507E0")]
	public void IAODCAICHDG(int BHFOGLICCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xB50580", Offset = "0xB4F180", VA = "0x180B50580")]
	public static byte[] FAGNBCKMMCF(string KMBILCCOMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xB4FC80", Offset = "0xB4E880", VA = "0x180B4FC80")]
	public static byte[] CILDBLGGBCB(string KMBILCCOMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xB507F0", Offset = "0xB4F3F0", VA = "0x180B507F0")]
	public static byte[] JFJGNEBDFNJ(string KMBILCCOMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xB4FE20", Offset = "0xB4EA20", VA = "0x180B4FE20")]
	public static byte[] CPFDACHCDBL(string KMBILCCOMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xB50EB0", Offset = "0xB4FAB0", VA = "0x180B50EB0")]
	public KIIEHHNNHHA(byte[] MJBDPNHFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xB4FF80", Offset = "0xB4EB80", VA = "0x180B4FF80")]
	public ArraySegment<byte> DFKDKBCAOHD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB50920", Offset = "0xB4F520", VA = "0x180B50920")]
	public byte[] LIGNKEOOCIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB50E00", Offset = "0xB4FA00", VA = "0x180B50E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xB50DF0", Offset = "0xB4F9F0", VA = "0x180B50DF0")]
	public void OOIGHFKJAGF(int GPBEMIHAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xB50D40", Offset = "0xB4F940", VA = "0x180B50D40")]
	public void ODGKJMCOCCF(byte[] FPGMPJFLMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xB506D0", Offset = "0xB4F2D0", VA = "0x180B506D0")]
	public void GFENDKGMMJO(byte FPGMPJFLMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xB4FC30", Offset = "0xB4E830", VA = "0x180B4FC30")]
	public void CIDKIDFFBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xB50600", Offset = "0xB4F200", VA = "0x180B50600")]
	public void FBIGODNDFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xB50710", Offset = "0xB4F310", VA = "0x180B50710")]
	public void GOMMHFOJOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xB50CC0", Offset = "0xB4F8C0", VA = "0x180B50CC0")]
	public void NMHPDMEAJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xB50760", Offset = "0xB4F360", VA = "0x180B50760")]
	public void HEOMHHACLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xB50680", Offset = "0xB4F280", VA = "0x180B50680")]
	public void FIFBGICKMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xB50C60", Offset = "0xB4F860", VA = "0x180B50C60")]
	public void NLPHDBICDAJ(string KMBILCCOMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xB50DA0", Offset = "0xB4F9A0", VA = "0x180B50DA0")]
	public void OKOLFACFPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB4FD50", Offset = "0xB4E950", VA = "0x180B4FD50")]
	public void CNIPENGNGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xB50A70", Offset = "0xB4F670", VA = "0x180B50A70")]
	public void LOCNOCEFKLK(bool JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xB50060", Offset = "0xB4EC60", VA = "0x180B50060")]
	public void DPCMPLHLNAH(float JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xB4FAF0", Offset = "0xB4E6F0", VA = "0x180B4FAF0")]
	public void CHFKLLHHIFC(double JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xB4FAC0", Offset = "0xB4E6C0", VA = "0x180B4FAC0")]
	public void AINFGBEAPIE(byte JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xB507B0", Offset = "0xB4F3B0", VA = "0x180B507B0")]
	public void HHMOCOGGEGL(ushort JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xB508F0", Offset = "0xB4F4F0", VA = "0x180B508F0")]
	public void LGJHOMBPGHE(uint JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4F4C0", VA = "0x180B508C0")]
	public void JJPIAHMOKAG(ulong JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xB50650", Offset = "0xB4F250", VA = "0x180B50650")]
	public void FDHHEOAEPFE(sbyte JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xB50D10", Offset = "0xB4F910", VA = "0x180B50D10")]
	public void NNHABNJLCGE(short JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xB4FA90", Offset = "0xB4E690", VA = "0x180B4FA90")]
	public void ADFILKONOJL(int JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xB50030", Offset = "0xB4EC30", VA = "0x180B50030")]
	public void DIPFJHNAEAD(long JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB501B0", Offset = "0xB4EDB0", VA = "0x180B501B0")]
	public void ENPAIHMKCDE(string JHEBJPCMJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JCGDCDFONOL : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class MPELDGLGDMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xEF08F0", Offset = "0xEEF4F0", VA = "0x180EF08F0")]
		static MPELDGLGDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private JCGDCDFONOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class LBKJODPDADB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> PLOBACLENHE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xB51B30", Offset = "0xB50730", VA = "0x180B51B30")]
	static LBKJODPDADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB515D0", Offset = "0xB501D0", VA = "0x180B515D0")]
	internal static object DLLBLGNCHLF(Type BMKMABBLJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DJHLPJMFGFO : global::FLDEMIEJACD<Vector2>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xE96960", Offset = "0xE95560", VA = "0x180E96960")]
	public DJHLPJMFGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xE968B0", Offset = "0xE954B0", VA = "0x180E968B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Vector2 JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xE966C0", Offset = "0xE952C0", VA = "0x180E966C0", Slot = "5")]
	public Vector2 CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HIKFNELEIAD : global::FLDEMIEJACD<Vector3>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xB4B5B0", Offset = "0xB4A1B0", VA = "0x180B4B5B0")]
	public HIKFNELEIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xB4B3A0", Offset = "0xB49FA0", VA = "0x180B4B3A0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Vector3 JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB4B1B0", Offset = "0xB49DB0", VA = "0x180B4B1B0", Slot = "5")]
	public Vector3 CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GCNFNBKFAMH : global::FLDEMIEJACD<Vector4>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xB49560", Offset = "0xB48160", VA = "0x180B49560")]
	public GCNFNBKFAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xB492F0", Offset = "0xB47EF0", VA = "0x180B492F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Vector4 JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xB490C0", Offset = "0xB47CC0", VA = "0x180B490C0", Slot = "5")]
	public Vector4 CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CHHBJFCMLDN : global::FLDEMIEJACD<Quaternion>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xE92FE0", Offset = "0xE91BE0", VA = "0x180E92FE0")]
	public CHHBJFCMLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xE92E90", Offset = "0xE91A90", VA = "0x180E92E90", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Quaternion JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xE92C00", Offset = "0xE91800", VA = "0x180E92C00", Slot = "5")]
	public Quaternion CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class HMMHCPOOAKM : global::FLDEMIEJACD<Color>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xB4C030", Offset = "0xB4AC30", VA = "0x180B4C030")]
	public HMMHCPOOAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xB492F0", Offset = "0xB47EF0", VA = "0x180B492F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Color JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xB4BE00", Offset = "0xB4AA00", VA = "0x180B4BE00", Slot = "5")]
	public Color CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BBCIMENJDKM : global::FLDEMIEJACD<Bounds>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xE8E560", Offset = "0xE8D160", VA = "0x180E8E560")]
	public BBCIMENJDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xE8E2F0", Offset = "0xE8CEF0", VA = "0x180E8E2F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Bounds JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xE8DFF0", Offset = "0xE8CBF0", VA = "0x180E8DFF0", Slot = "5")]
	public Bounds CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class LIJGNGFHKPK : global::FLDEMIEJACD<Rect>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly APLAENLIFGL BNKGOMNIAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] DLDNCMBGMNH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xB52960", Offset = "0xB51560", VA = "0x180B52960")]
	public LIJGNGFHKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xB526D0", Offset = "0xB512D0", VA = "0x180B526D0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Rect JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xB52470", Offset = "0xB51070", VA = "0x180B52470", Slot = "5")]
	public Rect CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JMMELPGGFLF : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class GOCPLIFOOIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xEE0200", Offset = "0xEDEE00", VA = "0x180EE0200")]
		static GOCPLIFOOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private JMMELPGGFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class NMPHOABPLKN : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class KHBEEHNKACN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x39FCF50", Offset = "0x39FBB50", VA = "0x1839FCF50")]
		static KHBEEHNKACN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NMONIMDMOGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> IPDNMKEGBFH;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x15E5A40", Offset = "0x15E4640", VA = "0x1815E5A40")]
		internal static object DLLBLGNCHLF(Type BMKMABBLJGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private NMPHOABPLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GHALNNFLBNB : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class JEDICGGEEMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x12A91E0", Offset = "0x12A7DE0", VA = "0x1812A91E0")]
		static JEDICGGEEMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GHALNNFLBNB APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool AKLHLKPPEEF;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static KKIBEEPOENK[] JBDJOFCPOAL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static NHMDIGGKGCP[] JFMAMPAKBFI;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private GHALNNFLBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xB49D70", Offset = "0xB48970", VA = "0x180B49D70")]
	public static void EECMIPBDCFL(params NHMDIGGKGCP[] JFMAMPAKBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xB49CB0", Offset = "0xB488B0", VA = "0x180B49CB0")]
	public static void EECMIPBDCFL(params KKIBEEPOENK[] JBDJOFCPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xB49E30", Offset = "0xB48A30", VA = "0x180B49E30")]
	public static void FELCKBCIMDE(KKIBEEPOENK[] JBDJOFCPOAL, NHMDIGGKGCP[] JFMAMPAKBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HFMIBNDEBGO : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class EBNOLBIGLPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xF36930", Offset = "0xF35530", VA = "0x180F36930")]
		static EBNOLBIGLPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private HFMIBNDEBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CKKMOEPPAOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NHMDIGGKGCP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly NHMDIGGKGCP KIOLDOFFGCO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NHMDIGGKGCP GMHEBLOJPCF;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly NHMDIGGKGCP ONAPIDNDFHK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly NHMDIGGKGCP PKCIMMJIPAP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly NHMDIGGKGCP MBPACCLMCJK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly NHMDIGGKGCP PCGNKNCLDBA;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly NHMDIGGKGCP MKLCOCMBACC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NHMDIGGKGCP OPODCKDJPFC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly NHMDIGGKGCP PNNBFJIJHLH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly NHMDIGGKGCP DGMFKGKJPBE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly NHMDIGGKGCP EAFCAAICGGP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LHOCNEHCHJH
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly NHMDIGGKGCP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NHMDIGGKGCP ODCJLDIKFHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MNIDCFPFPJL
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly NHMDIGGKGCP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly NHMDIGGKGCP KIOLDOFFGCO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NHMDIGGKGCP GMHEBLOJPCF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NHMDIGGKGCP ONAPIDNDFHK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly NHMDIGGKGCP PKCIMMJIPAP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly NHMDIGGKGCP MBPACCLMCJK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly NHMDIGGKGCP PCGNKNCLDBA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly NHMDIGGKGCP MKLCOCMBACC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NHMDIGGKGCP OPODCKDJPFC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NHMDIGGKGCP PNNBFJIJHLH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly NHMDIGGKGCP DGMFKGKJPBE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NHMDIGGKGCP EAFCAAICGGP;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class MEBAGKKKDMC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> IPDNMKEGBFH;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xB57130", Offset = "0xB55D30", VA = "0x180B57130")]
	internal static object DLLBLGNCHLF(Type BMKMABBLJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xB58720", Offset = "0xB57320", VA = "0x180B58720")]
	private static object NLDMLMHNKAK(Type LEHPLFEJHBK, Type[] GKEKLAIHEKB, params object[] DAMDGCGMKHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class NOIECJDPDMD : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class IBCFBJKLGMM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x39F9E80", Offset = "0x39F8A80", VA = "0x1839F9E80")]
		static IBCFBJKLGMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x15E7750", Offset = "0x15E6350", VA = "0x1815E7750")]
	static NOIECJDPDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private NOIECJDPDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class ECLLEBJMJEI : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class FMKGCJCBFKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3641450", Offset = "0x3640050", VA = "0x183641450")]
		static FMKGCJCBFKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xB423E0", Offset = "0xB40FE0", VA = "0x180B423E0")]
	static ECLLEBJMJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private ECLLEBJMJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class AKKFOHKJDBO : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JFDNJECFLFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x299CF80", Offset = "0x299BB80", VA = "0x18299CF80")]
		static JFDNJECFLFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0xE8D100", Offset = "0xE8BD00", VA = "0x180E8D100")]
	static AKKFOHKJDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private AKKFOHKJDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class IJGBFMPLODB : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class OFOCEJAPJGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1014740", Offset = "0x1013340", VA = "0x181014740")]
		static OFOCEJAPJGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xB4CDC0", Offset = "0xB4B9C0", VA = "0x180B4CDC0")]
	static IJGBFMPLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private IJGBFMPLODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class NMMMIOBFONM : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class CGPDIJFPBOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x39F5130", Offset = "0x39F3D30", VA = "0x1839F5130")]
		static CGPDIJFPBOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x15E5950", Offset = "0x15E4550", VA = "0x1815E5950")]
	static NMMMIOBFONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private NMMMIOBFONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class PNLCFHACBNE : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class GNIMNMNLEEP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3724140", Offset = "0x3722D40", VA = "0x183724140")]
		static GNIMNMNLEEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly ILHKBBBEGKB GCMHDOEBJJP;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x15EAD60", Offset = "0x15E9960", VA = "0x1815EAD60")]
	static PNLCFHACBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private PNLCFHACBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class JPAKLIFHPOK : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class DBIMMMPPEFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1495580", Offset = "0x1494180", VA = "0x181495580")]
		static DBIMMMPPEFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public JPAKLIFHPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LBIONANGBLN : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class NMKPHBMFCAH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1390AE0", Offset = "0x138F6E0", VA = "0x181390AE0")]
		static NMKPHBMFCAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public LBIONANGBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HNGBAGGPMAG : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class OBMKPLAFGCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xF4AF40", Offset = "0xF49B40", VA = "0x180F4AF40")]
		static OBMKPLAFGCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public HNGBAGGPMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class BFOBGHOOGPD : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class FAGAKIFHJIP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x398D7B0", Offset = "0x398C3B0", VA = "0x18398D7B0")]
		static FAGAKIFHJIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public BFOBGHOOGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CJEGEKEKIMK : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class NMBLODMLEMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B56800", Offset = "0x3B55400", VA = "0x183B56800")]
		static NMBLODMLEMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CJEGEKEKIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IHMIAIKDCHM : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class EFHABMEOFCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xFFEAC0", Offset = "0xFFD6C0", VA = "0x180FFEAC0")]
		static EFHABMEOFCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> OEIEDHLPKKI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool JKFMHAIJFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public IHMIAIKDCHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DJIONBEBIPL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NMCMGGHJJNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CCPJACCAPCF GJIBNIDEFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder NKPIMOKACJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder KFKFBGNBNAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class IPBOJIGGGEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class JDKAAILGMDF
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo JFJGNEBDFNJ;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo CILDBLGGBCB;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo CPFDACHCDBL;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo FAGNBCKMMCF;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CNIPENGNGMA;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo ODGKJMCOCCF;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo GOMMHFOJOLD;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo NMHPDMEAJAD;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo HEOMHHACLCP;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xEA1FC0", Offset = "0xEA0BC0", VA = "0x180EA1FC0")]
			static JDKAAILGMDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class CGPDLOHOPFN
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo BANPMMIMAKO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HOFJMDAMCMD;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HDPPNACCCDE;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo ELMBHGHPIPB;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BAAFJGKELCP;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo BNPBHGMPCMP;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo MECLLLKJHNP;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xE92100", Offset = "0xE90D00", VA = "0x180E92100")]
			static CGPDLOHOPFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GGPEOPJHING
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo MKFDJBLNKML;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo OHBKFLEADIK;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo JAMFKOBFMAG;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo NECGNDLCLGC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo NPGNPAHGIJI;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo HEKDOODPKKC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo DLJMJCIGGKA;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo JJMAKHBGMIG;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo BODJMBKNCAI;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo GPNBBLCGGID;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LMFGOIFMCON;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo NFJDIAKNDNM;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo ONHGGILGFAF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo ACANOJDKHFG;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xEA08E0", Offset = "0xE9F4E0", VA = "0x180EA08E0")]
		public static MethodInfo FIHFIFAJGAF(Type IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xEA0590", Offset = "0xE9F190", VA = "0x180EA0590")]
		public static MethodInfo CIMMFEHKACI(Type IONHFMDGLFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xEA07C0", Offset = "0xE9F3C0", VA = "0x180EA07C0")]
		public static MethodInfo DJONAGOMJNM(Type IONHFMDGLFB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class AOFMBIKAHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CCPJACCAPCF, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public AOFMBIKAHIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class NHIDEOIOGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AOFMBIKAHIG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public NHIDEOIOGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB58E90", Offset = "0xB57A90", VA = "0x180B58E90")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xB58ED0", Offset = "0xB57AD0", VA = "0x180B58ED0")]
		internal bool <BuildType>b__2(int index, CCPJACCAPCF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DNOHAGJELIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AOFMBIKAHIG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public DNOHAGJELIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xE9E7B0", Offset = "0xE9D3B0", VA = "0x180E9E7B0")]
		internal bool <BuildType>b__3(int index, CCPJACCAPCF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HIFGGKPMJJE
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public HIFGGKPMJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xEA0530", Offset = "0xE9F130", VA = "0x180EA0530")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GHIGJBOLHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public GHIGJBOLHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xEA0330", Offset = "0xE9EF30", VA = "0x180EA0330")]
		internal bool <BuildAnonymousFormatter>b__2(CCPJACCAPCF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class AOHHEJBOMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public HIFGGKPMJJE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public AOHHEJBOMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xE8D450", Offset = "0xE8C050", VA = "0x180E8D450")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xE8D460", Offset = "0xE8C060", VA = "0x180E8D460")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CCPJACCAPCF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class HHJKMBANLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public HIFGGKPMJJE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public HHJKMBANLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xEA0390", Offset = "0xE9EF90", VA = "0x180EA0390")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CCPJACCAPCF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IPIIBJIOBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public IPIIBJIOBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E550", VA = "0x18057F950")]
		internal Label <BuildSerialize>b__1(CCPJACCAPCF _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FDCEMBMPODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NMCMGGHJJNB[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CCPJACCAPCF, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PKFLFEBJHJC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PKFLFEBJHJC argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public FDCEMBMPODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xE9E850", Offset = "0xE9D450", VA = "0x180E9E850")]
		internal NMCMGGHJJNB <BuildDeserialize>b__0(CCPJACCAPCF item)
		{
			return default(NMCMGGHJJNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MIPNLGEDOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FDCEMBMPODM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public MIPNLGEDOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xB58B10", Offset = "0xB57710", VA = "0x180B58B10")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xB58DF0", Offset = "0xB579F0", VA = "0x180B58DF0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JJIPAEFJAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CCPJACCAPCF item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public JJIPAEFJAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xB4F0F0", Offset = "0xB4DCF0", VA = "0x180B4F0F0")]
		internal bool <EmitNewObject>b__0(NMCMGGHJJNB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MNIEHDHJGED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CCPJACCAPCF item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public MNIEHDHJGED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB4F0F0", Offset = "0xB4DCF0", VA = "0x180B4F0F0")]
		internal bool <EmitNewObject>b__2(NMCMGGHJJNB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex NNLLLHHGALB;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EIGAFFMGDOE;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> LHACMLONCEE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> CGOOAMNFBFD;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x36A42F0", Offset = "0x36A2EF0", VA = "0x1836A42F0")]
	public static object PMKDMJGKACM<T>(ILHKBBBEGKB GCMHDOEBJJP, NHMDIGGKGCP GIDCBACEFMF, Func<string, string> OEIEDHLPKKI, bool JKFMHAIJFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x369EDE0", Offset = "0x369D9E0", VA = "0x18369EDE0")]
	public static object MCOGDOFIABB<T>(NHMDIGGKGCP GIDCBACEFMF, Func<string, string> OEIEDHLPKKI, bool JKFMHAIJFEJ, bool MDNJGKDBHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xE99CB0", Offset = "0xE988B0", VA = "0x180E99CB0")]
	private static TypeInfo LGBEEJLMKEO(ILHKBBBEGKB GCMHDOEBJJP, Type IONHFMDGLFB, Func<string, string> OEIEDHLPKKI, bool JKFMHAIJFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xE971C0", Offset = "0xE95DC0", VA = "0x180E971C0")]
	public static object EIDJIJNOJBN(Type IONHFMDGLFB, Func<string, string> OEIEDHLPKKI, bool JKFMHAIJFEJ, bool MDNJGKDBHFM, bool MEHPMPDAEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xE96B70", Offset = "0xE95770", VA = "0x180E96B70")]
	private static Dictionary<CCPJACCAPCF, FieldInfo> BFLOHNOLEPO(TypeBuilder DIEJBIBEKIF, EKAMNJPMAEJ MPBBADKKMHG, ConstructorInfo JDBEJANMNJE, FieldBuilder PODGLPMIPPH, ILGenerator AMBCAJNMJFK, bool JKFMHAIJFEJ, bool HPNPEJLOOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xE98B80", Offset = "0xE97780", VA = "0x180E98B80")]
	private static Dictionary<CCPJACCAPCF, FieldInfo> FEJLICMBMEN(TypeBuilder DIEJBIBEKIF, EKAMNJPMAEJ MPBBADKKMHG, ILGenerator AMBCAJNMJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xE9AE20", Offset = "0xE99A20", VA = "0x180E9AE20")]
	private static void MILDCGBEKAC(Type IONHFMDGLFB, EKAMNJPMAEJ MPBBADKKMHG, ILGenerator AMBCAJNMJFK, Action GHKJHMHFFGK, Func<int, CCPJACCAPCF, bool> OJHNDHHAMOJ, bool JKFMHAIJFEJ, bool HPNPEJLOOBB, int DJEJPLPDLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xE992F0", Offset = "0xE97EF0", VA = "0x180E992F0")]
	private static void JANHGAJGPLC(TypeInfo IONHFMDGLFB, CCPJACCAPCF DJONAJHJEAO, ILGenerator AMBCAJNMJFK, int KMCFICBBFCD, Func<int, CCPJACCAPCF, bool> OJHNDHHAMOJ, PKFLFEBJHJC BHLBIOMPHHM, PKFLFEBJHJC PKJCKEMCIKP, PKFLFEBJHJC ACIOPFGHPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xE9C380", Offset = "0xE9AF80", VA = "0x180E9C380")]
	private static void MKGJJHHCJJH(Type IONHFMDGLFB, EKAMNJPMAEJ MPBBADKKMHG, ILGenerator AMBCAJNMJFK, Func<int, CCPJACCAPCF, bool> OJHNDHHAMOJ, bool MLOMOJLMJKH, int DJEJPLPDLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xE998A0", Offset = "0xE984A0", VA = "0x180E998A0")]
	private static void KJNFFHDFGND(ILGenerator AMBCAJNMJFK, NMCMGGHJJNB MPBBADKKMHG, int KMCFICBBFCD, Func<int, CCPJACCAPCF, bool> OJHNDHHAMOJ, PKFLFEBJHJC IBMBDMBMFCG, PKFLFEBJHJC ACIOPFGHPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xE9D630", Offset = "0xE9C230", VA = "0x180E9D630")]
	private static LocalBuilder NDHICEDLBEC(ILGenerator AMBCAJNMJFK, Type IONHFMDGLFB, EKAMNJPMAEJ MPBBADKKMHG, NMCMGGHJJNB[] DLOFELNKFLD, bool JBIAHCBDLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xE9A750", Offset = "0xE99350", VA = "0x180E9A750")]
	private static bool LHMIJEIPMBA(ConstructorInfo PDDLHJOEMLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xE99150", Offset = "0xE97D50", VA = "0x180E99150")]
	private static bool IKKAAAOEDOA(Type IONHFMDGLFB, out Type AHJJBIMFBHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void ENHMFMBBLOI<T>(byte[][] PODGLPMIPPH, object[] JCJKGFMFMBD, ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP CEOJHHGIAAG);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T HGMLIBJEOBN<T>(object[] JCJKGFMFMBD, ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP CEOJHHGIAAG);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BLKFDNMHAAK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class PECNIHPOIHP : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class GHHALEEIAAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1600", Offset = "0x3FE0200", VA = "0x183FE1600")]
		static GHHALEEIAAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private PECNIHPOIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class BFAMLEBBAAF : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class DJNGLNNHCNF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x42DAA70", Offset = "0x42D9670", VA = "0x1842DAA70")]
		static DJNGLNNHCNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private BFAMLEBBAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HHMMBJPFEIB
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly NHMDIGGKGCP[] NDBBPIDGMFC;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class HKONIJNLOKO : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class KOPNDCOBIGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xF45CE0", Offset = "0xF448E0", VA = "0x180F45CE0")]
		static KOPNDCOBIGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class IBJMCJKGNJC : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class CGJJEGNLIJC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xF32FE0", Offset = "0xF31BE0", VA = "0x180F32FE0")]
			static CGJJEGNLIJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private IBJMCJKGNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private HKONIJNLOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class MIEGFJJEPEI : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class LMNCBHIBNJH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x39652E0", Offset = "0x3963EE0", VA = "0x1839652E0")]
		static LMNCBHIBNJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NDMDGOOOAIB : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class MIFLNLBNEBF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x39726C0", Offset = "0x39712C0", VA = "0x1839726C0")]
			static MIFLNLBNEBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private NDMDGOOOAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private MIEGFJJEPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class GFDKKEJKNFO : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class OAOKOINEJBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x12AE9B0", Offset = "0x12AD5B0", VA = "0x1812AE9B0")]
		static OAOKOINEJBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class AHAPGNGDMKM : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class GIBNJENKNIJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x12A73E0", Offset = "0x12A5FE0", VA = "0x1812A73E0")]
			static GIBNJENKNIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private AHAPGNGDMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private GFDKKEJKNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class HOCNJENGMKF : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class LODMFPKOCPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x775F20", Offset = "0x774B20", VA = "0x180775F20")]
		static LODMFPKOCPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class DOMHPBJMCMD : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class JDCLFANOEJE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x773830", Offset = "0x772430", VA = "0x180773830")]
			static JDCLFANOEJE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private DOMHPBJMCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private HOCNJENGMKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class JJEANMBEMIP : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class OAOLAEPBBDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xEF1D30", Offset = "0xEF0930", VA = "0x180EF1D30")]
		static OAOLAEPBBDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class IMAINEJENIG : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class JAEMHLNENGC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xEE93C0", Offset = "0xEE7FC0", VA = "0x180EE93C0")]
			static JAEMHLNENGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private IMAINEJENIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private JJEANMBEMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class FEMLOHKOBNO : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class MFFKBMJFHMN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x12D8140", Offset = "0x12D6D40", VA = "0x1812D8140")]
		static MFFKBMJFHMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class APCNKNIDDKF : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GOCMBJOCMDI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x12D2190", Offset = "0x12D0D90", VA = "0x1812D2190")]
			static GOCMBJOCMDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private APCNKNIDDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private FEMLOHKOBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class AGCPOFIFIEG : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class BNGGNPCEEFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2D55A00", Offset = "0x2D54600", VA = "0x182D55A00")]
		static BNGGNPCEEFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class KBPAGNDJDGI : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class FIJPFMOKPDL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C2A0", Offset = "0x2D5AEA0", VA = "0x182D5C2A0")]
			static FIJPFMOKPDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private KBPAGNDJDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private AGCPOFIFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class ADMGJOIIOFN : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class BPIJCMICHAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xDF8710", Offset = "0xDF7310", VA = "0x180DF8710")]
		static BPIJCMICHAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class GHCIOLKNPPG : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class JNGFFDANOJH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xDFEBC0", Offset = "0xDFD7C0", VA = "0x180DFEBC0")]
			static JNGFFDANOJH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private GHCIOLKNPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private ADMGJOIIOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class HCFBBPHEEHD : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class MEJBBEJIFJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3191A20", Offset = "0x3190620", VA = "0x183191A20")]
		static MEJBBEJIFJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class LLJEDPCJBNH : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class AHHLKBEJCDB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x31893E0", Offset = "0x3187FE0", VA = "0x1831893E0")]
			static AHHLKBEJCDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private LLJEDPCJBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private HCFBBPHEEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class EKMBLOGCGNM : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class PENPBOPBHEJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3693140", Offset = "0x3691D40", VA = "0x183693140")]
		static PENPBOPBHEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OEOAFEHOBOJ : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class KPMCEAEENOO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x368EDB0", Offset = "0x368D9B0", VA = "0x18368EDB0")]
			static KPMCEAEENOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private OEOAFEHOBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private EKMBLOGCGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class LBBNJMFNNMI : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class EHKPJPFABGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x13803E0", Offset = "0x137EFE0", VA = "0x1813803E0")]
		static EHKPJPFABGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class NIFBJCDJJDL : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class CJMFHGKMELM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x137B680", Offset = "0x137A280", VA = "0x18137B680")]
			static CJMFHGKMELM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private NIFBJCDJJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private LBBNJMFNNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class KCMFBELINOI : NHMDIGGKGCP
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class OHCICKIDJGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x14AB3D0", Offset = "0x14A9FD0", VA = "0x1814AB3D0")]
		static OHCICKIDJGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class AOBEOJDJFGF : NHMDIGGKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class HJHNOMDHEKG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::FLDEMIEJACD<T> AIGMCFJOOCH;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x149F1A0", Offset = "0x149DDA0", VA = "0x18149F1A0")]
			static HJHNOMDHEKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly NHMDIGGKGCP APCGFOPGBDO;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly NHMDIGGKGCP[] JFMAMPAKBFI;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		private AOBEOJDJFGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
		public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly NHMDIGGKGCP APCGFOPGBDO;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::FLDEMIEJACD<object> FNBKIIELGMG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private KCMFBELINOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x276A6D0", Offset = "0x27692D0", VA = "0x18276A6D0", Slot = "4")]
	public global::FLDEMIEJACD<T> DLLBLGNCHLF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct EIDGKFDIIJA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] GNPNCAEEGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int OKLPHEBIEMI;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x363D570", Offset = "0x363C170", VA = "0x18363D570")]
	public EIDGKFDIIJA(int IALAKEFKJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x363D340", Offset = "0x363BF40", VA = "0x18363D340")]
	public void DLPDCPCMKFM(T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x363D4E0", Offset = "0x363C0E0", VA = "0x18363D4E0")]
	public T[] GEMJKIMGFLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class MHLAMPKDBLH : global::EAKEAOELOFN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly MHLAMPKDBLH NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x15E12E0", Offset = "0x15DFEE0", VA = "0x1815E12E0")]
	public MHLAMPKDBLH(int FPNIAMEHIFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class EAKEAOELOFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int FPNIAMEHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object HNKDMDHDBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int KMCFICBBFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] ENLOCGJGAFD;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x32E0840", Offset = "0x32DF440", VA = "0x1832E0840")]
	public EAKEAOELOFN(int FPNIAMEHIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x32DFAC0", Offset = "0x32DE6C0", VA = "0x1832DFAC0")]
	public T[] EIICLEHABKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x32DE800", Offset = "0x32DD400", VA = "0x1832DE800")]
	public void AKDNAEPEALN(T[] BBFDALJHIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class APLAENLIFGL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class GEJNBLFCEFA : IComparable<GEJNBLFCEFA>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class FNECFHFJPDH : IEnumerable<GEJNBLFCEFA>, IEnumerable, IEnumerator<GEJNBLFCEFA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private GEJNBLFCEFA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public GEJNBLFCEFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private GEJNBLFCEFA System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
			[DebuggerHidden]
			public FNECFHFJPDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xE9E980", Offset = "0xE9D580", VA = "0x180E9E980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xE9EAB0", Offset = "0xE9D6B0", VA = "0x180E9EAB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE9EA10", Offset = "0xE9D610", VA = "0x180E9EA10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GEJNBLFCEFA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xE9EA10", Offset = "0xE9D610", VA = "0x180E9EA10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class DJPNMCGLBOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public DJPNMCGLBOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E550", VA = "0x18057F950")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x57F950", Offset = "0x57E550", VA = "0x18057F950")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly GEJNBLFCEFA[] CCNFLPBHICO;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] BEKMIKBPCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong CGBHHKNJCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int EFFCIDNMALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string NBCFIMBKFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private GEJNBLFCEFA[] PBHCHHBFFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] IOILJNPFADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int PMKGCDLMBFP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool INAKGIMLKOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xE9EF10", Offset = "0xE9DB10", VA = "0x180E9EF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xE9FDB0", Offset = "0xE9E9B0", VA = "0x180E9FDB0")]
		public GEJNBLFCEFA(ulong GMCMHIFODNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xE9ECD0", Offset = "0xE9D8D0", VA = "0x180E9ECD0")]
		public GEJNBLFCEFA DLPDCPCMKFM(ulong GMCMHIFODNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xE9EEC0", Offset = "0xE9DAC0", VA = "0x180E9EEC0")]
		public GEJNBLFCEFA DLPDCPCMKFM(ulong GMCMHIFODNN, int JHEBJPCMJGD, string NBCFIMBKFBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xE9FB80", Offset = "0xE9E780", VA = "0x180E9FB80")]
		public GEJNBLFCEFA OLPPEEBLFNF(byte[] MOHICFNMKJK, ref int BHFOGLICCMI, ref int FFAPAPFLBMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xE9FB00", Offset = "0xE9E700", VA = "0x180E9FB00")]
		internal static int LMOADIABBDK(ulong[] BBFDALJHIIP, int KMCFICBBFCD, int GKHAECAMGEE, ulong JHEBJPCMJGD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xE9EC30", Offset = "0xE9D830", VA = "0x180E9EC30", Slot = "4")]
		public int CompareTo(GEJNBLFCEFA DEIAHGDLBHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xE9EC60", Offset = "0xE9D860", VA = "0x180E9EC60")]
		[IteratorStateMachine(typeof(FNECFHFJPDH))]
		public IEnumerable<GEJNBLFCEFA> DKAHMMNDMBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xE9EB00", Offset = "0xE9D700", VA = "0x180E9EB00")]
		public void CHFHGELHAEA(ILGenerator AMBCAJNMJFK, LocalBuilder MOHICFNMKJK, LocalBuilder FFAPAPFLBMB, LocalBuilder GMCMHIFODNN, Action<KeyValuePair<string, int>> BJCJACHKAKA, Action PBAEAECNLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xE9EF20", Offset = "0xE9DB20", VA = "0x180E9EF20")]
		private static void GFFIKAPMJPP(ILGenerator AMBCAJNMJFK, LocalBuilder MOHICFNMKJK, LocalBuilder FFAPAPFLBMB, LocalBuilder GMCMHIFODNN, Action<KeyValuePair<string, int>> BJCJACHKAKA, Action PBAEAECNLAA, GEJNBLFCEFA[] PBHCHHBFFFG, int PMKGCDLMBFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class KFBBGKLNDNO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<GEJNBLFCEFA> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<GEJNBLFCEFA> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<GEJNBLFCEFA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private GEJNBLFCEFA <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x577CC0", Offset = "0x5768C0", VA = "0x180577CC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA32F0", Offset = "0xEA1EF0", VA = "0x180EA32F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE00", Offset = "0xAABA00", VA = "0x180AACE00")]
		[DebuggerHidden]
		public KFBBGKLNDNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xEA3340", Offset = "0xEA1F40", VA = "0x180EA3340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xEA2E80", Offset = "0xEA1A80", VA = "0x180EA2E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xEA3440", Offset = "0xEA2040", VA = "0x180EA3440")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xEA3490", Offset = "0xEA2090", VA = "0x180EA3490")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xEA32A0", Offset = "0xEA1EA0", VA = "0x180EA32A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xEA3200", Offset = "0xEA1E00", VA = "0x180EA3200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xEA3200", Offset = "0xEA1E00", VA = "0x180EA3200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GEJNBLFCEFA LGLMPHDPDPB;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xE8DF80", Offset = "0xE8CB80", VA = "0x180E8DF80")]
	public APLAENLIFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xE8D8D0", Offset = "0xE8C4D0", VA = "0x180E8D8D0")]
	public void DLPDCPCMKFM(byte[] GLAICJAMEED, int JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xE8DDE0", Offset = "0xE8C9E0", VA = "0x180E8DDE0")]
	public bool OMEOGFDEHNI(ArraySegment<byte> GMCMHIFODNN, out int JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xE8DE90", Offset = "0xE8CA90", VA = "0x180E8DE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xE8DB60", Offset = "0xE8C760", VA = "0x180E8DB60")]
	private static void KPAPOJCEKGL(IEnumerable<GEJNBLFCEFA> PBHCHHBFFFG, StringBuilder CDHHGHKKFBN, int JPOCGFPMJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0xE8DA60", Offset = "0xE8C660", VA = "0x180E8DA60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xE8DA60", Offset = "0xE8C660", VA = "0x180E8DA60", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xE8D9F0", Offset = "0xE8C5F0", VA = "0x180E8D9F0")]
	[IteratorStateMachine(typeof(KFBBGKLNDNO))]
	private static IEnumerable<KeyValuePair<string, int>> GGAGGGOIOEM(IEnumerable<GEJNBLFCEFA> PBHCHHBFFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xE8D8A0", Offset = "0xE8C4A0", VA = "0x180E8D8A0")]
	public void DKEPGHEIMBL(ILGenerator AMBCAJNMJFK, LocalBuilder MOHICFNMKJK, LocalBuilder FFAPAPFLBMB, LocalBuilder GMCMHIFODNN, Action<KeyValuePair<string, int>> BJCJACHKAKA, Action PBAEAECNLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class NAOCDEPLEBA
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo GJPLKGMLFFP;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x15E3780", Offset = "0x15E2380", VA = "0x1815E3780")]
	public static ulong GJDCOJLPIGN(byte[] GLAICJAMEED, ref int BHFOGLICCMI, ref int FFAPAPFLBMB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class MDACDKMBJFN
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xB57010", Offset = "0xB55C10", VA = "0x180B57010")]
	public static void OOIGHFKJAGF(ref byte[] GLAICJAMEED, int BHFOGLICCMI, int GPBEMIHAAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xB56F20", Offset = "0xB55B20", VA = "0x180B56F20")]
	public static void JPAAJPBCMBI(ref byte[] BBFDALJHIIP, int OMEOALBMBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xB56E30", Offset = "0xB55A30", VA = "0x180B56E30")]
	public static byte[] AEJLNGJHEHD(byte[] ABPCDFNAJIH, int OMEOALBMBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JGCINONOACO
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0xB4EC00", Offset = "0xB4D800", VA = "0x180B4EC00")]
	public static bool EOFIHCCDBML(byte[] IAJJNLBCPJC, int FFBJGFMAMJL, int EKMJHMCLMFM, byte[] GLLFAPFKNFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class AAAGDFDPPAG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct NNKOECNCDFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] CGBHHKNJCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T EFFCIDNMALB;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1250040", Offset = "0x124EC40", VA = "0x181250040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DOKENAHJHKF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::AAAGDFDPPAG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private NNKOECNCDFA[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private NNKOECNCDFA[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x124EC20", Offset = "0x124D820", VA = "0x18124EC20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x124F6E0", Offset = "0x124E2E0", VA = "0x18124F6E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x77C3C0", Offset = "0x77AFC0", VA = "0x18077C3C0")]
		[DebuggerHidden]
		public DOKENAHJHKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x124E850", Offset = "0x124D450", VA = "0x18124E850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x124EE70", Offset = "0x124DA70", VA = "0x18124EE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NNKOECNCDFA[][] LLMBHHPEFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong MLHJLJPLEOH;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xDEE2F0", Offset = "0xDECEF0", VA = "0x180DEE2F0")]
	public AAAGDFDPPAG(int EAAJKPJKHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0xDEE320", Offset = "0xDECF20", VA = "0x180DEE320")]
	public AAAGDFDPPAG(int EAAJKPJKHNJ, float OFEMHLNKBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x124AE10", Offset = "0x1249A10", VA = "0x18124AE10")]
	public void DLPDCPCMKFM(byte[] GMCMHIFODNN, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x12489D0", Offset = "0x12475D0", VA = "0x1812489D0")]
	private bool BKLIBNIIEKL(byte[] GMCMHIFODNN, T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x124BC40", Offset = "0x124A840", VA = "0x18124BC40")]
	public bool ICGEJEGNFAB(ArraySegment<byte> GMCMHIFODNN, out T JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0xDEE260", Offset = "0xDECE60", VA = "0x180DEE260")]
	private static ulong OMHAHBHMJKL(byte[] PKLHFCEKMJB, int BHFOGLICCMI, int PMKGCDLMBFP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xDEE230", Offset = "0xDECE30", VA = "0x180DEE230")]
	private static int IJLBJFGOIBA(int FOHPAKENGAM, float OFEMHLNKBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xDEBF30", Offset = "0xDEAB30", VA = "0x180DEBF30", Slot = "4")]
	[IteratorStateMachine(typeof(global::AAAGDFDPPAG<>.DOKENAHJHKF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xDEE2C0", Offset = "0xDECEC0", VA = "0x180DEE2C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class KFCDDGPBPGK : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] LGCCIMHOCAL;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] MCHFMHMFGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int LMGHGNGGKLN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ICHOFEFCAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xB4F360", Offset = "0xB4DF60", VA = "0x180B4F360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xB4F4C0", Offset = "0xB4E0C0", VA = "0x180B4F4C0")]
	static KFCDDGPBPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xB4F710", Offset = "0xB4E310", VA = "0x180B4F710")]
	public KFCDDGPBPGK(byte[] HPPMJHNIBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xB4F3B0", Offset = "0xB4DFB0", VA = "0x180B4F3B0")]
	public OpCode NLFGKGMNEFO()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct CNNNCHHOLEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid EFFCIDNMALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte ADPOJAOMDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte LAAKPMHKEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte FHCGCGHGGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte MDMIODNDAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte IIAHMHPMDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JJLKEBKPHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte IAEMHLCDPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte PNLMIHAMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte JKFHKIHKDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FALEHBPKHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte FKEONOIIDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CDCFKEMPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte LEKONGMFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte AGNLMIIHOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte EAKEFMKPEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte GLPCEEIPFKH;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] MCANHJDCNEF;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] POILOHNOCFF;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xE95C00", Offset = "0xE94800", VA = "0x180E95C00")]
	public CNNNCHHOLEC(ref Guid JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xE95550", Offset = "0xE94150", VA = "0x180E95550")]
	public CNNNCHHOLEC(ref ArraySegment<byte> KHCLEKJKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xE953E0", Offset = "0xE93FE0", VA = "0x180E953E0")]
	private static byte JIDNNMBHOJF(byte[] GLAICJAMEED, int OAINBDLDFAP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xE93F90", Offset = "0xE92B90", VA = "0x180E93F90")]
	private static byte AGIDKMDEBDI(byte JCHDICMDCKL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xE940A0", Offset = "0xE92CA0", VA = "0x180E940A0")]
	public void BJCBCEAEKEH(byte[] KPKLOHHPHLJ, int BHFOGLICCMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class BOFAJPAJLFO
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xE90E80", Offset = "0xE8FA80", VA = "0x180E90E80")]
	public static bool LOIBLAODHCJ(byte DILCHLNKBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xE90F00", Offset = "0xE8FB00", VA = "0x180E90F00")]
	public static bool NCAMBDCIJNO(byte DILCHLNKBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xE905D0", Offset = "0xE8F1D0", VA = "0x180E905D0")]
	public static sbyte DOCFBOGHELL(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xE90E90", Offset = "0xE8FA90", VA = "0x180E90E90")]
	public static short MADCGCBIKDC(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xE8F730", Offset = "0xE8E330", VA = "0x180E8F730")]
	public static int BECIHFKJAHG(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xE91240", Offset = "0xE8FE40", VA = "0x180E91240")]
	public static long PLIANJKNCJP(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xE8F7A0", Offset = "0xE8E3A0", VA = "0x180E8F7A0")]
	public static byte CFIMDABBAOG(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xE8F920", Offset = "0xE8E520", VA = "0x180E8F920")]
	public static ushort DGHNDCKLKKM(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xE90F70", Offset = "0xE8FB70", VA = "0x180E90F70")]
	public static uint PCBLIPHCEKA(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xE8F810", Offset = "0xE8E410", VA = "0x180E8F810")]
	public static ulong CNCMDAIPBFM(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xE8F6C0", Offset = "0xE8E2C0", VA = "0x180E8F6C0")]
	public static float AALEGGLCMLI(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xE90640", Offset = "0xE8F240", VA = "0x180E90640")]
	public static double EMNLFIJHNJP(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xE906B0", Offset = "0xE8F2B0", VA = "0x180E906B0")]
	public static int JJPIAHMOKAG(ref byte[] KPKLOHHPHLJ, int BHFOGLICCMI, ulong JHEBJPCMJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xE8F990", Offset = "0xE8E590", VA = "0x180E8F990")]
	public static int DIPFJHNAEAD(ref byte[] KPKLOHHPHLJ, int BHFOGLICCMI, long JHEBJPCMJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xE90FF0", Offset = "0xE8FBF0", VA = "0x180E90FF0")]
	public static bool PKKMKLKEIKP(byte[] GLAICJAMEED, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class PCFHIBMALDK
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class CGFFLFNDIAK : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public CGFFLFNDIAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x15DDC20", Offset = "0x15DC820", VA = "0x1815DDC20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x15DD7C0", Offset = "0x15DC3C0", VA = "0x1815DD7C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x15DDD40", Offset = "0x15DC940", VA = "0x1815DDD40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x15DDD90", Offset = "0x15DC990", VA = "0x1815DDD90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x15DDBD0", Offset = "0x15DC7D0", VA = "0x1815DDBD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x15DDB20", Offset = "0x15DC720", VA = "0x1815DDB20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x15DDB20", Offset = "0x15DC720", VA = "0x1815DDB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class NDDPNGKOKFM : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x734200", Offset = "0x732E00", VA = "0x180734200")]
		[DebuggerHidden]
		public NDDPNGKOKFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x15E4C70", Offset = "0x15E3870", VA = "0x1815E4C70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x15E4810", Offset = "0x15E3410", VA = "0x1815E4810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x15E4D90", Offset = "0x15E3990", VA = "0x1815E4D90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x15E4DE0", Offset = "0x15E39E0", VA = "0x1815E4DE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15E4C20", Offset = "0x15E3820", VA = "0x1815E4C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x15E4B70", Offset = "0x15E3770", VA = "0x1815E4B70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x15E4B70", Offset = "0x15E3770", VA = "0x1815E4B70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x15E95B0", Offset = "0x15E81B0", VA = "0x1815E95B0")]
	public static bool IBHOMANCFJN(this TypeInfo IONHFMDGLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x15E9450", Offset = "0x15E8050", VA = "0x1815E9450")]
	public static bool DDCOAPCOMDC(this TypeInfo IONHFMDGLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x15E96F0", Offset = "0x15E82F0", VA = "0x1815E96F0")]
	public static IEnumerable<PropertyInfo> OADEMAIINND(this Type IONHFMDGLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x15E93C0", Offset = "0x15E7FC0", VA = "0x1815E93C0")]
	[IteratorStateMachine(typeof(CGFFLFNDIAK))]
	private static IEnumerable<PropertyInfo> DBGHFNLABOA(Type IONHFMDGLFB, HashSet<string> NMGHEPIMOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x15E9550", Offset = "0x15E8150", VA = "0x1815E9550")]
	public static IEnumerable<FieldInfo> FDAEBONMAJE(this Type IONHFMDGLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x15E9660", Offset = "0x15E8260", VA = "0x1815E9660")]
	[IteratorStateMachine(typeof(NDDPNGKOKFM))]
	private static IEnumerable<FieldInfo> KIAMIBIDFEL(Type IONHFMDGLFB, HashSet<string> NMGHEPIMOBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class IDBFBBAPJJL
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding LHKDIAEFJMN;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class MCAKGAIKDIN
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x61FB10", Offset = "0x61E710", VA = "0x18061FB10")]
	public static string GIGHGEKDOBB(string EPDNHJIJDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xB56B50", Offset = "0xB55750", VA = "0x180B56B50")]
	public static string KBONMGAINGK(string EPDNHJIJDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xB56C60", Offset = "0xB55860", VA = "0x180B56C60")]
	public static string OIIGHAHGOHD(string EPDNHJIJDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class MNOLNEKJABF<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class IMGKOMLPDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type CGBHHKNJCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue EFFCIDNMALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int CJAKOBAEMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public IMGKOMLPDGL BMDPDMGFGOK;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3A379F0", Offset = "0x3A365F0", VA = "0x183A379F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3A37970", Offset = "0x3A36570", VA = "0x183A37970")]
		private int IAPBBGBICKL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public IMGKOMLPDGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class NGCAAHNIEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public NGCAAHNIEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x60B9A0", Offset = "0x60A5A0", VA = "0x18060B9A0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private IMGKOMLPDGL[] LLMBHHPEFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int CFIGNJHENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object HEOFENAMNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float OFEMHLNKBKD;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3A41CA0", Offset = "0x3A408A0", VA = "0x183A41CA0")]
	public MNOLNEKJABF(int EAAJKPJKHNJ = 4, float OFEMHLNKBKD = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3A40AE0", Offset = "0x3A3F6E0", VA = "0x183A40AE0")]
	public bool AMIPHNDNCGN(Type GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3A40C30", Offset = "0x3A3F830", VA = "0x183A40C30")]
	public bool AMIPHNDNCGN(Type GMCMHIFODNN, Func<Type, TValue> KIDAELILHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3A40F70", Offset = "0x3A3FB70", VA = "0x183A40F70")]
	private bool BKLIBNIIEKL(Type GMCMHIFODNN, Func<Type, TValue> KIDAELILHAO, out TValue NILAANFKFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3A41510", Offset = "0x3A40110", VA = "0x183A41510")]
	private bool NPBLKNHHONB(IMGKOMLPDGL[] LLMBHHPEFGF, Type FPKELGFBLFG, IMGKOMLPDGL DLHOGBOCHMC, Func<Type, TValue> KIDAELILHAO, out TValue NILAANFKFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3A41270", Offset = "0x3A3FE70", VA = "0x183A41270")]
	public bool ICGEJEGNFAB(Type GMCMHIFODNN, out TValue JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3A40930", Offset = "0x3A3F530", VA = "0x183A40930")]
	public TValue AEMBJBABLKG(Type GMCMHIFODNN, Func<Type, TValue> KIDAELILHAO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xDEE230", Offset = "0xDECE30", VA = "0x180DEE230")]
	private static int IJLBJFGOIBA(int FOHPAKENGAM, float OFEMHLNKBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3A41C70", Offset = "0x3A40870", VA = "0x183A41C70")]
	private static void PPKIDOLENHO(ref IMGKOMLPDGL ALIEMNPBBAA, IMGKOMLPDGL JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3A41C70", Offset = "0x3A40870", VA = "0x183A41C70")]
	private static void PPKIDOLENHO(ref IMGKOMLPDGL[] ALIEMNPBBAA, IMGKOMLPDGL[] JHEBJPCMJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class ILHKBBBEGKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder NIBIKJAGIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder KHHFJFKCAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object HNKDMDHDBCE;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xB4CEB0", Offset = "0xB4BAB0", VA = "0x180B4CEB0")]
	public TypeBuilder FFKFCDGKKJJ(string FFOAIHIIDHB, TypeAttributes BJOCELILJMG, Type IDFFNMDMLBG, Type[] LJGBEGKOFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xB4CFA0", Offset = "0xB4BBA0", VA = "0x180B4CFA0")]
	public ILHKBBBEGKB(string PLDKFFOEFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class AAPAGPFMODO
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xE8B710", Offset = "0xE8A310", VA = "0x180E8B710")]
	private static MethodInfo JOEJBIHFMJB(LambdaExpression GAMDFCCEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x350A130", Offset = "0x3508D30", VA = "0x18350A130")]
	public static MethodInfo MOLNLEFJBLN<T>(Expression<Func<T>> GAMDFCCEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x350A130", Offset = "0x3508D30", VA = "0x18350A130")]
	public static MethodInfo MOLNLEFJBLN<T, TR>(Expression<Func<T, TR>> GAMDFCCEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x350A130", Offset = "0x3508D30", VA = "0x18350A130")]
	public static MethodInfo MOLNLEFJBLN<T>(Expression<Action<T>> GAMDFCCEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x350A130", Offset = "0x3508D30", VA = "0x18350A130")]
	public static MethodInfo MOLNLEFJBLN<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GAMDFCCEDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x350A090", Offset = "0x3508C90", VA = "0x18350A090")]
	private static MemberInfo CDBDCPFEDMD<T>(Expression<T> NFBENFHFKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x350A030", Offset = "0x3508C30", VA = "0x18350A030")]
	public static PropertyInfo BGJHEAFMBJL<T, TR>(Expression<Func<T, TR>> GAMDFCCEDPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct PKFLFEBJHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int EPHKOIPAMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool KEHIPLOAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator AMBCAJNMJFK;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x15EA960", Offset = "0x15E9560", VA = "0x1815EA960")]
	public PKFLFEBJHJC(ILGenerator AMBCAJNMJFK, int EPHKOIPAMCK, bool KEHIPLOAGJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x15EA8D0", Offset = "0x15E94D0", VA = "0x1815EA8D0")]
	public PKFLFEBJHJC(ILGenerator AMBCAJNMJFK, int EPHKOIPAMCK, Type IONHFMDGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x15EA8B0", Offset = "0x15E94B0", VA = "0x1815EA8B0")]
	public void OCKPMFBMAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class LLONPAHIGLF
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xB52EA0", Offset = "0xB51AA0", VA = "0x180B52EA0")]
	public static void CDJKEIFGPAN(this ILGenerator AMBCAJNMJFK, int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xB52E60", Offset = "0xB51A60", VA = "0x180B52E60")]
	public static void CDJKEIFGPAN(this ILGenerator AMBCAJNMJFK, LocalBuilder JMAMGDJHPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xB53E40", Offset = "0xB52A40", VA = "0x180B53E40")]
	public static void PLNGDHMMHGG(this ILGenerator AMBCAJNMJFK, int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xB53E00", Offset = "0xB52A00", VA = "0x180B53E00")]
	public static void PLNGDHMMHGG(this ILGenerator AMBCAJNMJFK, LocalBuilder JMAMGDJHPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xB53C00", Offset = "0xB52800", VA = "0x180B53C00")]
	public static void NKCIGCBGLAL(this ILGenerator AMBCAJNMJFK, int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xB53CF0", Offset = "0xB528F0", VA = "0x180B53CF0")]
	public static void NKCIGCBGLAL(this ILGenerator AMBCAJNMJFK, LocalBuilder JMAMGDJHPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xB53910", Offset = "0xB52510", VA = "0x180B53910")]
	public static void IMJLFMOIGBO(this ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xB536D0", Offset = "0xB522D0", VA = "0x180B536D0")]
	public static void HNGIFONHPEK(this ILGenerator AMBCAJNMJFK, bool JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xB531E0", Offset = "0xB51DE0", VA = "0x180B531E0")]
	public static void GKNAAFEFIPJ(this ILGenerator AMBCAJNMJFK, int JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xB53B10", Offset = "0xB52710", VA = "0x180B53B10")]
	public static void NGPLDFAEBLK(this ILGenerator AMBCAJNMJFK, Type IONHFMDGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xB53630", Offset = "0xB52230", VA = "0x180B53630")]
	public static void HKJBIPMNDOG(this ILGenerator AMBCAJNMJFK, Type IONHFMDGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0xB536E0", Offset = "0xB522E0", VA = "0x180B536E0")]
	public static void IBEMFBHAKEH(this ILGenerator AMBCAJNMJFK, int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xB530D0", Offset = "0xB51CD0", VA = "0x180B530D0")]
	public static void CGDELIDNEJF(this ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xB53A20", Offset = "0xB52620", VA = "0x180B53A20")]
	public static void MBBPLOFHDAN(this ILGenerator AMBCAJNMJFK, int KMCFICBBFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xB53920", Offset = "0xB52520", VA = "0x180B53920")]
	public static void LMKMPHEBJEP(this ILGenerator AMBCAJNMJFK, MethodInfo LLBIBLDMIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xB53150", Offset = "0xB51D50", VA = "0x180B53150")]
	public static void DJLIPFNFKOD(this ILGenerator AMBCAJNMJFK, FieldInfo JGHECONMIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xB52DD0", Offset = "0xB519D0", VA = "0x180B52DD0")]
	public static void AGLAHFAKNGB(this ILGenerator AMBCAJNMJFK, ulong JHEBJPCMJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CCPJACCAPCF
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class ADJKJNJEFNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ADJKJNJEFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA90", Offset = "0xE8A690", VA = "0x180E8BA90")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo GKCDMGCGNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo MIMCAHLJIHI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HDFENLJJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GLPEJBOGLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ONAPCCOCBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE91C00", Offset = "0xE90800", VA = "0x180E91C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FHBHHPHDADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x576EB0", Offset = "0x575AB0", VA = "0x180576EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x620AD0", Offset = "0x61F6D0", VA = "0x180620AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LFJBAJPKPID
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x576EC0", Offset = "0x575AC0", VA = "0x180576EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xBEE520", Offset = "0xBED120", VA = "0x180BEE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type POKPHDGLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x64DDB0", Offset = "0x64C9B0", VA = "0x18064DDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JMHPFCMGONM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo DGMMDOEPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x5520A0", VA = "0x1805534A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5768D0", VA = "0x180577CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo DEDNNAALFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x552800", Offset = "0x551400", VA = "0x180552800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x552880", Offset = "0x551480", VA = "0x180552880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xE91C10", Offset = "0xE90810", VA = "0x180E91C10")]
	protected CCPJACCAPCF(Type IONHFMDGLFB, string FFOAIHIIDHB, string ACMCBDLIOOI, bool OECNENJPHCB, bool PENKIEAMEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xE91E40", Offset = "0xE90A40", VA = "0x180E91E40")]
	public CCPJACCAPCF(FieldInfo MPBBADKKMHG, string FFOAIHIIDHB, bool MDNJGKDBHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xE91C90", Offset = "0xE90890", VA = "0x180E91C90")]
	public CCPJACCAPCF(PropertyInfo MPBBADKKMHG, string FFOAIHIIDHB, bool MDNJGKDBHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xE91A20", Offset = "0xE90620", VA = "0x180E91A20")]
	private static MethodInfo HAIKFINHPFM(MemberInfo MPBBADKKMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D920", Offset = "0x2C0C520", VA = "0x182C0D920")]
	public T JCKHJKAGJHB<T>(bool AEGIBOOPDIG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xE91B40", Offset = "0xE90740", VA = "0x180E91B40", Slot = "4")]
	public virtual void NIHNJFFNCBF(ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xE91960", Offset = "0xE90560", VA = "0x180E91960", Slot = "5")]
	public virtual void GPJDKPEAIJC(ILGenerator AMBCAJNMJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class OFLMAFKKFFG : CCPJACCAPCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string ODPKFNFPKDK;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x15E9030", Offset = "0x15E7C30", VA = "0x1815E9030")]
	public OFLMAFKKFFG(string FFOAIHIIDHB, string ODPKFNFPKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x15E8F70", Offset = "0x15E7B70", VA = "0x1815E8F70", Slot = "4")]
	public override void NIHNJFFNCBF(ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x15E8F20", Offset = "0x15E7B20", VA = "0x1815E8F20", Slot = "5")]
	public override void GPJDKPEAIJC(ILGenerator AMBCAJNMJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class BKHEHBLABOB : CCPJACCAPCF
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo FBPEHPIBPGC;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo PEBFAPAAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal PKFLFEBJHJC HOPJLPOFJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal PKFLFEBJHJC PKJCKEMCIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal PKFLFEBJHJC ACIOPFGHPJH;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xE8F410", Offset = "0xE8E010", VA = "0x180E8F410")]
	public BKHEHBLABOB(string FFOAIHIIDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEB0", Offset = "0xE8DAB0", VA = "0x180E8EEB0", Slot = "4")]
	public override void NIHNJFFNCBF(ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xE8ED50", Offset = "0xE8D950", VA = "0x180E8ED50", Slot = "5")]
	public override void GPJDKPEAIJC(ILGenerator AMBCAJNMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xE8EDA0", Offset = "0xE8D9A0", VA = "0x180E8EDA0")]
	public void JGGNDGOIHAB(ILGenerator AMBCAJNMJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class EKAMNJPMAEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type POKPHDGLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PCIEIOPACDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x811B10", Offset = "0x810710", VA = "0x180811B10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8EB230", Offset = "0x8E9E30", VA = "0x1808EB230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BIGGCOMIJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD670", Offset = "0x8AC270", VA = "0x1808AD670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8EB220", Offset = "0x8E9E20", VA = "0x1808EB220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo NJBHMDKMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CCPJACCAPCF[] KDGKOABNNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x64DDB0", Offset = "0x64C9B0", VA = "0x18064DDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CCPJACCAPCF[] KJAEMADFPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551610", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6131E0", Offset = "0x611DE0", VA = "0x1806131E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xB44160", Offset = "0xB42D60", VA = "0x180B44160")]
	public EKAMNJPMAEJ(Type IONHFMDGLFB, Func<string, string> IHJABLGENEP, bool MDNJGKDBHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xB44090", Offset = "0xB42C90", VA = "0x180B44090")]
	private static bool LKBDFNJGLCE(IEnumerator<ConstructorInfo> KAIPCOINJEC, ref ConstructorInfo KLHFNNHPLJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct PMBJFGACKJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong EMCNBABKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int AADNPGFOACH;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x15EAD50", Offset = "0x15E9950", VA = "0x1815EAD50")]
	public PMBJFGACKJM(ulong BMNBAGDLEBC, int LPKKJKIPNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x15EAD10", Offset = "0x15E9910", VA = "0x1815EAD10")]
	public void IIPLNOBBJLL(ref PMBJFGACKJM DEIAHGDLBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x15EAD20", Offset = "0x15E9920", VA = "0x1815EAD20")]
	public static PMBJFGACKJM MNKOGHMJEED(ref PMBJFGACKJM FIJKOPICOJA, ref PMBJFGACKJM JCHDICMDCKL)
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x15EAC80", Offset = "0x15E9880", VA = "0x1815EAC80")]
	public void IILCHEKOKOH(ref PMBJFGACKJM DEIAHGDLBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x15EAB30", Offset = "0x15E9730", VA = "0x1815EAB30")]
	public static PMBJFGACKJM GMLELCEKHGK(ref PMBJFGACKJM FIJKOPICOJA, ref PMBJFGACKJM JCHDICMDCKL)
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x15EABE0", Offset = "0x15E97E0", VA = "0x1815EABE0")]
	public void HFOPKNNBFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x15EAC20", Offset = "0x15E9820", VA = "0x1815EAC20")]
	public static PMBJFGACKJM HFOPKNNBFOC(ref PMBJFGACKJM FIJKOPICOJA)
	{
		return default(PMBJFGACKJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MAHDDGGGGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] KPKLOHHPHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int BHFOGLICCMI;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xB4BAA0", Offset = "0xB4A6A0", VA = "0x180B4BAA0")]
	public MAHDDGGGGAP(byte[] KPKLOHHPHLJ, int JFHKCFAKLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xB56AF0", Offset = "0xB556F0", VA = "0x180B56AF0")]
	public void NOGKDKDOICG(byte BEFOHGNCAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xB56880", Offset = "0xB55480", VA = "0x180B56880")]
	public void CAOFBJMPDFK(byte[] BEFOHGNCAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xB56A50", Offset = "0xB55650", VA = "0x180B56A50")]
	public void JEKCJEFKBDK(byte[] BEFOHGNCAKG, int GKHAECAMGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xB569A0", Offset = "0xB555A0", VA = "0x180B569A0")]
	public void JEKCJEFKBDK(byte[] BEFOHGNCAKG, int HKPOEHACKEK, int GKHAECAMGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xB56920", Offset = "0xB55520", VA = "0x180B56920")]
	public void ICDFJIDLJKH(byte DILCHLNKBGI, int PMKGCDLMBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xB56780", Offset = "0xB55380", VA = "0x180B56780")]
	public void AMEIEFJFACB(string BEFOHGNCAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class FMCFJLIIIEE
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum AEJLKNLOGBC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum LACKJPFFLCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum DOKLKICEMLJ
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
	private static byte[] IFHFDKJFEMA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] IGPIMNDHBKB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] IICINPIPNHF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] GNOFAODDPHB;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly DOKLKICEMLJ HJDEPMCEIOA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char PFOABNAAKPD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int LOMCFBDJCGJ;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int IKJDAKFDANI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] LDHGIGFJGJD;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xB46180", Offset = "0xB44D80", VA = "0x180B46180")]
	private static byte[] EBFCDNHJBEN(int CFIGNJHENGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xB45EB0", Offset = "0xB44AB0", VA = "0x180B45EB0")]
	private static byte[] ANHKINANEKB(int CFIGNJHENGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xB47BE0", Offset = "0xB467E0", VA = "0x180B47BE0")]
	public static int OOCOKFFAANF(ref byte[] KPKLOHHPHLJ, int BHFOGLICCMI, float JHEBJPCMJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xB47AD0", Offset = "0xB466D0", VA = "0x180B47AD0")]
	public static int OOCOKFFAANF(ref byte[] KPKLOHHPHLJ, int BHFOGLICCMI, double JHEBJPCMJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xB45F90", Offset = "0xB44B90", VA = "0x180B45F90")]
	private static bool BJAEHHPPJPJ(byte[] KPKLOHHPHLJ, int GKHAECAMGEE, ulong JILMGGNCFGH, ulong FNFGFJDAMOE, ulong FFAPAPFLBMB, ulong IJJPLNHCFCN, ulong BNKAMKDDEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xB47560", Offset = "0xB46160", VA = "0x180B47560")]
	private static void MCBLAFMKKAL(uint NMJHOECNFAJ, int MLCGALNKOMO, out uint KLDKFNJCDDE, out int KCANHPEEAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xB47680", Offset = "0xB46280", VA = "0x180B47680")]
	private static bool OAGHODAKJKE(PMBJFGACKJM HDIBBNLHIKO, PMBJFGACKJM DGOIKAEPCOF, PMBJFGACKJM MELLLFHJEGC, byte[] KPKLOHHPHLJ, out int GKHAECAMGEE, out int LOBIAEMNJBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xB46870", Offset = "0xB45470", VA = "0x180B46870")]
	private static bool HIDFFGKPJFB(double LPAKJPLGCCN, AEJLKNLOGBC KGGLFNEDFOJ, byte[] KPKLOHHPHLJ, out int GKHAECAMGEE, out int FONJGIIADBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xB46090", Offset = "0xB44C90", VA = "0x180B46090")]
	private static bool CHNLGBIEBOC(double LPAKJPLGCCN, AEJLKNLOGBC KGGLFNEDFOJ, byte[] KPKLOHHPHLJ, out int GKHAECAMGEE, out int KBNFFMMGIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xB46F70", Offset = "0xB45B70", VA = "0x180B46F70")]
	private static bool ILGEELMKEKP(double JHEBJPCMJGD, ref MAHDDGGGGAP BKMAMOABNGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xB46250", Offset = "0xB44E50", VA = "0x180B46250")]
	private static bool HHHANLEEOIG(double JHEBJPCMJGD, ref MAHDDGGGGAP BKMAMOABNGB, LACKJPFFLCA KGGLFNEDFOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xB47100", Offset = "0xB45D00", VA = "0x180B47100")]
	private static void KAPNILNKKED(byte[] FCFHMPGPBAE, int GKHAECAMGEE, int KBNFFMMGIFI, int NPJEKDJDOCG, ref MAHDDGGGGAP BKMAMOABNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xB46B20", Offset = "0xB45720", VA = "0x180B46B20")]
	private static void IGFBEFJEKMC(byte[] FCFHMPGPBAE, int GKHAECAMGEE, int LPKKJKIPNNI, ref MAHDDGGGGAP BKMAMOABNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xB473E0", Offset = "0xB45FE0", VA = "0x180B473E0")]
	private static bool MALJDKNNCJD(double LPAKJPLGCCN, LACKJPFFLCA KGGLFNEDFOJ, int NACJMFHONEE, byte[] MIFLDDJHOAM, out bool FLAOKDNFPFK, out int GKHAECAMGEE, out int IABANLOJEAM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct LEJAKOMBHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double KOLFADHHADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong GHEJOLMNMIE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct DFNDIJEIANI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float EMCNBABKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint BHAICLMCIBB;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct HGKIINMDNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong PNIPCEOOONC;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xB4ADF0", Offset = "0xB499F0", VA = "0x180B4ADF0")]
	public HGKIINMDNBE(double KOLFADHHADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xB4AE00", Offset = "0xB49A00", VA = "0x180B4AE00")]
	public HGKIINMDNBE(PMBJFGACKJM KOLFADHHADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xB4AD70", Offset = "0xB49970", VA = "0x180B4AD70")]
	public PMBJFGACKJM PNPDHEHHAML()
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xB4A950", Offset = "0xB49550", VA = "0x180B4A950")]
	public PMBJFGACKJM GPEPONBJCGK()
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x60B990", Offset = "0x60A590", VA = "0x18060B990")]
	public ulong MMOEGNNFDCC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xB4ACC0", Offset = "0xB498C0", VA = "0x180B4ACC0")]
	public double MKJCDCHGOIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xB4A8A0", Offset = "0xB494A0", VA = "0x180B4A8A0")]
	public double CKKCPFKLNHO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xB4AAE0", Offset = "0xB496E0", VA = "0x180B4AAE0")]
	public int JIANFFLFODK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xB4A920", Offset = "0xB49520", VA = "0x180B4A920")]
	public ulong ELFNOIFNHAC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xB4AD30", Offset = "0xB49930", VA = "0x180B4AD30")]
	public bool NKMLLBJNIOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xB4ACA0", Offset = "0xB498A0", VA = "0x180B4ACA0")]
	public bool LOMGMJBNBCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xB4AAA0", Offset = "0xB496A0", VA = "0x180B4AAA0")]
	public bool JFCFNKEGDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xB4A800", Offset = "0xB49400", VA = "0x180B4A800")]
	public bool BBPIMGNJMHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xB4A830", Offset = "0xB49430", VA = "0x180B4A830")]
	public int CDPGKNMEKBP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xB4AB10", Offset = "0xB49710", VA = "0x180B4AB10")]
	public void LJLPKNGPHPM(out PMBJFGACKJM AJNCJFPPMBP, out PMBJFGACKJM GNFBHIMJOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xB4A850", Offset = "0xB49450", VA = "0x180B4A850")]
	public bool CELGFMJNHID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xB4AAD0", Offset = "0xB496D0", VA = "0x180B4AAD0")]
	public double JHEBJPCMJGD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xB4AD50", Offset = "0xB49950", VA = "0x180B4AD50")]
	public static int PFMIEKKFDCG(int IEDIKJJOAEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xB4AA90", Offset = "0xB49690", VA = "0x180B4AA90")]
	public static double IBOECNGHIBJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xB4A9F0", Offset = "0xB495F0", VA = "0x180B4A9F0")]
	public static ulong IAODCLDOEEJ(PMBJFGACKJM MFDKEDCNPJP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct FPEABJJLJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint CKPHANNDFAI;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x54F480", Offset = "0x54E080", VA = "0x18054F480")]
	public FPEABJJLJMN(float EMCNBABKKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xB480F0", Offset = "0xB46CF0", VA = "0x180B480F0")]
	public PMBJFGACKJM PNPDHEHHAML()
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0")]
	public uint GMFIOJNELCP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xB47F50", Offset = "0xB46B50", VA = "0x180B47F50")]
	public int JIANFFLFODK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xB47F30", Offset = "0xB46B30", VA = "0x180B47F30")]
	public uint ELFNOIFNHAC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xB480E0", Offset = "0xB46CE0", VA = "0x180B480E0")]
	public bool NKMLLBJNIOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xB47F70", Offset = "0xB46B70", VA = "0x180B47F70")]
	public void LJLPKNGPHPM(out PMBJFGACKJM AJNCJFPPMBP, out PMBJFGACKJM GNFBHIMJOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xB47EF0", Offset = "0xB46AF0", VA = "0x180B47EF0")]
	public bool CELGFMJNHID()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct OHLNKLMNPDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong BMNBAGDLEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short PBEHMCLFEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short FONJGIIADBE;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x15E90E0", Offset = "0x15E7CE0", VA = "0x1815E90E0")]
	public OHLNKLMNPDE(ulong BMNBAGDLEBC, short PBEHMCLFEIG, short FONJGIIADBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class OENAKDILIPO
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly OHLNKLMNPDE[] BJKIJOEEMII;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x15E7840", Offset = "0x15E6440", VA = "0x1815E7840")]
	public static void DLMJBHFECMP(int BPNHJKHPODE, int ODHCDEKGMMD, out PMBJFGACKJM KLDKFNJCDDE, out int FONJGIIADBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x15E7970", Offset = "0x15E6570", VA = "0x1815E7970")]
	public static void DNDOFFBFGKD(int LJFNKEPAKLF, out PMBJFGACKJM KLDKFNJCDDE, out int ONOHDPJNDBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HMKMKCNEJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] GLAICJAMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int HKPOEHACKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int NBJMMEMIFHB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB4BD80", Offset = "0xB4A980", VA = "0x180B4BD80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xB4BDC0", Offset = "0xB4A9C0", VA = "0x180B4BDC0")]
	public HMKMKCNEJJJ(byte[] GLAICJAMEED, int HKPOEHACKEK, int GKHAECAMGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9976B0", Offset = "0x9962B0", VA = "0x1809976B0")]
	public int GKHAECAMGEE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xB4BD20", Offset = "0xB4A920", VA = "0x180B4BD20")]
	public HMKMKCNEJJJ FACGHBCHMEL(int LIKIKPPDKNM, int JLICPMDNNNH)
	{
		return default(HMKMKCNEJJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class LNNKPFHJELK
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] FAPBCPFFBFK;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] IBJKLFMFCFJ;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int IPABDMIFKBO;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xB558E0", Offset = "0xB544E0", VA = "0x180B558E0")]
	private static byte[] EAGJGEACHLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xB554E0", Offset = "0xB540E0", VA = "0x180B554E0")]
	private static HMKMKCNEJJJ CPCACGNEMJM(HMKMKCNEJJJ KPKLOHHPHLJ)
	{
		return default(HMKMKCNEJJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xB559C0", Offset = "0xB545C0", VA = "0x180B559C0")]
	private static HMKMKCNEJJJ IAAGJBGGIHN(HMKMKCNEJJJ KPKLOHHPHLJ)
	{
		return default(HMKMKCNEJJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xB55AA0", Offset = "0xB546A0", VA = "0x180B55AA0")]
	private static void LFKEBFAAFGB(HMKMKCNEJJJ KPKLOHHPHLJ, int LPKKJKIPNNI, byte[] NEHOMNBCIGM, out int ACBGMKILAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xB555C0", Offset = "0xB541C0", VA = "0x180B555C0")]
	private static void DKOJPPFLBNE(HMKMKCNEJJJ KPKLOHHPHLJ, int LPKKJKIPNNI, byte[] APEICLFLBKL, int MEKNHIMGBIC, out HMKMKCNEJJJ MAKMDFNHMMO, out int LLODKPMENMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xB55B50", Offset = "0xB54750", VA = "0x180B55B50")]
	private static ulong LGGGFKOGNOG(HMKMKCNEJJJ KPKLOHHPHLJ, out int MGACPLJCMLH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xB55BE0", Offset = "0xB547E0", VA = "0x180B55BE0")]
	private static void MCBAPPDADPH(HMKMKCNEJJJ KPKLOHHPHLJ, out PMBJFGACKJM JAGEKFPDBNG, out int LCGJOILEBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xB56010", Offset = "0xB54C10", VA = "0x180B56010")]
	private static bool ODOKNLKLOFK(HMKMKCNEJJJ MAKMDFNHMMO, int LPKKJKIPNNI, out double JAGEKFPDBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xB56460", Offset = "0xB55060", VA = "0x180B56460")]
	private static PMBJFGACKJM PDGHIPPLJOH(int LPKKJKIPNNI)
	{
		return default(PMBJFGACKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xB55070", Offset = "0xB53C70", VA = "0x180B55070")]
	private static bool CIFGDACBIHK(HMKMKCNEJJJ KPKLOHHPHLJ, int LPKKJKIPNNI, out double JAGEKFPDBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xB54F40", Offset = "0xB53B40", VA = "0x180B54F40")]
	private static bool APEDNBINDIG(HMKMKCNEJJJ MAKMDFNHMMO, int LPKKJKIPNNI, out double OIPFHALMANE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xB565C0", Offset = "0xB551C0", VA = "0x180B565C0")]
	public static double? PJMBMMMOJGA(HMKMKCNEJJJ KPKLOHHPHLJ, int LPKKJKIPNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xB55D80", Offset = "0xB54980", VA = "0x180B55D80")]
	public static float? ODJLCHJKMMK(HMKMKCNEJJJ KPKLOHHPHLJ, int LPKKJKIPNNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct HJMAKKNOIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] KPKLOHHPHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int BHFOGLICCMI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte EFFCIDNMALB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xB4B890", Offset = "0xB4A490", VA = "0x180B4B890")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xB4BAA0", Offset = "0xB4A6A0", VA = "0x180B4BAA0")]
	public HJMAKKNOIPF(byte[] KPKLOHHPHLJ, int BHFOGLICCMI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xB4B930", Offset = "0xB4A530", VA = "0x180B4B930")]
	public static HJMAKKNOIPF NANINLBPDJJ(HJMAKKNOIPF ADJBCMPCLMH)
	{
		return default(HJMAKKNOIPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xB4BA40", Offset = "0xB4A640", VA = "0x180B4BA40")]
	public static HJMAKKNOIPF OHGKCMEBKBN(HJMAKKNOIPF ADJBCMPCLMH, int GKHAECAMGEE)
	{
		return default(HJMAKKNOIPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xB4B8D0", Offset = "0xB4A4D0", VA = "0x180B4B8D0")]
	public static int JHHDBENEAON(HJMAKKNOIPF CPEDHIPPHNM, HJMAKKNOIPF DPHKKMEJFLG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xB4B9E0", Offset = "0xB4A5E0", VA = "0x180B4B9E0")]
	public static bool NEDFKNPKEMO(HJMAKKNOIPF CPEDHIPPHNM, HJMAKKNOIPF DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xB4B940", Offset = "0xB4A540", VA = "0x180B4B940")]
	public static bool NDELADKHDHK(HJMAKKNOIPF CPEDHIPPHNM, HJMAKKNOIPF DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xB4B9A0", Offset = "0xB4A5A0", VA = "0x180B4B9A0")]
	public static bool NEDFKNPKEMO(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xB4B960", Offset = "0xB4A560", VA = "0x180B4B960")]
	public static bool NDELADKHDHK(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xB4B960", Offset = "0xB4A560", VA = "0x180B4B960")]
	public static bool NDELADKHDHK(HJMAKKNOIPF CPEDHIPPHNM, byte DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xB4BA00", Offset = "0xB4A600", VA = "0x180B4BA00")]
	public static bool NPHCPPDBJAA(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xB4B850", Offset = "0xB4A450", VA = "0x180B4B850")]
	public static bool EIEMKMDHCGP(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xB4B8F0", Offset = "0xB4A4F0", VA = "0x180B4B8F0")]
	public static bool KEFMIEIBAEE(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xB4B810", Offset = "0xB4A410", VA = "0x180B4B810")]
	public static bool EGLEBPDFKCI(HJMAKKNOIPF CPEDHIPPHNM, char DPHKKMEJFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class NADDFOBMHGG
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] MBCGLPMACEI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] FFPAGODMLKK;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] IICINPIPNHF;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] GNOFAODDPHB;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] BGKHLDNFLAB;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int HLMLHBBDBLK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] DBCJINHOHKM;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int DHOBBKLLGIL;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x15E1BC0", Offset = "0x15E07C0", VA = "0x1815E1BC0")]
	private static byte[] DFKDKBCAOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x15E1FA0", Offset = "0x15E0BA0", VA = "0x1815E1FA0")]
	private static byte[] HEOKJHKCHHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x15E1E20", Offset = "0x15E0A20", VA = "0x1815E1E20")]
	public static double EJCLJEKIALP(byte[] KPKLOHHPHLJ, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x15E1EE0", Offset = "0x15E0AE0", VA = "0x1815E1EE0")]
	public static float FACCDKNBFNM(byte[] KPKLOHHPHLJ, int BHFOGLICCMI, out int IIGBDOEOJOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x15E1CA0", Offset = "0x15E08A0", VA = "0x1815E1CA0")]
	private static bool DOMGDFGJAKI(int PKLHFCEKMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x15E1AA0", Offset = "0x15E06A0", VA = "0x1815E1AA0")]
	private static bool COKMKPNBOCB(ref HJMAKKNOIPF LGHCGILILDP, HJMAKKNOIPF DMAGKBIPPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x15E20D0", Offset = "0x15E0CD0", VA = "0x1815E20D0")]
	private static bool NFEFGAMNMBI(ref HJMAKKNOIPF LGHCGILILDP, HJMAKKNOIPF DMAGKBIPPNM, byte[] ALAJHOBNKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x15E2080", Offset = "0x15E0C80", VA = "0x1815E2080")]
	private static bool LKMOKOBPBAG(ref HJMAKKNOIPF PBOGMMFMPJI, byte[] BEFOHGNCAKG, int BHFOGLICCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F4230", Offset = "0x6F2E30", VA = "0x1806F4230")]
	private static double OFEFPNMBFLC(bool FLAOKDNFPFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x15E21E0", Offset = "0x15E0DE0", VA = "0x1815E21E0")]
	private static double NKFODDEJJFP(HJMAKKNOIPF MBMKFFEJLPO, int GKHAECAMGEE, bool FNHEFPJKANC, out int MGPJHBJIOMG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class GONOLOAKMJH<T> : global::FLDEMIEJACD<T[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::EAKEAOELOFN<T> MAGJNKNAPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly DGAIANJENCK HAFLLDMNKGH;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x82BA50", Offset = "0x82A650", VA = "0x18082BA50")]
	public GONOLOAKMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x77C3C0", Offset = "0x77AFC0", VA = "0x18077C3C0")]
	public GONOLOAKMJH(DGAIANJENCK HAFLLDMNKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x82AED0", Offset = "0x829AD0", VA = "0x18082AED0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, T[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x82AAB0", Offset = "0x8296B0", VA = "0x18082AAB0", Slot = "5")]
	public T[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class BAAFMHAIPLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::EAKEAOELOFN<T> MAGJNKNAPEK;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PLEKFKLEIEP<T> : global::FLDEMIEJACD<List<T>>, KKIBEEPOENK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly DGAIANJENCK HAFLLDMNKGH;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x82BA50", Offset = "0x82A650", VA = "0x18082BA50")]
	public PLEKFKLEIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x77C3C0", Offset = "0x77AFC0", VA = "0x18077C3C0")]
	public PLEKFKLEIEP(DGAIANJENCK HAFLLDMNKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x372E5A0", Offset = "0x372D1A0", VA = "0x18372E5A0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, List<T> JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x372D980", Offset = "0x372C580", VA = "0x18372D980", Slot = "5")]
	public List<T> CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class COKBPABKAAK<TElement, TIntermediate, TEnumerator, TCollection> : global::FLDEMIEJACD<TCollection>, KKIBEEPOENK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DF70", Offset = "0x3B4CB70", VA = "0x183B4DF70", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, TCollection JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D350", Offset = "0x3B4BF50", VA = "0x183B4D350", Slot = "5")]
	public TCollection CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HLGOOPCKALG(TCollection NFBENFHFKBO);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JFONNKANKPC();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DLPDCPCMKFM(ref TIntermediate DNAONHNJOEM, int KMCFICBBFCD, TElement JHEBJPCMJGD);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection OMAIJKDLOLK(ref TIntermediate CNDDCPHMDHN);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	protected COKBPABKAAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class ILEHLJLADHG<TElement, TIntermediate, TCollection> : global::COKBPABKAAK<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x763DF0", Offset = "0x7629F0", VA = "0x180763DF0", Slot = "6")]
	protected override IEnumerator<TElement> HLGOOPCKALG(TCollection NFBENFHFKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x100A210", Offset = "0x1008E10", VA = "0x18100A210")]
	protected ILEHLJLADHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class DFDDKJLPOBA<TElement, TCollection> : global::ILEHLJLADHG<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected sealed override TCollection OMAIJKDLOLK(ref TCollection CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class EBPOFJDNEAH<TElement, TCollection> : global::DFDDKJLPOBA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3637D60", Offset = "0x3636960", VA = "0x183637D60", Slot = "7")]
	protected override TCollection JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3637CF0", Offset = "0x36368F0", VA = "0x183637CF0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref TCollection DNAONHNJOEM, int KMCFICBBFCD, TElement JHEBJPCMJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class AOKLKOOFPHD<T> : global::COKBPABKAAK<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x14308B0", Offset = "0x142F4B0", VA = "0x1814308B0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref LinkedList<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override LinkedList<T> OMAIJKDLOLK(ref LinkedList<T> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override LinkedList<T> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2995BE0", Offset = "0x29947E0", VA = "0x182995BE0", Slot = "6")]
	protected override LinkedList<T>.Enumerator HLGOOPCKALG(LinkedList<T> NFBENFHFKBO)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class EAKAKAONEBF<T> : global::COKBPABKAAK<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x14308B0", Offset = "0x142F4B0", VA = "0x1814308B0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref Queue<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override Queue<T> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x32D8180", Offset = "0x32D6D80", VA = "0x1832D8180", Slot = "6")]
	protected override Queue<T>.Enumerator HLGOOPCKALG(Queue<T> NFBENFHFKBO)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override Queue<T> OMAIJKDLOLK(ref Queue<T> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DPOIOGABJAB<T> : global::COKBPABKAAK<T, global::EIDGKFDIIJA<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0xEEB340", Offset = "0xEE9F40", VA = "0x180EEB340", Slot = "8")]
	protected override void DLPDCPCMKFM(ref global::EIDGKFDIIJA<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xEEB3A0", Offset = "0xEE9FA0", VA = "0x180EEB3A0", Slot = "7")]
	protected override global::EIDGKFDIIJA<T> JFONNKANKPC()
	{
		return default(global::EIDGKFDIIJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x32D8180", Offset = "0x32D6D80", VA = "0x1832D8180", Slot = "6")]
	protected override Stack<T>.Enumerator HLGOOPCKALG(Stack<T> NFBENFHFKBO)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x32D81D0", Offset = "0x32D6DD0", VA = "0x1832D81D0", Slot = "9")]
	protected override Stack<T> OMAIJKDLOLK(ref global::EIDGKFDIIJA<T> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PHFKIGHHIJE<T> : global::COKBPABKAAK<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x14308B0", Offset = "0x142F4B0", VA = "0x1814308B0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref HashSet<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override HashSet<T> OMAIJKDLOLK(ref HashSet<T> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override HashSet<T> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x32D8180", Offset = "0x32D6D80", VA = "0x1832D8180", Slot = "6")]
	protected override HashSet<T>.Enumerator HLGOOPCKALG(HashSet<T> NFBENFHFKBO)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MEBFCDFNIHF<T> : global::ILEHLJLADHG<T, global::EIDGKFDIIJA<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xEEB340", Offset = "0xEE9F40", VA = "0x180EEB340", Slot = "8")]
	protected override void DLPDCPCMKFM(ref global::EIDGKFDIIJA<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x396C870", Offset = "0x396B470", VA = "0x18396C870", Slot = "9")]
	protected override ReadOnlyCollection<T> OMAIJKDLOLK(ref global::EIDGKFDIIJA<T> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x396C820", Offset = "0x396B420", VA = "0x18396C820", Slot = "7")]
	protected override global::EIDGKFDIIJA<T> JFONNKANKPC()
	{
		return default(global::EIDGKFDIIJA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MBEGPJLNIPN<T> : global::ILEHLJLADHG<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x14308B0", Offset = "0x142F4B0", VA = "0x1814308B0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref List<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override List<T> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override IList<T> OMAIJKDLOLK(ref List<T> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PIJOKOFINJH<T> : global::ILEHLJLADHG<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x14308B0", Offset = "0x142F4B0", VA = "0x1814308B0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref List<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override List<T> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override ICollection<T> OMAIJKDLOLK(ref List<T> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class BKIPKLACIIK<T> : global::ILEHLJLADHG<T, global::EIDGKFDIIJA<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xEEB340", Offset = "0xEE9F40", VA = "0x180EEB340", Slot = "8")]
	protected override void DLPDCPCMKFM(ref global::EIDGKFDIIJA<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xEEB3A0", Offset = "0xEE9FA0", VA = "0x180EEB3A0", Slot = "7")]
	protected override global::EIDGKFDIIJA<T> JFONNKANKPC()
	{
		return default(global::EIDGKFDIIJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x398A800", Offset = "0x3989400", VA = "0x18398A800", Slot = "9")]
	protected override IEnumerable<T> OMAIJKDLOLK(ref global::EIDGKFDIIJA<T> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class PPMMLPGDIGC<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class ADFLKHPOJHH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PLHKLCOBIGF<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class BPIJFHBBNGI : global::FLDEMIEJACD<IEnumerable>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::FLDEMIEJACD<IEnumerable> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xE91470", Offset = "0xE90070", VA = "0x180E91470", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, IEnumerable JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xE912F0", Offset = "0xE8FEF0", VA = "0x180E912F0", Slot = "5")]
	public IEnumerable CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public BPIJFHBBNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NNAIMKEHPAF : global::FLDEMIEJACD<ICollection>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::FLDEMIEJACD<ICollection> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x15E7450", Offset = "0x15E6050", VA = "0x1815E7450", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ICollection JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x15E7260", Offset = "0x15E5E60", VA = "0x1815E7260", Slot = "5")]
	public ICollection CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public NNAIMKEHPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CPBIKBNNFDM : global::FLDEMIEJACD<IList>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::FLDEMIEJACD<IList> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0xE95D90", Offset = "0xE94990", VA = "0x180E95D90", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, IList JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xE95C10", Offset = "0xE94810", VA = "0x180E95C10", Slot = "5")]
	public IList CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CPBIKBNNFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JIDLKHKEHHC<T> : global::ILEHLJLADHG<T, global::EIDGKFDIIJA<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xEEB370", Offset = "0xEE9F70", VA = "0x180EEB370", Slot = "8")]
	protected override void DLPDCPCMKFM(ref global::EIDGKFDIIJA<T> DNAONHNJOEM, int KMCFICBBFCD, T JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xEEB3A0", Offset = "0xEE9FA0", VA = "0x180EEB3A0", Slot = "7")]
	protected override global::EIDGKFDIIJA<T> JFONNKANKPC()
	{
		return default(global::EIDGKFDIIJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xEEB3F0", Offset = "0xEE9FF0", VA = "0x180EEB3F0", Slot = "9")]
	protected override IReadOnlyList<T> OMAIJKDLOLK(ref global::EIDGKFDIIJA<T> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xEEB430", Offset = "0xEEA030", VA = "0x180EEB430")]
	public JIDLKHKEHHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JAFBJECJJCD
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xB4D990", Offset = "0xB4C590", VA = "0x180B4D990")]
	public static DateTime JNOENIDNKGK(DateTime CDPCGLPGEIE)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class AIGPAEEOIOK : global::FLDEMIEJACD<DateTime>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::FLDEMIEJACD<DateTime> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xE8CC50", Offset = "0xE8B850", VA = "0x180E8CC50", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, DateTime JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xE8BE10", Offset = "0xE8AA10", VA = "0x180E8BE10", Slot = "5")]
	public DateTime CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public AIGPAEEOIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class EICMFAPEDHN : global::FLDEMIEJACD<DateTimeOffset>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::FLDEMIEJACD<DateTimeOffset> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0xB43470", Offset = "0xB42070", VA = "0x180B43470", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, DateTimeOffset JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0xB424D0", Offset = "0xB410D0", VA = "0x180B424D0", Slot = "5")]
	public DateTimeOffset CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public EICMFAPEDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class JBEEPLGDFOM : global::FLDEMIEJACD<TimeSpan>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::FLDEMIEJACD<TimeSpan> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] NLNNPGEHNOC;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xB4E390", Offset = "0xB4CF90", VA = "0x180B4E390", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, TimeSpan JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xB4DA30", Offset = "0xB4C630", VA = "0x180B4DA30", Slot = "5")]
	public TimeSpan CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public JBEEPLGDFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AECKAHFPPGI<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::FLDEMIEJACD<TDictionary>, KKIBEEPOENK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F0F0", Offset = "0x2D4DCF0", VA = "0x182D4F0F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, TDictionary JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E6A0", Offset = "0x2D4D2A0", VA = "0x182D4E6A0", Slot = "5")]
	public TDictionary CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HLGOOPCKALG(TDictionary NFBENFHFKBO);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate JFONNKANKPC();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DLPDCPCMKFM(ref TIntermediate DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary OMAIJKDLOLK(ref TIntermediate CNDDCPHMDHN);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	protected AECKAHFPPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class ICGCKJCNKIL<TKey, TValue, TIntermediate, TDictionary> : global::AECKAHFPPGI<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x763DF0", Offset = "0x7629F0", VA = "0x180763DF0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HLGOOPCKALG(TDictionary NFBENFHFKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class ONMBNCCHKAD<TKey, TValue, TDictionary> : global::ICGCKJCNKIL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override TDictionary OMAIJKDLOLK(ref TDictionary CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class ENLOCKNANHD<TKey, TValue> : global::AECKAHFPPGI<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3685CD0", Offset = "0x36848D0", VA = "0x183685CD0", Slot = "8")]
	protected override void DLPDCPCMKFM(ref Dictionary<TKey, TValue> DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override Dictionary<TKey, TValue> OMAIJKDLOLK(ref Dictionary<TKey, TValue> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override Dictionary<TKey, TValue> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3685D10", Offset = "0x3684910", VA = "0x183685D10", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HLGOOPCKALG(Dictionary<TKey, TValue> NFBENFHFKBO)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x271DB50", Offset = "0x271C750", VA = "0x18271DB50")]
	public ENLOCKNANHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class JDOIPLBBPFB<TKey, TValue, TDictionary> : global::ONMBNCCHKAD<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0xEEAE50", Offset = "0xEE9A50", VA = "0x180EEAE50", Slot = "8")]
	protected override void DLPDCPCMKFM(ref TDictionary DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xEEAEC0", Offset = "0xEE9AC0", VA = "0x180EEAEC0", Slot = "7")]
	protected override TDictionary JFONNKANKPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JKABGJHFPEG<TKey, TValue> : global::ICGCKJCNKIL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE10", Offset = "0xEEAA10", VA = "0x180EEBE10", Slot = "8")]
	protected override void DLPDCPCMKFM(ref Dictionary<TKey, TValue> DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override Dictionary<TKey, TValue> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override IDictionary<TKey, TValue> OMAIJKDLOLK(ref Dictionary<TKey, TValue> CNDDCPHMDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KJBDDOKANIK<TKey, TValue> : global::ONMBNCCHKAD<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE10", Offset = "0xEEAA10", VA = "0x180EEBE10", Slot = "8")]
	protected override void DLPDCPCMKFM(ref SortedList<TKey, TValue> DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override SortedList<TKey, TValue> JFONNKANKPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class CDKJEJLHHIH<TKey, TValue> : global::AECKAHFPPGI<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE10", Offset = "0xEEAA10", VA = "0x180EEBE10", Slot = "8")]
	protected override void DLPDCPCMKFM(ref SortedDictionary<TKey, TValue> DNAONHNJOEM, int KMCFICBBFCD, TKey GMCMHIFODNN, TValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x83EAB0", Offset = "0x83D6B0", VA = "0x18083EAB0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> OMAIJKDLOLK(ref SortedDictionary<TKey, TValue> CNDDCPHMDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xEEBE50", Offset = "0xEEAA50", VA = "0x180EEBE50", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> JFONNKANKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3B433E0", Offset = "0x3B41FE0", VA = "0x183B433E0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HLGOOPCKALG(SortedDictionary<TKey, TValue> NFBENFHFKBO)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class LPMCACDLODJ<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class NFJMMHBPGBP : global::FLDEMIEJACD<IDictionary>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::FLDEMIEJACD<IDictionary> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x15E5570", Offset = "0x15E4170", VA = "0x1815E5570", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, IDictionary JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x15E5250", Offset = "0x15E3E50", VA = "0x1815E5250", Slot = "5")]
	public IDictionary CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public NFJMMHBPGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class LNGDFNPIAON : global::FLDEMIEJACD<object>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void PFEHBIPBBLI(object KLLPNHIBGOI, ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::MNOLNEKJABF<KeyValuePair<object, PFEHBIPBBLI>> AGFHIHALEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly NHMDIGGKGCP[] NFFLIANGBPP;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xB54EA0", Offset = "0xB53AA0", VA = "0x180B54EA0")]
	public LNGDFNPIAON(params NHMDIGGKGCP[] NFFLIANGBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xB54440", Offset = "0xB53040", VA = "0x180B54440", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xB543B0", Offset = "0xB52FB0", VA = "0x180B543B0", Slot = "5")]
	public object CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class PIAEDNKFHND
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x15E97B0", Offset = "0x15E83B0", VA = "0x1815E97B0")]
	public static object GEJNCGFMOOB(Type IONHFMDGLFB, out bool ODHPNHAMPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x15E9F90", Offset = "0x15E8B90", VA = "0x1815E9F90")]
	public static object KODADJJCPGA(Type IONHFMDGLFB, out bool ODHPNHAMPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class PALDFPNJINF<T> : global::FLDEMIEJACD<T>, KKIBEEPOENK, global::OEGOIJEKHMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class JMMLNLINHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public JMMLNLINHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x419CE30", Offset = "0x419BA30", VA = "0x18419CE30")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class FDBKJBFMPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::OFIOLFIFINJ<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public FDBKJBFMPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x419C100", Offset = "0x419AD00", VA = "0x18419C100")]
		internal void <.cctor>b__1(ref KIIEHHNNHHA writer, T value, NHMDIGGKGCP _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ECDDNICMCAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::ILGICHNCKDC<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public ECDDNICMCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x41998F0", Offset = "0x41984F0", VA = "0x1841998F0")]
		internal T <.cctor>b__2(ref MFJNBHDPLKH reader, NHMDIGGKGCP _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::AAAGDFDPPAG<T> NJAEAEGNHJE;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> ENOHILANIHE;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::OFIOLFIFINJ<T> GPLDPOOCIHI;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::ILGICHNCKDC<T> CINKBNLBBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool OFLJBMCPFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::OFIOLFIFINJ<T> AGHACAACGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::ILGICHNCKDC<T> AIPBJKMBEPD;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x41B0FD0", Offset = "0x41AFBD0", VA = "0x1841B0FD0")]
	static PALDFPNJINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3FFEB50", Offset = "0x3FFD750", VA = "0x183FFEB50")]
	public PALDFPNJINF(bool OFLJBMCPFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x41A4130", Offset = "0x41A2D30", VA = "0x1841A4130", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x41A0B20", Offset = "0x419F720", VA = "0x1841A0B20", Slot = "5")]
	public T CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0340", Offset = "0x3FEEF40", VA = "0x183FF0340", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, T JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x41A1B40", Offset = "0x41A0740", VA = "0x1841A1B40", Slot = "7")]
	public T EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class DJPJLPHIHJA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class MOLLILEGDJI<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class FCKCGPMLPLE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class OACDJLNLBIF<T> : global::FLDEMIEJACD<T?>, KKIBEEPOENK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE970", Offset = "0x4AAD570", VA = "0x184AAE970", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, T? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE670", Offset = "0x4AAD270", VA = "0x184AAE670", Slot = "5")]
	public T? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	public OACDJLNLBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class BMODACIKMND<T> : global::FLDEMIEJACD<T?>, KKIBEEPOENK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::FLDEMIEJACD<T> IGHCLPFOFBB;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
	public BMODACIKMND(global::FLDEMIEJACD<T> IGHCLPFOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BE20", Offset = "0x3A0AA20", VA = "0x183A0BE20", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, T? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B1B0", Offset = "0x3A09DB0", VA = "0x183A0B1B0", Slot = "5")]
	public T? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class ECBIMDGDCLB : global::FLDEMIEJACD<sbyte>, KKIBEEPOENK, global::OEGOIJEKHMB<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly ECBIMDGDCLB NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xB42280", Offset = "0xB40E80", VA = "0x180B42280", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, sbyte JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xB42200", Offset = "0xB40E00", VA = "0x180B42200", Slot = "5")]
	public sbyte CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xB422C0", Offset = "0xB40EC0", VA = "0x180B422C0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, sbyte JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xB42210", Offset = "0xB40E10", VA = "0x180B42210", Slot = "7")]
	public sbyte EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public ECBIMDGDCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class KGHFMPCBIAA : global::FLDEMIEJACD<sbyte?>, KKIBEEPOENK, global::OEGOIJEKHMB<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly KGHFMPCBIAA NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xB4F8B0", Offset = "0xB4E4B0", VA = "0x180B4F8B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, sbyte? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xB4F790", Offset = "0xB4E390", VA = "0x180B4F790", Slot = "5")]
	public sbyte? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xB4F930", Offset = "0xB4E530", VA = "0x180B4F930", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, sbyte? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xB4F800", Offset = "0xB4E400", VA = "0x180B4F800", Slot = "7")]
	public sbyte? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public KGHFMPCBIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class DKIIAFCFPLP : global::FLDEMIEJACD<sbyte[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly DKIIAFCFPLP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0xB41990", Offset = "0xB40590", VA = "0x180B41990", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, sbyte[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xB41850", Offset = "0xB40450", VA = "0x180B41850", Slot = "5")]
	public sbyte[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DKIIAFCFPLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class PODLKFEKDOH : global::FLDEMIEJACD<short>, KKIBEEPOENK, global::OEGOIJEKHMB<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PODLKFEKDOH NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x15EAF20", Offset = "0x15E9B20", VA = "0x1815EAF20", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, short JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x15EAE50", Offset = "0x15E9A50", VA = "0x1815EAE50", Slot = "5")]
	public short CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x15EAF40", Offset = "0x15E9B40", VA = "0x1815EAF40", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, short JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x15EAEB0", Offset = "0x15E9AB0", VA = "0x1815EAEB0", Slot = "7")]
	public short EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public PODLKFEKDOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NEICBHCMMAN : global::FLDEMIEJACD<short?>, KKIBEEPOENK, global::OEGOIJEKHMB<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly NEICBHCMMAN NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x15E5100", Offset = "0x15E3D00", VA = "0x1815E5100", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, short? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x15E4FB0", Offset = "0x15E3BB0", VA = "0x1815E4FB0", Slot = "5")]
	public short? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x15E5170", Offset = "0x15E3D70", VA = "0x1815E5170", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, short? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x15E5060", Offset = "0x15E3C60", VA = "0x1815E5060", Slot = "7")]
	public short? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public NEICBHCMMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LNBLHHCBDIJ : global::FLDEMIEJACD<short[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly LNBLHHCBDIJ NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xB541B0", Offset = "0xB52DB0", VA = "0x180B541B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, short[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xB54070", Offset = "0xB52C70", VA = "0x180B54070", Slot = "5")]
	public short[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public LNBLHHCBDIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class DNNGGHGIFGL : global::FLDEMIEJACD<int>, KKIBEEPOENK, global::OEGOIJEKHMB<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly DNNGGHGIFGL NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xB41EA0", Offset = "0xB40AA0", VA = "0x180B41EA0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, int JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB40A20", VA = "0x180B41E20", Slot = "5")]
	public int CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xB41ED0", Offset = "0xB40AD0", VA = "0x180B41ED0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, int JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xB41E30", Offset = "0xB40A30", VA = "0x180B41E30", Slot = "7")]
	public int EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DNNGGHGIFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class ABAHMFNOCDC : global::FLDEMIEJACD<int?>, KKIBEEPOENK, global::OEGOIJEKHMB<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly ABAHMFNOCDC NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xE8B940", Offset = "0xE8A540", VA = "0x180E8B940", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, int? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xE8B800", Offset = "0xE8A400", VA = "0x180E8B800", Slot = "5")]
	public int? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xE8B9B0", Offset = "0xE8A5B0", VA = "0x180E8B9B0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, int? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xE8B870", Offset = "0xE8A470", VA = "0x180E8B870", Slot = "7")]
	public int? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public ABAHMFNOCDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class DIIBGHHBFDN : global::FLDEMIEJACD<int[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly DIIBGHHBFDN NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xE965A0", Offset = "0xE951A0", VA = "0x180E965A0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, int[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xE96460", Offset = "0xE95060", VA = "0x180E96460", Slot = "5")]
	public int[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DIIBGHHBFDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class CEHAADANMFL : global::FLDEMIEJACD<long>, KKIBEEPOENK, global::OEGOIJEKHMB<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly CEHAADANMFL NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xE92040", Offset = "0xE90C40", VA = "0x180E92040", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, long JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xE91F50", Offset = "0xE90B50", VA = "0x180E91F50", Slot = "5")]
	public long CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xE92060", Offset = "0xE90C60", VA = "0x180E92060", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, long JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xE91F60", Offset = "0xE90B60", VA = "0x180E91F60", Slot = "7")]
	public long EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CEHAADANMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class IHMMNDEIHMG : global::FLDEMIEJACD<long?>, KKIBEEPOENK, global::OEGOIJEKHMB<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly IHMMNDEIHMG NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xB4CBE0", Offset = "0xB4B7E0", VA = "0x180B4CBE0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, long? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xB4CA90", Offset = "0xB4B690", VA = "0x180B4CA90", Slot = "5")]
	public long? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xB4CC60", Offset = "0xB4B860", VA = "0x180B4CC60", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, long? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xB4CB20", Offset = "0xB4B720", VA = "0x180B4CB20", Slot = "7")]
	public long? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public IHMMNDEIHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class LBCPJLENGBM : global::FLDEMIEJACD<long[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly LBCPJLENGBM NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xB51320", Offset = "0xB4FF20", VA = "0x180B51320", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, long[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xB511E0", Offset = "0xB4FDE0", VA = "0x180B511E0", Slot = "5")]
	public long[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public LBCPJLENGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class GNCMODLDMED : global::FLDEMIEJACD<byte>, KKIBEEPOENK, global::OEGOIJEKHMB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GNCMODLDMED NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xB4A1C0", Offset = "0xB48DC0", VA = "0x180B4A1C0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, byte JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xB4A140", Offset = "0xB48D40", VA = "0x180B4A140", Slot = "5")]
	public byte CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xB4A200", Offset = "0xB48E00", VA = "0x180B4A200", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, byte JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xB4A150", Offset = "0xB48D50", VA = "0x180B4A150", Slot = "7")]
	public byte EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public GNCMODLDMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class CBOMNFCJMPE : global::FLDEMIEJACD<byte?>, KKIBEEPOENK, global::OEGOIJEKHMB<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly CBOMNFCJMPE NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xE91810", Offset = "0xE90410", VA = "0x180E91810", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, byte? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xE916C0", Offset = "0xE902C0", VA = "0x180E916C0", Slot = "5")]
	public byte? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xE91880", Offset = "0xE90480", VA = "0x180E91880", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, byte? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xE91730", Offset = "0xE90330", VA = "0x180E91730", Slot = "7")]
	public byte? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CBOMNFCJMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class PLAIGNMODEP : global::FLDEMIEJACD<ushort>, KKIBEEPOENK, global::OEGOIJEKHMB<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly PLAIGNMODEP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x15EAA70", Offset = "0x15E9670", VA = "0x1815EAA70", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ushort JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x15EA9A0", Offset = "0x15E95A0", VA = "0x1815EA9A0", Slot = "5")]
	public ushort CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x15EAA90", Offset = "0x15E9690", VA = "0x1815EAA90", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, ushort JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x15EAA00", Offset = "0x15E9600", VA = "0x1815EAA00", Slot = "7")]
	public ushort EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public PLAIGNMODEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class IDLHEKIMHPG : global::FLDEMIEJACD<ushort?>, KKIBEEPOENK, global::OEGOIJEKHMB<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly IDLHEKIMHPG NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xB4C800", Offset = "0xB4B400", VA = "0x180B4C800", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ushort? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xB4C6F0", Offset = "0xB4B2F0", VA = "0x180B4C6F0", Slot = "5")]
	public ushort? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xB4C880", Offset = "0xB4B480", VA = "0x180B4C880", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, ushort? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xB4C760", Offset = "0xB4B360", VA = "0x180B4C760", Slot = "7")]
	public ushort? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public IDLHEKIMHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class IPMBNEHOLEE : global::FLDEMIEJACD<ushort[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IPMBNEHOLEE NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xB4D790", Offset = "0xB4C390", VA = "0x180B4D790", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ushort[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xB4D650", Offset = "0xB4C250", VA = "0x180B4D650", Slot = "5")]
	public ushort[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public IPMBNEHOLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class KOHHDHAKFEI : global::FLDEMIEJACD<uint>, KKIBEEPOENK, global::OEGOIJEKHMB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly KOHHDHAKFEI NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xB50F50", Offset = "0xB4FB50", VA = "0x180B50F50", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, uint JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xB50ED0", Offset = "0xB4FAD0", VA = "0x180B50ED0", Slot = "5")]
	public uint CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xB50F80", Offset = "0xB4FB80", VA = "0x180B50F80", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, uint JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xB50EE0", Offset = "0xB4FAE0", VA = "0x180B50EE0", Slot = "7")]
	public uint EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public KOHHDHAKFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class DCJAMKNBJHF : global::FLDEMIEJACD<uint?>, KKIBEEPOENK, global::OEGOIJEKHMB<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly DCJAMKNBJHF NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xE96310", Offset = "0xE94F10", VA = "0x180E96310", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, uint? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xE961C0", Offset = "0xE94DC0", VA = "0x180E961C0", Slot = "5")]
	public uint? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xE96380", Offset = "0xE94F80", VA = "0x180E96380", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, uint? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xE96230", Offset = "0xE94E30", VA = "0x180E96230", Slot = "7")]
	public uint? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DCJAMKNBJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BINONJGCILI : global::FLDEMIEJACD<uint[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly BINONJGCILI NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xE8EC30", Offset = "0xE8D830", VA = "0x180E8EC30", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, uint[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xE8EAF0", Offset = "0xE8D6F0", VA = "0x180E8EAF0", Slot = "5")]
	public uint[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public BINONJGCILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PKCNCIJIFHC : global::FLDEMIEJACD<ulong>, KKIBEEPOENK, global::OEGOIJEKHMB<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly PKCNCIJIFHC NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x15EA7F0", Offset = "0x15E93F0", VA = "0x1815EA7F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ulong JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x15EA770", Offset = "0x15E9370", VA = "0x1815EA770", Slot = "5")]
	public ulong CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x15EA810", Offset = "0x15E9410", VA = "0x1815EA810", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, ulong JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x15EA780", Offset = "0x15E9380", VA = "0x1815EA780", Slot = "7")]
	public ulong EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public PKCNCIJIFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class AOJFIHOBMCL : global::FLDEMIEJACD<ulong?>, KKIBEEPOENK, global::OEGOIJEKHMB<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly AOJFIHOBMCL NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xE8D750", Offset = "0xE8C350", VA = "0x180E8D750", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ulong? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xE8D600", Offset = "0xE8C200", VA = "0x180E8D600", Slot = "5")]
	public ulong? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xE8D7C0", Offset = "0xE8C3C0", VA = "0x180E8D7C0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, ulong? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0xE8D690", Offset = "0xE8C290", VA = "0x180E8D690", Slot = "7")]
	public ulong? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public AOJFIHOBMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class AOCPCGEBLBH : global::FLDEMIEJACD<ulong[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly AOCPCGEBLBH NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xE8D330", Offset = "0xE8BF30", VA = "0x180E8D330", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ulong[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xE8D1F0", Offset = "0xE8BDF0", VA = "0x180E8D1F0", Slot = "5")]
	public ulong[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public AOCPCGEBLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class LCOGPHNPAMF : global::FLDEMIEJACD<float>, KKIBEEPOENK, global::OEGOIJEKHMB<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly LCOGPHNPAMF NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xB51F70", Offset = "0xB50B70", VA = "0x180B51F70", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, float JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xB51EF0", Offset = "0xB50AF0", VA = "0x180B51EF0", Slot = "5")]
	public float CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xB51F80", Offset = "0xB50B80", VA = "0x180B51F80", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, float JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xB51F00", Offset = "0xB50B00", VA = "0x180B51F00", Slot = "7")]
	public float EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public LCOGPHNPAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FHBILKPAELD : global::FLDEMIEJACD<float?>, KKIBEEPOENK, global::OEGOIJEKHMB<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly FHBILKPAELD NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xB45A10", Offset = "0xB44610", VA = "0x180B45A10", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, float? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0xB45900", Offset = "0xB44500", VA = "0x180B45900", Slot = "5")]
	public float? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44680", VA = "0x180B45A80", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, float? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xB45970", Offset = "0xB44570", VA = "0x180B45970", Slot = "7")]
	public float? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public FHBILKPAELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LELLKLAMAMC : global::FLDEMIEJACD<float[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly LELLKLAMAMC NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xB521D0", Offset = "0xB50DD0", VA = "0x180B521D0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, float[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xB52090", Offset = "0xB50C90", VA = "0x180B52090", Slot = "5")]
	public float[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public LELLKLAMAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class FIFEKBFOJAL : global::FLDEMIEJACD<double>, KKIBEEPOENK, global::OEGOIJEKHMB<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly FIFEKBFOJAL NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xB45C50", Offset = "0xB44850", VA = "0x180B45C50", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, double JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xB45BD0", Offset = "0xB447D0", VA = "0x180B45BD0", Slot = "5")]
	public double CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xB45C60", Offset = "0xB44860", VA = "0x180B45C60", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, double JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xB45BE0", Offset = "0xB447E0", VA = "0x180B45BE0", Slot = "7")]
	public double EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public FIFEKBFOJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class CMAPKMBPJKH : global::FLDEMIEJACD<double?>, KKIBEEPOENK, global::OEGOIJEKHMB<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CMAPKMBPJKH NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xE93E40", Offset = "0xE92A40", VA = "0x180E93E40", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, double? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xE93CA0", Offset = "0xE928A0", VA = "0x180E93CA0", Slot = "5")]
	public double? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xE93EB0", Offset = "0xE92AB0", VA = "0x180E93EB0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, double? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xE93D30", Offset = "0xE92930", VA = "0x180E93D30", Slot = "7")]
	public double? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CMAPKMBPJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GGMJPLLCBPE : global::FLDEMIEJACD<double[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly GGMJPLLCBPE NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xB49AD0", Offset = "0xB486D0", VA = "0x180B49AD0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, double[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xB49990", Offset = "0xB48590", VA = "0x180B49990", Slot = "5")]
	public double[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public GGMJPLLCBPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class OIJMKDDCCLI : global::FLDEMIEJACD<bool>, KKIBEEPOENK, global::OEGOIJEKHMB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly OIJMKDDCCLI NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x15E9170", Offset = "0x15E7D70", VA = "0x1815E9170", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, bool JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x15E90F0", Offset = "0x15E7CF0", VA = "0x1815E90F0", Slot = "5")]
	public bool CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x15E9190", Offset = "0x15E7D90", VA = "0x1815E9190", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, bool JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x15E9100", Offset = "0x15E7D00", VA = "0x1815E9100", Slot = "7")]
	public bool EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public OIJMKDDCCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NAKMDMFNONI : global::FLDEMIEJACD<bool?>, KKIBEEPOENK, global::OEGOIJEKHMB<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NAKMDMFNONI NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x15E3630", Offset = "0x15E2230", VA = "0x1815E3630", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, bool? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x15E3510", Offset = "0x15E2110", VA = "0x1815E3510", Slot = "5")]
	public bool? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x15E36A0", Offset = "0x15E22A0", VA = "0x1815E36A0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, bool? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x15E3580", Offset = "0x15E2180", VA = "0x1815E3580", Slot = "7")]
	public bool? EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public NAKMDMFNONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class BEHLGFKABFB : global::FLDEMIEJACD<bool[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly BEHLGFKABFB NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xE8E8B0", Offset = "0xE8D4B0", VA = "0x180E8E8B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, bool[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xE8E770", Offset = "0xE8D370", VA = "0x180E8E770", Slot = "5")]
	public bool[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public BEHLGFKABFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GBNEOPIHMIF : global::FLDEMIEJACD<object>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::FLDEMIEJACD<object> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> HADICJBJEKA;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xB48400", Offset = "0xB47000", VA = "0x180B48400", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, object JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xB48160", Offset = "0xB46D60", VA = "0x180B48160", Slot = "5")]
	public object CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public GBNEOPIHMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HFHBIDCECOI : global::FLDEMIEJACD<byte[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::FLDEMIEJACD<byte[]> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xB4A6B0", Offset = "0xB492B0", VA = "0x180B4A6B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, byte[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xB4A630", Offset = "0xB49230", VA = "0x180B4A630", Slot = "5")]
	public byte[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public HFHBIDCECOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class MFAMDOGKCFJ : global::FLDEMIEJACD<ArraySegment<byte>>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::FLDEMIEJACD<ArraySegment<byte>> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x15DE1B0", Offset = "0x15DCDB0", VA = "0x1815DE1B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, ArraySegment<byte> JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x15DE0E0", Offset = "0x15DCCE0", VA = "0x1815DE0E0", Slot = "5")]
	public ArraySegment<byte> CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public MFAMDOGKCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DPDJDNPGCGM : global::FLDEMIEJACD<string>, KKIBEEPOENK, global::OEGOIJEKHMB<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::FLDEMIEJACD<string> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xB42180", Offset = "0xB40D80", VA = "0x180B42180", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, string JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xB42170", Offset = "0xB40D70", VA = "0x180B42170", Slot = "5")]
	public string CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xB42180", Offset = "0xB40D80", VA = "0x180B42180", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, string JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xB42170", Offset = "0xB40D70", VA = "0x180B42170", Slot = "7")]
	public string EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DPDJDNPGCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class JGDMEKPNCPC : global::FLDEMIEJACD<string[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly JGDMEKPNCPC NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xB4EDD0", Offset = "0xB4D9D0", VA = "0x180B4EDD0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, string[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xB4EC90", Offset = "0xB4D890", VA = "0x180B4EC90", Slot = "5")]
	public string[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public JGDMEKPNCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class HJNCIINHBMK : global::FLDEMIEJACD<char>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly HJNCIINHBMK NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xB4BB00", Offset = "0xB4A700", VA = "0x180B4BB00", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, char JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xB4BAD0", Offset = "0xB4A6D0", VA = "0x180B4BAD0", Slot = "5")]
	public char CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public HJNCIINHBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class MENJCBOOFLN : global::FLDEMIEJACD<char?>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly MENJCBOOFLN NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x15DDFB0", Offset = "0x15DCBB0", VA = "0x1815DDFB0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, char? JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x15DDEF0", Offset = "0x15DCAF0", VA = "0x1815DDEF0", Slot = "5")]
	public char? CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public MENJCBOOFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class INJLFBKDKBO : global::FLDEMIEJACD<char[]>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly INJLFBKDKBO NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xB4D3B0", Offset = "0xB4BFB0", VA = "0x180B4D3B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, char[] JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xB4D220", Offset = "0xB4BE20", VA = "0x180B4D220", Slot = "5")]
	public char[] CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public INJLFBKDKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class MJCBLKPLFIB : global::FLDEMIEJACD<Guid>, KKIBEEPOENK, global::OEGOIJEKHMB<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::FLDEMIEJACD<Guid> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x15E14D0", Offset = "0x15E00D0", VA = "0x1815E14D0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Guid JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x15E1470", Offset = "0x15E0070", VA = "0x1815E1470", Slot = "5")]
	public Guid CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x15E15B0", Offset = "0x15E01B0", VA = "0x1815E15B0", Slot = "6")]
	public void HLAKNPMHGDH(ref KIIEHHNNHHA BHLBIOMPHHM, Guid JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x15E1470", Offset = "0x15E0070", VA = "0x1815E1470", Slot = "7")]
	public Guid EBGLMCCHDIC(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public MJCBLKPLFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class MHDNIGLFHEP : global::FLDEMIEJACD<decimal>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::FLDEMIEJACD<decimal> NOMEFEEFAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool LHLOFENIOIM;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x111D7E0", Offset = "0x111C3E0", VA = "0x18111D7E0")]
	public MHDNIGLFHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xB59F70", Offset = "0xB58B70", VA = "0x180B59F70")]
	public MHDNIGLFHEP(bool LHLOFENIOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x15E10C0", Offset = "0x15DFCC0", VA = "0x1815E10C0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, decimal JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x15E0F10", Offset = "0x15DFB10", VA = "0x1815E0F10", Slot = "5")]
	public decimal CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class BNDALPKBBOA : global::FLDEMIEJACD<Uri>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::FLDEMIEJACD<Uri> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xE8F5B0", Offset = "0xE8E1B0", VA = "0x180E8F5B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Uri JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0xE8F530", Offset = "0xE8E130", VA = "0x180E8F530", Slot = "5")]
	public Uri CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public BNDALPKBBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PAOIECPJCDK : global::FLDEMIEJACD<Version>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::FLDEMIEJACD<Version> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x15E92B0", Offset = "0x15E7EB0", VA = "0x1815E92B0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Version JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x15E9230", Offset = "0x15E7E30", VA = "0x1815E9230", Slot = "5")]
	public Version CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public PAOIECPJCDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class BLNHJIAPBDL<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class CPODHINLGNO : global::FLDEMIEJACD<StringBuilder>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::FLDEMIEJACD<StringBuilder> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xE96110", Offset = "0xE94D10", VA = "0x180E96110", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, StringBuilder JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xE96090", Offset = "0xE94C90", VA = "0x180E96090", Slot = "5")]
	public StringBuilder CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CPODHINLGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class CIOCJDJEBFI : global::FLDEMIEJACD<BitArray>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::FLDEMIEJACD<BitArray> NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xE93400", Offset = "0xE92000", VA = "0x180E93400", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, BitArray JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xE93300", Offset = "0xE91F00", VA = "0x180E93300", Slot = "5")]
	public BitArray CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public CIOCJDJEBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class CKHBMGIGHCP : global::FLDEMIEJACD<Type>, KKIBEEPOENK
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly CKHBMGIGHCP NOMEFEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex NNLLLHHGALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool PLIKOJGFIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool FEEBIGOKLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool BPABKDHDPGP;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xE938D0", Offset = "0xE924D0", VA = "0x180E938D0")]
	public CKHBMGIGHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xE93880", Offset = "0xE92480", VA = "0x180E93880")]
	public CKHBMGIGHCP(bool PLIKOJGFIDE, bool FEEBIGOKLOG, bool BPABKDHDPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xE936F0", Offset = "0xE922F0", VA = "0x180E936F0", Slot = "4")]
	public void FIHFIFAJGAF(ref KIIEHHNNHHA BHLBIOMPHHM, Type JHEBJPCMJGD, NHMDIGGKGCP BBOCPHOPFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xE935D0", Offset = "0xE921D0", VA = "0x180E935D0", Slot = "5")]
	public Type CIMMFEHKACI(ref MFJNBHDPLKH IBMBDMBMFCG, NHMDIGGKGCP BBOCPHOPFOM)
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
