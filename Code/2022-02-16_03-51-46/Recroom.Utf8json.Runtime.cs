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
public class JPIDMMJPKMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public JPIDMMJPKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NDCCIFBMBKJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public NDCCIFBMBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MDJPKAICELG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public MDJPKAICELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class AHBBGAJNBMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public AHBBGAJNBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LBOGOONNADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4924550", Offset = "0x4922D50", VA = "0x184924550")]
	public static bool GGMNEHKNEGH(this TypeInfo BJNLFFPNEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class DFDPGFLELJD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LHPEEDADFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PNINNEKILJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CB410", Offset = "0x6C9C10", VA = "0x1806CB410")]
	public DFDPGFLELJD(Type KFFJHJNDMGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class JKAFEDKKAAO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EGIENKHCBHG<T>(ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T OIGKJKHOOII<T>(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI BPMIAJOHFFA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AOMFJBLHMMA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CCBAHIKANPJ<T> : AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NDKKKOMLDLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KECBLAJDCPL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AOJLKMIIAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31339F0", Offset = "0x31321F0", VA = "0x1831339F0")]
	public static global::CCBAHIKANPJ<T> GCIBJHBBCKH<T>(this CNPMPMJABJI BPMIAJOHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3622700", Offset = "0x3620F00", VA = "0x183622700")]
	public static object LMNMDHECHKH(this CNPMPMJABJI BPMIAJOHFFA, Type BJNLFFPNEBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ELFCNHBODPC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xFE8BD0", Offset = "0xFE73D0", VA = "0x180FE8BD0")]
	public ELFCNHBODPC(string MGAAKCJLEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LMJECJJKNAB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class MDIANPLGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] KIJIMACKNGN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] IPEFNJBDNON;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4929C40", Offset = "0x4928440", VA = "0x184929C40")]
		public static byte[] AANBMFLHOOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4929CC0", Offset = "0x49284C0", VA = "0x184929CC0")]
		public static char[] MLNGKMLNBOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> DHPCABDGJOE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] BJENPKGJBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] OCICGABDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BIJBEGOMFPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ECBOLOPOCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4926130", Offset = "0x4924930", VA = "0x184926130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x49286F0", Offset = "0x4926EF0", VA = "0x1849286F0")]
	public LMJECJJKNAB(byte[] OCICGABDCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4928510", Offset = "0x4926D10", VA = "0x184928510")]
	public LMJECJJKNAB(byte[] OCICGABDCEM, int BIJBEGOMFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4926F20", Offset = "0x4925720", VA = "0x184926F20")]
	private IAKDGNKPJCM KIIAIFLGMEM(string OIGJNHFPEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4925F90", Offset = "0x4924790", VA = "0x184925F90")]
	private IAKDGNKPJCM BKCIMGFJIIP(string MGAAKCJLEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xFE5230", Offset = "0xFE3A30", VA = "0x180FE5230")]
	public void PGAHPFODADP(int BIJBEGOMFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BBB80", Offset = "0x5BA380", VA = "0x1805BBB80")]
	public byte[] FDFMHMOIOHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A9E90", Offset = "0x7A8690", VA = "0x1807A9E90")]
	public int OLGJGLBFMLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4926B20", Offset = "0x4925320", VA = "0x184926B20")]
	public JKLBJIOBKDH HEOPKBMBIJP()
	{
		return default(JKLBJIOBKDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4926340", Offset = "0x4924B40", VA = "0x184926340")]
	public void EECOHDAADOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4927E70", Offset = "0x4926670", VA = "0x184927E70")]
	public bool NEPNAAPJJEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4926480", Offset = "0x4924C80", VA = "0x184926480")]
	public bool EEJDBMMNBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4925EA0", Offset = "0x49246A0", VA = "0x184925EA0")]
	public void BEPCGKMAIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4927F90", Offset = "0x4926790", VA = "0x184927F90")]
	public bool NHCGMAFIGGK(ref int BPCIMPGFHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4927420", Offset = "0x4925C20", VA = "0x184927420")]
	public bool KPCKEIBGIMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4928080", Offset = "0x4926880", VA = "0x184928080")]
	public void NKBIMJFIOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4926210", Offset = "0x4924A10", VA = "0x184926210")]
	public bool DAEBKIJNMJC(ref int BPCIMPGFHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4928350", Offset = "0x4926B50", VA = "0x184928350")]
	public bool PBHLAECNMFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4926DA0", Offset = "0x49255A0", VA = "0x184926DA0")]
	public void IPKNKJECMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49283C0", Offset = "0x4926BC0", VA = "0x1849283C0")]
	public bool PKCFILIKOPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4926E80", Offset = "0x4925680", VA = "0x184926E80")]
	public void KIAABGCCMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4927680", Offset = "0x4925E80", VA = "0x184927680")]
	private void MEAEPMAEIMH(out byte[] LEJDAPCAGJJ, out int IBPIBMILGEP, out int DAKJJJLOICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4925DF0", Offset = "0x49245F0", VA = "0x184925DF0")]
	private static int ANGPIJECCEL(char LNIJHEMDGEF, char LANKPNEAHJA, char DGNGOIEGJNG, char DPBGGLEPNBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4928200", Offset = "0x4926A00", VA = "0x184928200")]
	private static int OHAHMGIFLBI(char ODDCIAGBNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4926CB0", Offset = "0x49254B0", VA = "0x184926CB0")]
	public ArraySegment<byte> HFCGGJOMIAG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x49262A0", Offset = "0x4924AA0", VA = "0x1849262A0")]
	public string EAMMFBONMLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4927640", Offset = "0x4925E40", VA = "0x184927640")]
	public string LLCIIDBLNKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4926740", Offset = "0x4924F40", VA = "0x184926740")]
	public ArraySegment<byte> FDPPPLGKLNM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4926E40", Offset = "0x4925640", VA = "0x184926E40")]
	public ArraySegment<byte> JOGCHADMLJK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4925B90", Offset = "0x4924390", VA = "0x184925B90")]
	public bool AEEEPJNHOLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4926150", Offset = "0x4924950", VA = "0x184926150")]
	private static bool COMLGBOMIBH(byte DGNGOIEGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4926950", Offset = "0x4925150", VA = "0x184926950")]
	private void HDKHLCOCEDF(JKLBJIOBKDH JJGMEBEPKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4927670", Offset = "0x4925E70", VA = "0x184927670")]
	public void LMFBDOPMOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49264F0", Offset = "0x4924CF0", VA = "0x1849264F0")]
	private void EPIAJFAFKOH(int CKMGIACOGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4925F40", Offset = "0x4924740", VA = "0x184925F40")]
	public sbyte BFEACIKNEBK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4927E10", Offset = "0x4926610", VA = "0x184927E10")]
	public short MILCHEHMNFB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x49268F0", Offset = "0x49250F0", VA = "0x1849268F0")]
	public int FOFOJENFIGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4928120", Offset = "0x4926920", VA = "0x184928120")]
	public long NPLGBCBIHBH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4928020", Offset = "0x4926820", VA = "0x184928020")]
	public byte NICDPAIFMCG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x49273C0", Offset = "0x4925BC0", VA = "0x1849273C0")]
	public ushort KKLKKDJNENO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49281A0", Offset = "0x49269A0", VA = "0x1849281A0")]
	public uint ODIHPKEOICN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49282D0", Offset = "0x4926AD0", VA = "0x1849282D0")]
	public ulong OLOKPIMEMMF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4927580", Offset = "0x4925D80", VA = "0x184927580")]
	public float LHNPBPNOIJN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4926070", Offset = "0x4924870", VA = "0x184926070")]
	public double CBFBHAEEAHK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4927490", Offset = "0x4925C90", VA = "0x184927490")]
	public ArraySegment<byte> KPNCILKHIIO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49265C0", Offset = "0x4924DC0", VA = "0x1849265C0")]
	private static int FCBCGDHMFFA(byte[] OCICGABDCEM, int BIJBEGOMFPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IAKDGNKPJCM : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference EDAOPPLOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int DIGKEMGKALJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MLAPAPIBNHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xFF2EA0", Offset = "0xFF16A0", VA = "0x180FF2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FHIHILFFHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x66E350", Offset = "0x66CB50", VA = "0x18066E350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xFF2EB0", Offset = "0xFF16B0", VA = "0x180FF2EB0")]
	public IAKDGNKPJCM(string MGAAKCJLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xFF2F20", Offset = "0xFF1720", VA = "0x180FF2F20")]
	public IAKDGNKPJCM(string MGAAKCJLEOH, byte[] JIJGKLIABHI, int BIJBEGOMFPC, int DIGKEMGKALJ, string ODNNLHACDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BECLJDMHLEN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PFCFAAMGPJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void BGPEEPHDNDE(ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object OODDELIHOBC(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI BPMIAJOHFFA);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class FFBFKJDPGDD
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class DOOJBGGPHLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public DOOJBGGPHLG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x1A402E0", Offset = "0x1A3EAE0", VA = "0x181A402E0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3630A70", Offset = "0x362F270", VA = "0x183630A70")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, CNPMPMJABJI, byte[]> DJFJEPPEFOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, CNPMPMJABJI> BFJAMCGKMJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly BGPEEPHDNDE GGLDDFKMAHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, CNPMPMJABJI, ArraySegment<byte>> MCBBIEBEPFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, CNPMPMJABJI, string> COENPMNHEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, CNPMPMJABJI, object> LAJCNMPOCOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, CNPMPMJABJI, object> DOOIKLKLHJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, CNPMPMJABJI, object> IOMEBGDGPOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly OODDELIHOBC HEKBEPDAOCD;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3630E60", Offset = "0x362F660", VA = "0x183630E60")]
			public FFBFKJDPGDD(Type BJNLFFPNEBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B79DF0", Offset = "0x2B785F0", VA = "0x182B79DF0")]
			private static T ENOFMMMPICO<T>(DynamicMethod FBDHIIENKPE)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3630C70", Offset = "0x362F470", VA = "0x183630C70")]
			private static MethodInfo IIOHMMNODKL(Type BJNLFFPNEBC, string CEAFHMOKOGD, Type[] EACPODLMPGB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, FFBFKJDPGDD> MAOALKKADCI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::ICIFHOLFHBK<FFBFKJDPGDD> EDGCIFLCNIA;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3636160", Offset = "0x3634960", VA = "0x183636160")]
		static PFCFAAMGPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x36360E0", Offset = "0x36348E0", VA = "0x1836360E0")]
		private static FFBFKJDPGDD KMGMOMFIAIH(Type BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3635E60", Offset = "0x3634660", VA = "0x183635E60")]
		public static void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3635FD0", Offset = "0x36347D0", VA = "0x183635FD0")]
		public static void IPEJBGOIGOE(Type BJNLFFPNEBC, ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class PMDICJIOJCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] KIJIMACKNGN;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3637E00", Offset = "0x3636600", VA = "0x183637E00")]
		public static byte[] AANBMFLHOOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CNPMPMJABJI KHEFOCFAIEA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] JJKJOFNGOKD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] KGGDIGBJBJD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CNPMPMJABJI OBILLCONKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3627DF0", Offset = "0x36265F0", VA = "0x183627DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3176600", Offset = "0x3174E00", VA = "0x183176600")]
	public static string CKCJCDGHJAH<T>(T HNCFAALBJCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3176680", Offset = "0x3174E80", VA = "0x183176680")]
	public static string CKCJCDGHJAH<T>(T HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B751E0", Offset = "0x2B739E0", VA = "0x182B751E0")]
	public static T IEIPGDINOPI<T>(string FEGDFNIMIGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B75110", Offset = "0x2B73910", VA = "0x182B75110")]
	public static T IEIPGDINOPI<T>(string FEGDFNIMIGO, CNPMPMJABJI BPMIAJOHFFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B753B0", Offset = "0x2B73BB0", VA = "0x182B753B0")]
	public static T IEIPGDINOPI<T>(byte[] OCICGABDCEM, CNPMPMJABJI BPMIAJOHFFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B75260", Offset = "0x2B73A60", VA = "0x182B75260")]
	public static T IEIPGDINOPI<T>(byte[] OCICGABDCEM, int BIJBEGOMFPC, CNPMPMJABJI BPMIAJOHFFA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JKLBJIOBKDH : byte
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
public struct DPPLJIMOHKF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FDDOPGOHJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] KIJIMACKNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BIJBEGOMFPC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NPBKCOICICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A9E90", Offset = "0x7A8690", VA = "0x1807A9E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xFE5230", Offset = "0xFE3A30", VA = "0x180FE5230")]
	public void PGAHPFODADP(int BIJBEGOMFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xFE4D60", Offset = "0xFE3560", VA = "0x180FE4D60")]
	public static byte[] NGICOMEDAOO(string DAKHDGGOCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xFE5240", Offset = "0xFE3A40", VA = "0x180FE5240")]
	public static byte[] PIILIIJACGK(string DAKHDGGOCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xFE48F0", Offset = "0xFE30F0", VA = "0x180FE48F0")]
	public static byte[] IHBKFOPGNCH(string DAKHDGGOCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xFE41F0", Offset = "0xFE29F0", VA = "0x180FE41F0")]
	public static byte[] AHBLMAIODOH(string DAKHDGGOCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xFE5420", Offset = "0xFE3C20", VA = "0x180FE5420")]
	public DPPLJIMOHKF(byte[] BMMBIMFJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xFE3FB0", Offset = "0xFE27B0", VA = "0x180FE3FB0")]
	public ArraySegment<byte> AANBMFLHOOD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xFE4A50", Offset = "0xFE3250", VA = "0x180FE4A50")]
	public byte[] KBKHNIDKIMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xFE5370", Offset = "0xFE3B70", VA = "0x180FE5370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xFE48B0", Offset = "0xFE30B0", VA = "0x180FE48B0")]
	public void EOAJOHPEAEG(int NLJNEPKNCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xFE47C0", Offset = "0xFE2FC0", VA = "0x180FE47C0")]
	public void ECBGGNLFHJA(byte[] DACOMKJCGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xFE4C50", Offset = "0xFE3450", VA = "0x180FE4C50")]
	public void MHCEEALNBOE(byte DACOMKJCGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xFE4770", Offset = "0xFE2F70", VA = "0x180FE4770")]
	public void CKPKBGBCBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xFE51E0", Offset = "0xFE39E0", VA = "0x180FE51E0")]
	public void PBKIOGJCPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xFE4D10", Offset = "0xFE3510", VA = "0x180FE4D10")]
	public void MNLKMKGGKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xFE5060", Offset = "0xFE3860", VA = "0x180FE5060")]
	public void OEOAHLBPKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xFE4060", Offset = "0xFE2860", VA = "0x180FE4060")]
	public void ABCEGIDENAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xFE4C90", Offset = "0xFE3490", VA = "0x180FE4C90")]
	public void MIMGNBOOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xFE4850", Offset = "0xFE3050", VA = "0x180FE4850")]
	public void EHCDPJOEMPK(string DAKHDGGOCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xFE4350", Offset = "0xFE2B50", VA = "0x180FE4350")]
	public void CGGJJNPCJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xFE50E0", Offset = "0xFE38E0", VA = "0x180FE50E0")]
	public void OLAJJPLCIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xFE4E70", Offset = "0xFE3670", VA = "0x180FE4E70")]
	public void OAFGABNHOBF(bool HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xFE4AD0", Offset = "0xFE32D0", VA = "0x180FE4AD0")]
	public void KKLKAJKHGAJ(float HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xFE40B0", Offset = "0xFE28B0", VA = "0x180FE40B0")]
	public void ADIFEKLECDK(double HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xFE51B0", Offset = "0xFE39B0", VA = "0x180FE51B0")]
	public void OMEENFFOKAO(byte HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xFE4A20", Offset = "0xFE3220", VA = "0x180FE4A20")]
	public void JJMGJOLACCN(ushort HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xFE48C0", Offset = "0xFE30C0", VA = "0x180FE48C0")]
	public void HCMAJADGCHG(uint HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xFE4820", Offset = "0xFE3020", VA = "0x180FE4820")]
	public void EFBEIKDAFJD(ulong HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xFE4E40", Offset = "0xFE3640", VA = "0x180FE4E40")]
	public void NNMIPNMNGFK(sbyte HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xFE4CE0", Offset = "0xFE34E0", VA = "0x180FE4CE0")]
	public void MMGGENAMJBA(short HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xFE50B0", Offset = "0xFE38B0", VA = "0x180FE50B0")]
	public void OFHEEBHHHAC(int HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xFE4C20", Offset = "0xFE3420", VA = "0x180FE4C20")]
	public void LHHGHCNAAGJ(long HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xFE43A0", Offset = "0xFE2BA0", VA = "0x180FE43A0")]
	public void CKABPJMPHKK(string HNCFAALBJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BCNFNMCIJME : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class DAOIMHCCHNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x449D870", Offset = "0x449C070", VA = "0x18449D870")]
		static DAOIMHCCHNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private BCNFNMCIJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class DOBJNPGEOHM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> AOCDDKAKHLO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xFE3B10", Offset = "0xFE2310", VA = "0x180FE3B10")]
	static DOBJNPGEOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xFE35B0", Offset = "0xFE1DB0", VA = "0x180FE35B0")]
	internal static object PHIGFGFIPLB(Type NIDNHHLCCNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GPICHCIDKDL : global::CCBAHIKANPJ<Vector2>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xFF1890", Offset = "0xFF0090", VA = "0x180FF1890")]
	public GPICHCIDKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xFF1720", Offset = "0xFEFF20", VA = "0x180FF1720", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Vector2 HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xFF15A0", Offset = "0xFEFDA0", VA = "0x180FF15A0", Slot = "5")]
	public Vector2 IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DAACHMAHNKK : global::CCBAHIKANPJ<Vector3>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xFE14B0", Offset = "0xFDFCB0", VA = "0x180FE14B0")]
	public DAACHMAHNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xFE12A0", Offset = "0xFDFAA0", VA = "0x180FE12A0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Vector3 HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF8B0", VA = "0x180FE10B0", Slot = "5")]
	public Vector3 IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AHAHALJLHIE : global::CCBAHIKANPJ<Vector4>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3621120", Offset = "0x361F920", VA = "0x183621120")]
	public AHAHALJLHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3620FD0", Offset = "0x361F7D0", VA = "0x183620FD0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Vector4 HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3620D40", Offset = "0x361F540", VA = "0x183620D40", Slot = "5")]
	public Vector4 IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PCPBGOGOEAO : global::CCBAHIKANPJ<Quaternion>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x492F6C0", Offset = "0x492DEC0", VA = "0x18492F6C0")]
	public PCPBGOGOEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3620FD0", Offset = "0x361F7D0", VA = "0x183620FD0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Quaternion HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x492F380", Offset = "0x492DB80", VA = "0x18492F380", Slot = "5")]
	public Quaternion IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MFFDJFHNJCL : global::CCBAHIKANPJ<Color>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x492A150", Offset = "0x4928950", VA = "0x18492A150")]
	public MFFDJFHNJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3620FD0", Offset = "0x361F7D0", VA = "0x183620FD0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Color HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4929E10", Offset = "0x4928610", VA = "0x184929E10", Slot = "5")]
	public Color IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class FHOMFNBMDLN : global::CCBAHIKANPJ<Bounds>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xFEC820", Offset = "0xFEB020", VA = "0x180FEC820")]
	public FHOMFNBMDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xFEC520", Offset = "0xFEAD20", VA = "0x180FEC520", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Bounds HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xFEC280", Offset = "0xFEAA80", VA = "0x180FEC280", Slot = "5")]
	public Bounds IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CGPLNEPFKFB : global::CCBAHIKANPJ<Rect>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BDOGDIMNEGN DEKJDEDKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] PEPNLKOGHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xFE04B0", Offset = "0xFDECB0", VA = "0x180FE04B0")]
	public CGPLNEPFKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xFE0220", Offset = "0xFDEA20", VA = "0x180FE0220", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Rect HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xFDFFC0", Offset = "0xFDE7C0", VA = "0x180FDFFC0", Slot = "5")]
	public Rect IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class CCPJFIHNFNG : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class KCJPFNFHBIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D107E0", Offset = "0x3D0EFE0", VA = "0x183D107E0")]
		static KCJPFNFHBIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private CCPJFIHNFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class AHGEGPHMPGE : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class EPKMPBPLDED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B40", Offset = "0x2B24340", VA = "0x182B25B40")]
		static EPKMPBPLDED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class IHBDPFGEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> HGKJIKKOJNO;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3634110", Offset = "0x3632910", VA = "0x183634110")]
		internal static object PHIGFGFIPLB(Type NIDNHHLCCNA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private AHGEGPHMPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GGFLDPIFCLO : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class AGJEHEMFFCI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3591630", Offset = "0x358FE30", VA = "0x183591630")]
		static AGJEHEMFFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private GGFLDPIFCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GEGFPGKCJDA
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly CNPMPMJABJI OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly CNPMPMJABJI HJJCBHDHAIA;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly CNPMPMJABJI GHLKFFBBHIC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CNPMPMJABJI GPELOIBHDAC;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly CNPMPMJABJI DKFPPMNOIFH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly CNPMPMJABJI BJPJKCFAFCH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CNPMPMJABJI AACFHIGMMFL;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CNPMPMJABJI LGGNFFGMBKE;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly CNPMPMJABJI KHJKILMKBNF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly CNPMPMJABJI OMNDNPIKIDB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CNPMPMJABJI IBCOKGIDDEO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly CNPMPMJABJI GHECIFBIEBE;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MDPFECMOMJC
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly CNPMPMJABJI OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly CNPMPMJABJI GBIPPJFKBNC;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JPCOEOKBMBI
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CNPMPMJABJI OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly CNPMPMJABJI HJJCBHDHAIA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CNPMPMJABJI GHLKFFBBHIC;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CNPMPMJABJI GPELOIBHDAC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CNPMPMJABJI DKFPPMNOIFH;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CNPMPMJABJI BJPJKCFAFCH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CNPMPMJABJI AACFHIGMMFL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CNPMPMJABJI LGGNFFGMBKE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CNPMPMJABJI KHJKILMKBNF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CNPMPMJABJI OMNDNPIKIDB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CNPMPMJABJI IBCOKGIDDEO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CNPMPMJABJI GHECIFBIEBE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class NEKHPIABKOL
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly Dictionary<Type, Type> HGKJIKKOJNO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x492C3C0", Offset = "0x492ABC0", VA = "0x18492C3C0")]
	internal static object PHIGFGFIPLB(Type NIDNHHLCCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x492C380", Offset = "0x492AB80", VA = "0x18492C380")]
	private static object MGNLBMNMGMH(Type MMCIPIPAPPM, Type[] KCEJJMBCIFO, params object[] EACPODLMPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BEFLEAHIDGE : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class PEPPHCEFALP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3345AF0", Offset = "0x33442F0", VA = "0x183345AF0")]
		static PEPPHCEFALP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3628030", Offset = "0x3626830", VA = "0x183628030")]
	static BEFLEAHIDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private BEFLEAHIDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EEEDKDPIIML : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class FHCBCPCEHCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3239820", Offset = "0x3238020", VA = "0x183239820")]
		static FHCBCPCEHCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE74F0", Offset = "0xFE5CF0", VA = "0x180FE74F0")]
	static EEEDKDPIIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private EEEDKDPIIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class INMJJMIHBGI : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class BKFBFJMCFJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x306DDB0", Offset = "0x306C5B0", VA = "0x18306DDB0")]
		static BKFBFJMCFJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0xFF45F0", Offset = "0xFF2DF0", VA = "0x180FF45F0")]
	static INMJJMIHBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private INMJJMIHBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class GLPJLACMFMG : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PILHKJBFACI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9620", Offset = "0x2BE7E20", VA = "0x182BE9620")]
		static PILHKJBFACI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xFF14B0", Offset = "0xFEFCB0", VA = "0x180FF14B0")]
	static GLPJLACMFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private GLPJLACMFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ANNHDLGMGNH : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class PDOOMHCDOIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x364E960", Offset = "0x364D160", VA = "0x18364E960")]
		static PDOOMHCDOIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x36224A0", Offset = "0x3620CA0", VA = "0x1836224A0")]
	static ANNHDLGMGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private ANNHDLGMGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class DEEMDBDADCA : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class DOOOAJHELID<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BF48B0", Offset = "0x2BF30B0", VA = "0x182BF48B0")]
		static DOOOAJHELID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly EJJHBINHCAB GMOMMNELOJN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xFE1B80", Offset = "0xFE0380", VA = "0x180FE1B80")]
	static DEEMDBDADCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private DEEMDBDADCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class OFKNELMEEGI : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class KLEIPGLKOFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x439CA30", Offset = "0x439B230", VA = "0x18439CA30")]
		static KLEIPGLKOFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public OFKNELMEEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class JNNFBAKLLIH : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class IHMLGLKAMOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B540C0", Offset = "0x3B528C0", VA = "0x183B540C0")]
		static IHMLGLKAMOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JNNFBAKLLIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class PBLHHBFCAOK : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class CJKKIFGBFKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3577D70", Offset = "0x3576570", VA = "0x183577D70")]
		static CJKKIFGBFKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public PBLHHBFCAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class NEABFCJECMB : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class JEELCJJPBPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x360E6D0", Offset = "0x360CED0", VA = "0x18360E6D0")]
		static JEELCJJPBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public NEABFCJECMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class FNENKEOGKJE : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PHGIGJLEHGE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x35A67F0", Offset = "0x35A4FF0", VA = "0x1835A67F0")]
		static PHGIGJLEHGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public FNENKEOGKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JBKCIJBMHGB : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class COEPJDFJIJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x30716E0", Offset = "0x306FEE0", VA = "0x1830716E0")]
		static COEPJDFJIJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static readonly Func<string, string> HPMKIEIEBEO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly bool PDPEPDMNBLK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JBKCIJBMHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class CDJADHLJMPK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OEMFBCEIOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public HFMPACPJAOH FAAFCIKPCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LocalBuilder IBAGNNGKKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LocalBuilder IKGHNBHMFNA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class PINMHCFFEDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class LNIEMLHLLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo IHBKFOPGNCH;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo PIILIIJACGK;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo AHBLMAIODOH;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo NGICOMEDAOO;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly MethodInfo OLAJJPLCIDE;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo ECBGGNLFHJA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo MNLKMKGGKFI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OEOAHLBPKGM;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo ABCEGIDENAA;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xFF6CC0", Offset = "0xFF54C0", VA = "0x180FF6CC0")]
			static LNIEMLHLLKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class GAMKPOPKAFL
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo NEPNAAPJJEC;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo NKBIMJFIOCF;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DAEBKIJNMJC;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo IAABDMKNBAB;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo LMFBDOPMOON;

			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo FDFMHMOIOHM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo OLGJGLBFMLG;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xFEF750", Offset = "0xFEDF50", VA = "0x180FEF750")]
			static GAMKPOPKAFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PPLEBDBODMM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			internal static readonly MethodInfo LHPEEDADFFP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			internal static readonly MethodInfo PNINNEKILJF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly ConstructorInfo DKHLLDINBOB;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly MethodInfo GCIBJHBBCKH;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly ConstructorInfo ENGIIMPPEOE;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly MethodInfo HJAKBJEJDGN;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly MethodInfo IFABHBHKCNH;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly MethodInfo IHBHAHBIGLE;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ECHNDCHJAEB;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly MethodInfo EKGEEDKJIIM;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo OJHIMDAHHHC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo NGPNAFFKAHP;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo LJAEOLGLOPN;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo BKGMBANHLLN;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x36365A0", Offset = "0x3634DA0", VA = "0x1836365A0")]
		public static MethodInfo IPEJBGOIGOE(Type BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3636250", Offset = "0x3634A50", VA = "0x183636250")]
		public static MethodInfo IEIPGDINOPI(Type BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3636480", Offset = "0x3634C80", VA = "0x183636480")]
		public static MethodInfo IMBLDLBABDN(Type BJNLFFPNEBC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CGKKOCPPNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Dictionary<HFMPACPJAOH, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public CGKKOCPPNOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class KOCDFGNFGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CGKKOCPPNOO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public KOCDFGNFGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3635A00", Offset = "0x3634200", VA = "0x183635A00")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3635A40", Offset = "0x3634240", VA = "0x183635A40")]
		internal bool <BuildType>b__2(int index, HFMPACPJAOH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DLGCDHMLOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CGKKOCPPNOO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public DLGCDHMLOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x36309D0", Offset = "0x362F1D0", VA = "0x1836309D0")]
		internal bool <BuildType>b__3(int index, HFMPACPJAOH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GEDINBOFFML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public GEDINBOFFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x36329F0", Offset = "0x36311F0", VA = "0x1836329F0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class CBIADODEENM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public CBIADODEENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3628730", Offset = "0x3626F30", VA = "0x183628730")]
		internal bool <BuildAnonymousFormatter>b__2(HFMPACPJAOH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AINBJANFFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public GEDINBOFFML CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public AINBJANFFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x36214A0", Offset = "0x361FCA0", VA = "0x1836214A0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x36214B0", Offset = "0x361FCB0", VA = "0x1836214B0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, HFMPACPJAOH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ALDIFFEDAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public GEDINBOFFML CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public ALDIFFEDAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3621FB0", Offset = "0x36207B0", VA = "0x183621FB0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, HFMPACPJAOH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NEADAOBBBDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public NEADAOBBBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x537660", Offset = "0x535E60", VA = "0x180537660")]
		internal Label <BuildSerialize>b__1(HFMPACPJAOH _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JHKGGHGOCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OEMFBCEIOJO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Func<int, HFMPACPJAOH, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public KAFDHAEAPJC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public KAFDHAEAPJC argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public JHKGGHGOCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x36358D0", Offset = "0x36340D0", VA = "0x1836358D0")]
		internal OEMFBCEIOJO <BuildDeserialize>b__0(HFMPACPJAOH item)
		{
			return default(OEMFBCEIOJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class IAKIPOFBHBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public JHKGGHGOCHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public IAKIPOFBHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3633DC0", Offset = "0x36325C0", VA = "0x183633DC0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3634070", Offset = "0x3632870", VA = "0x183634070")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class KHGGEPKJHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public HFMPACPJAOH item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public KHGGEPKJHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x27E86E0", Offset = "0x27E6EE0", VA = "0x1827E86E0")]
		internal bool <EmitNewObject>b__0(OEMFBCEIOJO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GDLDNKMKFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HFMPACPJAOH item;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public GDLDNKMKFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x27E86E0", Offset = "0x27E6EE0", VA = "0x1827E86E0")]
		internal bool <EmitNewObject>b__2(OEMFBCEIOJO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly Regex DICMDJOEPAG;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int FGNNCOBNMDD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static HashSet<Type> FHHFGJLNCCG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static HashSet<Type> CCGDCFOPLAM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x36C34D0", Offset = "0x36C1CD0", VA = "0x1836C34D0")]
	public static object DPJGGEGEOEO<T>(EJJHBINHCAB GMOMMNELOJN, CNPMPMJABJI GEBDFNKLPIK, Func<string, string> HPMKIEIEBEO, bool PDPEPDMNBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x36CF0F0", Offset = "0x36CD8F0", VA = "0x1836CF0F0")]
	public static object FMFHIKPCEOL<T>(CNPMPMJABJI GEBDFNKLPIK, Func<string, string> HPMKIEIEBEO, bool PDPEPDMNBLK, bool AKGEBEDNNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x362AEF0", Offset = "0x36296F0", VA = "0x18362AEF0")]
	private static TypeInfo FEAJNMIJJGH(EJJHBINHCAB GMOMMNELOJN, Type BJNLFFPNEBC, Func<string, string> HPMKIEIEBEO, bool PDPEPDMNBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x36295B0", Offset = "0x3627DB0", VA = "0x1836295B0")]
	public static object BFIJDKPLIKM(Type BJNLFFPNEBC, Func<string, string> HPMKIEIEBEO, bool PDPEPDMNBLK, bool AKGEBEDNNDK, bool PCBIDGLMIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x362EBC0", Offset = "0x362D3C0", VA = "0x18362EBC0")]
	private static Dictionary<HFMPACPJAOH, FieldInfo> ODMJOBFJKFH(TypeBuilder FPIKCFGLDAF, LKCGMIBBDBP MODDMIDMILD, ConstructorInfo KGMFNKHHAAJ, FieldBuilder AKBMPDHDLJA, ILGenerator BLEEHJDPFMP, bool PDPEPDMNBLK, bool MCGEABHJBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x362CF00", Offset = "0x362B700", VA = "0x18362CF00")]
	private static Dictionary<HFMPACPJAOH, FieldInfo> GNAPKOCPLII(TypeBuilder FPIKCFGLDAF, LKCGMIBBDBP MODDMIDMILD, ILGenerator BLEEHJDPFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x362D660", Offset = "0x362BE60", VA = "0x18362D660")]
	private static void NKBJGNGLJCG(Type BJNLFFPNEBC, LKCGMIBBDBP MODDMIDMILD, ILGenerator BLEEHJDPFMP, Action MLELFNLHPCN, Func<int, HFMPACPJAOH, bool> CFOAAFLGDPI, bool PDPEPDMNBLK, bool MCGEABHJBBG, int IBPDBKBBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x362B990", Offset = "0x362A190", VA = "0x18362B990")]
	private static void FJEHDBMAPBD(TypeInfo BJNLFFPNEBC, HFMPACPJAOH ACGCFAHMCHI, ILGenerator BLEEHJDPFMP, int INFKIDFCOKN, Func<int, HFMPACPJAOH, bool> CFOAAFLGDPI, KAFDHAEAPJC PMAIAIDMOEI, KAFDHAEAPJC PBFHFAFBPBC, KAFDHAEAPJC HEPPHCCFDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x362F210", Offset = "0x362DA10", VA = "0x18362F210")]
	private static void OGDDMDLIFJM(Type BJNLFFPNEBC, LKCGMIBBDBP MODDMIDMILD, ILGenerator BLEEHJDPFMP, Func<int, HFMPACPJAOH, bool> CFOAAFLGDPI, bool DFMGPJIKEBK, int IBPDBKBBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x362BE80", Offset = "0x362A680", VA = "0x18362BE80")]
	private static void GGOGPBHLMMM(ILGenerator BLEEHJDPFMP, OEMFBCEIOJO MODDMIDMILD, int INFKIDFCOKN, Func<int, HFMPACPJAOH, bool> CFOAAFLGDPI, KAFDHAEAPJC APKEPEIJPBH, KAFDHAEAPJC HEPPHCCFDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x362C290", Offset = "0x362AA90", VA = "0x18362C290")]
	private static LocalBuilder GJPJAEBFKMN(ILGenerator BLEEHJDPFMP, Type BJNLFFPNEBC, LKCGMIBBDBP MODDMIDMILD, OEMFBCEIOJO[] OENMPGFFLOA, bool OGHPINGFMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3628EE0", Offset = "0x36276E0", VA = "0x183628EE0")]
	private static bool AOAFAHKOPED(ConstructorInfo OFHLNLIOFJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x362D4C0", Offset = "0x362BCC0", VA = "0x18362D4C0")]
	private static bool JBHPCLMJBHK(Type BJNLFFPNEBC, out Type NHCNKPAPLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate void NHMHFKIGOIB<T>(byte[][] AKBMPDHDLJA, object[] LNGBDOEKGCN, ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI BPMIAJOHFFA);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal delegate T ACAIJGNCLJE<T>(object[] LNGBDOEKGCN, ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI BPMIAJOHFFA);
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class BEDFMDFOCAH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class BNEBMEGBBFK : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class NJGBPJEAOKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3344A20", Offset = "0x3343220", VA = "0x183344A20")]
		static NJGBPJEAOKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private BNEBMEGBBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class CCLACAIAHMB : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class CKJFJLOPPKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3D05B80", Offset = "0x3D04380", VA = "0x183D05B80")]
		static CKJFJLOPPKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private CCLACAIAHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class IBLALDNDKJN
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal static readonly CNPMPMJABJI[] MINMBPJHLPE;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class JHAOHIAGPOC : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private static class KDGMKIFIPGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x354B350", Offset = "0x3549B50", VA = "0x18354B350")]
		static KDGMKIFIPGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class COILCPMKHIC : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private static class PBINJKFMEHG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x354FE90", Offset = "0x354E690", VA = "0x18354FE90")]
			static PBINJKFMEHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private COILCPMKHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private JHAOHIAGPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class OLKGLEEOOHK : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private static class CBFOENCGKHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x34EDB00", Offset = "0x34EC300", VA = "0x1834EDB00")]
		static CBFOENCGKHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class NBGAOLNKEOJ : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private static class NEPHIFDIANL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x34FBEF0", Offset = "0x34FA6F0", VA = "0x1834FBEF0")]
			static NEPHIFDIANL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private NBGAOLNKEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private OLKGLEEOOHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal sealed class OMGAKNEMJJH : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private static class NDFOFHPCIFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x34F8960", Offset = "0x34F7160", VA = "0x1834F8960")]
		static NDFOFHPCIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class NAFOJAGLEAH : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private static class NDELCLAGPKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x34F1A00", Offset = "0x34F0200", VA = "0x1834F1A00")]
			static NDELCLAGPKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private NAFOJAGLEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private OMGAKNEMJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class NPOJIMDFJCF : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private static class JNNINNNGGMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x39A9630", Offset = "0x39A7E30", VA = "0x1839A9630")]
		static JNNINNNGGMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class IBGCGHNDGAN : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		private static class LILFDPJDINK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39AAAF0", Offset = "0x39A92F0", VA = "0x1839AAAF0")]
			static LILFDPJDINK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private IBGCGHNDGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private NPOJIMDFJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class CDMJLIPPEMP : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private static class BIBFKDONPEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3CFF5E0", Offset = "0x3CFDDE0", VA = "0x183CFF5E0")]
		static BIBFKDONPEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class KKEGICKCEPN : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private static class BBNICHFGAKO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA350", Offset = "0x3CF8B50", VA = "0x183CFA350")]
			static BBNICHFGAKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private KKEGICKCEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private CDMJLIPPEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class EIOLPPNMGCC : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private static class LDNFIOILDHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3B9E790", Offset = "0x3B9CF90", VA = "0x183B9E790")]
		static LDNFIOILDHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private sealed class JAGGIBOINPJ : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private static class FFNJBBDKICG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3B99F60", Offset = "0x3B98760", VA = "0x183B99F60")]
			static FFNJBBDKICG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private JAGGIBOINPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private EIOLPPNMGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class KIILAJPJACE : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private static class EJNBPNCLJKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDA10", Offset = "0x3ACC210", VA = "0x183ACDA10")]
		static EJNBPNCLJKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class PEMCBMJFLIK : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		private static class FEAMBILMALP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3ACF870", Offset = "0x3ACE070", VA = "0x183ACF870")]
			static FEAMBILMALP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private PEMCBMJFLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private KIILAJPJACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal sealed class FIOIAPGDMOD : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private static class JCKLFEJNBOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x359F870", Offset = "0x359E070", VA = "0x18359F870")]
		static JCKLFEJNBOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private sealed class PKAOOPCPNFK : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private static class KOGLLDNCOGC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x35A08C0", Offset = "0x359F0C0", VA = "0x1835A08C0")]
			static KOGLLDNCOGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private PKAOOPCPNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private FIOIAPGDMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal sealed class AOJPEHJKFOO : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private static class AGKLNMFJHLE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4171290", Offset = "0x416FA90", VA = "0x184171290")]
		static AGKLNMFJHLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private sealed class PJHBAEOKMIM : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private static class IKPKJAHIPMH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4190970", Offset = "0x418F170", VA = "0x184190970")]
			static IKPKJAHIPMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private PJHBAEOKMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private AOJPEHJKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal sealed class KLJKGCOBMBK : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private static class JGNLLPCODBC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5B50", Offset = "0x3AD4350", VA = "0x183AD5B50")]
		static JGNLLPCODBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private sealed class JPPKGDDNHML : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		private static class DFJIDBCJBDC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3AC8800", Offset = "0x3AC7000", VA = "0x183AC8800")]
			static DFJIDBCJBDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private JPPKGDDNHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private KLJKGCOBMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal sealed class DJLAPMMMCNH : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private static class PMEOJHBJBFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39D8800", Offset = "0x39D7000", VA = "0x1839D8800")]
		static PMEOJHBJBFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class NNINNOGLBIB : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private static class OEOJAEKFIKG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x39D4D80", Offset = "0x39D3580", VA = "0x1839D4D80")]
			static OEOJAEKFIKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private NNINNOGLBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private DJLAPMMMCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal sealed class DAJCHLPPMMC : CNPMPMJABJI
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private static class HBBGIFHLCGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF950", Offset = "0x2BFE150", VA = "0x182BFF950")]
		static HBBGIFHLCGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class AEAAEEDMAJD : CNPMPMJABJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private static class FAEAIGJNJPF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly global::CCBAHIKANPJ<T> GALLOAPAJBK;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7260", Offset = "0x2BF5A60", VA = "0x182BF7260")]
			static FAEAIGJNJPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly CNPMPMJABJI OONGLDHDBNL;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static readonly CNPMPMJABJI[] DMMEGFAOELN;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		private AEAAEEDMAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
		public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static readonly CNPMPMJABJI OONGLDHDBNL;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly global::CCBAHIKANPJ<object> ANBHJONHKLF;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	private DAJCHLPPMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2AED720", Offset = "0x2AEBF20", VA = "0x182AED720", Slot = "4")]
	public global::CCBAHIKANPJ<T> PHIGFGFIPLB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct JKHJFLKCPBN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public T[] OHMLADLMFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public int BAPHJMOAMDE;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B56BA0", Offset = "0x3B553A0", VA = "0x183B56BA0")]
	public JKHJFLKCPBN(int MLMKEFCKKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B56AC0", Offset = "0x3B552C0", VA = "0x183B56AC0")]
	public void MFDJFDLHFHG(T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B567B0", Offset = "0x3B54FB0", VA = "0x183B567B0")]
	public T[] CEALNEPOJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal sealed class PNIPOJKHNOM : global::FOLOIACPPNC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly PNIPOJKHNOM OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x49300E0", Offset = "0x492E8E0", VA = "0x1849300E0")]
	public PNIPOJKHNOM(int NLFBAJDAOIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class FOLOIACPPNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly int NLFBAJDAOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly object JFKHCLJFBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int INFKIDFCOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T[][] JCOPPFNLGBE;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3597A50", Offset = "0x3596250", VA = "0x183597A50")]
	public FOLOIACPPNC(int NLFBAJDAOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3596790", Offset = "0x3594F90", VA = "0x183596790")]
	public T[] AAGHCKLHNJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3596E50", Offset = "0x3595650", VA = "0x183596E50")]
	public void MELMIGPNLOG(T[] IKFPKGEHMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class BDOGDIMNEGN : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class HPGKDPKIHEL : IComparable<HPGKDPKIHEL>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class BCHFIAOKPJC : IEnumerable<HPGKDPKIHEL>, IEnumerable, IEnumerator<HPGKDPKIHEL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private HPGKDPKIHEL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public HPGKDPKIHEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private HPGKDPKIHEL System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
			[DebuggerHidden]
			public BCHFIAOKPJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x36259C0", Offset = "0x36241C0", VA = "0x1836259C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x3625AF0", Offset = "0x36242F0", VA = "0x183625AF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x3625A50", Offset = "0x3624250", VA = "0x183625A50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HPGKDPKIHEL> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3625A50", Offset = "0x3624250", VA = "0x183625A50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class BFEOKLEPNLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public BFEOKLEPNLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x537660", Offset = "0x535E60", VA = "0x180537660")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x537660", Offset = "0x535E60", VA = "0x180537660")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly HPGKDPKIHEL[] FMDKFCPAHGB;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly ulong[] IJGICNFDJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ulong IICELGCNCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int FPOHGGJHLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public string IIGBKNOHEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private HPGKDPKIHEL[] GAAJFAEDMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ulong[] MNIOFENMHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int BPCIMPGFHBG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IONPPKLMFOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3632D60", Offset = "0x3631560", VA = "0x183632D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3633D00", Offset = "0x3632500", VA = "0x183633D00")]
		public HPGKDPKIHEL(ulong DOMICNELCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3632DF0", Offset = "0x36315F0", VA = "0x183632DF0")]
		public HPGKDPKIHEL MFDJFDLHFHG(ulong DOMICNELCFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3632FE0", Offset = "0x36317E0", VA = "0x183632FE0")]
		public HPGKDPKIHEL MFDJFDLHFHG(ulong DOMICNELCFM, int HNCFAALBJCG, string IIGBKNOHEJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3632BB0", Offset = "0x36313B0", VA = "0x183632BB0")]
		public HPGKDPKIHEL EFGKAFJDAPN(byte[] LLGHPHNDCPD, ref int BIJBEGOMFPC, ref int BOMIAMNPKHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3632D70", Offset = "0x3631570", VA = "0x183632D70")]
		internal static int IBENBPFNBIG(ulong[] IKFPKGEHMKB, int INFKIDFCOKN, int KMPDMGEMCKO, ulong HNCFAALBJCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3632B80", Offset = "0x3631380", VA = "0x183632B80", Slot = "4")]
		public int CompareTo(HPGKDPKIHEL AJEOGBNDGHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3633030", Offset = "0x3631830", VA = "0x183633030")]
		[IteratorStateMachine(typeof(BCHFIAOKPJC))]
		public IEnumerable<HPGKDPKIHEL> MFFNPBDAJGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3632A50", Offset = "0x3631250", VA = "0x183632A50")]
		public void AOGJNGKGOGK(ILGenerator BLEEHJDPFMP, LocalBuilder LLGHPHNDCPD, LocalBuilder BOMIAMNPKHB, LocalBuilder DOMICNELCFM, Action<KeyValuePair<string, int>> KJEMNMLDHJB, Action LJGMIOFIDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36330A0", Offset = "0x36318A0", VA = "0x1836330A0")]
		private static void OOPGDHFDCCE(ILGenerator BLEEHJDPFMP, LocalBuilder LLGHPHNDCPD, LocalBuilder BOMIAMNPKHB, LocalBuilder DOMICNELCFM, Action<KeyValuePair<string, int>> KJEMNMLDHJB, Action LJGMIOFIDCF, HPGKDPKIHEL[] GAAJFAEDMHK, int BPCIMPGFHBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class AKANIFKKDNI : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private IEnumerable<HPGKDPKIHEL> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IEnumerable<HPGKDPKIHEL> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IEnumerator<HPGKDPKIHEL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private HPGKDPKIHEL <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x52F9D0", Offset = "0x52E1D0", VA = "0x18052F9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x3621AC0", Offset = "0x36202C0", VA = "0x183621AC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xD5F340", Offset = "0xD5DB40", VA = "0x180D5F340")]
		[DebuggerHidden]
		public AKANIFKKDNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3621B10", Offset = "0x3620310", VA = "0x183621B10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3621650", Offset = "0x361FE50", VA = "0x183621650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3621C10", Offset = "0x3620410", VA = "0x183621C10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3621C60", Offset = "0x3620460", VA = "0x183621C60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3621A70", Offset = "0x3620270", VA = "0x183621A70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x36219D0", Offset = "0x36201D0", VA = "0x1836219D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x36219D0", Offset = "0x36201D0", VA = "0x1836219D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly HPGKDPKIHEL MIBMGGCCOAE;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3627D80", Offset = "0x3626580", VA = "0x183627D80")]
	public BDOGDIMNEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3627B80", Offset = "0x3626380", VA = "0x183627B80")]
	public void MFDJFDLHFHG(byte[] OCICGABDCEM, int HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3627930", Offset = "0x3626130", VA = "0x183627930")]
	public bool BPKEOAIGAAC(ArraySegment<byte> DOMICNELCFM, out int HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3627C90", Offset = "0x3626490", VA = "0x183627C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x36276B0", Offset = "0x3625EB0", VA = "0x1836276B0")]
	private static void AKHFDHPBCMI(IEnumerable<HPGKDPKIHEL> GAAJFAEDMHK, StringBuilder JHMNLEGMBJN, int PKLAHCEIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3627A80", Offset = "0x3626280", VA = "0x183627A80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3627A80", Offset = "0x3626280", VA = "0x183627A80", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x36279E0", Offset = "0x36261E0", VA = "0x1836279E0")]
	[IteratorStateMachine(typeof(AKANIFKKDNI))]
	private static IEnumerable<KeyValuePair<string, int>> DFPBFNNMODO(IEnumerable<HPGKDPKIHEL> GAAJFAEDMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3627A50", Offset = "0x3626250", VA = "0x183627A50")]
	public void GKKFOINCHMP(ILGenerator BLEEHJDPFMP, LocalBuilder LLGHPHNDCPD, LocalBuilder BOMIAMNPKHB, LocalBuilder DOMICNELCFM, Action<KeyValuePair<string, int>> KJEMNMLDHJB, Action LJGMIOFIDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class AFHEHIDCCNI
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static readonly MethodInfo JPPHMAIHKAN;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x361FCB0", Offset = "0x361E4B0", VA = "0x18361FCB0")]
	public static ulong DNJPNGBLGJH(byte[] OCICGABDCEM, ref int BIJBEGOMFPC, ref int BOMIAMNPKHB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class ALAHNCDKFAJ
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3621CB0", Offset = "0x36204B0", VA = "0x183621CB0")]
	public static void EOAJOHPEAEG(ref byte[] OCICGABDCEM, int BIJBEGOMFPC, int NLJNEPKNCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3621DD0", Offset = "0x36205D0", VA = "0x183621DD0")]
	public static void MKDAIJPLLMD(ref byte[] IKFPKGEHMKB, int EBNGJNDBCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3621EC0", Offset = "0x36206C0", VA = "0x183621EC0")]
	public static byte[] MOPHEEODAGK(byte[] AIKELJAMKAK, int EBNGJNDBCAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class KPJGLNJMBMP
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x49244C0", Offset = "0x4922CC0", VA = "0x1849244C0")]
	public static bool CBONECHNPKB(byte[] HNJEBDDIHKE, int IDDIKFMEGOC, int IKLMCHINCAE, byte[] ECEDDLLEDEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class NCCMNJFDJPK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private struct GCPOJDAOCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public byte[] IICELGCNCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T FPOHGGJHLDI;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x39DAA50", Offset = "0x39D9250", VA = "0x1839DAA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class MNNMPCEIHJO : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public global::NCCMNJFDJPK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private GCPOJDAOCKK[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private GCPOJDAOCKK[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1A90B00", Offset = "0x1A8F300", VA = "0x181A90B00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x39E3270", Offset = "0x39E1A70", VA = "0x1839E3270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x27234C0", Offset = "0x2721CC0", VA = "0x1827234C0")]
		[DebuggerHidden]
		public MNNMPCEIHJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x39E19D0", Offset = "0x39E01D0", VA = "0x1839E19D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x39E30E0", Offset = "0x39E18E0", VA = "0x1839E30E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly GCPOJDAOCKK[][] FGFCHGFJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly ulong AOHIKPNJLOA;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3616970", Offset = "0x3615170", VA = "0x183616970")]
	public NCCMNJFDJPK(int IBEBPLKPLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x36169A0", Offset = "0x36151A0", VA = "0x1836169A0")]
	public NCCMNJFDJPK(int IBEBPLKPLGA, float AMCKLOLHHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x39EB0F0", Offset = "0x39E98F0", VA = "0x1839EB0F0")]
	public void MFDJFDLHFHG(byte[] DOMICNELCFM, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x39EA090", Offset = "0x39E8890", VA = "0x1839EA090")]
	private bool EIJPDDDHDLG(byte[] DOMICNELCFM, T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x39E6340", Offset = "0x39E4B40", VA = "0x1839E6340")]
	public bool BDIOKLAMBCH(ArraySegment<byte> DOMICNELCFM, out T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3615C40", Offset = "0x3614440", VA = "0x183615C40")]
	private static ulong HPHIFPBPFNI(byte[] ODDCIAGBNFM, int BIJBEGOMFPC, int BPCIMPGFHBG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3616940", Offset = "0x3615140", VA = "0x183616940")]
	private static int NOBODKJKGEB(int EMCBINBBKFC, float AMCKLOLHHEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3615B20", Offset = "0x3614320", VA = "0x183615B20", Slot = "4")]
	[IteratorStateMachine(typeof(global::NCCMNJFDJPK<>.MNNMPCEIHJO))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA560", Offset = "0x2BF8D60", VA = "0x182BFA560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class EDJBBJIHOEE : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly OpCode[] OEOJGOOMPDD;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly OpCode[] OKAHBNCJNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int MDNMBIDNPFP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DKMJOLOEHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xFE71D0", Offset = "0xFE59D0", VA = "0x180FE71D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0xFE7220", Offset = "0xFE5A20", VA = "0x180FE7220")]
	static EDJBBJIHOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE7470", Offset = "0xFE5C70", VA = "0x180FE7470")]
	public EDJBBJIHOEE(byte[] KNGAPJAPFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xFE70C0", Offset = "0xFE58C0", VA = "0x180FE70C0")]
	public OpCode EGPEMJFJIDI()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct EADPOPFKNKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly Guid FPOHGGJHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte IHEPIDJAHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte OHOPONBIIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte LKOPCEPPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte KMHOKMJEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte OIDGHDIECLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte PKHEAFNAJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte HPEDOGNHDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte DNDHGACLAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte ICKLEKHHKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte IMJJOBAGOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte KDHOKILNOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte PBMDNHDMOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte CKIGKABEFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte OICOKLPDGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte KGFEMNOGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte HKODPEAGHPN;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static byte[] LJACFPEKMCO;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static byte[] NFGOECIJJKO;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE70B0", Offset = "0xFE58B0", VA = "0x180FE70B0")]
	public EADPOPFKNKK(ref Guid HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xFE6A00", Offset = "0xFE5200", VA = "0x180FE6A00")]
	public EADPOPFKNKK(ref ArraySegment<byte> EEBGEIBEOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xFE5440", Offset = "0xFE3C40", VA = "0x180FE5440")]
	private static byte AOPGKCDKMFC(byte[] OCICGABDCEM, int DPKOGCBKLCA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xFE5500", Offset = "0xFE3D00", VA = "0x180FE5500")]
	private static byte JJLNBNLPILB(byte LANKPNEAHJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xFE5610", Offset = "0xFE3E10", VA = "0x180FE5610")]
	public void MIPNPDFGNIA(byte[] KIJIMACKNGN, int BIJBEGOMFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class BBBIELFDAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x36248F0", Offset = "0x36230F0", VA = "0x1836248F0")]
	public static bool GNCDOFFOINM(byte DGNGOIEGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3623EE0", Offset = "0x36226E0", VA = "0x183623EE0")]
	public static bool APCMHJPFDDB(byte DGNGOIEGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3623F50", Offset = "0x3622750", VA = "0x183623F50")]
	public static sbyte BFEACIKNEBK(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x36256A0", Offset = "0x3623EA0", VA = "0x1836256A0")]
	public static short MILCHEHMNFB(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3624880", Offset = "0x3623080", VA = "0x183624880")]
	public static int FOFOJENFIGA(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3625780", Offset = "0x3623F80", VA = "0x183625780")]
	public static long NPLGBCBIHBH(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3625710", Offset = "0x3623F10", VA = "0x183625710")]
	public static byte NICDPAIFMCG(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3624900", Offset = "0x3623100", VA = "0x183624900")]
	public static ushort KKLKKDJNENO(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3625830", Offset = "0x3624030", VA = "0x183625830")]
	public static uint ODIHPKEOICN(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x36258B0", Offset = "0x36240B0", VA = "0x1836258B0")]
	public static ulong OLOKPIMEMMF(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x36255B0", Offset = "0x3623DB0", VA = "0x1836255B0")]
	public static float LHNPBPNOIJN(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3623FC0", Offset = "0x36227C0", VA = "0x183623FC0")]
	public static double CBFBHAEEAHK(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x36240B0", Offset = "0x36228B0", VA = "0x1836240B0")]
	public static int EFBEIKDAFJD(ref byte[] KIJIMACKNGN, int BIJBEGOMFPC, ulong HNCFAALBJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3624970", Offset = "0x3623170", VA = "0x183624970")]
	public static int LHHGHCNAAGJ(ref byte[] KIJIMACKNGN, int BIJBEGOMFPC, long HNCFAALBJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3623C90", Offset = "0x3622490", VA = "0x183623C90")]
	public static bool AEEEPJNHOLC(byte[] OCICGABDCEM, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class EFFMEKCCCBH
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class CDECGCADEFF : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
		[DebuggerHidden]
		public CDECGCADEFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xFDFAE0", Offset = "0xFDE2E0", VA = "0x180FDFAE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xFDF680", Offset = "0xFDDE80", VA = "0x180FDF680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xFDFC00", Offset = "0xFDE400", VA = "0x180FDFC00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xFDFC50", Offset = "0xFDE450", VA = "0x180FDFC50")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xFDFA90", Offset = "0xFDE290", VA = "0x180FDFA90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xFDF9E0", Offset = "0xFDE1E0", VA = "0x180FDF9E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xFDF9E0", Offset = "0xFDE1E0", VA = "0x180FDF9E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class AINPFHPAHBL : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x78C260", Offset = "0x78AA60", VA = "0x18078C260")]
		[DebuggerHidden]
		public AINPFHPAHBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xFDEF50", Offset = "0xFDD750", VA = "0x180FDEF50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xFDEAF0", Offset = "0xFDD2F0", VA = "0x180FDEAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xFDF070", Offset = "0xFDD870", VA = "0x180FDF070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xFDF0C0", Offset = "0xFDD8C0", VA = "0x180FDF0C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xFDEF00", Offset = "0xFDD700", VA = "0x180FDEF00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xFDEE50", Offset = "0xFDD650", VA = "0x180FDEE50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xFDEE50", Offset = "0xFDD650", VA = "0x180FDEE50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xFE75E0", Offset = "0xFE5DE0", VA = "0x180FE75E0")]
	public static bool CABDMNIENCF(this TypeInfo BJNLFFPNEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xFE7690", Offset = "0xFE5E90", VA = "0x180FE7690")]
	public static bool DDEBHIJNMGJ(this TypeInfo BJNLFFPNEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xFE7910", Offset = "0xFE6110", VA = "0x180FE7910")]
	public static IEnumerable<PropertyInfo> OLGBMPCADKL(this Type BJNLFFPNEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xFE7820", Offset = "0xFE6020", VA = "0x180FE7820")]
	[IteratorStateMachine(typeof(CDECGCADEFF))]
	private static IEnumerable<PropertyInfo> GPPDHHIBKIC(Type BJNLFFPNEBC, HashSet<string> MMDEMPJEBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xFE78B0", Offset = "0xFE60B0", VA = "0x180FE78B0")]
	public static IEnumerable<FieldInfo> JENMKHGCKPB(this Type BJNLFFPNEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xFE7790", Offset = "0xFE5F90", VA = "0x180FE7790")]
	[IteratorStateMachine(typeof(AINPFHPAHBL))]
	private static IEnumerable<FieldInfo> GPKAIJGMKPO(Type BJNLFFPNEBC, HashSet<string> MMDEMPJEBJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class CNAFEDJJCBK
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly Encoding GKGAKFIHBMF;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class HAJONJJGCPF
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCD0", Offset = "0x5CE4D0", VA = "0x1805CFCD0")]
	public static string IHAKMIBHEHG(string MNNJGJLHIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xFF1C30", Offset = "0xFF0430", VA = "0x180FF1C30")]
	public static string MGEFGHFPPOG(string MNNJGJLHIFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0xFF1A60", Offset = "0xFF0260", VA = "0x180FF1A60")]
	public static string DPKJMFKKCLM(string MNNJGJLHIFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class ICIFHOLFHBK<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class CCIMJDJNENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Type IICELGCNCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public TValue FPOHGGJHLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int OCPPJONDPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CCIMJDJNENF EIGEDKFDAIB;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB86D0", Offset = "0x3AB6ED0", VA = "0x183AB86D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8470", Offset = "0x3AB6C70", VA = "0x183AB8470")]
		private int DEPGKLODCFL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public CCIMJDJNENF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class KOALEJKJEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public KOALEJKJEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5BBB90", Offset = "0x5BA390", VA = "0x1805BBB90")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private CCIMJDJNENF[] FGFCHGFJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int GDBDJPILDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly object AIPHEBOADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly float AMCKLOLHHEH;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3AC37D0", Offset = "0x3AC1FD0", VA = "0x183AC37D0")]
	public ICIFHOLFHBK(int IBEBPLKPLGA = 4, float AMCKLOLHHEH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2BD0", Offset = "0x3AC13D0", VA = "0x183AC2BD0")]
	public bool HAKCAENOJKG(Type DOMICNELCFM, TValue HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2B90", Offset = "0x3AC1390", VA = "0x183AC2B90")]
	public bool HAKCAENOJKG(Type DOMICNELCFM, Func<Type, TValue> CDPIJHHADKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2860", Offset = "0x3AC1060", VA = "0x183AC2860")]
	private bool EIJPDDDHDLG(Type DOMICNELCFM, Func<Type, TValue> CDPIJHHADKD, out TValue OFFANLNDHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2E30", Offset = "0x3AC1630", VA = "0x183AC2E30")]
	private bool HIIEOAEKAOD(CCIMJDJNENF[] FGFCHGFJHKO, Type KKFEINMGBDJ, CCIMJDJNENF NAMLHEBMMCC, Func<Type, TValue> CDPIJHHADKD, out TValue OFFANLNDHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3AC22C0", Offset = "0x3AC0AC0", VA = "0x183AC22C0")]
	public bool BDIOKLAMBCH(Type DOMICNELCFM, out TValue HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3590", Offset = "0x3AC1D90", VA = "0x183AC3590")]
	public TValue KMGMOMFIAIH(Type DOMICNELCFM, Func<Type, TValue> CDPIJHHADKD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3616940", Offset = "0x3615140", VA = "0x183616940")]
	private static int NOBODKJKGEB(int EMCBINBBKFC, float AMCKLOLHHEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2B60", Offset = "0x3AC1360", VA = "0x183AC2B60")]
	private static void GGJKLFDOIJL(ref CCIMJDJNENF DMDIPKDELNN, CCIMJDJNENF HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2B60", Offset = "0x3AC1360", VA = "0x183AC2B60")]
	private static void GGJKLFDOIJL(ref CCIMJDJNENF[] DMDIPKDELNN, CCIMJDJNENF[] HNCFAALBJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class EJJHBINHCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly AssemblyBuilder PFGBCPOCIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly ModuleBuilder NHIBMLEOKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly object JFKHCLJFBCD;

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xFE89E0", Offset = "0xFE71E0", VA = "0x180FE89E0")]
	public TypeBuilder PHCPIPKMGPA(string CEAFHMOKOGD, TypeAttributes NBFAIIBBBPA, Type ECKBOFJGCOL, Type[] JDOBFJNPAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xFE8AD0", Offset = "0xFE72D0", VA = "0x180FE8AD0")]
	public EJJHBINHCAB(string EELLJCBMMPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class HLLCCMALGGN
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xFF2670", Offset = "0xFF0E70", VA = "0x180FF2670")]
	private static MethodInfo JCNDHBOLGLP(LambdaExpression OMAABDFGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x3182490", Offset = "0x3180C90", VA = "0x183182490")]
	public static MethodInfo EPLDKLGLEIB<T>(Expression<Func<T>> OMAABDFGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3182490", Offset = "0x3180C90", VA = "0x183182490")]
	public static MethodInfo EPLDKLGLEIB<T, TR>(Expression<Func<T, TR>> OMAABDFGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3182490", Offset = "0x3180C90", VA = "0x183182490")]
	public static MethodInfo EPLDKLGLEIB<T>(Expression<Action<T>> OMAABDFGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3182490", Offset = "0x3180C90", VA = "0x183182490")]
	public static MethodInfo EPLDKLGLEIB<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> OMAABDFGGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x31824A0", Offset = "0x3180CA0", VA = "0x1831824A0")]
	private static MemberInfo LLGFBIKOKLA<T>(Expression<T> KAEJCIIKOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3182430", Offset = "0x3180C30", VA = "0x183182430")]
	public static PropertyInfo DGNPFFAEKAM<T, TR>(Expression<Func<T, TR>> OMAABDFGGDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal struct KAFDHAEAPJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int NKKJIADADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly bool DPHBHJPIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly ILGenerator BLEEHJDPFMP;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xFF6730", Offset = "0xFF4F30", VA = "0x180FF6730")]
	public KAFDHAEAPJC(ILGenerator BLEEHJDPFMP, int NKKJIADADPE, bool DPHBHJPIBFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xFF6770", Offset = "0xFF4F70", VA = "0x180FF6770")]
	public KAFDHAEAPJC(ILGenerator BLEEHJDPFMP, int NKKJIADADPE, Type BJNLFFPNEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xFF6620", Offset = "0xFF4E20", VA = "0x180FF6620")]
	public void HAFGAGDJJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DLPNDENOIAF
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xFE2710", Offset = "0xFE0F10", VA = "0x180FE2710")]
	public static void DBIJCHHNBJE(this ILGenerator BLEEHJDPFMP, int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xFE2940", Offset = "0xFE1140", VA = "0x180FE2940")]
	public static void DBIJCHHNBJE(this ILGenerator BLEEHJDPFMP, LocalBuilder AIJICHMCLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xFE2AF0", Offset = "0xFE12F0", VA = "0x180FE2AF0")]
	public static void HKEJCCOJOKC(this ILGenerator BLEEHJDPFMP, int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFE2AB0", Offset = "0xFE12B0", VA = "0x180FE2AB0")]
	public static void HKEJCCOJOKC(this ILGenerator BLEEHJDPFMP, LocalBuilder AIJICHMCLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xFE2510", Offset = "0xFE0D10", VA = "0x180FE2510")]
	public static void CNBLGEPEHNJ(this ILGenerator BLEEHJDPFMP, int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xFE2600", Offset = "0xFE0E00", VA = "0x180FE2600")]
	public static void CNBLGEPEHNJ(this ILGenerator BLEEHJDPFMP, LocalBuilder AIJICHMCLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xFE2980", Offset = "0xFE1180", VA = "0x180FE2980")]
	public static void DEKBOBFCPEA(this ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xFE2500", Offset = "0xFE0D00", VA = "0x180FE2500")]
	public static void CDKOMHJHFMN(this ILGenerator BLEEHJDPFMP, bool HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xFE2FE0", Offset = "0xFE17E0", VA = "0x180FE2FE0")]
	public static void MPGDKINLOGB(this ILGenerator BLEEHJDPFMP, int HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xFE3430", Offset = "0xFE1C30", VA = "0x180FE3430")]
	public static void NMFFGHJIHNE(this ILGenerator BLEEHJDPFMP, Type BJNLFFPNEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xFE2A10", Offset = "0xFE1210", VA = "0x180FE2A10")]
	public static void GBIIJDGKFMI(this ILGenerator BLEEHJDPFMP, Type BJNLFFPNEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xFE2DB0", Offset = "0xFE15B0", VA = "0x180FE2DB0")]
	public static void MHPFEGOEGDA(this ILGenerator BLEEHJDPFMP, int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xFE2990", Offset = "0xFE1190", VA = "0x180FE2990")]
	public static void ELCBPFJHBND(this ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xFE2410", Offset = "0xFE0C10", VA = "0x180FE2410")]
	public static void AOHBMOGGILK(this ILGenerator BLEEHJDPFMP, int INFKIDFCOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xFE2310", Offset = "0xFE0B10", VA = "0x180FE2310")]
	public static void AFJOGEFFABJ(this ILGenerator BLEEHJDPFMP, MethodInfo LBCKFNFNGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xFE3520", Offset = "0xFE1D20", VA = "0x180FE3520")]
	public static void OOGKJIKIOPB(this ILGenerator BLEEHJDPFMP, FieldInfo KDHLDKMEJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xFE2D20", Offset = "0xFE1520", VA = "0x180FE2D20")]
	public static void HPBPNBFONLB(this ILGenerator BLEEHJDPFMP, ulong HNCFAALBJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class HFMPACPJAOH
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class GFODEDFNHGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public GFODEDFNHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xFF0790", Offset = "0xFEEF90", VA = "0x180FF0790")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private MethodInfo AOGDPGDEAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private MethodInfo OEDLKFKMMFK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PNDBGHBJEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GJHLADOEHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JEKAOKICAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xFF2320", Offset = "0xFF0B20", VA = "0x180FF2320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LCOICFLFMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC0", Offset = "0x52D3C0", VA = "0x18052EBC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C90", Offset = "0x5CF490", VA = "0x1805D0C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OGBMPCJOAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x52EBD0", Offset = "0x52D3D0", VA = "0x18052EBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x942540", Offset = "0x940D40", VA = "0x180942540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type GEKBHHLLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x50B460", Offset = "0x509C60", VA = "0x18050B460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D40", Offset = "0x5E2540", VA = "0x1805E3D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo OIIMFLHFDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo KKBGLOLEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x50B470", Offset = "0x509C70", VA = "0x18050B470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x52F9E0", Offset = "0x52E1E0", VA = "0x18052F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo GLFMNFDKFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x50A7D0", Offset = "0x508FD0", VA = "0x18050A7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x50A850", Offset = "0x509050", VA = "0x18050A850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xFF24E0", Offset = "0xFF0CE0", VA = "0x180FF24E0")]
	protected HFMPACPJAOH(Type BJNLFFPNEBC, string CEAFHMOKOGD, string JGCPNHEAFFA, bool LECHFHNFGNB, bool JEAHBLAKCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xFF2560", Offset = "0xFF0D60", VA = "0x180FF2560")]
	public HFMPACPJAOH(FieldInfo MODDMIDMILD, string CEAFHMOKOGD, bool AKGEBEDNNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xFF2330", Offset = "0xFF0B30", VA = "0x180FF2330")]
	public HFMPACPJAOH(PropertyInfo MODDMIDMILD, string CEAFHMOKOGD, bool AKGEBEDNNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xFF2140", Offset = "0xFF0940", VA = "0x180FF2140")]
	private static MethodInfo JAMMAKNGEJL(MemberInfo MODDMIDMILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AD70", Offset = "0x2B79570", VA = "0x182B7AD70")]
	public T JLGJPILLDPP<T>(bool EFJBGBFJNHD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xFF2080", Offset = "0xFF0880", VA = "0x180FF2080", Slot = "4")]
	public virtual void DDMIFCHDIHF(ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xFF2260", Offset = "0xFF0A60", VA = "0x180FF2260", Slot = "5")]
	public virtual void PGMNGDEALND(ILGenerator BLEEHJDPFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class IGHAIENNJMP : HFMPACPJAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly string ACLPGCIMAHA;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xFF3E10", Offset = "0xFF2610", VA = "0x180FF3E10")]
	public IGHAIENNJMP(string CEAFHMOKOGD, string ACLPGCIMAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xFF3D00", Offset = "0xFF2500", VA = "0x180FF3D00", Slot = "4")]
	public override void DDMIFCHDIHF(ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xFF3DC0", Offset = "0xFF25C0", VA = "0x180FF3DC0", Slot = "5")]
	public override void PGMNGDEALND(ILGenerator BLEEHJDPFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class FJOOMBOJAKA : HFMPACPJAOH
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly MethodInfo IODHKBIHEPM;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly MethodInfo NJLFNKGKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	internal KAFDHAEAPJC AEJNIMINIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	internal KAFDHAEAPJC PBFHFAFBPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	internal KAFDHAEAPJC HEPPHCCFDLM;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xFEF5F0", Offset = "0xFEDDF0", VA = "0x180FEF5F0")]
	public FJOOMBOJAKA(string CEAFHMOKOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xFEEF30", Offset = "0xFED730", VA = "0x180FEEF30", Slot = "4")]
	public override void DDMIFCHDIHF(ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xFEF100", Offset = "0xFED900", VA = "0x180FEF100", Slot = "5")]
	public override void PGMNGDEALND(ILGenerator BLEEHJDPFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0xFEEFF0", Offset = "0xFED7F0", VA = "0x180FEEFF0")]
	public void DPGGFDMEALF(ILGenerator BLEEHJDPFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class LKCGMIBBDBP
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type GEKBHHLLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OPEAIIMOMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC00", Offset = "0x7DC400", VA = "0x1807DDC00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x837710", Offset = "0x835F10", VA = "0x180837710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MJJJKDNMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x89AB40", Offset = "0x899340", VA = "0x18089AB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x89D1A0", Offset = "0x89B9A0", VA = "0x18089D1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo EEOBMGIGIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HFMPACPJAOH[] PFAGPJGIJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x50B460", Offset = "0x509C60", VA = "0x18050B460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D40", Offset = "0x5E2540", VA = "0x1805E3D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HFMPACPJAOH[] GODLHEJJLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4924910", Offset = "0x4923110", VA = "0x184924910")]
	public LKCGMIBBDBP(Type BJNLFFPNEBC, Func<string, string> AABMMAGHNLA, bool AKGEBEDNNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x4924840", Offset = "0x4923040", VA = "0x184924840")]
	private static bool FKFPDIGALEB(IEnumerator<ConstructorInfo> IMPBKCDFDLM, ref ConstructorInfo PGNAHGEKCPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct IOMPMCHEEDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public ulong CIDKNOKLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public int BCENOHLAIEF;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xFF4900", Offset = "0xFF3100", VA = "0x180FF4900")]
	public IOMPMCHEEDH(ulong MBIHOLIJBPL, int DFDIAAALMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xFF4710", Offset = "0xFF2F10", VA = "0x180FF4710")]
	public void GEEEGLPCFOL(ref IOMPMCHEEDH AJEOGBNDGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xFF46E0", Offset = "0xFF2EE0", VA = "0x180FF46E0")]
	public static IOMPMCHEEDH CNBNKEKHECC(ref IOMPMCHEEDH LNIJHEMDGEF, ref IOMPMCHEEDH LANKPNEAHJA)
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xFF47C0", Offset = "0xFF2FC0", VA = "0x180FF47C0")]
	public void MLLCOIGPLKE(ref IOMPMCHEEDH AJEOGBNDGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xFF4850", Offset = "0xFF3050", VA = "0x180FF4850")]
	public static IOMPMCHEEDH OADMCIJGKJM(ref IOMPMCHEEDH LNIJHEMDGEF, ref IOMPMCHEEDH LANKPNEAHJA)
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xFF4720", Offset = "0xFF2F20", VA = "0x180FF4720")]
	public void KFDFAOCIBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xFF4760", Offset = "0xFF2F60", VA = "0x180FF4760")]
	public static IOMPMCHEEDH KFDFAOCIBBC(ref IOMPMCHEEDH LNIJHEMDGEF)
	{
		return default(IOMPMCHEEDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct IIOEEHHMMJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public byte[] KIJIMACKNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public int BIJBEGOMFPC;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED350", Offset = "0x7EBB50", VA = "0x1807ED350")]
	public IIOEEHHMMJK(byte[] KIJIMACKNGN, int PBEKABJHDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xFF4410", Offset = "0xFF2C10", VA = "0x180FF4410")]
	public void MKMKAMAPKJL(byte LMLKAFLGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0xFF4220", Offset = "0xFF2A20", VA = "0x180FF4220")]
	public void FPCPMFPJNAD(byte[] LMLKAFLGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xFF4370", Offset = "0xFF2B70", VA = "0x180FF4370")]
	public void JCDOGNGOGLG(byte[] LMLKAFLGECK, int KMPDMGEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xFF42C0", Offset = "0xFF2AC0", VA = "0x180FF42C0")]
	public void JCDOGNGOGLG(byte[] LMLKAFLGECK, int OJOGGFGEONO, int KMPDMGEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0xFF4470", Offset = "0xFF2C70", VA = "0x180FF4470")]
	public void OANEPDJNELO(byte DGNGOIEGJNG, int BPCIMPGFHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xFF44F0", Offset = "0xFF2CF0", VA = "0x180FF44F0")]
	public void PIIHCHOMKGF(string LMLKAFLGECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class FICDMFLOHMO
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum IHDAOBFABIE
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum EMMLIHLFFHD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum IEMCDCMKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	[ThreadStatic]
	private static byte[] MAANNLPEDLL;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	[ThreadStatic]
	private static byte[] KFLBKLFHAAP;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly byte[] FGGKBEACOMC;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly byte[] HOANHDCPINM;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly IEMCDCMKPHN LBJOFNKJCFM;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly char EBDHILKMMOI;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly int MKEIFGDNOIM;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly int OHEGPLHFKAI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly uint[] ELBNGIFMEBG;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xFEE100", Offset = "0xFEC900", VA = "0x180FEE100")]
	private static byte[] JDJKIEEOEEH(int GDBDJPILDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xFED740", Offset = "0xFEBF40", VA = "0x180FED740")]
	private static byte[] GLCEJKHAEPE(int GDBDJPILDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xFEE2E0", Offset = "0xFECAE0", VA = "0x180FEE2E0")]
	public static int JHEOCAHAINB(ref byte[] KIJIMACKNGN, int BIJBEGOMFPC, float HNCFAALBJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xFEE1D0", Offset = "0xFEC9D0", VA = "0x180FEE1D0")]
	public static int JHEOCAHAINB(ref byte[] KIJIMACKNGN, int BIJBEGOMFPC, double HNCFAALBJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xFEE590", Offset = "0xFECD90", VA = "0x180FEE590")]
	private static bool OMCDIALKBIC(byte[] KIJIMACKNGN, int KMPDMGEMCKO, ulong AODNNHKNLJE, ulong ACAFGOIKCCH, ulong BOMIAMNPKHB, ulong DMOAMDBHMEH, ulong PPCNFCELNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xFED1D0", Offset = "0xFEB9D0", VA = "0x180FED1D0")]
	private static void AMDENDOGAAG(uint MGBAGKAPNOA, int IGMEIEGLFAI, out uint EHDGHDOJHDC, out int AJMOKPOLILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xFEE690", Offset = "0xFECE90", VA = "0x180FEE690")]
	private static bool PCJFDLHAEFN(IOMPMCHEEDH PGGODLNMLOC, IOMPMCHEEDH AEFBFMJCCOH, IOMPMCHEEDH GGFINGKNABA, byte[] KIJIMACKNGN, out int KMPDMGEMCKO, out int GPIGOLAPOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xFED9B0", Offset = "0xFEC1B0", VA = "0x180FED9B0")]
	private static bool HODGJJAFNHE(double PFMJOAEMNFL, IHDAOBFABIE HLBIKDBGOCF, byte[] KIJIMACKNGN, out int KMPDMGEMCKO, out int BBGADMFBIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xFEDD30", Offset = "0xFEC530", VA = "0x180FEDD30")]
	private static bool IHBGAILBCNE(double PFMJOAEMNFL, IHDAOBFABIE HLBIKDBGOCF, byte[] KIJIMACKNGN, out int KMPDMGEMCKO, out int CJFNNOOLEKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xFED820", Offset = "0xFEC020", VA = "0x180FED820")]
	private static bool HBFECNEPMDB(double HNCFAALBJCG, ref IIOEEHHMMJK EJKGBAILGOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xFECBA0", Offset = "0xFEB3A0", VA = "0x180FECBA0")]
	private static bool AIMJCCPMJKL(double HNCFAALBJCG, ref IIOEEHHMMJK EJKGBAILGOC, EMMLIHLFFHD HLBIKDBGOCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xFEDE20", Offset = "0xFEC620", VA = "0x180FEDE20")]
	private static void ILKNLBCBIPP(byte[] BABOPLPPHPG, int KMPDMGEMCKO, int CJFNNOOLEKG, int JMEKPDFNDPH, ref IIOEEHHMMJK EJKGBAILGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xFED2F0", Offset = "0xFEBAF0", VA = "0x180FED2F0")]
	private static void FALODEIBEJO(byte[] BABOPLPPHPG, int KMPDMGEMCKO, int DFDIAAALMJK, ref IIOEEHHMMJK EJKGBAILGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xFEE3F0", Offset = "0xFECBF0", VA = "0x180FEE3F0")]
	private static bool KLMBOBOEPLI(double PFMJOAEMNFL, EMMLIHLFFHD HLBIKDBGOCF, int BHMIMFFDNOJ, byte[] GJKBHCGCACC, out bool JJDHGHPAIGI, out int KMPDMGEMCKO, out int JMBNGJDJLPO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct AAJAOFEEIBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public double DPBGGLEPNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public ulong CHLKLJBNNNN;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct KCIJBFABEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float CIDKNOKLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public uint FFFEMJAEINF;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct CCDBLCGAFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private ulong HDJHFOMKAAD;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A253F0", Offset = "0x1A23BF0", VA = "0x181A253F0")]
	public CCDBLCGAFDD(double DPBGGLEPNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3628D80", Offset = "0x3627580", VA = "0x183628D80")]
	public CCDBLCGAFDD(IOMPMCHEEDH DPBGGLEPNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3628C10", Offset = "0x3627410", VA = "0x183628C10")]
	public IOMPMCHEEDH IMAALNDJGPA()
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3628B60", Offset = "0x3627360", VA = "0x183628B60")]
	public IOMPMCHEEDH FKOACMOOPOO()
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5BBB80", Offset = "0x5BA380", VA = "0x1805BBB80")]
	public ulong MAEIPPEMFOM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3628900", Offset = "0x3627100", VA = "0x183628900")]
	public double FAJCBJIJFOB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3628850", Offset = "0x3627050", VA = "0x183628850")]
	public double BHOCPPLECIF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3628D50", Offset = "0x3627550", VA = "0x183628D50")]
	public int PMALKPDIADE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3628B00", Offset = "0x3627300", VA = "0x183628B00")]
	public ulong FGCMAAAOLPA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3628C90", Offset = "0x3627490", VA = "0x183628C90")]
	public bool JAAOFBLDCBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3628830", Offset = "0x3627030", VA = "0x183628830")]
	public bool BGBHPHJLGNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3628B30", Offset = "0x3627330", VA = "0x183628B30")]
	public bool FJCPFIJMGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x36288D0", Offset = "0x36270D0", VA = "0x1836288D0")]
	public bool CCIDOLPLDHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3628CC0", Offset = "0x36274C0", VA = "0x183628CC0")]
	public int NLNPCLGANNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3628970", Offset = "0x3627170", VA = "0x183628970")]
	public void FDKBKFEIOEC(out IOMPMCHEEDH FBCJFJHNFEP, out IOMPMCHEEDH KAFMDMHFBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3628D00", Offset = "0x3627500", VA = "0x183628D00")]
	public bool OKEMCPJOAIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3628C00", Offset = "0x3627400", VA = "0x183628C00")]
	public double HNCFAALBJCG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3628CE0", Offset = "0x36274E0", VA = "0x183628CE0")]
	public static int NNLKDHNFHCE(int COKLPIKLPBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3628CB0", Offset = "0x36274B0", VA = "0x183628CB0")]
	public static double KCIJEBLEJBK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3628790", Offset = "0x3626F90", VA = "0x183628790")]
	public static ulong BENOHIFMHJM(IOMPMCHEEDH LPFLHILENKE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct ICIBLPKAKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private uint KOANEJHNINN;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x507480", Offset = "0x505C80", VA = "0x180507480")]
	public ICIBLPKAKFH(float CIDKNOKLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xFF3450", Offset = "0xFF1C50", VA = "0x180FF3450")]
	public IOMPMCHEEDH IMAALNDJGPA()
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5BBBC0", Offset = "0x5BA3C0", VA = "0x1805BBBC0")]
	public uint OGGMDPJIFIO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xFF34F0", Offset = "0xFF1CF0", VA = "0x180FF34F0")]
	public int PMALKPDIADE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xFF3430", Offset = "0xFF1C30", VA = "0x180FF3430")]
	public uint FGCMAAAOLPA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xFF34A0", Offset = "0xFF1CA0", VA = "0x180FF34A0")]
	public bool JAAOFBLDCBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xFF3300", Offset = "0xFF1B00", VA = "0x180FF3300")]
	public void FDKBKFEIOEC(out IOMPMCHEEDH FBCJFJHNFEP, out IOMPMCHEEDH KAFMDMHFBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xFF34B0", Offset = "0xFF1CB0", VA = "0x180FF34B0")]
	public bool OKEMCPJOAIN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct OCIALDMDPIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly ulong MBIHOLIJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly short JEIAHKFKKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly short BBGADMFBIKE;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x492E310", Offset = "0x492CB10", VA = "0x18492E310")]
	public OCIALDMDPIG(ulong MBIHOLIJBPL, short JEIAHKFKKBD, short BBGADMFBIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class MIFOPFHEEMH
{
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly OCIALDMDPIG[] NBMHGOIBGHP;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x492A730", Offset = "0x4928F30", VA = "0x18492A730")]
	public static void NDLKFKCBDJJ(int MOOPIDAIPHC, int PPBKBKKIKJM, out IOMPMCHEEDH EHDGHDOJHDC, out int BBGADMFBIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x492A630", Offset = "0x4928E30", VA = "0x18492A630")]
	public static void DMDCFNLDOHC(int ICEOHLIPNEJ, out IOMPMCHEEDH EHDGHDOJHDC, out int OGNNEJJFNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DefaultMember("Item")]
internal struct DPJNCDPMPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public readonly byte[] OCICGABDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly int OJOGGFGEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly int DBHJAJHAHJH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte BBAEBFDMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xFE3F30", Offset = "0xFE2730", VA = "0x180FE3F30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE3F70", Offset = "0xFE2770", VA = "0x180FE3F70")]
	public DPJNCDPMPOD(byte[] OCICGABDCEM, int OJOGGFGEONO, int KMPDMGEMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xC44C10", Offset = "0xC43410", VA = "0x180C44C10")]
	public int KMPDMGEMCKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xFE3ED0", Offset = "0xFE26D0", VA = "0x180FE3ED0")]
	public DPJNCDPMPOD JELGFPPNHDE(int ODIPMNFKGLE, int HDGPOJDDNJO)
	{
		return default(DPJNCDPMPOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class FCDKPACIEPI
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[ThreadStatic]
	private static byte[] ILHGMEPAGKO;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly double[] ONKHKPEHHMD;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly int GLCNENDJIMA;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xFEAD00", Offset = "0xFE9500", VA = "0x180FEAD00")]
	private static byte[] DNELLJIAGNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xFEAC20", Offset = "0xFE9420", VA = "0x180FEAC20")]
	private static DPJNCDPMPOD DDKKJEPOBHJ(DPJNCDPMPOD KIJIMACKNGN)
	{
		return default(DPJNCDPMPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xFEBAB0", Offset = "0xFEA2B0", VA = "0x180FEBAB0")]
	private static DPJNCDPMPOD PLGOLLILAMB(DPJNCDPMPOD KIJIMACKNGN)
	{
		return default(DPJNCDPMPOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xFEADE0", Offset = "0xFE95E0", VA = "0x180FEADE0")]
	private static void FGOPCCOMAIF(DPJNCDPMPOD KIJIMACKNGN, int DFDIAAALMJK, byte[] COKPANJJAND, out int MIFDLHJLBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xFEA470", Offset = "0xFE8C70", VA = "0x180FEA470")]
	private static void BMNBFLMIKDJ(DPJNCDPMPOD KIJIMACKNGN, int DFDIAAALMJK, byte[] KNEIHJJJBDA, int NBEIIMKMJPB, out DPJNCDPMPOD BOGIAFKDOJM, out int CFNIJOKMNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFEAE90", Offset = "0xFE9690", VA = "0x180FEAE90")]
	private static ulong GJIGGELCJKJ(DPJNCDPMPOD KIJIMACKNGN, out int FPLHFGNLIKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xFEAAB0", Offset = "0xFE92B0", VA = "0x180FEAAB0")]
	private static void DANOBHJOCDL(DPJNCDPMPOD KIJIMACKNGN, out IOMPMCHEEDH HMCKBHOBBJP, out int NOLBOGMLLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xFEB0C0", Offset = "0xFE98C0", VA = "0x180FEB0C0")]
	private static bool MLHMIOBLJHP(DPJNCDPMPOD BOGIAFKDOJM, int DFDIAAALMJK, out double HMCKBHOBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xFEAF20", Offset = "0xFE9720", VA = "0x180FEAF20")]
	private static IOMPMCHEEDH KNDCCGFIANN(int DFDIAAALMJK)
	{
		return default(IOMPMCHEEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xFEB510", Offset = "0xFE9D10", VA = "0x180FEB510")]
	private static bool PHDLKKCMECJ(DPJNCDPMPOD KIJIMACKNGN, int DFDIAAALMJK, out double HMCKBHOBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xFEA790", Offset = "0xFE8F90", VA = "0x180FEA790")]
	private static bool CHCHJLOFGII(DPJNCDPMPOD BOGIAFKDOJM, int DFDIAAALMJK, out double PMFOFBFGAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xFEA340", Offset = "0xFE8B40", VA = "0x180FEA340")]
	public static double? AKDKOIOKJAE(DPJNCDPMPOD KIJIMACKNGN, int DFDIAAALMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xFEA8D0", Offset = "0xFE90D0", VA = "0x180FEA8D0")]
	public static float? COAHHJEGJMH(DPJNCDPMPOD KIJIMACKNGN, int DFDIAAALMJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct PLHBDODKLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private byte[] KIJIMACKNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int BIJBEGOMFPC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x492FEE0", Offset = "0x492E6E0", VA = "0x18492FEE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED350", Offset = "0x7EBB50", VA = "0x1807ED350")]
	public PLHBDODKLKF(byte[] KIJIMACKNGN, int BIJBEGOMFPC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x492FE30", Offset = "0x492E630", VA = "0x18492FE30")]
	public static PLHBDODKLKF AECNFHFHFEH(PLHBDODKLKF ENIBKELLOBL)
	{
		return default(PLHBDODKLKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x492FDD0", Offset = "0x492E5D0", VA = "0x18492FDD0")]
	public static PLHBDODKLKF AAELLMJBLNM(PLHBDODKLKF ENIBKELLOBL, int KMPDMGEMCKO)
	{
		return default(PLHBDODKLKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x492FF20", Offset = "0x492E720", VA = "0x18492FF20")]
	public static int IFJHOACCPOG(PLHBDODKLKF PMMONDFDJHC, PLHBDODKLKF EDBHGEDEAKF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x492FFC0", Offset = "0x492E7C0", VA = "0x18492FFC0")]
	public static bool MNIIIAFMKIC(PLHBDODKLKF PMMONDFDJHC, PLHBDODKLKF EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x492FE40", Offset = "0x492E640", VA = "0x18492FE40")]
	public static bool CKJKHBIKNKE(PLHBDODKLKF PMMONDFDJHC, PLHBDODKLKF EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x492FFE0", Offset = "0x492E7E0", VA = "0x18492FFE0")]
	public static bool MNIIIAFMKIC(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x492FE60", Offset = "0x492E660", VA = "0x18492FE60")]
	public static bool CKJKHBIKNKE(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x492FE60", Offset = "0x492E660", VA = "0x18492FE60")]
	public static bool CKJKHBIKNKE(PLHBDODKLKF PMMONDFDJHC, byte EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4930020", Offset = "0x492E820", VA = "0x184930020")]
	public static bool PFKAMHEFIKH(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x492FF40", Offset = "0x492E740", VA = "0x18492FF40")]
	public static bool IGBIDDBJOKO(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x492FF80", Offset = "0x492E780", VA = "0x18492FF80")]
	public static bool KMJFECHOIEB(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x492FEA0", Offset = "0x492E6A0", VA = "0x18492FEA0")]
	public static bool HDEKANNJKIO(PLHBDODKLKF PMMONDFDJHC, char EDBHGEDEAKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BCKDNPKHHEL
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] GNJCLHHBBMG;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[ThreadStatic]
	private static byte[] CFCGKNADJOA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly byte[] FGGKBEACOMC;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly byte[] HOANHDCPINM;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly byte[] CKKENHLMCCK;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly int BNOLGJMBLCP;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ushort[] AMBLAILLPNO;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int DBGDGNHJDIL;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3625C80", Offset = "0x3624480", VA = "0x183625C80")]
	private static byte[] AANBMFLHOOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3627200", Offset = "0x3625A00", VA = "0x183627200")]
	private static byte[] PGKFNPGKEFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3626FD0", Offset = "0x36257D0", VA = "0x183626FD0")]
	public static double DKOFECMPJNB(byte[] KIJIMACKNGN, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3626F10", Offset = "0x3625710", VA = "0x183626F10")]
	public static float DKCEAFGKJCL(byte[] KIJIMACKNGN, int BIJBEGOMFPC, out int DNIHFNNPGFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x36272E0", Offset = "0x3625AE0", VA = "0x1836272E0")]
	private static bool PMFKIHABCOF(int ODDCIAGBNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3627090", Offset = "0x3625890", VA = "0x183627090")]
	private static bool HHPGHKJCMMG(ref PLHBDODKLKF KHJJNIPAGCA, PLHBDODKLKF KDNIOOOEPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3626E00", Offset = "0x3625600", VA = "0x183626E00")]
	private static bool DEGMMMDKNDB(ref PLHBDODKLKF KHJJNIPAGCA, PLHBDODKLKF KDNIOOOEPJF, byte[] BLEHJLLPLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x36271B0", Offset = "0x36259B0", VA = "0x1836271B0")]
	private static bool PDCHGCBMDHK(ref PLHBDODKLKF ODBFOHJHEIC, byte[] LMLKAFLGECK, int BIJBEGOMFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BF0", Offset = "0x6E03F0", VA = "0x1806E1BF0")]
	private static double ECANCGBMGJK(bool JJDHGHPAIGI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x3625D60", Offset = "0x3624560", VA = "0x183625D60")]
	private static double DEGBFOGNAOO(PLHBDODKLKF ABHCPJJMKJD, int KMPDMGEMCKO, bool ENANDAOGOEN, out int NPDLLDLBKGI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class DHOHPMLGPJA<T> : global::CCBAHIKANPJ<T[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly global::FOLOIACPPNC<T> FPAGFLHODDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly KECBLAJDCPL NBHGFPMLPEF;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD95D0", Offset = "0x2BD7DD0", VA = "0x182BD95D0")]
	public DHOHPMLGPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x27234C0", Offset = "0x2721CC0", VA = "0x1827234C0")]
	public DHOHPMLGPJA(KECBLAJDCPL NBHGFPMLPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x39CDD60", Offset = "0x39CC560", VA = "0x1839CDD60", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, T[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x39CD4F0", Offset = "0x39CBCF0", VA = "0x1839CD4F0", Slot = "5")]
	public T[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class BDPJJHFIHDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly global::FOLOIACPPNC<T> FPAGFLHODDH;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class EKMGIAIFPON<T> : global::CCBAHIKANPJ<List<T>>, AOMFJBLHMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly KECBLAJDCPL NBHGFPMLPEF;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2BD95D0", Offset = "0x2BD7DD0", VA = "0x182BD95D0")]
	public EKMGIAIFPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x27234C0", Offset = "0x2721CC0", VA = "0x1827234C0")]
	public EKMGIAIFPON(KECBLAJDCPL NBHGFPMLPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3B949D0", Offset = "0x3B931D0", VA = "0x183B949D0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, List<T> HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3B93620", Offset = "0x3B91E20", VA = "0x183B93620", Slot = "5")]
	public List<T> IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class EOOIBLBHAOP<TElement, TIntermediate, TEnumerator, TCollection> : global::CCBAHIKANPJ<TCollection>, AOMFJBLHMMA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3B97670", Offset = "0x3B95E70", VA = "0x183B97670", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, TCollection HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3B95950", Offset = "0x3B94150", VA = "0x183B95950", Slot = "5")]
	public TCollection IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LCNFIHIANAO(TCollection KAEJCIIKOCK);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OALNFBLCHMK();

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MFDJFDLHFHG(ref TIntermediate OFMMOHPAIOF, int INFKIDFCOKN, TElement HNCFAALBJCG);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection BDHAHGNBAKP(ref TIntermediate OOGNBOEEKKM);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	protected EOOIBLBHAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class PJFBCBDLFNB<TElement, TIntermediate, TCollection> : global::EOOIBLBHAOP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x35869D0", Offset = "0x35851D0", VA = "0x1835869D0", Slot = "6")]
	protected override IEnumerator<TElement> LCNFIHIANAO(TCollection KAEJCIIKOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1110", Offset = "0x2CBF910", VA = "0x182CC1110")]
	protected PJFBCBDLFNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class AOFBLFKJDPL<TElement, TCollection> : global::PJFBCBDLFNB<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected sealed override TCollection BDHAHGNBAKP(ref TCollection OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class PBFADHOFEHC<TElement, TCollection> : global::AOFBLFKJDPL<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x357C530", Offset = "0x357AD30", VA = "0x18357C530", Slot = "7")]
	protected override TCollection OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x357C4C0", Offset = "0x357ACC0", VA = "0x18357C4C0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref TCollection OFMMOHPAIOF, int INFKIDFCOKN, TElement HNCFAALBJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class KFLNAMDPCGJ<T> : global::EOOIBLBHAOP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1B0", Offset = "0x2BEA9B0", VA = "0x182BEC1B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref LinkedList<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override LinkedList<T> BDHAHGNBAKP(ref LinkedList<T> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override LinkedList<T> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3641820", Offset = "0x3640020", VA = "0x183641820", Slot = "6")]
	protected override LinkedList<T>.Enumerator LCNFIHIANAO(LinkedList<T> KAEJCIIKOCK)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LMPNEJEMFLF<T> : global::EOOIBLBHAOP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1B0", Offset = "0x2BEA9B0", VA = "0x182BEC1B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref Queue<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override Queue<T> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3526B40", Offset = "0x3525340", VA = "0x183526B40", Slot = "6")]
	protected override Queue<T>.Enumerator LCNFIHIANAO(Queue<T> KAEJCIIKOCK)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override Queue<T> BDHAHGNBAKP(ref Queue<T> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class OHFHFADIEJP<T> : global::EOOIBLBHAOP<T, global::JKHJFLKCPBN<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC530", Offset = "0x2BEAD30", VA = "0x182BEC530", Slot = "8")]
	protected override void MFDJFDLHFHG(ref global::JKHJFLKCPBN<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x36435B0", Offset = "0x3641DB0", VA = "0x1836435B0", Slot = "7")]
	protected override global::JKHJFLKCPBN<T> OALNFBLCHMK()
	{
		return default(global::JKHJFLKCPBN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3526B40", Offset = "0x3525340", VA = "0x183526B40", Slot = "6")]
	protected override Stack<T>.Enumerator LCNFIHIANAO(Stack<T> KAEJCIIKOCK)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x43A1770", Offset = "0x439FF70", VA = "0x1843A1770", Slot = "9")]
	protected override Stack<T> BDHAHGNBAKP(ref global::JKHJFLKCPBN<T> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class DIDCIPJBCND<T> : global::EOOIBLBHAOP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1B0", Offset = "0x2BEA9B0", VA = "0x182BEC1B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref HashSet<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override HashSet<T> BDHAHGNBAKP(ref HashSet<T> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override HashSet<T> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3526B40", Offset = "0x3525340", VA = "0x183526B40", Slot = "6")]
	protected override HashSet<T>.Enumerator LCNFIHIANAO(HashSet<T> KAEJCIIKOCK)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DCFBHMNOFNA<T> : global::PJFBCBDLFNB<T, global::JKHJFLKCPBN<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC530", Offset = "0x2BEAD30", VA = "0x182BEC530", Slot = "8")]
	protected override void MFDJFDLHFHG(ref global::JKHJFLKCPBN<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC4A0", Offset = "0x2BEACA0", VA = "0x182BEC4A0", Slot = "9")]
	protected override ReadOnlyCollection<T> BDHAHGNBAKP(ref global::JKHJFLKCPBN<T> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC560", Offset = "0x2BEAD60", VA = "0x182BEC560", Slot = "7")]
	protected override global::JKHJFLKCPBN<T> OALNFBLCHMK()
	{
		return default(global::JKHJFLKCPBN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DAHEGBLHCKH<T> : global::PJFBCBDLFNB<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1B0", Offset = "0x2BEA9B0", VA = "0x182BEC1B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref List<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override List<T> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override IList<T> BDHAHGNBAKP(ref List<T> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class HBCADKDCMHO<T> : global::PJFBCBDLFNB<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1B0", Offset = "0x2BEA9B0", VA = "0x182BEC1B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref List<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override List<T> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override ICollection<T> BDHAHGNBAKP(ref List<T> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class JLIDNNLGEIF<T> : global::PJFBCBDLFNB<T, global::JKHJFLKCPBN<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AD20", Offset = "0x3B59520", VA = "0x183B5AD20", Slot = "8")]
	protected override void MFDJFDLHFHG(ref global::JKHJFLKCPBN<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AD50", Offset = "0x3B59550", VA = "0x183B5AD50", Slot = "7")]
	protected override global::JKHJFLKCPBN<T> OALNFBLCHMK()
	{
		return default(global::JKHJFLKCPBN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3B5AD00", Offset = "0x3B59500", VA = "0x183B5AD00", Slot = "9")]
	protected override IEnumerable<T> BDHAHGNBAKP(ref global::JKHJFLKCPBN<T> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GOGJIGMCJMD<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LMIFOAEONEL<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class ALDNLMADMMM<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class HNLHBCNJGEA : global::CCBAHIKANPJ<IEnumerable>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly global::CCBAHIKANPJ<IEnumerable> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xFF28E0", Offset = "0xFF10E0", VA = "0x180FF28E0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, IEnumerable HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xFF2760", Offset = "0xFF0F60", VA = "0x180FF2760", Slot = "5")]
	public IEnumerable IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public HNLHBCNJGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class JCMAIOHKCLH : global::CCBAHIKANPJ<ICollection>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly global::CCBAHIKANPJ<ICollection> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xFF5350", Offset = "0xFF3B50", VA = "0x180FF5350", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ICollection HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xFF51D0", Offset = "0xFF39D0", VA = "0x180FF51D0", Slot = "5")]
	public ICollection IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JCMAIOHKCLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class KKAGDFGJBOJ : global::CCBAHIKANPJ<IList>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly global::CCBAHIKANPJ<IList> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4924080", Offset = "0x4922880", VA = "0x184924080", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, IList HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4923E90", Offset = "0x4922690", VA = "0x184923E90", Slot = "5")]
	public IList IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public KKAGDFGJBOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class AMFJEOPKBLJ<T> : global::PJFBCBDLFNB<T, global::JKHJFLKCPBN<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3643540", Offset = "0x3641D40", VA = "0x183643540", Slot = "8")]
	protected override void MFDJFDLHFHG(ref global::JKHJFLKCPBN<T> OFMMOHPAIOF, int INFKIDFCOKN, T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x36435B0", Offset = "0x3641DB0", VA = "0x1836435B0", Slot = "7")]
	protected override global::JKHJFLKCPBN<T> OALNFBLCHMK()
	{
		return default(global::JKHJFLKCPBN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3643500", Offset = "0x3641D00", VA = "0x183643500", Slot = "9")]
	protected override IReadOnlyList<T> BDHAHGNBAKP(ref global::JKHJFLKCPBN<T> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x272C2C0", Offset = "0x272AAC0", VA = "0x18272C2C0")]
	public AMFJEOPKBLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class DIMPGAFFMIJ
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0xFE1C70", Offset = "0xFE0470", VA = "0x180FE1C70")]
	public static DateTime KBIFMCPJANO(DateTime KFMFJCAAFBM)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class MDFBEACGLIM : global::CCBAHIKANPJ<DateTime>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly global::CCBAHIKANPJ<DateTime> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x4929790", Offset = "0x4927F90", VA = "0x184929790", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, DateTime HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4928890", Offset = "0x4927090", VA = "0x184928890", Slot = "5")]
	public DateTime IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public MDFBEACGLIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class APEAFOHIHPP : global::CCBAHIKANPJ<DateTimeOffset>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly global::CCBAHIKANPJ<DateTimeOffset> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3623860", Offset = "0x3622060", VA = "0x183623860", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, DateTimeOffset HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3622980", Offset = "0x3621180", VA = "0x183622980", Slot = "5")]
	public DateTimeOffset IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public APEAFOHIHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class EHIHMKKFHCA : global::CCBAHIKANPJ<TimeSpan>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::CCBAHIKANPJ<TimeSpan> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static byte[] DEFEEBBBKKO;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xFE82D0", Offset = "0xFE6AD0", VA = "0x180FE82D0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, TimeSpan HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xFE7970", Offset = "0xFE6170", VA = "0x180FE7970", Slot = "5")]
	public TimeSpan IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public EHIHMKKFHCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class ADFGKHCMIAH<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CCBAHIKANPJ<TDictionary>, AOMFJBLHMMA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3F382B0", Offset = "0x3F36AB0", VA = "0x183F382B0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, TDictionary HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3F371A0", Offset = "0x3F359A0", VA = "0x183F371A0", Slot = "5")]
	public TDictionary IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LCNFIHIANAO(TDictionary KAEJCIIKOCK);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OALNFBLCHMK();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MFDJFDLHFHG(ref TIntermediate OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary BDHAHGNBAKP(ref TIntermediate OOGNBOEEKKM);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	protected ADFGKHCMIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class MEGPDDCDDID<TKey, TValue, TIntermediate, TDictionary> : global::ADFGKHCMIAH<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x35869D0", Offset = "0x35851D0", VA = "0x1835869D0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LCNFIHIANAO(TDictionary KAEJCIIKOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BGOJAEOMJLI<TKey, TValue, TDictionary> : global::MEGPDDCDDID<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override TDictionary BDHAHGNBAKP(ref TDictionary OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class AKKAAALCIHB<TKey, TValue> : global::ADFGKHCMIAH<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3641880", Offset = "0x3640080", VA = "0x183641880", Slot = "8")]
	protected override void MFDJFDLHFHG(ref Dictionary<TKey, TValue> OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override Dictionary<TKey, TValue> BDHAHGNBAKP(ref Dictionary<TKey, TValue> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x36417D0", Offset = "0x363FFD0", VA = "0x1836417D0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LCNFIHIANAO(Dictionary<TKey, TValue> KAEJCIIKOCK)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2732FE0", Offset = "0x27317E0", VA = "0x182732FE0")]
	public AKKAAALCIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class BPAGFILNCGC<TKey, TValue, TDictionary> : global::BGOJAEOMJLI<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x33376B0", Offset = "0x3335EB0", VA = "0x1833376B0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref TDictionary OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3337790", Offset = "0x3335F90", VA = "0x183337790", Slot = "7")]
	protected override TDictionary OALNFBLCHMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class NHJCLPCJOBF<TKey, TValue> : global::MEGPDDCDDID<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3617BA0", Offset = "0x36163A0", VA = "0x183617BA0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref Dictionary<TKey, TValue> OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override Dictionary<TKey, TValue> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override IDictionary<TKey, TValue> BDHAHGNBAKP(ref Dictionary<TKey, TValue> OOGNBOEEKKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class AOBNBPFIEJP<TKey, TValue> : global::BGOJAEOMJLI<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3617BA0", Offset = "0x36163A0", VA = "0x183617BA0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref SortedList<TKey, TValue> OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override SortedList<TKey, TValue> OALNFBLCHMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class HDHGIKBOCHI<TKey, TValue> : global::ADFGKHCMIAH<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3617BA0", Offset = "0x36163A0", VA = "0x183617BA0", Slot = "8")]
	protected override void MFDJFDLHFHG(ref SortedDictionary<TKey, TValue> OFMMOHPAIOF, int INFKIDFCOKN, TKey DOMICNELCFM, TValue HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0xC7E6E0", Offset = "0xC7CEE0", VA = "0x180C7E6E0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> BDHAHGNBAKP(ref SortedDictionary<TKey, TValue> OOGNBOEEKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC1F0", Offset = "0x2BEA9F0", VA = "0x182BEC1F0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> OALNFBLCHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE2B0", Offset = "0x3DBCAB0", VA = "0x183DBE2B0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator LCNFIHIANAO(SortedDictionary<TKey, TValue> KAEJCIIKOCK)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class HMGOMLBOCNC<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class IOOFDKJAGKO : global::CCBAHIKANPJ<IDictionary>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::CCBAHIKANPJ<IDictionary> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xFF4AB0", Offset = "0xFF32B0", VA = "0x180FF4AB0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, IDictionary HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xFF4910", Offset = "0xFF3110", VA = "0x180FF4910", Slot = "5")]
	public IDictionary IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IOOFDKJAGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class GHOJMLILHJK : global::CCBAHIKANPJ<object>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private delegate void CBALFOMHPJG(object NLAJCIOPBDN, ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly global::ICIFHOLFHBK<KeyValuePair<object, CBALFOMHPJG>> JBCKDMDLCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly CNPMPMJABJI[] GMODANHGNHO;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xFF1380", Offset = "0xFEFB80", VA = "0x180FF1380")]
	public GHOJMLILHJK(params CNPMPMJABJI[] GMODANHGNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xFF0980", Offset = "0xFEF180", VA = "0x180FF0980", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xFF08F0", Offset = "0xFEF0F0", VA = "0x180FF08F0", Slot = "5")]
	public object IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class FAAOOOFMDEI
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xFE9B60", Offset = "0xFE8360", VA = "0x180FE9B60")]
	public static object JFGIDEDFEAD(Type BJNLFFPNEBC, out bool CGELMLAIJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xFE9380", Offset = "0xFE7B80", VA = "0x180FE9380")]
	public static object DLBLAPAHBPG(Type BJNLFFPNEBC, out bool CGELMLAIJGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class IAECNDNGADF<T> : global::CCBAHIKANPJ<T>, AOMFJBLHMMA, global::NDKKKOMLDLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class BOEBHBEIKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public BOEBHBEIKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x3D52640", Offset = "0x3D50E40", VA = "0x183D52640")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class BMNDOAKKPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public global::EGIENKHCBHG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public BMNDOAKKPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x3D50120", Offset = "0x3D4E920", VA = "0x183D50120")]
		internal void <.cctor>b__1(ref DPPLJIMOHKF writer, T value, CNPMPMJABJI _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class BMBMPAHLIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public global::OIGKJKHOOII<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public BMBMPAHLIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E580", Offset = "0x3D4CD80", VA = "0x183D4E580")]
		internal T <.cctor>b__2(ref LMJECJJKNAB reader, CNPMPMJABJI _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly global::NCCMNJFDJPK<T> BIELKCCEAMC;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly Dictionary<T, string> MINFDMLKJNF;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly global::EGIENKHCBHG<T> LCCDCLHIKEI;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly global::OIGKJKHOOII<T> HPDJKCMKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly bool PDMBMNOCAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly global::EGIENKHCBHG<T> MDEGJNFNEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly global::OIGKJKHOOII<T> FFOOPEAPDFM;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3D61C30", Offset = "0x3D60430", VA = "0x183D61C30")]
	static IAECNDNGADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3C28340", Offset = "0x3C26B40", VA = "0x183C28340")]
	public IAECNDNGADF(bool PDMBMNOCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3D5A2E0", Offset = "0x3D58AE0", VA = "0x183D5A2E0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3D56D50", Offset = "0x3D55550", VA = "0x183D56D50", Slot = "5")]
	public T IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3C14F70", Offset = "0x3C13770", VA = "0x183C14F70", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, T HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3D55290", Offset = "0x3D53A90", VA = "0x183D55290", Slot = "7")]
	public T ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class FAPECNLIHIK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class PGPEGNGKOHM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class KIEPOMEFKLE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class LMGBOJFBAGF<T> : global::CCBAHIKANPJ<T?>, AOMFJBLHMMA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3526910", Offset = "0x3525110", VA = "0x183526910", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, T? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x35264E0", Offset = "0x3524CE0", VA = "0x1835264E0", Slot = "5")]
	public T? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	public LMGBOJFBAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DJPCMGILIJJ<T> : global::CCBAHIKANPJ<T?>, AOMFJBLHMMA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::CCBAHIKANPJ<T> DEIEJEHDELF;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4550", Offset = "0x2AD2D50", VA = "0x182AD4550")]
	public DJPCMGILIJJ(global::CCBAHIKANPJ<T> DEIEJEHDELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2F78730", Offset = "0x2F76F30", VA = "0x182F78730", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, T? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2F778F0", Offset = "0x2F760F0", VA = "0x182F778F0", Slot = "5")]
	public T? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CGOIFHFCHLO : global::CCBAHIKANPJ<sbyte>, AOMFJBLHMMA, global::NDKKKOMLDLN<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly CGOIFHFCHLO OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xFDFF20", Offset = "0xFDE720", VA = "0x180FDFF20", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, sbyte HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xFDFE50", Offset = "0xFDE650", VA = "0x180FDFE50", Slot = "5")]
	public sbyte IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xFDFE60", Offset = "0xFDE660", VA = "0x180FDFE60", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, sbyte HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xFDFDE0", Offset = "0xFDE5E0", VA = "0x180FDFDE0", Slot = "7")]
	public sbyte ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public CGOIFHFCHLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class HOMNFCMPJHD : global::CCBAHIKANPJ<sbyte?>, AOMFJBLHMMA, global::NDKKKOMLDLN<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly HOMNFCMPJHD OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0xFF2DC0", Offset = "0xFF15C0", VA = "0x180FF2DC0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, sbyte? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0xFF2C50", Offset = "0xFF1450", VA = "0x180FF2C50", Slot = "5")]
	public sbyte? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xFF2CC0", Offset = "0xFF14C0", VA = "0x180FF2CC0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, sbyte? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xFF2BA0", Offset = "0xFF13A0", VA = "0x180FF2BA0", Slot = "7")]
	public sbyte? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public HOMNFCMPJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class IGHGJPFCDOE : global::CCBAHIKANPJ<sbyte[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly IGHGJPFCDOE OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xFF4020", Offset = "0xFF2820", VA = "0x180FF4020", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, sbyte[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0xFF3EE0", Offset = "0xFF26E0", VA = "0x180FF3EE0", Slot = "5")]
	public sbyte[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IGHGJPFCDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class AOFMPMGOAKM : global::CCBAHIKANPJ<short>, AOMFJBLHMMA, global::NDKKKOMLDLN<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly AOFMPMGOAKM OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3622680", Offset = "0x3620E80", VA = "0x183622680", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, short HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3622630", Offset = "0x3620E30", VA = "0x183622630", Slot = "5")]
	public short IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3622640", Offset = "0x3620E40", VA = "0x183622640", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, short HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3622590", Offset = "0x3620D90", VA = "0x183622590", Slot = "7")]
	public short ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public AOFMPMGOAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class CPHOGKBCLKF : global::CCBAHIKANPJ<short?>, AOMFJBLHMMA, global::NDKKKOMLDLN<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly CPHOGKBCLKF OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xFE0FD0", Offset = "0xFDF7D0", VA = "0x180FE0FD0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, short? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0xFE0E60", Offset = "0xFDF660", VA = "0x180FE0E60", Slot = "5")]
	public short? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xFE0ED0", Offset = "0xFDF6D0", VA = "0x180FE0ED0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, short? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xFE0DC0", Offset = "0xFDF5C0", VA = "0x180FE0DC0", Slot = "7")]
	public short? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public CPHOGKBCLKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class HBCFIICGBNP : global::CCBAHIKANPJ<short[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly HBCFIICGBNP OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xFF1E80", Offset = "0xFF0680", VA = "0x180FF1E80", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, short[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xFF1D40", Offset = "0xFF0540", VA = "0x180FF1D40", Slot = "5")]
	public short[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public HBCFIICGBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NOPNHINKDGD : global::CCBAHIKANPJ<int>, AOMFJBLHMMA, global::NDKKKOMLDLN<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly NOPNHINKDGD OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x492DEA0", Offset = "0x492C6A0", VA = "0x18492DEA0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, int HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x492DE00", Offset = "0x492C600", VA = "0x18492DE00", Slot = "5")]
	public int IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x492DE60", Offset = "0x492C660", VA = "0x18492DE60", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, int HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x492DD90", Offset = "0x492C590", VA = "0x18492DD90", Slot = "7")]
	public int ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public NOPNHINKDGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class PLBHDOHHOPD : global::CCBAHIKANPJ<int?>, AOMFJBLHMMA, global::NDKKKOMLDLN<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly PLBHDOHHOPD OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x492FD00", Offset = "0x492E500", VA = "0x18492FD00", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, int? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x492FBD0", Offset = "0x492E3D0", VA = "0x18492FBD0", Slot = "5")]
	public int? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x492FC80", Offset = "0x492E480", VA = "0x18492FC80", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, int? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x492FB30", Offset = "0x492E330", VA = "0x18492FB30", Slot = "7")]
	public int? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public PLBHDOHHOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class JEDPLAPAPDG : global::CCBAHIKANPJ<int[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly JEDPLAPAPDG OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xFF5850", Offset = "0xFF4050", VA = "0x180FF5850", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, int[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xFF5710", Offset = "0xFF3F10", VA = "0x180FF5710", Slot = "5")]
	public int[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JEDPLAPAPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JNPIPABBAKM : global::CCBAHIKANPJ<long>, AOMFJBLHMMA, global::NDKKKOMLDLN<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly JNPIPABBAKM OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xFF61E0", Offset = "0xFF49E0", VA = "0x180FF61E0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, long HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xFF6110", Offset = "0xFF4910", VA = "0x180FF6110", Slot = "5")]
	public long IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xFF6120", Offset = "0xFF4920", VA = "0x180FF6120", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, long HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xFF60A0", Offset = "0xFF48A0", VA = "0x180FF60A0", Slot = "7")]
	public long ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JNPIPABBAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class DEDMJOMFAEI : global::CCBAHIKANPJ<long?>, AOMFJBLHMMA, global::NDKKKOMLDLN<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly DEDMJOMFAEI OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xFE1AA0", Offset = "0xFE02A0", VA = "0x180FE1AA0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, long? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xFE1910", Offset = "0xFE0110", VA = "0x180FE1910", Slot = "5")]
	public long? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xFE19A0", Offset = "0xFE01A0", VA = "0x180FE19A0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, long? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xFE1850", Offset = "0xFE0050", VA = "0x180FE1850", Slot = "7")]
	public long? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public DEDMJOMFAEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class FDNOEMMACEC : global::CCBAHIKANPJ<long[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly FDNOEMMACEC OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xFEBD60", Offset = "0xFEA560", VA = "0x180FEBD60", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, long[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xFEBC20", Offset = "0xFEA420", VA = "0x180FEBC20", Slot = "5")]
	public long[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public FDNOEMMACEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class MBJABJMNHOP : global::CCBAHIKANPJ<byte>, AOMFJBLHMMA, global::NDKKKOMLDLN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly MBJABJMNHOP OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4928810", Offset = "0x4927010", VA = "0x184928810", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, byte HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4928770", Offset = "0x4926F70", VA = "0x184928770", Slot = "5")]
	public byte IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x49287D0", Offset = "0x4926FD0", VA = "0x1849287D0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, byte HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4928700", Offset = "0x4926F00", VA = "0x184928700", Slot = "7")]
	public byte ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public MBJABJMNHOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class MJGHHPCAAGL : global::CCBAHIKANPJ<byte?>, AOMFJBLHMMA, global::NDKKKOMLDLN<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MJGHHPCAAGL OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x492BF00", Offset = "0x492A700", VA = "0x18492BF00", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, byte? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x492BDD0", Offset = "0x492A5D0", VA = "0x18492BDD0", Slot = "5")]
	public byte? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x492BE80", Offset = "0x492A680", VA = "0x18492BE80", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, byte? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x492BD20", Offset = "0x492A520", VA = "0x18492BD20", Slot = "7")]
	public byte? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public MJGHHPCAAGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class IEHDLDHJFMB : global::CCBAHIKANPJ<ushort>, AOMFJBLHMMA, global::NDKKKOMLDLN<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IEHDLDHJFMB OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xFF3970", Offset = "0xFF2170", VA = "0x180FF3970", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ushort HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xFF38A0", Offset = "0xFF20A0", VA = "0x180FF38A0", Slot = "5")]
	public ushort IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xFF38B0", Offset = "0xFF20B0", VA = "0x180FF38B0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, ushort HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xFF3830", Offset = "0xFF2030", VA = "0x180FF3830", Slot = "7")]
	public ushort ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IEHDLDHJFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class IFPGEPIOOGI : global::CCBAHIKANPJ<ushort?>, AOMFJBLHMMA, global::NDKKKOMLDLN<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly IFPGEPIOOGI OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xFF3C20", Offset = "0xFF2420", VA = "0x180FF3C20", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ushort? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xFF3AB0", Offset = "0xFF22B0", VA = "0x180FF3AB0", Slot = "5")]
	public ushort? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xFF3B20", Offset = "0xFF2320", VA = "0x180FF3B20", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, ushort? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xFF3A10", Offset = "0xFF2210", VA = "0x180FF3A10", Slot = "7")]
	public ushort? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IFPGEPIOOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class KIAOGEMODHJ : global::CCBAHIKANPJ<ushort[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly KIAOGEMODHJ OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xFF6940", Offset = "0xFF5140", VA = "0x180FF6940", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ushort[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xFF6800", Offset = "0xFF5000", VA = "0x180FF6800", Slot = "5")]
	public ushort[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public KIAOGEMODHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class BGHGEJHKOGA : global::CCBAHIKANPJ<uint>, AOMFJBLHMMA, global::NDKKKOMLDLN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly BGHGEJHKOGA OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3628210", Offset = "0x3626A10", VA = "0x183628210", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, uint HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x36281C0", Offset = "0x36269C0", VA = "0x1836281C0", Slot = "5")]
	public uint IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x36281D0", Offset = "0x36269D0", VA = "0x1836281D0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, uint HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3628120", Offset = "0x3626920", VA = "0x183628120", Slot = "7")]
	public uint ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public BGHGEJHKOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class JFEDMPDCCMF : global::CCBAHIKANPJ<uint?>, AOMFJBLHMMA, global::NDKKKOMLDLN<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JFEDMPDCCMF OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xFF5C60", Offset = "0xFF4460", VA = "0x180FF5C60", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, uint? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xFF5AF0", Offset = "0xFF42F0", VA = "0x180FF5AF0", Slot = "5")]
	public uint? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xFF5B60", Offset = "0xFF4360", VA = "0x180FF5B60", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, uint? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xFF5A50", Offset = "0xFF4250", VA = "0x180FF5A50", Slot = "7")]
	public uint? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JFEDMPDCCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class LIPIGKHNDDJ : global::CCBAHIKANPJ<uint[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly LIPIGKHNDDJ OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x4924720", Offset = "0x4922F20", VA = "0x184924720", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, uint[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4924580", Offset = "0x4922D80", VA = "0x184924580", Slot = "5")]
	public uint[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public LIPIGKHNDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class BCIKKGDMLBD : global::CCBAHIKANPJ<ulong>, AOMFJBLHMMA, global::NDKKKOMLDLN<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly BCIKKGDMLBD OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3625C00", Offset = "0x3624400", VA = "0x183625C00", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ulong HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x3625BB0", Offset = "0x36243B0", VA = "0x183625BB0", Slot = "5")]
	public ulong IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x3625BC0", Offset = "0x36243C0", VA = "0x183625BC0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, ulong HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3625B40", Offset = "0x3624340", VA = "0x183625B40", Slot = "7")]
	public ulong ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public BCIKKGDMLBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BHOOAMLCENP : global::CCBAHIKANPJ<ulong?>, AOMFJBLHMMA, global::NDKKKOMLDLN<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly BHOOAMLCENP OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x36284F0", Offset = "0x3626CF0", VA = "0x1836284F0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ulong? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x36283E0", Offset = "0x3626BE0", VA = "0x1836283E0", Slot = "5")]
	public ulong? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x3628470", Offset = "0x3626C70", VA = "0x183628470", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, ulong? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3628320", Offset = "0x3626B20", VA = "0x183628320", Slot = "7")]
	public ulong? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public BHOOAMLCENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class OLPIHEDBLGE : global::CCBAHIKANPJ<ulong[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly OLPIHEDBLGE OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x492EE10", Offset = "0x492D610", VA = "0x18492EE10", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ulong[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x492EC70", Offset = "0x492D470", VA = "0x18492EC70", Slot = "5")]
	public ulong[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public OLPIHEDBLGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class KIJLOAEDCCH : global::CCBAHIKANPJ<float>, AOMFJBLHMMA, global::NDKKKOMLDLN<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KIJLOAEDCCH OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4923E20", Offset = "0x4922620", VA = "0x184923E20", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, float HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4923DD0", Offset = "0x49225D0", VA = "0x184923DD0", Slot = "5")]
	public float IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4923DE0", Offset = "0x49225E0", VA = "0x184923DE0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, float HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4923D60", Offset = "0x4922560", VA = "0x184923D60", Slot = "7")]
	public float ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public KIJLOAEDCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class ONDJNDCIAEF : global::CCBAHIKANPJ<float?>, AOMFJBLHMMA, global::NDKKKOMLDLN<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly ONDJNDCIAEF OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x492F200", Offset = "0x492DA00", VA = "0x18492F200", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, float? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x492F110", Offset = "0x492D910", VA = "0x18492F110", Slot = "5")]
	public float? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x492F180", Offset = "0x492D980", VA = "0x18492F180", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, float? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x492F070", Offset = "0x492D870", VA = "0x18492F070", Slot = "7")]
	public float? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public ONDJNDCIAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DJAFMMKLADP : global::CCBAHIKANPJ<float[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly DJAFMMKLADP OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xFE1E50", Offset = "0xFE0650", VA = "0x180FE1E50", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, float[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xFE1D10", Offset = "0xFE0510", VA = "0x180FE1D10", Slot = "5")]
	public float[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public DJAFMMKLADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class DLHBKMLDPBG : global::CCBAHIKANPJ<double>, AOMFJBLHMMA, global::NDKKKOMLDLN<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly DLHBKMLDPBG OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xFE22A0", Offset = "0xFE0AA0", VA = "0x180FE22A0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, double HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xFE21E0", Offset = "0xFE09E0", VA = "0x180FE21E0", Slot = "5")]
	public double IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xFE21F0", Offset = "0xFE09F0", VA = "0x180FE21F0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, double HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xFE2170", Offset = "0xFE0970", VA = "0x180FE2170", Slot = "7")]
	public double ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public DLHBKMLDPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class OHEDCDKFKBB : global::CCBAHIKANPJ<double?>, AOMFJBLHMMA, global::NDKKKOMLDLN<double?>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly OHEDCDKFKBB OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x492E5A0", Offset = "0x492CDA0", VA = "0x18492E5A0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, double? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x492E490", Offset = "0x492CC90", VA = "0x18492E490", Slot = "5")]
	public double? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x492E520", Offset = "0x492CD20", VA = "0x18492E520", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, double? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x492E3D0", Offset = "0x492CBD0", VA = "0x18492E3D0", Slot = "7")]
	public double? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public OHEDCDKFKBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class NPGPAGEDKKC : global::CCBAHIKANPJ<double[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly NPGPAGEDKKC OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x492E0B0", Offset = "0x492C8B0", VA = "0x18492E0B0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, double[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x492DF10", Offset = "0x492C710", VA = "0x18492DF10", Slot = "5")]
	public double[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public NPGPAGEDKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FHPDILOHAPL : global::CCBAHIKANPJ<bool>, AOMFJBLHMMA, global::NDKKKOMLDLN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly FHPDILOHAPL OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xFECB20", Offset = "0xFEB320", VA = "0x180FECB20", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, bool HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xFECA60", Offset = "0xFEB260", VA = "0x180FECA60", Slot = "5")]
	public bool IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xFECA70", Offset = "0xFEB270", VA = "0x180FECA70", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, bool HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xFEC9F0", Offset = "0xFEB1F0", VA = "0x180FEC9F0", Slot = "7")]
	public bool ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public FHPDILOHAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class OKIIIKJDAFH : global::CCBAHIKANPJ<bool?>, AOMFJBLHMMA, global::NDKKKOMLDLN<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly OKIIIKJDAFH OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x492EA60", Offset = "0x492D260", VA = "0x18492EA60", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, bool? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x492E970", Offset = "0x492D170", VA = "0x18492E970", Slot = "5")]
	public bool? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x492E9E0", Offset = "0x492D1E0", VA = "0x18492E9E0", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, bool? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x492E8C0", Offset = "0x492D0C0", VA = "0x18492E8C0", Slot = "7")]
	public bool? ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public OKIIIKJDAFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class ENBFKNCPEPL : global::CCBAHIKANPJ<bool[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly ENBFKNCPEPL OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xFE8D80", Offset = "0xFE7580", VA = "0x180FE8D80", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, bool[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xFE8C40", Offset = "0xFE7440", VA = "0x180FE8C40", Slot = "5")]
	public bool[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public ENBFKNCPEPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class PPENONJCMNG : global::CCBAHIKANPJ<object>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly global::CCBAHIKANPJ<object> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly Dictionary<Type, int> DNHEKDMFDKH;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x49305C0", Offset = "0x492EDC0", VA = "0x1849305C0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, object HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4930260", Offset = "0x492EA60", VA = "0x184930260", Slot = "5")]
	public object IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public PPENONJCMNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JNBLKEELOBB : global::CCBAHIKANPJ<byte[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly global::CCBAHIKANPJ<byte[]> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xFF5F00", Offset = "0xFF4700", VA = "0x180FF5F00", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, byte[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xFF5E80", Offset = "0xFF4680", VA = "0x180FF5E80", Slot = "5")]
	public byte[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public JNBLKEELOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class FIECLLMGECM : global::CCBAHIKANPJ<ArraySegment<byte>>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly global::CCBAHIKANPJ<ArraySegment<byte>> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xFEECF0", Offset = "0xFED4F0", VA = "0x180FEECF0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, ArraySegment<byte> HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xFEEC20", Offset = "0xFED420", VA = "0x180FEEC20", Slot = "5")]
	public ArraySegment<byte> IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public FIECLLMGECM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class GHOPOLCECNA : global::CCBAHIKANPJ<string>, AOMFJBLHMMA, global::NDKKKOMLDLN<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly global::CCBAHIKANPJ<string> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xFF1430", Offset = "0xFEFC30", VA = "0x180FF1430", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, string HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xFF1420", Offset = "0xFEFC20", VA = "0x180FF1420", Slot = "5")]
	public string IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0xFF1430", Offset = "0xFEFC30", VA = "0x180FF1430", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, string HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xFF1420", Offset = "0xFEFC20", VA = "0x180FF1420", Slot = "7")]
	public string ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public GHOPOLCECNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class IDOKPOHBBBO : global::CCBAHIKANPJ<string[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly IDOKPOHBBBO OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xFF3650", Offset = "0xFF1E50", VA = "0x180FF3650", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, string[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xFF3510", Offset = "0xFF1D10", VA = "0x180FF3510", Slot = "5")]
	public string[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IDOKPOHBBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BKIKLLBPMKO : global::CCBAHIKANPJ<char>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly BKIKLLBPMKO OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x36285F0", Offset = "0x3626DF0", VA = "0x1836285F0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, char HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x36285C0", Offset = "0x3626DC0", VA = "0x1836285C0", Slot = "5")]
	public char IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public BKIKLLBPMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class MHHNBLKLBDO : global::CCBAHIKANPJ<char?>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly MHHNBLKLBDO OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x492A500", Offset = "0x4928D00", VA = "0x18492A500", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, char? HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x492A440", Offset = "0x4928C40", VA = "0x18492A440", Slot = "5")]
	public char? IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public MHHNBLKLBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CMIFKNPBIPO : global::CCBAHIKANPJ<char[]>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly CMIFKNPBIPO OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xFE0940", Offset = "0xFDF140", VA = "0x180FE0940", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, char[] HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xFE07A0", Offset = "0xFDEFA0", VA = "0x180FE07A0", Slot = "5")]
	public char[] IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public CMIFKNPBIPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class FAAAHPCJBLM : global::CCBAHIKANPJ<Guid>, AOMFJBLHMMA, global::NDKKKOMLDLN<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::CCBAHIKANPJ<Guid> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xFE9190", Offset = "0xFE7990", VA = "0x180FE9190", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Guid HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xFE9140", Offset = "0xFE7940", VA = "0x180FE9140", Slot = "5")]
	public Guid IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xFE9190", Offset = "0xFE7990", VA = "0x180FE9190", Slot = "6")]
	public void IJCKMFNJBJL(ref DPPLJIMOHKF PMAIAIDMOEI, Guid HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xFE90F0", Offset = "0xFE78F0", VA = "0x180FE90F0", Slot = "7")]
	public Guid ANAIOFAHBBP(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public FAAAHPCJBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class ANGEAAPMLCJ : global::CCBAHIKANPJ<decimal>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::CCBAHIKANPJ<decimal> OJLDJOBNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly bool MCPDDJBJBBG;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x645450", Offset = "0x643C50", VA = "0x180645450")]
	public ANGEAAPMLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x645420", Offset = "0x643C20", VA = "0x180645420")]
	public ANGEAAPMLCJ(bool MCPDDJBJBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x3622300", Offset = "0x3620B00", VA = "0x183622300", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, decimal HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x3622150", Offset = "0x3620950", VA = "0x183622150", Slot = "5")]
	public decimal IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class ENJKMHAOLLN : global::CCBAHIKANPJ<Uri>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::CCBAHIKANPJ<Uri> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0xFE8FE0", Offset = "0xFE77E0", VA = "0x180FE8FE0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Uri HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0xFE8F60", Offset = "0xFE7760", VA = "0x180FE8F60", Slot = "5")]
	public Uri IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public ENJKMHAOLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class GDFAIAEHMJP : global::CCBAHIKANPJ<Version>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::CCBAHIKANPJ<Version> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xFF02D0", Offset = "0xFEEAD0", VA = "0x180FF02D0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Version HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xFF0250", Offset = "0xFEEA50", VA = "0x180FF0250", Slot = "5")]
	public Version IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public GDFAIAEHMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class KDDAHAFNPNI<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class POIHLMCGEGE : global::CCBAHIKANPJ<StringBuilder>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::CCBAHIKANPJ<StringBuilder> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x49301B0", Offset = "0x492E9B0", VA = "0x1849301B0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, StringBuilder HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x4930130", Offset = "0x492E930", VA = "0x184930130", Slot = "5")]
	public StringBuilder IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public POIHLMCGEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class OKEOCGICGPP : global::CCBAHIKANPJ<BitArray>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::CCBAHIKANPJ<BitArray> OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x492E7D0", Offset = "0x492CFD0", VA = "0x18492E7D0", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, BitArray HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x492E670", Offset = "0x492CE70", VA = "0x18492E670", Slot = "5")]
	public BitArray IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public OKEOCGICGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class FEEPEJCPNBB : global::CCBAHIKANPJ<Type>, AOMFJBLHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly FEEPEJCPNBB OJLDJOBNOGB;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly Regex DICMDJOEPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private bool CBJHLBMLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private bool IADOBEPNMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private bool OFFMMNPMKHG;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xFEC210", Offset = "0xFEAA10", VA = "0x180FEC210")]
	public FEEPEJCPNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xFEC230", Offset = "0xFEAA30", VA = "0x180FEC230")]
	public FEEPEJCPNBB(bool CBJHLBMLIJJ, bool IADOBEPNMAK, bool OFFMMNPMKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xFEC080", Offset = "0xFEA880", VA = "0x180FEC080", Slot = "4")]
	public void IPEJBGOIGOE(ref DPPLJIMOHKF PMAIAIDMOEI, Type HNCFAALBJCG, CNPMPMJABJI GDIKFMBFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xFEBF60", Offset = "0xFEA760", VA = "0x180FEBF60", Slot = "5")]
	public Type IEIPGDINOPI(ref LMJECJJKNAB APKEPEIJPBH, CNPMPMJABJI GDIKFMBFBBO)
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
