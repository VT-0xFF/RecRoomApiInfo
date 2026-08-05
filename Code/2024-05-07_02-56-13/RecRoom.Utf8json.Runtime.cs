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

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class JKDFFIOLPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B09620", Offset = "0x6B08820", VA = "0x186B09620")]
	public static bool DPJDDBNKHHP(this TypeInfo FLPJMDMACMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class MNEOMHHNJAB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type INLGCHOEGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] IOEHEPNHDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
	public MNEOMHHNJAB(Type EEBMDEKNDFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class FDPKGNBCGBF : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void INOJACEJDDN<T>(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T PLLNKLKJLNI<T>(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH BPDAEDIJBFN);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BPIGAGDGECE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IFDPBPAOPOC<T> : BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OHENOILEMIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IGNCDIEHDLP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GPMGJMELGAE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28F82D0", Offset = "0x28F74D0", VA = "0x1828F82D0")]
	public static string FNFIEBBOMAL<T>(this IFDPBPAOPOC<T> HONMGKIILJF, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFDPBPAOPOC<T> AJBHOHKMLBJ<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HJEJILKAOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2909950", Offset = "0x2908B50", VA = "0x182909950")]
	public static IFDPBPAOPOC<T> IJOOAGKBACE<T>(this KDHJEPEDNOH BPDAEDIJBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B08890", Offset = "0x6B07A90", VA = "0x186B08890")]
	public static object LJABDIGFDDN(this KDHJEPEDNOH BPDAEDIJBFN, Type FLPJMDMACMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CMFOFLBCCON : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B07E00", Offset = "0x6B07000", VA = "0x186B07E00")]
	public CMFOFLBCCON(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NABNPJBAMMM
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class PINPHOGBCPG
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BCDEBAAMJOP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] LEODMALJHNA;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B179B0", Offset = "0x6B16BB0", VA = "0x186B179B0")]
		public static byte[] POIFEOCODFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B17910", Offset = "0x6B16B10", VA = "0x186B17910")]
		public static char[] GKBOFHOIAAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KEDOBKFINPH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] NCGLOCIGDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CGAHJPHALBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BJPGLMJPACN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HPJJPELJIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B12760", Offset = "0x6B11960", VA = "0x186B12760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B13BD0", Offset = "0x6B12DD0", VA = "0x186B13BD0")]
	public NABNPJBAMMM(byte[] CGAHJPHALBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B13C30", Offset = "0x6B12E30", VA = "0x186B13C30")]
	public NABNPJBAMMM(byte[] CGAHJPHALBC, int BJPGLMJPACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B13260", Offset = "0x6B12460", VA = "0x186B13260")]
	private CCNJFDGBCAF OFGPINBFLDL(string AHDCPLGCKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B12B60", Offset = "0x6B11D60", VA = "0x186B12B60")]
	private CCNJFDGBCAF LPGKOBLJKHL(string JGNAJPMGGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B09F50", Offset = "0x6B09150", VA = "0x186B09F50")]
	public void EKMKLFCOKAF(int BJPGLMJPACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public byte[] GDNJJIJJNLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
	public int FECCLAMCBHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B12D20", Offset = "0x6B11F20", VA = "0x186B12D20")]
	public PLIBLOECENO MGAGPECBHMI()
	{
		return default(PLIBLOECENO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B11E80", Offset = "0x6B11080", VA = "0x186B11E80")]
	public void EIFNNKODNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B12780", Offset = "0x6B11980", VA = "0x186B12780")]
	public bool JPNCLBDPPAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B11C80", Offset = "0x6B10E80", VA = "0x186B11C80")]
	public bool EAOJODLFHPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B10A60", Offset = "0x6B0FC60", VA = "0x186B10A60")]
	public void ALOIJAEJEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B11DF0", Offset = "0x6B10FF0", VA = "0x186B11DF0")]
	public bool EHMKGFOKHPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B12ED0", Offset = "0x6B120D0", VA = "0x186B12ED0")]
	public bool MGANEIFDOFE(int KIGJDGACGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B12550", Offset = "0x6B11750", VA = "0x186B12550")]
	public bool HOEILALAGIP(int KIGJDGACGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B12380", Offset = "0x6B11580", VA = "0x186B12380")]
	public bool FKOCBKBJJOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B139A0", Offset = "0x6B12BA0", VA = "0x186B139A0")]
	public void PNGGANIKMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B137B0", Offset = "0x6B129B0", VA = "0x186B137B0")]
	public bool OLADECPAFAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B12C50", Offset = "0x6B11E50", VA = "0x186B12C50")]
	public bool MEBEADIJDNO(int KIGJDGACGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B10990", Offset = "0x6B0FB90", VA = "0x186B10990")]
	public bool AGAIALALFEG(int KIGJDGACGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B115F0", Offset = "0x6B107F0", VA = "0x186B115F0")]
	public bool CBFIEIIJKHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B10B00", Offset = "0x6B0FD00", VA = "0x186B10B00")]
	public void ANHLPMDGCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B11A60", Offset = "0x6B10C60", VA = "0x186B11A60")]
	public bool CIMPLNJFKDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B131C0", Offset = "0x6B123C0", VA = "0x186B131C0")]
	public void NLLDBFPHFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B10BA0", Offset = "0x6B0FDA0", VA = "0x186B10BA0")]
	private void BBBNKHKLDJF([Out] byte[] JJCODLCMKDC, [Out] int NHPOBIHAMPN, [Out] int FPIJCJGNPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B11AF0", Offset = "0x6B10CF0", VA = "0x186B11AF0")]
	private static int DJPFACJJLFB(char JPEEHDCLFEK, char HGMCBKHHGFH, char MOAAELBABJA, char IDBHAEBCELK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B11BA0", Offset = "0x6B10DA0", VA = "0x186B11BA0")]
	private static int DNMANPCOFAI(char KPEEHKEJDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B130A0", Offset = "0x6B122A0", VA = "0x186B130A0")]
	public ArraySegment<byte> NFOBBADHCJI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B11D10", Offset = "0x6B10F10", VA = "0x186B11D10")]
	public string EGBDMOCGMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B10920", Offset = "0x6B0FB20", VA = "0x186B10920")]
	public string ADHKOBNPDPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B11680", Offset = "0x6B10880", VA = "0x186B11680")]
	public ArraySegment<byte> CBHEHODPNDO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B128A0", Offset = "0x6B11AA0", VA = "0x186B128A0")]
	public ArraySegment<byte> KPOEFEMGNLC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B12130", Offset = "0x6B11330", VA = "0x186B12130")]
	public bool FKCPLFLAFGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B118A0", Offset = "0x6B10AA0", VA = "0x186B118A0")]
	private static bool CEFKPLGOLDO(byte MOAAELBABJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B12910", Offset = "0x6B11B10", VA = "0x186B12910")]
	private void LKKDFPCCKOA(PLIBLOECENO FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B115A0", Offset = "0x6B107A0", VA = "0x186B115A0")]
	public void BNELDDEHPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B13840", Offset = "0x6B12A40", VA = "0x186B13840")]
	private void ONPOAPPABHA(int IGMHMMDBDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B13A40", Offset = "0x6B12C40", VA = "0x186B13A40")]
	public sbyte PPKJGLDLLHI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B11520", Offset = "0x6B10720", VA = "0x186B11520")]
	public short BLMBOGBOOAE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B124D0", Offset = "0x6B116D0", VA = "0x186B124D0")]
	public int HJNJNCBEIAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B126A0", Offset = "0x6B118A0", VA = "0x186B126A0")]
	public long JJOHJLILCMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B12620", Offset = "0x6B11820", VA = "0x186B12620")]
	public byte ICCFAJCCIEF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B11330", Offset = "0x6B10530", VA = "0x186B11330")]
	public ushort BEOPENAOHNM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B11FB0", Offset = "0x6B111B0", VA = "0x186B11FB0")]
	public uint FDABNBMDDLH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B12410", Offset = "0x6B11610", VA = "0x186B12410")]
	public ulong GOHHLDDBBOO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B12FA0", Offset = "0x6B121A0", VA = "0x186B12FA0")]
	public float NENCCFNEKEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B11960", Offset = "0x6B10B60", VA = "0x186B11960")]
	public double CHGAIGGEEPN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B12030", Offset = "0x6B11230", VA = "0x186B12030")]
	public ArraySegment<byte> FJFPOELKOBD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B113B0", Offset = "0x6B105B0", VA = "0x186B113B0")]
	private static int BGLMLOMFJFC(byte[] CGAHJPHALBC, int BJPGLMJPACN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CCNJFDGBCAF : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference KFOPAOHDBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int NJAJNECCAJF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OIGLMMJODMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC767A0", VA = "0x180C775A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NHIMMKHFGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87BCE0", Offset = "0x87AEE0", VA = "0x18087BCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B07CB0", Offset = "0x6B06EB0", VA = "0x186B07CB0")]
	public CCNJFDGBCAF(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B07D10", Offset = "0x6B06F10", VA = "0x186B07D10")]
	public CCNJFDGBCAF(string JGNAJPMGGNE, byte[] IMABEEEBIIF, int BJPGLMJPACN, int NJAJNECCAJF, string AFMNFCBHAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJFPANAIHEC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class ADDECHBODJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BCDEBAAMJOP;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD0A0", Offset = "0x6AFC2A0", VA = "0x186AFD0A0")]
		public static byte[] POIFEOCODFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class FBOMPEDHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void HBAHCPMCKBI(JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object AFENKFINGLA(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH BPDAEDIJBFN);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class AEGGPLOOKPK
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class JBFADPLBCGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
				public JBFADPLBCGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3A3F6F0", Offset = "0x3A3E8F0", VA = "0x183A3F6F0")]
				internal bool DPJHKPHOPPM(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6B09190", Offset = "0x6B08390", VA = "0x186B09190")]
				internal bool BFHLHFOMLBF(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, KDHJEPEDNOH, byte[]> BPJOHMJGIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, KDHJEPEDNOH> JHLHCJGKAMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly HBAHCPMCKBI CHCHACLFCCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, KDHJEPEDNOH, ArraySegment<byte>> HCIJNFPCFJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, KDHJEPEDNOH, string> BBBPLOJJHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, KDHJEPEDNOH, object> PHECELHKKGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, KDHJEPEDNOH, object> JFFNOPDOHIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, KDHJEPEDNOH, object> DMAFNLNMADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly AFENKFINGLA HPKILLBOEAM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD390", Offset = "0x6AFC590", VA = "0x186AFD390")]
			public AEGGPLOOKPK(Type FLPJMDMACMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2ED9EC0", Offset = "0x2ED90C0", VA = "0x182ED9EC0")]
			private static T POOALDIIFGD<T>(DynamicMethod DKKNCJLFDMA)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD140", Offset = "0x6AFC340", VA = "0x186AFD140")]
			private static MethodInfo IHBEGHPKPHK(Type FLPJMDMACMC, string IKEFBMMMAJB, Type[] NLKIGFDMHGH)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, AEGGPLOOKPK> MLHOJDNBOIH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IAFLOKKLFCN<AEGGPLOOKPK> FHAJLPMDAAL;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B08160", Offset = "0x6B07360", VA = "0x186B08160")]
		static FBOMPEDHCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B080E0", Offset = "0x6B072E0", VA = "0x186B080E0")]
		private static AEGGPLOOKPK PGLPCKLKBJO(Type FLPJMDMACMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B07E60", Offset = "0x6B07060", VA = "0x186B07E60")]
		public static void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B07FE0", Offset = "0x6B071E0", VA = "0x186B07FE0")]
		public static void OHDBDPJBHPM(Type FLPJMDMACMC, JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KDHJEPEDNOH GBOOAGLGHBL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BFLKDGGFCCD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] LALHAFPGOCM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KDHJEPEDNOH OCFKBKMKBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0BFD0", Offset = "0x6B0B1D0", VA = "0x186B0BFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FLFFMMHGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B1F0", Offset = "0x6B0A3F0", VA = "0x186B0B1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B240", Offset = "0x6B0A440", VA = "0x186B0B240")]
	public static void IKNGIAFCADP(KDHJEPEDNOH BPDAEDIJBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x297A510", Offset = "0x2979710", VA = "0x18297A510")]
	public static byte[] OHDBDPJBHPM<T>(T JFJMICPDNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x297A580", Offset = "0x2979780", VA = "0x18297A580")]
	public static byte[] OHDBDPJBHPM<T>(T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x297AB10", Offset = "0x2979D10", VA = "0x18297AB10")]
	public static void OHDBDPJBHPM<T>(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x297AA30", Offset = "0x2979C30", VA = "0x18297AA30")]
	public static void OHDBDPJBHPM<T>(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x297A9B0", Offset = "0x2979BB0", VA = "0x18297A9B0")]
	public static void OHDBDPJBHPM<T>(Stream KIIMFPPABLA, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x297A6F0", Offset = "0x29798F0", VA = "0x18297A6F0")]
	public static void OHDBDPJBHPM<T>(Stream KIIMFPPABLA, T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2978EB0", Offset = "0x29780B0", VA = "0x182978EB0")]
	public static ArraySegment<byte> JHJKFGDGPBO<T>(T JFJMICPDNDH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2978F40", Offset = "0x2978140", VA = "0x182978F40")]
	public static ArraySegment<byte> JHJKFGDGPBO<T>(T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2978CC0", Offset = "0x2977EC0", VA = "0x182978CC0")]
	public static string FNFIEBBOMAL<T>(T NICEPFIEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2978D30", Offset = "0x2977F30", VA = "0x182978D30")]
	public static string FNFIEBBOMAL<T>(T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2979D70", Offset = "0x2978F70", VA = "0x182979D70")]
	public static T LKMADFBDLGL<T>(string FOOMKMLAHDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2979A60", Offset = "0x2978C60", VA = "0x182979A60")]
	public static T LKMADFBDLGL<T>(string FOOMKMLAHDI, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2979E00", Offset = "0x2979000", VA = "0x182979E00")]
	public static T LKMADFBDLGL<T>(byte[] CGAHJPHALBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2979B50", Offset = "0x2978D50", VA = "0x182979B50")]
	public static T LKMADFBDLGL<T>(byte[] CGAHJPHALBC, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x297A090", Offset = "0x2979290", VA = "0x18297A090")]
	public static T LKMADFBDLGL<T>(byte[] CGAHJPHALBC, int BJPGLMJPACN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2979BE0", Offset = "0x2978DE0", VA = "0x182979BE0")]
	public static T LKMADFBDLGL<T>(byte[] CGAHJPHALBC, int BJPGLMJPACN, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x297A020", Offset = "0x2979220", VA = "0x18297A020")]
	public static T LKMADFBDLGL<T>(NABNPJBAMMM CAMFAGAEHOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x297A440", Offset = "0x2979640", VA = "0x18297A440")]
	public static T LKMADFBDLGL<T>(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2979FB0", Offset = "0x29791B0", VA = "0x182979FB0")]
	public static T LKMADFBDLGL<T>(Stream KIIMFPPABLA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x297A300", Offset = "0x2979500", VA = "0x18297A300")]
	public static T LKMADFBDLGL<T>(Stream KIIMFPPABLA, KDHJEPEDNOH BPDAEDIJBFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AF00", Offset = "0x6B0A100", VA = "0x186B0AF00")]
	public static string CALAMKHKLJD(byte[] FOOMKMLAHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ADC0", Offset = "0x6B09FC0", VA = "0x186B0ADC0")]
	public static string CALAMKHKLJD(byte[] FOOMKMLAHDI, int BJPGLMJPACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B060", Offset = "0x6B0A260", VA = "0x186B0B060")]
	public static string CALAMKHKLJD(string FOOMKMLAHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BE60", Offset = "0x6B0B060", VA = "0x186B0BE60")]
	public static byte[] MIGKLCJDIDF(byte[] FOOMKMLAHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BB60", Offset = "0x6B0AD60", VA = "0x186B0BB60")]
	public static byte[] MIGKLCJDIDF(byte[] FOOMKMLAHDI, int BJPGLMJPACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BCB0", Offset = "0x6B0AEB0", VA = "0x186B0BCB0")]
	public static byte[] MIGKLCJDIDF(string FOOMKMLAHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B2B0", Offset = "0x6B0A4B0", VA = "0x186B0B2B0")]
	private static void KAKLAKKEPFL(NABNPJBAMMM CAMFAGAEHOD, JNDOKAMOCLB KPDGEKKKOHO, int JOJPILNPIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AD20", Offset = "0x6B09F20", VA = "0x186B0AD20")]
	private static int AKKLIJOIEAC(Stream CCAOJBHBKKC, byte[] BCDEBAAMJOP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PLIBLOECENO : byte
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
public struct JNDOKAMOCLB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] LOBFKHFFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BCDEBAAMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BJPGLMJPACN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OMKKEJIGCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B09F50", Offset = "0x6B09150", VA = "0x186B09F50")]
	public void EKMKLFCOKAF(int BJPGLMJPACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B09760", Offset = "0x6B08960", VA = "0x186B09760")]
	public static byte[] AMEJMHPBKIM(string COCPAGHPOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B09C70", Offset = "0x6B08E70", VA = "0x186B09C70")]
	public static byte[] DODPBJDBNEN(string COCPAGHPOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B09DE0", Offset = "0x6B08FE0", VA = "0x186B09DE0")]
	public static byte[] EGGJANDAMOH(string COCPAGHPOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B09890", Offset = "0x6B08A90", VA = "0x186B09890")]
	public static byte[] AMIMMBICKPN(string COCPAGHPOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56B3D80", Offset = "0x56B2F80", VA = "0x1856B3D80")]
	public JNDOKAMOCLB(byte[] GELOAFONJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AA40", Offset = "0x6B09C40", VA = "0x186B0AA40")]
	public ArraySegment<byte> POIFEOCODFI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B09B10", Offset = "0x6B08D10", VA = "0x186B09B10")]
	public byte[] BLIJDCLNFML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AAE0", Offset = "0x6B09CE0", VA = "0x186B0AAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B09F60", Offset = "0x6B09160", VA = "0x186B09F60")]
	public void EPBJJNCPEEH(int PCJBGNKGAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A980", Offset = "0x6B09B80", VA = "0x186B0A980")]
	public void PEMEAAFMLNB(byte DJGMFOFOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A9E0", Offset = "0x6B09BE0", VA = "0x186B0A9E0")]
	public void PEMEAAFMLNB(byte[] DJGMFOFOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A660", Offset = "0x6B09860", VA = "0x186B0A660")]
	public void JCAPFHKALAK(byte DJGMFOFOCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B09B80", Offset = "0x6B08D80", VA = "0x186B09B80")]
	public void BMDNMIGAFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A1E0", Offset = "0x6B093E0", VA = "0x186B0A1E0")]
	public void HGCOGNJDKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B09AC0", Offset = "0x6B08CC0", VA = "0x186B09AC0")]
	public void BAPLKBEPPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A030", Offset = "0x6B09230", VA = "0x186B0A030")]
	public void GFPDIGHNCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B09F70", Offset = "0x6B09170", VA = "0x186B09F70")]
	public void FMNKKNOJNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B096C0", Offset = "0x6B088C0", VA = "0x186B096C0")]
	public void AEGCPGKIEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A230", Offset = "0x6B09430", VA = "0x186B0A230")]
	public void HJDLPCPCIKC(string COCPAGHPOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B09710", Offset = "0x6B08910", VA = "0x186B09710")]
	public void AKNAOFIIAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B09BD0", Offset = "0x6B08DD0", VA = "0x186B09BD0")]
	public void DEPIGFAEMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A080", Offset = "0x6B09280", VA = "0x186B0A080")]
	public void GGOFELMKBIF(bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A860", Offset = "0x6B09A60", VA = "0x186B0A860")]
	public void LLCOBEKOOFD(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B09A40", Offset = "0x6B08C40", VA = "0x186B09A40")]
	public void AOKAAIEOIMO(double NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B09FC0", Offset = "0x6B091C0", VA = "0x186B09FC0")]
	public void FOIJKDJMMFL(byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A910", Offset = "0x6B09B10", VA = "0x186B0A910")]
	public void NBLGGOABCFP(ushort NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A6A0", Offset = "0x6B098A0", VA = "0x186B0A6A0")]
	public void JIIGHKNKBDB(uint NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B09A10", Offset = "0x6B08C10", VA = "0x186B09A10")]
	public void AMKJAKBGILP(ulong NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A780", Offset = "0x6B09980", VA = "0x186B0A780")]
	public void KHKJDMGKJBB(sbyte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A7F0", Offset = "0x6B099F0", VA = "0x186B0A7F0")]
	public void LCLPACHFKEG(short NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A710", Offset = "0x6B09910", VA = "0x186B0A710")]
	public void JKFEAKHFLME(int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A8E0", Offset = "0x6B09AE0", VA = "0x186B0A8E0")]
	public void MNECDHHCACK(long NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A2D0", Offset = "0x6B094D0", VA = "0x186B0A2D0")]
	public void IHMOKBBNCHB(string NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class GIBEIOAFCPJ : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class EOIABDDECEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x349FDE0", Offset = "0x349EFE0", VA = "0x18349FDE0")]
		static EOIABDDECEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private GIBEIOAFCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FMPDOGAGBDJ : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class FIGLFHMDBKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38026F0", Offset = "0x38018F0", VA = "0x1838026F0")]
		static FIGLFHMDBKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class LBCHEOCGIIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> DNOHLNDHMBG;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C400", Offset = "0x6B0B600", VA = "0x186B0C400")]
		internal static object AJBHOHKMLBJ(Type MOAGOANMCEN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private FMPDOGAGBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BEFBPNOJKOK : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class DKECLLHCLMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5121F00", Offset = "0x5121100", VA = "0x185121F00")]
		static DKECLLHCLMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly BEFBPNOJKOK KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool FKCOGHINNJC;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static BPIGAGDGECE[] ECBAOLKPFCK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static KDHJEPEDNOH[] AIJILADDNFO;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private BEFBPNOJKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF590", Offset = "0x6AFE790", VA = "0x186AFF590")]
	public static void FPMBLPAHIMD(params KDHJEPEDNOH[] AIJILADDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF670", Offset = "0x6AFE870", VA = "0x186AFF670")]
	public static void FPMBLPAHIMD(params BPIGAGDGECE[] ECBAOLKPFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF320", Offset = "0x6AFE520", VA = "0x186AFF320")]
	public static void EAGJCONFOHD(BPIGAGDGECE[] ECBAOLKPFCK, KDHJEPEDNOH[] AIJILADDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JCBNAFAMHIH : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class LJKNMDDOMPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D75B00", Offset = "0x3D74D00", VA = "0x183D75B00")]
		static LJKNMDDOMPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private JCBNAFAMHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class IPAOJEJNHND
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly KDHJEPEDNOH CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly KDHJEPEDNOH HCDBMNNNDAL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KDHJEPEDNOH LEGKKMMIMLH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly KDHJEPEDNOH EHPDLFKIFCI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly KDHJEPEDNOH CDOFCFCMAPH;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KDHJEPEDNOH ABJKECEKEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly KDHJEPEDNOH ACLIPOFIEIL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KDHJEPEDNOH OEHLFBLNCJB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KDHJEPEDNOH CPCCHLLLGBM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KDHJEPEDNOH NDMIMOEBDJC;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KDHJEPEDNOH HBDFCILOKAL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly KDHJEPEDNOH CNDJJOHNMJB;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BFGGNDCBHOI
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly KDHJEPEDNOH CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly KDHJEPEDNOH OGBAEJLJFDI;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FNEHMCIAJNK
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly KDHJEPEDNOH CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KDHJEPEDNOH HCDBMNNNDAL;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly KDHJEPEDNOH LEGKKMMIMLH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly KDHJEPEDNOH EHPDLFKIFCI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly KDHJEPEDNOH CDOFCFCMAPH;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly KDHJEPEDNOH ABJKECEKEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KDHJEPEDNOH ACLIPOFIEIL;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly KDHJEPEDNOH OEHLFBLNCJB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly KDHJEPEDNOH CPCCHLLLGBM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly KDHJEPEDNOH NDMIMOEBDJC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly KDHJEPEDNOH HBDFCILOKAL;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly KDHJEPEDNOH CNDJJOHNMJB;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class PDABLEAIIJM
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> DNOHLNDHMBG;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B14F00", Offset = "0x6B14100", VA = "0x186B14F00")]
	internal static object AJBHOHKMLBJ(Type MOAGOANMCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6B16610", Offset = "0x6B15810", VA = "0x186B16610")]
	private static object BPIELJBNJDP(Type NDAFBAJBDNJ, Type[] IMBBDJHEDPH, params object[] NLKIGFDMHGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class AOJGOLEIHDP : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class NADEFIPIDAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2A60", Offset = "0x3FE1C60", VA = "0x183FE2A60")]
		static NADEFIPIDAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF1A0", Offset = "0x6AFE3A0", VA = "0x186AFF1A0")]
	static AOJGOLEIHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private AOJGOLEIHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class AMPLNIPEDCM : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class FMGPKLADCDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3813020", Offset = "0x3812220", VA = "0x183813020")]
		static FMGPKLADCDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF050", Offset = "0x6AFE250", VA = "0x186AFF050")]
	static AMPLNIPEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private AMPLNIPEDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BNJAGOCHBOC : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class NEAOAACAPAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4006080", Offset = "0x4005280", VA = "0x184006080")]
		static NEAOAACAPAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B07B60", Offset = "0x6B06D60", VA = "0x186B07B60")]
	static BNJAGOCHBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private BNJAGOCHBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class LLIEFMLHFEG : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class JJFAHNPLMIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D910", Offset = "0x3C1CB10", VA = "0x183C1D910")]
		static JJFAHNPLMIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B10100", Offset = "0x6B0F300", VA = "0x186B10100")]
	static LLIEFMLHFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private LLIEFMLHFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MJIMLIMKBHH : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class JLJDPEFMHFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2CD00", Offset = "0x3C2BF00", VA = "0x183C2CD00")]
		static JLJDPEFMHFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B107D0", Offset = "0x6B0F9D0", VA = "0x186B107D0")]
	static MJIMLIMKBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private MJIMLIMKBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class NFBNDIDEGNK : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class PADLLOCDIGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x424E4B0", Offset = "0x424D6B0", VA = "0x18424E4B0")]
		static PADLLOCDIGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly EGJCFOMKMGN IJEEDLMKMGM;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B13D80", Offset = "0x6B12F80", VA = "0x186B13D80")]
	static NFBNDIDEGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private NFBNDIDEGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AIOEHFIMLFL : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GCHBKCBKJJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38A3DB0", Offset = "0x38A2FB0", VA = "0x1838A3DB0")]
		static GCHBKCBKJJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public AIOEHFIMLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class ONFBLCPCECD : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class JAKMFCPKMFH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7550", Offset = "0x3BE6750", VA = "0x183BE7550")]
		static JAKMFCPKMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public ONFBLCPCECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IHAGKKCHFHE : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class OJIFANFNKFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x41AD680", Offset = "0x41AC880", VA = "0x1841AD680")]
		static OJIFANFNKFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public IHAGKKCHFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class LODFLAINLHK : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class MMONDJOIFMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F99FE0", Offset = "0x3F991E0", VA = "0x183F99FE0")]
		static MMONDJOIFMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LODFLAINLHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class AKAKIAENOON : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class MPMJKLFIECD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB8F0", Offset = "0x3FAAAF0", VA = "0x183FAB8F0")]
		static MPMJKLFIECD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public AKAKIAENOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class GKEIMLMFGJP : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class NOGBLDNIBAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4082E50", Offset = "0x4082050", VA = "0x184082E50")]
		static NOGBLDNIBAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> OKPMOKDNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool MNEAHEPOODB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GKEIMLMFGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class BHIGIKFCJEH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct BNCCEPJPLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HLIJMIDBICH BCGHNJEBPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder NCADJCNOPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder PCOMFNEFOMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class LHGBFNOGPJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class PIBHMBMPECL
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo EGGJANDAMOH;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo DODPBJDBNEN;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo AMIMMBICKPN;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo AMEJMHPBKIM;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo DEPIGFAEMMN;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo PEMEAAFMLNB;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo BAPLKBEPPJH;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo GFPDIGHNCCC;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo FMNKKNOJNFH;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6B16B90", Offset = "0x6B15D90", VA = "0x186B16B90")]
			static PIBHMBMPECL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class NJNNEHHKFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo JPNCLBDPPAN;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo PNGGANIKMPB;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo MEBEADIJDNO;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo DEBPHPIMHJH;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo BNELDDEHPAO;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo GDNJJIJJNLA;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo FECCLAMCBHM;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6B13ED0", Offset = "0x6B130D0", VA = "0x186B13ED0")]
			static NJNNEHHKFEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class OFHBKEPIFNL
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo INLGCHOEGFM;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo IOEHEPNHDFP;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo ICNANKFLNHE;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo IJOOAGKBACE;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo EHNDKEJJOHB;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo JIKKEKBFFFE;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo GGNOEBFINCC;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo GFFPIILMFEE;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo FDDIAAMKLND;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo DADMGEKKPIP;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo EGCBDLEBHDJ;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo PADHBOFKNMJ;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo NMOBBANDKKN;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo DNHBIIMIHCO;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E8D0", Offset = "0x6B0DAD0", VA = "0x186B0E8D0")]
		public static MethodInfo OHDBDPJBHPM(Type FLPJMDMACMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E690", Offset = "0x6B0D890", VA = "0x186B0E690")]
		public static MethodInfo LKMADFBDLGL(Type FLPJMDMACMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E560", Offset = "0x6B0D760", VA = "0x186B0E560")]
		public static MethodInfo HAIOMLPPOMJ(Type FLPJMDMACMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EHPAMAMMAEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<HLIJMIDBICH, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public EHPAMAMMAEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class JIPLPDCOEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public EHPAMAMMAEA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JIPLPDCOEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B095E0", Offset = "0x6B087E0", VA = "0x186B095E0")]
		internal void MCCMPONLCJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6B09540", Offset = "0x6B08740", VA = "0x186B09540")]
		internal bool KJNMNDFKPCE(int index, HLIJMIDBICH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class INJIMJGCLIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public EHPAMAMMAEA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public INJIMJGCLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6B08CD0", Offset = "0x6B07ED0", VA = "0x186B08CD0")]
		internal bool LCOIJMDDEOE(int index, HLIJMIDBICH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class FHHEKCDIHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FHHEKCDIHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3A31750", Offset = "0x3A30950", VA = "0x183A31750")]
		internal string PCPNFBDNCEM(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class KABEJPIMIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KABEJPIMIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0ACC0", Offset = "0x6B09EC0", VA = "0x186B0ACC0")]
		internal bool LHDBKFOAALB(HLIJMIDBICH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HNENAJNJMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FHHEKCDIHCG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HNENAJNJMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B08B60", Offset = "0x6B07D60", VA = "0x186B08B60")]
		internal void MLKCBHBJIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B089E0", Offset = "0x6B07BE0", VA = "0x186B089E0")]
		internal bool ICDGBLEFGGM(int index, HLIJMIDBICH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JEHDCKLBIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public FHHEKCDIHCG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JEHDCKLBIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B093C0", Offset = "0x6B085C0", VA = "0x186B093C0")]
		internal bool GMNJMDDDADF(int index, HLIJMIDBICH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BDDLHCMODIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BDDLHCMODIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF2F0", Offset = "0x6AFE4F0", VA = "0x186AFF2F0")]
		internal Label JJHADDHOGNG(HLIJMIDBICH _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JNPINKLLELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public BNCCEPJPLBC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, HLIJMIDBICH, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public LMOHOEJPFDC argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public LMOHOEJPFDC argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JNPINKLLELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B0ABA0", Offset = "0x6B09DA0", VA = "0x186B0ABA0")]
		internal BNCCEPJPLBC CHPAFMIBABO(HLIJMIDBICH item)
		{
			return default(BNCCEPJPLBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MBFKICOFDNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public JNPINKLLELB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public MBFKICOFDNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B103D0", Offset = "0x6B0F5D0", VA = "0x186B103D0")]
		internal void EPOGFALMAAJ(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B10340", Offset = "0x6B0F540", VA = "0x186B10340")]
		internal void EAJLOAPNEAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AMEKBEHCOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HLIJMIDBICH item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AMEKBEHCOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xBC0960", Offset = "0xBBFB60", VA = "0x180BC0960")]
		internal bool PHJPGHKOBPE(BNCCEPJPLBC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class PPAJKCNCGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public HLIJMIDBICH item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PPAJKCNCGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBC0960", Offset = "0xBBFB60", VA = "0x180BC0960")]
		internal bool FADJOMLLHDO(BNCCEPJPLBC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex OHPEKOPJNHP;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int BJLFGCMCEKB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> MNFNNKNIFJI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> JFBBCLAFDCD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x26B40B0", Offset = "0x26B32B0", VA = "0x1826B40B0")]
	public static object IDFPBBFLJOP<T>(EGJCFOMKMGN IJEEDLMKMGM, KDHJEPEDNOH INNCPGLFJJB, Func<string, string> OKPMOKDNBDC, bool MNEAHEPOODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26AC1F0", Offset = "0x26AB3F0", VA = "0x1826AC1F0")]
	public static object ELKDBHCJOAC<T>(KDHJEPEDNOH INNCPGLFJJB, Func<string, string> OKPMOKDNBDC, bool MNEAHEPOODB, bool MCGFLJPKJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B05870", Offset = "0x6B04A70", VA = "0x186B05870")]
	private static TypeInfo PCGFNBBKIPB(EGJCFOMKMGN IJEEDLMKMGM, Type FLPJMDMACMC, Func<string, string> OKPMOKDNBDC, bool MNEAHEPOODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B03920", Offset = "0x6B02B20", VA = "0x186B03920")]
	public static object NKCOKEKCOEH(Type FLPJMDMACMC, Func<string, string> OKPMOKDNBDC, bool MNEAHEPOODB, bool MCGFLJPKJBI, bool LOBGKNGPDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B03230", Offset = "0x6B02430", VA = "0x186B03230")]
	private static Dictionary<HLIJMIDBICH, FieldInfo> KJMBOAJMOCG(TypeBuilder CLOIIAMHGDP, MAMMFPLPJFK FNIBPAONDEO, ConstructorInfo LJEALFGEAGN, FieldBuilder DHKACHBOJLC, ILGenerator OPIHFNDEDPG, bool MNEAHEPOODB, bool ADJKAJCICPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B01420", Offset = "0x6B00620", VA = "0x186B01420")]
	private static Dictionary<HLIJMIDBICH, FieldInfo> GIIIDOHLACN(TypeBuilder CLOIIAMHGDP, MAMMFPLPJFK FNIBPAONDEO, ILGenerator OPIHFNDEDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B01AD0", Offset = "0x6B00CD0", VA = "0x186B01AD0")]
	private static void HKEAGHHOLDK(Type FLPJMDMACMC, MAMMFPLPJFK FNIBPAONDEO, ILGenerator OPIHFNDEDPG, Action IPAIFPKGDIC, Func<int, HLIJMIDBICH, bool> DOIPFODPOCA, bool MNEAHEPOODB, bool ADJKAJCICPP, int LFLEAPNCOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B06FD0", Offset = "0x6B061D0", VA = "0x186B06FD0")]
	private static void PIFNOCILCCI(TypeInfo FLPJMDMACMC, HLIJMIDBICH GHDGDEPKAAM, ILGenerator OPIHFNDEDPG, int HMFNCGHECPG, Func<int, HLIJMIDBICH, bool> DOIPFODPOCA, LMOHOEJPFDC KPDGEKKKOHO, LMOHOEJPFDC LLCOCEABGAL, LMOHOEJPFDC GEBMBIGPPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFFE0", Offset = "0x6AFF1E0", VA = "0x186AFFFE0")]
	private static void BNOPFFKLCIO(Type FLPJMDMACMC, MAMMFPLPJFK FNIBPAONDEO, ILGenerator OPIHFNDEDPG, Func<int, HLIJMIDBICH, bool> DOIPFODPOCA, bool ICCLAIMLAEP, int LFLEAPNCOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B05420", Offset = "0x6B04620", VA = "0x186B05420")]
	private static void NMDOCNEKPEF(ILGenerator OPIHFNDEDPG, BNCCEPJPLBC FNIBPAONDEO, int HMFNCGHECPG, Func<int, HLIJMIDBICH, bool> DOIPFODPOCA, LMOHOEJPFDC CAMFAGAEHOD, LMOHOEJPFDC GEBMBIGPPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B06280", Offset = "0x6B05480", VA = "0x186B06280")]
	private static LocalBuilder PEBGNIIBBOL(ILGenerator OPIHFNDEDPG, Type FLPJMDMACMC, MAMMFPLPJFK FNIBPAONDEO, BNCCEPJPLBC[] KBMFDIOEOII, bool NHPDCLDCIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF920", Offset = "0x6AFEB20", VA = "0x186AFF920")]
	private static bool BKFELFLGJJG(ConstructorInfo EKGFLDGNNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6B030B0", Offset = "0x6B022B0", VA = "0x186B030B0")]
	private static bool JGHPJEFHOFO(Type FLPJMDMACMC, [Out] Type IIJBEPCFBEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void HGNOPNPBIAI<T>(byte[][] DHKACHBOJLC, object[] NLKKCJMKOPK, JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH BPDAEDIJBFN);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T OKOJPFHLBIO<T>(object[] NLKKCJMKOPK, NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH BPDAEDIJBFN);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class DIMEPIAFFAA<T> : IFDPBPAOPOC<T>, BPIGAGDGECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] DHKACHBOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] GAGFKMIHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] CGBGKKIIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly HGNOPNPBIAI<T> ILCKGMDOFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly OKOJPFHLBIO<T> ICCNIAGFDKH;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1E12380", Offset = "0x1E11580", VA = "0x181E12380")]
	public DIMEPIAFFAA(byte[][] DHKACHBOJLC, object[] GAGFKMIHGNC, object[] CGBGKKIIDLB, HGNOPNPBIAI<T> ILCKGMDOFFP, OKOJPFHLBIO<T> ICCNIAGFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5118B40", Offset = "0x5117D40", VA = "0x185118B40", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5118A60", Offset = "0x5117C60", VA = "0x185118A60", Slot = "5")]
	public T LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JLNBCJAMOFP : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class JBDDOPMIPLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC5B0", Offset = "0x3BEB7B0", VA = "0x183BEC5B0")]
		static JBDDOPMIPLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private JLNBCJAMOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class IGIMECPFLKO : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class KGJKDEFJECH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3C88AE0", Offset = "0x3C87CE0", VA = "0x183C88AE0")]
		static KGJKDEFJECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private IGIMECPFLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class LBEJABLOFKA
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly KDHJEPEDNOH[] DJKBLPAGCBP;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class MDCJJHIDNIB : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class LGJFMPNNCKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D392B0", Offset = "0x3D384B0", VA = "0x183D392B0")]
		static LGJFMPNNCKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class KLAACKOFPCI : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class HNLKBMKFDBG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x398B2E0", Offset = "0x398A4E0", VA = "0x18398B2E0")]
			static HNLKBMKFDBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private KLAACKOFPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private MDCJJHIDNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class LGLLICBHFPE : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class NCBALKIOOJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4980", Offset = "0x3FF3B80", VA = "0x183FF4980")]
		static NCBALKIOOJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class EBLHCDFFPPL : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class DENAJBKLJHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x510F9D0", Offset = "0x510EBD0", VA = "0x18510F9D0")]
			static DENAJBKLJHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private EBLHCDFFPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private LGLLICBHFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class FKANHGIOHDC : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class HCGENHBJBPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x391C9E0", Offset = "0x391BBE0", VA = "0x18391C9E0")]
		static HCGENHBJBPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class GBAOFCKBIND : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class DLOBAFACHMP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5133450", Offset = "0x5132650", VA = "0x185133450")]
			static DLOBAFACHMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private GBAOFCKBIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private FKANHGIOHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class GLKDOIIFIFK : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class CDFKAHCGPIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4B5EF60", Offset = "0x4B5E160", VA = "0x184B5EF60")]
		static CDFKAHCGPIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class NMPLGAFHDKL : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class NIADMNOFMJF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4071AB0", Offset = "0x4070CB0", VA = "0x184071AB0")]
			static NIADMNOFMJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private NMPLGAFHDKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private GLKDOIIFIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class CNINOLINKEF : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class FOKOFHOOBDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x381D950", Offset = "0x381CB50", VA = "0x18381D950")]
		static FOKOFHOOBDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class HFBJBOBAIEO : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class BOCCNKCCKDK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x48B7180", Offset = "0x48B6380", VA = "0x1848B7180")]
			static BOCCNKCCKDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private HFBJBOBAIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private CNINOLINKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class JFGEKAKFOAL : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class ILLOMBKNBOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3A59330", Offset = "0x3A58530", VA = "0x183A59330")]
		static ILLOMBKNBOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class MGEAINBILMB : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class MBCCBLALHDF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3F45670", Offset = "0x3F44870", VA = "0x183F45670")]
			static MBCCBLALHDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private MGEAINBILMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private JFGEKAKFOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class GJBGFIBJJIB : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class PHOBAFGEGPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x426D450", Offset = "0x426C650", VA = "0x18426D450")]
		static PHOBAFGEGPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class KGCKJLMOOBE : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class FDCCGDKPLPI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x37F4950", Offset = "0x37F3B50", VA = "0x1837F4950")]
			static FDCCGDKPLPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private KGCKJLMOOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private GJBGFIBJJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class KHMDKFBHHMN : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class LFGNOGLBICM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D32EF0", Offset = "0x3D320F0", VA = "0x183D32EF0")]
		static LFGNOGLBICM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class LGLHEEKLCHB : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class LILJBLGEMOL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3D6AEE0", Offset = "0x3D6A0E0", VA = "0x183D6AEE0")]
			static LILJBLGEMOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private LGLHEEKLCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private KHMDKFBHHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class DFPHHHFPMKB : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class DBEBMBBGABF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x50FED00", Offset = "0x50FDF00", VA = "0x1850FED00")]
		static DBEBMBBGABF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class IFDCABPBDLJ : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class LEMPKHFPINP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3D26A90", Offset = "0x3D25C90", VA = "0x183D26A90")]
			static LEMPKHFPINP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private IFDCABPBDLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private DFPHHHFPMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class CLDAEDNPFEE : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class KDJLOOCLKMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CD00", Offset = "0x3C6BF00", VA = "0x183C6CD00")]
		static KDJLOOCLKMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class IAMJJBNEHJD : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class KFPNICJMFJI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3C80170", Offset = "0x3C7F370", VA = "0x183C80170")]
			static KFPNICJMFJI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private IAMJJBNEHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private CLDAEDNPFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class DDKKHBCMIPG : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class NIIOHBAHJGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4076C90", Offset = "0x4075E90", VA = "0x184076C90")]
		static NIIOHBAHJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class PHFCBMKFLHL : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class EKICHHNAIJD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3488B80", Offset = "0x3487D80", VA = "0x183488B80")]
			static EKICHHNAIJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private PHFCBMKFLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private DDKKHBCMIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class JPGPNLLDLFE : KDHJEPEDNOH
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class HANAICOPJKK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3913030", Offset = "0x3912230", VA = "0x183913030")]
		static HANAICOPJKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class LPKHJLKKHEN : KDHJEPEDNOH
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class EBGELOPGDPN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly IFDPBPAOPOC<T> HONMGKIILJF;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x345B730", Offset = "0x345A930", VA = "0x18345B730")]
			static EBGELOPGDPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly KDHJEPEDNOH KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly KDHJEPEDNOH[] AIJILADDNFO;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private LPKHJLKKHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
		public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly KDHJEPEDNOH KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly IFDPBPAOPOC<object> FCLINOAHFII;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	private JPGPNLLDLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	public IFDPBPAOPOC<T> AJBHOHKMLBJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct AONGOPAAACD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] EPPPFIJJACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int JPOIEEJJKGH;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B02910", Offset = "0x3B01B10", VA = "0x183B02910")]
	public AONGOPAAACD(int OBFGGCFPFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B025B0", Offset = "0x3B017B0", VA = "0x183B025B0")]
	public void OEOPOJPHCNL(T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B02450", Offset = "0x3B01650", VA = "0x183B02450")]
	public T[] BMDNHBEFNOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class AKDNOPGAPAP : JIHGNJAIIGM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly AKDNOPGAPAP CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B18B30", Offset = "0x6B17D30", VA = "0x186B18B30")]
	public AKDNOPGAPAP(int BGGHAHDMFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class JIHGNJAIIGM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int BGGHAHDMFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object JACBFOIPGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int HMFNCGHECPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] BMMNLBFEELM;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1AF40", Offset = "0x3C1A140", VA = "0x183C1AF40")]
	public JIHGNJAIIGM(int BGGHAHDMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C1AC50", Offset = "0x3C19E50", VA = "0x183C1AC50")]
	public T[] PKDDMFKGBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C1AAD0", Offset = "0x3C19CD0", VA = "0x183C1AAD0")]
	public void HKAJHANEFAP(T[] GEHAOEPMDJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class ECNJGNIHOKK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class HGGKBLLHKEK : IComparable<HGGKBLLHKEK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class PHEBAOKFFCI : IEnumerable<HGGKBLLHKEK>, IEnumerable, IEnumerator<HGGKBLLHKEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private HGGKBLLHKEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public HGGKBLLHKEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private HGGKBLLHKEK System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
			[DebuggerHidden]
			public PHEBAOKFFCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6B2E730", Offset = "0x6B2D930", VA = "0x186B2E730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6B2E860", Offset = "0x6B2DA60", VA = "0x186B2E860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6B2E7B0", Offset = "0x6B2D9B0", VA = "0x186B2E7B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HGGKBLLHKEK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6B2E7B0", Offset = "0x6B2D9B0", VA = "0x186B2E7B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class NBOGNDHBFMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public NBOGNDHBFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF2F0", Offset = "0x6AFE4F0", VA = "0x186AFF2F0")]
			internal Label CEPPLEINIHG(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6AFF2F0", Offset = "0x6AFE4F0", VA = "0x186AFF2F0")]
			internal Label OBBGCOFBNKM(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly HGGKBLLHKEK[] GDBLBONHONF;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] IJLOAJMCJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong OGJDOBGGLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int FJJHODHBEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string KFDKCLDOFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private HGGKBLLHKEK[] NIFANPEJNFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] NDBPHMEDIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int KIGJDGACGDD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PMKOCJMHJOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x53DCAF0", Offset = "0x53DBCF0", VA = "0x1853DCAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B22640", Offset = "0x6B21840", VA = "0x186B22640")]
		public HGGKBLLHKEK(ulong GOBGGNLGONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6B222B0", Offset = "0x6B214B0", VA = "0x186B222B0")]
		public HGGKBLLHKEK OEOPOJPHCNL(ulong GOBGGNLGONA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B224B0", Offset = "0x6B216B0", VA = "0x186B224B0")]
		public HGGKBLLHKEK OEOPOJPHCNL(ulong GOBGGNLGONA, int NICEPFIEJED, string KFDKCLDOFAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B21060", Offset = "0x6B20260", VA = "0x186B21060")]
		public HGGKBLLHKEK AIFOHJCJKMJ(byte[] MBFPHKFMHDM, int BJPGLMJPACN, int BIFBCDFEPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B22510", Offset = "0x6B21710", VA = "0x186B22510")]
		internal static int PLEJCFLAILC(ulong[] GEHAOEPMDJB, int HMFNCGHECPG, int HHOELNLHIEN, ulong NICEPFIEJED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B211E0", Offset = "0x6B203E0", VA = "0x186B211E0", Slot = "4")]
		public int CompareTo(HGGKBLLHKEK NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B21EC0", Offset = "0x6B210C0", VA = "0x186B21EC0")]
		[IteratorStateMachine(typeof(PHEBAOKFFCI))]
		public IEnumerable<HGGKBLLHKEK> GAOKEDLFJPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B21F40", Offset = "0x6B21140", VA = "0x186B21F40")]
		public void MBAEGBAJOCG(ILGenerator OPIHFNDEDPG, LocalBuilder MBFPHKFMHDM, LocalBuilder BIFBCDFEPOE, LocalBuilder GOBGGNLGONA, Action<KeyValuePair<string, int>> KJGBEOPHEFM, Action MIGDAMICHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6B21210", Offset = "0x6B20410", VA = "0x186B21210")]
		private static void EGFMPHODAKI(ILGenerator OPIHFNDEDPG, LocalBuilder MBFPHKFMHDM, LocalBuilder BIFBCDFEPOE, LocalBuilder GOBGGNLGONA, Action<KeyValuePair<string, int>> KJGBEOPHEFM, Action MIGDAMICHMO, HGGKBLLHKEK[] NIFANPEJNFC, int KIGJDGACGDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IIANHHJBFBO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IEnumerable<HGGKBLLHKEK> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<HGGKBLLHKEK> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<HGGKBLLHKEK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HGGKBLLHKEK <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xAEBD30", Offset = "0xAEAF30", VA = "0x180AEBD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B23A00", Offset = "0x6B22C00", VA = "0x186B23A00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D32B70", Offset = "0x1D31D70", VA = "0x181D32B70")]
		[DebuggerHidden]
		public IIANHHJBFBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6B23A50", Offset = "0x6B22C50", VA = "0x186B23A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B23450", Offset = "0x6B22650", VA = "0x186B23450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B23400", Offset = "0x6B22600", VA = "0x186B23400")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B238B0", Offset = "0x6B22AB0", VA = "0x186B238B0")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6B239B0", Offset = "0x6B22BB0", VA = "0x186B239B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B23900", Offset = "0x6B22B00", VA = "0x186B23900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B23900", Offset = "0x6B22B00", VA = "0x186B23900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HGGKBLLHKEK MIAAKEAGJGI;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DFF0", Offset = "0x6B1D1F0", VA = "0x186B1DFF0")]
	public ECNJGNIHOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DE50", Offset = "0x6B1D050", VA = "0x186B1DE50")]
	public void OEOPOJPHCNL(byte[] CGAHJPHALBC, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DC90", Offset = "0x6B1CE90", VA = "0x186B1DC90")]
	public bool EMDPJMCEPGP(ArraySegment<byte> GOBGGNLGONA, [Out] int NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DF60", Offset = "0x6B1D160", VA = "0x186B1DF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D980", Offset = "0x6B1CB80", VA = "0x186B1D980")]
	private static void BHFOKGFGAPF(IEnumerable<HGGKBLLHKEK> NIFANPEJNFC, StringBuilder JPLKLKEAPIE, int JOJPILNPIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DD70", Offset = "0x6B1CF70", VA = "0x186B1DD70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DD70", Offset = "0x6B1CF70", VA = "0x186B1DD70", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DDD0", Offset = "0x6B1CFD0", VA = "0x186B1DDD0")]
	[IteratorStateMachine(typeof(IIANHHJBFBO))]
	private static IEnumerable<KeyValuePair<string, int>> ICAIDMCNMLI(IEnumerable<HGGKBLLHKEK> NIFANPEJNFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DC60", Offset = "0x6B1CE60", VA = "0x186B1DC60")]
	public void CHGILMOADOJ(ILGenerator OPIHFNDEDPG, LocalBuilder MBFPHKFMHDM, LocalBuilder BIFBCDFEPOE, LocalBuilder GOBGGNLGONA, Action<KeyValuePair<string, int>> KJGBEOPHEFM, Action MIGDAMICHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class MKFHBJEONHN
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo DENHLDMMOCP;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B27A10", Offset = "0x6B26C10", VA = "0x186B27A10")]
	public static ulong ABFHAHLIIJD(byte[] CGAHJPHALBC, int BJPGLMJPACN, int BIFBCDFEPOE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DDMLPHPNENJ
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D200", Offset = "0x6B1C400", VA = "0x186B1D200")]
	public static void EPBJJNCPEEH(byte[] CGAHJPHALBC, int BJPGLMJPACN, int PCJBGNKGAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D0E0", Offset = "0x6B1C2E0", VA = "0x186B1D0E0")]
	public static void DOIPHBFNAHD(byte[] GEHAOEPMDJB, int GAJHCGJHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D340", Offset = "0x6B1C540", VA = "0x186B1D340")]
	public static byte[] JOMMIHBFGID(byte[] LHCBCAKMNGO, int GAJHCGJHEHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GNLNAFDAKBD
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B20E30", Offset = "0x6B20030", VA = "0x186B20E30")]
	public static bool DBJIIIOILFO(byte[] PNOBAOELAFB, int OPGJHPICKNC, int KFGIJMCBNLG, byte[] LHBBKMODMNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class EENEOLFAKJA<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct CBPFDMEMOII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] OGJDOBGGLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T FJJHODHBEGH;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4B52E60", Offset = "0x4B52060", VA = "0x184B52E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class DKOCIPMLAPC : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public EENEOLFAKJA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private CBPFDMEMOII[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private CBPFDMEMOII[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAEBD30", Offset = "0xAEAF30", VA = "0x180AEBD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x384CCB0", Offset = "0x384BEB0", VA = "0x18384CCB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public DKOCIPMLAPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x512BF10", Offset = "0x512B110", VA = "0x18512BF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x512D2D0", Offset = "0x512C4D0", VA = "0x18512D2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly CBPFDMEMOII[][] OENLFJODJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong CDFPHPJEDMK;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3469C50", Offset = "0x3468E50", VA = "0x183469C50")]
	public EENEOLFAKJA(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3469C70", Offset = "0x3468E70", VA = "0x183469C70")]
	public EENEOLFAKJA(int DIHLAEIGMPG, float LPKGPHHDONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3467DB0", Offset = "0x3466FB0", VA = "0x183467DB0")]
	public void OEOPOJPHCNL(byte[] GOBGGNLGONA, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3465F00", Offset = "0x3465100", VA = "0x183465F00")]
	private bool KLOLLFDBPJP(byte[] GOBGGNLGONA, T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3469390", Offset = "0x3468590", VA = "0x183469390")]
	public bool PEFGNEHBCPG(ArraySegment<byte> GOBGGNLGONA, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3467D60", Offset = "0x3466F60", VA = "0x183467D60")]
	private static ulong LBLACBKJBDJ(byte[] KPEEHKEJDAP, int BJPGLMJPACN, int KIGJDGACGDD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x34659C0", Offset = "0x3464BC0", VA = "0x1834659C0")]
	private static int AEDIBNJOMMK(int KGJIALMKFLN, float LPKGPHHDONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3465B10", Offset = "0x3464D10", VA = "0x183465B10", Slot = "4")]
	[IteratorStateMachine(typeof(EENEOLFAKJA<>.DKOCIPMLAPC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3469C30", Offset = "0x3468E30", VA = "0x183469C30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class OBEJHGEACKG : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] CNBAPMOOHOC;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] JGAJOIPICPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int NINJBHIEKAN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool GGLJIGIDAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B2C8B0", Offset = "0x6B2BAB0", VA = "0x186B2C8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C9F0", Offset = "0x6B2BBF0", VA = "0x186B2C9F0")]
	static OBEJHGEACKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CC30", Offset = "0x6B2BE30", VA = "0x186B2CC30")]
	public OBEJHGEACKG(byte[] DENLBHBCHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C900", Offset = "0x6B2BB00", VA = "0x186B2C900")]
	public OpCode NGAEKDCDAIC()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct NNAOENKBIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid FJJHODHBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte JLKJKHLOLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte IEBDFPFFLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte POGPICNJDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte IEDKAEBDJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte LLLHGIMDIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte AILPPEHHMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte NIFJNKJKALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte OOBJDDNEJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte NPMJHMKCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte PHCBLFDNBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte GCHEGACJGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte LPGGDPAAIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte NCFHBFPACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte BBAPAPPPGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte DCPACGLIPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte LIGGJOAKJOA;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] ICCIHECPKNM;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] NAJPBCLOBHL;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B150", Offset = "0x6B2A350", VA = "0x186B2B150")]
	public NNAOENKBIPG(Guid NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B160", Offset = "0x6B2A360", VA = "0x186B2B160")]
	public NNAOENKBIPG(ArraySegment<byte> KAIDPKKMNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2AFD0", Offset = "0x6B2A1D0", VA = "0x186B2AFD0")]
	private static byte POBPJJLNAKC(byte[] CGAHJPHALBC, int DMJGGHPPDIA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A2A0", Offset = "0x6B294A0", VA = "0x186B2A2A0")]
	private static byte ANICMLNBBBD(byte HGMCBKHHGFH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A3C0", Offset = "0x6B295C0", VA = "0x186B2A3C0")]
	public void PDEJFMIBDBD(byte[] BCDEBAAMJOP, int BJPGLMJPACN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class NMFIJFHLFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B28F10", Offset = "0x6B28110", VA = "0x186B28F10")]
	public static bool DNIEEKADBEI(byte MOAAELBABJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B29450", Offset = "0x6B28650", VA = "0x186B29450")]
	public static bool JJCOLCLJIPH(byte MOAAELBABJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A000", Offset = "0x6B29200", VA = "0x186B2A000")]
	public static sbyte PPKJGLDLLHI(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B28D40", Offset = "0x6B27F40", VA = "0x186B28D40")]
	public static short BLMBOGBOOAE(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6B292E0", Offset = "0x6B284E0", VA = "0x186B292E0")]
	public static int HJNJNCBEIAL(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B294C0", Offset = "0x6B286C0", VA = "0x186B294C0")]
	public static long JJOHJLILCMK(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B293D0", Offset = "0x6B285D0", VA = "0x186B293D0")]
	public static byte ICCFAJCCIEF(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B28CC0", Offset = "0x6B27EC0", VA = "0x186B28CC0")]
	public static ushort BEOPENAOHNM(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B28F20", Offset = "0x6B28120", VA = "0x186B28F20")]
	public static uint FDABNBMDDLH(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6B291D0", Offset = "0x6B283D0", VA = "0x186B291D0")]
	public static ulong GOHHLDDBBOO(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6B29F20", Offset = "0x6B29120", VA = "0x186B29F20")]
	public static float NENCCFNEKEH(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6B28E30", Offset = "0x6B28030", VA = "0x186B28E30")]
	public static double CHGAIGGEEPN(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6B28620", Offset = "0x6B27820", VA = "0x186B28620")]
	public static int AMKJAKBGILP(byte[] BCDEBAAMJOP, int BJPGLMJPACN, ulong NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6B29560", Offset = "0x6B28760", VA = "0x186B29560")]
	public static int MNECDHHCACK(byte[] BCDEBAAMJOP, int BJPGLMJPACN, long NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6B28FA0", Offset = "0x6B281A0", VA = "0x186B28FA0")]
	public static bool FKCPLFLAFGM(byte[] CGAHJPHALBC, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class FCGCNJODOOC
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class EELPHAHJADO : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public EELPHAHJADO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E650", Offset = "0x6B1D850", VA = "0x186B1E650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E0C0", Offset = "0x6B1D2C0", VA = "0x186B1E0C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E070", Offset = "0x6B1D270", VA = "0x186B1E070")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E4F0", Offset = "0x6B1D6F0", VA = "0x186B1E4F0")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E600", Offset = "0x6B1D800", VA = "0x186B1E600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E540", Offset = "0x6B1D740", VA = "0x186B1E540", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E540", Offset = "0x6B1D740", VA = "0x186B1E540", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class AIHGAJGJJBE : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public AIHGAJGJJBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6B18960", Offset = "0x6B17B60", VA = "0x186B18960", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6B183D0", Offset = "0x6B175D0", VA = "0x186B183D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6B18380", Offset = "0x6B17580", VA = "0x186B18380")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6B18800", Offset = "0x6B17A00", VA = "0x186B18800")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6B18910", Offset = "0x6B17B10", VA = "0x186B18910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6B18850", Offset = "0x6B17A50", VA = "0x186B18850", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6B18850", Offset = "0x6B17A50", VA = "0x186B18850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FBF0", Offset = "0x6B1EDF0", VA = "0x186B1FBF0")]
	public static bool EDKBBHFNNFH(this TypeInfo FLPJMDMACMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FCB0", Offset = "0x6B1EEB0", VA = "0x186B1FCB0")]
	public static bool HMCAFCHDPMI(this TypeInfo FLPJMDMACMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FDE0", Offset = "0x6B1EFE0", VA = "0x186B1FDE0")]
	public static IEnumerable<PropertyInfo> IIGPCAKCKOD(this Type FLPJMDMACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FB50", Offset = "0x6B1ED50", VA = "0x186B1FB50")]
	[IteratorStateMachine(typeof(EELPHAHJADO))]
	private static IEnumerable<PropertyInfo> CJANONKDLKJ(Type FLPJMDMACMC, HashSet<string> CCAJKFPIDEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FE60", Offset = "0x6B1F060", VA = "0x186B1FE60")]
	public static IEnumerable<FieldInfo> LDAOFAFICIL(this Type FLPJMDMACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FEE0", Offset = "0x6B1F0E0", VA = "0x186B1FEE0")]
	[IteratorStateMachine(typeof(AIHGAJGJJBE))]
	private static IEnumerable<FieldInfo> NIOAKANJCGD(Type FLPJMDMACMC, HashSet<string> CCAJKFPIDEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class FBACKLFHIOB
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding EAAIHEJCLON;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class LEOKGBGHMMD
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static string DHOCLMGPKKN(string HHFLAHOCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6B25B40", Offset = "0x6B24D40", VA = "0x186B25B40")]
	public static string BDHNALOJGMF(string HHFLAHOCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6B25C20", Offset = "0x6B24E20", VA = "0x186B25C20")]
	public static string LENDKBEGHPJ(string HHFLAHOCOCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class IAFLOKKLFCN<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class GHLKFHLOGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type OGJDOBGGLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue FJJHODHBEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int CAFLFDOEGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public GHLKFHLOGPN GNHHBJIJMBA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x38BAB20", Offset = "0x38B9D20", VA = "0x1838BAB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x38BA9D0", Offset = "0x38B9BD0", VA = "0x1838BA9D0")]
		private int PIKJCOKEANP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GHLKFHLOGPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class GDJJJOJIHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GDJJJOJIHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
		internal TValue IINCFKCGMEE(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private GHLKFHLOGPN[] OENLFJODJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int MKJBDDDPMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object DOBCKLEGDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float LPKGPHHDONF;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3A31550", Offset = "0x3A30750", VA = "0x183A31550")]
	public IAFLOKKLFCN(int DIHLAEIGMPG = 4, float LPKGPHHDONF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3A30920", Offset = "0x3A2FB20", VA = "0x183A30920")]
	public bool PBCOJKEDMAJ(Type GOBGGNLGONA, TValue NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3A308E0", Offset = "0x3A2FAE0", VA = "0x183A308E0")]
	public bool PBCOJKEDMAJ(Type GOBGGNLGONA, Func<Type, TValue> HDILAFDKDCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3A30130", Offset = "0x3A2F330", VA = "0x183A30130")]
	private bool KLOLLFDBPJP(Type GOBGGNLGONA, Func<Type, TValue> HDILAFDKDCN, [Out] TValue HBGOMBMDFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3A31190", Offset = "0x3A30390", VA = "0x183A31190")]
	private bool PNAHMPPBHIF(GHLKFHLOGPN[] OENLFJODJKC, Type FAIEOMHAPAB, GHLKFHLOGPN GHAGHICADLI, Func<Type, TValue> HDILAFDKDCN, [Out] TValue HBGOMBMDFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3A30A40", Offset = "0x3A2FC40", VA = "0x183A30A40")]
	public bool PEFGNEHBCPG(Type GOBGGNLGONA, [Out] TValue NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3A30D50", Offset = "0x3A2FF50", VA = "0x183A30D50")]
	public TValue PGLPCKLKBJO(Type GOBGGNLGONA, Func<Type, TValue> HDILAFDKDCN)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x34659C0", Offset = "0x3464BC0", VA = "0x1834659C0")]
	private static int AEDIBNJOMMK(int KGJIALMKFLN, float LPKGPHHDONF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3A30100", Offset = "0x3A2F300", VA = "0x183A30100")]
	private static void CDKCIDPIIHN(GHLKFHLOGPN JPLLMLDHNHB, GHLKFHLOGPN NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3A30100", Offset = "0x3A2F300", VA = "0x183A30100")]
	private static void CDKCIDPIIHN(GHLKFHLOGPN[] JPLLMLDHNHB, GHLKFHLOGPN[] NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class EGJCFOMKMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder MOCFBLPEKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder PGCELPHNFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object JACBFOIPGPG;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E780", Offset = "0x6B1D980", VA = "0x186B1E780")]
	public TypeBuilder AMIPBLNDJIJ(string IKEFBMMMAJB, TypeAttributes PCDBIALGHAF, Type BHNONFFBKHO, Type[] GPEHLLEGJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E880", Offset = "0x6B1DA80", VA = "0x186B1E880")]
	public EGJCFOMKMGN(string MIMBGPDAAHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class OILEGKAACJA
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CCC0", Offset = "0x6B2BEC0", VA = "0x186B2CCC0")]
	private static MethodInfo HFBOGDGBEMH(LambdaExpression MDHGHMHLHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2A49490", Offset = "0x2A48690", VA = "0x182A49490")]
	public static MethodInfo ADIMHJCNCKP<T>(Expression<Func<T>> MDHGHMHLHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2A49490", Offset = "0x2A48690", VA = "0x182A49490")]
	public static MethodInfo ADIMHJCNCKP<T, TR>(Expression<Func<T, TR>> MDHGHMHLHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2A49490", Offset = "0x2A48690", VA = "0x182A49490")]
	public static MethodInfo ADIMHJCNCKP<T>(Expression<Action<T>> MDHGHMHLHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2A49490", Offset = "0x2A48690", VA = "0x182A49490")]
	public static MethodInfo ADIMHJCNCKP<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> MDHGHMHLHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A494A0", Offset = "0x2A486A0", VA = "0x182A494A0")]
	private static MemberInfo DDALGHHPJFD<T>(Expression<T> GBHPBJPAFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A49580", Offset = "0x2A48780", VA = "0x182A49580")]
	public static PropertyInfo IEIDLNAJFEL<T, TR>(Expression<Func<T, TR>> MDHGHMHLHDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct LMOHOEJPFDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int GJIHJJPNBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool OHLLOGKMPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator OPIHFNDEDPG;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6B26100", Offset = "0x6B25300", VA = "0x186B26100")]
	public LMOHOEJPFDC(ILGenerator OPIHFNDEDPG, int GJIHJJPNBNJ, bool OHLLOGKMPMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6B26070", Offset = "0x6B25270", VA = "0x186B26070")]
	public LMOHOEJPFDC(ILGenerator OPIHFNDEDPG, int GJIHJJPNBNJ, Type FLPJMDMACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6B25F70", Offset = "0x6B25170", VA = "0x186B25F70")]
	public void JKMFDFKKEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class LBCHKJNKEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6B25450", Offset = "0x6B24650", VA = "0x186B25450")]
	public static void MAOGPDGMPBP(this ILGenerator OPIHFNDEDPG, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6B25630", Offset = "0x6B24830", VA = "0x186B25630")]
	public static void MAOGPDGMPBP(this ILGenerator OPIHFNDEDPG, LocalBuilder GCDKOBFDKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6B25750", Offset = "0x6B24950", VA = "0x186B25750")]
	public static void PBLHJDJMGCM(this ILGenerator OPIHFNDEDPG, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6B25710", Offset = "0x6B24910", VA = "0x186B25710")]
	public static void PBLHJDJMGCM(this ILGenerator OPIHFNDEDPG, LocalBuilder GCDKOBFDKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6B24FA0", Offset = "0x6B241A0", VA = "0x186B24FA0")]
	public static void KCDEKBPNBGK(this ILGenerator OPIHFNDEDPG, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6B24EA0", Offset = "0x6B240A0", VA = "0x186B24EA0")]
	public static void KCDEKBPNBGK(this ILGenerator OPIHFNDEDPG, LocalBuilder GCDKOBFDKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6B25440", Offset = "0x6B24640", VA = "0x186B25440")]
	public static void MAMIBGNFAGP(this ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6B24A50", Offset = "0x6B23C50", VA = "0x186B24A50")]
	public static void FEDAKPOLCJA(this ILGenerator OPIHFNDEDPG, bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6B25080", Offset = "0x6B24280", VA = "0x186B25080")]
	public static void KEEPELIIEIB(this ILGenerator OPIHFNDEDPG, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6B24BF0", Offset = "0x6B23DF0", VA = "0x186B24BF0")]
	public static void IAJFJHAHDPF(this ILGenerator OPIHFNDEDPG, Type FLPJMDMACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6B25670", Offset = "0x6B24870", VA = "0x186B25670")]
	public static void MDEJIONBOCP(this ILGenerator OPIHFNDEDPG, Type FLPJMDMACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6B24CC0", Offset = "0x6B23EC0", VA = "0x186B24CC0")]
	public static void IEOAKCPIHJO(this ILGenerator OPIHFNDEDPG, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6B24AF0", Offset = "0x6B23CF0", VA = "0x186B24AF0")]
	public static void GEGNBJAMAAL(this ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6B24890", Offset = "0x6B23A90", VA = "0x186B24890")]
	public static void AIMMHHJKMIN(this ILGenerator OPIHFNDEDPG, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6B24960", Offset = "0x6B23B60", VA = "0x186B24960")]
	public static void COBOCJNCNAM(this ILGenerator OPIHFNDEDPG, MethodInfo KFBFAFBOJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6B24B60", Offset = "0x6B23D60", VA = "0x186B24B60")]
	public static void HPBIKHILBAM(this ILGenerator OPIHFNDEDPG, FieldInfo KACPPNGOFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6B24A60", Offset = "0x6B23C60", VA = "0x186B24A60")]
	public static void GDGBOILDLLK(this ILGenerator OPIHFNDEDPG, ulong NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class HLIJMIDBICH
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class BFEMAJOCPKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BFEMAJOCPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6B18EA0", Offset = "0x6B180A0", VA = "0x186B18EA0")]
		internal bool LAFMGAHCCGG(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo DFKACHGFPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo IPGEGJGGOIF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string LBFKNMEJJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OHOMDIIGPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6B22D20", Offset = "0x6B21F20", VA = "0x186B22D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NIFJCIFGHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7B62E0", Offset = "0x7B54E0", VA = "0x1807B62E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B5200", VA = "0x1807B6000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AGFAIOPENBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x93BA90", Offset = "0x93AC90", VA = "0x18093BA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x93B650", Offset = "0x93A850", VA = "0x18093B650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type DIOCHMJOOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo IGAIMCCNMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CODPPBIKJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo LJHLOCLHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F0", Offset = "0x7B54F0", VA = "0x1807B62F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6B23000", Offset = "0x6B22200", VA = "0x186B23000")]
	protected HLIJMIDBICH(Type FLPJMDMACMC, string IKEFBMMMAJB, string EMDBDBEGFFC, bool OADAPGJOEHI, bool PPADEKPJOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6B22D30", Offset = "0x6B21F30", VA = "0x186B22D30")]
	public HLIJMIDBICH(FieldInfo FNIBPAONDEO, string IKEFBMMMAJB, bool MCGFLJPKJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6B22E40", Offset = "0x6B22040", VA = "0x186B22E40")]
	public HLIJMIDBICH(PropertyInfo FNIBPAONDEO, string IKEFBMMMAJB, bool MCGFLJPKJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6B22A40", Offset = "0x6B21C40", VA = "0x186B22A40")]
	private static MethodInfo HADJBCBNFMP(MemberInfo FNIBPAONDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x290BF20", Offset = "0x290B120", VA = "0x18290BF20")]
	public T JABEHOMNLNO<T>(bool AOOOGFJINGC) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6B22BB0", Offset = "0x6B21DB0", VA = "0x186B22BB0", Slot = "4")]
	public virtual void KKELKJPCCCB(ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6B228D0", Offset = "0x6B21AD0", VA = "0x186B228D0", Slot = "5")]
	public virtual void DBJKNMGDOBH(ILGenerator OPIHFNDEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class HILNEPDMFKO : HLIJMIDBICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string MFFCALOPPLO;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6B227F0", Offset = "0x6B219F0", VA = "0x186B227F0")]
	public HILNEPDMFKO(string IKEFBMMMAJB, string MFFCALOPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6B22740", Offset = "0x6B21940", VA = "0x186B22740", Slot = "4")]
	public override void KKELKJPCCCB(ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6B226F0", Offset = "0x6B218F0", VA = "0x186B226F0", Slot = "5")]
	public override void DBJKNMGDOBH(ILGenerator OPIHFNDEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class FPBIEKLAAAO : HLIJMIDBICH
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo KJPIEJIDNNO;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo DBNDJEOKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal LMOHOEJPFDC HKKFHALPILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal LMOHOEJPFDC LLCOCEABGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal LMOHOEJPFDC GEBMBIGPPDN;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6B208D0", Offset = "0x6B1FAD0", VA = "0x186B208D0")]
	public FPBIEKLAAAO(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6B20150", Offset = "0x6B1F350", VA = "0x186B20150", Slot = "4")]
	public override void KKELKJPCCCB(ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6B20100", Offset = "0x6B1F300", VA = "0x186B20100", Slot = "5")]
	public override void DBJKNMGDOBH(ILGenerator OPIHFNDEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6B20210", Offset = "0x6B1F410", VA = "0x186B20210")]
	public void MHDHIFGCJGC(ILGenerator OPIHFNDEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class MAMMFPLPJFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type DIOCHMJOOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EJCFJMAHMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E0", Offset = "0x85E5E0", VA = "0x18085F3E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA960", Offset = "0x7B9B60", VA = "0x1807BA960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CIANBEMKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85F530", Offset = "0x85E730", VA = "0x18085F530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x93A290", Offset = "0x939490", VA = "0x18093A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo AABBFLBDAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HLIJMIDBICH[] EJIGPJNJJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HLIJMIDBICH[] MEFENEBBDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6B263E0", Offset = "0x6B255E0", VA = "0x186B263E0")]
	public MAMMFPLPJFK(Type FLPJMDMACMC, Func<string, string> MCFHBPNJKFH, bool MCGFLJPKJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6B26300", Offset = "0x6B25500", VA = "0x186B26300")]
	private static bool KKLIELHHMFJ(IEnumerator<ConstructorInfo> BAFNAKLJDEN, ConstructorInfo GNCNKCCBFMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct DFDDKKHOBCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong AOFBHBBPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int HBHCJPCIBAB;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1E323B0", Offset = "0x1E315B0", VA = "0x181E323B0")]
	public DFDDKKHOBCC(ulong MDNPBHDCHBD, int HHPOMGOJMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D630", Offset = "0x6B1C830", VA = "0x186B1D630")]
	public void LLIMONGBOJB(DFDDKKHOBCC NOBJAPGNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D640", Offset = "0x6B1C840", VA = "0x186B1D640")]
	public static DFDDKKHOBCC MKGPLJPCJIO(DFDDKKHOBCC JPEEHDCLFEK, DFDDKKHOBCC HGMCBKHHGFH)
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D5A0", Offset = "0x6B1C7A0", VA = "0x186B1D5A0")]
	public void HMIOBLKFMLJ(DFDDKKHOBCC NOBJAPGNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D470", Offset = "0x6B1C670", VA = "0x186B1D470")]
	public static DFDDKKHOBCC DAALOBHLANB(DFDDKKHOBCC JPEEHDCLFEK, DFDDKKHOBCC HGMCBKHHGFH)
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D510", Offset = "0x6B1C710", VA = "0x186B1D510")]
	public void EELFFHKLADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D550", Offset = "0x6B1C750", VA = "0x186B1D550")]
	public static DFDDKKHOBCC EELFFHKLADA(DFDDKKHOBCC JPEEHDCLFEK)
	{
		return default(DFDDKKHOBCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct APDLLHEJGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] BCDEBAAMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int BJPGLMJPACN;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1902280", Offset = "0x1901480", VA = "0x181902280")]
	public APDLLHEJGHE(byte[] BCDEBAAMJOP, int DHMMMGDKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A980", Offset = "0x6B09B80", VA = "0x186B0A980")]
	public void DDDPIABJJAF(byte ENONAODCGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6B18E20", Offset = "0x6B18020", VA = "0x186B18E20")]
	public void NLCHLFKJJPO(byte[] ENONAODCGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6B18DA0", Offset = "0x6B17FA0", VA = "0x186B18DA0")]
	public void JJPGMOLEPHH(byte[] ENONAODCGNA, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6B18D00", Offset = "0x6B17F00", VA = "0x186B18D00")]
	public void JJPGMOLEPHH(byte[] ENONAODCGNA, int PFGKDMDHLBN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6B18C80", Offset = "0x6B17E80", VA = "0x186B18C80")]
	public void FLLPAFCGJJC(byte MOAAELBABJA, int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6B18B80", Offset = "0x6B17D80", VA = "0x186B18B80")]
	public void CJEGPAGFHFF(string ENONAODCGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class BGKGMKMLMKL
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum LEKBNKJDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum FGBOMNMNLCP
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum PJBCPPCMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ThreadStatic]
	private static byte[] KLKLAPNBIOA;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] JBCJCEGKMMA;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] JCNMDGFPILD;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] KODHHOHGPHE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly PJBCPPCMNDN KMBIDBHGDCO;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char FMJJPDDPFEP;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int IMECFPHFEMN;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int BANBLGPMOAF;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] PGMOBHEKKJI;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A5A0", Offset = "0x6B197A0", VA = "0x186B1A5A0")]
	private static byte[] KEFALEHNFFE(int MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A670", Offset = "0x6B19870", VA = "0x186B1A670")]
	private static byte[] KJECNBILEGG(int MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B194F0", Offset = "0x6B186F0", VA = "0x186B194F0")]
	public static int BANJBNJDIAG(byte[] BCDEBAAMJOP, int BJPGLMJPACN, float NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B193D0", Offset = "0x6B185D0", VA = "0x186B193D0")]
	public static int BANJBNJDIAG(byte[] BCDEBAAMJOP, int BJPGLMJPACN, double NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AE30", Offset = "0x6B1A030", VA = "0x186B1AE30")]
	private static bool NJFDMPLBBFH(byte[] BCDEBAAMJOP, int HHOELNLHIEN, ulong NFOMDIMMABA, ulong AJMKCOMLPKB, ulong BIFBCDFEPOE, ulong NIMNKIPJALJ, ulong CAGPDPAMACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B199A0", Offset = "0x6B18BA0", VA = "0x186B199A0")]
	private static void CGAJKNNLGHE(uint DLJHBOKIEPE, int EMIKLOCDBLC, [Out] uint DMBBHINHALK, [Out] int KEDCNNDPOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A940", Offset = "0x6B19B40", VA = "0x186B1A940")]
	private static bool MPABFAPJLKG(DFDDKKHOBCC OIHFDFKJMFI, DFDDKKHOBCC KLBKDHONFBL, DFDDKKHOBCC HPCAMODNDFG, byte[] BCDEBAAMJOP, [Out] int HHOELNLHIEN, [Out] int ECNPFFGDBBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A120", Offset = "0x6B19320", VA = "0x186B1A120")]
	private static bool JFBHDBNJFPF(double IFBNMJJOJMJ, LEKBNKJDJJE MAGPNICKDGE, byte[] BCDEBAAMJOP, [Out] int HHOELNLHIEN, [Out] int MPLBENIMFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AD20", Offset = "0x6B19F20", VA = "0x186B1AD20")]
	private static bool NGFHECCCJND(double IFBNMJJOJMJ, LEKBNKJDJJE MAGPNICKDGE, byte[] BCDEBAAMJOP, [Out] int HHOELNLHIEN, [Out] int HMGEPBMAABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B19F60", Offset = "0x6B19160", VA = "0x186B19F60")]
	private static bool HIJHMKFEIJA(double NICEPFIEJED, APDLLHEJGHE FPNCMMLOMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B19A90", Offset = "0x6B18C90", VA = "0x186B19A90")]
	private static bool FDKJELFENIG(double NICEPFIEJED, APDLLHEJGHE FPNCMMLOMOC, FGBOMNMNLCP MAGPNICKDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B19610", Offset = "0x6B18810", VA = "0x186B19610")]
	private static void BOHADKKENIE(byte[] JMGGDKIOBGI, int HHOELNLHIEN, int HMGEPBMAABB, int CPDANFBMNPC, APDLLHEJGHE FPNCMMLOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B18FB0", Offset = "0x6B181B0", VA = "0x186B18FB0")]
	private static void AINHIOFADAH(byte[] JMGGDKIOBGI, int HHOELNLHIEN, int HHPOMGOJMHG, APDLLHEJGHE FPNCMMLOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A750", Offset = "0x6B19950", VA = "0x186B1A750")]
	private static bool LCJNAMEOELC(double IFBNMJJOJMJ, FGBOMNMNLCP MAGPNICKDGE, int FGFNDJDDDID, byte[] FLPDINIBANF, [Out] bool GABFNCFJJDA, [Out] int HHOELNLHIEN, [Out] int LJBCIKIPLBF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct EHJJHMOPCAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double IDBHAEBCELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong GBLGPHIBGIP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct FKLDNLLPPME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float AOFBHBBPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint KFAHLPLDGPG;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct KNMHOLFFKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong KMPPAAJLFAP;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B24740", Offset = "0x6B23940", VA = "0x186B24740")]
	public KNMHOLFFKFC(double IDBHAEBCELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B24750", Offset = "0x6B23950", VA = "0x186B24750")]
	public KNMHOLFFKFC(DFDDKKHOBCC IDBHAEBCELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B241B0", Offset = "0x6B233B0", VA = "0x186B241B0")]
	public DFDDKKHOBCC AHCKKCKEKGB()
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B24300", Offset = "0x6B23500", VA = "0x186B24300")]
	public DFDDKKHOBCC DINACIOOEHM()
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public ulong JCAFHHMHPFB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B243D0", Offset = "0x6B235D0", VA = "0x186B243D0")]
	public double LJLEKFGFNKA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B24450", Offset = "0x6B23650", VA = "0x186B24450")]
	public double LOMCEKNDKEM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B243A0", Offset = "0x6B235A0", VA = "0x186B243A0")]
	public int JHHMDPPBLLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B244F0", Offset = "0x6B236F0", VA = "0x186B244F0")]
	public ulong MNCJEEDNBJC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B24700", Offset = "0x6B23900", VA = "0x186B24700")]
	public bool PFIILDKKMGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B24380", Offset = "0x6B23580", VA = "0x186B24380")]
	public bool GFKEAILOHDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B242D0", Offset = "0x6B234D0", VA = "0x186B242D0")]
	public bool DCKODKLOFHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B246D0", Offset = "0x6B238D0", VA = "0x186B246D0")]
	public bool OBAMOCPGFHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B24720", Offset = "0x6B23920", VA = "0x186B24720")]
	public int PHIEANCBFJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B24520", Offset = "0x6B23720", VA = "0x186B24520")]
	public void NDMKHGCBONO([Out] DFDDKKHOBCC CHFOBOJFBOJ, [Out] DFDDKKHOBCC JCHGKBFGJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B24670", Offset = "0x6B23870", VA = "0x186B24670")]
	public bool NICKBONLPAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1070", Offset = "0x2EA0270", VA = "0x182EA1070")]
	public double NICEPFIEJED()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B24220", Offset = "0x6B23420", VA = "0x186B24220")]
	public static int BLDKGDKBDPL(int ADLNMELCEDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B246C0", Offset = "0x6B238C0", VA = "0x186B246C0")]
	public static double NNKCFKFACBN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B24240", Offset = "0x6B23440", VA = "0x186B24240")]
	public static ulong CAFADNPJHPE(DFDDKKHOBCC FEJMFFGDAMG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct LDPLGIHCELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint NAMKGPBLIME;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4DE0", Offset = "0x1FE3FE0", VA = "0x181FE4DE0")]
	public LDPLGIHCELJ(float AOFBHBBPJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B25930", Offset = "0x6B24B30", VA = "0x186B25930")]
	public DFDDKKHOBCC AHCKKCKEKGB()
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
	public uint LDCBNMMMOKB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B25980", Offset = "0x6B24B80", VA = "0x186B25980")]
	public int JHHMDPPBLLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B259A0", Offset = "0x6B24BA0", VA = "0x186B259A0")]
	public uint MNCJEEDNBJC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B25B30", Offset = "0x6B24D30", VA = "0x186B25B30")]
	public bool PFIILDKKMGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B259C0", Offset = "0x6B24BC0", VA = "0x186B259C0")]
	public void NDMKHGCBONO([Out] DFDDKKHOBCC CHFOBOJFBOJ, [Out] DFDDKKHOBCC JCHGKBFGJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B25AF0", Offset = "0x6B24CF0", VA = "0x186B25AF0")]
	public bool NICKBONLPAN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct FNGEOLOLHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong MDNPBHDCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short JCHFJONLNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short MPLBENIMFAP;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B200F0", Offset = "0x6B1F2F0", VA = "0x186B200F0")]
	public FNGEOLOLHEP(ulong MDNPBHDCHBD, short JCHFJONLNBH, short MPLBENIMFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class EIBECMINDGK
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly FNGEOLOLHEP[] DIGFIKIKCJN;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EA60", Offset = "0x6B1DC60", VA = "0x186B1EA60")]
	public static void MOBKFCKNKPH(int KJCDMHMOBCG, int HIDIKLKMOBI, [Out] DFDDKKHOBCC DMBBHINHALK, [Out] int MPLBENIMFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E990", Offset = "0x6B1DB90", VA = "0x186B1E990")]
	public static void DMPHNIOBKOD(int AJCEAPKLKNJ, [Out] DFDDKKHOBCC DMBBHINHALK, [Out] int EKPNNJJKNNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct KOOHKCDANNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] CGAHJPHALBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int PFGKDMDHLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int HIHHIOPJGAD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6B24850", Offset = "0x6B23A50", VA = "0x186B24850")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x37D35A0", Offset = "0x37D27A0", VA = "0x1837D35A0")]
	public KOOHKCDANNN(byte[] CGAHJPHALBC, int PFGKDMDHLBN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2038F50", Offset = "0x2038150", VA = "0x182038F50")]
	public int HHOELNLHIEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B247F0", Offset = "0x6B239F0", VA = "0x186B247F0")]
	public KOOHKCDANNN EKFOHMMPGPL(int AGNBNOOMFNG, int LKEJHNGNLDG)
	{
		return default(KOOHKCDANNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class CJACPCOHLNF
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] IAFAIKHOHPO;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] CLGPFBHBFOG;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int DBHLFEEDDKA;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B750", Offset = "0x6B1A950", VA = "0x186B1B750")]
	private static byte[] BOJLCIOMEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BCB0", Offset = "0x6B1AEB0", VA = "0x186B1BCB0")]
	private static KOOHKCDANNN LGJMMMNDPAK(KOOHKCDANNN BCDEBAAMJOP)
	{
		return default(KOOHKCDANNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B2F0", Offset = "0x6B1A4F0", VA = "0x186B1B2F0")]
	private static KOOHKCDANNN AFBNKJFEDBD(KOOHKCDANNN BCDEBAAMJOP)
	{
		return default(KOOHKCDANNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BB00", Offset = "0x6B1AD00", VA = "0x186B1BB00")]
	private static void DMDAGHCBEMH(KOOHKCDANNN BCDEBAAMJOP, int HHPOMGOJMHG, byte[] NFLGLGPBBFE, [Out] int HPDIBEGODLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B3D0", Offset = "0x6B1A5D0", VA = "0x186B1B3D0")]
	private static void AFIGNFNPEAH(KOOHKCDANNN BCDEBAAMJOP, int HHPOMGOJMHG, byte[] HJPNEGDINAC, int CEEIODMDPNA, [Out] KOOHKCDANNN JGOHJOJCDDB, [Out] int ABFBLGMPDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B6C0", Offset = "0x6B1A8C0", VA = "0x186B1B6C0")]
	private static ulong AJBDJHEBIDO(KOOHKCDANNN BCDEBAAMJOP, [Out] int PKCKMAEPMEI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BD90", Offset = "0x6B1AF90", VA = "0x186B1BD90")]
	private static void LJAMIMCPFFC(KOOHKCDANNN BCDEBAAMJOP, [Out] DFDDKKHOBCC HCIDHCBMOPD, [Out] int KMMOBPLFEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BED0", Offset = "0x6B1B0D0", VA = "0x186B1BED0")]
	private static bool LPKKOEJPDAP(KOOHKCDANNN JGOHJOJCDDB, int HHPOMGOJMHG, [Out] double HCIDHCBMOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B150", Offset = "0x6B1A350", VA = "0x186B1B150")]
	private static DFDDKKHOBCC AADPAHBDHME(int HHPOMGOJMHG)
	{
		return default(DFDDKKHOBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C3B0", Offset = "0x6B1B5B0", VA = "0x186B1C3B0")]
	private static bool NNAEHPJGEMB(KOOHKCDANNN BCDEBAAMJOP, int HHPOMGOJMHG, [Out] double HCIDHCBMOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BB90", Offset = "0x6B1AD90", VA = "0x186B1BB90")]
	private static bool GFKAMKPMMDF(KOOHKCDANNN JGOHJOJCDDB, int HHPOMGOJMHG, [Out] double KEDGJGEOJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C290", Offset = "0x6B1B490", VA = "0x186B1C290")]
	public static double? NJEOKLGNHGG(KOOHKCDANNN BCDEBAAMJOP, int HHPOMGOJMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B830", Offset = "0x6B1AA30", VA = "0x186B1B830")]
	public static float? DEJLGLONHEA(KOOHKCDANNN BCDEBAAMJOP, int HHPOMGOJMHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct CPOJPEFIKAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] BCDEBAAMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int BJPGLMJPACN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE10", Offset = "0x6B1C010", VA = "0x186B1CE10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1902280", Offset = "0x1901480", VA = "0x181902280")]
	public CPOJPEFIKAM(byte[] BCDEBAAMJOP, int BJPGLMJPACN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE00", Offset = "0x6B1C000", VA = "0x186B1CE00")]
	public static CPOJPEFIKAM CIOICKGFNHP(CPOJPEFIKAM KNKOEEEKHDK)
	{
		return default(CPOJPEFIKAM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CEF0", Offset = "0x6B1C0F0", VA = "0x186B1CEF0")]
	public static CPOJPEFIKAM MBJPJBDPKJP(CPOJPEFIKAM KNKOEEEKHDK, int HHOELNLHIEN)
	{
		return default(CPOJPEFIKAM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE40", Offset = "0x6B1C040", VA = "0x186B1CE40")]
	public static int HKGOFCKCKJJ(CPOJPEFIKAM EFLJLNCMHDD, CPOJPEFIKAM DJDKOLONKNI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CDF0", Offset = "0x6B1BFF0", VA = "0x186B1CDF0")]
	public static bool AIPCENMEJFE(CPOJPEFIKAM EFLJLNCMHDD, CPOJPEFIKAM DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CEB0", Offset = "0x6B1C0B0", VA = "0x186B1CEB0")]
	public static bool KEIKIALHENC(CPOJPEFIKAM EFLJLNCMHDD, CPOJPEFIKAM DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CDC0", Offset = "0x6B1BFC0", VA = "0x186B1CDC0")]
	public static bool AIPCENMEJFE(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CEC0", Offset = "0x6B1C0C0", VA = "0x186B1CEC0")]
	public static bool KEIKIALHENC(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CEC0", Offset = "0x6B1C0C0", VA = "0x186B1CEC0")]
	public static bool KEIKIALHENC(CPOJPEFIKAM EFLJLNCMHDD, byte DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CD90", Offset = "0x6B1BF90", VA = "0x186B1CD90")]
	public static bool AAHEHJLFKKD(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CF40", Offset = "0x6B1C140", VA = "0x186B1CF40")]
	public static bool NLCOBONFENC(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE50", Offset = "0x6B1C050", VA = "0x186B1CE50")]
	public static bool IOJMJLOPDNE(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE80", Offset = "0x6B1C080", VA = "0x186B1CE80")]
	public static bool JKCKFAAOGBA(CPOJPEFIKAM EFLJLNCMHDD, char DJDKOLONKNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class PEEEAKNOEBG
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] OHKIAJGGJDM;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] JPFKHHJGGME;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] JCNMDGFPILD;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] KODHHOHGPHE;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] GMDGEBPNOPM;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int LODEFLOCAIB;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] CCJIAPIEMNC;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int ILIDBJLMLGI;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E3C0", Offset = "0x6B2D5C0", VA = "0x186B2E3C0")]
	private static byte[] POIFEOCODFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E1E0", Offset = "0x6B2D3E0", VA = "0x186B2E1E0")]
	private static byte[] KDBCLGBJELF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D1A0", Offset = "0x6B2C3A0", VA = "0x186B2D1A0")]
	public static double GCDMKCGPBHB(byte[] BCDEBAAMJOP, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E310", Offset = "0x6B2D510", VA = "0x186B2E310")]
	public static float OCKPHEBIOOG(byte[] BCDEBAAMJOP, int BJPGLMJPACN, [Out] int EBDGNIKNKAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CDA0", Offset = "0x6B2BFA0", VA = "0x186B2CDA0")]
	private static bool ADMLFNCHGFM(int KPEEHKEJDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CED0", Offset = "0x6B2C0D0", VA = "0x186B2CED0")]
	private static bool DLHGCNJJGAG(CPOJPEFIKAM EKJLIEFFPDC, CPOJPEFIKAM KOILIPEDBEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D0D0", Offset = "0x6B2C2D0", VA = "0x186B2D0D0")]
	private static bool EABJDNBKMDP(CPOJPEFIKAM EKJLIEFFPDC, CPOJPEFIKAM KOILIPEDBEG, byte[] MMFCPJBBHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E2C0", Offset = "0x6B2D4C0", VA = "0x186B2E2C0")]
	private static bool LDAMMNHPDDH(CPOJPEFIKAM NJJIKCOKDKD, byte[] ENONAODCGNA, int BJPGLMJPACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D0B0", Offset = "0x6B2C2B0", VA = "0x186B2D0B0")]
	private static double DONJFGLPNGC(bool GABFNCFJJDA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D250", Offset = "0x6B2C450", VA = "0x186B2D250")]
	private static double IKKHCEEDPEI(CPOJPEFIKAM CCAOJBHBKKC, int HHOELNLHIEN, bool BDKKLBACOLE, [Out] int CIJIIKIPHCC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class BFHJCHGODNF<T> : IFDPBPAOPOC<T[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly JIHGNJAIIGM<T> JDHOGMMGNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly IGNCDIEHDLP FMLEBKKGGML;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x37DF480", Offset = "0x37DE680", VA = "0x1837DF480")]
	public BFHJCHGODNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
	public BFHJCHGODNF(IGNCDIEHDLP FMLEBKKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4897560", Offset = "0x4896760", VA = "0x184897560", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x48971B0", Offset = "0x48963B0", VA = "0x1848971B0", Slot = "5")]
	public T[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class ODDAIMPMDPP<T> : IFDPBPAOPOC<ArraySegment<T>>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly JIHGNJAIIGM<T> JDHOGMMGNFL;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4133B70", Offset = "0x4132D70", VA = "0x184133B70", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ArraySegment<T> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4133770", Offset = "0x4132970", VA = "0x184133770", Slot = "5")]
	public ArraySegment<T> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class FDCBGIPABJH<T> : IFDPBPAOPOC<List<T>>, BPIGAGDGECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly IGNCDIEHDLP FMLEBKKGGML;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x37DF480", Offset = "0x37DE680", VA = "0x1837DF480")]
	public FDCBGIPABJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
	public FDCBGIPABJH(IGNCDIEHDLP FMLEBKKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x37DE410", Offset = "0x37DD610", VA = "0x1837DE410", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, List<T> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x37DD920", Offset = "0x37DCB20", VA = "0x1837DD920", Slot = "5")]
	public List<T> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class JBGDGCJIJJH<TElement, TIntermediate, TEnumerator, TCollection> : IFDPBPAOPOC<TCollection>, BPIGAGDGECE where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3BF91B0", Offset = "0x3BF83B0", VA = "0x183BF91B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, TCollection NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7B40", Offset = "0x3BF6D40", VA = "0x183BF7B40", Slot = "5")]
	public TCollection LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DLEBDPDLJCN(TCollection GBHPBJPAFFB);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate LAFNMEJJDLL();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OEOPOJPHCNL(TIntermediate JOLHBAIGFNI, int HMFNCGHECPG, TElement NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection IBGEGAABELB(TIntermediate MJAECBJKKCH);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected JBGDGCJIJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class MNLCOHAKAPK<TElement, TIntermediate, TCollection> : JBGDGCJIJJH<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D760", Offset = "0x3F9C960", VA = "0x183F9D760", Slot = "6")]
	protected override IEnumerator<TElement> DLEBDPDLJCN(TCollection GBHPBJPAFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x343F700", Offset = "0x343E900", VA = "0x18343F700")]
	protected MNLCOHAKAPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class FHIHPDLEHJE<TElement, TCollection> : MNLCOHAKAPK<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected sealed override TCollection IBGEGAABELB(TCollection MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class GKGCHDCHPDB<TElement, TCollection> : FHIHPDLEHJE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x38C24C0", Offset = "0x38C16C0", VA = "0x1838C24C0", Slot = "7")]
	protected override TCollection LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x38C24E0", Offset = "0x38C16E0", VA = "0x1838C24E0", Slot = "8")]
	protected override void OEOPOJPHCNL(TCollection JOLHBAIGFNI, int HMFNCGHECPG, TElement NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class POJKOPOBGAH<T> : JBGDGCJIJJH<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348DA50", VA = "0x18348E850", Slot = "8")]
	protected override void OEOPOJPHCNL(LinkedList<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override LinkedList<T> IBGEGAABELB(LinkedList<T> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override LinkedList<T> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3D915D0", Offset = "0x3D907D0", VA = "0x183D915D0", Slot = "6")]
	protected override LinkedList<T>.Enumerator DLEBDPDLJCN(LinkedList<T> GBHPBJPAFFB)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class INCFNDKMMLG<T> : JBGDGCJIJJH<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348DA50", VA = "0x18348E850", Slot = "8")]
	protected override void OEOPOJPHCNL(Queue<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override Queue<T> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3A5ED90", Offset = "0x3A5DF90", VA = "0x183A5ED90", Slot = "6")]
	protected override Queue<T>.Enumerator DLEBDPDLJCN(Queue<T> GBHPBJPAFFB)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override Queue<T> IBGEGAABELB(Queue<T> MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class IIIPBOODPJA<T> : JBGDGCJIJJH<T, AONGOPAAACD<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE00", Offset = "0x38DD000", VA = "0x1838DDE00", Slot = "8")]
	protected override void OEOPOJPHCNL(AONGOPAAACD<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x38DDDB0", Offset = "0x38DCFB0", VA = "0x1838DDDB0", Slot = "7")]
	protected override AONGOPAAACD<T> LAFNMEJJDLL()
	{
		return default(AONGOPAAACD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3A40320", Offset = "0x3A3F520", VA = "0x183A40320", Slot = "6")]
	protected override Stack<T>.Enumerator DLEBDPDLJCN(Stack<T> GBHPBJPAFFB)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3A40380", Offset = "0x3A3F580", VA = "0x183A40380", Slot = "9")]
	protected override Stack<T> IBGEGAABELB(AONGOPAAACD<T> MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class KGDICNLDKLE<T> : JBGDGCJIJJH<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348DA50", VA = "0x18348E850", Slot = "8")]
	protected override void OEOPOJPHCNL(HashSet<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override HashSet<T> IBGEGAABELB(HashSet<T> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override HashSet<T> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3A5ED90", Offset = "0x3A5DF90", VA = "0x183A5ED90", Slot = "6")]
	protected override HashSet<T>.Enumerator DLEBDPDLJCN(HashSet<T> GBHPBJPAFFB)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class MHPKAHBDKGA<T> : MNLCOHAKAPK<T, AONGOPAAACD<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE00", Offset = "0x38DD000", VA = "0x1838DDE00", Slot = "8")]
	protected override void OEOPOJPHCNL(AONGOPAAACD<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E460", Offset = "0x3F5D660", VA = "0x183F5E460", Slot = "9")]
	protected override ReadOnlyCollection<T> IBGEGAABELB(AONGOPAAACD<T> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E4F0", Offset = "0x3F5D6F0", VA = "0x183F5E4F0", Slot = "7")]
	protected override AONGOPAAACD<T> LAFNMEJJDLL()
	{
		return default(AONGOPAAACD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class HAAKLILOOAB<T> : MNLCOHAKAPK<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348DA50", VA = "0x18348E850", Slot = "8")]
	protected override void OEOPOJPHCNL(List<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override List<T> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override IList<T> IBGEGAABELB(List<T> MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class EMBHJMHBIIL<T> : MNLCOHAKAPK<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x348E850", Offset = "0x348DA50", VA = "0x18348E850", Slot = "8")]
	protected override void OEOPOJPHCNL(List<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override List<T> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override ICollection<T> IBGEGAABELB(List<T> MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class CHPMIKFMKAE<T> : MNLCOHAKAPK<T, AONGOPAAACD<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE00", Offset = "0x38DD000", VA = "0x1838DDE00", Slot = "8")]
	protected override void OEOPOJPHCNL(AONGOPAAACD<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x38DDDB0", Offset = "0x38DCFB0", VA = "0x1838DDDB0", Slot = "7")]
	protected override AONGOPAAACD<T> LAFNMEJJDLL()
	{
		return default(AONGOPAAACD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x4C32720", Offset = "0x4C31920", VA = "0x184C32720", Slot = "9")]
	protected override IEnumerable<T> IBGEGAABELB(AONGOPAAACD<T> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x344D480", Offset = "0x344C680", VA = "0x18344D480")]
	public CHPMIKFMKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class PKNHCGAEKKI<TKey, TElement> : IFDPBPAOPOC<IGrouping<TKey, TElement>>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4275120", Offset = "0x4274320", VA = "0x184275120", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, IGrouping<TKey, TElement> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4274E30", Offset = "0x4274030", VA = "0x184274E30", Slot = "5")]
	public IGrouping<TKey, TElement> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BCDECJHAFAI<TKey, TElement> : IFDPBPAOPOC<ILookup<TKey, TElement>>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x4891920", Offset = "0x4890B20", VA = "0x184891920", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ILookup<TKey, TElement> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x48915E0", Offset = "0x48907E0", VA = "0x1848915E0", Slot = "5")]
	public ILookup<TKey, TElement> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class PFIMOHPNLKA<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey GOBGGNLGONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> HGPCNIDKMCF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey OGJDOBGGLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public PFIMOHPNLKA(TKey GOBGGNLGONA, IEnumerable<TElement> HGPCNIDKMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x426B610", Offset = "0x426A810", VA = "0x18426B610", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x34EEA30", Offset = "0x34EDC30", VA = "0x1834EEA30", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class NNCKNKOAPLO<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> MCDADHAFDLJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3815B40", Offset = "0x3814D40", VA = "0x183815B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public NNCKNKOAPLO(Dictionary<TKey, IGrouping<TKey, TElement>> MCDADHAFDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3A36130", Offset = "0x3A35330", VA = "0x183A36130", Slot = "5")]
	public bool Contains(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x407FC70", Offset = "0x407EE70", VA = "0x18407FC70", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x407FC70", Offset = "0x407EE70", VA = "0x18407FC70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class OLILOHJOJNN<T> : IFDPBPAOPOC<T>, BPIGAGDGECE where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x41B2A30", Offset = "0x41B1C30", VA = "0x1841B2A30", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x41B27B0", Offset = "0x41B19B0", VA = "0x1841B27B0", Slot = "5")]
	public T LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OLILOHJOJNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GECDIBHOGDE : IFDPBPAOPOC<IEnumerable>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly IFDPBPAOPOC<IEnumerable> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6B34430", Offset = "0x6B33630", VA = "0x186B34430", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, IEnumerable NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6B341E0", Offset = "0x6B333E0", VA = "0x186B341E0", Slot = "5")]
	public IEnumerable LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GECDIBHOGDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class CLKJIEDNJBO : IFDPBPAOPOC<ICollection>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly IFDPBPAOPOC<ICollection> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6B30ED0", Offset = "0x6B300D0", VA = "0x186B30ED0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ICollection NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6B30C80", Offset = "0x6B2FE80", VA = "0x186B30C80", Slot = "5")]
	public ICollection LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CLKJIEDNJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MFKLDFFNBBA : IFDPBPAOPOC<IList>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly IFDPBPAOPOC<IList> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AA10", Offset = "0x6B39C10", VA = "0x186B3AA10", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, IList NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A7C0", Offset = "0x6B399C0", VA = "0x186B3A7C0", Slot = "5")]
	public IList LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MFKLDFFNBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AGALECGJGFD<T> : MNLCOHAKAPK<T, AONGOPAAACD<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE20", Offset = "0x38DD020", VA = "0x1838DDE20", Slot = "8")]
	protected override void OEOPOJPHCNL(AONGOPAAACD<T> JOLHBAIGFNI, int HMFNCGHECPG, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x38DDDB0", Offset = "0x38DCFB0", VA = "0x1838DDDB0", Slot = "7")]
	protected override AONGOPAAACD<T> LAFNMEJJDLL()
	{
		return default(AONGOPAAACD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x38DDD60", Offset = "0x38DCF60", VA = "0x1838DDD60", Slot = "9")]
	protected override IReadOnlyList<T> IBGEGAABELB(AONGOPAAACD<T> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x344CDD0", Offset = "0x344BFD0", VA = "0x18344CDD0")]
	public AGALECGJGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class CEOIBJKAMKF
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FAA0", Offset = "0x6B2ECA0", VA = "0x186B2FAA0")]
	public static DateTime JHKILJMFNBI(DateTime BIDMMBNJKHH)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class HHPHDIPFCBD : IFDPBPAOPOC<DateTime>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly IFDPBPAOPOC<DateTime> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6B35C10", Offset = "0x6B34E10", VA = "0x186B35C10", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, DateTime NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6B34F00", Offset = "0x6B34100", VA = "0x186B34F00", Slot = "5")]
	public DateTime LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HHPHDIPFCBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class IHDPOKFOOLG : IFDPBPAOPOC<DateTimeOffset>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly IFDPBPAOPOC<DateTimeOffset> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6B38480", Offset = "0x6B37680", VA = "0x186B38480", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, DateTimeOffset NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6B37860", Offset = "0x6B36A60", VA = "0x186B37860", Slot = "5")]
	public DateTimeOffset LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public IHDPOKFOOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class OCCAEBCBKNN : IFDPBPAOPOC<TimeSpan>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly IFDPBPAOPOC<TimeSpan> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] ELPAFMMBJAP;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E640", Offset = "0x6B3D840", VA = "0x186B3E640", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, TimeSpan NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DD30", Offset = "0x6B3CF30", VA = "0x186B3DD30", Slot = "5")]
	public TimeSpan LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OCCAEBCBKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class AKCLLIJFKKE<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : IFDPBPAOPOC<TDictionary>, BPIGAGDGECE where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BFA0", Offset = "0x3A0B1A0", VA = "0x183A0BFA0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, TDictionary NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A0A0", Offset = "0x3A092A0", VA = "0x183A0A0A0", Slot = "5")]
	public TDictionary LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator DLEBDPDLJCN(TDictionary GBHPBJPAFFB);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate LAFNMEJJDLL();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OEOPOJPHCNL(TIntermediate JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary IBGEGAABELB(TIntermediate MJAECBJKKCH);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected AKCLLIJFKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class NMLPLJAOJAE<TKey, TValue, TIntermediate, TDictionary> : AKCLLIJFKKE<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D760", Offset = "0x3F9C960", VA = "0x183F9D760", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> DLEBDPDLJCN(TDictionary GBHPBJPAFFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class PCHLPKMLBNM<TKey, TValue, TDictionary> : NMLPLJAOJAE<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override TDictionary IBGEGAABELB(TDictionary MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class LMHLAODHDJM<TKey, TValue> : AKCLLIJFKKE<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3D91780", Offset = "0x3D90980", VA = "0x183D91780", Slot = "8")]
	protected override void OEOPOJPHCNL(Dictionary<TKey, TValue> JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override Dictionary<TKey, TValue> IBGEGAABELB(Dictionary<TKey, TValue> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3D91630", Offset = "0x3D90830", VA = "0x183D91630", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator DLEBDPDLJCN(Dictionary<TKey, TValue> GBHPBJPAFFB)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x343EA00", Offset = "0x343DC00", VA = "0x18343EA00")]
	public LMHLAODHDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class DHPAGBHFEHA<TKey, TValue, TDictionary> : PCHLPKMLBNM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5117A60", Offset = "0x5116C60", VA = "0x185117A60", Slot = "8")]
	protected override void OEOPOJPHCNL(TDictionary JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x327DF30", Offset = "0x327D130", VA = "0x18327DF30", Slot = "7")]
	protected override TDictionary LAFNMEJJDLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CGKMGEDLCDM<TKey, TValue> : NMLPLJAOJAE<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE51F0", Offset = "0x3BE43F0", VA = "0x183BE51F0", Slot = "8")]
	protected override void OEOPOJPHCNL(Dictionary<TKey, TValue> JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override Dictionary<TKey, TValue> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override IDictionary<TKey, TValue> IBGEGAABELB(Dictionary<TKey, TValue> MJAECBJKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class OOEINMLKJHP<TKey, TValue> : PCHLPKMLBNM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE51F0", Offset = "0x3BE43F0", VA = "0x183BE51F0", Slot = "8")]
	protected override void OEOPOJPHCNL(SortedList<TKey, TValue> JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override SortedList<TKey, TValue> LAFNMEJJDLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class JACDEJCJIDL<TKey, TValue> : AKCLLIJFKKE<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3BE51F0", Offset = "0x3BE43F0", VA = "0x183BE51F0", Slot = "8")]
	protected override void OEOPOJPHCNL(SortedDictionary<TKey, TValue> JOLHBAIGFNI, int HMFNCGHECPG, TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> IBGEGAABELB(SortedDictionary<TKey, TValue> MJAECBJKKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x348E7E0", Offset = "0x348D9E0", VA = "0x18348E7E0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> LAFNMEJJDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5190", Offset = "0x3BE4390", VA = "0x183BE5190", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator DLEBDPDLJCN(SortedDictionary<TKey, TValue> GBHPBJPAFFB)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class MBOINHLKPAI<T> : IFDPBPAOPOC<T>, BPIGAGDGECE where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3F48950", Offset = "0x3F47B50", VA = "0x183F48950", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3F486B0", Offset = "0x3F478B0", VA = "0x183F486B0", Slot = "5")]
	public T LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MBOINHLKPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class EEKEBBJPMND : IFDPBPAOPOC<IDictionary>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly IFDPBPAOPOC<IDictionary> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6B321D0", Offset = "0x6B313D0", VA = "0x186B321D0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, IDictionary NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6B31FA0", Offset = "0x6B311A0", VA = "0x186B31FA0", Slot = "5")]
	public IDictionary LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EEKEBBJPMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class NHCBHGKHANI : IFDPBPAOPOC<object>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void KBKOMAAFDLG(object DLGEGFCJCDH, JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly IAFLOKKLFCN<KeyValuePair<object, KBKOMAAFDLG>> LBBDABGKLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly KDHJEPEDNOH[] CHKPOPHCIGP;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D670", Offset = "0x6B3C870", VA = "0x186B3D670")]
	public NHCBHGKHANI(params KDHJEPEDNOH[] CHKPOPHCIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CCB0", Offset = "0x6B3BEB0", VA = "0x186B3CCB0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CC20", Offset = "0x6B3BE20", VA = "0x186B3CC20", Slot = "5")]
	public object LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class CJMPJOHOEGO
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FB60", Offset = "0x6B2ED60", VA = "0x186B2FB60")]
	public static object CCLPBAKFJIB(Type FLPJMDMACMC, [Out] bool MIABONKDNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6B303F0", Offset = "0x6B2F5F0", VA = "0x186B303F0")]
	public static object GLPECHCKAIB(Type FLPJMDMACMC, [Out] bool MIABONKDNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class ODJGECCGAEF<T> : IFDPBPAOPOC<T>, BPIGAGDGECE, OHENOILEMIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class LNGFEKFGPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LNGFEKFGPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3D93F60", Offset = "0x3D93160", VA = "0x183D93F60")]
		internal bool JMBIABHLLMG(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class IHCHGMOGLJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IHCHGMOGLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F6F0", Offset = "0x3A3E8F0", VA = "0x183A3F6F0")]
		internal bool CGOMCPHOJBM(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class FHNGJFNJBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public INOJACEJDDN<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FHNGJFNJBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x37FFC30", Offset = "0x37FEE30", VA = "0x1837FFC30")]
		internal void ENJHKHPOPJK(JNDOKAMOCLB writer, T value, KDHJEPEDNOH _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class MHBPBHBBBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public PLLNKLKJLNI<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public MHBPBHBBBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D160", Offset = "0x3F5C360", VA = "0x183F5D160")]
		internal T INHKBEKIHOM(NABNPJBAMMM reader, KDHJEPEDNOH _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly EENEOLFAKJA<T> MKCCMHPKHMA;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> EJFJEMFJGFB;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly INOJACEJDDN<T> CPEOGOMBHEK;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly PLLNKLKJLNI<T> OINGJDGBMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool CGKHKPOGLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly INOJACEJDDN<T> NFNNMAIEBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly PLLNKLKJLNI<T> PMFALCBLJHB;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x414FFA0", Offset = "0x414F1A0", VA = "0x18414FFA0")]
	static ODJGECCGAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x4152350", Offset = "0x4151550", VA = "0x184152350")]
	public ODJGECCGAEF(bool CGKHKPOGLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x413BAB0", Offset = "0x413ACB0", VA = "0x18413BAB0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x4136F60", Offset = "0x4136160", VA = "0x184136F60", Slot = "5")]
	public T LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4134570", Offset = "0x4133770", VA = "0x184134570", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, T NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4135FD0", Offset = "0x41351D0", VA = "0x184135FD0", Slot = "7")]
	public T KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class NADINPEPIGC<T> : IFDPBPAOPOC<T[,]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FE42B0", Offset = "0x3FE34B0", VA = "0x183FE42B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T[,] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3FA0", Offset = "0x3FE31A0", VA = "0x183FE3FA0", Slot = "5")]
	public T[,] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NADINPEPIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class MDOLIOLLPPN<T> : IFDPBPAOPOC<T[,,]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F599A0", Offset = "0x3F58BA0", VA = "0x183F599A0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T[,,] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F59590", Offset = "0x3F58790", VA = "0x183F59590", Slot = "5")]
	public T[,,] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MDOLIOLLPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class EGNMDOHGNGM<T> : IFDPBPAOPOC<T[,,,]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x3478B00", Offset = "0x3477D00", VA = "0x183478B00", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T[,,,] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x34785D0", Offset = "0x34777D0", VA = "0x1834785D0", Slot = "5")]
	public T[,,,] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EGNMDOHGNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class LIMPPMPLGAH<T> : IFDPBPAOPOC<T?>, BPIGAGDGECE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DF80", Offset = "0x3D6D180", VA = "0x183D6DF80", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DC60", Offset = "0x3D6CE60", VA = "0x183D6DC60", Slot = "5")]
	public T? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LIMPPMPLGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class KEEDBKAOKIG<T> : IFDPBPAOPOC<T?>, BPIGAGDGECE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly IFDPBPAOPOC<T> IDFFFCBJHMG;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public KEEDBKAOKIG(IFDPBPAOPOC<T> IDFFFCBJHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C70D30", Offset = "0x3C6FF30", VA = "0x183C70D30", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, T? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C70560", Offset = "0x3C6F760", VA = "0x183C70560", Slot = "5")]
	public T? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class MHBPAHODNPI : IFDPBPAOPOC<sbyte>, BPIGAGDGECE, OHENOILEMIG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly MHBPAHODNPI CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AF30", Offset = "0x6B3A130", VA = "0x186B3AF30", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, sbyte NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AEE0", Offset = "0x6B3A0E0", VA = "0x186B3AEE0", Slot = "5")]
	public sbyte LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ADB0", Offset = "0x6B39FB0", VA = "0x186B3ADB0", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, sbyte NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AE20", Offset = "0x6B3A020", VA = "0x186B3AE20", Slot = "7")]
	public sbyte KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MHBPAHODNPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class ADOHLGDEALP : IFDPBPAOPOC<sbyte?>, BPIGAGDGECE, OHENOILEMIG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly ADOHLGDEALP CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EF30", Offset = "0x6B2E130", VA = "0x186B2EF30", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, sbyte? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EE80", Offset = "0x6B2E080", VA = "0x186B2EE80", Slot = "5")]
	public sbyte? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2ECA0", Offset = "0x6B2DEA0", VA = "0x186B2ECA0", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, sbyte? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2ED60", Offset = "0x6B2DF60", VA = "0x186B2ED60", Slot = "7")]
	public sbyte? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public ADOHLGDEALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class FMJCCMOFDIE : IFDPBPAOPOC<sbyte[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly FMJCCMOFDIE CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B33770", Offset = "0x6B32970", VA = "0x186B33770", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, sbyte[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B335E0", Offset = "0x6B327E0", VA = "0x186B335E0", Slot = "5")]
	public sbyte[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FMJCCMOFDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class NOGPJDOMAPA : IFDPBPAOPOC<short>, BPIGAGDGECE, OHENOILEMIG<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly NOGPJDOMAPA CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DC60", Offset = "0x6B3CE60", VA = "0x186B3DC60", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, short NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DC10", Offset = "0x6B3CE10", VA = "0x186B3DC10", Slot = "5")]
	public short LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DAE0", Offset = "0x6B3CCE0", VA = "0x186B3DAE0", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, short NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DB50", Offset = "0x6B3CD50", VA = "0x186B3DB50", Slot = "7")]
	public short KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NOGPJDOMAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class EMHKMMLFPLF : IFDPBPAOPOC<short?>, BPIGAGDGECE, OHENOILEMIG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly EMHKMMLFPLF CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B332C0", Offset = "0x6B324C0", VA = "0x186B332C0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, short? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B33210", Offset = "0x6B32410", VA = "0x186B33210", Slot = "5")]
	public short? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B33030", Offset = "0x6B32230", VA = "0x186B33030", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, short? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B330F0", Offset = "0x6B322F0", VA = "0x186B330F0", Slot = "7")]
	public short? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EMHKMMLFPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class JEBOODKELKM : IFDPBPAOPOC<short[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly JEBOODKELKM CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B397B0", Offset = "0x6B389B0", VA = "0x186B397B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, short[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B39620", Offset = "0x6B38820", VA = "0x186B39620", Slot = "5")]
	public short[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public JEBOODKELKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DLJOBIGMDHO : IFDPBPAOPOC<int>, BPIGAGDGECE, OHENOILEMIG<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly DLJOBIGMDHO CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B31BC0", Offset = "0x6B30DC0", VA = "0x186B31BC0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, int NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B31B70", Offset = "0x6B30D70", VA = "0x186B31B70", Slot = "5")]
	public int LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B31A40", Offset = "0x6B30C40", VA = "0x186B31A40", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, int NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B31AB0", Offset = "0x6B30CB0", VA = "0x186B31AB0", Slot = "7")]
	public int KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DLJOBIGMDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class GHHPIJOBGMD : IFDPBPAOPOC<int?>, BPIGAGDGECE, OHENOILEMIG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly GHHPIJOBGMD CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B349E0", Offset = "0x6B33BE0", VA = "0x186B349E0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, int? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B34930", Offset = "0x6B33B30", VA = "0x186B34930", Slot = "5")]
	public int? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B34750", Offset = "0x6B33950", VA = "0x186B34750", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, int? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B34810", Offset = "0x6B33A10", VA = "0x186B34810", Slot = "7")]
	public int? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GHHPIJOBGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class HKABIDOIPAC : IFDPBPAOPOC<int[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly HKABIDOIPAC CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B36790", Offset = "0x6B35990", VA = "0x186B36790", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, int[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B36600", Offset = "0x6B35800", VA = "0x186B36600", Slot = "5")]
	public int[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HKABIDOIPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class GCHCMGECNIM : IFDPBPAOPOC<long>, BPIGAGDGECE, OHENOILEMIG<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly GCHCMGECNIM CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6B33A90", Offset = "0x6B32C90", VA = "0x186B33A90", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, long NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B33A40", Offset = "0x6B32C40", VA = "0x186B33A40", Slot = "5")]
	public long LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B33910", Offset = "0x6B32B10", VA = "0x186B33910", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, long NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B33980", Offset = "0x6B32B80", VA = "0x186B33980", Slot = "7")]
	public long KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GCHCMGECNIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class DBBAAPGBJOJ : IFDPBPAOPOC<long?>, BPIGAGDGECE, OHENOILEMIG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly DBBAAPGBJOJ CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B31910", Offset = "0x6B30B10", VA = "0x186B31910", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, long? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B31850", Offset = "0x6B30A50", VA = "0x186B31850", Slot = "5")]
	public long? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B31650", Offset = "0x6B30850", VA = "0x186B31650", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, long? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B31710", Offset = "0x6B30910", VA = "0x186B31710", Slot = "7")]
	public long? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DBBAAPGBJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HLALMMMPOFN : IFDPBPAOPOC<long[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HLALMMMPOFN CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B36AC0", Offset = "0x6B35CC0", VA = "0x186B36AC0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, long[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B36930", Offset = "0x6B35B30", VA = "0x186B36930", Slot = "5")]
	public long[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HLALMMMPOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PIEMBAFDHCN : IFDPBPAOPOC<byte>, BPIGAGDGECE, OHENOILEMIG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PIEMBAFDHCN CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F9A0", Offset = "0x6B3EBA0", VA = "0x186B3F9A0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, byte NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F950", Offset = "0x6B3EB50", VA = "0x186B3F950", Slot = "5")]
	public byte LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F820", Offset = "0x6B3EA20", VA = "0x186B3F820", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, byte NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F890", Offset = "0x6B3EA90", VA = "0x186B3F890", Slot = "7")]
	public byte KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public PIEMBAFDHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JOPKIJPEMEL : IFDPBPAOPOC<byte?>, BPIGAGDGECE, OHENOILEMIG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly JOPKIJPEMEL CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B39BE0", Offset = "0x6B38DE0", VA = "0x186B39BE0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, byte? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B39B30", Offset = "0x6B38D30", VA = "0x186B39B30", Slot = "5")]
	public byte? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B39950", Offset = "0x6B38B50", VA = "0x186B39950", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, byte? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B39A10", Offset = "0x6B38C10", VA = "0x186B39A10", Slot = "7")]
	public byte? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public JOPKIJPEMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HEJDKABMDGJ : IFDPBPAOPOC<ushort>, BPIGAGDGECE, OHENOILEMIG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly HEJDKABMDGJ CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6B34E30", Offset = "0x6B34030", VA = "0x186B34E30", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ushort NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6B34DE0", Offset = "0x6B33FE0", VA = "0x186B34DE0", Slot = "5")]
	public ushort LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6B34CB0", Offset = "0x6B33EB0", VA = "0x186B34CB0", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, ushort NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6B34D20", Offset = "0x6B33F20", VA = "0x186B34D20", Slot = "7")]
	public ushort KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HEJDKABMDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class OLMDHIPMGFO : IFDPBPAOPOC<ushort?>, BPIGAGDGECE, OHENOILEMIG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly OLMDHIPMGFO CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F050", Offset = "0x6B3E250", VA = "0x186B3F050", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ushort? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EFA0", Offset = "0x6B3E1A0", VA = "0x186B3EFA0", Slot = "5")]
	public ushort? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EDC0", Offset = "0x6B3DFC0", VA = "0x186B3EDC0", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, ushort? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EE80", Offset = "0x6B3E080", VA = "0x186B3EE80", Slot = "7")]
	public ushort? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OLMDHIPMGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class KLPILJGNCEF : IFDPBPAOPOC<ushort[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly KLPILJGNCEF CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6B39FF0", Offset = "0x6B391F0", VA = "0x186B39FF0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ushort[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6B39E60", Offset = "0x6B39060", VA = "0x186B39E60", Slot = "5")]
	public ushort[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public KLPILJGNCEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class ODHKBEJOOKH : IFDPBPAOPOC<uint>, BPIGAGDGECE, OHENOILEMIG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ODHKBEJOOKH CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ECF0", Offset = "0x6B3DEF0", VA = "0x186B3ECF0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, uint NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ECA0", Offset = "0x6B3DEA0", VA = "0x186B3ECA0", Slot = "5")]
	public uint LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EB70", Offset = "0x6B3DD70", VA = "0x186B3EB70", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, uint NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EBE0", Offset = "0x6B3DDE0", VA = "0x186B3EBE0", Slot = "7")]
	public uint KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public ODHKBEJOOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IOLOCDDEHBJ : IFDPBPAOPOC<uint?>, BPIGAGDGECE, OHENOILEMIG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly IOLOCDDEHBJ CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6B392F0", Offset = "0x6B384F0", VA = "0x186B392F0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, uint? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6B39240", Offset = "0x6B38440", VA = "0x186B39240", Slot = "5")]
	public uint? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6B39060", Offset = "0x6B38260", VA = "0x186B39060", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, uint? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6B39120", Offset = "0x6B38320", VA = "0x186B39120", Slot = "7")]
	public uint? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public IOLOCDDEHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MHEPMCOEMMH : IFDPBPAOPOC<uint[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly MHEPMCOEMMH CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B190", Offset = "0x6B3A390", VA = "0x186B3B190", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, uint[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B000", Offset = "0x6B3A200", VA = "0x186B3B000", Slot = "5")]
	public uint[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MHEPMCOEMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class EEOJNOCABBA : IFDPBPAOPOC<ulong>, BPIGAGDGECE, OHENOILEMIG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly EEOJNOCABBA CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6B328A0", Offset = "0x6B31AA0", VA = "0x186B328A0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ulong NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6B32850", Offset = "0x6B31A50", VA = "0x186B32850", Slot = "5")]
	public ulong LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6B32720", Offset = "0x6B31920", VA = "0x186B32720", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, ulong NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6B32790", Offset = "0x6B31990", VA = "0x186B32790", Slot = "7")]
	public ulong KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EEOJNOCABBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class OOLHHDLMGGM : IFDPBPAOPOC<ulong?>, BPIGAGDGECE, OHENOILEMIG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OOLHHDLMGGM CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F6F0", Offset = "0x6B3E8F0", VA = "0x186B3F6F0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ulong? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F630", Offset = "0x6B3E830", VA = "0x186B3F630", Slot = "5")]
	public ulong? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F430", Offset = "0x6B3E630", VA = "0x186B3F430", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, ulong? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F4F0", Offset = "0x6B3E6F0", VA = "0x186B3F4F0", Slot = "7")]
	public ulong? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OOLHHDLMGGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class ALPOPDKCCPN : IFDPBPAOPOC<ulong[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly ALPOPDKCCPN CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F1F0", Offset = "0x6B2E3F0", VA = "0x186B2F1F0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ulong[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F060", Offset = "0x6B2E260", VA = "0x186B2F060", Slot = "5")]
	public ulong[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public ALPOPDKCCPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class IKKDLEDNKFE : IFDPBPAOPOC<float>, BPIGAGDGECE, OHENOILEMIG<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IKKDLEDNKFE CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6B38D10", Offset = "0x6B37F10", VA = "0x186B38D10", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, float NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6B38CC0", Offset = "0x6B37EC0", VA = "0x186B38CC0", Slot = "5")]
	public float LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6B38B90", Offset = "0x6B37D90", VA = "0x186B38B90", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, float NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6B38C00", Offset = "0x6B37E00", VA = "0x186B38C00", Slot = "7")]
	public float KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public IKKDLEDNKFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NJBPOEADAGK : IFDPBPAOPOC<float?>, BPIGAGDGECE, OHENOILEMIG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NJBPOEADAGK CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D9B0", Offset = "0x6B3CBB0", VA = "0x186B3D9B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, float? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D900", Offset = "0x6B3CB00", VA = "0x186B3D900", Slot = "5")]
	public float? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D720", Offset = "0x6B3C920", VA = "0x186B3D720", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, float? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D7E0", Offset = "0x6B3C9E0", VA = "0x186B3D7E0", Slot = "7")]
	public float? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NJBPOEADAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class GDHOCMHIPKP : IFDPBPAOPOC<float[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly GDHOCMHIPKP CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6B34030", Offset = "0x6B33230", VA = "0x186B34030", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, float[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6B33EA0", Offset = "0x6B330A0", VA = "0x186B33EA0", Slot = "5")]
	public float[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GDHOCMHIPKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class IHCLFEGGKAD : IFDPBPAOPOC<double>, BPIGAGDGECE, OHENOILEMIG<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IHCLFEGGKAD CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6B37790", Offset = "0x6B36990", VA = "0x186B37790", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, double NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6B37740", Offset = "0x6B36940", VA = "0x186B37740", Slot = "5")]
	public double LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6B37610", Offset = "0x6B36810", VA = "0x186B37610", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, double NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6B37680", Offset = "0x6B36880", VA = "0x186B37680", Slot = "7")]
	public double KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public IHCLFEGGKAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class HLIHPKAGEAB : IFDPBPAOPOC<double?>, BPIGAGDGECE, OHENOILEMIG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly HLIHPKAGEAB CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6B36F20", Offset = "0x6B36120", VA = "0x186B36F20", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, double? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6B36E60", Offset = "0x6B36060", VA = "0x186B36E60", Slot = "5")]
	public double? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6B36C60", Offset = "0x6B35E60", VA = "0x186B36C60", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, double? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6B36D20", Offset = "0x6B35F20", VA = "0x186B36D20", Slot = "7")]
	public double? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HLIHPKAGEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class PPPPJFJEEGK : IFDPBPAOPOC<double[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly PPPPJFJEEGK CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FC00", Offset = "0x6B3EE00", VA = "0x186B3FC00", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, double[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FA70", Offset = "0x6B3EC70", VA = "0x186B3FA70", Slot = "5")]
	public double[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public PPPPJFJEEGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class LANHIEOIMKF : IFDPBPAOPOC<bool>, BPIGAGDGECE, OHENOILEMIG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly LANHIEOIMKF CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A310", Offset = "0x6B39510", VA = "0x186B3A310", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, bool NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A2C0", Offset = "0x6B394C0", VA = "0x186B3A2C0", Slot = "5")]
	public bool LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A190", Offset = "0x6B39390", VA = "0x186B3A190", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, bool NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A200", Offset = "0x6B39400", VA = "0x186B3A200", Slot = "7")]
	public bool KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LANHIEOIMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HNKBMJJPBPC : IFDPBPAOPOC<bool?>, BPIGAGDGECE, OHENOILEMIG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly HNKBMJJPBPC CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6B374E0", Offset = "0x6B366E0", VA = "0x186B374E0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, bool? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6B37430", Offset = "0x6B36630", VA = "0x186B37430", Slot = "5")]
	public bool? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6B37250", Offset = "0x6B36450", VA = "0x186B37250", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, bool? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6B37310", Offset = "0x6B36510", VA = "0x186B37310", Slot = "7")]
	public bool? KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HNKBMJJPBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class GDHHIBMDEOL : IFDPBPAOPOC<bool[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly GDHHIBMDEOL CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6B33CF0", Offset = "0x6B32EF0", VA = "0x186B33CF0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, bool[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6B33B60", Offset = "0x6B32D60", VA = "0x186B33B60", Slot = "5")]
	public bool[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GDHHIBMDEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MLEDEKIPMEF : IFDPBPAOPOC<object>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IFDPBPAOPOC<object> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> JGNHKDFHNED;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BB80", Offset = "0x6B3AD80", VA = "0x186B3BB80", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, object NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B740", Offset = "0x6B3A940", VA = "0x186B3B740", Slot = "5")]
	public object LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MLEDEKIPMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BNFOJGKPFDF : IFDPBPAOPOC<byte[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IFDPBPAOPOC<byte[]> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F440", Offset = "0x6B2E640", VA = "0x186B2F440", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, byte[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F390", Offset = "0x6B2E590", VA = "0x186B2F390", Slot = "5")]
	public byte[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public BNFOJGKPFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class ONGKJBICAGK : IFDPBPAOPOC<ArraySegment<byte>>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly IFDPBPAOPOC<ArraySegment<byte>> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F290", Offset = "0x6B3E490", VA = "0x186B3F290", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, ArraySegment<byte> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F180", Offset = "0x6B3E380", VA = "0x186B3F180", Slot = "5")]
	public ArraySegment<byte> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public ONGKJBICAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class CBIECJPMMCO : IFDPBPAOPOC<string>, BPIGAGDGECE, OHENOILEMIG<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly IFDPBPAOPOC<string> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F670", Offset = "0x6B2E870", VA = "0x186B2F670", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, string NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F620", Offset = "0x6B2E820", VA = "0x186B2F620", Slot = "5")]
	public string LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F570", Offset = "0x6B2E770", VA = "0x186B2F570", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, string NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F5D0", Offset = "0x6B2E7D0", VA = "0x186B2F5D0", Slot = "7")]
	public string KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CBIECJPMMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class COEIKEDEAOL : IFDPBPAOPOC<string[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly COEIKEDEAOL CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6B314B0", Offset = "0x6B306B0", VA = "0x186B314B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, string[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6B312E0", Offset = "0x6B304E0", VA = "0x186B312E0", Slot = "5")]
	public string[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public COEIKEDEAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HBDPBGIIJJF : IFDPBPAOPOC<char>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly HBDPBGIIJJF CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B80", Offset = "0x6B33D80", VA = "0x186B34B80", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, char NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B10", Offset = "0x6B33D10", VA = "0x186B34B10", Slot = "5")]
	public char LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HBDPBGIIJJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class INIKCIINJBL : IFDPBPAOPOC<char?>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly INIKCIINJBL CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6B38EF0", Offset = "0x6B380F0", VA = "0x186B38EF0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, char? NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6B38DE0", Offset = "0x6B37FE0", VA = "0x186B38DE0", Slot = "5")]
	public char? LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public INIKCIINJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LECFLHEIJNC : IFDPBPAOPOC<char[]>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly LECFLHEIJNC CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A5A0", Offset = "0x6B397A0", VA = "0x186B3A5A0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, char[] NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A3E0", Offset = "0x6B395E0", VA = "0x186B3A3E0", Slot = "5")]
	public char[] LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LECFLHEIJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class MHGECLNKOKK : IFDPBPAOPOC<Guid>, BPIGAGDGECE, OHENOILEMIG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly IFDPBPAOPOC<Guid> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B5A0", Offset = "0x6B3A7A0", VA = "0x186B3B5A0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, Guid NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B510", Offset = "0x6B3A710", VA = "0x186B3B510", Slot = "5")]
	public Guid LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B330", Offset = "0x6B3A530", VA = "0x186B3B330", Slot = "6")]
	public void JBEMGBONGIE(JNDOKAMOCLB KPDGEKKKOHO, Guid NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B470", Offset = "0x6B3A670", VA = "0x186B3B470", Slot = "7")]
	public Guid KFDNPCDOMOH(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MHGECLNKOKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class EIBMNBKFNLI : IFDPBPAOPOC<decimal>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IFDPBPAOPOC<decimal> CGCFGJJDBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool NMDFNMHJEDL;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x534CAA0", Offset = "0x534BCA0", VA = "0x18534CAA0")]
	public EIBMNBKFNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x187F930", Offset = "0x187EB30", VA = "0x18187F930")]
	public EIBMNBKFNLI(bool NMDFNMHJEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6B32C00", Offset = "0x6B31E00", VA = "0x186B32C00", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, decimal NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6B32970", Offset = "0x6B31B70", VA = "0x186B32970", Slot = "5")]
	public decimal LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class EINFBFMCOAK : IFDPBPAOPOC<Uri>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly IFDPBPAOPOC<Uri> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6B32EE0", Offset = "0x6B320E0", VA = "0x186B32EE0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, Uri NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6B32E20", Offset = "0x6B32020", VA = "0x186B32E20", Slot = "5")]
	public Uri LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EINFBFMCOAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class FMIGEJOFFAL : IFDPBPAOPOC<Version>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly IFDPBPAOPOC<Version> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6B334B0", Offset = "0x6B326B0", VA = "0x186B334B0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, Version NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6B333F0", Offset = "0x6B325F0", VA = "0x186B333F0", Slot = "5")]
	public Version LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FMIGEJOFFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HNFCOJBOEHH<TKey, TValue> : IFDPBPAOPOC<KeyValuePair<TKey, TValue>>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3989C70", Offset = "0x3988E70", VA = "0x183989C70", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, KeyValuePair<TKey, TValue> NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3989960", Offset = "0x3988B60", VA = "0x183989960", Slot = "5")]
	public KeyValuePair<TKey, TValue> LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class HIJNFJFEEII : IFDPBPAOPOC<StringBuilder>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly IFDPBPAOPOC<StringBuilder> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6B364F0", Offset = "0x6B356F0", VA = "0x186B364F0", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, StringBuilder NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6B36430", Offset = "0x6B35630", VA = "0x186B36430", Slot = "5")]
	public StringBuilder LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HIJNFJFEEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class EBNCIBCNDIK : IFDPBPAOPOC<BitArray>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly IFDPBPAOPOC<BitArray> CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6B31E10", Offset = "0x6B31010", VA = "0x186B31E10", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, BitArray NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6B31C90", Offset = "0x6B30E90", VA = "0x186B31C90", Slot = "5")]
	public BitArray LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EBNCIBCNDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CEBLCJJIAHJ : IFDPBPAOPOC<Type>, BPIGAGDGECE
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly CEBLCJJIAHJ CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex OHPEKOPJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool PBEALHBAAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool PCHKNKKHAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool AGPJCMGCEAB;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FA80", Offset = "0x6B2EC80", VA = "0x186B2FA80")]
	public CEBLCJJIAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x60DE530", Offset = "0x60DD730", VA = "0x1860DE530")]
	public CEBLCJJIAHJ(bool PBEALHBAAOM, bool PCHKNKKHAEM, bool AGPJCMGCEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F890", Offset = "0x6B2EA90", VA = "0x186B2F890", Slot = "4")]
	public void OHDBDPJBHPM(JNDOKAMOCLB KPDGEKKKOHO, Type NICEPFIEJED, KDHJEPEDNOH AEDCFAKMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F740", Offset = "0x6B2E940", VA = "0x186B2F740", Slot = "5")]
	public Type LKMADFBDLGL(NABNPJBAMMM CAMFAGAEHOD, KDHJEPEDNOH AEDCFAKMOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class IPKCKCAICGE
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] BLHOEMGECFP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly ECNJGNIHOKK NAALEPHOCGC;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B39420", Offset = "0x6B38620", VA = "0x186B39420")]
	static IPKCKCAICGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class HNHNJGBOING
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] LBAIJLJFPFN;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly ECNJGNIHOKK FFCLIPFGFCD;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B37050", Offset = "0x6B36250", VA = "0x186B37050")]
	static HNHNJGBOING()
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
