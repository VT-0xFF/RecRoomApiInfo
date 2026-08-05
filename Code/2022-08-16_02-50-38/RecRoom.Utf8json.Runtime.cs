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
public class CINIGMPOELM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public CINIGMPOELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class MAAMKHAGLKM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public MAAMKHAGLKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DDMDOFNPDGC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public DDMDOFNPDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NOPOBHKFAOP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E4480", Offset = "0x5E3080", VA = "0x1805E4480")]
	public NOPOBHKFAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BBNEJIMIAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x395B770", Offset = "0x395A370", VA = "0x18395B770")]
	public static bool IPJLODBEONL(this TypeInfo HCPDGKICMEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NNHDNIDGPIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type KEJNIPLNPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] DIJODMMNJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x725AD0", Offset = "0x7246D0", VA = "0x180725AD0")]
	public NNHDNIDGPIN(Type HDAFAANLGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class IICFLIJEPGI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void HLPMBFGCNKA<T>(ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T PGNGCNAHINH<T>(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO GKMAGFBIEJL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JCNOPFNCEFO
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GBFELAFCCEK<T> : JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CCIEOMJBIPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LJPONMCMJPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GBFELAFCCEK<T> IJLAMDOPLAO<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OGFMEACEPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2192280", Offset = "0x2190E80", VA = "0x182192280")]
	public static global::GBFELAFCCEK<T> DNKOLDMMGLE<T>(this HOIKBOKFDFO GKMAGFBIEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DA00", Offset = "0x4C2C600", VA = "0x184C2DA00")]
	public static object CGGHOHOBCLC(this HOIKBOKFDFO GKMAGFBIEJL, Type HCPDGKICMEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LCDNFEFABBH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37239E0", Offset = "0x37225E0", VA = "0x1837239E0")]
	public LCDNFEFABBH(string EHGGIAFACBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HFCILADMLMB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OBPEDDONAGH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] GDLCFFFAFKF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] DPGONMMACCN;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37270B0", Offset = "0x3725CB0", VA = "0x1837270B0")]
		public static byte[] NKCIMNPLFEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3727020", Offset = "0x3725C20", VA = "0x183727020")]
		public static char[] GBJDGNLBENF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> OJPNODOFLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] NDMHJBDFBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] DNJADMBKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int HMFFBMGNBCG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool MANFHDOKPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3714B30", Offset = "0x3713730", VA = "0x183714B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3716050", Offset = "0x3714C50", VA = "0x183716050")]
	public HFCILADMLMB(byte[] DNJADMBKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3715E70", Offset = "0x3714A70", VA = "0x183715E70")]
	public HFCILADMLMB(byte[] DNJADMBKFKK, int HMFFBMGNBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37142B0", Offset = "0x3712EB0", VA = "0x1837142B0")]
	private FNICJKBJKBD DODFHHGJGHJ(string NPONPJFDJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3714890", Offset = "0x3713490", VA = "0x183714890")]
	private FNICJKBJKBD EJFKHJCDACA(string EHGGIAFACBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3715050", Offset = "0x3713C50", VA = "0x183715050")]
	public void HNPHGPMFALN(int HMFFBMGNBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0")]
	public byte[] LELAHOJCCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8A34B0", Offset = "0x8A20B0", VA = "0x1808A34B0")]
	public int CFNGIMBELMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37153F0", Offset = "0x3713FF0", VA = "0x1837153F0")]
	public OOHCCHFLGEG JBJCKEJFCKL()
	{
		return default(OOHCCHFLGEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3715A90", Offset = "0x3714690", VA = "0x183715A90")]
	public void OOACEAECEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3714D90", Offset = "0x3713990", VA = "0x183714D90")]
	public bool GPNHDNPHDCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3713E60", Offset = "0x3712A60", VA = "0x183713E60")]
	public bool BKKAACFGNOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3714970", Offset = "0x3713570", VA = "0x183714970")]
	public void EMJEHHJJMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3714800", Offset = "0x3713400", VA = "0x183714800")]
	public bool EHPGHPGKJID(ref int GCKMDOIKFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3714240", Offset = "0x3712E40", VA = "0x183714240")]
	public bool DNOGINHFGHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3715640", Offset = "0x3714240", VA = "0x183715640")]
	public void LKHJAPNFKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3714EF0", Offset = "0x3713AF0", VA = "0x183714EF0")]
	public bool HGOMBMOHNDE(ref int GCKMDOIKFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37152D0", Offset = "0x3713ED0", VA = "0x1837152D0")]
	public bool ILJJHBMDIFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3714A10", Offset = "0x3713610", VA = "0x183714A10")]
	public void ENBBHJACIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3713D90", Offset = "0x3712990", VA = "0x183713D90")]
	public bool BBIJCDHDBGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37156E0", Offset = "0x37142E0", VA = "0x1837156E0")]
	public void MCELMLLDOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37134E0", Offset = "0x37120E0", VA = "0x1837134E0")]
	private void ADAICKHFNFF(out byte[] PHOJDAEKPFO, out int LMCHMINHLAM, out int GONLJJENNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3715340", Offset = "0x3713F40", VA = "0x183715340")]
	private static int IMFDHFIOLAI(char GBHOMBFJPAG, char DBJNEGCCKCM, char CAOLLJDPDGJ, char OHKJMOLJEFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3715BD0", Offset = "0x37147D0", VA = "0x183715BD0")]
	private static int PDODHNOMNDC(char FPNCCNLMGCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3713F50", Offset = "0x3712B50", VA = "0x183713F50")]
	public ArraySegment<byte> CJBCMELAMBF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3715790", Offset = "0x3714390", VA = "0x183715790")]
	public string NPDFNADDKNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3714040", Offset = "0x3712C40", VA = "0x183714040")]
	public string DFHMEFKFADC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3715120", Offset = "0x3713D20", VA = "0x183715120")]
	public ArraySegment<byte> IIHAGELICOL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3714EB0", Offset = "0x3713AB0", VA = "0x183714EB0")]
	public ArraySegment<byte> HGNFHGMIAJI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3715830", Offset = "0x3714430", VA = "0x183715830")]
	public bool OCABIOEJBCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3713C70", Offset = "0x3712870", VA = "0x183713C70")]
	private static bool ALCCPPLBPMO(byte CAOLLJDPDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3714070", Offset = "0x3712C70", VA = "0x183714070")]
	private void DJLKDPNBCJG(OOHCCHFLGEG BNKIDKMECMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3715780", Offset = "0x3714380", VA = "0x183715780")]
	public void NDCJOLJCNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3714F80", Offset = "0x3713B80", VA = "0x183714F80")]
	private void HHPPEMIGIME(int NOHBEALCJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3714750", Offset = "0x3713350", VA = "0x183714750")]
	public sbyte EAHGIJKAHMC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37155E0", Offset = "0x37141E0", VA = "0x1837155E0")]
	public short KCBMALFCLKO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3715580", Offset = "0x3714180", VA = "0x183715580")]
	public int JLNDLKEKDDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3714AB0", Offset = "0x37136B0", VA = "0x183714AB0")]
	public long FILEOKLGGFL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3713E00", Offset = "0x3712A00", VA = "0x183713E00")]
	public byte BKECFEAKLAO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37147A0", Offset = "0x37133A0", VA = "0x1837147A0")]
	public ushort EFAIKMPFPCO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3713D30", Offset = "0x3712930", VA = "0x183713D30")]
	public uint APCBBMJJJOL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3713ED0", Offset = "0x3712AD0", VA = "0x183713ED0")]
	public ulong BLNCMIKFMNC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3715060", Offset = "0x3713C60", VA = "0x183715060")]
	public float IIFADMLKPDC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3714CD0", Offset = "0x37138D0", VA = "0x183714CD0")]
	public double GPBNGHKHGGK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3715CA0", Offset = "0x37148A0", VA = "0x183715CA0")]
	public ArraySegment<byte> PGGANHOKIEF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3714B50", Offset = "0x3713750", VA = "0x183714B50")]
	private static int GJFODPMIEJK(byte[] DNJADMBKFKK, int HMFFBMGNBCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FNICJKBJKBD : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HJLNDNFIKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PEKAEDPKOPB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int POLPDLBAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x151C9E0", Offset = "0x151B5E0", VA = "0x18151C9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DDFBGNAMBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67EE10", Offset = "0x67DA10", VA = "0x18067EE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x370EC90", Offset = "0x370D890", VA = "0x18370EC90")]
	public FNICJKBJKBD(string EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x370EBC0", Offset = "0x370D7C0", VA = "0x18370EBC0")]
	public FNICJKBJKBD(string EHGGIAFACBG, byte[] LACLAIFNMPK, int HMFFBMGNBCG, int PEKAEDPKOPB, string EJCLMOIEDOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IDFAFDGDAIF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NHAKDGAEDDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void PGFNLIMGMIC(ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object IDMMFLHNIGB(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO GKMAGFBIEJL);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class JFCOOLAPFJN
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class PMDBJIALEJE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
				public PMDBJIALEJE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x37275D0", Offset = "0x37261D0", VA = "0x1837275D0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x3727610", Offset = "0x3726210", VA = "0x183727610")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, HOIKBOKFDFO, byte[]> AALDLDKCLID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, HOIKBOKFDFO> PDIANHLEOEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly PGFNLIMGMIC CIOMOOKOEML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, HOIKBOKFDFO, ArraySegment<byte>> LIOICKEMCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, HOIKBOKFDFO, string> FMGADMNAPMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, HOIKBOKFDFO, object> INCJALIIAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, HOIKBOKFDFO, object> OHLFCNMPMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, HOIKBOKFDFO, object> CMLKBMJLGOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly IDMMFLHNIGB AIMOJDFHING;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x371EB50", Offset = "0x371D750", VA = "0x18371EB50")]
			public JFCOOLAPFJN(Type HCPDGKICMEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x33DE560", Offset = "0x33DD160", VA = "0x1833DE560")]
			private static T CCJDOBMKKCL<T>(DynamicMethod BIBFDNBNFJL)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x371E960", Offset = "0x371D560", VA = "0x18371E960")]
			private static MethodInfo FLJBDPLMPFK(Type HCPDGKICMEB, string AMDKCMALAFD, Type[] OMICOJKFMAK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, JFCOOLAPFJN> OCINBNNFIFL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::LJMOEGEKHCB<JFCOOLAPFJN> HLCLFONJNBN;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3726EB0", Offset = "0x3725AB0", VA = "0x183726EB0")]
		static NHAKDGAEDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3726BB0", Offset = "0x37257B0", VA = "0x183726BB0")]
		private static JFCOOLAPFJN BEINJCDLMJJ(Type HCPDGKICMEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3726D40", Offset = "0x3725940", VA = "0x183726D40")]
		public static void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3726C30", Offset = "0x3725830", VA = "0x183726C30")]
		public static void EKJBCLFLGLG(Type HCPDGKICMEB, ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class OBALIIBDCLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] GDLCFFFAFKF;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3726FA0", Offset = "0x3725BA0", VA = "0x183726FA0")]
		public static byte[] NKCIMNPLFEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HOIKBOKFDFO CJMEJAINLLB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] MOHKEELMDMO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] AJJOLCBHFOI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HOIKBOKFDFO FGNNCBDEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x37184D0", Offset = "0x37170D0", VA = "0x1837184D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37185E0", Offset = "0x37171E0", VA = "0x1837185E0")]
	public static void OFIIJPFEDCJ(HOIKBOKFDFO GKMAGFBIEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22181B0", Offset = "0x2216DB0", VA = "0x1822181B0")]
	public static string HLHOCEKHAPJ<T>(T PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2218230", Offset = "0x2216E30", VA = "0x182218230")]
	public static string HLHOCEKHAPJ<T>(T PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33DB120", Offset = "0x33D9D20", VA = "0x1833DB120")]
	public static T OPELNPIHKCP<T>(string JPMLCFACGMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x33DAE80", Offset = "0x33D9A80", VA = "0x1833DAE80")]
	public static T OPELNPIHKCP<T>(string JPMLCFACGMD, HOIKBOKFDFO GKMAGFBIEJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x33DB0A0", Offset = "0x33D9CA0", VA = "0x1833DB0A0")]
	public static T OPELNPIHKCP<T>(byte[] DNJADMBKFKK, HOIKBOKFDFO GKMAGFBIEJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33DAF50", Offset = "0x33D9B50", VA = "0x1833DAF50")]
	public static T OPELNPIHKCP<T>(byte[] DNJADMBKFKK, int HMFFBMGNBCG, HOIKBOKFDFO GKMAGFBIEJL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OOHCCHFLGEG : byte
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
public struct JDFGLOCODHE
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] CNDHFCCCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] GDLCFFFAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int HMFFBMGNBCG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KOODLEBLOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A34B0", Offset = "0x8A20B0", VA = "0x1808A34B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3715050", Offset = "0x3713C50", VA = "0x183715050")]
	public void HNPHGPMFALN(int HMFFBMGNBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x371DE70", Offset = "0x371CA70", VA = "0x18371DE70")]
	public static byte[] JNLBLAJIFCI(string LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x371DD20", Offset = "0x371C920", VA = "0x18371DD20")]
	public static byte[] JKPBKJDPNGK(string LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x371DEF0", Offset = "0x371CAF0", VA = "0x18371DEF0")]
	public static byte[] KOOECPMEFNJ(string LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x371E240", Offset = "0x371CE40", VA = "0x18371E240")]
	public static byte[] PNEONKKDEKO(string LOBDPBBMIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD7B2A0", Offset = "0xD79EA0", VA = "0x180D7B2A0")]
	public JDFGLOCODHE(byte[] GPFDMNGGJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x371E180", Offset = "0x371CD80", VA = "0x18371E180")]
	public ArraySegment<byte> NKCIMNPLFEP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x371DBD0", Offset = "0x371C7D0", VA = "0x18371DBD0")]
	public byte[] JICOOFMNDDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x371E3A0", Offset = "0x371CFA0", VA = "0x18371E3A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x371E230", Offset = "0x371CE30", VA = "0x18371E230")]
	public void PDNFMEFDKJB(int LDAOHLBMDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x371E070", Offset = "0x371CC70", VA = "0x18371E070")]
	public void LKGAFNIDHNP(byte[] BJDMGNIELJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x371DB10", Offset = "0x371C710", VA = "0x18371DB10")]
	public void IMCPHAFBIHM(byte BJDMGNIELJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x371DFF0", Offset = "0x371CBF0", VA = "0x18371DFF0")]
	public void LDLANHLPAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x371D600", Offset = "0x371C200", VA = "0x18371D600")]
	public void CKFKLLGPHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x371DA60", Offset = "0x371C660", VA = "0x18371DA60")]
	public void HMHONLGJELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x371D940", Offset = "0x371C540", VA = "0x18371D940")]
	public void GCBEHKMLLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x371E0D0", Offset = "0x371CCD0", VA = "0x18371E0D0")]
	public void LPMIGMKHKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x371D8F0", Offset = "0x371C4F0", VA = "0x18371D8F0")]
	public void GBIFLAPIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x371DAB0", Offset = "0x371C6B0", VA = "0x18371DAB0")]
	public void ILDNEAENNAE(string LOBDPBBMIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x371DB50", Offset = "0x371C750", VA = "0x18371DB50")]
	public void IPPMMKHKHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x371D990", Offset = "0x371C590", VA = "0x18371D990")]
	public void HBIGHPFNGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x371D700", Offset = "0x371C300", VA = "0x18371D700")]
	public void FLGKKLMOPMJ(bool PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x371D680", Offset = "0x371C280", VA = "0x18371D680")]
	public void EFNKOLFAKOH(float PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x371DDF0", Offset = "0x371C9F0", VA = "0x18371DDF0")]
	public void JMLKEDDDNFK(double PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x371D5D0", Offset = "0x371C1D0", VA = "0x18371D5D0")]
	public void CEIDKOLJFON(byte PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x371D5A0", Offset = "0x371C1A0", VA = "0x18371D5A0")]
	public void BOAGNEHOOFG(ushort PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x371E040", Offset = "0x371CC40", VA = "0x18371E040")]
	public void LHBCJKGFBED(uint PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x371D650", Offset = "0x371C250", VA = "0x18371D650")]
	public void EEGPEAAMMOF(ulong PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x371E150", Offset = "0x371CD50", VA = "0x18371E150")]
	public void NDNGBEOLJDP(sbyte PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x371E120", Offset = "0x371CD20", VA = "0x18371E120")]
	public void MLHAFAAAFIK(short PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x371DBA0", Offset = "0x371C7A0", VA = "0x18371DBA0")]
	public void JFIPKDFCEGO(int PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x371DFC0", Offset = "0x371CBC0", VA = "0x18371DFC0")]
	public void LAADLKGGFMG(long PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x371D1D0", Offset = "0x371BDD0", VA = "0x18371D1D0")]
	public void BFNMIAFOPCI(string PDMPLJICJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KEBNDFICDOB : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class OHBMJLIJIPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3135A20", Offset = "0x3134620", VA = "0x183135A20")]
		static OHBMJLIJIPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private KEBNDFICDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class NBFLOLIAGIL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> EJBJCCLNLDM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A2C0", Offset = "0x4C28EC0", VA = "0x184C2A2C0")]
	static NBFLOLIAGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D60", Offset = "0x4C28960", VA = "0x184C29D60")]
	internal static object IJLAMDOPLAO(Type JJBHDPAHMPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PKEEMJNIAEP : global::GBFELAFCCEK<Vector2>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4C32520", Offset = "0x4C31120", VA = "0x184C32520")]
	public PKEEMJNIAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C322F0", Offset = "0x4C30EF0", VA = "0x184C322F0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Vector2 PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C323A0", Offset = "0x4C30FA0", VA = "0x184C323A0", Slot = "5")]
	public Vector2 OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PKEJHMAGJMP : global::GBFELAFCCEK<Vector3>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4C32A00", Offset = "0x4C31600", VA = "0x184C32A00")]
	public PKEJHMAGJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4C326F0", Offset = "0x4C312F0", VA = "0x184C326F0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Vector3 PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4C32810", Offset = "0x4C31410", VA = "0x184C32810", Slot = "5")]
	public Vector3 OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EAEFNLHGEII : global::GBFELAFCCEK<Vector4>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39695A0", Offset = "0x39681A0", VA = "0x1839695A0")]
	public EAEFNLHGEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3969220", Offset = "0x3967E20", VA = "0x183969220", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Vector4 PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3969370", Offset = "0x3967F70", VA = "0x183969370", Slot = "5")]
	public Vector4 OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MCLKMAOFHAC : global::GBFELAFCCEK<Quaternion>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4C25E00", Offset = "0x4C24A00", VA = "0x184C25E00")]
	public MCLKMAOFHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3969220", Offset = "0x3967E20", VA = "0x183969220", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Quaternion PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C25BD0", Offset = "0x4C247D0", VA = "0x184C25BD0", Slot = "5")]
	public Quaternion OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GGPNECIMAHK : global::GBFELAFCCEK<Color>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3711530", Offset = "0x3710130", VA = "0x183711530")]
	public GGPNECIMAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3710F40", Offset = "0x370FB40", VA = "0x183710F40", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Color PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x37111B0", Offset = "0x370FDB0", VA = "0x1837111B0", Slot = "5")]
	public Color OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GDHEDHGLPBE : global::GBFELAFCCEK<Bounds>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x370FA90", Offset = "0x370E690", VA = "0x18370FA90")]
	public GDHEDHGLPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x370F390", Offset = "0x370DF90", VA = "0x18370F390", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Bounds PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x370F690", Offset = "0x370E290", VA = "0x18370F690", Slot = "5")]
	public Bounds OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class BNGHGAIEACH : global::GBFELAFCCEK<Rect>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GOHPBPLHEPK FJLGKMKJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] FEKFANFNFJA;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x395BEF0", Offset = "0x395AAF0", VA = "0x18395BEF0")]
	public BNGHGAIEACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x395BB20", Offset = "0x395A720", VA = "0x18395BB20", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Rect PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x395BC90", Offset = "0x395A890", VA = "0x18395BC90", Slot = "5")]
	public Rect OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PAPPIAFIDKP : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class PKLOHBIHMCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x405E890", Offset = "0x405D490", VA = "0x18405E890")]
		static PKLOHBIHMCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private PAPPIAFIDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JDJIIBIOPCN : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class GMAOLFOPIOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x31F4D70", Offset = "0x31F3970", VA = "0x1831F4D70")]
		static GMAOLFOPIOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KEPPBLLDCFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MAIFMNAMMEA;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3721630", Offset = "0x3720230", VA = "0x183721630")]
		internal static object IJLAMDOPLAO(Type JJBHDPAHMPA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private JDJIIBIOPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DDINPDDDKFK : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LHCPEMJMPOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x491DA40", Offset = "0x491C640", VA = "0x18491DA40")]
		static LHCPEMJMPOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DDINPDDDKFK PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool BNPPEIECMGD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static JCNOPFNCEFO[] NPFEDMBAFPO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static HOIKBOKFDFO[] EJEGOPDKKPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private DDINPDDDKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x39672A0", Offset = "0x3965EA0", VA = "0x1839672A0")]
	public static void LGPGOGPHNHB(params HOIKBOKFDFO[] EJEGOPDKKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x39671E0", Offset = "0x3965DE0", VA = "0x1839671E0")]
	public static void LGPGOGPHNHB(params JCNOPFNCEFO[] NPFEDMBAFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3966F90", Offset = "0x3965B90", VA = "0x183966F90")]
	public static void ACIDCNEPMBM(JCNOPFNCEFO[] NPFEDMBAFPO, HOIKBOKFDFO[] EJEGOPDKKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class LIMAADMPFMI : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class KGNJGLPNBFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x34E1380", Offset = "0x34DFF80", VA = "0x1834E1380")]
		static KGNJGLPNBFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private LIMAADMPFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NBBEBNPMIFK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly HOIKBOKFDFO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly HOIKBOKFDFO MBGKGJCNKME;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly HOIKBOKFDFO IPNJFOBIFJA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly HOIKBOKFDFO KAPJOIEGHNG;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly HOIKBOKFDFO KIHMKOCMHED;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly HOIKBOKFDFO HPKHIKONNIM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly HOIKBOKFDFO EPGGMCENFOC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly HOIKBOKFDFO LPAOFFCGKJI;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly HOIKBOKFDFO CMIPCKHCANG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly HOIKBOKFDFO HPGJECBHPIG;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly HOIKBOKFDFO EFDCGMICEHI;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly HOIKBOKFDFO AFKNGIGALKN;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MNLFMLIAIHE
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly HOIKBOKFDFO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly HOIKBOKFDFO BMCLBLGKPNC;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IBKKOMEBOAF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly HOIKBOKFDFO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly HOIKBOKFDFO MBGKGJCNKME;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly HOIKBOKFDFO IPNJFOBIFJA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly HOIKBOKFDFO KAPJOIEGHNG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly HOIKBOKFDFO KIHMKOCMHED;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly HOIKBOKFDFO HPKHIKONNIM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly HOIKBOKFDFO EPGGMCENFOC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly HOIKBOKFDFO LPAOFFCGKJI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly HOIKBOKFDFO CMIPCKHCANG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HOIKBOKFDFO HPGJECBHPIG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly HOIKBOKFDFO EFDCGMICEHI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HOIKBOKFDFO AFKNGIGALKN;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class HKNPMBMDFAD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MAIFMNAMMEA;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3716460", Offset = "0x3715060", VA = "0x183716460")]
	internal static object IJLAMDOPLAO(Type JJBHDPAHMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3717A50", Offset = "0x3716650", VA = "0x183717A50")]
	private static object KGEBPHPBNEM(Type NKCLPBBAMFL, Type[] JKHNOJEDFMP, params object[] OMICOJKFMAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class KPFPGAGNEGL : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class KMOOJCKCPNC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x44E3D60", Offset = "0x44E2960", VA = "0x1844E3D60")]
		static KMOOJCKCPNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3723630", Offset = "0x3722230", VA = "0x183723630")]
	static KPFPGAGNEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private KPFPGAGNEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class KFHFHDCLHBB : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class JNDHLANJOIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x312E040", Offset = "0x312CC40", VA = "0x18312E040")]
		static JNDHLANJOIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3722DF0", Offset = "0x37219F0", VA = "0x183722DF0")]
	static KFHFHDCLHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private KFHFHDCLHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class DFAHDEIDMOD : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PMFONEAKMJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B62B50", Offset = "0x4B61750", VA = "0x184B62B50")]
		static PMFONEAKMJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3967420", Offset = "0x3966020", VA = "0x183967420")]
	static DFAHDEIDMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private DFAHDEIDMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class LHEPODMJEJJ : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class GHJELDINMDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4892C30", Offset = "0x4891830", VA = "0x184892C30")]
		static GHJELDINMDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3723DF0", Offset = "0x37229F0", VA = "0x183723DF0")]
	static LHEPODMJEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private LHEPODMJEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class MEHCLKOGBGB : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class AOFKDFJLKMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x38F6200", Offset = "0x38F4E00", VA = "0x1838F6200")]
		static AOFKDFJLKMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C260F0", Offset = "0x4C24CF0", VA = "0x184C260F0")]
	static MEHCLKOGBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private MEHCLKOGBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class ACHEOGAEONH : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class ECALJEJGDNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x44BB3F0", Offset = "0x44B9FF0", VA = "0x1844BB3F0")]
		static ECALJEJGDNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly FODHAEEFNDJ AKBBMJBOHOK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x395A1F0", Offset = "0x3958DF0", VA = "0x18395A1F0")]
	static ACHEOGAEONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private ACHEOGAEONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class INPLIAEHGKC : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class FDGDNOAPOAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3FFBB60", Offset = "0x3FFA760", VA = "0x183FFBB60")]
		static FDGDNOAPOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public INPLIAEHGKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class HHFOKJFALPN : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class FHHNGHLKBNG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4399260", Offset = "0x4397E60", VA = "0x184399260")]
		static FHHNGHLKBNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HHFOKJFALPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class OCJEOBIDALC : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class EBPGBJFKKGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B140", Offset = "0x2A49D40", VA = "0x182A4B140")]
		static EBPGBJFKKGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OCJEOBIDALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class FLDIFNEFKCE : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class IGIMNOOIMNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2107FF0", Offset = "0x2106BF0", VA = "0x182107FF0")]
		static IGIMNOOIMNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FLDIFNEFKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class FAGKPEFDLIO : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class HLCPMAOFIIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C05320", Offset = "0x3C03F20", VA = "0x183C05320")]
		static HLCPMAOFIIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FAGKPEFDLIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DNHLLHEIJKJ : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class FNFHHODFDJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x22C0090", Offset = "0x22BEC90", VA = "0x1822C0090")]
		static FNFHHODFDJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> OBLOKKBDAGI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DMJAIKIGMJJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public DNHLLHEIJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class BNGOFBJMOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct KACPAAAHGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CAGCBJEHKLL LPHJCKPPEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder BOPBECMHCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HGMNLDEPCHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class IHNDCGKKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class GBLJHAIJLAE
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KOOECPMEFNJ;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo JKPBKJDPNGK;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo PNEONKKDEKO;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo JNLBLAJIFCI;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo HBIGHPFNGJD;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo LKGAFNIDHNP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo HMHONLGJELG;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo GCBEHKMLLLF;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo LPMIGMKHKAM;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x396DC80", Offset = "0x396C880", VA = "0x18396DC80")]
			static GBLJHAIJLAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class JPMCFMPNECP
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo GPNHDNPHDCG;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo LKHJAPNFKGG;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HGOMBMOHNDE;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo PLOKMJMGLAJ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo NDCJOLJCNAH;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo LELAHOJCCKN;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo CFNGIMBELMG;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3970610", Offset = "0x396F210", VA = "0x183970610")]
			static JPMCFMPNECP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class AMCJNGFDLKB
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo KEJNIPLNPKA;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo DIJODMMNJMN;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MAODFICBPFB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo DNKOLDMMGLE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo KKNIOFMLHNK;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo LLHCEBHNMHM;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GHAKMFCHMAA;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo LDIMKAAKCMK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo EHMEAGLIPLG;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo CEKJGGDAPOH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo GOHKKCFGPCB;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo POJAGJKIFFO;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo MFIGNICLBMP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo LLEHGKEGNAH;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x396EBE0", Offset = "0x396D7E0", VA = "0x18396EBE0")]
		public static MethodInfo EKJBCLFLGLG(Type HCPDGKICMEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x396EE70", Offset = "0x396DA70", VA = "0x18396EE70")]
		public static MethodInfo OPELNPIHKCP(Type HCPDGKICMEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x396F0A0", Offset = "0x396DCA0", VA = "0x18396F0A0")]
		public static MethodInfo PGKLIBOGKJD(Type HCPDGKICMEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FGNHAHKDEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CAGCBJEHKLL, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FGNHAHKDEIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BMMJDDCFJCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FGNHAHKDEIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public BMMJDDCFJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x395BA40", Offset = "0x395A640", VA = "0x18395BA40")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x395BA80", Offset = "0x395A680", VA = "0x18395BA80")]
		internal bool <BuildType>b__2(int index, CAGCBJEHKLL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GLHDBHHHALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FGNHAHKDEIA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public GLHDBHHHALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x396E9C0", Offset = "0x396D5C0", VA = "0x18396E9C0")]
		internal bool <BuildType>b__3(int index, CAGCBJEHKLL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MOPPGLJEIOM
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public MOPPGLJEIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3971110", Offset = "0x396FD10", VA = "0x183971110")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AOLHKJODPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public AOLHKJODPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x395B620", Offset = "0x395A220", VA = "0x18395B620")]
		internal bool <BuildAnonymousFormatter>b__2(CAGCBJEHKLL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CHFPFAAICOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MOPPGLJEIOM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public CHFPFAAICOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3966A60", Offset = "0x3965660", VA = "0x183966A60")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3966A70", Offset = "0x3965670", VA = "0x183966A70")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CAGCBJEHKLL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class DMBCFGIFBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MOPPGLJEIOM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public DMBCFGIFBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3967E20", Offset = "0x3966A20", VA = "0x183967E20")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CAGCBJEHKLL member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FDHOEIFKEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FDHOEIFKEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC0", Offset = "0x5EB8C0", VA = "0x1805ECCC0")]
		internal Label <BuildSerialize>b__1(CAGCBJEHKLL _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class AJGJPHHELMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public KACPAAAHGLB[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CAGCBJEHKLL, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public APNFKNLPJCH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public APNFKNLPJCH argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public AJGJPHHELMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x395A730", Offset = "0x3959330", VA = "0x18395A730")]
		internal KACPAAAHGLB <BuildDeserialize>b__0(CAGCBJEHKLL item)
		{
			return default(KACPAAAHGLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class AALLFMLPCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AJGJPHHELMC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public AALLFMLPCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3959D60", Offset = "0x3958960", VA = "0x183959D60")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x395A010", Offset = "0x3958C10", VA = "0x18395A010")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FNECNPAANHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CAGCBJEHKLL item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FNECNPAANHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x14EE880", Offset = "0x14ED480", VA = "0x1814EE880")]
		internal bool <EmitNewObject>b__0(KACPAAAHGLB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HJNGMKAGOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CAGCBJEHKLL item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public HJNGMKAGOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x14EE880", Offset = "0x14ED480", VA = "0x1814EE880")]
		internal bool <EmitNewObject>b__2(KACPAAAHGLB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex EFIOPLHCPLN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KINBEFCBGOC;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> OOGIOCDHGIB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NJLGKGNMMGD;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E63320", Offset = "0x2E61F20", VA = "0x182E63320")]
	public static object GBFKJMLEOAK<T>(FODHAEEFNDJ AKBBMJBOHOK, HOIKBOKFDFO DPELMJJKLEG, Func<string, string> OBLOKKBDAGI, bool DMJAIKIGMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BDD0", Offset = "0x2E5A9D0", VA = "0x182E5BDD0")]
	public static object ADJLHFLHCHP<T>(HOIKBOKFDFO DPELMJJKLEG, Func<string, string> OBLOKKBDAGI, bool DMJAIKIGMJJ, bool PJPIAIPDPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x395C1E0", Offset = "0x395ADE0", VA = "0x18395C1E0")]
	private static TypeInfo EBNODEPFLNF(FODHAEEFNDJ AKBBMJBOHOK, Type HCPDGKICMEB, Func<string, string> OBLOKKBDAGI, bool DMJAIKIGMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3960660", Offset = "0x395F260", VA = "0x183960660")]
	public static object OCMNLHKMJBG(Type HCPDGKICMEB, Func<string, string> OBLOKKBDAGI, bool DMJAIKIGMJJ, bool PJPIAIPDPAM, bool LNMNNLGBDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3963670", Offset = "0x3962270", VA = "0x183963670")]
	private static Dictionary<CAGCBJEHKLL, FieldInfo> PCIHDGALJDG(TypeBuilder ALAGAPKDKIL, LJLGKKLHPKF DGFLPFMPLJK, ConstructorInfo BKELFKBKEFL, FieldBuilder JBKALLKNLPL, ILGenerator BJJMHHFCDMP, bool DMJAIKIGMJJ, bool PCBPOKCBEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x395CC80", Offset = "0x395B880", VA = "0x18395CC80")]
	private static Dictionary<CAGCBJEHKLL, FieldInfo> ENPJNLNJFCL(TypeBuilder ALAGAPKDKIL, LJLGKKLHPKF DGFLPFMPLJK, ILGenerator BJJMHHFCDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x395D250", Offset = "0x395BE50", VA = "0x18395D250")]
	private static void FIAJLLNFBCA(Type HCPDGKICMEB, LJLGKKLHPKF DGFLPFMPLJK, ILGenerator BJJMHHFCDMP, Action EFCGOIIBKHB, Func<int, CAGCBJEHKLL, bool> NNBKJGIGJHD, bool DMJAIKIGMJJ, bool PCBPOKCBEFH, int PJNMBBALMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x395EDC0", Offset = "0x395D9C0", VA = "0x18395EDC0")]
	private static void IPAPMKPJPAO(TypeInfo HCPDGKICMEB, CAGCBJEHKLL CAAPCNBKDLN, ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF, Func<int, CAGCBJEHKLL, bool> NNBKJGIGJHD, APNFKNLPJCH BFKGLJCKHHO, APNFKNLPJCH GCJKLACHJAL, APNFKNLPJCH DDKHDOIKIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x395F390", Offset = "0x395DF90", VA = "0x18395F390")]
	private static void MPNMMIOKMJM(Type HCPDGKICMEB, LJLGKKLHPKF DGFLPFMPLJK, ILGenerator BJJMHHFCDMP, Func<int, CAGCBJEHKLL, bool> NNBKJGIGJHD, bool EOPIJCFGFNO, int PJNMBBALMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x395E910", Offset = "0x395D510", VA = "0x18395E910")]
	private static void IJJJCEIHLCE(ILGenerator BJJMHHFCDMP, KACPAAAHGLB DGFLPFMPLJK, int BAOHKIGDOBF, Func<int, CAGCBJEHKLL, bool> NNBKJGIGJHD, APNFKNLPJCH CPAEFKPNLIE, APNFKNLPJCH DDKHDOIKIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3962A00", Offset = "0x3961600", VA = "0x183962A00")]
	private static LocalBuilder PAGBGAAPJOP(ILGenerator BJJMHHFCDMP, Type HCPDGKICMEB, LJLGKKLHPKF DGFLPFMPLJK, KACPAAAHGLB[] CGNNNGCGAHK, bool CNJEINKEPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39621D0", Offset = "0x3960DD0", VA = "0x1839621D0")]
	private static bool OOEGKIIBLPP(ConstructorInfo FLPBLPJPJII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3962030", Offset = "0x3960C30", VA = "0x183962030")]
	private static bool OLCMGANMFNB(Type HCPDGKICMEB, out Type OEGGKICNAPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void OBGNKFHOEJJ<T>(byte[][] JBKALLKNLPL, object[] LCCPJKFIJJN, ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO GKMAGFBIEJL);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T BBPLKGGLGLA<T>(object[] LCCPJKFIJJN, ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO GKMAGFBIEJL);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class MJEEKNMDFIA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class PBHKKCEBHGD : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class MNDOCKMGPNA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4049100", Offset = "0x4047D00", VA = "0x184049100")]
		static MNDOCKMGPNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private PBHKKCEBHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class FEOLIPLCFNJ : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class INAAKOJIAOG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C06B80", Offset = "0x3C05780", VA = "0x183C06B80")]
		static INAAKOJIAOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private FEOLIPLCFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class PNPLKLDPOFK
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly HOIKBOKFDFO[] JEGHHLHDCCD;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class LPFEGAEANOF : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class KJNHDFMDAGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x34E2560", Offset = "0x34E1160", VA = "0x1834E2560")]
		static KJNHDFMDAGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class CIMIPLJAJCL : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class HCCMIMKHGGC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x34DF260", Offset = "0x34DDE60", VA = "0x1834DF260")]
			static HCCMIMKHGGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private CIMIPLJAJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private LPFEGAEANOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class IDFNGIJOOPL : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class IFPGCJLOPMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x33C8B10", Offset = "0x33C7710", VA = "0x1833C8B10")]
		static IFPGCJLOPMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class HKKNGJMDLKL : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class PPAJHMJFOMP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x33D1F10", Offset = "0x33D0B10", VA = "0x1833D1F10")]
			static PPAJHMJFOMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private HKKNGJMDLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private IDFNGIJOOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class JJAKHADCFHM : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class EBDIPFJBENI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x31EF7F0", Offset = "0x31EE3F0", VA = "0x1831EF7F0")]
		static EBDIPFJBENI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GHHNAECKEMN : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class ELLNBEDNLLA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x31F25F0", Offset = "0x31F11F0", VA = "0x1831F25F0")]
			static ELLNBEDNLLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private GHHNAECKEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private JJAKHADCFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class CIMOKJEPMNK : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class ABPEJOJJLOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2CE68B0", Offset = "0x2CE54B0", VA = "0x182CE68B0")]
		static ABPEJOJJLOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class FLNHKDMGCLH : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class CEGFNJPLGOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x234F600", Offset = "0x234E200", VA = "0x18234F600")]
			static CEGFNJPLGOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private FLNHKDMGCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private CIMOKJEPMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class ILKEPFCBCLB : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class DAFGPMBNEFB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x33BF280", Offset = "0x33BDE80", VA = "0x1833BF280")]
		static DAFGPMBNEFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class PKPELKNKIME : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class HKPHFLOLDPE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2F744C0", Offset = "0x2F730C0", VA = "0x182F744C0")]
			static HKPHFLOLDPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private PKPELKNKIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private ILKEPFCBCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class BNOLGJONALC : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class MJFOHKKIEMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x20548F0", Offset = "0x20534F0", VA = "0x1820548F0")]
		static MJFOHKKIEMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class HMLMMGGLIEH : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class MGFBICNEGFL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x204FD50", Offset = "0x204E950", VA = "0x18204FD50")]
			static MGFBICNEGFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private HMLMMGGLIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private BNOLGJONALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class PCONGAGBCEJ : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class KMJBLNBMHLO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4615A40", Offset = "0x4614640", VA = "0x184615A40")]
		static KMJBLNBMHLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class OIFHLJLKFKO : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GKMMDBAHHDC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4611150", Offset = "0x460FD50", VA = "0x184611150")]
			static GKMMDBAHHDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private OIFHLJLKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private PCONGAGBCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class GCGFPMJOPHI : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class OJGLHJNEBHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x33AD170", Offset = "0x33ABD70", VA = "0x1833AD170")]
		static OJGLHJNEBHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class JHLIOJDCODN : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class ALLFLDIMDFF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x33995E0", Offset = "0x33981E0", VA = "0x1833995E0")]
			static ALLFLDIMDFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private JHLIOJDCODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private GCGFPMJOPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class ACBPCGEEGMC : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class OAJLJDBMMKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x44C4490", Offset = "0x44C3090", VA = "0x1844C4490")]
		static OAJLJDBMMKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class ACPANLLHCNH : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class JNDNCPGCMEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x44C0430", Offset = "0x44BF030", VA = "0x1844C0430")]
			static JNDNCPGCMEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private ACPANLLHCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private ACBPCGEEGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class NEIAFJMLPIL : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FMMAPALOGNP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x46B7600", Offset = "0x46B6200", VA = "0x1846B7600")]
		static FMMAPALOGNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KEMPJJPHAPH : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class BAPELPECENJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46B48D0", Offset = "0x46B34D0", VA = "0x1846B48D0")]
			static BAPELPECENJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private KEMPJJPHAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private NEIAFJMLPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class KKOHJBCGAGE : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class DHDAIKEHAJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x304DC20", Offset = "0x304C820", VA = "0x18304DC20")]
		static DHDAIKEHAJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class MPABHMFPJKA : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class KKHCBMBIPEN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x305BA90", Offset = "0x305A690", VA = "0x18305BA90")]
			static KKHCBMBIPEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private MPABHMFPJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private KKOHJBCGAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class PFFHEFKNAFH : HOIKBOKFDFO
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class BPKEBGHENGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x460AB70", Offset = "0x4609770", VA = "0x18460AB70")]
		static BPKEBGHENGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class MAEEMBOIINJ : HOIKBOKFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class HBNKDGGFHGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::GBFELAFCCEK<T> DHBOCAOJPAP;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x46141E0", Offset = "0x4612DE0", VA = "0x1846141E0")]
			static HBNKDGGFHGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly HOIKBOKFDFO PPLIIACIKDD;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly HOIKBOKFDFO[] EJEGOPDKKPJ;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		private MAEEMBOIINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
		public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly HOIKBOKFDFO PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::GBFELAFCCEK<object> KFOBIDMPJHB;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	private PFFHEFKNAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2184BF0", Offset = "0x21837F0", VA = "0x182184BF0", Slot = "4")]
	public global::GBFELAFCCEK<T> IJLAMDOPLAO<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NABMDDKEKNK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] KKIKEFLCNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int NODCJGOKMPN;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3319DD0", Offset = "0x33189D0", VA = "0x183319DD0")]
	public NABMDDKEKNK(int BKAKMOPHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3319D00", Offset = "0x3318900", VA = "0x183319D00")]
	public void JNIPLPDFDNO(T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3319AC0", Offset = "0x33186C0", VA = "0x183319AC0")]
	public T[] JAKNHMFGHIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class CLBFNLFDHCF : global::GHNJKLJEPKK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly CLBFNLFDHCF OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3966DD0", Offset = "0x39659D0", VA = "0x183966DD0")]
	public CLBFNLFDHCF(int NALCEPDOIJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class GHNJKLJEPKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int NALCEPDOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object CFOFCPJINIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int BAOHKIGDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] OKKAMNFKGNP;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x33A6590", Offset = "0x33A5190", VA = "0x1833A6590")]
	public GHNJKLJEPKK(int NALCEPDOIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x33A4850", Offset = "0x33A3450", VA = "0x1833A4850")]
	public T[] FKKFAGJPOHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x33A5C90", Offset = "0x33A4890", VA = "0x1833A5C90")]
	public void NPFICJABKLL(T[] MPENDCAONOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GOHPBPLHEPK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class GPAGDAJLAPN : IComparable<GPAGDAJLAPN>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class ADAGCHCJHLB : IEnumerable<GPAGDAJLAPN>, IEnumerable, IEnumerator<GPAGDAJLAPN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private GPAGDAJLAPN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public GPAGDAJLAPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private GPAGDAJLAPN System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
			[DebuggerHidden]
			public ADAGCHCJHLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x370E5B0", Offset = "0x370D1B0", VA = "0x18370E5B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x370E6E0", Offset = "0x370D2E0", VA = "0x18370E6E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x370E640", Offset = "0x370D240", VA = "0x18370E640", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GPAGDAJLAPN> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x370E640", Offset = "0x370D240", VA = "0x18370E640", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class OMNJBJLEIMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public OMNJBJLEIMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCC0", Offset = "0x5EB8C0", VA = "0x1805ECCC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCC0", Offset = "0x5EB8C0", VA = "0x1805ECCC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly GPAGDAJLAPN[] CDNEMEKEPIG;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] GHMFNEBFCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong EBFNOOKFFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int CFABBBMGOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string EGGAEGKBBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private GPAGDAJLAPN[] GMEHAOPBOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] KJGAPKEDDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int GCKMDOIKFCL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JHCEAJLLNAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xC6D0F0", Offset = "0xC6BCF0", VA = "0x180C6D0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3713420", Offset = "0x3712020", VA = "0x183713420")]
		public GPAGDAJLAPN(ulong IHPCMBAPNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x37122F0", Offset = "0x3710EF0", VA = "0x1837122F0")]
		public GPAGDAJLAPN JNIPLPDFDNO(ulong IHPCMBAPNMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x37122A0", Offset = "0x3710EA0", VA = "0x1837122A0")]
		public GPAGDAJLAPN JNIPLPDFDNO(ulong IHPCMBAPNMC, int PDMPLJICJLE, string EGGAEGKBBIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3712550", Offset = "0x3711150", VA = "0x183712550")]
		public GPAGDAJLAPN NJMPKMAPKDC(byte[] LMLNCGLGHJD, ref int HMFFBMGNBCG, ref int HCJEOLIBPAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3713320", Offset = "0x3711F20", VA = "0x183713320")]
		internal static int PHBOADCIDLF(ulong[] MPENDCAONOC, int BAOHKIGDOBF, int LIJNMPAFKGC, ulong PDMPLJICJLE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3712270", Offset = "0x3710E70", VA = "0x183712270", Slot = "4")]
		public int CompareTo(GPAGDAJLAPN LPEBOAHCFNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x37124E0", Offset = "0x37110E0", VA = "0x1837124E0")]
		[IteratorStateMachine(typeof(ADAGCHCJHLB))]
		public IEnumerable<GPAGDAJLAPN> KLPHMLEBHCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3712120", Offset = "0x3710D20", VA = "0x183712120")]
		public void ALNCOCDAPPH(ILGenerator BJJMHHFCDMP, LocalBuilder LMLNCGLGHJD, LocalBuilder HCJEOLIBPAH, LocalBuilder IHPCMBAPNMC, Action<KeyValuePair<string, int>> JFDGAGHJDKN, Action BMKNDHAMNLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3712700", Offset = "0x3711300", VA = "0x183712700")]
		private static void NKLEOMOJPKG(ILGenerator BJJMHHFCDMP, LocalBuilder LMLNCGLGHJD, LocalBuilder HCJEOLIBPAH, LocalBuilder IHPCMBAPNMC, Action<KeyValuePair<string, int>> JFDGAGHJDKN, Action BMKNDHAMNLA, GPAGDAJLAPN[] GMEHAOPBOMJ, int GCKMDOIKFCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IKMAENALAMH : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<GPAGDAJLAPN> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<GPAGDAJLAPN> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<GPAGDAJLAPN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private GPAGDAJLAPN <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E5000", Offset = "0x5E3C00", VA = "0x1805E5000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x371C3A0", Offset = "0x371AFA0", VA = "0x18371C3A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA0D7D0", Offset = "0xA0C3D0", VA = "0x180A0D7D0")]
		[DebuggerHidden]
		public IKMAENALAMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x371C3F0", Offset = "0x371AFF0", VA = "0x18371C3F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x371BF30", Offset = "0x371AB30", VA = "0x18371BF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x371C4F0", Offset = "0x371B0F0", VA = "0x18371C4F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x371C540", Offset = "0x371B140", VA = "0x18371C540")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x371C350", Offset = "0x371AF50", VA = "0x18371C350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x371C2B0", Offset = "0x371AEB0", VA = "0x18371C2B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x371C2B0", Offset = "0x371AEB0", VA = "0x18371C2B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly GPAGDAJLAPN FEKJACABLNO;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x37120B0", Offset = "0x3710CB0", VA = "0x1837120B0")]
	public GOHPBPLHEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3711E30", Offset = "0x3710A30", VA = "0x183711E30")]
	public void JNIPLPDFDNO(byte[] DNJADMBKFKK, int PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3711D50", Offset = "0x3710950", VA = "0x183711D50")]
	public bool HNEAKNDPHAD(ArraySegment<byte> IHPCMBAPNMC, out int PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3711FC0", Offset = "0x3710BC0", VA = "0x183711FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x37119D0", Offset = "0x37105D0", VA = "0x1837119D0")]
	private static void ENMNFIOJCHE(IEnumerable<GPAGDAJLAPN> GMEHAOPBOMJ, StringBuilder HEDCPOGLKFH, int HGCNCFEGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3711C50", Offset = "0x3710850", VA = "0x183711C50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3711C50", Offset = "0x3710850", VA = "0x183711C50", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3711F50", Offset = "0x3710B50", VA = "0x183711F50")]
	[IteratorStateMachine(typeof(IKMAENALAMH))]
	private static IEnumerable<KeyValuePair<string, int>> MDDEAGKBNNF(IEnumerable<GPAGDAJLAPN> GMEHAOPBOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3711E00", Offset = "0x3710A00", VA = "0x183711E00")]
	public void JBIPPJGHLNB(ILGenerator BJJMHHFCDMP, LocalBuilder LMLNCGLGHJD, LocalBuilder HCJEOLIBPAH, LocalBuilder IHPCMBAPNMC, Action<KeyValuePair<string, int>> JFDGAGHJDKN, Action BMKNDHAMNLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class OIMLGKIHBML
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo JHDOBKAAACL;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DCC0", Offset = "0x4C2C8C0", VA = "0x184C2DCC0")]
	public static ulong NMIIIJFJPBM(byte[] DNJADMBKFKK, ref int HMFFBMGNBCG, ref int HCJEOLIBPAH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class IHKDJKNAEHC
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x371BAE0", Offset = "0x371A6E0", VA = "0x18371BAE0")]
	public static void PDNFMEFDKJB(ref byte[] DNJADMBKFKK, int HMFFBMGNBCG, int LDAOHLBMDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x371B900", Offset = "0x371A500", VA = "0x18371B900")]
	public static void ALBEDBBPIFD(ref byte[] MPENDCAONOC, int IGPJCKOIDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x371B9F0", Offset = "0x371A5F0", VA = "0x18371B9F0")]
	public static byte[] KIAGHOLGHIE(byte[] HOMNJBLAHAL, int IGPJCKOIDKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GAKNANIPACG
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x370F1C0", Offset = "0x370DDC0", VA = "0x18370F1C0")]
	public static bool KMDDCOFIBJP(byte[] ICFABHEKICB, int JJIHFKOILHM, int PGHGDAFKFNF, byte[] ONNENEOJGAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class GPIACEDOAJK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct JHKGINGBAFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] EBFNOOKFFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T CFABBBMGOIO;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3737CD0", Offset = "0x37368D0", VA = "0x183737CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class NMLLMKEPODC : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::GPIACEDOAJK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private JHKGINGBAFN[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private JHKGINGBAFN[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1AE18A0", Offset = "0x1AE04A0", VA = "0x181AE18A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x373EC60", Offset = "0x373D860", VA = "0x18373EC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E35600", Offset = "0x1E34200", VA = "0x181E35600")]
		[DebuggerHidden]
		public NMLLMKEPODC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x373DB70", Offset = "0x373C770", VA = "0x18373DB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x373E8F0", Offset = "0x373D4F0", VA = "0x18373E8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly JHKGINGBAFN[][] NJKAJHPLGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong NCHIOFNHBII;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2F62220", Offset = "0x2F60E20", VA = "0x182F62220")]
	public GPIACEDOAJK(int EFOLPOOCAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F62250", Offset = "0x2F60E50", VA = "0x182F62250")]
	public GPIACEDOAJK(int EFOLPOOCAHO, float ALMNFPJFGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3736220", Offset = "0x3734E20", VA = "0x183736220")]
	public void JNIPLPDFDNO(byte[] IHPCMBAPNMC, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3733760", Offset = "0x3732360", VA = "0x183733760")]
	private bool ECDLGLOJOND(byte[] IHPCMBAPNMC, T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3734B30", Offset = "0x3733730", VA = "0x183734B30")]
	public bool EKDAOPLAPIM(ArraySegment<byte> IHPCMBAPNMC, out T PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F594A0", Offset = "0x2F580A0", VA = "0x182F594A0")]
	private static ulong BHIODFBGPCN(byte[] FPNCCNLMGCF, int HMFFBMGNBCG, int GCKMDOIKFCL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F621F0", Offset = "0x2F60DF0", VA = "0x182F621F0")]
	private static int KCGHNFIHPMB(int DPILLPCDHDM, float ALMNFPJFGNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F60E70", Offset = "0x2F5FA70", VA = "0x182F60E70", Slot = "4")]
	[IteratorStateMachine(typeof(global::GPIACEDOAJK<>.NMLLMKEPODC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2447EE0", Offset = "0x2446AE0", VA = "0x182447EE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class AOEPGJFAOOI : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] DPOGKKPJDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] JIJALMLADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int DKOOJNKMECJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool AINDAKFJDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x395B300", Offset = "0x3959F00", VA = "0x18395B300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x395B350", Offset = "0x3959F50", VA = "0x18395B350")]
	static AOEPGJFAOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x395B5A0", Offset = "0x395A1A0", VA = "0x18395B5A0")]
	public AOEPGJFAOOI(byte[] OCNIALGOFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x395B1F0", Offset = "0x3959DF0", VA = "0x18395B1F0")]
	public OpCode JILIPLOJDND()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct NAKAMOFICLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid CFABBBMGOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte LNCMHEBMGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte JIHOOCNNPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte NGIFLLHLHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte GLKOCBLAAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte KANBLKIDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte MKBOLHCFJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte KDOLKDOKECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte PDOEOGMAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte GKCIKMDNLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte PLJAIHCCJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte ONCMCJLIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CHLBPKFKNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte IPDCPJDIDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CABLEKKKIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte DDLEBHNLKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte NOOJHMNNFAD;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] KLDECGGKHBK;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] MGIAHCOKINC;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4C29160", Offset = "0x4C27D60", VA = "0x184C29160")]
	public NAKAMOFICLJ(ref Guid PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4C29170", Offset = "0x4C27D70", VA = "0x184C29170")]
	public NAKAMOFICLJ(ref ArraySegment<byte> KALHPBPNIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4C27BA0", Offset = "0x4C267A0", VA = "0x184C27BA0")]
	private static byte BCEJADOGDOJ(byte[] DNJADMBKFKK, int NJBKDLCIFAK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4C27C60", Offset = "0x4C26860", VA = "0x184C27C60")]
	private static byte LJNAGPOKPDO(byte DBJNEGCCKCM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4C27D70", Offset = "0x4C26970", VA = "0x184C27D70")]
	public void NAJKHBEKKJC(byte[] GDLCFFFAFKF, int HMFFBMGNBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class CBGOIAFNHDL
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x39662D0", Offset = "0x3964ED0", VA = "0x1839662D0")]
	public static bool LPFDEHABNOK(byte CAOLLJDPDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x39655B0", Offset = "0x39641B0", VA = "0x1839655B0")]
	public static bool JLPIJDGAJIG(byte CAOLLJDPDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3964B00", Offset = "0x3963700", VA = "0x183964B00")]
	public static sbyte EAHGIJKAHMC(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3965620", Offset = "0x3964220", VA = "0x183965620")]
	public static short KCBMALFCLKO(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3965540", Offset = "0x3964140", VA = "0x183965540")]
	public static int JLNDLKEKDDD(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x39653B0", Offset = "0x3963FB0", VA = "0x1839653B0")]
	public static long FILEOKLGGFL(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3964980", Offset = "0x3963580", VA = "0x183964980")]
	public static byte BKECFEAKLAO(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3965340", Offset = "0x3963F40", VA = "0x183965340")]
	public static ushort EFAIKMPFPCO(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3964900", Offset = "0x3963500", VA = "0x183964900")]
	public static uint APCBBMJJJOL(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x39649F0", Offset = "0x39635F0", VA = "0x1839649F0")]
	public static ulong BLNCMIKFMNC(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x39654D0", Offset = "0x39640D0", VA = "0x1839654D0")]
	public static float IIFADMLKPDC(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3965460", Offset = "0x3964060", VA = "0x183965460")]
	public static double GPBNGHKHGGK(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3964B70", Offset = "0x3963770", VA = "0x183964B70")]
	public static int EEGPEAAMMOF(ref byte[] GDLCFFFAFKF, int HMFFBMGNBCG, ulong PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3965690", Offset = "0x3964290", VA = "0x183965690")]
	public static int LAADLKGGFMG(ref byte[] GDLCFFFAFKF, int HMFFBMGNBCG, long PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x39662E0", Offset = "0x3964EE0", VA = "0x1839662E0")]
	public static bool OCABIOEJBCL(byte[] DNJADMBKFKK, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class OMKBLOPNGIP
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class GCPKMPNKOJP : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public GCPKMPNKOJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4C25330", Offset = "0x4C23F30", VA = "0x184C25330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4C24ED0", Offset = "0x4C23AD0", VA = "0x184C24ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4C25450", Offset = "0x4C24050", VA = "0x184C25450")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4C254A0", Offset = "0x4C240A0", VA = "0x184C254A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4C252E0", Offset = "0x4C23EE0", VA = "0x184C252E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4C25230", Offset = "0x4C23E30", VA = "0x184C25230", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4C25230", Offset = "0x4C23E30", VA = "0x184C25230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class MEMEAFGMEOK : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E0", Offset = "0x6F3FE0", VA = "0x1806F53E0")]
		[DebuggerHidden]
		public MEMEAFGMEOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4C26640", Offset = "0x4C25240", VA = "0x184C26640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4C261E0", Offset = "0x4C24DE0", VA = "0x184C261E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4C26760", Offset = "0x4C25360", VA = "0x184C26760")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4C267B0", Offset = "0x4C253B0", VA = "0x184C267B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4C265F0", Offset = "0x4C251F0", VA = "0x184C265F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4C26540", Offset = "0x4C25140", VA = "0x184C26540", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4C26540", Offset = "0x4C25140", VA = "0x184C26540", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F5C0", Offset = "0x4C2E1C0", VA = "0x184C2F5C0")]
	public static bool JBEPOOIMHMM(this TypeInfo HCPDGKICMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F670", Offset = "0x4C2E270", VA = "0x184C2F670")]
	public static bool NOIFMHEKNLO(this TypeInfo HCPDGKICMEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F560", Offset = "0x4C2E160", VA = "0x184C2F560")]
	public static IEnumerable<PropertyInfo> IHDJBKPIDBH(this Type HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F4D0", Offset = "0x4C2E0D0", VA = "0x184C2F4D0")]
	[IteratorStateMachine(typeof(GCPKMPNKOJP))]
	private static IEnumerable<PropertyInfo> FLOFPIINKFF(Type HCPDGKICMEB, HashSet<string> DINJPMKBEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F770", Offset = "0x4C2E370", VA = "0x184C2F770")]
	public static IEnumerable<FieldInfo> OJCKODGIIOP(this Type HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F440", Offset = "0x4C2E040", VA = "0x184C2F440")]
	[IteratorStateMachine(typeof(MEMEAFGMEOK))]
	private static IEnumerable<FieldInfo> CCAPHAMLPAN(Type HCPDGKICMEB, HashSet<string> DINJPMKBEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class PBAEPEDPDLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding CEIBMIPFJBL;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class KGPNLFAGCBA
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x699F60", Offset = "0x698B60", VA = "0x180699F60")]
	public static string PKFHBPNPBPA(string IPOFGLEPCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x37230B0", Offset = "0x3721CB0", VA = "0x1837230B0")]
	public static string GAALICBBEHA(string IPOFGLEPCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3722EE0", Offset = "0x3721AE0", VA = "0x183722EE0")]
	public static string DLBLHPBMFGG(string IPOFGLEPCDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class LJMOEGEKHCB<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CLBBKPKNNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type EBFNOOKFFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue CFABBBMGOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int DCMCCJJAAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CLBBKPKNNII DBBHILFBFOM;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x34DBBA0", Offset = "0x34DA7A0", VA = "0x1834DBBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x34DBB20", Offset = "0x34DA720", VA = "0x1834DBB20")]
		private int JFMPCJJIJJI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public CLBBKPKNNII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class LPKPJKJEKDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public LPKPJKJEKDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8F5A40", Offset = "0x8F4640", VA = "0x1808F5A40")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private CLBBKPKNNII[] NJKAJHPLGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int AABEJHHLOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object DOKEHLEFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float ALMNFPJFGNF;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x34E60F0", Offset = "0x34E4CF0", VA = "0x1834E60F0")]
	public LJMOEGEKHCB(int EFOLPOOCAHO = 4, float ALMNFPJFGNF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x34E5850", Offset = "0x34E4450", VA = "0x1834E5850")]
	public bool IEGCNIFBCNH(Type IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x34E5810", Offset = "0x34E4410", VA = "0x1834E5810")]
	public bool IEGCNIFBCNH(Type IHPCMBAPNMC, Func<Type, TValue> NPFLBFPIOIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x34E5120", Offset = "0x34E3D20", VA = "0x1834E5120")]
	private bool ECDLGLOJOND(Type IHPCMBAPNMC, Func<Type, TValue> NPFLBFPIOIH, out TValue MFMADGOFBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x34E5960", Offset = "0x34E4560", VA = "0x1834E5960")]
	private bool LLBIDDIMPEM(CLBBKPKNNII[] NJKAJHPLGMK, Type JFNIFBBHPJO, CLBBKPKNNII KHNHJCFCNDC, Func<Type, TValue> NPFLBFPIOIH, out TValue MFMADGOFBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x34E5570", Offset = "0x34E4170", VA = "0x1834E5570")]
	public bool EKDAOPLAPIM(Type IHPCMBAPNMC, out TValue PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x34E4D80", Offset = "0x34E3980", VA = "0x1834E4D80")]
	public TValue BEINJCDLMJJ(Type IHPCMBAPNMC, Func<Type, TValue> NPFLBFPIOIH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2F621F0", Offset = "0x2F60DF0", VA = "0x182F621F0")]
	private static int KCGHNFIHPMB(int DPILLPCDHDM, float ALMNFPJFGNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x34E60C0", Offset = "0x34E4CC0", VA = "0x1834E60C0")]
	private static void OMMIDIAFKKF(ref CLBBKPKNNII ADEPAGJKGAB, CLBBKPKNNII PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x34E60C0", Offset = "0x34E4CC0", VA = "0x1834E60C0")]
	private static void OMMIDIAFKKF(ref CLBBKPKNNII[] ADEPAGJKGAB, CLBBKPKNNII[] PDMPLJICJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class FODHAEEFNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder BKIPFDFGAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder KJIGMBKJIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object CFOFCPJINIC;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x370EFD0", Offset = "0x370DBD0", VA = "0x18370EFD0")]
	public TypeBuilder IHDBNKNFFCG(string AMDKCMALAFD, TypeAttributes GMBGBADNKDL, Type PPHLLODMENC, Type[] PPIAOODGCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x370F0C0", Offset = "0x370DCC0", VA = "0x18370F0C0")]
	public FODHAEEFNDJ(string MNEMGJEEGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class AIDEIMFNCAL
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x395A640", Offset = "0x3959240", VA = "0x18395A640")]
	private static MethodInfo GLPKPIECMDJ(LambdaExpression FIFAMKLPKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2207080", Offset = "0x2205C80", VA = "0x182207080")]
	public static MethodInfo IMLAJALPNBJ<T>(Expression<Func<T>> FIFAMKLPKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2207080", Offset = "0x2205C80", VA = "0x182207080")]
	public static MethodInfo IMLAJALPNBJ<T, TR>(Expression<Func<T, TR>> FIFAMKLPKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2207080", Offset = "0x2205C80", VA = "0x182207080")]
	public static MethodInfo IMLAJALPNBJ<T>(Expression<Action<T>> FIFAMKLPKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2207080", Offset = "0x2205C80", VA = "0x182207080")]
	public static MethodInfo IMLAJALPNBJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> FIFAMKLPKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2206FE0", Offset = "0x2205BE0", VA = "0x182206FE0")]
	private static MemberInfo FOPCPGEPBCJ<T>(Expression<T> CHFHFNDILMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2207090", Offset = "0x2205C90", VA = "0x182207090")]
	public static PropertyInfo NICDJKINKPF<T, TR>(Expression<Func<T, TR>> FIFAMKLPKLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct APNFKNLPJCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int ACJHPBCLINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool KLFAKLBBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator BJJMHHFCDMP;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x395B730", Offset = "0x395A330", VA = "0x18395B730")]
	public APNFKNLPJCH(ILGenerator BJJMHHFCDMP, int ACJHPBCLINB, bool KLFAKLBBDGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x395B6A0", Offset = "0x395A2A0", VA = "0x18395B6A0")]
	public APNFKNLPJCH(ILGenerator BJJMHHFCDMP, int ACJHPBCLINB, Type HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x395B680", Offset = "0x395A280", VA = "0x18395B680")]
	public void JGMCEEFPILE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class GGBFAIIHBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3710450", Offset = "0x370F050", VA = "0x183710450")]
	public static void KFCAIOBCADD(this ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3710680", Offset = "0x370F280", VA = "0x183710680")]
	public static void KFCAIOBCADD(this ILGenerator BJJMHHFCDMP, LocalBuilder LJEANPHJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3710090", Offset = "0x370EC90", VA = "0x183710090")]
	public static void DAHKIHJBIMM(this ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3710050", Offset = "0x370EC50", VA = "0x183710050")]
	public static void DAHKIHJBIMM(this ILGenerator BJJMHHFCDMP, LocalBuilder LJEANPHJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3710DA0", Offset = "0x370F9A0", VA = "0x183710DA0")]
	public static void OHBDDKNJPNA(this ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3710C90", Offset = "0x370F890", VA = "0x183710C90")]
	public static void OHBDDKNJPNA(this ILGenerator BJJMHHFCDMP, LocalBuilder LJEANPHJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3710F30", Offset = "0x370FB30", VA = "0x183710F30")]
	public static void PHHPIJMMBLD(this ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3710340", Offset = "0x370EF40", VA = "0x183710340")]
	public static void FGPCLFLBBEH(this ILGenerator BJJMHHFCDMP, bool PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3710840", Offset = "0x370F440", VA = "0x183710840")]
	public static void NIHPJFOOHLI(this ILGenerator BJJMHHFCDMP, int PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x370FCA0", Offset = "0x370E8A0", VA = "0x18370FCA0")]
	public static void AAIPGHMIDLP(this ILGenerator BJJMHHFCDMP, Type HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3710E90", Offset = "0x370FA90", VA = "0x183710E90")]
	public static void PDJNMKKMNHM(this ILGenerator BJJMHHFCDMP, Type HCPDGKICMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x370FE20", Offset = "0x370EA20", VA = "0x18370FE20")]
	public static void CHCJDCBOFJH(this ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x37102C0", Offset = "0x370EEC0", VA = "0x1837102C0")]
	public static void FBANOGJIOOG(this ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3710750", Offset = "0x370F350", VA = "0x183710750")]
	public static void MGPKCECPKLM(this ILGenerator BJJMHHFCDMP, int BAOHKIGDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3710350", Offset = "0x370EF50", VA = "0x183710350")]
	public static void HCELCPOPCAN(this ILGenerator BJJMHHFCDMP, MethodInfo GMLBAPJILHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x370FD90", Offset = "0x370E990", VA = "0x18370FD90")]
	public static void BJEAIHHHODP(this ILGenerator BJJMHHFCDMP, FieldInfo BPDMLEEILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x37106C0", Offset = "0x370F2C0", VA = "0x1837106C0")]
	public static void KKBINGFMPKA(this ILGenerator BJJMHHFCDMP, ulong PDMPLJICJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CAGCBJEHKLL
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class EFCLGABMKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EFCLGABMKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x396AB90", Offset = "0x3969790", VA = "0x18396AB90")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo BELIBHBAJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo JPAICKOBEII;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string PLBJOONAPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GNMCLEBOIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x39644F0", Offset = "0x39630F0", VA = "0x1839644F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DANHLEBECBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5E4190", Offset = "0x5E2D90", VA = "0x1805E4190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x73F180", Offset = "0x73DD80", VA = "0x18073F180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FMPNMFGFFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41A0", Offset = "0x5E2DA0", VA = "0x1805E41A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x803500", Offset = "0x802100", VA = "0x180803500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type IPCNLNJCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo BJBOINEDJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo BONBFJOGDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo MIDFAPMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5F7D70", Offset = "0x5F6970", VA = "0x1805F7D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x67EFC0", Offset = "0x67DBC0", VA = "0x18067EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x39645C0", Offset = "0x39631C0", VA = "0x1839645C0")]
	protected CAGCBJEHKLL(Type HCPDGKICMEB, string AMDKCMALAFD, string KACFJFDAOHM, bool HFKOPINNOCB, bool HHBGFFOLIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x39647F0", Offset = "0x39633F0", VA = "0x1839647F0")]
	public CAGCBJEHKLL(FieldInfo DGFLPFMPLJK, string AMDKCMALAFD, bool PJPIAIPDPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3964640", Offset = "0x3963240", VA = "0x183964640")]
	public CAGCBJEHKLL(PropertyInfo DGFLPFMPLJK, string AMDKCMALAFD, bool PJPIAIPDPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x39643D0", Offset = "0x3962FD0", VA = "0x1839643D0")]
	private static MethodInfo DCCDDCAJJIH(MemberInfo DGFLPFMPLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1D85EB0", Offset = "0x1D84AB0", VA = "0x181D85EB0")]
	public T AKNPACMKJII<T>(bool KLBLCFOKOFG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3964310", Offset = "0x3962F10", VA = "0x183964310", Slot = "4")]
	public virtual void CILNJHECONC(ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3964500", Offset = "0x3963100", VA = "0x183964500", Slot = "5")]
	public virtual void MIBGIGINIGG(ILGenerator BJJMHHFCDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class AFOFLNHGGBO : CAGCBJEHKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string IBPGLHJJFJF;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x395A570", Offset = "0x3959170", VA = "0x18395A570")]
	public AFOFLNHGGBO(string AMDKCMALAFD, string IBPGLHJJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x395A460", Offset = "0x3959060", VA = "0x18395A460", Slot = "4")]
	public override void CILNJHECONC(ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x395A520", Offset = "0x3959120", VA = "0x18395A520", Slot = "5")]
	public override void MIBGIGINIGG(ILGenerator BJJMHHFCDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class PKPIDIAMOGL : CAGCBJEHKLL
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo LLGFEEGPMCE;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo FKKAMHJBOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal APNFKNLPJCH HLFKJPNOJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal APNFKNLPJCH GCJKLACHJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal APNFKNLPJCH DDKHDOIKIAI;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4C33320", Offset = "0x4C31F20", VA = "0x184C33320")]
	public PKPIDIAMOGL(string AMDKCMALAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4C32C60", Offset = "0x4C31860", VA = "0x184C32C60", Slot = "4")]
	public override void CILNJHECONC(ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4C32D20", Offset = "0x4C31920", VA = "0x184C32D20", Slot = "5")]
	public override void MIBGIGINIGG(ILGenerator BJJMHHFCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x4C32D70", Offset = "0x4C31970", VA = "0x184C32D70")]
	public void PMGFGEFKKII(ILGenerator BJJMHHFCDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class LJLGKKLHPKF
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type IPCNLNJCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNLGHEFFNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x712FE0", Offset = "0x711BE0", VA = "0x180712FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B78D0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HLOGABKOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7A7F10", Offset = "0x7A6B10", VA = "0x1807A7F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE48F00", Offset = "0xE47B00", VA = "0x180E48F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo EHHLDEFAFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x60ED70", Offset = "0x60D970", VA = "0x18060ED70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CAGCBJEHKLL[] COPHDHPDBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x708440", Offset = "0x707040", VA = "0x180708440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CAGCBJEHKLL[] PCFCDNPACJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x60CA30", Offset = "0x60B630", VA = "0x18060CA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x71C880", Offset = "0x71B480", VA = "0x18071C880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x37257B0", Offset = "0x37243B0", VA = "0x1837257B0")]
	public LJLGKKLHPKF(Type HCPDGKICMEB, Func<string, string> IHMHIMFJKAL, bool PJPIAIPDPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x37256E0", Offset = "0x37242E0", VA = "0x1837256E0")]
	private static bool CCELEKJHJOH(IEnumerator<ConstructorInfo> IKGIFFNMDGC, ref ConstructorInfo MKIBLHAAGPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct LAMGCPGAHFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong DMKJHAOIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int NDHKDNBHBLL;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x27049E0", Offset = "0x27035E0", VA = "0x1827049E0")]
	public LAMGCPGAHFL(ulong CBIALPGPJBD, int EGHMFKBFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3723930", Offset = "0x3722530", VA = "0x183723930")]
	public void PAEIJPBEFPE(ref LAMGCPGAHFL LPEBOAHCFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3723900", Offset = "0x3722500", VA = "0x183723900")]
	public static LAMGCPGAHFL KIMKFDEMDGI(ref LAMGCPGAHFL GBHOMBFJPAG, ref LAMGCPGAHFL DBJNEGCCKCM)
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3723870", Offset = "0x3722470", VA = "0x183723870")]
	public void HBDBGFMEPBG(ref LAMGCPGAHFL LPEBOAHCFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x37237C0", Offset = "0x37223C0", VA = "0x1837237C0")]
	public static LAMGCPGAHFL DOJHHMCJENF(ref LAMGCPGAHFL GBHOMBFJPAG, ref LAMGCPGAHFL DBJNEGCCKCM)
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3723720", Offset = "0x3722320", VA = "0x183723720")]
	public void BBCKKCGDGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3723760", Offset = "0x3722360", VA = "0x183723760")]
	public static LAMGCPGAHFL BBCKKCGDGDB(ref LAMGCPGAHFL GBHOMBFJPAG)
	{
		return default(LAMGCPGAHFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct EKFPEMAABHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] GDLCFFFAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int HMFFBMGNBCG;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA25A90", Offset = "0xA24690", VA = "0x180A25A90")]
	public EKFPEMAABHJ(byte[] GDLCFFFAFKF, int AJODAOPNJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x396C190", Offset = "0x396AD90", VA = "0x18396C190")]
	public void NILJFGOOMDD(byte LDIGNLIMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x396C0F0", Offset = "0x396ACF0", VA = "0x18396C0F0")]
	public void JIIPOHONDGD(byte[] LDIGNLIMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x396BFD0", Offset = "0x396ABD0", VA = "0x18396BFD0")]
	public void FCOLGAFPKEM(byte[] LDIGNLIMJJL, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x396BF20", Offset = "0x396AB20", VA = "0x18396BF20")]
	public void FCOLGAFPKEM(byte[] LDIGNLIMJJL, int DJHHNCHEKKB, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x396C070", Offset = "0x396AC70", VA = "0x18396C070")]
	public void GHIEHLBMDMK(byte CAOLLJDPDGJ, int GCKMDOIKFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x396BE20", Offset = "0x396AA20", VA = "0x18396BE20")]
	public void CEFPHANGLCA(string LDIGNLIMJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class PJFABJFHFDB
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum HCOJMNEFFPD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum FDCCEODHODL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum BCHFOPADFAA
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
	private static byte[] DGAMAFDALKN;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] FPFNBDJMOOA;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] CEJGGNHJPPK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] NGCJAALGJCB;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly BCHFOPADFAA FPCNCOAGFAG;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char LMOODIPIKAC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int LKDLMKLMMLA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int AGBHHFAGFCA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] NCIGPJAHPFE;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C310F0", Offset = "0x4C2FCF0", VA = "0x184C310F0")]
	private static byte[] HEAMACILGAJ(int AABEJHHLOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4C30D70", Offset = "0x4C2F970", VA = "0x184C30D70")]
	private static byte[] DDJKPOJFHKN(int AABEJHHLOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4C30C60", Offset = "0x4C2F860", VA = "0x184C30C60")]
	public static int CCMABEKPFOE(ref byte[] GDLCFFFAFKF, int HMFFBMGNBCG, float PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4C30B50", Offset = "0x4C2F750", VA = "0x184C30B50")]
	public static int CCMABEKPFOE(ref byte[] GDLCFFFAFKF, int HMFFBMGNBCG, double PDMPLJICJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4C30A50", Offset = "0x4C2F650", VA = "0x184C30A50")]
	private static bool BGKJKMEAPNJ(byte[] GDLCFFFAFKF, int LIJNMPAFKGC, ulong ECGAEOCEAKL, ulong GKDKDAJEAFM, ulong HCJEOLIBPAH, ulong ADCFFFAMOPC, ulong OFBDPHPJOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C30E50", Offset = "0x4C2FA50", VA = "0x184C30E50")]
	private static void DJLJLKIIHLM(uint LDDDJPNNFEB, int OOIGNADHMKK, out uint BFMJHDOOPMF, out int PCBLOIGDMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C30510", Offset = "0x4C2F110", VA = "0x184C30510")]
	private static bool AELIFCIJHND(LAMGCPGAHFL NFEABAJADNP, LAMGCPGAHFL EPICGAFMOJC, LAMGCPGAHFL GNIGBGNNFIE, byte[] GDLCFFFAFKF, out int LIJNMPAFKGC, out int LPCKFNFCIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C311C0", Offset = "0x4C2FDC0", VA = "0x184C311C0")]
	private static bool HFBOKEABMMC(double MLEMCDNNOBN, HCOJMNEFFPD DJEGGGAIOHL, byte[] GDLCFFFAFKF, out int LIJNMPAFKGC, out int IDFAAGIHKIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C30960", Offset = "0x4C2F560", VA = "0x184C30960")]
	private static bool BFJPKPMNJBB(double MLEMCDNNOBN, HCOJMNEFFPD DJEGGGAIOHL, byte[] GDLCFFFAFKF, out int LIJNMPAFKGC, out int PFLLBFJGDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C31AB0", Offset = "0x4C306B0", VA = "0x184C31AB0")]
	private static bool MLIOKJGOCEA(double PDMPLJICJLE, ref EKFPEMAABHJ NBGHHEOHIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C31490", Offset = "0x4C30090", VA = "0x184C31490")]
	private static bool HIKBHCOHAOH(double PDMPLJICJLE, ref EKFPEMAABHJ NBGHHEOHIMH, FDCCEODHODL DJEGGGAIOHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4C31F30", Offset = "0x4C30B30", VA = "0x184C31F30")]
	private static void OIHMKMHKFHB(byte[] ICMEGGFIPOK, int LIJNMPAFKGC, int PFLLBFJGDBL, int OIPAFPGKMKE, ref EKFPEMAABHJ NBGHHEOHIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C31C40", Offset = "0x4C30840", VA = "0x184C31C40")]
	private static void MNMBMNIBHPH(byte[] ICMEGGFIPOK, int LIJNMPAFKGC, int EGHMFKBFGKN, ref EKFPEMAABHJ NBGHHEOHIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C30F70", Offset = "0x4C2FB70", VA = "0x184C30F70")]
	private static bool FNFEBEFDOBG(double MLEMCDNNOBN, FDCCEODHODL DJEGGGAIOHL, int OFGPJCJFPIE, byte[] IMLAJCHBIOP, out bool NBLLPAFCCIJ, out int LIJNMPAFKGC, out int LFHAKIFFEMA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PNHPEPBIPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double OHKJMOLJEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong KEADBMCFIIE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct HLJABEPBGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float DMKJHAOIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint FKMCNNBOCCI;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct ODMMEIIIFGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong BALIGOANOGF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D9F0", Offset = "0x4C2C5F0", VA = "0x184C2D9F0")]
	public ODMMEIIIFGA(double OHKJMOLJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D950", Offset = "0x4C2C550", VA = "0x184C2D950")]
	public ODMMEIIIFGA(LAMGCPGAHFL OHKJMOLJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D850", Offset = "0x4C2C450", VA = "0x184C2D850")]
	public LAMGCPGAHFL NBEACPOIOJA()
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D670", Offset = "0x4C2C270", VA = "0x184C2D670")]
	public LAMGCPGAHFL GOIJBFLIBAB()
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B8FE0", VA = "0x1807BA3E0")]
	public ulong EBMIKMEPDEO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D790", Offset = "0x4C2C390", VA = "0x184C2D790")]
	public double KCJHGNHALID()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D710", Offset = "0x4C2C310", VA = "0x184C2D710")]
	public double JGNGJDHKEHM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D8F0", Offset = "0x4C2C4F0", VA = "0x184C2D8F0")]
	public int PHKLDFBJGGL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D800", Offset = "0x4C2C400", VA = "0x184C2D800")]
	public ulong MKFMMNIGCNH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D830", Offset = "0x4C2C430", VA = "0x184C2D830")]
	public bool MLPLEMAGCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D490", Offset = "0x4C2C090", VA = "0x184C2D490")]
	public bool DKMBPIOGNMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D920", Offset = "0x4C2C520", VA = "0x184C2D920")]
	public bool PJLDMIEKLKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D640", Offset = "0x4C2C240", VA = "0x184C2D640")]
	public bool FIMKJIIDJID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D3B0", Offset = "0x4C2BFB0", VA = "0x184C2D3B0")]
	public int AGBDCEHENHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D4B0", Offset = "0x4C2C0B0", VA = "0x184C2D4B0")]
	public void ENPKLCPMNBC(out LAMGCPGAHFL LFLJBNIGJIF, out LAMGCPGAHFL PJHDNHEELKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D360", Offset = "0x4C2BF60", VA = "0x184C2D360")]
	public bool ABGGCLLNALI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D8E0", Offset = "0x4C2C4E0", VA = "0x184C2D8E0")]
	public double PDMPLJICJLE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D3D0", Offset = "0x4C2BFD0", VA = "0x184C2D3D0")]
	public static int CJDPLBNIJOO(int NGELEFNOGOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D8D0", Offset = "0x4C2C4D0", VA = "0x184C2D8D0")]
	public static double NHHCANFLCHG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D3F0", Offset = "0x4C2BFF0", VA = "0x184C2D3F0")]
	public static ulong DGLHOEKAODG(LAMGCPGAHFL HHHPLCBBKIE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct IFKLDIPGKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint MFMMLNKNMGF;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F376A0", Offset = "0x1F362A0", VA = "0x181F376A0")]
	public IFKLDIPGKLK(float DMKJHAOIIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x371B290", Offset = "0x3719E90", VA = "0x18371B290")]
	public LAMGCPGAHFL NBEACPOIOJA()
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2100", VA = "0x1808A3500")]
	public uint KOGJJHAFHOC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x371B2E0", Offset = "0x3719EE0", VA = "0x18371B2E0")]
	public int PHKLDFBJGGL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x371B260", Offset = "0x3719E60", VA = "0x18371B260")]
	public uint MKFMMNIGCNH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x371B280", Offset = "0x3719E80", VA = "0x18371B280")]
	public bool MLPLEMAGCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x371B130", Offset = "0x3719D30", VA = "0x18371B130")]
	public void ENPKLCPMNBC(out LAMGCPGAHFL LFLJBNIGJIF, out LAMGCPGAHFL PJHDNHEELKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x371B0F0", Offset = "0x3719CF0", VA = "0x18371B0F0")]
	public bool ABGGCLLNALI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct EBJPFBJMKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong CBIALPGPJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short PENIGCFGPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short IDFAAGIHKIE;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3969890", Offset = "0x3968490", VA = "0x183969890")]
	public EBJPFBJMKFA(ulong CBIALPGPJBD, short PENIGCFGPON, short IDFAAGIHKIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class IENKLLEPAAO
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly EBJPFBJMKFA[] FEFGKMAKHGB;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3719040", Offset = "0x3717C40", VA = "0x183719040")]
	public static void MPALDDELMAG(int MADHNEJMLBF, int EJPOEOLKHID, out LAMGCPGAHFL BFMJHDOOPMF, out int IDFAAGIHKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3718F50", Offset = "0x3717B50", VA = "0x183718F50")]
	public static void COKLIDKHEEL(int EACMCLPEELH, out LAMGCPGAHFL BFMJHDOOPMF, out int APMEBAHPHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct DLBEDBPHOGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] DNJADMBKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int DJHHNCHEKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int FKPHEIJMGBL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte LFAJLOBHMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x3967DE0", Offset = "0x39669E0", VA = "0x183967DE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F19E0", Offset = "0x9F05E0", VA = "0x1809F19E0")]
	public DLBEDBPHOGO(byte[] DNJADMBKFKK, int DJHHNCHEKKB, int LIJNMPAFKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8A34C0", Offset = "0x8A20C0", VA = "0x1808A34C0")]
	public int LIJNMPAFKGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3967D80", Offset = "0x3966980", VA = "0x183967D80")]
	public DLBEDBPHOGO IFHDGJKKKAK(int PIMDCPHDLPC, int MHKIPJIIMLH)
	{
		return default(DLBEDBPHOGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class LJGNANHEPII
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] KFMNDKKOEPJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] DMGJFPNEHHA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int GMDAFJPHLLB;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3725290", Offset = "0x3723E90", VA = "0x183725290")]
	private static byte[] MCGAGHFCFEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x37251E0", Offset = "0x3723DE0", VA = "0x1837251E0")]
	private static DLBEDBPHOGO KKPMPHDGAPM(DLBEDBPHOGO GDLCFFFAFKF)
	{
		return default(DLBEDBPHOGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3724730", Offset = "0x3723330", VA = "0x183724730")]
	private static DLBEDBPHOGO FMCLEFAECKO(DLBEDBPHOGO GDLCFFFAFKF)
	{
		return default(DLBEDBPHOGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3723F40", Offset = "0x3722B40", VA = "0x183723F40")]
	private static void ADGPMJLFGHE(DLBEDBPHOGO GDLCFFFAFKF, int EGHMFKBFGKN, byte[] JOAFLGCGMFH, out int FPCADGMLOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x37249C0", Offset = "0x37235C0", VA = "0x1837249C0")]
	private static void HHJBCEGKKGK(DLBEDBPHOGO GDLCFFFAFKF, int EGHMFKBFGKN, byte[] DBLPIPOCCMI, int AHHFOOJNPEM, out DLBEDBPHOGO LEFEOJHADBM, out int KCIFBHANINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3724C70", Offset = "0x3723870", VA = "0x183724C70")]
	private static ulong HKNCKMLBGME(DLBEDBPHOGO GDLCFFFAFKF, out int IPGIHBHBBCF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3724000", Offset = "0x3722C00", VA = "0x183724000")]
	private static void AMNLHEJLALA(DLBEDBPHOGO GDLCFFFAFKF, out LAMGCPGAHFL FADBLLIMALF, out int APFPJCMNNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3724E30", Offset = "0x3723A30", VA = "0x183724E30")]
	private static bool KAOGMAMHPAL(DLBEDBPHOGO LEFEOJHADBM, int EGHMFKBFGKN, out double FADBLLIMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3725370", Offset = "0x3723F70", VA = "0x183725370")]
	private static LAMGCPGAHFL MMNPAKCPPHM(int EGHMFKBFGKN)
	{
		return default(LAMGCPGAHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3724130", Offset = "0x3722D30", VA = "0x183724130")]
	private static bool FANKCIAIMON(DLBEDBPHOGO GDLCFFFAFKF, int EGHMFKBFGKN, out double FADBLLIMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3725510", Offset = "0x3724110", VA = "0x183725510")]
	private static bool NABAMOHFHMH(DLBEDBPHOGO LEFEOJHADBM, int EGHMFKBFGKN, out double PMLNJCIOIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3724D00", Offset = "0x3723900", VA = "0x183724D00")]
	public static double? JGBGINKFIDD(DLBEDBPHOGO GDLCFFFAFKF, int EGHMFKBFGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x37247E0", Offset = "0x37233E0", VA = "0x1837247E0")]
	public static float? HBMGAOBCJCL(DLBEDBPHOGO GDLCFFFAFKF, int EGHMFKBFGKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct ALGGJPFCPBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] GDLCFFFAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int HMFFBMGNBCG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x395AB50", Offset = "0x3959750", VA = "0x18395AB50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA25A90", Offset = "0xA24690", VA = "0x180A25A90")]
	public ALGGJPFCPBD(byte[] GDLCFFFAFKF, int HMFFBMGNBCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x395AAE0", Offset = "0x39596E0", VA = "0x18395AAE0")]
	public static ALGGJPFCPBD GJKEOPMFNFE(ALGGJPFCPBD HKEOACGCKDE)
	{
		return default(ALGGJPFCPBD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x395AA20", Offset = "0x3959620", VA = "0x18395AA20")]
	public static ALGGJPFCPBD DMKHOINDPJP(ALGGJPFCPBD HKEOACGCKDE, int LIJNMPAFKGC)
	{
		return default(ALGGJPFCPBD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x395A9C0", Offset = "0x39595C0", VA = "0x18395A9C0")]
	public static int BNJDCMFIPDA(ALGGJPFCPBD EAGBNEBPABL, ALGGJPFCPBD HDKBIEHDLMI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x395AAF0", Offset = "0x39596F0", VA = "0x18395AAF0")]
	public static bool GPLOOKALJBH(ALGGJPFCPBD EAGBNEBPABL, ALGGJPFCPBD HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x395AAC0", Offset = "0x39596C0", VA = "0x18395AAC0")]
	public static bool EGNPDGHOPNA(ALGGJPFCPBD EAGBNEBPABL, ALGGJPFCPBD HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x395AB10", Offset = "0x3959710", VA = "0x18395AB10")]
	public static bool GPLOOKALJBH(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x395AA80", Offset = "0x3959680", VA = "0x18395AA80")]
	public static bool EGNPDGHOPNA(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x395AA80", Offset = "0x3959680", VA = "0x18395AA80")]
	public static bool EGNPDGHOPNA(ALGGJPFCPBD EAGBNEBPABL, byte HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x395AB90", Offset = "0x3959790", VA = "0x18395AB90")]
	public static bool IIAENOKCJHF(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x395AC10", Offset = "0x3959810", VA = "0x18395AC10")]
	public static bool NFEJAAILLBH(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x395A9E0", Offset = "0x39595E0", VA = "0x18395A9E0")]
	public static bool CEIIEGAKHCK(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x395ABD0", Offset = "0x39597D0", VA = "0x18395ABD0")]
	public static bool JPMKLIFPJBA(ALGGJPFCPBD EAGBNEBPABL, char HDKBIEHDLMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class NGMLAIBGAIA
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] PKABDNIDJBC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] IPJNCPENKAA;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] CEJGGNHJPPK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] NGCJAALGJCB;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] LAAGFFOJMCL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int AGBPOFCGDFJ;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] JJKDNDMHKAO;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int INFDEKNPBPA;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CBC0", Offset = "0x4C2B7C0", VA = "0x184C2CBC0")]
	private static byte[] NKCIMNPLFEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C670", Offset = "0x4C2B270", VA = "0x184C2C670")]
	private static byte[] CIEACNFJGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CCA0", Offset = "0x4C2B8A0", VA = "0x184C2CCA0")]
	public static double OAMABMEBACM(byte[] GDLCFFFAFKF, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C750", Offset = "0x4C2B350", VA = "0x184C2C750")]
	public static float GDNODKEHNHO(byte[] GDLCFFFAFKF, int HMFFBMGNBCG, out int PPILNOKLPIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CA40", Offset = "0x4C2B640", VA = "0x184C2CA40")]
	private static bool NECGGOFMJBG(int FPNCCNLMGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C920", Offset = "0x4C2B520", VA = "0x184C2C920")]
	private static bool KMPJNIJIJIK(ref ALGGJPFCPBD PDAHFHABHCI, ALGGJPFCPBD HDGDBPHDMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C810", Offset = "0x4C2B410", VA = "0x184C2C810")]
	private static bool GENGKHIIBCI(ref ALGGJPFCPBD PDAHFHABHCI, ALGGJPFCPBD HDGDBPHDMPI, byte[] AJKBKKKOCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B510", Offset = "0x4C2A110", VA = "0x184C2B510")]
	private static bool ALPLLHOPAKH(ref ALGGJPFCPBD OFBIEOEMOAJ, byte[] LDIGNLIMJJL, int HMFFBMGNBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x10DBAF0", Offset = "0x10DA6F0", VA = "0x1810DBAF0")]
	private static double LAHGKPHFNEB(bool NBLLPAFCCIJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4C2B560", Offset = "0x4C2A160", VA = "0x184C2B560")]
	private static double CFCIINPBNPD(ALGGJPFCPBD OOAPEFLOBMN, int LIJNMPAFKGC, bool OHOGKPGDLHP, out int EKJPPJCDPFM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class JCFKAFDNCLG<T> : global::GBFELAFCCEK<T[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::GHNJKLJEPKK<T> DHOKCKGKFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly LJPONMCMJPJ JNBBLDDJLCO;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x33C6CE0", Offset = "0x33C58E0", VA = "0x1833C6CE0")]
	public JCFKAFDNCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1E35600", Offset = "0x1E34200", VA = "0x181E35600")]
	public JCFKAFDNCLG(LJPONMCMJPJ JNBBLDDJLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4005400", Offset = "0x4004000", VA = "0x184005400", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, T[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4007C40", Offset = "0x4006840", VA = "0x184007C40", Slot = "5")]
	public T[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class LJEJDBLJCFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::GHNJKLJEPKK<T> DHOKCKGKFFN;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class IDODBIDIMHD<T> : global::GBFELAFCCEK<List<T>>, JCNOPFNCEFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly LJPONMCMJPJ JNBBLDDJLCO;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x33C6CE0", Offset = "0x33C58E0", VA = "0x1833C6CE0")]
	public IDODBIDIMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1E35600", Offset = "0x1E34200", VA = "0x181E35600")]
	public IDODBIDIMHD(LJPONMCMJPJ JNBBLDDJLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x33C5930", Offset = "0x33C4530", VA = "0x1833C5930", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, List<T> PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x33C6770", Offset = "0x33C5370", VA = "0x1833C6770", Slot = "5")]
	public List<T> OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class IKNCEFCCMPJ<TElement, TIntermediate, TEnumerator, TCollection> : global::GBFELAFCCEK<TCollection>, JCNOPFNCEFO where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x33CF910", Offset = "0x33CE510", VA = "0x1833CF910", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, TCollection PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x33CFF00", Offset = "0x33CEB00", VA = "0x1833CFF00", Slot = "5")]
	public TCollection OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OCHGGCMACBE(TCollection CHFHFNDILMF);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NEKFKHFNPIG();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JNIPLPDFDNO(ref TIntermediate AIMOGJHOLCP, int BAOHKIGDOBF, TElement PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection HLHCNOFHMCO(ref TIntermediate LICAFMAJGDE);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected IKNCEFCCMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class GMEKABKJCDL<TElement, TIntermediate, TCollection> : global::IKNCEFCCMPJ<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3315060", Offset = "0x3313C60", VA = "0x183315060", Slot = "6")]
	protected override IEnumerator<TElement> OCHGGCMACBE(TCollection CHFHFNDILMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBE890", VA = "0x181FBFC90")]
	protected GMEKABKJCDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class AKJJNEFGAPL<TElement, TCollection> : global::GMEKABKJCDL<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected sealed override TCollection HLHCNOFHMCO(ref TCollection LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class EMMBKMFKALH<TElement, TCollection> : global::AKJJNEFGAPL<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3E1DA70", Offset = "0x3E1C670", VA = "0x183E1DA70", Slot = "7")]
	protected override TCollection NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D990", Offset = "0x3E1C590", VA = "0x183E1D990", Slot = "8")]
	protected override void JNIPLPDFDNO(ref TCollection AIMOGJHOLCP, int BAOHKIGDOBF, TElement PDMPLJICJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class COBJJEPGLCF<T> : global::IKNCEFCCMPJ<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x22B3790", Offset = "0x22B2390", VA = "0x1822B3790", Slot = "8")]
	protected override void JNIPLPDFDNO(ref LinkedList<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override LinkedList<T> HLHCNOFHMCO(ref LinkedList<T> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override LinkedList<T> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x23526B0", Offset = "0x23512B0", VA = "0x1823526B0", Slot = "6")]
	protected override LinkedList<T>.Enumerator OCHGGCMACBE(LinkedList<T> CHFHFNDILMF)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class MDCJBKHFDPB<T> : global::IKNCEFCCMPJ<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x22B3790", Offset = "0x22B2390", VA = "0x1822B3790", Slot = "8")]
	protected override void JNIPLPDFDNO(ref Queue<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override Queue<T> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2CE10A0", Offset = "0x2CDFCA0", VA = "0x182CE10A0", Slot = "6")]
	protected override Queue<T>.Enumerator OCHGGCMACBE(Queue<T> CHFHFNDILMF)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override Queue<T> HLHCNOFHMCO(ref Queue<T> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IDMPJMAGHMI<T> : global::IKNCEFCCMPJ<T, global::NABMDDKEKNK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2101160", Offset = "0x20FFD60", VA = "0x182101160", Slot = "8")]
	protected override void JNIPLPDFDNO(ref global::NABMDDKEKNK<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2101190", Offset = "0x20FFD90", VA = "0x182101190", Slot = "7")]
	protected override global::NABMDDKEKNK<T> NEKFKHFNPIG()
	{
		return default(global::NABMDDKEKNK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2CE10A0", Offset = "0x2CDFCA0", VA = "0x182CE10A0", Slot = "6")]
	protected override Stack<T>.Enumerator OCHGGCMACBE(Stack<T> CHFHFNDILMF)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x33C5410", Offset = "0x33C4010", VA = "0x1833C5410", Slot = "9")]
	protected override Stack<T> HLHCNOFHMCO(ref global::NABMDDKEKNK<T> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NNMINKGJHGE<T> : global::IKNCEFCCMPJ<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x22B3790", Offset = "0x22B2390", VA = "0x1822B3790", Slot = "8")]
	protected override void JNIPLPDFDNO(ref HashSet<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override HashSet<T> HLHCNOFHMCO(ref HashSet<T> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override HashSet<T> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2CE10A0", Offset = "0x2CDFCA0", VA = "0x182CE10A0", Slot = "6")]
	protected override HashSet<T>.Enumerator OCHGGCMACBE(HashSet<T> CHFHFNDILMF)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MGICKIDGFAG<T> : global::GMEKABKJCDL<T, global::NABMDDKEKNK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2101160", Offset = "0x20FFD60", VA = "0x182101160", Slot = "8")]
	protected override void JNIPLPDFDNO(ref global::NABMDDKEKNK<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3907FF0", Offset = "0x3906BF0", VA = "0x183907FF0", Slot = "9")]
	protected override ReadOnlyCollection<T> HLHCNOFHMCO(ref global::NABMDDKEKNK<T> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3908080", Offset = "0x3906C80", VA = "0x183908080", Slot = "7")]
	protected override global::NABMDDKEKNK<T> NEKFKHFNPIG()
	{
		return default(global::NABMDDKEKNK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MIFDIJCAIAC<T> : global::GMEKABKJCDL<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x22B3790", Offset = "0x22B2390", VA = "0x1822B3790", Slot = "8")]
	protected override void JNIPLPDFDNO(ref List<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override List<T> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override IList<T> HLHCNOFHMCO(ref List<T> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class DIDBFLCBLAM<T> : global::GMEKABKJCDL<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x22B3790", Offset = "0x22B2390", VA = "0x1822B3790", Slot = "8")]
	protected override void JNIPLPDFDNO(ref List<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override List<T> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override ICollection<T> HLHCNOFHMCO(ref List<T> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class IGIODDLKNPB<T> : global::GMEKABKJCDL<T, global::NABMDDKEKNK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2101160", Offset = "0x20FFD60", VA = "0x182101160", Slot = "8")]
	protected override void JNIPLPDFDNO(ref global::NABMDDKEKNK<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2101190", Offset = "0x20FFD90", VA = "0x182101190", Slot = "7")]
	protected override global::NABMDDKEKNK<T> NEKFKHFNPIG()
	{
		return default(global::NABMDDKEKNK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x33CCE20", Offset = "0x33CBA20", VA = "0x1833CCE20", Slot = "9")]
	protected override IEnumerable<T> HLHCNOFHMCO(ref global::NABMDDKEKNK<T> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class IDKMMPDMDGM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class GPFAMKGMENL<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class FMHOEGDEAEL<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class JDKHIIDDOMB : global::GBFELAFCCEK<IEnumerable>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::GBFELAFCCEK<IEnumerable> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x371E4B0", Offset = "0x371D0B0", VA = "0x18371E4B0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, IEnumerable PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x371E710", Offset = "0x371D310", VA = "0x18371E710", Slot = "5")]
	public IEnumerable OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JDKHIIDDOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OLEGEMDBPEL : global::GBFELAFCCEK<ICollection>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::GBFELAFCCEK<ICollection> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EE90", Offset = "0x4C2DA90", VA = "0x184C2EE90", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ICollection PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F130", Offset = "0x4C2DD30", VA = "0x184C2F130", Slot = "5")]
	public ICollection OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OLEGEMDBPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class IPMOEDOHMLO : global::GBFELAFCCEK<IList>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::GBFELAFCCEK<IList> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x371C910", Offset = "0x371B510", VA = "0x18371C910", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, IList PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x371CC50", Offset = "0x371B850", VA = "0x18371CC50", Slot = "5")]
	public IList OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IPMOEDOHMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class FJILAHKMPKK<T> : global::GMEKABKJCDL<T, global::NABMDDKEKNK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2101130", Offset = "0x20FFD30", VA = "0x182101130", Slot = "8")]
	protected override void JNIPLPDFDNO(ref global::NABMDDKEKNK<T> AIMOGJHOLCP, int BAOHKIGDOBF, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2101190", Offset = "0x20FFD90", VA = "0x182101190", Slot = "7")]
	protected override global::NABMDDKEKNK<T> NEKFKHFNPIG()
	{
		return default(global::NABMDDKEKNK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x21010F0", Offset = "0x20FFCF0", VA = "0x1821010F0", Slot = "9")]
	protected override IReadOnlyList<T> HLHCNOFHMCO(ref global::NABMDDKEKNK<T> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1E27C90", Offset = "0x1E26890", VA = "0x181E27C90")]
	public FJILAHKMPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class LBDOCGEAFNP
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3723940", Offset = "0x3722540", VA = "0x183723940")]
	public static DateTime FGLFPDHLIJN(DateTime GBMAFDNOPLJ)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class EFAKKPGEKIK : global::GBFELAFCCEK<DateTime>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::GBFELAFCCEK<DateTime> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x39698A0", Offset = "0x39684A0", VA = "0x1839698A0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, DateTime PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3969CF0", Offset = "0x39688F0", VA = "0x183969CF0", Slot = "5")]
	public DateTime OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EFAKKPGEKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class FHDBIIMBDKF : global::GBFELAFCCEK<DateTimeOffset>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::GBFELAFCCEK<DateTimeOffset> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x396C7F0", Offset = "0x396B3F0", VA = "0x18396C7F0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, DateTimeOffset PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x396CBC0", Offset = "0x396B7C0", VA = "0x18396CBC0", Slot = "5")]
	public DateTimeOffset OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FHDBIIMBDKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class NEEJKKHLNMJ : global::GBFELAFCCEK<TimeSpan>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::GBFELAFCCEK<TimeSpan> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] DFOOCMACODD;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A680", Offset = "0x4C29280", VA = "0x184C2A680", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, TimeSpan PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A940", Offset = "0x4C29540", VA = "0x184C2A940", Slot = "5")]
	public TimeSpan OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NEEJKKHLNMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class IPAFPPACAAN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::GBFELAFCCEK<TDictionary>, JCNOPFNCEFO where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4000600", Offset = "0x3FFF200", VA = "0x184000600", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, TDictionary PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4003D40", Offset = "0x4002940", VA = "0x184003D40", Slot = "5")]
	public TDictionary OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator OCHGGCMACBE(TDictionary CHFHFNDILMF);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NEKFKHFNPIG();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JNIPLPDFDNO(ref TIntermediate AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary HLHCNOFHMCO(ref TIntermediate LICAFMAJGDE);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected IPAFPPACAAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class MMMLDNDMDJM<TKey, TValue, TIntermediate, TDictionary> : global::IPAFPPACAAN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3315060", Offset = "0x3313C60", VA = "0x183315060", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> OCHGGCMACBE(TDictionary CHFHFNDILMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class MMPEAOGJOHC<TKey, TValue, TDictionary> : global::MMMLDNDMDJM<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override TDictionary HLHCNOFHMCO(ref TDictionary LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class GLCNKIECBBC<TKey, TValue> : global::IPAFPPACAAN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x33A7E20", Offset = "0x33A6A20", VA = "0x1833A7E20", Slot = "8")]
	protected override void JNIPLPDFDNO(ref Dictionary<TKey, TValue> AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override Dictionary<TKey, TValue> HLHCNOFHMCO(ref Dictionary<TKey, TValue> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x33A7E60", Offset = "0x33A6A60", VA = "0x1833A7E60", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator OCHGGCMACBE(Dictionary<TKey, TValue> CHFHFNDILMF)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C9E0", Offset = "0x1F0B5E0", VA = "0x181F0C9E0")]
	public GLCNKIECBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PAKALCNIKLP<TKey, TValue, TDictionary> : global::MMPEAOGJOHC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4056A00", Offset = "0x4055600", VA = "0x184056A00", Slot = "8")]
	protected override void JNIPLPDFDNO(ref TDictionary AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3CFCE20", Offset = "0x3CFBA20", VA = "0x183CFCE20", Slot = "7")]
	protected override TDictionary NEKFKHFNPIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class ANPHFKPJKFD<TKey, TValue> : global::MMMLDNDMDJM<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2425B60", Offset = "0x2424760", VA = "0x182425B60", Slot = "8")]
	protected override void JNIPLPDFDNO(ref Dictionary<TKey, TValue> AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override IDictionary<TKey, TValue> HLHCNOFHMCO(ref Dictionary<TKey, TValue> LICAFMAJGDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class BCCEGIDMJDD<TKey, TValue> : global::MMPEAOGJOHC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2425B60", Offset = "0x2424760", VA = "0x182425B60", Slot = "8")]
	protected override void JNIPLPDFDNO(ref SortedList<TKey, TValue> AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override SortedList<TKey, TValue> NEKFKHFNPIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class JLNBGGDBNFI<TKey, TValue> : global::IPAFPPACAAN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2425B60", Offset = "0x2424760", VA = "0x182425B60", Slot = "8")]
	protected override void JNIPLPDFDNO(ref SortedDictionary<TKey, TValue> AIMOGJHOLCP, int BAOHKIGDOBF, TKey IHPCMBAPNMC, TValue PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x10BFCB0", Offset = "0x10BE8B0", VA = "0x1810BFCB0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> HLHCNOFHMCO(ref SortedDictionary<TKey, TValue> LICAFMAJGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x22B37D0", Offset = "0x22B23D0", VA = "0x1822B37D0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> NEKFKHFNPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2425BA0", Offset = "0x24247A0", VA = "0x182425BA0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator OCHGGCMACBE(SortedDictionary<TKey, TValue> CHFHFNDILMF)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class MLGOPMHENKG<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class DJABACNDDGL : global::GBFELAFCCEK<IDictionary>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::GBFELAFCCEK<IDictionary> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3967510", Offset = "0x3966110", VA = "0x183967510", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, IDictionary PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x3967890", Offset = "0x3966490", VA = "0x183967890", Slot = "5")]
	public IDictionary OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public DJABACNDDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class MIILLOKLEFP : global::GBFELAFCCEK<object>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void AIOEFBLNNLD(object KPEMJGJPIGB, ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::LJMOEGEKHCB<KeyValuePair<object, AIOEFBLNNLD>> JLNMBMPNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly HOIKBOKFDFO[] HCJHLEFAOJH;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4C273E0", Offset = "0x4C25FE0", VA = "0x184C273E0")]
	public MIILLOKLEFP(params HOIKBOKFDFO[] HCJHLEFAOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4C26A60", Offset = "0x4C25660", VA = "0x184C26A60", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4C27350", Offset = "0x4C25F50", VA = "0x184C27350", Slot = "5")]
	public object OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class DNGPFAFDJPE
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x39687A0", Offset = "0x39673A0", VA = "0x1839687A0")]
	public static object EPKKPIPAEND(Type HCPDGKICMEB, out bool AKAPMJENFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3967FC0", Offset = "0x3966BC0", VA = "0x183967FC0")]
	public static object CEOGJEAKLBM(Type HCPDGKICMEB, out bool AKAPMJENFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class NEFFLODHFKC<T> : global::GBFELAFCCEK<T>, JCNOPFNCEFO, global::CCIEOMJBIPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class HDFOFAPKEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public HDFOFAPKEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4890", Offset = "0x3FA3490", VA = "0x183FA4890")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class NLDCKHBFGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::HLPMBFGCNKA<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public NLDCKHBFGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3FBC2E0", Offset = "0x3FBAEE0", VA = "0x183FBC2E0")]
		internal void <.cctor>b__1(ref JDFGLOCODHE writer, T value, HOIKBOKFDFO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HBKAILIHIHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::PGNGCNAHINH<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public HBKAILIHIHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3FA2C00", Offset = "0x3FA1800", VA = "0x183FA2C00")]
		internal T <.cctor>b__2(ref HFCILADMLMB reader, HOIKBOKFDFO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::GPIACEDOAJK<T> PBBPEOCEJDM;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> IJDOFOBNIGA;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::HLPMBFGCNKA<T> PALGEFLGBOH;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::PGNGCNAHINH<T> DDNGAKMCFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool EBPGMBEOKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::HLPMBFGCNKA<T> IPFNMNOFKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::PGNGCNAHINH<T> PFNIEGCOECM;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3FB1FC0", Offset = "0x3FB0BC0", VA = "0x183FB1FC0")]
	static NEFFLODHFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB020", Offset = "0x3FB9C20", VA = "0x183FBB020")]
	public NEFFLODHFKC(bool EBPGMBEOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3FA91B0", Offset = "0x3FA7DB0", VA = "0x183FA91B0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3FAAFE0", Offset = "0x3FA9BE0", VA = "0x183FAAFE0", Slot = "5")]
	public T OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA880", Offset = "0x3FA9480", VA = "0x183FAA880", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, T PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8600", Offset = "0x3FA7200", VA = "0x183FA8600", Slot = "7")]
	public T BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class JADIIDGDHKH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class OICJEOOEEOK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class PKLKCHPLGPB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class KPLNOOPIBAG<T> : global::GBFELAFCCEK<T?>, JCNOPFNCEFO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x44E7290", Offset = "0x44E5E90", VA = "0x1844E7290", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, T? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x44E7540", Offset = "0x44E6140", VA = "0x1844E7540", Slot = "5")]
	public T? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	public KPLNOOPIBAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class AADJAGENCLK<T> : global::GBFELAFCCEK<T?>, JCNOPFNCEFO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::GBFELAFCCEK<T> FOJOHHABFAB;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
	public AADJAGENCLK(global::GBFELAFCCEK<T> FOJOHHABFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5317F70", Offset = "0x5316B70", VA = "0x185317F70", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, T? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x53180A0", Offset = "0x5316CA0", VA = "0x1853180A0", Slot = "5")]
	public T? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class DBCFOIKCHDP : global::GBFELAFCCEK<sbyte>, JCNOPFNCEFO, global::CCIEOMJBIPK<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly DBCFOIKCHDP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3966EC0", Offset = "0x3965AC0", VA = "0x183966EC0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, sbyte PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3966F20", Offset = "0x3965B20", VA = "0x183966F20", Slot = "5")]
	public sbyte OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x3966EE0", Offset = "0x3965AE0", VA = "0x183966EE0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, sbyte PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3966E20", Offset = "0x3965A20", VA = "0x183966E20", Slot = "7")]
	public sbyte BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public DBCFOIKCHDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class PGPMPAEFOJD : global::GBFELAFCCEK<sbyte?>, JCNOPFNCEFO, global::CCIEOMJBIPK<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly PGPMPAEFOJD OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4C30350", Offset = "0x4C2EF50", VA = "0x184C30350", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, sbyte? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C30440", Offset = "0x4C2F040", VA = "0x184C30440", Slot = "5")]
	public sbyte? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C303C0", Offset = "0x4C2EFC0", VA = "0x184C303C0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, sbyte? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C302A0", Offset = "0x4C2EEA0", VA = "0x184C302A0", Slot = "7")]
	public sbyte? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PGPMPAEFOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class LCHOGOPEPMG : global::GBFELAFCCEK<sbyte[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly LCHOGOPEPMG OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3723A50", Offset = "0x3722650", VA = "0x183723A50", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, sbyte[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x3723BF0", Offset = "0x37227F0", VA = "0x183723BF0", Slot = "5")]
	public sbyte[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public LCHOGOPEPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class OJMNDAOBDCJ : global::GBFELAFCCEK<short>, JCNOPFNCEFO, global::CCIEOMJBIPK<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly OJMNDAOBDCJ OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EDC0", Offset = "0x4C2D9C0", VA = "0x184C2EDC0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, short PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EE20", Offset = "0x4C2DA20", VA = "0x184C2EE20", Slot = "5")]
	public short OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C2EDE0", Offset = "0x4C2D9E0", VA = "0x184C2EDE0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, short PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2ED50", Offset = "0x4C2D950", VA = "0x184C2ED50", Slot = "7")]
	public short BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OJMNDAOBDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class OOGEJDFAANJ : global::GBFELAFCCEK<short?>, JCNOPFNCEFO, global::CCIEOMJBIPK<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly OOGEJDFAANJ OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F870", Offset = "0x4C2E470", VA = "0x184C2F870", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, short? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F960", Offset = "0x4C2E560", VA = "0x184C2F960", Slot = "5")]
	public short? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F8E0", Offset = "0x4C2E4E0", VA = "0x184C2F8E0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, short? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F7D0", Offset = "0x4C2E3D0", VA = "0x184C2F7D0", Slot = "7")]
	public short? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OOGEJDFAANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MIKNMKJCAEF : global::GBFELAFCCEK<short[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly MIKNMKJCAEF OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C27480", Offset = "0x4C26080", VA = "0x184C27480", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, short[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x4C27540", Offset = "0x4C26140", VA = "0x184C27540", Slot = "5")]
	public short[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public MIKNMKJCAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IHJDPFKPDJP : global::GBFELAFCCEK<int>, JCNOPFNCEFO, global::CCIEOMJBIPK<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly IHJDPFKPDJP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x371B750", Offset = "0x371A350", VA = "0x18371B750", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, int PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x371B840", Offset = "0x371A440", VA = "0x18371B840", Slot = "5")]
	public int OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x371B780", Offset = "0x371A380", VA = "0x18371B780", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, int PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x371B6E0", Offset = "0x371A2E0", VA = "0x18371B6E0", Slot = "7")]
	public int BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IHJDPFKPDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JANLFMCHDHA : global::GBFELAFCCEK<int?>, JCNOPFNCEFO, global::CCIEOMJBIPK<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JANLFMCHDHA OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x371CF40", Offset = "0x371BB40", VA = "0x18371CF40", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, int? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x371D0C0", Offset = "0x371BCC0", VA = "0x18371D0C0", Slot = "5")]
	public int? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x371CFC0", Offset = "0x371BBC0", VA = "0x18371CFC0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, int? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x371CEA0", Offset = "0x371BAA0", VA = "0x18371CEA0", Slot = "7")]
	public int? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JANLFMCHDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class PPFOPIMKPCA : global::GBFELAFCCEK<int[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly PPFOPIMKPCA OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4C33A20", Offset = "0x4C32620", VA = "0x184C33A20", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, int[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4C33AE0", Offset = "0x4C326E0", VA = "0x184C33AE0", Slot = "5")]
	public int[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PPFOPIMKPCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class OCCKNKNHNMP : global::GBFELAFCCEK<long>, JCNOPFNCEFO, global::CCIEOMJBIPK<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly OCCKNKNHNMP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D1E0", Offset = "0x4C2BDE0", VA = "0x184C2D1E0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, long PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D240", Offset = "0x4C2BE40", VA = "0x184C2D240", Slot = "5")]
	public long OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D200", Offset = "0x4C2BE00", VA = "0x184C2D200", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, long PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D170", Offset = "0x4C2BD70", VA = "0x184C2D170", Slot = "7")]
	public long BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OCCKNKNHNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class IJAIGKIFMHO : global::GBFELAFCCEK<long?>, JCNOPFNCEFO, global::CCIEOMJBIPK<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly IJAIGKIFMHO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x371BCC0", Offset = "0x371A8C0", VA = "0x18371BCC0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, long? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x371BE40", Offset = "0x371AA40", VA = "0x18371BE40", Slot = "5")]
	public long? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x371BD40", Offset = "0x371A940", VA = "0x18371BD40", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, long? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x371BC00", Offset = "0x371A800", VA = "0x18371BC00", Slot = "7")]
	public long? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IJAIGKIFMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class NADNIHJKAHM : global::GBFELAFCCEK<long[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly NADNIHJKAHM OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C27940", Offset = "0x4C26540", VA = "0x184C27940", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, long[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C27A00", Offset = "0x4C26600", VA = "0x184C27A00", Slot = "5")]
	public long[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NADNIHJKAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JNCMBFOEMAB : global::GBFELAFCCEK<byte>, JCNOPFNCEFO, global::CCIEOMJBIPK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JNCMBFOEMAB OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3721300", Offset = "0x371FF00", VA = "0x183721300", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, byte PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3721400", Offset = "0x3720000", VA = "0x183721400", Slot = "5")]
	public byte OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3721340", Offset = "0x371FF40", VA = "0x183721340", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, byte PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3721290", Offset = "0x371FE90", VA = "0x183721290", Slot = "7")]
	public byte BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JNCMBFOEMAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class BMJHEHIDMBJ : global::GBFELAFCCEK<byte?>, JCNOPFNCEFO, global::CCIEOMJBIPK<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BMJHEHIDMBJ OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x395B880", Offset = "0x395A480", VA = "0x18395B880", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, byte? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x395B970", Offset = "0x395A570", VA = "0x18395B970", Slot = "5")]
	public byte? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x395B8F0", Offset = "0x395A4F0", VA = "0x18395B8F0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, byte? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x395B7A0", Offset = "0x395A3A0", VA = "0x18395B7A0", Slot = "7")]
	public byte? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public BMJHEHIDMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class CBIPFAFGPCO : global::GBFELAFCCEK<ushort>, JCNOPFNCEFO, global::CCIEOMJBIPK<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly CBIPFAFGPCO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x39665D0", Offset = "0x39651D0", VA = "0x1839665D0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ushort PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3966630", Offset = "0x3965230", VA = "0x183966630", Slot = "5")]
	public ushort OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x39665F0", Offset = "0x39651F0", VA = "0x1839665F0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, ushort PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x3966530", Offset = "0x3965130", VA = "0x183966530", Slot = "7")]
	public ushort BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public CBIPFAFGPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class EIENMMKNLOH : global::GBFELAFCCEK<ushort?>, JCNOPFNCEFO, global::CCIEOMJBIPK<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly EIENMMKNLOH OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x396BC60", Offset = "0x396A860", VA = "0x18396BC60", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ushort? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x396BD50", Offset = "0x396A950", VA = "0x18396BD50", Slot = "5")]
	public ushort? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x396BCD0", Offset = "0x396A8D0", VA = "0x18396BCD0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, ushort? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x396BB90", Offset = "0x396A790", VA = "0x18396BB90", Slot = "7")]
	public ushort? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EIENMMKNLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class AMNKNBMBLEJ : global::GBFELAFCCEK<ushort[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly AMNKNBMBLEJ OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x395AF90", Offset = "0x3959B90", VA = "0x18395AF90", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ushort[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x395B050", Offset = "0x3959C50", VA = "0x18395B050", Slot = "5")]
	public ushort[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public AMNKNBMBLEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class CELGFFPKLMM : global::GBFELAFCCEK<uint>, JCNOPFNCEFO, global::CCIEOMJBIPK<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CELGFFPKLMM OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3966740", Offset = "0x3965340", VA = "0x183966740", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, uint PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3966790", Offset = "0x3965390", VA = "0x183966790", Slot = "5")]
	public uint OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3966750", Offset = "0x3965350", VA = "0x183966750", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, uint PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x39666A0", Offset = "0x39652A0", VA = "0x1839666A0", Slot = "7")]
	public uint BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public CELGFFPKLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KMJBEBJPMOB : global::GBFELAFCCEK<uint?>, JCNOPFNCEFO, global::CCIEOMJBIPK<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KMJBEBJPMOB OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x37233A0", Offset = "0x3721FA0", VA = "0x1837233A0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, uint? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3723520", Offset = "0x3722120", VA = "0x183723520", Slot = "5")]
	public uint? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3723420", Offset = "0x3722020", VA = "0x183723420", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, uint? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3723300", Offset = "0x3721F00", VA = "0x183723300", Slot = "7")]
	public uint? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public KMJBEBJPMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CHFNFBLAAGB : global::GBFELAFCCEK<uint[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly CHFNFBLAAGB OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3966800", Offset = "0x3965400", VA = "0x183966800", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, uint[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x39668C0", Offset = "0x39654C0", VA = "0x1839668C0", Slot = "5")]
	public uint[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public CHFNFBLAAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PGGOAMNCMBO : global::GBFELAFCCEK<ulong>, JCNOPFNCEFO, global::CCIEOMJBIPK<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly PGGOAMNCMBO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF70", Offset = "0x4C2EB70", VA = "0x184C2FF70", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ulong PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FFD0", Offset = "0x4C2EBD0", VA = "0x184C2FFD0", Slot = "5")]
	public ulong OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF90", Offset = "0x4C2EB90", VA = "0x184C2FF90", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, ulong PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FF00", Offset = "0x4C2EB00", VA = "0x184C2FF00", Slot = "7")]
	public ulong BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PGGOAMNCMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class MAKFKCONECC : global::GBFELAFCCEK<ulong?>, JCNOPFNCEFO, global::CCIEOMJBIPK<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly MAKFKCONECC OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4C259F0", Offset = "0x4C245F0", VA = "0x184C259F0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ulong? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4C25AE0", Offset = "0x4C246E0", VA = "0x184C25AE0", Slot = "5")]
	public ulong? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4C25A60", Offset = "0x4C24660", VA = "0x184C25A60", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, ulong? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4C25930", Offset = "0x4C24530", VA = "0x184C25930", Slot = "7")]
	public ulong? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public MAKFKCONECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MHOFDAOHHNA : global::GBFELAFCCEK<ulong[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly MHOFDAOHHNA OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4C26800", Offset = "0x4C25400", VA = "0x184C26800", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ulong[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x4C268C0", Offset = "0x4C254C0", VA = "0x184C268C0", Slot = "5")]
	public ulong[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public MHOFDAOHHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class AJJIHGNFJGG : global::GBFELAFCCEK<float>, JCNOPFNCEFO, global::CCIEOMJBIPK<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly AJJIHGNFJGG OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x395A900", Offset = "0x3959500", VA = "0x18395A900", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, float PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x395A950", Offset = "0x3959550", VA = "0x18395A950", Slot = "5")]
	public float OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x395A910", Offset = "0x3959510", VA = "0x18395A910", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, float PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x395A860", Offset = "0x3959460", VA = "0x18395A860", Slot = "7")]
	public float BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public AJJIHGNFJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FNPFKKKMFOM : global::GBFELAFCCEK<float?>, JCNOPFNCEFO, global::CCIEOMJBIPK<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly FNPFKKKMFOM OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x370EDA0", Offset = "0x370D9A0", VA = "0x18370EDA0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, float? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x370EF00", Offset = "0x370DB00", VA = "0x18370EF00", Slot = "5")]
	public float? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x370EE10", Offset = "0x370DA10", VA = "0x18370EE10", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, float? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x370ED00", Offset = "0x370D900", VA = "0x18370ED00", Slot = "7")]
	public float? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FNPFKKKMFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IGGHFMANCNN : global::GBFELAFCCEK<float[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IGGHFMANCNN OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x371B300", Offset = "0x3719F00", VA = "0x18371B300", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, float[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x371B4E0", Offset = "0x371A0E0", VA = "0x18371B4E0", Slot = "5")]
	public float[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IGGHFMANCNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class PBIANNDKABP : global::GBFELAFCCEK<double>, JCNOPFNCEFO, global::CCIEOMJBIPK<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly PBIANNDKABP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FBC0", Offset = "0x4C2E7C0", VA = "0x184C2FBC0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, double PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FC10", Offset = "0x4C2E810", VA = "0x184C2FC10", Slot = "5")]
	public double OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FBD0", Offset = "0x4C2E7D0", VA = "0x184C2FBD0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, double PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x4C2FB50", Offset = "0x4C2E750", VA = "0x184C2FB50", Slot = "7")]
	public double BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PBIANNDKABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class DKNILMDBMAF : global::GBFELAFCCEK<double?>, JCNOPFNCEFO, global::CCIEOMJBIPK<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly DKNILMDBMAF OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3967BA0", Offset = "0x39667A0", VA = "0x183967BA0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, double? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3967C90", Offset = "0x3966890", VA = "0x183967C90", Slot = "5")]
	public double? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3967C10", Offset = "0x3966810", VA = "0x183967C10", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, double? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3967A90", Offset = "0x3966690", VA = "0x183967A90", Slot = "7")]
	public double? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public DKNILMDBMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class FHOAPJGMPEE : global::GBFELAFCCEK<double[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly FHOAPJGMPEE OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x370E730", Offset = "0x370D330", VA = "0x18370E730", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, double[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x370E910", Offset = "0x370D510", VA = "0x18370E910", Slot = "5")]
	public double[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FHOAPJGMPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class JJIDJDKLCPC : global::GBFELAFCCEK<bool>, JCNOPFNCEFO, global::CCIEOMJBIPK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly JJIDJDKLCPC OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x37210C0", Offset = "0x371FCC0", VA = "0x1837210C0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, bool PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3721190", Offset = "0x371FD90", VA = "0x183721190", Slot = "5")]
	public bool OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x37210E0", Offset = "0x371FCE0", VA = "0x1837210E0", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, bool PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x3721050", Offset = "0x371FC50", VA = "0x183721050", Slot = "7")]
	public bool BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JJIDJDKLCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class ICNLLJFINCC : global::GBFELAFCCEK<bool?>, JCNOPFNCEFO, global::CCIEOMJBIPK<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly ICNLLJFINCC OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x37182A0", Offset = "0x3716EA0", VA = "0x1837182A0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, bool? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3718400", Offset = "0x3717000", VA = "0x183718400", Slot = "5")]
	public bool? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3718310", Offset = "0x3716F10", VA = "0x183718310", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, bool? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x37181F0", Offset = "0x3716DF0", VA = "0x1837181F0", Slot = "7")]
	public bool? BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public ICNLLJFINCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class IDKPBGIEKGO : global::GBFELAFCCEK<bool[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly IDKPBGIEKGO OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x37188B0", Offset = "0x37174B0", VA = "0x1837188B0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, bool[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x3718A30", Offset = "0x3717630", VA = "0x183718A30", Slot = "5")]
	public bool[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public IDKPBGIEKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class EGDFCHDFIFC : global::GBFELAFCCEK<object>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::GBFELAFCCEK<object> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> KKKCOINJJOA;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x396AC90", Offset = "0x3969890", VA = "0x18396AC90", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, object PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x396B5E0", Offset = "0x396A1E0", VA = "0x18396B5E0", Slot = "5")]
	public object OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EGDFCHDFIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EMFFBFGCBIG : global::GBFELAFCCEK<byte[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::GBFELAFCCEK<byte[]> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x396C1F0", Offset = "0x396ADF0", VA = "0x18396C1F0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, byte[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x396C280", Offset = "0x396AE80", VA = "0x18396C280", Slot = "5")]
	public byte[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EMFFBFGCBIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HJEDEHMPHEF : global::GBFELAFCCEK<ArraySegment<byte>>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::GBFELAFCCEK<ArraySegment<byte>> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3716110", Offset = "0x3714D10", VA = "0x183716110", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, ArraySegment<byte> PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x37161B0", Offset = "0x3714DB0", VA = "0x1837161B0", Slot = "5")]
	public ArraySegment<byte> OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public HJEDEHMPHEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JKPIDALFOMM : global::GBFELAFCCEK<string>, JCNOPFNCEFO, global::CCIEOMJBIPK<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::GBFELAFCCEK<string> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x3721210", Offset = "0x371FE10", VA = "0x183721210", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, string PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x3721200", Offset = "0x371FE00", VA = "0x183721200", Slot = "5")]
	public string OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x3721210", Offset = "0x371FE10", VA = "0x183721210", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, string PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x3721200", Offset = "0x371FE00", VA = "0x183721200", Slot = "7")]
	public string BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JKPIDALFOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class PGNHDPBNFCP : global::GBFELAFCCEK<string[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly PGNHDPBNFCP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4C30040", Offset = "0x4C2EC40", VA = "0x184C30040", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, string[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4C30100", Offset = "0x4C2ED00", VA = "0x184C30100", Slot = "5")]
	public string[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public PGNHDPBNFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class JOFLDOHGKPP : global::GBFELAFCCEK<char>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly JOFLDOHGKPP OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x37214C0", Offset = "0x37200C0", VA = "0x1837214C0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, char PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3721540", Offset = "0x3720140", VA = "0x183721540", Slot = "5")]
	public char OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public JOFLDOHGKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class DNLELLMGADA : global::GBFELAFCCEK<char?>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly DNLELLMGADA OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x3969030", Offset = "0x3967C30", VA = "0x183969030", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, char? PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3969100", Offset = "0x3967D00", VA = "0x183969100", Slot = "5")]
	public char? OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public DNLELLMGADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class EOKCDNOFEFC : global::GBFELAFCCEK<char[]>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly EOKCDNOFEFC OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x396C360", Offset = "0x396AF60", VA = "0x18396C360", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, char[] PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x396C4E0", Offset = "0x396B0E0", VA = "0x18396C4E0", Slot = "5")]
	public char[] OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public EOKCDNOFEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class MLKAECDJMEP : global::GBFELAFCCEK<Guid>, JCNOPFNCEFO, global::CCIEOMJBIPK<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::GBFELAFCCEK<Guid> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4C27730", Offset = "0x4C26330", VA = "0x184C27730", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Guid PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4C277D0", Offset = "0x4C263D0", VA = "0x184C277D0", Slot = "5")]
	public Guid OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4C27730", Offset = "0x4C26330", VA = "0x184C27730", Slot = "6")]
	public void KAALOPHABDF(ref JDFGLOCODHE BFKGLJCKHHO, Guid PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4C276E0", Offset = "0x4C262E0", VA = "0x184C276E0", Slot = "7")]
	public Guid BIDAICGMHLG(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public MLKAECDJMEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class PODDMNHLIFF : global::GBFELAFCCEK<decimal>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::GBFELAFCCEK<decimal> OAMALNNIHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool ODAJLNGEMMF;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xBC9F40", Offset = "0xBC8B40", VA = "0x180BC9F40")]
	public PODDMNHLIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x192B180", Offset = "0x1929D80", VA = "0x18192B180")]
	public PODDMNHLIFF(bool ODAJLNGEMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4C336D0", Offset = "0x4C322D0", VA = "0x184C336D0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, decimal PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4C33810", Offset = "0x4C32410", VA = "0x184C33810", Slot = "5")]
	public decimal OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class INFLGJBGIFL : global::GBFELAFCCEK<Uri>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::GBFELAFCCEK<Uri> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x371C6D0", Offset = "0x371B2D0", VA = "0x18371C6D0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Uri PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x371C780", Offset = "0x371B380", VA = "0x18371C780", Slot = "5")]
	public Uri OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public INFLGJBGIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class NBBFBDHOLNA : global::GBFELAFCCEK<Version>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::GBFELAFCCEK<Version> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x4C29BD0", Offset = "0x4C287D0", VA = "0x184C29BD0", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Version PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C80", Offset = "0x4C28880", VA = "0x184C29C80", Slot = "5")]
	public Version OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NBBFBDHOLNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class HGGOIKHONMP<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class OMEFOGFGBGO : global::GBFELAFCCEK<StringBuilder>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::GBFELAFCCEK<StringBuilder> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F310", Offset = "0x4C2DF10", VA = "0x184C2F310", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, StringBuilder PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F360", Offset = "0x4C2DF60", VA = "0x184C2F360", Slot = "5")]
	public StringBuilder OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OMEFOGFGBGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class NNDOMEBGHFE : global::GBFELAFCCEK<BitArray>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::GBFELAFCCEK<BitArray> OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CF80", Offset = "0x4C2BB80", VA = "0x184C2CF80", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, BitArray PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D010", Offset = "0x4C2BC10", VA = "0x184C2D010", Slot = "5")]
	public BitArray OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public NNDOMEBGHFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class JFHMLEEBGFM : global::GBFELAFCCEK<Type>, JCNOPFNCEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly JFHMLEEBGFM OAMALNNIHFL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex EFIOPLHCPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool OLOGGMKCGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool CAGOANJEEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool OCDFDCGEDHH;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x3720D20", Offset = "0x371F920", VA = "0x183720D20")]
	public JFHMLEEBGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x3720D40", Offset = "0x371F940", VA = "0x183720D40")]
	public JFHMLEEBGFM(bool OLOGGMKCGDO, bool CAGOANJEEJL, bool OCDFDCGEDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x3720A70", Offset = "0x371F670", VA = "0x183720A70", Slot = "4")]
	public void EKJBCLFLGLG(ref JDFGLOCODHE BFKGLJCKHHO, Type PDMPLJICJLE, HOIKBOKFDFO MNOAAOBLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x3720B60", Offset = "0x371F760", VA = "0x183720B60", Slot = "5")]
	public Type OPELNPIHKCP(ref HFCILADMLMB CPAEFKPNLIE, HOIKBOKFDFO MNOAAOBLFAN)
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
