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
public class GJPJFCBJMKH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55C480", Offset = "0x55B080", VA = "0x18055C480")]
	public GJPJFCBJMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FKEINAIGGNH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55C480", Offset = "0x55B080", VA = "0x18055C480")]
	public FKEINAIGGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KAIDBDGNHED : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x55C480", Offset = "0x55B080", VA = "0x18055C480")]
	public KAIDBDGNHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NNDIHGGDOND : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x55C480", Offset = "0x55B080", VA = "0x18055C480")]
	public NNDIHGGDOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JHAOFDDMJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3013ED0", Offset = "0x3012AD0", VA = "0x183013ED0")]
	public static bool PKCNBCMAKOO(this TypeInfo CEEEOOFNMPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NMDIGEOGBFH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type ELJHKGDMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] OLPLBNIIFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67ACA0", Offset = "0x6798A0", VA = "0x18067ACA0")]
	public NMDIGEOGBFH(Type KIIEGNOJDKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class GCNMNJBOCNA : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void HJCBAJHIAPL<T>(ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T JMFJBNJNHAD<T>(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL NGIPEEJHLPK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FHLLIKOGGFC
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EPIIBJLGPNA<T> : FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ODFGCJPFNPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OMLBIIILDNN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GJLMDADJGJF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A90CC0", Offset = "0x2A8F8C0", VA = "0x182A90CC0")]
	public static global::EPIIBJLGPNA<T> NCCGOIFKLNC<T>(this IOIBOLJBEGL NGIPEEJHLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C090", Offset = "0x2F4AC90", VA = "0x182F4C090")]
	public static object BIADGIPBFKK(this IOIBOLJBEGL NGIPEEJHLPK, Type CEEEOOFNMPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MKLEBLFHEAL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x301AE80", Offset = "0x3019A80", VA = "0x18301AE80")]
	public MKLEBLFHEAL(string PFLCCLDEBMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IJNHJAICOBP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OECIIAPPMOH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] EINFEEMFPOI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CGOEGNKGCGK;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x30251B0", Offset = "0x3023DB0", VA = "0x1830251B0")]
		public static byte[] DMLFPFKJIEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3025230", Offset = "0x3023E30", VA = "0x183025230")]
		public static char[] EKLIKCBAPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GKLBFEACLLA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] NKJMBBGCBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EDEEEGMMOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IHLNGFCHHLC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GDEJHNILKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3010660", Offset = "0x300F260", VA = "0x183010660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3012820", Offset = "0x3011420", VA = "0x183012820")]
	public IJNHJAICOBP(byte[] EDEEEGMMOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3012640", Offset = "0x3011240", VA = "0x183012640")]
	public IJNHJAICOBP(byte[] EDEEEGMMOHA, int IHLNGFCHHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x300FDF0", Offset = "0x300E9F0", VA = "0x18300FDF0")]
	private NLCOIKHGMEM BDOBJMDLOKF(string LAHGJIHNOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3012480", Offset = "0x3011080", VA = "0x183012480")]
	private NLCOIKHGMEM PNGDEDCAGNF(string PFLCCLDEBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CB90", Offset = "0x2F4B790", VA = "0x182F4CB90")]
	public void DBMCODEALJN(int IHLNGFCHHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x865D30", Offset = "0x864930", VA = "0x180865D30")]
	public byte[] PDLJOOKLHGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7844C0", Offset = "0x7830C0", VA = "0x1807844C0")]
	public int NHCJNBJMGHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3011210", Offset = "0x300FE10", VA = "0x183011210")]
	public KPPNANAAMNP FCKJDAGKNKI()
	{
		return default(KPPNANAAMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30116C0", Offset = "0x30102C0", VA = "0x1830116C0")]
	public void HHODNADHCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30104C0", Offset = "0x300F0C0", VA = "0x1830104C0")]
	public bool CGBDDDLIMOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3011CE0", Offset = "0x30108E0", VA = "0x183011CE0")]
	public bool LBFCFACGBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3010920", Offset = "0x300F520", VA = "0x183010920")]
	public void EIPKCFOOHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30119B0", Offset = "0x30105B0", VA = "0x1830119B0")]
	public bool HODLMFHNCFP(ref int MAKGNGIINDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3011F20", Offset = "0x3010B20", VA = "0x183011F20")]
	public bool NACGMJBLKDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3011D80", Offset = "0x3010980", VA = "0x183011D80")]
	public void LPECKELMOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3011BF0", Offset = "0x30107F0", VA = "0x183011BF0")]
	public bool JIBMNBNDNPJ(ref int MAKGNGIINDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3011F90", Offset = "0x3010B90", VA = "0x183011F90")]
	public bool OJPHODCHIAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3012000", Offset = "0x3010C00", VA = "0x183012000")]
	public void OMJCCDHMNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3011610", Offset = "0x3010210", VA = "0x183011610")]
	public bool GJOJFJGBGKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3011E80", Offset = "0x3010A80", VA = "0x183011E80")]
	public void MONCONCDBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30109C0", Offset = "0x300F5C0", VA = "0x1830109C0")]
	private void ELDINJGCDIO(out byte[] ENGJLPNOKAG, out int GJJLNOLDBMH, out int FOIHKFCNLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30113A0", Offset = "0x300FFA0", VA = "0x1830113A0")]
	private static int FDFAOJJENJH(char BDJKEBGEAJO, char GONCOEMNHPC, char PKPFJHLMNLB, char BFNPMNIFJNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x300FD20", Offset = "0x300E920", VA = "0x18300FD20")]
	private static int AHBMCEHFNPB(char JJCLMNFFLAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3011450", Offset = "0x3010050", VA = "0x183011450")]
	public ArraySegment<byte> FMIDOIBFAPA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3010880", Offset = "0x300F480", VA = "0x183010880")]
	public string EIPBCKKMIAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3011D50", Offset = "0x3010950", VA = "0x183011D50")]
	public string LEBMKLLADOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3011800", Offset = "0x3010400", VA = "0x183011800")]
	public ArraySegment<byte> HMLINKHHCNE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3011680", Offset = "0x3010280", VA = "0x183011680")]
	public ArraySegment<byte> GNLGNDKIEEI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30120A0", Offset = "0x3010CA0", VA = "0x1830120A0")]
	public bool PHPMEBOBMND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30107C0", Offset = "0x300F3C0", VA = "0x1830107C0")]
	private static bool EIOMPBJIHAD(byte PKPFJHLMNLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3010290", Offset = "0x300EE90", VA = "0x183010290")]
	private void CAKDGCGMJBN(KPPNANAAMNP FOKGBGEFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3011A40", Offset = "0x3010640", VA = "0x183011A40")]
	public void IHLEIGBFNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3011540", Offset = "0x3010140", VA = "0x183011540")]
	private void FOMBCGEGGAL(int LIAAMAOKICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3010680", Offset = "0x300F280", VA = "0x183010680")]
	public sbyte EGBLLDBHLJB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3011C80", Offset = "0x3010880", VA = "0x183011C80")]
	public short KLDANFFIMJK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3010460", Offset = "0x300F060", VA = "0x183010460")]
	public int CEFNBFEIKKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3011B10", Offset = "0x3010710", VA = "0x183011B10")]
	public long IMKPBCAPCDL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3011B90", Offset = "0x3010790", VA = "0x183011B90")]
	public byte JBDDDNPMFLO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x300FCC0", Offset = "0x300E8C0", VA = "0x18300FCC0")]
	public ushort AEPKMAIFCAK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3011E20", Offset = "0x3010A20", VA = "0x183011E20")]
	public uint MJJBIDNHCNF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30105E0", Offset = "0x300F1E0", VA = "0x1830105E0")]
	public ulong CNMFONHFCBH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3011150", Offset = "0x300FD50", VA = "0x183011150")]
	public float EPNJJBONDOJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3011A50", Offset = "0x3010650", VA = "0x183011A50")]
	public double IIHFJACGHHA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30106D0", Offset = "0x300F2D0", VA = "0x1830106D0")]
	public ArraySegment<byte> EHOCMDOEFMD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3012300", Offset = "0x3010F00", VA = "0x183012300")]
	private static int PJDOHFGLEKF(byte[] EDEEEGMMOHA, int IHLNGFCHHLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NLCOIKHGMEM : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference PONGGLEBCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FNOLLEOIOGE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int ONNGOMKJMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x12BE040", Offset = "0x12BCC40", VA = "0x1812BE040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CNLMMKKIOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6E10", Offset = "0x5F5A10", VA = "0x1805F6E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x301C3D0", Offset = "0x301AFD0", VA = "0x18301C3D0")]
	public NLCOIKHGMEM(string PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x301C300", Offset = "0x301AF00", VA = "0x18301C300")]
	public NLCOIKHGMEM(string PFLCCLDEBMC, byte[] PKHBFGCCKNL, int IHLNGFCHHLC, int FNOLLEOIOGE, string PMNKDFGCLEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AOEBJEHBKAM
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BBBGEJNDGOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void KFOEMJNOOAN(ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object OMOEKAGIMFB(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL NGIPEEJHLPK);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class CEDDAIFHJOL
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class DKBBAGDEFIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
				public DKBBAGDEFIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2F42D90", Offset = "0x2F41990", VA = "0x182F42D90")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2F42DD0", Offset = "0x2F419D0", VA = "0x182F42DD0")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, IOIBOLJBEGL, byte[]> HBICEGKNBBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, IOIBOLJBEGL> HCIFGBCFANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly KFOEMJNOOAN AFKDMEPBNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, IOIBOLJBEGL, ArraySegment<byte>> GLLLMIBJMJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, IOIBOLJBEGL, string> OJMKIGIGBDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, IOIBOLJBEGL, object> ANCAPBFHENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, IOIBOLJBEGL, object> AIJCKOKFEGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, IOIBOLJBEGL, object> HEOIABMEKMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly OMOEKAGIMFB BOFBILNEIOD;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2F3DE90", Offset = "0x2F3CA90", VA = "0x182F3DE90")]
			public CEDDAIFHJOL(Type CEEEOOFNMPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1F4C2A0", Offset = "0x1F4AEA0", VA = "0x181F4C2A0")]
			private static T GHHHNFCMDDD<T>(DynamicMethod FIOEAFODGAN)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2F3DCA0", Offset = "0x2F3C8A0", VA = "0x182F3DCA0")]
			private static MethodInfo PFFAHHPBCAN(Type CEEEOOFNMPD, string HBGNDBNJDEC, Type[] JNJOOLHNLGJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, CEDDAIFHJOL> HIJGPFFNMHP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::MNNCCEFDIPH<CEDDAIFHJOL> HLIHFKAHANC;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AFF0", Offset = "0x2F39BF0", VA = "0x182F3AFF0")]
		static BBBGEJNDGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2F3ACF0", Offset = "0x2F398F0", VA = "0x182F3ACF0")]
		private static CEDDAIFHJOL HJKAEAJHDHG(Type CEEEOOFNMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AE80", Offset = "0x2F39A80", VA = "0x182F3AE80")]
		public static void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AD70", Offset = "0x2F39970", VA = "0x182F3AD70")]
		public static void NOHBCKDOEHC(Type CEEEOOFNMPD, ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class OPLPMHNGJEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] EINFEEMFPOI;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2F53520", Offset = "0x2F52120", VA = "0x182F53520")]
		public static byte[] DMLFPFKJIEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IOIBOLJBEGL IEMEHHLKPEI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] ACFEPEHIFCA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] HKHJCEFNIEJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IOIBOLJBEGL PGLOLBDLDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AA50", Offset = "0x2F39650", VA = "0x182F3AA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AB60", Offset = "0x2F39760", VA = "0x182F3AB60")]
	public static void PHBCMGICIHF(IOIBOLJBEGL NGIPEEJHLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x21E0740", Offset = "0x21DF340", VA = "0x1821E0740")]
	public static string EKCFMCGKOLJ<T>(T ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x21E05E0", Offset = "0x21DF1E0", VA = "0x1821E05E0")]
	public static string EKCFMCGKOLJ<T>(T ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F474E0", Offset = "0x1F460E0", VA = "0x181F474E0")]
	public static T DEFMGIMGNBI<T>(string DHGILEBMGHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F47410", Offset = "0x1F46010", VA = "0x181F47410")]
	public static T DEFMGIMGNBI<T>(string DHGILEBMGHG, IOIBOLJBEGL NGIPEEJHLPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F476B0", Offset = "0x1F462B0", VA = "0x181F476B0")]
	public static T DEFMGIMGNBI<T>(byte[] EDEEEGMMOHA, IOIBOLJBEGL NGIPEEJHLPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F47560", Offset = "0x1F46160", VA = "0x181F47560")]
	public static T DEFMGIMGNBI<T>(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, IOIBOLJBEGL NGIPEEJHLPK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KPPNANAAMNP : byte
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
public struct GONHPJLEIMB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] LDPBLIMIOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] EINFEEMFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IHLNGFCHHLC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GIEDBHJFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7844C0", Offset = "0x7830C0", VA = "0x1807844C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CB90", Offset = "0x2F4B790", VA = "0x182F4CB90")]
	public void DBMCODEALJN(int IHLNGFCHHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DA80", Offset = "0x2F4C680", VA = "0x182F4DA80")]
	public static byte[] NIIKGIPNNLN(string IGNKLGFFCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D510", Offset = "0x2F4C110", VA = "0x182F4D510")]
	public static byte[] IOKHJAMCAAF(string IGNKLGFFCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D6E0", Offset = "0x2F4C2E0", VA = "0x182F4D6E0")]
	public static byte[] KNFMFIGJHFN(string IGNKLGFFCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D7E0", Offset = "0x2F4C3E0", VA = "0x182F4D7E0")]
	public static byte[] LELDOPNKHNI(string IGNKLGFFCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xC85100", Offset = "0xC83D00", VA = "0x180C85100")]
	public GONHPJLEIMB(byte[] CAKMHECLIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CD20", Offset = "0x2F4B920", VA = "0x182F4CD20")]
	public ArraySegment<byte> DMLFPFKJIEL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CBA0", Offset = "0x2F4B7A0", VA = "0x182F4CBA0")]
	public byte[] DMEOEFJHFFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DBA0", Offset = "0x2F4C7A0", VA = "0x182F4DBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D4D0", Offset = "0x2F4C0D0", VA = "0x182F4D4D0")]
	public void IFAFBMBKJFL(int AJELPBLPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CDD0", Offset = "0x2F4B9D0", VA = "0x182F4CDD0")]
	public void DOIMLBEGHJN(byte[] EKLNAKPJMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D5E0", Offset = "0x2F4C1E0", VA = "0x182F4D5E0")]
	public void JHOHDIMFOKG(byte EKLNAKPJMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C950", Offset = "0x2F4B550", VA = "0x182F4C950")]
	public void BJKBDJAOEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C860", Offset = "0x2F4B460", VA = "0x182F4C860")]
	public void AIEPAOHLOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DB50", Offset = "0x2F4C750", VA = "0x182F4DB50")]
	public void POPLOOJLGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DB00", Offset = "0x2F4C700", VA = "0x182F4DB00")]
	public void OEFDFBHMGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C8B0", Offset = "0x2F4B4B0", VA = "0x182F4C8B0")]
	public void BGIOFKJPBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C900", Offset = "0x2F4B500", VA = "0x182F4C900")]
	public void BGJBHBHDGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D650", Offset = "0x2F4C250", VA = "0x182F4D650")]
	public void JMBDPLPBJCF(string IGNKLGFFCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CE60", Offset = "0x2F4BA60", VA = "0x182F4CE60")]
	public void FALKKCMNBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D000", Offset = "0x2F4BC00", VA = "0x182F4D000")]
	public void GLLBBJOEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C9A0", Offset = "0x2F4B5A0", VA = "0x182F4C9A0")]
	public void BNLGNMJHDPP(bool ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CEB0", Offset = "0x2F4BAB0", VA = "0x182F4CEB0")]
	public void FLJBKBFMBPL(float ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D940", Offset = "0x2F4C540", VA = "0x182F4D940")]
	public void NBOLLDFFJLB(double ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CCF0", Offset = "0x2F4B8F0", VA = "0x182F4CCF0")]
	public void DMKGBOJGJOH(byte ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D0D0", Offset = "0x2F4BCD0", VA = "0x182F4D0D0")]
	public void HHFAEDCJHGI(ushort ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CE30", Offset = "0x2F4BA30", VA = "0x182F4CE30")]
	public void EHNDEEEMGKK(uint ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D6B0", Offset = "0x2F4C2B0", VA = "0x182F4D6B0")]
	public void KHIABHEGGGJ(ulong ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D7B0", Offset = "0x2F4C3B0", VA = "0x182F4D7B0")]
	public void LCLBKPHPIPP(sbyte ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D4E0", Offset = "0x2F4C0E0", VA = "0x182F4D4E0")]
	public void IMAMDMKGJON(short ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D620", Offset = "0x2F4C220", VA = "0x182F4D620")]
	public void JLGCLHDHPDP(int ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C830", Offset = "0x2F4B430", VA = "0x182F4C830")]
	public void ACEOEDOEEKD(long ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D100", Offset = "0x2F4BD00", VA = "0x182F4D100")]
	public void IDLIELLHCJE(string ODCJDJDBONO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BHEELBACOMH : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class GGNKHLDGGAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF370", Offset = "0x2ABDF70", VA = "0x182ABF370")]
		static GGNKHLDGGAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private BHEELBACOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class DKPDHMNMCON
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BIECNDOHKEP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F43530", Offset = "0x2F42130", VA = "0x182F43530")]
	static DKPDHMNMCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2F42FD0", Offset = "0x2F41BD0", VA = "0x182F42FD0")]
	internal static object JCBFDOBFKIF(Type NHMGOELDBCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KEMKDFIALHF : global::EPIIBJLGPNA<Vector2>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3018300", Offset = "0x3016F00", VA = "0x183018300")]
	public KEMKDFIALHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3018250", Offset = "0x3016E50", VA = "0x183018250", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Vector2 ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3017F60", Offset = "0x3016B60", VA = "0x183017F60", Slot = "5")]
	public Vector2 DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PGOHJJLEIBJ : global::EPIIBJLGPNA<Vector3>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2C10", Offset = "0x4AE1810", VA = "0x184AE2C10")]
	public PGOHJJLEIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2AF0", Offset = "0x4AE16F0", VA = "0x184AE2AF0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Vector3 ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2900", Offset = "0x4AE1500", VA = "0x184AE2900", Slot = "5")]
	public Vector3 DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LPAPAGPCEFD : global::EPIIBJLGPNA<Vector4>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x301A160", Offset = "0x3018D60", VA = "0x18301A160")]
	public LPAPAGPCEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x301A010", Offset = "0x3018C10", VA = "0x18301A010", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Vector4 ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3019C90", Offset = "0x3018890", VA = "0x183019C90", Slot = "5")]
	public Vector4 DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class POOGMABDIFA : global::EPIIBJLGPNA<Quaternion>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4910", Offset = "0x4AE3510", VA = "0x184AE4910")]
	public POOGMABDIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x301A010", Offset = "0x3018C10", VA = "0x18301A010", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Quaternion ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4AE46E0", Offset = "0x4AE32E0", VA = "0x184AE46E0", Slot = "5")]
	public Quaternion DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PHKLMBFDCIK : global::EPIIBJLGPNA<Color>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AE30A0", Offset = "0x4AE1CA0", VA = "0x184AE30A0")]
	public PHKLMBFDCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x301A010", Offset = "0x3018C10", VA = "0x18301A010", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Color ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2E70", Offset = "0x4AE1A70", VA = "0x184AE2E70", Slot = "5")]
	public Color DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IECNIINECIF : global::EPIIBJLGPNA<Bounds>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x300E5E0", Offset = "0x300D1E0", VA = "0x18300E5E0")]
	public IECNIINECIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x300E370", Offset = "0x300CF70", VA = "0x18300E370", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Bounds ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x300DF70", Offset = "0x300CB70", VA = "0x18300DF70", Slot = "5")]
	public Bounds DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class JPMKEBNGJHN : global::EPIIBJLGPNA<Rect>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NPIMINEJMJA ELFFLKKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HEPBCNBGEPH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x30177A0", Offset = "0x30163A0", VA = "0x1830177A0")]
	public JPMKEBNGJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3017630", Offset = "0x3016230", VA = "0x183017630", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Rect ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3017280", Offset = "0x3015E80", VA = "0x183017280", Slot = "5")]
	public Rect DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class ACHCPIJKKNM : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class MNNOMEEBDCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x422F2E0", Offset = "0x422DEE0", VA = "0x18422F2E0")]
		static MNNOMEEBDCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private ACHCPIJKKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class ELFLPEAKDAJ : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class JFDNJNAJCFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x329CAF0", Offset = "0x329B6F0", VA = "0x18329CAF0")]
		static JFDNJNAJCFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class OFPKMHLNLLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> PGPIFJPPJCP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F518C0", Offset = "0x2F504C0", VA = "0x182F518C0")]
		internal static object JCBFDOBFKIF(Type NHMGOELDBCA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private ELFLPEAKDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class JFCJPKLAKNH : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GFHDHLLHCHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x33D4E70", Offset = "0x33D3A70", VA = "0x1833D4E70")]
		static GFHDHLLHCHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JFCJPKLAKNH PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool EOLAAMHGFHB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static FHLLIKOGGFC[] CNPCFNAHBIJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IOIBOLJBEGL[] LBGMNDCAAHH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private JFCJPKLAKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3013B00", Offset = "0x3012700", VA = "0x183013B00")]
	public static void KHEKHCDAEKG(params IOIBOLJBEGL[] LBGMNDCAAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3013A40", Offset = "0x3012640", VA = "0x183013A40")]
	public static void KHEKHCDAEKG(params FHLLIKOGGFC[] CNPCFNAHBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3013BC0", Offset = "0x30127C0", VA = "0x183013BC0")]
	public static void PPLAHBJCOMO(FHLLIKOGGFC[] CNPCFNAHBIJ, IOIBOLJBEGL[] LBGMNDCAAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class KOMKJPLPFEK : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class BIGPJOBCFJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x23BF860", Offset = "0x23BE460", VA = "0x1823BF860")]
		static BIGPJOBCFJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private KOMKJPLPFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EMIHAJBFIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IOIBOLJBEGL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly IOIBOLJBEGL AFCHDMGNOGP;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly IOIBOLJBEGL LGLOGJFDNKD;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IOIBOLJBEGL LLJKLAEGPBD;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly IOIBOLJBEGL LNKPBBOAFKB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IOIBOLJBEGL KGMHPHMHGHH;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IOIBOLJBEGL CMFMIGIDBKB;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly IOIBOLJBEGL CHAJLLEHCCN;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IOIBOLJBEGL AHGGIKKLBAL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly IOIBOLJBEGL JPMEIPKMJDL;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IOIBOLJBEGL IDAGFOIMODM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IOIBOLJBEGL DGHGNCIPHHG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KDFMBHAJFOD
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IOIBOLJBEGL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IOIBOLJBEGL HLGJJKLBHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AEBMIJEEOFE
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IOIBOLJBEGL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IOIBOLJBEGL AFCHDMGNOGP;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IOIBOLJBEGL LGLOGJFDNKD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IOIBOLJBEGL LLJKLAEGPBD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IOIBOLJBEGL LNKPBBOAFKB;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IOIBOLJBEGL KGMHPHMHGHH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IOIBOLJBEGL CMFMIGIDBKB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IOIBOLJBEGL CHAJLLEHCCN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IOIBOLJBEGL AHGGIKKLBAL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IOIBOLJBEGL JPMEIPKMJDL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IOIBOLJBEGL IDAGFOIMODM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IOIBOLJBEGL DGHGNCIPHHG;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class JJKNENHHBEL
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> PGPIFJPPJCP;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30140E0", Offset = "0x3012CE0", VA = "0x1830140E0")]
	internal static object JCBFDOBFKIF(Type NHMGOELDBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3015700", Offset = "0x3014300", VA = "0x183015700")]
	private static object LCODLOOEENK(Type KEIBGCKINFM, Type[] AGLHOGMOFKN, params object[] JNJOOLHNLGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class AFDGNPBFMHJ : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class DKJCBKLMDJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x25E4A90", Offset = "0x25E3690", VA = "0x1825E4A90")]
		static DKJCBKLMDJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A7D0", Offset = "0x2F393D0", VA = "0x182F3A7D0")]
	static AFDGNPBFMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private AFDGNPBFMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class IIOMMBGLMEO : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class DFJLAIAEMLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x27DE130", Offset = "0x27DCD30", VA = "0x1827DE130")]
		static DFJLAIAEMLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x300FBD0", Offset = "0x300E7D0", VA = "0x18300FBD0")]
	static IIOMMBGLMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private IIOMMBGLMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class NPIEJBJNHJB : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class AKEEFCBOCPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x40208D0", Offset = "0x401F4D0", VA = "0x1840208D0")]
		static AKEEFCBOCPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x301C930", Offset = "0x301B530", VA = "0x18301C930")]
	static NPIEJBJNHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private NPIEJBJNHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class HEMHPMMGIEG : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class IAAOOEALAOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A300C0", Offset = "0x3A2ECC0", VA = "0x183A300C0")]
		static IAAOOEALAOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F490", Offset = "0x2F4E090", VA = "0x182F4F490")]
	static HEMHPMMGIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private HEMHPMMGIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class ODLFPFPIDGH : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class FBMLGIFOGKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x42DC0E0", Offset = "0x42DACE0", VA = "0x1842DC0E0")]
		static FBMLGIFOGKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC340", Offset = "0x4ADAF40", VA = "0x184ADC340")]
	static ODLFPFPIDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private ODLFPFPIDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class JMKEPGGLALH : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class BDMPJDLDBPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3508670", Offset = "0x3507270", VA = "0x183508670")]
		static BDMPJDLDBPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly HDILLOPCJCG PDMKNIAILHF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3015C70", Offset = "0x3014870", VA = "0x183015C70")]
	static JMKEPGGLALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private JMKEPGGLALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class NGHMICDECBJ : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class FBEKHEMODGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28BED70", Offset = "0x28BD970", VA = "0x1828BED70")]
		static FBEKHEMODGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public NGHMICDECBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class BPECGHPMAKP : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DEHMHCADNAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E85700", Offset = "0x2E84300", VA = "0x182E85700")]
		static DEHMHCADNAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BPECGHPMAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class AEMKMCPEGBP : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class HLOPLJJAJHL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x25E84A0", Offset = "0x25E70A0", VA = "0x1825E84A0")]
		static HLOPLJJAJHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public AEMKMCPEGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class CGLFBFJLNIL : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class NFJAEBMJACH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x20D4830", Offset = "0x20D3430", VA = "0x1820D4830")]
		static NFJAEBMJACH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public CGLFBFJLNIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class KGEMGGHOJIM : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class GHIPPDNOHDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x40E9790", Offset = "0x40E8390", VA = "0x1840E9790")]
		static GHIPPDNOHDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public KGEMGGHOJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class EIOPEGDGDAD : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class DEDPOFLJDHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4100", Offset = "0x3EB2D00", VA = "0x183EB4100")]
		static DEDPOFLJDHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> CNKNPFHBHLP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool FJBKJODANMF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public EIOPEGDGDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OBDPFILMIPF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct INEMGPJFGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EEGHKMEEJID LOFIJOHNFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder OKIJOENKEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder PAFLPAADFDG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class JFCKMKMOGIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class GICHHDIKALD
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KNFMFIGJHFN;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IOKHJAMCAAF;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo LELDOPNKHNI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo NIIKGIPNNLN;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo GLLBBJOEPFH;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo DOIMLBEGHJN;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo POPLOOJLGOB;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo OEFDFBHMGFE;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo BGIOFKJPBNN;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4AD9540", Offset = "0x4AD8140", VA = "0x184AD9540")]
			static GICHHDIKALD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class FFCOEIBEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo CGBDDDLIMOK;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo LPECKELMOEF;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JIBMNBNDNPJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo CKDEEOGOAPN;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo IHLEIGBFNAH;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo PDLJOOKLHGB;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NHCJNBJMGHG;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4AD8A40", Offset = "0x4AD7640", VA = "0x184AD8A40")]
			static FFCOEIBEEDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class DOLDGMJKFKB
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo ELJHKGDMAGH;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo OLPLBNIIFJH;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo DBOKJMEKLJB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo NCCGOIFKLNC;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo KCLINNFJDBP;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo CMFJNNCILGA;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo MBCCGKNMEOL;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo FMMBLONAIOD;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo KGPKKLHDLMF;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo PEDFELDEOIE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo NPOGOGFGLII;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo BBCNGGONODN;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo AFEGKHMDLIP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo PKCHLDNFJDG;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA920", Offset = "0x4AD9520", VA = "0x184ADA920")]
		public static MethodInfo NOHBCKDOEHC(Type CEEEOOFNMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA5D0", Offset = "0x4AD91D0", VA = "0x184ADA5D0")]
		public static MethodInfo DEFMGIMGNBI(Type CEEEOOFNMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA800", Offset = "0x4AD9400", VA = "0x184ADA800")]
		public static MethodInfo DOJJNMENJJM(Type CEEEOOFNMPD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class IHPDHNNKKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<EEGHKMEEJID, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public IHPDHNNKKMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class NKKDFJLENNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public IHPDHNNKKMA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public NKKDFJLENNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC260", Offset = "0x4ADAE60", VA = "0x184ADC260")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC2A0", Offset = "0x4ADAEA0", VA = "0x184ADC2A0")]
		internal bool <BuildType>b__2(int index, EEGHKMEEJID member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class EOMMLNFKHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public IHPDHNNKKMA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public EOMMLNFKHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4AD87F0", Offset = "0x4AD73F0", VA = "0x184AD87F0")]
		internal bool <BuildType>b__3(int index, EEGHKMEEJID member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MPHJLPIOKIC
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public MPHJLPIOKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC060", Offset = "0x4ADAC60", VA = "0x184ADC060")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MOKPONGKCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public MOKPONGKCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC000", Offset = "0x4ADAC00", VA = "0x184ADC000")]
		internal bool <BuildAnonymousFormatter>b__2(EEGHKMEEJID x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FELDBCKLCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MPHJLPIOKIC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public FELDBCKLCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8890", Offset = "0x4AD7490", VA = "0x184AD8890")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4AD88A0", Offset = "0x4AD74A0", VA = "0x184AD88A0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, EEGHKMEEJID member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NADEMKKMGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MPHJLPIOKIC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public NADEMKKMGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC0C0", Offset = "0x4ADACC0", VA = "0x184ADC0C0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, EEGHKMEEJID member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NDJPOJIOICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public NDJPOJIOICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x564CC0", Offset = "0x5638C0", VA = "0x180564CC0")]
		internal Label <BuildSerialize>b__1(EEGHKMEEJID _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class CALPFMEPFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public INEMGPJFGCC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, EEGHKMEEJID, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JJIGDHPEBAL argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public JJIGDHPEBAL argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public CALPFMEPFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8380", Offset = "0x4AD6F80", VA = "0x184AD8380")]
		internal INEMGPJFGCC <BuildDeserialize>b__0(EEGHKMEEJID item)
		{
			return default(INEMGPJFGCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class HNLBOFDBNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CALPFMEPFOP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public HNLBOFDBNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA280", Offset = "0x4AD8E80", VA = "0x184ADA280")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA530", Offset = "0x4AD9130", VA = "0x184ADA530")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JGGOOLHMHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EEGHKMEEJID item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public JGGOOLHMHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
		internal bool <EmitNewObject>b__0(INEMGPJFGCC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class BNEIKLMCPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EEGHKMEEJID item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public BNEIKLMCPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
		internal bool <EmitNewObject>b__2(INEMGPJFGCC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex COJEPHNEBEC;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int DJKOEFMPCBE;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> AKGNFNKFFMF;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> PIOCDCGBIBK;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x35B43D0", Offset = "0x35B2FD0", VA = "0x1835B43D0")]
	public static object BKHLAMPMCJE<T>(HDILLOPCJCG PDMKNIAILHF, IOIBOLJBEGL BMBGOEBNPDE, Func<string, string> CNKNPFHBHLP, bool FJBKJODANMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x35BD6E0", Offset = "0x35BC2E0", VA = "0x1835BD6E0")]
	public static object CJLFIGHKJLI<T>(IOIBOLJBEGL BMBGOEBNPDE, Func<string, string> CNKNPFHBHLP, bool FJBKJODANMF, bool FPJFLNKAMAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3021510", Offset = "0x3020110", VA = "0x183021510")]
	private static TypeInfo LHOANMFILBA(HDILLOPCJCG PDMKNIAILHF, Type CEEEOOFNMPD, Func<string, string> CNKNPFHBHLP, bool FJBKJODANMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3022C90", Offset = "0x3021890", VA = "0x183022C90")]
	public static object OLFLHGLOBCE(Type CEEEOOFNMPD, Func<string, string> CNKNPFHBHLP, bool FJBKJODANMF, bool FPJFLNKAMAK, bool IPHKNALEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x301F830", Offset = "0x301E430", VA = "0x18301F830")]
	private static Dictionary<EEGHKMEEJID, FieldInfo> IBBPLPJFKEF(TypeBuilder PIAPMPANMNF, POAOIPDGDGE GCMEGDICJNC, ConstructorInfo IAONOFEDCFK, FieldBuilder KHHLHJFKFJO, ILGenerator OGOENPILONM, bool FJBKJODANMF, bool FJIMBCKKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x301EBD0", Offset = "0x301D7D0", VA = "0x18301EBD0")]
	private static Dictionary<EEGHKMEEJID, FieldInfo> GDEADEKOFFM(TypeBuilder PIAPMPANMNF, POAOIPDGDGE GCMEGDICJNC, ILGenerator OGOENPILONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x301FF30", Offset = "0x301EB30", VA = "0x18301FF30")]
	private static void IDNFJNGJOAK(Type CEEEOOFNMPD, POAOIPDGDGE GCMEGDICJNC, ILGenerator OGOENPILONM, Action MDLDEHNIDGL, Func<int, EEGHKMEEJID, bool> GJFFFLPGKKF, bool FJBKJODANMF, bool FJIMBCKKEPM, int CKAKJHLPKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x301F1A0", Offset = "0x301DDA0", VA = "0x18301F1A0")]
	private static void HDHMILPIBGN(TypeInfo CEEEOOFNMPD, EEGHKMEEJID DBJKHNCEADC, ILGenerator OGOENPILONM, int PMMFOLCEJEJ, Func<int, EEGHKMEEJID, bool> GJFFFLPGKKF, JJIGDHPEBAL EJKJMALPMJH, JJIGDHPEBAL CLAKHCOHLMD, JJIGDHPEBAL KAEIMNIFDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x301D800", Offset = "0x301C400", VA = "0x18301D800")]
	private static void DOHDIJLIAPF(Type CEEEOOFNMPD, POAOIPDGDGE GCMEGDICJNC, ILGenerator OGOENPILONM, Func<int, EEGHKMEEJID, bool> GJFFFLPGKKF, bool IHEHEOAICKO, int CKAKJHLPKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x301D3E0", Offset = "0x301BFE0", VA = "0x18301D3E0")]
	private static void AHMLKJHMHJJ(ILGenerator OGOENPILONM, INEMGPJFGCC GCMEGDICJNC, int PMMFOLCEJEJ, Func<int, EEGHKMEEJID, bool> GJFFFLPGKKF, JJIGDHPEBAL HGAMEAMKNKI, JJIGDHPEBAL KAEIMNIFDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3021FB0", Offset = "0x3020BB0", VA = "0x183021FB0")]
	private static LocalBuilder NDFHJAMKMGK(ILGenerator OGOENPILONM, Type CEEEOOFNMPD, POAOIPDGDGE GCMEGDICJNC, INEMGPJFGCC[] OFELBBHLOOI, bool NLDCOMMLILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30245D0", Offset = "0x30231D0", VA = "0x1830245D0")]
	private static bool PDBBKKCLJDA(ConstructorInfo ONAHMMHAKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x301F690", Offset = "0x301E290", VA = "0x18301F690")]
	private static bool HJHJFDOOFEB(Type CEEEOOFNMPD, out Type KLMNMHLKDBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void PPJGFMGHAHN<T>(byte[][] KHHLHJFKFJO, object[] PDFIPGMODLC, ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL NGIPEEJHLPK);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T HIDPPLIMAMG<T>(object[] PDFIPGMODLC, ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL NGIPEEJHLPK);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class OFLPGALEEKG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class LBHMDICDEKK : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class BGKFFEOLOCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB820", Offset = "0x2EBA420", VA = "0x182EBB820")]
		static BGKFFEOLOCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private LBHMDICDEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class MDJMIJJAKDB : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class BJOPFHMCBNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2575F50", Offset = "0x2574B50", VA = "0x182575F50")]
		static BJOPFHMCBNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private MDJMIJJAKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class FMBHBJCIMHA
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly IOIBOLJBEGL[] OELGNCHEHAL;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class MPOHLLHOJNN : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class PBOJEINDFCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x31D6B10", Offset = "0x31D5710", VA = "0x1831D6B10")]
		static PBOJEINDFCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LMDPAJLPPFM : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class NCKOHFIJKAC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x31D48F0", Offset = "0x31D34F0", VA = "0x1831D48F0")]
			static NCKOHFIJKAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private LMDPAJLPPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private MPOHLLHOJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class LFCGODBJLFI : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class EOLEJDHDEPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EA10", Offset = "0x2B1D610", VA = "0x182B1EA10")]
		static EOLEJDHDEPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class DBDOOPPCKPG : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class MJCPCJICBJG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2B30E90", Offset = "0x2B2FA90", VA = "0x182B30E90")]
			static MJCPCJICBJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private DBDOOPPCKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private LFCGODBJLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class IGBNNNJEAGE : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class BPJKCMIGLBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x377E430", Offset = "0x377D030", VA = "0x18377E430")]
		static BPJKCMIGLBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class JLNAEENDAAJ : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class GEKGPGBCMFP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x37836B0", Offset = "0x37822B0", VA = "0x1837836B0")]
			static GEKGPGBCMFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private JLNAEENDAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private IGBNNNJEAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class CJFMNKOEOME : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class ENHIIEMFIMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3EA17D0", Offset = "0x3EA03D0", VA = "0x183EA17D0")]
		static ENHIIEMFIMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class KPFGPFEHNMD : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class MMFMCDGCPDO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2FE54D0", Offset = "0x2FE40D0", VA = "0x182FE54D0")]
			static MMFMCDGCPDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private KPFGPFEHNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private CJFMNKOEOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class JCODELLEOPK : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class DKBJOOGNEFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x33D0980", Offset = "0x33CF580", VA = "0x1833D0980")]
		static DKBJOOGNEFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class OKOJGIOJILA : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class NMHPLKFKCHB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x33E8640", Offset = "0x33E7240", VA = "0x1833E8640")]
			static NMHPLKFKCHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private OKOJGIOJILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private JCODELLEOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class BDBAGOOEDCA : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class ABLEPFHBKJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2AAF1A0", Offset = "0x2AADDA0", VA = "0x182AAF1A0")]
		static ABLEPFHBKJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class OJICADNINHH : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GIALMHEPKAC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2AC19E0", Offset = "0x2AC05E0", VA = "0x182AC19E0")]
			static GIALMHEPKAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private OJICADNINHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private BDBAGOOEDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class AAGFACMNAFI : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class GHKNJKDCKMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4226C10", Offset = "0x4225810", VA = "0x184226C10")]
		static GHKNJKDCKMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class FMLEKFHJMLJ : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class MMDOGLMCCFA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x422DB90", Offset = "0x422C790", VA = "0x18422DB90")]
			static MMDOGLMCCFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private FMLEKFHJMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private AAGFACMNAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class DGMEIMGHAEC : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class HFHFLJLNEEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3224240", Offset = "0x3222E40", VA = "0x183224240")]
		static HFHFLJLNEEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class IMAIOLPHJLP : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class JLFBLDCHJGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x32296D0", Offset = "0x32282D0", VA = "0x1832296D0")]
			static JLFBLDCHJGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private IMAIOLPHJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private DGMEIMGHAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class MILLEEANHIA : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class IBLHBBIKNJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x25852E0", Offset = "0x2583EE0", VA = "0x1825852E0")]
		static IBLHBBIKNJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class LELDDOHEDMB : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class FEIGKAKHGJL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2580470", Offset = "0x257F070", VA = "0x182580470")]
			static FEIGKAKHGJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private LELDDOHEDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private MILLEEANHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class FLGBBGKPJNP : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class GKIDMLIBCDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D35510", Offset = "0x3D34110", VA = "0x183D35510")]
		static GKIDMLIBCDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class BCGIJCFPMPH : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DFGFMMOFPBH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3D21E30", Offset = "0x3D20A30", VA = "0x183D21E30")]
			static DFGFMMOFPBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private BCGIJCFPMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private FLGBBGKPJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class ACJJJCAMEEK : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class AJOAOPGFNEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x358C5E0", Offset = "0x358B1E0", VA = "0x18358C5E0")]
		static AJOAOPGFNEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class BOLLLBGJDAC : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NBJCMNDBLPH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3596FE0", Offset = "0x3595BE0", VA = "0x183596FE0")]
			static NBJCMNDBLPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private BOLLLBGJDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private ACJJJCAMEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class BEOKBLFAMID : IOIBOLJBEGL
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class LJLALIANKHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA970", Offset = "0x2AC9570", VA = "0x182ACA970")]
		static LJLALIANKHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class OAOIEPBGJGE : IOIBOLJBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class FLHFANHNILA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::EPIIBJLGPNA<T> PLKOKHLHKFA;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2ABDA10", Offset = "0x2ABC610", VA = "0x182ABDA10")]
			static FLHFANHNILA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly IOIBOLJBEGL PMDDBIJFNMN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly IOIBOLJBEGL[] LBGMNDCAAHH;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		private OAOIEPBGJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
		public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly IOIBOLJBEGL PMDDBIJFNMN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::EPIIBJLGPNA<object> FPDGJJHBHJH;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	private BEOKBLFAMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x20F3A90", Offset = "0x20F2690", VA = "0x1820F3A90", Slot = "4")]
	public global::EPIIBJLGPNA<T> JCBFDOBFKIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct BEDBCLJHCBE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] DAKMHCHMEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int CFAAKDNGFPF;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6010", Offset = "0x2AB4C10", VA = "0x182AB6010")]
	public BEDBCLJHCBE(int HAPDJPLLMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5D00", Offset = "0x2AB4900", VA = "0x182AB5D00")]
	public void DNJODILJGAL(T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5F80", Offset = "0x2AB4B80", VA = "0x182AB5F80")]
	public T[] NLICAOPBBEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class MNHODGGDEDH : global::DGMKKBPNOII<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly MNHODGGDEDH FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x301AF70", Offset = "0x3019B70", VA = "0x18301AF70")]
	public MNHODGGDEDH(int IDNMMKDMEMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DGMKKBPNOII<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int IDNMMKDMEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object IBBGGKBDNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int PMMFOLCEJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] APLPDEJGPPF;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3215960", Offset = "0x3214560", VA = "0x183215960")]
	public DGMKKBPNOII(int IDNMMKDMEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3213620", Offset = "0x3212220", VA = "0x183213620")]
	public T[] KFONIKOIBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3215060", Offset = "0x3213C60", VA = "0x183215060")]
	public void MAFGDJPFPMP(T[] IIIEKHDFIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NPIMINEJMJA : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class DFOGHHJAGHH : IComparable<DFOGHHJAGHH>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class IOIFKAIJLKE : IEnumerable<DFOGHHJAGHH>, IEnumerable, IEnumerator<DFOGHHJAGHH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private DFOGHHJAGHH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public DFOGHHJAGHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DFOGHHJAGHH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
			[DebuggerHidden]
			public IOIFKAIJLKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3012EA0", Offset = "0x3011AA0", VA = "0x183012EA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3012FD0", Offset = "0x3011BD0", VA = "0x183012FD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3012F30", Offset = "0x3011B30", VA = "0x183012F30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DFOGHHJAGHH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3012F30", Offset = "0x3011B30", VA = "0x183012F30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class DDGHJNLMNOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public DDGHJNLMNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x564CC0", Offset = "0x5638C0", VA = "0x180564CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x564CC0", Offset = "0x5638C0", VA = "0x180564CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly DFOGHHJAGHH[] DJEBHKPFFKJ;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] DGAPFDDIMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong LBLIIGONCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int HNBDKKLMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string FLLHICALKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DFOGHHJAGHH[] BJPOCLNPKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] ODPAAIIJGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int MAKGNGIINDI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PFKANJFOHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9D2CF0", Offset = "0x9D18F0", VA = "0x1809D2CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x300DBF0", Offset = "0x300C7F0", VA = "0x18300DBF0")]
		public DFOGHHJAGHH(ulong OMAJLLKKGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x300C9A0", Offset = "0x300B5A0", VA = "0x18300C9A0")]
		public DFOGHHJAGHH DNJODILJGAL(ulong OMAJLLKKGPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x300CB90", Offset = "0x300B790", VA = "0x18300CB90")]
		public DFOGHHJAGHH DNJODILJGAL(ulong OMAJLLKKGPH, int ODCJDJDBONO, string FLLHICALKLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x300CBE0", Offset = "0x300B7E0", VA = "0x18300CBE0")]
		public DFOGHHJAGHH EAPPCJEHAAB(byte[] BHAIGFJIALO, ref int IHLNGFCHHLC, ref int KCJFKKHEPDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x300C8F0", Offset = "0x300B4F0", VA = "0x18300C8F0")]
		internal static int AFGMOLIJHAA(ulong[] IIIEKHDFIBE, int PMMFOLCEJEJ, int DMBGGGOKIMF, ulong ODCJDJDBONO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x300C970", Offset = "0x300B570", VA = "0x18300C970", Slot = "4")]
		public int CompareTo(DFOGHHJAGHH PJEOMNDGEFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x300CD90", Offset = "0x300B990", VA = "0x18300CD90")]
		[IteratorStateMachine(typeof(IOIFKAIJLKE))]
		public IEnumerable<DFOGHHJAGHH> EPHDNMEEIHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x300CE00", Offset = "0x300BA00", VA = "0x18300CE00")]
		public void HJCNGHJPNDC(ILGenerator OGOENPILONM, LocalBuilder BHAIGFJIALO, LocalBuilder KCJFKKHEPDA, LocalBuilder OMAJLLKKGPH, Action<KeyValuePair<string, int>> IEAGLENLBOI, Action HEIHNDOILKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x300CF50", Offset = "0x300BB50", VA = "0x18300CF50")]
		private static void IKNMPHKDMEH(ILGenerator OGOENPILONM, LocalBuilder BHAIGFJIALO, LocalBuilder KCJFKKHEPDA, LocalBuilder OMAJLLKKGPH, Action<KeyValuePair<string, int>> IEAGLENLBOI, Action HEIHNDOILKD, DFOGHHJAGHH[] BJPOCLNPKJE, int MAKGNGIINDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class AKDIJMGGFPD : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<DFOGHHJAGHH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<DFOGHHJAGHH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<DFOGHHJAGHH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private DFOGHHJAGHH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x55D000", Offset = "0x55BC00", VA = "0x18055D000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x300C580", Offset = "0x300B180", VA = "0x18300C580", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE60", Offset = "0x8EEA60", VA = "0x1808EFE60")]
		[DebuggerHidden]
		public AKDIJMGGFPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x300C5D0", Offset = "0x300B1D0", VA = "0x18300C5D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x300C110", Offset = "0x300AD10", VA = "0x18300C110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x300C6D0", Offset = "0x300B2D0", VA = "0x18300C6D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x300C720", Offset = "0x300B320", VA = "0x18300C720")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x300C530", Offset = "0x300B130", VA = "0x18300C530", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x300C490", Offset = "0x300B090", VA = "0x18300C490", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x300C490", Offset = "0x300B090", VA = "0x18300C490", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly DFOGHHJAGHH AMKOBFEBOFJ;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x301D0F0", Offset = "0x301BCF0", VA = "0x18301D0F0")]
	public NPIMINEJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x301CA20", Offset = "0x301B620", VA = "0x18301CA20")]
	public void DNJODILJGAL(byte[] EDEEEGMMOHA, int ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x301CF50", Offset = "0x301BB50", VA = "0x18301CF50")]
	public bool PPFIBEGAHKC(ArraySegment<byte> OMAJLLKKGPH, out int ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x301D000", Offset = "0x301BC00", VA = "0x18301D000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x301CC60", Offset = "0x301B860", VA = "0x18301CC60")]
	private static void JKEFGFJCHDH(IEnumerable<DFOGHHJAGHH> BJPOCLNPKJE, StringBuilder HNHAGKDLPFM, int ELNAPHFJDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x301CB30", Offset = "0x301B730", VA = "0x18301CB30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x301CB30", Offset = "0x301B730", VA = "0x18301CB30", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x301CEE0", Offset = "0x301BAE0", VA = "0x18301CEE0")]
	[IteratorStateMachine(typeof(AKDIJMGGFPD))]
	private static IEnumerable<KeyValuePair<string, int>> KAPOBCCDBLO(IEnumerable<DFOGHHJAGHH> BJPOCLNPKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x301CC30", Offset = "0x301B830", VA = "0x18301CC30")]
	public void HKHEANHPLKI(ILGenerator OGOENPILONM, LocalBuilder BHAIGFJIALO, LocalBuilder KCJFKKHEPDA, LocalBuilder OMAJLLKKGPH, Action<KeyValuePair<string, int>> IEAGLENLBOI, Action HEIHNDOILKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class JNMAENKACMH
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo JKDNHDNLCCF;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3015DC0", Offset = "0x30149C0", VA = "0x183015DC0")]
	public static ulong FEELNCBNEFD(byte[] EDEEEGMMOHA, ref int IHLNGFCHHLC, ref int KCJFKKHEPDA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class EOMPCGMPPLI
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F44CC0", Offset = "0x2F438C0", VA = "0x182F44CC0")]
	public static void IFAFBMBKJFL(ref byte[] EDEEEGMMOHA, int IHLNGFCHHLC, int AJELPBLPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F44BD0", Offset = "0x2F437D0", VA = "0x182F44BD0")]
	public static void FMIIDMFCCEH(ref byte[] IIIEKHDFIBE, int BLNCPMDCDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F44DE0", Offset = "0x2F439E0", VA = "0x182F44DE0")]
	public static byte[] NIBHIAIKDKD(byte[] FPFPNAEGMEA, int BLNCPMDCDFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class ANHAADLEDBA
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A9C0", Offset = "0x2F395C0", VA = "0x182F3A9C0")]
	public static bool KCMIAPKPHME(byte[] ADHDEDHDEBO, int EFAILPMCJKO, int MCGNNNEMAEA, byte[] IFNBHEANCOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class CJFDNFKLLLK<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct BGIBICCDHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] LBLIIGONCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T HNBDKKLMMPE;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x20C8F60", Offset = "0x20C7B60", VA = "0x1820C8F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MFIDDGPPKKH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::CJFDNFKLLLK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private BGIBICCDHCG[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private BGIBICCDHCG[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x13A8F10", Offset = "0x13A7B10", VA = "0x1813A8F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x20D3600", Offset = "0x20D2200", VA = "0x1820D3600", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D051A0", Offset = "0x1D03DA0", VA = "0x181D051A0")]
		[DebuggerHidden]
		public MFIDDGPPKKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x20D2570", Offset = "0x20D1170", VA = "0x1820D2570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x20D2DE0", Offset = "0x20D19E0", VA = "0x1820D2DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly BGIBICCDHCG[][] OFIGAHBIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong NLBKAIPELBN;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3EA09C0", Offset = "0x3E9F5C0", VA = "0x183EA09C0")]
	public CJFDNFKLLLK(int HNBFBADKDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0900", Offset = "0x3E9F500", VA = "0x183EA0900")]
	public CJFDNFKLLLK(int HNBFBADKDCL, float MDOILNNGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E98DA0", Offset = "0x3E979A0", VA = "0x183E98DA0")]
	public void DNJODILJGAL(byte[] OMAJLLKKGPH, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A010", Offset = "0x3E98C10", VA = "0x183E9A010")]
	private bool GEKDGLHJLEN(byte[] OMAJLLKKGPH, T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E95A20", Offset = "0x3E94620", VA = "0x183E95A20")]
	public bool BOKJIEDKGMF(ArraySegment<byte> OMAJLLKKGPH, out T ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3EA08A0", Offset = "0x3E9F4A0", VA = "0x183EA08A0")]
	private static ulong OJCJEDKELCM(byte[] JJCLMNFFLAC, int IHLNGFCHHLC, int MAKGNGIINDI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3D002A0", Offset = "0x3CFEEA0", VA = "0x183D002A0")]
	private static int FGLDAAJPGDL(int ANEJNKDBDMK, float MDOILNNGCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3EA06F0", Offset = "0x3E9F2F0", VA = "0x183EA06F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::CJFDNFKLLLK<>.MFIDDGPPKKH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D7F2B0", Offset = "0x1D7DEB0", VA = "0x181D7F2B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class FGPOMEKKBAI : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] FDAAOBKGHLC;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] IBEJMLGCPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int PCMJJMAJMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MNGFGCBLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2F45D50", Offset = "0x2F44950", VA = "0x182F45D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2F45DA0", Offset = "0x2F449A0", VA = "0x182F45DA0")]
	static FGPOMEKKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2F45FF0", Offset = "0x2F44BF0", VA = "0x182F45FF0")]
	public FGPOMEKKBAI(byte[] PEDOALAIOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2F45C40", Offset = "0x2F44840", VA = "0x182F45C40")]
	public OpCode FCFJLAILHKN()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct OKLOCGJNHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid HNBDKKLMMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte NCAAFMNAFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte OKPONNANDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte HDJPLDPMCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte NFIONHLLDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte BAKGIKBEMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte GGOMEJMMHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte KPLFCMDMINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KDANGHHDIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte MIFJCMIFFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte JAIGGNNLADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte DEPDOGCFHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte CIKEGOPLNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte IJMOAJOFIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte HNLEHPKNNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GOAPCFFCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte EBKMHBMPMIK;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] LKHCKBOOHGG;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] GMEOBEOGNKE;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2560", Offset = "0x4AE1160", VA = "0x184AE2560")]
	public OKLOCGJNHFN(ref Guid ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1EB0", Offset = "0x4AE0AB0", VA = "0x184AE1EB0")]
	public OKLOCGJNHFN(ref ArraySegment<byte> ECBLGPNOKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0A00", Offset = "0x4ADF600", VA = "0x184AE0A00")]
	private static byte OECOENLCEFF(byte[] EDEEEGMMOHA, int BKFMDKDHLDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4AE08F0", Offset = "0x4ADF4F0", VA = "0x184AE08F0")]
	private static byte BEKPJOMOLJL(byte GONCOEMNHPC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0AC0", Offset = "0x4ADF6C0", VA = "0x184AE0AC0")]
	public void PHFAMGKNPIN(byte[] EINFEEMFPOI, int IHLNGFCHHLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class IANICOIAGCI
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2F50490", Offset = "0x2F4F090", VA = "0x182F50490")]
	public static bool FIMAODNKDKD(byte PKPFJHLMNLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2F504A0", Offset = "0x2F4F0A0", VA = "0x182F504A0")]
	public static bool IHFDCINACNP(byte PKPFJHLMNLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2F503B0", Offset = "0x2F4EFB0", VA = "0x182F503B0")]
	public static sbyte EGBLLDBHLJB(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2F50E70", Offset = "0x2F4FA70", VA = "0x182F50E70")]
	public static short KLDANFFIMJK(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2F50230", Offset = "0x2F4EE30", VA = "0x182F50230")]
	public static int CEFNBFEIKKK(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2F50580", Offset = "0x2F4F180", VA = "0x182F50580")]
	public static long IMKPBCAPCDL(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2F50630", Offset = "0x2F4F230", VA = "0x182F50630")]
	public static byte JBDDDNPMFLO(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2F501C0", Offset = "0x2F4EDC0", VA = "0x182F501C0")]
	public static ushort AEPKMAIFCAK(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2F50EE0", Offset = "0x2F4FAE0", VA = "0x182F50EE0")]
	public static uint MJJBIDNHCNF(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2F502A0", Offset = "0x2F4EEA0", VA = "0x182F502A0")]
	public static ulong CNMFONHFCBH(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2F50420", Offset = "0x2F4F020", VA = "0x182F50420")]
	public static float EPNJJBONDOJ(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2F50510", Offset = "0x2F4F110", VA = "0x182F50510")]
	public static double IIHFJACGHHA(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2F506A0", Offset = "0x2F4F2A0", VA = "0x182F506A0")]
	public static int KHIABHEGGGJ(ref byte[] EINFEEMFPOI, int IHLNGFCHHLC, ulong ODCJDJDBONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F580", Offset = "0x2F4E180", VA = "0x182F4F580")]
	public static int ACEOEDOEEKD(ref byte[] EINFEEMFPOI, int IHLNGFCHHLC, long ODCJDJDBONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F50F60", Offset = "0x2F4FB60", VA = "0x182F50F60")]
	public static bool PHPMEBOBMND(byte[] EDEEEGMMOHA, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class ACBPGCCLEJB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class PIHKNJBIEDN : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public PIHKNJBIEDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2F53A00", Offset = "0x2F52600", VA = "0x182F53A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2F535A0", Offset = "0x2F521A0", VA = "0x182F535A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2F53B20", Offset = "0x2F52720", VA = "0x182F53B20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2F53B70", Offset = "0x2F52770", VA = "0x182F53B70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2F539B0", Offset = "0x2F525B0", VA = "0x182F539B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2F53900", Offset = "0x2F52500", VA = "0x182F53900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2F53900", Offset = "0x2F52500", VA = "0x182F53900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class CFPOJCBLMHN : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x66D3E0", Offset = "0x66BFE0", VA = "0x18066D3E0")]
		[DebuggerHidden]
		public CFPOJCBLMHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FE80", Offset = "0x2F3EA80", VA = "0x182F3FE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FA20", Offset = "0x2F3E620", VA = "0x182F3FA20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FFA0", Offset = "0x2F3EBA0", VA = "0x182F3FFA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FFF0", Offset = "0x2F3EBF0", VA = "0x182F3FFF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FE30", Offset = "0x2F3EA30", VA = "0x182F3FE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FD80", Offset = "0x2F3E980", VA = "0x182F3FD80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2F3FD80", Offset = "0x2F3E980", VA = "0x182F3FD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2F39D00", Offset = "0x2F38900", VA = "0x182F39D00")]
	public static bool JLPLNPCLLIC(this TypeInfo CEEEOOFNMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2F39B70", Offset = "0x2F38770", VA = "0x182F39B70")]
	public static bool FFLDHEJPIGB(this TypeInfo CEEEOOFNMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2F39E40", Offset = "0x2F38A40", VA = "0x182F39E40")]
	public static IEnumerable<PropertyInfo> NKECFGIFKNA(this Type CEEEOOFNMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2F39DB0", Offset = "0x2F389B0", VA = "0x182F39DB0")]
	[IteratorStateMachine(typeof(PIHKNJBIEDN))]
	private static IEnumerable<PropertyInfo> NBGFIOJAKFE(Type CEEEOOFNMPD, HashSet<string> IAHHCBNKIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2F39B10", Offset = "0x2F38710", VA = "0x182F39B10")]
	public static IEnumerable<FieldInfo> BLPODLGDEHD(this Type CEEEOOFNMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C70", Offset = "0x2F38870", VA = "0x182F39C70")]
	[IteratorStateMachine(typeof(CFPOJCBLMHN))]
	private static IEnumerable<FieldInfo> HCIJMDKGCIN(Type CEEEOOFNMPD, HashSet<string> IAHHCBNKIHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class JNKGKJACBOC
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding GLHAKPLJHIH;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class LEMIPDDJDPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x611F60", Offset = "0x610B60", VA = "0x180611F60")]
	public static string EOEDOICIIFF(string KJCBCBPOLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3018D60", Offset = "0x3017960", VA = "0x183018D60")]
	public static string FKPOEGMHJKC(string KJCBCBPOLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3018E70", Offset = "0x3017A70", VA = "0x183018E70")]
	public static string KPKINPHHBKC(string KJCBCBPOLJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class MNNCCEFDIPH<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class FIDHLPHPAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type LBLIIGONCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue HNBDKKLMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int MNKDELGFFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public FIDHLPHPAEO CDOJOBPJHKC;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3CF52C0", Offset = "0x3CF3EC0", VA = "0x183CF52C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5020", Offset = "0x3CF3C20", VA = "0x183CF5020")]
		private int BPKHNEOEKIH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public FIDHLPHPAEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class GPENPEJCINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public GPENPEJCINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E90", Offset = "0x7F3A90", VA = "0x1807F4E90")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private FIDHLPHPAEO[] OFIGAHBIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int BNLHOMCBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object DKBPOKJPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float MDOILNNGCNK;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3D01540", Offset = "0x3D00140", VA = "0x183D01540")]
	public MNNCCEFDIPH(int HNBFBADKDCL = 4, float MDOILNNGCNK = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3D00460", Offset = "0x3CFF060", VA = "0x183D00460")]
	public bool GECDJKLEMCP(Type OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3D003E0", Offset = "0x3CFEFE0", VA = "0x183D003E0")]
	public bool GECDJKLEMCP(Type OMAJLLKKGPH, Func<Type, TValue> DPOGOKKBDFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3D00570", Offset = "0x3CFF170", VA = "0x183D00570")]
	private bool GEKDGLHJLEN(Type OMAJLLKKGPH, Func<Type, TValue> DPOGOKKBDFA, out TValue GMKMMHEDKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3D00B70", Offset = "0x3CFF770", VA = "0x183D00B70")]
	private bool HHOOCDDDMNO(FIDHLPHPAEO[] OFIGAHBIFNK, Type MKPBNLBLJHK, FIDHLPHPAEO DNHCKCKBCAA, Func<Type, TValue> DPOGOKKBDFA, out TValue GMKMMHEDKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3D00150", Offset = "0x3CFED50", VA = "0x183D00150")]
	public bool BOKJIEDKGMF(Type OMAJLLKKGPH, out TValue ODCJDJDBONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3D01380", Offset = "0x3CFFF80", VA = "0x183D01380")]
	public TValue HJKAEAJHDHG(Type OMAJLLKKGPH, Func<Type, TValue> DPOGOKKBDFA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3D002A0", Offset = "0x3CFEEA0", VA = "0x183D002A0")]
	private static int FGLDAAJPGDL(int ANEJNKDBDMK, float MDOILNNGCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3D01420", Offset = "0x3D00020", VA = "0x183D01420")]
	private static void NNHBMFJBGBB(ref FIDHLPHPAEO LDNKFEIPMBB, FIDHLPHPAEO ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3D01420", Offset = "0x3D00020", VA = "0x183D01420")]
	private static void NNHBMFJBGBB(ref FIDHLPHPAEO[] LDNKFEIPMBB, FIDHLPHPAEO[] ODCJDJDBONO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HDILLOPCJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder HEICIMFHOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder OCPPNODKOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object IBBGGKBDNGB;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E2E0", Offset = "0x2F4CEE0", VA = "0x182F4E2E0")]
	public TypeBuilder INMOLPCJBAO(string HBGNDBNJDEC, TypeAttributes FIGOLBANJGE, Type JNKAEALDKKD, Type[] DKENNCIKLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E3D0", Offset = "0x2F4CFD0", VA = "0x182F4E3D0")]
	public HDILLOPCJCG(string JKBHACNKDOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class ONADGKPMOPH
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2810", Offset = "0x4AE1410", VA = "0x184AE2810")]
	private static MethodInfo LNAGEGDJKLO(LambdaExpression GFDEDELABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x21EB2D0", Offset = "0x21E9ED0", VA = "0x1821EB2D0")]
	public static MethodInfo MFBPLDLIJFA<T>(Expression<Func<T>> GFDEDELABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x21EB2D0", Offset = "0x21E9ED0", VA = "0x1821EB2D0")]
	public static MethodInfo MFBPLDLIJFA<T, TR>(Expression<Func<T, TR>> GFDEDELABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x21EB2D0", Offset = "0x21E9ED0", VA = "0x1821EB2D0")]
	public static MethodInfo MFBPLDLIJFA<T>(Expression<Action<T>> GFDEDELABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x21EB2D0", Offset = "0x21E9ED0", VA = "0x1821EB2D0")]
	public static MethodInfo MFBPLDLIJFA<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GFDEDELABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x21EB1D0", Offset = "0x21E9DD0", VA = "0x1821EB1D0")]
	private static MemberInfo AJKEGKKIFBH<T>(Expression<T> OFELDCBPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x21EB270", Offset = "0x21E9E70", VA = "0x1821EB270")]
	public static PropertyInfo HBCGHGMCGCF<T, TR>(Expression<Func<T, TR>> GFDEDELABEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct JJIGDHPEBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int DAEOPGECNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool LJNKCJPDIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator OGOENPILONM;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3014010", Offset = "0x3012C10", VA = "0x183014010")]
	public JJIGDHPEBAL(ILGenerator OGOENPILONM, int DAEOPGECNJN, bool LJNKCJPDIJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3014050", Offset = "0x3012C50", VA = "0x183014050")]
	public JJIGDHPEBAL(ILGenerator OGOENPILONM, int DAEOPGECNJN, Type CEEEOOFNMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3013F00", Offset = "0x3012B00", VA = "0x183013F00")]
	public void OHOPPOFKPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IHIAKCBHBJF
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x300ECD0", Offset = "0x300D8D0", VA = "0x18300ECD0")]
	public static void GMDFJANAMNL(this ILGenerator OGOENPILONM, int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x300EF00", Offset = "0x300DB00", VA = "0x18300EF00")]
	public static void GMDFJANAMNL(this ILGenerator OGOENPILONM, LocalBuilder ANELMKBOGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x300F380", Offset = "0x300DF80", VA = "0x18300F380")]
	public static void KPLKAGMBMJK(this ILGenerator OGOENPILONM, int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x300F5B0", Offset = "0x300E1B0", VA = "0x18300F5B0")]
	public static void KPLKAGMBMJK(this ILGenerator OGOENPILONM, LocalBuilder ANELMKBOGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x300F050", Offset = "0x300DC50", VA = "0x18300F050")]
	public static void IDGFABPGNPM(this ILGenerator OGOENPILONM, int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x300EF40", Offset = "0x300DB40", VA = "0x18300EF40")]
	public static void IDGFABPGNPM(this ILGenerator OGOENPILONM, LocalBuilder ANELMKBOGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x300F140", Offset = "0x300DD40", VA = "0x18300F140")]
	public static void JKIPDCOGDGK(this ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x300EC20", Offset = "0x300D820", VA = "0x18300EC20")]
	public static void GKMBJOCNKME(this ILGenerator OGOENPILONM, bool ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x300F780", Offset = "0x300E380", VA = "0x18300F780")]
	public static void PDAJFIJACIM(this ILGenerator OGOENPILONM, int ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x300EAA0", Offset = "0x300D6A0", VA = "0x18300EAA0")]
	public static void EOIIFNOOJKG(this ILGenerator OGOENPILONM, Type CEEEOOFNMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x300EC30", Offset = "0x300D830", VA = "0x18300EC30")]
	public static void GLPKGFINMNG(this ILGenerator OGOENPILONM, Type CEEEOOFNMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x300F150", Offset = "0x300DD50", VA = "0x18300F150")]
	public static void KCJPKFFAOKL(this ILGenerator OGOENPILONM, int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x300EA20", Offset = "0x300D620", VA = "0x18300EA20")]
	public static void EBLBCPHPHOP(this ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x300E930", Offset = "0x300D530", VA = "0x18300E930")]
	public static void DFBIADLIBIC(this ILGenerator OGOENPILONM, int PMMFOLCEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x300F5F0", Offset = "0x300E1F0", VA = "0x18300F5F0")]
	public static void NCMDNFODLGC(this ILGenerator OGOENPILONM, MethodInfo DCKJKPICNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x300F6F0", Offset = "0x300E2F0", VA = "0x18300F6F0")]
	public static void PCKCOOEHLDB(this ILGenerator OGOENPILONM, FieldInfo HJGCBHJDPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x300EB90", Offset = "0x300D790", VA = "0x18300EB90")]
	public static void GCNGOMFKNKJ(this ILGenerator OGOENPILONM, ulong ODCJDJDBONO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class EEGHKMEEJID
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class AMPFJEKJAEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public AMPFJEKJAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2F3A8C0", Offset = "0x2F394C0", VA = "0x182F3A8C0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo BILJFMGJEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo IALIMIIFJLJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GBBNAEGPONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KOEOGCGKIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CLJADLEGOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2F43F60", Offset = "0x2F42B60", VA = "0x182F43F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HMGDOFPEKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x55C190", Offset = "0x55AD90", VA = "0x18055C190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x694360", Offset = "0x692F60", VA = "0x180694360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MEGGHEPLLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x55C1A0", Offset = "0x55ADA0", VA = "0x18055C1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xBB07D0", Offset = "0xBAF3D0", VA = "0x180BB07D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type FNINLBAICGK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6875A0", Offset = "0x6861A0", VA = "0x1806875A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo BCGOJIKCGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo MGFGFFEKFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x55D010", Offset = "0x55BC10", VA = "0x18055D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x55D020", Offset = "0x55BC20", VA = "0x18055D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo MEAMCLJMJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x56FD70", Offset = "0x56E970", VA = "0x18056FD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5F6FC0", Offset = "0x5F5BC0", VA = "0x1805F6FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2F44350", Offset = "0x2F42F50", VA = "0x182F44350")]
	protected EEGHKMEEJID(Type CEEEOOFNMPD, string HBGNDBNJDEC, string KHOFDDDHFCC, bool NBLNGOEGEDA, bool IBCGINFLEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2F44240", Offset = "0x2F42E40", VA = "0x182F44240")]
	public EEGHKMEEJID(FieldInfo GCMEGDICJNC, string HBGNDBNJDEC, bool FPJFLNKAMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2F44090", Offset = "0x2F42C90", VA = "0x182F44090")]
	public EEGHKMEEJID(PropertyInfo GCMEGDICJNC, string HBGNDBNJDEC, bool FPJFLNKAMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2F43F70", Offset = "0x2F42B70", VA = "0x182F43F70")]
	private static MethodInfo MLPGMIKCHCC(MemberInfo GCMEGDICJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1F50460", Offset = "0x1F4F060", VA = "0x181F50460")]
	public T EDMOHFOLFLE<T>(bool AINELGCGOGH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2F43DE0", Offset = "0x2F429E0", VA = "0x182F43DE0", Slot = "4")]
	public virtual void CANMLILFBGD(ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2F43EA0", Offset = "0x2F42AA0", VA = "0x182F43EA0", Slot = "5")]
	public virtual void EJEHLFOOADE(ILGenerator OGOENPILONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class OKLAECMOFBM : EEGHKMEEJID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string LMAPKGKGNCD;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0840", Offset = "0x4ADF440", VA = "0x184AE0840")]
	public OKLAECMOFBM(string HBGNDBNJDEC, string LMAPKGKGNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0730", Offset = "0x4ADF330", VA = "0x184AE0730", Slot = "4")]
	public override void CANMLILFBGD(ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4AE07F0", Offset = "0x4ADF3F0", VA = "0x184AE07F0", Slot = "5")]
	public override void EJEHLFOOADE(ILGenerator OGOENPILONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class COKDAGIOPOH : EEGHKMEEJID
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo MFACABOGLAL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo EDBKGEMPJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal JJIGDHPEBAL GNMPGGJBMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal JJIGDHPEBAL CLAKHCOHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal JJIGDHPEBAL KAEIMNIFDKI;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2F41B90", Offset = "0x2F40790", VA = "0x182F41B90")]
	public COKDAGIOPOH(string HBGNDBNJDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2F414D0", Offset = "0x2F400D0", VA = "0x182F414D0", Slot = "4")]
	public override void CANMLILFBGD(ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2F41590", Offset = "0x2F40190", VA = "0x182F41590", Slot = "5")]
	public override void EJEHLFOOADE(ILGenerator OGOENPILONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2F415E0", Offset = "0x2F401E0", VA = "0x182F415E0")]
	public void HCJDAPDPAKC(ILGenerator OGOENPILONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class POAOIPDGDGE
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type FNINLBAICGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PNJNPPIKLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6CE8C0", Offset = "0x6CD4C0", VA = "0x1806CE8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6CE8E0", Offset = "0x6CD4E0", VA = "0x1806CE8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HBNNBBKEEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xD1AF60", Offset = "0xD19B60", VA = "0x180D1AF60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xCE08D0", Offset = "0xCDF4D0", VA = "0x180CE08D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo MFBEPIOBDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x586D70", Offset = "0x585970", VA = "0x180586D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EEGHKMEEJID[] GEAFIHENPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5850C0", Offset = "0x583CC0", VA = "0x1805850C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6875A0", Offset = "0x6861A0", VA = "0x1806875A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EEGHKMEEJID[] HEEAHMKICHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x584A30", Offset = "0x583630", VA = "0x180584A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x671A50", Offset = "0x670650", VA = "0x180671A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3460", Offset = "0x4AE2060", VA = "0x184AE3460")]
	public POAOIPDGDGE(Type CEEEOOFNMPD, Func<string, string> JEDHCBBNAPM, bool FPJFLNKAMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3390", Offset = "0x4AE1F90", VA = "0x184AE3390")]
	private static bool HDINEEGGKBH(IEnumerator<ConstructorInfo> OJOPLOECFLN, ref ConstructorInfo FIHMFAIHECK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct NEEDJNFEMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong BMLHNCOCMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int GBDFGDELJEN;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2373D00", Offset = "0x2372900", VA = "0x182373D00")]
	public NEEDJNFEMIF(ulong NIDGFLLPMNK, int FKBHLJGOCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x301B8B0", Offset = "0x301A4B0", VA = "0x18301B8B0")]
	public void CLGBLNOIFBC(ref NEEDJNFEMIF PJEOMNDGEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x301B8C0", Offset = "0x301A4C0", VA = "0x18301B8C0")]
	public static NEEDJNFEMIF EIDPDHAHLFK(ref NEEDJNFEMIF BDJKEBGEAJO, ref NEEDJNFEMIF GONCOEMNHPC)
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x301B8F0", Offset = "0x301A4F0", VA = "0x18301B8F0")]
	public void EJGPDAPNCPO(ref NEEDJNFEMIF PJEOMNDGEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x301B980", Offset = "0x301A580", VA = "0x18301B980")]
	public static NEEDJNFEMIF HPDNMMLMKFC(ref NEEDJNFEMIF BDJKEBGEAJO, ref NEEDJNFEMIF GONCOEMNHPC)
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x301B810", Offset = "0x301A410", VA = "0x18301B810")]
	public void CDMEMMAFKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x301B850", Offset = "0x301A450", VA = "0x18301B850")]
	public static NEEDJNFEMIF CDMEMMAFKHB(ref NEEDJNFEMIF BDJKEBGEAJO)
	{
		return default(NEEDJNFEMIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MKGAAMHPBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] EINFEEMFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int IHLNGFCHHLC;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A79C0", Offset = "0x7A65C0", VA = "0x1807A79C0")]
	public MKGAAMHPBIA(byte[] EINFEEMFPOI, int EAPNHJBIJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x301AE20", Offset = "0x3019A20", VA = "0x18301AE20")]
	public void LPNLHGBJPAF(byte GPCMIGFPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x301ABB0", Offset = "0x30197B0", VA = "0x18301ABB0")]
	public void GLJAMKNHPMB(byte[] GPCMIGFPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x301AD80", Offset = "0x3019980", VA = "0x18301AD80")]
	public void HFMKNDEOLEA(byte[] GPCMIGFPEEF, int DMBGGGOKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x301ACD0", Offset = "0x30198D0", VA = "0x18301ACD0")]
	public void HFMKNDEOLEA(byte[] GPCMIGFPEEF, int ALJNEIFKIKO, int DMBGGGOKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x301AC50", Offset = "0x3019850", VA = "0x18301AC50")]
	public void HBAHOMHFDNG(byte PKPFJHLMNLB, int MAKGNGIINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x301AAB0", Offset = "0x30196B0", VA = "0x18301AAB0")]
	public void BCMKFJBBENK(string GPCMIGFPEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GCKLPOFPPDD
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum HCIKPPHFHHO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum MIJJADKHCFH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum JENDDJKCMIF
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
	private static byte[] BJMMJEIIOGL;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] GIGGCCGEEME;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] CCAOCOHBECE;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] NLCOFBEAPCD;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly JENDDJKCMIF FFIECPCDMAF;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char DOMOFHAIGJP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int DEKPBJDMBAE;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int DNDFOHEEOGJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] HIDPMLPGDHC;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F49700", Offset = "0x2F48300", VA = "0x182F49700")]
	private static byte[] EOONGHIJFNK(int BNLHOMCBDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A0B0", Offset = "0x2F48CB0", VA = "0x182F4A0B0")]
	private static byte[] KCPGJLAMFAB(int BNLHOMCBDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F48F90", Offset = "0x2F47B90", VA = "0x182F48F90")]
	public static int ACFJLMJPPGC(ref byte[] EINFEEMFPOI, int IHLNGFCHHLC, float ODCJDJDBONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F490A0", Offset = "0x2F47CA0", VA = "0x182F490A0")]
	public static int ACFJLMJPPGC(ref byte[] EINFEEMFPOI, int IHLNGFCHHLC, double ODCJDJDBONO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F49600", Offset = "0x2F48200", VA = "0x182F49600")]
	private static bool ECPPBNDDFPG(byte[] EINFEEMFPOI, int DMBGGGOKIMF, ulong DCJAHNNDCPH, ulong BKIFHHGDMDC, ulong KCJFKKHEPDA, ulong MGIFHEBCKCJ, ulong KMLHEAJCEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A4C0", Offset = "0x2F490C0", VA = "0x182F4A4C0")]
	private static void OGBKBNLPEDN(uint DKFIMPEHAKB, int KPCMPGEBBEO, out uint LNLGIFOIIPE, out int LEJEMHJLPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F491B0", Offset = "0x2F47DB0", VA = "0x182F491B0")]
	private static bool DLLKALFKNAK(NEEDJNFEMIF IKGGIELNKMD, NEEDJNFEMIF FOLOKEFNILH, NEEDJNFEMIF KIGMLLLJECJ, byte[] EINFEEMFPOI, out int DMBGGGOKIMF, out int MGKPPFDFPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A5E0", Offset = "0x2F491E0", VA = "0x182F4A5E0")]
	private static bool OOIOJJNKFOL(double EBHCGNBEDHN, HCIKPPHFHHO ODDGPNAKPIK, byte[] EINFEEMFPOI, out int DMBGGGOKIMF, out int LJLKFEFMMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F49E00", Offset = "0x2F48A00", VA = "0x182F49E00")]
	private static bool GIBDJNNDKCO(double EBHCGNBEDHN, HCIKPPHFHHO ODDGPNAKPIK, byte[] EINFEEMFPOI, out int DMBGGGOKIMF, out int PPFJLHEIOCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A330", Offset = "0x2F48F30", VA = "0x182F4A330")]
	private static bool OABEFHIBBFG(double ODCJDJDBONO, ref MKGAAMHPBIA EFCJMCKFELO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F497D0", Offset = "0x2F483D0", VA = "0x182F497D0")]
	private static bool GGDMHOPGFBA(double ODCJDJDBONO, ref MKGAAMHPBIA EFCJMCKFELO, MIJJADKHCFH ODDGPNAKPIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F49EF0", Offset = "0x2F48AF0", VA = "0x182F49EF0")]
	private static void HKFIHLHDHLP(byte[] OLNBLEKFLIM, int DMBGGGOKIMF, int PPFJLHEIOCA, int OMMPCLFOHHK, ref MKGAAMHPBIA EFCJMCKFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F48CA0", Offset = "0x2F478A0", VA = "0x182F48CA0")]
	private static void AAHAAMNDIAP(byte[] OLNBLEKFLIM, int DMBGGGOKIMF, int FKBHLJGOCEK, ref MKGAAMHPBIA EFCJMCKFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A190", Offset = "0x2F48D90", VA = "0x182F4A190")]
	private static bool NHOHMJMONNJ(double EBHCGNBEDHN, MIJJADKHCFH ODDGPNAKPIK, int AMHEBMCFLAF, byte[] DPJAFHJGELF, out bool IGPJLALBPHK, out int DMBGGGOKIMF, out int CDNIKKONEFF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct ALBNPOCMKAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double BFNPMNIFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong HANMHPKOKIP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct GNHJADPGJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float BMLHNCOCMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint ECGOOPJCOFE;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct NIIICIKLBEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong GIIILHGKKPH;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x301C250", Offset = "0x301AE50", VA = "0x18301C250")]
	public NIIICIKLBEI(double BFNPMNIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x301C260", Offset = "0x301AE60", VA = "0x18301C260")]
	public NIIICIKLBEI(NEEDJNFEMIF BFNPMNIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x301BD00", Offset = "0x301A900", VA = "0x18301BD00")]
	public NEEDJNFEMIF DNMHJHHEIOC()
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x301C1C0", Offset = "0x301ADC0", VA = "0x18301C1C0")]
	public NEEDJNFEMIF PNJEGHJIECN()
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x865D30", Offset = "0x864930", VA = "0x180865D30")]
	public ulong GJMLLMKOIOJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x301BFA0", Offset = "0x301ABA0", VA = "0x18301BFA0")]
	public double KHIJKKIBDAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x301BD80", Offset = "0x301A980", VA = "0x18301BD80")]
	public double DPHKGAADMKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x301BE10", Offset = "0x301AA10", VA = "0x18301BE10")]
	public int EJFPKFAJIKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x301BEE0", Offset = "0x301AAE0", VA = "0x18301BEE0")]
	public ulong FMBALALIKIK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x301C010", Offset = "0x301AC10", VA = "0x18301C010")]
	public bool OAOIOJONGKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x301BF60", Offset = "0x301AB60", VA = "0x18301BF60")]
	public bool HOEOHMBEPIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x301BCB0", Offset = "0x301A8B0", VA = "0x18301BCB0")]
	public bool BGACGIMGIJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x301C040", Offset = "0x301AC40", VA = "0x18301C040")]
	public bool ODHEKDDAEGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x301BF80", Offset = "0x301AB80", VA = "0x18301BF80")]
	public int JCELJLHEBFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x301C070", Offset = "0x301AC70", VA = "0x18301C070")]
	public void PFKOBMDLPHK(out NEEDJNFEMIF NNFAFOGKBCB, out NEEDJNFEMIF MLBOCBFMKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x301BF10", Offset = "0x301AB10", VA = "0x18301BF10")]
	public bool GPPHKCABGAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x301C030", Offset = "0x301AC30", VA = "0x18301C030")]
	public double ODCJDJDBONO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x301BCE0", Offset = "0x301A8E0", VA = "0x18301BCE0")]
	public static int CKBPBADBKAP(int BAFGEFDJHGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x301BE00", Offset = "0x301AA00", VA = "0x18301BE00")]
	public static double DPHLCLAGLMN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x301BE40", Offset = "0x301AA40", VA = "0x18301BE40")]
	public static ulong FLBHDLODHPM(NEEDJNFEMIF LPJBMHNCEMM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct EOOLMJGJEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint NFKJFPKPNEM;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DEB0", Offset = "0x1E1CAB0", VA = "0x181E1DEB0")]
	public EOOLMJGJEGN(float BMLHNCOCMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F44ED0", Offset = "0x2F43AD0", VA = "0x182F44ED0")]
	public NEEDJNFEMIF DNMHJHHEIOC()
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x784510", Offset = "0x783110", VA = "0x180784510")]
	public uint ONPBHGKLDAF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F44F40", Offset = "0x2F43B40", VA = "0x182F44F40")]
	public int EJFPKFAJIKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F44F60", Offset = "0x2F43B60", VA = "0x182F44F60")]
	public uint FMBALALIKIK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F44FC0", Offset = "0x2F43BC0", VA = "0x182F44FC0")]
	public bool OAOIOJONGKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F44FD0", Offset = "0x2F43BD0", VA = "0x182F44FD0")]
	public void PFKOBMDLPHK(out NEEDJNFEMIF NNFAFOGKBCB, out NEEDJNFEMIF MLBOCBFMKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F44F80", Offset = "0x2F43B80", VA = "0x182F44F80")]
	public bool GPPHKCABGAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct PPGMMMCILPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong NIDGFLLPMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short DGMNGJHGLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short LJLKFEFMMBN;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4D90", Offset = "0x4AE3990", VA = "0x184AE4D90")]
	public PPGMMMCILPH(ulong NIDGFLLPMNK, short DGMNGJHGLOL, short LJLKFEFMMBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class GACDJNCNKIH
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly PPGMMMCILPH[] KAMGBEFKOFN;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F46740", Offset = "0x2F45340", VA = "0x182F46740")]
	public static void BIEIGIBPPDF(int BJPHMDEPNPH, int HIMCBIKBLOA, out NEEDJNFEMIF LNLGIFOIIPE, out int LJLKFEFMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2F46640", Offset = "0x2F45240", VA = "0x182F46640")]
	public static void AGLADDBNFEA(int CAFOFNAGNFF, out NEEDJNFEMIF LNLGIFOIIPE, out int LJBECFMEPHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct BEOPFAOGKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] EDEEEGMMOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int ALJNEIFKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int CLIIJMDEMDA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte ABDOPKFKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F3B4E0", Offset = "0x2F3A0E0", VA = "0x182F3B4E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8D4070", Offset = "0x8D2C70", VA = "0x1808D4070")]
	public BEOPFAOGKHI(byte[] EDEEEGMMOHA, int ALJNEIFKIKO, int DMBGGGOKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7844D0", Offset = "0x7830D0", VA = "0x1807844D0")]
	public int DMBGGGOKIMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B520", Offset = "0x2F3A120", VA = "0x182F3B520")]
	public BEOPFAOGKHI NBLINKOMJPI(int ILJKCFDHLHM, int EDNOLMEMMMG)
	{
		return default(BEOPFAOGKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BGKFGJFEJCA
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] LFHPDEGCBFK;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] ILCIHNOODBC;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int PGOHDEEFEOO;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C5A0", Offset = "0x2F3B1A0", VA = "0x182F3C5A0")]
	private static byte[] ILHILMNLPCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BEA0", Offset = "0x2F3AAA0", VA = "0x182F3BEA0")]
	private static BEOPFAOGKHI EMOOEDJMAJI(BEOPFAOGKHI EINFEEMFPOI)
	{
		return default(BEOPFAOGKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B8C0", Offset = "0x2F3A4C0", VA = "0x182F3B8C0")]
	private static BEOPFAOGKHI BBIILNLIOCK(BEOPFAOGKHI EINFEEMFPOI)
	{
		return default(BEOPFAOGKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CCA0", Offset = "0x2F3B8A0", VA = "0x182F3CCA0")]
	private static void OEPLIGEINPL(BEOPFAOGKHI EINFEEMFPOI, int FKBHLJGOCEK, byte[] MIIIICPEPEM, out int IHFEELBNAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BB80", Offset = "0x2F3A780", VA = "0x182F3BB80")]
	private static void EDNHOBJBLPA(BEOPFAOGKHI EINFEEMFPOI, int FKBHLJGOCEK, byte[] MDHJBPDPGFP, int FNOLKIIADMG, out BEOPFAOGKHI BJKMHMAAKNL, out int OFHFNCBBFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C3D0", Offset = "0x2F3AFD0", VA = "0x182F3C3D0")]
	private static ulong HLJFAJMKIOH(BEOPFAOGKHI EINFEEMFPOI, out int NGGJPJDDHLL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CD50", Offset = "0x2F3B950", VA = "0x182F3CD50")]
	private static void PEPNCDCEFML(BEOPFAOGKHI EINFEEMFPOI, out NEEDJNFEMIF FNMKBJFEJIH, out int DMGNLBEMKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F3BF80", Offset = "0x2F3AB80", VA = "0x182F3BF80")]
	private static bool HABAKENBDLC(BEOPFAOGKHI BJKMHMAAKNL, int FKBHLJGOCEK, out double FNMKBJFEJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CB40", Offset = "0x2F3B740", VA = "0x182F3CB40")]
	private static NEEDJNFEMIF KANOKJJMCFB(int FKBHLJGOCEK)
	{
		return default(NEEDJNFEMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C680", Offset = "0x2F3B280", VA = "0x182F3C680")]
	private static bool JNGHAJNFFFK(BEOPFAOGKHI EINFEEMFPOI, int FKBHLJGOCEK, out double FNMKBJFEJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C460", Offset = "0x2F3B060", VA = "0x182F3C460")]
	private static bool IKOMPBJDLLC(BEOPFAOGKHI BJKMHMAAKNL, int FKBHLJGOCEK, out double OHDIDMMBHCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B790", Offset = "0x2F3A390", VA = "0x182F3B790")]
	public static double? AHHHBBKEMPK(BEOPFAOGKHI EINFEEMFPOI, int FKBHLJGOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B9A0", Offset = "0x2F3A5A0", VA = "0x182F3B9A0")]
	public static float? DKOMBIILCMF(BEOPFAOGKHI EINFEEMFPOI, int FKBHLJGOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct NECKKIAINBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] EINFEEMFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int IHLNGFCHHLC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x301B5E0", Offset = "0x301A1E0", VA = "0x18301B5E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A79C0", Offset = "0x7A65C0", VA = "0x1807A79C0")]
	public NECKKIAINBK(byte[] EINFEEMFPOI, int IHLNGFCHHLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x301B6A0", Offset = "0x301A2A0", VA = "0x18301B6A0")]
	public static NECKKIAINBK GIPIIINBCKD(NECKKIAINBK MPDFMGGHMLI)
	{
		return default(NECKKIAINBK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x301B580", Offset = "0x301A180", VA = "0x18301B580")]
	public static NECKKIAINBK BEGGLOIEPOO(NECKKIAINBK MPDFMGGHMLI, int DMBGGGOKIMF)
	{
		return default(NECKKIAINBK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x301B7F0", Offset = "0x301A3F0", VA = "0x18301B7F0")]
	public static int NMEMLLOCDBD(NECKKIAINBK DMGEENBOIFD, NECKKIAINBK CGDAAEMLLFJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x301B6F0", Offset = "0x301A2F0", VA = "0x18301B6F0")]
	public static bool KHGJMNBDDHA(NECKKIAINBK DMGEENBOIFD, NECKKIAINBK CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x301B7D0", Offset = "0x301A3D0", VA = "0x18301B7D0")]
	public static bool MCNBFCBPMDA(NECKKIAINBK DMGEENBOIFD, NECKKIAINBK CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x301B710", Offset = "0x301A310", VA = "0x18301B710")]
	public static bool KHGJMNBDDHA(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x301B790", Offset = "0x301A390", VA = "0x18301B790")]
	public static bool MCNBFCBPMDA(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x301B790", Offset = "0x301A390", VA = "0x18301B790")]
	public static bool MCNBFCBPMDA(NECKKIAINBK DMGEENBOIFD, byte CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x301B660", Offset = "0x301A260", VA = "0x18301B660")]
	public static bool FNCCFAMJDHJ(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x301B750", Offset = "0x301A350", VA = "0x18301B750")]
	public static bool KJHJGAEJDAG(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x301B620", Offset = "0x301A220", VA = "0x18301B620")]
	public static bool FMHFFJIFDFG(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x301B6B0", Offset = "0x301A2B0", VA = "0x18301B6B0")]
	public static bool JGPBEMDEOAM(NECKKIAINBK DMGEENBOIFD, char CGDAAEMLLFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class OEDJEMCEKFE
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] BJKLDCLELJF;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] ALFNLLFADLE;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] CCAOCOHBECE;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] NLCOFBEAPCD;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] EAKNILOPALM;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int PCPJLOAIAHI;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] BEOJLJHOAPN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int OMHBGMPJOHK;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC720", Offset = "0x4ADB320", VA = "0x184ADC720")]
	private static byte[] DMLFPFKJIEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC800", Offset = "0x4ADB400", VA = "0x184ADC800")]
	private static byte[] FJBIMMJHJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4ADDA40", Offset = "0x4ADC640", VA = "0x184ADDA40")]
	public static double MPOFGNMIADC(byte[] EINFEEMFPOI, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC550", Offset = "0x4ADB150", VA = "0x184ADC550")]
	public static float CDCCNJFFOHG(byte[] EINFEEMFPOI, int IHLNGFCHHLC, out int DBHGNJJKELE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4ADDB00", Offset = "0x4ADC700", VA = "0x184ADDB00")]
	private static bool ONBICOENKBC(int JJCLMNFFLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC430", Offset = "0x4ADB030", VA = "0x184ADC430")]
	private static bool APDDELDCBOK(ref NECKKIAINBK GMPMFFPAGLL, NECKKIAINBK BBJPFDEKHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC610", Offset = "0x4ADB210", VA = "0x184ADC610")]
	private static bool DMIHBMHAECD(ref NECKKIAINBK GMPMFFPAGLL, NECKKIAINBK BBJPFDEKHCM, byte[] GFDNMBIFANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC8E0", Offset = "0x4ADB4E0", VA = "0x184ADC8E0")]
	private static bool GPONPCGDDOM(ref NECKKIAINBK ANBLAFEGBIO, byte[] GPCMIGFPEEF, int IHLNGFCHHLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xD72BC0", Offset = "0xD717C0", VA = "0x180D72BC0")]
	private static double ONHGGOEHOGM(bool IGPJLALBPHK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC930", Offset = "0x4ADB530", VA = "0x184ADC930")]
	private static double IMDKEDDNBFO(NECKKIAINBK KBBHJLPMDKI, int DMBGGGOKIMF, bool APDFAAJIPJB, out int AEIBNCBFINE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class EIIPNLDJPJD<T> : global::EPIIBJLGPNA<T[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::DGMKKBPNOII<T> PPHJALCHMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly OMLBIIILDNN CBGCPKGHBJP;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3844FD0", Offset = "0x3843BD0", VA = "0x183844FD0")]
	public EIIPNLDJPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1D051A0", Offset = "0x1D03DA0", VA = "0x181D051A0")]
	public EIIPNLDJPJD(OMLBIIILDNN CBGCPKGHBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3EC33A0", Offset = "0x3EC1FA0", VA = "0x183EC33A0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, T[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3EC15F0", Offset = "0x3EC01F0", VA = "0x183EC15F0", Slot = "5")]
	public T[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class OKGHDAHOPJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::DGMKKBPNOII<T> PPHJALCHMCI;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class GFJBIIMMGII<T> : global::EPIIBJLGPNA<List<T>>, FHLLIKOGGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly OMLBIIILDNN CBGCPKGHBJP;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3844FD0", Offset = "0x3843BD0", VA = "0x183844FD0")]
	public GFJBIIMMGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1D051A0", Offset = "0x1D03DA0", VA = "0x181D051A0")]
	public GFJBIIMMGII(OMLBIIILDNN CBGCPKGHBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3844DB0", Offset = "0x38439B0", VA = "0x183844DB0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, List<T> ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3843B80", Offset = "0x3842780", VA = "0x183843B80", Slot = "5")]
	public List<T> DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FFKIFAINIFI<TElement, TIntermediate, TEnumerator, TCollection> : global::EPIIBJLGPNA<TCollection>, FHLLIKOGGFC where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3D26AF0", Offset = "0x3D256F0", VA = "0x183D26AF0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, TCollection ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3D262F0", Offset = "0x3D24EF0", VA = "0x183D262F0", Slot = "5")]
	public TCollection DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CBGBECNEKFN(TCollection OFELDCBPMEH);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KGHLJHHMDNN();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DNJODILJGAL(ref TIntermediate HDEOCGHDANO, int PMMFOLCEJEJ, TElement ODCJDJDBONO);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DPCLEGEILBJ(ref TIntermediate FJAKKKDFMLA);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
	protected FFKIFAINIFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class HMMHDBCOPAL<TElement, TIntermediate, TCollection> : global::FFKIFAINIFI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x36FC810", Offset = "0x36FB410", VA = "0x1836FC810", Slot = "6")]
	protected override IEnumerator<TElement> CBGBECNEKFN(TCollection OFELDCBPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1EF21B0", Offset = "0x1EF0DB0", VA = "0x181EF21B0")]
	protected HMMHDBCOPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class BFMJMJGNJHD<TElement, TCollection> : global::HMMHDBCOPAL<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected sealed override TCollection DPCLEGEILBJ(ref TCollection FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NJNCJPALBOL<TElement, TCollection> : global::BFMJMJGNJHD<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2B3EF90", Offset = "0x2B3DB90", VA = "0x182B3EF90", Slot = "7")]
	protected override TCollection KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2B3EF20", Offset = "0x2B3DB20", VA = "0x182B3EF20", Slot = "8")]
	protected override void DNJODILJGAL(ref TCollection HDEOCGHDANO, int PMMFOLCEJEJ, TElement ODCJDJDBONO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PFNLOIFDBKJ<T> : global::FFKIFAINIFI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2275110", Offset = "0x2273D10", VA = "0x182275110", Slot = "8")]
	protected override void DNJODILJGAL(ref LinkedList<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override LinkedList<T> DPCLEGEILBJ(ref LinkedList<T> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override LinkedList<T> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x22750B0", Offset = "0x2273CB0", VA = "0x1822750B0", Slot = "6")]
	protected override LinkedList<T>.Enumerator CBGBECNEKFN(LinkedList<T> OFELDCBPMEH)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class GPLMIAMBIEF<T> : global::FFKIFAINIFI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2275110", Offset = "0x2273D10", VA = "0x182275110", Slot = "8")]
	protected override void DNJODILJGAL(ref Queue<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override Queue<T> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D30", Offset = "0x31D0930", VA = "0x1831D1D30", Slot = "6")]
	protected override Queue<T>.Enumerator CBGBECNEKFN(Queue<T> OFELDCBPMEH)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override Queue<T> DPCLEGEILBJ(ref Queue<T> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class GKHMEKLMCOM<T> : global::FFKIFAINIFI<T, global::BEDBCLJHCBE<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3298840", Offset = "0x3297440", VA = "0x183298840", Slot = "8")]
	protected override void DNJODILJGAL(ref global::BEDBCLJHCBE<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3298890", Offset = "0x3297490", VA = "0x183298890", Slot = "7")]
	protected override global::BEDBCLJHCBE<T> KGHLJHHMDNN()
	{
		return default(global::BEDBCLJHCBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D30", Offset = "0x31D0930", VA = "0x1831D1D30", Slot = "6")]
	protected override Stack<T>.Enumerator CBGBECNEKFN(Stack<T> OFELDCBPMEH)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x38B20C0", Offset = "0x38B0CC0", VA = "0x1838B20C0", Slot = "9")]
	protected override Stack<T> DPCLEGEILBJ(ref global::BEDBCLJHCBE<T> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class NADBOLFNGIF<T> : global::FFKIFAINIFI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2275110", Offset = "0x2273D10", VA = "0x182275110", Slot = "8")]
	protected override void DNJODILJGAL(ref HashSet<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override HashSet<T> DPCLEGEILBJ(ref HashSet<T> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override HashSet<T> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x31D1D30", Offset = "0x31D0930", VA = "0x1831D1D30", Slot = "6")]
	protected override HashSet<T>.Enumerator CBGBECNEKFN(HashSet<T> OFELDCBPMEH)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IMAEFBIJLHC<T> : global::HMMHDBCOPAL<T, global::BEDBCLJHCBE<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3298840", Offset = "0x3297440", VA = "0x183298840", Slot = "8")]
	protected override void DNJODILJGAL(ref global::BEDBCLJHCBE<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x33DE160", Offset = "0x33DCD60", VA = "0x1833DE160", Slot = "9")]
	protected override ReadOnlyCollection<T> DPCLEGEILBJ(ref global::BEDBCLJHCBE<T> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x33DE1F0", Offset = "0x33DCDF0", VA = "0x1833DE1F0", Slot = "7")]
	protected override global::BEDBCLJHCBE<T> KGHLJHHMDNN()
	{
		return default(global::BEDBCLJHCBE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class DDCEMPDDHJH<T> : global::HMMHDBCOPAL<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2275110", Offset = "0x2273D10", VA = "0x182275110", Slot = "8")]
	protected override void DNJODILJGAL(ref List<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override List<T> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override IList<T> DPCLEGEILBJ(ref List<T> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class FGDLMLJFNII<T> : global::HMMHDBCOPAL<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2275110", Offset = "0x2273D10", VA = "0x182275110", Slot = "8")]
	protected override void DNJODILJGAL(ref List<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override List<T> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override ICollection<T> DPCLEGEILBJ(ref List<T> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class EPIMFNHDAAD<T> : global::HMMHDBCOPAL<T, global::BEDBCLJHCBE<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3298840", Offset = "0x3297440", VA = "0x183298840", Slot = "8")]
	protected override void DNJODILJGAL(ref global::BEDBCLJHCBE<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3298890", Offset = "0x3297490", VA = "0x183298890", Slot = "7")]
	protected override global::BEDBCLJHCBE<T> KGHLJHHMDNN()
	{
		return default(global::BEDBCLJHCBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3298870", Offset = "0x3297470", VA = "0x183298870", Slot = "9")]
	protected override IEnumerable<T> DPCLEGEILBJ(ref global::BEDBCLJHCBE<T> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class FGJPKDJLMNK<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class FMNMBCJPFHG<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DOPKEPAGFBA<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class BKIGMAOCLEP : global::EPIIBJLGPNA<IEnumerable>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::EPIIBJLGPNA<IEnumerable> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D160", Offset = "0x2F3BD60", VA = "0x182F3D160", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, IEnumerable ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2F3CFE0", Offset = "0x2F3BBE0", VA = "0x182F3CFE0", Slot = "5")]
	public IEnumerable DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BKIGMAOCLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class INKDKDAJBAF : global::EPIIBJLGPNA<ICollection>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::EPIIBJLGPNA<ICollection> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3012BA0", Offset = "0x30117A0", VA = "0x183012BA0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ICollection ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x30129B0", Offset = "0x30115B0", VA = "0x1830129B0", Slot = "5")]
	public ICollection DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public INKDKDAJBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class NPICFHDONDG : global::EPIIBJLGPNA<IList>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::EPIIBJLGPNA<IList> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x301C630", Offset = "0x301B230", VA = "0x18301C630", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, IList ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x301C440", Offset = "0x301B040", VA = "0x18301C440", Slot = "5")]
	public IList DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public NPICFHDONDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class GAFACMMFDAF<T> : global::HMMHDBCOPAL<T, global::BEDBCLJHCBE<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3841460", Offset = "0x3840060", VA = "0x183841460", Slot = "8")]
	protected override void DNJODILJGAL(ref global::BEDBCLJHCBE<T> HDEOCGHDANO, int PMMFOLCEJEJ, T ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3298890", Offset = "0x3297490", VA = "0x183298890", Slot = "7")]
	protected override global::BEDBCLJHCBE<T> KGHLJHHMDNN()
	{
		return default(global::BEDBCLJHCBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3841490", Offset = "0x3840090", VA = "0x183841490", Slot = "9")]
	protected override IReadOnlyList<T> DPCLEGEILBJ(ref global::BEDBCLJHCBE<T> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1D09AB0", Offset = "0x1D086B0", VA = "0x181D09AB0")]
	public GAFACMMFDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class NFEGMGGAFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x301BA30", Offset = "0x301A630", VA = "0x18301BA30")]
	public static DateTime KCJJMKLBAOF(DateTime EIELDHGGAPN)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OGFLCGHHNMH : global::EPIIBJLGPNA<DateTime>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::EPIIBJLGPNA<DateTime> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0170", Offset = "0x4ADED70", VA = "0x184AE0170", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, DateTime ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF270", Offset = "0x4ADDE70", VA = "0x184ADF270", Slot = "5")]
	public DateTime DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OGFLCGHHNMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class OFNJALJBCOJ : global::EPIIBJLGPNA<DateTimeOffset>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::EPIIBJLGPNA<DateTimeOffset> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4ADEE40", Offset = "0x4ADDA40", VA = "0x184ADEE40", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, DateTimeOffset ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4ADDEA0", Offset = "0x4ADCAA0", VA = "0x184ADDEA0", Slot = "5")]
	public DateTimeOffset DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OFNJALJBCOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class DBIKHBCHPBF : global::EPIIBJLGPNA<TimeSpan>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::EPIIBJLGPNA<TimeSpan> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] MNPFMNGJGPB;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2F424B0", Offset = "0x2F410B0", VA = "0x182F424B0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, TimeSpan ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2F41C40", Offset = "0x2F40840", VA = "0x182F41C40", Slot = "5")]
	public TimeSpan DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public DBIKHBCHPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class JMFHBIODDEP<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::EPIIBJLGPNA<TDictionary>, FHLLIKOGGFC where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x350EF50", Offset = "0x350DB50", VA = "0x18350EF50", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, TDictionary ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x350CDC0", Offset = "0x350B9C0", VA = "0x18350CDC0", Slot = "5")]
	public TDictionary DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CBGBECNEKFN(TDictionary OFELDCBPMEH);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate KGHLJHHMDNN();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DNJODILJGAL(ref TIntermediate HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DPCLEGEILBJ(ref TIntermediate FJAKKKDFMLA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
	protected JMFHBIODDEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class HOFKOOCDGNA<TKey, TValue, TIntermediate, TDictionary> : global::JMFHBIODDEP<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3790C10", Offset = "0x378F810", VA = "0x183790C10", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> CBGBECNEKFN(TDictionary OFELDCBPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class GJEJCGLNBIO<TKey, TValue, TDictionary> : global::HOFKOOCDGNA<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override TDictionary DPCLEGEILBJ(ref TDictionary FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class IAJFLJMHOCF<TKey, TValue> : global::JMFHBIODDEP<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3792900", Offset = "0x3791500", VA = "0x183792900", Slot = "8")]
	protected override void DNJODILJGAL(ref Dictionary<TKey, TValue> HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override Dictionary<TKey, TValue> DPCLEGEILBJ(ref Dictionary<TKey, TValue> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override Dictionary<TKey, TValue> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x37928B0", Offset = "0x37914B0", VA = "0x1837928B0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator CBGBECNEKFN(Dictionary<TKey, TValue> OFELDCBPMEH)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D7F0", Offset = "0x1D0C3F0", VA = "0x181D0D7F0")]
	public IAJFLJMHOCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class MLGDJDFAEPM<TKey, TValue, TDictionary> : global::GJEJCGLNBIO<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x258CD40", Offset = "0x258B940", VA = "0x18258CD40", Slot = "8")]
	protected override void DNJODILJGAL(ref TDictionary HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x258CE20", Offset = "0x258BA20", VA = "0x18258CE20", Slot = "7")]
	protected override TDictionary KGHLJHHMDNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class LFBAPBADDIC<TKey, TValue> : global::HOFKOOCDGNA<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2B246B0", Offset = "0x2B232B0", VA = "0x182B246B0", Slot = "8")]
	protected override void DNJODILJGAL(ref Dictionary<TKey, TValue> HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override Dictionary<TKey, TValue> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override IDictionary<TKey, TValue> DPCLEGEILBJ(ref Dictionary<TKey, TValue> FJAKKKDFMLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NPLNPDLFEGC<TKey, TValue> : global::GJEJCGLNBIO<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2B246B0", Offset = "0x2B232B0", VA = "0x182B246B0", Slot = "8")]
	protected override void DNJODILJGAL(ref SortedList<TKey, TValue> HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override SortedList<TKey, TValue> KGHLJHHMDNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class DJNHGGCNJGJ<TKey, TValue> : global::JMFHBIODDEP<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2B246B0", Offset = "0x2B232B0", VA = "0x182B246B0", Slot = "8")]
	protected override void DNJODILJGAL(ref SortedDictionary<TKey, TValue> HDEOCGHDANO, int PMMFOLCEJEJ, TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xFFB450", Offset = "0xFFA050", VA = "0x180FFB450", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DPCLEGEILBJ(ref SortedDictionary<TKey, TValue> FJAKKKDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2275150", Offset = "0x2273D50", VA = "0x182275150", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> KGHLJHHMDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3216F10", Offset = "0x3215B10", VA = "0x183216F10", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator CBGBECNEKFN(SortedDictionary<TKey, TValue> OFELDCBPMEH)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class HKIOBBCIHOD<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class HBDDIDAHADD : global::EPIIBJLGPNA<IDictionary>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::EPIIBJLGPNA<IDictionary> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DDF0", Offset = "0x2F4C9F0", VA = "0x182F4DDF0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, IDictionary ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DC50", Offset = "0x2F4C850", VA = "0x182F4DC50", Slot = "5")]
	public IDictionary DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HBDDIDAHADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class GFJOGEGJOAA : global::EPIIBJLGPNA<object>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void EBHDHJDKKOJ(object BKJFDJIHNNO, ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::MNNCCEFDIPH<KeyValuePair<object, EBHDHJDKKOJ>> BDNCELDFEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly IOIBOLJBEGL[] NDFJAAFPLMF;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2F4B6D0", Offset = "0x2F4A2D0", VA = "0x182F4B6D0")]
	public GFJOGEGJOAA(params IOIBOLJBEGL[] NDFJAAFPLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2F4AD60", Offset = "0x2F49960", VA = "0x182F4AD60", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2F4ACD0", Offset = "0x2F498D0", VA = "0x182F4ACD0", Slot = "5")]
	public object DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class HEEHMLBAFMC
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E4D0", Offset = "0x2F4D0D0", VA = "0x182F4E4D0")]
	public static object AHPDDIGPMPC(Type CEEEOOFNMPD, out bool BAIHNIEIHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4ECB0", Offset = "0x2F4D8B0", VA = "0x182F4ECB0")]
	public static object EEHNAJBHNEI(Type CEEEOOFNMPD, out bool BAIHNIEIHLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class AJOKIOCFKBO<T> : global::EPIIBJLGPNA<T>, FHLLIKOGGFC, global::ODFGCJPFNPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AFHIOOIINIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public AFHIOOIINIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1B40", Offset = "0x1EA0740", VA = "0x181EA1B40")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class BDABGKLEJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::HJCBAJHIAPL<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public BDABGKLEJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8030", Offset = "0x1EA6C30", VA = "0x181EA8030")]
		internal void <.cctor>b__1(ref GONHPJLEIMB writer, T value, IOIBOLJBEGL _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GNFKALEGFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::JMFJBNJNHAD<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public GNFKALEGFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB010", Offset = "0x1EA9C10", VA = "0x181EAB010")]
		internal T <.cctor>b__2(ref IJNHJAICOBP reader, IOIBOLJBEGL _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::CJFDNFKLLLK<T> CJCGHOEEHBB;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> MLLHHDOBAKB;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::HJCBAJHIAPL<T> NIBEJNBPEAK;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::JMFJBNJNHAD<T> DFEKLGAMHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool OHHJCGPKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::HJCBAJHIAPL<T> HHPHNLFDEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::JMFJBNJNHAD<T> POFFFPNECGH;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4880", Offset = "0x1EA3480", VA = "0x181EA4880")]
	static AJOKIOCFKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7400", Offset = "0x1EA6000", VA = "0x181EA7400")]
	public AJOKIOCFKBO(bool OHHJCGPKBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3340", Offset = "0x1EA1F40", VA = "0x181EA3340", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1EA28F0", Offset = "0x1EA14F0", VA = "0x181EA28F0", Slot = "5")]
	public T DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x1EA3270", Offset = "0x1EA1E70", VA = "0x181EA3270", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, T ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1EA2FA0", Offset = "0x1EA1BA0", VA = "0x181EA2FA0", Slot = "7")]
	public T HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class JOMHGJMIAGL<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class BOFCOHOGNMK<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LIBFFMDKDAH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class LDKNOCNJNOD<T> : global::EPIIBJLGPNA<T?>, FHLLIKOGGFC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2B24420", Offset = "0x2B23020", VA = "0x182B24420", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, T? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2B24270", Offset = "0x2B22E70", VA = "0x182B24270", Slot = "5")]
	public T? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
	public LDKNOCNJNOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GPMHGJIOGBL<T> : global::EPIIBJLGPNA<T?>, FHLLIKOGGFC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::EPIIBJLGPNA<T> EKPLHHFCBMM;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
	public GPMHGJIOGBL(global::EPIIBJLGPNA<T> EKPLHHFCBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3368580", Offset = "0x3367180", VA = "0x183368580", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, T? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3367EA0", Offset = "0x3366AA0", VA = "0x183367EA0", Slot = "5")]
	public T? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class BFFIHDLFCAB : global::EPIIBJLGPNA<sbyte>, FHLLIKOGGFC, global::ODFGCJPFNPK<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly BFFIHDLFCAB FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B6F0", Offset = "0x2F3A2F0", VA = "0x182F3B6F0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, sbyte ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B580", Offset = "0x2F3A180", VA = "0x182F3B580", Slot = "5")]
	public sbyte DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B630", Offset = "0x2F3A230", VA = "0x182F3B630", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, sbyte ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B590", Offset = "0x2F3A190", VA = "0x182F3B590", Slot = "7")]
	public sbyte HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BFFIHDLFCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class LHNPNINMMMM : global::EPIIBJLGPNA<sbyte?>, FHLLIKOGGFC, global::ODFGCJPFNPK<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly LHNPNINMMMM FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3019600", Offset = "0x3018200", VA = "0x183019600", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, sbyte? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3019420", Offset = "0x3018020", VA = "0x183019420", Slot = "5")]
	public sbyte? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3019580", Offset = "0x3018180", VA = "0x183019580", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, sbyte? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x30194D0", Offset = "0x30180D0", VA = "0x1830194D0", Slot = "7")]
	public sbyte? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LHNPNINMMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class CKKOFDMNHHB : global::EPIIBJLGPNA<sbyte[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly CKKOFDMNHHB FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F40370", Offset = "0x2F3EF70", VA = "0x182F40370", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, sbyte[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F40230", Offset = "0x2F3EE30", VA = "0x182F40230", Slot = "5")]
	public sbyte[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public CKKOFDMNHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JOGELJHHKKA : global::EPIIBJLGPNA<short>, FHLLIKOGGFC, global::ODFGCJPFNPK<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly JOGELJHHKKA FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3016F60", Offset = "0x3015B60", VA = "0x183016F60", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, short ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3016E50", Offset = "0x3015A50", VA = "0x183016E50", Slot = "5")]
	public short DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3016F20", Offset = "0x3015B20", VA = "0x183016F20", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, short ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3016EB0", Offset = "0x3015AB0", VA = "0x183016EB0", Slot = "7")]
	public short HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public JOGELJHHKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class KBKBKKAHHEN : global::EPIIBJLGPNA<short?>, FHLLIKOGGFC, global::ODFGCJPFNPK<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly KBKBKKAHHEN FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3017C90", Offset = "0x3016890", VA = "0x183017C90", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, short? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3017AC0", Offset = "0x30166C0", VA = "0x183017AC0", Slot = "5")]
	public short? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3017C10", Offset = "0x3016810", VA = "0x183017C10", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, short? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x3017B70", Offset = "0x3016770", VA = "0x183017B70", Slot = "7")]
	public short? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public KBKBKKAHHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class LBNOJEBMAPI : global::EPIIBJLGPNA<short[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly LBNOJEBMAPI FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3018820", Offset = "0x3017420", VA = "0x183018820", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, short[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x3018680", Offset = "0x3017280", VA = "0x183018680", Slot = "5")]
	public short[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LBNOJEBMAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IMMOBGHGFLE : global::EPIIBJLGPNA<int>, FHLLIKOGGFC, global::ODFGCJPFNPK<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly IMMOBGHGFLE FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3012940", Offset = "0x3011540", VA = "0x183012940", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, int ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3012830", Offset = "0x3011430", VA = "0x183012830", Slot = "5")]
	public int DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3012900", Offset = "0x3011500", VA = "0x183012900", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, int ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3012890", Offset = "0x3011490", VA = "0x183012890", Slot = "7")]
	public int HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public IMMOBGHGFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class BPMGIHPKIPO : global::EPIIBJLGPNA<int?>, FHLLIKOGGFC, global::ODFGCJPFNPK<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly BPMGIHPKIPO FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DBC0", Offset = "0x2F3C7C0", VA = "0x182F3DBC0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, int? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D980", Offset = "0x2F3C580", VA = "0x182F3D980", Slot = "5")]
	public int? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DAC0", Offset = "0x2F3C6C0", VA = "0x182F3DAC0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, int? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D9F0", Offset = "0x2F3C5F0", VA = "0x182F3D9F0", Slot = "7")]
	public int? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BPMGIHPKIPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class ABCBMOMFDEF : global::EPIIBJLGPNA<int[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ABCBMOMFDEF FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F39910", Offset = "0x2F38510", VA = "0x182F39910", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, int[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F397D0", Offset = "0x2F383D0", VA = "0x182F397D0", Slot = "5")]
	public int[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public ABCBMOMFDEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class KELPCCOAOFH : global::EPIIBJLGPNA<long>, FHLLIKOGGFC, global::ODFGCJPFNPK<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly KELPCCOAOFH FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3017EE0", Offset = "0x3016AE0", VA = "0x183017EE0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, long ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3017E20", Offset = "0x3016A20", VA = "0x183017E20", Slot = "5")]
	public long DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3017EA0", Offset = "0x3016AA0", VA = "0x183017EA0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, long ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3017E30", Offset = "0x3016A30", VA = "0x183017E30", Slot = "7")]
	public long HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public KELPCCOAOFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class LFINAIBPBOP : global::EPIIBJLGPNA<long?>, FHLLIKOGGFC, global::ODFGCJPFNPK<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LFINAIBPBOP FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x3019350", Offset = "0x3017F50", VA = "0x183019350", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, long? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3019180", Offset = "0x3017D80", VA = "0x183019180", Slot = "5")]
	public long? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x30192D0", Offset = "0x3017ED0", VA = "0x1830192D0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, long? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3019210", Offset = "0x3017E10", VA = "0x183019210", Slot = "7")]
	public long? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LFINAIBPBOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class GGKGGJLNCCF : global::EPIIBJLGPNA<long[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly GGKGGJLNCCF FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F4B8B0", Offset = "0x2F4A4B0", VA = "0x182F4B8B0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, long[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F4B770", Offset = "0x2F4A370", VA = "0x182F4B770", Slot = "5")]
	public long[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GGKGGJLNCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class GHEDCAMOKDC : global::EPIIBJLGPNA<byte>, FHLLIKOGGFC, global::ODFGCJPFNPK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GHEDCAMOKDC FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BC20", Offset = "0x2F4A820", VA = "0x182F4BC20", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, byte ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BAB0", Offset = "0x2F4A6B0", VA = "0x182F4BAB0", Slot = "5")]
	public byte DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BB60", Offset = "0x2F4A760", VA = "0x182F4BB60", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, byte ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BAC0", Offset = "0x2F4A6C0", VA = "0x182F4BAC0", Slot = "7")]
	public byte HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GHEDCAMOKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class BLECKHAPKIG : global::EPIIBJLGPNA<byte?>, FHLLIKOGGFC, global::ODFGCJPFNPK<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BLECKHAPKIG FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D670", Offset = "0x2F3C270", VA = "0x182F3D670", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, byte? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D420", Offset = "0x2F3C020", VA = "0x182F3D420", Slot = "5")]
	public byte? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D570", Offset = "0x2F3C170", VA = "0x182F3D570", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, byte? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D490", Offset = "0x2F3C090", VA = "0x182F3D490", Slot = "7")]
	public byte? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BLECKHAPKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NBHNFAFCAFN : global::EPIIBJLGPNA<ushort>, FHLLIKOGGFC, global::ODFGCJPFNPK<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NBHNFAFCAFN FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x301B500", Offset = "0x301A100", VA = "0x18301B500", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ushort ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x301B3F0", Offset = "0x3019FF0", VA = "0x18301B3F0", Slot = "5")]
	public ushort DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x301B4C0", Offset = "0x301A0C0", VA = "0x18301B4C0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, ushort ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x301B450", Offset = "0x301A050", VA = "0x18301B450", Slot = "7")]
	public ushort HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public NBHNFAFCAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class LDELNGDEKJL : global::EPIIBJLGPNA<ushort?>, FHLLIKOGGFC, global::ODFGCJPFNPK<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LDELNGDEKJL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3018B10", Offset = "0x3017710", VA = "0x183018B10", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ushort? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3018940", Offset = "0x3017540", VA = "0x183018940", Slot = "5")]
	public ushort? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3018A90", Offset = "0x3017690", VA = "0x183018A90", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, ushort? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x30189F0", Offset = "0x30175F0", VA = "0x1830189F0", Slot = "7")]
	public ushort? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LDELNGDEKJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class FCPIMBBOEKB : global::EPIIBJLGPNA<ushort[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly FCPIMBBOEKB FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F45A40", Offset = "0x2F44640", VA = "0x182F45A40", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ushort[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F45900", Offset = "0x2F44500", VA = "0x182F45900", Slot = "5")]
	public ushort[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public FCPIMBBOEKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class GJAAELKJDDJ : global::EPIIBJLGPNA<uint>, FHLLIKOGGFC, global::ODFGCJPFNPK<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly GJAAELKJDDJ FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C000", Offset = "0x2F4AC00", VA = "0x182F4C000", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, uint ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BE90", Offset = "0x2F4AA90", VA = "0x182F4BE90", Slot = "5")]
	public uint DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BF40", Offset = "0x2F4AB40", VA = "0x182F4BF40", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, uint ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BEA0", Offset = "0x2F4AAA0", VA = "0x182F4BEA0", Slot = "7")]
	public uint HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GJAAELKJDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class AFAFCMHHDCM : global::EPIIBJLGPNA<uint?>, FHLLIKOGGFC, global::ODFGCJPFNPK<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly AFAFCMHHDCM FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A6F0", Offset = "0x2F392F0", VA = "0x182F3A6F0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, uint? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A4A0", Offset = "0x2F390A0", VA = "0x182F3A4A0", Slot = "5")]
	public uint? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A5F0", Offset = "0x2F391F0", VA = "0x182F3A5F0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, uint? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A510", Offset = "0x2F39110", VA = "0x182F3A510", Slot = "7")]
	public uint? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public AFAFCMHHDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class GLPCBNECNNK : global::EPIIBJLGPNA<uint[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GLPCBNECNNK FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C630", Offset = "0x2F4B230", VA = "0x182F4C630", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, uint[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C4F0", Offset = "0x2F4B0F0", VA = "0x182F4C4F0", Slot = "5")]
	public uint[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GLPCBNECNNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class FCOBGGEEHNL : global::EPIIBJLGPNA<ulong>, FHLLIKOGGFC, global::ODFGCJPFNPK<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly FCOBGGEEHNL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2F45870", Offset = "0x2F44470", VA = "0x182F45870", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ulong ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2F45730", Offset = "0x2F44330", VA = "0x182F45730", Slot = "5")]
	public ulong DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2F457B0", Offset = "0x2F443B0", VA = "0x182F457B0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, ulong ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2F45740", Offset = "0x2F44340", VA = "0x182F45740", Slot = "7")]
	public ulong HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public FCOBGGEEHNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class OMHHLHCNGKF : global::EPIIBJLGPNA<ulong?>, FHLLIKOGGFC, global::ODFGCJPFNPK<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly OMHHLHCNGKF FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2740", Offset = "0x4AE1340", VA = "0x184AE2740", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ulong? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2570", Offset = "0x4AE1170", VA = "0x184AE2570", Slot = "5")]
	public ulong? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4AE26C0", Offset = "0x4AE12C0", VA = "0x184AE26C0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, ulong? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2600", Offset = "0x4AE1200", VA = "0x184AE2600", Slot = "7")]
	public ulong? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OMHHLHCNGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EENHANCFHDF : global::EPIIBJLGPNA<ulong[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EENHANCFHDF FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2F44510", Offset = "0x2F43110", VA = "0x182F44510", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ulong[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2F443D0", Offset = "0x2F42FD0", VA = "0x182F443D0", Slot = "5")]
	public ulong[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public EENHANCFHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DJOGAHKFNML : global::EPIIBJLGPNA<float>, FHLLIKOGGFC, global::ODFGCJPFNPK<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly DJOGAHKFNML FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2F42D20", Offset = "0x2F41920", VA = "0x182F42D20", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, float ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2F42BC0", Offset = "0x2F417C0", VA = "0x182F42BC0", Slot = "5")]
	public float DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2F42C70", Offset = "0x2F41870", VA = "0x182F42C70", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, float ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2F42BD0", Offset = "0x2F417D0", VA = "0x182F42BD0", Slot = "7")]
	public float HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public DJOGAHKFNML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class MPOBAMHKBGM : global::EPIIBJLGPNA<float?>, FHLLIKOGGFC, global::ODFGCJPFNPK<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MPOBAMHKBGM FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x301B1E0", Offset = "0x3019DE0", VA = "0x18301B1E0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, float? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x301B050", Offset = "0x3019C50", VA = "0x18301B050", Slot = "5")]
	public float? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x301B160", Offset = "0x3019D60", VA = "0x18301B160", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, float? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x301B0C0", Offset = "0x3019CC0", VA = "0x18301B0C0", Slot = "7")]
	public float? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public MPOBAMHKBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class GAMPBHJNBKD : global::EPIIBJLGPNA<float[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly GAMPBHJNBKD FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2F48AC0", Offset = "0x2F476C0", VA = "0x182F48AC0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, float[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2F48980", Offset = "0x2F47580", VA = "0x182F48980", Slot = "5")]
	public float[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GAMPBHJNBKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GHNPILOINAC : global::EPIIBJLGPNA<double>, FHLLIKOGGFC, global::ODFGCJPFNPK<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GHNPILOINAC FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BE20", Offset = "0x2F4AA20", VA = "0x182F4BE20", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, double ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BCC0", Offset = "0x2F4A8C0", VA = "0x182F4BCC0", Slot = "5")]
	public double DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BD70", Offset = "0x2F4A970", VA = "0x182F4BD70", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, double ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BCD0", Offset = "0x2F4A8D0", VA = "0x182F4BCD0", Slot = "7")]
	public double HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GHNPILOINAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class JOGKHLLNBNM : global::EPIIBJLGPNA<double?>, FHLLIKOGGFC, global::ODFGCJPFNPK<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly JOGKHLLNBNM FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x30171B0", Offset = "0x3015DB0", VA = "0x1830171B0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, double? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3016FE0", Offset = "0x3015BE0", VA = "0x183016FE0", Slot = "5")]
	public double? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3017130", Offset = "0x3015D30", VA = "0x183017130", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, double? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3017070", Offset = "0x3015C70", VA = "0x183017070", Slot = "7")]
	public double? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public JOGKHLLNBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class IBONBBEKILF : global::EPIIBJLGPNA<double[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly IBONBBEKILF FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x300DE50", Offset = "0x300CA50", VA = "0x18300DE50", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, double[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x300DCB0", Offset = "0x300C8B0", VA = "0x18300DCB0", Slot = "5")]
	public double[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public IBONBBEKILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FCEGKALBHIL : global::EPIIBJLGPNA<bool>, FHLLIKOGGFC, global::ODFGCJPFNPK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly FCEGKALBHIL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2F456B0", Offset = "0x2F442B0", VA = "0x182F456B0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, bool ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2F45580", Offset = "0x2F44180", VA = "0x182F45580", Slot = "5")]
	public bool DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2F45600", Offset = "0x2F44200", VA = "0x182F45600", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, bool ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2F45590", Offset = "0x2F44190", VA = "0x182F45590", Slot = "7")]
	public bool HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public FCEGKALBHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class JDDJOGNFLLE : global::EPIIBJLGPNA<bool?>, FHLLIKOGGFC, global::ODFGCJPFNPK<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JDDJOGNFLLE FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x3013620", Offset = "0x3012220", VA = "0x183013620", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, bool? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x3013480", Offset = "0x3012080", VA = "0x183013480", Slot = "5")]
	public bool? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x30135A0", Offset = "0x30121A0", VA = "0x1830135A0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, bool? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x30134F0", Offset = "0x30120F0", VA = "0x1830134F0", Slot = "7")]
	public bool? HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public JDDJOGNFLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class GKEFBMIHHJG : global::EPIIBJLGPNA<bool[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly GKEFBMIHHJG FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C310", Offset = "0x2F4AF10", VA = "0x182F4C310", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, bool[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C1D0", Offset = "0x2F4ADD0", VA = "0x182F4C1D0", Slot = "5")]
	public bool[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GKEFBMIHHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class CNLJFCBJDBE : global::EPIIBJLGPNA<object>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::EPIIBJLGPNA<object> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> PHABLKLFDLH;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2F40810", Offset = "0x2F3F410", VA = "0x182F40810", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, object ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2F40570", Offset = "0x2F3F170", VA = "0x182F40570", Slot = "5")]
	public object DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public CNLJFCBJDBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class GFIAAAHIOCM : global::EPIIBJLGPNA<byte[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::EPIIBJLGPNA<byte[]> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2F4ABE0", Offset = "0x2F497E0", VA = "0x182F4ABE0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, byte[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2F4AB60", Offset = "0x2F49760", VA = "0x182F4AB60", Slot = "5")]
	public byte[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GFIAAAHIOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class MEIJEPGMFHJ : global::EPIIBJLGPNA<ArraySegment<byte>>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::EPIIBJLGPNA<ArraySegment<byte>> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x301A870", Offset = "0x3019470", VA = "0x18301A870", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, ArraySegment<byte> ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x301A7A0", Offset = "0x30193A0", VA = "0x18301A7A0", Slot = "5")]
	public ArraySegment<byte> DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public MEIJEPGMFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MOIDNGMGFHJ : global::EPIIBJLGPNA<string>, FHLLIKOGGFC, global::ODFGCJPFNPK<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::EPIIBJLGPNA<string> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x301AFD0", Offset = "0x3019BD0", VA = "0x18301AFD0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, string ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x301AFC0", Offset = "0x3019BC0", VA = "0x18301AFC0", Slot = "5")]
	public string DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x301AFD0", Offset = "0x3019BD0", VA = "0x18301AFD0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, string ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x301AFC0", Offset = "0x3019BC0", VA = "0x18301AFC0", Slot = "7")]
	public string HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public MOIDNGMGFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class MBELFOBBLOL : global::EPIIBJLGPNA<string[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly MBELFOBBLOL FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x301A620", Offset = "0x3019220", VA = "0x18301A620", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, string[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x301A480", Offset = "0x3019080", VA = "0x18301A480", Slot = "5")]
	public string[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public MBELFOBBLOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class OJEPFHHAHCC : global::EPIIBJLGPNA<char>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly OJEPFHHAHCC FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0650", Offset = "0x4ADF250", VA = "0x184AE0650", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, char ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0620", Offset = "0x4ADF220", VA = "0x184AE0620", Slot = "5")]
	public char DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OJEPFHHAHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class LOCIKCFDHEJ : global::EPIIBJLGPNA<char?>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly LOCIKCFDHEJ FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x3019B60", Offset = "0x3018760", VA = "0x183019B60", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, char? ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x3019AA0", Offset = "0x30186A0", VA = "0x183019AA0", Slot = "5")]
	public char? DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LOCIKCFDHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class FAKALFHPOHN : global::EPIIBJLGPNA<char[]>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly FAKALFHPOHN FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2F452E0", Offset = "0x2F43EE0", VA = "0x182F452E0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, char[] ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2F45140", Offset = "0x2F43D40", VA = "0x182F45140", Slot = "5")]
	public char[] DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public FAKALFHPOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class OAALHNLFMFL : global::EPIIBJLGPNA<Guid>, FHLLIKOGGFC, global::ODFGCJPFNPK<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::EPIIBJLGPNA<Guid> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x301D2A0", Offset = "0x301BEA0", VA = "0x18301D2A0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Guid ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x301D160", Offset = "0x301BD60", VA = "0x18301D160", Slot = "5")]
	public Guid DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x301D1C0", Offset = "0x301BDC0", VA = "0x18301D1C0", Slot = "6")]
	public void MIFKAMHMBOL(ref GONHPJLEIMB EJKJMALPMJH, Guid ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x301D160", Offset = "0x301BD60", VA = "0x18301D160", Slot = "7")]
	public Guid HONLDEKMBBO(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OAALHNLFMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class JDJOJOALPPM : global::EPIIBJLGPNA<decimal>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::EPIIBJLGPNA<decimal> FJPDIHIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool MNAPEPGJNHH;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xA81420", Offset = "0xA80020", VA = "0x180A81420")]
	public JDJOJOALPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xE10D50", Offset = "0xE0F950", VA = "0x180E10D50")]
	public JDJOJOALPPM(bool MNAPEPGJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x30138A0", Offset = "0x30124A0", VA = "0x1830138A0", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, decimal ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x30136F0", Offset = "0x30122F0", VA = "0x1830136F0", Slot = "5")]
	public decimal DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class GADKLIOPIAB : global::EPIIBJLGPNA<Uri>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::EPIIBJLGPNA<Uri> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2F48870", Offset = "0x2F47470", VA = "0x182F48870", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Uri ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2F487F0", Offset = "0x2F473F0", VA = "0x182F487F0", Slot = "5")]
	public Uri DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GADKLIOPIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PPAJCDAHLFA : global::EPIIBJLGPNA<Version>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::EPIIBJLGPNA<Version> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4C80", Offset = "0x4AE3880", VA = "0x184AE4C80", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Version ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x4AE4C00", Offset = "0x4AE3800", VA = "0x184AE4C00", Slot = "5")]
	public Version DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public PPAJCDAHLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class PIGALKFDLBJ<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class NHABHOAAAIB : global::EPIIBJLGPNA<StringBuilder>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::EPIIBJLGPNA<StringBuilder> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x301BC00", Offset = "0x301A800", VA = "0x18301BC00", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, StringBuilder ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x301BB80", Offset = "0x301A780", VA = "0x18301BB80", Slot = "5")]
	public StringBuilder DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public NHABHOAAAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class LLHMHDBNPNA : global::EPIIBJLGPNA<BitArray>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::EPIIBJLGPNA<BitArray> FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x3019830", Offset = "0x3018430", VA = "0x183019830", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, BitArray ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x30196D0", Offset = "0x30182D0", VA = "0x1830196D0", Slot = "5")]
	public BitArray DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public LLHMHDBNPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class IOMCJKKBKCD : global::EPIIBJLGPNA<Type>, FHLLIKOGGFC
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly IOMCJKKBKCD FJPDIHIOMFH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex COJEPHNEBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool AIPPMMGPAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool INAPGLFOAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool FGLEHMHNELP;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x30132D0", Offset = "0x3011ED0", VA = "0x1830132D0")]
	public IOMCJKKBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x30132F0", Offset = "0x3011EF0", VA = "0x1830132F0")]
	public IOMCJKKBKCD(bool AIPPMMGPAAB, bool INAPGLFOAFH, bool FGLEHMHNELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x3013140", Offset = "0x3011D40", VA = "0x183013140", Slot = "4")]
	public void NOHBCKDOEHC(ref GONHPJLEIMB EJKJMALPMJH, Type ODCJDJDBONO, IOIBOLJBEGL BJONBLFOGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x3013020", Offset = "0x3011C20", VA = "0x183013020", Slot = "5")]
	public Type DEFMGIMGNBI(ref IJNHJAICOBP HGAMEAMKNKI, IOIBOLJBEGL BJONBLFOGCH)
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
