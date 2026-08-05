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
public class HEICIEPPEBI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x560480", Offset = "0x55EA80", VA = "0x180560480")]
	public HEICIEPPEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NNMFDPLENEI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x560480", Offset = "0x55EA80", VA = "0x180560480")]
	public NNMFDPLENEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FBHHBNPELEA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x560480", Offset = "0x55EA80", VA = "0x180560480")]
	public FBHHBNPELEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class IFELBPHGLHN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x560480", Offset = "0x55EA80", VA = "0x180560480")]
	public IFELBPHGLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DNFKNMMCOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28944A0", Offset = "0x2892AA0", VA = "0x1828944A0")]
	public static bool JLMMOHJDJMD(this TypeInfo ONIHNDBDHGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class AKMAOHAMOHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type GNIKAEDNMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] NMHECDFAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3F0", Offset = "0x6A99F0", VA = "0x1806AB3F0")]
	public AKMAOHAMOHH(Type LHFKJCCMEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class KEDJKDCMBGF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FLDPJJAEEPN<T>(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T FDIOKMHEKJP<T>(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD BGBEOCLNGLJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKODBDPOJMK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CHGOEAEDIKB<T> : MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NMJJJPGKCNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FPCGCAFHCPC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CGJGPHFJPHB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x254AEF0", Offset = "0x25494F0", VA = "0x18254AEF0")]
	public static global::CHGOEAEDIKB<T> GJNNJHOLLCI<T>(this IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2890520", Offset = "0x288EB20", VA = "0x182890520")]
	public static object LJHCALIFJOI(this IHNIPBDLGGD BGBEOCLNGLJ, Type ONIHNDBDHGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JCAIOMBJAKG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x347BC40", Offset = "0x347A240", VA = "0x18347BC40")]
	public JCAIOMBJAKG(string EPAKPJCIEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IOOLDPGGJIO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class AFKPCGELLNL
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] HKAAJCFANGC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LDICALKEHKH;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x346AB10", Offset = "0x3469110", VA = "0x18346AB10")]
		public static byte[] DEKOJDJMHGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x346AB90", Offset = "0x3469190", VA = "0x18346AB90")]
		public static char[] PCNLDJCJIGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> AGLLMNMMDJC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] FMDEBCPADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] KFCJKMJDFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int KJBKACPPODJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool NOEBKNCAMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x34794A0", Offset = "0x3477AA0", VA = "0x1834794A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x347A7B0", Offset = "0x3478DB0", VA = "0x18347A7B0")]
	public IOOLDPGGJIO(byte[] KFCJKMJDFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x347A7C0", Offset = "0x3478DC0", VA = "0x18347A7C0")]
	public IOOLDPGGJIO(byte[] KFCJKMJDFKE, int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3479EE0", Offset = "0x34784E0", VA = "0x183479EE0")]
	private AJAFKPAHHHF LPMPFAOIPKG(string JNHAOKCIHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3477E80", Offset = "0x3476480", VA = "0x183477E80")]
	private AJAFKPAHHHF DEMHAKNOFEJ(string EPAKPJCIEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x288E970", Offset = "0x288CF70", VA = "0x18288E970")]
	public void EDMFEBGBCLN(int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77A190", Offset = "0x778790", VA = "0x18077A190")]
	public byte[] ANLCBLJHBIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D1410", Offset = "0x7CFA10", VA = "0x1807D1410")]
	public int GHHLDEKGCJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3478E60", Offset = "0x3477460", VA = "0x183478E60")]
	public PKLNMNEJKMG IOKHOEJFANM()
	{
		return default(PKLNMNEJKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x347A450", Offset = "0x3478A50", VA = "0x18347A450")]
	public void MGBGCFBJAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3478110", Offset = "0x3476710", VA = "0x183478110")]
	public bool EIDLCOIBNLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3477F60", Offset = "0x3476560", VA = "0x183477F60")]
	public bool DOEALCBHJHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3477CF0", Offset = "0x34762F0", VA = "0x183477CF0")]
	public void BPCEHELAHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34787E0", Offset = "0x3476DE0", VA = "0x1834787E0")]
	public bool GAJAKINPFHD(ref int DHNBJNKGAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x347A610", Offset = "0x3478C10", VA = "0x18347A610")]
	public bool PFLNJCGGCMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3478230", Offset = "0x3476830", VA = "0x183478230")]
	public void EJBGKEHJCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3479D20", Offset = "0x3478320", VA = "0x183479D20")]
	public bool LHNNKMINANN(ref int DHNBJNKGAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3479520", Offset = "0x3477B20", VA = "0x183479520")]
	public bool LEIJCCNDBPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3479400", Offset = "0x3477A00", VA = "0x183479400")]
	public void KHEKFAAAMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3478A40", Offset = "0x3477040", VA = "0x183478A40")]
	public bool HAGAMNNJKIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3478B70", Offset = "0x3477170", VA = "0x183478B70")]
	public void HCJGBJCJCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3479590", Offset = "0x3477B90", VA = "0x183479590")]
	private void LGBIIGGCLFH(out byte[] HMCLMNFAJOL, out int EBHBGKNMNEM, out int NEMMMEBFEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3478FF0", Offset = "0x34775F0", VA = "0x183478FF0")]
	private static int IPCJDLFFADG(char NCGEKBENJBA, char IIFMPDAMAIA, char AHENHIDOBEA, char CGNILIACKIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x347A380", Offset = "0x3478980", VA = "0x18347A380")]
	private static int LPNDBOAHMBD(char KDNDPAEEMPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3477D90", Offset = "0x3476390", VA = "0x183477D90")]
	public ArraySegment<byte> CCHGKEDCHLC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3478DC0", Offset = "0x34773C0", VA = "0x183478DC0")]
	public string INFADKCFFPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3477CC0", Offset = "0x34762C0", VA = "0x183477CC0")]
	public string BANLLOJGIBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3478C10", Offset = "0x3477210", VA = "0x183478C10")]
	public ArraySegment<byte> IAPLLEOEOHH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3477C80", Offset = "0x3476280", VA = "0x183477C80")]
	public ArraySegment<byte> AHIBADFNBNC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34784B0", Offset = "0x3476AB0", VA = "0x1834784B0")]
	public bool FBCOPIEIEPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3478AB0", Offset = "0x34770B0", VA = "0x183478AB0")]
	private static bool HBILFBPOFDI(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34790A0", Offset = "0x34776A0", VA = "0x1834790A0")]
	private void JPHJILHNJGL(PKLNMNEJKMG GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34792D0", Offset = "0x34778D0", VA = "0x1834792D0")]
	public void KDGCILECFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3478710", Offset = "0x3476D10", VA = "0x183478710")]
	private void FPIAKNCHIJD(int GDLAKOPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x347A680", Offset = "0x3478C80", VA = "0x18347A680")]
	public sbyte PJCGOJJOCBK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3478870", Offset = "0x3476E70", VA = "0x183478870")]
	public short GAPLLDKLEID()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34794C0", Offset = "0x3477AC0", VA = "0x1834794C0")]
	public int LEANGICBMPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3478930", Offset = "0x3476F30", VA = "0x183478930")]
	public long GKMKBANOJIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3479270", Offset = "0x3477870", VA = "0x183479270")]
	public byte KCPBODNFLBD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34782D0", Offset = "0x34768D0", VA = "0x1834782D0")]
	public ushort EJJGFBICOJP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34788D0", Offset = "0x3476ED0", VA = "0x1834788D0")]
	public uint GHIGFJHGFLL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x347A590", Offset = "0x3478B90", VA = "0x18347A590")]
	public ulong NCFNCPMJIII()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3477FD0", Offset = "0x34765D0", VA = "0x183477FD0")]
	public float EAHNPLKCOGI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3479DB0", Offset = "0x34783B0", VA = "0x183479DB0")]
	public double LNIAIEFDMPM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34792E0", Offset = "0x34778E0", VA = "0x1834792E0")]
	public ArraySegment<byte> KEOOFOJLDNB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3478330", Offset = "0x3476930", VA = "0x183478330")]
	private static int FAIEDHLKGAO(byte[] KFCJKMJDFKE, int KJBKACPPODJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AJAFKPAHHHF : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference OBAGLBCDACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int NDLALHMPCOO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int KEINCLOKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x136B5B0", Offset = "0x1369BB0", VA = "0x18136B5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JNGOGNMICHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE10", Offset = "0x5F9410", VA = "0x1805FAE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x288B0A0", Offset = "0x28896A0", VA = "0x18288B0A0")]
	public AJAFKPAHHHF(string EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x288AFD0", Offset = "0x28895D0", VA = "0x18288AFD0")]
	public AJAFKPAHHHF(string EPAKPJCIEHE, byte[] KMOEKFNONEL, int KJBKACPPODJ, int NDLALHMPCOO, string JGJAGHOIJEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LDDLGKNEKDC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OAIJHJCAGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void JFGMFCOFBHF(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object NBILPDOGIMN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD BGBEOCLNGLJ);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class ONMKNMPCMBI
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class CCKPKNKGKBP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
				public CCKPKNKGKBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x346B090", Offset = "0x3469690", VA = "0x18346B090")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x346B0D0", Offset = "0x34696D0", VA = "0x18346B0D0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, IHNIPBDLGGD, byte[]> AOGHILMHGFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, IHNIPBDLGGD> JOEKANJLNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly JFGMFCOFBHF CDCPJAFMHGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, IHNIPBDLGGD, ArraySegment<byte>> LKDJCNNOKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, IHNIPBDLGGD, string> GCFNNLMBFDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, IHNIPBDLGGD, object> AFJLOEFBHNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, IHNIPBDLGGD, object> NBKPFGPKIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, IHNIPBDLGGD, object> JBENBAKCJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly NBILPDOGIMN FCLOGFBAABN;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x34808D0", Offset = "0x347EED0", VA = "0x1834808D0")]
			public ONMKNMPCMBI(Type ONIHNDBDHGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1E25F30", Offset = "0x1E24530", VA = "0x181E25F30")]
			private static T PEPLOGDBAKE<T>(DynamicMethod CFBBCIHBFGC)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x34806E0", Offset = "0x347ECE0", VA = "0x1834806E0")]
			private static MethodInfo CGHPKPBAJFA(Type ONIHNDBDHGC, string MONHCMBIJIP, Type[] IGJKFMKMMBC)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, ONMKNMPCMBI> JAGEELDFBNI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::JHPNJCCNEJI<ONMKNMPCMBI> LLGPHAAEJON;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x34805F0", Offset = "0x347EBF0", VA = "0x1834805F0")]
		static OAIJHJCAGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3480570", Offset = "0x347EB70", VA = "0x183480570")]
		private static ONMKNMPCMBI GPHBEMBAHLO(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3480400", Offset = "0x347EA00", VA = "0x183480400")]
		public static void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x34802F0", Offset = "0x347E8F0", VA = "0x1834802F0")]
		public static void DFIGKGIDJJK(Type ONIHNDBDHGC, ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BHACMNMHJJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] HKAAJCFANGC;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x346ADB0", Offset = "0x34693B0", VA = "0x18346ADB0")]
		public static byte[] DEKOJDJMHGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IHNIPBDLGGD GLEMDGOCHLA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BCEKFABBDJE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] MGDAGJONBMI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IHNIPBDLGGD HMACIDIMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x347E9C0", Offset = "0x347CFC0", VA = "0x18347E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x347EAD0", Offset = "0x347D0D0", VA = "0x18347EAD0")]
	public static void NHJIBBCGBND(IHNIPBDLGGD BGBEOCLNGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2646350", Offset = "0x2644950", VA = "0x182646350")]
	public static string OIKBPFLAJDM<T>(T MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26463D0", Offset = "0x26449D0", VA = "0x1826463D0")]
	public static string OIKBPFLAJDM<T>(T MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E21F30", Offset = "0x1E20530", VA = "0x181E21F30")]
	public static T IACEKGNLJIN<T>(string LONLOCHDGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E22100", Offset = "0x1E20700", VA = "0x181E22100")]
	public static T IACEKGNLJIN<T>(string LONLOCHDGLG, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E221D0", Offset = "0x1E207D0", VA = "0x181E221D0")]
	public static T IACEKGNLJIN<T>(byte[] KFCJKMJDFKE, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E21FB0", Offset = "0x1E205B0", VA = "0x181E21FB0")]
	public static T IACEKGNLJIN<T>(byte[] KFCJKMJDFKE, int KJBKACPPODJ, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PKLNMNEJKMG : byte
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
public struct BFLLELOAEDL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NBALBGPFGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] HKAAJCFANGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KJBKACPPODJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IAGLNBBAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D1410", Offset = "0x7CFA10", VA = "0x1807D1410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x288E970", Offset = "0x288CF70", VA = "0x18288E970")]
	public void EDMFEBGBCLN(int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x288DFF0", Offset = "0x288C5F0", VA = "0x18288DFF0")]
	public static byte[] BHGNMLKIJJL(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x288EE90", Offset = "0x288D490", VA = "0x18288EE90")]
	public static byte[] OEGJGAOMNPJ(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x288E890", Offset = "0x288CE90", VA = "0x18288E890")]
	public static byte[] DIOCPAKGNHA(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x288EFB0", Offset = "0x288D5B0", VA = "0x18288EFB0")]
	public static byte[] PJMIOFIMEIG(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xC21510", Offset = "0xC1FB10", VA = "0x180C21510")]
	public BFLLELOAEDL(byte[] PFPPJJFPBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x288E7E0", Offset = "0x288CDE0", VA = "0x18288E7E0")]
	public ArraySegment<byte> DEKOJDJMHGL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x288E690", Offset = "0x288CC90", VA = "0x18288E690")]
	public byte[] DDDJBCEJAGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x288F140", Offset = "0x288D740", VA = "0x18288F140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x288E960", Offset = "0x288CF60", VA = "0x18288E960")]
	public void DKIJAJMBPMB(int HIOEEKOEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x288E5B0", Offset = "0x288CBB0", VA = "0x18288E5B0")]
	public void CNIJIIBKHGD(byte[] NHJFMJONGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x288DFB0", Offset = "0x288C5B0", VA = "0x18288DFB0")]
	public void BCHMBNDGGKP(byte NHJFMJONGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x288EE10", Offset = "0x288D410", VA = "0x18288EE10")]
	public void NCEMMBAADAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x288EF60", Offset = "0x288D560", VA = "0x18288EF60")]
	public void PEIHGKEGFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x288E070", Offset = "0x288C670", VA = "0x18288E070")]
	public void BNPDFBDGPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x288DF60", Offset = "0x288C560", VA = "0x18288DF60")]
	public void AMGGNLPPHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x288ED90", Offset = "0x288D390", VA = "0x18288ED90")]
	public void MNCOMPPPIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x288E560", Offset = "0x288CB60", VA = "0x18288E560")]
	public void CEHHIAKLNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x288E9B0", Offset = "0x288CFB0", VA = "0x18288E9B0")]
	public void FGEKFOJFKAM(string COJCGCCEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x288EAF0", Offset = "0x288D0F0", VA = "0x18288EAF0")]
	public void KACKNIIPIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x288E0C0", Offset = "0x288C6C0", VA = "0x18288E0C0")]
	public void CCANMKDCHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x288EBA0", Offset = "0x288D1A0", VA = "0x18288EBA0")]
	public void LCHGDDBOIEL(bool MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x288E610", Offset = "0x288CC10", VA = "0x18288E610")]
	public void COHDDEPPNIH(float MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x288EA70", Offset = "0x288D070", VA = "0x18288EA70")]
	public void JJPMNDEFDHN(double MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x288EB40", Offset = "0x288D140", VA = "0x18288EB40")]
	public void KCPFAFEIOBI(byte MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x288E980", Offset = "0x288CF80", VA = "0x18288E980")]
	public void FDCIFNHEFDI(ushort MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x288EE60", Offset = "0x288D460", VA = "0x18288EE60")]
	public void NNEBGLPOEPP(uint MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x288EA10", Offset = "0x288D010", VA = "0x18288EA10")]
	public void GNBMBHPKNHE(ulong MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x288F110", Offset = "0x288D710", VA = "0x18288F110")]
	public void PMDAEPOBFNL(sbyte MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x288EDE0", Offset = "0x288D3E0", VA = "0x18288EDE0")]
	public void MPDMFIKLGHJ(short MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x288EB70", Offset = "0x288D170", VA = "0x18288EB70")]
	public void KOMOEGLDKHK(int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x288EA40", Offset = "0x288D040", VA = "0x18288EA40")]
	public void IAFNNDIMDCI(long MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x288E190", Offset = "0x288C790", VA = "0x18288E190")]
	public void CEBNGIOKBBB(string MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GCGOCHGFGOG : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class JLBMNPKDJEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3F98890", Offset = "0x3F96E90", VA = "0x183F98890")]
		static JLBMNPKDJEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private GCGOCHGFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class DNJBEEELAMN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> NGAKGFCMOMH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2894A30", Offset = "0x2893030", VA = "0x182894A30")]
	static DNJBEEELAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x28944D0", Offset = "0x2892AD0", VA = "0x1828944D0")]
	internal static object IEEPEMKCBNI(Type JDLAIFIMIJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LFLILFPPGOL : global::CHGOEAEDIKB<Vector2>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x347EFB0", Offset = "0x347D5B0", VA = "0x18347EFB0")]
	public LFLILFPPGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x347EC60", Offset = "0x347D260", VA = "0x18347EC60", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector2 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x347ED10", Offset = "0x347D310", VA = "0x18347ED10", Slot = "5")]
	public Vector2 IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IFKLADLHEBE : global::CHGOEAEDIKB<Vector3>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3476D90", Offset = "0x3475390", VA = "0x183476D90")]
	public IFKLADLHEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3476970", Offset = "0x3474F70", VA = "0x183476970", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector3 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3476A90", Offset = "0x3475090", VA = "0x183476A90", Slot = "5")]
	public Vector3 IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NNHNGGCLELP : global::CHGOEAEDIKB<Vector4>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA97A0", Offset = "0x4DA7DA0", VA = "0x184DA97A0")]
	public NNHNGGCLELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x347E230", Offset = "0x347C830", VA = "0x18347E230", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector4 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9570", Offset = "0x4DA7B70", VA = "0x184DA9570", Slot = "5")]
	public Vector4 IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PEHEEFOCHFE : global::CHGOEAEDIKB<Quaternion>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE940", Offset = "0x4DACF40", VA = "0x184DAE940")]
	public PEHEEFOCHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x347E230", Offset = "0x347C830", VA = "0x18347E230", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Quaternion MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE710", Offset = "0x4DACD10", VA = "0x184DAE710", Slot = "5")]
	public Quaternion IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KNNDMCAJFJB : global::CHGOEAEDIKB<Color>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x347E6C0", Offset = "0x347CCC0", VA = "0x18347E6C0")]
	public KNNDMCAJFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x347E230", Offset = "0x347C830", VA = "0x18347E230", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Color MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x347E380", Offset = "0x347C980", VA = "0x18347E380", Slot = "5")]
	public Color IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IKNFAKHHMNI : global::CHGOEAEDIKB<Bounds>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3477A50", Offset = "0x3476050", VA = "0x183477A50")]
	public IKNFAKHHMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3477430", Offset = "0x3475A30", VA = "0x183477430", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Bounds MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x34776A0", Offset = "0x3475CA0", VA = "0x1834776A0", Slot = "5")]
	public Bounds IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FKMAABLNDCK : global::CHGOEAEDIKB<Rect>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BHOCKMMPNPJ NHOMHEIGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] GIFKPGNABBF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2898960", Offset = "0x2896F60", VA = "0x182898960")]
	public FKMAABLNDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2898420", Offset = "0x2896A20", VA = "0x182898420", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Rect MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x28986B0", Offset = "0x2896CB0", VA = "0x1828986B0", Slot = "5")]
	public Rect IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IMHPEGMGGPN : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class MPNDEIOOPGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F418A0", Offset = "0x2F3FEA0", VA = "0x182F418A0")]
		static MPNDEIOOPGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private IMHPEGMGGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class BHNKLNPENPK : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class EBHKAHGIEBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9510", Offset = "0x2FD7B10", VA = "0x182FD9510")]
		static EBHKAHGIEBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class OFOHFIPCADD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MBJIBLCBGBL;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A10", Offset = "0x28A2010", VA = "0x1828A3A10")]
		internal static object IEEPEMKCBNI(Type JDLAIFIMIJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private BHNKLNPENPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GNGKBLLGJAL : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class JJCJIBEINFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x31D9350", Offset = "0x31D7950", VA = "0x1831D9350")]
		static JJCJIBEINFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GNGKBLLGJAL NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool HKFIHCBAKDH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MKODBDPOJMK[] GPDBPECMEOL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IHNIPBDLGGD[] JDAGHLFJEIL;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private GNGKBLLGJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x34706A0", Offset = "0x346ECA0", VA = "0x1834706A0")]
	public static void LOCJDHNCFIF(params IHNIPBDLGGD[] JDAGHLFJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3470760", Offset = "0x346ED60", VA = "0x183470760")]
	public static void LOCJDHNCFIF(params MKODBDPOJMK[] GPDBPECMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3470450", Offset = "0x346EA50", VA = "0x183470450")]
	public static void FBDLAIMELGO(MKODBDPOJMK[] GPDBPECMEOL, IHNIPBDLGGD[] JDAGHLFJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FGLFDEADAJP : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class JMDGCCEDPFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CD40", Offset = "0x2C7B340", VA = "0x182C7CD40")]
		static JMDGCCEDPFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private FGLFDEADAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HNGICEJCDIK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IHNIPBDLGGD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly IHNIPBDLGGD HJJBHPOPDFF;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly IHNIPBDLGGD JHOFENNCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IHNIPBDLGGD FCCLGDLEJHK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly IHNIPBDLGGD DPKHBDNBNAJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IHNIPBDLGGD EILHDPBBBLM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IHNIPBDLGGD JEIMMODGJCH;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly IHNIPBDLGGD FFKGIHOAKOL;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IHNIPBDLGGD HLCFBFJBFMJ;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly IHNIPBDLGGD OABHFBOEIOJ;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IHNIPBDLGGD MPCMEPMDBCE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IHNIPBDLGGD IGMABBJNGGD;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JECJGMALLON
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IHNIPBDLGGD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IHNIPBDLGGD ILHIDIDHFIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OPMJHJKNPIB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IHNIPBDLGGD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IHNIPBDLGGD HJJBHPOPDFF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IHNIPBDLGGD JHOFENNCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IHNIPBDLGGD FCCLGDLEJHK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IHNIPBDLGGD DPKHBDNBNAJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IHNIPBDLGGD EILHDPBBBLM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IHNIPBDLGGD JEIMMODGJCH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IHNIPBDLGGD FFKGIHOAKOL;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IHNIPBDLGGD HLCFBFJBFMJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IHNIPBDLGGD OABHFBOEIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IHNIPBDLGGD MPCMEPMDBCE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IHNIPBDLGGD IGMABBJNGGD;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class GLCEHICJEPM
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MBJIBLCBGBL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x346EAB0", Offset = "0x346D0B0", VA = "0x18346EAB0")]
	internal static object IEEPEMKCBNI(Type JDLAIFIMIJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x346EA70", Offset = "0x346D070", VA = "0x18346EA70")]
	private static object APLEAOIJADB(Type NAHHCICAJCE, Type[] BNCLGMLJFAP, params object[] IGJKFMKMMBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class BFCAODKNLKD : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class MAIEFMEDIMK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2699070", Offset = "0x2697670", VA = "0x182699070")]
		static MAIEFMEDIMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x288DE70", Offset = "0x288C470", VA = "0x18288DE70")]
	static BFCAODKNLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private BFCAODKNLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class LLJLLMLFCBJ : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class IGGMMIIMAJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x229CC90", Offset = "0x229B290", VA = "0x18229CC90")]
		static IGGMMIIMAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA56F0", Offset = "0x4DA3CF0", VA = "0x184DA56F0")]
	static LLJLLMLFCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private LLJLLMLFCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CKEAFNJLLPE : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DPGLJNBOHPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x23DD880", Offset = "0x23DBE80", VA = "0x1823DD880")]
		static DPGLJNBOHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2890980", Offset = "0x288EF80", VA = "0x182890980")]
	static CKEAFNJLLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private CKEAFNJLLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class IIDCGIPJBDE : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class GPDINJHHJAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F33410", Offset = "0x2F31A10", VA = "0x182F33410")]
		static GPDINJHHJAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3476FF0", Offset = "0x34755F0", VA = "0x183476FF0")]
	static IIDCGIPJBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private IIDCGIPJBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class LHCFECFNJFM : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class JKGJNOBDLPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x287B380", Offset = "0x2879980", VA = "0x18287B380")]
		static JKGJNOBDLPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x347F2C0", Offset = "0x347D8C0", VA = "0x18347F2C0")]
	static LHCFECFNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private LHCFECFNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class DCIELAKOBLE : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class FHBDKNGHANI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8790", Offset = "0x2CD6D90", VA = "0x182CD8790")]
		static FHBDKNGHANI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly DFDMNMAAHFF KOGJOKEBHLE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2890D80", Offset = "0x288F380", VA = "0x182890D80")]
	static DCIELAKOBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private DCIELAKOBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class OHMLIOFDDFK : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class EOBDIIKICJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x39F3F60", Offset = "0x39F2560", VA = "0x1839F3F60")]
		static EOBDIIKICJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OHMLIOFDDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class EGMKKKGOODM : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class BKGNEPKDPEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x34A59E0", Offset = "0x34A3FE0", VA = "0x1834A59E0")]
		static BKGNEPKDPEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EGMKKKGOODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class FBKKMNOOJKD : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class FDBKKBICJMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x433F720", Offset = "0x433DD20", VA = "0x18433F720")]
		static FDBKKBICJMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public FBKKMNOOJKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class GIKOMLFBGEI : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class NHEKJNANECH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x32E9420", Offset = "0x32E7A20", VA = "0x1832E9420")]
		static NHEKJNANECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GIKOMLFBGEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class MOLAEAIKNAM : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KHDOONPDGEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x390E5F0", Offset = "0x390CBF0", VA = "0x18390E5F0")]
		static KHDOONPDGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MOLAEAIKNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class HABAKHAGCIN : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class JABKCBCAANN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3A348F0", Offset = "0x3A32EF0", VA = "0x183A348F0")]
		static JABKCBCAANN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> DHGIKBBNFJL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DMCNEKLGFOA;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HABAKHAGCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GECAMHNPCHL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DGFMHGBCKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public LKBPCACDHBB KEFMCNNHCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder FGLBNDICKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder CJMPMBGHFCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class HNIHKEMBCCC
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PFNGJNIEMCC
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo DIOCPAKGNHA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo OEGJGAOMNPJ;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo PJMIOFIMEIG;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo BHGNMLKIJJL;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CCANMKDCHHN;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo CNIJIIBKHGD;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo BNPDFBDGPDK;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo AMGGNLPPHCK;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo MNCOMPPPIEI;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x34832F0", Offset = "0x34818F0", VA = "0x1834832F0")]
			static PFNGJNIEMCC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class PBNPNCJKKCC
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo EIDLCOIBNLL;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo EJBGKEHJCKA;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo LHNNKMINANN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo CEDEHGKCILM;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo KDGCILECFFP;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo ANLCBLJHBIJ;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo GHHLDEKGCJM;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x34827F0", Offset = "0x3480DF0", VA = "0x1834827F0")]
			static PBNPNCJKKCC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class MKMDGMKLLHL
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo GNIKAEDNMGA;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo NMHECDFAOFF;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MFJIOKAAHLD;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo GJNNJHOLLCI;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EHGEMLIHIIL;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo LBJDIGFOINL;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo LDPICJLCNJE;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo KJGJBCMGAJE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo OPIGBIGALHM;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo HONEMPNAPBJ;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo MCJOMHLHDEG;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo AOKMFDCAOJJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FIFIICBIAKK;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo EJBMDBNMLJL;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3474770", Offset = "0x3472D70", VA = "0x183474770")]
		public static MethodInfo DFIGKGIDJJK(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3474A00", Offset = "0x3473000", VA = "0x183474A00")]
		public static MethodInfo IACEKGNLJIN(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3474C30", Offset = "0x3473230", VA = "0x183474C30")]
		public static MethodInfo JDBJDHHGAGO(Type ONIHNDBDHGC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FDAEEGOAJKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<LKBPCACDHBB, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FDAEEGOAJKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KCEAJEGCIBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public FDAEEGOAJKL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KCEAJEGCIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x347DD80", Offset = "0x347C380", VA = "0x18347DD80")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x347DDC0", Offset = "0x347C3C0", VA = "0x18347DDC0")]
		internal bool <BuildType>b__2(int index, LKBPCACDHBB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class EKKDBFBMDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public FDAEEGOAJKL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public EKKDBFBMDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x346B3D0", Offset = "0x34699D0", VA = "0x18346B3D0")]
		internal bool <BuildType>b__3(int index, LKBPCACDHBB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class ALOPMBFJHPD
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
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ALOPMBFJHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x346AC20", Offset = "0x3469220", VA = "0x18346AC20")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class BIKFEOPBLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BIKFEOPBLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x346AE30", Offset = "0x3469430", VA = "0x18346AE30")]
		internal bool <BuildAnonymousFormatter>b__2(LKBPCACDHBB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FEIJDPFFOJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ALOPMBFJHPD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FEIJDPFFOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x346B470", Offset = "0x3469A70", VA = "0x18346B470")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x346B4F0", Offset = "0x3469AF0", VA = "0x18346B4F0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, LKBPCACDHBB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BPFCAGMMOGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public ALOPMBFJHPD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BPFCAGMMOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x346AE90", Offset = "0x3469490", VA = "0x18346AE90")]
		internal bool <BuildAnonymousFormatter>b__7(int index, LKBPCACDHBB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LLENGPBGEHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LLENGPBGEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x568CC0", Offset = "0x5672C0", VA = "0x180568CC0")]
		internal Label <BuildSerialize>b__1(LKBPCACDHBB _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BELEPFBINBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DGFMHGBCKME[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, LKBPCACDHBB, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PMKAMCEMKDO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PMKAMCEMKDO argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BELEPFBINBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x346AC80", Offset = "0x3469280", VA = "0x18346AC80")]
		internal DGFMHGBCKME <BuildDeserialize>b__0(LKBPCACDHBB item)
		{
			return default(DGFMHGBCKME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GBDJJMFLLKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BELEPFBINBP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GBDJJMFLLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x346B6F0", Offset = "0x3469CF0", VA = "0x18346B6F0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x346B9D0", Offset = "0x3469FD0", VA = "0x18346B9D0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PNJMHCICIGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public LKBPCACDHBB item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public PNJMHCICIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x15D0710", Offset = "0x15CED10", VA = "0x1815D0710")]
		internal bool <EmitNewObject>b__0(DGFMHGBCKME x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class PMJEPHGHNBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LKBPCACDHBB item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public PMJEPHGHNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x15D0710", Offset = "0x15CED10", VA = "0x1815D0710")]
		internal bool <EmitNewObject>b__2(DGFMHGBCKME x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex GKBAKNLNDEG;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int EDCDNCKKJLF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> PPOHDMLJOCA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> KFJFFMACFPI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E83A50", Offset = "0x2E82050", VA = "0x182E83A50")]
	public static object KHCJFJIEAJP<T>(DFDMNMAAHFF KOGJOKEBHLE, IHNIPBDLGGD HNOMMFACBME, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E7EAA0", Offset = "0x2E7D0A0", VA = "0x182E7EAA0")]
	public static object KDKCPDOOPCN<T>(IHNIPBDLGGD HNOMMFACBME, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA, bool PCLBELHBGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x289A790", Offset = "0x2898D90", VA = "0x18289A790")]
	private static TypeInfo CAGLKNBIIJI(DFDMNMAAHFF KOGJOKEBHLE, Type ONIHNDBDHGC, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x289CD40", Offset = "0x289B340", VA = "0x18289CD40")]
	public static object KGNGEFFCKAI(Type ONIHNDBDHGC, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA, bool PCLBELHBGNF, bool AFMLKDIHJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x289F7E0", Offset = "0x289DDE0", VA = "0x18289F7E0")]
	private static Dictionary<LKBPCACDHBB, FieldInfo> NMDHBMGBEBO(TypeBuilder BICKMGKOLLI, AHFAAOJAMII OONMAFOODBN, ConstructorInfo FKIPEOKEBBE, FieldBuilder MKNEIAFPMHL, ILGenerator HMCBAGLFFGI, bool DMCNEKLGFOA, bool GCKKJOLACNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x289A1D0", Offset = "0x28987D0", VA = "0x18289A1D0")]
	private static Dictionary<LKBPCACDHBB, FieldInfo> AALMMKJPBLC(TypeBuilder BICKMGKOLLI, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x289B7E0", Offset = "0x2899DE0", VA = "0x18289B7E0")]
	private static void KAGIKLLGIIJ(Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI, Action GHINGLJFBGA, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, bool DMCNEKLGFOA, bool GCKKJOLACNK, int PHNBPAOLNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x289F2F0", Offset = "0x289D8F0", VA = "0x18289F2F0")]
	private static void NMAKCKNBNCG(TypeInfo ONIHNDBDHGC, LKBPCACDHBB OCIIPMFHMAL, ILGenerator HMCBAGLFFGI, int HOOANEAGKNH, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, PMKAMCEMKDO CCLGELJKLAA, PMKAMCEMKDO FAHNBHGDLOA, PMKAMCEMKDO MGOLHMJHIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x289FE30", Offset = "0x289E430", VA = "0x18289FE30")]
	private static void OAPKFGEDAEC(Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, bool EHEOEOEECJN, int PHNBPAOLNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x289B230", Offset = "0x2899830", VA = "0x18289B230")]
	private static void FOIHLFMJADL(ILGenerator HMCBAGLFFGI, DGFMHGBCKME OONMAFOODBN, int HOOANEAGKNH, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, PMKAMCEMKDO JFKAGENJIJO, PMKAMCEMKDO MGOLHMJHIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x289E680", Offset = "0x289CC80", VA = "0x18289E680")]
	private static LocalBuilder NDILHEKOKAM(ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, DGFMHGBCKME[] IGONJNNHEAF, bool FKOHGHCOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x28A10E0", Offset = "0x289F6E0", VA = "0x1828A10E0")]
	private static bool OJBNKPKGOPB(ConstructorInfo JGAECKKFOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x289B640", Offset = "0x2899C40", VA = "0x18289B640")]
	private static bool JOANBAEMPAB(Type ONIHNDBDHGC, out Type GENENPEKLJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void LJCBABGAIKB<T>(byte[][] MKNEIAFPMHL, object[] GPHLODINKFK, ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T OBHGCMGGLEA<T>(object[] GPHLODINKFK, ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD BGBEOCLNGLJ);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class EPFIHGGGMBH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class FFBDLONNCIJ : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class GHMAJBAOIEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x29732E0", Offset = "0x29718E0", VA = "0x1829732E0")]
		static GHMAJBAOIEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private FFBDLONNCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class DCIGECOFGMP : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class JHBECBDPOFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC460", Offset = "0x2CDAA60", VA = "0x182CDC460")]
		static JHBECBDPOFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private DCIGECOFGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class PKKGEALGEEJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly IHNIPBDLGGD[] BPEGMJIHIAH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DINNFFNFKED : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class FBAFFJMPEKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x21C6930", Offset = "0x21C4F30", VA = "0x1821C6930")]
		static FBAFFJMPEKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class EMHOAOAMHJI : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class LIINGFINADP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x21CE870", Offset = "0x21CCE70", VA = "0x1821CE870")]
			static LIINGFINADP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private EMHOAOAMHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private DINNFFNFKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class ICCLJEFEOHG : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class FGDNDJBEJPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x20AF590", Offset = "0x20ADB90", VA = "0x1820AF590")]
		static FGDNDJBEJPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class GHKHFGBHLGK : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class FBGHNCKKBDM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x20AC090", Offset = "0x20AA690", VA = "0x1820AC090")]
			static FBGHNCKKBDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private GHKHFGBHLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private ICCLJEFEOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class MKIIGBGPDIL : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class KJGNIOBHNHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3912960", Offset = "0x3910F60", VA = "0x183912960")]
		static KJGNIOBHNHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class NGFLNBOJLPM : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class FCCDHDOCDLK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x390B8D0", Offset = "0x3909ED0", VA = "0x18390B8D0")]
			static FCCDHDOCDLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private NGFLNBOJLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private MKIIGBGPDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class DGGNKKHCMLK : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class ENPKEDOLMKL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x21C15F0", Offset = "0x21BFBF0", VA = "0x1821C15F0")]
		static ENPKEDOLMKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IPCLCCNBGCK : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class BGBICDHOBHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x21B2240", Offset = "0x21B0840", VA = "0x1821B2240")]
			static BGBICDHOBHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private IPCLCCNBGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private DGGNKKHCMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class PEGIGHKNFBF : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class KDFAEPODDLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x39F95B0", Offset = "0x39F7BB0", VA = "0x1839F95B0")]
		static KDFAEPODDLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class LGGGNCBEFFI : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class EPOCBMDOJEB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x39F5E50", Offset = "0x39F4450", VA = "0x1839F5E50")]
			static EPOCBMDOJEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private LGGGNCBEFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private PEGIGHKNFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class FAJMEAPJFND : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class ONGCLOGODFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x43431B0", Offset = "0x43417B0", VA = "0x1843431B0")]
		static ONGCLOGODFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class NPAOFOPNIOF : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class BIDANKPLMLO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x432B530", Offset = "0x4329B30", VA = "0x18432B530")]
			static BIDANKPLMLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private NPAOFOPNIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private FAJMEAPJFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class AAGJGALLFCB : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class CHHBIENJMML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2114D90", Offset = "0x2113390", VA = "0x182114D90")]
		static CHHBIENJMML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class LAGPLBFCDIL : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class MLAIMBFMMGO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2117D90", Offset = "0x2116390", VA = "0x182117D90")]
			static MLAIMBFMMGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private LAGPLBFCDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private AAGJGALLFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class CMDAMDNNMFN : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class FKMNMDFIICI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x306F5C0", Offset = "0x306DBC0", VA = "0x18306F5C0")]
		static FKMNMDFIICI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class FFPHJBCIDIK : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class LKHAMECFKKB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3071C70", Offset = "0x3070270", VA = "0x183071C70")]
			static LKHAMECFKKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private FFPHJBCIDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private CMDAMDNNMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class NHJBLIHKFJK : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class MBAAMAMADGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3425010", Offset = "0x3423610", VA = "0x183425010")]
		static MBAAMAMADGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class HCPBCADHABA : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class NLBINFKMOHG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3435960", Offset = "0x3433F60", VA = "0x183435960")]
			static NLBINFKMOHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private HCPBCADHABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private NHJBLIHKFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PBIGJPLIMON : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class LAJCEBJKNPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39FDB10", Offset = "0x39FC110", VA = "0x1839FDB10")]
		static LAJCEBJKNPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class POHIJONKKGJ : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class CCLNJODDMFG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x39EF6A0", Offset = "0x39EDCA0", VA = "0x1839EF6A0")]
			static CCLNJODDMFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private POHIJONKKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private PBIGJPLIMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class FKADDFNKPAK : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class JPDFFEHKMKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C7FFA0", Offset = "0x2C7E5A0", VA = "0x182C7FFA0")]
		static JPDFFEHKMKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class FMDJBANAEGG : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class IPHPMJEBAKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C7A000", Offset = "0x2C78600", VA = "0x182C7A000")]
			static IPHPMJEBAKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private FMDJBANAEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private FKADDFNKPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class EJIPJKEKNDP : IHNIPBDLGGD
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class AIBNLLDMEAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3920700", Offset = "0x391ED00", VA = "0x183920700")]
		static AIBNLLDMEAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class ECLECEMGEDC : IHNIPBDLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class DBKCKGGJGLD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::CHGOEAEDIKB<T> KGCJFILJLBJ;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3926EB0", Offset = "0x39254B0", VA = "0x183926EB0")]
			static DBKCKGGJGLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		private ECLECEMGEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
		public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::CHGOEAEDIKB<object> NJMGIGIDNMM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	private EJIPJKEKNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E430", Offset = "0x1C1CA30", VA = "0x181C1E430", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct CDAEICHCHHJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] HJEFHIFHAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int OJCJOGAFMFG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x23CC2E0", Offset = "0x23CA8E0", VA = "0x1823CC2E0")]
	public CDAEICHCHHJ(int EGALJCLILAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x23CC210", Offset = "0x23CA810", VA = "0x1823CC210")]
	public void NENJMCKJAJO(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x23CBFD0", Offset = "0x23CA5D0", VA = "0x1823CBFD0")]
	public T[] GPKIFPIDNBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class EDCLNHDEIED : global::GIDKKHOLMPJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly EDCLNHDEIED KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2895190", Offset = "0x2893790", VA = "0x182895190")]
	public EDCLNHDEIED(int FKILMHAJCAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class GIDKKHOLMPJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int FKILMHAJCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object MOCFKOIMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int HOOANEAGKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] HLCLFCOLJGI;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x32DDFA0", Offset = "0x32DC5A0", VA = "0x1832DDFA0")]
	public GIDKKHOLMPJ(int FKILMHAJCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x32DC7A0", Offset = "0x32DADA0", VA = "0x1832DC7A0")]
	public T[] OFKILNPFOMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x32DBBA0", Offset = "0x32DA1A0", VA = "0x1832DBBA0")]
	public void KOPGBHEAMMO(T[] BEGPAFGBCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class BHOCKMMPNPJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class JLNMMFKEPHK : IComparable<JLNMMFKEPHK>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class CEGGALCHCNI : IEnumerable<JLNMMFKEPHK>, IEnumerable, IEnumerator<JLNMMFKEPHK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private JLNMMFKEPHK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public JLNMMFKEPHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JLNMMFKEPHK System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
			[DebuggerHidden]
			public CEGGALCHCNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2890140", Offset = "0x288E740", VA = "0x182890140", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2890270", Offset = "0x288E870", VA = "0x182890270", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x28901D0", Offset = "0x288E7D0", VA = "0x1828901D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JLNMMFKEPHK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x28901D0", Offset = "0x288E7D0", VA = "0x1828901D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class MPEPFICGFAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public MPEPFICGFAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x568CC0", Offset = "0x5672C0", VA = "0x180568CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x568CC0", Offset = "0x5672C0", VA = "0x180568CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly JLNMMFKEPHK[] DEEPNHDEOPG;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] GICFKKKPADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int NLLJAAOBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CJBGLAIHCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private JLNMMFKEPHK[] JBHHJGALHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] NNEBHFBMGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int DHNBJNKGAHH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JGJHLGPPKJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA06E30", Offset = "0xA05430", VA = "0x180A06E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x28A30E0", Offset = "0x28A16E0", VA = "0x1828A30E0")]
		public JLNMMFKEPHK(ulong MKDJIBNCKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x28A2E20", Offset = "0x28A1420", VA = "0x1828A2E20")]
		public JLNMMFKEPHK NENJMCKJAJO(ulong MKDJIBNCKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x28A3010", Offset = "0x28A1610", VA = "0x1828A3010")]
		public JLNMMFKEPHK NENJMCKJAJO(ulong MKDJIBNCKNC, int MPHFKGJNMOK, string CJBGLAIHCKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x28A1E40", Offset = "0x28A0440", VA = "0x1828A1E40")]
		public JLNMMFKEPHK CDJIOKDMGJP(byte[] ODINNAEBCEA, ref int KJBKACPPODJ, ref int EEJHLCLDPFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x28A2020", Offset = "0x28A0620", VA = "0x1828A2020")]
		internal static int DDEOPFDEKMP(ulong[] BEGPAFGBCJM, int HOOANEAGKNH, int GGLJPLLKLMG, ulong MPHFKGJNMOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x28A1FF0", Offset = "0x28A05F0", VA = "0x1828A1FF0", Slot = "4")]
		public int CompareTo(JLNMMFKEPHK GJPJDOANCNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x28A20A0", Offset = "0x28A06A0", VA = "0x1828A20A0")]
		[IteratorStateMachine(typeof(CEGGALCHCNI))]
		public IEnumerable<JLNMMFKEPHK> GMELHOHILOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x28A2110", Offset = "0x28A0710", VA = "0x1828A2110")]
		public void KODGINIKBHE(ILGenerator HMCBAGLFFGI, LocalBuilder ODINNAEBCEA, LocalBuilder EEJHLCLDPFL, LocalBuilder MKDJIBNCKNC, Action<KeyValuePair<string, int>> MDGDLKLOBOA, Action GMJPOKHDHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x28A2240", Offset = "0x28A0840", VA = "0x1828A2240")]
		private static void LBPAGENHNMF(ILGenerator HMCBAGLFFGI, LocalBuilder ODINNAEBCEA, LocalBuilder EEJHLCLDPFL, LocalBuilder MKDJIBNCKNC, Action<KeyValuePair<string, int>> MDGDLKLOBOA, Action GMJPOKHDHCP, JLNMMFKEPHK[] JBHHJGALHMA, int DHNBJNKGAHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class DKICFJBDCCD : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<JLNMMFKEPHK> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<JLNMMFKEPHK> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<JLNMMFKEPHK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private JLNMMFKEPHK <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x561000", Offset = "0x55F600", VA = "0x180561000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x28942B0", Offset = "0x28928B0", VA = "0x1828942B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x935250", Offset = "0x933850", VA = "0x180935250")]
		[DebuggerHidden]
		public DKICFJBDCCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2894300", Offset = "0x2892900", VA = "0x182894300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2893E40", Offset = "0x2892440", VA = "0x182893E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2894400", Offset = "0x2892A00", VA = "0x182894400")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2894450", Offset = "0x2892A50", VA = "0x182894450")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2894260", Offset = "0x2892860", VA = "0x182894260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x28941C0", Offset = "0x28927C0", VA = "0x1828941C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x28941C0", Offset = "0x28927C0", VA = "0x1828941C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly JLNMMFKEPHK PFOHKHPLBFI;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x288FD10", Offset = "0x288E310", VA = "0x18288FD10")]
	public BHOCKMMPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x288FAD0", Offset = "0x288E0D0", VA = "0x18288FAD0")]
	public void NENJMCKJAJO(byte[] KFCJKMJDFKE, int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x288F8B0", Offset = "0x288DEB0", VA = "0x18288F8B0")]
	public bool CFIELOGABGK(ArraySegment<byte> MKDJIBNCKNC, out int MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x288FC20", Offset = "0x288E220", VA = "0x18288FC20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x288F630", Offset = "0x288DC30", VA = "0x18288F630")]
	private static void ADMOJALOIIJ(IEnumerable<JLNMMFKEPHK> JBHHJGALHMA, StringBuilder ECKLGDCNNAE, int DIAIBOCHHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x288F960", Offset = "0x288DF60", VA = "0x18288F960", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x288F960", Offset = "0x288DF60", VA = "0x18288F960", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x288FA60", Offset = "0x288E060", VA = "0x18288FA60")]
	[IteratorStateMachine(typeof(DKICFJBDCCD))]
	private static IEnumerable<KeyValuePair<string, int>> LHDALGDBNIM(IEnumerable<JLNMMFKEPHK> JBHHJGALHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x288FBF0", Offset = "0x288E1F0", VA = "0x18288FBF0")]
	public void OCMMECOBJCP(ILGenerator HMCBAGLFFGI, LocalBuilder ODINNAEBCEA, LocalBuilder EEJHLCLDPFL, LocalBuilder MKDJIBNCKNC, Action<KeyValuePair<string, int>> MDGDLKLOBOA, Action GMJPOKHDHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class GOMOFHGAPHE
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo CEKOBFFCKBD;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3470BA0", Offset = "0x346F1A0", VA = "0x183470BA0")]
	public static ulong PPBJDECHJBE(byte[] KFCJKMJDFKE, ref int KJBKACPPODJ, ref int EEJHLCLDPFL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class ANJJMLKHEKD
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x288B450", Offset = "0x2889A50", VA = "0x18288B450")]
	public static void DKIJAJMBPMB(ref byte[] KFCJKMJDFKE, int KJBKACPPODJ, int HIOEEKOEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x288B570", Offset = "0x2889B70", VA = "0x18288B570")]
	public static void LILIHALMBDE(ref byte[] BEGPAFGBCJM, int IHELJAFNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x288B660", Offset = "0x2889C60", VA = "0x18288B660")]
	public static byte[] MJGBCADCHCE(byte[] APOAJBBJNEM, int IHELJAFNFGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class EHLDNNPHMAM
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x28955A0", Offset = "0x2893BA0", VA = "0x1828955A0")]
	public static bool EODIBPOHCMG(byte[] PINEIALLKOA, int BIGJCKOKHNK, int JCMDCKDKIMO, byte[] IGIBBECELKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class EGMPBFEECFD<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct PFBAALPIMPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T NLLJAAOBNLN;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x34B49B0", Offset = "0x34B2FB0", VA = "0x1834B49B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AMGINOBEOKJ : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::EGMPBFEECFD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private PFBAALPIMPP[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private PFBAALPIMPP[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFE3120", Offset = "0xFE1720", VA = "0x180FE3120", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34A4760", Offset = "0x34A2D60", VA = "0x1834A4760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C64A70", Offset = "0x1C63070", VA = "0x181C64A70")]
		[DebuggerHidden]
		public AMGINOBEOKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x34A38B0", Offset = "0x34A1EB0", VA = "0x1834A38B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x34A3D60", Offset = "0x34A2360", VA = "0x1834A3D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly PFBAALPIMPP[][] NIBJPKMIFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong LGEAOCPJDAL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x34AE9D0", Offset = "0x34ACFD0", VA = "0x1834AE9D0")]
	public EGMPBFEECFD(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x34AE910", Offset = "0x34ACF10", VA = "0x1834AE910")]
	public EGMPBFEECFD(int NKJBJGFALMO, float DHHHFBOOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x34AE120", Offset = "0x34AC720", VA = "0x1834AE120")]
	public void NENJMCKJAJO(byte[] MKDJIBNCKNC, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x34ADA60", Offset = "0x34AC060", VA = "0x1834ADA60")]
	private bool IHPPCNEGKBA(byte[] MKDJIBNCKNC, T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x34AA8B0", Offset = "0x34A8EB0", VA = "0x1834AA8B0")]
	public bool ACEOCCKNHLM(ArraySegment<byte> MKDJIBNCKNC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x34ADDC0", Offset = "0x34AC3C0", VA = "0x1834ADDC0")]
	private static ulong KIJDHMPIPNP(byte[] KDNDPAEEMPL, int KJBKACPPODJ, int DHNBJNKGAHH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE5E0", Offset = "0x2BFCBE0", VA = "0x182BFE5E0")]
	private static int JKBCEOCOJBL(int DFHEMEDDEMC, float DHHHFBOOEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x34AAF00", Offset = "0x34A9500", VA = "0x1834AAF00", Slot = "4")]
	[IteratorStateMachine(typeof(global::EGMPBFEECFD<>.AMGINOBEOKJ))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1ECD460", Offset = "0x1ECBA60", VA = "0x181ECD460", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class GKANLDOACPP : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] KLMHLNGMNMA;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] KNFLBLAMPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int OAJOCKHBJEN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MKIBELADCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x346E3B0", Offset = "0x346C9B0", VA = "0x18346E3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x346E510", Offset = "0x346CB10", VA = "0x18346E510")]
	static GKANLDOACPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x346E760", Offset = "0x346CD60", VA = "0x18346E760")]
	public GKANLDOACPP(byte[] LBGOONHAHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x346E400", Offset = "0x346CA00", VA = "0x18346E400")]
	public OpCode NDDBFGKMLLM()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct AOELBBNOMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid NLLJAAOBNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte PNCAFPELOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte DEKIGHFKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte CJKJFOHHNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte ELPCEOKODKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte JKMOIIDNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte LPJDBFLDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte JIDNCJCAMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KEKDAJAGGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte IBMLAJLLDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte NPFPJMKHEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte ABPBKGGPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte MNLBPKMIMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte GICABNMIPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte JJMDAMOMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte ADMJLDGDDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte IBAJEKBAGPN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] EFBHDNMJDLO;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] DEGJPGDMJDK;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x288D3C0", Offset = "0x288B9C0", VA = "0x18288D3C0")]
	public AOELBBNOMEN(ref Guid MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x288CD10", Offset = "0x288B310", VA = "0x18288CD10")]
	public AOELBBNOMEN(ref ArraySegment<byte> ONIMEGFECJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x288CBA0", Offset = "0x288B1A0", VA = "0x18288CBA0")]
	private static byte MADGIHMIKEK(byte[] KFCJKMJDFKE, int ENJPLLFKKPA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x288CA90", Offset = "0x288B090", VA = "0x18288CA90")]
	private static byte HNJFLCJJCJG(byte IIFMPDAMAIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x288B750", Offset = "0x2889D50", VA = "0x18288B750")]
	public void BHCFMJJHILF(byte[] HKAAJCFANGC, int KJBKACPPODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GFAKEAABANL
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x346D430", Offset = "0x346BA30", VA = "0x18346D430")]
	public static bool LEMKLJOOAEP(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x346D630", Offset = "0x346BC30", VA = "0x18346D630")]
	public static bool PPHEJILLNCL(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x346D5C0", Offset = "0x346BBC0", VA = "0x18346D5C0")]
	public static sbyte PJCGOJJOCBK(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x346BDA0", Offset = "0x346A3A0", VA = "0x18346BDA0")]
	public static short GAPLLDKLEID(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x346D3C0", Offset = "0x346B9C0", VA = "0x18346D3C0")]
	public static int LEANGICBMPH(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x346BE90", Offset = "0x346A490", VA = "0x18346BE90")]
	public static long GKMKBANOJIM(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x346D350", Offset = "0x346B950", VA = "0x18346D350")]
	public static byte KCPBODNFLBD(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x346BAE0", Offset = "0x346A0E0", VA = "0x18346BAE0")]
	public static ushort EJJGFBICOJP(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x346BE10", Offset = "0x346A410", VA = "0x18346BE10")]
	public static uint GHIGFJHGFLL(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x346D4B0", Offset = "0x346BAB0", VA = "0x18346D4B0")]
	public static ulong NCFNCPMJIII(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x346BA70", Offset = "0x346A070", VA = "0x18346BA70")]
	public static float EAHNPLKCOGI(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x346D440", Offset = "0x346BA40", VA = "0x18346D440")]
	public static double LNIAIEFDMPM(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x346BF40", Offset = "0x346A540", VA = "0x18346BF40")]
	public static int GNBMBHPKNHE(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, ulong MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x346C710", Offset = "0x346AD10", VA = "0x18346C710")]
	public static int IAFNNDIMDCI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, long MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x346BB50", Offset = "0x346A150", VA = "0x18346BB50")]
	public static bool FBCOPIEIEPC(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class NJJDCODAMJM
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NNPECCAKOCO : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public NNPECCAKOCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9EF0", Offset = "0x4DA84F0", VA = "0x184DA9EF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9A90", Offset = "0x4DA8090", VA = "0x184DA9A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4DAA010", Offset = "0x4DA8610", VA = "0x184DAA010")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4DAA060", Offset = "0x4DA8660", VA = "0x184DAA060")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9EA0", Offset = "0x4DA84A0", VA = "0x184DA9EA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9DF0", Offset = "0x4DA83F0", VA = "0x184DA9DF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9DF0", Offset = "0x4DA83F0", VA = "0x184DA9DF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class MLMJDAFHGCB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public MLMJDAFHGCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7F00", Offset = "0x4DA6500", VA = "0x184DA7F00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7AA0", Offset = "0x4DA60A0", VA = "0x184DA7AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4DA8020", Offset = "0x4DA6620", VA = "0x184DA8020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4DA8070", Offset = "0x4DA6670", VA = "0x184DA8070")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7EB0", Offset = "0x4DA64B0", VA = "0x184DA7EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7E00", Offset = "0x4DA6400", VA = "0x184DA7E00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4DA7E00", Offset = "0x4DA6400", VA = "0x184DA7E00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA92D0", Offset = "0x4DA78D0", VA = "0x184DA92D0")]
	public static bool MLPBAAHIHAB(this TypeInfo ONIHNDBDHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9380", Offset = "0x4DA7980", VA = "0x184DA9380")]
	public static bool OKMKGDCDFFC(this TypeInfo ONIHNDBDHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4DA91E0", Offset = "0x4DA77E0", VA = "0x184DA91E0")]
	public static IEnumerable<PropertyInfo> LLKGOABBBBM(this Type ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA90F0", Offset = "0x4DA76F0", VA = "0x184DA90F0")]
	[IteratorStateMachine(typeof(NNPECCAKOCO))]
	private static IEnumerable<PropertyInfo> CCCDKLIODAN(Type ONIHNDBDHGC, HashSet<string> OALKGLBOPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9180", Offset = "0x4DA7780", VA = "0x184DA9180")]
	public static IEnumerable<FieldInfo> JPCPLPNDGIH(this Type ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9240", Offset = "0x4DA7840", VA = "0x184DA9240")]
	[IteratorStateMachine(typeof(MLMJDAFHGCB))]
	private static IEnumerable<FieldInfo> MGJAPKDODLI(Type ONIHNDBDHGC, HashSet<string> OALKGLBOPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class FEFPNDCJNHP
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding ELHDABAHCLO;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class AEHJBALKIOF
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x615F60", Offset = "0x614560", VA = "0x180615F60")]
	public static string KPBKJHIBDBM(string AGEMEGILCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x28899A0", Offset = "0x2887FA0", VA = "0x1828899A0")]
	public static string FDNMBKIKNJJ(string AGEMEGILCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x28897D0", Offset = "0x2887DD0", VA = "0x1828897D0")]
	public static string DNEIGIOLJOL(string AGEMEGILCNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JHPNJCCNEJI<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class PAMEBGNMIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type FJPMPBHLOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue NLLJAAOBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int NPDBGCLGLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PAMEBGNMIKA MKGHNHOEKJH;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2C02880", Offset = "0x2C00E80", VA = "0x182C02880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2C02800", Offset = "0x2C00E00", VA = "0x182C02800")]
		private int LLHHHCBKNJN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public PAMEBGNMIKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OIBMMFPILNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public OIBMMFPILNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x83A090", Offset = "0x838690", VA = "0x18083A090")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private PAMEBGNMIKA[] NIBJPKMIFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int KMCJMFPOINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object DPHKIIKGFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float DHHHFBOOEHH;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF010", Offset = "0x2BFD610", VA = "0x182BFF010")]
	public JHPNJCCNEJI(int NKJBJGFALMO = 4, float DHHHFBOOEHH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE7A0", Offset = "0x2BFCDA0", VA = "0x182BFE7A0")]
	public bool LHNHAJKKNNC(Type MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE760", Offset = "0x2BFCD60", VA = "0x182BFE760")]
	public bool LHNHAJKKNNC(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDFE0", Offset = "0x2BFC5E0", VA = "0x182BFDFE0")]
	private bool IHPPCNEGKBA(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO, out TValue LCKGMJMPKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE8B0", Offset = "0x2BFCEB0", VA = "0x182BFE8B0")]
	private bool MPKFCMNJKDJ(PAMEBGNMIKA[] NIBJPKMIFMM, Type HPGCPPOKJBN, PAMEBGNMIKA BODGFIHOMHP, Func<Type, TValue> HALEMICJPIO, out TValue LCKGMJMPKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDBC0", Offset = "0x2BFC1C0", VA = "0x182BFDBC0")]
	public bool ACEOCCKNHLM(Type MKDJIBNCKNC, out TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDF40", Offset = "0x2BFC540", VA = "0x182BFDF40")]
	public TValue GPHBEMBAHLO(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE5E0", Offset = "0x2BFCBE0", VA = "0x182BFE5E0")]
	private static int JKBCEOCOJBL(int DFHEMEDDEMC, float DHHHFBOOEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDE60", Offset = "0x2BFC460", VA = "0x182BFDE60")]
	private static void BPGBIHIIOCC(ref PAMEBGNMIKA HLLENNLJMEE, PAMEBGNMIKA MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDE60", Offset = "0x2BFC460", VA = "0x182BFDE60")]
	private static void BPGBIHIIOCC(ref PAMEBGNMIKA[] HLLENNLJMEE, PAMEBGNMIKA[] MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class DFDMNMAAHFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder IHDHLIJIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder DGDOHPNLKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object MOCFKOIMCLO;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x28936B0", Offset = "0x2891CB0", VA = "0x1828936B0")]
	public TypeBuilder JMABCCNHJMG(string MONHCMBIJIP, TypeAttributes BHEENIELJOE, Type COLFLONKFJK, Type[] GFCJLCDHMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x28937A0", Offset = "0x2891DA0", VA = "0x1828937A0")]
	public DFDMNMAAHFF(string NAJECPPKLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class NKPJFGJKGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9480", Offset = "0x4DA7A80", VA = "0x184DA9480")]
	private static MethodInfo MGGNHCLFIMC(LambdaExpression PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2648C60", Offset = "0x2647260", VA = "0x182648C60")]
	public static MethodInfo BEEKDKKBJDO<T>(Expression<Func<T>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2648C60", Offset = "0x2647260", VA = "0x182648C60")]
	public static MethodInfo BEEKDKKBJDO<T, TR>(Expression<Func<T, TR>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2648C60", Offset = "0x2647260", VA = "0x182648C60")]
	public static MethodInfo BEEKDKKBJDO<T>(Expression<Action<T>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2648C60", Offset = "0x2647260", VA = "0x182648C60")]
	public static MethodInfo BEEKDKKBJDO<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2648C70", Offset = "0x2647270", VA = "0x182648C70")]
	private static MemberInfo KJICPPJCOJB<T>(Expression<T> KEIJPKNBGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2648D10", Offset = "0x2647310", VA = "0x182648D10")]
	public static PropertyInfo MHDEBEMAEPF<T, TR>(Expression<Func<T, TR>> PIAHFNDOJLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct PMKAMCEMKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int CKOCCIDDCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool HDGCHPFCEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator HMCBAGLFFGI;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF250", Offset = "0x4DAD850", VA = "0x184DAF250")]
	public PMKAMCEMKDO(ILGenerator HMCBAGLFFGI, int CKOCCIDDCLA, bool HDGCHPFCEBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF1C0", Offset = "0x4DAD7C0", VA = "0x184DAF1C0")]
	public PMKAMCEMKDO(ILGenerator HMCBAGLFFGI, int CKOCCIDDCLA, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF1A0", Offset = "0x4DAD7A0", VA = "0x184DAF1A0")]
	public void CAKENMMPPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IPEDPDKGDGE
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x347A9A0", Offset = "0x3478FA0", VA = "0x18347A9A0")]
	public static void DACFCJEOKMI(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x347ABD0", Offset = "0x34791D0", VA = "0x18347ABD0")]
	public static void DACFCJEOKMI(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x347B0C0", Offset = "0x34796C0", VA = "0x18347B0C0")]
	public static void EGHHLFBNODJ(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x347B2F0", Offset = "0x34798F0", VA = "0x18347B2F0")]
	public static void EGHHLFBNODJ(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x347AEC0", Offset = "0x34794C0", VA = "0x18347AEC0")]
	public static void EEPKJINBPPG(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x347AFB0", Offset = "0x34795B0", VA = "0x18347AFB0")]
	public static void EEPKJINBPPG(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x347BC30", Offset = "0x347A230", VA = "0x18347BC30")]
	public static void PPGPNDEDFNG(this ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x347B8F0", Offset = "0x3479EF0", VA = "0x18347B8F0")]
	public static void LJGOPOEJLNC(this ILGenerator HMCBAGLFFGI, bool MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x347B4A0", Offset = "0x3479AA0", VA = "0x18347B4A0")]
	public static void LJBELDBICHC(this ILGenerator HMCBAGLFFGI, int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x347B3B0", Offset = "0x34799B0", VA = "0x18347B3B0")]
	public static void KJFMKPABEGK(this ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x347AD00", Offset = "0x3479300", VA = "0x18347AD00")]
	public static void DIADLHFGMHO(this ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x347BA00", Offset = "0x347A000", VA = "0x18347BA00")]
	public static void ODNKHGICGHK(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x347B330", Offset = "0x3479930", VA = "0x18347B330")]
	public static void EJEOKCIAAIK(this ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x347AC10", Offset = "0x3479210", VA = "0x18347AC10")]
	public static void DCKKOHNOHBH(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x347B900", Offset = "0x3479F00", VA = "0x18347B900")]
	public static void MLDIFNCPOBH(this ILGenerator HMCBAGLFFGI, MethodInfo FBNKADPNIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x347ADA0", Offset = "0x34793A0", VA = "0x18347ADA0")]
	public static void DKNLNMCPGIB(this ILGenerator HMCBAGLFFGI, FieldInfo NJPKCJNHCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x347AE30", Offset = "0x3479430", VA = "0x18347AE30")]
	public static void EEGNCFDNIPK(this ILGenerator HMCBAGLFFGI, ulong MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class LKBPCACDHBB
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class DPMBLPDMMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DPMBLPDMMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x346B2D0", Offset = "0x34698D0", VA = "0x18346B2D0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo EAGLOJLDCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo IOLBEHBNMOK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string KKHBICLGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GOCAGFIEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OHGKPCLKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x347F9F0", Offset = "0x347DFF0", VA = "0x18347F9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DJLFPEOGKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x560190", Offset = "0x55E790", VA = "0x180560190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AA0", Offset = "0x6C30A0", VA = "0x1806C4AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ELMJAFHEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5601A0", Offset = "0x55E7A0", VA = "0x1805601A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x67B090", Offset = "0x679690", VA = "0x18067B090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type DMIFKFNAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x673F20", Offset = "0x672520", VA = "0x180673F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo OKHIMGKBOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo HIHMGNAJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x561010", Offset = "0x55F610", VA = "0x180561010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x561020", Offset = "0x55F620", VA = "0x180561020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo JOPENEKHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x573D70", Offset = "0x572370", VA = "0x180573D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5FAFC0", Offset = "0x5F95C0", VA = "0x1805FAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x347FEA0", Offset = "0x347E4A0", VA = "0x18347FEA0")]
	protected LKBPCACDHBB(Type ONIHNDBDHGC, string MONHCMBIJIP, string EOIFKMMFMLJ, bool ABKIDIPLMCJ, bool MKADPEHJEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x347FBE0", Offset = "0x347E1E0", VA = "0x18347FBE0")]
	public LKBPCACDHBB(FieldInfo OONMAFOODBN, string MONHCMBIJIP, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x347FCF0", Offset = "0x347E2F0", VA = "0x18347FCF0")]
	public LKBPCACDHBB(PropertyInfo OONMAFOODBN, string MONHCMBIJIP, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x347FAC0", Offset = "0x347E0C0", VA = "0x18347FAC0")]
	private static MethodInfo JDDHPIOOJDE(MemberInfo OONMAFOODBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1E22BB0", Offset = "0x1E211B0", VA = "0x181E22BB0")]
	public T DOCCIPGBCJB<T>(bool IMJOKNAOEDB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x347F930", Offset = "0x347DF30", VA = "0x18347F930", Slot = "4")]
	public virtual void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x347FA00", Offset = "0x347E000", VA = "0x18347FA00", Slot = "5")]
	public virtual void FCOAICOLOMN(ILGenerator HMCBAGLFFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class GJMIDJECICF : LKBPCACDHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string EKBGBKNBPCC;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x346E2E0", Offset = "0x346C8E0", VA = "0x18346E2E0")]
	public GJMIDJECICF(string MONHCMBIJIP, string EKBGBKNBPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x346E1D0", Offset = "0x346C7D0", VA = "0x18346E1D0", Slot = "4")]
	public override void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x346E290", Offset = "0x346C890", VA = "0x18346E290", Slot = "5")]
	public override void FCOAICOLOMN(ILGenerator HMCBAGLFFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class GGDBGPDLCPF : LKBPCACDHBB
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo EPCNCFKDPHP;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo POHCAONEGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal PMKAMCEMKDO IHCDAABIFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal PMKAMCEMKDO FAHNBHGDLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal PMKAMCEMKDO MGOLHMJHIGM;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x346DD60", Offset = "0x346C360", VA = "0x18346DD60")]
	public GGDBGPDLCPF(string MONHCMBIJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x346D6A0", Offset = "0x346BCA0", VA = "0x18346D6A0", Slot = "4")]
	public override void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x346D760", Offset = "0x346BD60", VA = "0x18346D760", Slot = "5")]
	public override void FCOAICOLOMN(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x346D7B0", Offset = "0x346BDB0", VA = "0x18346D7B0")]
	public void PGABLMPDFEL(ILGenerator HMCBAGLFFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class AHFAAOJAMII
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type DMIFKFNAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CFJFHJKJFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x687F70", Offset = "0x686570", VA = "0x180687F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6FF010", Offset = "0x6FD610", VA = "0x1806FF010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GPJIPCPMJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x67C6B0", Offset = "0x67ACB0", VA = "0x18067C6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xCD9FC0", Offset = "0xCD85C0", VA = "0x180CD9FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo GHMOHGIAGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LKBPCACDHBB[] JOHLIPDABIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5890C0", Offset = "0x5876C0", VA = "0x1805890C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x673F20", Offset = "0x672520", VA = "0x180673F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LKBPCACDHBB[] EGKIPDNMJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x588A30", Offset = "0x587030", VA = "0x180588A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6818D0", Offset = "0x67FED0", VA = "0x1806818D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2889D50", Offset = "0x2888350", VA = "0x182889D50")]
	public AHFAAOJAMII(Type ONIHNDBDHGC, Func<string, string> OHINHBEMEGD, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2889C80", Offset = "0x2888280", VA = "0x182889C80")]
	private static bool JLEJEBDIIGF(IEnumerator<ConstructorInfo> LMBKNHEJNPB, ref ConstructorInfo LKMNIJIPDNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct ICJOJGBLNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong DAFIBMCLHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int BACBMFCMEGB;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x21D2720", Offset = "0x21D0D20", VA = "0x1821D2720")]
	public ICJOJGBLNNM(ulong FLMABCAICKN, int LOILPLMGAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x34768A0", Offset = "0x3474EA0", VA = "0x1834768A0")]
	public void GBOGKLFOEGK(ref ICJOJGBLNNM GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x34768B0", Offset = "0x3474EB0", VA = "0x1834768B0")]
	public static ICJOJGBLNNM GFGJFPCMACO(ref ICJOJGBLNNM NCGEKBENJBA, ref ICJOJGBLNNM IIFMPDAMAIA)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x34768E0", Offset = "0x3474EE0", VA = "0x1834768E0")]
	public void ONDBJDAMOCP(ref ICJOJGBLNNM GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x34767F0", Offset = "0x3474DF0", VA = "0x1834767F0")]
	public static ICJOJGBLNNM FJIECJBHBHC(ref ICJOJGBLNNM NCGEKBENJBA, ref ICJOJGBLNNM IIFMPDAMAIA)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3476750", Offset = "0x3474D50", VA = "0x183476750")]
	public void AOMMKPJONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3476790", Offset = "0x3474D90", VA = "0x183476790")]
	public static ICJOJGBLNNM AOMMKPJONNB(ref ICJOJGBLNNM NCGEKBENJBA)
	{
		return default(ICJOJGBLNNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct KEHNKMCECIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] HKAAJCFANGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int KJBKACPPODJ;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x80BFA0", Offset = "0x80A5A0", VA = "0x18080BFA0")]
	public KEHNKMCECIM(byte[] HKAAJCFANGC, int MMBOHLJHNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x347DFE0", Offset = "0x347C5E0", VA = "0x18347DFE0")]
	public void FOOPJIOCBII(byte IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x347E040", Offset = "0x347C640", VA = "0x18347E040")]
	public void GBIPJNGEOHM(byte[] IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x347E0E0", Offset = "0x347C6E0", VA = "0x18347E0E0")]
	public void KCDJHCENIOP(byte[] IOLGJHAFBKL, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x347E180", Offset = "0x347C780", VA = "0x18347E180")]
	public void KCDJHCENIOP(byte[] IOLGJHAFBKL, int BDOCBPFFDPK, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x347DE60", Offset = "0x347C460", VA = "0x18347DE60")]
	public void CMJAKOMAIAC(byte AHENHIDOBEA, int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x347DEE0", Offset = "0x347C4E0", VA = "0x18347DEE0")]
	public void DCNCMHKNFMO(string IOLGJHAFBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class HGOJHGMOCOE
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum DFHOELFBLBO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum FAIIPAOBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum IIGFPGPPPBE
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
	private static byte[] GOBIIDAJNKA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] KLAGPGJOKIO;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] DMEKMNBBIOK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] CDODMOGBILN;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly IIGFPGPPPBE AEPMCCNNIEH;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char ENENAODBJPL;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int AOEONBIHLOI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int KKACPOPEJFK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] NNLAHDKAMHJ;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x3473C00", Offset = "0x3472200", VA = "0x183473C00")]
	private static byte[] POEHGAGHMDA(int KMCJMFPOINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3473230", Offset = "0x3471830", VA = "0x183473230")]
	private static byte[] KOJOBMPIIJH(int KMCJMFPOINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3472D30", Offset = "0x3471330", VA = "0x183472D30")]
	public static int JAEIHBBACGI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, float MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3472E40", Offset = "0x3471440", VA = "0x183472E40")]
	public static int JAEIHBBACGI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, double MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3473B00", Offset = "0x3472100", VA = "0x183473B00")]
	private static bool PJHFBCPAMIE(byte[] HKAAJCFANGC, int GGLJPLLKLMG, ulong HGLKOJIEPBB, ulong JAMNKCJHBEE, ulong EEJHLCLDPFL, ulong FFGIANIPOBK, ulong MMMBPCNCOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x34726B0", Offset = "0x3470CB0", VA = "0x1834726B0")]
	private static void CKMFHIKLDBF(uint FPHMKGOEILD, int NBPMLEBACBE, out uint CIOMBPDDIJL, out int AKFNFAOOCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x34727D0", Offset = "0x3470DD0", VA = "0x1834727D0")]
	private static bool GEEHAIOMOKD(ICJOJGBLNNM IMIIMLHLMBB, ICJOJGBLNNM PCMOEMJBGBJ, ICJOJGBLNNM HJHPAGOJMLM, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int EDDMIDAOJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3473310", Offset = "0x3471910", VA = "0x183473310")]
	private static bool OGONHDKIFMM(double LNDKNIFDPNN, DFHOELFBLBO EAPLEPGNBDJ, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int OCPPDCOIKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3471DF0", Offset = "0x34703F0", VA = "0x183471DF0")]
	private static bool AEKPJPBLBKH(double LNDKNIFDPNN, DFHOELFBLBO EAPLEPGNBDJ, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int FBCOLBDEPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3472BA0", Offset = "0x34711A0", VA = "0x183472BA0")]
	private static bool IDKJPDAOBCI(double MPHFKGJNMOK, ref KEHNKMCECIM GAHBGNKOLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3471EE0", Offset = "0x34704E0", VA = "0x183471EE0")]
	private static bool BABMENAOPLA(double MPHFKGJNMOK, ref KEHNKMCECIM GAHBGNKOLLK, FAIIPAOBDAG EAPLEPGNBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3472F50", Offset = "0x3471550", VA = "0x183472F50")]
	private static void JKFMHJLKMCE(byte[] IPEPACCMODI, int GGLJPLLKLMG, int FBCOLBDEPBA, int NJNPFOKFMMM, ref KEHNKMCECIM GAHBGNKOLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x34736B0", Offset = "0x3471CB0", VA = "0x1834736B0")]
	private static void OOFILHDKLCI(byte[] IPEPACCMODI, int GGLJPLLKLMG, int LOILPLMGAOK, ref KEHNKMCECIM GAHBGNKOLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3472510", Offset = "0x3470B10", VA = "0x183472510")]
	private static bool BPMPGPOJFMH(double LNDKNIFDPNN, FAIIPAOBDAG EAPLEPGNBDJ, int POBDFIGBFKI, byte[] IHINACCKNDA, out bool DFJLNNJENJG, out int GGLJPLLKLMG, out int ECAKKCJGNHD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct NKCKDCMOOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double CGNILIACKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong IFEKAIOIAHE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct ALDFPIGAGGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float DAFIBMCLHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint OEONHNEDOHA;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct LKGKFGJDEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong DDEPCBPGECF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4CF4AF0", Offset = "0x4CF30F0", VA = "0x184CF4AF0")]
	public LKGKFGJDEIF(double CGNILIACKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5650", Offset = "0x4DA3C50", VA = "0x184DA5650")]
	public LKGKFGJDEIF(ICJOJGBLNNM CGNILIACKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA50B0", Offset = "0x4DA36B0", VA = "0x184DA50B0")]
	public ICJOJGBLNNM DBOBBBBCAHB()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4DA51C0", Offset = "0x4DA37C0", VA = "0x184DA51C0")]
	public ICJOJGBLNNM GFBHOJKBILH()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x77A190", Offset = "0x778790", VA = "0x18077A190")]
	public ulong NPNBJPGFFCP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5540", Offset = "0x4DA3B40", VA = "0x184DA5540")]
	public double ODDKFBOIOCJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5280", Offset = "0x4DA3880", VA = "0x184DA5280")]
	public double JILGKCMADAE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5190", Offset = "0x4DA3790", VA = "0x184DA5190")]
	public int GBEIFCGDNDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5130", Offset = "0x4DA3730", VA = "0x184DA5130")]
	public ulong EBEENLGOKDO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5300", Offset = "0x4DA3900", VA = "0x184DA5300")]
	public bool KDBOJCBLALE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5260", Offset = "0x4DA3860", VA = "0x184DA5260")]
	public bool HJNABLMJJFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5510", Offset = "0x4DA3B10", VA = "0x184DA5510")]
	public bool NNJKJKADGFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5060", Offset = "0x4DA3660", VA = "0x184DA5060")]
	public bool BLHIGENOLOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5090", Offset = "0x4DA3690", VA = "0x184DA5090")]
	public int CCEBHEBFJPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5320", Offset = "0x4DA3920", VA = "0x184DA5320")]
	public void KLEHMJLJOGC(out ICJOJGBLNNM NKJOGBMKNAB, out ICJOJGBLNNM KHLDEDHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA54B0", Offset = "0x4DA3AB0", VA = "0x184DA54B0")]
	public bool MOGBHHADNGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5500", Offset = "0x4DA3B00", VA = "0x184DA5500")]
	public double MPHFKGJNMOK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5170", Offset = "0x4DA3770", VA = "0x184DA5170")]
	public static int FJGDOBPEPFH(int NBFKFPHEKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5160", Offset = "0x4DA3760", VA = "0x184DA5160")]
	public static double EGMIKCIDOME()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4DA55B0", Offset = "0x4DA3BB0", VA = "0x184DA55B0")]
	public static ulong PEEHPIGHLPF(ICJOJGBLNNM DAMNFNCMKFN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct MICNDKJFANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint FOCEEBCDIFN;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C530", Offset = "0x1D4AB30", VA = "0x181D4C530")]
	public MICNDKJFANN(float DAFIBMCLHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4DA72A0", Offset = "0x4DA58A0", VA = "0x184DA72A0")]
	public ICJOJGBLNNM DBOBBBBCAHB()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460")]
	public uint IKIPEKHHPDN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7330", Offset = "0x4DA5930", VA = "0x184DA7330")]
	public int GBEIFCGDNDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7310", Offset = "0x4DA5910", VA = "0x184DA7310")]
	public uint EBEENLGOKDO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7350", Offset = "0x4DA5950", VA = "0x184DA7350")]
	public bool KDBOJCBLALE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7360", Offset = "0x4DA5960", VA = "0x184DA7360")]
	public void KLEHMJLJOGC(out ICJOJGBLNNM NKJOGBMKNAB, out ICJOJGBLNNM KHLDEDHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA74D0", Offset = "0x4DA5AD0", VA = "0x184DA74D0")]
	public bool MOGBHHADNGK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct KOJMDEPANIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong FLMABCAICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short OKABPHGCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short OCPPDCOIKPH;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x347E9B0", Offset = "0x347CFB0", VA = "0x18347E9B0")]
	public KOJMDEPANIF(ulong FLMABCAICKN, short OKABPHGCAJF, short OCPPDCOIKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class DEKJACJMGNP
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly KOJMDEPANIF[] GHFILDNMAGF;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x28912C0", Offset = "0x288F8C0", VA = "0x1828912C0")]
	public static void LBPDMHECPAL(int HFKKAJAGHJI, int CCNEDFGLIMI, out ICJOJGBLNNM CIOMBPDDIJL, out int OCPPDCOIKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x28911C0", Offset = "0x288F7C0", VA = "0x1828911C0")]
	public static void BCGIKMELGNO(int EGKHBABAHCI, out ICJOJGBLNNM CIOMBPDDIJL, out int CCMGNLAIEBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct PPAOGPLCIHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] KFCJKMJDFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int BDOCBPFFDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int DAKGLFFBGMC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte NHFHAHEKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF470", Offset = "0x4DADA70", VA = "0x184DAF470")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x919440", Offset = "0x917A40", VA = "0x180919440")]
	public PPAOGPLCIHK(byte[] KFCJKMJDFKE, int BDOCBPFFDPK, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D1420", Offset = "0x7CFA20", VA = "0x1807D1420")]
	public int GGLJPLLKLMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF410", Offset = "0x4DADA10", VA = "0x184DAF410")]
	public PPAOGPLCIHK JNPMOECIBMN(int LGIDLLONMNC, int IICCOEMDOFD)
	{
		return default(PPAOGPLCIHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class OEJIIBJNDLB
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] PHJLIJBEKEL;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] HAIGGEMCGKK;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int LBIOMMCNKOG;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA0B0", Offset = "0x4DA86B0", VA = "0x184DAA0B0")]
	private static byte[] AJJMNDIEAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4DAAF60", Offset = "0x4DA9560", VA = "0x184DAAF60")]
	private static PPAOGPLCIHK JONHCCLBNGF(PPAOGPLCIHK HKAAJCFANGC)
	{
		return default(PPAOGPLCIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA870", Offset = "0x4DA8E70", VA = "0x184DAA870")]
	private static PPAOGPLCIHK FDPHDDDLIHD(PPAOGPLCIHK HKAAJCFANGC)
	{
		return default(PPAOGPLCIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB040", Offset = "0x4DA9640", VA = "0x184DAB040")]
	private static void LEKLKBBFIEF(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, byte[] MGLDDGKJEDM, out int FJGODEPODFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA2C0", Offset = "0x4DA88C0", VA = "0x184DAA2C0")]
	private static void EJPDLOJKOHA(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, byte[] OLCOOGOHMAB, int FJEMJMEDLKK, out PPAOGPLCIHK PGCLLAMLLAG, out int AEGCLGFDNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB540", Offset = "0x4DA9B40", VA = "0x184DAB540")]
	private static ulong NJIDGANEADL(PPAOGPLCIHK HKAAJCFANGC, out int EOFENAJNBBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4DAADC0", Offset = "0x4DA93C0", VA = "0x184DAADC0")]
	private static void GNPDBLIDOKK(PPAOGPLCIHK HKAAJCFANGC, out ICJOJGBLNNM AEOILPMENGG, out int KHCCHNNOCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB0F0", Offset = "0x4DA96F0", VA = "0x184DAB0F0")]
	private static bool NBJFADFMIFH(PPAOGPLCIHK PGCLLAMLLAG, int LOILPLMGAOK, out double AEOILPMENGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB700", Offset = "0x4DA9D00", VA = "0x184DAB700")]
	private static ICJOJGBLNNM PFOOOHBEFHD(int LOILPLMGAOK)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA950", Offset = "0x4DA8F50", VA = "0x184DAA950")]
	private static bool FGHEPNEAIEG(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, out double AEOILPMENGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB5D0", Offset = "0x4DA9BD0", VA = "0x184DAB5D0")]
	private static bool OCECKPHNJHO(PPAOGPLCIHK PGCLLAMLLAG, int LOILPLMGAOK, out double HHAHHDPKMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA190", Offset = "0x4DA8790", VA = "0x184DAA190")]
	public static double? CAKBNADJNFN(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA5E0", Offset = "0x4DA8BE0", VA = "0x184DAA5E0")]
	public static float? EMENIDKICMJ(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct GKEOKIIGBCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] HKAAJCFANGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int KJBKACPPODJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x346E7E0", Offset = "0x346CDE0", VA = "0x18346E7E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x80BFA0", Offset = "0x80A5A0", VA = "0x18080BFA0")]
	public GKEOKIIGBCH(byte[] HKAAJCFANGC, int KJBKACPPODJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x346E9C0", Offset = "0x346CFC0", VA = "0x18346E9C0")]
	public static GKEOKIIGBCH ICOMJBHOLAC(GKEOKIIGBCH GNFIGHOBONH)
	{
		return default(GKEOKIIGBCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x346E820", Offset = "0x346CE20", VA = "0x18346E820")]
	public static GKEOKIIGBCH BNJHJDGNPLG(GKEOKIIGBCH GNFIGHOBONH, int GGLJPLLKLMG)
	{
		return default(GKEOKIIGBCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x346EA10", Offset = "0x346D010", VA = "0x18346EA10")]
	public static int ODGGBCCOGPF(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x346E880", Offset = "0x346CE80", VA = "0x18346E880")]
	public static bool FJEMBADJMEI(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x346E9A0", Offset = "0x346CFA0", VA = "0x18346E9A0")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x346E8A0", Offset = "0x346CEA0", VA = "0x18346E8A0")]
	public static bool FJEMBADJMEI(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x346E960", Offset = "0x346CF60", VA = "0x18346E960")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x346E960", Offset = "0x346CF60", VA = "0x18346E960")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, byte JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x346E9D0", Offset = "0x346CFD0", VA = "0x18346E9D0")]
	public static bool NGFDLBKKBOB(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x346E920", Offset = "0x346CF20", VA = "0x18346E920")]
	public static bool GMJAIIPFDPE(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x346E8E0", Offset = "0x346CEE0", VA = "0x18346E8E0")]
	public static bool GMHEFHCDCON(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x346EA30", Offset = "0x346D030", VA = "0x18346EA30")]
	public static bool PKCDJHCJECC(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class KAECGNBFICH
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] OMGAFJKMEOK;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] ELJFPNMKGAP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] DMEKMNBBIOK;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] CDODMOGBILN;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] POKNBECICAL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int PPOEGJMAHGM;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] ENEMMFIBLFL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int KEPJHDNBDHG;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x347C2D0", Offset = "0x347A8D0", VA = "0x18347C2D0")]
	private static byte[] DEKOJDJMHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x347C3B0", Offset = "0x347A9B0", VA = "0x18347C3B0")]
	private static byte[] HGHDBBBGEHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x347C4F0", Offset = "0x347AAF0", VA = "0x18347C4F0")]
	public static double IFNEAFFKEID(byte[] HKAAJCFANGC, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x347C210", Offset = "0x347A810", VA = "0x18347C210")]
	public static float CLICGOHMJEH(byte[] HKAAJCFANGC, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x347C090", Offset = "0x347A690", VA = "0x18347C090")]
	private static bool CJDNOPJFMCA(int KDNDPAEEMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x347D750", Offset = "0x347BD50", VA = "0x18347D750")]
	private static bool MMAGGLJNLBL(ref GKEOKIIGBCH IFKCAMEPHHB, GKEOKIIGBCH OHLDOAGOHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x347D630", Offset = "0x347BC30", VA = "0x18347D630")]
	private static bool IPBFCOOKKHL(ref GKEOKIIGBCH IFKCAMEPHHB, GKEOKIIGBCH OHLDOAGOHKP, byte[] EODJLEOKFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x347C490", Offset = "0x347AA90", VA = "0x18347C490")]
	private static bool IFLGFKBACJI(ref GKEOKIIGBCH FNELENENEHA, byte[] IOLGJHAFBKL, int KJBKACPPODJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xDB6200", Offset = "0xDB4800", VA = "0x180DB6200")]
	private static double BCLNFEHPOPE(bool DFJLNNJENJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x347C5B0", Offset = "0x347ABB0", VA = "0x18347C5B0")]
	private static double IMICNFCKHNM(GKEOKIIGBCH IOOJGDGEFAL, int GGLJPLLKLMG, bool KLBOCMHKLAG, out int EGCEENEMJOP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class OLJNJOELGPF<T> : global::CHGOEAEDIKB<T[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::GIDKKHOLMPJ<T> APMJLBFCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly FPCGCAFHCPC OJKNHIJCOFA;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x296B310", Offset = "0x2969910", VA = "0x18296B310")]
	public OLJNJOELGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1C64A70", Offset = "0x1C63070", VA = "0x181C64A70")]
	public OLJNJOELGPF(FPCGCAFHCPC OJKNHIJCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3A04EF0", Offset = "0x3A034F0", VA = "0x183A04EF0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3A06630", Offset = "0x3A04C30", VA = "0x183A06630", Slot = "5")]
	public T[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class JAOEMJKPGCH<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::GIDKKHOLMPJ<T> APMJLBFCBKG;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class FCDHNCJHIHO<T> : global::CHGOEAEDIKB<List<T>>, MKODBDPOJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly FPCGCAFHCPC OJKNHIJCOFA;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x296B310", Offset = "0x2969910", VA = "0x18296B310")]
	public FCDHNCJHIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1C64A70", Offset = "0x1C63070", VA = "0x181C64A70")]
	public FCDHNCJHIHO(FPCGCAFHCPC OJKNHIJCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x296A180", Offset = "0x2968780", VA = "0x18296A180", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, List<T> MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x296AA00", Offset = "0x2969000", VA = "0x18296AA00", Slot = "5")]
	public List<T> IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class PHCDJIKFGEC<TElement, TIntermediate, TEnumerator, TCollection> : global::CHGOEAEDIKB<TCollection>, MKODBDPOJMK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x30A7A20", Offset = "0x30A6020", VA = "0x1830A7A20", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TCollection MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x30A90D0", Offset = "0x30A76D0", VA = "0x1830A90D0", Slot = "5")]
	public TCollection IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator BGBEEAEAJCL(TCollection KEIJPKNBGAA);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GPCBEJLMGEM();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NENJMCKJAJO(ref TIntermediate DBAKNDFCOIL, int HOOANEAGKNH, TElement MPHFKGJNMOK);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection AKPIIOLAJBO(ref TIntermediate OAGOHGHOJMF);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	protected PHCDJIKFGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class HAJEABEMJKP<TElement, TIntermediate, TCollection> : global::PHCDJIKFGEC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CE10", Offset = "0x2F3B410", VA = "0x182F3CE10", Slot = "6")]
	protected override IEnumerator<TElement> BGBEEAEAJCL(TCollection KEIJPKNBGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x209F570", Offset = "0x209DB70", VA = "0x18209F570")]
	protected HAJEABEMJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class MLDBOOBKCAC<TElement, TCollection> : global::HAJEABEMJKP<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected sealed override TCollection AKPIIOLAJBO(ref TCollection OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ACOFAAGDAJB<TElement, TCollection> : global::MLDBOOBKCAC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x210B910", Offset = "0x2109F10", VA = "0x18210B910", Slot = "7")]
	protected override TCollection GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x210B930", Offset = "0x2109F30", VA = "0x18210B930", Slot = "8")]
	protected override void NENJMCKJAJO(ref TCollection DBAKNDFCOIL, int HOOANEAGKNH, TElement MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GOCOPCOHHJA<T> : global::PHCDJIKFGEC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C10", Offset = "0x31D2210", VA = "0x1831D3C10", Slot = "8")]
	protected override void NENJMCKJAJO(ref LinkedList<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override LinkedList<T> AKPIIOLAJBO(ref LinkedList<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override LinkedList<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x31D3BB0", Offset = "0x31D21B0", VA = "0x1831D3BB0", Slot = "6")]
	protected override LinkedList<T>.Enumerator BGBEEAEAJCL(LinkedList<T> KEIJPKNBGAA)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class EECBMJKHJKK<T> : global::PHCDJIKFGEC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C10", Offset = "0x31D2210", VA = "0x1831D3C10", Slot = "8")]
	protected override void NENJMCKJAJO(ref Queue<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override Queue<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E10", Offset = "0x22A5410", VA = "0x1822A6E10", Slot = "6")]
	protected override Queue<T>.Enumerator BGBEEAEAJCL(Queue<T> KEIJPKNBGAA)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override Queue<T> AKPIIOLAJBO(ref Queue<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LNGKJJBAMLJ<T> : global::PHCDJIKFGEC<T, global::CDAEICHCHHJ<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x20B7C90", Offset = "0x20B6290", VA = "0x1820B7C90", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E60", Offset = "0x22A5460", VA = "0x1822A6E60", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E10", Offset = "0x22A5410", VA = "0x1822A6E10", Slot = "6")]
	protected override Stack<T>.Enumerator BGBEEAEAJCL(Stack<T> KEIJPKNBGAA)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D30", Offset = "0x22A5330", VA = "0x1822A6D30", Slot = "9")]
	protected override Stack<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FAHICIMOLAN<T> : global::PHCDJIKFGEC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C10", Offset = "0x31D2210", VA = "0x1831D3C10", Slot = "8")]
	protected override void NENJMCKJAJO(ref HashSet<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override HashSet<T> AKPIIOLAJBO(ref HashSet<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override HashSet<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E10", Offset = "0x22A5410", VA = "0x1822A6E10", Slot = "6")]
	protected override HashSet<T>.Enumerator BGBEEAEAJCL(HashSet<T> KEIJPKNBGAA)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class HPIIMAAAPII<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x20B7C90", Offset = "0x20B6290", VA = "0x1820B7C90", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x20B7BB0", Offset = "0x20B61B0", VA = "0x1820B7BB0", Slot = "9")]
	protected override ReadOnlyCollection<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x20B7C40", Offset = "0x20B6240", VA = "0x1820B7C40", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GPCPINFCLIB<T> : global::HAJEABEMJKP<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C10", Offset = "0x31D2210", VA = "0x1831D3C10", Slot = "8")]
	protected override void NENJMCKJAJO(ref List<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override List<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override IList<T> AKPIIOLAJBO(ref List<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GIGCBPMJAAP<T> : global::HAJEABEMJKP<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C10", Offset = "0x31D2210", VA = "0x1831D3C10", Slot = "8")]
	protected override void NENJMCKJAJO(ref List<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override List<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override ICollection<T> AKPIIOLAJBO(ref List<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class CCBNDKCBLID<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x23CBFA0", Offset = "0x23CA5A0", VA = "0x1823CBFA0", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x23CBF00", Offset = "0x23CA500", VA = "0x1823CBF00", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x23CBEE0", Offset = "0x23CA4E0", VA = "0x1823CBEE0", Slot = "9")]
	protected override IEnumerable<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class DGDFINDPMGK<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class PNMHOHFLNOD<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class EFMCCGOEJEE<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GDPEGJNACLJ : global::CHGOEAEDIKB<IEnumerable>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::CHGOEAEDIKB<IEnumerable> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2899D90", Offset = "0x2898390", VA = "0x182899D90", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IEnumerable MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2899FF0", Offset = "0x28985F0", VA = "0x182899FF0", Slot = "5")]
	public IEnumerable IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GDPEGJNACLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class OFLOPFFEFLJ : global::CHGOEAEDIKB<ICollection>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::CHGOEAEDIKB<ICollection> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB8F0", Offset = "0x4DA9EF0", VA = "0x184DAB8F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ICollection MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4DABB90", Offset = "0x4DAA190", VA = "0x184DABB90", Slot = "5")]
	public ICollection IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OFLOPFFEFLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class HJJFAIEACPO : global::CHGOEAEDIKB<IList>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::CHGOEAEDIKB<IList> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3473ED0", Offset = "0x34724D0", VA = "0x183473ED0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IList MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3474170", Offset = "0x3472770", VA = "0x183474170", Slot = "5")]
	public IList IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HJJFAIEACPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LFEEDOKPLMB<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x287E8B0", Offset = "0x287CEB0", VA = "0x18287E8B0", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x22A6E60", Offset = "0x22A5460", VA = "0x1822A6E60", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x287E870", Offset = "0x287CE70", VA = "0x18287E870", Slot = "9")]
	protected override IReadOnlyList<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1C68820", Offset = "0x1C66E20", VA = "0x181C68820")]
	public LFEEDOKPLMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class BHFMGMAPKDK
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x288F1F0", Offset = "0x288D7F0", VA = "0x18288F1F0")]
	public static DateTime KDKCDOAFGFC(DateTime NOKIJJPGCEC)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OGLICBEHDKK : global::CHGOEAEDIKB<DateTime>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::CHGOEAEDIKB<DateTime> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4DABD70", Offset = "0x4DAA370", VA = "0x184DABD70", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, DateTime MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4DAC1C0", Offset = "0x4DAA7C0", VA = "0x184DAC1C0", Slot = "5")]
	public DateTime IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OGLICBEHDKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class MBGNIONBEGD : global::CHGOEAEDIKB<DateTimeOffset>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::CHGOEAEDIKB<DateTimeOffset> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA59D0", Offset = "0x4DA3FD0", VA = "0x184DA59D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, DateTimeOffset MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5DA0", Offset = "0x4DA43A0", VA = "0x184DA5DA0", Slot = "5")]
	public DateTimeOffset IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MBGNIONBEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class GAOOAKNBAGD : global::CHGOEAEDIKB<TimeSpan>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::CHGOEAEDIKB<TimeSpan> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] OGOMMGKMDDF;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2898E00", Offset = "0x2897400", VA = "0x182898E00", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TimeSpan MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x28992A0", Offset = "0x28978A0", VA = "0x1828992A0", Slot = "5")]
	public TimeSpan IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GAOOAKNBAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class LEPKBFACBLN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CHGOEAEDIKB<TDictionary>, MKODBDPOJMK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x38F4170", Offset = "0x38F2770", VA = "0x1838F4170", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TDictionary MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x38F78B0", Offset = "0x38F5EB0", VA = "0x1838F78B0", Slot = "5")]
	public TDictionary IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator BGBEEAEAJCL(TDictionary KEIJPKNBGAA);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GPCBEJLMGEM();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void NENJMCKJAJO(ref TIntermediate DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary AKPIIOLAJBO(ref TIntermediate OAGOHGHOJMF);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	protected LEPKBFACBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class IPCEIILJBCJ<TKey, TValue, TIntermediate, TDictionary> : global::LEPKBFACBLN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CE10", Offset = "0x2F3B410", VA = "0x182F3CE10", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> BGBEEAEAJCL(TDictionary KEIJPKNBGAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class DLDLONHNNIB<TKey, TValue, TDictionary> : global::IPCEIILJBCJ<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override TDictionary AKPIIOLAJBO(ref TDictionary OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class GFEDNOJBCAI<TKey, TValue> : global::LEPKBFACBLN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x32D2330", Offset = "0x32D0930", VA = "0x1832D2330", Slot = "8")]
	protected override void NENJMCKJAJO(ref Dictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override Dictionary<TKey, TValue> AKPIIOLAJBO(ref Dictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x32D22E0", Offset = "0x32D08E0", VA = "0x1832D22E0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator BGBEEAEAJCL(Dictionary<TKey, TValue> KEIJPKNBGAA)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1C6BCA0", Offset = "0x1C6A2A0", VA = "0x181C6BCA0")]
	public GFEDNOJBCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class CGEEPICIGPD<TKey, TValue, TDictionary> : global::DLDLONHNNIB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x23D23C0", Offset = "0x23D09C0", VA = "0x1823D23C0", Slot = "8")]
	protected override void NENJMCKJAJO(ref TDictionary DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x23D23A0", Offset = "0x23D09A0", VA = "0x1823D23A0", Slot = "7")]
	protected override TDictionary GPCBEJLMGEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class IGAELHMMLFJ<TKey, TValue> : global::IPCEIILJBCJ<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2F371A0", Offset = "0x2F357A0", VA = "0x182F371A0", Slot = "8")]
	protected override void NENJMCKJAJO(ref Dictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override IDictionary<TKey, TValue> AKPIIOLAJBO(ref Dictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class OOGPPDJPFMC<TKey, TValue> : global::DLDLONHNNIB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2F371A0", Offset = "0x2F357A0", VA = "0x182F371A0", Slot = "8")]
	protected override void NENJMCKJAJO(ref SortedList<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override SortedList<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class FAFFMBHFLDJ<TKey, TValue> : global::LEPKBFACBLN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2F371A0", Offset = "0x2F357A0", VA = "0x182F371A0", Slot = "8")]
	protected override void NENJMCKJAJO(ref SortedDictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xF81700", Offset = "0xF7FD00", VA = "0x180F81700", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> AKPIIOLAJBO(ref SortedDictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2F37140", Offset = "0x2F35740", VA = "0x182F37140", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x4334320", Offset = "0x4332920", VA = "0x184334320", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator BGBEEAEAJCL(SortedDictionary<TKey, TValue> KEIJPKNBGAA)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class LNKDPCFJPCN<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class PAMAIKMMIOM : global::CHGOEAEDIKB<IDictionary>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::CHGOEAEDIKB<IDictionary> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x4DADCA0", Offset = "0x4DAC2A0", VA = "0x184DADCA0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IDictionary MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE020", Offset = "0x4DAC620", VA = "0x184DAE020", Slot = "5")]
	public IDictionary IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public PAMAIKMMIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class APBLDOJLDOE : global::CHGOEAEDIKB<object>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void LDHJDPKHPNP(object KALCDHMJAKI, ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::JHPNJCCNEJI<KeyValuePair<object, LDHJDPKHPNP>> EADEHHIIILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly IHNIPBDLGGD[] PONJFHCADKN;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x288DDD0", Offset = "0x288C3D0", VA = "0x18288DDD0")]
	public APBLDOJLDOE(params IHNIPBDLGGD[] PONJFHCADKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x288D3D0", Offset = "0x288B9D0", VA = "0x18288D3D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x288DD40", Offset = "0x288C340", VA = "0x18288DD40", Slot = "5")]
	public object IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EHMCPLGOAGI
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2895E10", Offset = "0x2894410", VA = "0x182895E10")]
	public static object LAJHCLCCLFA(Type ONIHNDBDHGC, out bool HHDNKNNDMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2895630", Offset = "0x2893C30", VA = "0x182895630")]
	public static object AAFPBEADCDM(Type ONIHNDBDHGC, out bool HHDNKNNDMOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class NCGGMPGGABE<T> : global::CHGOEAEDIKB<T>, MKODBDPOJMK, global::NMJJJPGKCNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ILPKOOLLNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public ILPKOOLLNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3150840", Offset = "0x314EE40", VA = "0x183150840")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class HIABHPIAIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::FLDPJJAEEPN<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public HIABHPIAIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x314E9C0", Offset = "0x314CFC0", VA = "0x18314E9C0")]
		internal void <.cctor>b__1(ref BFLLELOAEDL writer, T value, IHNIPBDLGGD _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class EKKGDBPDDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::FDIOKMHEKJP<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public EKKGDBPDDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x314CA80", Offset = "0x314B080", VA = "0x18314CA80")]
		internal T <.cctor>b__2(ref IOOLDPGGJIO reader, IHNIPBDLGGD _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::EGMPBFEECFD<T> CNILBENNJHD;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> OGAFEEBLDPL;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::FLDPJJAEEPN<T> NPGHGNIHPMH;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::FDIOKMHEKJP<T> HNMNEKAFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool EPLMIALLCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::FLDPJJAEEPN<T> HFLFBLNOIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::FDIOKMHEKJP<T> NAFDFLMANJD;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x315CAD0", Offset = "0x315B0D0", VA = "0x18315CAD0")]
	static NCGGMPGGABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3161350", Offset = "0x315F950", VA = "0x183161350")]
	public NCGGMPGGABE(bool EPLMIALLCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x315B3D0", Offset = "0x31599D0", VA = "0x18315B3D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x315C1C0", Offset = "0x315A7C0", VA = "0x18315C1C0", Slot = "5")]
	public T IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x315AC30", Offset = "0x3159230", VA = "0x18315AC30", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x315C980", Offset = "0x315AF80", VA = "0x18315C980", Slot = "7")]
	public T NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ANBNKDOBEKJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class HMCLNFOJHIP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class GGHELKAJCOA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class BMCCIOHGKFA<T> : global::CHGOEAEDIKB<T?>, MKODBDPOJMK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3C30", Offset = "0x2FD2230", VA = "0x182FD3C30", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3D90", Offset = "0x2FD2390", VA = "0x182FD3D90", Slot = "5")]
	public T? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	public BMCCIOHGKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class NAGNDDHEKOG<T> : global::CHGOEAEDIKB<T?>, MKODBDPOJMK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::CHGOEAEDIKB<T> OMOOBBJDLEN;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
	public NAGNDDHEKOG(global::CHGOEAEDIKB<T> OMOOBBJDLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3158960", Offset = "0x3156F60", VA = "0x183158960", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x31592F0", Offset = "0x31578F0", VA = "0x1831592F0", Slot = "5")]
	public T? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class PPPCNJIJHMK : global::CHGOEAEDIKB<sbyte>, MKODBDPOJMK, global::NMJJJPGKCNG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly PPPCNJIJHMK KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF4F0", Offset = "0x4DADAF0", VA = "0x184DAF4F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF510", Offset = "0x4DADB10", VA = "0x184DAF510", Slot = "5")]
	public sbyte IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF4B0", Offset = "0x4DADAB0", VA = "0x184DAF4B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, sbyte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF520", Offset = "0x4DADB20", VA = "0x184DAF520", Slot = "7")]
	public sbyte NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public PPPCNJIJHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class EPMLHOMLFPD : global::CHGOEAEDIKB<sbyte?>, MKODBDPOJMK, global::NMJJJPGKCNG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly EPMLHOMLFPD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x28969B0", Offset = "0x2894FB0", VA = "0x1828969B0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2896A30", Offset = "0x2895030", VA = "0x182896A30", Slot = "5")]
	public sbyte? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x28968B0", Offset = "0x2894EB0", VA = "0x1828968B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, sbyte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2896AA0", Offset = "0x28950A0", VA = "0x182896AA0", Slot = "7")]
	public sbyte? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EPMLHOMLFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class FKIFBHIGJLJ : global::CHGOEAEDIKB<sbyte[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly FKIFBHIGJLJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x28980E0", Offset = "0x28966E0", VA = "0x1828980E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2898280", Offset = "0x2896880", VA = "0x182898280", Slot = "5")]
	public sbyte[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public FKIFBHIGJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class NJGMOCMKONI : global::CHGOEAEDIKB<short>, MKODBDPOJMK, global::NMJJJPGKCNG<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly NJGMOCMKONI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8FF0", Offset = "0x4DA75F0", VA = "0x184DA8FF0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9010", Offset = "0x4DA7610", VA = "0x184DA9010", Slot = "5")]
	public short IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8FB0", Offset = "0x4DA75B0", VA = "0x184DA8FB0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, short MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9020", Offset = "0x4DA7620", VA = "0x184DA9020", Slot = "7")]
	public short NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NJGMOCMKONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class DEHHBNKCJDB : global::CHGOEAEDIKB<short?>, MKODBDPOJMK, global::NMJJJPGKCNG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly DEHHBNKCJDB KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2890FD0", Offset = "0x288F5D0", VA = "0x182890FD0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2891050", Offset = "0x288F650", VA = "0x182891050", Slot = "5")]
	public short? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2890ED0", Offset = "0x288F4D0", VA = "0x182890ED0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, short? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x28910C0", Offset = "0x288F6C0", VA = "0x1828910C0", Slot = "7")]
	public short? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public DEHHBNKCJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LJCMDOMFENP : global::CHGOEAEDIKB<short[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly LJCMDOMFENP KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x347F3B0", Offset = "0x347D9B0", VA = "0x18347F3B0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x347F470", Offset = "0x347DA70", VA = "0x18347F470", Slot = "5")]
	public short[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public LJCMDOMFENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class AGBCOINIOCJ : global::CHGOEAEDIKB<int>, MKODBDPOJMK, global::NMJJJPGKCNG<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly AGBCOINIOCJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2889B70", Offset = "0x2888170", VA = "0x182889B70", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2889BA0", Offset = "0x28881A0", VA = "0x182889BA0", Slot = "5")]
	public int IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2889AB0", Offset = "0x28880B0", VA = "0x182889AB0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, int MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2889BB0", Offset = "0x28881B0", VA = "0x182889BB0", Slot = "7")]
	public int NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public AGBCOINIOCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class PKLMOOAKJNM : global::CHGOEAEDIKB<int?>, MKODBDPOJMK, global::NMJJJPGKCNG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly PKLMOOAKJNM KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEFC0", Offset = "0x4DAD5C0", VA = "0x184DAEFC0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF030", Offset = "0x4DAD630", VA = "0x184DAF030", Slot = "5")]
	public int? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4DAEF40", Offset = "0x4DAD540", VA = "0x184DAEF40", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, int? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DAF0A0", Offset = "0x4DAD6A0", VA = "0x184DAF0A0", Slot = "7")]
	public int? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public PKLMOOAKJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class ALIIOKEABIG : global::CHGOEAEDIKB<int[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ALIIOKEABIG KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x288B110", Offset = "0x2889710", VA = "0x18288B110", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x288B2B0", Offset = "0x28898B0", VA = "0x18288B2B0", Slot = "5")]
	public int[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public ALIIOKEABIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class IAHCLILINAG : global::CHGOEAEDIKB<long>, MKODBDPOJMK, global::NMJJJPGKCNG<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IAHCLILINAG KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x34764A0", Offset = "0x3474AA0", VA = "0x1834764A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x34764C0", Offset = "0x3474AC0", VA = "0x1834764C0", Slot = "5")]
	public long IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3476460", Offset = "0x3474A60", VA = "0x183476460", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, long MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x34764D0", Offset = "0x3474AD0", VA = "0x1834764D0", Slot = "7")]
	public long NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public IAHCLILINAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class NHFFBKIENKI : global::CHGOEAEDIKB<long?>, MKODBDPOJMK, global::NMJJJPGKCNG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly NHFFBKIENKI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8AE0", Offset = "0x4DA70E0", VA = "0x184DA8AE0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8B50", Offset = "0x4DA7150", VA = "0x184DA8B50", Slot = "5")]
	public long? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8A60", Offset = "0x4DA7060", VA = "0x184DA8A60", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, long? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8BE0", Offset = "0x4DA71E0", VA = "0x184DA8BE0", Slot = "7")]
	public long? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NHFFBKIENKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class DEOMDGDCKDJ : global::CHGOEAEDIKB<long[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly DEOMDGDCKDJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2893370", Offset = "0x2891970", VA = "0x182893370", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2893510", Offset = "0x2891B10", VA = "0x182893510", Slot = "5")]
	public long[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public DEOMDGDCKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class EHCBLOGHFCP : global::CHGOEAEDIKB<byte>, MKODBDPOJMK, global::NMJJJPGKCNG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly EHCBLOGHFCP KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2895480", Offset = "0x2893A80", VA = "0x182895480", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x28954C0", Offset = "0x2893AC0", VA = "0x1828954C0", Slot = "5")]
	public byte IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x28953C0", Offset = "0x28939C0", VA = "0x1828953C0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, byte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x28954D0", Offset = "0x2893AD0", VA = "0x1828954D0", Slot = "7")]
	public byte NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EHCBLOGHFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PDPJIHDBJKC : global::CHGOEAEDIKB<byte?>, MKODBDPOJMK, global::NMJJJPGKCNG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly PDPJIHDBJKC KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE3E0", Offset = "0x4DAC9E0", VA = "0x184DAE3E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE450", Offset = "0x4DACA50", VA = "0x184DAE450", Slot = "5")]
	public byte? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE360", Offset = "0x4DAC960", VA = "0x184DAE360", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, byte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE4C0", Offset = "0x4DACAC0", VA = "0x184DAE4C0", Slot = "7")]
	public byte? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public PDPJIHDBJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class ADPLNAOFHGD : global::CHGOEAEDIKB<ushort>, MKODBDPOJMK, global::NMJJJPGKCNG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly ADPLNAOFHGD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x28896B0", Offset = "0x2887CB0", VA = "0x1828896B0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x28896F0", Offset = "0x2887CF0", VA = "0x1828896F0", Slot = "5")]
	public ushort IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x28895F0", Offset = "0x2887BF0", VA = "0x1828895F0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ushort MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2889700", Offset = "0x2887D00", VA = "0x182889700", Slot = "7")]
	public ushort NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public ADPLNAOFHGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class NBIDNCBCPJA : global::CHGOEAEDIKB<ushort?>, MKODBDPOJMK, global::NMJJJPGKCNG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NBIDNCBCPJA KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA81F0", Offset = "0x4DA67F0", VA = "0x184DA81F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8260", Offset = "0x4DA6860", VA = "0x184DA8260", Slot = "5")]
	public ushort? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8170", Offset = "0x4DA6770", VA = "0x184DA8170", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ushort? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA82D0", Offset = "0x4DA68D0", VA = "0x184DA82D0", Slot = "7")]
	public ushort? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NBIDNCBCPJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class MDDOMMAFGKD : global::CHGOEAEDIKB<ushort[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly MDDOMMAFGKD KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6DA0", Offset = "0x4DA53A0", VA = "0x184DA6DA0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6E60", Offset = "0x4DA5460", VA = "0x184DA6E60", Slot = "5")]
	public ushort[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MDDOMMAFGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class DAHLJGFLMIO : global::CHGOEAEDIKB<uint>, MKODBDPOJMK, global::NMJJJPGKCNG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly DAHLJGFLMIO KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2890C70", Offset = "0x288F270", VA = "0x182890C70", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2890CA0", Offset = "0x288F2A0", VA = "0x182890CA0", Slot = "5")]
	public uint IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2890BB0", Offset = "0x288F1B0", VA = "0x182890BB0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, uint MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2890CB0", Offset = "0x288F2B0", VA = "0x182890CB0", Slot = "7")]
	public uint NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public DAHLJGFLMIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KBACNMDMLDJ : global::CHGOEAEDIKB<uint?>, MKODBDPOJMK, global::NMJJJPGKCNG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly KBACNMDMLDJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x347DB20", Offset = "0x347C120", VA = "0x18347DB20", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x347DB90", Offset = "0x347C190", VA = "0x18347DB90", Slot = "5")]
	public uint? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x347DAA0", Offset = "0x347C0A0", VA = "0x18347DAA0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, uint? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x347DC40", Offset = "0x347C240", VA = "0x18347DC40", Slot = "7")]
	public uint? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public KBACNMDMLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BHGHKPHCIGG : global::CHGOEAEDIKB<uint[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly BHGHKPHCIGG KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x288F290", Offset = "0x288D890", VA = "0x18288F290", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x288F430", Offset = "0x288DA30", VA = "0x18288F430", Slot = "5")]
	public uint[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public BHGHKPHCIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class OMOINCMGLPI : global::CHGOEAEDIKB<ulong>, MKODBDPOJMK, global::NMJJJPGKCNG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly OMOINCMGLPI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD7F0", Offset = "0x4DABDF0", VA = "0x184DAD7F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD810", Offset = "0x4DABE10", VA = "0x184DAD810", Slot = "5")]
	public ulong IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD7B0", Offset = "0x4DABDB0", VA = "0x184DAD7B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ulong MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD820", Offset = "0x4DABE20", VA = "0x184DAD820", Slot = "7")]
	public ulong NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OMOINCMGLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class MGHHGGKBLBM : global::CHGOEAEDIKB<ulong?>, MKODBDPOJMK, global::NMJJJPGKCNG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly MGHHGGKBLBM KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7080", Offset = "0x4DA5680", VA = "0x184DA7080", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4DA70F0", Offset = "0x4DA56F0", VA = "0x184DA70F0", Slot = "5")]
	public ulong? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7000", Offset = "0x4DA5600", VA = "0x184DA7000", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ulong? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7180", Offset = "0x4DA5780", VA = "0x184DA7180", Slot = "7")]
	public ulong? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MGHHGGKBLBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class ADJJKNBNMGG : global::CHGOEAEDIKB<ulong[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly ADJJKNBNMGG KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x28892B0", Offset = "0x28878B0", VA = "0x1828892B0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2889450", Offset = "0x2887A50", VA = "0x182889450", Slot = "5")]
	public ulong[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public ADJJKNBNMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class EBBEEMEDIOJ : global::CHGOEAEDIKB<float>, MKODBDPOJMK, global::NMJJJPGKCNG<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly EBBEEMEDIOJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2894EA0", Offset = "0x28934A0", VA = "0x182894EA0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2894EB0", Offset = "0x28934B0", VA = "0x182894EB0", Slot = "5")]
	public float IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2894DF0", Offset = "0x28933F0", VA = "0x182894DF0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, float MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2894EC0", Offset = "0x28934C0", VA = "0x182894EC0", Slot = "7")]
	public float NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EBBEEMEDIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class OLLNPFFLDOE : global::CHGOEAEDIKB<float?>, MKODBDPOJMK, global::NMJJJPGKCNG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly OLLNPFFLDOE KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD5D0", Offset = "0x4DABBD0", VA = "0x184DAD5D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD640", Offset = "0x4DABC40", VA = "0x184DAD640", Slot = "5")]
	public float? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD550", Offset = "0x4DABB50", VA = "0x184DAD550", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, float? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD6B0", Offset = "0x4DABCB0", VA = "0x184DAD6B0", Slot = "7")]
	public float? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OLLNPFFLDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LJHLHDBDABB : global::CHGOEAEDIKB<float[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly LJHLHDBDABB KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x347F670", Offset = "0x347DC70", VA = "0x18347F670", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x347F730", Offset = "0x347DD30", VA = "0x18347F730", Slot = "5")]
	public float[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public LJHLHDBDABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class BPDDCGMIJKL : global::CHGOEAEDIKB<double>, MKODBDPOJMK, global::NMJJJPGKCNG<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly BPDDCGMIJKL KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x288FEC0", Offset = "0x288E4C0", VA = "0x18288FEC0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x288FED0", Offset = "0x288E4D0", VA = "0x18288FED0", Slot = "5")]
	public double IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x288FE10", Offset = "0x288E410", VA = "0x18288FE10", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, double MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x288FEE0", Offset = "0x288E4E0", VA = "0x18288FEE0", Slot = "7")]
	public double NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public BPDDCGMIJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class NGDFCEOLOEI : global::CHGOEAEDIKB<double?>, MKODBDPOJMK, global::NMJJJPGKCNG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly NGDFCEOLOEI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8450", Offset = "0x4DA6A50", VA = "0x184DA8450", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4DA84C0", Offset = "0x4DA6AC0", VA = "0x184DA84C0", Slot = "5")]
	public double? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4DA83D0", Offset = "0x4DA69D0", VA = "0x184DA83D0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, double? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8550", Offset = "0x4DA6B50", VA = "0x184DA8550", Slot = "7")]
	public double? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NGDFCEOLOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class GOGFDNDDKGI : global::CHGOEAEDIKB<double[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly GOGFDNDDKGI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x34708E0", Offset = "0x346EEE0", VA = "0x1834708E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x34709A0", Offset = "0x346EFA0", VA = "0x1834709A0", Slot = "5")]
	public double[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GOGFDNDDKGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LGCINGNIEEO : global::CHGOEAEDIKB<bool>, MKODBDPOJMK, global::NMJJJPGKCNG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LGCINGNIEEO KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x347F1C0", Offset = "0x347D7C0", VA = "0x18347F1C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x347F1E0", Offset = "0x347D7E0", VA = "0x18347F1E0", Slot = "5")]
	public bool IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x347F180", Offset = "0x347D780", VA = "0x18347F180", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, bool MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x347F1F0", Offset = "0x347D7F0", VA = "0x18347F1F0", Slot = "7")]
	public bool NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public LGCINGNIEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NGLOGHHDLCI : global::CHGOEAEDIKB<bool?>, MKODBDPOJMK, global::NMJJJPGKCNG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NGLOGHHDLCI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8870", Offset = "0x4DA6E70", VA = "0x184DA8870", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4DA88E0", Offset = "0x4DA6EE0", VA = "0x184DA88E0", Slot = "5")]
	public bool? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4DA87F0", Offset = "0x4DA6DF0", VA = "0x184DA87F0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, bool? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8950", Offset = "0x4DA6F50", VA = "0x184DA8950", Slot = "7")]
	public bool? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NGLOGHHDLCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DFGEHHFNKFB : global::CHGOEAEDIKB<bool[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DFGEHHFNKFB KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x28938A0", Offset = "0x2891EA0", VA = "0x1828938A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2893A20", Offset = "0x2892020", VA = "0x182893A20", Slot = "5")]
	public bool[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public DFGEHHFNKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class FHJHIBOONFM : global::CHGOEAEDIKB<object>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::CHGOEAEDIKB<object> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> CAFFKCPMKAK;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2897040", Offset = "0x2895640", VA = "0x182897040", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x28979F0", Offset = "0x2895FF0", VA = "0x1828979F0", Slot = "5")]
	public object IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public FHJHIBOONFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class NJFKHNOIOFF : global::CHGOEAEDIKB<byte[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::CHGOEAEDIKB<byte[]> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8E40", Offset = "0x4DA7440", VA = "0x184DA8E40", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8ED0", Offset = "0x4DA74D0", VA = "0x184DA8ED0", Slot = "5")]
	public byte[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NJFKHNOIOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class MJIMBHEFBID : global::CHGOEAEDIKB<ArraySegment<byte>>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::CHGOEAEDIKB<ArraySegment<byte>> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7510", Offset = "0x4DA5B10", VA = "0x184DA7510", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ArraySegment<byte> MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x4DA75B0", Offset = "0x4DA5BB0", VA = "0x184DA75B0", Slot = "5")]
	public ArraySegment<byte> IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MJIMBHEFBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BLLBHCMJHII : global::CHGOEAEDIKB<string>, MKODBDPOJMK, global::NMJJJPGKCNG<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::CHGOEAEDIKB<string> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x288FD80", Offset = "0x288E380", VA = "0x18288FD80", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, string MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x288FDA0", Offset = "0x288E3A0", VA = "0x18288FDA0", Slot = "5")]
	public string IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x288FD80", Offset = "0x288E380", VA = "0x18288FD80", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, string MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x288FDA0", Offset = "0x288E3A0", VA = "0x18288FDA0", Slot = "7")]
	public string NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public BLLBHCMJHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HPLLPNIFJPO : global::CHGOEAEDIKB<string[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly HPLLPNIFJPO KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x34761A0", Offset = "0x34747A0", VA = "0x1834761A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, string[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3474860", VA = "0x183476260", Slot = "5")]
	public string[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HPLLPNIFJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class HAOCNJONJEJ : global::CHGOEAEDIKB<char>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly HAOCNJONJEJ KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x3471CE0", Offset = "0x34702E0", VA = "0x183471CE0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3471D60", Offset = "0x3470360", VA = "0x183471D60", Slot = "5")]
	public char IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HAOCNJONJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class LPBAFFEMJEP : global::CHGOEAEDIKB<char?>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly LPBAFFEMJEP KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4DA57E0", Offset = "0x4DA3DE0", VA = "0x184DA57E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4DA58B0", Offset = "0x4DA3EB0", VA = "0x184DA58B0", Slot = "5")]
	public char? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public LPBAFFEMJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class OHJFAJMDHBI : global::CHGOEAEDIKB<char[]>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly OHJFAJMDHBI KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD120", Offset = "0x4DAB720", VA = "0x184DAD120", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD2A0", Offset = "0x4DAB8A0", VA = "0x184DAD2A0", Slot = "5")]
	public char[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public OHJFAJMDHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class MLFOBBDBHDJ : global::CHGOEAEDIKB<Guid>, MKODBDPOJMK, global::NMJJJPGKCNG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::CHGOEAEDIKB<Guid> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7900", Offset = "0x4DA5F00", VA = "0x184DA7900", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Guid MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA79E0", Offset = "0x4DA5FE0", VA = "0x184DA79E0", Slot = "5")]
	public Guid IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7820", Offset = "0x4DA5E20", VA = "0x184DA7820", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, Guid MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4DA79E0", Offset = "0x4DA5FE0", VA = "0x184DA79E0", Slot = "7")]
	public Guid NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MLFOBBDBHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class IJCEGKAJEIJ : global::CHGOEAEDIKB<decimal>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::CHGOEAEDIKB<decimal> KAKLFEMJBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool FEIFBPHLOHB;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xBAD490", Offset = "0xBABA90", VA = "0x180BAD490")]
	public IJCEGKAJEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xCFCD10", Offset = "0xCFB310", VA = "0x180CFCD10")]
	public IJCEGKAJEIJ(bool FEIFBPHLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x34770E0", Offset = "0x34756E0", VA = "0x1834770E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, decimal MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x3477220", Offset = "0x3475820", VA = "0x183477220", Slot = "5")]
	public decimal IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CBKDDFDECMA : global::CHGOEAEDIKB<Uri>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::CHGOEAEDIKB<Uri> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x288FFB0", Offset = "0x288E5B0", VA = "0x18288FFB0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Uri MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2890060", Offset = "0x288E660", VA = "0x182890060", Slot = "5")]
	public Uri IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public CBKDDFDECMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class GJCOAIDLDKJ : global::CHGOEAEDIKB<Version>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::CHGOEAEDIKB<Version> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x346E040", Offset = "0x346C640", VA = "0x18346E040", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Version MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x346E0F0", Offset = "0x346C6F0", VA = "0x18346E0F0", Slot = "5")]
	public Version IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GJCOAIDLDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class KCHGNDBBMCD<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EEAAJCIGCLD : global::CHGOEAEDIKB<StringBuilder>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::CHGOEAEDIKB<StringBuilder> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x28951E0", Offset = "0x28937E0", VA = "0x1828951E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, StringBuilder MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2895230", Offset = "0x2893830", VA = "0x182895230", Slot = "5")]
	public StringBuilder IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EEAAJCIGCLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class CFIDIJAFPMF : global::CHGOEAEDIKB<BitArray>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::CHGOEAEDIKB<BitArray> KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x28902C0", Offset = "0x288E8C0", VA = "0x1828902C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, BitArray MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x28903C0", Offset = "0x288E9C0", VA = "0x1828903C0", Slot = "5")]
	public BitArray IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public CFIDIJAFPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class CGPFBJPKMOA : global::CHGOEAEDIKB<Type>, MKODBDPOJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly CGPFBJPKMOA KAKLFEMJBPO;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex GKBAKNLNDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool IMDHIECDLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool HILNFOOBCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool CEMAFOCGOIO;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2890960", Offset = "0x288EF60", VA = "0x182890960")]
	public CGPFBJPKMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2890910", Offset = "0x288EF10", VA = "0x182890910")]
	public CGPFBJPKMOA(bool IMDHIECDLNM, bool HILNFOOBCEP, bool CEMAFOCGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2890660", Offset = "0x288EC60", VA = "0x182890660", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Type MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2890750", Offset = "0x288ED50", VA = "0x182890750", Slot = "5")]
	public Type IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
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
