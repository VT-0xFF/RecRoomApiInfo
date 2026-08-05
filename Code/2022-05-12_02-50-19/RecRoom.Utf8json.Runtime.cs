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
public class CEKDOHEDOAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x552480", Offset = "0x551880", VA = "0x180552480")]
	public CEKDOHEDOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FNCAFDFMGGG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x552480", Offset = "0x551880", VA = "0x180552480")]
	public FNCAFDFMGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PHDOGJLJBPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x552480", Offset = "0x551880", VA = "0x180552480")]
	public PHDOGJLJBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CANOPCHMKBM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x552480", Offset = "0x551880", VA = "0x180552480")]
	public CANOPCHMKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class FAMCOFOEIEH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33DD8F0", Offset = "0x33DCCF0", VA = "0x1833DD8F0")]
	public static bool LABOPIBENEN(this TypeInfo HHDFIJECABM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class IEJELOKOGJD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DNHPLAKEEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] CBEEOJCLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEB0", Offset = "0x6BF2B0", VA = "0x1806BFEB0")]
	public IEJELOKOGJD(Type CLKBAJLNFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BHDPHKJGPJC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void KHINOOOLBII<T>(ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T FMGEFDIKCGE<T>(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL ICEFPGFDNNM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NPKKFPKKFLD
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BFPOGOEJBPA<T> : NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEIMJFDODOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NMABLJJJMND
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JMCBGHBACEH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2090970", Offset = "0x208FD70", VA = "0x182090970")]
	public static global::BFPOGOEJBPA<T> GAGELACHAEP<T>(this FLGJCMOKHGL ICEFPGFDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4224F70", Offset = "0x4224370", VA = "0x184224F70")]
	public static object DBFPCNOCKLK(this FLGJCMOKHGL ICEFPGFDNNM, Type HHDFIJECABM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DLDIBMIKHCJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3308F30", Offset = "0x3308330", VA = "0x183308F30")]
	public DLDIBMIKHCJ(string IOHPBCJMLDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BJFAHAPJAFA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OEJLPDIKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] KCNEECJJIPG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] HFHHFMPELKC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x330FB20", Offset = "0x330EF20", VA = "0x18330FB20")]
		public static byte[] GPHHBMKNIJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x330FA90", Offset = "0x330EE90", VA = "0x18330FA90")]
		public static char[] GFIDDJBELDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> HCJNFAILCNH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] JGFGGCEPEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] MFCIHENGNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CBMNFDDLNMI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KPJBPGLLEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3304380", Offset = "0x3303780", VA = "0x183304380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33063A0", Offset = "0x33057A0", VA = "0x1833063A0")]
	public BJFAHAPJAFA(byte[] MFCIHENGNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33061C0", Offset = "0x33055C0", VA = "0x1833061C0")]
	public BJFAHAPJAFA(byte[] MFCIHENGNMD, int CBMNFDDLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3304B50", Offset = "0x3303F50", VA = "0x183304B50")]
	private IBFMMOHOGBJ JAHKCDJEDFG(string COLNLKGICAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3305070", Offset = "0x3304470", VA = "0x183305070")]
	private IBFMMOHOGBJ KBBIHKJLKBL(string IOHPBCJMLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33043A0", Offset = "0x33037A0", VA = "0x1833043A0")]
	public void DGJJMBINKFL(int CBMNFDDLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78E1B0", Offset = "0x78D5B0", VA = "0x18078E1B0")]
	public byte[] LGCKFCEFPOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4A0", Offset = "0x7FD8A0", VA = "0x1807FE4A0")]
	public int CFMEKAFAPHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3305300", Offset = "0x3304700", VA = "0x183305300")]
	public BEGGCFIPLFA LMFIIANDNJM()
	{
		return default(BEGGCFIPLFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33039C0", Offset = "0x3302DC0", VA = "0x1833039C0")]
	public void BPJBHKLNJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x33043B0", Offset = "0x33037B0", VA = "0x1833043B0")]
	public bool DKDCDDPPOLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3306070", Offset = "0x3305470", VA = "0x183306070")]
	public bool PJKBPENPHBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3305770", Offset = "0x3304B70", VA = "0x183305770")]
	public void MNFMMDAPDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3305F40", Offset = "0x3305340", VA = "0x183305F40")]
	public bool PEODIKFGLKN(ref int LFFBMCJGPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3304910", Offset = "0x3303D10", VA = "0x183304910")]
	public bool IBHOPDHHHHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3305FD0", Offset = "0x33053D0", VA = "0x183305FD0")]
	public void PFJJKJDOEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3304290", Offset = "0x3303690", VA = "0x183304290")]
	public bool CFKAFHJALDP(ref int LFFBMCJGPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3305810", Offset = "0x3304C10", VA = "0x183305810")]
	public bool NBJBEGHPLDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3304AB0", Offset = "0x3303EB0", VA = "0x183304AB0")]
	public void IKBIJIBPJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33048A0", Offset = "0x3303CA0", VA = "0x1833048A0")]
	public bool HPJLLOIOJAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x33047A0", Offset = "0x3303BA0", VA = "0x1833047A0")]
	public void FFCPBABNBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3303B00", Offset = "0x3302F00", VA = "0x183303B00")]
	private void CABGINFJCDJ(out byte[] CFIKCFLFIPA, out int OONMMDKAIHC, out int GLAIKPOIECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3303910", Offset = "0x3302D10", VA = "0x183303910")]
	private static int BGMOAHPJIBO(char GNKLMCIFODF, char FFOHEAHJJEI, char DMIPEKEOIKL, char LHMFHKDLIJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x33049E0", Offset = "0x3303DE0", VA = "0x1833049E0")]
	private static int IDEKDOJFGLO(char JEPLLBBBDFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3305680", Offset = "0x3304A80", VA = "0x183305680")]
	public ArraySegment<byte> MLGEKEKGEFM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3305950", Offset = "0x3304D50", VA = "0x183305950")]
	public string NIPEMCBLCJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x33052D0", Offset = "0x33046D0", VA = "0x1833052D0")]
	public string KFJMJIJLOJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3305490", Offset = "0x3304890", VA = "0x183305490")]
	public ArraySegment<byte> MACGMHFJAGH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3305640", Offset = "0x3304A40", VA = "0x183305640")]
	public ArraySegment<byte> MFCDGCMEPOA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3305BC0", Offset = "0x3304FC0", VA = "0x183305BC0")]
	public bool NMDOJNAHNDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x33046E0", Offset = "0x3303AE0", VA = "0x1833046E0")]
	private static bool EMPLBKNLHHO(byte DMIPEKEOIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33059F0", Offset = "0x3304DF0", VA = "0x1833059F0")]
	private void NLEDCOGEHJL(BEGGCFIPLFA ANBIAABLBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3305E20", Offset = "0x3305220", VA = "0x183305E20")]
	public void OEGFPPMJHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3305880", Offset = "0x3304C80", VA = "0x183305880")]
	private void NEDBEHBJHNN(int BOPIENBKGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3305EF0", Offset = "0x33052F0", VA = "0x183305EF0")]
	public sbyte OKNBJFHECNL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3304320", Offset = "0x3303720", VA = "0x183304320")]
	public short DEENCJPHFAI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33044D0", Offset = "0x33038D0", VA = "0x1833044D0")]
	public int DNKFJCGPCMM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3303830", Offset = "0x3302C30", VA = "0x183303830")]
	public long APMFEEADCDG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33038B0", Offset = "0x3302CB0", VA = "0x1833038B0")]
	public byte BFCDBEKLKAA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3304980", Offset = "0x3303D80", VA = "0x183304980")]
	public ushort IDBMLGFPOJC()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3304840", Offset = "0x3303C40", VA = "0x183304840")]
	public uint GMPBCDALIEO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3304FF0", Offset = "0x33043F0", VA = "0x183304FF0")]
	public ulong JFIFPFHEIHA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3305E30", Offset = "0x3305230", VA = "0x183305E30")]
	public float OJIJJKHMNDL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3304620", Offset = "0x3303A20", VA = "0x183304620")]
	public double EDILBILMAEL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3304530", Offset = "0x3303930", VA = "0x183304530")]
	public ArraySegment<byte> EBAMJDLHMCB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3305150", Offset = "0x3304550", VA = "0x183305150")]
	private static int KEAGCDFCPDD(byte[] MFCIHENGNMD, int CBMNFDDLNMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IBFMMOHOGBJ : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference BKFJIIELOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int NEHFENFFMBG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int JODHBANPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x10AA1B0", Offset = "0x10A95B0", VA = "0x1810AA1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NNGIELNMONC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE10", Offset = "0x5EC210", VA = "0x1805ECE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33EBA00", Offset = "0x33EAE00", VA = "0x1833EBA00")]
	public IBFMMOHOGBJ(string IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x33EB930", Offset = "0x33EAD30", VA = "0x1833EB930")]
	public IBFMMOHOGBJ(string IOHPBCJMLDB, byte[] FCCHBNMKBDE, int CBMNFDDLNMI, int NEHFENFFMBG, string FMBJAAHLHNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CNCGAFHHGIK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PNCDFEEGBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void PDDCIFKCNEJ(ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object HKOGNDMFMKL(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL ICEFPGFDNNM);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KOHDMPOOAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class FMAANBNLDDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
				public FMAANBNLDDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x33096D0", Offset = "0x3308AD0", VA = "0x1833096D0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x3309710", Offset = "0x3308B10", VA = "0x183309710")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, FLGJCMOKHGL, byte[]> PNEDGAKHCOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, FLGJCMOKHGL> LDCDNGGCODF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly PDDCIFKCNEJ CJPLNKDPAKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, FLGJCMOKHGL, ArraySegment<byte>> JINJINOKBPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, FLGJCMOKHGL, string> BHDCAKFGMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, FLGJCMOKHGL, object> HCGFCHPHOCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, FLGJCMOKHGL, object> NKECFPHMJBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, FLGJCMOKHGL, object> JGCJJNFBELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly HKOGNDMFMKL LENKIMNIFEN;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x330BEA0", Offset = "0x330B2A0", VA = "0x18330BEA0")]
			public KOHDMPOOAHJ(Type HHDFIJECABM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2227290", Offset = "0x2226690", VA = "0x182227290")]
			private static T CIHMMOMKKHB<T>(DynamicMethod FMMAOEIKCHM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x330BCB0", Offset = "0x330B0B0", VA = "0x18330BCB0")]
			private static MethodInfo NENGCEJNOEJ(Type HHDFIJECABM, string AFIDHHDMHNB, Type[] HBIOPPCGKCJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KOHDMPOOAHJ> OGKLKIBPNIK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::DPINBBJCAPM<KOHDMPOOAHJ> NGIIGJIEPPA;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3310250", Offset = "0x330F650", VA = "0x183310250")]
		static PNCDFEEGBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x33101D0", Offset = "0x330F5D0", VA = "0x1833101D0")]
		private static KOHDMPOOAHJ EMHHNHGGMLN(Type HHDFIJECABM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x330FF50", Offset = "0x330F350", VA = "0x18330FF50")]
		public static void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x33100C0", Offset = "0x330F4C0", VA = "0x1833100C0")]
		public static void EIOHABDHFHD(Type HHDFIJECABM, ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class LALOICILABC
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] KCNEECJJIPG;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x330DA30", Offset = "0x330CE30", VA = "0x18330DA30")]
		public static byte[] GPHHBMKNIJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FLGJCMOKHGL FOIHJKJOHED;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] EMCKAKGICCL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] MKHKHJFGLEM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FLGJCMOKHGL PHMKEIMJNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3307BC0", Offset = "0x3306FC0", VA = "0x183307BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3307CD0", Offset = "0x33070D0", VA = "0x183307CD0")]
	public static void CDIGHKOHLMK(FLGJCMOKHGL ICEFPGFDNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F21030", Offset = "0x2F20430", VA = "0x182F21030")]
	public static string IFEGHLHKEIE<T>(T MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F20ED0", Offset = "0x2F202D0", VA = "0x182F20ED0")]
	public static string IFEGHLHKEIE<T>(T MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x221DCA0", Offset = "0x221D0A0", VA = "0x18221DCA0")]
	public static T NJNBMDCLBPB<T>(string AKPGNFAINCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x221DD20", Offset = "0x221D120", VA = "0x18221DD20")]
	public static T NJNBMDCLBPB<T>(string AKPGNFAINCF, FLGJCMOKHGL ICEFPGFDNNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x221DC20", Offset = "0x221D020", VA = "0x18221DC20")]
	public static T NJNBMDCLBPB<T>(byte[] MFCIHENGNMD, FLGJCMOKHGL ICEFPGFDNNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x221DDF0", Offset = "0x221D1F0", VA = "0x18221DDF0")]
	public static T NJNBMDCLBPB<T>(byte[] MFCIHENGNMD, int CBMNFDDLNMI, FLGJCMOKHGL ICEFPGFDNNM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BEGGCFIPLFA : byte
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
public struct ELHPCBKIJOC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NICNIBCCJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] KCNEECJJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CBMNFDDLNMI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OPGHMCFKMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4A0", Offset = "0x7FD8A0", VA = "0x1807FE4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x33043A0", Offset = "0x33037A0", VA = "0x1833043A0")]
	public void DGJJMBINKFL(int CBMNFDDLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x33DB9B0", Offset = "0x33DADB0", VA = "0x1833DB9B0")]
	public static byte[] GLPBDGMPJJO(string EBNLILMGBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x33DB350", Offset = "0x33DA750", VA = "0x1833DB350")]
	public static byte[] DJJPGGOGAMI(string EBNLILMGBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x33DBCB0", Offset = "0x33DB0B0", VA = "0x1833DBCB0")]
	public static byte[] LHHOMJLACLN(string EBNLILMGBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x33DBDE0", Offset = "0x33DB1E0", VA = "0x1833DBDE0")]
	public static byte[] LLAHEGIHGAA(string EBNLILMGBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCCE920", Offset = "0xCCDD20", VA = "0x180CCE920")]
	public ELHPCBKIJOC(byte[] HJMOINEOBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x33DBAC0", Offset = "0x33DAEC0", VA = "0x1833DBAC0")]
	public ArraySegment<byte> GPHHBMKNIJD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x33DB080", Offset = "0x33DA480", VA = "0x1833DB080")]
	public byte[] BBEFHJBGAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x33DC1C0", Offset = "0x33DB5C0", VA = "0x1833DC1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33DBF70", Offset = "0x33DB370", VA = "0x1833DBF70")]
	public void OBNPLLBBJNA(int KIAFFMCDIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x33DB480", Offset = "0x33DA880", VA = "0x1833DB480")]
	public void EDBPCBHJCGJ(byte[] ILNHDAGICPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFF0", Offset = "0x33DA3F0", VA = "0x1833DAFF0")]
	public void AILOMLOINOL(byte ILNHDAGICPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x33DB030", Offset = "0x33DA430", VA = "0x1833DB030")]
	public void ALEFNGHAGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x33DC0D0", Offset = "0x33DB4D0", VA = "0x1833DC0D0")]
	public void PGAFCIKOPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x33DBC60", Offset = "0x33DB060", VA = "0x1833DBC60")]
	public void LCMICBLFINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x33DAFA0", Offset = "0x33DA3A0", VA = "0x1833DAFA0")]
	public void ABJKHDCNMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x33DC170", Offset = "0x33DB570", VA = "0x1833DC170")]
	public void PPJDMDEONBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x33DC000", Offset = "0x33DB400", VA = "0x1833DC000")]
	public void OPNLHKBPLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33DBB70", Offset = "0x33DAF70", VA = "0x1833DBB70")]
	public void HPLIDCLDBGJ(string EBNLILMGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33DC120", Offset = "0x33DB520", VA = "0x1833DC120")]
	public void PIMJPELEGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x33DB4E0", Offset = "0x33DA8E0", VA = "0x1833DB4E0")]
	public void EDNCIKHAHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x33DB160", Offset = "0x33DA560", VA = "0x1833DB160")]
	public void DEFABHPAEEP(bool MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x33DC050", Offset = "0x33DB450", VA = "0x1833DC050")]
	public void PBACEHFFGPL(float MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x33DBF80", Offset = "0x33DB380", VA = "0x1833DBF80")]
	public void OJGEBMIEPNI(double MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x33DB130", Offset = "0x33DA530", VA = "0x1833DB130")]
	public void CNIIKOIKGIG(byte MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x33DBA90", Offset = "0x33DAE90", VA = "0x1833DBA90")]
	public void GPHGOAAJJCK(ushort MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x33DB100", Offset = "0x33DA500", VA = "0x1833DB100")]
	public void CHAFMNNOKAP(uint MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x33DBF40", Offset = "0x33DB340", VA = "0x1833DBF40")]
	public void MDNMMFDHBBF(ulong MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x33DBC30", Offset = "0x33DB030", VA = "0x1833DBC30")]
	public void JEMPAKDHJLE(sbyte MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x33DB980", Offset = "0x33DAD80", VA = "0x1833DB980")]
	public void GGHCIGMHLBO(short MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x33DBC00", Offset = "0x33DB000", VA = "0x1833DBC00")]
	public void ICCFIAHAIKL(int MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x33DBBD0", Offset = "0x33DAFD0", VA = "0x1833DBBD0")]
	public void IAOKJJNFAGJ(long MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x33DB5B0", Offset = "0x33DA9B0", VA = "0x1833DB5B0")]
	public void GDMNAMFJCOD(string MGNFAPLJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EJCOJELANCF : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class OIAHDLJMPCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3944FF0", Offset = "0x39443F0", VA = "0x183944FF0")]
		static OIAHDLJMPCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private EJCOJELANCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class HIOAEONDGNK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> OIFEGLIKKPC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x33EA8C0", Offset = "0x33E9CC0", VA = "0x1833EA8C0")]
	static HIOAEONDGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x33EA360", Offset = "0x33E9760", VA = "0x1833EA360")]
	internal static object LDEMEFLNBBI(Type HFMCMEGOMAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FHJEOBHDNDP : global::BFPOGOEJBPA<Vector2>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33DE3E0", Offset = "0x33DD7E0", VA = "0x1833DE3E0")]
	public FHJEOBHDNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x33DE0F0", Offset = "0x33DD4F0", VA = "0x1833DE0F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Vector2 MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33DE260", Offset = "0x33DD660", VA = "0x1833DE260", Slot = "5")]
	public Vector2 NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LGNPODFKKLO : global::BFPOGOEJBPA<Vector3>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4226B70", Offset = "0x4225F70", VA = "0x184226B70")]
	public LGNPODFKKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4226860", Offset = "0x4225C60", VA = "0x184226860", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Vector3 MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4226980", Offset = "0x4225D80", VA = "0x184226980", Slot = "5")]
	public Vector3 NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GEDKDJAJAKI : global::BFPOGOEJBPA<Vector4>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x33E40D0", Offset = "0x33E34D0", VA = "0x1833E40D0")]
	public GEDKDJAJAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x33E3C30", Offset = "0x33E3030", VA = "0x1833E3C30", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Vector4 MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x33E3EA0", Offset = "0x33E32A0", VA = "0x1833E3EA0", Slot = "5")]
	public Vector4 NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BEIGGJEDIIJ : global::BFPOGOEJBPA<Quaternion>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3303510", Offset = "0x3302910", VA = "0x183303510")]
	public BEIGGJEDIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3303040", Offset = "0x3302440", VA = "0x183303040", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Quaternion MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3303190", Offset = "0x3302590", VA = "0x183303190", Slot = "5")]
	public Quaternion NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JEOGLGAOFGK : global::BFPOGOEJBPA<Color>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4223980", Offset = "0x4222D80", VA = "0x184223980")]
	public JEOGLGAOFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3303040", Offset = "0x3302440", VA = "0x183303040", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Color MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4223750", Offset = "0x4222B50", VA = "0x184223750", Slot = "5")]
	public Color NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GEJLLIGPEFO : global::BFPOGOEJBPA<Bounds>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x33E4D30", Offset = "0x33E4130", VA = "0x1833E4D30")]
	public GEJLLIGPEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33E4790", Offset = "0x33E3B90", VA = "0x1833E4790", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Bounds MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x33E4A90", Offset = "0x33E3E90", VA = "0x1833E4A90", Slot = "5")]
	public Bounds NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class OOEINBEMDKI : global::BFPOGOEJBPA<Rect>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DLPPPOGJIGO KPOPDJLIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] IOKEOKHKHOH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x422E1C0", Offset = "0x422D5C0", VA = "0x18422E1C0")]
	public OOEINBEMDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x422DDF0", Offset = "0x422D1F0", VA = "0x18422DDF0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Rect MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x422DF60", Offset = "0x422D360", VA = "0x18422DF60", Slot = "5")]
	public Rect NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class CALCLCCBKPC : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class FBIBEEBBABE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1F44A10", Offset = "0x1F43E10", VA = "0x181F44A10")]
		static FBIBEEBBABE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private CALCLCCBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class IAKANGIGNDI : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class GOEOCDBEHHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8060", Offset = "0x2FA7460", VA = "0x182FA8060")]
		static GOEOCDBEHHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class JDJEGJEBICF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> CMKODFNMAPN;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x33ECE00", Offset = "0x33EC200", VA = "0x1833ECE00")]
		internal static object LDEMEFLNBBI(Type HFMCMEGOMAH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private IAKANGIGNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class AOIOBPEPFEJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GMDFOIMNDJN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A11A00", Offset = "0x3A10E00", VA = "0x183A11A00")]
		static GMDFOIMNDJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AOIOBPEPFEJ KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool HNFJCFLOFIA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static NPKKFPKKFLD[] OPJGMLAHIAN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static FLGJCMOKHGL[] KGKGHAAEKDG;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private AOIOBPEPFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33022E0", Offset = "0x33016E0", VA = "0x1833022E0")]
	public static void GHONEEDGEPN(params FLGJCMOKHGL[] KGKGHAAEKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33023A0", Offset = "0x33017A0", VA = "0x1833023A0")]
	public static void GHONEEDGEPN(params NPKKFPKKFLD[] OPJGMLAHIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3302460", Offset = "0x3301860", VA = "0x183302460")]
	public static void HGLLIMKHAPB(NPKKFPKKFLD[] OPJGMLAHIAN, FLGJCMOKHGL[] KGKGHAAEKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class MBDIFIGENAB : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class KFNKEGLFMPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0F50", Offset = "0x1EF0350", VA = "0x181EF0F50")]
		static KFNKEGLFMPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private MBDIFIGENAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LKOIDGJLGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FLGJCMOKHGL NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly FLGJCMOKHGL JJOGHJGJGIE;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FLGJCMOKHGL CEAJEGAGEAO;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FLGJCMOKHGL DIOLBIBNIFN;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly FLGJCMOKHGL EDHBLCGMODH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FLGJCMOKHGL DDJKHPIPDCE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FLGJCMOKHGL LJELLCCPPBH;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FLGJCMOKHGL JMIJMBIHKEE;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FLGJCMOKHGL OEIELHCGFMG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FLGJCMOKHGL IMOIIIHIEKP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FLGJCMOKHGL NIMCIAHNMFN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FLGJCMOKHGL OEOAPOMBEMK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BCFJCBLAPAG
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FLGJCMOKHGL NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FLGJCMOKHGL HPBNBHNDBMB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DJDEDBICHKP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly FLGJCMOKHGL NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FLGJCMOKHGL JJOGHJGJGIE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly FLGJCMOKHGL CEAJEGAGEAO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FLGJCMOKHGL DIOLBIBNIFN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly FLGJCMOKHGL EDHBLCGMODH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly FLGJCMOKHGL DDJKHPIPDCE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly FLGJCMOKHGL LJELLCCPPBH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly FLGJCMOKHGL JMIJMBIHKEE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly FLGJCMOKHGL OEIELHCGFMG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FLGJCMOKHGL IMOIIIHIEKP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly FLGJCMOKHGL NIMCIAHNMFN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly FLGJCMOKHGL OEOAPOMBEMK;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class FPGFGANPMBC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> CMKODFNMAPN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x33E0A00", Offset = "0x33DFE00", VA = "0x1833E0A00")]
	internal static object LDEMEFLNBBI(Type HFMCMEGOMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x33E09C0", Offset = "0x33DFDC0", VA = "0x1833E09C0")]
	private static object DMFIFKLEOEF(Type IPADNBNCCOI, Type[] MKMEMHPCMNB, params object[] HBIOPPCGKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OALMFLHPAML : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class CAGEDBDGAAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3FBAA50", Offset = "0x3FB9E50", VA = "0x183FBAA50")]
		static CAGEDBDGAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x422BCB0", Offset = "0x422B0B0", VA = "0x18422BCB0")]
	static OALMFLHPAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private OALMFLHPAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class AMGBJDBJJNJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class FLJOCGLDNBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D0B0", Offset = "0x3A0C4B0", VA = "0x183A0D0B0")]
		static FLJOCGLDNBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x33021F0", Offset = "0x33015F0", VA = "0x1833021F0")]
	static AMGBJDBJJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private AMGBJDBJJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class GJMEBBHNKOI : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DKOLFOJMLAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F322B0", Offset = "0x2F316B0", VA = "0x182F322B0")]
		static DKOLFOJMLAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x33E53D0", Offset = "0x33E47D0", VA = "0x1833E53D0")]
	static GJMEBBHNKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private GJMEBBHNKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CILDACEJOFJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class OBCKEELKLII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D7D0", Offset = "0x1F4CBD0", VA = "0x181F4D7D0")]
		static OBCKEELKLII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3307690", Offset = "0x3306A90", VA = "0x183307690")]
	static CILDACEJOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private CILDACEJOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class AAHDIGFPOBE : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class DEAPAKMMOAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3388440", Offset = "0x3387840", VA = "0x183388440")]
		static DEAPAKMMOAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x32F8CA0", Offset = "0x32F80A0", VA = "0x1832F8CA0")]
	static AAHDIGFPOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private AAHDIGFPOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BPNANHOBOCG : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class LDLEPGJAJBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2220", Offset = "0x3BD1620", VA = "0x183BD2220")]
		static LDLEPGJAJBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly HCANHEBHGME HGDLPLJMDOE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3306F10", Offset = "0x3306310", VA = "0x183306F10")]
	static BPNANHOBOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private BPNANHOBOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class EHAIFAANDJK : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class LBJFOAFJIIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
		static LBJFOAFJIIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EHAIFAANDJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class HNHMGBCHHCH : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class GDPMPJAGAEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6840", Offset = "0x2FA5C40", VA = "0x182FA6840")]
		static GDPMPJAGAEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HNHMGBCHHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class IDMDMPKHFJB : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class KFAPODHIPJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2FB50C0", Offset = "0x2FB44C0", VA = "0x182FB50C0")]
		static KFAPODHIPJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public IDMDMPKHFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class OEMFMABAGDN : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class BLJIJLEFBAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6C90", Offset = "0x3FB6090", VA = "0x183FB6C90")]
		static BLJIJLEFBAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OEMFMABAGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class NCNIDOCJEOH : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class OGMMCHJHHNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9170", Offset = "0x2EB8570", VA = "0x182EB9170")]
		static OGMMCHJHHNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public NCNIDOCJEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class LKJCCMFDJHP : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class EGIDLDJIACP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1E24A10", Offset = "0x1E23E10", VA = "0x181E24A10")]
		static EGIDLDJIACP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> LFBLFCFMFDH;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool LIJLAKMAJPF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public LKJCCMFDJHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class ACHLPLNGNOA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DPCMBCDGJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public BDOPNAEIOEE PLNECEJCNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder AGEHBOEMADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PELGNKFNDFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class JIGCGACDKIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PPBGBLOHNAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LHHOMJLACLN;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo DJJPGGOGAMI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo LLAHEGIHGAA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo GLPBDGMPJJO;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo EDNCIKHAHGN;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo EDBPCBHJCGJ;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo LCMICBLFINA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo ABJKHDCNMFB;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo PPJDMDEONBM;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3310340", Offset = "0x330F740", VA = "0x183310340")]
			static PPBGBLOHNAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class OBJFCGKGIAE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo DKDCDDPPOLM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo PFJJKJDOEAN;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo CFKAFHJALDP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo EDMLEKCDMFA;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo OEGFPPMJHLC;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo LGCKFCEFPOI;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo CFMEKAFAPHK;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x330EF90", Offset = "0x330E390", VA = "0x18330EF90")]
			static OBJFCGKGIAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class BOFMEFPCDKA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo DNHPLAKEEJL;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo CBEEOJCLCCB;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo GEGJMHDMCKJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo GAGELACHAEP;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo ENNEJMHBAOG;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FNEJHCFHLNM;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo EPMCLJHGHLB;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo PFAIHGFCJLH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo KLLMKIHIIGL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo AIKCKBAGIMC;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo HODDJOKONOK;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo FEHANPKCPAL;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DFDBDJGCDJG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo HOMLNEFPLOP;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x330A3A0", Offset = "0x33097A0", VA = "0x18330A3A0")]
		public static MethodInfo EIOHABDHFHD(Type HHDFIJECABM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x330A630", Offset = "0x3309A30", VA = "0x18330A630")]
		public static MethodInfo NJNBMDCLBPB(Type HHDFIJECABM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x330A280", Offset = "0x3309680", VA = "0x18330A280")]
		public static MethodInfo DEMDPKEBDIE(Type HHDFIJECABM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FOLJLNMONEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<BDOPNAEIOEE, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public FOLJLNMONEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DBIGBBOGOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FOLJLNMONEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public DBIGBBOGOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3308540", Offset = "0x3307940", VA = "0x183308540")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3308580", Offset = "0x3307980", VA = "0x183308580")]
		internal bool <BuildType>b__2(int index, BDOPNAEIOEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DFKOLFLAHOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FOLJLNMONEC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public DFKOLFLAHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3308620", Offset = "0x3307A20", VA = "0x183308620")]
		internal bool <BuildType>b__3(int index, BDOPNAEIOEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OOOMINBLEPJ
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public OOOMINBLEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x330FD20", Offset = "0x330F120", VA = "0x18330FD20")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AAMIJFMNNEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public AAMIJFMNNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x32F8D90", Offset = "0x32F8190", VA = "0x1832F8D90")]
		internal bool <BuildAnonymousFormatter>b__2(BDOPNAEIOEE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CAFEDCBCJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OOOMINBLEPJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public CAFEDCBCJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3307000", Offset = "0x3306400", VA = "0x183307000")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3307010", Offset = "0x3306410", VA = "0x183307010")]
		internal bool <BuildAnonymousFormatter>b__6(int index, BDOPNAEIOEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GNOANCBKEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public OOOMINBLEPJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public GNOANCBKEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3309910", Offset = "0x3308D10", VA = "0x183309910")]
		internal bool <BuildAnonymousFormatter>b__7(int index, BDOPNAEIOEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GFMPJMGIDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public GFMPJMGIDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x55ACC0", Offset = "0x55A0C0", VA = "0x18055ACC0")]
		internal Label <BuildSerialize>b__1(BDOPNAEIOEE _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PJJKBHIICPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DPCMBCDGJMP[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, BDOPNAEIOEE, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public LGAHLFCBKPD argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public LGAHLFCBKPD argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public PJJKBHIICPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x330FE20", Offset = "0x330F220", VA = "0x18330FE20")]
		internal DPCMBCDGJMP <BuildDeserialize>b__0(BDOPNAEIOEE item)
		{
			return default(DPCMBCDGJMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class IFMLPFJLBIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public PJJKBHIICPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public IFMLPFJLBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3309F30", Offset = "0x3309330", VA = "0x183309F30")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x330A1E0", Offset = "0x33095E0", VA = "0x18330A1E0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class HENMCDEIKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BDOPNAEIOEE item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public HENMCDEIKCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x19441B0", Offset = "0x19435B0", VA = "0x1819441B0")]
		internal bool <EmitNewObject>b__0(DPCMBCDGJMP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class BHABGJBKILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BDOPNAEIOEE item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public BHABGJBKILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x19441B0", Offset = "0x19435B0", VA = "0x1819441B0")]
		internal bool <EmitNewObject>b__2(DPCMBCDGJMP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex CJIEMDHJGNC;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int BCEONMMHAPM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> NOMEMHKAOBM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> AIFLJFCFKIG;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BAD0", Offset = "0x2F1AED0", VA = "0x182F1BAD0")]
	public static object KENAKBCILNA<T>(HCANHEBHGME HGDLPLJMDOE, FLGJCMOKHGL LMFOICGLHFK, Func<string, string> LFBLFCFMFDH, bool LIJLAKMAJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x273CF60", Offset = "0x273C360", VA = "0x18273CF60")]
	public static object DDDNDMHGDEF<T>(FLGJCMOKHGL LMFOICGLHFK, Func<string, string> LFBLFCFMFDH, bool LIJLAKMAJPF, bool KGGKCAAOFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x32FF0D0", Offset = "0x32FE4D0", VA = "0x1832FF0D0")]
	private static TypeInfo GFGNJHOCGAI(HCANHEBHGME HGDLPLJMDOE, Type HHDFIJECABM, Func<string, string> LFBLFCFMFDH, bool LIJLAKMAJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x32FB2C0", Offset = "0x32FA6C0", VA = "0x1832FB2C0")]
	public static object CGNPKNHMBBA(Type HHDFIJECABM, Func<string, string> LFBLFCFMFDH, bool LIJLAKMAJPF, bool KGGKCAAOFNM, bool NPIANJCGLOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32FFB70", Offset = "0x32FEF70", VA = "0x1832FFB70")]
	private static Dictionary<BDOPNAEIOEE, FieldInfo> HFHEMMOOCBJ(TypeBuilder PAMKNGANHEA, ONDMLCJMHOL KLNNIKJBGAF, ConstructorInfo PHHPNEPFEIA, FieldBuilder LIJMLGPOLHM, ILGenerator JEJJFLAKDDM, bool LIJLAKMAJPF, bool BDEOBGLBGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x32FCC90", Offset = "0x32FC090", VA = "0x1832FCC90")]
	private static Dictionary<BDOPNAEIOEE, FieldInfo> CNCEJELMDLP(TypeBuilder PAMKNGANHEA, ONDMLCJMHOL KLNNIKJBGAF, ILGenerator JEJJFLAKDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x32F9D60", Offset = "0x32F9160", VA = "0x1832F9D60")]
	private static void ACCGPAMLCAK(Type HHDFIJECABM, ONDMLCJMHOL KLNNIKJBGAF, ILGenerator JEJJFLAKDDM, Action OOEIIMKPDNC, Func<int, BDOPNAEIOEE, bool> PBFPAJCIPKL, bool LIJLAKMAJPF, bool BDEOBGLBGBB, int PJLINHMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x32FEBE0", Offset = "0x32FDFE0", VA = "0x1832FEBE0")]
	private static void FIDCCJJAPOP(TypeInfo HHDFIJECABM, BDOPNAEIOEE LLOKOIDMBDI, ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL, Func<int, BDOPNAEIOEE, bool> PBFPAJCIPKL, LGAHLFCBKPD AJGCNLDPDIN, LGAHLFCBKPD GNJBGJKFNBO, LGAHLFCBKPD KBPFAEDCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x32FD260", Offset = "0x32FC660", VA = "0x1832FD260")]
	private static void CNICBGLFEHM(Type HHDFIJECABM, ONDMLCJMHOL KLNNIKJBGAF, ILGenerator JEJJFLAKDDM, Func<int, BDOPNAEIOEE, bool> PBFPAJCIPKL, bool HFPBEKENNON, int PJLINHMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3300360", Offset = "0x32FF760", VA = "0x183300360")]
	private static void JEJAAMECMAL(ILGenerator JEJJFLAKDDM, DPCMBCDGJMP KLNNIKJBGAF, int DBFCFFLFJDL, Func<int, BDOPNAEIOEE, bool> PBFPAJCIPKL, LGAHLFCBKPD ACCMDMPIIKM, LGAHLFCBKPD KBPFAEDCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x32F90F0", Offset = "0x32F84F0", VA = "0x1832F90F0")]
	private static LocalBuilder ABIKMJDMGJN(ILGenerator JEJJFLAKDDM, Type HHDFIJECABM, ONDMLCJMHOL KLNNIKJBGAF, DPCMBCDGJMP[] OEOCMOBPBHJ, bool JBDIMKJLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x32FE510", Offset = "0x32FD910", VA = "0x1832FE510")]
	private static bool EFPKMEEFOFO(ConstructorInfo JKKKAIMPJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x33001C0", Offset = "0x32FF5C0", VA = "0x1833001C0")]
	private static bool HIHDBFNDIIH(Type HHDFIJECABM, out Type MFFECEDANLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void OOLOIDBOGMD<T>(byte[][] LIJMLGPOLHM, object[] OCIMJCGKOPB, ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL ICEFPGFDNNM);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T OFJMKJJPNAO<T>(object[] OCIMJCGKOPB, ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL ICEFPGFDNNM);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BNNMEKPDHKB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class LGNONCJHBEG : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class AFGOAMFCMLE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D2B0", Offset = "0x1E1C6B0", VA = "0x181E1D2B0")]
		static AFGOAMFCMLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private LGNONCJHBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class HKBOGGIBMJP : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class PGNJLHIKHJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x37552E0", Offset = "0x37546E0", VA = "0x1837552E0")]
		static PGNJLHIKHJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private HKBOGGIBMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class ICFFNHJFPPI
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly FLGJCMOKHGL[] FOGCBDHDAIK;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class PCKPFLOKBPB : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class LOKCPMONEOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB700", Offset = "0x3CBAB00", VA = "0x183CBB700")]
		static LOKCPMONEOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class INMHNAMGDLF : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class DEHGJJFKLGI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3CB7870", Offset = "0x3CB6C70", VA = "0x183CB7870")]
			static DEHGJJFKLGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private INMHNAMGDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private PCKPFLOKBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class JHPNOENBFGJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class IMJNAEGCPCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x24B5D90", Offset = "0x24B5190", VA = "0x1824B5D90")]
		static IMJNAEGCPCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class LHPPHPIPHKA : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class FANABEKKNNP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4270AD0", Offset = "0x426FED0", VA = "0x184270AD0")]
			static FANABEKKNNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private LHPPHPIPHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private JHPNOENBFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class FJOHENFOMMP : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class FIDKKOGHJFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CDA0", Offset = "0x3E3C1A0", VA = "0x183E3CDA0")]
		static FIDKKOGHJFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class MCBPIDMPFPN : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class KAGDCCKOJDM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3E4C1F0", Offset = "0x3E4B5F0", VA = "0x183E4C1F0")]
			static KAGDCCKOJDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private MCBPIDMPFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private FJOHENFOMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class KEEPFAHLGNP : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class ODNNLPGCINB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2C6B2A0", Offset = "0x2C6A6A0", VA = "0x182C6B2A0")]
		static ODNNLPGCINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class LFBJCIDNOBF : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DDAJEPIONAK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2C5C5D0", Offset = "0x2C5B9D0", VA = "0x182C5C5D0")]
			static DDAJEPIONAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private LFBJCIDNOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private KEEPFAHLGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OGMDFILLAJN : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class CHJDAGOOMFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB7D0", Offset = "0x3FBABD0", VA = "0x183FBB7D0")]
		static CHJDAGOOMFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class OJNJODCOBKE : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class PANKBIMIDHF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3FD2590", Offset = "0x3FD1990", VA = "0x183FD2590")]
			static PANKBIMIDHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private OJNJODCOBKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private OGMDFILLAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class JMIBLIGCGGL : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class FNCMJABFHOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4276510", Offset = "0x4275910", VA = "0x184276510")]
		static FNCMJABFHOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class PKKEMNKOFNE : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class JMDJEDGDIEL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42828C0", Offset = "0x4281CC0", VA = "0x1842828C0")]
			static JMDJEDGDIEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private PKKEMNKOFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private JMIBLIGCGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FFFPJGDGIAP : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class OOFOCOABBDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7910", Offset = "0x3EC6D10", VA = "0x183EC7910")]
		static OOFOCOABBDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class MMLCFPOFLAA : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class EMGHLHIBICL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3EB7E30", Offset = "0x3EB7230", VA = "0x183EB7E30")]
			static EMGHLHIBICL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private MMLCFPOFLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private FFFPJGDGIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class PKDGNPFGGBO : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class BKLJJLGNDPM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F692E0", Offset = "0x3F686E0", VA = "0x183F692E0")]
		static BKLJJLGNDPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class ACDIDLIHDKP : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NKLALPHPEBA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3658900", Offset = "0x3657D00", VA = "0x183658900")]
			static NKLALPHPEBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private ACDIDLIHDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private PKDGNPFGGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class BOLHFNGBBII : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class ECKBMKGOGFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC8F0", Offset = "0x3BCBCF0", VA = "0x183BCC8F0")]
		static ECKBMKGOGFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class MEHDJMHLFPJ : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class MLHCKMNBACO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3BD64B0", Offset = "0x3BD58B0", VA = "0x183BD64B0")]
			static MLHCKMNBACO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private MEHDJMHLFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private BOLHFNGBBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class BJKLKPOLAEJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class CEHEOIOGAJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F2D0", Offset = "0x3E9E6D0", VA = "0x183E9F2D0")]
		static CEHEOIOGAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OJDDKLIFIAK : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DGIDMAGFDCN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3EA2E10", Offset = "0x3EA2210", VA = "0x183EA2E10")]
			static DGIDMAGFDCN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private OJDDKLIFIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private BJKLKPOLAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class ICIJOCJKFIJ : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class LLGEACPAFJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2FB9190", Offset = "0x2FB8590", VA = "0x182FB9190")]
		static LLGEACPAFJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class EBGCIBCLIHM : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class OIKHGNGBNKC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2FBB860", Offset = "0x2FBAC60", VA = "0x182FBB860")]
			static OIKHGNGBNKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private EBGCIBCLIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private ICIJOCJKFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class OFIKCJLPOAK : FLGJCMOKHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class ECICCIOBMHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4730", Offset = "0x3FC3B30", VA = "0x183FC4730")]
		static ECICCIOBMHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class MBGKHDDAHPF : FLGJCMOKHGL
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class KKMFNACMHMO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::BFPOGOEJBPA<T> APPBFPFEAKL;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3FC9D60", Offset = "0x3FC9160", VA = "0x183FC9D60")]
			static KKMFNACMHMO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly FLGJCMOKHGL KFKKKAOCIAC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly FLGJCMOKHGL[] KGKGHAAEKDG;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private MBGKHDDAHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
		public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly FLGJCMOKHGL KFKKKAOCIAC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::BFPOGOEJBPA<object> HIHABNIPDIG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	private OFIKCJLPOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x208D610", Offset = "0x208CA10", VA = "0x18208D610", Slot = "4")]
	public global::BFPOGOEJBPA<T> LDEMEFLNBBI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct DHMKJDPNKKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] CGLNLPJNDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int OMJCACLPBAH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2341850", Offset = "0x2340C50", VA = "0x182341850")]
	public DHMKJDPNKKL(int IDNCCJPLHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2341780", Offset = "0x2340B80", VA = "0x182341780")]
	public void KCLLGEJMGAB(T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2341540", Offset = "0x2340940", VA = "0x182341540")]
	public T[] CLPJPLOKDGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class IJLJGBDJBNE : global::FAFAPEFJKCK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly IJLJGBDJBNE NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x42217E0", Offset = "0x4220BE0", VA = "0x1842217E0")]
	public IJLJGBDJBNE(int HNJCOGHDDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class FAFAPEFJKCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int HNJCOGHDDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object GFDGGBJPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int DBFCFFLFJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] JABPKKOFAGB;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE2A0", Offset = "0x3EBD6A0", VA = "0x183EBE2A0")]
	public FAFAPEFJKCK(int HNJCOGHDDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC560", Offset = "0x3EBB960", VA = "0x183EBC560")]
	public T[] GCHAJGDIOAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD520", Offset = "0x3EBC920", VA = "0x183EBD520")]
	public void JEFMGOGHGPO(T[] INALBAMOJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class DLPPPOGJIGO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class LMGPDFJOAGF : IComparable<LMGPDFJOAGF>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class FACAMBCLIKD : IEnumerable<LMGPDFJOAGF>, IEnumerable, IEnumerator<LMGPDFJOAGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private LMGPDFJOAGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public LMGPDFJOAGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private LMGPDFJOAGF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
			[DebuggerHidden]
			public FACAMBCLIKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x33DD770", Offset = "0x33DCB70", VA = "0x1833DD770", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x33DD8A0", Offset = "0x33DCCA0", VA = "0x1833DD8A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x33DD800", Offset = "0x33DCC00", VA = "0x1833DD800", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LMGPDFJOAGF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x33DD800", Offset = "0x33DCC00", VA = "0x1833DD800", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class DGMHJILBBCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public DGMHJILBBCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x55ACC0", Offset = "0x55A0C0", VA = "0x18055ACC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x55ACC0", Offset = "0x55A0C0", VA = "0x18055ACC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly LMGPDFJOAGF[] OIAAGGGBJNF;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] IIPPJJBMEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong DCBIHGMJIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int IKGDHNEELOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string EHKFHELMBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private LMGPDFJOAGF[] GGDGDJLKODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] BPFANKLPJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int LFFBMCJGPOI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BFEAGIDEOEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA81F20", Offset = "0xA81320", VA = "0x180A81F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x330ED50", Offset = "0x330E150", VA = "0x18330ED50")]
		public LMGPDFJOAGF(ulong KACNOLACOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x330DC10", Offset = "0x330D010", VA = "0x18330DC10")]
		public LMGPDFJOAGF KCLLGEJMGAB(ulong KACNOLACOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x330DE00", Offset = "0x330D200", VA = "0x18330DE00")]
		public LMGPDFJOAGF KCLLGEJMGAB(ulong KACNOLACOBJ, int MGNFAPLJAOB, string EHKFHELMBCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x330EB20", Offset = "0x330DF20", VA = "0x18330EB20")]
		public LMGPDFJOAGF PGHPMBMKINM(byte[] ADHJDFLGPNE, ref int CBMNFDDLNMI, ref int PHEEEEKAHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x330EA30", Offset = "0x330DE30", VA = "0x18330EA30")]
		internal static int KGNLHCAMPBB(ulong[] INALBAMOJHE, int DBFCFFLFJDL, int EIKDAKIMGCJ, ulong MGNFAPLJAOB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x330DAB0", Offset = "0x330CEB0", VA = "0x18330DAB0", Slot = "4")]
		public int CompareTo(LMGPDFJOAGF OGCBGOIPCGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x330EAB0", Offset = "0x330DEB0", VA = "0x18330EAB0")]
		[IteratorStateMachine(typeof(FACAMBCLIKD))]
		public IEnumerable<LMGPDFJOAGF> LPIBELOJPAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x330DAE0", Offset = "0x330CEE0", VA = "0x18330DAE0")]
		public void HIDEJAPFGPO(ILGenerator JEJJFLAKDDM, LocalBuilder ADHJDFLGPNE, LocalBuilder PHEEEEKAHPF, LocalBuilder KACNOLACOBJ, Action<KeyValuePair<string, int>> DJMEFNFCGIC, Action JNGKBEMKGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x330DE50", Offset = "0x330D250", VA = "0x18330DE50")]
		private static void KENGENCANDK(ILGenerator JEJJFLAKDDM, LocalBuilder ADHJDFLGPNE, LocalBuilder PHEEEEKAHPF, LocalBuilder KACNOLACOBJ, Action<KeyValuePair<string, int>> DJMEFNFCGIC, Action JNGKBEMKGAK, LMGPDFJOAGF[] GGDGDJLKODN, int LFFBMCJGPOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class OGEHGDDIPLH : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<LMGPDFJOAGF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<LMGPDFJOAGF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<LMGPDFJOAGF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private LMGPDFJOAGF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x553000", Offset = "0x552400", VA = "0x180553000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EED90", Offset = "0x33EE190", VA = "0x1833EED90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x981440", Offset = "0x980840", VA = "0x180981440")]
		[DebuggerHidden]
		public OGEHGDDIPLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x33EEDE0", Offset = "0x33EE1E0", VA = "0x1833EEDE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x33EE8C0", Offset = "0x33EDCC0", VA = "0x1833EE8C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x33EEEE0", Offset = "0x33EE2E0", VA = "0x1833EEEE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x33EEF30", Offset = "0x33EE330", VA = "0x1833EEF30")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x33EED40", Offset = "0x33EE140", VA = "0x1833EED40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x33EECA0", Offset = "0x33EE0A0", VA = "0x1833EECA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x33EECA0", Offset = "0x33EE0A0", VA = "0x1833EECA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly LMGPDFJOAGF PGMAAINPEGN;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3309660", Offset = "0x3308A60", VA = "0x183309660")]
	public DLPPPOGJIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x33090A0", Offset = "0x33084A0", VA = "0x1833090A0")]
	public void KCLLGEJMGAB(byte[] MFCIHENGNMD, int MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3309430", Offset = "0x3308830", VA = "0x183309430")]
	public bool NCGDALPCHMG(ArraySegment<byte> KACNOLACOBJ, out int MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3309580", Offset = "0x3308980", VA = "0x183309580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x33091B0", Offset = "0x33085B0", VA = "0x1833091B0")]
	private static void LOMKJBAHCFB(IEnumerable<LMGPDFJOAGF> GGDGDJLKODN, StringBuilder PBHAAAHBLGA, int BDNGLGIDOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3308FA0", Offset = "0x33083A0", VA = "0x183308FA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3308FA0", Offset = "0x33083A0", VA = "0x183308FA0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x33094E0", Offset = "0x33088E0", VA = "0x1833094E0")]
	[IteratorStateMachine(typeof(OGEHGDDIPLH))]
	private static IEnumerable<KeyValuePair<string, int>> PBPPKAGONJO(IEnumerable<LMGPDFJOAGF> GGDGDJLKODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3309550", Offset = "0x3308950", VA = "0x183309550")]
	public void PHODBLJEOGO(ILGenerator JEJJFLAKDDM, LocalBuilder ADHJDFLGPNE, LocalBuilder PHEEEEKAHPF, LocalBuilder KACNOLACOBJ, Action<KeyValuePair<string, int>> DJMEFNFCGIC, Action JNGKBEMKGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class AKALHPIEPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo OHAIEKPMHBH;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3301160", Offset = "0x3300560", VA = "0x183301160")]
	public static ulong MLDELGEFCFD(byte[] MFCIHENGNMD, ref int CBMNFDDLNMI, ref int PHEEEEKAHPF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class ACDOJPNAJCO
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x32F8FD0", Offset = "0x32F83D0", VA = "0x1832F8FD0")]
	public static void OBNPLLBBJNA(ref byte[] MFCIHENGNMD, int CBMNFDDLNMI, int KIAFFMCDIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x32F8DF0", Offset = "0x32F81F0", VA = "0x1832F8DF0")]
	public static void IAENNEGKGEJ(ref byte[] INALBAMOJHE, int KFHFOADDGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x32F8EE0", Offset = "0x32F82E0", VA = "0x1832F8EE0")]
	public static byte[] LMIAJFHBHOH(byte[] MGCDCHPLPGJ, int KFHFOADDGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class EJINCCNDCEM
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x33DAF10", Offset = "0x33DA310", VA = "0x1833DAF10")]
	public static bool OMFKDJAGFKD(byte[] HFHENMGIMDJ, int IPCBLEAPCJC, int MPBJPAEOIJN, byte[] FLGKIFPGMPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class PFLDMGPLLOG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct DHABGODONNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] DCBIHGMJIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T IKGDHNEELOA;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x39E1CD0", Offset = "0x39E10D0", VA = "0x1839E1CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DPDKOLOBBHD : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::PFLDMGPLLOG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private DHABGODONNN[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private DHABGODONNN[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1A40800", Offset = "0x1A3FC00", VA = "0x181A40800", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x38DAF60", Offset = "0x38DA360", VA = "0x1838DAF60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C21930", Offset = "0x1C20D30", VA = "0x181C21930")]
		[DebuggerHidden]
		public DPDKOLOBBHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x39E3210", Offset = "0x39E2610", VA = "0x1839E3210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x39E5010", Offset = "0x39E4410", VA = "0x1839E5010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DHABGODONNN[][] OJEECDPFGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong CODOEGJOLNG;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x365EA10", Offset = "0x365DE10", VA = "0x18365EA10")]
	public PFLDMGPLLOG(int KJJBHCMHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x365E950", Offset = "0x365DD50", VA = "0x18365E950")]
	public PFLDMGPLLOG(int KJJBHCMHFJM, float PDKFGBIJKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x39EAD90", Offset = "0x39EA190", VA = "0x1839EAD90")]
	public void KCLLGEJMGAB(byte[] KACNOLACOBJ, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x39EB1B0", Offset = "0x39EA5B0", VA = "0x1839EB1B0")]
	private bool LEPPCKDIKHK(byte[] KACNOLACOBJ, T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x39E9130", Offset = "0x39E8530", VA = "0x1839E9130")]
	public bool BIAHFFMAKML(ArraySegment<byte> KACNOLACOBJ, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x365E8F0", Offset = "0x365DCF0", VA = "0x18365E8F0")]
	private static ulong NNEAADFOEDG(byte[] JEPLLBBBDFO, int CBMNFDDLNMI, int LFFBMCJGPOI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2350130", Offset = "0x234F530", VA = "0x182350130")]
	private static int FJFIFDICKDK(int IFAEIMMIAJL, float PDKFGBIJKBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x365A5F0", Offset = "0x36599F0", VA = "0x18365A5F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::PFLDMGPLLOG<>.DPDKOLOBBHD))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x234AC30", Offset = "0x234A030", VA = "0x18234AC30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class PGHPCGHLFCJ : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] DLLMDJDLGJM;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] OABAAOIGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int ICCPAKBOGEA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BOCMOFAOONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x422E990", Offset = "0x422DD90", VA = "0x18422E990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x422EAF0", Offset = "0x422DEF0", VA = "0x18422EAF0")]
	static PGHPCGHLFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x422ED40", Offset = "0x422E140", VA = "0x18422ED40")]
	public PGHPCGHLFCJ(byte[] POGOGFFAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x422E9E0", Offset = "0x422DDE0", VA = "0x18422E9E0")]
	public OpCode KMPIDFEOJBL()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct FOBJCIMGJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid IKGDHNEELOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte NGCOMHNJILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte FAHLIFHKJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte LKEIEJDANBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte IGGBJJDPOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte DHEBKPLOHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte OLGNPCNCAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte IECCJADOHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte CFKPHGKKPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte DBIMAKBHCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte MAACIEDGMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte NBEGGDHFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte OCEPENMFCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte JIHBIDDOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte KPEMEEPFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte PNNBOPLMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte GBEFIJHDOOF;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] BNNGMCOOHBP;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] BHGNJDFDFLK;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x33E0300", Offset = "0x33DF700", VA = "0x1833E0300")]
	public FOBJCIMGJLF(ref Guid MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x33E0310", Offset = "0x33DF710", VA = "0x1833E0310")]
	public FOBJCIMGJLF(ref ArraySegment<byte> BKMDIGDANHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x33DED40", Offset = "0x33DE140", VA = "0x1833DED40")]
	private static byte EEGKMNNHAAP(byte[] MFCIHENGNMD, int FCCCIOAPCFE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x33E0140", Offset = "0x33DF540", VA = "0x1833E0140")]
	private static byte JKKGOBKFJFN(byte FFOHEAHJJEI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x33DEE00", Offset = "0x33DE200", VA = "0x1833DEE00")]
	public void EKNIIIHDBAK(byte[] KCNEECJJIPG, int CBMNFDDLNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class ECPEFLCDBMI
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x33D8F80", Offset = "0x33D8380", VA = "0x1833D8F80")]
	public static bool FDPEEPNONCC(byte DMIPEKEOIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x33D9CC0", Offset = "0x33D90C0", VA = "0x1833D9CC0")]
	public static bool JEGIJGJFOBM(byte DMIPEKEOIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x33DA950", Offset = "0x33D9D50", VA = "0x1833DA950")]
	public static sbyte OKNBJFHECNL(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x33D8DB0", Offset = "0x33D81B0", VA = "0x1833D8DB0")]
	public static short DEENCJPHFAI(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x33D8E20", Offset = "0x33D8220", VA = "0x1833D8E20")]
	public static int DNKFJCGPCMM(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x33D8C90", Offset = "0x33D8090", VA = "0x1833D8C90")]
	public static long APMFEEADCDG(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x33D8D40", Offset = "0x33D8140", VA = "0x1833D8D40")]
	public static byte BFCDBEKLKAA(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x33D9C50", Offset = "0x33D9050", VA = "0x1833D9C50")]
	public static ushort IDBMLGFPOJC(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x33D8F90", Offset = "0x33D8390", VA = "0x1833D8F90")]
	public static uint GMPBCDALIEO(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x33D9D30", Offset = "0x33D9130", VA = "0x1833D9D30")]
	public static ulong JFIFPFHEIHA(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x33DA860", Offset = "0x33D9C60", VA = "0x1833DA860")]
	public static float OJIJJKHMNDL(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x33D8E90", Offset = "0x33D8290", VA = "0x1833D8E90")]
	public static double EDILBILMAEL(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E40", Offset = "0x33D9240", VA = "0x1833D9E40")]
	public static int MDNMMFDHBBF(ref byte[] KCNEECJJIPG, int CBMNFDDLNMI, ulong MGNFAPLJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x33D9010", Offset = "0x33D8410", VA = "0x1833D9010")]
	public static int IAOKJJNFAGJ(ref byte[] KCNEECJJIPG, int CBMNFDDLNMI, long MGNFAPLJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x33DA610", Offset = "0x33D9A10", VA = "0x1833DA610")]
	public static bool NMDOJNAHNDD(byte[] MFCIHENGNMD, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class LLJLHPIAOIC
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class CJJCJEEKFHH : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public CJJCJEEKFHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4220F80", Offset = "0x4220380", VA = "0x184220F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4220B20", Offset = "0x421FF20", VA = "0x184220B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x42210A0", Offset = "0x42204A0", VA = "0x1842210A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x42210F0", Offset = "0x42204F0", VA = "0x1842210F0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4220F30", Offset = "0x4220330", VA = "0x184220F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4220E80", Offset = "0x4220280", VA = "0x184220E80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4220E80", Offset = "0x4220280", VA = "0x184220E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class GDJNHPIHCKH : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6633E0", Offset = "0x6627E0", VA = "0x1806633E0")]
		[DebuggerHidden]
		public GDJNHPIHCKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x42215A0", Offset = "0x42209A0", VA = "0x1842215A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4221140", Offset = "0x4220540", VA = "0x184221140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x42216C0", Offset = "0x4220AC0", VA = "0x1842216C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4221710", Offset = "0x4220B10", VA = "0x184221710")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4221550", Offset = "0x4220950", VA = "0x184221550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x42214A0", Offset = "0x42208A0", VA = "0x1842214A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x42214A0", Offset = "0x42208A0", VA = "0x1842214A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4227770", Offset = "0x4226B70", VA = "0x184227770")]
	public static bool IMHFDCNIHKD(this TypeInfo HHDFIJECABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4227670", Offset = "0x4226A70", VA = "0x184227670")]
	public static bool FOPKCNJFHIM(this TypeInfo HHDFIJECABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x42278B0", Offset = "0x4226CB0", VA = "0x1842278B0")]
	public static IEnumerable<PropertyInfo> OCKLNIOKHHB(this Type HHDFIJECABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4227910", Offset = "0x4226D10", VA = "0x184227910")]
	[IteratorStateMachine(typeof(CJJCJEEKFHH))]
	private static IEnumerable<PropertyInfo> OLHOGKCGLFP(Type HHDFIJECABM, HashSet<string> EGCINFJOKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4227610", Offset = "0x4226A10", VA = "0x184227610")]
	public static IEnumerable<FieldInfo> EGEJKPPEBGI(this Type HHDFIJECABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4227820", Offset = "0x4226C20", VA = "0x184227820")]
	[IteratorStateMachine(typeof(GDJNHPIHCKH))]
	private static IEnumerable<FieldInfo> MMFNGNPNCLL(Type HHDFIJECABM, HashSet<string> EGCINFJOKJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class HOFIDEPKEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding IEOCLBNBPIH;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class BOOANALJJNG
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x607F60", Offset = "0x607360", VA = "0x180607F60")]
	public static string IBEIOCOBBPC(string FBDAAAJCJMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3306C30", Offset = "0x3306030", VA = "0x183306C30")]
	public static string AJFNFLFMECD(string FBDAAAJCJMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3306D40", Offset = "0x3306140", VA = "0x183306D40")]
	public static string EEOEICKFNPG(string FBDAAAJCJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class DPINBBJCAPM<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CPGMNKNGBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type DCBIHGMJIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue IKGDHNEELOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int CECIPCMLOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public CPGMNKNGBGG MKDBJDGKENJ;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x233F550", Offset = "0x233E950", VA = "0x18233F550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x233F2B0", Offset = "0x233E6B0", VA = "0x18233F2B0")]
		private int MKAOECNIAAG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public CPGMNKNGBGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class MKJEKKPMFEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public MKJEKKPMFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8864E0", Offset = "0x8858E0", VA = "0x1808864E0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private CPGMNKNGBGG[] OJEECDPFGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int IJHNFJCHOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object FEKMNOBBIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float PDKFGBIJKBM;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2350B20", Offset = "0x234FF20", VA = "0x182350B20")]
	public DPINBBJCAPM(int KJJBHCMHFJM = 4, float PDKFGBIJKBM = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x23502B0", Offset = "0x234F6B0", VA = "0x1823502B0")]
	public bool HPGJOBNABMC(Type KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x23503C0", Offset = "0x234F7C0", VA = "0x1823503C0")]
	public bool HPGJOBNABMC(Type KACNOLACOBJ, Func<Type, TValue> BGCNLLHLOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2350430", Offset = "0x234F830", VA = "0x182350430")]
	private bool LEPPCKDIKHK(Type KACNOLACOBJ, Func<Type, TValue> BGCNLLHLOAE, out TValue CBDDPGHMFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x234FC20", Offset = "0x234F020", VA = "0x18234FC20")]
	private bool CCBABOMLLPL(CPGMNKNGBGG[] OJEECDPFGOF, Type NDLAJIBCDGA, CPGMNKNGBGG LANCGEEELEL, Func<Type, TValue> BGCNLLHLOAE, out TValue CBDDPGHMFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x234F730", Offset = "0x234EB30", VA = "0x18234F730")]
	public bool BIAHFFMAKML(Type KACNOLACOBJ, out TValue MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2350090", Offset = "0x234F490", VA = "0x182350090")]
	public TValue EMHHNHGGMLN(Type KACNOLACOBJ, Func<Type, TValue> BGCNLLHLOAE)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2350130", Offset = "0x234F530", VA = "0x182350130")]
	private static int FJFIFDICKDK(int IFAEIMMIAJL, float PDKFGBIJKBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2350400", Offset = "0x234F800", VA = "0x182350400")]
	private static void JHHIMGMMCEP(ref CPGMNKNGBGG HIPPNHBKCJB, CPGMNKNGBGG MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2350400", Offset = "0x234F800", VA = "0x182350400")]
	private static void JHHIMGMMCEP(ref CPGMNKNGBGG[] HIPPNHBKCJB, CPGMNKNGBGG[] MGNFAPLJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HCANHEBHGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder BMFEOFECNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder EJGIKLOHEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object GFDGGBJPAAG;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x33E90D0", Offset = "0x33E84D0", VA = "0x1833E90D0")]
	public TypeBuilder DOIPNIAANGJ(string AFIDHHDMHNB, TypeAttributes HODIBENBEGK, Type PDIGOPINEPN, Type[] MGBOLIJHBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x33E91C0", Offset = "0x33E85C0", VA = "0x1833E91C0")]
	public HCANHEBHGME(string LIIHGADBJOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class ODAEKCDMNMM
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x422C020", Offset = "0x422B420", VA = "0x18422C020")]
	private static MethodInfo EHJDIBMMDCA(LambdaExpression INIDJJMHFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2F28330", Offset = "0x2F27730", VA = "0x182F28330")]
	public static MethodInfo BFBBNNGNKMP<T>(Expression<Func<T>> INIDJJMHFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2F28330", Offset = "0x2F27730", VA = "0x182F28330")]
	public static MethodInfo BFBBNNGNKMP<T, TR>(Expression<Func<T, TR>> INIDJJMHFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2F28330", Offset = "0x2F27730", VA = "0x182F28330")]
	public static MethodInfo BFBBNNGNKMP<T>(Expression<Action<T>> INIDJJMHFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2F28330", Offset = "0x2F27730", VA = "0x182F28330")]
	public static MethodInfo BFBBNNGNKMP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> INIDJJMHFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2F283A0", Offset = "0x2F277A0", VA = "0x182F283A0")]
	private static MemberInfo PPJBHFFPFAE<T>(Expression<T> CJIAPCFJKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2F28340", Offset = "0x2F27740", VA = "0x182F28340")]
	public static PropertyInfo NNDHIIEGJFH<T, TR>(Expression<Func<T, TR>> INIDJJMHFNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct LGAHLFCBKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int BOPGJDPNNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool BHKNHNGNNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator JEJJFLAKDDM;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x42267C0", Offset = "0x4225BC0", VA = "0x1842267C0")]
	public LGAHLFCBKPD(ILGenerator JEJJFLAKDDM, int BOPGJDPNNAI, bool BHKNHNGNNNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4226730", Offset = "0x4225B30", VA = "0x184226730")]
	public LGAHLFCBKPD(ILGenerator JEJJFLAKDDM, int BOPGJDPNNAI, Type HHDFIJECABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4226710", Offset = "0x4225B10", VA = "0x184226710")]
	public void EADIICMEDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class ENBBJPNGHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x33DCD30", Offset = "0x33DC130", VA = "0x1833DCD30")]
	public static void FEEFDKBFMLA(this ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x33DCCF0", Offset = "0x33DC0F0", VA = "0x1833DCCF0")]
	public static void FEEFDKBFMLA(this ILGenerator JEJJFLAKDDM, LocalBuilder LOKMGNDFMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x33DC700", Offset = "0x33DBB00", VA = "0x1833DC700")]
	public static void BAJDGKFNMKA(this ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x33DC6C0", Offset = "0x33DBAC0", VA = "0x1833DC6C0")]
	public static void BAJDGKFNMKA(this ILGenerator JEJJFLAKDDM, LocalBuilder LOKMGNDFMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x33DD280", Offset = "0x33DC680", VA = "0x1833DD280")]
	public static void NKOKJOIAFOH(this ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x33DD370", Offset = "0x33DC770", VA = "0x1833DD370")]
	public static void NKOKJOIAFOH(this ILGenerator JEJJFLAKDDM, LocalBuilder LOKMGNDFMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x33DD000", Offset = "0x33DC400", VA = "0x1833DD000")]
	public static void HAAGAICCCIO(this ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x33DD100", Offset = "0x33DC500", VA = "0x1833DD100")]
	public static void LAFBKBCMPJN(this ILGenerator JEJJFLAKDDM, bool MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x33DC270", Offset = "0x33DB670", VA = "0x1833DC270")]
	public static void ALAPPGPGEIB(this ILGenerator JEJJFLAKDDM, int MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x33DD110", Offset = "0x33DC510", VA = "0x1833DD110")]
	public static void LFPPDMPEHAD(this ILGenerator JEJJFLAKDDM, Type HHDFIJECABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x33DCF60", Offset = "0x33DC360", VA = "0x1833DCF60")]
	public static void GPMAPCPPOHO(this ILGenerator JEJJFLAKDDM, Type HHDFIJECABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x33DCA30", Offset = "0x33DBE30", VA = "0x1833DCA30")]
	public static void CLFMGEGNIAA(this ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x33DD200", Offset = "0x33DC600", VA = "0x1833DD200")]
	public static void MMBMGGJKAOM(this ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x33DD010", Offset = "0x33DC410", VA = "0x1833DD010")]
	public static void KCPEPOKKKKA(this ILGenerator JEJJFLAKDDM, int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x33DC930", Offset = "0x33DBD30", VA = "0x1833DC930")]
	public static void BCFJOMACFPH(this ILGenerator JEJJFLAKDDM, MethodInfo PKBAEJAPJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x33DD480", Offset = "0x33DC880", VA = "0x1833DD480")]
	public static void PBDJIGANEAH(this ILGenerator JEJJFLAKDDM, FieldInfo KEFCBGOFEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x33DCC60", Offset = "0x33DC060", VA = "0x1833DCC60")]
	public static void DMENPIEPEMN(this ILGenerator JEJJFLAKDDM, ulong MGNFAPLJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class BDOPNAEIOEE
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GOHMOLAIFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public GOHMOLAIFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3309AB0", Offset = "0x3308EB0", VA = "0x183309AB0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo KJNJCAONDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo FCIABIJDCCJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string MDLHDLKLAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FAIIGAPDLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GIHAGGBJLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3302A50", Offset = "0x3301E50", VA = "0x183302A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ALJEJNDLBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x552190", Offset = "0x551590", VA = "0x180552190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9560", Offset = "0x6D8960", VA = "0x1806D9560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OOOKBPIDNML
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5521A0", Offset = "0x5515A0", VA = "0x1805521A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x68FB70", Offset = "0x68EF70", VA = "0x18068FB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type NIFGAMMDEME
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x675A90", Offset = "0x674E90", VA = "0x180675A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo HDINJONLFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo JOLOIOFAEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x553010", Offset = "0x552410", VA = "0x180553010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x553020", Offset = "0x552420", VA = "0x180553020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo PBBNEAJEKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x565D70", Offset = "0x565170", VA = "0x180565D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFC0", Offset = "0x5EC3C0", VA = "0x1805ECFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3302E10", Offset = "0x3302210", VA = "0x183302E10")]
	protected BDOPNAEIOEE(Type HHDFIJECABM, string AFIDHHDMHNB, string PNCHNBLDIHM, bool JOINAANPKIN, bool JOLMIDEJLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3302D00", Offset = "0x3302100", VA = "0x183302D00")]
	public BDOPNAEIOEE(FieldInfo KLNNIKJBGAF, string AFIDHHDMHNB, bool KGGKCAAOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3302E90", Offset = "0x3302290", VA = "0x183302E90")]
	public BDOPNAEIOEE(PropertyInfo KLNNIKJBGAF, string AFIDHHDMHNB, bool KGGKCAAOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3302A60", Offset = "0x3301E60", VA = "0x183302A60")]
	private static MethodInfo GPPELFCNBOL(MemberInfo KLNNIKJBGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x221D080", Offset = "0x221C480", VA = "0x18221D080")]
	public T KPLPAJPLLLI<T>(bool LAHDILIJJAG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3302C40", Offset = "0x3302040", VA = "0x183302C40", Slot = "4")]
	public virtual void PNDHMLFHAPD(ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3302B80", Offset = "0x3301F80", VA = "0x183302B80", Slot = "5")]
	public virtual void HOENJJCELJF(ILGenerator JEJJFLAKDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class CDOCINFJEEH : BDOPNAEIOEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string DAGBIDPPOEN;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x3307320", Offset = "0x3306720", VA = "0x183307320")]
	public CDOCINFJEEH(string AFIDHHDMHNB, string DAGBIDPPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x3307260", Offset = "0x3306660", VA = "0x183307260", Slot = "4")]
	public override void PNDHMLFHAPD(ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x3307210", Offset = "0x3306610", VA = "0x183307210", Slot = "5")]
	public override void HOENJJCELJF(ILGenerator JEJJFLAKDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class IPDCNDDCIHM : BDOPNAEIOEE
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo NLJIDGODFDK;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo JCLODFADIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal LGAHLFCBKPD GPGOJCCKLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal LGAHLFCBKPD GNJBGJKFNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal LGAHLFCBKPD KBPFAEDCBEB;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4223450", Offset = "0x4222850", VA = "0x184223450")]
	public IPDCNDDCIHM(string AFIDHHDMHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4222EF0", Offset = "0x42222F0", VA = "0x184222EF0", Slot = "4")]
	public override void PNDHMLFHAPD(ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4222EA0", Offset = "0x42222A0", VA = "0x184222EA0", Slot = "5")]
	public override void HOENJJCELJF(ILGenerator JEJJFLAKDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x4222D60", Offset = "0x4222160", VA = "0x184222D60")]
	public void BCPMNBANNMB(ILGenerator JEJJFLAKDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class ONDMLCJMHOL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type NIFGAMMDEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FAJHPNKGGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x680BA0", Offset = "0x67FFA0", VA = "0x180680BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x713AD0", Offset = "0x712ED0", VA = "0x180713AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MMOBMIDGEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x691190", Offset = "0x690590", VA = "0x180691190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD954B0", Offset = "0xD948B0", VA = "0x180D954B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo COOLGGGECEI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BDOPNAEIOEE[] JMNHOHNFJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x675A90", Offset = "0x674E90", VA = "0x180675A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BDOPNAEIOEE[] DBHKKGLNMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x422CBD0", Offset = "0x422BFD0", VA = "0x18422CBD0")]
	public ONDMLCJMHOL(Type HHDFIJECABM, Func<string, string> OCGMHNKPIHO, bool KGGKCAAOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x422CB00", Offset = "0x422BF00", VA = "0x18422CB00")]
	private static bool LBKFGBCAEMP(IEnumerator<ConstructorInfo> IGNAALAJKIM, ref ConstructorInfo JMDJIJDEKPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct BDNBGJJNFNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong BLMLHPOFNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int OCJJHJBGOJM;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2271B40", Offset = "0x2270F40", VA = "0x182271B40")]
	public BDNBGJJNFNP(ulong BCMDLIOAGJN, int GOLKLCJNPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3302960", Offset = "0x3301D60", VA = "0x183302960")]
	public void IGNNJKGOMHD(ref BDNBGJJNFNP OGCBGOIPCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3302A20", Offset = "0x3301E20", VA = "0x183302A20")]
	public static BDNBGJJNFNP NIGNMMCNMGE(ref BDNBGJJNFNP GNKLMCIFODF, ref BDNBGJJNFNP FFOHEAHJJEI)
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x33028D0", Offset = "0x3301CD0", VA = "0x1833028D0")]
	public void HBJMDBELOLE(ref BDNBGJJNFNP OGCBGOIPCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3302970", Offset = "0x3301D70", VA = "0x183302970")]
	public static BDNBGJJNFNP LADDKGHJLAE(ref BDNBGJJNFNP GNKLMCIFODF, ref BDNBGJJNFNP FFOHEAHJJEI)
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3302830", Offset = "0x3301C30", VA = "0x183302830")]
	public void AHOGEGJCFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3302870", Offset = "0x3301C70", VA = "0x183302870")]
	public static BDNBGJJNFNP AHOGEGJCFGD(ref BDNBGJJNFNP GNKLMCIFODF)
	{
		return default(BDNBGJJNFNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct GEFAPJCPEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] KCNEECJJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int CBMNFDDLNMI;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x839030", Offset = "0x838430", VA = "0x180839030")]
	public GEFAPJCPEIM(byte[] KCNEECJJIPG, int FPKNBMBNOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x33E4540", Offset = "0x33E3940", VA = "0x1833E4540")]
	public void ELAHLANBELN(byte NJLPAIJKDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x33E46F0", Offset = "0x33E3AF0", VA = "0x1833E46F0")]
	public void ONIJJOCPIJD(byte[] NJLPAIJKDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x33E45A0", Offset = "0x33E39A0", VA = "0x1833E45A0")]
	public void JLHOLHKAAJN(byte[] NJLPAIJKDNM, int EIKDAKIMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x33E4640", Offset = "0x33E3A40", VA = "0x1833E4640")]
	public void JLHOLHKAAJN(byte[] NJLPAIJKDNM, int KAGIKHONMOM, int EIKDAKIMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x33E44C0", Offset = "0x33E38C0", VA = "0x1833E44C0")]
	public void ECPMGHINNAH(byte DMIPEKEOIKL, int LFFBMCJGPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x33E43C0", Offset = "0x33E37C0", VA = "0x1833E43C0")]
	public void CBHHKOJIPIF(string NJLPAIJKDNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class MBHELGAJAPB
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum BJJFIHAIKJF
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum IPNLCGCJPGC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum NPPLPECNPGF
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
	private static byte[] AHOKLIELNFA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] PLIDDNCDNCB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] MDDOEFEGKOK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] DFJBMHMJPLG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly NPPLPECNPGF EOOKFMDBEKE;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char LOLPAOALFGP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int MNFNJFMDCHA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int KLJDMEKGFLA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] KPKCKCALCOH;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x42291C0", Offset = "0x42285C0", VA = "0x1842291C0")]
	private static byte[] KLKKADPCMOP(int IJHNFJCHOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4229790", Offset = "0x4228B90", VA = "0x184229790")]
	private static byte[] PFKMODMMFHD(int IJHNFJCHOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x42281F0", Offset = "0x42275F0", VA = "0x1842281F0")]
	public static int CLNEGBGDELF(ref byte[] KCNEECJJIPG, int CBMNFDDLNMI, float MGNFAPLJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4228300", Offset = "0x4227700", VA = "0x184228300")]
	public static int CLNEGBGDELF(ref byte[] KCNEECJJIPG, int CBMNFDDLNMI, double MGNFAPLJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x42280F0", Offset = "0x42274F0", VA = "0x1842280F0")]
	private static bool CJJPLODHBEB(byte[] KCNEECJJIPG, int EIKDAKIMGCJ, ulong KKIBLBINLIF, ulong EGKKKDGJEHP, ulong PHEEEEKAHPF, ulong BAFLLAMLAJJ, ulong PFPGDMFLCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4229290", Offset = "0x4228690", VA = "0x184229290")]
	private static void NPPNDCGNEAC(uint PHAFIJABMCJ, int CBOBJOMMCJG, out uint NLPBLCFHKKJ, out int OLPIFHPBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4228D70", Offset = "0x4228170", VA = "0x184228D70")]
	private static bool KJECBFKJMNA(BDNBGJJNFNP JAPKJFJCOOB, BDNBGJJNFNP OKFCFKIHJCI, BDNBGJJNFNP PKLPMJOGBFB, byte[] KCNEECJJIPG, out int EIKDAKIMGCJ, out int NLIGGNIBCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4227E80", Offset = "0x4227280", VA = "0x184227E80")]
	private static bool BFDODGPJNOA(double AEKDMOKGKJI, BJJFIHAIKJF IHAPPEONNEN, byte[] KCNEECJJIPG, out int EIKDAKIMGCJ, out int FDJHMIJMBEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x42293B0", Offset = "0x42287B0", VA = "0x1842293B0")]
	private static bool OKDKOFENILN(double AEKDMOKGKJI, BJJFIHAIKJF IHAPPEONNEN, byte[] KCNEECJJIPG, out int EIKDAKIMGCJ, out int AKAJODOCDJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4228A40", Offset = "0x4227E40", VA = "0x184228A40")]
	private static bool HOMENOBMLOB(double MGNFAPLJAOB, ref GEFAPJCPEIM LKJJNCFMHJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4228410", Offset = "0x4227810", VA = "0x184228410")]
	private static bool GMNKDALDMGN(double MGNFAPLJAOB, ref GEFAPJCPEIM LKJJNCFMHJO, IPNLCGCJPGC IHAPPEONNEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4227CC0", Offset = "0x42270C0", VA = "0x184227CC0")]
	private static void BADJFFDJIAM(byte[] OIKPPFJDJGD, int EIKDAKIMGCJ, int AKAJODOCDJL, int FNNKMPOBOJH, ref GEFAPJCPEIM LKJJNCFMHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x42294A0", Offset = "0x42288A0", VA = "0x1842294A0")]
	private static void OMNIBJMGOLO(byte[] OIKPPFJDJGD, int EIKDAKIMGCJ, int GOLKLCJNPIN, ref GEFAPJCPEIM LKJJNCFMHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4228BD0", Offset = "0x4227FD0", VA = "0x184228BD0")]
	private static bool JCFLDIEDOIM(double AEKDMOKGKJI, IPNLCGCJPGC IHAPPEONNEN, int OCFDIPHLJOF, byte[] DDLPEBFKGGM, out bool MNGMEJGHJBD, out int EIKDAKIMGCJ, out int PIHBNCCGJFN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct DHKOHKFBDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double LHMFHKDLIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong AGIEPPICJIJ;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct DHHOFPGFDJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float BLMLHPOFNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint MIKBMPADNFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct IJFONBECFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong BJNBCAHPLFG;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x33ECD50", Offset = "0x33EC150", VA = "0x1833ECD50")]
	public IJFONBECFCM(double LHMFHKDLIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x33ECD60", Offset = "0x33EC160", VA = "0x1833ECD60")]
	public IJFONBECFCM(BDNBGJJNFNP LHMFHKDLIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x33ECA60", Offset = "0x33EBE60", VA = "0x1833ECA60")]
	public BDNBGJJNFNP IDMEGHCBCCG()
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x33ECC60", Offset = "0x33EC060", VA = "0x1833ECC60")]
	public BDNBGJJNFNP OLLCJMDIHAC()
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x78E1B0", Offset = "0x78D5B0", VA = "0x18078E1B0")]
	public ulong OJPAEOLOMBN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x33ECB50", Offset = "0x33EBF50", VA = "0x1833ECB50")]
	public double ODGBAMKHBHA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x33EC820", Offset = "0x33EBC20", VA = "0x1833EC820")]
	public double FCNONJOODCL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x33EC760", Offset = "0x33EBB60", VA = "0x1833EC760")]
	public int AJJGMJDMBIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x33ECD00", Offset = "0x33EC100", VA = "0x1833ECD00")]
	public ulong OOOOKNLEBML()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x33ECD30", Offset = "0x33EC130", VA = "0x1833ECD30")]
	public bool PJEAJAIPABI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x33EC7B0", Offset = "0x33EBBB0", VA = "0x1833EC7B0")]
	public bool DFNFBDLLIBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x33EC8A0", Offset = "0x33EBCA0", VA = "0x1833EC8A0")]
	public bool FKCDCCKECLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x33ECAF0", Offset = "0x33EBEF0", VA = "0x1833ECAF0")]
	public bool KKNKIEJBNBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x33ECB20", Offset = "0x33EBF20", VA = "0x1833ECB20")]
	public int MCPJHAKCIAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x33EC8D0", Offset = "0x33EBCD0", VA = "0x1833EC8D0")]
	public void ICGDHOBPOCO(out BDNBGJJNFNP EAEMLOJOPEJ, out BDNBGJJNFNP PDIHLCCMPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x33EC7D0", Offset = "0x33EBBD0", VA = "0x1833EC7D0")]
	public bool ECMFLCCOJHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x33ECB40", Offset = "0x33EBF40", VA = "0x1833ECB40")]
	public double MGNFAPLJAOB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x33EC790", Offset = "0x33EBB90", VA = "0x1833EC790")]
	public static int BMCGPBLNBEB(int JABKMEPKCJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x33ECAE0", Offset = "0x33EBEE0", VA = "0x1833ECAE0")]
	public static double IGJHHFBKHKE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x33ECBC0", Offset = "0x33EBFC0", VA = "0x1833ECBC0")]
	public static ulong OEJHJCEDIGH(BDNBGJJNFNP HMGEAIAOIMJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct NGBGJDAMBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint CEJGBNGFLHE;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D880", Offset = "0x1E2CC80", VA = "0x181E2D880")]
	public NGBGJDAMBCE(float BLMLHPOFNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x422A450", Offset = "0x4229850", VA = "0x18422A450")]
	public BDNBGJJNFNP IDMEGHCBCCG()
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0")]
	public uint FBAKNNEHOGF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x422A280", Offset = "0x4229680", VA = "0x18422A280")]
	public int AJJGMJDMBIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x422A4C0", Offset = "0x42298C0", VA = "0x18422A4C0")]
	public uint OOOOKNLEBML()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x422A4E0", Offset = "0x42298E0", VA = "0x18422A4E0")]
	public bool PJEAJAIPABI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x422A2E0", Offset = "0x42296E0", VA = "0x18422A2E0")]
	public void ICGDHOBPOCO(out BDNBGJJNFNP EAEMLOJOPEJ, out BDNBGJJNFNP PDIHLCCMPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x422A2A0", Offset = "0x42296A0", VA = "0x18422A2A0")]
	public bool ECMFLCCOJHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct IJDEMCBELDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong BCMDLIOAGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short MFNHNLJKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short FDJHMIJMBEI;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x33EC750", Offset = "0x33EBB50", VA = "0x1833EC750")]
	public IJDEMCBELDP(ulong BCMDLIOAGJN, short MFNHNLJKBDJ, short FDJHMIJMBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class GCHNAJAMEEN
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly IJDEMCBELDP[] FKIJAJPHDDH;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x33E2640", Offset = "0x33E1A40", VA = "0x1833E2640")]
	public static void OMLNKKPDLMF(int GFCPBOLFDOF, int MNLCPOKDNPJ, out BDNBGJJNFNP NLPBLCFHKKJ, out int FDJHMIJMBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x33E2540", Offset = "0x33E1940", VA = "0x1833E2540")]
	public static void KMKLKNBMPKP(int DEHNDICOLFH, out BDNBGJJNFNP NLPBLCFHKKJ, out int PNLMNGHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HAPMAACEMDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] MFCIHENGNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int KAGIKHONMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int JDPGOEFLGMC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x33E9090", Offset = "0x33E8490", VA = "0x1833E9090")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x965650", Offset = "0x964A50", VA = "0x180965650")]
	public HAPMAACEMDJ(byte[] MFCIHENGNMD, int KAGIKHONMOM, int EIKDAKIMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4B0", Offset = "0x7FD8B0", VA = "0x1807FE4B0")]
	public int EIKDAKIMGCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x33E9030", Offset = "0x33E8430", VA = "0x1833E9030")]
	public HAPMAACEMDJ DCOPCKCNCKG(int PCLONNAPMJP, int FMJIGIMGIMB)
	{
		return default(HAPMAACEMDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class NKLPOFAMPOI
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] GOCEFMONGPJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] GIFKEOMANNA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int ALILAOALFEN;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x422B810", Offset = "0x422AC10", VA = "0x18422B810")]
	private static byte[] NHBHBIHKGPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x422B3B0", Offset = "0x422A7B0", VA = "0x18422B3B0")]
	private static HAPMAACEMDJ KCODDHHBPII(HAPMAACEMDJ KCNEECJJIPG)
	{
		return default(HAPMAACEMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x422ADD0", Offset = "0x422A1D0", VA = "0x18422ADD0")]
	private static HAPMAACEMDJ DJPDEAHDAPE(HAPMAACEMDJ KCNEECJJIPG)
	{
		return default(HAPMAACEMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x422AE80", Offset = "0x422A280", VA = "0x18422AE80")]
	private static void FGNOOIOPIPN(HAPMAACEMDJ KCNEECJJIPG, int GOLKLCJNPIN, byte[] DOOEDLFPNLA, out int PAPENFHPGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x422A630", Offset = "0x4229A30", VA = "0x18422A630")]
	private static void BHEBLFHIJJC(HAPMAACEMDJ KCNEECJJIPG, int GOLKLCJNPIN, byte[] BACCDNIGAMN, int IFFMMBDNJAJ, out HAPMAACEMDJ LLLFFBJKJMA, out int JHDENCIKFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x422B8F0", Offset = "0x422ACF0", VA = "0x18422B8F0")]
	private static ulong ODJDKOIEGDN(HAPMAACEMDJ KCNEECJJIPG, out int BHALEGJBCFP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x422AC80", Offset = "0x422A080", VA = "0x18422AC80")]
	private static void DDGGEMBIAPE(HAPMAACEMDJ KCNEECJJIPG, out BDNBGJJNFNP BLBGKFGAFHM, out int CKDLJHPLADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x422B460", Offset = "0x422A860", VA = "0x18422B460")]
	private static bool KLFMLEEPPCM(HAPMAACEMDJ LLLFFBJKJMA, int GOLKLCJNPIN, out double BLBGKFGAFHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x422B070", Offset = "0x422A470", VA = "0x18422B070")]
	private static BDNBGJJNFNP HHILINOPPON(int GOLKLCJNPIN)
	{
		return default(BDNBGJJNFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x422A8E0", Offset = "0x4229CE0", VA = "0x18422A8E0")]
	private static bool CMNLCELEPHD(HAPMAACEMDJ KCNEECJJIPG, int GOLKLCJNPIN, out double BLBGKFGAFHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x422A4F0", Offset = "0x42298F0", VA = "0x18422A4F0")]
	private static bool AMIMIJOGIHH(HAPMAACEMDJ LLLFFBJKJMA, int GOLKLCJNPIN, out double CHDLOKNECIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x422AF40", Offset = "0x422A340", VA = "0x18422AF40")]
	public static double? GIABOHDKMFD(HAPMAACEMDJ KCNEECJJIPG, int GOLKLCJNPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x422B1D0", Offset = "0x422A5D0", VA = "0x18422B1D0")]
	public static float? JFBFJDACOGL(HAPMAACEMDJ KCNEECJJIPG, int GOLKLCJNPIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct IDCOBPPDDNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] KCNEECJJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int CBMNFDDLNMI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte IKGDHNEELOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x33EC040", Offset = "0x33EB440", VA = "0x1833EC040")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x839030", Offset = "0x838430", VA = "0x180839030")]
	public IDCOBPPDDNB(byte[] KCNEECJJIPG, int CBMNFDDLNMI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x33EC140", Offset = "0x33EB540", VA = "0x1833EC140")]
	public static IDCOBPPDDNB OMMGNBKGDNF(IDCOBPPDDNB DDGLIDGJCGC)
	{
		return default(IDCOBPPDDNB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x33EC0E0", Offset = "0x33EB4E0", VA = "0x1833EC0E0")]
	public static IDCOBPPDDNB NJOFOEAECPI(IDCOBPPDDNB DDGLIDGJCGC, int EIKDAKIMGCJ)
	{
		return default(IDCOBPPDDNB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x33EC0C0", Offset = "0x33EB4C0", VA = "0x1833EC0C0")]
	public static int MNLNHINEFGM(IDCOBPPDDNB NCCAGEJPKHF, IDCOBPPDDNB LIGCOAKACCN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x33EC020", Offset = "0x33EB420", VA = "0x1833EC020")]
	public static bool IIKKEAGJJHP(IDCOBPPDDNB NCCAGEJPKHF, IDCOBPPDDNB LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x33EBF40", Offset = "0x33EB340", VA = "0x1833EBF40")]
	public static bool GCGPIAFPBCM(IDCOBPPDDNB NCCAGEJPKHF, IDCOBPPDDNB LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x33EBFE0", Offset = "0x33EB3E0", VA = "0x1833EBFE0")]
	public static bool IIKKEAGJJHP(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x33EBF00", Offset = "0x33EB300", VA = "0x1833EBF00")]
	public static bool GCGPIAFPBCM(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x33EBF00", Offset = "0x33EB300", VA = "0x1833EBF00")]
	public static bool GCGPIAFPBCM(IDCOBPPDDNB NCCAGEJPKHF, byte LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x33EBEC0", Offset = "0x33EB2C0", VA = "0x1833EBEC0")]
	public static bool AAAGHMFCFAA(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x33EC080", Offset = "0x33EB480", VA = "0x1833EC080")]
	public static bool LNPEBFLONDP(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x33EBFA0", Offset = "0x33EB3A0", VA = "0x1833EBFA0")]
	public static bool IBJEGDPCLHG(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x33EBF60", Offset = "0x33EB360", VA = "0x1833EBF60")]
	public static bool GIHEDGOHIAG(IDCOBPPDDNB NCCAGEJPKHF, char LIGCOAKACCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GOFPALFIBLM
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CNBMIJPBPDI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] DCMKNODEDDB;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] MDDOEFEGKOK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] DFJBMHMJPLG;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] PODPPEGGHAM;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int LPMBLBNKLCP;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] LMOHAALLAGI;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int LJHHFPPOPJO;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x33E87D0", Offset = "0x33E7BD0", VA = "0x1833E87D0")]
	private static byte[] GPHHBMKNIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x33E8A90", Offset = "0x33E7E90", VA = "0x1833E8A90")]
	private static byte[] KIEBIEJFBNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x33E8C90", Offset = "0x33E8090", VA = "0x1833E8C90")]
	public static double LHNPHJNIFJE(byte[] KCNEECJJIPG, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x33E8D50", Offset = "0x33E8150", VA = "0x1833E8D50")]
	public static float NPEDAGOFFJK(byte[] KCNEECJJIPG, int CBMNFDDLNMI, out int JHEHGHFCJPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x33E88B0", Offset = "0x33E7CB0", VA = "0x1833E88B0")]
	private static bool HDDECADGNBP(int JEPLLBBBDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x33E7660", Offset = "0x33E6A60", VA = "0x1833E7660")]
	private static bool AHFMNDDHGHM(ref IDCOBPPDDNB EMDIPBMHJFM, IDCOBPPDDNB MEEFFGBBAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x33E8B70", Offset = "0x33E7F70", VA = "0x1833E8B70")]
	private static bool KLFBKMHJGGN(ref IDCOBPPDDNB EMDIPBMHJFM, IDCOBPPDDNB MEEFFGBBAJM, byte[] KBCBGNLODDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x33E8A30", Offset = "0x33E7E30", VA = "0x1833E8A30")]
	private static bool IMALFCHPILA(ref IDCOBPPDDNB CKDLMLNMLMA, byte[] NJLPAIJKDNM, int CBMNFDDLNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xEA74C0", Offset = "0xEA68C0", VA = "0x180EA74C0")]
	private static double EAMAIDDCCFL(bool MNGMEJGHJBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x33E7790", Offset = "0x33E6B90", VA = "0x1833E7790")]
	private static double DFNCPPJMECH(IDCOBPPDDNB CDNMLGEOKBM, int EIKDAKIMGCJ, bool OMEBLFFINML, out int PHJMDIOLJHJ)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class JENCALDEBPP<T> : global::BFPOGOEJBPA<T[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::FAFAPEFJKCK<T> ODMFGCGEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly NMABLJJJMND FIPMBDNGMGH;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x24CCF30", Offset = "0x24CC330", VA = "0x1824CCF30")]
	public JENCALDEBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1C21930", Offset = "0x1C20D30", VA = "0x181C21930")]
	public JENCALDEBPP(NMABLJJJMND FIPMBDNGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x24CA600", Offset = "0x24C9A00", VA = "0x1824CA600", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, T[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x24CB910", Offset = "0x24CAD10", VA = "0x1824CB910", Slot = "5")]
	public T[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class FMPFIFNPDKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::FAFAPEFJKCK<T> ODMFGCGEHJN;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class CNHBOJHNAKG<T> : global::BFPOGOEJBPA<List<T>>, NPKKFPKKFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly NMABLJJJMND FIPMBDNGMGH;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x24CCF30", Offset = "0x24CC330", VA = "0x1824CCF30")]
	public CNHBOJHNAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1C21930", Offset = "0x1C20D30", VA = "0x181C21930")]
	public CNHBOJHNAKG(NMABLJJJMND FIPMBDNGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x35A10C0", Offset = "0x35A04C0", VA = "0x1835A10C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, List<T> MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x35A26E0", Offset = "0x35A1AE0", VA = "0x1835A26E0", Slot = "5")]
	public List<T> NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class JIMPNCMCEDO<TElement, TIntermediate, TEnumerator, TCollection> : global::BFPOGOEJBPA<TCollection>, NPKKFPKKFLD where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x427E6C0", Offset = "0x427DAC0", VA = "0x18427E6C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, TCollection MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x427F780", Offset = "0x427EB80", VA = "0x18427F780", Slot = "5")]
	public TCollection NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator ONFKLIDKLBL(TCollection CJIAPCFJKNL);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DDAMABLPPOO();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KCLLGEJMGAB(ref TIntermediate PDDJFCOJOLJ, int DBFCFFLFJDL, TElement MGNFAPLJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection KNOFFOGILML(ref TIntermediate FAOIJEMLJEB);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
	protected JIMPNCMCEDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class JJLIBLHPICN<TElement, TIntermediate, TCollection> : global::JIMPNCMCEDO<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2F391F0", Offset = "0x2F385F0", VA = "0x182F391F0", Slot = "6")]
	protected override IEnumerator<TElement> ONFKLIDKLBL(TCollection CJIAPCFJKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E890", Offset = "0x1F3DC90", VA = "0x181F3E890")]
	protected JJLIBLHPICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class LGFKJICEGAE<TElement, TCollection> : global::JJLIBLHPICN<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected sealed override TCollection KNOFFOGILML(ref TCollection FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class DKDOMOLEKBE<TElement, TCollection> : global::LGFKJICEGAE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x23430A0", Offset = "0x23424A0", VA = "0x1823430A0", Slot = "7")]
	protected override TCollection DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x23430C0", Offset = "0x23424C0", VA = "0x1823430C0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref TCollection PDDJFCOJOLJ, int DBFCFFLFJDL, TElement MGNFAPLJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GJEIGFEEADM<T> : global::JIMPNCMCEDO<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E920", Offset = "0x1F3DD20", VA = "0x181F3E920", Slot = "8")]
	protected override void KCLLGEJMGAB(ref LinkedList<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override LinkedList<T> KNOFFOGILML(ref LinkedList<T> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override LinkedList<T> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C220", Offset = "0x2F3B620", VA = "0x182F3C220", Slot = "6")]
	protected override LinkedList<T>.Enumerator ONFKLIDKLBL(LinkedList<T> CJIAPCFJKNL)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class OAEKIDHJAHF<T> : global::JIMPNCMCEDO<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E920", Offset = "0x1F3DD20", VA = "0x181F3E920", Slot = "8")]
	protected override void KCLLGEJMGAB(ref Queue<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override Queue<T> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x359EF10", Offset = "0x359E310", VA = "0x18359EF10", Slot = "6")]
	protected override Queue<T>.Enumerator ONFKLIDKLBL(Queue<T> CJIAPCFJKNL)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override Queue<T> KNOFFOGILML(ref Queue<T> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class HCHONIJFPDL<T> : global::JIMPNCMCEDO<T, global::DHMKJDPNKKL<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x37431D0", Offset = "0x37425D0", VA = "0x1837431D0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref global::DHMKJDPNKKL<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3743180", Offset = "0x3742580", VA = "0x183743180", Slot = "7")]
	protected override global::DHMKJDPNKKL<T> DDAMABLPPOO()
	{
		return default(global::DHMKJDPNKKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x359EF10", Offset = "0x359E310", VA = "0x18359EF10", Slot = "6")]
	protected override Stack<T>.Enumerator ONFKLIDKLBL(Stack<T> CJIAPCFJKNL)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3743200", Offset = "0x3742600", VA = "0x183743200", Slot = "9")]
	protected override Stack<T> KNOFFOGILML(ref global::DHMKJDPNKKL<T> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class CLKBJEKMLNH<T> : global::JIMPNCMCEDO<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E920", Offset = "0x1F3DD20", VA = "0x181F3E920", Slot = "8")]
	protected override void KCLLGEJMGAB(ref HashSet<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override HashSet<T> KNOFFOGILML(ref HashSet<T> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override HashSet<T> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x359EF10", Offset = "0x359E310", VA = "0x18359EF10", Slot = "6")]
	protected override HashSet<T>.Enumerator ONFKLIDKLBL(HashSet<T> CJIAPCFJKNL)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class EMFBFIADKHN<T> : global::JJLIBLHPICN<T, global::DHMKJDPNKKL<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x37431D0", Offset = "0x37425D0", VA = "0x1837431D0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref global::DHMKJDPNKKL<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x393B5A0", Offset = "0x393A9A0", VA = "0x18393B5A0", Slot = "9")]
	protected override ReadOnlyCollection<T> KNOFFOGILML(ref global::DHMKJDPNKKL<T> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x393B550", Offset = "0x393A950", VA = "0x18393B550", Slot = "7")]
	protected override global::DHMKJDPNKKL<T> DDAMABLPPOO()
	{
		return default(global::DHMKJDPNKKL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PNOJCDOHNJE<T> : global::JJLIBLHPICN<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E920", Offset = "0x1F3DD20", VA = "0x181F3E920", Slot = "8")]
	protected override void KCLLGEJMGAB(ref List<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override List<T> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override IList<T> KNOFFOGILML(ref List<T> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class CJOGKGKIBPC<T> : global::JJLIBLHPICN<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E920", Offset = "0x1F3DD20", VA = "0x181F3E920", Slot = "8")]
	protected override void KCLLGEJMGAB(ref List<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override List<T> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override ICollection<T> KNOFFOGILML(ref List<T> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class DODEPLFDODP<T> : global::JJLIBLHPICN<T, global::DHMKJDPNKKL<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x234BEA0", Offset = "0x234B2A0", VA = "0x18234BEA0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref global::DHMKJDPNKKL<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x234BE00", Offset = "0x234B200", VA = "0x18234BE00", Slot = "7")]
	protected override global::DHMKJDPNKKL<T> DDAMABLPPOO()
	{
		return default(global::DHMKJDPNKKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x234BED0", Offset = "0x234B2D0", VA = "0x18234BED0", Slot = "9")]
	protected override IEnumerable<T> KNOFFOGILML(ref global::DHMKJDPNKKL<T> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class MDMCGGDGFIG<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class NJKCODJMDNH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PHGNINPNNMO<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GEPBDDJEOEH : global::BFPOGOEJBPA<IEnumerable>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::BFPOGOEJBPA<IEnumerable> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x33E4F00", Offset = "0x33E4300", VA = "0x1833E4F00", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, IEnumerable MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x33E5160", Offset = "0x33E4560", VA = "0x1833E5160", Slot = "5")]
	public IEnumerable NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public GEPBDDJEOEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class LBEJKGAJGOC : global::BFPOGOEJBPA<ICollection>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::BFPOGOEJBPA<ICollection> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4226110", Offset = "0x4225510", VA = "0x184226110", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ICollection MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x42263B0", Offset = "0x42257B0", VA = "0x1842263B0", Slot = "5")]
	public ICollection NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public LBEJKGAJGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GKBDHCJDPDK : global::BFPOGOEJBPA<IList>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::BFPOGOEJBPA<IList> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x33E55A0", Offset = "0x33E49A0", VA = "0x1833E55A0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, IList MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x33E58E0", Offset = "0x33E4CE0", VA = "0x1833E58E0", Slot = "5")]
	public IList NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public GKBDHCJDPDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class HHLCOCJONBA<T> : global::JJLIBLHPICN<T, global::DHMKJDPNKKL<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x37463C0", Offset = "0x37457C0", VA = "0x1837463C0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref global::DHMKJDPNKKL<T> PDDJFCOJOLJ, int DBFCFFLFJDL, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3743180", Offset = "0x3742580", VA = "0x183743180", Slot = "7")]
	protected override global::DHMKJDPNKKL<T> DDAMABLPPOO()
	{
		return default(global::DHMKJDPNKKL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x37463F0", Offset = "0x37457F0", VA = "0x1837463F0", Slot = "9")]
	protected override IReadOnlyList<T> KNOFFOGILML(ref global::DHMKJDPNKKL<T> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1C282C0", Offset = "0x1C276C0", VA = "0x181C282C0")]
	public HHLCOCJONBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class GOBCGJOPCNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x33E75C0", Offset = "0x33E69C0", VA = "0x1833E75C0")]
	public static DateTime JDLIMEOLDLP(DateTime HCBPGNDPOFE)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class IMIMLLPPIKD : global::BFPOGOEJBPA<DateTime>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::BFPOGOEJBPA<DateTime> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4221830", Offset = "0x4220C30", VA = "0x184221830", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, DateTime MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4221C80", Offset = "0x4221080", VA = "0x184221C80", Slot = "5")]
	public DateTime NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public IMIMLLPPIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class GNCMGOPDPCK : global::BFPOGOEJBPA<DateTimeOffset>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::BFPOGOEJBPA<DateTimeOffset> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x33E5AC0", Offset = "0x33E4EC0", VA = "0x1833E5AC0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, DateTimeOffset MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x33E6680", Offset = "0x33E5A80", VA = "0x1833E6680", Slot = "5")]
	public DateTimeOffset NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public GNCMGOPDPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HIGJLPOJBKM : global::BFPOGOEJBPA<TimeSpan>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::BFPOGOEJBPA<TimeSpan> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] NLKJGFAMAHF;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x33E9520", Offset = "0x33E8920", VA = "0x1833E9520", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, TimeSpan MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x33E99C0", Offset = "0x33E8DC0", VA = "0x1833E99C0", Slot = "5")]
	public TimeSpan NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HIGJLPOJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class ONIEOIDDLOB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::BFPOGOEJBPA<TDictionary>, NPKKFPKKFLD where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4FA0", Offset = "0x3CC43A0", VA = "0x183CC4FA0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, TDictionary MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3CC75D0", Offset = "0x3CC69D0", VA = "0x183CC75D0", Slot = "5")]
	public TDictionary NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator ONFKLIDKLBL(TDictionary CJIAPCFJKNL);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DDAMABLPPOO();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KCLLGEJMGAB(ref TIntermediate PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary KNOFFOGILML(ref TIntermediate FAOIJEMLJEB);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
	protected ONIEOIDDLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class GEMAJAPJKLB<TKey, TValue, TIntermediate, TDictionary> : global::ONIEOIDDLOB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2F391F0", Offset = "0x2F385F0", VA = "0x182F391F0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> ONFKLIDKLBL(TDictionary CJIAPCFJKNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class JMNDHPEHECH<TKey, TValue, TDictionary> : global::GEMAJAPJKLB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override TDictionary KNOFFOGILML(ref TDictionary FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class PJLLBBKEIBO<TKey, TValue> : global::ONIEOIDDLOB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3665350", Offset = "0x3664750", VA = "0x183665350", Slot = "8")]
	protected override void KCLLGEJMGAB(ref Dictionary<TKey, TValue> PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override Dictionary<TKey, TValue> KNOFFOGILML(ref Dictionary<TKey, TValue> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3665390", Offset = "0x3664790", VA = "0x183665390", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator ONFKLIDKLBL(Dictionary<TKey, TValue> CJIAPCFJKNL)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1C2C230", Offset = "0x1C2B630", VA = "0x181C2C230")]
	public PJLLBBKEIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class HAILGCGMALK<TKey, TValue, TDictionary> : global::JMNDHPEHECH<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x37430A0", Offset = "0x37424A0", VA = "0x1837430A0", Slot = "8")]
	protected override void KCLLGEJMGAB(ref TDictionary PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x293B660", Offset = "0x293AA60", VA = "0x18293B660", Slot = "7")]
	protected override TDictionary DDAMABLPPOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class ENDLBPFCHLI<TKey, TValue> : global::GEMAJAPJKLB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x35C1620", Offset = "0x35C0A20", VA = "0x1835C1620", Slot = "8")]
	protected override void KCLLGEJMGAB(ref Dictionary<TKey, TValue> PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override Dictionary<TKey, TValue> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override IDictionary<TKey, TValue> KNOFFOGILML(ref Dictionary<TKey, TValue> FAOIJEMLJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NKACCDNDJHI<TKey, TValue> : global::JMNDHPEHECH<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x35C1620", Offset = "0x35C0A20", VA = "0x1835C1620", Slot = "8")]
	protected override void KCLLGEJMGAB(ref SortedList<TKey, TValue> PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override SortedList<TKey, TValue> DDAMABLPPOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class FNEMIBGJDLA<TKey, TValue> : global::ONIEOIDDLOB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x35C1620", Offset = "0x35C0A20", VA = "0x1835C1620", Slot = "8")]
	protected override void KCLLGEJMGAB(ref SortedDictionary<TKey, TValue> PDDJFCOJOLJ, int DBFCFFLFJDL, TKey KACNOLACOBJ, TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1121660", Offset = "0x1120A60", VA = "0x181121660", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> KNOFFOGILML(ref SortedDictionary<TKey, TValue> FAOIJEMLJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1F3E8C0", Offset = "0x1F3DCC0", VA = "0x181F3E8C0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DDAMABLPPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x38DD840", Offset = "0x38DCC40", VA = "0x1838DD840", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator ONFKLIDKLBL(SortedDictionary<TKey, TValue> CJIAPCFJKNL)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class MCLJEPANKKG<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class FHIICEDLIKM : global::BFPOGOEJBPA<IDictionary>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::BFPOGOEJBPA<IDictionary> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x33DDA60", Offset = "0x33DCE60", VA = "0x1833DDA60", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, IDictionary MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x33DDEF0", Offset = "0x33DD2F0", VA = "0x1833DDEF0", Slot = "5")]
	public IDictionary NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public FHIICEDLIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class KNKKDBHONAD : global::BFPOGOEJBPA<object>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void ABEEMAOEIGN(object BNPNBAPEEFC, ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::DPINBBJCAPM<KeyValuePair<object, ABEEMAOEIGN>> EAHNEAEAHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly FLGJCMOKHGL[] NDEKPGPBDOL;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x4226070", Offset = "0x4225470", VA = "0x184226070")]
	public KNKKDBHONAD(params FLGJCMOKHGL[] NDEKPGPBDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x42256F0", Offset = "0x4224AF0", VA = "0x1842256F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4225FE0", Offset = "0x42253E0", VA = "0x184225FE0", Slot = "5")]
	public object NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EBHBLJDCHKF
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x33D84B0", Offset = "0x33D78B0", VA = "0x1833D84B0")]
	public static object IFMCKDFMMAD(Type HHDFIJECABM, out bool MIMNDLFJIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x33D7CD0", Offset = "0x33D70D0", VA = "0x1833D7CD0")]
	public static object GGONDJHFBPL(Type HHDFIJECABM, out bool MIMNDLFJIDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class EHBEINLEEAL<T> : global::BFPOGOEJBPA<T>, NPKKFPKKFLD, global::LEIMJFDODOP<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class BOENOHDJBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public BOENOHDJBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBB80", Offset = "0x3ECAF80", VA = "0x183ECBB80")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class CHCCBMILCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::KHINOOOLBII<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public CHCCBMILCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC300", Offset = "0x3ECB700", VA = "0x183ECC300")]
		internal void <.cctor>b__1(ref ELHPCBKIJOC writer, T value, FLGJCMOKHGL _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HMELPMHELIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::FMGEFDIKCGE<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public HMELPMHELIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3230", Offset = "0x3EE2630", VA = "0x183EE3230")]
		internal T <.cctor>b__2(ref BJFAHAPJAFA reader, FLGJCMOKHGL _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::PFLDMGPLLOG<T> IPJDGGCIAPP;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> PCHNPGHEIBJ;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::KHINOOOLBII<T> OPCLIFNGFBP;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::FMGEFDIKCGE<T> BPKPCABABIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool OHHMKIPDOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::KHINOOOLBII<T> GPKKFNGGDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::FMGEFDIKCGE<T> GABAJFJNNEM;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5F60", Offset = "0x3ED5360", VA = "0x183ED5F60")]
	static EHBEINLEEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2970", Offset = "0x3EE1D70", VA = "0x183EE2970")]
	public EHBEINLEEAL(bool OHHMKIPDOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF100", Offset = "0x3ECE500", VA = "0x183ECF100", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2A00", Offset = "0x3ED1E00", VA = "0x183ED2A00", Slot = "5")]
	public T NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3ECFE60", Offset = "0x3ECF260", VA = "0x183ECFE60", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, T MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0830", Offset = "0x3ECFC30", VA = "0x183ED0830", Slot = "7")]
	public T IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class OLLBPJBKGGN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class CNBPNABHJIK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LOACCKPKLCA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class GEBMKNHLAIB<T> : global::BFPOGOEJBPA<T?>, NPKKFPKKFLD where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2F35D50", Offset = "0x2F35150", VA = "0x182F35D50", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, T? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2F36000", Offset = "0x2F35400", VA = "0x182F36000", Slot = "5")]
	public T? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
	public GEBMKNHLAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class AEPNLJHEDNI<T> : global::BFPOGOEJBPA<T?>, NPKKFPKKFLD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::BFPOGOEJBPA<T> EALCAAOFBEH;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
	public AEPNLJHEDNI(global::BFPOGOEJBPA<T> EALCAAOFBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x33841C0", Offset = "0x33835C0", VA = "0x1833841C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, T? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3384E10", Offset = "0x3384210", VA = "0x183384E10", Slot = "5")]
	public T? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class IEHKNJGAHPB : global::BFPOGOEJBPA<sbyte>, NPKKFPKKFLD, global::LEIMJFDODOP<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly IEHKNJGAHPB NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x33EC200", Offset = "0x33EB600", VA = "0x1833EC200", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, sbyte MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x33EC3A0", Offset = "0x33EB7A0", VA = "0x1833EC3A0", Slot = "5")]
	public sbyte NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x33EC240", Offset = "0x33EB640", VA = "0x1833EC240", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, sbyte MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x33EC300", Offset = "0x33EB700", VA = "0x1833EC300", Slot = "7")]
	public sbyte IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public IEHKNJGAHPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class DBHNONJLEDC : global::BFPOGOEJBPA<sbyte?>, NPKKFPKKFLD, global::LEIMJFDODOP<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly DBHNONJLEDC NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3308290", Offset = "0x3307690", VA = "0x183308290", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, sbyte? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3308430", Offset = "0x3307830", VA = "0x183308430", Slot = "5")]
	public sbyte? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3308300", Offset = "0x3307700", VA = "0x183308300", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, sbyte? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3308380", Offset = "0x3307780", VA = "0x183308380", Slot = "7")]
	public sbyte? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public DBHNONJLEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class NCPJMPDIKAJ : global::BFPOGOEJBPA<sbyte[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly NCPJMPDIKAJ NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x422A020", Offset = "0x4229420", VA = "0x18422A020", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, sbyte[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x422A0E0", Offset = "0x42294E0", VA = "0x18422A0E0", Slot = "5")]
	public sbyte[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public NCPJMPDIKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class KCDKAAFGIOM : global::BFPOGOEJBPA<short>, NPKKFPKKFLD, global::LEIMJFDODOP<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly KCDKAAFGIOM NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4225470", Offset = "0x4224870", VA = "0x184225470", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, short MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4225540", Offset = "0x4224940", VA = "0x184225540", Slot = "5")]
	public short NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4225490", Offset = "0x4224890", VA = "0x184225490", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, short MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x42254D0", Offset = "0x42248D0", VA = "0x1842254D0", Slot = "7")]
	public short IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public KCDKAAFGIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class LIGKMFHALGI : global::BFPOGOEJBPA<short?>, NPKKFPKKFLD, global::LEIMJFDODOP<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly LIGKMFHALGI NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4226F50", Offset = "0x4226350", VA = "0x184226F50", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, short? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x42270E0", Offset = "0x42264E0", VA = "0x1842270E0", Slot = "5")]
	public short? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4226FC0", Offset = "0x42263C0", VA = "0x184226FC0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, short? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4227040", Offset = "0x4226440", VA = "0x184227040", Slot = "7")]
	public short? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public LIGKMFHALGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class CLGKECHMGEG : global::BFPOGOEJBPA<short[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly CLGKECHMGEG NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3307900", Offset = "0x3306D00", VA = "0x183307900", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, short[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x33079C0", Offset = "0x3306DC0", VA = "0x1833079C0", Slot = "5")]
	public short[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CLGKECHMGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class CKEEKJBIJFG : global::BFPOGOEJBPA<int>, NPKKFPKKFLD, global::LEIMJFDODOP<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly CKEEKJBIJFG NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3307780", Offset = "0x3306B80", VA = "0x183307780", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, int MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3307840", Offset = "0x3306C40", VA = "0x183307840", Slot = "5")]
	public int NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3307790", Offset = "0x3306B90", VA = "0x183307790", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, int MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x33077D0", Offset = "0x3306BD0", VA = "0x1833077D0", Slot = "7")]
	public int IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CKEEKJBIJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CPCFBENNMON : global::BFPOGOEJBPA<int?>, NPKKFPKKFLD, global::LEIMJFDODOP<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly CPCFBENNMON NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3307E60", Offset = "0x3307260", VA = "0x183307E60", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, int? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3307FF0", Offset = "0x33073F0", VA = "0x183307FF0", Slot = "5")]
	public int? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3307ED0", Offset = "0x33072D0", VA = "0x183307ED0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, int? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3307F50", Offset = "0x3307350", VA = "0x183307F50", Slot = "7")]
	public int? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CPCFBENNMON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class OMBCAPFCFCM : global::BFPOGOEJBPA<int[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly OMBCAPFCFCM NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x422C8A0", Offset = "0x422BCA0", VA = "0x18422C8A0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, int[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x422C960", Offset = "0x422BD60", VA = "0x18422C960", Slot = "5")]
	public int[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OMBCAPFCFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class EJFKKJDNNMC : global::BFPOGOEJBPA<long>, NPKKFPKKFLD, global::LEIMJFDODOP<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly EJFKKJDNNMC NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x33DACD0", Offset = "0x33DA0D0", VA = "0x1833DACD0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, long MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x33DAEA0", Offset = "0x33DA2A0", VA = "0x1833DAEA0", Slot = "5")]
	public long NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x33DAD00", Offset = "0x33DA100", VA = "0x1833DAD00", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, long MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x33DADC0", Offset = "0x33DA1C0", VA = "0x1833DADC0", Slot = "7")]
	public long IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EJFKKJDNNMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class FNOKNJKINOH : global::BFPOGOEJBPA<long?>, NPKKFPKKFLD, global::LEIMJFDODOP<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly FNOKNJKINOH NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x33DEA10", Offset = "0x33DDE10", VA = "0x1833DEA10", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, long? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x33DEC50", Offset = "0x33DE050", VA = "0x1833DEC50", Slot = "5")]
	public long? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x33DEA90", Offset = "0x33DDE90", VA = "0x1833DEA90", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, long? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x33DEB90", Offset = "0x33DDF90", VA = "0x1833DEB90", Slot = "7")]
	public long? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public FNOKNJKINOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class JBLBCGFFEOL : global::BFPOGOEJBPA<long[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly JBLBCGFFEOL NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x42234F0", Offset = "0x42228F0", VA = "0x1842234F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, long[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x42235B0", Offset = "0x42229B0", VA = "0x1842235B0", Slot = "5")]
	public long[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public JBLBCGFFEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class CPIEGMCIAFN : global::BFPOGOEJBPA<byte>, NPKKFPKKFLD, global::LEIMJFDODOP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly CPIEGMCIAFN NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3308100", Offset = "0x3307500", VA = "0x183308100", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, byte MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x33081D0", Offset = "0x33075D0", VA = "0x1833081D0", Slot = "5")]
	public byte NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3308120", Offset = "0x3307520", VA = "0x183308120", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, byte MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3308160", Offset = "0x3307560", VA = "0x183308160", Slot = "7")]
	public byte IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CPIEGMCIAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PDAEBNJPNEM : global::BFPOGOEJBPA<byte?>, NPKKFPKKFLD, global::LEIMJFDODOP<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly PDAEBNJPNEM NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x422E720", Offset = "0x422DB20", VA = "0x18422E720", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, byte? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x422E8C0", Offset = "0x422DCC0", VA = "0x18422E8C0", Slot = "5")]
	public byte? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x422E790", Offset = "0x422DB90", VA = "0x18422E790", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, byte? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x422E810", Offset = "0x422DC10", VA = "0x18422E810", Slot = "7")]
	public byte? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public PDAEBNJPNEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class KAGCKCGMGAM : global::BFPOGOEJBPA<ushort>, NPKKFPKKFLD, global::LEIMJFDODOP<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly KAGCKCGMGAM NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4225330", Offset = "0x4224730", VA = "0x184225330", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ushort MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x4225400", Offset = "0x4224800", VA = "0x184225400", Slot = "5")]
	public ushort NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x4225350", Offset = "0x4224750", VA = "0x184225350", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, ushort MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4225390", Offset = "0x4224790", VA = "0x184225390", Slot = "7")]
	public ushort IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public KAGCKCGMGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class FIJCDMHFKDM : global::BFPOGOEJBPA<ushort?>, NPKKFPKKFLD, global::LEIMJFDODOP<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly FIJCDMHFKDM NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x33DE5B0", Offset = "0x33DD9B0", VA = "0x1833DE5B0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ushort? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x33DE800", Offset = "0x33DDC00", VA = "0x1833DE800", Slot = "5")]
	public ushort? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x33DE630", Offset = "0x33DDA30", VA = "0x1833DE630", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, ushort? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x33DE730", Offset = "0x33DDB30", VA = "0x1833DE730", Slot = "7")]
	public ushort? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public FIJCDMHFKDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class IHNCIGIJAIB : global::BFPOGOEJBPA<ushort[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IHNCIGIJAIB NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x33EC410", Offset = "0x33EB810", VA = "0x1833EC410", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ushort[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x33EC5B0", Offset = "0x33EB9B0", VA = "0x1833EC5B0", Slot = "5")]
	public ushort[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public IHNCIGIJAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class EGNCNFHNLIG : global::BFPOGOEJBPA<uint>, NPKKFPKKFLD, global::LEIMJFDODOP<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly EGNCNFHNLIG NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x33DA9C0", Offset = "0x33D9DC0", VA = "0x1833DA9C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, uint MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x33DAB50", Offset = "0x33D9F50", VA = "0x1833DAB50", Slot = "5")]
	public uint NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x33DA9F0", Offset = "0x33D9DF0", VA = "0x1833DA9F0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, uint MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x33DAAB0", Offset = "0x33D9EB0", VA = "0x1833DAAB0", Slot = "7")]
	public uint IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EGNCNFHNLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class CEDLJMGMJCC : global::BFPOGOEJBPA<uint?>, NPKKFPKKFLD, global::LEIMJFDODOP<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CEDLJMGMJCC NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x33073F0", Offset = "0x33067F0", VA = "0x1833073F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, uint? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3307580", Offset = "0x3306980", VA = "0x183307580", Slot = "5")]
	public uint? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x3307460", Offset = "0x3306860", VA = "0x183307460", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, uint? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x33074E0", Offset = "0x33068E0", VA = "0x1833074E0", Slot = "7")]
	public uint? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CEDLJMGMJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MPNPNFNPIDE : global::BFPOGOEJBPA<uint[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MPNPNFNPIDE NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4229D10", Offset = "0x4229110", VA = "0x184229D10", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, uint[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x4229DD0", Offset = "0x42291D0", VA = "0x184229DD0", Slot = "5")]
	public uint[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public MPNPNFNPIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class JOCMNLBDACD : global::BFPOGOEJBPA<ulong>, NPKKFPKKFLD, global::LEIMJFDODOP<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly JOCMNLBDACD NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x42251F0", Offset = "0x42245F0", VA = "0x1842251F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ulong MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x42252C0", Offset = "0x42246C0", VA = "0x1842252C0", Slot = "5")]
	public ulong NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4225210", Offset = "0x4224610", VA = "0x184225210", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, ulong MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4225250", Offset = "0x4224650", VA = "0x184225250", Slot = "7")]
	public ulong IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public JOCMNLBDACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class NPLBGGLNEHO : global::BFPOGOEJBPA<ulong?>, NPKKFPKKFLD, global::LEIMJFDODOP<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly NPLBGGLNEHO NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x422BA10", Offset = "0x422AE10", VA = "0x18422BA10", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ulong? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x422BBC0", Offset = "0x422AFC0", VA = "0x18422BBC0", Slot = "5")]
	public ulong? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x422BA80", Offset = "0x422AE80", VA = "0x18422BA80", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, ulong? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x422BB00", Offset = "0x422AF00", VA = "0x18422BB00", Slot = "7")]
	public ulong? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public NPLBGGLNEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EAHLHGOJOCI : global::BFPOGOEJBPA<ulong[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EAHLHGOJOCI NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x33D7680", Offset = "0x33D6A80", VA = "0x1833D7680", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ulong[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x33D7820", Offset = "0x33D6C20", VA = "0x1833D7820", Slot = "5")]
	public ulong[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EAHLHGOJOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class OONAAHBLCOK : global::BFPOGOEJBPA<float>, NPKKFPKKFLD, global::LEIMJFDODOP<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly OONAAHBLCOK NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x422E4B0", Offset = "0x422D8B0", VA = "0x18422E4B0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, float MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x422E570", Offset = "0x422D970", VA = "0x18422E570", Slot = "5")]
	public float NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x422E4C0", Offset = "0x422D8C0", VA = "0x18422E4C0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, float MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x422E500", Offset = "0x422D900", VA = "0x18422E500", Slot = "7")]
	public float IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OONAAHBLCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class JKKLGPDHDII : global::BFPOGOEJBPA<float?>, NPKKFPKKFLD, global::LEIMJFDODOP<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly JKKLGPDHDII NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4224D10", Offset = "0x4224110", VA = "0x184224D10", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, float? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4224EA0", Offset = "0x42242A0", VA = "0x184224EA0", Slot = "5")]
	public float? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4224D80", Offset = "0x4224180", VA = "0x184224D80", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, float? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4224E00", Offset = "0x4224200", VA = "0x184224E00", Slot = "7")]
	public float? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public JKKLGPDHDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class BJPKMDBCJFC : global::BFPOGOEJBPA<float[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BJPKMDBCJFC NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x33064F0", Offset = "0x33058F0", VA = "0x1833064F0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, float[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x33065B0", Offset = "0x33059B0", VA = "0x1833065B0", Slot = "5")]
	public float[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public BJPKMDBCJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class HDDFEMPKIDJ : global::BFPOGOEJBPA<double>, NPKKFPKKFLD, global::LEIMJFDODOP<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly HDDFEMPKIDJ NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x33E92C0", Offset = "0x33E86C0", VA = "0x1833E92C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, double MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x33E94B0", Offset = "0x33E88B0", VA = "0x1833E94B0", Slot = "5")]
	public double NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x33E92D0", Offset = "0x33E86D0", VA = "0x1833E92D0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, double MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x33E9380", Offset = "0x33E8780", VA = "0x1833E9380", Slot = "7")]
	public double IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HDDFEMPKIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class MMCOMCHGMIN : global::BFPOGOEJBPA<double?>, NPKKFPKKFLD, global::LEIMJFDODOP<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly MMCOMCHGMIN NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4229A70", Offset = "0x4228E70", VA = "0x184229A70", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, double? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4229C20", Offset = "0x4229020", VA = "0x184229C20", Slot = "5")]
	public double? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4229AE0", Offset = "0x4228EE0", VA = "0x184229AE0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, double? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4229B60", Offset = "0x4228F60", VA = "0x184229B60", Slot = "7")]
	public double? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public MMCOMCHGMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class HPJMPIBGPKN : global::BFPOGOEJBPA<double[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly HPJMPIBGPKN NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x33EB550", Offset = "0x33EA950", VA = "0x1833EB550", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, double[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x33EB730", Offset = "0x33EAB30", VA = "0x1833EB730", Slot = "5")]
	public double[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HPJMPIBGPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LNJCGMBFJJB : global::BFPOGOEJBPA<bool>, NPKKFPKKFLD, global::LEIMJFDODOP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LNJCGMBFJJB NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x42279A0", Offset = "0x4226DA0", VA = "0x1842279A0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, bool MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4227A70", Offset = "0x4226E70", VA = "0x184227A70", Slot = "5")]
	public bool NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x42279C0", Offset = "0x4226DC0", VA = "0x1842279C0", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, bool MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x4227A00", Offset = "0x4226E00", VA = "0x184227A00", Slot = "7")]
	public bool IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public LNJCGMBFJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class DPMMFOPJNKO : global::BFPOGOEJBPA<bool?>, NPKKFPKKFLD, global::LEIMJFDODOP<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly DPMMFOPJNKO NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x33D73A0", Offset = "0x33D67A0", VA = "0x1833D73A0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, bool? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x33D75B0", Offset = "0x33D69B0", VA = "0x1833D75B0", Slot = "5")]
	public bool? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x33D7410", Offset = "0x33D6810", VA = "0x1833D7410", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, bool? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x33D7500", Offset = "0x33D6900", VA = "0x1833D7500", Slot = "7")]
	public bool? IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public DPMMFOPJNKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DILEIFFFNII : global::BFPOGOEJBPA<bool[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DILEIFFFNII NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x33086C0", Offset = "0x3307AC0", VA = "0x1833086C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, bool[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x3308790", Offset = "0x3307B90", VA = "0x183308790", Slot = "5")]
	public bool[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public DILEIFFFNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class JFDHFKFHJCG : global::BFPOGOEJBPA<object>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::BFPOGOEJBPA<object> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> MHKJAAEBMID;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x4223C70", Offset = "0x4223070", VA = "0x184223C70", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, object MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4224620", Offset = "0x4223A20", VA = "0x184224620", Slot = "5")]
	public object NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public JFDHFKFHJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class GBGLJOAEHHF : global::BFPOGOEJBPA<byte[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::BFPOGOEJBPA<byte[]> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x33E23D0", Offset = "0x33E17D0", VA = "0x1833E23D0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, byte[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x33E2460", Offset = "0x33E1860", VA = "0x1833E2460", Slot = "5")]
	public byte[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public GBGLJOAEHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class OLDAFFLFDKD : global::BFPOGOEJBPA<ArraySegment<byte>>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::BFPOGOEJBPA<ArraySegment<byte>> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x422C5C0", Offset = "0x422B9C0", VA = "0x18422C5C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, ArraySegment<byte> MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x422C660", Offset = "0x422BA60", VA = "0x18422C660", Slot = "5")]
	public ArraySegment<byte> NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OLDAFFLFDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GIFFDKCMKIP : global::BFPOGOEJBPA<string>, NPKKFPKKFLD, global::LEIMJFDODOP<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::BFPOGOEJBPA<string> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x33E5340", Offset = "0x33E4740", VA = "0x1833E5340", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, string MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x33E5360", Offset = "0x33E4760", VA = "0x1833E5360", Slot = "5")]
	public string NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x33E5340", Offset = "0x33E4740", VA = "0x1833E5340", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, string MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x33E5360", Offset = "0x33E4760", VA = "0x1833E5360", Slot = "7")]
	public string IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public GIFFDKCMKIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HJLHANPJLHE : global::BFPOGOEJBPA<string[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly HJLHANPJLHE NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x33EAC80", Offset = "0x33EA080", VA = "0x1833EAC80", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, string[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x33EAE00", Offset = "0x33EA200", VA = "0x1833EAE00", Slot = "5")]
	public string[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HJLHANPJLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class OLIBOLHAEAP : global::BFPOGOEJBPA<char>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly OLIBOLHAEAP NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x422C790", Offset = "0x422BB90", VA = "0x18422C790", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, char MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x422C810", Offset = "0x422BC10", VA = "0x18422C810", Slot = "5")]
	public char NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OLIBOLHAEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class DJJALBGMIPI : global::BFPOGOEJBPA<char?>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly DJJALBGMIPI NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x3308D40", Offset = "0x3308140", VA = "0x183308D40", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, char? MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3308E10", Offset = "0x3308210", VA = "0x183308E10", Slot = "5")]
	public char? NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public DJJALBGMIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HLIKBGCEAHE : global::BFPOGOEJBPA<char[]>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly HLIKBGCEAHE NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x33EB000", Offset = "0x33EA400", VA = "0x1833EB000", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, char[] MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x33EB240", Offset = "0x33EA640", VA = "0x1833EB240", Slot = "5")]
	public char[] NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HLIKBGCEAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class OBBIPFDJKEB : global::BFPOGOEJBPA<Guid>, NPKKFPKKFLD, global::LEIMJFDODOP<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::BFPOGOEJBPA<Guid> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x422BDA0", Offset = "0x422B1A0", VA = "0x18422BDA0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Guid MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x422BF60", Offset = "0x422B360", VA = "0x18422BF60", Slot = "5")]
	public Guid NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x422BE80", Offset = "0x422B280", VA = "0x18422BE80", Slot = "6")]
	public void ILFOFNHAFGI(ref ELHPCBKIJOC AJGCNLDPDIN, Guid MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x422BF60", Offset = "0x422B360", VA = "0x18422BF60", Slot = "7")]
	public Guid IOCAMODKKLG(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public OBBIPFDJKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class AINPLCOLGAJ : global::BFPOGOEJBPA<decimal>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::BFPOGOEJBPA<decimal> NHBAGNNNDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool EEEAIDLBPNP;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xB30570", Offset = "0xB2F970", VA = "0x180B30570")]
	public AINPLCOLGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xFB9C30", Offset = "0xFB9030", VA = "0x180FB9C30")]
	public AINPLCOLGAJ(bool EEEAIDLBPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x3300C80", Offset = "0x3300080", VA = "0x183300C80", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, decimal MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x3300DC0", Offset = "0x33001C0", VA = "0x183300DC0", Slot = "5")]
	public decimal NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class EBDFMIAFNAI : global::BFPOGOEJBPA<Uri>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::BFPOGOEJBPA<Uri> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x33D79C0", Offset = "0x33D6DC0", VA = "0x1833D79C0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Uri MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x33D7A70", Offset = "0x33D6E70", VA = "0x1833D7A70", Slot = "5")]
	public Uri NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public EBDFMIAFNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class AJMCDNLCFHN : global::BFPOGOEJBPA<Version>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::BFPOGOEJBPA<Version> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3300FD0", Offset = "0x33003D0", VA = "0x183300FD0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Version MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x3301080", Offset = "0x3300480", VA = "0x183301080", Slot = "5")]
	public Version NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public AJMCDNLCFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class GHBKMGBNAFP<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class PMGFEJBCLLN : global::BFPOGOEJBPA<StringBuilder>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::BFPOGOEJBPA<StringBuilder> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x422F080", Offset = "0x422E480", VA = "0x18422F080", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, StringBuilder MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x422F0D0", Offset = "0x422E4D0", VA = "0x18422F0D0", Slot = "5")]
	public StringBuilder NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public PMGFEJBCLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class ENCFHLDJNKI : global::BFPOGOEJBPA<BitArray>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::BFPOGOEJBPA<BitArray> NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x33DD510", Offset = "0x33DC910", VA = "0x1833DD510", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, BitArray MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x33DD610", Offset = "0x33DCA10", VA = "0x1833DD610", Slot = "5")]
	public BitArray NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public ENCFHLDJNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class PPMLLCGKNAK : global::BFPOGOEJBPA<Type>, NPKKFPKKFLD
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly PPMLLCGKNAK NHBAGNNNDIM;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex CJIEMDHJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool FPBAOOOJAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool DPNAMKEJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool LHKNPNOBFIO;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x422F4B0", Offset = "0x422E8B0", VA = "0x18422F4B0")]
	public PPMLLCGKNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x422F460", Offset = "0x422E860", VA = "0x18422F460")]
	public PPMLLCGKNAK(bool FPBAOOOJAIF, bool DPNAMKEJNKH, bool LHKNPNOBFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x422F1B0", Offset = "0x422E5B0", VA = "0x18422F1B0", Slot = "4")]
	public void EIOHABDHFHD(ref ELHPCBKIJOC AJGCNLDPDIN, Type MGNFAPLJAOB, FLGJCMOKHGL FMCBDKNKBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x422F2A0", Offset = "0x422E6A0", VA = "0x18422F2A0", Slot = "5")]
	public Type NJNBMDCLBPB(ref BJFAHAPJAFA ACCMDMPIIKM, FLGJCMOKHGL FMCBDKNKBJH)
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
