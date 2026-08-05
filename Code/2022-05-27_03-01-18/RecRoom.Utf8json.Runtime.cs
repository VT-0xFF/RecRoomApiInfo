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
	[Cpp2IlInjected.Address(RVA = "0x5AADA0", Offset = "0x5A9DA0", VA = "0x1805AADA0")]
	public HEICIEPPEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NNMFDPLENEI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA0", Offset = "0x5A9DA0", VA = "0x1805AADA0")]
	public NNMFDPLENEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FBHHBNPELEA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA0", Offset = "0x5A9DA0", VA = "0x1805AADA0")]
	public FBHHBNPELEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class IFELBPHGLHN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5AADA0", Offset = "0x5A9DA0", VA = "0x1805AADA0")]
	public IFELBPHGLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DNFKNMMCOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBD44C0", Offset = "0xBD34C0", VA = "0x180BD44C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] NMHECDFAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0B0", Offset = "0x7EE0B0", VA = "0x1807EF0B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x32DE7A0", Offset = "0x32DD7A0", VA = "0x1832DE7A0")]
	public static global::CHGOEAEDIKB<T> GJNNJHOLLCI<T>(this IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xBD0540", Offset = "0xBCF540", VA = "0x180BD0540")]
	public static object LJHCALIFJOI(this IHNIPBDLGGD BGBEOCLNGLJ, Type ONIHNDBDHGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JCAIOMBJAKG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x14C0FA0", Offset = "0x14BFFA0", VA = "0x1814C0FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14AFE60", Offset = "0x14AEE60", VA = "0x1814AFE60")]
		public static byte[] DEKOJDJMHGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x14AFEE0", Offset = "0x14AEEE0", VA = "0x1814AFEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BE800", Offset = "0x14BD800", VA = "0x1814BE800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x14BFB10", Offset = "0x14BEB10", VA = "0x1814BFB10")]
	public IOOLDPGGJIO(byte[] KFCJKMJDFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x14BFB20", Offset = "0x14BEB20", VA = "0x1814BFB20")]
	public IOOLDPGGJIO(byte[] KFCJKMJDFKE, int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x14BF240", Offset = "0x14BE240", VA = "0x1814BF240")]
	private AJAFKPAHHHF LPMPFAOIPKG(string JNHAOKCIHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14BD1E0", Offset = "0x14BC1E0", VA = "0x1814BD1E0")]
	private AJAFKPAHHHF DEMHAKNOFEJ(string EPAKPJCIEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xBCE970", Offset = "0xBCD970", VA = "0x180BCE970")]
	public void EDMFEBGBCLN(int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x698DA0", Offset = "0x697DA0", VA = "0x180698DA0")]
	public byte[] ANLCBLJHBIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B9730", Offset = "0x7B8730", VA = "0x1807B9730")]
	public int GHHLDEKGCJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x14BE1C0", Offset = "0x14BD1C0", VA = "0x1814BE1C0")]
	public PKLNMNEJKMG IOKHOEJFANM()
	{
		return default(PKLNMNEJKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x14BF7B0", Offset = "0x14BE7B0", VA = "0x1814BF7B0")]
	public void MGBGCFBJAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x14BD470", Offset = "0x14BC470", VA = "0x1814BD470")]
	public bool EIDLCOIBNLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x14BD2C0", Offset = "0x14BC2C0", VA = "0x1814BD2C0")]
	public bool DOEALCBHJHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x14BD050", Offset = "0x14BC050", VA = "0x1814BD050")]
	public void BPCEHELAHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x14BDB40", Offset = "0x14BCB40", VA = "0x1814BDB40")]
	public bool GAJAKINPFHD(ref int DHNBJNKGAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x14BF970", Offset = "0x14BE970", VA = "0x1814BF970")]
	public bool PFLNJCGGCMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x14BD590", Offset = "0x14BC590", VA = "0x1814BD590")]
	public void EJBGKEHJCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x14BF080", Offset = "0x14BE080", VA = "0x1814BF080")]
	public bool LHNNKMINANN(ref int DHNBJNKGAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x14BE880", Offset = "0x14BD880", VA = "0x1814BE880")]
	public bool LEIJCCNDBPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14BE760", Offset = "0x14BD760", VA = "0x1814BE760")]
	public void KHEKFAAAMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x14BDDA0", Offset = "0x14BCDA0", VA = "0x1814BDDA0")]
	public bool HAGAMNNJKIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14BDED0", Offset = "0x14BCED0", VA = "0x1814BDED0")]
	public void HCJGBJCJCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x14BE8F0", Offset = "0x14BD8F0", VA = "0x1814BE8F0")]
	private void LGBIIGGCLFH(out byte[] HMCLMNFAJOL, out int EBHBGKNMNEM, out int NEMMMEBFEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x14BE350", Offset = "0x14BD350", VA = "0x1814BE350")]
	private static int IPCJDLFFADG(char NCGEKBENJBA, char IIFMPDAMAIA, char AHENHIDOBEA, char CGNILIACKIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x14BF6E0", Offset = "0x14BE6E0", VA = "0x1814BF6E0")]
	private static int LPNDBOAHMBD(char KDNDPAEEMPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14BD0F0", Offset = "0x14BC0F0", VA = "0x1814BD0F0")]
	public ArraySegment<byte> CCHGKEDCHLC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14BE120", Offset = "0x14BD120", VA = "0x1814BE120")]
	public string INFADKCFFPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14BD020", Offset = "0x14BC020", VA = "0x1814BD020")]
	public string BANLLOJGIBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14BDF70", Offset = "0x14BCF70", VA = "0x1814BDF70")]
	public ArraySegment<byte> IAPLLEOEOHH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14BCFE0", Offset = "0x14BBFE0", VA = "0x1814BCFE0")]
	public ArraySegment<byte> AHIBADFNBNC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x14BD810", Offset = "0x14BC810", VA = "0x1814BD810")]
	public bool FBCOPIEIEPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x14BDE10", Offset = "0x14BCE10", VA = "0x1814BDE10")]
	private static bool HBILFBPOFDI(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x14BE400", Offset = "0x14BD400", VA = "0x1814BE400")]
	private void JPHJILHNJGL(PKLNMNEJKMG GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14BE630", Offset = "0x14BD630", VA = "0x1814BE630")]
	public void KDGCILECFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14BDA70", Offset = "0x14BCA70", VA = "0x1814BDA70")]
	private void FPIAKNCHIJD(int GDLAKOPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x14BF9E0", Offset = "0x14BE9E0", VA = "0x1814BF9E0")]
	public sbyte PJCGOJJOCBK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14BDBD0", Offset = "0x14BCBD0", VA = "0x1814BDBD0")]
	public short GAPLLDKLEID()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14BE820", Offset = "0x14BD820", VA = "0x1814BE820")]
	public int LEANGICBMPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x14BDC90", Offset = "0x14BCC90", VA = "0x1814BDC90")]
	public long GKMKBANOJIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x14BE5D0", Offset = "0x14BD5D0", VA = "0x1814BE5D0")]
	public byte KCPBODNFLBD()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x14BD630", Offset = "0x14BC630", VA = "0x1814BD630")]
	public ushort EJJGFBICOJP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x14BDC30", Offset = "0x14BCC30", VA = "0x1814BDC30")]
	public uint GHIGFJHGFLL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x14BF8F0", Offset = "0x14BE8F0", VA = "0x1814BF8F0")]
	public ulong NCFNCPMJIII()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x14BD330", Offset = "0x14BC330", VA = "0x1814BD330")]
	public float EAHNPLKCOGI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x14BF110", Offset = "0x14BE110", VA = "0x1814BF110")]
	public double LNIAIEFDMPM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x14BE640", Offset = "0x14BD640", VA = "0x1814BE640")]
	public ArraySegment<byte> KEOOFOJLDNB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14BD690", Offset = "0x14BC690", VA = "0x1814BD690")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCAFC0", Offset = "0xBC9FC0", VA = "0x180BCAFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JNGOGNMICHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78AA30", Offset = "0x789A30", VA = "0x18078AA30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xBCB0A0", Offset = "0xBCA0A0", VA = "0x180BCB0A0")]
	public AJAFKPAHHHF(string EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xBCAFD0", Offset = "0xBC9FD0", VA = "0x180BCAFD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
				public CCKPKNKGKBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x14B03E0", Offset = "0x14AF3E0", VA = "0x1814B03E0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x14B0420", Offset = "0x14AF420", VA = "0x1814B0420")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C5EC0", Offset = "0x14C4EC0", VA = "0x1814C5EC0")]
			public ONMKNMPCMBI(Type ONIHNDBDHGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3174D20", Offset = "0x3173D20", VA = "0x183174D20")]
			private static T PEPLOGDBAKE<T>(DynamicMethod CFBBCIHBFGC)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x14C5CD0", Offset = "0x14C4CD0", VA = "0x1814C5CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C5BE0", Offset = "0x14C4BE0", VA = "0x1814C5BE0")]
		static OAIJHJCAGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x14C5B60", Offset = "0x14C4B60", VA = "0x1814C5B60")]
		private static ONMKNMPCMBI GPHBEMBAHLO(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x14C59F0", Offset = "0x14C49F0", VA = "0x1814C59F0")]
		public static void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x14C58E0", Offset = "0x14C48E0", VA = "0x1814C58E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B0100", Offset = "0x14AF100", VA = "0x1814B0100")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C3D20", Offset = "0x14C2D20", VA = "0x1814C3D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14C3E30", Offset = "0x14C2E30", VA = "0x1814C3E30")]
	public static void NHJIBBCGBND(IHNIPBDLGGD BGBEOCLNGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3274110", Offset = "0x3273110", VA = "0x183274110")]
	public static string OIKBPFLAJDM<T>(T MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3274190", Offset = "0x3273190", VA = "0x183274190")]
	public static string OIKBPFLAJDM<T>(T MPHFKGJNMOK, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x316E1C0", Offset = "0x316D1C0", VA = "0x18316E1C0")]
	public static T IACEKGNLJIN<T>(string LONLOCHDGLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x316E390", Offset = "0x316D390", VA = "0x18316E390")]
	public static T IACEKGNLJIN<T>(string LONLOCHDGLG, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x316E460", Offset = "0x316D460", VA = "0x18316E460")]
	public static T IACEKGNLJIN<T>(byte[] KFCJKMJDFKE, IHNIPBDLGGD BGBEOCLNGLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x316E240", Offset = "0x316D240", VA = "0x18316E240")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B9730", Offset = "0x7B8730", VA = "0x1807B9730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xBCE970", Offset = "0xBCD970", VA = "0x180BCE970")]
	public void EDMFEBGBCLN(int KJBKACPPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xBCDFF0", Offset = "0xBCCFF0", VA = "0x180BCDFF0")]
	public static byte[] BHGNMLKIJJL(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xBCEE90", Offset = "0xBCDE90", VA = "0x180BCEE90")]
	public static byte[] OEGJGAOMNPJ(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xBCE890", Offset = "0xBCD890", VA = "0x180BCE890")]
	public static byte[] DIOCPAKGNHA(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xBCEFB0", Offset = "0xBCDFB0", VA = "0x180BCEFB0")]
	public static byte[] PJMIOFIMEIG(string COJCGCCEFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xBCF1F0", Offset = "0xBCE1F0", VA = "0x180BCF1F0")]
	public BFLLELOAEDL(byte[] PFPPJJFPBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xBCE7E0", Offset = "0xBCD7E0", VA = "0x180BCE7E0")]
	public ArraySegment<byte> DEKOJDJMHGL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBCE690", Offset = "0xBCD690", VA = "0x180BCE690")]
	public byte[] DDDJBCEJAGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xBCF140", Offset = "0xBCE140", VA = "0x180BCF140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xBCE960", Offset = "0xBCD960", VA = "0x180BCE960")]
	public void DKIJAJMBPMB(int HIOEEKOEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xBCE5B0", Offset = "0xBCD5B0", VA = "0x180BCE5B0")]
	public void CNIJIIBKHGD(byte[] NHJFMJONGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xBCDFB0", Offset = "0xBCCFB0", VA = "0x180BCDFB0")]
	public void BCHMBNDGGKP(byte NHJFMJONGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xBCEE10", Offset = "0xBCDE10", VA = "0x180BCEE10")]
	public void NCEMMBAADAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xBCEF60", Offset = "0xBCDF60", VA = "0x180BCEF60")]
	public void PEIHGKEGFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xBCE070", Offset = "0xBCD070", VA = "0x180BCE070")]
	public void BNPDFBDGPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xBCDF60", Offset = "0xBCCF60", VA = "0x180BCDF60")]
	public void AMGGNLPPHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xBCED90", Offset = "0xBCDD90", VA = "0x180BCED90")]
	public void MNCOMPPPIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xBCE560", Offset = "0xBCD560", VA = "0x180BCE560")]
	public void CEHHIAKLNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBCE9B0", Offset = "0xBCD9B0", VA = "0x180BCE9B0")]
	public void FGEKFOJFKAM(string COJCGCCEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xBCEAF0", Offset = "0xBCDAF0", VA = "0x180BCEAF0")]
	public void KACKNIIPIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xBCE0C0", Offset = "0xBCD0C0", VA = "0x180BCE0C0")]
	public void CCANMKDCHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBA0", Offset = "0xBCDBA0", VA = "0x180BCEBA0")]
	public void LCHGDDBOIEL(bool MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xBCE610", Offset = "0xBCD610", VA = "0x180BCE610")]
	public void COHDDEPPNIH(float MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xBCEA70", Offset = "0xBCDA70", VA = "0x180BCEA70")]
	public void JJPMNDEFDHN(double MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xBCEB40", Offset = "0xBCDB40", VA = "0x180BCEB40")]
	public void KCPFAFEIOBI(byte MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xBCE980", Offset = "0xBCD980", VA = "0x180BCE980")]
	public void FDCIFNHEFDI(ushort MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xBCEE60", Offset = "0xBCDE60", VA = "0x180BCEE60")]
	public void NNEBGLPOEPP(uint MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xBCEA10", Offset = "0xBCDA10", VA = "0x180BCEA10")]
	public void GNBMBHPKNHE(ulong MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBCF110", Offset = "0xBCE110", VA = "0x180BCF110")]
	public void PMDAEPOBFNL(sbyte MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xBCEDE0", Offset = "0xBCDDE0", VA = "0x180BCEDE0")]
	public void MPDMFIKLGHJ(short MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBCEB70", Offset = "0xBCDB70", VA = "0x180BCEB70")]
	public void KOMOEGLDKHK(int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xBCEA40", Offset = "0xBCDA40", VA = "0x180BCEA40")]
	public void IAFNNDIMDCI(long MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xBCE190", Offset = "0xBCD190", VA = "0x180BCE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x44B80D0", Offset = "0x44B70D0", VA = "0x1844B80D0")]
		static JLBMNPKDJEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private GCGOCHGFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD4A50", Offset = "0xBD3A50", VA = "0x180BD4A50")]
	static DNJBEEELAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBD44F0", Offset = "0xBD34F0", VA = "0x180BD44F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C4310", Offset = "0x14C3310", VA = "0x1814C4310")]
	public LFLILFPPGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x14C3FC0", Offset = "0x14C2FC0", VA = "0x1814C3FC0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector2 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x14C4070", Offset = "0x14C3070", VA = "0x1814C4070", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BC0F0", Offset = "0x14BB0F0", VA = "0x1814BC0F0")]
	public IFKLADLHEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x14BBCD0", Offset = "0x14BACD0", VA = "0x1814BBCD0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector3 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x14BBDF0", Offset = "0x14BADF0", VA = "0x1814BBDF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF3DF0", Offset = "0x1CF2DF0", VA = "0x181CF3DF0")]
	public NNHNGGCLELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x14C3590", Offset = "0x14C2590", VA = "0x1814C3590", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Vector4 MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3BC0", Offset = "0x1CF2BC0", VA = "0x181CF3BC0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF8F90", Offset = "0x1CF7F90", VA = "0x181CF8F90")]
	public PEHEEFOCHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x14C3590", Offset = "0x14C2590", VA = "0x1814C3590", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Quaternion MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8D60", Offset = "0x1CF7D60", VA = "0x181CF8D60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C3A20", Offset = "0x14C2A20", VA = "0x1814C3A20")]
	public KNNDMCAJFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x14C3590", Offset = "0x14C2590", VA = "0x1814C3590", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Color MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x14C36E0", Offset = "0x14C26E0", VA = "0x1814C36E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BCDB0", Offset = "0x14BBDB0", VA = "0x1814BCDB0")]
	public IKNFAKHHMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x14BC790", Offset = "0x14BB790", VA = "0x1814BC790", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Bounds MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x14BCA00", Offset = "0x14BBA00", VA = "0x1814BCA00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD8980", Offset = "0xBD7980", VA = "0x180BD8980")]
	public FKMAABLNDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xBD8440", Offset = "0xBD7440", VA = "0x180BD8440", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Rect MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xBD86D0", Offset = "0xBD76D0", VA = "0x180BD86D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3937EB0", Offset = "0x3936EB0", VA = "0x183937EB0")]
		static MPNDEIOOPGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private IMHPEGMGGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x38A99E0", Offset = "0x38A89E0", VA = "0x1838A99E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBE3A40", Offset = "0xBE2A40", VA = "0x180BE3A40")]
		internal static object IEEPEMKCBNI(Type JDLAIFIMIJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private BHNKLNPENPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x38FF730", Offset = "0x38FE730", VA = "0x1838FF730")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private GNGKBLLGJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x14B59F0", Offset = "0x14B49F0", VA = "0x1814B59F0")]
	public static void LOCJDHNCFIF(params IHNIPBDLGGD[] JDAGHLFJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x14B5AB0", Offset = "0x14B4AB0", VA = "0x1814B5AB0")]
	public static void LOCJDHNCFIF(params MKODBDPOJMK[] GPDBPECMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x14B57A0", Offset = "0x14B47A0", VA = "0x1814B57A0")]
	public static void FBDLAIMELGO(MKODBDPOJMK[] GPDBPECMEOL, IHNIPBDLGGD[] JDAGHLFJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CE6EA0", Offset = "0x3CE5EA0", VA = "0x183CE6EA0")]
		static JMDGCCEDPFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private FGLFDEADAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B3E00", Offset = "0x14B2E00", VA = "0x1814B3E00")]
	internal static object IEEPEMKCBNI(Type JDLAIFIMIJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x14B3DC0", Offset = "0x14B2DC0", VA = "0x1814B3DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x38AE3A0", Offset = "0x38AD3A0", VA = "0x1838AE3A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCDE70", Offset = "0xBCCE70", VA = "0x180BCDE70")]
	static BFCAODKNLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private BFCAODKNLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31BF680", Offset = "0x31BE680", VA = "0x1831BF680")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CEFD40", Offset = "0x1CEED40", VA = "0x181CEFD40")]
	static LLJLLMLFCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private LLJLLMLFCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3101400", Offset = "0x3100400", VA = "0x183101400")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD09A0", Offset = "0xBCF9A0", VA = "0x180BD09A0")]
	static CKEAFNJLLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private CKEAFNJLLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BEFA0", Offset = "0x8BDFA0", VA = "0x1808BEFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BC350", Offset = "0x14BB350", VA = "0x1814BC350")]
	static IIDCGIPJBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private IIDCGIPJBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3910610", Offset = "0x390F610", VA = "0x183910610")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C4620", Offset = "0x14C3620", VA = "0x1814C4620")]
	static LHCFECFNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private LHCFECFNJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3711150", Offset = "0x3710150", VA = "0x183711150")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD0DA0", Offset = "0xBCFDA0", VA = "0x180BD0DA0")]
	static DCIELAKOBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private DCIELAKOBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F35650", Offset = "0x3F34650", VA = "0x183F35650")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A03700", Offset = "0x3A02700", VA = "0x183A03700")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x43521D0", Offset = "0x43511D0", VA = "0x1843521D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A50B30", Offset = "0x3A4FB30", VA = "0x183A50B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x4006E90", Offset = "0x4005E90", VA = "0x184006E90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x17EB520", Offset = "0x17EA520", VA = "0x1817EB520")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
	public global::CHGOEAEDIKB<T> IEEPEMKCBNI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C88E0", Offset = "0x14C78E0", VA = "0x1814C88E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14C7DE0", Offset = "0x14C6DE0", VA = "0x1814C7DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B9AC0", Offset = "0x14B8AC0", VA = "0x1814B9AC0")]
		public static MethodInfo DFIGKGIDJJK(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x14B9D50", Offset = "0x14B8D50", VA = "0x1814B9D50")]
		public static MethodInfo IACEKGNLJIN(Type ONIHNDBDHGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x14B9F80", Offset = "0x14B8F80", VA = "0x1814B9F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public KCEAJEGCIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x14C30E0", Offset = "0x14C20E0", VA = "0x1814C30E0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x14C3120", Offset = "0x14C2120", VA = "0x1814C3120")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public EKKDBFBMDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x14B0720", Offset = "0x14AF720", VA = "0x1814B0720")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public ALOPMBFJHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x14AFF70", Offset = "0x14AEF70", VA = "0x1814AFF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public BIKFEOPBLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x14B0180", Offset = "0x14AF180", VA = "0x1814B0180")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public FEIJDPFFOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x14B07C0", Offset = "0x14AF7C0", VA = "0x1814B07C0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x14B0840", Offset = "0x14AF840", VA = "0x1814B0840")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public BPFCAGMMOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x14B01E0", Offset = "0x14AF1E0", VA = "0x1814B01E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public LLENGPBGEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5F81A0", Offset = "0x5F71A0", VA = "0x1805F81A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public BELEPFBINBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x14AFFD0", Offset = "0x14AEFD0", VA = "0x1814AFFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public GBDJJMFLLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x14B0A40", Offset = "0x14AFA40", VA = "0x1814B0A40")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x14B0D20", Offset = "0x14AFD20", VA = "0x1814B0D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public PNJMHCICIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x14C9620", Offset = "0x14C8620", VA = "0x1814C9620")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public PMJEPHGHNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x14C9620", Offset = "0x14C8620", VA = "0x1814C9620")]
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
	[Cpp2IlInjected.Address(RVA = "0x3821F40", Offset = "0x3820F40", VA = "0x183821F40")]
	public static object KHCJFJIEAJP<T>(DFDMNMAAHFF KOGJOKEBHLE, IHNIPBDLGGD HNOMMFACBME, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x381A9F0", Offset = "0x38199F0", VA = "0x18381A9F0")]
	public static object KDKCPDOOPCN<T>(IHNIPBDLGGD HNOMMFACBME, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA, bool PCLBELHBGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xBDA7B0", Offset = "0xBD97B0", VA = "0x180BDA7B0")]
	private static TypeInfo CAGLKNBIIJI(DFDMNMAAHFF KOGJOKEBHLE, Type ONIHNDBDHGC, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xBDCD60", Offset = "0xBDBD60", VA = "0x180BDCD60")]
	public static object KGNGEFFCKAI(Type ONIHNDBDHGC, Func<string, string> DHGIKBBNFJL, bool DMCNEKLGFOA, bool PCLBELHBGNF, bool AFMLKDIHJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xBDF800", Offset = "0xBDE800", VA = "0x180BDF800")]
	private static Dictionary<LKBPCACDHBB, FieldInfo> NMDHBMGBEBO(TypeBuilder BICKMGKOLLI, AHFAAOJAMII OONMAFOODBN, ConstructorInfo FKIPEOKEBBE, FieldBuilder MKNEIAFPMHL, ILGenerator HMCBAGLFFGI, bool DMCNEKLGFOA, bool GCKKJOLACNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xBDA1F0", Offset = "0xBD91F0", VA = "0x180BDA1F0")]
	private static Dictionary<LKBPCACDHBB, FieldInfo> AALMMKJPBLC(TypeBuilder BICKMGKOLLI, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xBDB800", Offset = "0xBDA800", VA = "0x180BDB800")]
	private static void KAGIKLLGIIJ(Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI, Action GHINGLJFBGA, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, bool DMCNEKLGFOA, bool GCKKJOLACNK, int PHNBPAOLNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xBDF310", Offset = "0xBDE310", VA = "0x180BDF310")]
	private static void NMAKCKNBNCG(TypeInfo ONIHNDBDHGC, LKBPCACDHBB OCIIPMFHMAL, ILGenerator HMCBAGLFFGI, int HOOANEAGKNH, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, PMKAMCEMKDO CCLGELJKLAA, PMKAMCEMKDO FAHNBHGDLOA, PMKAMCEMKDO MGOLHMJHIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xBDFE50", Offset = "0xBDEE50", VA = "0x180BDFE50")]
	private static void OAPKFGEDAEC(Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, ILGenerator HMCBAGLFFGI, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, bool EHEOEOEECJN, int PHNBPAOLNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xBDB250", Offset = "0xBDA250", VA = "0x180BDB250")]
	private static void FOIHLFMJADL(ILGenerator HMCBAGLFFGI, DGFMHGBCKME OONMAFOODBN, int HOOANEAGKNH, Func<int, LKBPCACDHBB, bool> OLDKIBNJONP, PMKAMCEMKDO JFKAGENJIJO, PMKAMCEMKDO MGOLHMJHIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xBDE6A0", Offset = "0xBDD6A0", VA = "0x180BDE6A0")]
	private static LocalBuilder NDILHEKOKAM(ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC, AHFAAOJAMII OONMAFOODBN, DGFMHGBCKME[] IGONJNNHEAF, bool FKOHGHCOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xBE1100", Offset = "0xBE0100", VA = "0x180BE1100")]
	private static bool OJBNKPKGOPB(ConstructorInfo JGAECKKFOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDA660", VA = "0x180BDB660")]
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
		[Cpp2IlInjected.Address(RVA = "0x34863A0", Offset = "0x34853A0", VA = "0x1834863A0")]
		static GHMAJBAOIEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private FFBDLONNCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3714E50", Offset = "0x3713E50", VA = "0x183714E50")]
		static JHBECBDPOFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly IHNIPBDLGGD NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private DCIGECOFGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31EC440", Offset = "0x31EB440", VA = "0x1831EC440")]
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
			[Cpp2IlInjected.Address(RVA = "0x31F39F0", Offset = "0x31F29F0", VA = "0x1831F39F0")]
			static LIINGFINADP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private EMHOAOAMHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private DINNFFNFKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BB530", Offset = "0x8BA530", VA = "0x1808BB530")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B8030", Offset = "0x8B7030", VA = "0x1808B8030")]
			static FBGHNCKKBDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private GHKHFGBHLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private ICCLJEFEOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x400B200", Offset = "0x400A200", VA = "0x18400B200")]
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
			[Cpp2IlInjected.Address(RVA = "0x4004250", Offset = "0x4003250", VA = "0x184004250")]
			static FCCDHDOCDLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private NGFLNBOJLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private MKIIGBGPDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31E7100", Offset = "0x31E6100", VA = "0x1831E7100")]
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
			[Cpp2IlInjected.Address(RVA = "0x31D7510", Offset = "0x31D6510", VA = "0x1831D7510")]
			static BGBICDHOBHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private IPCLCCNBGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private DGGNKKHCMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4083AD0", Offset = "0x4082AD0", VA = "0x184083AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40800E0", Offset = "0x407F0E0", VA = "0x1840800E0")]
			static EPOCBMDOJEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private LGGGNCBEFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private PEGIGHKNFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x43566C0", Offset = "0x43556C0", VA = "0x1843566C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x433F870", Offset = "0x433E870", VA = "0x18433F870")]
			static BIDANKPLMLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private NPAOFOPNIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private FAJMEAPJFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x140A390", Offset = "0x1409390", VA = "0x18140A390")]
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
			[Cpp2IlInjected.Address(RVA = "0x140BF20", Offset = "0x140AF20", VA = "0x18140BF20")]
			static MLAIMBFMMGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private LAGPLBFCDIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private AAGJGALLFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF7AF0", Offset = "0xCF6AF0", VA = "0x180CF7AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFA1A0", Offset = "0xCF91A0", VA = "0x180CFA1A0")]
			static LKHAMECFKKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private FFPHJBCIDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private CMDAMDNNMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4095060", Offset = "0x4094060", VA = "0x184095060")]
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
			[Cpp2IlInjected.Address(RVA = "0x40A5F50", Offset = "0x40A4F50", VA = "0x1840A5F50")]
			static NLBINFKMOHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private HCPBCADHABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private NHJBLIHKFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4088030", Offset = "0x4087030", VA = "0x184088030")]
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
			[Cpp2IlInjected.Address(RVA = "0x407D390", Offset = "0x407C390", VA = "0x18407D390")]
			static CCLNJODDMFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private POHIJONKKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private PBIGJPLIMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3768840", Offset = "0x3767840", VA = "0x183768840")]
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
			[Cpp2IlInjected.Address(RVA = "0x3765760", Offset = "0x3764760", VA = "0x183765760")]
			static IPHPMJEBAKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private FMDJBANAEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private FKADDFNKPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E84600", Offset = "0x3E83600", VA = "0x183E84600")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E8A890", Offset = "0x3E89890", VA = "0x183E8A890")]
			static DBKCKGGJGLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly IHNIPBDLGGD NNHENCBEIJC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly IHNIPBDLGGD[] JDAGHLFJEIL;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		private ECLECEMGEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	private EJIPJKEKNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C560", Offset = "0x2D9B560", VA = "0x182D9C560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30F2BE0", Offset = "0x30F1BE0", VA = "0x1830F2BE0")]
	public CDAEICHCHHJ(int EGALJCLILAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x30F2B10", Offset = "0x30F1B10", VA = "0x1830F2B10")]
	public void NENJMCKJAJO(T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x30F28D0", Offset = "0x30F18D0", VA = "0x1830F28D0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD51B0", Offset = "0xBD41B0", VA = "0x180BD51B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A441F0", Offset = "0x3A431F0", VA = "0x183A441F0")]
	public GIDKKHOLMPJ(int FKILMHAJCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A429F0", Offset = "0x3A419F0", VA = "0x183A429F0")]
	public T[] OFKILNPFOMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A41DF0", Offset = "0x3A40DF0", VA = "0x183A41DF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x81C050", Offset = "0x81B050", VA = "0x18081C050")]
			[DebuggerHidden]
			public CEGGALCHCNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBD0160", Offset = "0xBCF160", VA = "0x180BD0160", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xBD0290", Offset = "0xBCF290", VA = "0x180BD0290", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xBD01F0", Offset = "0xBCF1F0", VA = "0x180BD01F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JLNMMFKEPHK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xBD01F0", Offset = "0xBCF1F0", VA = "0x180BD01F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public MPEPFICGFAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5F81A0", Offset = "0x5F71A0", VA = "0x1805F81A0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5F81A0", Offset = "0x5F71A0", VA = "0x1805F81A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE20C0", Offset = "0xBE10C0", VA = "0x180BE20C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xBE3110", Offset = "0xBE2110", VA = "0x180BE3110")]
		public JLNMMFKEPHK(ulong MKDJIBNCKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xBE2E50", Offset = "0xBE1E50", VA = "0x180BE2E50")]
		public JLNMMFKEPHK NENJMCKJAJO(ulong MKDJIBNCKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xBE3040", Offset = "0xBE2040", VA = "0x180BE3040")]
		public JLNMMFKEPHK NENJMCKJAJO(ulong MKDJIBNCKNC, int MPHFKGJNMOK, string CJBGLAIHCKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xBE1E60", Offset = "0xBE0E60", VA = "0x180BE1E60")]
		public JLNMMFKEPHK CDJIOKDMGJP(byte[] ODINNAEBCEA, ref int KJBKACPPODJ, ref int EEJHLCLDPFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xBE2040", Offset = "0xBE1040", VA = "0x180BE2040")]
		internal static int DDEOPFDEKMP(ulong[] BEGPAFGBCJM, int HOOANEAGKNH, int GGLJPLLKLMG, ulong MPHFKGJNMOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xBE2010", Offset = "0xBE1010", VA = "0x180BE2010", Slot = "4")]
		public int CompareTo(JLNMMFKEPHK GJPJDOANCNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xBE20D0", Offset = "0xBE10D0", VA = "0x180BE20D0")]
		[IteratorStateMachine(typeof(CEGGALCHCNI))]
		public IEnumerable<JLNMMFKEPHK> GMELHOHILOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xBE2140", Offset = "0xBE1140", VA = "0x180BE2140")]
		public void KODGINIKBHE(ILGenerator HMCBAGLFFGI, LocalBuilder ODINNAEBCEA, LocalBuilder EEJHLCLDPFL, LocalBuilder MKDJIBNCKNC, Action<KeyValuePair<string, int>> MDGDLKLOBOA, Action GMJPOKHDHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xBE2270", Offset = "0xBE1270", VA = "0x180BE2270")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F0550", Offset = "0x5EF550", VA = "0x1805F0550", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD42D0", Offset = "0xBD32D0", VA = "0x180BD42D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAB8490", Offset = "0xAB7490", VA = "0x180AB8490")]
		[DebuggerHidden]
		public DKICFJBDCCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xBD4320", Offset = "0xBD3320", VA = "0x180BD4320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xBD3E60", Offset = "0xBD2E60", VA = "0x180BD3E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xBD4420", Offset = "0xBD3420", VA = "0x180BD4420")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xBD4470", Offset = "0xBD3470", VA = "0x180BD4470")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xBD4280", Offset = "0xBD3280", VA = "0x180BD4280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBD41E0", Offset = "0xBD31E0", VA = "0x180BD41E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xBD41E0", Offset = "0xBD31E0", VA = "0x180BD41E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCFD30", Offset = "0xBCED30", VA = "0x180BCFD30")]
	public BHOCKMMPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xBCFAF0", Offset = "0xBCEAF0", VA = "0x180BCFAF0")]
	public void NENJMCKJAJO(byte[] KFCJKMJDFKE, int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xBCF8D0", Offset = "0xBCE8D0", VA = "0x180BCF8D0")]
	public bool CFIELOGABGK(ArraySegment<byte> MKDJIBNCKNC, out int MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xBCFC40", Offset = "0xBCEC40", VA = "0x180BCFC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xBCF650", Offset = "0xBCE650", VA = "0x180BCF650")]
	private static void ADMOJALOIIJ(IEnumerable<JLNMMFKEPHK> JBHHJGALHMA, StringBuilder ECKLGDCNNAE, int DIAIBOCHHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0xBCF980", Offset = "0xBCE980", VA = "0x180BCF980", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xBCF980", Offset = "0xBCE980", VA = "0x180BCF980", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xBCFA80", Offset = "0xBCEA80", VA = "0x180BCFA80")]
	[IteratorStateMachine(typeof(DKICFJBDCCD))]
	private static IEnumerable<KeyValuePair<string, int>> LHDALGDBNIM(IEnumerable<JLNMMFKEPHK> JBHHJGALHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xBCFC10", Offset = "0xBCEC10", VA = "0x180BCFC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B5EF0", Offset = "0x14B4EF0", VA = "0x1814B5EF0")]
	public static ulong PPBJDECHJBE(byte[] KFCJKMJDFKE, ref int KJBKACPPODJ, ref int EEJHLCLDPFL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class ANJJMLKHEKD
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xBCB450", Offset = "0xBCA450", VA = "0x180BCB450")]
	public static void DKIJAJMBPMB(ref byte[] KFCJKMJDFKE, int KJBKACPPODJ, int HIOEEKOEKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xBCB570", Offset = "0xBCA570", VA = "0x180BCB570")]
	public static void LILIHALMBDE(ref byte[] BEGPAFGBCJM, int IHELJAFNFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xBCB660", Offset = "0xBCA660", VA = "0x180BCB660")]
	public static byte[] MJGBCADCHCE(byte[] APOAJBBJNEM, int IHELJAFNFGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class EHLDNNPHMAM
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0xBD55C0", Offset = "0xBD45C0", VA = "0x180BD55C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A126D0", Offset = "0x3A116D0", VA = "0x183A126D0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x81CB30", Offset = "0x81BB30", VA = "0x18081CB30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A02480", Offset = "0x3A01480", VA = "0x183A02480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xCFCCC0", Offset = "0xCFBCC0", VA = "0x180CFCCC0")]
		[DebuggerHidden]
		public AMGINOBEOKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A015D0", Offset = "0x3A005D0", VA = "0x183A015D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A01A80", Offset = "0x3A00A80", VA = "0x183A01A80", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A0C6F0", Offset = "0x3A0B6F0", VA = "0x183A0C6F0")]
	public EGMPBFEECFD(int NKJBJGFALMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C630", Offset = "0x3A0B630", VA = "0x183A0C630")]
	public EGMPBFEECFD(int NKJBJGFALMO, float DHHHFBOOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BE40", Offset = "0x3A0AE40", VA = "0x183A0BE40")]
	public void NENJMCKJAJO(byte[] MKDJIBNCKNC, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B780", Offset = "0x3A0A780", VA = "0x183A0B780")]
	private bool IHPPCNEGKBA(byte[] MKDJIBNCKNC, T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A085D0", Offset = "0x3A075D0", VA = "0x183A085D0")]
	public bool ACEOCCKNHLM(ArraySegment<byte> MKDJIBNCKNC, out T MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BAE0", Offset = "0x3A0AAE0", VA = "0x183A0BAE0")]
	private static ulong KIJDHMPIPNP(byte[] KDNDPAEEMPL, int KJBKACPPODJ, int DHNBJNKGAHH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x366D810", Offset = "0x366C810", VA = "0x18366D810")]
	private static int JKBCEOCOJBL(int DFHEMEDDEMC, float DHHHFBOOEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A08C20", Offset = "0x3A07C20", VA = "0x183A08C20", Slot = "4")]
	[IteratorStateMachine(typeof(global::EGMPBFEECFD<>.AMGINOBEOKJ))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8CAA80", Offset = "0x8C9A80", VA = "0x1808CAA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B3700", Offset = "0x14B2700", VA = "0x1814B3700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x14B3860", Offset = "0x14B2860", VA = "0x1814B3860")]
	static GKANLDOACPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x14B3AB0", Offset = "0x14B2AB0", VA = "0x1814B3AB0")]
	public GKANLDOACPP(byte[] LBGOONHAHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x14B3750", Offset = "0x14B2750", VA = "0x1814B3750")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCD3C0", Offset = "0xBCC3C0", VA = "0x180BCD3C0")]
	public AOELBBNOMEN(ref Guid MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xBCCD10", Offset = "0xBCBD10", VA = "0x180BCCD10")]
	public AOELBBNOMEN(ref ArraySegment<byte> ONIMEGFECJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xBCCBA0", Offset = "0xBCBBA0", VA = "0x180BCCBA0")]
	private static byte MADGIHMIKEK(byte[] KFCJKMJDFKE, int ENJPLLFKKPA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xBCCA90", Offset = "0xBCBA90", VA = "0x180BCCA90")]
	private static byte HNJFLCJJCJG(byte IIFMPDAMAIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xBCB750", Offset = "0xBCA750", VA = "0x180BCB750")]
	public void BHCFMJJHILF(byte[] HKAAJCFANGC, int KJBKACPPODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GFAKEAABANL
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x14B2780", Offset = "0x14B1780", VA = "0x1814B2780")]
	public static bool LEMKLJOOAEP(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x14B2980", Offset = "0x14B1980", VA = "0x1814B2980")]
	public static bool PPHEJILLNCL(byte AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x14B2910", Offset = "0x14B1910", VA = "0x1814B2910")]
	public static sbyte PJCGOJJOCBK(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x14B10F0", Offset = "0x14B00F0", VA = "0x1814B10F0")]
	public static short GAPLLDKLEID(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x14B2710", Offset = "0x14B1710", VA = "0x1814B2710")]
	public static int LEANGICBMPH(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x14B11E0", Offset = "0x14B01E0", VA = "0x1814B11E0")]
	public static long GKMKBANOJIM(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x14B26A0", Offset = "0x14B16A0", VA = "0x1814B26A0")]
	public static byte KCPBODNFLBD(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x14B0E30", Offset = "0x14AFE30", VA = "0x1814B0E30")]
	public static ushort EJJGFBICOJP(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x14B1160", Offset = "0x14B0160", VA = "0x1814B1160")]
	public static uint GHIGFJHGFLL(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x14B2800", Offset = "0x14B1800", VA = "0x1814B2800")]
	public static ulong NCFNCPMJIII(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DC0", Offset = "0x14AFDC0", VA = "0x1814B0DC0")]
	public static float EAHNPLKCOGI(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x14B2790", Offset = "0x14B1790", VA = "0x1814B2790")]
	public static double LNIAIEFDMPM(byte[] KFCJKMJDFKE, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x14B1290", Offset = "0x14B0290", VA = "0x1814B1290")]
	public static int GNBMBHPKNHE(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, ulong MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x14B1A60", Offset = "0x14B0A60", VA = "0x1814B1A60")]
	public static int IAFNNDIMDCI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, long MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x14B0EA0", Offset = "0x14AFEA0", VA = "0x1814B0EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x81C050", Offset = "0x81B050", VA = "0x18081C050")]
		[DebuggerHidden]
		public NNPECCAKOCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4540", Offset = "0x1CF3540", VA = "0x181CF4540", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1CF40E0", Offset = "0x1CF30E0", VA = "0x181CF40E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4660", Offset = "0x1CF3660", VA = "0x181CF4660")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1CF46B0", Offset = "0x1CF36B0", VA = "0x181CF46B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1CF44F0", Offset = "0x1CF34F0", VA = "0x181CF44F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4440", Offset = "0x1CF3440", VA = "0x181CF4440", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4440", Offset = "0x1CF3440", VA = "0x181CF4440", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x81C050", Offset = "0x81B050", VA = "0x18081C050")]
		[DebuggerHidden]
		public MLMJDAFHGCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2550", Offset = "0x1CF1550", VA = "0x181CF2550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF20F0", Offset = "0x1CF10F0", VA = "0x181CF20F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2670", Offset = "0x1CF1670", VA = "0x181CF2670")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF26C0", Offset = "0x1CF16C0", VA = "0x181CF26C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2500", Offset = "0x1CF1500", VA = "0x181CF2500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2450", Offset = "0x1CF1450", VA = "0x181CF2450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2450", Offset = "0x1CF1450", VA = "0x181CF2450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3920", Offset = "0x1CF2920", VA = "0x181CF3920")]
	public static bool MLPBAAHIHAB(this TypeInfo ONIHNDBDHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF39D0", Offset = "0x1CF29D0", VA = "0x181CF39D0")]
	public static bool OKMKGDCDFFC(this TypeInfo ONIHNDBDHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3830", Offset = "0x1CF2830", VA = "0x181CF3830")]
	public static IEnumerable<PropertyInfo> LLKGOABBBBM(this Type ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3740", Offset = "0x1CF2740", VA = "0x181CF3740")]
	[IteratorStateMachine(typeof(NNPECCAKOCO))]
	private static IEnumerable<PropertyInfo> CCCDKLIODAN(Type ONIHNDBDHGC, HashSet<string> OALKGLBOPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF37D0", Offset = "0x1CF27D0", VA = "0x181CF37D0")]
	public static IEnumerable<FieldInfo> JPCPLPNDGIH(this Type ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3890", Offset = "0x1CF2890", VA = "0x181CF3890")]
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
	[Cpp2IlInjected.Address(RVA = "0x6ACEB0", Offset = "0x6ABEB0", VA = "0x1806ACEB0")]
	public static string KPBKJHIBDBM(string AGEMEGILCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xBC9990", Offset = "0xBC8990", VA = "0x180BC9990")]
	public static string FDNMBKIKNJJ(string AGEMEGILCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xBC97C0", Offset = "0xBC87C0", VA = "0x180BC97C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3676350", Offset = "0x3675350", VA = "0x183676350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x36762D0", Offset = "0x36752D0", VA = "0x1836762D0")]
		private int LLHHHCBKNJN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public OIBMMFPILNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x698DB0", Offset = "0x697DB0", VA = "0x180698DB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x366E240", Offset = "0x366D240", VA = "0x18366E240")]
	public JHPNJCCNEJI(int NKJBJGFALMO = 4, float DHHHFBOOEHH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x366D9D0", Offset = "0x366C9D0", VA = "0x18366D9D0")]
	public bool LHNHAJKKNNC(Type MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x366D990", Offset = "0x366C990", VA = "0x18366D990")]
	public bool LHNHAJKKNNC(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x366D210", Offset = "0x366C210", VA = "0x18366D210")]
	private bool IHPPCNEGKBA(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO, out TValue LCKGMJMPKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x366DAE0", Offset = "0x366CAE0", VA = "0x18366DAE0")]
	private bool MPKFCMNJKDJ(PAMEBGNMIKA[] NIBJPKMIFMM, Type HPGCPPOKJBN, PAMEBGNMIKA BODGFIHOMHP, Func<Type, TValue> HALEMICJPIO, out TValue LCKGMJMPKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x366CDF0", Offset = "0x366BDF0", VA = "0x18366CDF0")]
	public bool ACEOCCKNHLM(Type MKDJIBNCKNC, out TValue MPHFKGJNMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x366D170", Offset = "0x366C170", VA = "0x18366D170")]
	public TValue GPHBEMBAHLO(Type MKDJIBNCKNC, Func<Type, TValue> HALEMICJPIO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x366D810", Offset = "0x366C810", VA = "0x18366D810")]
	private static int JKBCEOCOJBL(int DFHEMEDDEMC, float DHHHFBOOEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x366D090", Offset = "0x366C090", VA = "0x18366D090")]
	private static void BPGBIHIIOCC(ref PAMEBGNMIKA HLLENNLJMEE, PAMEBGNMIKA MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x366D090", Offset = "0x366C090", VA = "0x18366D090")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD36D0", Offset = "0xBD26D0", VA = "0x180BD36D0")]
	public TypeBuilder JMABCCNHJMG(string MONHCMBIJIP, TypeAttributes BHEENIELJOE, Type COLFLONKFJK, Type[] GFCJLCDHMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xBD37C0", Offset = "0xBD27C0", VA = "0x180BD37C0")]
	public DFDMNMAAHFF(string NAJECPPKLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class NKPJFGJKGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3AD0", Offset = "0x1CF2AD0", VA = "0x181CF3AD0")]
	private static MethodInfo MGGNHCLFIMC(LambdaExpression PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3275500", Offset = "0x3274500", VA = "0x183275500")]
	public static MethodInfo BEEKDKKBJDO<T>(Expression<Func<T>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3275500", Offset = "0x3274500", VA = "0x183275500")]
	public static MethodInfo BEEKDKKBJDO<T, TR>(Expression<Func<T, TR>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3275500", Offset = "0x3274500", VA = "0x183275500")]
	public static MethodInfo BEEKDKKBJDO<T>(Expression<Action<T>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3275500", Offset = "0x3274500", VA = "0x183275500")]
	public static MethodInfo BEEKDKKBJDO<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> PIAHFNDOJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3275510", Offset = "0x3274510", VA = "0x183275510")]
	private static MemberInfo KJICPPJCOJB<T>(Expression<T> KEIJPKNBGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x32755B0", Offset = "0x32745B0", VA = "0x1832755B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF98A0", Offset = "0x1CF88A0", VA = "0x181CF98A0")]
	public PMKAMCEMKDO(ILGenerator HMCBAGLFFGI, int CKOCCIDDCLA, bool HDGCHPFCEBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9810", Offset = "0x1CF8810", VA = "0x181CF9810")]
	public PMKAMCEMKDO(ILGenerator HMCBAGLFFGI, int CKOCCIDDCLA, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1CF97F0", Offset = "0x1CF87F0", VA = "0x181CF97F0")]
	public void CAKENMMPPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IPEDPDKGDGE
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x14BFD00", Offset = "0x14BED00", VA = "0x1814BFD00")]
	public static void DACFCJEOKMI(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x14BFF30", Offset = "0x14BEF30", VA = "0x1814BFF30")]
	public static void DACFCJEOKMI(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x14C0420", Offset = "0x14BF420", VA = "0x1814C0420")]
	public static void EGHHLFBNODJ(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x14C0650", Offset = "0x14BF650", VA = "0x1814C0650")]
	public static void EGHHLFBNODJ(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x14C0220", Offset = "0x14BF220", VA = "0x1814C0220")]
	public static void EEPKJINBPPG(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x14C0310", Offset = "0x14BF310", VA = "0x1814C0310")]
	public static void EEPKJINBPPG(this ILGenerator HMCBAGLFFGI, LocalBuilder JOFPDPGKFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x14C0F90", Offset = "0x14BFF90", VA = "0x1814C0F90")]
	public static void PPGPNDEDFNG(this ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x14C0C50", Offset = "0x14BFC50", VA = "0x1814C0C50")]
	public static void LJGOPOEJLNC(this ILGenerator HMCBAGLFFGI, bool MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x14C0800", Offset = "0x14BF800", VA = "0x1814C0800")]
	public static void LJBELDBICHC(this ILGenerator HMCBAGLFFGI, int MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x14C0710", Offset = "0x14BF710", VA = "0x1814C0710")]
	public static void KJFMKPABEGK(this ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x14C0060", Offset = "0x14BF060", VA = "0x1814C0060")]
	public static void DIADLHFGMHO(this ILGenerator HMCBAGLFFGI, Type ONIHNDBDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x14C0D60", Offset = "0x14BFD60", VA = "0x1814C0D60")]
	public static void ODNKHGICGHK(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x14C0690", Offset = "0x14BF690", VA = "0x1814C0690")]
	public static void EJEOKCIAAIK(this ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x14BFF70", Offset = "0x14BEF70", VA = "0x1814BFF70")]
	public static void DCKKOHNOHBH(this ILGenerator HMCBAGLFFGI, int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x14C0C60", Offset = "0x14BFC60", VA = "0x1814C0C60")]
	public static void MLDIFNCPOBH(this ILGenerator HMCBAGLFFGI, MethodInfo FBNKADPNIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x14C0100", Offset = "0x14BF100", VA = "0x1814C0100")]
	public static void DKNLNMCPGIB(this ILGenerator HMCBAGLFFGI, FieldInfo NJPKCJNHCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x14C0190", Offset = "0x14BF190", VA = "0x1814C0190")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public DPMBLPDMMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x14B0620", Offset = "0x14AF620", VA = "0x1814B0620")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GOCAGFIEAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5AB350", Offset = "0x5AA350", VA = "0x1805AB350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5AB360", Offset = "0x5AA360", VA = "0x1805AB360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OHGKPCLKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x14C4D50", Offset = "0x14C3D50", VA = "0x1814C4D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DJLFPEOGKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7A0", Offset = "0x5EE7A0", VA = "0x1805EF7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE70", Offset = "0x6ACE70", VA = "0x1806ADE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ELMJAFHEMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7B0", Offset = "0x5EE7B0", VA = "0x1805EF7B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9CFB10", Offset = "0x9CEB10", VA = "0x1809CFB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type DMIFKFNAHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F20", Offset = "0x6BFF20", VA = "0x1806C0F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo OKHIMGKBOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo HIHMGNAJNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDE0", Offset = "0x5CADE0", VA = "0x1805CBDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5F0560", Offset = "0x5EF560", VA = "0x1805F0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo JOPENEKHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5CB180", Offset = "0x5CA180", VA = "0x1805CB180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5CB200", Offset = "0x5CA200", VA = "0x1805CB200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x14C5200", Offset = "0x14C4200", VA = "0x1814C5200")]
	protected LKBPCACDHBB(Type ONIHNDBDHGC, string MONHCMBIJIP, string EOIFKMMFMLJ, bool ABKIDIPLMCJ, bool MKADPEHJEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x14C4F40", Offset = "0x14C3F40", VA = "0x1814C4F40")]
	public LKBPCACDHBB(FieldInfo OONMAFOODBN, string MONHCMBIJIP, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x14C5050", Offset = "0x14C4050", VA = "0x1814C5050")]
	public LKBPCACDHBB(PropertyInfo OONMAFOODBN, string MONHCMBIJIP, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x14C4E20", Offset = "0x14C3E20", VA = "0x1814C4E20")]
	private static MethodInfo JDDHPIOOJDE(MemberInfo OONMAFOODBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x316EE40", Offset = "0x316DE40", VA = "0x18316EE40")]
	public T DOCCIPGBCJB<T>(bool IMJOKNAOEDB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x14C4C90", Offset = "0x14C3C90", VA = "0x1814C4C90", Slot = "4")]
	public virtual void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x14C4D60", Offset = "0x14C3D60", VA = "0x1814C4D60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B3630", Offset = "0x14B2630", VA = "0x1814B3630")]
	public GJMIDJECICF(string MONHCMBIJIP, string EKBGBKNBPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x14B3520", Offset = "0x14B2520", VA = "0x1814B3520", Slot = "4")]
	public override void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x14B35E0", Offset = "0x14B25E0", VA = "0x1814B35E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B30B0", Offset = "0x14B20B0", VA = "0x1814B30B0")]
	public GGDBGPDLCPF(string MONHCMBIJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x14B29F0", Offset = "0x14B19F0", VA = "0x1814B29F0", Slot = "4")]
	public override void BNGLJPKENJE(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x14B2AB0", Offset = "0x14B1AB0", VA = "0x1814B2AB0", Slot = "5")]
	public override void FCOAICOLOMN(ILGenerator HMCBAGLFFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x14B2B00", Offset = "0x14B1B00", VA = "0x1814B2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A81F0", Offset = "0x5A71F0", VA = "0x1805A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A10", Offset = "0x5C4A10", VA = "0x1805C5A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CFJFHJKJFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7D5110", Offset = "0x7D4110", VA = "0x1807D5110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BD0", Offset = "0x8C3BD0", VA = "0x1808C4BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GPJIPCPMJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9D1130", Offset = "0x9D0130", VA = "0x1809D1130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAEC4D0", Offset = "0xAEB4D0", VA = "0x180AEC4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo GHMOHGIAGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LKBPCACDHBB[] JOHLIPDABIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5CBDD0", Offset = "0x5CADD0", VA = "0x1805CBDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F20", Offset = "0x6BFF20", VA = "0x1806C0F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LKBPCACDHBB[] EGKIPDNMJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5CB390", Offset = "0x5CA390", VA = "0x1805CB390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6A05C0", Offset = "0x69F5C0", VA = "0x1806A05C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xBC9D40", Offset = "0xBC8D40", VA = "0x180BC9D40")]
	public AHFAAOJAMII(Type ONIHNDBDHGC, Func<string, string> OHINHBEMEGD, bool PCLBELHBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xBC9C70", Offset = "0xBC8C70", VA = "0x180BC9C70")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BBCC0", Offset = "0x14BACC0", VA = "0x1814BBCC0")]
	public ICJOJGBLNNM(ulong FLMABCAICKN, int LOILPLMGAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x14BBBF0", Offset = "0x14BABF0", VA = "0x1814BBBF0")]
	public void GBOGKLFOEGK(ref ICJOJGBLNNM GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x14BBC00", Offset = "0x14BAC00", VA = "0x1814BBC00")]
	public static ICJOJGBLNNM GFGJFPCMACO(ref ICJOJGBLNNM NCGEKBENJBA, ref ICJOJGBLNNM IIFMPDAMAIA)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x14BBC30", Offset = "0x14BAC30", VA = "0x1814BBC30")]
	public void ONDBJDAMOCP(ref ICJOJGBLNNM GJPJDOANCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x14BBB40", Offset = "0x14BAB40", VA = "0x1814BBB40")]
	public static ICJOJGBLNNM FJIECJBHBHC(ref ICJOJGBLNNM NCGEKBENJBA, ref ICJOJGBLNNM IIFMPDAMAIA)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x14BBAA0", Offset = "0x14BAAA0", VA = "0x1814BBAA0")]
	public void AOMMKPJONNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x14BBAE0", Offset = "0x14BAAE0", VA = "0x1814BBAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B7F80", Offset = "0x9B6F80", VA = "0x1809B7F80")]
	public KEHNKMCECIM(byte[] HKAAJCFANGC, int MMBOHLJHNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x14C3340", Offset = "0x14C2340", VA = "0x1814C3340")]
	public void FOOPJIOCBII(byte IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x14C33A0", Offset = "0x14C23A0", VA = "0x1814C33A0")]
	public void GBIPJNGEOHM(byte[] IOLGJHAFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x14C3440", Offset = "0x14C2440", VA = "0x1814C3440")]
	public void KCDJHCENIOP(byte[] IOLGJHAFBKL, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x14C34E0", Offset = "0x14C24E0", VA = "0x1814C34E0")]
	public void KCDJHCENIOP(byte[] IOLGJHAFBKL, int BDOCBPFFDPK, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x14C31C0", Offset = "0x14C21C0", VA = "0x1814C31C0")]
	public void CMJAKOMAIAC(byte AHENHIDOBEA, int DHNBJNKGAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x14C3240", Offset = "0x14C2240", VA = "0x1814C3240")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B8F50", Offset = "0x14B7F50", VA = "0x1814B8F50")]
	private static byte[] POEHGAGHMDA(int KMCJMFPOINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x14B8580", Offset = "0x14B7580", VA = "0x1814B8580")]
	private static byte[] KOJOBMPIIJH(int KMCJMFPOINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x14B8080", Offset = "0x14B7080", VA = "0x1814B8080")]
	public static int JAEIHBBACGI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, float MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x14B8190", Offset = "0x14B7190", VA = "0x1814B8190")]
	public static int JAEIHBBACGI(ref byte[] HKAAJCFANGC, int KJBKACPPODJ, double MPHFKGJNMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x14B8E50", Offset = "0x14B7E50", VA = "0x1814B8E50")]
	private static bool PJHFBCPAMIE(byte[] HKAAJCFANGC, int GGLJPLLKLMG, ulong HGLKOJIEPBB, ulong JAMNKCJHBEE, ulong EEJHLCLDPFL, ulong FFGIANIPOBK, ulong MMMBPCNCOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x14B7A00", Offset = "0x14B6A00", VA = "0x1814B7A00")]
	private static void CKMFHIKLDBF(uint FPHMKGOEILD, int NBPMLEBACBE, out uint CIOMBPDDIJL, out int AKFNFAOOCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x14B7B20", Offset = "0x14B6B20", VA = "0x1814B7B20")]
	private static bool GEEHAIOMOKD(ICJOJGBLNNM IMIIMLHLMBB, ICJOJGBLNNM PCMOEMJBGBJ, ICJOJGBLNNM HJHPAGOJMLM, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int EDDMIDAOJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x14B8660", Offset = "0x14B7660", VA = "0x1814B8660")]
	private static bool OGONHDKIFMM(double LNDKNIFDPNN, DFHOELFBLBO EAPLEPGNBDJ, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int OCPPDCOIKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x14B7140", Offset = "0x14B6140", VA = "0x1814B7140")]
	private static bool AEKPJPBLBKH(double LNDKNIFDPNN, DFHOELFBLBO EAPLEPGNBDJ, byte[] HKAAJCFANGC, out int GGLJPLLKLMG, out int FBCOLBDEPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x14B7EF0", Offset = "0x14B6EF0", VA = "0x1814B7EF0")]
	private static bool IDKJPDAOBCI(double MPHFKGJNMOK, ref KEHNKMCECIM GAHBGNKOLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x14B7230", Offset = "0x14B6230", VA = "0x1814B7230")]
	private static bool BABMENAOPLA(double MPHFKGJNMOK, ref KEHNKMCECIM GAHBGNKOLLK, FAIIPAOBDAG EAPLEPGNBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x14B82A0", Offset = "0x14B72A0", VA = "0x1814B82A0")]
	private static void JKFMHJLKMCE(byte[] IPEPACCMODI, int GGLJPLLKLMG, int FBCOLBDEPBA, int NJNPFOKFMMM, ref KEHNKMCECIM GAHBGNKOLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x14B8A00", Offset = "0x14B7A00", VA = "0x1814B8A00")]
	private static void OOFILHDKLCI(byte[] IPEPACCMODI, int GGLJPLLKLMG, int LOILPLMGAOK, ref KEHNKMCECIM GAHBGNKOLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B7860", Offset = "0x14B6860", VA = "0x1814B7860")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C728D0", Offset = "0x1C718D0", VA = "0x181C728D0")]
	public LKGKFGJDEIF(double CGNILIACKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFCA0", Offset = "0x1CEECA0", VA = "0x181CEFCA0")]
	public LKGKFGJDEIF(ICJOJGBLNNM CGNILIACKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF700", Offset = "0x1CEE700", VA = "0x181CEF700")]
	public ICJOJGBLNNM DBOBBBBCAHB()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF810", Offset = "0x1CEE810", VA = "0x181CEF810")]
	public ICJOJGBLNNM GFBHOJKBILH()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x698DA0", Offset = "0x697DA0", VA = "0x180698DA0")]
	public ulong NPNBJPGFFCP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFB90", Offset = "0x1CEEB90", VA = "0x181CEFB90")]
	public double ODDKFBOIOCJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF8D0", Offset = "0x1CEE8D0", VA = "0x181CEF8D0")]
	public double JILGKCMADAE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF7E0", Offset = "0x1CEE7E0", VA = "0x181CEF7E0")]
	public int GBEIFCGDNDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF780", Offset = "0x1CEE780", VA = "0x181CEF780")]
	public ulong EBEENLGOKDO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF950", Offset = "0x1CEE950", VA = "0x181CEF950")]
	public bool KDBOJCBLALE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF8B0", Offset = "0x1CEE8B0", VA = "0x181CEF8B0")]
	public bool HJNABLMJJFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFB60", Offset = "0x1CEEB60", VA = "0x181CEFB60")]
	public bool NNJKJKADGFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF6B0", Offset = "0x1CEE6B0", VA = "0x181CEF6B0")]
	public bool BLHIGENOLOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF6E0", Offset = "0x1CEE6E0", VA = "0x181CEF6E0")]
	public int CCEBHEBFJPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF970", Offset = "0x1CEE970", VA = "0x181CEF970")]
	public void KLEHMJLJOGC(out ICJOJGBLNNM NKJOGBMKNAB, out ICJOJGBLNNM KHLDEDHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFB00", Offset = "0x1CEEB00", VA = "0x181CEFB00")]
	public bool MOGBHHADNGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFB50", Offset = "0x1CEEB50", VA = "0x181CEFB50")]
	public double MPHFKGJNMOK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF7C0", Offset = "0x1CEE7C0", VA = "0x181CEF7C0")]
	public static int FJGDOBPEPFH(int NBFKFPHEKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF7B0", Offset = "0x1CEE7B0", VA = "0x181CEF7B0")]
	public static double EGMIKCIDOME()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFC00", Offset = "0x1CEEC00", VA = "0x181CEFC00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C7E10", Offset = "0x5C6E10", VA = "0x1805C7E10")]
	public MICNDKJFANN(float DAFIBMCLHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF18F0", Offset = "0x1CF08F0", VA = "0x181CF18F0")]
	public ICJOJGBLNNM DBOBBBBCAHB()
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5598D0", Offset = "0x5588D0", VA = "0x1805598D0")]
	public uint IKIPEKHHPDN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1980", Offset = "0x1CF0980", VA = "0x181CF1980")]
	public int GBEIFCGDNDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1960", Offset = "0x1CF0960", VA = "0x181CF1960")]
	public uint EBEENLGOKDO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF19A0", Offset = "0x1CF09A0", VA = "0x181CF19A0")]
	public bool KDBOJCBLALE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF19B0", Offset = "0x1CF09B0", VA = "0x181CF19B0")]
	public void KLEHMJLJOGC(out ICJOJGBLNNM NKJOGBMKNAB, out ICJOJGBLNNM KHLDEDHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1B20", Offset = "0x1CF0B20", VA = "0x181CF1B20")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C3D10", Offset = "0x14C2D10", VA = "0x1814C3D10")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD12E0", Offset = "0xBD02E0", VA = "0x180BD12E0")]
	public static void LBPDMHECPAL(int HFKKAJAGHJI, int CCNEDFGLIMI, out ICJOJGBLNNM CIOMBPDDIJL, out int OCPPDCOIKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xBD11E0", Offset = "0xBD01E0", VA = "0x180BD11E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CF9AC0", Offset = "0x1CF8AC0", VA = "0x181CF9AC0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1292610", Offset = "0x1291610", VA = "0x181292610")]
	public PPAOGPLCIHK(byte[] KFCJKMJDFKE, int BDOCBPFFDPK, int GGLJPLLKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xE2C9C0", Offset = "0xE2B9C0", VA = "0x180E2C9C0")]
	public int GGLJPLLKLMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9A60", Offset = "0x1CF8A60", VA = "0x181CF9A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF4700", Offset = "0x1CF3700", VA = "0x181CF4700")]
	private static byte[] AJJMNDIEAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF55B0", Offset = "0x1CF45B0", VA = "0x181CF55B0")]
	private static PPAOGPLCIHK JONHCCLBNGF(PPAOGPLCIHK HKAAJCFANGC)
	{
		return default(PPAOGPLCIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4EC0", Offset = "0x1CF3EC0", VA = "0x181CF4EC0")]
	private static PPAOGPLCIHK FDPHDDDLIHD(PPAOGPLCIHK HKAAJCFANGC)
	{
		return default(PPAOGPLCIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5690", Offset = "0x1CF4690", VA = "0x181CF5690")]
	private static void LEKLKBBFIEF(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, byte[] MGLDDGKJEDM, out int FJGODEPODFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4910", Offset = "0x1CF3910", VA = "0x181CF4910")]
	private static void EJPDLOJKOHA(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, byte[] OLCOOGOHMAB, int FJEMJMEDLKK, out PPAOGPLCIHK PGCLLAMLLAG, out int AEGCLGFDNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5B90", Offset = "0x1CF4B90", VA = "0x181CF5B90")]
	private static ulong NJIDGANEADL(PPAOGPLCIHK HKAAJCFANGC, out int EOFENAJNBBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5410", Offset = "0x1CF4410", VA = "0x181CF5410")]
	private static void GNPDBLIDOKK(PPAOGPLCIHK HKAAJCFANGC, out ICJOJGBLNNM AEOILPMENGG, out int KHCCHNNOCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5740", Offset = "0x1CF4740", VA = "0x181CF5740")]
	private static bool NBJFADFMIFH(PPAOGPLCIHK PGCLLAMLLAG, int LOILPLMGAOK, out double AEOILPMENGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5D50", Offset = "0x1CF4D50", VA = "0x181CF5D50")]
	private static ICJOJGBLNNM PFOOOHBEFHD(int LOILPLMGAOK)
	{
		return default(ICJOJGBLNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4FA0", Offset = "0x1CF3FA0", VA = "0x181CF4FA0")]
	private static bool FGHEPNEAIEG(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK, out double AEOILPMENGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5C20", Offset = "0x1CF4C20", VA = "0x181CF5C20")]
	private static bool OCECKPHNJHO(PPAOGPLCIHK PGCLLAMLLAG, int LOILPLMGAOK, out double HHAHHDPKMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF47E0", Offset = "0x1CF37E0", VA = "0x181CF47E0")]
	public static double? CAKBNADJNFN(PPAOGPLCIHK HKAAJCFANGC, int LOILPLMGAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4C30", Offset = "0x1CF3C30", VA = "0x181CF4C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B3B30", Offset = "0x14B2B30", VA = "0x1814B3B30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9B7F80", Offset = "0x9B6F80", VA = "0x1809B7F80")]
	public GKEOKIIGBCH(byte[] HKAAJCFANGC, int KJBKACPPODJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x14B3D10", Offset = "0x14B2D10", VA = "0x1814B3D10")]
	public static GKEOKIIGBCH ICOMJBHOLAC(GKEOKIIGBCH GNFIGHOBONH)
	{
		return default(GKEOKIIGBCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x14B3B70", Offset = "0x14B2B70", VA = "0x1814B3B70")]
	public static GKEOKIIGBCH BNJHJDGNPLG(GKEOKIIGBCH GNFIGHOBONH, int GGLJPLLKLMG)
	{
		return default(GKEOKIIGBCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x14B3D60", Offset = "0x14B2D60", VA = "0x1814B3D60")]
	public static int ODGGBCCOGPF(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x14B3BD0", Offset = "0x14B2BD0", VA = "0x1814B3BD0")]
	public static bool FJEMBADJMEI(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x14B3CF0", Offset = "0x14B2CF0", VA = "0x1814B3CF0")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, GKEOKIIGBCH JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x14B3BF0", Offset = "0x14B2BF0", VA = "0x1814B3BF0")]
	public static bool FJEMBADJMEI(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x14B3CB0", Offset = "0x14B2CB0", VA = "0x1814B3CB0")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x14B3CB0", Offset = "0x14B2CB0", VA = "0x1814B3CB0")]
	public static bool HDGACIKPOBA(GKEOKIIGBCH NNKIPLHOMAE, byte JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x14B3D20", Offset = "0x14B2D20", VA = "0x1814B3D20")]
	public static bool NGFDLBKKBOB(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x14B3C70", Offset = "0x14B2C70", VA = "0x1814B3C70")]
	public static bool GMJAIIPFDPE(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x14B3C30", Offset = "0x14B2C30", VA = "0x1814B3C30")]
	public static bool GMHEFHCDCON(GKEOKIIGBCH NNKIPLHOMAE, char JDKIOCBBPAN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x14B3D80", Offset = "0x14B2D80", VA = "0x1814B3D80")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C1630", Offset = "0x14C0630", VA = "0x1814C1630")]
	private static byte[] DEKOJDJMHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x14C1710", Offset = "0x14C0710", VA = "0x1814C1710")]
	private static byte[] HGHDBBBGEHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x14C1850", Offset = "0x14C0850", VA = "0x1814C1850")]
	public static double IFNEAFFKEID(byte[] HKAAJCFANGC, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x14C1570", Offset = "0x14C0570", VA = "0x1814C1570")]
	public static float CLICGOHMJEH(byte[] HKAAJCFANGC, int KJBKACPPODJ, out int JBAFDLDFKGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x14C13F0", Offset = "0x14C03F0", VA = "0x1814C13F0")]
	private static bool CJDNOPJFMCA(int KDNDPAEEMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x14C2AB0", Offset = "0x14C1AB0", VA = "0x1814C2AB0")]
	private static bool MMAGGLJNLBL(ref GKEOKIIGBCH IFKCAMEPHHB, GKEOKIIGBCH OHLDOAGOHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x14C2990", Offset = "0x14C1990", VA = "0x1814C2990")]
	private static bool IPBFCOOKKHL(ref GKEOKIIGBCH IFKCAMEPHHB, GKEOKIIGBCH OHLDOAGOHKP, byte[] EODJLEOKFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x14C17F0", Offset = "0x14C07F0", VA = "0x1814C17F0")]
	private static bool IFLGFKBACJI(ref GKEOKIIGBCH FNELENENEHA, byte[] IOLGJHAFBKL, int KJBKACPPODJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x853220", Offset = "0x852220", VA = "0x180853220")]
	private static double BCLNFEHPOPE(bool DFJLNNJENJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x14C1910", Offset = "0x14C0910", VA = "0x1814C1910")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF2570", Offset = "0xCF1570", VA = "0x180CF2570")]
	public OLJNJOELGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xCFCCC0", Offset = "0xCFBCC0", VA = "0x180CFCCC0")]
	public OLJNJOELGPF(FPCGCAFHCPC OJKNHIJCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x408CED0", Offset = "0x408BED0", VA = "0x18408CED0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x408E610", Offset = "0x408D610", VA = "0x18408E610", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF2570", Offset = "0xCF1570", VA = "0x180CF2570")]
	public FCDHNCJHIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xCFCCC0", Offset = "0xCFBCC0", VA = "0x180CFCCC0")]
	public FCDHNCJHIHO(FPCGCAFHCPC OJKNHIJCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x347BCF0", Offset = "0x347ACF0", VA = "0x18347BCF0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, List<T> MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x347C570", Offset = "0x347B570", VA = "0x18347C570", Slot = "5")]
	public List<T> IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class PHCDJIKFGEC<TElement, TIntermediate, TEnumerator, TCollection> : global::CHGOEAEDIKB<TCollection>, MKODBDPOJMK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA63C0", Offset = "0x3BA53C0", VA = "0x183BA63C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TCollection MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7A70", Offset = "0x3BA6A70", VA = "0x183BA7A70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
	protected PHCDJIKFGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class HAJEABEMJKP<TElement, TIntermediate, TCollection> : global::PHCDJIKFGEC<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x17E5B80", Offset = "0x17E4B80", VA = "0x1817E5B80", Slot = "6")]
	protected override IEnumerator<TElement> BGBEEAEAJCL(TCollection KEIJPKNBGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x17E5BD0", Offset = "0x17E4BD0", VA = "0x1817E5BD0")]
	protected HAJEABEMJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class MLDBOOBKCAC<TElement, TCollection> : global::HAJEABEMJKP<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected sealed override TCollection AKPIIOLAJBO(ref TCollection OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class ACOFAAGDAJB<TElement, TCollection> : global::MLDBOOBKCAC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1403CC0", Offset = "0x1402CC0", VA = "0x181403CC0", Slot = "7")]
	protected override TCollection GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1403CE0", Offset = "0x1402CE0", VA = "0x181403CE0", Slot = "8")]
	protected override void NENJMCKJAJO(ref TCollection DBAKNDFCOIL, int HOOANEAGKNH, TElement MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GOCOPCOHHJA<T> : global::PHCDJIKFGEC<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FF0", Offset = "0x38F8FF0", VA = "0x1838F9FF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref LinkedList<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override LinkedList<T> AKPIIOLAJBO(ref LinkedList<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override LinkedList<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x38F9F90", Offset = "0x38F8F90", VA = "0x1838F9F90", Slot = "6")]
	protected override LinkedList<T>.Enumerator BGBEEAEAJCL(LinkedList<T> KEIJPKNBGAA)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class EECBMJKHJKK<T> : global::PHCDJIKFGEC<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FF0", Offset = "0x38F8FF0", VA = "0x1838F9FF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref Queue<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override Queue<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x31C9DF0", Offset = "0x31C8DF0", VA = "0x1831C9DF0", Slot = "6")]
	protected override Queue<T>.Enumerator BGBEEAEAJCL(Queue<T> KEIJPKNBGAA)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override Queue<T> AKPIIOLAJBO(ref Queue<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LNGKJJBAMLJ<T> : global::PHCDJIKFGEC<T, global::CDAEICHCHHJ<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A50", Offset = "0x8C5A50", VA = "0x1808C6A50", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x31C9E40", Offset = "0x31C8E40", VA = "0x1831C9E40", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x31C9DF0", Offset = "0x31C8DF0", VA = "0x1831C9DF0", Slot = "6")]
	protected override Stack<T>.Enumerator BGBEEAEAJCL(Stack<T> KEIJPKNBGAA)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x31C9D10", Offset = "0x31C8D10", VA = "0x1831C9D10", Slot = "9")]
	protected override Stack<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FAHICIMOLAN<T> : global::PHCDJIKFGEC<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FF0", Offset = "0x38F8FF0", VA = "0x1838F9FF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref HashSet<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override HashSet<T> AKPIIOLAJBO(ref HashSet<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override HashSet<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x31C9DF0", Offset = "0x31C8DF0", VA = "0x1831C9DF0", Slot = "6")]
	protected override HashSet<T>.Enumerator BGBEEAEAJCL(HashSet<T> KEIJPKNBGAA)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class HPIIMAAAPII<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A50", Offset = "0x8C5A50", VA = "0x1808C6A50", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6970", Offset = "0x8C5970", VA = "0x1808C6970", Slot = "9")]
	protected override ReadOnlyCollection<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A00", Offset = "0x8C5A00", VA = "0x1808C6A00", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GPCPINFCLIB<T> : global::HAJEABEMJKP<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FF0", Offset = "0x38F8FF0", VA = "0x1838F9FF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref List<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override List<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override IList<T> AKPIIOLAJBO(ref List<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GIGCBPMJAAP<T> : global::HAJEABEMJKP<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FF0", Offset = "0x38F8FF0", VA = "0x1838F9FF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref List<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override List<T> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override ICollection<T> AKPIIOLAJBO(ref List<T> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class CCBNDKCBLID<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x30F28A0", Offset = "0x30F18A0", VA = "0x1830F28A0", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x30F2800", Offset = "0x30F1800", VA = "0x1830F2800", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x30F27E0", Offset = "0x30F17E0", VA = "0x1830F27E0", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD9DB0", Offset = "0xBD8DB0", VA = "0x180BD9DB0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IEnumerable MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xBDA010", Offset = "0xBD9010", VA = "0x180BDA010", Slot = "5")]
	public IEnumerable IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF5F40", Offset = "0x1CF4F40", VA = "0x181CF5F40", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ICollection MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF61E0", Offset = "0x1CF51E0", VA = "0x181CF61E0", Slot = "5")]
	public ICollection IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B9220", Offset = "0x14B8220", VA = "0x1814B9220", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IList MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x14B94C0", Offset = "0x14B84C0", VA = "0x1814B94C0", Slot = "5")]
	public IList IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HJJFAIEACPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LFEEDOKPLMB<T> : global::HAJEABEMJKP<T, global::CDAEICHCHHJ<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x39235C0", Offset = "0x39225C0", VA = "0x1839235C0", Slot = "8")]
	protected override void NENJMCKJAJO(ref global::CDAEICHCHHJ<T> DBAKNDFCOIL, int HOOANEAGKNH, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x31C9E40", Offset = "0x31C8E40", VA = "0x1831C9E40", Slot = "7")]
	protected override global::CDAEICHCHHJ<T> GPCBEJLMGEM()
	{
		return default(global::CDAEICHCHHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3923580", Offset = "0x3922580", VA = "0x183923580", Slot = "9")]
	protected override IReadOnlyList<T> AKPIIOLAJBO(ref global::CDAEICHCHHJ<T> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA820", Offset = "0x2CD9820", VA = "0x182CDA820")]
	public LFEEDOKPLMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class BHFMGMAPKDK
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xBCF210", Offset = "0xBCE210", VA = "0x180BCF210")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF63C0", Offset = "0x1CF53C0", VA = "0x181CF63C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, DateTime MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6810", Offset = "0x1CF5810", VA = "0x181CF6810", Slot = "5")]
	public DateTime IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF0020", Offset = "0x1CEF020", VA = "0x181CF0020", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, DateTimeOffset MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1CF03F0", Offset = "0x1CEF3F0", VA = "0x181CF03F0", Slot = "5")]
	public DateTimeOffset IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD8E20", Offset = "0xBD7E20", VA = "0x180BD8E20", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TimeSpan MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xBD92C0", Offset = "0xBD82C0", VA = "0x180BD92C0", Slot = "5")]
	public TimeSpan IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public GAOOAKNBAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class LEPKBFACBLN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::CHGOEAEDIKB<TDictionary>, MKODBDPOJMK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x391F4C0", Offset = "0x391E4C0", VA = "0x18391F4C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, TDictionary MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3922C00", Offset = "0x3921C00", VA = "0x183922C00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
	protected LEPKBFACBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class IPCEIILJBCJ<TKey, TValue, TIntermediate, TDictionary> : global::LEPKBFACBLN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x17E5B80", Offset = "0x17E4B80", VA = "0x1817E5B80", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> BGBEEAEAJCL(TDictionary KEIJPKNBGAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class DLDLONHNNIB<TKey, TValue, TDictionary> : global::IPCEIILJBCJ<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override TDictionary AKPIIOLAJBO(ref TDictionary OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class GFEDNOJBCAI<TKey, TValue> : global::LEPKBFACBLN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3A385B0", Offset = "0x3A375B0", VA = "0x183A385B0", Slot = "8")]
	protected override void NENJMCKJAJO(ref Dictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override Dictionary<TKey, TValue> AKPIIOLAJBO(ref Dictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3A38560", Offset = "0x3A37560", VA = "0x183A38560", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator BGBEEAEAJCL(Dictionary<TKey, TValue> KEIJPKNBGAA)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x140D9D0", Offset = "0x140C9D0", VA = "0x18140D9D0")]
	public GFEDNOJBCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class CGEEPICIGPD<TKey, TValue, TDictionary> : global::DLDLONHNNIB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x30F8CF0", Offset = "0x30F7CF0", VA = "0x1830F8CF0", Slot = "8")]
	protected override void NENJMCKJAJO(ref TDictionary DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x30F8CD0", Offset = "0x30F7CD0", VA = "0x1830F8CD0", Slot = "7")]
	protected override TDictionary GPCBEJLMGEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class IGAELHMMLFJ<TKey, TValue> : global::IPCEIILJBCJ<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8CB330", Offset = "0x8CA330", VA = "0x1808CB330", Slot = "8")]
	protected override void NENJMCKJAJO(ref Dictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override IDictionary<TKey, TValue> AKPIIOLAJBO(ref Dictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class OOGPPDJPFMC<TKey, TValue> : global::DLDLONHNNIB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8CB330", Offset = "0x8CA330", VA = "0x1808CB330", Slot = "8")]
	protected override void NENJMCKJAJO(ref SortedList<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override SortedList<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class FAFFMBHFLDJ<TKey, TValue> : global::LEPKBFACBLN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8CB330", Offset = "0x8CA330", VA = "0x1808CB330", Slot = "8")]
	protected override void NENJMCKJAJO(ref SortedDictionary<TKey, TValue> DBAKNDFCOIL, int HOOANEAGKNH, TKey MKDJIBNCKNC, TValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2C0", Offset = "0x8CA2C0", VA = "0x1808CB2C0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> AKPIIOLAJBO(ref SortedDictionary<TKey, TValue> OAGOHGHOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2D0", Offset = "0x8CA2D0", VA = "0x1808CB2D0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GPCBEJLMGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x4345BD0", Offset = "0x4344BD0", VA = "0x184345BD0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF82F0", Offset = "0x1CF72F0", VA = "0x181CF82F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, IDictionary MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8670", Offset = "0x1CF7670", VA = "0x181CF8670", Slot = "5")]
	public IDictionary IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCDDD0", Offset = "0xBCCDD0", VA = "0x180BCDDD0")]
	public APBLDOJLDOE(params IHNIPBDLGGD[] PONJFHCADKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xBCD3D0", Offset = "0xBCC3D0", VA = "0x180BCD3D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xBCDD40", Offset = "0xBCCD40", VA = "0x180BCDD40", Slot = "5")]
	public object IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EHMCPLGOAGI
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xBD5E30", Offset = "0xBD4E30", VA = "0x180BD5E30")]
	public static object LAJHCLCCLFA(Type ONIHNDBDHGC, out bool HHDNKNNDMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xBD5650", Offset = "0xBD4650", VA = "0x180BD5650")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public ILPKOOLLNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x385B1F0", Offset = "0x385A1F0", VA = "0x18385B1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public HIABHPIAIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3859370", Offset = "0x3858370", VA = "0x183859370")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public EKKGDBPDDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3857430", Offset = "0x3856430", VA = "0x183857430")]
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
	[Cpp2IlInjected.Address(RVA = "0x3867A50", Offset = "0x3866A50", VA = "0x183867A50")]
	static NCGGMPGGABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x386C2D0", Offset = "0x386B2D0", VA = "0x18386C2D0")]
	public NCGGMPGGABE(bool EPLMIALLCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3866350", Offset = "0x3865350", VA = "0x183866350", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3867140", Offset = "0x3866140", VA = "0x183867140", Slot = "5")]
	public T IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3865BB0", Offset = "0x3864BB0", VA = "0x183865BB0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, T MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3867900", Offset = "0x3866900", VA = "0x183867900", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x38A57C0", Offset = "0x38A47C0", VA = "0x1838A57C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x38A5920", Offset = "0x38A4920", VA = "0x1838A5920", Slot = "5")]
	public T? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C6F60", Offset = "0x8C5F60", VA = "0x1808C6F60")]
	public NAGNDDHEKOG(global::CHGOEAEDIKB<T> OMOOBBJDLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x38638E0", Offset = "0x38628E0", VA = "0x1838638E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, T? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3864270", Offset = "0x3863270", VA = "0x183864270", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF9B40", Offset = "0x1CF8B40", VA = "0x181CF9B40", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9B60", Offset = "0x1CF8B60", VA = "0x181CF9B60", Slot = "5")]
	public sbyte IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9B00", Offset = "0x1CF8B00", VA = "0x181CF9B00", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, sbyte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9B70", Offset = "0x1CF8B70", VA = "0x181CF9B70", Slot = "7")]
	public sbyte NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD69D0", Offset = "0xBD59D0", VA = "0x180BD69D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xBD6A50", Offset = "0xBD5A50", VA = "0x180BD6A50", Slot = "5")]
	public sbyte? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xBD68D0", Offset = "0xBD58D0", VA = "0x180BD68D0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, sbyte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xBD6AC0", Offset = "0xBD5AC0", VA = "0x180BD6AC0", Slot = "7")]
	public sbyte? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD8100", Offset = "0xBD7100", VA = "0x180BD8100", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, sbyte[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xBD82A0", Offset = "0xBD72A0", VA = "0x180BD82A0", Slot = "5")]
	public sbyte[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF3640", Offset = "0x1CF2640", VA = "0x181CF3640", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3660", Offset = "0x1CF2660", VA = "0x181CF3660", Slot = "5")]
	public short IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3600", Offset = "0x1CF2600", VA = "0x181CF3600", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, short MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3670", Offset = "0x1CF2670", VA = "0x181CF3670", Slot = "7")]
	public short NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD0FF0", Offset = "0xBCFFF0", VA = "0x180BD0FF0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xBD1070", Offset = "0xBD0070", VA = "0x180BD1070", Slot = "5")]
	public short? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xBD0EF0", Offset = "0xBCFEF0", VA = "0x180BD0EF0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, short? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xBD10E0", Offset = "0xBD00E0", VA = "0x180BD10E0", Slot = "7")]
	public short? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C4710", Offset = "0x14C3710", VA = "0x1814C4710", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, short[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x14C47D0", Offset = "0x14C37D0", VA = "0x1814C47D0", Slot = "5")]
	public short[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBC9B60", Offset = "0xBC8B60", VA = "0x180BC9B60", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xBC9B90", Offset = "0xBC8B90", VA = "0x180BC9B90", Slot = "5")]
	public int IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xBC9AA0", Offset = "0xBC8AA0", VA = "0x180BC9AA0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, int MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xBC9BA0", Offset = "0xBC8BA0", VA = "0x180BC9BA0", Slot = "7")]
	public int NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF9610", Offset = "0x1CF8610", VA = "0x181CF9610", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9680", Offset = "0x1CF8680", VA = "0x181CF9680", Slot = "5")]
	public int? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9590", Offset = "0x1CF8590", VA = "0x181CF9590", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, int? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF96F0", Offset = "0x1CF86F0", VA = "0x181CF96F0", Slot = "7")]
	public int? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCB110", Offset = "0xBCA110", VA = "0x180BCB110", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, int[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xBCB2B0", Offset = "0xBCA2B0", VA = "0x180BCB2B0", Slot = "5")]
	public int[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BB7F0", Offset = "0x14BA7F0", VA = "0x1814BB7F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x14BB810", Offset = "0x14BA810", VA = "0x1814BB810", Slot = "5")]
	public long IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x14BB7B0", Offset = "0x14BA7B0", VA = "0x1814BB7B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, long MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x14BB820", Offset = "0x14BA820", VA = "0x1814BB820", Slot = "7")]
	public long NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF3130", Offset = "0x1CF2130", VA = "0x181CF3130", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF31A0", Offset = "0x1CF21A0", VA = "0x181CF31A0", Slot = "5")]
	public long? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF30B0", Offset = "0x1CF20B0", VA = "0x181CF30B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, long? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3230", Offset = "0x1CF2230", VA = "0x181CF3230", Slot = "7")]
	public long? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD3390", Offset = "0xBD2390", VA = "0x180BD3390", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, long[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xBD3530", Offset = "0xBD2530", VA = "0x180BD3530", Slot = "5")]
	public long[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD54A0", Offset = "0xBD44A0", VA = "0x180BD54A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xBD54E0", Offset = "0xBD44E0", VA = "0x180BD54E0", Slot = "5")]
	public byte IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xBD53E0", Offset = "0xBD43E0", VA = "0x180BD53E0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, byte MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xBD54F0", Offset = "0xBD44F0", VA = "0x180BD54F0", Slot = "7")]
	public byte NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF8A30", Offset = "0x1CF7A30", VA = "0x181CF8A30", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8AA0", Offset = "0x1CF7AA0", VA = "0x181CF8AA0", Slot = "5")]
	public byte? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF89B0", Offset = "0x1CF79B0", VA = "0x181CF89B0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, byte? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8B10", Offset = "0x1CF7B10", VA = "0x181CF8B10", Slot = "7")]
	public byte? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBC96A0", Offset = "0xBC86A0", VA = "0x180BC96A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xBC96E0", Offset = "0xBC86E0", VA = "0x180BC96E0", Slot = "5")]
	public ushort IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xBC95E0", Offset = "0xBC85E0", VA = "0x180BC95E0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ushort MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xBC96F0", Offset = "0xBC86F0", VA = "0x180BC96F0", Slot = "7")]
	public ushort NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF2840", Offset = "0x1CF1840", VA = "0x181CF2840", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF28B0", Offset = "0x1CF18B0", VA = "0x181CF28B0", Slot = "5")]
	public ushort? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF27C0", Offset = "0x1CF17C0", VA = "0x181CF27C0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ushort? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2920", Offset = "0x1CF1920", VA = "0x181CF2920", Slot = "7")]
	public ushort? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF13F0", Offset = "0x1CF03F0", VA = "0x181CF13F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ushort[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF14B0", Offset = "0x1CF04B0", VA = "0x181CF14B0", Slot = "5")]
	public ushort[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD0C90", Offset = "0xBCFC90", VA = "0x180BD0C90", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xBD0CC0", Offset = "0xBCFCC0", VA = "0x180BD0CC0", Slot = "5")]
	public uint IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xBD0BD0", Offset = "0xBCFBD0", VA = "0x180BD0BD0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, uint MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xBD0CD0", Offset = "0xBCFCD0", VA = "0x180BD0CD0", Slot = "7")]
	public uint NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C2E80", Offset = "0x14C1E80", VA = "0x1814C2E80", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x14C2EF0", Offset = "0x14C1EF0", VA = "0x1814C2EF0", Slot = "5")]
	public uint? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x14C2E00", Offset = "0x14C1E00", VA = "0x1814C2E00", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, uint? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x14C2FA0", Offset = "0x14C1FA0", VA = "0x1814C2FA0", Slot = "7")]
	public uint? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCF2B0", Offset = "0xBCE2B0", VA = "0x180BCF2B0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, uint[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xBCF450", Offset = "0xBCE450", VA = "0x180BCF450", Slot = "5")]
	public uint[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF7E40", Offset = "0x1CF6E40", VA = "0x181CF7E40", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7E60", Offset = "0x1CF6E60", VA = "0x181CF7E60", Slot = "5")]
	public ulong IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7E00", Offset = "0x1CF6E00", VA = "0x181CF7E00", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ulong MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7E70", Offset = "0x1CF6E70", VA = "0x181CF7E70", Slot = "7")]
	public ulong NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF16D0", Offset = "0x1CF06D0", VA = "0x181CF16D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1740", Offset = "0x1CF0740", VA = "0x181CF1740", Slot = "5")]
	public ulong? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1650", Offset = "0x1CF0650", VA = "0x181CF1650", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, ulong? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1CF17D0", Offset = "0x1CF07D0", VA = "0x181CF17D0", Slot = "7")]
	public ulong? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBC92A0", Offset = "0xBC82A0", VA = "0x180BC92A0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ulong[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xBC9440", Offset = "0xBC8440", VA = "0x180BC9440", Slot = "5")]
	public ulong[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD4EC0", Offset = "0xBD3EC0", VA = "0x180BD4EC0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xBD4ED0", Offset = "0xBD3ED0", VA = "0x180BD4ED0", Slot = "5")]
	public float IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xBD4E10", Offset = "0xBD3E10", VA = "0x180BD4E10", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, float MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xBD4EE0", Offset = "0xBD3EE0", VA = "0x180BD4EE0", Slot = "7")]
	public float NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF7C20", Offset = "0x1CF6C20", VA = "0x181CF7C20", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7C90", Offset = "0x1CF6C90", VA = "0x181CF7C90", Slot = "5")]
	public float? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7BA0", Offset = "0x1CF6BA0", VA = "0x181CF7BA0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, float? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7D00", Offset = "0x1CF6D00", VA = "0x181CF7D00", Slot = "7")]
	public float? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C49D0", Offset = "0x14C39D0", VA = "0x1814C49D0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, float[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x14C4A90", Offset = "0x14C3A90", VA = "0x1814C4A90", Slot = "5")]
	public float[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCFEE0", Offset = "0xBCEEE0", VA = "0x180BCFEE0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xBCFEF0", Offset = "0xBCEEF0", VA = "0x180BCFEF0", Slot = "5")]
	public double IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xBCFE30", Offset = "0xBCEE30", VA = "0x180BCFE30", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, double MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xBCFF00", Offset = "0xBCEF00", VA = "0x180BCFF00", Slot = "7")]
	public double NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF2AA0", Offset = "0x1CF1AA0", VA = "0x181CF2AA0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2B10", Offset = "0x1CF1B10", VA = "0x181CF2B10", Slot = "5")]
	public double? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2A20", Offset = "0x1CF1A20", VA = "0x181CF2A20", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, double? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2BA0", Offset = "0x1CF1BA0", VA = "0x181CF2BA0", Slot = "7")]
	public double? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B5C30", Offset = "0x14B4C30", VA = "0x1814B5C30", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, double[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x14B5CF0", Offset = "0x14B4CF0", VA = "0x1814B5CF0", Slot = "5")]
	public double[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14C4520", Offset = "0x14C3520", VA = "0x1814C4520", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x14C4540", Offset = "0x14C3540", VA = "0x1814C4540", Slot = "5")]
	public bool IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x14C44E0", Offset = "0x14C34E0", VA = "0x1814C44E0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, bool MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x14C4550", Offset = "0x14C3550", VA = "0x1814C4550", Slot = "7")]
	public bool NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF2EC0", Offset = "0x1CF1EC0", VA = "0x181CF2EC0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2F30", Offset = "0x1CF1F30", VA = "0x181CF2F30", Slot = "5")]
	public bool? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2E40", Offset = "0x1CF1E40", VA = "0x181CF2E40", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, bool? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2FA0", Offset = "0x1CF1FA0", VA = "0x181CF2FA0", Slot = "7")]
	public bool? NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD38C0", Offset = "0xBD28C0", VA = "0x180BD38C0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, bool[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBD3A40", Offset = "0xBD2A40", VA = "0x180BD3A40", Slot = "5")]
	public bool[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD7060", Offset = "0xBD6060", VA = "0x180BD7060", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, object MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xBD7A10", Offset = "0xBD6A10", VA = "0x180BD7A10", Slot = "5")]
	public object IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF3490", Offset = "0x1CF2490", VA = "0x181CF3490", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, byte[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3520", Offset = "0x1CF2520", VA = "0x181CF3520", Slot = "5")]
	public byte[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF1B60", Offset = "0x1CF0B60", VA = "0x181CF1B60", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, ArraySegment<byte> MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C00", Offset = "0x1CF0C00", VA = "0x181CF1C00", Slot = "5")]
	public ArraySegment<byte> IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCFDA0", Offset = "0xBCEDA0", VA = "0x180BCFDA0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, string MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xBCFDC0", Offset = "0xBCEDC0", VA = "0x180BCFDC0", Slot = "5")]
	public string IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xBCFDA0", Offset = "0xBCEDA0", VA = "0x180BCFDA0", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, string MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xBCFDC0", Offset = "0xBCEDC0", VA = "0x180BCFDC0", Slot = "7")]
	public string NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14BB4F0", Offset = "0x14BA4F0", VA = "0x1814BB4F0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, string[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x14BB5B0", Offset = "0x14BA5B0", VA = "0x1814BB5B0", Slot = "5")]
	public string[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B7030", Offset = "0x14B6030", VA = "0x1814B7030", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x14B70B0", Offset = "0x14B60B0", VA = "0x1814B70B0", Slot = "5")]
	public char IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CEFE30", Offset = "0x1CEEE30", VA = "0x181CEFE30", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char? MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFF00", Offset = "0x1CEEF00", VA = "0x181CEFF00", Slot = "5")]
	public char? IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF7770", Offset = "0x1CF6770", VA = "0x181CF7770", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, char[] MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF78F0", Offset = "0x1CF68F0", VA = "0x181CF78F0", Slot = "5")]
	public char[] IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CF1F50", Offset = "0x1CF0F50", VA = "0x181CF1F50", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Guid MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2030", Offset = "0x1CF1030", VA = "0x181CF2030", Slot = "5")]
	public Guid IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1E70", Offset = "0x1CF0E70", VA = "0x181CF1E70", Slot = "6")]
	public void AAGHDKLPGKN(ref BFLLELOAEDL CCLGELJKLAA, Guid MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2030", Offset = "0x1CF1030", VA = "0x181CF2030", Slot = "7")]
	public Guid NLOMFAADLKI(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x722600", Offset = "0x721600", VA = "0x180722600")]
	public IJCEGKAJEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7225D0", Offset = "0x7215D0", VA = "0x1807225D0")]
	public IJCEGKAJEIJ(bool FEIFBPHLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x14BC440", Offset = "0x14BB440", VA = "0x1814BC440", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, decimal MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x14BC580", Offset = "0x14BB580", VA = "0x1814BC580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCFFD0", Offset = "0xBCEFD0", VA = "0x180BCFFD0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Uri MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0xBD0080", Offset = "0xBCF080", VA = "0x180BD0080", Slot = "5")]
	public Uri IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0x14B3390", Offset = "0x14B2390", VA = "0x1814B3390", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Version MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x14B3440", Offset = "0x14B2440", VA = "0x1814B3440", Slot = "5")]
	public Version IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD5200", Offset = "0xBD4200", VA = "0x180BD5200", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, StringBuilder MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xBD5250", Offset = "0xBD4250", VA = "0x180BD5250", Slot = "5")]
	public StringBuilder IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD02E0", Offset = "0xBCF2E0", VA = "0x180BD02E0", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, BitArray MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xBD03E0", Offset = "0xBCF3E0", VA = "0x180BD03E0", Slot = "5")]
	public BitArray IACEKGNLJIN(ref IOOLDPGGJIO JFKAGENJIJO, IHNIPBDLGGD OMCEHKJNIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
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
	[Cpp2IlInjected.Address(RVA = "0xBD0980", Offset = "0xBCF980", VA = "0x180BD0980")]
	public CGPFBJPKMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xBD0930", Offset = "0xBCF930", VA = "0x180BD0930")]
	public CGPFBJPKMOA(bool IMDHIECDLNM, bool HILNFOOBCEP, bool CEMAFOCGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xBD0680", Offset = "0xBCF680", VA = "0x180BD0680", Slot = "4")]
	public void DFIGKGIDJJK(ref BFLLELOAEDL CCLGELJKLAA, Type MPHFKGJNMOK, IHNIPBDLGGD OMCEHKJNIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xBD0770", Offset = "0xBCF770", VA = "0x180BD0770", Slot = "5")]
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
