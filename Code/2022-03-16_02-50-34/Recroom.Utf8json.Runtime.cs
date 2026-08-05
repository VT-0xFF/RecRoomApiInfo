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
public class CAJAODDKDMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51C480", Offset = "0x51B280", VA = "0x18051C480")]
	public CAJAODDKDMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JHDJIFEFEAC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51C480", Offset = "0x51B280", VA = "0x18051C480")]
	public JHDJIFEFEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HHLAGLOEHLN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51C480", Offset = "0x51B280", VA = "0x18051C480")]
	public HHLAGLOEHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class AFKHMFMJAIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51C480", Offset = "0x51B280", VA = "0x18051C480")]
	public AFKHMFMJAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class HHCOCDKJJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x309EBC0", Offset = "0x309D9C0", VA = "0x18309EBC0")]
	public static bool MLGBHCBENLK(this TypeInfo IDPNMFPNBCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class JBAPALHHLMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LBELGLNIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] IFDNBEAHNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65D790", Offset = "0x65C590", VA = "0x18065D790")]
	public JBAPALHHLMC(Type OFJBEDKHEKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class EPDGBALBOBK : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void GHHKGFJDGHP<T>(ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T JLBKJKEIONG<T>(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH FOKJAANJGMD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BAPLCOKFLEM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MMAJPDOPPIO<T> : BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BJIPLPNBNJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PGNEAEKPJGC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PINCDDMNGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2891940", Offset = "0x2890740", VA = "0x182891940")]
	public static global::MMAJPDOPPIO<T> EMADILJFJFL<T>(this JGMBDHJDMIH FOKJAANJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x417B470", Offset = "0x417A270", VA = "0x18417B470")]
	public static object NDPBCFKBPOB(this JGMBDHJDMIH FOKJAANJGMD, Type IDPNMFPNBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IPLEKBAJNKM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x30AF010", Offset = "0x30ADE10", VA = "0x1830AF010")]
	public IPLEKBAJNKM(string MNIDJMIIGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FMFKHIMMIHK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class HFECLBLCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] FLHEFONBKGE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] OEEENEHKCNE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3320A30", Offset = "0x331F830", VA = "0x183320A30")]
		public static byte[] JIAAMNHPIJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3320AB0", Offset = "0x331F8B0", VA = "0x183320AB0")]
		public static char[] OJLOBCPBJPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> DNJCNMMAGBH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] MGPLMDEIKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] NBHAFAAIDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int HGFCPLJDPAG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GINJMIJMABM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3318A20", Offset = "0x3317820", VA = "0x183318A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3319A10", Offset = "0x3318810", VA = "0x183319A10")]
	public FMFKHIMMIHK(byte[] NBHAFAAIDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3319A20", Offset = "0x3318820", VA = "0x183319A20")]
	public FMFKHIMMIHK(byte[] NBHAFAAIDII, int HGFCPLJDPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3318BD0", Offset = "0x33179D0", VA = "0x183318BD0")]
	private FLGJIIKOJEA MONBDJPNFJL(string KBHKGEFPKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33197B0", Offset = "0x33185B0", VA = "0x1833197B0")]
	private FLGJIIKOJEA PMAOCJMFLGJ(string MNIDJMIIGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3319560", Offset = "0x3318360", VA = "0x183319560")]
	public void OBPGNHNFMFA(int HGFCPLJDPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DD80", VA = "0x18076EF80")]
	public byte[] KLIIHIOJADB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DF260", Offset = "0x7DE060", VA = "0x1807DF260")]
	public int CGKHJNFPCMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3318A40", Offset = "0x3317840", VA = "0x183318A40")]
	public EHFJEBODOPL MNPGIMGBCCK()
	{
		return default(EHFJEBODOPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3317770", Offset = "0x3316570", VA = "0x183317770")]
	public void EHAOAHOILLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3319690", Offset = "0x3318490", VA = "0x183319690")]
	public bool PLKIKKIIHJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3317A10", Offset = "0x3316810", VA = "0x183317A10")]
	public bool FKFJKAFJAMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3316F90", Offset = "0x3315D90", VA = "0x183316F90")]
	public void AGFIBADIHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3319600", Offset = "0x3318400", VA = "0x183319600")]
	public bool PKNCABBDKBG(ref int JPKOENICFPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3317DE0", Offset = "0x3316BE0", VA = "0x183317DE0")]
	public bool HKHNEKMIDJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3319890", Offset = "0x3318690", VA = "0x183319890")]
	public void PNAPMLPEFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3317600", Offset = "0x3316400", VA = "0x183317600")]
	public bool DLPBJBJNIHP(ref int JPKOENICFPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3317A80", Offset = "0x3316880", VA = "0x183317A80")]
	public bool GBFEPNBGAJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3317F80", Offset = "0x3316D80", VA = "0x183317F80")]
	public void JEFGPFEHAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33179A0", Offset = "0x33167A0", VA = "0x1833179A0")]
	public bool FKAPLMGDJHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x33187C0", Offset = "0x33175C0", VA = "0x1833187C0")]
	public void LHCCGIDLFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3318020", Offset = "0x3316E20", VA = "0x183318020")]
	private void KJAAJGIMCBC(out byte[] GEMKNIFPIFA, out int OCCCIECEDNG, out int PBMCCGBOPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x33170F0", Offset = "0x3315EF0", VA = "0x1833170F0")]
	private static int BGLICMOMABM(char OCLDIKFJHHO, char KBBKPHEOPAB, char EACNPFGCNPL, char MEEHFAALDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3318950", Offset = "0x3317750", VA = "0x183318950")]
	private static int MHLMNLDJOGC(char ACPFKFODNNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3317270", Offset = "0x3316070", VA = "0x183317270")]
	public ArraySegment<byte> CLGGPLBGLJE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3317900", Offset = "0x3316700", VA = "0x183317900")]
	public string FJCPLGFPBFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3319570", Offset = "0x3318370", VA = "0x183319570")]
	public string OINBMIJBPOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3317C30", Offset = "0x3316A30", VA = "0x183317C30")]
	public ArraySegment<byte> HDEBEDNFGGP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3317360", Offset = "0x3316160", VA = "0x183317360")]
	public ArraySegment<byte> CNJOLIAMBGB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33173A0", Offset = "0x33161A0", VA = "0x1833173A0")]
	public bool DCJBIIBDGHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3317030", Offset = "0x3315E30", VA = "0x183317030")]
	private static bool BBJHIFEGMME(byte EACNPFGCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33191F0", Offset = "0x3317FF0", VA = "0x1833191F0")]
	private void NEOPJFGIIHM(EHFJEBODOPL BKGLGBGKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33187B0", Offset = "0x33175B0", VA = "0x1833187B0")]
	public void LEMBALIJPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33171A0", Offset = "0x3315FA0", VA = "0x1833171A0")]
	private void CEMLBKHMGBO(int MLNBCHKCPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x33178B0", Offset = "0x33166B0", VA = "0x1833178B0")]
	public sbyte FJCDPKBLICJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3319420", Offset = "0x3318220", VA = "0x183319420")]
	public short NGFMKADNKJE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33193C0", Offset = "0x33181C0", VA = "0x1833193C0")]
	public int NFBEAKFCFGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3317690", Offset = "0x3316490", VA = "0x183317690")]
	public long DMNIAPBHAOA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3317710", Offset = "0x3316510", VA = "0x183317710")]
	public byte EGPJDJCBFBL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33195A0", Offset = "0x33183A0", VA = "0x1833195A0")]
	public ushort PKEFOLNKIFF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3319480", Offset = "0x3318280", VA = "0x183319480")]
	public uint NMABEICNBAI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33194E0", Offset = "0x33182E0", VA = "0x1833194E0")]
	public ulong NNLOFFKEECD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3317AF0", Offset = "0x33168F0", VA = "0x183317AF0")]
	public float GCNAICEECAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3317E50", Offset = "0x3316C50", VA = "0x183317E50")]
	public double IAHCMILMKGJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3318860", Offset = "0x3317660", VA = "0x183318860")]
	public ArraySegment<byte> MGGJDHAPADE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3319070", Offset = "0x3317E70", VA = "0x183319070")]
	private static int NBNLIINCIED(byte[] NBHAFAAIDII, int HGFCPLJDPAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FLGJIIKOJEA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference CCFDNCCKAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FGOPGOEBOED;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AJJLGDACNFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x119D230", Offset = "0x119C030", VA = "0x18119D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JCKLODMPNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B6E10", Offset = "0x5B5C10", VA = "0x1805B6E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3316E50", Offset = "0x3315C50", VA = "0x183316E50")]
	public FLGJIIKOJEA(string MNIDJMIIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3316EC0", Offset = "0x3315CC0", VA = "0x183316EC0")]
	public FLGJIIKOJEA(string MNIDJMIIGBM, byte[] BKEDFKFAHGA, int HGFCPLJDPAG, int FGOPGOEBOED, string EKFEINKMCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AOLAAAPEEFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MHCJFIIMNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void AEDMHFKHJMD(ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object LGNLEOBBJIL(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH FOKJAANJGMD);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class PECDIFPJHLP
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class HOAIFPIPIML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public HOAIFPIPIML()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x3320B40", Offset = "0x331F940", VA = "0x183320B40")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x3320B80", Offset = "0x331F980", VA = "0x183320B80")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, JGMBDHJDMIH, byte[]> KNCNIOBJAHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, JGMBDHJDMIH> FAJPJKLKBHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly AEDMHFKHJMD MCEGBIBKHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, JGMBDHJDMIH, ArraySegment<byte>> HAFICIEIIKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, JGMBDHJDMIH, string> AIKHNHOPLCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, JGMBDHJDMIH, object> HBEGPJIELIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, JGMBDHJDMIH, object> ANAIDLINMCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, JGMBDHJDMIH, object> HKAFBOJGDHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly LGNLEOBBJIL HFEIPMMPIIO;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x33220A0", Offset = "0x3320EA0", VA = "0x1833220A0")]
			public PECDIFPJHLP(Type IDPNMFPNBCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1C6E380", Offset = "0x1C6D180", VA = "0x181C6E380")]
			private static T LCIFOJHOJLN<T>(DynamicMethod GDGNPPDLMFM)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3321EB0", Offset = "0x3320CB0", VA = "0x183321EB0")]
			private static MethodInfo AIKFJFNHEKI(Type IDPNMFPNBCP, string HPAMGGFODJL, Type[] AJGCFLBAFKK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, PECDIFPJHLP> DNPHHDLLGIA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::KNMIMOAILGP<PECDIFPJHLP> LLMCCNDLEKO;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3321DC0", Offset = "0x3320BC0", VA = "0x183321DC0")]
		static MHCJFIIMNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3321AC0", Offset = "0x33208C0", VA = "0x183321AC0")]
		private static PECDIFPJHLP FEPKLAIJEJO(Type IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3321B40", Offset = "0x3320940", VA = "0x183321B40")]
		public static void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3321CB0", Offset = "0x3320AB0", VA = "0x183321CB0")]
		public static void GGGHAECNNDD(Type IDPNMFPNBCP, ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class GPMCLOFLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] FLHEFONBKGE;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x33209B0", Offset = "0x331F7B0", VA = "0x1833209B0")]
		public static byte[] JIAAMNHPIJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JGMBDHJDMIH KIFJNCOAADP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] HHLJMGACBOG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] EAFAFHFNMNC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JGMBDHJDMIH FGKEACJAAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x330C300", Offset = "0x330B100", VA = "0x18330C300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3228D40", Offset = "0x3227B40", VA = "0x183228D40")]
	public static string JKHLKNGKHKL<T>(T KCFMHIDCDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3228BE0", Offset = "0x32279E0", VA = "0x183228BE0")]
	public static string JKHLKNGKHKL<T>(T KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1C559E0", Offset = "0x1C547E0", VA = "0x181C559E0")]
	public static T NMBJEEACLGI<T>(string PLMCJDLPKKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C55910", Offset = "0x1C54710", VA = "0x181C55910")]
	public static T NMBJEEACLGI<T>(string PLMCJDLPKKN, JGMBDHJDMIH FOKJAANJGMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C55A60", Offset = "0x1C54860", VA = "0x181C55A60")]
	public static T NMBJEEACLGI<T>(byte[] NBHAFAAIDII, JGMBDHJDMIH FOKJAANJGMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1C557C0", Offset = "0x1C545C0", VA = "0x181C557C0")]
	public static T NMBJEEACLGI<T>(byte[] NBHAFAAIDII, int HGFCPLJDPAG, JGMBDHJDMIH FOKJAANJGMD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EHFJEBODOPL : byte
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
public struct GGMDNFGBBDM
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FFKEODAHFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] FLHEFONBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int HGFCPLJDPAG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ICDPFOKIGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7DF260", Offset = "0x7DE060", VA = "0x1807DF260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3319560", Offset = "0x3318360", VA = "0x183319560")]
	public void OBPGNHNFMFA(int HGFCPLJDPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x331D570", Offset = "0x331C370", VA = "0x18331D570")]
	public static byte[] FNFGGNDBJJG(string OKGLMAEHPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x331DAB0", Offset = "0x331C8B0", VA = "0x18331DAB0")]
	public static byte[] JCALECOCKMG(string OKGLMAEHPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x331E090", Offset = "0x331CE90", VA = "0x18331E090")]
	public static byte[] OPHBJJAHLCA(string OKGLMAEHPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x331DBE0", Offset = "0x331C9E0", VA = "0x18331DBE0")]
	public static byte[] JGMJELBBBOB(string OKGLMAEHPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xC98030", Offset = "0xC96E30", VA = "0x180C98030")]
	public GGMDNFGBBDM(byte[] DINEJOOEEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x331DD40", Offset = "0x331CB40", VA = "0x18331DD40")]
	public ArraySegment<byte> JIAAMNHPIJF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x331DFE0", Offset = "0x331CDE0", VA = "0x18331DFE0")]
	public byte[] OFPOLMCOCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x331E310", Offset = "0x331D110", VA = "0x18331E310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x331DFA0", Offset = "0x331CDA0", VA = "0x18331DFA0")]
	public void OABALLCMNBO(int PCIKNLHGAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x331D130", Offset = "0x331BF30", VA = "0x18331D130")]
	public void AHLEHNBHFNO(byte[] ADFKGBHGPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x331D0F0", Offset = "0x331BEF0", VA = "0x18331D0F0")]
	public void ABJLNFEEFDF(byte ADFKGBHGPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x331D3D0", Offset = "0x331C1D0", VA = "0x18331D3D0")]
	public void DFPIANIHMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x331D420", Offset = "0x331C220", VA = "0x18331D420")]
	public void DFPJMNJIKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x331DE70", Offset = "0x331CC70", VA = "0x18331DE70")]
	public void KEPEOOILJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x331D4C0", Offset = "0x331C2C0", VA = "0x18331D4C0")]
	public void DJBFCPGLGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x331D470", Offset = "0x331C270", VA = "0x18331D470")]
	public void DGNINJMEJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x331D190", Offset = "0x331BF90", VA = "0x18331D190")]
	public void APIOFOFMJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x331D510", Offset = "0x331C310", VA = "0x18331D510")]
	public void ELOKHLAGLFF(string OKGLMAEHPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x331DF20", Offset = "0x331CD20", VA = "0x18331DF20")]
	public void NKKPMKEGFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x331E240", Offset = "0x331D040", VA = "0x18331E240")]
	public void PFBGODNLNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x331D1E0", Offset = "0x331BFE0", VA = "0x18331D1E0")]
	public void CABBCJLEEOE(bool KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x331DDF0", Offset = "0x331CBF0", VA = "0x18331DDF0")]
	public void JJGNPPBBCAI(float KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x331E1C0", Offset = "0x331CFC0", VA = "0x18331E1C0")]
	public void PCMNFBMMOGL(double KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x331DF70", Offset = "0x331CD70", VA = "0x18331DF70")]
	public void NMFLKOKLEGK(byte KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x331DA80", Offset = "0x331C880", VA = "0x18331DA80")]
	public void IEEKIJGDAJC(ushort KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x331DA50", Offset = "0x331C850", VA = "0x18331DA50")]
	public void GGCOBDLACCK(uint KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x331DFB0", Offset = "0x331CDB0", VA = "0x18331DFB0")]
	public void OABPDOGFOGD(ulong KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x331DEF0", Offset = "0x331CCF0", VA = "0x18331DEF0")]
	public void MHDENPICLCM(sbyte KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x331D650", Offset = "0x331C450", VA = "0x18331D650")]
	public void GDMPLNCMIJN(short KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x331DEC0", Offset = "0x331CCC0", VA = "0x18331DEC0")]
	public void KPMEHGOAFJK(int KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x331E060", Offset = "0x331CE60", VA = "0x18331E060")]
	public void OJDBHJCEACA(long KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x331D680", Offset = "0x331C480", VA = "0x18331D680")]
	public void GEDDLCPDJBG(string KCFMHIDCDCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KHPDIDEEGFD : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class PBCLOJNJEPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3B0ACA0", Offset = "0x3B09AA0", VA = "0x183B0ACA0")]
		static PBCLOJNJEPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private KHPDIDEEGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class OGHDOEPELEH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BABHGPLLDLD;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4176570", Offset = "0x4175370", VA = "0x184176570")]
	static OGHDOEPELEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4176010", Offset = "0x4174E10", VA = "0x184176010")]
	internal static object GNPPGFMJMCE(Type LIIJOLOJJBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DOIICFKMMNP : global::MMAJPDOPPIO<Vector2>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3311B20", Offset = "0x3310920", VA = "0x183311B20")]
	public DOIICFKMMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33116C0", Offset = "0x33104C0", VA = "0x1833116C0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Vector2 KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3311830", Offset = "0x3310630", VA = "0x183311830", Slot = "5")]
	public Vector2 NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FMJPHNDAADE : global::MMAJPDOPPIO<Vector3>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x331A160", Offset = "0x3318F60", VA = "0x18331A160")]
	public FMJPHNDAADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3319C00", Offset = "0x3318A00", VA = "0x183319C00", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Vector3 KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3319E10", Offset = "0x3318C10", VA = "0x183319E10", Slot = "5")]
	public Vector3 NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EIOOIMENFCB : global::MMAJPDOPPIO<Vector4>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3314480", Offset = "0x3313280", VA = "0x183314480")]
	public EIOOIMENFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x330B190", Offset = "0x3309F90", VA = "0x18330B190", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Vector4 KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3314100", Offset = "0x3312F00", VA = "0x183314100", Slot = "5")]
	public Vector4 NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FGNJJELFPNP : global::MMAJPDOPPIO<Quaternion>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3315A90", Offset = "0x3314890", VA = "0x183315A90")]
	public FGNJJELFPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x330B190", Offset = "0x3309F90", VA = "0x18330B190", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Quaternion KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3315710", Offset = "0x3314510", VA = "0x183315710", Slot = "5")]
	public Quaternion NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class AFCOEMBFOAI : global::MMAJPDOPPIO<Color>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x330B780", Offset = "0x330A580", VA = "0x18330B780")]
	public AFCOEMBFOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x330B190", Offset = "0x3309F90", VA = "0x18330B190", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Color KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x330B400", Offset = "0x330A200", VA = "0x18330B400", Slot = "5")]
	public Color NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class DBGGEGKLPBF : global::MMAJPDOPPIO<Bounds>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3310A50", Offset = "0x330F850", VA = "0x183310A50")]
	public DBGGEGKLPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3310350", Offset = "0x330F150", VA = "0x183310350", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Bounds KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3310650", Offset = "0x330F450", VA = "0x183310650", Slot = "5")]
	public Bounds NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FJPNJHKFDGI : global::MMAJPDOPPIO<Rect>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GNOCPDAMICE GLPNAHJJCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HOJKDKBFOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3316800", Offset = "0x3315600", VA = "0x183316800")]
	public FJPNJHKFDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x33161C0", Offset = "0x3314FC0", VA = "0x1833161C0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Rect KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3316450", Offset = "0x3315250", VA = "0x183316450", Slot = "5")]
	public Rect NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class CLDAEBPHGIJ : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class KHGJIOGAMMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D553A0", Offset = "0x3D541A0", VA = "0x183D553A0")]
		static KHGJIOGAMMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private CLDAEBPHGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MAFEOAAMBJJ : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class FAFNBCIMCPA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3B27470", Offset = "0x3B26270", VA = "0x183B27470")]
		static FAFNBCIMCPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class LOPAFHMMLBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> OPMGINGPJEO;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4171FE0", Offset = "0x4170DE0", VA = "0x184171FE0")]
		internal static object GNPPGFMJMCE(Type LIIJOLOJJBP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private MAFEOAAMBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ELLONLFGJHC : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class BANJFGFGKFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x31ADDC0", Offset = "0x31ACBC0", VA = "0x1831ADDC0")]
		static BANJFGFGKFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private ELLONLFGJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JLHCDNDGPDF
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly JGMBDHJDMIH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JGMBDHJDMIH OKKALMLFAHP;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly JGMBDHJDMIH IPOKHELCBFH;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly JGMBDHJDMIH ADAONDMOJEE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly JGMBDHJDMIH DFPCHECLHJF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly JGMBDHJDMIH MGNNCAILCOP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly JGMBDHJDMIH NECOKPCFIIM;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly JGMBDHJDMIH FNHEMAMGJHE;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly JGMBDHJDMIH JNKOMNIKHLG;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly JGMBDHJDMIH JHKPPIMLOHC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly JGMBDHJDMIH HKPJINCDBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly JGMBDHJDMIH FPGJHCLHFNM;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NIIBKKDCJOB
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly JGMBDHJDMIH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly JGMBDHJDMIH GHFJMHHFAEP;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OFOOKBLJDHI
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly JGMBDHJDMIH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly JGMBDHJDMIH OKKALMLFAHP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JGMBDHJDMIH IPOKHELCBFH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly JGMBDHJDMIH ADAONDMOJEE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JGMBDHJDMIH DFPCHECLHJF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly JGMBDHJDMIH MGNNCAILCOP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly JGMBDHJDMIH NECOKPCFIIM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly JGMBDHJDMIH FNHEMAMGJHE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly JGMBDHJDMIH JNKOMNIKHLG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly JGMBDHJDMIH JHKPPIMLOHC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly JGMBDHJDMIH HKPJINCDBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly JGMBDHJDMIH FPGJHCLHFNM;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class GDDCOKAJNFO
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly Dictionary<Type, Type> OPMGINGPJEO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x331A4F0", Offset = "0x33192F0", VA = "0x18331A4F0")]
	internal static object GNPPGFMJMCE(Type LIIJOLOJJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x331A4B0", Offset = "0x33192B0", VA = "0x18331A4B0")]
	private static object EOEJPJKLFEG(Type HDODGKAIEFB, Type[] MCEPLGHHGOM, params object[] AJGCFLBAFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PEHHHNDHJEK : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class KFAJLGJGFOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x31E4DA0", Offset = "0x31E3BA0", VA = "0x1831E4DA0")]
		static KFAJLGJGFOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x417ADD0", Offset = "0x4179BD0", VA = "0x18417ADD0")]
	static PEHHHNDHJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private PEHHHNDHJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GPHOLHKOOCC : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class EGOHJKFHHJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2830BF0", Offset = "0x282F9F0", VA = "0x182830BF0")]
		static EGOHJKFHHJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x309CE10", Offset = "0x309BC10", VA = "0x18309CE10")]
	static GPHOLHKOOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private GPHOLHKOOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class ALDKJCLNEHG : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class EABGENNKNHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1CC5AA0", Offset = "0x1CC48A0", VA = "0x181CC5AA0")]
		static EABGENNKNHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x330C120", Offset = "0x330AF20", VA = "0x18330C120")]
	static ALDKJCLNEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private ALDKJCLNEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class JCAMCJMCFCG : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JLAJGFFAKMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x29A93A0", Offset = "0x29A81A0", VA = "0x1829A93A0")]
		static JLAJGFFAKMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x30AF080", Offset = "0x30ADE80", VA = "0x1830AF080")]
	static JCAMCJMCFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private JCAMCJMCFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ANGGJKCHNEI : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class OMPAGFGNKAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1CCD2D0", Offset = "0x1CCC0D0", VA = "0x181CCD2D0")]
		static OMPAGFGNKAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x330C210", Offset = "0x330B010", VA = "0x18330C210")]
	static ANGGJKCHNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private ANGGJKCHNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class NGKFIFOLEGN : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class BIKIKIDOEGH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DCF0", Offset = "0x3B0CAF0", VA = "0x183B0DCF0")]
		static BIKIKIDOEGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly NCEKONJIBAF KLLBNCFAHHC;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4174BB0", Offset = "0x41739B0", VA = "0x184174BB0")]
	static NGKFIFOLEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private NGKFIFOLEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class HHFLPNDHLAN : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class GABENMLKFNJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x32E6810", Offset = "0x32E5610", VA = "0x1832E6810")]
		static GABENMLKFNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HHFLPNDHLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class BBLPAMMPJJB : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class LFAKCGLNOAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x377C8E0", Offset = "0x377B6E0", VA = "0x18377C8E0")]
		static LFAKCGLNOAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BBLPAMMPJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class PCNFKCJPIGP : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DHICOKCIIHG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x31DE970", Offset = "0x31DD770", VA = "0x1831DE970")]
		static DHICOKCIIHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PCNFKCJPIGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class CBIGMNGONFA : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class PFDNIDOMHFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x31D9440", Offset = "0x31D8240", VA = "0x1831D9440")]
		static PFDNIDOMHFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public CBIGMNGONFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class PDMLPFPGDNN : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PEKILNAMOGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x31F3A20", Offset = "0x31F2820", VA = "0x1831F3A20")]
		static PEKILNAMOGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PDMLPFPGDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class FNJMOGEAHCE : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class LGLCGCDCELL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x344BAA0", Offset = "0x344A8A0", VA = "0x18344BAA0")]
		static LGLCGCDCELL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static readonly Func<string, string> AGDFLMHGNPE;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly bool GGIJLMAOOJC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public FNJMOGEAHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class INOMAPLNJHP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct BDPHEINGEED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public EHGEOGBPIDI IIKNGIHOPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LocalBuilder OKIEHHFAGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LocalBuilder MLINIKKLLKB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class HAIMGKKJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class NLFIPJMNIPE
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo OPHBJJAHLCA;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo JCALECOCKMG;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo JGMJELBBBOB;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo FNFGGNDBJJG;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly MethodInfo PFBGODNLNOI;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo AHLEHNBHFNO;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo KEPEOOILJFC;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo DJBFCPGLGNH;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo DGNINJMEJEK;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x30B3660", Offset = "0x30B2460", VA = "0x1830B3660")]
			static NLFIPJMNIPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class JHCEPAFENPG
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo PLKIKKIIHJI;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo PNAPMLPEFCP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DLPBJBJNIHP;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo OPBFODLFNPL;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo LEMBALIJPAF;

			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo KLIIHIOJADB;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo CGKHJNFPCMF;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x30B2630", Offset = "0x30B1430", VA = "0x1830B2630")]
			static JHCEPAFENPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PBAJILBGCPL
		{
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			internal static readonly MethodInfo LBELGLNIHOG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			internal static readonly MethodInfo IFDNBEAHNLG;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly ConstructorInfo IMDLBJLBGLC;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly MethodInfo EMADILJFJFL;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly ConstructorInfo LOCDOBMFMJL;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly MethodInfo MAAACPKJHKA;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly MethodInfo CMDLNECICGC;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly MethodInfo KHFOMJCFAGB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ANPKHPLLGOE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly MethodInfo NAIDJJGNCPF;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo JKOMHHODAEF;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo EGNNAADOGIE;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo CJGLGBMOCAI;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo NGBEPHIJLCF;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x309CF00", Offset = "0x309BD00", VA = "0x18309CF00")]
		public static MethodInfo GGGHAECNNDD(Type IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x309D2B0", Offset = "0x309C0B0", VA = "0x18309D2B0")]
		public static MethodInfo NMBJEEACLGI(Type IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x309D190", Offset = "0x309BF90", VA = "0x18309D190")]
		public static MethodInfo MEBIBLENMNC(Type IDPNMFPNBCP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AFINGDBOACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Dictionary<EHGEOGBPIDI, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public AFINGDBOACP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NLKEHHAALID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AFINGDBOACP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public NLKEHHAALID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x30B43A0", Offset = "0x30B31A0", VA = "0x1830B43A0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x30B43E0", Offset = "0x30B31E0", VA = "0x1830B43E0")]
		internal bool <BuildType>b__2(int index, EHGEOGBPIDI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class MDBFLFOOOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AFINGDBOACP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public MDBFLFOOOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x30B35C0", Offset = "0x30B23C0", VA = "0x1830B35C0")]
		internal bool <BuildType>b__3(int index, EHGEOGBPIDI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KIOMMMLMPNG
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
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public KIOMMMLMPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x30B33E0", Offset = "0x30B21E0", VA = "0x1830B33E0")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class GJJBJICDHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public GJJBJICDHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x309CDB0", Offset = "0x309BBB0", VA = "0x18309CDB0")]
		internal bool <BuildAnonymousFormatter>b__2(EHGEOGBPIDI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DFMCNOBLHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public KIOMMMLMPNG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public DFMCNOBLHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x309C730", Offset = "0x309B530", VA = "0x18309C730")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x309C740", Offset = "0x309B540", VA = "0x18309C740")]
		internal bool <BuildAnonymousFormatter>b__6(int index, EHGEOGBPIDI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PFODCOAKCKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public KIOMMMLMPNG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public PFODCOAKCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x30B47C0", Offset = "0x30B35C0", VA = "0x1830B47C0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, EHGEOGBPIDI member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CFINPPKIFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public CFINPPKIFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x524CC0", Offset = "0x523AC0", VA = "0x180524CC0")]
		internal Label <BuildSerialize>b__1(EHGEOGBPIDI _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KBNOPAFPMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public BDPHEINGEED[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Func<int, EHGEOGBPIDI, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public BOFCGFBEHAL argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public BOFCGFBEHAL argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public KBNOPAFPMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x30B3130", Offset = "0x30B1F30", VA = "0x1830B3130")]
		internal BDPHEINGEED <BuildDeserialize>b__0(EHGEOGBPIDI item)
		{
			return default(BDPHEINGEED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DGLEGKAMPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public KBNOPAFPMCN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public DGLEGKAMPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x309C8E0", Offset = "0x309B6E0", VA = "0x18309C8E0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x309CB90", Offset = "0x309B990", VA = "0x18309CB90")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FJKKEJBMFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public EHGEOGBPIDI item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public FJKKEJBMFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1B1A180", Offset = "0x1B18F80", VA = "0x181B1A180")]
		internal bool <EmitNewObject>b__0(BDPHEINGEED x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BKPJIBENPLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EHGEOGBPIDI item;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public BKPJIBENPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1B1A180", Offset = "0x1B18F80", VA = "0x181B1A180")]
		internal bool <EmitNewObject>b__2(BDPHEINGEED x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly Regex NLLHOPNGNLJ;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int PHGALAJLMKO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static HashSet<Type> OIDGPPGCJDO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static HashSet<Type> IIBBDCJNFIL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x32344C0", Offset = "0x32332C0", VA = "0x1832344C0")]
	public static object HGJLKFDKLEG<T>(NCEKONJIBAF KLLBNCFAHHC, JGMBDHJDMIH JLKMBMNEPCI, Func<string, string> AGDFLMHGNPE, bool GGIJLMAOOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x25D6870", Offset = "0x25D5670", VA = "0x1825D6870")]
	public static object AHAMECDOAMM<T>(JGMBDHJDMIH JLKMBMNEPCI, Func<string, string> AGDFLMHGNPE, bool GGIJLMAOOJC, bool MGPIJJNCICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x30AC0E0", Offset = "0x30AAEE0", VA = "0x1830AC0E0")]
	private static TypeInfo LNPKHOOKGBG(NCEKONJIBAF KLLBNCFAHHC, Type IDPNMFPNBCP, Func<string, string> AGDFLMHGNPE, bool GGIJLMAOOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x30A87C0", Offset = "0x30A75C0", VA = "0x1830A87C0")]
	public static object FODBKIEKNHK(Type IDPNMFPNBCP, Func<string, string> AGDFLMHGNPE, bool GGIJLMAOOJC, bool MGPIJJNCICH, bool PAJEAFKKDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x30AAD70", Offset = "0x30A9B70", VA = "0x1830AAD70")]
	private static Dictionary<EHGEOGBPIDI, FieldInfo> IICHPMPCJMI(TypeBuilder OGKIHBJMELH, IMMEJNLAKAC LIGOHHDCFFK, ConstructorInfo HIGIPMCLDOJ, FieldBuilder JAJCFFGHPFC, ILGenerator JMOOLDHNLGE, bool GGIJLMAOOJC, bool CGGKDNAJLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x30ACF90", Offset = "0x30ABD90", VA = "0x1830ACF90")]
	private static Dictionary<EHGEOGBPIDI, FieldInfo> OKGGHHIEBIL(TypeBuilder OGKIHBJMELH, IMMEJNLAKAC LIGOHHDCFFK, ILGenerator JMOOLDHNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x30A7260", Offset = "0x30A6060", VA = "0x1830A7260")]
	private static void DLOGEFEHHOJ(Type IDPNMFPNBCP, IMMEJNLAKAC LIGOHHDCFFK, ILGenerator JMOOLDHNLGE, Action JKJLJNGFKPC, Func<int, EHGEOGBPIDI, bool> KALOCELCFHB, bool GGIJLMAOOJC, bool CGGKDNAJLLI, int BLGFNHDDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x30ABBF0", Offset = "0x30AA9F0", VA = "0x1830ABBF0")]
	private static void LIJGBCJJELM(TypeInfo IDPNMFPNBCP, EHGEOGBPIDI AOCJHHFDKHL, ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE, Func<int, EHGEOGBPIDI, bool> KALOCELCFHB, BOFCGFBEHAL EIFADDPDFHE, BOFCGFBEHAL LHBKBAFLOIJ, BOFCGFBEHAL ILECBDCGLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x30AD550", Offset = "0x30AC350", VA = "0x1830AD550")]
	private static void PCBMHCMHIKO(Type IDPNMFPNBCP, IMMEJNLAKAC LIGOHHDCFFK, ILGenerator JMOOLDHNLGE, Func<int, EHGEOGBPIDI, bool> KALOCELCFHB, bool OJBIEFFDDAC, int BLGFNHDDLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x30ACB80", Offset = "0x30AB980", VA = "0x1830ACB80")]
	private static void ODLCADPNDBN(ILGenerator JMOOLDHNLGE, BDPHEINGEED LIGOHHDCFFK, int CKPFCCCIOFE, Func<int, EHGEOGBPIDI, bool> KALOCELCFHB, BOFCGFBEHAL DJHBICGFJIM, BOFCGFBEHAL ILECBDCGLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x30AA100", Offset = "0x30A8F00", VA = "0x1830AA100")]
	private static LocalBuilder ICIKPLHBDOI(ILGenerator JMOOLDHNLGE, Type IDPNMFPNBCP, IMMEJNLAKAC LIGOHHDCFFK, BDPHEINGEED[] JKEMHDLKKJB, bool NHOKPNJFAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x30AB3C0", Offset = "0x30AA1C0", VA = "0x1830AB3C0")]
	private static bool KNLHOCGNEIH(ConstructorInfo JCLLDPIJNPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30A70C0", Offset = "0x30A5EC0", VA = "0x1830A70C0")]
	private static bool AOINBCOBEMF(Type IDPNMFPNBCP, out Type KCPPGJILGAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate void KKABGOIEDPM<T>(byte[][] JAJCFFGHPFC, object[] PLBFAFBBNPB, ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH FOKJAANJGMD);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal delegate T FNNDBMHNHAJ<T>(object[] PLBFAFBBNPB, ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH FOKJAANJGMD);
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class ALNDFBPBLAA<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class DJPHGMLIKOM : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class IIHKJFKENDK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x36EA610", Offset = "0x36E9410", VA = "0x1836EA610")]
		static IIHKJFKENDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private DJPHGMLIKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class ODCFGIBDJFG : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class HLNMAOIEFLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3903E40", Offset = "0x3902C40", VA = "0x183903E40")]
		static HLNMAOIEFLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private ODCFGIBDJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal static class JFFGCFNFPPN
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal static readonly JGMBDHJDMIH[] NOFFPJBKMNO;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class MDPKHNLFFDL : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private static class KIEKMLGKFMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3B2A690", Offset = "0x3B29490", VA = "0x183B2A690")]
		static KIEKMLGKFMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class FAHKPCHDCPO : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private static class DJIMAPNLFGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3B22EF0", Offset = "0x3B21CF0", VA = "0x183B22EF0")]
			static DJIMAPNLFGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private FAHKPCHDCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private MDPKHNLFFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class GEJGJLBBCPE : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private static class KILIGBECNDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3062C40", Offset = "0x3061A40", VA = "0x183062C40")]
		static KILIGBECNDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private sealed class KJFFPHPHPIG : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private static class DJCOHEFINAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x304D060", Offset = "0x304BE60", VA = "0x18304D060")]
			static DJCOHEFINAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private KJFFPHPHPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private GEJGJLBBCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal sealed class DFHMPAKKJCJ : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private static class LIOMHGNIDFO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2BF26D0", Offset = "0x2BF14D0", VA = "0x182BF26D0")]
		static LIOMHGNIDFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class BMJDOMJOLCN : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private static class BAEEMJNPNFP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8670", Offset = "0x2BD7470", VA = "0x182BD8670")]
			static BAEEMJNPNFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private BMJDOMJOLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private DFHMPAKKJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class FAOJCBDDDMC : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private static class NMIGFEMEMGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3B81990", Offset = "0x3B80790", VA = "0x183B81990")]
		static NMIGFEMEMGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class BMEFADGNLCJ : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		private static class LEILOFHGIMC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3B7C560", Offset = "0x3B7B360", VA = "0x183B7C560")]
			static LEILOFHGIMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private BMEFADGNLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private FAOJCBDDDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class ICFHBDGIFJJ : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private static class PHLGOONNCID<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B1B0", Offset = "0x1C39FB0", VA = "0x181C3B1B0")]
		static PHLGOONNCID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class EDJHEEKPPEL : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private static class JJDIIKHCMBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1C365E0", Offset = "0x1C353E0", VA = "0x181C365E0")]
			static JJDIIKHCMBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private EDJHEEKPPEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private ICFHBDGIFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal sealed class DFFOJBHMMIL : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private static class EMOBKGLHIHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BE84F0", Offset = "0x2BE72F0", VA = "0x182BE84F0")]
		static EMOBKGLHIHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private sealed class JJLPFPEOJPG : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private static class KFIMOGNGCKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2BECBF0", Offset = "0x2BEB9F0", VA = "0x182BECBF0")]
			static KFIMOGNGCKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private JJLPFPEOJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private DFFOJBHMMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal sealed class JDONBGNFDGD : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private static class BBPOJAODMOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2997290", Offset = "0x2996090", VA = "0x182997290")]
		static BBPOJAODMOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class DCKMOKNEMAM : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		private static class ALFGIGJNPFK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2991690", Offset = "0x2990490", VA = "0x182991690")]
			static ALFGIGJNPFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private DCKMOKNEMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private JDONBGNFDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
internal sealed class KJOGIIONJFI : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private static class LPNLHFPJFFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B07150", Offset = "0x3B05F50", VA = "0x183B07150")]
		static LPNLHFPJFFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private sealed class ODGJGLBHDGA : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private static class JNHHLGIPIFD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7830", Offset = "0x3AF6630", VA = "0x183AF7830")]
			static JNHHLGIPIFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private ODGJGLBHDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private KJOGIIONJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal sealed class PNONPKDEKPM : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private static class EANCCKHGFFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x34D5210", Offset = "0x34D4010", VA = "0x1834D5210")]
		static EANCCKHGFFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private sealed class GNGABHPOBLH : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		private static class JKDEIHNCLGP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x34D8240", Offset = "0x34D7040", VA = "0x1834D8240")]
			static JKDEIHNCLGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private GNGABHPOBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private PNONPKDEKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal sealed class MIBDCNHECAF : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private static class PJNANHEJDFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x31ABA30", Offset = "0x31AA830", VA = "0x1831ABA30")]
		static PJNANHEJDFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private sealed class AMFAGOHEDOO : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		private static class MHOFLEMHOKO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x319DC40", Offset = "0x319CA40", VA = "0x18319DC40")]
			static MHOFLEMHOKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private AMFAGOHEDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private MIBDCNHECAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal sealed class FHNAFAJBNCE : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private static class CJPOEKOANNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x34386E0", Offset = "0x34374E0", VA = "0x1834386E0")]
		static CJPOEKOANNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class DPPDJFKAOKA : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private static class LMGEJAEHECB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x344E080", Offset = "0x344CE80", VA = "0x18344E080")]
			static LMGEJAEHECB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private DPPDJFKAOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private FHNAFAJBNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal sealed class HOIOADKJOJC : JGMBDHJDMIH
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private static class LHCICLIGMGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x32F6440", Offset = "0x32F5240", VA = "0x1832F6440")]
		static LHCICLIGMGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class KDBEFMFHCEO : JGMBDHJDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private static class MMJLMLPOBAI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public static readonly global::MMAJPDOPPIO<T> PGJBFDKPDEB;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x32FAF30", Offset = "0x32F9D30", VA = "0x1832FAF30")]
			static MMJLMLPOBAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly JGMBDHJDMIH GDKAJIKDHCH;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static readonly JGMBDHJDMIH[] BIBBDLFEEHK;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		private KDBEFMFHCEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
		public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public static readonly JGMBDHJDMIH GDKAJIKDHCH;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly global::MMAJPDOPPIO<object> GJJBDCGJJCM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	private HOIOADKJOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7ED0", Offset = "0x1FC6CD0", VA = "0x181FC7ED0", Slot = "4")]
	public global::MMAJPDOPPIO<T> GNPPGFMJMCE<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct EBECPFAMFNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public T[] LKODPENHECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public int IAGMOONFPOH;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x397B2F0", Offset = "0x397A0F0", VA = "0x18397B2F0")]
	public EBECPFAMFNF(int HOHNAFLEAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x397AF90", Offset = "0x3979D90", VA = "0x18397AF90")]
	public void PEIDOEKHNGH(T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x397AF00", Offset = "0x3979D00", VA = "0x18397AF00")]
	public T[] ILIHCFDCHEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal sealed class ECKHGAKJPIM : global::JIFLMPJHPCM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly ECKHGAKJPIM HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3313AC0", Offset = "0x33128C0", VA = "0x183313AC0")]
	public ECKHGAKJPIM(int PBJKLJJMBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class JIFLMPJHPCM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly int PBJKLJJMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly object AIALKNLJCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CKPFCCCIOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private T[][] IKJBPEJPNBH;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x29A4FD0", Offset = "0x29A3DD0", VA = "0x1829A4FD0")]
	public JIFLMPJHPCM(int PBJKLJJMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x29A3A10", Offset = "0x29A2810", VA = "0x1829A3A10")]
	public T[] FJILCONEHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x29A4250", Offset = "0x29A3050", VA = "0x1829A4250")]
	public void PIFOKNFDPJG(T[] DMCIGPCAGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class GNOCPDAMICE : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class INEDBPFCOLH : IComparable<INEDBPFCOLH>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class LOJMHGJIMHD : IEnumerable<INEDBPFCOLH>, IEnumerable, IEnumerator<INEDBPFCOLH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private INEDBPFCOLH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public INEDBPFCOLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private INEDBPFCOLH System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
			[DebuggerHidden]
			public LOJMHGJIMHD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x30B3440", Offset = "0x30B2240", VA = "0x1830B3440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x30B3570", Offset = "0x30B2370", VA = "0x1830B3570", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x30B34D0", Offset = "0x30B22D0", VA = "0x1830B34D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<INEDBPFCOLH> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x30B34D0", Offset = "0x30B22D0", VA = "0x1830B34D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class LMJILOBAIHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public LMJILOBAIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x524CC0", Offset = "0x523AC0", VA = "0x180524CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x524CC0", Offset = "0x523AC0", VA = "0x180524CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly INEDBPFCOLH[] NOGEFPKMMIK;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly ulong[] FHCFJFKJOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ulong AEAEDHDPBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MKDOFJMDMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public string MFLKBEIFIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private INEDBPFCOLH[] FANBCDBHALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private ulong[] LJFGHNHEBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int JPKOENICFPA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool COAKGCNKHAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA4B680", Offset = "0xA4A480", VA = "0x180A4B680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x30A7000", Offset = "0x30A5E00", VA = "0x1830A7000")]
		public INEDBPFCOLH(ulong LHOJNLGGKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x30A6D00", Offset = "0x30A5B00", VA = "0x1830A6D00")]
		public INEDBPFCOLH PEIDOEKHNGH(ulong LHOJNLGGKDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x30A6CB0", Offset = "0x30A5AB0", VA = "0x1830A6CB0")]
		public INEDBPFCOLH PEIDOEKHNGH(ulong LHOJNLGGKDH, int KCFMHIDCDCO, string MFLKBEIFIDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x30A6B00", Offset = "0x30A5900", VA = "0x1830A6B00")]
		public INEDBPFCOLH NLOKNNICFII(byte[] HKIJFBCAPBG, ref int HGFCPLJDPAG, ref int FBGACGPKIAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x30A5D70", Offset = "0x30A4B70", VA = "0x1830A5D70")]
		internal static int FMCEAPIKBKI(ulong[] DMCIGPCAGBM, int CKPFCCCIOFE, int JGBFFLOHENE, ulong KCFMHIDCDCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x30A5D40", Offset = "0x30A4B40", VA = "0x1830A5D40", Slot = "4")]
		public int CompareTo(INEDBPFCOLH NDGDPPHIMJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x30A5CD0", Offset = "0x30A4AD0", VA = "0x1830A5CD0")]
		[IteratorStateMachine(typeof(LOJMHGJIMHD))]
		public IEnumerable<INEDBPFCOLH> CDPLLICEPGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x30A5DF0", Offset = "0x30A4BF0", VA = "0x1830A5DF0")]
		public void HBNOBHLNCGN(ILGenerator JMOOLDHNLGE, LocalBuilder HKIJFBCAPBG, LocalBuilder FBGACGPKIAG, LocalBuilder LHOJNLGGKDH, Action<KeyValuePair<string, int>> AOMAOMONGON, Action IOAKECPLLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x30A5F20", Offset = "0x30A4D20", VA = "0x1830A5F20")]
		private static void IOPPIGHAFGK(ILGenerator JMOOLDHNLGE, LocalBuilder HKIJFBCAPBG, LocalBuilder FBGACGPKIAG, LocalBuilder LHOJNLGGKDH, Action<KeyValuePair<string, int>> AOMAOMONGON, Action IOAKECPLLBB, INEDBPFCOLH[] FANBCDBHALF, int JPKOENICFPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DEBCDIEAFLN : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<INEDBPFCOLH> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public IEnumerable<INEDBPFCOLH> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IEnumerator<INEDBPFCOLH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private INEDBPFCOLH <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x51D000", Offset = "0x51BE00", VA = "0x18051D000", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x33111E0", Offset = "0x330FFE0", VA = "0x1833111E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x94AB70", Offset = "0x949970", VA = "0x18094AB70")]
		[DebuggerHidden]
		public DEBCDIEAFLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3311230", Offset = "0x3310030", VA = "0x183311230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3310D70", Offset = "0x330FB70", VA = "0x183310D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3311330", Offset = "0x3310130", VA = "0x183311330")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3311380", Offset = "0x3310180", VA = "0x183311380")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3311190", Offset = "0x330FF90", VA = "0x183311190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x33110F0", Offset = "0x330FEF0", VA = "0x1833110F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x33110F0", Offset = "0x330FEF0", VA = "0x1833110F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly INEDBPFCOLH FBADHAKMLIA;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3320940", Offset = "0x331F740", VA = "0x183320940")]
	public GNOCPDAMICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x33207A0", Offset = "0x331F5A0", VA = "0x1833207A0")]
	public void PEIDOEKHNGH(byte[] NBHAFAAIDII, int KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x33206F0", Offset = "0x331F4F0", VA = "0x1833206F0")]
	public bool LCDHHMEMAAE(ArraySegment<byte> LHOJNLGGKDH, out int KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x33208B0", Offset = "0x331F6B0", VA = "0x1833208B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3320310", Offset = "0x331F110", VA = "0x183320310")]
	private static void CMLHHGDLGGE(IEnumerable<INEDBPFCOLH> FANBCDBHALF, StringBuilder PKDCBKLMDGN, int GPPJEGMCOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x33205C0", Offset = "0x331F3C0", VA = "0x1833205C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x33205C0", Offset = "0x331F3C0", VA = "0x1833205C0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3320680", Offset = "0x331F480", VA = "0x183320680")]
	[IteratorStateMachine(typeof(DEBCDIEAFLN))]
	private static IEnumerable<KeyValuePair<string, int>> HACGANNEPAK(IEnumerable<INEDBPFCOLH> FANBCDBHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3320590", Offset = "0x331F390", VA = "0x183320590")]
	public void DBJKBBLJFKH(ILGenerator JMOOLDHNLGE, LocalBuilder HKIJFBCAPBG, LocalBuilder FBGACGPKIAG, LocalBuilder LHOJNLGGKDH, Action<KeyValuePair<string, int>> AOMAOMONGON, Action IOAKECPLLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class GEEJNNOKNEK
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public static readonly MethodInfo HHPNBLHLFFB;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x331BF20", Offset = "0x331AD20", VA = "0x18331BF20")]
	public static ulong CAMADEFCIBP(byte[] NBHAFAAIDII, ref int HGFCPLJDPAG, ref int FBGACGPKIAG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class HKNLJDIEJGN
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x30A1380", Offset = "0x30A0180", VA = "0x1830A1380")]
	public static void OABALLCMNBO(ref byte[] NBHAFAAIDII, int HGFCPLJDPAG, int PCIKNLHGAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x30A1290", Offset = "0x30A0090", VA = "0x1830A1290")]
	public static void CGDBLIJCHEN(ref byte[] DMCIGPCAGBM, int INGPHIJGJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x30A11A0", Offset = "0x309FFA0", VA = "0x1830A11A0")]
	public static byte[] BAJIDFMJNBF(byte[] CHDOGMHMIDI, int INGPHIJGJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class GLOAACKIPEH
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x33200B0", Offset = "0x331EEB0", VA = "0x1833200B0")]
	public static bool ALJDPOBCGCB(byte[] IKGGNOFHAJG, int CJFHLJKFCJB, int ALCJLFLBBHG, byte[] IHKPJBEOCLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class NCPAGGKMMHO<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private struct CKELCPDOCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public byte[] AEAEDHDPBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public T MKDOFJMDMOL;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3331B50", Offset = "0x3330950", VA = "0x183331B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class BIHLJMJKNFC : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public global::NCPAGGKMMHO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private CKELCPDOCOA[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private CKELCPDOCOA[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xFFEFA0", Offset = "0xFFDDA0", VA = "0x180FFEFA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3330420", Offset = "0x332F220", VA = "0x183330420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1B5B470", Offset = "0x1B5A270", VA = "0x181B5B470")]
		[DebuggerHidden]
		public BIHLJMJKNFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x332E480", Offset = "0x332D280", VA = "0x18332E480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x332FCF0", Offset = "0x332EAF0", VA = "0x18332FCF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly CKELCPDOCOA[][] AGBOIACPOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly ulong MDGJIOGGKBK;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3343620", Offset = "0x3342420", VA = "0x183343620")]
	public NCPAGGKMMHO(int OIICMJBLBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3343650", Offset = "0x3342450", VA = "0x183343650")]
	public NCPAGGKMMHO(int OIICMJBLBOB, float KGJGAPEOHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3343230", Offset = "0x3342030", VA = "0x183343230")]
	public void PEIDOEKHNGH(byte[] LHOJNLGGKDH, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3341390", Offset = "0x3340190", VA = "0x183341390")]
	private bool LKLBPBMJMCH(byte[] LHOJNLGGKDH, T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3342B50", Offset = "0x3341950", VA = "0x183342B50")]
	public bool MNODOEFIIGL(ArraySegment<byte> LHOJNLGGKDH, out T KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3342440", Offset = "0x3341240", VA = "0x183342440")]
	private static ulong MIGHLGJENPH(byte[] ACPFKFODNNE, int HGFCPLJDPAG, int JPKOENICFPA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3340B30", Offset = "0x333F930", VA = "0x183340B30")]
	private static int BOHNEIMDDMA(int LDJECHIHOEI, float KGJGAPEOHNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3340C80", Offset = "0x333FA80", VA = "0x183340C80", Slot = "4")]
	[IteratorStateMachine(typeof(global::NCPAGGKMMHO<>.BIHLJMJKNFC))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2030AE0", Offset = "0x202F8E0", VA = "0x182030AE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class HIILLJMENEN : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly OpCode[] AIMGLMKPJFN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly OpCode[] CFONCHMCNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int PEOOBAFKFJI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PEJKNKBLNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x309EDB0", Offset = "0x309DBB0", VA = "0x18309EDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x309EE00", Offset = "0x309DC00", VA = "0x18309EE00")]
	static HIILLJMENEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x309F050", Offset = "0x309DE50", VA = "0x18309F050")]
	public HIILLJMENEN(byte[] ACHMBINJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x309ECA0", Offset = "0x309DAA0", VA = "0x18309ECA0")]
	public OpCode EAEKICJEFKJ()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct JHNKNBOHAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly Guid MKDOFJMDMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte COCDBDCCLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte ODDPBOELKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte IPJMCIJAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte BJAOGGJOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte EKEALBNJKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte BEPAFGKBJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte LKFIEIEAGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte EBDOIODAABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte DPJJAKLKNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte AFLMNJMDHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte PMPBDJPKFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte AHEFNILENAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte HEOMNBNLBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte NJKEOLFDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte DLFBFLLPIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte HCNIFGIFALD;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static byte[] OGNPBGHMGHP;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static byte[] ICDDIIJPEPI;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x416F600", Offset = "0x416E400", VA = "0x18416F600")]
	public JHNKNBOHAMO(ref Guid KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x416EF50", Offset = "0x416DD50", VA = "0x18416EF50")]
	public JHNKNBOHAMO(ref ArraySegment<byte> KGIGLBMFOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x416EDE0", Offset = "0x416DBE0", VA = "0x18416EDE0")]
	private static byte PCBCHMNHEKN(byte[] NBHAFAAIDII, int CHCDEGANCAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x416ECD0", Offset = "0x416DAD0", VA = "0x18416ECD0")]
	private static byte JCIDHGEDGBG(byte KBBKPHEOPAB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x416D990", Offset = "0x416C790", VA = "0x18416D990")]
	public void DEDDMECMLMC(byte[] FLHEFONBKGE, int HGFCPLJDPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class HJOBBKFIDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x309F7B0", Offset = "0x309E5B0", VA = "0x18309F7B0")]
	public static bool KNMCLDGNPKB(byte EACNPFGCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x309F5F0", Offset = "0x309E3F0", VA = "0x18309F5F0")]
	public static bool FAKNLAKJIBH(byte EACNPFGCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x309F660", Offset = "0x309E460", VA = "0x18309F660")]
	public static sbyte FJCDPKBLICJ(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x309F830", Offset = "0x309E630", VA = "0x18309F830")]
	public static short NGFMKADNKJE(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x309F7C0", Offset = "0x309E5C0", VA = "0x18309F7C0")]
	public static int NFBEAKFCFGP(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x309F4D0", Offset = "0x309E2D0", VA = "0x18309F4D0")]
	public static long DMNIAPBHAOA(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x309F580", Offset = "0x309E380", VA = "0x18309F580")]
	public static byte EGPJDJCBFBL(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x30A0E40", Offset = "0x309FC40", VA = "0x1830A0E40")]
	public static ushort PKEFOLNKIFF(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x309F8A0", Offset = "0x309E6A0", VA = "0x18309F8A0")]
	public static uint NMABEICNBAI(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x309F920", Offset = "0x309E720", VA = "0x18309F920")]
	public static ulong NNLOFFKEECD(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x309F6D0", Offset = "0x309E4D0", VA = "0x18309F6D0")]
	public static float GCNAICEECAN(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x309F740", Offset = "0x309E540", VA = "0x18309F740")]
	public static double IAHCMILMKGJ(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x309FA30", Offset = "0x309E830", VA = "0x18309FA30")]
	public static int OABPDOGFOGD(ref byte[] FLHEFONBKGE, int HGFCPLJDPAG, ulong KCFMHIDCDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x30A0200", Offset = "0x309F000", VA = "0x1830A0200")]
	public static int OJDBHJCEACA(ref byte[] FLHEFONBKGE, int HGFCPLJDPAG, long KCFMHIDCDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x309F280", Offset = "0x309E080", VA = "0x18309F280")]
	public static bool DCJBIIBDGHG(byte[] NBHAFAAIDII, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class DAGNHGNDHGE
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class IJDINMGJGAB : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
		[DebuggerHidden]
		public IJDINMGJGAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x33211E0", Offset = "0x331FFE0", VA = "0x1833211E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3320D80", Offset = "0x331FB80", VA = "0x183320D80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3321300", Offset = "0x3320100", VA = "0x183321300")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3321350", Offset = "0x3320150", VA = "0x183321350")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3321190", Offset = "0x331FF90", VA = "0x183321190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x33210E0", Offset = "0x331FEE0", VA = "0x1833210E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x33210E0", Offset = "0x331FEE0", VA = "0x1833210E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class EAIIOJLFEIP : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x62D3E0", Offset = "0x62C1E0", VA = "0x18062D3E0")]
		[DebuggerHidden]
		public EAIIOJLFEIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x33135B0", Offset = "0x33123B0", VA = "0x1833135B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3313150", Offset = "0x3311F50", VA = "0x183313150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x33136D0", Offset = "0x33124D0", VA = "0x1833136D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3313720", Offset = "0x3312520", VA = "0x183313720")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3313560", Offset = "0x3312360", VA = "0x183313560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x33134B0", Offset = "0x33122B0", VA = "0x1833134B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x33134B0", Offset = "0x33122B0", VA = "0x1833134B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x33101B0", Offset = "0x330EFB0", VA = "0x1833101B0")]
	public static bool MGLLEEOADAI(this TypeInfo IDPNMFPNBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x330FFC0", Offset = "0x330EDC0", VA = "0x18330FFC0")]
	public static bool AKKDCHFALBM(this TypeInfo IDPNMFPNBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3310260", Offset = "0x330F060", VA = "0x183310260")]
	public static IEnumerable<PropertyInfo> OEBGDMOAODE(this Type IDPNMFPNBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x33102C0", Offset = "0x330F0C0", VA = "0x1833102C0")]
	[IteratorStateMachine(typeof(IJDINMGJGAB))]
	private static IEnumerable<PropertyInfo> PLNEJKLAIGJ(Type IDPNMFPNBCP, HashSet<string> PDLCLGCMFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3310150", Offset = "0x330EF50", VA = "0x183310150")]
	public static IEnumerable<FieldInfo> LFPADONOINO(this Type IDPNMFPNBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x33100C0", Offset = "0x330EEC0", VA = "0x1833100C0")]
	[IteratorStateMachine(typeof(EAIIOJLFEIP))]
	private static IEnumerable<FieldInfo> DHOAKJCCCIG(Type IDPNMFPNBCP, HashSet<string> PDLCLGCMFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class KAMFMONEEGP
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly Encoding JJOCKHMFJCF;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal static class MDOMHJADLPD
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F60", Offset = "0x5D0D60", VA = "0x1805D1F60")]
	public static string MLMCIOKNPFJ(string FAJPLDJFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4173A60", Offset = "0x4172860", VA = "0x184173A60")]
	public static string AOGIPOCFJCL(string FAJPLDJFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4173B70", Offset = "0x4172970", VA = "0x184173B70")]
	public static string KPKIEPJLDDI(string FAJPLDJFIPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class KNMIMOAILGP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class IALOGCJLEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Type AEAEDHDPBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public TValue MKDOFJMDMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int FCFEDJGBILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public IALOGCJLEHC COBFKKGAOBN;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED40E0", Offset = "0x3ED2EE0", VA = "0x183ED40E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4060", Offset = "0x3ED2E60", VA = "0x183ED4060")]
		private int CPEMKADKPJF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public IALOGCJLEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class JBEDENPNNAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public JBEDENPNNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x84FC10", Offset = "0x84EA10", VA = "0x18084FC10")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private IALOGCJLEHC[] AGBOIACPOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int DPKPMBGBJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly object PPLBHGBCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly float KGJGAPEOHNH;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6480", Offset = "0x3ED5280", VA = "0x183ED6480")]
	public KNMIMOAILGP(int OIICMJBLBOB = 4, float KGJGAPEOHNH = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3ED51B0", Offset = "0x3ED3FB0", VA = "0x183ED51B0")]
	public bool COEFNJLJPMM(Type LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3ED52C0", Offset = "0x3ED40C0", VA = "0x183ED52C0")]
	public bool COEFNJLJPMM(Type LHOJNLGGKDH, Func<Type, TValue> PCDPOKMINLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5BB0", Offset = "0x3ED49B0", VA = "0x183ED5BB0")]
	private bool LKLBPBMJMCH(Type LHOJNLGGKDH, Func<Type, TValue> PCDPOKMINLP, out TValue ILCCJCPOEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5300", Offset = "0x3ED4100", VA = "0x183ED5300")]
	private bool ELMBJNGBPAP(IALOGCJLEHC[] AGBOIACPOLE, Type HANFJLJIEGA, IALOGCJLEHC APKHAFPKAFD, Func<Type, TValue> PCDPOKMINLP, out TValue ILCCJCPOEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3ED61E0", Offset = "0x3ED4FE0", VA = "0x183ED61E0")]
	public bool MNODOEFIIGL(Type LHOJNLGGKDH, out TValue KCFMHIDCDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5B10", Offset = "0x3ED4910", VA = "0x183ED5B10")]
	public TValue FEPKLAIJEJO(Type LHOJNLGGKDH, Func<Type, TValue> PCDPOKMINLP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3340B30", Offset = "0x333F930", VA = "0x183340B30")]
	private static int BOHNEIMDDMA(int LDJECHIHOEI, float KGJGAPEOHNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3ED61B0", Offset = "0x3ED4FB0", VA = "0x183ED61B0")]
	private static void MDIEKNADBLD(ref IALOGCJLEHC MPKABAJOMBO, IALOGCJLEHC KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3ED61B0", Offset = "0x3ED4FB0", VA = "0x183ED61B0")]
	private static void MDIEKNADBLD(ref IALOGCJLEHC[] MPKABAJOMBO, IALOGCJLEHC[] KCFMHIDCDCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class NCEKONJIBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly AssemblyBuilder BOIGPHJLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly ModuleBuilder GNMHIAHMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly object AIALKNLJCMP;

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x41742E0", Offset = "0x41730E0", VA = "0x1841742E0")]
	public TypeBuilder AHHNKABMPME(string HPAMGGFODJL, TypeAttributes MIJIEHADOIE, Type DEGLKKAFDCN, Type[] LBEMBECAKMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x41743D0", Offset = "0x41731D0", VA = "0x1841743D0")]
	public NCEKONJIBAF(string GHIBHBCAMOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class EBHIPAMBJLF
{
	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3313770", Offset = "0x3312570", VA = "0x183313770")]
	private static MethodInfo KAHOIKGEPLD(LambdaExpression EENLBPOOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x322AEA0", Offset = "0x3229CA0", VA = "0x18322AEA0")]
	public static MethodInfo FFEGKDMECJJ<T>(Expression<Func<T>> EENLBPOOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x322AEA0", Offset = "0x3229CA0", VA = "0x18322AEA0")]
	public static MethodInfo FFEGKDMECJJ<T, TR>(Expression<Func<T, TR>> EENLBPOOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x322AEA0", Offset = "0x3229CA0", VA = "0x18322AEA0")]
	public static MethodInfo FFEGKDMECJJ<T>(Expression<Action<T>> EENLBPOOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x322AEA0", Offset = "0x3229CA0", VA = "0x18322AEA0")]
	public static MethodInfo FFEGKDMECJJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> EENLBPOOKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x322AEB0", Offset = "0x3229CB0", VA = "0x18322AEB0")]
	private static MemberInfo KJGIOBEGCFE<T>(Expression<T> FCICKMMLFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x322AE40", Offset = "0x3229C40", VA = "0x18322AE40")]
	public static PropertyInfo BNICHKNMMHB<T, TR>(Expression<Func<T, TR>> EENLBPOOKAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal struct BOFCGFBEHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int CKCPKBAGJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly bool MPGFJMFDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly ILGenerator JMOOLDHNLGE;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x330E290", Offset = "0x330D090", VA = "0x18330E290")]
	public BOFCGFBEHAL(ILGenerator JMOOLDHNLGE, int CKCPKBAGJMN, bool MPGFJMFDMED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x330E200", Offset = "0x330D000", VA = "0x18330E200")]
	public BOFCGFBEHAL(ILGenerator JMOOLDHNLGE, int CKCPKBAGJMN, Type IDPNMFPNBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x330E0F0", Offset = "0x330CEF0", VA = "0x18330E0F0")]
	public void GOGCAEOGONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DPEOPIAEHGN
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3311E20", Offset = "0x3310C20", VA = "0x183311E20")]
	public static void BCHLEPICPJG(this ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3312050", Offset = "0x3310E50", VA = "0x183312050")]
	public static void BCHLEPICPJG(this ILGenerator JMOOLDHNLGE, LocalBuilder MFPMIHKPBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3312650", Offset = "0x3311450", VA = "0x183312650")]
	public static void MDOJBNAPMMF(this ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3312880", Offset = "0x3311680", VA = "0x183312880")]
	public static void MDOJBNAPMMF(this ILGenerator JMOOLDHNLGE, LocalBuilder MFPMIHKPBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3312120", Offset = "0x3310F20", VA = "0x183312120")]
	public static void FKJFILHKACC(this ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3312210", Offset = "0x3311010", VA = "0x183312210")]
	public static void FKJFILHKACC(this ILGenerator JMOOLDHNLGE, LocalBuilder MFPMIHKPBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3312320", Offset = "0x3311120", VA = "0x183312320")]
	public static void GEDGOEMBNEL(this ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3312110", Offset = "0x3310F10", VA = "0x183312110")]
	public static void EHHMHIBNNAA(this ILGenerator JMOOLDHNLGE, bool KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3312950", Offset = "0x3311750", VA = "0x183312950")]
	public static void OMHPJLCFOEC(this ILGenerator JMOOLDHNLGE, int KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3311D30", Offset = "0x3310B30", VA = "0x183311D30")]
	public static void AKIOPJOCAFC(this ILGenerator JMOOLDHNLGE, Type IDPNMFPNBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x33124C0", Offset = "0x33112C0", VA = "0x1833124C0")]
	public static void KEMKNCNFHPE(this ILGenerator JMOOLDHNLGE, Type IDPNMFPNBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3312DA0", Offset = "0x3311BA0", VA = "0x183312DA0")]
	public static void PKKBLKMBPNM(this ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3312090", Offset = "0x3310E90", VA = "0x183312090")]
	public static void CHDHLPNCCDP(this ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3312560", Offset = "0x3311360", VA = "0x183312560")]
	public static void LGHAFHHMMBD(this ILGenerator JMOOLDHNLGE, int CKPFCCCIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x33123C0", Offset = "0x33111C0", VA = "0x1833123C0")]
	public static void KDHEPOFOOLL(this ILGenerator JMOOLDHNLGE, MethodInfo OMHDDDHNAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x33128C0", Offset = "0x33116C0", VA = "0x1833128C0")]
	public static void OEOEDHIGBAM(this ILGenerator JMOOLDHNLGE, FieldInfo MGLNGEJJGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3312330", Offset = "0x3311130", VA = "0x183312330")]
	public static void HHHOHBDAHNA(this ILGenerator JMOOLDHNLGE, ulong KCFMHIDCDCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class EHGEOGBPIDI
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class LPEBAHKGPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public LPEBAHKGPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x33219C0", Offset = "0x33207C0", VA = "0x1833219C0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private MethodInfo AIMLLNLPDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private MethodInfo HFHODFNAPMB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IAPKIIHBPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FFPCFEHOMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ODPMHNKLOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3313B10", Offset = "0x3312910", VA = "0x183313B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HHEKFGIOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x51C190", Offset = "0x51AF90", VA = "0x18051C190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x676E40", Offset = "0x675C40", VA = "0x180676E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MJLECBOPJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x51C1A0", Offset = "0x51AFA0", VA = "0x18051C1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x73C950", Offset = "0x73B750", VA = "0x18073C950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type IILDJILJIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5450C0", Offset = "0x543EC0", VA = "0x1805450C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63FA90", Offset = "0x63E890", VA = "0x18063FA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo ICGOFNFCLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo OHOAMFLHFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x51D010", Offset = "0x51BE10", VA = "0x18051D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x51D020", Offset = "0x51BE20", VA = "0x18051D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo NGOFOMGCIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x52FD70", Offset = "0x52EB70", VA = "0x18052FD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5B6FC0", Offset = "0x5B5DC0", VA = "0x1805B6FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x3313ED0", Offset = "0x3312CD0", VA = "0x183313ED0")]
	protected EHGEOGBPIDI(Type IDPNMFPNBCP, string HPAMGGFODJL, string KIILDBJGBBJ, bool BFOPMMOLFEH, bool FOCDMNBPMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3313DC0", Offset = "0x3312BC0", VA = "0x183313DC0")]
	public EHGEOGBPIDI(FieldInfo LIGOHHDCFFK, string HPAMGGFODJL, bool MGPIJJNCICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3313F50", Offset = "0x3312D50", VA = "0x183313F50")]
	public EHGEOGBPIDI(PropertyInfo LIGOHHDCFFK, string HPAMGGFODJL, bool MGPIJJNCICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3313B20", Offset = "0x3312920", VA = "0x183313B20")]
	private static MethodInfo KBPLGJLBGHH(MemberInfo LIGOHHDCFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E1B0", Offset = "0x1C5CFB0", VA = "0x181C5E1B0")]
	public T HKFFNJEENBN<T>(bool DDFKOLNHEHE) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3313C40", Offset = "0x3312A40", VA = "0x183313C40", Slot = "4")]
	public virtual void MCAFEBNOBGM(ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3313D00", Offset = "0x3312B00", VA = "0x183313D00", Slot = "5")]
	public virtual void NGFHLDENGAO(ILGenerator JMOOLDHNLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class EBIIOGOHAKF : EHGEOGBPIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly string LFHIAPDHEIC;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3313970", Offset = "0x3312770", VA = "0x183313970")]
	public EBIIOGOHAKF(string HPAMGGFODJL, string LFHIAPDHEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3313860", Offset = "0x3312660", VA = "0x183313860", Slot = "4")]
	public override void MCAFEBNOBGM(ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3313920", Offset = "0x3312720", VA = "0x183313920", Slot = "5")]
	public override void NGFHLDENGAO(ILGenerator JMOOLDHNLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class FGCGFNOPDND : EHGEOGBPIDI
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly MethodInfo LMDKCLFFCKL;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly MethodInfo CAPHOEOCELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	internal BOFCGFBEHAL KNAOHIKLGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	internal BOFCGFBEHAL LHBKBAFLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	internal BOFCGFBEHAL ILECBDCGLFA;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3315660", Offset = "0x3314460", VA = "0x183315660")]
	public FGCGFNOPDND(string HPAMGGFODJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x33150B0", Offset = "0x3313EB0", VA = "0x1833150B0", Slot = "4")]
	public override void MCAFEBNOBGM(ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3315170", Offset = "0x3313F70", VA = "0x183315170", Slot = "5")]
	public override void NGFHLDENGAO(ILGenerator JMOOLDHNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3314FA0", Offset = "0x3313DA0", VA = "0x183314FA0")]
	public void EHDGBHFEJNP(ILGenerator JMOOLDHNLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class IMMEJNLAKAC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type IILDJILJIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IMMEBMIHFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x64ABA0", Offset = "0x6499A0", VA = "0x18064ABA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6B13B0", Offset = "0x6B01B0", VA = "0x1806B13B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HBMLAKJMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x715110", Offset = "0x713F10", VA = "0x180715110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xD5D3E0", Offset = "0xD5C1E0", VA = "0x180D5D3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo JHODMKFEAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x51EDF0", Offset = "0x51DBF0", VA = "0x18051EDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x546D70", Offset = "0x545B70", VA = "0x180546D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EHGEOGBPIDI[] NCLMBEMDABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5450C0", Offset = "0x543EC0", VA = "0x1805450C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x63FA90", Offset = "0x63E890", VA = "0x18063FA90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EHGEOGBPIDI[] KLLDNHJIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x30A4A50", Offset = "0x30A3850", VA = "0x1830A4A50")]
	public IMMEJNLAKAC(Type IDPNMFPNBCP, Func<string, string> JKJLFPGMDNN, bool MGPIJJNCICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x30A4980", Offset = "0x30A3780", VA = "0x1830A4980")]
	private static bool DNBFNLONDHA(IEnumerator<ConstructorInfo> ALHFKFNMECH, ref ConstructorInfo KEDGMIGMDBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct PGPBOFMHMON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public ulong KMALPLHJDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public int OGCHFBMNBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2057630", Offset = "0x2056430", VA = "0x182057630")]
	public PGPBOFMHMON(ulong BKFIIMGGNBM, int ELFHJPNNKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x417B090", Offset = "0x4179E90", VA = "0x18417B090")]
	public void DAFHDDPCGAC(ref PGPBOFMHMON NDGDPPHIMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x417B150", Offset = "0x4179F50", VA = "0x18417B150")]
	public static PGPBOFMHMON LPKFIFIKELD(ref PGPBOFMHMON OCLDIKFJHHO, ref PGPBOFMHMON KBBKPHEOPAB)
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x417B180", Offset = "0x4179F80", VA = "0x18417B180")]
	public void NLMGCIPHBDO(ref PGPBOFMHMON NDGDPPHIMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x417B0A0", Offset = "0x4179EA0", VA = "0x18417B0A0")]
	public static PGPBOFMHMON GEICHHLBKKH(ref PGPBOFMHMON OCLDIKFJHHO, ref PGPBOFMHMON KBBKPHEOPAB)
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x417AFF0", Offset = "0x4179DF0", VA = "0x18417AFF0")]
	public void AJBJFOJFHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x417B030", Offset = "0x4179E30", VA = "0x18417B030")]
	public static PGPBOFMHMON AJBJFOJFHBB(ref PGPBOFMHMON OCLDIKFJHHO)
	{
		return default(PGPBOFMHMON);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct ICNMOFNMIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public byte[] FLHEFONBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public int HGFCPLJDPAG;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x802760", Offset = "0x801560", VA = "0x180802760")]
	public ICNMOFNMIMM(byte[] FLHEFONBKGE, int EKDPPBPKOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x30A4010", Offset = "0x30A2E10", VA = "0x1830A4010")]
	public void LHGHMNPBCCG(byte DCNFCFNCDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x30A3E20", Offset = "0x30A2C20", VA = "0x1830A3E20")]
	public void GLLLDPNGEPN(byte[] DCNFCFNCDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x30A3F70", Offset = "0x30A2D70", VA = "0x1830A3F70")]
	public void KHFOOOABEGH(byte[] DCNFCFNCDHA, int JGBFFLOHENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x30A3EC0", Offset = "0x30A2CC0", VA = "0x1830A3EC0")]
	public void KHFOOOABEGH(byte[] DCNFCFNCDHA, int CDNJHFLFOKC, int JGBFFLOHENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x30A3DA0", Offset = "0x30A2BA0", VA = "0x1830A3DA0")]
	public void DIDMEHJMJDD(byte EACNPFGCNPL, int JPKOENICFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x30A3CA0", Offset = "0x30A2AA0", VA = "0x1830A3CA0")]
	public void AEMJAJGGINO(string DCNFCFNCDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class PCJMOIAHFJO
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum PAMJEHKGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum HDDCEPJLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum GAGPCDOAAMF
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
	private static byte[] DKINHJIBDMI;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	[ThreadStatic]
	private static byte[] EPIAGHIPJLJ;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly byte[] GKOEPOMBNOF;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly byte[] FFDIGFCMGKN;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly GAGPCDOAAMF CKCGNPBELOB;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly char BIPBOGKFCFG;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly int PAJOGAAEKMG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly int CPNEKJJMCAF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly uint[] FMADGKNEHBB;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4178FB0", Offset = "0x4177DB0", VA = "0x184178FB0")]
	private static byte[] BIPPBFMDGMK(int DPKPMBGBJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x417A680", Offset = "0x4179480", VA = "0x18417A680")]
	private static byte[] JGDPGLEOMPG(int DPKPMBGBJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4179580", Offset = "0x4178380", VA = "0x184179580")]
	public static int DMBLNAENAAA(ref byte[] FLHEFONBKGE, int HGFCPLJDPAG, float KCFMHIDCDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x4179470", Offset = "0x4178270", VA = "0x184179470")]
	public static int DMBLNAENAAA(ref byte[] FLHEFONBKGE, int HGFCPLJDPAG, double KCFMHIDCDCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4179370", Offset = "0x4178170", VA = "0x184179370")]
	private static bool DHIKJPGENKC(byte[] FLHEFONBKGE, int JGBFFLOHENE, ulong MAOIMEJMKLJ, ulong GGGEMFIGIEB, ulong FBGACGPKIAG, ulong KDPLNIKMMIP, ulong DBKEFGIHNMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4178E90", Offset = "0x4177C90", VA = "0x184178E90")]
	private static void BIFPFFOJAJP(uint FPFEJJEACBE, int IPMOKIACEKK, out uint IJJDCIKLEMD, out int ALAGEHEDHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4179F20", Offset = "0x4178D20", VA = "0x184179F20")]
	private static bool HONFFLIJPIK(PGPBOFMHMON IECKCMBIKAD, PGPBOFMHMON AOLMKHAFJHD, PGPBOFMHMON KOLHMBPDLOF, byte[] FLHEFONBKGE, out int JGBFFLOHENE, out int MNOGFKKIMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x417A2F0", Offset = "0x41790F0", VA = "0x18417A2F0")]
	private static bool JFPFMPMCKFJ(double ELGBOAGNPGH, PAMJEHKGIEL MEACFLCKBLC, byte[] FLHEFONBKGE, out int JGBFFLOHENE, out int JDNJMOKMDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4179690", Offset = "0x4178490", VA = "0x184179690")]
	private static bool FJCDLJJCJEH(double ELGBOAGNPGH, PAMJEHKGIEL MEACFLCKBLC, byte[] FLHEFONBKGE, out int JGBFFLOHENE, out int IHCELLEANBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x417A920", Offset = "0x4179720", VA = "0x18417A920")]
	private static bool NNGBJLKAMOD(double KCFMHIDCDCO, ref ICNMOFNMIMM PDIHLICMGMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4179780", Offset = "0x4178580", VA = "0x184179780")]
	private static bool GDGOAHABDNF(double KCFMHIDCDCO, ref ICNMOFNMIMM PDIHLICMGMH, HDDCEPJLLIH MEACFLCKBLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x417A760", Offset = "0x4179560", VA = "0x18417A760")]
	private static void MNMINLIGJDG(byte[] HOGHHFEBLLA, int JGBFFLOHENE, int IHCELLEANBC, int HFBMOOCLJNM, ref ICNMOFNMIMM PDIHLICMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4179080", Offset = "0x4177E80", VA = "0x184179080")]
	private static void CDKNOFNGCLL(byte[] HOGHHFEBLLA, int JGBFFLOHENE, int ELFHJPNNKKI, ref ICNMOFNMIMM PDIHLICMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4179DA0", Offset = "0x4178BA0", VA = "0x184179DA0")]
	private static bool HDFGCJFPBOB(double ELGBOAGNPGH, HDDCEPJLLIH MEACFLCKBLC, int GBHAKBAMHEM, byte[] LNNBFFOFBJK, out bool AHFMBECFNDD, out int JGBFFLOHENE, out int AHEILJOHIAB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct GCACDNGCHFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public double MEEHFAALDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public ulong DFLPELHMOJJ;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct IHPBNGLOEGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public float KMALPLHJDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public uint BEDDALPKNMC;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PAFPAOOCLGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private ulong PGOIMJHPKDJ;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4177E70", Offset = "0x4176C70", VA = "0x184177E70")]
	public PAFPAOOCLGN(double MEEHFAALDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4177DD0", Offset = "0x4176BD0", VA = "0x184177DD0")]
	public PAFPAOOCLGN(PGPBOFMHMON MEEHFAALDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x4177990", Offset = "0x4176790", VA = "0x184177990")]
	public PGPBOFMHMON DFCPFGKEEIB()
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x4177D30", Offset = "0x4176B30", VA = "0x184177D30")]
	public PGPBOFMHMON OMAMMFIGMDF()
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x76EF80", Offset = "0x76DD80", VA = "0x18076EF80")]
	public ulong HKMJLNFKFPC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4177C90", Offset = "0x4176A90", VA = "0x184177C90")]
	public double MFGEJODFCIG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x4177BC0", Offset = "0x41769C0", VA = "0x184177BC0")]
	public double IFMGOCJNHGC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4177A10", Offset = "0x4176810", VA = "0x184177A10")]
	public int FBONKCOPBAH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4177A40", Offset = "0x4176840", VA = "0x184177A40")]
	public ulong HPJLPDHFBCG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4177860", Offset = "0x4176660", VA = "0x184177860")]
	public bool CGGLEPGNCGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4177C40", Offset = "0x4176A40", VA = "0x184177C40")]
	public bool KAHJOGGBOHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4177D00", Offset = "0x4176B00", VA = "0x184177D00")]
	public bool OGLGKEBHEGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4177830", Offset = "0x4176630", VA = "0x184177830")]
	public bool AJJPFBKOANA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4177C70", Offset = "0x4176A70", VA = "0x184177C70")]
	public int KIHEDAEADMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4177A70", Offset = "0x4176870", VA = "0x184177A70")]
	public void HPKLDOBLMIG(out PGPBOFMHMON BJJGIOMDAAI, out PGPBOFMHMON KOPCAKFKPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4177940", Offset = "0x4176740", VA = "0x184177940")]
	public bool DCJNIEMDKOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4177C60", Offset = "0x4176A60", VA = "0x184177C60")]
	public double KCFMHIDCDCO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4177880", Offset = "0x4176680", VA = "0x184177880")]
	public static int CIKDAFLAGAH(int IGDKPAJDAIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4177DC0", Offset = "0x4176BC0", VA = "0x184177DC0")]
	public static double PMDNNLFGPLF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x41778A0", Offset = "0x41766A0", VA = "0x1841778A0")]
	public static ulong CMDIEFAOBNB(PGPBOFMHMON MOPLGICKNMH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct BPHNMCKLLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private uint DMOHECAMDGD;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D03060", Offset = "0x1D01E60", VA = "0x181D03060")]
	public BPHNMCKLLGO(float KMALPLHJDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x330E9F0", Offset = "0x330D7F0", VA = "0x18330E9F0")]
	public PGPBOFMHMON DFCPFGKEEIB()
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2B0", Offset = "0x7DE0B0", VA = "0x1807DF2B0")]
	public uint NJBECPMNCDG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x330EA60", Offset = "0x330D860", VA = "0x18330EA60")]
	public int FBONKCOPBAH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x330EA80", Offset = "0x330D880", VA = "0x18330EA80")]
	public uint HPJLPDHFBCG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x330E9A0", Offset = "0x330D7A0", VA = "0x18330E9A0")]
	public bool CGGLEPGNCGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x330EAA0", Offset = "0x330D8A0", VA = "0x18330EAA0")]
	public void HPKLDOBLMIG(out PGPBOFMHMON BJJGIOMDAAI, out PGPBOFMHMON KOPCAKFKPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x330E9B0", Offset = "0x330D7B0", VA = "0x18330E9B0")]
	public bool DCJNIEMDKOH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct DJBCNHKDMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public readonly ulong BKFIIMGGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly short NGPOJNKAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly short JDNJMOKMDDH;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x3311650", Offset = "0x3310450", VA = "0x183311650")]
	public DJBCNHKDMAK(ulong BKFIIMGGNBM, short NGPOJNKAFFJ, short JDNJMOKMDDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class JDEKKIPKDHE
{
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly DJBCNHKDMAK[] GDMOGEDMHJA;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x30B0580", Offset = "0x30AF380", VA = "0x1830B0580")]
	public static void MGMKLEPIMAB(int AFMEKFPMBAH, int PJGEHBBCIJK, out PGPBOFMHMON IJJDCIKLEMD, out int JDNJMOKMDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x30B0480", Offset = "0x30AF280", VA = "0x1830B0480")]
	public static void LPJLEMMHHCM(int LIBOMMCDNLH, out PGPBOFMHMON IJJDCIKLEMD, out int EADAGFOBHFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DefaultMember("Item")]
internal struct BJEEIPLBMGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public readonly byte[] NBHAFAAIDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly int CDNJHFLFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly int DIIJDDOCANC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte MFGCGCHGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x330DC10", Offset = "0x330CA10", VA = "0x18330DC10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x92ED80", Offset = "0x92DB80", VA = "0x18092ED80")]
	public BJEEIPLBMGF(byte[] NBHAFAAIDII, int CDNJHFLFOKC, int JGBFFLOHENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DF270", Offset = "0x7DE070", VA = "0x1807DF270")]
	public int JGBFFLOHENE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x330DBB0", Offset = "0x330C9B0", VA = "0x18330DBB0")]
	public BJEEIPLBMGF FIDLEIKJNOL(int MODMKCNINHI, int LOOOHKLGFFC)
	{
		return default(BJEEIPLBMGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class HNCDCLPKCML
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[ThreadStatic]
	private static byte[] BJGNEKDJADN;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly double[] NLJILIDAOMK;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly int MBALMKJKLID;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x30A1F80", Offset = "0x30A0D80", VA = "0x1830A1F80")]
	private static byte[] CLKEDEPIDHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x30A2650", Offset = "0x30A1450", VA = "0x1830A2650")]
	private static BJEEIPLBMGF KHEGCLMPPMA(BJEEIPLBMGF FLHEFONBKGE)
	{
		return default(BJEEIPLBMGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x30A2060", Offset = "0x30A0E60", VA = "0x1830A2060")]
	private static BJEEIPLBMGF FFNJACEPKHC(BJEEIPLBMGF FLHEFONBKGE)
	{
		return default(BJEEIPLBMGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x30A1EC0", Offset = "0x30A0CC0", VA = "0x1830A1EC0")]
	private static void BKLLAEGALCN(BJEEIPLBMGF FLHEFONBKGE, int ELFHJPNNKKI, byte[] DEOCJEIKOIH, out int FCGIBNINJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x30A2110", Offset = "0x30A0F10", VA = "0x1830A2110")]
	private static void FMKOIGMHPCJ(BJEEIPLBMGF FLHEFONBKGE, int ELFHJPNNKKI, byte[] FDFMNFIALLM, int ANOKFDNDGKC, out BJEEIPLBMGF JEFONIOCHMA, out int BLNCOIJAMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x30A1890", Offset = "0x30A0690", VA = "0x1830A1890")]
	private static ulong ABLAOALNOEL(BJEEIPLBMGF FLHEFONBKGE, out int NMPEBAKCCHA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x30A2C90", Offset = "0x30A1A90", VA = "0x1830A2C90")]
	private static void OIIJDPFCBGB(BJEEIPLBMGF FLHEFONBKGE, out PGPBOFMHMON CFLKPKIKHKL, out int AKMOGDBKEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x30A28E0", Offset = "0x30A16E0", VA = "0x1830A28E0")]
	private static bool LOHEGFGIJFI(BJEEIPLBMGF JEFONIOCHMA, int ELFHJPNNKKI, out double CFLKPKIKHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x30A24F0", Offset = "0x30A12F0", VA = "0x1830A24F0")]
	private static PGPBOFMHMON KFHCJCDJNFJ(int ELFHJPNNKKI)
	{
		return default(PGPBOFMHMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x30A1920", Offset = "0x30A0720", VA = "0x1830A1920")]
	private static bool AMNMOIHCMKA(BJEEIPLBMGF FLHEFONBKGE, int ELFHJPNNKKI, out double CFLKPKIKHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x30A1D80", Offset = "0x30A0B80", VA = "0x1830A1D80")]
	private static bool BFACNLCOOCM(BJEEIPLBMGF JEFONIOCHMA, int ELFHJPNNKKI, out double FKNDAOCJNHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x30A23C0", Offset = "0x30A11C0", VA = "0x1830A23C0")]
	public static double? IMLGDKBIFGA(BJEEIPLBMGF FLHEFONBKGE, int ELFHJPNNKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x30A2700", Offset = "0x30A1500", VA = "0x1830A2700")]
	public static float? KLHCIAPJJLE(BJEEIPLBMGF FLHEFONBKGE, int ELFHJPNNKKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal struct IMDPNMBEAGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private byte[] FLHEFONBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private int HGFCPLJDPAG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x30A4780", Offset = "0x30A3580", VA = "0x1830A4780")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x802760", Offset = "0x801560", VA = "0x180802760")]
	public IMDPNMBEAGO(byte[] FLHEFONBKGE, int HGFCPLJDPAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x30A46F0", Offset = "0x30A34F0", VA = "0x1830A46F0")]
	public static IMDPNMBEAGO BLJJCDFHGOA(IMDPNMBEAGO PGAIJHEIDLP)
	{
		return default(IMDPNMBEAGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x30A48A0", Offset = "0x30A36A0", VA = "0x1830A48A0")]
	public static IMDPNMBEAGO MNGJEHAGHLB(IMDPNMBEAGO PGAIJHEIDLP, int JGBFFLOHENE)
	{
		return default(IMDPNMBEAGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x30A4960", Offset = "0x30A3760", VA = "0x1830A4960")]
	public static int OIOIOKDPJIP(IMDPNMBEAGO NFDHPBJGLLD, IMDPNMBEAGO OKAHHBEIFGO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x30A4940", Offset = "0x30A3740", VA = "0x1830A4940")]
	public static bool NCKPEIMALDG(IMDPNMBEAGO NFDHPBJGLLD, IMDPNMBEAGO OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x30A4800", Offset = "0x30A3600", VA = "0x1830A4800")]
	public static bool JIHGJOPENJG(IMDPNMBEAGO NFDHPBJGLLD, IMDPNMBEAGO OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x30A4900", Offset = "0x30A3700", VA = "0x1830A4900")]
	public static bool NCKPEIMALDG(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x30A4820", Offset = "0x30A3620", VA = "0x1830A4820")]
	public static bool JIHGJOPENJG(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x30A4820", Offset = "0x30A3620", VA = "0x1830A4820")]
	public static bool JIHGJOPENJG(IMDPNMBEAGO NFDHPBJGLLD, byte OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x30A4740", Offset = "0x30A3540", VA = "0x1830A4740")]
	public static bool EHMPIACBGJN(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x30A4700", Offset = "0x30A3500", VA = "0x1830A4700")]
	public static bool CMBBIOFJKOB(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x30A47C0", Offset = "0x30A35C0", VA = "0x1830A47C0")]
	public static bool GBHJHDDOOND(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x30A4860", Offset = "0x30A3660", VA = "0x1830A4860")]
	public static bool MIFLKGFODAN(IMDPNMBEAGO NFDHPBJGLLD, char OKAHHBEIFGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class GHBPIHLIAEE
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] EPBGAHLPJII;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	[ThreadStatic]
	private static byte[] FHPOBCDHBAO;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly byte[] GKOEPOMBNOF;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly byte[] FFDIGFCMGKN;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly byte[] EPEGBFBHGLJ;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly int JDDBLJJGFPJ;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ushort[] PDHDNPLPHMG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int FJCPGBKOGIE;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x331FBF0", Offset = "0x331E9F0", VA = "0x18331FBF0")]
	private static byte[] JIAAMNHPIJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x331FDE0", Offset = "0x331EBE0", VA = "0x18331FDE0")]
	private static byte[] LPCLHHKKGOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x331FD20", Offset = "0x331EB20", VA = "0x18331FD20")]
	public static double KMNFLOGLJGM(byte[] FLHEFONBKGE, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x331FA10", Offset = "0x331E810", VA = "0x18331FA10")]
	public static float EKDACPPINHG(byte[] FLHEFONBKGE, int HGFCPLJDPAG, out int GIGNPKNEBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x331F890", Offset = "0x331E690", VA = "0x18331F890")]
	private static bool DCPPABIFOHH(int ACPFKFODNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x331FAD0", Offset = "0x331E8D0", VA = "0x18331FAD0")]
	private static bool GLOGJHGHMGE(ref IMDPNMBEAGO HEECMNLHCFC, IMDPNMBEAGO ICLHCKDDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x331F780", Offset = "0x331E580", VA = "0x18331F780")]
	private static bool CPGMMIOPGOP(ref IMDPNMBEAGO HEECMNLHCFC, IMDPNMBEAGO ICLHCKDDPDG, byte[] CDNJOALDIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x331FCD0", Offset = "0x331EAD0", VA = "0x18331FCD0")]
	private static bool JMHFGBCAIDE(ref IMDPNMBEAGO MOLLNBBKAHM, byte[] DCNFCFNCDHA, int HGFCPLJDPAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0xECAFD0", Offset = "0xEC9DD0", VA = "0x180ECAFD0")]
	private static double GPLBNGKILHN(bool AHFMBECFNDD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x331E6F0", Offset = "0x331D4F0", VA = "0x18331E6F0")]
	private static double CNGGKEDPLBE(IMDPNMBEAGO MAGHBLGPAIA, int JGBFFLOHENE, bool OKHNGKNBFFE, out int DGOGHEINNPE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class HEOJPMDMKDJ<T> : global::MMAJPDOPPIO<T[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly global::JIFLMPJHPCM<T> GOHDINAEBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly PGNEAEKPJGC PANFGNHJHFE;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDD00", Offset = "0x1CBCB00", VA = "0x181CBDD00")]
	public HEOJPMDMKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1B5B470", Offset = "0x1B5A270", VA = "0x181B5B470")]
	public HEOJPMDMKDJ(PGNEAEKPJGC PANFGNHJHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x32EA040", Offset = "0x32E8E40", VA = "0x1832EA040", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, T[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x32EC010", Offset = "0x32EAE10", VA = "0x1832EC010", Slot = "5")]
	public T[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class LAMHLBFMOPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly global::JIFLMPJHPCM<T> GOHDINAEBLK;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class KDMCONGEFOI<T> : global::MMAJPDOPPIO<List<T>>, BAPLCOKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly PGNEAEKPJGC PANFGNHJHFE;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDD00", Offset = "0x1CBCB00", VA = "0x181CBDD00")]
	public KDMCONGEFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1B5B470", Offset = "0x1B5A270", VA = "0x181B5B470")]
	public KDMCONGEFOI(PGNEAEKPJGC PANFGNHJHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x32A8A10", Offset = "0x32A7810", VA = "0x1832A8A10", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, List<T> KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x32A9800", Offset = "0x32A8600", VA = "0x1832A9800", Slot = "5")]
	public List<T> NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class CJNBFAGOPKI<TElement, TIntermediate, TEnumerator, TCollection> : global::MMAJPDOPPIO<TCollection>, BAPLCOKFLEM where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D850", Offset = "0x3D4C650", VA = "0x183D4D850", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, TCollection KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3D4ED20", Offset = "0x3D4DB20", VA = "0x183D4ED20", Slot = "5")]
	public TCollection NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LOCDEIGLBEC(TCollection FCICKMMLFCE);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PEDPEIEILOF();

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void PEIDOEKHNGH(ref TIntermediate PHCKAIHDLFL, int CKPFCCCIOFE, TElement KCFMHIDCDCO);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection IANFCFBCFJO(ref TIntermediate AMAJELDGFOB);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
	protected CJNBFAGOPKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class KIOHKAFBAGP<TElement, TIntermediate, TCollection> : global::CJNBFAGOPKI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1C34D50", Offset = "0x1C33B50", VA = "0x181C34D50", Slot = "6")]
	protected override IEnumerator<TElement> LOCDEIGLBEC(TCollection FCICKMMLFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1D93190", Offset = "0x1D91F90", VA = "0x181D93190")]
	protected KIOHKAFBAGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EJNIKCAKNKF<TElement, TCollection> : global::KIOHKAFBAGP<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected sealed override TCollection IANFCFBCFJO(ref TCollection AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class IOEJDIBECGB<TElement, TCollection> : global::EJNIKCAKNKF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x299E680", Offset = "0x299D480", VA = "0x18299E680", Slot = "7")]
	protected override TCollection PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x299E6A0", Offset = "0x299D4A0", VA = "0x18299E6A0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref TCollection PHCKAIHDLFL, int CKPFCCCIOFE, TElement KCFMHIDCDCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class PALCFBOIMIF<T> : global::CJNBFAGOPKI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDCC0", Offset = "0x1CBCAC0", VA = "0x181CBDCC0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref LinkedList<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override LinkedList<T> IANFCFBCFJO(ref LinkedList<T> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override LinkedList<T> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2837F50", Offset = "0x2836D50", VA = "0x182837F50", Slot = "6")]
	protected override LinkedList<T>.Enumerator LOCDEIGLBEC(LinkedList<T> FCICKMMLFCE)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class CFBNDEILGLL<T> : global::CJNBFAGOPKI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDCC0", Offset = "0x1CBCAC0", VA = "0x181CBDCC0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref Queue<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override Queue<T> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x31D0830", Offset = "0x31CF630", VA = "0x1831D0830", Slot = "6")]
	protected override Queue<T>.Enumerator LOCDEIGLBEC(Queue<T> FCICKMMLFCE)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override Queue<T> IANFCFBCFJO(ref Queue<T> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class PKGEPMBOIHI<T> : global::CJNBFAGOPKI<T, global::EBECPFAMFNF<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1D98780", Offset = "0x1D97580", VA = "0x181D98780", Slot = "8")]
	protected override void PEIDOEKHNGH(ref global::EBECPFAMFNF<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1D98700", Offset = "0x1D97500", VA = "0x181D98700", Slot = "7")]
	protected override global::EBECPFAMFNF<T> PEDPEIEILOF()
	{
		return default(global::EBECPFAMFNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x31D0830", Offset = "0x31CF630", VA = "0x1831D0830", Slot = "6")]
	protected override Stack<T>.Enumerator LOCDEIGLBEC(Stack<T> FCICKMMLFCE)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x34E4460", Offset = "0x34E3260", VA = "0x1834E4460", Slot = "9")]
	protected override Stack<T> IANFCFBCFJO(ref global::EBECPFAMFNF<T> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class NELKOMIEHEL<T> : global::CJNBFAGOPKI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDCC0", Offset = "0x1CBCAC0", VA = "0x181CBDCC0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref HashSet<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override HashSet<T> IANFCFBCFJO(ref HashSet<T> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override HashSet<T> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x31D0830", Offset = "0x31CF630", VA = "0x1831D0830", Slot = "6")]
	protected override HashSet<T>.Enumerator LOCDEIGLBEC(HashSet<T> FCICKMMLFCE)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class CDPDEOFOIMI<T> : global::KIOHKAFBAGP<T, global::EBECPFAMFNF<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1D98780", Offset = "0x1D97580", VA = "0x181D98780", Slot = "8")]
	protected override void PEIDOEKHNGH(ref global::EBECPFAMFNF<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x31CDEE0", Offset = "0x31CCCE0", VA = "0x1831CDEE0", Slot = "9")]
	protected override ReadOnlyCollection<T> IANFCFBCFJO(ref global::EBECPFAMFNF<T> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x31CDF70", Offset = "0x31CCD70", VA = "0x1831CDF70", Slot = "7")]
	protected override global::EBECPFAMFNF<T> PEDPEIEILOF()
	{
		return default(global::EBECPFAMFNF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AKILKIEOKHN<T> : global::KIOHKAFBAGP<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDCC0", Offset = "0x1CBCAC0", VA = "0x181CBDCC0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref List<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override List<T> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override IList<T> IANFCFBCFJO(ref List<T> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class MFOCIJADAOO<T> : global::KIOHKAFBAGP<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDCC0", Offset = "0x1CBCAC0", VA = "0x181CBDCC0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref List<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override List<T> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override ICollection<T> IANFCFBCFJO(ref List<T> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class OIJGKKFOEFP<T> : global::KIOHKAFBAGP<T, global::EBECPFAMFNF<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1D98780", Offset = "0x1D97580", VA = "0x181D98780", Slot = "8")]
	protected override void PEIDOEKHNGH(ref global::EBECPFAMFNF<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1D98700", Offset = "0x1D97500", VA = "0x181D98700", Slot = "7")]
	protected override global::EBECPFAMFNF<T> PEDPEIEILOF()
	{
		return default(global::EBECPFAMFNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x31E5D20", Offset = "0x31E4B20", VA = "0x1831E5D20", Slot = "9")]
	protected override IEnumerable<T> IANFCFBCFJO(ref global::EBECPFAMFNF<T> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HEPKMNLJNIN<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HLIBNJJDEPK<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class NNNJDOLKHJF<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class IADBAMLICDL : global::MMAJPDOPPIO<IEnumerable>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly global::MMAJPDOPPIO<IEnumerable> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x30A3790", Offset = "0x30A2590", VA = "0x1830A3790", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, IEnumerable KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x30A3980", Offset = "0x30A2780", VA = "0x1830A3980", Slot = "5")]
	public IEnumerable NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public IADBAMLICDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class CGLOLNGBKGF : global::MMAJPDOPPIO<ICollection>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly global::MMAJPDOPPIO<ICollection> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x330F290", Offset = "0x330E090", VA = "0x18330F290", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ICollection KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x330F5F0", Offset = "0x330E3F0", VA = "0x18330F5F0", Slot = "5")]
	public ICollection NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public CGLOLNGBKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class NGJGDGBPCHA : global::MMAJPDOPPIO<IList>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public static readonly global::MMAJPDOPPIO<IList> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4174730", Offset = "0x4173530", VA = "0x184174730", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, IList KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x41749D0", Offset = "0x41737D0", VA = "0x1841749D0", Slot = "5")]
	public IList NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public NGJGDGBPCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class LMCHEKJLOFN<T> : global::KIOHKAFBAGP<T, global::EBECPFAMFNF<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1D987B0", Offset = "0x1D975B0", VA = "0x181D987B0", Slot = "8")]
	protected override void PEIDOEKHNGH(ref global::EBECPFAMFNF<T> PHCKAIHDLFL, int CKPFCCCIOFE, T KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1D98700", Offset = "0x1D97500", VA = "0x181D98700", Slot = "7")]
	protected override global::EBECPFAMFNF<T> PEDPEIEILOF()
	{
		return default(global::EBECPFAMFNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1D986C0", Offset = "0x1D974C0", VA = "0x181D986C0", Slot = "9")]
	protected override IReadOnlyList<T> IANFCFBCFJO(ref global::EBECPFAMFNF<T> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1B61F10", Offset = "0x1B60D10", VA = "0x181B61F10")]
	public LMCHEKJLOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class NHHEGKDHNND
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4174CA0", Offset = "0x4173AA0", VA = "0x184174CA0")]
	public static DateTime NAGFOAOLKEI(DateTime DGPLHGHMKAG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KLCPNBDJLHM : global::MMAJPDOPPIO<DateTime>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly global::MMAJPDOPPIO<DateTime> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x41701D0", Offset = "0x416EFD0", VA = "0x1841701D0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, DateTime KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4170620", Offset = "0x416F420", VA = "0x184170620", Slot = "5")]
	public DateTime NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public KLCPNBDJLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class JCHJNOIDBEO : global::MMAJPDOPPIO<DateTimeOffset>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly global::MMAJPDOPPIO<DateTimeOffset> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x30AF170", Offset = "0x30ADF70", VA = "0x1830AF170", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, DateTimeOffset KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x30AF540", Offset = "0x30AE340", VA = "0x1830AF540", Slot = "5")]
	public DateTimeOffset NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public JCHJNOIDBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class PAGEONHLMIA : global::MMAJPDOPPIO<TimeSpan>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::MMAJPDOPPIO<TimeSpan> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static byte[] GJKELBJCHGD;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4177E80", Offset = "0x4176C80", VA = "0x184177E80", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, TimeSpan KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x4178140", Offset = "0x4176F40", VA = "0x184178140", Slot = "5")]
	public TimeSpan NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PAGEONHLMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class EKKFNCJGIEF<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::MMAJPDOPPIO<TDictionary>, BAPLCOKFLEM where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x31B8B20", Offset = "0x31B7920", VA = "0x1831B8B20", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, TDictionary KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x31BC260", Offset = "0x31BB060", VA = "0x1831BC260", Slot = "5")]
	public TDictionary NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator LOCDEIGLBEC(TDictionary FCICKMMLFCE);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PEDPEIEILOF();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void PEIDOEKHNGH(ref TIntermediate PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary IANFCFBCFJO(ref TIntermediate AMAJELDGFOB);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
	protected EKKFNCJGIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class IEIAMIGLJOK<TKey, TValue, TIntermediate, TDictionary> : global::EKKFNCJGIEF<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1C34D50", Offset = "0x1C33B50", VA = "0x181C34D50", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> LOCDEIGLBEC(TDictionary FCICKMMLFCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class KKCHBCDAGMM<TKey, TValue, TDictionary> : global::IEIAMIGLJOK<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override TDictionary IANFCFBCFJO(ref TDictionary AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class GLIGKJJIGEI<TKey, TValue> : global::EKKFNCJGIEF<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2838040", Offset = "0x2836E40", VA = "0x182838040", Slot = "8")]
	protected override void PEIDOEKHNGH(ref Dictionary<TKey, TValue> PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override Dictionary<TKey, TValue> IANFCFBCFJO(ref Dictionary<TKey, TValue> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override Dictionary<TKey, TValue> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2837FB0", Offset = "0x2836DB0", VA = "0x182837FB0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator LOCDEIGLBEC(Dictionary<TKey, TValue> FCICKMMLFCE)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x1B67E50", Offset = "0x1B66C50", VA = "0x181B67E50")]
	public GLIGKJJIGEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class JKEJEOOEJAK<TKey, TValue, TDictionary> : global::KKCHBCDAGMM<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3412470", Offset = "0x3411270", VA = "0x183412470", Slot = "8")]
	protected override void PEIDOEKHNGH(ref TDictionary PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3412450", Offset = "0x3411250", VA = "0x183412450", Slot = "7")]
	protected override TDictionary PEDPEIEILOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class OMFNCGGLFPJ<TKey, TValue> : global::IEIAMIGLJOK<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2838000", Offset = "0x2836E00", VA = "0x182838000", Slot = "8")]
	protected override void PEIDOEKHNGH(ref Dictionary<TKey, TValue> PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override Dictionary<TKey, TValue> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override IDictionary<TKey, TValue> IANFCFBCFJO(ref Dictionary<TKey, TValue> AMAJELDGFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class CDOIGFLCBIH<TKey, TValue> : global::KKCHBCDAGMM<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2838000", Offset = "0x2836E00", VA = "0x182838000", Slot = "8")]
	protected override void PEIDOEKHNGH(ref SortedList<TKey, TValue> PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override SortedList<TKey, TValue> PEDPEIEILOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EBHDOACPOPB<TKey, TValue> : global::EKKFNCJGIEF<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2838000", Offset = "0x2836E00", VA = "0x182838000", Slot = "8")]
	protected override void PEIDOEKHNGH(ref SortedDictionary<TKey, TValue> PHCKAIHDLFL, int CKPFCCCIOFE, TKey LHOJNLGGKDH, TValue KCFMHIDCDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x12344C0", Offset = "0x12332C0", VA = "0x1812344C0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> IANFCFBCFJO(ref SortedDictionary<TKey, TValue> AMAJELDGFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDC60", Offset = "0x1CBCA60", VA = "0x181CBDC60", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> PEDPEIEILOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x397B370", Offset = "0x397A170", VA = "0x18397B370", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator LOCDEIGLBEC(SortedDictionary<TKey, TValue> FCICKMMLFCE)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KCNLPPKLKJI<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class HOEPDJAMHKA : global::MMAJPDOPPIO<IDictionary>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::MMAJPDOPPIO<IDictionary> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x30A30D0", Offset = "0x30A1ED0", VA = "0x1830A30D0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, IDictionary KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x30A3450", Offset = "0x30A2250", VA = "0x1830A3450", Slot = "5")]
	public IDictionary NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HOEPDJAMHKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NKFFJOCPHPD : global::MMAJPDOPPIO<object>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private delegate void LALIIMHGJLE(object FGLGOCJHPHN, ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly global::KNMIMOAILGP<KeyValuePair<object, LALIIMHGJLE>> ONEIGHIACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly JGMBDHJDMIH[] LNPEKCGGNLN;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x41759E0", Offset = "0x41747E0", VA = "0x1841759E0")]
	public NKFFJOCPHPD(params JGMBDHJDMIH[] LNPEKCGGNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4175060", Offset = "0x4173E60", VA = "0x184175060", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4175950", Offset = "0x4174750", VA = "0x184175950", Slot = "5")]
	public object NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class BCNBEBIPBHI
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x330D0B0", Offset = "0x330BEB0", VA = "0x18330D0B0")]
	public static object PANMHMAGGAI(Type IDPNMFPNBCP, out bool CEHNEOBLDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x330C8D0", Offset = "0x330B6D0", VA = "0x18330C8D0")]
	public static object CGDLEOEDPHG(Type IDPNMFPNBCP, out bool CEHNEOBLDAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class APDCHJIBKHP<T> : global::MMAJPDOPPIO<T>, BAPLCOKFLEM, global::BJIPLPNBNJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class PBMPEEIAGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public PBMPEEIAGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1CCEEF0", Offset = "0x1CCDCF0", VA = "0x181CCEEF0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class CEECGMPDBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public global::GHHKGFJDGHP<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public CEECGMPDBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x1CC34A0", Offset = "0x1CC22A0", VA = "0x181CC34A0")]
		internal void <.cctor>b__1(ref GGMDNFGBBDM writer, T value, JGMBDHJDMIH _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LOPAGIGDLAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public global::JLBKJKEIONG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public LOPAGIGDLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9C00", Offset = "0x1CC8A00", VA = "0x181CC9C00")]
		internal T <.cctor>b__2(ref FMFKHIMMIHK reader, JGMBDHJDMIH _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly global::NCPAGGKMMHO<T> KBIFNMHDHKE;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly Dictionary<T, string> CHLDDHLGMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly global::GHHKGFJDGHP<T> LAHKBJPBFOD;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly global::JLBKJKEIONG<T> GHLFIOHBJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly bool OOPILEDHBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly global::GHHKGFJDGHP<T> EPMCJKBDLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly global::JLBKJKEIONG<T> PCOCIPGEBPG;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0B40", Offset = "0x1CBF940", VA = "0x181CC0B40")]
	static APDCHJIBKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1CC19C0", Offset = "0x1CC07C0", VA = "0x181CC19C0")]
	public APDCHJIBKHP(bool OOPILEDHBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1CBEFF0", Offset = "0x1CBDDF0", VA = "0x181CBEFF0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1CBF980", Offset = "0x1CBE780", VA = "0x181CBF980", Slot = "5")]
	public T NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1CBEF20", Offset = "0x1CBDD20", VA = "0x181CBEF20", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, T KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBF4E0", Offset = "0x1CBE2E0", VA = "0x181CBF4E0", Slot = "7")]
	public T LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class BNLJJFBIEDG<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class JAKKELFBMKE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class EFHENBBDAAJ<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class EPIMPHCEOHC<T> : global::MMAJPDOPPIO<T?>, BAPLCOKFLEM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31C7160", Offset = "0x31C5F60", VA = "0x1831C7160", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, T? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x31C73A0", Offset = "0x31C61A0", VA = "0x1831C73A0", Slot = "5")]
	public T? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
	public EPIMPHCEOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EKPBJGCKBBK<T> : global::MMAJPDOPPIO<T?>, BAPLCOKFLEM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::MMAJPDOPPIO<T> CHAIONOEBDG;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDF20", Offset = "0x1CBCD20", VA = "0x181CBDF20")]
	public EKPBJGCKBBK(global::MMAJPDOPPIO<T> CHAIONOEBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x31BD0B0", Offset = "0x31BBEB0", VA = "0x1831BD0B0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, T? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x31BD800", Offset = "0x31BC600", VA = "0x1831BD800", Slot = "5")]
	public T? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class JJFGCLHCBIF : global::MMAJPDOPPIO<sbyte>, BAPLCOKFLEM, global::BJIPLPNBNJL<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly JJFGCLHCBIF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x416F650", Offset = "0x416E450", VA = "0x18416F650", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, sbyte KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x416F6E0", Offset = "0x416E4E0", VA = "0x18416F6E0", Slot = "5")]
	public sbyte NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x416F610", Offset = "0x416E410", VA = "0x18416F610", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, sbyte KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x416F670", Offset = "0x416E470", VA = "0x18416F670", Slot = "7")]
	public sbyte LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public JJFGCLHCBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class IIOFNGOHHDD : global::MMAJPDOPPIO<sbyte?>, BAPLCOKFLEM, global::BJIPLPNBNJL<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly IIOFNGOHHDD HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x30A4390", Offset = "0x30A3190", VA = "0x1830A4390", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, sbyte? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x30A44E0", Offset = "0x30A32E0", VA = "0x1830A44E0", Slot = "5")]
	public sbyte? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x30A4310", Offset = "0x30A3110", VA = "0x1830A4310", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, sbyte? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x30A4400", Offset = "0x30A3200", VA = "0x1830A4400", Slot = "7")]
	public sbyte? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public IIOFNGOHHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class EOHAOMAMFBL : global::MMAJPDOPPIO<sbyte[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly EOHAOMAMFBL HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3314990", Offset = "0x3313790", VA = "0x183314990", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, sbyte[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3314B30", Offset = "0x3313930", VA = "0x183314B30", Slot = "5")]
	public sbyte[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public EOHAOMAMFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ABHCAHNGMHF : global::MMAJPDOPPIO<short>, BAPLCOKFLEM, global::BJIPLPNBNJL<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly ABHCAHNGMHF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x330AD00", Offset = "0x3309B00", VA = "0x18330AD00", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, short KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x330ADB0", Offset = "0x3309BB0", VA = "0x18330ADB0", Slot = "5")]
	public short NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x330AC40", Offset = "0x3309A40", VA = "0x18330AC40", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, short KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x330AD40", Offset = "0x3309B40", VA = "0x18330AD40", Slot = "7")]
	public short LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public ABHCAHNGMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GHAGBOMOPHJ : global::MMAJPDOPPIO<short?>, BAPLCOKFLEM, global::BJIPLPNBNJL<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly GHAGBOMOPHJ HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x331E4C0", Offset = "0x331D2C0", VA = "0x18331E4C0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, short? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x331E5E0", Offset = "0x331D3E0", VA = "0x18331E5E0", Slot = "5")]
	public short? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x331E3C0", Offset = "0x331D1C0", VA = "0x18331E3C0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, short? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x331E540", Offset = "0x331D340", VA = "0x18331E540", Slot = "7")]
	public short? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public GHAGBOMOPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class NFGCIFNDLOC : global::MMAJPDOPPIO<short[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly NFGCIFNDLOC HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x41744D0", Offset = "0x41732D0", VA = "0x1841744D0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, short[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4174590", Offset = "0x4173390", VA = "0x184174590", Slot = "5")]
	public short[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public NFGCIFNDLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class PFJGNLGKJKH : global::MMAJPDOPPIO<int>, BAPLCOKFLEM, global::BJIPLPNBNJL<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly PFJGNLGKJKH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x417AF00", Offset = "0x4179D00", VA = "0x18417AF00", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, int KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x417AF80", Offset = "0x4179D80", VA = "0x18417AF80", Slot = "5")]
	public int NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x417AEC0", Offset = "0x4179CC0", VA = "0x18417AEC0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, int KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x417AF10", Offset = "0x4179D10", VA = "0x18417AF10", Slot = "7")]
	public int LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PFJGNLGKJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class PIBIIPKEDGA : global::MMAJPDOPPIO<int?>, BAPLCOKFLEM, global::BJIPLPNBNJL<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly PIBIIPKEDGA HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x417B290", Offset = "0x417A090", VA = "0x18417B290", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, int? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x417B3A0", Offset = "0x417A1A0", VA = "0x18417B3A0", Slot = "5")]
	public int? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x417B210", Offset = "0x417A010", VA = "0x18417B210", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, int? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x417B300", Offset = "0x417A100", VA = "0x18417B300", Slot = "7")]
	public int? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PIBIIPKEDGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class BOPNPCMCHCH : global::MMAJPDOPPIO<int[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly BOPNPCMCHCH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x330E2D0", Offset = "0x330D0D0", VA = "0x18330E2D0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, int[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x330E470", Offset = "0x330D270", VA = "0x18330E470", Slot = "5")]
	public int[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BOPNPCMCHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class HJHCNHACFBN : global::MMAJPDOPPIO<long>, BAPLCOKFLEM, global::BJIPLPNBNJL<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly HJHCNHACFBN HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x309F110", Offset = "0x309DF10", VA = "0x18309F110", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, long KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x309F210", Offset = "0x309E010", VA = "0x18309F210", Slot = "5")]
	public long NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x309F0D0", Offset = "0x309DED0", VA = "0x18309F0D0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, long KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x309F130", Offset = "0x309DF30", VA = "0x18309F130", Slot = "7")]
	public long LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HJHCNHACFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IFOLFANGANK : global::MMAJPDOPPIO<long?>, BAPLCOKFLEM, global::BJIPLPNBNJL<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly IFOLFANGANK HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x30A40F0", Offset = "0x30A2EF0", VA = "0x1830A40F0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, long? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x30A4220", Offset = "0x30A3020", VA = "0x1830A4220", Slot = "5")]
	public long? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x30A4070", Offset = "0x30A2E70", VA = "0x1830A4070", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, long? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x30A4160", Offset = "0x30A2F60", VA = "0x1830A4160", Slot = "7")]
	public long? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public IFOLFANGANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class KEEOGOEAPJF : global::MMAJPDOPPIO<long[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly KEEOGOEAPJF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x416FB60", Offset = "0x416E960", VA = "0x18416FB60", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, long[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x416FC20", Offset = "0x416EA20", VA = "0x18416FC20", Slot = "5")]
	public long[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public KEEOGOEAPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class HNAEJAEIMKI : global::MMAJPDOPPIO<byte>, BAPLCOKFLEM, global::BJIPLPNBNJL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly HNAEJAEIMKI HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x30A1760", Offset = "0x30A0560", VA = "0x1830A1760", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, byte KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x30A1820", Offset = "0x30A0620", VA = "0x1830A1820", Slot = "5")]
	public byte NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x30A1720", Offset = "0x30A0520", VA = "0x1830A1720", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, byte KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x30A1780", Offset = "0x30A0580", VA = "0x1830A1780", Slot = "7")]
	public byte LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HNAEJAEIMKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KJDLIFHBKAI : global::MMAJPDOPPIO<byte?>, BAPLCOKFLEM, global::BJIPLPNBNJL<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KJDLIFHBKAI HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x416FEA0", Offset = "0x416ECA0", VA = "0x18416FEA0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, byte? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x416FFC0", Offset = "0x416EDC0", VA = "0x18416FFC0", Slot = "5")]
	public byte? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x416FE20", Offset = "0x416EC20", VA = "0x18416FE20", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, byte? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x416FF10", Offset = "0x416ED10", VA = "0x18416FF10", Slot = "7")]
	public byte? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public KJDLIFHBKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class CGHIMJCLFHG : global::MMAJPDOPPIO<ushort>, BAPLCOKFLEM, global::BJIPLPNBNJL<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly CGHIMJCLFHG HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x330F120", Offset = "0x330DF20", VA = "0x18330F120", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ushort KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x330F1D0", Offset = "0x330DFD0", VA = "0x18330F1D0", Slot = "5")]
	public ushort NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x330F060", Offset = "0x330DE60", VA = "0x18330F060", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, ushort KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x330F160", Offset = "0x330DF60", VA = "0x18330F160", Slot = "7")]
	public ushort LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public CGHIMJCLFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class HENFMMMMGFH : global::MMAJPDOPPIO<ushort?>, BAPLCOKFLEM, global::BJIPLPNBNJL<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly HENFMMMMGFH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x309E9B0", Offset = "0x309D7B0", VA = "0x18309E9B0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ushort? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x309EAF0", Offset = "0x309D8F0", VA = "0x18309EAF0", Slot = "5")]
	public ushort? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x309E930", Offset = "0x309D730", VA = "0x18309E930", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, ushort? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x309EA20", Offset = "0x309D820", VA = "0x18309EA20", Slot = "7")]
	public ushort? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HENFMMMMGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NHPGKKJAEKA : global::MMAJPDOPPIO<ushort[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly NHPGKKJAEKA HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4174D40", Offset = "0x4173B40", VA = "0x184174D40", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ushort[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4174E00", Offset = "0x4173C00", VA = "0x184174E00", Slot = "5")]
	public ushort[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public NHPGKKJAEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class MGPKHDOFEHD : global::MMAJPDOPPIO<uint>, BAPLCOKFLEM, global::BJIPLPNBNJL<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly MGPKHDOFEHD HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4173EC0", Offset = "0x4172CC0", VA = "0x184173EC0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, uint KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4173F40", Offset = "0x4172D40", VA = "0x184173F40", Slot = "5")]
	public uint NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4173E80", Offset = "0x4172C80", VA = "0x184173E80", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, uint KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4173ED0", Offset = "0x4172CD0", VA = "0x184173ED0", Slot = "7")]
	public uint LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MGPKHDOFEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class FKNKBHKGMMC : global::MMAJPDOPPIO<uint?>, BAPLCOKFLEM, global::BJIPLPNBNJL<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly FKNKBHKGMMC HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x3316C20", Offset = "0x3315A20", VA = "0x183316C20", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, uint? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x3316D40", Offset = "0x3315B40", VA = "0x183316D40", Slot = "5")]
	public uint? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3316B20", Offset = "0x3315920", VA = "0x183316B20", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, uint? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3316CA0", Offset = "0x3315AA0", VA = "0x183316CA0", Slot = "7")]
	public uint? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public FKNKBHKGMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class COOJBHJIEMG : global::MMAJPDOPPIO<uint[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly COOJBHJIEMG HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x330FC20", Offset = "0x330EA20", VA = "0x18330FC20", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, uint[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x330FDC0", Offset = "0x330EBC0", VA = "0x18330FDC0", Slot = "5")]
	public uint[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public COOJBHJIEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class IKNPNEALEFM : global::MMAJPDOPPIO<ulong>, BAPLCOKFLEM, global::BJIPLPNBNJL<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly IKNPNEALEFM HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x30A45F0", Offset = "0x30A33F0", VA = "0x1830A45F0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ulong KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x30A4680", Offset = "0x30A3480", VA = "0x1830A4680", Slot = "5")]
	public ulong NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x30A45B0", Offset = "0x30A33B0", VA = "0x1830A45B0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, ulong KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x30A4610", Offset = "0x30A3410", VA = "0x1830A4610", Slot = "7")]
	public ulong LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public IKNPNEALEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BPFEOHHLNGB : global::MMAJPDOPPIO<ulong?>, BAPLCOKFLEM, global::BJIPLPNBNJL<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly BPFEOHHLNGB HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x330E770", Offset = "0x330D570", VA = "0x18330E770", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ulong? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x330E8B0", Offset = "0x330D6B0", VA = "0x18330E8B0", Slot = "5")]
	public ulong? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x330E670", Offset = "0x330D470", VA = "0x18330E670", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, ulong? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x330E7F0", Offset = "0x330D5F0", VA = "0x18330E7F0", Slot = "7")]
	public ulong? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BPFEOHHLNGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class CCCPBBJIIOJ : global::MMAJPDOPPIO<ulong[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CCCPBBJIIOJ HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x330ECC0", Offset = "0x330DAC0", VA = "0x18330ECC0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ulong[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x330EE60", Offset = "0x330DC60", VA = "0x18330EE60", Slot = "5")]
	public ulong[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public CCCPBBJIIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class BJJADOIPICF : global::MMAJPDOPPIO<float>, BAPLCOKFLEM, global::BJIPLPNBNJL<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly BJJADOIPICF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x330DD00", Offset = "0x330CB00", VA = "0x18330DD00", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, float KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x330DD80", Offset = "0x330CB80", VA = "0x18330DD80", Slot = "5")]
	public float NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x330DC50", Offset = "0x330CA50", VA = "0x18330DC50", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, float KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x330DD10", Offset = "0x330CB10", VA = "0x18330DD10", Slot = "7")]
	public float LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BJJADOIPICF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FHIMNJGDAKH : global::MMAJPDOPPIO<float?>, BAPLCOKFLEM, global::BJIPLPNBNJL<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FHIMNJGDAKH HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3315EA0", Offset = "0x3314CA0", VA = "0x183315EA0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, float? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3315FB0", Offset = "0x3314DB0", VA = "0x183315FB0", Slot = "5")]
	public float? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3315DB0", Offset = "0x3314BB0", VA = "0x183315DB0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, float? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3315F10", Offset = "0x3314D10", VA = "0x183315F10", Slot = "7")]
	public float? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public FHIMNJGDAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class MDDFCMEEKNF : global::MMAJPDOPPIO<float[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly MDDFCMEEKNF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x4173800", Offset = "0x4172600", VA = "0x184173800", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, float[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x41738C0", Offset = "0x41726C0", VA = "0x1841738C0", Slot = "5")]
	public float[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MDDFCMEEKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class PBDOJHABMEN : global::MMAJPDOPPIO<double>, BAPLCOKFLEM, global::BJIPLPNBNJL<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PBDOJHABMEN HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4178DA0", Offset = "0x4177BA0", VA = "0x184178DA0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, double KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x4178E20", Offset = "0x4177C20", VA = "0x184178E20", Slot = "5")]
	public double NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x4178D60", Offset = "0x4177B60", VA = "0x184178D60", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, double KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4178DB0", Offset = "0x4177BB0", VA = "0x184178DB0", Slot = "7")]
	public double LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PBDOJHABMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class HKBHHFLEDJJ : global::MMAJPDOPPIO<double?>, BAPLCOKFLEM, global::BJIPLPNBNJL<double?>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HKBHHFLEDJJ HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x30A0F30", Offset = "0x309FD30", VA = "0x1830A0F30", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, double? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x30A10B0", Offset = "0x309FEB0", VA = "0x1830A10B0", Slot = "5")]
	public double? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x30A0EB0", Offset = "0x309FCB0", VA = "0x1830A0EB0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, double? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x30A0FA0", Offset = "0x309FDA0", VA = "0x1830A0FA0", Slot = "7")]
	public double? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HKBHHFLEDJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class KPFHIOJJPCP : global::MMAJPDOPPIO<double[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly KPFHIOJJPCP HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x41716A0", Offset = "0x41704A0", VA = "0x1841716A0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, double[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4171760", Offset = "0x4170560", VA = "0x184171760", Slot = "5")]
	public double[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public KPFHIOJJPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class JDNJOOFIAIO : global::MMAJPDOPPIO<bool>, BAPLCOKFLEM, global::BJIPLPNBNJL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly JDNJOOFIAIO HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x416D440", Offset = "0x416C240", VA = "0x18416D440", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, bool KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x416D4D0", Offset = "0x416C2D0", VA = "0x18416D4D0", Slot = "5")]
	public bool NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x416D400", Offset = "0x416C200", VA = "0x18416D400", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, bool KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x416D460", Offset = "0x416C260", VA = "0x18416D460", Slot = "7")]
	public bool LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public JDNJOOFIAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class BAMDNFAMPJF : global::MMAJPDOPPIO<bool?>, BAPLCOKFLEM, global::BJIPLPNBNJL<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BAMDNFAMPJF HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x330C630", Offset = "0x330B430", VA = "0x18330C630", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, bool? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x330C750", Offset = "0x330B550", VA = "0x18330C750", Slot = "5")]
	public bool? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x330C540", Offset = "0x330B340", VA = "0x18330C540", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, bool? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x330C6A0", Offset = "0x330B4A0", VA = "0x18330C6A0", Slot = "7")]
	public bool? LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public BAMDNFAMPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class CHMOIMIDMDG : global::MMAJPDOPPIO<bool[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly CHMOIMIDMDG HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x330F840", Offset = "0x330E640", VA = "0x18330F840", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, bool[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x330F9C0", Offset = "0x330E7C0", VA = "0x18330F9C0", Slot = "5")]
	public bool[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public CHMOIMIDMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class OGNDGNPFBPG : global::MMAJPDOPPIO<object>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly global::MMAJPDOPPIO<object> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly Dictionary<Type, int> JBCGCEABCNH;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4176930", Offset = "0x4175730", VA = "0x184176930", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, object KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x4177280", Offset = "0x4176080", VA = "0x184177280", Slot = "5")]
	public object NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public OGNDGNPFBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class LGIIKABHMNC : global::MMAJPDOPPIO<byte[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly global::MMAJPDOPPIO<byte[]> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4171E70", Offset = "0x4170C70", VA = "0x184171E70", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, byte[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4171F00", Offset = "0x4170D00", VA = "0x184171F00", Slot = "5")]
	public byte[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public LGIIKABHMNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GNJKCMFAGKK : global::MMAJPDOPPIO<ArraySegment<byte>>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly global::MMAJPDOPPIO<ArraySegment<byte>> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3320140", Offset = "0x331EF40", VA = "0x183320140", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, ArraySegment<byte> KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x33201E0", Offset = "0x331EFE0", VA = "0x1833201E0", Slot = "5")]
	public ArraySegment<byte> NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public GNJKCMFAGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class KNAANINJPCN : global::MMAJPDOPPIO<string>, BAPLCOKFLEM, global::BJIPLPNBNJL<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly global::MMAJPDOPPIO<string> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4171610", Offset = "0x4170410", VA = "0x184171610", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, string KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4171630", Offset = "0x4170430", VA = "0x184171630", Slot = "5")]
	public string NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4171610", Offset = "0x4170410", VA = "0x184171610", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, string KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4171630", Offset = "0x4170430", VA = "0x184171630", Slot = "7")]
	public string LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public KNAANINJPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HNCDHABCMPA : global::MMAJPDOPPIO<string[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly HNCDHABCMPA HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x30A2E70", Offset = "0x30A1C70", VA = "0x1830A2E70", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, string[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x30A2F30", Offset = "0x30A1D30", VA = "0x1830A2F30", Slot = "5")]
	public string[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HNCDHABCMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DCOPBKMHJPL : global::MMAJPDOPPIO<char>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly DCOPBKMHJPL HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x3310C60", Offset = "0x330FA60", VA = "0x183310C60", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, char KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x3310CE0", Offset = "0x330FAE0", VA = "0x183310CE0", Slot = "5")]
	public char NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public DCOPBKMHJPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class AJOACLHJMEG : global::MMAJPDOPPIO<char?>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AJOACLHJMEG HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x330BF30", Offset = "0x330AD30", VA = "0x18330BF30", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, char? KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x330C000", Offset = "0x330AE00", VA = "0x18330C000", Slot = "5")]
	public char? NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public AJOACLHJMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class AFIEECGONHA : global::MMAJPDOPPIO<char[]>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly AFIEECGONHA HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x330BAA0", Offset = "0x330A8A0", VA = "0x18330BAA0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, char[] KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x330BCE0", Offset = "0x330AAE0", VA = "0x18330BCE0", Slot = "5")]
	public char[] NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public AFIEECGONHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class HMJOMKAENPH : global::MMAJPDOPPIO<Guid>, BAPLCOKFLEM, global::BJIPLPNBNJL<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::MMAJPDOPPIO<Guid> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x30A1580", Offset = "0x30A0380", VA = "0x1830A1580", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Guid KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x30A1660", Offset = "0x30A0460", VA = "0x1830A1660", Slot = "5")]
	public Guid NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x30A14A0", Offset = "0x30A02A0", VA = "0x1830A14A0", Slot = "6")]
	public void FIJOEKPLPLK(ref GGMDNFGBBDM EIFADDPDFHE, Guid KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x30A1660", Offset = "0x30A0460", VA = "0x1830A1660", Slot = "7")]
	public Guid LGKHKMHOLAK(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public HMJOMKAENPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class IPFHDJIBOAH : global::MMAJPDOPPIO<decimal>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::MMAJPDOPPIO<decimal> HDNKDHGBPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly bool ANACBFPGIKK;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xAF9C80", Offset = "0xAF8A80", VA = "0x180AF9C80")]
	public IPFHDJIBOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x173C420", Offset = "0x173B220", VA = "0x18173C420")]
	public IPFHDJIBOAH(bool ANACBFPGIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x30AECC0", Offset = "0x30ADAC0", VA = "0x1830AECC0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, decimal KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x30AEE00", Offset = "0x30ADC00", VA = "0x1830AEE00", Slot = "5")]
	public decimal NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class EMFFHAKLGDC : global::MMAJPDOPPIO<Uri>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::MMAJPDOPPIO<Uri> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x3314800", Offset = "0x3313600", VA = "0x183314800", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Uri KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x33148B0", Offset = "0x33136B0", VA = "0x1833148B0", Slot = "5")]
	public Uri NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public EMFFHAKLGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class PBADCHHKLKJ : global::MMAJPDOPPIO<Version>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::MMAJPDOPPIO<Version> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x4178BD0", Offset = "0x41779D0", VA = "0x184178BD0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Version KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x4178C80", Offset = "0x4177A80", VA = "0x184178C80", Slot = "5")]
	public Version NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public PBADCHHKLKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class EIFCFAOAEGH<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class FEFKDIJOECD : global::MMAJPDOPPIO<StringBuilder>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::MMAJPDOPPIO<StringBuilder> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x3314E70", Offset = "0x3313C70", VA = "0x183314E70", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, StringBuilder KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x3314EC0", Offset = "0x3313CC0", VA = "0x183314EC0", Slot = "5")]
	public StringBuilder NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public FEFKDIJOECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class MKGCDLAHOME : global::MMAJPDOPPIO<BitArray>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::MMAJPDOPPIO<BitArray> HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x41740F0", Offset = "0x4172EF0", VA = "0x1841740F0", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, BitArray KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x4174180", Offset = "0x4172F80", VA = "0x184174180", Slot = "5")]
	public BitArray NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MKGCDLAHOME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class BCOGAPKGHJP : global::MMAJPDOPPIO<Type>, BAPLCOKFLEM
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly BCOGAPKGHJP HDNKDHGBPHH;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly Regex NLLHOPNGNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private bool BJJKBIGGOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private bool PKDMKGGKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private bool DFLICPCEKDM;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x330DB90", Offset = "0x330C990", VA = "0x18330DB90")]
	public BCOGAPKGHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x330DB40", Offset = "0x330C940", VA = "0x18330DB40")]
	public BCOGAPKGHJP(bool BJJKBIGGOJK, bool PKDMKGGKECE, bool DFLICPCEKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x330D890", Offset = "0x330C690", VA = "0x18330D890", Slot = "4")]
	public void GGGHAECNNDD(ref GGMDNFGBBDM EIFADDPDFHE, Type KCFMHIDCDCO, JGMBDHJDMIH EJFLCNIAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x330D980", Offset = "0x330C780", VA = "0x18330D980", Slot = "5")]
	public Type NMBJEEACLGI(ref FMFKHIMMIHK DJHBICGFJIM, JGMBDHJDMIH EJFLCNIAGGE)
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
