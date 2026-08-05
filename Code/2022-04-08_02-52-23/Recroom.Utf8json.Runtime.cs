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
public class MOELFIGAJEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x522480", Offset = "0x521280", VA = "0x180522480")]
	public MOELFIGAJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class LLONGNMJOLH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x522480", Offset = "0x521280", VA = "0x180522480")]
	public LLONGNMJOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LEKICEGNAAH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x522480", Offset = "0x521280", VA = "0x180522480")]
	public LEKICEGNAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class GGCMPFFFCKD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x522480", Offset = "0x521280", VA = "0x180522480")]
	public GGCMPFFFCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class EBEJGDBENMH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3866B00", Offset = "0x3865900", VA = "0x183866B00")]
	public static bool GLIFCHBPPOH(this TypeInfo FEGCMBEFABH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class HKOGMCIDICO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FDFKJJKNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PAGGONMPIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7120", VA = "0x1806E8320")]
	public HKOGMCIDICO(Type MAJFEMLCDAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class HAMLFMLPHIN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ACJEJABPPJJ<T>(ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T MMBCJADJOPN<T>(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH EJKAMLKIILE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface POOHDCJJHAO
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EAILOOFMBAA<T> : POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DINKDOIEAEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LIEOELCGNLK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EAILOOFMBAA<T> JEPJKOECGPB<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BNGNENDCONC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0860", Offset = "0x2EEF660", VA = "0x182EF0860")]
	public static global::EAILOOFMBAA<T> LGMOBCBONFE<T>(this JLIBPADHAKH EJKAMLKIILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x385C740", Offset = "0x385B540", VA = "0x18385C740")]
	public static object DOIDJBDGJAN(this JLIBPADHAKH EJKAMLKIILE, Type FEGCMBEFABH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKHCKJKCPOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3860190", Offset = "0x385EF90", VA = "0x183860190")]
	public CKHCKJKCPOD(string FJNMEOAHDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CHIKEMHDNHC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class ACCCLMIKNKN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DLJHFCENONG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LGHMGNGOMDE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3858140", Offset = "0x3856F40", VA = "0x183858140")]
		public static byte[] ICCOFGLAEON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x38580B0", Offset = "0x3856EB0", VA = "0x1838580B0")]
		public static char[] GPJHOLBLGIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GFKKOPBDNIL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] HOICFNBIJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] IEDOMBJDKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CAOPPMKILFB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FMMMGCFIKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x385E4D0", Offset = "0x385D2D0", VA = "0x18385E4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3860180", Offset = "0x385EF80", VA = "0x183860180")]
	public CHIKEMHDNHC(byte[] IEDOMBJDKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x385FFA0", Offset = "0x385EDA0", VA = "0x18385FFA0")]
	public CHIKEMHDNHC(byte[] IEDOMBJDKEO, int CAOPPMKILFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x385D6B0", Offset = "0x385C4B0", VA = "0x18385D6B0")]
	private IJOPHFFDDPI CEOOHLBOKPD(string KDPGKLHOOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x385E940", Offset = "0x385D740", VA = "0x18385E940")]
	private IJOPHFFDDPI HPFMBPIJENP(string FJNMEOAHDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35FAE20", Offset = "0x35F9C20", VA = "0x1835FAE20")]
	public void GKOHMMFMINC(int CAOPPMKILFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C6380", Offset = "0x5C5180", VA = "0x1805C6380")]
	public byte[] EHEKDIIDAGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2A0", Offset = "0x6DA0A0", VA = "0x1806DB2A0")]
	public int NDGOALLKPMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x385EA80", Offset = "0x385D880", VA = "0x18385EA80")]
	public ANNNKCACKBI IJJMDCGPIHC()
	{
		return default(ANNNKCACKBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x385EC10", Offset = "0x385DA10", VA = "0x18385EC10")]
	public void INMGFIGKEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x385E820", Offset = "0x385D620", VA = "0x18385E820")]
	public bool HNBGGJFJLLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x385EE00", Offset = "0x385DC00", VA = "0x18385EE00")]
	public bool IPLFFJFPPOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x385F760", Offset = "0x385E560", VA = "0x18385F760")]
	public void KHLPEJBONLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x385E660", Offset = "0x385D460", VA = "0x18385E660")]
	public bool GMNNALFGNNC(ref int FDHPLBOBCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x385FDF0", Offset = "0x385EBF0", VA = "0x18385FDF0")]
	public bool OPOFBFMKGBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x385E6F0", Offset = "0x385D4F0", VA = "0x18385E6F0")]
	public void HECLIGJHELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x385E790", Offset = "0x385D590", VA = "0x18385E790")]
	public bool HLCNDCDBHMO(ref int FDHPLBOBCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x385FD10", Offset = "0x385EB10", VA = "0x18385FD10")]
	public bool NNFKHAPCGDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x385DD00", Offset = "0x385CB00", VA = "0x18385DD00")]
	public void DEDAMBHEKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x385E460", Offset = "0x385D260", VA = "0x18385E460")]
	public bool EIPPCAMCIKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x385E4F0", Offset = "0x385D2F0", VA = "0x18385E4F0")]
	public void EJKCNBGANCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x385EF90", Offset = "0x385DD90", VA = "0x18385EF90")]
	private void KCMEEAKEKFE(out byte[] BPFACBEPCJF, out int BBBDFAHNENB, out int EAANJKEKGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x385ED50", Offset = "0x385DB50", VA = "0x18385ED50")]
	private static int IPBFEKEELCF(char OCNFPNPPOJC, char BAHCPBFJIGN, char PMOBKAEONAF, char NBJFNMANLHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x385E590", Offset = "0x385D390", VA = "0x18385E590")]
	private static int GMJFDLFPJCB(char DCMLOLBECIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x385F800", Offset = "0x385E600", VA = "0x18385F800")]
	public ArraySegment<byte> KJGCLABNIGB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x385FC70", Offset = "0x385EA70", VA = "0x18385FC70")]
	public string NEBAEIFOFPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x385D5C0", Offset = "0x385C3C0", VA = "0x18385D5C0")]
	public string AHMEMOGGBGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x385DB50", Offset = "0x385C950", VA = "0x18385DB50")]
	public ArraySegment<byte> CJECHPMBCFE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x385F720", Offset = "0x385E520", VA = "0x18385F720")]
	public ArraySegment<byte> KGHBIPPIKDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x385E200", Offset = "0x385D000", VA = "0x18385E200")]
	public bool EADHMLFCEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x385D5F0", Offset = "0x385C3F0", VA = "0x18385D5F0")]
	private static bool BLBAAAIKNNO(byte PMOBKAEONAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x385DDA0", Offset = "0x385CBA0", VA = "0x18385DDA0")]
	private void DJMJHIIEPJI(ANNNKCACKBI JFEIMLLHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x385FDE0", Offset = "0x385EBE0", VA = "0x18385FDE0")]
	public void OBNNDMOAIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x385FA80", Offset = "0x385E880", VA = "0x18385FA80")]
	private void KPHPCEMLNKK(int LNCNCFNLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x385FA30", Offset = "0x385E830", VA = "0x18385FA30")]
	public sbyte KOPGPAOCIGH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x385EA20", Offset = "0x385D820", VA = "0x18385EA20")]
	public short IHNFCOJBDOO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x385EF30", Offset = "0x385DD30", VA = "0x18385EF30")]
	public int KBNGCPOFBFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x385E0F0", Offset = "0x385CEF0", VA = "0x18385E0F0")]
	public long DOPBIEDGIIN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x385FD80", Offset = "0x385EB80", VA = "0x18385FD80")]
	public byte OBGGGAEPLHN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x385FE60", Offset = "0x385EC60", VA = "0x18385FE60")]
	public ushort PMIOKGHOEHH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x385D560", Offset = "0x385C360", VA = "0x18385D560")]
	public uint ADHLIJAIHKK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x385F9B0", Offset = "0x385E7B0", VA = "0x18385F9B0")]
	public ulong KONKEJCNGAA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x385EE70", Offset = "0x385DC70", VA = "0x18385EE70")]
	public float JKMKELGFOIC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x385F8F0", Offset = "0x385E6F0", VA = "0x18385F8F0")]
	public double KNKBNPEPNLG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x385FB50", Offset = "0x385E950", VA = "0x18385FB50")]
	public ArraySegment<byte> MEHJBHPMKFC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x385DF70", Offset = "0x385CD70", VA = "0x18385DF70")]
	private static int DMFFJJLCPLN(byte[] IEDOMBJDKEO, int CAOPPMKILFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IJOPHFFDDPI : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference IHOEMBPNBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int LGAJCLCKDDD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int PHBILJAOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD5E0F0", Offset = "0xD5CEF0", VA = "0x180D5E0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IAOMPMNLPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x661E90", Offset = "0x660C90", VA = "0x180661E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4293700", Offset = "0x4292500", VA = "0x184293700")]
	public IJOPHFFDDPI(string FJNMEOAHDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4293630", Offset = "0x4292430", VA = "0x184293630")]
	public IJOPHFFDDPI(string FJNMEOAHDMG, byte[] CONFDLCLIIH, int CAOPPMKILFB, int LGAJCLCKDDD, string OKFIGEIEKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KPBMGIDLOFG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class AJEBFCNBCML
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void HCGCNINODNP(ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object MKJEKGELBDK(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH EJKAMLKIILE);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class FDIOKJGCKAN
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class GDCPDLLENHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public GDCPDLLENHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x4292B20", Offset = "0x4291920", VA = "0x184292B20")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x4292B60", Offset = "0x4291960", VA = "0x184292B60")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, JLIBPADHAKH, byte[]> KGKBIOJDKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, JLIBPADHAKH> BEEFFGPOJLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly HCGCNINODNP JLGCMEBFMNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, JLIBPADHAKH, ArraySegment<byte>> CCDFJAPFDAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, JLIBPADHAKH, string> IFPPLFBMFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, JLIBPADHAKH, object> LDLBGCADNPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, JLIBPADHAKH, object> MPCOELBLCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, JLIBPADHAKH, object> OMPLGMFPPNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly MKJEKGELBDK COPJBDNFLOE;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4290F90", Offset = "0x428FD90", VA = "0x184290F90")]
			public FDIOKJGCKAN(Type FEGCMBEFABH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2663120", Offset = "0x2661F20", VA = "0x182663120")]
			private static T NEIKFHDOGOK<T>(DynamicMethod CLGPIMILKGG)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4290DA0", Offset = "0x428FBA0", VA = "0x184290DA0")]
			private static MethodInfo CHMBPKIKHCK(Type FEGCMBEFABH, string CLDEJGBBMEF, Type[] DHPHBHNJPIM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, FDIOKJGCKAN> HJDGCFEEMBN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::DMMDPLBGKDA<FDIOKJGCKAN> GIPCICCPOAA;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4290B30", Offset = "0x428F930", VA = "0x184290B30")]
		static AJEBFCNBCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4290830", Offset = "0x428F630", VA = "0x184290830")]
		private static FDIOKJGCKAN KIBNCMDPOBB(Type FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x42908B0", Offset = "0x428F6B0", VA = "0x1842908B0")]
		public static void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4290A20", Offset = "0x428F820", VA = "0x184290A20")]
		public static void OABGKNCLGBC(Type FEGCMBEFABH, ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class NHJHNCJABGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DLJHFCENONG;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x429C760", Offset = "0x429B560", VA = "0x18429C760")]
		public static byte[] ICCOFGLAEON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JLIBPADHAKH GNEJBEBNEMC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] ELBDPAGAOPP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] JENLIIPOOFJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JLIBPADHAKH JGIHONAHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4297DE0", Offset = "0x4296BE0", VA = "0x184297DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4297D80", Offset = "0x4296B80", VA = "0x184297D80")]
	public static void KKPKJHGHKGI(JLIBPADHAKH EJKAMLKIILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E9E0", Offset = "0x3D8D7E0", VA = "0x183D8E9E0")]
	public static string FJALGLPEOHC<T>(T PEPOHKCFAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D8EA60", Offset = "0x3D8D860", VA = "0x183D8EA60")]
	public static string FJALGLPEOHC<T>(T PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2668B80", Offset = "0x2667980", VA = "0x182668B80")]
	public static T PEHBIENJBGL<T>(string PDPBDNCEJBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2668C00", Offset = "0x2667A00", VA = "0x182668C00")]
	public static T PEHBIENJBGL<T>(string PDPBDNCEJBN, JLIBPADHAKH EJKAMLKIILE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26689B0", Offset = "0x26677B0", VA = "0x1826689B0")]
	public static T PEHBIENJBGL<T>(byte[] IEDOMBJDKEO, JLIBPADHAKH EJKAMLKIILE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2668A30", Offset = "0x2667830", VA = "0x182668A30")]
	public static T PEHBIENJBGL<T>(byte[] IEDOMBJDKEO, int CAOPPMKILFB, JLIBPADHAKH EJKAMLKIILE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum ANNNKCACKBI : byte
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
public struct GPKCBNBKGKM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] LABBFGFOLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DLJHFCENONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CAOPPMKILFB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CGEIDCLGKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2A0", Offset = "0x6DA0A0", VA = "0x1806DB2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x35FAE20", Offset = "0x35F9C20", VA = "0x1835FAE20")]
	public void GKOHMMFMINC(int CAOPPMKILFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x35FA3F0", Offset = "0x35F91F0", VA = "0x1835FA3F0")]
	public static byte[] AAKGEMLLGKG(string FBHMFJIODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35FB3E0", Offset = "0x35FA1E0", VA = "0x1835FB3E0")]
	public static byte[] NCJIDKCEFFJ(string FBHMFJIODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35FB1E0", Offset = "0x35F9FE0", VA = "0x1835FB1E0")]
	public static byte[] LPANKDNEJON(string FBHMFJIODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x35FAC90", Offset = "0x35F9A90", VA = "0x1835FAC90")]
	public static byte[] GBLFGEDDNIM(string FBHMFJIODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1669ED0", Offset = "0x1668CD0", VA = "0x181669ED0")]
	public GPKCBNBKGKM(byte[] GJBMAOMKLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x35FB030", Offset = "0x35F9E30", VA = "0x1835FB030")]
	public ArraySegment<byte> ICCOFGLAEON()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x35FA950", Offset = "0x35F9750", VA = "0x1835FA950")]
	public byte[] CPLHHEKNGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x35FB620", Offset = "0x35FA420", VA = "0x1835FB620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x35FB5C0", Offset = "0x35FA3C0", VA = "0x1835FB5C0")]
	public void PLHGGAIPPCA(int BFGIFLNPHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x35FAFD0", Offset = "0x35F9DD0", VA = "0x1835FAFD0")]
	public void IBIBBIEGJAB(byte[] BPANKHGGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x35FB0E0", Offset = "0x35F9EE0", VA = "0x1835FB0E0")]
	public void JMLFFEKGEGJ(byte BPANKHGGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x35FB5D0", Offset = "0x35FA3D0", VA = "0x1835FB5D0")]
	public void PNOHJJAABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x35FAEB0", Offset = "0x35F9CB0", VA = "0x1835FAEB0")]
	public void GOKKLOHHDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x35FB570", Offset = "0x35FA370", VA = "0x1835FB570")]
	public void OAANGLFALBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x35FAF80", Offset = "0x35F9D80", VA = "0x1835FAF80")]
	public void HOGIMBPCAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35FA530", Offset = "0x35F9330", VA = "0x1835FA530")]
	public void CMKOHKKHHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35FB390", Offset = "0x35FA190", VA = "0x1835FB390")]
	public void NAMPPHEBEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x35FB510", Offset = "0x35FA310", VA = "0x1835FB510")]
	public void NOBPNBDLPMG(string FBHMFJIODCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x35FAF30", Offset = "0x35F9D30", VA = "0x1835FAF30")]
	public void HMDAPOGCPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35FA9D0", Offset = "0x35F97D0", VA = "0x1835FA9D0")]
	public void DLKPAFGHFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x35FAAA0", Offset = "0x35F98A0", VA = "0x1835FAAA0")]
	public void DPPFNAFKEBM(bool PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35FAE30", Offset = "0x35F9C30", VA = "0x1835FAE30")]
	public void GNLPODIKKIJ(float PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x35FB310", Offset = "0x35FA110", VA = "0x1835FB310")]
	public void MIPPJMDKPDC(double PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x35FA4D0", Offset = "0x35F92D0", VA = "0x1835FA4D0")]
	public void AIAHILBJGKI(byte PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x35FB1B0", Offset = "0x35F9FB0", VA = "0x1835FB1B0")]
	public void LNEPAMONBDE(ushort PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35FB120", Offset = "0x35F9F20", VA = "0x1835FB120")]
	public void KCOIGPDCHAH(uint PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35FADF0", Offset = "0x35F9BF0", VA = "0x1835FADF0")]
	public void GHJIKOPGCLF(ulong PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35FAF00", Offset = "0x35F9D00", VA = "0x1835FAF00")]
	public void HHDFDGJDKHF(sbyte PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x35FB150", Offset = "0x35F9F50", VA = "0x1835FB150")]
	public void KIBJGCPCBFE(short PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x35FB180", Offset = "0x35F9F80", VA = "0x1835FB180")]
	public void LHGKENFBOEG(int PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x35FA500", Offset = "0x35F9300", VA = "0x1835FA500")]
	public void BEEGGODKJHP(long PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x35FA580", Offset = "0x35F9380", VA = "0x1835FA580")]
	public void COKKMMPBIPD(string PEPOHKCFAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BFNMFOLHOHG : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class AMGMPLIJAAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFA30", Offset = "0x3BFE830", VA = "0x183BFFA30")]
		static AMGMPLIJAAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private BFNMFOLHOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class CLFFIANFANF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> MGOEMMPHPNE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3860760", Offset = "0x385F560", VA = "0x183860760")]
	static CLFFIANFANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3860200", Offset = "0x385F000", VA = "0x183860200")]
	internal static object JEPJKOECGPB(Type NCLDEDMIFEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CCHEIGICPNP : global::EAILOOFMBAA<Vector2>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x385D1A0", Offset = "0x385BFA0", VA = "0x18385D1A0")]
	public CCHEIGICPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x385CE50", Offset = "0x385BC50", VA = "0x18385CE50", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Vector2 PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x385CF00", Offset = "0x385BD00", VA = "0x18385CF00", Slot = "5")]
	public Vector2 PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IPLICOJIHGP : global::EAILOOFMBAA<Vector3>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42941A0", Offset = "0x4292FA0", VA = "0x1842941A0")]
	public IPLICOJIHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4293E90", Offset = "0x4292C90", VA = "0x184293E90", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Vector3 PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4293FB0", Offset = "0x4292DB0", VA = "0x184293FB0", Slot = "5")]
	public Vector3 PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JLHAHDIKJEC : global::EAILOOFMBAA<Vector4>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4296E50", Offset = "0x4295C50", VA = "0x184296E50")]
	public JLHAHDIKJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4296AD0", Offset = "0x42958D0", VA = "0x184296AD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Vector4 PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4296C20", Offset = "0x4295A20", VA = "0x184296C20", Slot = "5")]
	public Vector4 PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PMKPMEGDPPD : global::EAILOOFMBAA<Quaternion>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x429E7E0", Offset = "0x429D5E0", VA = "0x18429E7E0")]
	public PMKPMEGDPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4296AD0", Offset = "0x42958D0", VA = "0x184296AD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Quaternion PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x429E5B0", Offset = "0x429D3B0", VA = "0x18429E5B0", Slot = "5")]
	public Quaternion PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class LGDEIIGBHEM : global::EAILOOFMBAA<Color>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4298A20", Offset = "0x4297820", VA = "0x184298A20")]
	public LGDEIIGBHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4296AD0", Offset = "0x42958D0", VA = "0x184296AD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Color PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42987F0", Offset = "0x42975F0", VA = "0x1842987F0", Slot = "5")]
	public Color PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EPOJHDCCKNE : global::EAILOOFMBAA<Bounds>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x386AF40", Offset = "0x3869D40", VA = "0x18386AF40")]
	public EPOJHDCCKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x386A920", Offset = "0x3869720", VA = "0x18386A920", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Bounds PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x386AB90", Offset = "0x3869990", VA = "0x18386AB90", Slot = "5")]
	public Bounds PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DLBNKKCKHJE : global::EAILOOFMBAA<Rect>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FHCPGMELKBI LNJGMKPJHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] IAECPCCAPHB;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3864F30", Offset = "0x3863D30", VA = "0x183864F30")]
	public DLBNKKCKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3864A50", Offset = "0x3863850", VA = "0x183864A50", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Rect PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3864BC0", Offset = "0x38639C0", VA = "0x183864BC0", Slot = "5")]
	public Rect PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class HDLDLIOOLLI : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class CIOJANNMGMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4007990", Offset = "0x4006790", VA = "0x184007990")]
		static CIOJANNMGMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private HDLDLIOOLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class HOIGHONMOEM : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class BMOLIJNFOPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4760", Offset = "0x3DC3560", VA = "0x183DC4760")]
		static BMOLIJNFOPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class OCDNODBECIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> GALBCFMAALA;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3602290", Offset = "0x3601090", VA = "0x183602290")]
		internal static object JEPJKOECGPB(Type NCLDEDMIFEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private HOIGHONMOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class JKIGBOEOGMC : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class JBAAOMOLHII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4052260", Offset = "0x4051060", VA = "0x184052260")]
		static JBAAOMOLHII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JKIGBOEOGMC MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FGMFAFAJPFN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static POOHDCJJHAO[] CPGAMINKDOM;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static JLIBPADHAKH[] JMMMJOFNFCF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private JKIGBOEOGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4296700", Offset = "0x4295500", VA = "0x184296700")]
	public static void JPALDKHHFDL(params JLIBPADHAKH[] JMMMJOFNFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4296640", Offset = "0x4295440", VA = "0x184296640")]
	public static void JPALDKHHFDL(params POOHDCJJHAO[] CPGAMINKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x42967C0", Offset = "0x42955C0", VA = "0x1842967C0")]
	public static void OLLCFNALBBI(POOHDCJJHAO[] CPGAMINKDOM, JLIBPADHAKH[] JMMMJOFNFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class JFHAFBGGMHL : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class HLEADCBJMBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x46B6B40", Offset = "0x46B5940", VA = "0x1846B6B40")]
		static HLEADCBJMBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private JFHAFBGGMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LGKFAPNGJIA
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly JLIBPADHAKH OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly JLIBPADHAKH GABPFHAIAHN;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly JLIBPADHAKH CMAEAEBNIKA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly JLIBPADHAKH GGNOCHDEEBD;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly JLIBPADHAKH DEFDDKCCDCE;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly JLIBPADHAKH ALKGLNMFFML;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly JLIBPADHAKH NFONCLONCOE;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly JLIBPADHAKH PIDJMNANCMD;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly JLIBPADHAKH GNKIFIHKIPM;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly JLIBPADHAKH BMCEJBANDNL;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly JLIBPADHAKH AOAFMNMIDJG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JLIBPADHAKH OLGEMCEBHFF;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GNJAHMMJDON
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly JLIBPADHAKH OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JLIBPADHAKH MMNLMJNFFCB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PODPFGCJKKJ
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly JLIBPADHAKH OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly JLIBPADHAKH GABPFHAIAHN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly JLIBPADHAKH CMAEAEBNIKA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly JLIBPADHAKH GGNOCHDEEBD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly JLIBPADHAKH DEFDDKCCDCE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly JLIBPADHAKH ALKGLNMFFML;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly JLIBPADHAKH NFONCLONCOE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly JLIBPADHAKH PIDJMNANCMD;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JLIBPADHAKH GNKIFIHKIPM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly JLIBPADHAKH BMCEJBANDNL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly JLIBPADHAKH AOAFMNMIDJG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly JLIBPADHAKH OLGEMCEBHFF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class EDFJOGOLOJA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> GALBCFMAALA;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3866B70", Offset = "0x3865970", VA = "0x183866B70")]
	internal static object JEPJKOECGPB(Type NCLDEDMIFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3866B30", Offset = "0x3865930", VA = "0x183866B30")]
	private static object CENECFLBNIB(Type BMJAIAPOAAI, Type[] GJGNNGOHMEM, params object[] DHPHBHNJPIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GHKBAPAFMMI : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class NHEIAILODHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28CD580", Offset = "0x28CC380", VA = "0x1828CD580")]
		static NHEIAILODHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x35F9AE0", Offset = "0x35F88E0", VA = "0x1835F9AE0")]
	static GHKBAPAFMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private GHKBAPAFMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class BHHPMJEANPM : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class LBODAJPCCBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C16410", Offset = "0x3C15210", VA = "0x183C16410")]
		static LBODAJPCCBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x385A810", Offset = "0x3859610", VA = "0x18385A810")]
	static BHHPMJEANPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private BHHPMJEANPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class BPHEGGINCIA : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FDFMOACMMEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C09760", Offset = "0x3C08560", VA = "0x183C09760")]
		static FDFMOACMMEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x385C910", Offset = "0x385B710", VA = "0x18385C910")]
	static BPHEGGINCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private BPHEGGINCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ALFAODJFLMJ : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class AJNMINGELOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4230410", Offset = "0x422F210", VA = "0x184230410")]
		static AJNMINGELOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3859A00", Offset = "0x3858800", VA = "0x183859A00")]
	static ALFAODJFLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private ALFAODJFLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class JCLJNOFNNNM : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class EKDLEBIAFHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4307FB0", Offset = "0x4306DB0", VA = "0x184307FB0")]
		static EKDLEBIAFHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4294780", Offset = "0x4293580", VA = "0x184294780")]
	static JCLJNOFNNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private JCLJNOFNNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MNCNNPFIPHG : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class DJKILBKIBGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3927530", Offset = "0x3926330", VA = "0x183927530")]
		static DJKILBKIBGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly DEONEPEIIOL NFAKLMNLHKI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x429C130", Offset = "0x429AF30", VA = "0x18429C130")]
	static MNCNNPFIPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private MNCNNPFIPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class LMIHPOJCFJO : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class CCIMNKCKEFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x36F4C20", Offset = "0x36F3A20", VA = "0x1836F4C20")]
		static CCIMNKCKEFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public LMIHPOJCFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class DBBFHBPIAHC : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class GHHICAFEPCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E28760", Offset = "0x3E27560", VA = "0x183E28760")]
		static GHHICAFEPCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public DBBFHBPIAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HMFGHNANKCJ : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class MNHIBBOBIIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A91EB0", Offset = "0x3A90CB0", VA = "0x183A91EB0")]
		static MNHIBBOBIIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HMFGHNANKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class KAOHDGCMLBF : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class NCBBIADGNGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEDE0", Offset = "0x3DBDBE0", VA = "0x183DBEDE0")]
		static NCBBIADGNGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KAOHDGCMLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class KMGOOFOOJJP : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KIBGCLPCOBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0930", Offset = "0x2ABF730", VA = "0x182AC0930")]
		static KIBGCLPCOBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KMGOOFOOJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class MJEKJCDNILG : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class OEEFBKIPOAD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4332F90", Offset = "0x4331D90", VA = "0x184332F90")]
		static OEEFBKIPOAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> AAPDELPJAEA;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool LLHFEHLCOBG;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public MJEKJCDNILG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GBDFAGLKGBB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NPLPFILEEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FFGBNJDEJLK EGEICCLLLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder LBMJHGBKHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HFKDOPKALPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class FKOMOFJGALD
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class IPONELODODO
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LPANKDNEJON;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo NCJIDKCEFFJ;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo GBLFGEDDNIM;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo AAKGEMLLGKG;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo DLKPAFGHFCP;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo IBIBBIEGJAB;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo OAANGLFALBA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HOGIMBPCAMF;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo CMKOHKKHHNC;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x35FEB20", Offset = "0x35FD920", VA = "0x1835FEB20")]
			static IPONELODODO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class MDPCCOMDFBP
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo HNBGGJFJLLF;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HECLIGJHELJ;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo HLCNDCDBHMO;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo LPOPLGLGALK;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo OBNNDMOAIFJ;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo EHEKDIIDAGL;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NDGOALLKPMB;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x35FF9E0", Offset = "0x35FE7E0", VA = "0x1835FF9E0")]
			static MDPCCOMDFBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class NHLNKMFPJAL
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FDFKJJKNLOG;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PAGGONMPIPA;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MENGIMOOHDJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo LGMOBCBONFE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EJBKLLBNMDH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo FIDEHKOLDJC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo LDMJFFEAKHH;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo OHGMOIIINJP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo BAEFCENEDMK;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo NCNHKIKEADH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo ACGBPCDKKCO;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo FANEJPKJDII;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo AEDPBHOGIPG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo GEIJHBIBCNF;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x35ED010", Offset = "0x35EBE10", VA = "0x1835ED010")]
		public static MethodInfo OABGKNCLGBC(Type FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x35ED2A0", Offset = "0x35EC0A0", VA = "0x1835ED2A0")]
		public static MethodInfo PEHBIENJBGL(Type FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x35ECEF0", Offset = "0x35EBCF0", VA = "0x1835ECEF0")]
		public static MethodInfo LDCGCAKEDMH(Type FEGCMBEFABH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EBPBKINMKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<FFGBNJDEJLK, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public EBPBKINMKAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class NIJBMDOIBLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EBPBKINMKAJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public NIJBMDOIBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x36021B0", Offset = "0x3600FB0", VA = "0x1836021B0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x36021F0", Offset = "0x3600FF0", VA = "0x1836021F0")]
		internal bool <BuildType>b__2(int index, FFGBNJDEJLK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GGOIICEIJPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EBPBKINMKAJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public GGOIICEIJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x35F9A40", Offset = "0x35F8840", VA = "0x1835F9A40")]
		internal bool <BuildType>b__3(int index, FFGBNJDEJLK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IEGJEOFHNKE
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
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public IEGJEOFHNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x35FEAC0", Offset = "0x35FD8C0", VA = "0x1835FEAC0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AJDNCPEMLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public AJDNCPEMLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x35EB7C0", Offset = "0x35EA5C0", VA = "0x1835EB7C0")]
		internal bool <BuildAnonymousFormatter>b__2(FFGBNJDEJLK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GAKKMIKDAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IEGJEOFHNKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public GAKKMIKDAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x35EFDF0", Offset = "0x35EEBF0", VA = "0x1835EFDF0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x35EFE70", Offset = "0x35EEC70", VA = "0x1835EFE70")]
		internal bool <BuildAnonymousFormatter>b__6(int index, FFGBNJDEJLK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BHHEJHIOJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IEGJEOFHNKE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public BHHEJHIOJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x35EB9A0", Offset = "0x35EA7A0", VA = "0x1835EB9A0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, FFGBNJDEJLK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class KAKENFCDMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public KAKENFCDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x52ACC0", Offset = "0x529AC0", VA = "0x18052ACC0")]
		internal Label <BuildSerialize>b__1(FFGBNJDEJLK _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class POCKBOAGDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NPLPFILEEDC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, FFGBNJDEJLK, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public LIKCLPOBDDJ argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public LIKCLPOBDDJ argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public POCKBOAGDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3603F50", Offset = "0x3602D50", VA = "0x183603F50")]
		internal NPLPFILEEDC <BuildDeserialize>b__0(FFGBNJDEJLK item)
		{
			return default(NPLPFILEEDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class PKHKNBGHDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public POCKBOAGDEM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public PKHKNBGHDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3603BD0", Offset = "0x36029D0", VA = "0x183603BD0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3603EB0", Offset = "0x3602CB0", VA = "0x183603EB0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class EDJBLBHDNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FFGBNJDEJLK item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public EDJBLBHDNJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2380C80", Offset = "0x237FA80", VA = "0x182380C80")]
		internal bool <EmitNewObject>b__0(NPLPFILEEDC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JDCIIKJFJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FFGBNJDEJLK item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public JDCIIKJFJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2380C80", Offset = "0x237FA80", VA = "0x182380C80")]
		internal bool <EmitNewObject>b__2(NPLPFILEEDC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex KGLHPEOCMIF;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KFEPOCAGPNH;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> DIDIFCMLKOI;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NHDNLLGENDC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FFA0", Offset = "0x3D7EDA0", VA = "0x183D7FFA0")]
	public static object HMOCOOJAIDO<T>(DEONEPEIIOL NFAKLMNLHKI, JLIBPADHAKH IFEKMPEBPAK, Func<string, string> AAPDELPJAEA, bool LLHFEHLCOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A030", Offset = "0x3D88E30", VA = "0x183D8A030")]
	public static object NMFHKKLIONG<T>(JLIBPADHAKH IFEKMPEBPAK, Func<string, string> AAPDELPJAEA, bool LLHFEHLCOBG, bool EPOBMKDFEAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x35F0640", Offset = "0x35EF440", VA = "0x1835F0640")]
	private static TypeInfo BBBCBGPJEPO(DEONEPEIIOL NFAKLMNLHKI, Type FEGCMBEFABH, Func<string, string> AAPDELPJAEA, bool LLHFEHLCOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x35F5210", Offset = "0x35F4010", VA = "0x1835F5210")]
	public static object NCGPEJAIBGO(Type FEGCMBEFABH, Func<string, string> AAPDELPJAEA, bool LLHFEHLCOBG, bool EPOBMKDFEAA, bool KHFAGOBJBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35F4B10", Offset = "0x35F3910", VA = "0x1835F4B10")]
	private static Dictionary<FFGBNJDEJLK, FieldInfo> MKJMIPGLMPN(TypeBuilder PCHMDPLLNMK, NPHCFKFPHEO HOHHDPMJFFP, ConstructorInfo PKGDELDOIFP, FieldBuilder HFNCONDBKGN, ILGenerator KPIDMNENJHI, bool LLHFEHLCOBG, bool KJAJCNJACAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x35F0070", Offset = "0x35EEE70", VA = "0x1835F0070")]
	private static Dictionary<FFGBNJDEJLK, FieldInfo> AOIBFEKNDDO(TypeBuilder PCHMDPLLNMK, NPHCFKFPHEO HOHHDPMJFFP, ILGenerator KPIDMNENJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x35F3560", Offset = "0x35F2360", VA = "0x1835F3560")]
	private static void JPAOKKHENGP(Type FEGCMBEFABH, NPHCFKFPHEO HOHHDPMJFFP, ILGenerator KPIDMNENJHI, Action FJAOIIKCJIO, Func<int, FFGBNJDEJLK, bool> GMMKHGHDINK, bool LLHFEHLCOBG, bool KJAJCNJACAG, int EGJNAPKNGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x35F24C0", Offset = "0x35F12C0", VA = "0x1835F24C0")]
	private static void EEBHMFPJECP(TypeInfo FEGCMBEFABH, FFGBNJDEJLK CLBFDHAJPED, ILGenerator KPIDMNENJHI, int IMDCPBGFCMD, Func<int, FFGBNJDEJLK, bool> GMMKHGHDINK, LIKCLPOBDDJ CENMEHNCJLA, LIKCLPOBDDJ BHKGALCFMGB, LIKCLPOBDDJ ADKHFPMMLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x35F10E0", Offset = "0x35EFEE0", VA = "0x1835F10E0")]
	private static void CHCJJDGILPN(Type FEGCMBEFABH, NPHCFKFPHEO HOHHDPMJFFP, ILGenerator KPIDMNENJHI, Func<int, FFGBNJDEJLK, bool> GMMKHGHDINK, bool KEENLFCNAHA, int EGJNAPKNGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x35F3140", Offset = "0x35F1F40", VA = "0x1835F3140")]
	private static void HDPENCAEIEJ(ILGenerator KPIDMNENJHI, NPLPFILEEDC HOHHDPMJFFP, int IMDCPBGFCMD, Func<int, FFGBNJDEJLK, bool> GMMKHGHDINK, LIKCLPOBDDJ NGOLKADBHEG, LIKCLPOBDDJ ADKHFPMMLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35F6D50", Offset = "0x35F5B50", VA = "0x1835F6D50")]
	private static LocalBuilder NKAKOCNNNKL(ILGenerator KPIDMNENJHI, Type FEGCMBEFABH, NPHCFKFPHEO HOHHDPMJFFP, NPLPFILEEDC[] NDFJLJGIKAM, bool OEHAIEOGCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x35F2A70", Offset = "0x35F1870", VA = "0x1835F2A70")]
	private static bool FOGLPFPCKKG(ConstructorInfo GOCGFMPPMCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x35F6BB0", Offset = "0x35F59B0", VA = "0x1835F6BB0")]
	private static bool NDHFAMECCDB(Type FEGCMBEFABH, out Type DKOHGGPOPEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void PFNEMABFAOE<T>(byte[][] HFNCONDBKGN, object[] NIBJAJMDPHK, ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH EJKAMLKIILE);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T LMLHHLFKPFG<T>(object[] NIBJAJMDPHK, ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH EJKAMLKIILE);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class CBDPLIGGDOJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class CENCPIJBMMJ : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class EFFCAAMEHBI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x36644B0", Offset = "0x36632B0", VA = "0x1836644B0")]
		static EFFCAAMEHBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private CENCPIJBMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class DFPENCCDOLF : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class MGOKMEOKBKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9640", Offset = "0x3CD8440", VA = "0x183CD9640")]
		static MGOKMEOKBKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private DFPENCCDOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class NMCJIPNHKNN
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly JLIBPADHAKH[] HLCCDAIBNFF;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DKFKODIGAMK : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class JMOBEIKLNNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCE90", Offset = "0x3CCBC90", VA = "0x183CCCE90")]
		static JMOBEIKLNNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LFHHPMKNCBB : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class BOGLOEEFOOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x38EAE80", Offset = "0x38E9C80", VA = "0x1838EAE80")]
			static BOGLOEEFOOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private LFHHPMKNCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private DKFKODIGAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class GBEBBEDDPHK : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class CMNGFOINCBG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8890", Offset = "0x2BF7690", VA = "0x182BF8890")]
		static CMNGFOINCBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class BCKJOIEBEDD : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class BJKAJKNDPPI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2BF70D0", Offset = "0x2BF5ED0", VA = "0x182BF70D0")]
			static BJKAJKNDPPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private BCKJOIEBEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private GBEBBEDDPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class DBCMIEAMDFI : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class LAOMDKBFKBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C010", Offset = "0x3E2AE10", VA = "0x183E2C010")]
		static LAOMDKBFKBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class ODABHGECKGM : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class BANLMLKLBEC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3CC2AA0", Offset = "0x3CC18A0", VA = "0x183CC2AA0")]
			static BANLMLKLBEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private ODABHGECKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private DBCMIEAMDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class FJBEEIACAID : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class MCFPMDFNCFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x38E1F30", Offset = "0x38E0D30", VA = "0x1838E1F30")]
		static MCFPMDFNCFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class AINOKPECDEN : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DFNMDMJADJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x38CD730", Offset = "0x38CC530", VA = "0x1838CD730")]
			static DFNMDMJADJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private AINOKPECDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private FJBEEIACAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class CBFILGHEJMK : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class OKBODNEDHJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2E24FC0", Offset = "0x2E23DC0", VA = "0x182E24FC0")]
		static OKBODNEDHJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class DDDCNMEBOFG : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class EFEMCGEFHPA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2E21590", Offset = "0x2E20390", VA = "0x182E21590")]
			static EFEMCGEFHPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private DDDCNMEBOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private CBFILGHEJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LAFAGMJAMEK : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class OLJJHHNIBEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8900", Offset = "0x2FC7700", VA = "0x182FC8900")]
		static OLJJHHNIBEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class GEMNEADMPGK : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class LJKKAFHHAND<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2FC53A0", Offset = "0x2FC41A0", VA = "0x182FC53A0")]
			static LJKKAFHHAND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private GEMNEADMPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private LAFAGMJAMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FKCLJHPEHFC : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class CEDILJJBCNN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x38C9EC0", Offset = "0x38C8CC0", VA = "0x1838C9EC0")]
		static CEDILJJBCNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GDEPIPGLACJ : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class PCJLOEHNCNN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x38E72E0", Offset = "0x38E60E0", VA = "0x1838E72E0")]
			static PCJLOEHNCNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private GDEPIPGLACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private FKCLJHPEHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class BNGGMOKCGBP : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class FNAALABKGMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C440", Offset = "0x3C0B240", VA = "0x183C0C440")]
		static FNAALABKGMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class JOHLDGBJJAI : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class MEGOMJAPPCH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3C17460", Offset = "0x3C16260", VA = "0x183C17460")]
			static MEGOMJAPPCH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private JOHLDGBJJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private BNGGMOKCGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class FDLFDIPAKLI : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class GMNBMKOEEBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x38DAD40", Offset = "0x38D9B40", VA = "0x1838DAD40")]
		static GMNBMKOEEBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class PEEDLAMDLCP : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class IEEIAADIAPE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x38DEEC0", Offset = "0x38DDCC0", VA = "0x1838DEEC0")]
			static IEEIAADIAPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private PEEDLAMDLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private FDLFDIPAKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class OADIPGDIAKO : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class CAMNGDFKNAF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x343E150", Offset = "0x343CF50", VA = "0x18343E150")]
		static CAMNGDFKNAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class FCCFKKHGGFL : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class OOLBEAJCKCP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x344CEB0", Offset = "0x344BCB0", VA = "0x18344CEB0")]
			static OOLBEAJCKCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private FCCFKKHGGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private OADIPGDIAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class HNMHNDEJJEL : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class MHMCEHMHLAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB4E0", Offset = "0x3DDA2E0", VA = "0x183DDB4E0")]
		static MHMCEHMHLAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class OENCLNBBFKD : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class FDFJGBPMGNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7630", Offset = "0x3DC6430", VA = "0x183DC7630")]
			static FDFJGBPMGNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private OENCLNBBFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private HNMHNDEJJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class LPNKNCFLGNE : JLIBPADHAKH
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class FLABIPCHAAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x36F6200", Offset = "0x36F5000", VA = "0x1836F6200")]
		static FLABIPCHAAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class NBBNGBAILGB : JLIBPADHAKH
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class LAKFKBJKIDE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::EAILOOFMBAA<T> HNFHDOLIGHO;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x36FBF40", Offset = "0x36FAD40", VA = "0x1836FBF40")]
			static LAKFKBJKIDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly JLIBPADHAKH MHOGIHBANHN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly JLIBPADHAKH[] JMMMJOFNFCF;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private NBBNGBAILGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
		public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly JLIBPADHAKH MHOGIHBANHN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::EAILOOFMBAA<object> OOAFMPHJBCM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private LPNKNCFLGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x29C21B0", Offset = "0x29C0FB0", VA = "0x1829C21B0", Slot = "4")]
	public global::EAILOOFMBAA<T> JEPJKOECGPB<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct CKJPIKONOGC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] KEEGNILPGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int JHKKINIGJOH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x36B7910", Offset = "0x36B6710", VA = "0x1836B7910")]
	public CKJPIKONOGC(int DGHOLAABJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x36B7830", Offset = "0x36B6630", VA = "0x1836B7830")]
	public void NGPIMMKGFMI(T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x36B7520", Offset = "0x36B6320", VA = "0x1836B7520")]
	public T[] CBCMPCCLAJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class BFLHABHDPBI : global::JPOHBEBMLBI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly BFLHABHDPBI OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x385A760", Offset = "0x3859560", VA = "0x18385A760")]
	public BFLHABHDPBI(int OFHJJCACKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class JPOHBEBMLBI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int OFHJJCACKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object DENIBGCJEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int IMDCPBGFCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] GPAJFBHACPK;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DB61E0", Offset = "0x3DB4FE0", VA = "0x183DB61E0")]
	public JPOHBEBMLBI(int OFHJJCACKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4320", Offset = "0x3DB3120", VA = "0x183DB4320")]
	public T[] DECNINODAKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5460", Offset = "0x3DB4260", VA = "0x183DB5460")]
	public void DFAECMHJGCO(T[] KGBBFPHOMGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FHCPGMELKBI : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class MNLEAIMHBIP : IComparable<MNLEAIMHBIP>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class LKHOPKNLDNK : IEnumerable<MNLEAIMHBIP>, IEnumerable, IEnumerator<MNLEAIMHBIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private MNLEAIMHBIP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public MNLEAIMHBIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MNLEAIMHBIP System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
			[DebuggerHidden]
			public LKHOPKNLDNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x35FF860", Offset = "0x35FE660", VA = "0x1835FF860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x35FF990", Offset = "0x35FE790", VA = "0x1835FF990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x35FF8F0", Offset = "0x35FE6F0", VA = "0x1835FF8F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MNLEAIMHBIP> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x35FF8F0", Offset = "0x35FE6F0", VA = "0x1835FF8F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class PBFDAPCJNKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public PBFDAPCJNKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x52ACC0", Offset = "0x529AC0", VA = "0x18052ACC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x52ACC0", Offset = "0x529AC0", VA = "0x18052ACC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly MNLEAIMHBIP[] OCNIAHFLPJA;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] EPAJPDIHBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong EKMCGMDHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int NMGHIPGAEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string LFPIIPPHJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MNLEAIMHBIP[] FNFMEJPBIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] OCPFHBCPDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int FDHPLBOBCJJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DGOADOEOHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xFB6A10", Offset = "0xFB5810", VA = "0x180FB6A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36017E0", Offset = "0x36005E0", VA = "0x1836017E0")]
		public MNLEAIMHBIP(ulong IFKOMGEEEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3601570", Offset = "0x3600370", VA = "0x183601570")]
		public MNLEAIMHBIP NGPIMMKGFMI(ulong IFKOMGEEEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3601520", Offset = "0x3600320", VA = "0x183601520")]
		public MNLEAIMHBIP NGPIMMKGFMI(ulong IFKOMGEEEMC, int PEPOHKCFAOG, string LFPIIPPHJKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3600660", Offset = "0x35FF460", VA = "0x183600660")]
		public MNLEAIMHBIP FJNLCOHFOMJ(byte[] GAGCMAOJCLC, ref int CAOPPMKILFB, ref int BAKBBIICEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3600880", Offset = "0x35FF680", VA = "0x183600880")]
		internal static int KCPAIAPCHAD(ulong[] KGBBFPHOMGB, int IMDCPBGFCMD, int LBDDMJPBOJI, ulong PEPOHKCFAOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3600630", Offset = "0x35FF430", VA = "0x183600630", Slot = "4")]
		public int CompareTo(MNLEAIMHBIP KBAPGFOKKBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3600810", Offset = "0x35FF610", VA = "0x183600810")]
		[IteratorStateMachine(typeof(LKHOPKNLDNK))]
		public IEnumerable<MNLEAIMHBIP> FNEAGBMHHJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x36004E0", Offset = "0x35FF2E0", VA = "0x1836004E0")]
		public void COKLAFLKGII(ILGenerator KPIDMNENJHI, LocalBuilder GAGCMAOJCLC, LocalBuilder BAKBBIICEFA, LocalBuilder IFKOMGEEEMC, Action<KeyValuePair<string, int>> EADHKCFOFFK, Action GHEGIBECJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3600900", Offset = "0x35FF700", VA = "0x183600900")]
		private static void KFBEJKHHPKF(ILGenerator KPIDMNENJHI, LocalBuilder GAGCMAOJCLC, LocalBuilder BAKBBIICEFA, LocalBuilder IFKOMGEEEMC, Action<KeyValuePair<string, int>> EADHKCFOFFK, Action GHEGIBECJHF, MNLEAIMHBIP[] FNFMEJPBIID, int FDHPLBOBCJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ENGBNGDEDPL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<MNLEAIMHBIP> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<MNLEAIMHBIP> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<MNLEAIMHBIP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private MNLEAIMHBIP <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x35EC010", Offset = "0x35EAE10", VA = "0x1835EC010", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA21C0", Offset = "0xAA0FC0", VA = "0x180AA21C0")]
		[DebuggerHidden]
		public ENGBNGDEDPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x35EC060", Offset = "0x35EAE60", VA = "0x1835EC060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x35EBBA0", Offset = "0x35EA9A0", VA = "0x1835EBBA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x35EC160", Offset = "0x35EAF60", VA = "0x1835EC160")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x35EC1B0", Offset = "0x35EAFB0", VA = "0x1835EC1B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x35EBFC0", Offset = "0x35EADC0", VA = "0x1835EBFC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x35EBF20", Offset = "0x35EAD20", VA = "0x1835EBF20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x35EBF20", Offset = "0x35EAD20", VA = "0x1835EBF20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly MNLEAIMHBIP MIJPOFHLMNP;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x35EC8E0", Offset = "0x35EB6E0", VA = "0x1835EC8E0")]
	public FHCPGMELKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x35EC6D0", Offset = "0x35EB4D0", VA = "0x1835EC6D0")]
	public void NGPIMMKGFMI(byte[] IEDOMBJDKEO, int PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x35EC5F0", Offset = "0x35EB3F0", VA = "0x1835EC5F0")]
	public bool HMAAOFECOHI(ArraySegment<byte> IFKOMGEEEMC, out int PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x35EC7F0", Offset = "0x35EB5F0", VA = "0x1835EC7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x35EC200", Offset = "0x35EB000", VA = "0x1835EC200")]
	private static void CFIMPIKOLMN(IEnumerable<MNLEAIMHBIP> FNFMEJPBIID, StringBuilder AMAJBOKAIJO, int GPFBOLLGNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x35EC4F0", Offset = "0x35EB2F0", VA = "0x1835EC4F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x35EC4F0", Offset = "0x35EB2F0", VA = "0x1835EC4F0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x35EC480", Offset = "0x35EB280", VA = "0x1835EC480")]
	[IteratorStateMachine(typeof(ENGBNGDEDPL))]
	private static IEnumerable<KeyValuePair<string, int>> DLJDFHPIFBP(IEnumerable<MNLEAIMHBIP> FNFMEJPBIID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x35EC6A0", Offset = "0x35EB4A0", VA = "0x1835EC6A0")]
	public void MNJAELGOGOI(ILGenerator KPIDMNENJHI, LocalBuilder GAGCMAOJCLC, LocalBuilder BAKBBIICEFA, LocalBuilder IFKOMGEEEMC, Action<KeyValuePair<string, int>> EADHKCFOFFK, Action GHEGIBECJHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class EHAOLJNFGFN
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo APAEOLDLEKE;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3868BC0", Offset = "0x38679C0", VA = "0x183868BC0")]
	public static ulong KGKPEGJMHIP(byte[] IEDOMBJDKEO, ref int CAOPPMKILFB, ref int BAKBBIICEFA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class BPMGJCKMBCD
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x385CBE0", Offset = "0x385B9E0", VA = "0x18385CBE0")]
	public static void PLHGGAIPPCA(ref byte[] IEDOMBJDKEO, int CAOPPMKILFB, int BFGIFLNPHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x385CAF0", Offset = "0x385B8F0", VA = "0x18385CAF0")]
	public static void JFICGKOMKOE(ref byte[] KGBBFPHOMGB, int ACHEGPDDCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x385CA00", Offset = "0x385B800", VA = "0x18385CA00")]
	public static byte[] ECNJEIFGBIM(byte[] NAANBEIGCLG, int ACHEGPDDCMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class BOENHNBDNHG
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x385C880", Offset = "0x385B680", VA = "0x18385C880")]
	public static bool MOAHIBEKJCF(byte[] HJBBHMKGAGP, int DBMHJIPGDJE, int ADJJOAMPALB, byte[] OKFMGDLPJNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HJJONMLFBDC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct DCPKBGONPOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] EKMCGMDHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T NMGHIPGAEHB;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x35DB4A0", Offset = "0x35DA2A0", VA = "0x1835DB4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class FFMDMNJFLKH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::HJJONMLFBDC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private DCPKBGONPOH[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private DCPKBGONPOH[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x22B1780", Offset = "0x22B0580", VA = "0x1822B1780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35E2EB0", Offset = "0x35E1CB0", VA = "0x1835E2EB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x26011A0", Offset = "0x25FFFA0", VA = "0x1826011A0")]
		[DebuggerHidden]
		public FFMDMNJFLKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x35E0D10", Offset = "0x35DFB10", VA = "0x1835E0D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x35E2BE0", Offset = "0x35E19E0", VA = "0x1835E2BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DCPKBGONPOH[][] IEBPDFFFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong DBJALMMPBHK;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x35EB480", Offset = "0x35EA280", VA = "0x1835EB480")]
	public HJJONMLFBDC(int IMNCEOIPJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x35EB3C0", Offset = "0x35EA1C0", VA = "0x1835EB3C0")]
	public HJJONMLFBDC(int IMNCEOIPJNE, float DNKFLMDMBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x35EABD0", Offset = "0x35E99D0", VA = "0x1835EABD0")]
	public void NGPIMMKGFMI(byte[] IFKOMGEEEMC, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x35E9D80", Offset = "0x35E8B80", VA = "0x1835E9D80")]
	private bool CKBHHPDDOHM(byte[] IFKOMGEEEMC, T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x35EB020", Offset = "0x35E9E20", VA = "0x1835EB020")]
	public bool PDIMMFIGHEA(ArraySegment<byte> IFKOMGEEEMC, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x35E99B0", Offset = "0x35E87B0", VA = "0x1835E99B0")]
	private static ulong CHEOEHLOJLF(byte[] DCMLOLBECIB, int CAOPPMKILFB, int FDHPLBOBCJJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x35EA930", Offset = "0x35E9730", VA = "0x1835EA930")]
	private static int LLHMBKFDFFG(int FDFCNMEBPPG, float DNKFLMDMBOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x35EA810", Offset = "0x35E9610", VA = "0x1835EA810", Slot = "4")]
	[IteratorStateMachine(typeof(global::HJJONMLFBDC<>.FFMDMNJFLKH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2608E70", Offset = "0x2607C70", VA = "0x182608E70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class DPAFLFBBGBM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] KIOJPIJCJBN;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] IMJKCACNCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int EKHJKDJOKIF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ONHHKMCAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x38665D0", Offset = "0x38653D0", VA = "0x1838665D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3866730", Offset = "0x3865530", VA = "0x183866730")]
	static DPAFLFBBGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3866980", Offset = "0x3865780", VA = "0x183866980")]
	public DPAFLFBBGBM(byte[] GGHFGOEGJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3866620", Offset = "0x3865420", VA = "0x183866620")]
	public OpCode MDAHJPHFMDG()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DGEOEEPBGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid NMGHIPGAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte KOLPLKGCNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte BMHBPOJCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte EEEAKDIKJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte PJKCPFLABAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte BIDPAHKAAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte LANFEGMMJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte MDHHBBEMAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte NALDPOELHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte KPJCGABLHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte MHAMPGLKOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte IPNLAEBDCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte DKBHBFPBNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte KNEJGOCJGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte MNHKCBABHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte IBKNDIFOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte PBDIMJHNOGM;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] DABNPNCIBIM;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] NJKEHDBCBCG;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3864310", Offset = "0x3863110", VA = "0x183864310")]
	public DGEOEEPBGDP(ref Guid PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3863C60", Offset = "0x3862A60", VA = "0x183863C60")]
	public DGEOEEPBGDP(ref ArraySegment<byte> HHDFOCMALNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3863AF0", Offset = "0x38628F0", VA = "0x183863AF0")]
	private static byte HKEHCMANBBH(byte[] IEDOMBJDKEO, int KMKAGNANOJA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x38626A0", Offset = "0x38614A0", VA = "0x1838626A0")]
	private static byte FHFBHPNFGDM(byte BAHCPBFJIGN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x38627B0", Offset = "0x38615B0", VA = "0x1838627B0")]
	public void GMDPHCLFDKK(byte[] DLJHFCENONG, int CAOPPMKILFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class FGMJBJBJKPO
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x386E2F0", Offset = "0x386D0F0", VA = "0x18386E2F0")]
	public static bool JGPMFEOCMBC(byte PMOBKAEONAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x386DA40", Offset = "0x386C840", VA = "0x18386DA40")]
	public static bool EKHIIOCBLHK(byte PMOBKAEONAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x386E560", Offset = "0x386D360", VA = "0x18386E560")]
	public static sbyte KOPGPAOCIGH(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x386E280", Offset = "0x386D080", VA = "0x18386E280")]
	public static short IHNFCOJBDOO(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x386E370", Offset = "0x386D170", VA = "0x18386E370")]
	public static int KBNGCPOFBFO(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x386D740", Offset = "0x386C540", VA = "0x18386D740")]
	public static long DOPBIEDGIIN(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x386E5D0", Offset = "0x386D3D0", VA = "0x18386E5D0")]
	public static byte OBGGGAEPLHN(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x386E640", Offset = "0x386D440", VA = "0x18386E640")]
	public static ushort PMIOKGHOEHH(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x386CA80", Offset = "0x386B880", VA = "0x18386CA80")]
	public static uint ADHLIJAIHKK(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x386E450", Offset = "0x386D250", VA = "0x18386E450")]
	public static ulong KONKEJCNGAA(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x386E300", Offset = "0x386D100", VA = "0x18386E300")]
	public static float JKMKELGFOIC(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x386E3E0", Offset = "0x386D1E0", VA = "0x18386E3E0")]
	public static double KNKBNPEPNLG(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x386DAB0", Offset = "0x386C8B0", VA = "0x18386DAB0")]
	public static int GHJIKOPGCLF(ref byte[] DLJHFCENONG, int CAOPPMKILFB, ulong PEPOHKCFAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x386CB00", Offset = "0x386B900", VA = "0x18386CB00")]
	public static int BEEGGODKJHP(ref byte[] DLJHFCENONG, int CAOPPMKILFB, long PEPOHKCFAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x386D7F0", Offset = "0x386C5F0", VA = "0x18386D7F0")]
	public static bool EADHMLFCEEI(byte[] IEDOMBJDKEO, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class DODNHBMKGEM
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class ENKOMBJOBFJ : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
		[DebuggerHidden]
		public ENKOMBJOBFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x386A760", Offset = "0x3869560", VA = "0x18386A760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x386A300", Offset = "0x3869100", VA = "0x18386A300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x386A880", Offset = "0x3869680", VA = "0x18386A880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x386A8D0", Offset = "0x38696D0", VA = "0x18386A8D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x386A710", Offset = "0x3869510", VA = "0x18386A710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x386A660", Offset = "0x3869460", VA = "0x18386A660", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x386A660", Offset = "0x3869460", VA = "0x18386A660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class LKIGHMFMFHD : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x706B10", Offset = "0x705910", VA = "0x180706B10")]
		[DebuggerHidden]
		public LKIGHMFMFHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x386EE10", Offset = "0x386DC10", VA = "0x18386EE10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x386E9B0", Offset = "0x386D7B0", VA = "0x18386E9B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x386EF30", Offset = "0x386DD30", VA = "0x18386EF30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x386EF80", Offset = "0x386DD80", VA = "0x18386EF80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x386EDC0", Offset = "0x386DBC0", VA = "0x18386EDC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x386ED10", Offset = "0x386DB10", VA = "0x18386ED10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x386ED10", Offset = "0x386DB10", VA = "0x18386ED10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3866420", Offset = "0x3865220", VA = "0x183866420")]
	public static bool JDMJDABFCCA(this TypeInfo FEGCMBEFABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x38664D0", Offset = "0x38652D0", VA = "0x1838664D0")]
	public static bool JOKCMDLKIDB(this TypeInfo FEGCMBEFABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x38663C0", Offset = "0x38651C0", VA = "0x1838663C0")]
	public static IEnumerable<PropertyInfo> HIPPEMNPPNA(this Type FEGCMBEFABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x38662A0", Offset = "0x38650A0", VA = "0x1838662A0")]
	[IteratorStateMachine(typeof(ENKOMBJOBFJ))]
	private static IEnumerable<PropertyInfo> GAIMJOJDKHA(Type FEGCMBEFABH, HashSet<string> IBGOFEDMLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3866240", Offset = "0x3865040", VA = "0x183866240")]
	public static IEnumerable<FieldInfo> CPOKMHEHEKC(this Type FEGCMBEFABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3866330", Offset = "0x3865130", VA = "0x183866330")]
	[IteratorStateMachine(typeof(LKIGHMFMFHD))]
	private static IEnumerable<FieldInfo> HAIBOOMJLCM(Type FEGCMBEFABH, HashSet<string> IBGOFEDMLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class BKJAKMFGCCP
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding ANFPLJKFEGF;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class MICAADNCABK
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4E0", Offset = "0x5D92E0", VA = "0x1805DA4E0")]
	public static string LJIHCIBKMDO(string EIGPEBMCCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x429BA80", Offset = "0x429A880", VA = "0x18429BA80")]
	public static string KKHPPPCKMFC(string EIGPEBMCCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x429B8B0", Offset = "0x429A6B0", VA = "0x18429B8B0")]
	public static string BDMMNGPDDCB(string EIGPEBMCCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class DMMDPLBGKDA<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HIKCPAECOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type EKMCGMDHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue NMGHIPGAEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int KODFJICOHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HIKCPAECOHO CHNIPAPIDDL;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x38F70F0", Offset = "0x38F5EF0", VA = "0x1838F70F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x38F7070", Offset = "0x38F5E70", VA = "0x1838F7070")]
		private int PJJBNMLIMKK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public HIKCPAECOHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class EBLBILAGPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public EBLBILAGPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5C6390", Offset = "0x5C5190", VA = "0x1805C6390")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private HIKCPAECOHO[] IEBPDFFFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int ILOELBIABFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object LKJGFNHKDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float DNKFLMDMBOP;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x38F2340", Offset = "0x38F1140", VA = "0x1838F2340")]
	public DMMDPLBGKDA(int IMNCEOIPJNE = 4, float DNKFLMDMBOP = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x38F1E10", Offset = "0x38F0C10", VA = "0x1838F1E10")]
	public bool LLIEDMKLNJB(Type IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x38F2030", Offset = "0x38F0E30", VA = "0x1838F2030")]
	public bool LLIEDMKLNJB(Type IFKOMGEEEMC, Func<Type, TValue> HLJHEEMEAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x38F1680", Offset = "0x38F0480", VA = "0x1838F1680")]
	private bool CKBHHPDDOHM(Type IFKOMGEEEMC, Func<Type, TValue> HLJHEEMEAFD, out TValue EHGOODIPGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x38F12C0", Offset = "0x38F00C0", VA = "0x1838F12C0")]
	private bool BIOKCJIDKAD(HIKCPAECOHO[] IEBPDFFFPGL, Type HEOANAMCHEA, HIKCPAECOHO DCNHABGGIFJ, Func<Type, TValue> HLJHEEMEAFD, out TValue EHGOODIPGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x38F20A0", Offset = "0x38F0EA0", VA = "0x1838F20A0")]
	public bool PDIMMFIGHEA(Type IFKOMGEEEMC, out TValue PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x38F1D30", Offset = "0x38F0B30", VA = "0x1838F1D30")]
	public TValue KIBNCMDPOBB(Type IFKOMGEEEMC, Func<Type, TValue> HLJHEEMEAFD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x35EA930", Offset = "0x35E9730", VA = "0x1835EA930")]
	private static int LLHMBKFDFFG(int FDFCNMEBPPG, float DNKFLMDMBOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x38F2070", Offset = "0x38F0E70", VA = "0x1838F2070")]
	private static void MOHIKADNPGM(ref HIKCPAECOHO NLLJLFIANGM, HIKCPAECOHO PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x38F2070", Offset = "0x38F0E70", VA = "0x1838F2070")]
	private static void MOHIKADNPGM(ref HIKCPAECOHO[] NLLJLFIANGM, HIKCPAECOHO[] PEPOHKCFAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class DEONEPEIIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder NGGHADGOBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder BEJBGEIPEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object DENIBGCJEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3862450", Offset = "0x3861250", VA = "0x183862450")]
	public TypeBuilder KNMAINCKFIK(string CLDEJGBBMEF, TypeAttributes GNGMBGJBFNF, Type ABHIDEANEGM, Type[] BAENAJKFNLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3862540", Offset = "0x3861340", VA = "0x183862540")]
	public DEONEPEIIOL(string IGKMHEHFFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class GIGIECICHFO
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x35F9BD0", Offset = "0x35F89D0", VA = "0x1835F9BD0")]
	private static MethodInfo HOIDMEFOINO(LambdaExpression KAKEOADBNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D9B0", Offset = "0x3D8C7B0", VA = "0x183D8D9B0")]
	public static MethodInfo EIMNIJMDPNJ<T>(Expression<Func<T>> KAKEOADBNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D9B0", Offset = "0x3D8C7B0", VA = "0x183D8D9B0")]
	public static MethodInfo EIMNIJMDPNJ<T, TR>(Expression<Func<T, TR>> KAKEOADBNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D9B0", Offset = "0x3D8C7B0", VA = "0x183D8D9B0")]
	public static MethodInfo EIMNIJMDPNJ<T>(Expression<Action<T>> KAKEOADBNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D9B0", Offset = "0x3D8C7B0", VA = "0x183D8D9B0")]
	public static MethodInfo EIMNIJMDPNJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> KAKEOADBNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D910", Offset = "0x3D8C710", VA = "0x183D8D910")]
	private static MemberInfo ANHKELHFEJE<T>(Expression<T> KLEAHJOOHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D9C0", Offset = "0x3D8C7C0", VA = "0x183D8D9C0")]
	public static PropertyInfo ILLEPNDPHIM<T, TR>(Expression<Func<T, TR>> KAKEOADBNKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct LIKCLPOBDDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int KOHLIKKCMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool BJMJLEPEEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator KPIDMNENJHI;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x429AE80", Offset = "0x4299C80", VA = "0x18429AE80")]
	public LIKCLPOBDDJ(ILGenerator KPIDMNENJHI, int KOHLIKKCMDH, bool BJMJLEPEEPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x429AEC0", Offset = "0x4299CC0", VA = "0x18429AEC0")]
	public LIKCLPOBDDJ(ILGenerator KPIDMNENJHI, int KOHLIKKCMDH, Type FEGCMBEFABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x429AE60", Offset = "0x4299C60", VA = "0x18429AE60")]
	public void NFPOELKGEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class HHHPHCAAGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x35FCAE0", Offset = "0x35FB8E0", VA = "0x1835FCAE0")]
	public static void IHAOIIGOACF(this ILGenerator KPIDMNENJHI, int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x35FCD10", Offset = "0x35FBB10", VA = "0x1835FCD10")]
	public static void IHAOIIGOACF(this ILGenerator KPIDMNENJHI, LocalBuilder KGDIIEPNOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x35FC5E0", Offset = "0x35FB3E0", VA = "0x1835FC5E0")]
	public static void HEHFMPMCEKC(this ILGenerator KPIDMNENJHI, int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x35FC810", Offset = "0x35FB610", VA = "0x1835FC810")]
	public static void HEHFMPMCEKC(this ILGenerator KPIDMNENJHI, LocalBuilder KGDIIEPNOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x35FC850", Offset = "0x35FB650", VA = "0x1835FC850")]
	public static void IBGPAEAAMOF(this ILGenerator KPIDMNENJHI, int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x35FC940", Offset = "0x35FB740", VA = "0x1835FC940")]
	public static void IBGPAEAAMOF(this ILGenerator KPIDMNENJHI, LocalBuilder KGDIIEPNOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x35FC5D0", Offset = "0x35FB3D0", VA = "0x1835FC5D0")]
	public static void GMOEIBCIKBF(this ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x35FC5C0", Offset = "0x35FB3C0", VA = "0x1835FC5C0")]
	public static void FJMDOECEKGB(this ILGenerator KPIDMNENJHI, bool PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x35FCDE0", Offset = "0x35FBBE0", VA = "0x1835FCDE0")]
	public static void NIBAKLGCGMF(this ILGenerator KPIDMNENJHI, int PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x35FD2D0", Offset = "0x35FC0D0", VA = "0x1835FD2D0")]
	public static void OIIDJFBLPNL(this ILGenerator KPIDMNENJHI, Type FEGCMBEFABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x35FD230", Offset = "0x35FC030", VA = "0x1835FD230")]
	public static void NJFHMKFPPEH(this ILGenerator KPIDMNENJHI, Type FEGCMBEFABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x35FC390", Offset = "0x35FB190", VA = "0x1835FC390")]
	public static void CEFOJBDEJPJ(this ILGenerator KPIDMNENJHI, int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x35FC310", Offset = "0x35FB110", VA = "0x1835FC310")]
	public static void AJGPNAIPLLA(this ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x35FD4C0", Offset = "0x35FC2C0", VA = "0x1835FD4C0")]
	public static void PPIFNBFPEEL(this ILGenerator KPIDMNENJHI, int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x35FD3C0", Offset = "0x35FC1C0", VA = "0x1835FD3C0")]
	public static void OJJAJPBFANJ(this ILGenerator KPIDMNENJHI, MethodInfo COCIIIJIBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x35FCD50", Offset = "0x35FBB50", VA = "0x1835FCD50")]
	public static void IOBFCPHKBLM(this ILGenerator KPIDMNENJHI, FieldInfo NJCNDFAKCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x35FCA50", Offset = "0x35FB850", VA = "0x1835FCA50")]
	public static void IEIMKKMGKHK(this ILGenerator KPIDMNENJHI, ulong PEPOHKCFAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class FFGBNJDEJLK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class EACAKFLEKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public EACAKFLEKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3866A00", Offset = "0x3865800", VA = "0x183866A00")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo CPJAGALMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo LPLMJHJMCOI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PDFFKONPKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string CPOEODIIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HHLJMNMJMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x386C380", Offset = "0x386B180", VA = "0x18386C380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DCOIOEHNPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x522190", Offset = "0x520F90", VA = "0x180522190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4A0", Offset = "0x5DA2A0", VA = "0x1805DB4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AADKNEJPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5221A0", Offset = "0x520FA0", VA = "0x1805221A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x765020", Offset = "0x763E20", VA = "0x180765020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type LFIEJOANCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x54B0C0", Offset = "0x549EC0", VA = "0x18054B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x650410", Offset = "0x64F210", VA = "0x180650410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo JCNCKKDJKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo KACLCOEOLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x523010", Offset = "0x521E10", VA = "0x180523010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x523020", Offset = "0x521E20", VA = "0x180523020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo AJEBGLEPBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x535D70", Offset = "0x534B70", VA = "0x180535D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5C52A0", Offset = "0x5C40A0", VA = "0x1805C52A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x386C600", Offset = "0x386B400", VA = "0x18386C600")]
	protected FFGBNJDEJLK(Type FEGCMBEFABH, string CLDEJGBBMEF, string CILMBOEPMJJ, bool IPCBLILDEGO, bool OOHECHAHPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x386C680", Offset = "0x386B480", VA = "0x18386C680")]
	public FFGBNJDEJLK(FieldInfo HOHHDPMJFFP, string CLDEJGBBMEF, bool EPOBMKDFEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x386C450", Offset = "0x386B250", VA = "0x18386C450")]
	public FFGBNJDEJLK(PropertyInfo HOHHDPMJFFP, string CLDEJGBBMEF, bool EPOBMKDFEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x386C1A0", Offset = "0x386AFA0", VA = "0x18386C1A0")]
	private static MethodInfo ELKPKNJNAAG(MemberInfo HOHHDPMJFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2B59350", Offset = "0x2B58150", VA = "0x182B59350")]
	public T JCHKHCEGDHK<T>(bool GIOFKOOJHNB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x386C2C0", Offset = "0x386B0C0", VA = "0x18386C2C0", Slot = "4")]
	public virtual void KHDENBFACIC(ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x386C390", Offset = "0x386B190", VA = "0x18386C390", Slot = "5")]
	public virtual void NBCDEEFKFDJ(ILGenerator KPIDMNENJHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class BHINEPBDCII : FFGBNJDEJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string PLCOPFHKOGO;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x385AA10", Offset = "0x3859810", VA = "0x18385AA10")]
	public BHINEPBDCII(string CLDEJGBBMEF, string PLCOPFHKOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x385A900", Offset = "0x3859700", VA = "0x18385A900", Slot = "4")]
	public override void KHDENBFACIC(ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x385A9C0", Offset = "0x38597C0", VA = "0x18385A9C0", Slot = "5")]
	public override void NBCDEEFKFDJ(ILGenerator KPIDMNENJHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class FPJPJOBFEBG : FFGBNJDEJLK
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo MNFHINKPKEI;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo AJHJAPLECJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal LIKCLPOBDDJ BENLIDAKJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal LIKCLPOBDDJ BHKGALCFMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal LIKCLPOBDDJ ADKHFPMMLHD;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x35EF1B0", Offset = "0x35EDFB0", VA = "0x1835EF1B0")]
	public FPJPJOBFEBG(string CLDEJGBBMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x35EEAF0", Offset = "0x35ED8F0", VA = "0x1835EEAF0", Slot = "4")]
	public override void KHDENBFACIC(ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x35EECC0", Offset = "0x35EDAC0", VA = "0x1835EECC0", Slot = "5")]
	public override void NBCDEEFKFDJ(ILGenerator KPIDMNENJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x35EEBB0", Offset = "0x35ED9B0", VA = "0x1835EEBB0")]
	public void MALFFAFGKGN(ILGenerator KPIDMNENJHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class NPHCFKFPHEO
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type LFIEJOANCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HNEOIJGNPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x769780", Offset = "0x768580", VA = "0x180769780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x769D40", Offset = "0x768B40", VA = "0x180769D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CLBHJNFCEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x81E610", Offset = "0x81D410", VA = "0x18081E610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x81E680", Offset = "0x81D480", VA = "0x18081E680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo FJPNAHKMMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FFGBNJDEJLK[] HIKEGEIAALP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x54B0C0", Offset = "0x549EC0", VA = "0x18054B0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x650410", Offset = "0x64F210", VA = "0x180650410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FFGBNJDEJLK[] ECDGKDINAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x429CBC0", Offset = "0x429B9C0", VA = "0x18429CBC0")]
	public NPHCFKFPHEO(Type FEGCMBEFABH, Func<string, string> PMHDFEKDEJN, bool EPOBMKDFEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x429CAF0", Offset = "0x429B8F0", VA = "0x18429CAF0")]
	private static bool GAIBNFHFNDE(IEnumerator<ConstructorInfo> DLDAMHIBFMI, ref ConstructorInfo LMABLJIPHNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct EECKFAKKICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong OLMJDJKENIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int FLNLIILPCOE;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C300", Offset = "0x2A9B100", VA = "0x182A9C300")]
	public EECKFAKKICP(ulong GNOMGDPACNC, int COAOLOCDDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3868680", Offset = "0x3867480", VA = "0x183868680")]
	public void EINECDDFLLP(ref EECKFAKKICP KBAPGFOKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3868690", Offset = "0x3867490", VA = "0x183868690")]
	public static EECKFAKKICP GIDGPINEPIK(ref EECKFAKKICP OCNFPNPPOJC, ref EECKFAKKICP BAHCPBFJIGN)
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3868760", Offset = "0x3867560", VA = "0x183868760")]
	public void PJHEHPDCCKJ(ref EECKFAKKICP KBAPGFOKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x38685D0", Offset = "0x38673D0", VA = "0x1838685D0")]
	public static EECKFAKKICP BFDGCOFKGAK(ref EECKFAKKICP OCNFPNPPOJC, ref EECKFAKKICP BAHCPBFJIGN)
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x38686C0", Offset = "0x38674C0", VA = "0x1838686C0")]
	public void MDBAPBDMONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3868700", Offset = "0x3867500", VA = "0x183868700")]
	public static EECKFAKKICP MDBAPBDMONK(ref EECKFAKKICP OCNFPNPPOJC)
	{
		return default(EECKFAKKICP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct HDELBAPNJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] DLJHFCENONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int CAOPPMKILFB;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA836F0", Offset = "0xA824F0", VA = "0x180A836F0")]
	public HDELBAPNJCI(byte[] DLJHFCENONG, int ANCLOMCNDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x35FBA50", Offset = "0x35FA850", VA = "0x1835FBA50")]
	public void DHDFDAIEGPL(byte EKDDMDAOKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x35FB8B0", Offset = "0x35FA6B0", VA = "0x1835FB8B0")]
	public void AFCACAJFPMH(byte[] EKDDMDAOKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x35FBBE0", Offset = "0x35FA9E0", VA = "0x1835FBBE0")]
	public void HJDMOFGEBNL(byte[] EKDDMDAOKHM, int LBDDMJPBOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x35FBB30", Offset = "0x35FA930", VA = "0x1835FBB30")]
	public void HJDMOFGEBNL(byte[] EKDDMDAOKHM, int HAPPPLCCINM, int LBDDMJPBOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x35FBAB0", Offset = "0x35FA8B0", VA = "0x1835FBAB0")]
	public void EKMHIGKOPML(byte PMOBKAEONAF, int FDHPLBOBCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x35FB950", Offset = "0x35FA750", VA = "0x1835FB950")]
	public void BKGIIHLIPFH(string EKDDMDAOKHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class LHBDDGCIFDF
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum NEPIBDJCMBO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum BCNOHMDEBAM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum MJMJPCGGCBF
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
	private static byte[] EIKKCFDLEBM;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] PDJKPMOGJKI;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] DMFCMCOGIOM;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] FFAIGPAKHAK;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly MJMJPCGGCBF DPDGJHNNALD;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char ADEKNAFOHHG;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int HEEHGOAGEEF;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int AHDMMAGFBME;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] MJIHMFLGPEO;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x429A8C0", Offset = "0x42996C0", VA = "0x18429A8C0")]
	private static byte[] LHEIANPNGEM(int ILOELBIABFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4299250", Offset = "0x4298050", VA = "0x184299250")]
	private static byte[] AOKALLFLPLG(int ILOELBIABFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x429AAA0", Offset = "0x42998A0", VA = "0x18429AAA0")]
	public static int LIBIIHBBIIG(ref byte[] DLJHFCENONG, int CAOPPMKILFB, float PEPOHKCFAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x429A990", Offset = "0x4299790", VA = "0x18429A990")]
	public static int LIBIIHBBIIG(ref byte[] DLJHFCENONG, int CAOPPMKILFB, double PEPOHKCFAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x429A7C0", Offset = "0x42995C0", VA = "0x18429A7C0")]
	private static bool LFJNICCNIDL(byte[] DLJHFCENONG, int LBDDMJPBOJI, ulong DPNBDJDCEIP, ulong PHMJMHFFLEE, ulong BAKBBIICEFA, ulong CBOCCMBLAPE, ulong BECNJLPGGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4299C30", Offset = "0x4298A30", VA = "0x184299C30")]
	private static void HFEBCAGJJOC(uint OBJGOBOKNJB, int KJGODFDOJJJ, out uint FOIFFIHOODK, out int HJIAEIGLAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x429A370", Offset = "0x4299170", VA = "0x18429A370")]
	private static bool JHCIGCGNMNN(EECKFAKKICP GCOACHJLBLO, EECKFAKKICP LMHLEELBKOB, EECKFAKKICP HANODEAODAD, byte[] DLJHFCENONG, out int LBDDMJPBOJI, out int PMHPHHIEBPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x42994B0", Offset = "0x42982B0", VA = "0x1842994B0")]
	private static bool BOHJNLDIMCD(double GOCEOGCFGOI, NEPIBDJCMBO BANMLNILNAN, byte[] DLJHFCENONG, out int LBDDMJPBOJI, out int NMPJEKOCKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x429ABB0", Offset = "0x42999B0", VA = "0x18429ABB0")]
	private static bool OHLPHINADBC(double GOCEOGCFGOI, NEPIBDJCMBO BANMLNILNAN, byte[] DLJHFCENONG, out int LBDDMJPBOJI, out int ADOABHEDCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x42990C0", Offset = "0x4297EC0", VA = "0x1842990C0")]
	private static bool ACMJHBIGILN(double PEPOHKCFAOG, ref HDELBAPNJCI DPNMIJADNCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4299D50", Offset = "0x4298B50", VA = "0x184299D50")]
	private static bool HMBCNOABAKA(double PEPOHKCFAOG, ref HDELBAPNJCI DPNMIJADNCO, BCNOHMDEBAM BANMLNILNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4299780", Offset = "0x4298580", VA = "0x184299780")]
	private static void CBAINJHHENO(byte[] LLMBHKGAPEA, int LBDDMJPBOJI, int ADOABHEDCCA, int ONACDKONCHL, ref HDELBAPNJCI DPNMIJADNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4299940", Offset = "0x4298740", VA = "0x184299940")]
	private static void CIOFEKMPNOL(byte[] LLMBHKGAPEA, int LBDDMJPBOJI, int COAOLOCDDIF, ref HDELBAPNJCI DPNMIJADNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4299330", Offset = "0x4298130", VA = "0x184299330")]
	private static bool BAIDDANCGLL(double GOCEOGCFGOI, BCNOHMDEBAM BANMLNILNAN, int NDNECFHBPPH, byte[] CPNAFBCFJLO, out bool NJOAINKMNCD, out int LBDDMJPBOJI, out int JBDAPFGHENJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct HNMOFBGEPEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double NBJFNMANLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong JNHNPLAJJMD;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct PGEADPLIOEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float OLMJDJKENIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint OPPGAGOJLGF;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct LFNDLDJENAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong KBCKKOIHEFP;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x15E6340", Offset = "0x15E5140", VA = "0x1815E6340")]
	public LFNDLDJENAL(double NBJFNMANLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4298750", Offset = "0x4297550", VA = "0x184298750")]
	public LFNDLDJENAL(EECKFAKKICP NBJFNMANLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4298570", Offset = "0x4297370", VA = "0x184298570")]
	public EECKFAKKICP MAKOFGIMBIL()
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4298640", Offset = "0x4297440", VA = "0x184298640")]
	public EECKFAKKICP NAGIFJPAFJM()
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5C6380", Offset = "0x5C5180", VA = "0x1805C6380")]
	public ulong ACPGEEHBGAF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4298160", Offset = "0x4296F60", VA = "0x184298160")]
	public double AFHJMLDFOIM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4298490", Offset = "0x4297290", VA = "0x184298490")]
	public double JAFAEMFLMIN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4298270", Offset = "0x4297070", VA = "0x184298270")]
	public int CHOKPGGKJPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4298430", Offset = "0x4297230", VA = "0x184298430")]
	public ulong EHADLABGGHP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4298700", Offset = "0x4297500", VA = "0x184298700")]
	public bool OHBLGBHDHDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x42986E0", Offset = "0x42974E0", VA = "0x1842986E0")]
	public bool NJAHFFFNJIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4298510", Offset = "0x4297310", VA = "0x184298510")]
	public bool KGEEIAHGNAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4298540", Offset = "0x4297340", VA = "0x184298540")]
	public bool LENJNKFFHIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4298730", Offset = "0x4297530", VA = "0x184298730")]
	public int PNJHLJININA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x42982A0", Offset = "0x42970A0", VA = "0x1842982A0")]
	public void CIPCIENGABG(out EECKFAKKICP IJEDMOEFFKL, out EECKFAKKICP OMNMONHLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x42985F0", Offset = "0x42973F0", VA = "0x1842985F0")]
	public bool MGGPAAIKHIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4298720", Offset = "0x4297520", VA = "0x184298720")]
	public double PEPOHKCFAOG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4298470", Offset = "0x4297270", VA = "0x184298470")]
	public static int ILHEMPNLJOF(int HKCLGNPBNOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4298460", Offset = "0x4297260", VA = "0x184298460")]
	public static double HHHGFMHBLDB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x42981D0", Offset = "0x4296FD0", VA = "0x1842981D0")]
	public static ulong AHAPKHOKHFE(EECKFAKKICP NFDPEKAHDIK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct ABHGMPPKEGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint NFLDOPAGJNL;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x75A720", Offset = "0x759520", VA = "0x18075A720")]
	public ABHGMPPKEGI(float OLMJDJKENIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3858010", Offset = "0x3856E10", VA = "0x183858010")]
	public EECKFAKKICP MAKOFGIMBIL()
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C63C0", Offset = "0x5C51C0", VA = "0x1805C63C0")]
	public uint ADKGFEOOHFA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3857EA0", Offset = "0x3856CA0", VA = "0x183857EA0")]
	public int CHOKPGGKJPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3857FF0", Offset = "0x3856DF0", VA = "0x183857FF0")]
	public uint EHADLABGGHP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x38580A0", Offset = "0x3856EA0", VA = "0x1838580A0")]
	public bool OHBLGBHDHDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3857EC0", Offset = "0x3856CC0", VA = "0x183857EC0")]
	public void CIPCIENGABG(out EECKFAKKICP IJEDMOEFFKL, out EECKFAKKICP OMNMONHLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3858060", Offset = "0x3856E60", VA = "0x183858060")]
	public bool MGGPAAIKHIA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct CALMAFLKHFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong GNOMGDPACNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short LNLNEOPHJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short NMPJEKOCKNM;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x385CD00", Offset = "0x385BB00", VA = "0x18385CD00")]
	public CALMAFLKHFB(ulong GNOMGDPACNC, short LNLNEOPHJNH, short NMPJEKOCKNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class ADGKLKKDPEA
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly CALMAFLKHFB[] NMALAKGPAMH;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x38582B0", Offset = "0x38570B0", VA = "0x1838582B0")]
	public static void MHLEMLNMILD(int MKJDOOBKGLK, int EEIOPKONPBG, out EECKFAKKICP FOIFFIHOODK, out int NMPJEKOCKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x38581C0", Offset = "0x3856FC0", VA = "0x1838581C0")]
	public static void CBDIPFAOJFH(int OAOHMMEMBLK, out EECKFAKKICP FOIFFIHOODK, out int ONOGLKBPMLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct LJFBCBFBBCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] IEDOMBJDKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int HAPPPLCCINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int AAGJKMGHEGC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x429AFB0", Offset = "0x4299DB0", VA = "0x18429AFB0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xD890C0", Offset = "0xD87EC0", VA = "0x180D890C0")]
	public LJFBCBFBBCB(byte[] IEDOMBJDKEO, int HAPPPLCCINM, int LBDDMJPBOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9C2B10", Offset = "0x9C1910", VA = "0x1809C2B10")]
	public int LBDDMJPBOJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x429AF50", Offset = "0x4299D50", VA = "0x18429AF50")]
	public LJFBCBFBBCB BCFMDBILCHJ(int JLJBHLOFJPD, int LLJJBKAPJGF)
	{
		return default(LJFBCBFBBCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class GGDOBKLDHBI
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] IACNONENOLM;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] DOEOGEIEDCO;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int KDDPELJBKNF;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x35F8D50", Offset = "0x35F7B50", VA = "0x1835F8D50")]
	private static byte[] GCMBICCIAHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x35F9900", Offset = "0x35F8700", VA = "0x1835F9900")]
	private static LJFBCBFBBCB OINDHJCGCEF(LJFBCBFBBCB DLJHFCENONG)
	{
		return default(LJFBCBFBBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x35F95E0", Offset = "0x35F83E0", VA = "0x1835F95E0")]
	private static LJFBCBFBBCB NOOAANJBPPK(LJFBCBFBBCB DLJHFCENONG)
	{
		return default(LJFBCBFBBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x35F8E30", Offset = "0x35F7C30", VA = "0x1835F8E30")]
	private static void INDNMPLGMFD(LJFBCBFBBCB DLJHFCENONG, int COAOLOCDDIF, byte[] BCJEJFPFNBM, out int MKEIFFFELAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x35F88C0", Offset = "0x35F76C0", VA = "0x1835F88C0")]
	private static void BMPOCFEHMDO(LJFBCBFBBCB DLJHFCENONG, int COAOLOCDDIF, byte[] HJNCIDOMDIH, int AEKDAPIBAPO, out LJFBCBFBBCB JEPHPEGMDMH, out int FPNHEPKKBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x35F8EF0", Offset = "0x35F7CF0", VA = "0x1835F8EF0")]
	private static ulong LDLCEOAHLNA(LJFBCBFBBCB DLJHFCENONG, out int HGDHGNEDMDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x35F9490", Offset = "0x35F8290", VA = "0x1835F9490")]
	private static void NJLAAPMGCNN(LJFBCBFBBCB DLJHFCENONG, out EECKFAKKICP OEKNFPMCAIF, out int KMCFFALFFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x35F90E0", Offset = "0x35F7EE0", VA = "0x1835F90E0")]
	private static bool NHPIOIPBJNP(LJFBCBFBBCB JEPHPEGMDMH, int COAOLOCDDIF, out double OEKNFPMCAIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x35F8F80", Offset = "0x35F7D80", VA = "0x1835F8F80")]
	private static EECKFAKKICP MDAFNDHAKKB(int COAOLOCDDIF)
	{
		return default(EECKFAKKICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x35F8520", Offset = "0x35F7320", VA = "0x1835F8520")]
	private static bool AJJJCKKGLFD(LJFBCBFBBCB DLJHFCENONG, int COAOLOCDDIF, out double OEKNFPMCAIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x35F9690", Offset = "0x35F8490", VA = "0x1835F9690")]
	private static bool OCJLNAGAMNC(LJFBCBFBBCB JEPHPEGMDMH, int COAOLOCDDIF, out double CIHOMADDOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x35F97D0", Offset = "0x35F85D0", VA = "0x1835F97D0")]
	public static double? OGPBMODFAJB(LJFBCBFBBCB DLJHFCENONG, int COAOLOCDDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x35F8B70", Offset = "0x35F7970", VA = "0x1835F8B70")]
	public static float? CBAJLNMCDNJ(LJFBCBFBBCB DLJHFCENONG, int COAOLOCDDIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct PKGLINPEBHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] DLJHFCENONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int CAOPPMKILFB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x429E550", Offset = "0x429D350", VA = "0x18429E550")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA836F0", Offset = "0xA824F0", VA = "0x180A836F0")]
	public PKGLINPEBHP(byte[] DLJHFCENONG, int CAOPPMKILFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x429E440", Offset = "0x429D240", VA = "0x18429E440")]
	public static PKGLINPEBHP EJJMJKFPEIL(PKGLINPEBHP OOHLLAEGIIK)
	{
		return default(PKGLINPEBHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x429E4F0", Offset = "0x429D2F0", VA = "0x18429E4F0")]
	public static PKGLINPEBHP MBKONHDDFDE(PKGLINPEBHP OOHLLAEGIIK, int LBDDMJPBOJI)
	{
		return default(PKGLINPEBHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x429E590", Offset = "0x429D390", VA = "0x18429E590")]
	public static int PAILFEFMMAH(PKGLINPEBHP COMGDPEPLKC, PKGLINPEBHP HJFFDGEGELD)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x429E3A0", Offset = "0x429D1A0", VA = "0x18429E3A0")]
	public static bool AILHDGEAGAB(PKGLINPEBHP COMGDPEPLKC, PKGLINPEBHP HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x429E4D0", Offset = "0x429D2D0", VA = "0x18429E4D0")]
	public static bool HBNNFNJCOBM(PKGLINPEBHP COMGDPEPLKC, PKGLINPEBHP HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x429E360", Offset = "0x429D160", VA = "0x18429E360")]
	public static bool AILHDGEAGAB(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x429E490", Offset = "0x429D290", VA = "0x18429E490")]
	public static bool HBNNFNJCOBM(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x429E490", Offset = "0x429D290", VA = "0x18429E490")]
	public static bool HBNNFNJCOBM(PKGLINPEBHP COMGDPEPLKC, byte HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x429E320", Offset = "0x429D120", VA = "0x18429E320")]
	public static bool ABPNFMEHONF(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x429E3C0", Offset = "0x429D1C0", VA = "0x18429E3C0")]
	public static bool CDDNFGLMCBD(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x429E450", Offset = "0x429D250", VA = "0x18429E450")]
	public static bool FDEBAIEGNHA(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x429E400", Offset = "0x429D200", VA = "0x18429E400")]
	public static bool DGKGFFEBPNF(PKGLINPEBHP COMGDPEPLKC, char HJFFDGEGELD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class JHINLGJBLBI
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] DLEHLENHAFF;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] GMAEACFJNCJ;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] DMFCMCOGIOM;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] FFAIGPAKHAK;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] NNELOBEDNHE;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int KMOOOFJKLOL;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] KIAEEIBFKCA;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int LNDKBPJBAHK;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4295DB0", Offset = "0x4294BB0", VA = "0x184295DB0")]
	private static byte[] ICCOFGLAEON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4295CD0", Offset = "0x4294AD0", VA = "0x184295CD0")]
	private static byte[] HOMHBPAFOHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4295AF0", Offset = "0x42948F0", VA = "0x184295AF0")]
	public static double FKNHLGBNEBL(byte[] DLJHFCENONG, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4295E90", Offset = "0x4294C90", VA = "0x184295E90")]
	public static float KOLCMAGDNAH(byte[] DLJHFCENONG, int CAOPPMKILFB, out int KALPCNBIPDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x42960E0", Offset = "0x4294EE0", VA = "0x1842960E0")]
	private static bool PPHLMKMKPPA(int DCMLOLBECIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4295FB0", Offset = "0x4294DB0", VA = "0x184295FB0")]
	private static bool MMMJAOLNKCN(ref PKGLINPEBHP ENDNHOAIPKE, PKGLINPEBHP NIFLCMKMBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4295BB0", Offset = "0x42949B0", VA = "0x184295BB0")]
	private static bool GGFJPEADJGC(ref PKGLINPEBHP ENDNHOAIPKE, PKGLINPEBHP NIFLCMKMBDD, byte[] JLMHDGHOFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4295F50", Offset = "0x4294D50", VA = "0x184295F50")]
	private static bool LFFABEJGALJ(ref PKGLINPEBHP GNFGONOJOCC, byte[] EKDDMDAOKHM, int CAOPPMKILFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xA5A890", Offset = "0xA59690", VA = "0x180A5A890")]
	private static double IIBHIAMLPKG(bool NJOAINKMNCD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4294B40", Offset = "0x4293940", VA = "0x184294B40")]
	private static double DLFDPBAGELF(PKGLINPEBHP GOPNEDIFNEH, int LBDDMJPBOJI, bool DEBOHJBIAOC, out int INNEMOAOFLH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class KCBMAJIMHBK<T> : global::EAILOOFMBAA<T[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::JPOHBEBMLBI<T> BKMPFCBAJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly LIEOELCGNLK FFAAOHEOLIM;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3453AC0", Offset = "0x34528C0", VA = "0x183453AC0")]
	public KCBMAJIMHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x26011A0", Offset = "0x25FFFA0", VA = "0x1826011A0")]
	public KCBMAJIMHBK(LIEOELCGNLK FFAAOHEOLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8130", Offset = "0x3DB6F30", VA = "0x183DB8130", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, T[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9ED0", Offset = "0x3DB8CD0", VA = "0x183DB9ED0", Slot = "5")]
	public T[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class CCCJJLABJJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::JPOHBEBMLBI<T> BKMPFCBAJBA;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class KBGEIOPEGGE<T> : global::EAILOOFMBAA<List<T>>, POOHDCJJHAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly LIEOELCGNLK FFAAOHEOLIM;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3453AC0", Offset = "0x34528C0", VA = "0x183453AC0")]
	public KBGEIOPEGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x26011A0", Offset = "0x25FFFA0", VA = "0x1826011A0")]
	public KBGEIOPEGGE(LIEOELCGNLK FFAAOHEOLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB71C0", Offset = "0x3DB5FC0", VA = "0x183DB71C0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, List<T> PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7B70", Offset = "0x3DB6970", VA = "0x183DB7B70", Slot = "5")]
	public List<T> PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class AKGCKJHCPJC<TElement, TIntermediate, TEnumerator, TCollection> : global::EAILOOFMBAA<TCollection>, POOHDCJJHAO where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x32897F0", Offset = "0x32885F0", VA = "0x1832897F0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, TCollection PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x328A420", Offset = "0x3289220", VA = "0x18328A420", Slot = "5")]
	public TCollection PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JANBGIPBIID(TCollection KLEAHJOOHFN);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBNMOHOMNBD();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NGPIMMKGFMI(ref TIntermediate JOKLCLMKOJG, int IMDCPBGFCMD, TElement PEPOHKCFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ALCOILIHPJM(ref TIntermediate BKBJAEEPGDG);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
	protected AKGCKJHCPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class LEDHFHPIHAB<TElement, TIntermediate, TCollection> : global::AKGCKJHCPJC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE790", Offset = "0x2FBD590", VA = "0x182FBE790", Slot = "6")]
	protected override IEnumerator<TElement> JANBGIPBIID(TCollection KLEAHJOOHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x267C4A0", Offset = "0x267B2A0", VA = "0x18267C4A0")]
	protected LEDHFHPIHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class ACOLCABIFGC<TElement, TCollection> : global::LEDHFHPIHAB<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected sealed override TCollection ALCOILIHPJM(ref TCollection BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class FAAHKPAPACP<TElement, TCollection> : global::ACOLCABIFGC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA960", Offset = "0x3EB9760", VA = "0x183EBA960", Slot = "7")]
	protected override TCollection FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA980", Offset = "0x3EB9780", VA = "0x183EBA980", Slot = "8")]
	protected override void NGPIMMKGFMI(ref TCollection JOKLCLMKOJG, int IMDCPBGFCMD, TElement PEPOHKCFAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class DJBCONIBOGM<T> : global::AKGCKJHCPJC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3540A60", Offset = "0x353F860", VA = "0x183540A60", Slot = "8")]
	protected override void NGPIMMKGFMI(ref LinkedList<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override LinkedList<T> ALCOILIHPJM(ref LinkedList<T> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override LinkedList<T> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCBE00", Offset = "0x3CCAC00", VA = "0x183CCBE00", Slot = "6")]
	protected override LinkedList<T>.Enumerator JANBGIPBIID(LinkedList<T> KLEAHJOOHFN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PJONAAGFOIP<T> : global::AKGCKJHCPJC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3540A60", Offset = "0x353F860", VA = "0x183540A60", Slot = "8")]
	protected override void NGPIMMKGFMI(ref Queue<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override Queue<T> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3540A10", Offset = "0x353F810", VA = "0x183540A10", Slot = "6")]
	protected override Queue<T>.Enumerator JANBGIPBIID(Queue<T> KLEAHJOOHFN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override Queue<T> ALCOILIHPJM(ref Queue<T> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class DEFCEJDAKBE<T> : global::AKGCKJHCPJC<T, global::CKJPIKONOGC<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x35E85B0", Offset = "0x35E73B0", VA = "0x1835E85B0", Slot = "8")]
	protected override void NGPIMMKGFMI(ref global::CKJPIKONOGC<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB10", Offset = "0x3A8B910", VA = "0x183A8CB10", Slot = "7")]
	protected override global::CKJPIKONOGC<T> FBNMOHOMNBD()
	{
		return default(global::CKJPIKONOGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3540A10", Offset = "0x353F810", VA = "0x183540A10", Slot = "6")]
	protected override Stack<T>.Enumerator JANBGIPBIID(Stack<T> KLEAHJOOHFN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76A0", Offset = "0x3CC64A0", VA = "0x183CC76A0", Slot = "9")]
	protected override Stack<T> ALCOILIHPJM(ref global::CKJPIKONOGC<T> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class ANDJIGNKJOG<T> : global::AKGCKJHCPJC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3540A60", Offset = "0x353F860", VA = "0x183540A60", Slot = "8")]
	protected override void NGPIMMKGFMI(ref HashSet<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override HashSet<T> ALCOILIHPJM(ref HashSet<T> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override HashSet<T> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3540A10", Offset = "0x353F810", VA = "0x183540A10", Slot = "6")]
	protected override HashSet<T>.Enumerator JANBGIPBIID(HashSet<T> KLEAHJOOHFN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class HHCCMCILOOI<T> : global::LEDHFHPIHAB<T, global::CKJPIKONOGC<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x35E85B0", Offset = "0x35E73B0", VA = "0x1835E85B0", Slot = "8")]
	protected override void NGPIMMKGFMI(ref global::CKJPIKONOGC<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x35E84D0", Offset = "0x35E72D0", VA = "0x1835E84D0", Slot = "9")]
	protected override ReadOnlyCollection<T> ALCOILIHPJM(ref global::CKJPIKONOGC<T> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x35E8560", Offset = "0x35E7360", VA = "0x1835E8560", Slot = "7")]
	protected override global::CKJPIKONOGC<T> FBNMOHOMNBD()
	{
		return default(global::CKJPIKONOGC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class OIEMLJNPKJK<T> : global::LEDHFHPIHAB<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3540A60", Offset = "0x353F860", VA = "0x183540A60", Slot = "8")]
	protected override void NGPIMMKGFMI(ref List<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override List<T> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override IList<T> ALCOILIHPJM(ref List<T> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class ECJGNBPCCCO<T> : global::LEDHFHPIHAB<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3540A60", Offset = "0x353F860", VA = "0x183540A60", Slot = "8")]
	protected override void NGPIMMKGFMI(ref List<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override List<T> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override ICollection<T> ALCOILIHPJM(ref List<T> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HLLJGMJMDNF<T> : global::LEDHFHPIHAB<T, global::CKJPIKONOGC<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x35E85B0", Offset = "0x35E73B0", VA = "0x1835E85B0", Slot = "8")]
	protected override void NGPIMMKGFMI(ref global::CKJPIKONOGC<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB10", Offset = "0x3A8B910", VA = "0x183A8CB10", Slot = "7")]
	protected override global::CKJPIKONOGC<T> FBNMOHOMNBD()
	{
		return default(global::CKJPIKONOGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CAF0", Offset = "0x3A8B8F0", VA = "0x183A8CAF0", Slot = "9")]
	protected override IEnumerable<T> ALCOILIHPJM(ref global::CKJPIKONOGC<T> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class JPPFKMJIPAF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class LPFOPMAGKMH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class BMCGNHJLDCI<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class MCGEMLGCKDP : global::EAILOOFMBAA<IEnumerable>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::EAILOOFMBAA<IEnumerable> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x429B1E0", Offset = "0x4299FE0", VA = "0x18429B1E0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, IEnumerable PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x429B3D0", Offset = "0x429A1D0", VA = "0x18429B3D0", Slot = "5")]
	public IEnumerable PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public MCGEMLGCKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class BLJLDHJAHBN : global::EAILOOFMBAA<ICollection>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::EAILOOFMBAA<ICollection> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x385AE00", Offset = "0x3859C00", VA = "0x18385AE00", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ICollection PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x385B0A0", Offset = "0x3859EA0", VA = "0x18385B0A0", Slot = "5")]
	public ICollection PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BLJLDHJAHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class BEFFDDPFBCG : global::EAILOOFMBAA<IList>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::EAILOOFMBAA<IList> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x385A1F0", Offset = "0x3858FF0", VA = "0x18385A1F0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, IList PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x385A490", Offset = "0x3859290", VA = "0x18385A490", Slot = "5")]
	public IList PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BEFFDDPFBCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JCOICFDJPAE<T> : global::LEDHFHPIHAB<T, global::CKJPIKONOGC<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x431EAB0", Offset = "0x431D8B0", VA = "0x18431EAB0", Slot = "8")]
	protected override void NGPIMMKGFMI(ref global::CKJPIKONOGC<T> JOKLCLMKOJG, int IMDCPBGFCMD, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB10", Offset = "0x3A8B910", VA = "0x183A8CB10", Slot = "7")]
	protected override global::CKJPIKONOGC<T> FBNMOHOMNBD()
	{
		return default(global::CKJPIKONOGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x431EA40", Offset = "0x431D840", VA = "0x18431EA40", Slot = "9")]
	protected override IReadOnlyList<T> ALCOILIHPJM(ref global::CKJPIKONOGC<T> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x26039F0", Offset = "0x26027F0", VA = "0x1826039F0")]
	public JCOICFDJPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class MCHPKAMNILG
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x429B5B0", Offset = "0x429A3B0", VA = "0x18429B5B0")]
	public static DateTime MFLJMNMICHG(DateTime PKLBMMAOPIP)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class DDBOACKBGGG : global::EAILOOFMBAA<DateTime>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::EAILOOFMBAA<DateTime> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3860FE0", Offset = "0x385FDE0", VA = "0x183860FE0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, DateTime PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3861430", Offset = "0x3860230", VA = "0x183861430", Slot = "5")]
	public DateTime PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public DDBOACKBGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class BMDNONEPOCB : global::EAILOOFMBAA<DateTimeOffset>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::EAILOOFMBAA<DateTimeOffset> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x385B2F0", Offset = "0x385A0F0", VA = "0x18385B2F0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, DateTimeOffset PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x385B6C0", Offset = "0x385A4C0", VA = "0x18385B6C0", Slot = "5")]
	public DateTimeOffset PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BMDNONEPOCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class FAAKNEEMJBG : global::EAILOOFMBAA<TimeSpan>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::EAILOOFMBAA<TimeSpan> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] NJHKKJLGPAM;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x386B110", Offset = "0x3869F10", VA = "0x18386B110", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, TimeSpan PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x386B3D0", Offset = "0x386A1D0", VA = "0x18386B3D0", Slot = "5")]
	public TimeSpan PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public FAAKNEEMJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class DKODEIBMDCO<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EAILOOFMBAA<TDictionary>, POOHDCJJHAO where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x38ED290", Offset = "0x38EC090", VA = "0x1838ED290", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, TDictionary PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x38EDE60", Offset = "0x38ECC60", VA = "0x1838EDE60", Slot = "5")]
	public TDictionary PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JANBGIPBIID(TDictionary KLEAHJOOHFN);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FBNMOHOMNBD();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NGPIMMKGFMI(ref TIntermediate JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ALCOILIHPJM(ref TIntermediate BKBJAEEPGDG);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
	protected DKODEIBMDCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class BBBILHEDOLM<TKey, TValue, TIntermediate, TDictionary> : global::DKODEIBMDCO<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE790", Offset = "0x2FBD590", VA = "0x182FBE790", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JANBGIPBIID(TDictionary KLEAHJOOHFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class PAJCDLOMCDM<TKey, TValue, TDictionary> : global::BBBILHEDOLM<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override TDictionary ALCOILIHPJM(ref TDictionary BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KCJGJIEFLPC<TKey, TValue> : global::DKODEIBMDCO<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBACC0", Offset = "0x3DB9AC0", VA = "0x183DBACC0", Slot = "8")]
	protected override void NGPIMMKGFMI(ref Dictionary<TKey, TValue> JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override Dictionary<TKey, TValue> ALCOILIHPJM(ref Dictionary<TKey, TValue> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAC70", Offset = "0x3DB9A70", VA = "0x183DBAC70", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JANBGIPBIID(Dictionary<TKey, TValue> KLEAHJOOHFN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2608180", Offset = "0x2606F80", VA = "0x182608180")]
	public KCJGJIEFLPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class AGMKNDFCGFE<TKey, TValue, TDictionary> : global::PAJCDLOMCDM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2F69840", Offset = "0x2F68640", VA = "0x182F69840", Slot = "8")]
	protected override void NGPIMMKGFMI(ref TDictionary JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2F69820", Offset = "0x2F68620", VA = "0x182F69820", Slot = "7")]
	protected override TDictionary FBNMOHOMNBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class NHECHCGLKCH<TKey, TValue> : global::BBBILHEDOLM<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2722780", Offset = "0x2721580", VA = "0x182722780", Slot = "8")]
	protected override void NGPIMMKGFMI(ref Dictionary<TKey, TValue> JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override Dictionary<TKey, TValue> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override IDictionary<TKey, TValue> ALCOILIHPJM(ref Dictionary<TKey, TValue> BKBJAEEPGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class JBOHIPKCDJP<TKey, TValue> : global::PAJCDLOMCDM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2722780", Offset = "0x2721580", VA = "0x182722780", Slot = "8")]
	protected override void NGPIMMKGFMI(ref SortedList<TKey, TValue> JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override SortedList<TKey, TValue> FBNMOHOMNBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class NIAOPAGKDBB<TKey, TValue> : global::DKODEIBMDCO<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2722780", Offset = "0x2721580", VA = "0x182722780", Slot = "8")]
	protected override void NGPIMMKGFMI(ref SortedDictionary<TKey, TValue> JOKLCLMKOJG, int IMDCPBGFCMD, TKey IFKOMGEEEMC, TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1696290", Offset = "0x1695090", VA = "0x181696290", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ALCOILIHPJM(ref SortedDictionary<TKey, TValue> BKBJAEEPGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721520", VA = "0x182722720", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> FBNMOHOMNBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x27227C0", Offset = "0x27215C0", VA = "0x1827227C0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JANBGIPBIID(SortedDictionary<TKey, TValue> KLEAHJOOHFN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class JEHPIBDCNFM<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class BDNJHDAGAIJ : global::EAILOOFMBAA<IDictionary>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::EAILOOFMBAA<IDictionary> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3859AF0", Offset = "0x38588F0", VA = "0x183859AF0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, IDictionary PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x3859E70", Offset = "0x3858C70", VA = "0x183859E70", Slot = "5")]
	public IDictionary PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BDNJHDAGAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class GAINMCBJDJH : global::EAILOOFMBAA<object>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void NGGEAMHHGFI(object GFBNKNKECHO, ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::DMMDPLBGKDA<KeyValuePair<object, NGGEAMHHGFI>> KKMEEIKIAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly JLIBPADHAKH[] GCNILAGLDIE;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x35EFD50", Offset = "0x35EEB50", VA = "0x1835EFD50")]
	public GAINMCBJDJH(params JLIBPADHAKH[] GCNILAGLDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x35EF250", Offset = "0x35EE050", VA = "0x1835EF250", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x35EFC50", Offset = "0x35EEA50", VA = "0x1835EFC50", Slot = "5")]
	public object PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class HNMLDKBOHLA
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x35FE280", Offset = "0x35FD080", VA = "0x1835FE280")]
	public static object NGKAJHKJLMB(Type FEGCMBEFABH, out bool BJAJAAGILPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x35FDAA0", Offset = "0x35FC8A0", VA = "0x1835FDAA0")]
	public static object FDJONGAIKMJ(Type FEGCMBEFABH, out bool BJAJAAGILPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class JACBMOHIELC<T> : global::EAILOOFMBAA<T>, POOHDCJJHAO, global::DINKDOIEAEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class EEMLAICENKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public EEMLAICENKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x383DCF0", Offset = "0x383CAF0", VA = "0x18383DCF0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class INKEOHIJEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::ACJEJABPPJJ<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public INKEOHIJEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3847DB0", Offset = "0x3846BB0", VA = "0x183847DB0")]
		internal void <.cctor>b__1(ref GPKCBNBKGKM writer, T value, JLIBPADHAKH _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class IBBECDADMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::MMBCJADJOPN<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public IBBECDADMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x383E540", Offset = "0x383D340", VA = "0x18383E540")]
		internal T <.cctor>b__2(ref CHIKEMHDNHC reader, JLIBPADHAKH _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::HJJONMLFBDC<T> LPOJFLEJHLI;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> LDNPPFKLNIC;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::ACJEJABPPJJ<T> AILKBBFLADF;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::MMBCJADJOPN<T> GPIOJDEBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool ONCIOLEGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::ACJEJABPPJJ<T> MADEJOKJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::MMBCJADJOPN<T> LIAKBOLJMPP;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x38520B0", Offset = "0x3850EB0", VA = "0x1838520B0")]
	static JACBMOHIELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3853DA0", Offset = "0x3852BA0", VA = "0x183853DA0")]
	public JACBMOHIELC(bool ONCIOLEGOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x384A750", Offset = "0x3849550", VA = "0x18384A750", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x384C060", Offset = "0x384AE60", VA = "0x18384C060", Slot = "5")]
	public T PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x384ACE0", Offset = "0x3849AE0", VA = "0x18384ACE0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, T PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3849A70", Offset = "0x3848870", VA = "0x183849A70", Slot = "7")]
	public T CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class EFGPFKDHIIF<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class JPLEJPMBDKK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class NAAFCLGJHDG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class MPGIHAFCHNE<T> : global::EAILOOFMBAA<T?>, POOHDCJJHAO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x39321D0", Offset = "0x3930FD0", VA = "0x1839321D0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, T? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3932410", Offset = "0x3931210", VA = "0x183932410", Slot = "5")]
	public T? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
	public MPGIHAFCHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class PNGGBHBGNCH<T> : global::EAILOOFMBAA<T?>, POOHDCJJHAO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::EAILOOFMBAA<T> ILPABIDBONP;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2727290", Offset = "0x2726090", VA = "0x182727290")]
	public PNGGBHBGNCH(global::EAILOOFMBAA<T> ILPABIDBONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3543F50", Offset = "0x3542D50", VA = "0x183543F50", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, T? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3544880", Offset = "0x3543680", VA = "0x183544880", Slot = "5")]
	public T? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KLAGKPHBJIN : global::EAILOOFMBAA<sbyte>, POOHDCJJHAO, global::DINKDOIEAEB<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly KLAGKPHBJIN OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4297C00", Offset = "0x4296A00", VA = "0x184297C00", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, sbyte PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4297C60", Offset = "0x4296A60", VA = "0x184297C60", Slot = "5")]
	public sbyte PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4297C20", Offset = "0x4296A20", VA = "0x184297C20", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, sbyte PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4297B90", Offset = "0x4296990", VA = "0x184297B90", Slot = "7")]
	public sbyte CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KLAGKPHBJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class JGJKODKBMOE : global::EAILOOFMBAA<sbyte?>, POOHDCJJHAO, global::DINKDOIEAEB<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly JGJKODKBMOE OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4294980", Offset = "0x4293780", VA = "0x184294980", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, sbyte? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4294A70", Offset = "0x4293870", VA = "0x184294A70", Slot = "5")]
	public sbyte? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x42949F0", Offset = "0x42937F0", VA = "0x1842949F0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, sbyte? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x42948D0", Offset = "0x42936D0", VA = "0x1842948D0", Slot = "7")]
	public sbyte? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public JGJKODKBMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class EFMLFGLDFCN : global::EAILOOFMBAA<sbyte[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly EFMLFGLDFCN OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x3868900", Offset = "0x3867700", VA = "0x183868900", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, sbyte[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x38689C0", Offset = "0x38677C0", VA = "0x1838689C0", Slot = "5")]
	public sbyte[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public EFMLFGLDFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class EKNBFJFFJFG : global::EAILOOFMBAA<short>, POOHDCJJHAO, global::DINKDOIEAEB<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly EKNBFJFFJFG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3869F90", Offset = "0x3868D90", VA = "0x183869F90", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, short PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3869FF0", Offset = "0x3868DF0", VA = "0x183869FF0", Slot = "5")]
	public short PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3869FB0", Offset = "0x3868DB0", VA = "0x183869FB0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, short PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3869EF0", Offset = "0x3868CF0", VA = "0x183869EF0", Slot = "7")]
	public short CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public EKNBFJFFJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class IOKCEHMEBHH : global::EAILOOFMBAA<short?>, POOHDCJJHAO, global::DINKDOIEAEB<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly IOKCEHMEBHH OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4293CD0", Offset = "0x4292AD0", VA = "0x184293CD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, short? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4293DC0", Offset = "0x4292BC0", VA = "0x184293DC0", Slot = "5")]
	public short? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4293D40", Offset = "0x4292B40", VA = "0x184293D40", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, short? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4293C30", Offset = "0x4292A30", VA = "0x184293C30", Slot = "7")]
	public short? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public IOKCEHMEBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class GJGAKBGKDPI : global::EAILOOFMBAA<short[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly GJGAKBGKDPI OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x35F9FF0", Offset = "0x35F8DF0", VA = "0x1835F9FF0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, short[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x35FA190", Offset = "0x35F8F90", VA = "0x1835FA190", Slot = "5")]
	public short[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public GJGAKBGKDPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class FMHJICCEFLP : global::EAILOOFMBAA<int>, POOHDCJJHAO, global::DINKDOIEAEB<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly FMHJICCEFLP OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x35EE990", Offset = "0x35ED790", VA = "0x1835EE990", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, int PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x35EEA80", Offset = "0x35ED880", VA = "0x1835EEA80", Slot = "5")]
	public int PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x35EE9C0", Offset = "0x35ED7C0", VA = "0x1835EE9C0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, int PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x35EE920", Offset = "0x35ED720", VA = "0x1835EE920", Slot = "7")]
	public int CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public FMHJICCEFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class HEKKEOEMFCJ : global::EAILOOFMBAA<int?>, POOHDCJJHAO, global::DINKDOIEAEB<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly HEKKEOEMFCJ OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x35FBD80", Offset = "0x35FAB80", VA = "0x1835FBD80", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, int? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x35FBF00", Offset = "0x35FAD00", VA = "0x1835FBF00", Slot = "5")]
	public int? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x35FBE00", Offset = "0x35FAC00", VA = "0x1835FBE00", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, int? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x35FBCE0", Offset = "0x35FAAE0", VA = "0x1835FBCE0", Slot = "7")]
	public int? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HEKKEOEMFCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class FCNIJANMBAP : global::EAILOOFMBAA<int[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FCNIJANMBAP OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x386BDA0", Offset = "0x386ABA0", VA = "0x18386BDA0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, int[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x386BE60", Offset = "0x386AC60", VA = "0x18386BE60", Slot = "5")]
	public int[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public FCNIJANMBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class NFGLDMKCNFN : global::EAILOOFMBAA<long>, POOHDCJJHAO, global::DINKDOIEAEB<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly NFGLDMKCNFN OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x429C690", Offset = "0x429B490", VA = "0x18429C690", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, long PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x429C6F0", Offset = "0x429B4F0", VA = "0x18429C6F0", Slot = "5")]
	public long PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x429C6B0", Offset = "0x429B4B0", VA = "0x18429C6B0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, long PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x429C620", Offset = "0x429B420", VA = "0x18429C620", Slot = "7")]
	public long CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public NFGLDMKCNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class DIPDBGFKLPE : global::EAILOOFMBAA<long?>, POOHDCJJHAO, global::DINKDOIEAEB<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly DIPDBGFKLPE OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x3864730", Offset = "0x3863530", VA = "0x183864730", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, long? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3864820", Offset = "0x3863620", VA = "0x183864820", Slot = "5")]
	public long? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x38647A0", Offset = "0x38635A0", VA = "0x1838647A0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, long? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3864670", Offset = "0x3863470", VA = "0x183864670", Slot = "7")]
	public long? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public DIPDBGFKLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class IKOBNMIABCF : global::EAILOOFMBAA<long[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly IKOBNMIABCF OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4293770", Offset = "0x4292570", VA = "0x184293770", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, long[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4293830", Offset = "0x4292630", VA = "0x184293830", Slot = "5")]
	public long[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public IKOBNMIABCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class HAIEJIJPILN : global::EAILOOFMBAA<byte>, POOHDCJJHAO, global::DINKDOIEAEB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly HAIEJIJPILN OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x35FB740", Offset = "0x35FA540", VA = "0x1835FB740", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, byte PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x35FB840", Offset = "0x35FA640", VA = "0x1835FB840", Slot = "5")]
	public byte PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x35FB780", Offset = "0x35FA580", VA = "0x1835FB780", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, byte PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x35FB6D0", Offset = "0x35FA4D0", VA = "0x1835FB6D0", Slot = "7")]
	public byte CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HAIEJIJPILN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class JPJABPDCMOA : global::EAILOOFMBAA<byte?>, POOHDCJJHAO, global::DINKDOIEAEB<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly JPJABPDCMOA OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4297320", Offset = "0x4296120", VA = "0x184297320", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, byte? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4297410", Offset = "0x4296210", VA = "0x184297410", Slot = "5")]
	public byte? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4297390", Offset = "0x4296190", VA = "0x184297390", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, byte? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x4297270", Offset = "0x4296070", VA = "0x184297270", Slot = "7")]
	public byte? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public JPJABPDCMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MLFGJFLKIAL : global::EAILOOFMBAA<ushort>, POOHDCJJHAO, global::DINKDOIEAEB<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MLFGJFLKIAL OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x429C060", Offset = "0x429AE60", VA = "0x18429C060", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ushort PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x429C0C0", Offset = "0x429AEC0", VA = "0x18429C0C0", Slot = "5")]
	public ushort PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x429C080", Offset = "0x429AE80", VA = "0x18429C080", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, ushort PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x429BFF0", Offset = "0x429ADF0", VA = "0x18429BFF0", Slot = "7")]
	public ushort CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public MLFGJFLKIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class CNFELOHGPPG : global::EAILOOFMBAA<ushort?>, POOHDCJJHAO, global::DINKDOIEAEB<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly CNFELOHGPPG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3860BF0", Offset = "0x385F9F0", VA = "0x183860BF0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ushort? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3860CE0", Offset = "0x385FAE0", VA = "0x183860CE0", Slot = "5")]
	public ushort? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3860C60", Offset = "0x385FA60", VA = "0x183860C60", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, ushort? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3860B20", Offset = "0x385F920", VA = "0x183860B20", Slot = "7")]
	public ushort? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public CNFELOHGPPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class HELKFDJIGHG : global::EAILOOFMBAA<ushort[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly HELKFDJIGHG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x35FBFD0", Offset = "0x35FADD0", VA = "0x1835FBFD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ushort[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x35FC170", Offset = "0x35FAF70", VA = "0x1835FC170", Slot = "5")]
	public ushort[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HELKFDJIGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class JNPCNIOCDCG : global::EAILOOFMBAA<uint>, POOHDCJJHAO, global::DINKDOIEAEB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly JNPCNIOCDCG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x42971B0", Offset = "0x4295FB0", VA = "0x1842971B0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, uint PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4297200", Offset = "0x4296000", VA = "0x184297200", Slot = "5")]
	public uint PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x42971C0", Offset = "0x4295FC0", VA = "0x1842971C0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, uint PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4297140", Offset = "0x4295F40", VA = "0x184297140", Slot = "7")]
	public uint CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public JNPCNIOCDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class MFHCKFAHDHG : global::EAILOOFMBAA<uint?>, POOHDCJJHAO, global::DINKDOIEAEB<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly MFHCKFAHDHG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x429B6F0", Offset = "0x429A4F0", VA = "0x18429B6F0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, uint? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x429B7E0", Offset = "0x429A5E0", VA = "0x18429B7E0", Slot = "5")]
	public uint? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x429B760", Offset = "0x429A560", VA = "0x18429B760", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, uint? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x429B650", Offset = "0x429A450", VA = "0x18429B650", Slot = "7")]
	public uint? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public MFHCKFAHDHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class IODGJCHJGEG : global::EAILOOFMBAA<uint[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly IODGJCHJGEG OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x42939D0", Offset = "0x42927D0", VA = "0x1842939D0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, uint[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x4293A90", Offset = "0x4292890", VA = "0x184293A90", Slot = "5")]
	public uint[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public IODGJCHJGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class EKKJHMNFCHK : global::EAILOOFMBAA<ulong>, POOHDCJJHAO, global::DINKDOIEAEB<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly EKKJHMNFCHK OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x3869E20", Offset = "0x3868C20", VA = "0x183869E20", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ulong PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3869E80", Offset = "0x3868C80", VA = "0x183869E80", Slot = "5")]
	public ulong PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3869E40", Offset = "0x3868C40", VA = "0x183869E40", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, ulong PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3869DB0", Offset = "0x3868BB0", VA = "0x183869DB0", Slot = "7")]
	public ulong CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public EKKJHMNFCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class GIOGAAPEDAI : global::EAILOOFMBAA<ulong?>, POOHDCJJHAO, global::DINKDOIEAEB<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly GIOGAAPEDAI OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x35F9D80", Offset = "0x35F8B80", VA = "0x1835F9D80", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ulong? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x35F9F00", Offset = "0x35F8D00", VA = "0x1835F9F00", Slot = "5")]
	public ulong? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x35F9E00", Offset = "0x35F8C00", VA = "0x1835F9E00", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, ulong? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x35F9CC0", Offset = "0x35F8AC0", VA = "0x1835F9CC0", Slot = "7")]
	public ulong? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public GIOGAAPEDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class IBKLFJDJMHM : global::EAILOOFMBAA<ulong[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly IBKLFJDJMHM OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4293200", Offset = "0x4292000", VA = "0x184293200", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ulong[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x42932C0", Offset = "0x42920C0", VA = "0x1842932C0", Slot = "5")]
	public ulong[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public IBKLFJDJMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class EJGGMCDHEDI : global::EAILOOFMBAA<float>, POOHDCJJHAO, global::DINKDOIEAEB<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly EJGGMCDHEDI OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3869CF0", Offset = "0x3868AF0", VA = "0x183869CF0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, float PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3869D40", Offset = "0x3868B40", VA = "0x183869D40", Slot = "5")]
	public float PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3869D00", Offset = "0x3868B00", VA = "0x183869D00", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, float PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3869C50", Offset = "0x3868A50", VA = "0x183869C50", Slot = "7")]
	public float CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public EJGGMCDHEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class KKGJPHHHMCA : global::EAILOOFMBAA<float?>, POOHDCJJHAO, global::DINKDOIEAEB<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly KKGJPHHHMCA OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x42979D0", Offset = "0x42967D0", VA = "0x1842979D0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, float? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4297AC0", Offset = "0x42968C0", VA = "0x184297AC0", Slot = "5")]
	public float? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4297A40", Offset = "0x4296840", VA = "0x184297A40", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, float? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4297930", Offset = "0x4296730", VA = "0x184297930", Slot = "7")]
	public float? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KKGJPHHHMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class BHOEFMHJINC : global::EAILOOFMBAA<float[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BHOEFMHJINC OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x385AAE0", Offset = "0x38598E0", VA = "0x18385AAE0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, float[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x385ABA0", Offset = "0x38599A0", VA = "0x18385ABA0", Slot = "5")]
	public float[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public BHOEFMHJINC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class AEHAJEBBLGK : global::EAILOOFMBAA<double>, POOHDCJJHAO, global::DINKDOIEAEB<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly AEHAJEBBLGK OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x3859940", Offset = "0x3858740", VA = "0x183859940", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, double PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x3859990", Offset = "0x3858790", VA = "0x183859990", Slot = "5")]
	public double PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x3859950", Offset = "0x3858750", VA = "0x183859950", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, double PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x38598A0", Offset = "0x38586A0", VA = "0x1838598A0", Slot = "7")]
	public double CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public AEHAJEBBLGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FFPKIKIAJEI : global::EAILOOFMBAA<double?>, POOHDCJJHAO, global::DINKDOIEAEB<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly FFPKIKIAJEI OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x386C8A0", Offset = "0x386B6A0", VA = "0x18386C8A0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, double? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x386C990", Offset = "0x386B790", VA = "0x18386C990", Slot = "5")]
	public double? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x386C910", Offset = "0x386B710", VA = "0x18386C910", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, double? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x386C790", Offset = "0x386B590", VA = "0x18386C790", Slot = "7")]
	public double? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public FFPKIKIAJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NPMJCKCIKBD : global::EAILOOFMBAA<double[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly NPMJCKCIKBD OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x429DE40", Offset = "0x429CC40", VA = "0x18429DE40", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, double[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x429DF00", Offset = "0x429CD00", VA = "0x18429DF00", Slot = "5")]
	public double[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public NPMJCKCIKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class OENJLBOLFPO : global::EAILOOFMBAA<bool>, POOHDCJJHAO, global::DINKDOIEAEB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly OENJLBOLFPO OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x429E250", Offset = "0x429D050", VA = "0x18429E250", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, bool PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x429E2B0", Offset = "0x429D0B0", VA = "0x18429E2B0", Slot = "5")]
	public bool PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x429E270", Offset = "0x429D070", VA = "0x18429E270", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, bool PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x429E1E0", Offset = "0x429CFE0", VA = "0x18429E1E0", Slot = "7")]
	public bool CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public OENJLBOLFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class PNMPMCLLJHK : global::EAILOOFMBAA<bool?>, POOHDCJJHAO, global::DINKDOIEAEB<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly PNMPMCLLJHK OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x429EB80", Offset = "0x429D980", VA = "0x18429EB80", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, bool? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x429EC70", Offset = "0x429DA70", VA = "0x18429EC70", Slot = "5")]
	public bool? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x429EBF0", Offset = "0x429D9F0", VA = "0x18429EBF0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, bool? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x429EAD0", Offset = "0x429D8D0", VA = "0x18429EAD0", Slot = "7")]
	public bool? CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNMPMCLLJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class KFLEHBGLHNP : global::EAILOOFMBAA<bool[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly KFLEHBGLHNP OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4297590", Offset = "0x4296390", VA = "0x184297590", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, bool[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4297660", Offset = "0x4296460", VA = "0x184297660", Slot = "5")]
	public bool[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KFLEHBGLHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class DLFIKPNMGBK : global::EAILOOFMBAA<object>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::EAILOOFMBAA<object> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> CHAIPGDNLHD;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3865220", Offset = "0x3864020", VA = "0x183865220", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, object PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3865BD0", Offset = "0x38649D0", VA = "0x183865BD0", Slot = "5")]
	public object PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public DLFIKPNMGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HLGJKKBDCBK : global::EAILOOFMBAA<byte[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::EAILOOFMBAA<byte[]> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x35FD5B0", Offset = "0x35FC3B0", VA = "0x1835FD5B0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, byte[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x35FD640", Offset = "0x35FC440", VA = "0x1835FD640", Slot = "5")]
	public byte[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HLGJKKBDCBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class ICKDGLHLNEO : global::EAILOOFMBAA<ArraySegment<byte>>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::EAILOOFMBAA<ArraySegment<byte>> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4293460", Offset = "0x4292260", VA = "0x184293460", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, ArraySegment<byte> PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x4293500", Offset = "0x4292300", VA = "0x184293500", Slot = "5")]
	public ArraySegment<byte> PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public ICKDGLHLNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MKDEFBAGOOJ : global::EAILOOFMBAA<string>, POOHDCJJHAO, global::DINKDOIEAEB<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::EAILOOFMBAA<string> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x429BC50", Offset = "0x429AA50", VA = "0x18429BC50", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, string PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x429BC40", Offset = "0x429AA40", VA = "0x18429BC40", Slot = "5")]
	public string PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x429BC50", Offset = "0x429AA50", VA = "0x18429BC50", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, string PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x429BC40", Offset = "0x429AA40", VA = "0x18429BC40", Slot = "7")]
	public string CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public MKDEFBAGOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class GDIAKPOJEJL : global::EAILOOFMBAA<string[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly GDIAKPOJEJL OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x35F8200", Offset = "0x35F7000", VA = "0x1835F8200", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, string[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x35F8380", Offset = "0x35F7180", VA = "0x1835F8380", Slot = "5")]
	public string[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public GDIAKPOJEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EEEBHGPFMKE : global::EAILOOFMBAA<char>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EEEBHGPFMKE OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x38687F0", Offset = "0x38675F0", VA = "0x1838687F0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, char PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3868870", Offset = "0x3867670", VA = "0x183868870", Slot = "5")]
	public char PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public EEEBHGPFMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class JJKKADNKPMF : global::EAILOOFMBAA<char?>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly JJKKADNKPMF OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4296450", Offset = "0x4295250", VA = "0x184296450", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, char? PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4296520", Offset = "0x4295320", VA = "0x184296520", Slot = "5")]
	public char? PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public JJKKADNKPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class IPOLBCIHAMM : global::EAILOOFMBAA<char[]>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly IPOLBCIHAMM OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4294400", Offset = "0x4293200", VA = "0x184294400", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, char[] PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4294580", Offset = "0x4293380", VA = "0x184294580", Slot = "5")]
	public char[] PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public IPOLBCIHAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class NEANHCCEBKG : global::EAILOOFMBAA<Guid>, POOHDCJJHAO, global::DINKDOIEAEB<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::EAILOOFMBAA<Guid> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x429C400", Offset = "0x429B200", VA = "0x18429C400", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Guid PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x429C3A0", Offset = "0x429B1A0", VA = "0x18429C3A0", Slot = "5")]
	public Guid PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x429C4E0", Offset = "0x429B2E0", VA = "0x18429C4E0", Slot = "6")]
	public void OIGIACCPCCL(ref GPKCBNBKGKM CENMEHNCJLA, Guid PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x429C3A0", Offset = "0x429B1A0", VA = "0x18429C3A0", Slot = "7")]
	public Guid CIBCFBDBMKC(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public NEANHCCEBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class DHNFOIJAPKP : global::EAILOOFMBAA<decimal>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::EAILOOFMBAA<decimal> OJCIGOFJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool IBDBMMDFELP;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x783140", Offset = "0x781F40", VA = "0x180783140")]
	public DHNFOIJAPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x783110", Offset = "0x781F10", VA = "0x180783110")]
	public DHNFOIJAPKP(bool IBDBMMDFELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x3864320", Offset = "0x3863120", VA = "0x183864320", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, decimal PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x3864460", Offset = "0x3863260", VA = "0x183864460", Slot = "5")]
	public decimal PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class HNDCNEMJLOD : global::EAILOOFMBAA<Uri>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::EAILOOFMBAA<Uri> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x35FD7D0", Offset = "0x35FC5D0", VA = "0x1835FD7D0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Uri PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x35FD880", Offset = "0x35FC680", VA = "0x1835FD880", Slot = "5")]
	public Uri PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public HNDCNEMJLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class CHGKJOHDDKJ : global::EAILOOFMBAA<Version>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::EAILOOFMBAA<Version> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x385D3D0", Offset = "0x385C1D0", VA = "0x18385D3D0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Version PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x385D480", Offset = "0x385C280", VA = "0x18385D480", Slot = "5")]
	public Version PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public CHGKJOHDDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class MNNFCGEKEEJ<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class KJNLJHKLHCH : global::EAILOOFMBAA<StringBuilder>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::EAILOOFMBAA<StringBuilder> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4297800", Offset = "0x4296600", VA = "0x184297800", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, StringBuilder PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4297850", Offset = "0x4296650", VA = "0x184297850", Slot = "5")]
	public StringBuilder PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public KJNLJHKLHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class ELEACGDLNIH : global::EAILOOFMBAA<BitArray>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::EAILOOFMBAA<BitArray> OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x386A0B0", Offset = "0x3868EB0", VA = "0x18386A0B0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, BitArray PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x386A140", Offset = "0x3868F40", VA = "0x18386A140", Slot = "5")]
	public BitArray PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public ELEACGDLNIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class FKHGDLFBPOM : global::EAILOOFMBAA<Type>, POOHDCJJHAO
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly FKHGDLFBPOM OJCIGOFJNDO;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex KGLHPEOCMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool GDHMOIPLPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool MOEJEEINCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool MGGLJJJAHJN;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x35ECE80", Offset = "0x35EBC80", VA = "0x1835ECE80")]
	public FKHGDLFBPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x35ECEA0", Offset = "0x35EBCA0", VA = "0x1835ECEA0")]
	public FKHGDLFBPOM(bool GDHMOIPLPLM, bool MOEJEEINCPO, bool MGGLJJJAHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x35ECBD0", Offset = "0x35EB9D0", VA = "0x1835ECBD0", Slot = "4")]
	public void OABGKNCLGBC(ref GPKCBNBKGKM CENMEHNCJLA, Type PEPOHKCFAOG, JLIBPADHAKH JCGLBKJKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x35ECCC0", Offset = "0x35EBAC0", VA = "0x1835ECCC0", Slot = "5")]
	public Type PEHBIENJBGL(ref CHIKEMHDNHC NGOLKADBHEG, JLIBPADHAKH JCGLBKJKIPF)
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
