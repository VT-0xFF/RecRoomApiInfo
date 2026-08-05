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
public class GBMOCCLAKJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public GBMOCCLAKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class KLJJHKCNBHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public KLJJHKCNBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PEPIOMACPLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public PEPIOMACPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class BLMDIMBDNNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public BLMDIMBDNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JBFBDPNHPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4618150", Offset = "0x4616D50", VA = "0x184618150")]
	public static bool NDOJDIMIIEF(this TypeInfo BIEGICDMJCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class AKPDIBJJBLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FEOPAPPFEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] EDFJLPBOOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6912F0", VA = "0x1806926F0")]
	public AKPDIBJJBLM(Type MMKEBLBLBOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class DABGAFGLJHO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EFJMCNIOMKI<T>(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T KHILBEPBCPG<T>(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG MOPBAELKKDA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DIAHDCBEFFK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKBCOOCHDMC<T> : DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KKDIOMBNNDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CIIAACDLPMF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KFHDMAFNCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x23508E0", Offset = "0x234F4E0", VA = "0x1823508E0")]
	public static global::LKBCOOCHDMC<T> ILCHNEBHGJJ<T>(this ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x461A060", Offset = "0x4618C60", VA = "0x18461A060")]
	public static object KOFBLMMAJHF(this ECLEPONANIG MOPBAELKKDA, Type BIEGICDMJCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AKLGEGPAJHF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x51ACC70", Offset = "0x51AB870", VA = "0x1851ACC70")]
	public AKLGEGPAJHF(string HDKJDEIGPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FHNCKNEPFID
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class EDKIGAOFKIB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NFMJIELOGNG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] PFFCDABHPPI;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4F1E610", Offset = "0x4F1D210", VA = "0x184F1E610")]
		public static byte[] FDFMHAOFGLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F1E580", Offset = "0x4F1D180", VA = "0x184F1E580")]
		public static char[] DEBOIGFLHNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EKLOAALNNKI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] IAPAAFHCHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EHAMCGPFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int HPNBOGMLOLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool INAAMNBKIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51BCA30", Offset = "0x51BB630", VA = "0x1851BCA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x51BE240", Offset = "0x51BCE40", VA = "0x1851BE240")]
	public FHNCKNEPFID(byte[] EHAMCGPFFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51BE050", Offset = "0x51BCC50", VA = "0x1851BE050")]
	public FHNCKNEPFID(byte[] EHAMCGPFFID, int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51BCF80", Offset = "0x51BBB80", VA = "0x1851BCF80")]
	private BKIIPNGFFKI NNMMLDHIAKI(string JJPEDAIHJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51BB3B0", Offset = "0x51B9FB0", VA = "0x1851BB3B0")]
	private BKIIPNGFFKI AAOJCIIPDAH(string HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51B83D0", Offset = "0x51B6FD0", VA = "0x1851B83D0")]
	public void OKNDODPLLNL(int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675C00", VA = "0x180677000")]
	public byte[] GDIDANNFJND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x7751E0", VA = "0x1807765E0")]
	public int BLLADAFDHDF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x51BCCC0", Offset = "0x51BB8C0", VA = "0x1851BCCC0")]
	public MNBDGEMMGMF MOOCLKPHCAO()
	{
		return default(MNBDGEMMGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x51BB880", Offset = "0x51BA480", VA = "0x1851BB880")]
	public void BMFOBKMHLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51BC6C0", Offset = "0x51BB2C0", VA = "0x1851BC6C0")]
	public bool JFIBIBKIIPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE30", Offset = "0x51BCA30", VA = "0x1851BDE30")]
	public bool OLCJIINABGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51BCA50", Offset = "0x51BB650", VA = "0x1851BCA50")]
	public void LCFCCHJHEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51BC340", Offset = "0x51BAF40", VA = "0x1851BC340")]
	public bool HMKFEOPMAMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51BCE40", Offset = "0x51BBA40", VA = "0x1851BCE40")]
	public bool NGMEPHKHLIO(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51BD490", Offset = "0x51BC090", VA = "0x1851BD490")]
	public bool OBKBBHNCGNN(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51BCC00", Offset = "0x51BB800", VA = "0x1851BCC00")]
	public bool MKBBGKKEBBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51BCAE0", Offset = "0x51BB6E0", VA = "0x1851BCAE0")]
	public void LECJNHNEKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51BC660", Offset = "0x51BB260", VA = "0x1851BC660")]
	public bool JCCOHPNHBNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51BBE00", Offset = "0x51BAA00", VA = "0x1851BBE00")]
	public bool FABBNLFMFDG(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51BCEC0", Offset = "0x51BBAC0", VA = "0x1851BCEC0")]
	public bool NMCFMCPCBDB(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51BCC60", Offset = "0x51BB860", VA = "0x1851BCC60")]
	public bool MOFMGBPLFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51BC9A0", Offset = "0x51BB5A0", VA = "0x1851BC9A0")]
	public void KGEBHBJAGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51BDDD0", Offset = "0x51BC9D0", VA = "0x1851BDDD0")]
	public bool OHLPACMKPHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x51BBCC0", Offset = "0x51BA8C0", VA = "0x1851BBCC0")]
	public void EGGFOGLBMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51BD550", Offset = "0x51BC150", VA = "0x1851BD550")]
	private void ODHKNFKBIBL(out byte[] IIIDLAGBFEE, out int BMPLOMLEEPP, out int FBELCFFBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51BBD50", Offset = "0x51BA950", VA = "0x1851BBD50")]
	private static int EJOPLIGJPIC(char LEOEMBMBFBC, char GHDGKPNPOBN, char EKIHFBHEKEC, char EIEOEGFMKEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51BB7B0", Offset = "0x51BA3B0", VA = "0x1851BB7B0")]
	private static int BLECCDCJFOO(char IODEOJKDCNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51BBBC0", Offset = "0x51BA7C0", VA = "0x1851BBBC0")]
	public ArraySegment<byte> EDANADJEPFF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51BC5C0", Offset = "0x51BB1C0", VA = "0x1851BC5C0")]
	public string IMGKNGLCBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51BCB70", Offset = "0x51BB770", VA = "0x1851BCB70")]
	public string MANAPIJEGEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51BB5E0", Offset = "0x51BA1E0", VA = "0x1851BB5E0")]
	public ArraySegment<byte> BFNMMCFEPHM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51BC3A0", Offset = "0x51BAFA0", VA = "0x1851BC3A0")]
	public ArraySegment<byte> HMPMOMGBNJN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51BBE80", Offset = "0x51BAA80", VA = "0x1851BBE80")]
	public bool FDOGOBIIKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51BDD10", Offset = "0x51BC910", VA = "0x1851BDD10")]
	private static bool OFBGBKADAAF(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51BC7C0", Offset = "0x51BB3C0", VA = "0x1851BC7C0")]
	private void JJMNIGLHHNA(MNBDGEMMGMF JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51BB9C0", Offset = "0x51BA5C0", VA = "0x1851BB9C0")]
	public void BNGOLHFJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51BC1C0", Offset = "0x51BADC0", VA = "0x1851BC1C0")]
	private void GFFHNPAKJPN(int EAJOOLPCDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51BC2F0", Offset = "0x51BAEF0", VA = "0x1851BC2F0")]
	public sbyte GKHGHCCKMDI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51BC290", Offset = "0x51BAE90", VA = "0x1851BC290")]
	public short GKGCAGNIFGK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51BDEF0", Offset = "0x51BCAF0", VA = "0x1851BDEF0")]
	public int POHKECICMGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51BC0C0", Offset = "0x51BACC0", VA = "0x1851BC0C0")]
	public long FJDGBGKNLND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51BCBA0", Offset = "0x51BB7A0", VA = "0x1851BCBA0")]
	public byte MIKONJDFFEM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE90", Offset = "0x51BCA90", VA = "0x1851BDE90")]
	public ushort PAAPNJDFIJA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51BB9D0", Offset = "0x51BA5D0", VA = "0x1851BB9D0")]
	public uint CLCMAHJMHOC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51BB560", Offset = "0x51BA160", VA = "0x1851BB560")]
	public ulong ANPDDMDKNFL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51BC4F0", Offset = "0x51BB0F0", VA = "0x1851BC4F0")]
	public float IJECNOKHBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x51BB490", Offset = "0x51BA090", VA = "0x1851BB490")]
	public double AINDKHMENLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x51BC3E0", Offset = "0x51BAFE0", VA = "0x1851BC3E0")]
	public ArraySegment<byte> IFDDHGFBHHP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51BBA30", Offset = "0x51BA630", VA = "0x1851BBA30")]
	private static int DMHAEOHBHFG(byte[] EHAMCGPFFID, int HPNBOGMLOLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BKIIPNGFFKI : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference HEDHMLEKPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JHFGKBLLOPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LDPKODMFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2020F50", Offset = "0x201FB50", VA = "0x182020F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CPGGHEFPEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x913EA0", Offset = "0x912AA0", VA = "0x180913EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51B0BD0", Offset = "0x51AF7D0", VA = "0x1851B0BD0")]
	public BKIIPNGFFKI(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x51B0C40", Offset = "0x51AF840", VA = "0x1851B0C40")]
	public BKIIPNGFFKI(string HDKJDEIGPPL, byte[] IEDJKJMGMCB, int HPNBOGMLOLG, int JHFGKBLLOPH, string ODGCKIFPDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FOOFLNNKKNA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KCMEBGMHKHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void BBPGGJBKCIE(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG MOPBAELKKDA);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object MMMLAJGMPLL(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG MOPBAELKKDA);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class NLLAIECJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class CCJENINHPJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public CCJENINHPJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x3844140", Offset = "0x3842D40", VA = "0x183844140")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4F1BF70", Offset = "0x4F1AB70", VA = "0x184F1BF70")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, ECLEPONANIG, byte[]> CPGCJMALEGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, ECLEPONANIG> POGELFFFOIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly BBPGGJBKCIE AIONPDNNEIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, ECLEPONANIG, ArraySegment<byte>> BKDHLOBMMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, ECLEPONANIG, string> FHAHLENJICH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, ECLEPONANIG, object> CPDBPEGMOPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, ECLEPONANIG, object> CEOHDJAMPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, ECLEPONANIG, object> JKIFHLFHALJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly MMMLAJGMPLL ANKGHBBMFKB;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4F24C30", Offset = "0x4F23830", VA = "0x184F24C30")]
			public NLLAIECJHOI(Type BIEGICDMJCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x34541C0", Offset = "0x3452DC0", VA = "0x1834541C0")]
			private static T LDEJBIHPFHF<T>(DynamicMethod IIEAKKJENEJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4F249E0", Offset = "0x4F235E0", VA = "0x184F249E0")]
			private static MethodInfo JPHNHDJFBJA(Type BIEGICDMJCM, string NLCIGFDKGEE, Type[] EJOIHFKBLHN)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, NLLAIECJHOI> FFBFNDBHNOO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::PPCMGBHHGII<NLLAIECJHOI> HGIOIKCLCEO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4F22740", Offset = "0x4F21340", VA = "0x184F22740")]
		static KCMEBGMHKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F226B0", Offset = "0x4F212B0", VA = "0x184F226B0")]
		private static NLLAIECJHOI KAAMKKLEPKC(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4F22520", Offset = "0x4F21120", VA = "0x184F22520")]
		public static void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4F22400", Offset = "0x4F21000", VA = "0x184F22400")]
		public static void CLPGJOCDFOA(Type BIEGICDMJCM, ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class EHONKNPAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] NFMJIELOGNG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F1E860", Offset = "0x4F1D460", VA = "0x184F1E860")]
		public static byte[] FDFMHAOFGLE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ECLEPONANIG HMAEAEFDNCD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] OFEIHLGAINA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] JHDPIBINNFI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static ECLEPONANIG KEEDNCFNJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51C2400", Offset = "0x51C1000", VA = "0x1851C2400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MKNOGDLMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x51C1600", Offset = "0x51C0200", VA = "0x1851C1600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x51C2390", Offset = "0x51C0F90", VA = "0x1851C2390")]
	public static void PBGMGIBLABI(ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3502C30", Offset = "0x3501830", VA = "0x183502C30")]
	public static byte[] CLPGJOCDFOA<T>(T KMFLGGMLFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3502D40", Offset = "0x3501940", VA = "0x183502D40")]
	public static byte[] CLPGJOCDFOA<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3502BA0", Offset = "0x35017A0", VA = "0x183502BA0")]
	public static void CLPGJOCDFOA<T>(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3502FC0", Offset = "0x3501BC0", VA = "0x183502FC0")]
	public static void CLPGJOCDFOA<T>(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3502CB0", Offset = "0x35018B0", VA = "0x183502CB0")]
	public static void CLPGJOCDFOA<T>(Stream HPPBGHGOBLD, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3502EA0", Offset = "0x3501AA0", VA = "0x183502EA0")]
	public static void CLPGJOCDFOA<T>(Stream HPPBGHGOBLD, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3503400", Offset = "0x3502000", VA = "0x183503400")]
	public static ArraySegment<byte> LNHPCNIMABF<T>(T KMFLGGMLFJA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3503280", Offset = "0x3501E80", VA = "0x183503280")]
	public static ArraySegment<byte> LNHPCNIMABF<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x35030A0", Offset = "0x3501CA0", VA = "0x1835030A0")]
	public static string IAINPCLLFDI<T>(T GKFICKKHACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3503120", Offset = "0x3501D20", VA = "0x183503120")]
	public static string IAINPCLLFDI<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3503EF0", Offset = "0x3502AF0", VA = "0x183503EF0")]
	public static T MNOLKCHHLIP<T>(string KKNHJNEDEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3503E00", Offset = "0x3502A00", VA = "0x183503E00")]
	public static T MNOLKCHHLIP<T>(string KKNHJNEDEHL, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3504730", Offset = "0x3503330", VA = "0x183504730")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x35040F0", Offset = "0x3502CF0", VA = "0x1835040F0")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x35047B0", Offset = "0x35033B0", VA = "0x1835047B0")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, int HPNBOGMLOLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3503F90", Offset = "0x3502B90", VA = "0x183503F90")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, int HPNBOGMLOLG, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3504190", Offset = "0x3502D90", VA = "0x183504190")]
	public static T MNOLKCHHLIP<T>(ref FHNCKNEPFID LDNLHJMBEIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3504500", Offset = "0x3503100", VA = "0x183504500")]
	public static T MNOLKCHHLIP<T>(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3504840", Offset = "0x3503440", VA = "0x183504840")]
	public static T MNOLKCHHLIP<T>(Stream HPPBGHGOBLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3504290", Offset = "0x3502E90", VA = "0x183504290")]
	public static T MNOLKCHHLIP<T>(Stream HPPBGHGOBLD, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51C13B0", Offset = "0x51BFFB0", VA = "0x1851C13B0")]
	public static string CDCAOLJEGBI(byte[] KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51C12B0", Offset = "0x51BFEB0", VA = "0x1851C12B0")]
	public static string CDCAOLJEGBI(byte[] KKNHJNEDEHL, int HPNBOGMLOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51C14E0", Offset = "0x51C00E0", VA = "0x1851C14E0")]
	public static string CDCAOLJEGBI(string KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x51C1820", Offset = "0x51C0420", VA = "0x1851C1820")]
	public static byte[] KMIPBNPKIBI(byte[] KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x51C1700", Offset = "0x51C0300", VA = "0x1851C1700")]
	public static byte[] KMIPBNPKIBI(byte[] KKNHJNEDEHL, int HPNBOGMLOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x51C1970", Offset = "0x51C0570", VA = "0x1851C1970")]
	public static byte[] KMIPBNPKIBI(string KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x51C1AB0", Offset = "0x51C06B0", VA = "0x1851C1AB0")]
	private static void MIOMJNAFJDI(ref FHNCKNEPFID LDNLHJMBEIM, ref DOFDDFPOMMF FHGALIAOBLC, int EMDDAPNEEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51C1660", Offset = "0x51C0260", VA = "0x1851C1660")]
	private static int IDKDCCKJBHC(Stream EDEJMAKDAOA, ref byte[] NFMJIELOGNG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MNBDGEMMGMF : byte
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
public struct DOFDDFPOMMF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NLNEGODMDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NFMJIELOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int HPNBOGMLOLG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OFLOOHIHEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x7751E0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x51B83D0", Offset = "0x51B6FD0", VA = "0x1851B83D0")]
	public void OKNDODPLLNL(int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x51B7770", Offset = "0x51B6370", VA = "0x1851B7770")]
	public static byte[] DPEKEGKFHAB(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x51B8160", Offset = "0x51B6D60", VA = "0x1851B8160")]
	public static byte[] NKNKPMFDIPK(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x51B7630", Offset = "0x51B6230", VA = "0x1851B7630")]
	public static byte[] CNAIAJHCJCG(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x51B71F0", Offset = "0x51B5DF0", VA = "0x1851B71F0")]
	public static byte[] ANBKJMCPAMB(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCEB450", Offset = "0xCEA050", VA = "0x180CEB450")]
	public DOFDDFPOMMF(byte[] PPGNAMOOEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51B7950", Offset = "0x51B6550", VA = "0x1851B7950")]
	public ArraySegment<byte> FDFMHAOFGLE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F90", Offset = "0x51B6B90", VA = "0x1851B7F90")]
	public byte[] LMJOLBHEOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x51B83F0", Offset = "0x51B6FF0", VA = "0x1851B83F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x51B83E0", Offset = "0x51B6FE0", VA = "0x1851B83E0")]
	public void PHCHFJPBPOA(int MMJADBDACLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51B65B0", Offset = "0x51B51B0", VA = "0x1851B65B0")]
	public void JBKLAODHJCC(byte BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x51B7EB0", Offset = "0x51B6AB0", VA = "0x1851B7EB0")]
	public void JBKLAODHJCC(byte[] BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x51B71B0", Offset = "0x51B5DB0", VA = "0x1851B71B0")]
	public void AIHHAKJNJBB(byte BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x51B78D0", Offset = "0x51B64D0", VA = "0x1851B78D0")]
	public void EMDHFENDCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x51B8070", Offset = "0x51B6C70", VA = "0x1851B8070")]
	public void MJFBLGFMJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51B75E0", Offset = "0x51B61E0", VA = "0x1851B75E0")]
	public void CLFPAFJEFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x51B80C0", Offset = "0x51B6CC0", VA = "0x1851B80C0")]
	public void MPADNNCKMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F40", Offset = "0x51B6B40", VA = "0x1851B7F40")]
	public void KKDPKKBBNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x51B8110", Offset = "0x51B6D10", VA = "0x1851B8110")]
	public void NCEKAAPKDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x51B8370", Offset = "0x51B6F70", VA = "0x1851B8370")]
	public void OHPIDNLMPDM(string BBEHMKMODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51B7E00", Offset = "0x51B6A00", VA = "0x1851B7E00")]
	public void GFFEGFECPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51B82A0", Offset = "0x51B6EA0", VA = "0x1851B82A0")]
	public void OHCAIIKBKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x51B7370", Offset = "0x51B5F70", VA = "0x1851B7370")]
	public void BMMBHBNGKAB(bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51B7850", Offset = "0x51B6450", VA = "0x1851B7850")]
	public void EAFKALCKAFI(float GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x51B7560", Offset = "0x51B6160", VA = "0x1851B7560")]
	public void BNFJECHLACP(double GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x51B7E50", Offset = "0x51B6A50", VA = "0x1851B7E50")]
	public void HDKNFFFMDLO(byte GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51B8010", Offset = "0x51B6C10", VA = "0x1851B8010")]
	public void MBGEIOOOPHJ(ushort GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x51B7E80", Offset = "0x51B6A80", VA = "0x1851B7E80")]
	public void INKIGEMMDAP(uint GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51B7920", Offset = "0x51B6520", VA = "0x1851B7920")]
	public void EODPALIIPIF(ulong GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x51B7340", Offset = "0x51B5F40", VA = "0x1851B7340")]
	public void BBNIDPFHDDO(sbyte GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x51B7DD0", Offset = "0x51B69D0", VA = "0x1851B7DD0")]
	public void FJNGIBNLCOA(short GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x51B8040", Offset = "0x51B6C40", VA = "0x1851B8040")]
	public void MCDADLDAIEM(int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F10", Offset = "0x51B6B10", VA = "0x1851B7F10")]
	public void JMNCMAGABKG(long GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x51B7A00", Offset = "0x51B6600", VA = "0x1851B7A00")]
	public void FJFBDJLPGMG(string GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OIJDCLPFBIM : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class BOJCPICAHNA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x23D6420", Offset = "0x23D5020", VA = "0x1823D6420")]
		static BOJCPICAHNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private OIJDCLPFBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class IDDNDICPBJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> FPIFFIOCGBO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46157A0", Offset = "0x46143A0", VA = "0x1846157A0")]
	static IDDNDICPBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4615090", Offset = "0x4613C90", VA = "0x184615090")]
	internal static object GGDPDDGCHAL(Type NDJEJACDKEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DBMEJEOCJCJ : global::LKBCOOCHDMC<Vector2>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x51B5F60", Offset = "0x51B4B60", VA = "0x1851B5F60")]
	public DBMEJEOCJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51B5AD0", Offset = "0x51B46D0", VA = "0x1851B5AD0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector2 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x51B5C80", Offset = "0x51B4880", VA = "0x1851B5C80", Slot = "5")]
	public Vector2 MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PNBENEPHLOP : global::LKBCOOCHDMC<Vector3>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4F2DE00", Offset = "0x4F2CA00", VA = "0x184F2DE00")]
	public PNBENEPHLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F2DB20", Offset = "0x4F2C720", VA = "0x184F2DB20", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector3 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4F2DC40", Offset = "0x4F2C840", VA = "0x184F2DC40", Slot = "5")]
	public Vector3 MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OPBMICDPKHH : global::LKBCOOCHDMC<Vector4>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B830", Offset = "0x4F2A430", VA = "0x184F2B830")]
	public OPBMICDPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x461A300", Offset = "0x4618F00", VA = "0x18461A300", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector4 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F2B610", Offset = "0x4F2A210", VA = "0x184F2B610", Slot = "5")]
	public Vector4 MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KIGCAHADMEK : global::LKBCOOCHDMC<Quaternion>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x461A6E0", Offset = "0x46192E0", VA = "0x18461A6E0")]
	public KIGCAHADMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x461A300", Offset = "0x4618F00", VA = "0x18461A300", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Quaternion GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x461A450", Offset = "0x4619050", VA = "0x18461A450", Slot = "5")]
	public Quaternion MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PEMLHGIEKJK : global::LKBCOOCHDMC<Color>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C230", Offset = "0x4F2AE30", VA = "0x184F2C230")]
	public PEMLHGIEKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x461A300", Offset = "0x4618F00", VA = "0x18461A300", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Color GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C010", Offset = "0x4F2AC10", VA = "0x184F2C010", Slot = "5")]
	public Color MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IKIFIEFOCKK : global::LKBCOOCHDMC<Bounds>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4617C80", Offset = "0x4616880", VA = "0x184617C80")]
	public IKIFIEFOCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46177B0", Offset = "0x46163B0", VA = "0x1846177B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Bounds GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4617950", Offset = "0x4616550", VA = "0x184617950", Slot = "5")]
	public Bounds MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class PFGDOALPDIF : global::LKBCOOCHDMC<Rect>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly KOGDNCENHJL GDFFDJBCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] JFMKKHGAFLO;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C910", Offset = "0x4F2B510", VA = "0x184F2C910")]
	public PFGDOALPDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C560", Offset = "0x4F2B160", VA = "0x184F2C560", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Rect GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C6D0", Offset = "0x4F2B2D0", VA = "0x184F2C6D0", Slot = "5")]
	public Rect MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MBFLFPGENDB : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class CCBAFBMDFKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x39BF350", Offset = "0x39BDF50", VA = "0x1839BF350")]
		static CCBAFBMDFKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private MBFLFPGENDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MNMDCFDLAMO : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class GLHJJAGBONB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x33A1870", Offset = "0x33A0470", VA = "0x1833A1870")]
		static GLHJJAGBONB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class HIBPLCOHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> KNAIFFKDIFL;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F5E0", Offset = "0x4F1E1E0", VA = "0x184F1F5E0")]
		internal static object GGDPDDGCHAL(Type NDJEJACDKEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private MNMDCFDLAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OECOPDMAIAG : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class CIOKOPCKGBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x35752D0", Offset = "0x3573ED0", VA = "0x1835752D0")]
		static CIOKOPCKGBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OECOPDMAIAG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool ODMMJCPJNNB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static DIAHDCBEFFK[] EMKJNOOCILN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static ECLEPONANIG[] POPNGAPBKKH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private OECOPDMAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F26F40", Offset = "0x4F25B40", VA = "0x184F26F40")]
	public static void EHMHLLLMBAF(params ECLEPONANIG[] POPNGAPBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F27020", Offset = "0x4F25C20", VA = "0x184F27020")]
	public static void EHMHLLLMBAF(params DIAHDCBEFFK[] EMKJNOOCILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F26CB0", Offset = "0x4F258B0", VA = "0x184F26CB0")]
	public static void BIBMIBHFBCM(DIAHDCBEFFK[] EMKJNOOCILN, ECLEPONANIG[] POPNGAPBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class LHEGHLFPDKL : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class CNJCKOJHKHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3594930", Offset = "0x3593530", VA = "0x183594930")]
		static CNJCKOJHKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private LHEGHLFPDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PNAEKNGMOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly ECLEPONANIG BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly ECLEPONANIG HNAGHEPPKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly ECLEPONANIG CAINAFDBKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly ECLEPONANIG CDFMJGKKAAF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly ECLEPONANIG NAGJGNCGNAG;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly ECLEPONANIG JAGHEDBFFOP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly ECLEPONANIG IBMOLHEKOBH;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly ECLEPONANIG FDGOJCELFMH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly ECLEPONANIG HBNPMLOFHPD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly ECLEPONANIG IHGHDENHMAK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly ECLEPONANIG MINGCMJOEEI;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly ECLEPONANIG LGNLDHCINOG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CHBGCGHKOPG
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly ECLEPONANIG BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ECLEPONANIG FGIFDCMHIOC;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GOINLKODAGN
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly ECLEPONANIG BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly ECLEPONANIG HNAGHEPPKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly ECLEPONANIG CAINAFDBKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly ECLEPONANIG CDFMJGKKAAF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly ECLEPONANIG NAGJGNCGNAG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly ECLEPONANIG JAGHEDBFFOP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ECLEPONANIG IBMOLHEKOBH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly ECLEPONANIG FDGOJCELFMH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly ECLEPONANIG HBNPMLOFHPD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly ECLEPONANIG IHGHDENHMAK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly ECLEPONANIG MINGCMJOEEI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly ECLEPONANIG LGNLDHCINOG;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class HBJPIHKCGOK
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> KNAIFFKDIFL;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46120B0", Offset = "0x4610CB0", VA = "0x1846120B0")]
	internal static object GGDPDDGCHAL(Type NDJEJACDKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4613A40", Offset = "0x4612640", VA = "0x184613A40")]
	private static object JIHEOLKLADA(Type FIFJIHHKPEH, Type[] HLCLPJOEDAN, params object[] EJOIHFKBLHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class KABDEOJOCOB : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class LAOKPCNKEPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A34FD0", Offset = "0x2A33BD0", VA = "0x182A34FD0")]
		static LAOKPCNKEPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4619CA0", Offset = "0x46188A0", VA = "0x184619CA0")]
	static KABDEOJOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private KABDEOJOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GJJDKMNHGIL : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class LNJLOANKIEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x354C890", Offset = "0x354B490", VA = "0x18354C890")]
		static LNJLOANKIEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x51C3780", Offset = "0x51C2380", VA = "0x1851C3780")]
	static GJJDKMNHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private GJJDKMNHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class IMJMANNAMBC : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LMCGFOCDPIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3546450", Offset = "0x3545050", VA = "0x183546450")]
		static LMCGFOCDPIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4617EC0", Offset = "0x4616AC0", VA = "0x184617EC0")]
	static IMJMANNAMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private IMJMANNAMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class KIEFALEGKCJ : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class BKFKFMMNACL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2887C90", Offset = "0x2886890", VA = "0x182887C90")]
		static BKFKFMMNACL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x461A1D0", Offset = "0x4618DD0", VA = "0x18461A1D0")]
	static KIEFALEGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private KIEFALEGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class OGPLIMMAGHJ : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class JBBPJMBPNOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B071C0", Offset = "0x2B05DC0", VA = "0x182B071C0")]
		static JBBPJMBPNOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F271E0", Offset = "0x4F25DE0", VA = "0x184F271E0")]
	static OGPLIMMAGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private OGPLIMMAGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BEIFCJDKFGA : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class JEHPAHPKPEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B14F50", Offset = "0x2B13B50", VA = "0x182B14F50")]
		static JEHPAHPKPEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly ANANODFDIKB AGJCPOHEOBI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x51B00B0", Offset = "0x51AECB0", VA = "0x1851B00B0")]
	static BEIFCJDKFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private BEIFCJDKFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class LNKBJAMGHGA : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class LHJCJHJFIFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x24FF280", Offset = "0x24FDE80", VA = "0x1824FF280")]
		static LHJCJHJFIFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LNKBJAMGHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class HFKPNLGBMLC : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class CBMLCIHDELE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39BBC30", Offset = "0x39BA830", VA = "0x1839BBC30")]
		static CBMLCIHDELE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HFKPNLGBMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HFAPKPGNFNJ : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class ODGFFLDLFOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x27E8BE0", Offset = "0x27E77E0", VA = "0x1827E8BE0")]
		static ODGFFLDLFOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HFAPKPGNFNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class IDNKGANDKMN : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class DBAAHDAPCPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2E10CF0", Offset = "0x2E0F8F0", VA = "0x182E10CF0")]
		static DBAAHDAPCPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IDNKGANDKMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class ACJEKMHJBCE : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class KBNGNJFAHMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x280D900", Offset = "0x280C500", VA = "0x18280D900")]
		static KBNGNJFAHMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public ACJEKMHJBCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class AKGEFKOPOPO : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class GDEELHDEKJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3488720", Offset = "0x3487320", VA = "0x183488720")]
		static GDEELHDEKJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> JFENHKOBMIC;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool OEPDJABOINL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public AKGEFKOPOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class KKHJLNLFCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct EONIPAGNNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public PGBPOAOHMEE HDMAGBADBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder HNBJFIAPLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder CPFBMPODIPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class DOBFKGPECMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class KMNGKEBFKBD
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo CNAIAJHCJCG;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo NKNKPMFDIPK;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo ANBKJMCPAMB;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo DPEKEGKFHAB;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo OHCAIIKBKMK;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo JBKLAODHJCC;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo CLFPAFJEFJG;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo MPADNNCKMNO;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo KKDPKKBBNCI;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4F22990", Offset = "0x4F21590", VA = "0x184F22990")]
			static KMNGKEBFKBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class MLDFEMDAINF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo JFIBIBKIIPO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo LECJNHNEKMI;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo FABBNLFMFDG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo JBFCNKDLHAP;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo BNGOLHFJLEP;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo GDIDANNFJND;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo BLLADAFDHDF;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4F23AD0", Offset = "0x4F226D0", VA = "0x184F23AD0")]
			static MLDFEMDAINF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GIEHOIKJINP
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FEOPAPPFEJD;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo EDFJLPBOOJA;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo KGIOELFBODH;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo ILCHNEBHGJJ;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo FLNDBFCDKCH;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo EAGJIDLMLNI;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo PENBAPFFMHB;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo JJMBCHIKGHO;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo DKOECILACHM;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo NNBNBNMHHEF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo MBFNOLNOJAP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo AIFPDABGJCC;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo NFBGFCODOJA;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo CBNJJHLECPG;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4F1C840", Offset = "0x4F1B440", VA = "0x184F1C840")]
		public static MethodInfo CLPGJOCDFOA(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F1CB10", Offset = "0x4F1B710", VA = "0x184F1CB10")]
		public static MethodInfo MNOLKCHHLIP(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4F1CD80", Offset = "0x4F1B980", VA = "0x184F1CD80")]
		public static MethodInfo OAFOCKPBJBL(Type BIEGICDMJCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OAEMMLDFDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<PGBPOAOHMEE, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OAEMMLDFDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class HFDDHAENLHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public OAEMMLDFDKD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public HFDDHAENLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F500", Offset = "0x4F1E100", VA = "0x184F1F500")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F540", Offset = "0x4F1E140", VA = "0x184F1F540")]
		internal bool <BuildType>b__2(int index, PGBPOAOHMEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GFOMLFPAHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public OAEMMLDFDKD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GFOMLFPAHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4F1EB60", Offset = "0x4F1D760", VA = "0x184F1EB60")]
		internal bool <BuildType>b__3(int index, PGBPOAOHMEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EAHJEHDNDME
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

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public EAHJEHDNDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F1E520", Offset = "0x4F1D120", VA = "0x184F1E520")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NNDJACBLPGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public NNDJACBLPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4F26930", Offset = "0x4F25530", VA = "0x184F26930")]
		internal bool <BuildAnonymousFormatter>b__2(PGBPOAOHMEE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IPLPHBDMGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EAHJEHDNDME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public IPLPHBDMGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F21B40", Offset = "0x4F20740", VA = "0x184F21B40")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4F21B50", Offset = "0x4F20750", VA = "0x184F21B50")]
		internal bool <BuildAnonymousFormatter>b__6(int index, PGBPOAOHMEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LNMMKAGJEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EAHJEHDNDME CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LNMMKAGJEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F23770", Offset = "0x4F22370", VA = "0x184F23770")]
		internal bool <BuildAnonymousFormatter>b__7(int index, PGBPOAOHMEE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GMKMJOPDOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GMKMJOPDOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A0BD0", VA = "0x1806A1FD0")]
		internal Label <BuildSerialize>b__1(PGBPOAOHMEE _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class NINEDALDEDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EONIPAGNNJL[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, PGBPOAOHMEE, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public BGDOAOECCIG argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public BGDOAOECCIG argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public NINEDALDEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4F248C0", Offset = "0x4F234C0", VA = "0x184F248C0")]
		internal EONIPAGNNJL <BuildDeserialize>b__0(PGBPOAOHMEE item)
		{
			return default(EONIPAGNNJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CKDJFAPEMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NINEDALDEDA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public CKDJFAPEMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4F1C330", Offset = "0x4F1AF30", VA = "0x184F1C330")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4F1C5E0", Offset = "0x4F1B1E0", VA = "0x184F1C5E0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class MFNJNIHLMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public PGBPOAOHMEE item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MFNJNIHLMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x113EAA0", Offset = "0x113D6A0", VA = "0x18113EAA0")]
		internal bool <EmitNewObject>b__0(EONIPAGNNJL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class EEEBCKEOIPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PGBPOAOHMEE item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public EEEBCKEOIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x113EAA0", Offset = "0x113D6A0", VA = "0x18113EAA0")]
		internal bool <EmitNewObject>b__2(EONIPAGNNJL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex NHKCDGICKHJ;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LEMODFFIKDK;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GLMEAMHOMLP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> LAPDAMMKGNM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D01FE0", Offset = "0x3D00BE0", VA = "0x183D01FE0")]
	public static object DBODLKDNNEM<T>(ANANODFDIKB AGJCPOHEOBI, ECLEPONANIG IJNCCJAKJOI, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D420", Offset = "0x3D0C020", VA = "0x183D0D420")]
	public static object KCKCFHGHKEK<T>(ECLEPONANIG IJNCCJAKJOI, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL, bool JLPMIGAFJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x461B0D0", Offset = "0x4619CD0", VA = "0x18461B0D0")]
	private static TypeInfo BDOJKEENDPE(ANANODFDIKB AGJCPOHEOBI, Type BIEGICDMJCM, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4620CA0", Offset = "0x461F8A0", VA = "0x184620CA0")]
	public static object NCENDCOIFBB(Type BIEGICDMJCM, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL, bool JLPMIGAFJEJ, bool BLAHBPOEOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x461F3C0", Offset = "0x461DFC0", VA = "0x18461F3C0")]
	private static Dictionary<PGBPOAOHMEE, FieldInfo> LKOENEEHEKD(TypeBuilder CNPCNGBKDBI, ANHAKGCJAHL DHBOJIINPOH, ConstructorInfo IBPPDEDMEKC, FieldBuilder NJALFMNOAPL, ILGenerator MELBLMPENNB, bool OEPDJABOINL, bool FJNLHMAPMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x461AA50", Offset = "0x4619650", VA = "0x18461AA50")]
	private static Dictionary<PGBPOAOHMEE, FieldInfo> AHIKKEHANPB(TypeBuilder CNPCNGBKDBI, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x461CFB0", Offset = "0x461BBB0", VA = "0x18461CFB0")]
	private static void JDMNBMACBCI(Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB, Action JDEMAONCDFJ, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, bool OEPDJABOINL, bool FJNLHMAPMEP, int BONMOGBABJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4620750", Offset = "0x461F350", VA = "0x184620750")]
	private static void MKOKDLPOMPB(TypeInfo BIEGICDMJCM, PGBPOAOHMEE INHJAOHPFCJ, ILGenerator MELBLMPENNB, int BNNEENLPEFO, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, BGDOAOECCIG FHGALIAOBLC, BGDOAOECCIG GGGECDMHEBI, BGDOAOECCIG KMAIOPKCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x461BB60", Offset = "0x461A760", VA = "0x18461BB60")]
	private static void BEFMGEKOLMK(Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, bool MGKAEDHHCAB, int BONMOGBABJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x461ED50", Offset = "0x461D950", VA = "0x18461ED50")]
	private static void LAGLEDHAGFO(ILGenerator MELBLMPENNB, EONIPAGNNJL DHBOJIINPOH, int BNNEENLPEFO, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, BGDOAOECCIG LDNLHJMBEIM, BGDOAOECCIG KMAIOPKCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x461FAA0", Offset = "0x461E6A0", VA = "0x18461FAA0")]
	private static LocalBuilder MBBGJNBFHMO(ILGenerator MELBLMPENNB, Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, EONIPAGNNJL[] NFHEICNCFMJ, bool JHKCINPJOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x461E4D0", Offset = "0x461D0D0", VA = "0x18461E4D0")]
	private static bool JINNMECLADC(ConstructorInfo DHONEMIKGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x461F210", Offset = "0x461DE10", VA = "0x18461F210")]
	private static bool LBHKJFLGGMH(Type BIEGICDMJCM, out Type MPEPJMOMGGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void AGOCOFFCFAH<T>(byte[][] NJALFMNOAPL, object[] KIICPBGNDCM, ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T CACKAMEIKNN<T>(object[] KIICPBGNDCM, ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG MOPBAELKKDA);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class CLMDGEBICMB<T> : global::LKBCOOCHDMC<T>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] NJALFMNOAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] ACFNKICABCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] HPDDDHNNNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::AGOCOFFCFAH<T> KKIKIOMPACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::CACKAMEIKNN<T> KMACGJHLGJP;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2690800", Offset = "0x268F400", VA = "0x182690800")]
	public CLMDGEBICMB(byte[][] NJALFMNOAPL, object[] ACFNKICABCE, object[] HPDDDHNNNKJ, global::AGOCOFFCFAH<T> KKIKIOMPACD, global::CACKAMEIKNN<T> KMACGJHLGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x35806E0", Offset = "0x357F2E0", VA = "0x1835806E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x35807C0", Offset = "0x357F3C0", VA = "0x1835807C0", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class EBEAGAKJIJC : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class DCICBPIEDCI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2E16570", Offset = "0x2E15170", VA = "0x182E16570")]
		static DCICBPIEDCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private EBEAGAKJIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class OJCEJFJPBKL : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class KHOFOIIPIOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x36AB870", Offset = "0x36AA470", VA = "0x1836AB870")]
		static KHOFOIIPIOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private OJCEJFJPBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class LKFCAGBGJBP
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly ECLEPONANIG[] JLPEEKNGIJJ;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class ONDKCGAIIJK : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class NFFHHFJGKFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2692B20", Offset = "0x2691720", VA = "0x182692B20")]
		static NFFHHFJGKFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class HCOFJOPDBBI : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class LPBOBHJPPEE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3551500", Offset = "0x3550100", VA = "0x183551500")]
			static LPBOBHJPPEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private HCOFJOPDBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private ONDKCGAIIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class BLGFOAGCBLH : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class GCADLBJPNIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x347D500", Offset = "0x347C100", VA = "0x18347D500")]
		static GCADLBJPNIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class CFJDEAIFBGB : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class EGFNLOBLPBK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2DF7CA0", Offset = "0x2DF68A0", VA = "0x182DF7CA0")]
			static EGFNLOBLPBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private CFJDEAIFBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private BLGFOAGCBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class EPJCBPCEIAA : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class KFEAJMGEKJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x36962D0", Offset = "0x3694ED0", VA = "0x1836962D0")]
		static KFEAJMGEKJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class BNNNFALHJAJ : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class IOEAGHKDPBP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2FAB970", Offset = "0x2FAA570", VA = "0x182FAB970")]
			static IOEAGHKDPBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private BNNNFALHJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private EPJCBPCEIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class GOKFDIDIAAG : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class EBBLJBLKJML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2DE3520", Offset = "0x2DE2120", VA = "0x182DE3520")]
		static EBBLJBLKJML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class EEGDJECFLLA : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class IPJJEPMFOIO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2FAF750", Offset = "0x2FAE350", VA = "0x182FAF750")]
			static IPJJEPMFOIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private EEGDJECFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private GOKFDIDIAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class BJMILNEOFCH : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class JLANLIIPKCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3E3EE40", Offset = "0x3E3DA40", VA = "0x183E3EE40")]
		static JLANLIIPKCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class GEINDHIHCHB : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class JKCADDHPNAM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3E3A1E0", Offset = "0x3E38DE0", VA = "0x183E3A1E0")]
			static JKCADDHPNAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private GEINDHIHCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private BJMILNEOFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class FDIGDCAFECG : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class ALIFBBIOPBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3BA4570", Offset = "0x3BA3170", VA = "0x183BA4570")]
		static ALIFBBIOPBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class GOGDFHOMLIJ : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class NELEBMCODFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x268CBA0", Offset = "0x268B7A0", VA = "0x18268CBA0")]
			static NELEBMCODFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private GOGDFHOMLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private FDIGDCAFECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class LHLHDKCALGH : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class NHNKOEDMKGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x269B360", Offset = "0x2699F60", VA = "0x18269B360")]
		static NHNKOEDMKGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class NPJJBBLMMPC : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class PDBOBIMOPHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B46FC0", Offset = "0x2B45BC0", VA = "0x182B46FC0")]
			static PDBOBIMOPHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private NPJJBBLMMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private LHLHDKCALGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class IHJNLDFHNHD : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class HEDIEDNJDKD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BE0B30", Offset = "0x3BDF730", VA = "0x183BE0B30")]
		static HEDIEDNJDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class HCINNBDDFKI : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class CIJPDLGFEFL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D892D0", Offset = "0x3D87ED0", VA = "0x183D892D0")]
			static CIJPDLGFEFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private HCINNBDDFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private IHJNLDFHNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class IMKLBCBNCML : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class BEKGHLAHNBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2873F10", Offset = "0x2872B10", VA = "0x182873F10")]
		static BEKGHLAHNBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class MEBNEMNFBLA : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class ODJFOJAGMJM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x27EB9A0", Offset = "0x27EA5A0", VA = "0x1827EB9A0")]
			static ODJFOJAGMJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private MEBNEMNFBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private IMKLBCBNCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class DLADNMIEPNH : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class APGMDFBOLLK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3642400", Offset = "0x3641000", VA = "0x183642400")]
		static APGMDFBOLLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class OPMAAGAJEDD : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class KINCFKKDDDE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x36B3A80", Offset = "0x36B2680", VA = "0x1836B3A80")]
			static KINCFKKDDDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private OPMAAGAJEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private DLADNMIEPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class LHMBFIFALOE : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class ONBDIDAKHNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2764870", Offset = "0x2763470", VA = "0x182764870")]
		static ONBDIDAKHNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class PKDODGFHMHN : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class MHDIACEPOFD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x2549B30", Offset = "0x2548730", VA = "0x182549B30")]
			static MHDIACEPOFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private PKDODGFHMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private LHMBFIFALOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class EDPFLBHCIBA : ECLEPONANIG
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class PEMNHNPFJKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B51C20", Offset = "0x2B50820", VA = "0x182B51C20")]
		static PEMNHNPFJKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class DDCEDBKOKMA : ECLEPONANIG
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class JLMJJDEPOEB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::LKBCOOCHDMC<T> OONGIBECEAN;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3E437E0", Offset = "0x3E423E0", VA = "0x183E437E0")]
			static JLMJJDEPOEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		private DDCEDBKOKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
		public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::LKBCOOCHDMC<object> OGBFODJLADK;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	private EDPFLBHCIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A8B0", Offset = "0x1A994B0", VA = "0x181A9A8B0", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NKNHJAPLKAK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] NMKENLHJBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int PEPLKIOHEKE;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x33848D0", Offset = "0x33834D0", VA = "0x1833848D0")]
	public NKNHJAPLKAK(int BMBMFEJNLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x33844E0", Offset = "0x33830E0", VA = "0x1833844E0")]
	public void ELGBPIMHCCH(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3384840", Offset = "0x3383440", VA = "0x183384840")]
	public T[] HCHCDCPPAPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class JONFGDCNMGB : global::OPAADMJLBMO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly JONFGDCNMGB BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4619C50", Offset = "0x4618850", VA = "0x184619C50")]
	public JONFGDCNMGB(int LNKIBLBMMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class OPAADMJLBMO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int LNKIBLBMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object OFKEPKDOKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int BNNEENLPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] IPKMDMLMIMD;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x276D750", Offset = "0x276C350", VA = "0x18276D750")]
	public OPAADMJLBMO(int LNKIBLBMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x276C450", Offset = "0x276B050", VA = "0x18276C450")]
	public T[] FGHCNDDNPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x276C790", Offset = "0x276B390", VA = "0x18276C790")]
	public void NBODJICPIJL(T[] EJLDCNGHIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KOGDNCENHJL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class AFDNADMOAPK : IComparable<AFDNADMOAPK>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class NGKOJBMIPHD : IEnumerable<AFDNADMOAPK>, IEnumerable, IEnumerator<AFDNADMOAPK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private AFDNADMOAPK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public AFDNADMOAPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private AFDNADMOAPK System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public NGKOJBMIPHD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4F24750", Offset = "0x4F23350", VA = "0x184F24750", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4F24880", Offset = "0x4F23480", VA = "0x184F24880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4F247E0", Offset = "0x4F233E0", VA = "0x184F247E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AFDNADMOAPK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4F247E0", Offset = "0x4F233E0", VA = "0x184F247E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class IEPHHBMNIGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public IEPHHBMNIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A0BD0", VA = "0x1806A1FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A0BD0", VA = "0x1806A1FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly AFDNADMOAPK[] KBLPLCGBDBF;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] GMIAJLBAMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong POMHLJMDJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string GMPCBKNNHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private AFDNADMOAPK[] MLODMDDPNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] LKLMFGLCJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int CGKKILDEEIJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JCCHAIMPLPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xDA2CE0", Offset = "0xDA18E0", VA = "0x180DA2CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F1BA60", Offset = "0x4F1A660", VA = "0x184F1BA60")]
		public AFDNADMOAPK(ulong BIMCDHOFDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B4F0", Offset = "0x4F1A0F0", VA = "0x184F1B4F0")]
		public AFDNADMOAPK ELGBPIMHCCH(ulong BIMCDHOFDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B4A0", Offset = "0x4F1A0A0", VA = "0x184F1B4A0")]
		public AFDNADMOAPK ELGBPIMHCCH(ulong BIMCDHOFDCP, int GKFICKKHACC, string GMPCBKNNHPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B820", Offset = "0x4F1A420", VA = "0x184F1B820")]
		public AFDNADMOAPK MKBIJINFBDG(byte[] KNNJFFBFLLC, ref int HPNBOGMLOLG, ref int KNMPCIFBGHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B420", Offset = "0x4F1A020", VA = "0x184F1B420")]
		internal static int DDLINCEEPBH(ulong[] EJLDCNGHIAK, int BNNEENLPEFO, int PMIIGNOLFGJ, ulong GKFICKKHACC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B3F0", Offset = "0x4F19FF0", VA = "0x184F1B3F0", Slot = "4")]
		public int CompareTo(AFDNADMOAPK MCLIMJFDMCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B7B0", Offset = "0x4F1A3B0", VA = "0x184F1B7B0")]
		[IteratorStateMachine(typeof(NGKOJBMIPHD))]
		public IEnumerable<AFDNADMOAPK> HNOKIDCJDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F1A5C0", Offset = "0x4F191C0", VA = "0x184F1A5C0")]
		public void AOMPHOEGFJA(ILGenerator MELBLMPENNB, LocalBuilder KNNJFFBFLLC, LocalBuilder KNMPCIFBGHP, LocalBuilder BIMCDHOFDCP, Action<KeyValuePair<string, int>> AHFKDOABCIJ, Action CEGBGLEKOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F1A700", Offset = "0x4F19300", VA = "0x184F1A700")]
		private static void BHAEKGKDOLI(ILGenerator MELBLMPENNB, LocalBuilder KNNJFFBFLLC, LocalBuilder KNMPCIFBGHP, LocalBuilder BIMCDHOFDCP, Action<KeyValuePair<string, int>> AHFKDOABCIJ, Action CEGBGLEKOHN, AFDNADMOAPK[] MLODMDDPNOG, int CGKKILDEEIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class JBJECKBFACL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<AFDNADMOAPK> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<AFDNADMOAPK> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<AFDNADMOAPK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private AFDNADMOAPK <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4F22230", Offset = "0x4F20E30", VA = "0x184F22230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAB8140", Offset = "0xAB6D40", VA = "0x180AB8140")]
		[DebuggerHidden]
		public JBJECKBFACL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4F22280", Offset = "0x4F20E80", VA = "0x184F22280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4F21CF0", Offset = "0x4F208F0", VA = "0x184F21CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4F22360", Offset = "0x4F20F60", VA = "0x184F22360")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4F223B0", Offset = "0x4F20FB0", VA = "0x184F223B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4F221F0", Offset = "0x4F20DF0", VA = "0x184F221F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4F22150", Offset = "0x4F20D50", VA = "0x184F22150", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4F22150", Offset = "0x4F20D50", VA = "0x184F22150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly AFDNADMOAPK MHPJOFNEKOG;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x46234C0", Offset = "0x46220C0", VA = "0x1846234C0")]
	public KOGDNCENHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4622E90", Offset = "0x4621A90", VA = "0x184622E90")]
	public void ELGBPIMHCCH(byte[] EHAMCGPFFID, int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4623300", Offset = "0x4621F00", VA = "0x184623300")]
	public bool KMBCPONNOJK(ArraySegment<byte> BIMCDHOFDCP, out int GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4623430", Offset = "0x4622030", VA = "0x184623430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4623060", Offset = "0x4621C60", VA = "0x184623060")]
	private static void KIIBOHGMPDA(IEnumerable<AFDNADMOAPK> MLODMDDPNOG, StringBuilder HBILMDLCHEA, int EMDDAPNEEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4622FB0", Offset = "0x4621BB0", VA = "0x184622FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4622FB0", Offset = "0x4621BB0", VA = "0x184622FB0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x46233C0", Offset = "0x4621FC0", VA = "0x1846233C0")]
	[IteratorStateMachine(typeof(JBJECKBFACL))]
	private static IEnumerable<KeyValuePair<string, int>> MIHGOPNCGDP(IEnumerable<AFDNADMOAPK> MLODMDDPNOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4622E60", Offset = "0x4621A60", VA = "0x184622E60")]
	public void AGAHDBMIABB(ILGenerator MELBLMPENNB, LocalBuilder KNNJFFBFLLC, LocalBuilder KNMPCIFBGHP, LocalBuilder BIMCDHOFDCP, Action<KeyValuePair<string, int>> AHFKDOABCIJ, Action CEGBGLEKOHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class CDHDENKNOAD
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo MIOEMEJJBPG;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x51B32C0", Offset = "0x51B1EC0", VA = "0x1851B32C0")]
	public static ulong FFJCNLGDCMN(byte[] EHAMCGPFFID, ref int HPNBOGMLOLG, ref int KNMPCIFBGHP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class JOJPDIPPANJ
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4619A90", Offset = "0x4618690", VA = "0x184619A90")]
	public static void PHCHFJPBPOA(ref byte[] EHAMCGPFFID, int HPNBOGMLOLG, int MMJADBDACLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4619860", Offset = "0x4618460", VA = "0x184619860")]
	public static void BDDKEINNAJH(ref byte[] EJLDCNGHIAK, int JLCKPDBPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4619970", Offset = "0x4618570", VA = "0x184619970")]
	public static byte[] KDBLIMPBLJN(byte[] HOGBBBFDPKI, int JLCKPDBPCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GEGFCFJAGFJ
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x51C3480", Offset = "0x51C2080", VA = "0x1851C3480")]
	public static bool OKMKGFFNCCL(byte[] CFNJPLNHAMH, int DOBCCIMGKBE, int LAKCPFGCFOL, byte[] EHBGIPICIMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class CHMFILPMNGC<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct ECMLOKEAJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] POMHLJMDJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T AMPEKKPGHLN;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2DEAA90", Offset = "0x2DE9690", VA = "0x182DEAA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class JDDMCLINGPO : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::CHMFILPMNGC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private ECMLOKEAJBG[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private ECMLOKEAJBG[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E4A0", Offset = "0x2B0D0A0", VA = "0x182B0E4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5730", Offset = "0x1FB4330", VA = "0x181FB5730")]
		[DebuggerHidden]
		public JDDMCLINGPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D890", Offset = "0x2B0C490", VA = "0x182B0D890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E3A0", Offset = "0x2B0CFA0", VA = "0x182B0E3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly ECMLOKEAJBG[][] BJJJFFMEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong EKMLKMMDKNE;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3D83ED0", Offset = "0x3D82AD0", VA = "0x183D83ED0")]
	public CHMFILPMNGC(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3D83E10", Offset = "0x3D82A10", VA = "0x183D83E10")]
	public CHMFILPMNGC(int BPGPHKEJPBF, float NMIHKFPNGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E560", Offset = "0x3D7D160", VA = "0x183D7E560")]
	public void ELGBPIMHCCH(byte[] BIMCDHOFDCP, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3D78F70", Offset = "0x3D77B70", VA = "0x183D78F70")]
	private bool COBHKKPEGNJ(byte[] BIMCDHOFDCP, T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3D83090", Offset = "0x3D81C90", VA = "0x183D83090")]
	public bool GINCMLLPDOD(ArraySegment<byte> BIMCDHOFDCP, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3D83DB0", Offset = "0x3D829B0", VA = "0x183D83DB0")]
	private static ulong HFEBIEPOMOG(byte[] IODEOJKDCNL, int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DCB0", Offset = "0x2B2C8B0", VA = "0x182B2DCB0")]
	private static int EIDKLNIPCLK(int EFDNGGMKDGH, float NMIHKFPNGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3D83B70", Offset = "0x3D82770", VA = "0x183D83B70", Slot = "4")]
	[IteratorStateMachine(typeof(global::CHMFILPMNGC<>.JDDMCLINGPO))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x26A6F00", Offset = "0x26A5B00", VA = "0x1826A6F00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class LIDIKILGCGM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] LACFGMOJAGN;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] AGGKMOBMMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int AFJCPNNAMAG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MHAPGNEJFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4624410", Offset = "0x4623010", VA = "0x184624410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4624580", Offset = "0x4623180", VA = "0x184624580")]
	static LIDIKILGCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4624800", Offset = "0x4623400", VA = "0x184624800")]
	public LIDIKILGCGM(byte[] ONEBLEMJKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4624460", Offset = "0x4623060", VA = "0x184624460")]
	public OpCode NPPPFCEENLM()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct NGOHDGPKKNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid AMPEKKPGHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte ABNGIPGIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte HEIFIJKJEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte FJCCEHNNMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte INILNIDPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FDJHBNKDIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte BKGBCBNFDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte BPHOGCGNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte FJCAIHKJMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte GPPMDBNLOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte EAJKNGPOPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte GEACGJKPGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte DFMDEOLKOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte FELHEJOFJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte OAHCKNEHPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte FOOONEJDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte NAPHLMKDJLD;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] HDEGNMIBDJG;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] NACBPPMIHPK;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x462B560", Offset = "0x462A160", VA = "0x18462B560")]
	public NGOHDGPKKNN(ref Guid GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x462A110", Offset = "0x4628D10", VA = "0x18462A110")]
	public NGOHDGPKKNN(ref ArraySegment<byte> HMLIEMNEDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4629F80", Offset = "0x4628B80", VA = "0x184629F80")]
	private static byte PANKMHLLLEL(byte[] EHAMCGPFFID, int MDJJLNNJDPM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4629E70", Offset = "0x4628A70", VA = "0x184629E70")]
	private static byte NDDMAKJOOLA(byte GHDGKPNPOBN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4628B20", Offset = "0x4627720", VA = "0x184628B20")]
	public void FEBNLFJNNAM(byte[] NFMJIELOGNG, int HPNBOGMLOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class FOGHDLBJEFL
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x51C1230", Offset = "0x51BFE30", VA = "0x1851C1230")]
	public static bool PMLBIFINJOC(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x51BF870", Offset = "0x51BE470", VA = "0x1851BF870")]
	public static bool EMLMMFCHINI(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x51C0440", Offset = "0x51BF040", VA = "0x1851C0440")]
	public static sbyte GKHGHCCKMDI(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x51C03D0", Offset = "0x51BEFD0", VA = "0x1851C03D0")]
	public static short GKGCAGNIFGK(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x51C1240", Offset = "0x51BFE40", VA = "0x1851C1240")]
	public static int POHKECICMGP(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x51C0320", Offset = "0x51BEF20", VA = "0x1851C0320")]
	public static long FJDGBGKNLND(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x51C1150", Offset = "0x51BFD50", VA = "0x1851C1150")]
	public static byte MIKONJDFFEM(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x51C11C0", Offset = "0x51BFDC0", VA = "0x1851C11C0")]
	public static ushort PAAPNJDFIJA(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x51BF7F0", Offset = "0x51BE3F0", VA = "0x1851BF7F0")]
	public static uint CLCMAHJMHOC(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x51BF6E0", Offset = "0x51BE2E0", VA = "0x1851BF6E0")]
	public static ulong ANPDDMDKNFL(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x51C04B0", Offset = "0x51BF0B0", VA = "0x1851C04B0")]
	public static float IJECNOKHBPP(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x51BF670", Offset = "0x51BE270", VA = "0x1851BF670")]
	public static double AINDKHMENLM(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x51BF8E0", Offset = "0x51BE4E0", VA = "0x1851BF8E0")]
	public static int EODPALIIPIF(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, ulong GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x51C0520", Offset = "0x51BF120", VA = "0x1851C0520")]
	public static int JMNCMAGABKG(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, long GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x51C00B0", Offset = "0x51BECB0", VA = "0x1851C00B0")]
	public static bool FDOGOBIIKHL(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class GNOKFLABFBH
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class OJHPBLBMBDM : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public OJHPBLBMBDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4F27A90", Offset = "0x4F26690", VA = "0x184F27A90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4F27630", Offset = "0x4F26230", VA = "0x184F27630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4F27B80", Offset = "0x4F26780", VA = "0x184F27B80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4F27BD0", Offset = "0x4F267D0", VA = "0x184F27BD0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F27A50", Offset = "0x4F26650", VA = "0x184F27A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4F279A0", Offset = "0x4F265A0", VA = "0x184F279A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4F279A0", Offset = "0x4F265A0", VA = "0x184F279A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HKFHACCKHFE : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public HKFHACCKHFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4F219B0", Offset = "0x4F205B0", VA = "0x184F219B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4F21550", Offset = "0x4F20150", VA = "0x184F21550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4F21AA0", Offset = "0x4F206A0", VA = "0x184F21AA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4F21AF0", Offset = "0x4F206F0", VA = "0x184F21AF0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4F21970", Offset = "0x4F20570", VA = "0x184F21970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4F218C0", Offset = "0x4F204C0", VA = "0x184F218C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4F218C0", Offset = "0x4F204C0", VA = "0x184F218C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x51C3940", Offset = "0x51C2540", VA = "0x1851C3940")]
	public static bool BGPBEDMIFCA(this TypeInfo BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x51C3A00", Offset = "0x51C2600", VA = "0x1851C3A00")]
	public static bool DLBFJADMJFC(this TypeInfo BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x51C3C80", Offset = "0x51C2880", VA = "0x1851C3C80")]
	public static IEnumerable<PropertyInfo> NKHKNEHJNAG(this Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x51C3B20", Offset = "0x51C2720", VA = "0x1851C3B20")]
	[IteratorStateMachine(typeof(OJHPBLBMBDM))]
	private static IEnumerable<PropertyInfo> FLLPLKOEGFI(Type BIEGICDMJCM, HashSet<string> JLFCMEJDGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x51C3BB0", Offset = "0x51C27B0", VA = "0x1851C3BB0")]
	public static IEnumerable<FieldInfo> JABDJJLEKHG(this Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x51C38B0", Offset = "0x51C24B0", VA = "0x1851C38B0")]
	[IteratorStateMachine(typeof(HKFHACCKHFE))]
	private static IEnumerable<FieldInfo> BDPPIILENHJ(Type BIEGICDMJCM, HashSet<string> JLFCMEJDGIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class JGJEOONDNEF
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding PMEMEOLEGCH;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class IFBCCBILKCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500")]
	public static string MLEKIOIIADP(string PJBFFCCCLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4615D70", Offset = "0x4614970", VA = "0x184615D70")]
	public static string BNIINNGFBOA(string PJBFFCCCLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4615E80", Offset = "0x4614A80", VA = "0x184615E80")]
	public static string FKKJPHIAOLM(string PJBFFCCCLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PPCMGBHHGII<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class NFOEMPKBOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type POMHLJMDJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue AMPEKKPGHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int CCKPMFNDKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NFOEMPKBOIG BIAGFGAGMMK;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2696EB0", Offset = "0x2695AB0", VA = "0x182696EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2696E70", Offset = "0x2695A70", VA = "0x182696E70")]
		private int EONFJIOMKJN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public NFOEMPKBOIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class HGMJKEBGDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public HGMJKEBGDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NFOEMPKBOIG[] BJJJFFMEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int LBLAPKMJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object OOJLFMKJGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float NMIHKFPNGOL;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2B2EB00", Offset = "0x2B2D700", VA = "0x182B2EB00")]
	public PPCMGBHHGII(int BPGPHKEJPBF = 4, float NMIHKFPNGOL = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E260", Offset = "0x2B2CE60", VA = "0x182B2E260")]
	public bool NKDBGPNCFBD(Type BIMCDHOFDCP, TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E1E0", Offset = "0x2B2CDE0", VA = "0x182B2E1E0")]
	public bool NKDBGPNCFBD(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D710", Offset = "0x2B2C310", VA = "0x182B2D710")]
	private bool COBHKKPEGNJ(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK, out TValue FGDPPDEPGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E740", Offset = "0x2B2D340", VA = "0x182B2E740")]
	private bool PDBPLCCLOAF(NFOEMPKBOIG[] BJJJFFMEHMH, Type OLADFIEFHDG, NFOEMPKBOIG JMCIBGBLEIM, Func<Type, TValue> FOPKMMCKCMK, out TValue FGDPPDEPGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DCE0", Offset = "0x2B2C8E0", VA = "0x182B2DCE0")]
	public bool GINCMLLPDOD(Type BIMCDHOFDCP, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E020", Offset = "0x2B2CC20", VA = "0x182B2E020")]
	public TValue KAAMKKLEPKC(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DCB0", Offset = "0x2B2C8B0", VA = "0x182B2DCB0")]
	private static int EIDKLNIPCLK(int EFDNGGMKDGH, float NMIHKFPNGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E370", Offset = "0x2B2CF70", VA = "0x182B2E370")]
	private static void PDBMHFFHIGN(ref NFOEMPKBOIG NIBJLJHBBKF, NFOEMPKBOIG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E370", Offset = "0x2B2CF70", VA = "0x182B2E370")]
	private static void PDBMHFFHIGN(ref NFOEMPKBOIG[] NIBJLJHBBKF, NFOEMPKBOIG[] GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class ANANODFDIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder JNDONELEECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder DIHLFGOJOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object OFKEPKDOKPG;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x51ACCE0", Offset = "0x51AB8E0", VA = "0x1851ACCE0")]
	public TypeBuilder NHJENGODLDL(string NLCIGFDKGEE, TypeAttributes MLLHCAFGHOC, Type GEOFAMNLJNK, Type[] NCOLHBJLCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x51ACDB0", Offset = "0x51AB9B0", VA = "0x1851ACDB0")]
	public ANANODFDIKB(string GEBMPOGMOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class JMIKOBEKADH
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4619790", Offset = "0x4618390", VA = "0x184619790")]
	private static MethodInfo LFDNPDEIIDA(LambdaExpression GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x233CF10", Offset = "0x233BB10", VA = "0x18233CF10")]
	public static MethodInfo OIDJDNPFAIN<T>(Expression<Func<T>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x233CF10", Offset = "0x233BB10", VA = "0x18233CF10")]
	public static MethodInfo OIDJDNPFAIN<T, TR>(Expression<Func<T, TR>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x233CF10", Offset = "0x233BB10", VA = "0x18233CF10")]
	public static MethodInfo OIDJDNPFAIN<T>(Expression<Action<T>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x233CF10", Offset = "0x233BB10", VA = "0x18233CF10")]
	public static MethodInfo OIDJDNPFAIN<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x233CE60", Offset = "0x233BA60", VA = "0x18233CE60")]
	private static MemberInfo HBEJEGLPNIG<T>(Expression<T> GPNGGDGNOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x233CE00", Offset = "0x233BA00", VA = "0x18233CE00")]
	public static PropertyInfo AEBOMPJOPLK<T, TR>(Expression<Func<T, TR>> GOFOHEEBHML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct BGDOAOECCIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int OJFFKHAMPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool OCFDEANOGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator MELBLMPENNB;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x51B0570", Offset = "0x51AF170", VA = "0x1851B0570")]
	public BGDOAOECCIG(ILGenerator MELBLMPENNB, int OJFFKHAMPMJ, bool OCFDEANOGHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x51B05B0", Offset = "0x51AF1B0", VA = "0x1851B05B0")]
	public BGDOAOECCIG(ILGenerator MELBLMPENNB, int OJFFKHAMPMJ, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x51B0450", Offset = "0x51AF050", VA = "0x1851B0450")]
	public void OCFDDABPLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class FIECBGFDONB
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x51BE490", Offset = "0x51BD090", VA = "0x1851BE490")]
	public static void BIGOJAJDKGK(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x51BE450", Offset = "0x51BD050", VA = "0x1851BE450")]
	public static void BIGOJAJDKGK(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x51BF080", Offset = "0x51BDC80", VA = "0x1851BF080")]
	public static void GHAFKHPOGHA(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x51BF040", Offset = "0x51BDC40", VA = "0x1851BF040")]
	public static void GHAFKHPOGHA(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x51BE900", Offset = "0x51BD500", VA = "0x1851BE900")]
	public static void DAMGICMJNFF(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x51BE9F0", Offset = "0x51BD5F0", VA = "0x1851BE9F0")]
	public static void DAMGICMJNFF(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x51BF360", Offset = "0x51BDF60", VA = "0x1851BF360")]
	public static void LGOONGAKBBP(this ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x51BE6C0", Offset = "0x51BD2C0", VA = "0x1851BE6C0")]
	public static void BKOMNOEFPEC(this ILGenerator MELBLMPENNB, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x51BEB00", Offset = "0x51BD700", VA = "0x1851BEB00")]
	public static void EDFNEBOGMOB(this ILGenerator MELBLMPENNB, int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x51BE360", Offset = "0x51BCF60", VA = "0x1851BE360")]
	public static void BAIOGHHAOHC(this ILGenerator MELBLMPENNB, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x51BF2B0", Offset = "0x51BDEB0", VA = "0x1851BF2B0")]
	public static void IIMCIMBCFNE(this ILGenerator MELBLMPENNB, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x51BE6D0", Offset = "0x51BD2D0", VA = "0x1851BE6D0")]
	public static void CPBLONEDPCM(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x51BE2E0", Offset = "0x51BCEE0", VA = "0x1851BE2E0")]
	public static void AJLPANEMOIG(this ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x51BEF50", Offset = "0x51BDB50", VA = "0x1851BEF50")]
	public static void FLEAOBFOFNL(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x51BF370", Offset = "0x51BDF70", VA = "0x1851BF370")]
	public static void NBLBNIKJOOA(this ILGenerator MELBLMPENNB, MethodInfo FNCJNLKEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x51BF470", Offset = "0x51BE070", VA = "0x1851BF470")]
	public static void PDJKCLNFHPP(this ILGenerator MELBLMPENNB, FieldInfo KMGHMIBILGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x51BE250", Offset = "0x51BCE50", VA = "0x1851BE250")]
	public static void AHMKOJLNPBP(this ILGenerator MELBLMPENNB, ulong GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class PGBPOAOHMEE
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KFNGDDBHDKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public KFNGDDBHDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4F22880", Offset = "0x4F21480", VA = "0x184F22880")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo CNGAJKHBHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo PFNFKNBEMHK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OPPFMAGEFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ABAECAAJAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4F2CE70", Offset = "0x4F2BA70", VA = "0x184F2CE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FKBGOIOAGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6923D0", Offset = "0x690FD0", VA = "0x1806923D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782240", VA = "0x180783640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AFDBPFCGPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6923E0", Offset = "0x690FE0", VA = "0x1806923E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD2E770", Offset = "0xD2D370", VA = "0x180D2E770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo LPGKLPONEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo NPELOLJCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo GFJAMJDBOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67D180", VA = "0x18067E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67D1A0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D0F0", Offset = "0x4F2BCF0", VA = "0x184F2D0F0")]
	protected PGBPOAOHMEE(Type BIEGICDMJCM, string NLCIGFDKGEE, string OEFLJIGICBN, bool MMLNHIIHOCM, bool MKIMJIGKCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D170", Offset = "0x4F2BD70", VA = "0x184F2D170")]
	public PGBPOAOHMEE(FieldInfo DHBOJIINPOH, string NLCIGFDKGEE, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4F2CF40", Offset = "0x4F2BB40", VA = "0x184F2CF40")]
	public PGBPOAOHMEE(PropertyInfo DHBOJIINPOH, string NLCIGFDKGEE, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4F2CC40", Offset = "0x4F2B840", VA = "0x184F2CC40")]
	private static MethodInfo DJMCNMAPCPA(MemberInfo DHBOJIINPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x313B700", Offset = "0x313A300", VA = "0x18313B700")]
	public T GBPGJOFKFHE<T>(bool CFCGGLFINKD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4F2CDB0", Offset = "0x4F2B9B0", VA = "0x184F2CDB0", Slot = "4")]
	public virtual void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4F2CE80", Offset = "0x4F2BA80", VA = "0x184F2CE80", Slot = "5")]
	public virtual void KGLKKNLMJEK(ILGenerator MELBLMPENNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class EHGLNLGAPKL : PGBPOAOHMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string FFMFEIJPNJJ;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x51B8FE0", Offset = "0x51B7BE0", VA = "0x1851B8FE0")]
	public EHGLNLGAPKL(string NLCIGFDKGEE, string FFMFEIJPNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x51B8EE0", Offset = "0x51B7AE0", VA = "0x1851B8EE0", Slot = "4")]
	public override void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x51B8FA0", Offset = "0x51B7BA0", VA = "0x1851B8FA0", Slot = "5")]
	public override void KGLKKNLMJEK(ILGenerator MELBLMPENNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class DLFCMKPFNBB : PGBPOAOHMEE
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo GADLFJLDFAH;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo DFKNMLBJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal BGDOAOECCIG FCHELKKCBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal BGDOAOECCIG GGGECDMHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal BGDOAOECCIG KMAIOPKCFJD;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x51B7110", Offset = "0x51B5D10", VA = "0x1851B7110")]
	public DLFCMKPFNBB(string NLCIGFDKGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x51B68C0", Offset = "0x51B54C0", VA = "0x1851B68C0", Slot = "4")]
	public override void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x51B6990", Offset = "0x51B5590", VA = "0x1851B6990", Slot = "5")]
	public override void KGLKKNLMJEK(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x51B69D0", Offset = "0x51B55D0", VA = "0x1851B69D0")]
	public void MKPFOCFALMI(ILGenerator MELBLMPENNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class ANHAKGCJAHL
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NLJPCHJAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6904D0", VA = "0x1806918D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1C00", VA = "0x1806B3000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool APGEBDOEDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x80EFB0", Offset = "0x80DBB0", VA = "0x18080EFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xCFDC60", Offset = "0xCFC860", VA = "0x180CFDC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo EGIIEMHKNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public PGBPOAOHMEE[] OBKIAAGHOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PGBPOAOHMEE[] MLJLECLCPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E6E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x51ACFA0", Offset = "0x51ABBA0", VA = "0x1851ACFA0")]
	public ANHAKGCJAHL(Type BIEGICDMJCM, Func<string, string> JIFKAGHKCDP, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x51ACEB0", Offset = "0x51ABAB0", VA = "0x1851ACEB0")]
	private static bool FKPDJMBEJKH(IEnumerator<ConstructorInfo> CCOCEPFMGBO, ref ConstructorInfo KCFEOFCBPFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct HDPPPAGPOAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong ACKCJINFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int AENGIJLJHJA;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2010D40", Offset = "0x200F940", VA = "0x182010D40")]
	public HDPPPAGPOAN(ulong CIGHMLHPNEM, int OBIAJGIJCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4614190", Offset = "0x4612D90", VA = "0x184614190")]
	public void LKKCEELIFBM(ref HDPPPAGPOAN MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4614180", Offset = "0x4612D80", VA = "0x184614180")]
	public static HDPPPAGPOAN JMBCMGEKCAM(ref HDPPPAGPOAN LEOEMBMBFBC, ref HDPPPAGPOAN GHDGKPNPOBN)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4613FC0", Offset = "0x4612BC0", VA = "0x184613FC0")]
	public void DPAGLMCLGFK(ref HDPPPAGPOAN MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x46140E0", Offset = "0x4612CE0", VA = "0x1846140E0")]
	public static HDPPPAGPOAN HHAGGJNGCLD(ref HDPPPAGPOAN LEOEMBMBFBC, ref HDPPPAGPOAN GHDGKPNPOBN)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4614050", Offset = "0x4612C50", VA = "0x184614050")]
	public void GAFHGDAPAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4614090", Offset = "0x4612C90", VA = "0x184614090")]
	public static HDPPPAGPOAN GAFHGDAPAKF(ref HDPPPAGPOAN LEOEMBMBFBC)
	{
		return default(HDPPPAGPOAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct DDFDOIEOJFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] NFMJIELOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int HPNBOGMLOLG;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7765B0", Offset = "0x7751B0", VA = "0x1807765B0")]
	public DDFDOIEOJFN(byte[] NFMJIELOGNG, int DKGAADMNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x51B65B0", Offset = "0x51B51B0", VA = "0x1851B65B0")]
	public void OEFGJPAFBJA(byte IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x51B6510", Offset = "0x51B5110", VA = "0x1851B6510")]
	public void OADGLMLJILG(byte[] IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x51B6610", Offset = "0x51B5210", VA = "0x1851B6610")]
	public void OKAPFIKHMGE(byte[] IBEOABCOFOH, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x51B66B0", Offset = "0x51B52B0", VA = "0x1851B66B0")]
	public void OKAPFIKHMGE(byte[] IBEOABCOFOH, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x51B6490", Offset = "0x51B5090", VA = "0x1851B6490")]
	public void NMOCDNGDHHC(byte EKIHFBHEKEC, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x51B6390", Offset = "0x51B4F90", VA = "0x1851B6390")]
	public void GLMJCHMDEKG(string IBEOABCOFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class OMNAOPPHCDM
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum FIBBNIKEKFG
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum GLMAMNLHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum HBGBPJOPAEN
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] JLIKBOJDNCI;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] CHAJFGOIJFA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] MBJHGENHIOA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] LACIIDAODHI;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly HBGBPJOPAEN IJAFCCCEBPF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char EGJELBBOKAM;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int FOLGGJIECLK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int FHEKDBPIMDP;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] IIPDKDIJBDL;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F289D0", Offset = "0x4F275D0", VA = "0x184F289D0")]
	private static byte[] FMICAEMHFFB(int LBLAPKMJFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F29420", Offset = "0x4F28020", VA = "0x184F29420")]
	private static byte[] MFJDOIHLMBL(int LBLAPKMJFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F280F0", Offset = "0x4F26CF0", VA = "0x184F280F0")]
	public static int ADBOFBMDIGH(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, float GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F28210", Offset = "0x4F26E10", VA = "0x184F28210")]
	public static int ADBOFBMDIGH(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, double GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F285D0", Offset = "0x4F271D0", VA = "0x184F285D0")]
	private static bool EEGNKKDGANB(byte[] NFMJIELOGNG, int PMIIGNOLFGJ, ulong HCINGBLCLMG, ulong BKHJFEJBBAJ, ulong KNMPCIFBGHP, ulong FOJOBKNJBNI, ulong MIJKDEGILOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F29500", Offset = "0x4F28100", VA = "0x184F29500")]
	private static void MLBBBLHBGLC(uint AEGJCHOCHON, int CCGCEKIACPE, out uint EAMONKPFMKB, out int JAPDDGECJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F28AB0", Offset = "0x4F276B0", VA = "0x184F28AB0")]
	private static bool IBMCHPDKABD(HDPPPAGPOAN CCKAGBPNPHP, HDPPPAGPOAN AEPJHDKHAPL, HDPPPAGPOAN POJEPHCOPHL, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int NBOPCLGJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F28330", Offset = "0x4F26F30", VA = "0x184F28330")]
	private static bool AKAILJAPAHO(double MINMGIMIPFB, FIBBNIKEKFG GGBPGDBFPKJ, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int EJKCOIKAGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F28FD0", Offset = "0x4F27BD0", VA = "0x184F28FD0")]
	private static bool JEPPDKIOPPE(double MINMGIMIPFB, FIBBNIKEKFG GGBPGDBFPKJ, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int MLFIMNODEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F29290", Offset = "0x4F27E90", VA = "0x184F29290")]
	private static bool LOKDAEGLCHE(double GKFICKKHACC, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F29620", Offset = "0x4F28220", VA = "0x184F29620")]
	private static bool NCIKKBIMJMP(double GKFICKKHACC, ref DDFDOIEOJFN HLCBDOBJLEA, GLMAMNLHEDH GGBPGDBFPKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F29C80", Offset = "0x4F28880", VA = "0x184F29C80")]
	private static void PAHDLPKJFFB(byte[] MFJBIPKGIMM, int PMIIGNOLFGJ, int MLFIMNODEGM, int GFOODILKNMI, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F286D0", Offset = "0x4F272D0", VA = "0x184F286D0")]
	private static void FMHHMDANCJM(byte[] MFJBIPKGIMM, int PMIIGNOLFGJ, int OBIAJGIJCCM, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F290E0", Offset = "0x4F27CE0", VA = "0x184F290E0")]
	private static bool KPBMFCEMEBK(double MINMGIMIPFB, GLMAMNLHEDH GGBPGDBFPKJ, int LGIFEBBPKCD, byte[] OOFDBBLHJJG, out bool MBMLLHNGIJI, out int PMIIGNOLFGJ, out int DEDMBANHEDJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct BNPOGOCFGIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double EIEOEGFMKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong FFNMCABNGBH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct IKLPBECPHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float ACKCJINFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint NBMEBIAMMLC;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct NPGDCGJINPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong JGIJKAGFJFA;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x462BBE0", Offset = "0x462A7E0", VA = "0x18462BBE0")]
	public NPGDCGJINPK(double EIEOEGFMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x462BB40", Offset = "0x462A740", VA = "0x18462BB40")]
	public NPGDCGJINPK(HDPPPAGPOAN EIEOEGFMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x462B940", Offset = "0x462A540", VA = "0x18462B940")]
	public HDPPPAGPOAN OPPMPNMHHGP()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x462B570", Offset = "0x462A170", VA = "0x18462B570")]
	public HDPPPAGPOAN AEHNMHAPBLN()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675C00", VA = "0x180677000")]
	public ulong PBJPLBKCOIP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x462B7C0", Offset = "0x462A3C0", VA = "0x18462B7C0")]
	public double GGICKHOGJLP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x462B6A0", Offset = "0x462A2A0", VA = "0x18462B6A0")]
	public double CEDPJDNJFNL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x462B880", Offset = "0x462A480", VA = "0x18462B880")]
	public int HNEMJIFAEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x462B8F0", Offset = "0x462A4F0", VA = "0x18462B8F0")]
	public ulong NHIFOPMLBBI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x462B8D0", Offset = "0x462A4D0", VA = "0x18462B8D0")]
	public bool MLLJKNOGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x462B860", Offset = "0x462A460", VA = "0x18462B860")]
	public bool GOOPKBDOMPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x462B9C0", Offset = "0x462A5C0", VA = "0x18462B9C0")]
	public bool PGCBBBOMFMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x462B740", Offset = "0x462A340", VA = "0x18462B740")]
	public bool DMBPNMFJBNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x462B920", Offset = "0x462A520", VA = "0x18462B920")]
	public int OLMNPEBDPEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x462B9F0", Offset = "0x462A5F0", VA = "0x18462B9F0")]
	public void PPMBGOLLFMK(out HDPPPAGPOAN NKLLPKACEDN, out HDPPPAGPOAN NJOPGKCDOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x462B770", Offset = "0x462A370", VA = "0x18462B770")]
	public bool GBCCIFBKPKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x462B850", Offset = "0x462A450", VA = "0x18462B850")]
	public double GKFICKKHACC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x462B8B0", Offset = "0x462A4B0", VA = "0x18462B8B0")]
	public static int JPDOLDFAPLN(int FMHBLLJICEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x462B730", Offset = "0x462A330", VA = "0x18462B730")]
	public static double CLEEEKJAEIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x462B600", Offset = "0x462A200", VA = "0x18462B600")]
	public static ulong BHGEDMGMKKN(HDPPPAGPOAN POKPHELBHGC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct ELEFMLDFMOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint LNFNFDFECNO;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7210", Offset = "0x2CE5E10", VA = "0x182CE7210")]
	public ELEFMLDFMOJ(float ACKCJINFPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x51B9B00", Offset = "0x51B8700", VA = "0x1851B9B00")]
	public HDPPPAGPOAN OPPMPNMHHGP()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20")]
	public uint OEOKALDCDDE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x51B9AB0", Offset = "0x51B86B0", VA = "0x1851B9AB0")]
	public int HNEMJIFAEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x51B9AE0", Offset = "0x51B86E0", VA = "0x1851B9AE0")]
	public uint NHIFOPMLBBI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x51B9AD0", Offset = "0x51B86D0", VA = "0x1851B9AD0")]
	public bool MLLJKNOGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x51B9B70", Offset = "0x51B8770", VA = "0x1851B9B70")]
	public void PPMBGOLLFMK(out HDPPPAGPOAN NKLLPKACEDN, out HDPPPAGPOAN NJOPGKCDOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x51B9A70", Offset = "0x51B8670", VA = "0x1851B9A70")]
	public bool GBCCIFBKPKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct OAIKKENALFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong CIGHMLHPNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short IMHCMAIHJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short EJKCOIKAGLH;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F26CA0", Offset = "0x4F258A0", VA = "0x184F26CA0")]
	public OAIKKENALFC(ulong CIGHMLHPNEM, short IMHCMAIHJLK, short EJKCOIKAGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class CAFCOFFGDGD
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly OAIKKENALFC[] DKJOGKHFFPN;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x51B12C0", Offset = "0x51AFEC0", VA = "0x1851B12C0")]
	public static void DNHAGNBBNPH(int CCDDEDHJDAA, int PBHGLBGJLGO, out HDPPPAGPOAN EAMONKPFMKB, out int EJKCOIKAGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x51B1400", Offset = "0x51B0000", VA = "0x1851B1400")]
	public static void OJEKDEJFOAF(int BEHLALONOKJ, out HDPPPAGPOAN EAMONKPFMKB, out int CNODINNHALB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct MNEGMGECNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] EHAMCGPFFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int HOKMFDPKLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int FMLJGOBEAAE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4628560", Offset = "0x4627160", VA = "0x184628560")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCEC360", Offset = "0xCEAF60", VA = "0x180CEC360")]
	public MNEGMGECNBK(byte[] EHAMCGPFFID, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76FA40", Offset = "0x76E640", VA = "0x18076FA40")]
	public int PMIIGNOLFGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4628500", Offset = "0x4627100", VA = "0x184628500")]
	public MNEGMGECNBK AMNPCGAIBPP(int BEFJFPBKMMC, int DFFNEOCPAMF)
	{
		return default(MNEGMGECNBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BCHHEFDHKPC
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] NKLGOFHMAHG;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] BKJPMIJIHHB;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int EMLKMJDGDAH;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x51AF420", Offset = "0x51AE020", VA = "0x1851AF420")]
	private static byte[] FKHMACMBIPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x51AEA70", Offset = "0x51AD670", VA = "0x1851AEA70")]
	private static MNEGMGECNBK BCHFIFOAIBL(MNEGMGECNBK NFMJIELOGNG)
	{
		return default(MNEGMGECNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x51AF830", Offset = "0x51AE430", VA = "0x1851AF830")]
	private static MNEGMGECNBK KKHHGFHHLII(MNEGMGECNBK NFMJIELOGNG)
	{
		return default(MNEGMGECNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x51AF360", Offset = "0x51ADF60", VA = "0x1851AF360")]
	private static void FFOJMDLKNEF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, byte[] OOOGLFCLBNA, out int GIPCJMDMLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x51AF970", Offset = "0x51AE570", VA = "0x1851AF970")]
	private static void MAJHNPEHBID(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, byte[] LKCNBGKBDIA, int PEJPJHIEDLM, out MNEGMGECNBK MHAMFBJFPDE, out int PKJPGFCHEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x51AF8E0", Offset = "0x51AE4E0", VA = "0x1851AF8E0")]
	private static ulong KOEFHJEOGIJ(MNEGMGECNBK NFMJIELOGNG, out int DEOIJPIBBBF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x51AE920", Offset = "0x51AD520", VA = "0x1851AE920")]
	private static void AHIDCFFKLJB(MNEGMGECNBK NFMJIELOGNG, out HDPPPAGPOAN BMBFIGGJLDD, out int CCDJDGCIHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x51AFC10", Offset = "0x51AE810", VA = "0x1851AFC10")]
	private static bool OMFNPPNBDCN(MNEGMGECNBK MHAMFBJFPDE, int OBIAJGIJCCM, out double BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x51AEB20", Offset = "0x51AD720", VA = "0x1851AEB20")]
	private static HDPPPAGPOAN DIIHKLMMFOI(int OBIAJGIJCCM)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x51AECD0", Offset = "0x51AD8D0", VA = "0x1851AECD0")]
	private static bool EELPCGOOFGF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, out double BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x51AF6F0", Offset = "0x51AE2F0", VA = "0x1851AF6F0")]
	private static bool JGEIHNJOKFM(MNEGMGECNBK MHAMFBJFPDE, int OBIAJGIJCCM, out double IKDDGAKHENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x51AF240", Offset = "0x51ADE40", VA = "0x1851AF240")]
	public static double? EILPIJLGMAF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x51AF510", Offset = "0x51AE110", VA = "0x1851AF510")]
	public static float? FLIHBIIDGKH(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct HMMCPBGOLOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] NFMJIELOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int HPNBOGMLOLG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4614A30", Offset = "0x4613630", VA = "0x184614A30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7765B0", Offset = "0x7751B0", VA = "0x1807765B0")]
	public HMMCPBGOLOB(byte[] NFMJIELOGNG, int HPNBOGMLOLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x46148A0", Offset = "0x46134A0", VA = "0x1846148A0")]
	public static HMMCPBGOLOB DIEKDAOPMKP(HMMCPBGOLOB DLIFLKHFBMM)
	{
		return default(HMMCPBGOLOB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4614AE0", Offset = "0x46136E0", VA = "0x184614AE0")]
	public static HMMCPBGOLOB PFCLMAKECFN(HMMCPBGOLOB DLIFLKHFBMM, int PMIIGNOLFGJ)
	{
		return default(HMMCPBGOLOB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x46149C0", Offset = "0x46135C0", VA = "0x1846149C0")]
	public static int KJPIPKKGFFF(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4614900", Offset = "0x4613500", VA = "0x184614900")]
	public static bool IKJLJMIELNH(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4614AC0", Offset = "0x46136C0", VA = "0x184614AC0")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x46148B0", Offset = "0x46134B0", VA = "0x1846148B0")]
	public static bool IKJLJMIELNH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4614A70", Offset = "0x4613670", VA = "0x184614A70")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4614A70", Offset = "0x4613670", VA = "0x184614A70")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, byte GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4614850", Offset = "0x4613450", VA = "0x184614850")]
	public static bool ABIJJBCCMCH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4614920", Offset = "0x4613520", VA = "0x184614920")]
	public static bool JPGBLBGGKGH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x46149E0", Offset = "0x46135E0", VA = "0x1846149E0")]
	public static bool LPHAHCNFNBE(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4614970", Offset = "0x4613570", VA = "0x184614970")]
	public static bool KFBFAJJNDAK(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LOFADFFGOID
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] MJNGNLNICPP;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] APBEDLBIGLC;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] MBJHGENHIOA;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] LACIIDAODHI;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] CLNLBNOGPJG;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int ECGCNHFOGPB;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] BMBCCNNFIBO;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int CJGNGKCLMMI;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4625100", Offset = "0x4623D00", VA = "0x184625100")]
	private static byte[] FDFMHAOFGLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x46251F0", Offset = "0x4623DF0", VA = "0x1846251F0")]
	private static byte[] GBKHNKGCCMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4626610", Offset = "0x4625210", VA = "0x184626610")]
	public static double OKPMGHCHGCC(byte[] NFMJIELOGNG, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4624FE0", Offset = "0x4623BE0", VA = "0x184624FE0")]
	public static float CLBBBKDNDGC(byte[] NFMJIELOGNG, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x46252E0", Offset = "0x4623EE0", VA = "0x1846252E0")]
	private static bool HFDKOBEMKBD(int IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4624EC0", Offset = "0x4623AC0", VA = "0x184624EC0")]
	private static bool BMHKKDIAIOB(ref HMMCPBGOLOB LBIAANDOGFM, HMMCPBGOLOB OCMAALMMILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4625480", Offset = "0x4624080", VA = "0x184625480")]
	private static bool HKJEHHKCMHN(ref HMMCPBGOLOB LBIAANDOGFM, HMMCPBGOLOB OCMAALMMILB, byte[] ACCKOIDDKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x46250A0", Offset = "0x4623CA0", VA = "0x1846250A0")]
	private static bool EJGJPNMOJNP(ref HMMCPBGOLOB CFABDILLBHK, byte[] IBEOABCOFOH, int HPNBOGMLOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4625460", Offset = "0x4624060", VA = "0x184625460")]
	private static double HFIDKEONNBG(bool MBMLLHNGIJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x46255A0", Offset = "0x46241A0", VA = "0x1846255A0")]
	private static double MHAICMGLGOM(HMMCPBGOLOB EDEJMAKDAOA, int PMIIGNOLFGJ, bool JJEPBDAJOLL, out int HHJKCPNFBGP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class JDMMKILJOPO<T> : global::LKBCOOCHDMC<T[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::OPAADMJLBMO<T> EOKGPHHNIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly CIIAACDLPMF HLNKAKEJJGB;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x23D9BA0", Offset = "0x23D87A0", VA = "0x1823D9BA0")]
	public JDMMKILJOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5730", Offset = "0x1FB4330", VA = "0x181FB5730")]
	public JDMMKILJOPO(CIIAACDLPMF HLNKAKEJJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2B0F100", Offset = "0x2B0DD00", VA = "0x182B0F100", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FBA0", Offset = "0x2B0E7A0", VA = "0x182B0FBA0", Slot = "5")]
	public T[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class LEHIPNBEMCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::OPAADMJLBMO<T> EOKGPHHNIBC;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class BPEFBMNIBND<T> : global::LKBCOOCHDMC<List<T>>, DIAHDCBEFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly CIIAACDLPMF HLNKAKEJJGB;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x23D9BA0", Offset = "0x23D87A0", VA = "0x1823D9BA0")]
	public BPEFBMNIBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5730", Offset = "0x1FB4330", VA = "0x181FB5730")]
	public BPEFBMNIBND(CIIAACDLPMF HLNKAKEJJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x23D7F70", Offset = "0x23D6B70", VA = "0x1823D7F70", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, List<T> GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x23D9090", Offset = "0x23D7C90", VA = "0x1823D9090", Slot = "5")]
	public List<T> MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EHHAFBIFONP<TElement, TIntermediate, TEnumerator, TCollection> : global::LKBCOOCHDMC<TCollection>, DIAHDCBEFFK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB670", Offset = "0x2DFA270", VA = "0x182DFB670", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TCollection GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBFE0", Offset = "0x2DFABE0", VA = "0x182DFBFE0", Slot = "5")]
	public TCollection MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator FBNBLHOIDFC(TCollection GPNGGDGNOJH);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GLBIKEOEKPG();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ELGBPIMHCCH(ref TIntermediate BDLMAMHCIKB, int BNNEENLPEFO, TElement GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DNAKJMIBDKI(ref TIntermediate COGPBFFGMCM);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected EHHAFBIFONP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class OCMDAGJGCGH<TElement, TIntermediate, TCollection> : global::EHHAFBIFONP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x27E1360", Offset = "0x27DFF60", VA = "0x1827E1360", Slot = "6")]
	protected override IEnumerator<TElement> FBNBLHOIDFC(TCollection GPNGGDGNOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x17F7AD0", Offset = "0x17F66D0", VA = "0x1817F7AD0")]
	protected OCMDAGJGCGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class PIDEOKIODBD<TElement, TCollection> : global::OCMDAGJGCGH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected sealed override TCollection DNAKJMIBDKI(ref TCollection COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class GCJMOAENCJA<TElement, TCollection> : global::PIDEOKIODBD<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3481D80", Offset = "0x3480980", VA = "0x183481D80", Slot = "7")]
	protected override TCollection GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3481D10", Offset = "0x3480910", VA = "0x183481D10", Slot = "8")]
	protected override void ELGBPIMHCCH(ref TCollection BDLMAMHCIKB, int BNNEENLPEFO, TElement GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class HLAMPDEKNFM<T> : global::EHHAFBIFONP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x22844D0", Offset = "0x22830D0", VA = "0x1822844D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref LinkedList<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override LinkedList<T> DNAKJMIBDKI(ref LinkedList<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override LinkedList<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBABB0", Offset = "0x2BB97B0", VA = "0x182BBABB0", Slot = "6")]
	protected override LinkedList<T>.Enumerator FBNBLHOIDFC(LinkedList<T> GPNGGDGNOJH)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class BLLPJDJGIIN<T> : global::EHHAFBIFONP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x22844D0", Offset = "0x22830D0", VA = "0x1822844D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Queue<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override Queue<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x1807930", Offset = "0x1806530", VA = "0x181807930", Slot = "6")]
	protected override Queue<T>.Enumerator FBNBLHOIDFC(Queue<T> GPNGGDGNOJH)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override Queue<T> DNAKJMIBDKI(ref Queue<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IKMONGHCFLA<T> : global::EHHAFBIFONP<T, global::NKNHJAPLKAK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1807900", Offset = "0x1806500", VA = "0x181807900", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1807980", Offset = "0x1806580", VA = "0x181807980", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1807930", Offset = "0x1806530", VA = "0x181807930", Slot = "6")]
	protected override Stack<T>.Enumerator FBNBLHOIDFC(Stack<T> GPNGGDGNOJH)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1807820", Offset = "0x1806420", VA = "0x181807820", Slot = "9")]
	protected override Stack<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FCDNELIFOMD<T> : global::EHHAFBIFONP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x22844D0", Offset = "0x22830D0", VA = "0x1822844D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref HashSet<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override HashSet<T> DNAKJMIBDKI(ref HashSet<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override HashSet<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1807930", Offset = "0x1806530", VA = "0x181807930", Slot = "6")]
	protected override HashSet<T>.Enumerator FBNBLHOIDFC(HashSet<T> GPNGGDGNOJH)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NBANMFDDADH<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1807900", Offset = "0x1806500", VA = "0x181807900", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2687310", Offset = "0x2685F10", VA = "0x182687310", Slot = "9")]
	protected override ReadOnlyCollection<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x26873A0", Offset = "0x2685FA0", VA = "0x1826873A0", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MDIOCIIBFEJ<T> : global::OCMDAGJGCGH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x22844D0", Offset = "0x22830D0", VA = "0x1822844D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref List<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override List<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override IList<T> DNAKJMIBDKI(ref List<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BIGONKJDOJL<T> : global::OCMDAGJGCGH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x22844D0", Offset = "0x22830D0", VA = "0x1822844D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref List<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override List<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override ICollection<T> DNAKJMIBDKI(ref List<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JJGBPFHDOMD<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1807900", Offset = "0x1806500", VA = "0x181807900", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1807980", Offset = "0x1806580", VA = "0x181807980", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3E34A40", Offset = "0x3E33640", VA = "0x183E34A40", Slot = "9")]
	protected override IEnumerable<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class KJGIAIIIJGM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MNGEPIKLNLB<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MDAHNLKJPNP<T> : global::LKBCOOCHDMC<T>, DIAHDCBEFFK where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF2E0", Offset = "0x2FEDEE0", VA = "0x182FEF2E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2FEF5A0", Offset = "0x2FEE1A0", VA = "0x182FEF5A0", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public MDAHNLKJPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class EBOEBEHABNO : global::LKBCOOCHDMC<IEnumerable>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::LKBCOOCHDMC<IEnumerable> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x51B8820", Offset = "0x51B7420", VA = "0x1851B8820", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IEnumerable GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x51B8A90", Offset = "0x51B7690", VA = "0x1851B8A90", Slot = "5")]
	public IEnumerable MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public EBOEBEHABNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class FPFDKBHNFEJ : global::LKBCOOCHDMC<ICollection>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::LKBCOOCHDMC<ICollection> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x51C29E0", Offset = "0x51C15E0", VA = "0x1851C29E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ICollection GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x51C2D60", Offset = "0x51C1960", VA = "0x1851C2D60", Slot = "5")]
	public ICollection MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FPFDKBHNFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class EHIKLFILEGB : global::LKBCOOCHDMC<IList>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::LKBCOOCHDMC<IList> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x51B90A0", Offset = "0x51B7CA0", VA = "0x1851B90A0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IList GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x51B9410", Offset = "0x51B8010", VA = "0x1851B9410", Slot = "5")]
	public IList MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public EHIKLFILEGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JLNMCCCBPOJ<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3E464C0", Offset = "0x3E450C0", VA = "0x183E464C0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1807980", Offset = "0x1806580", VA = "0x181807980", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3E46480", Offset = "0x3E45080", VA = "0x183E46480", Slot = "9")]
	protected override IReadOnlyList<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x23DC690", Offset = "0x23DB290", VA = "0x1823DC690")]
	public JLNMCCCBPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JFLGIIGIKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4619000", Offset = "0x4617C00", VA = "0x184619000")]
	public static DateTime NCLBMPOBBGB(DateTime OJFAGFHHLAF)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OOCHLCPBMNA : global::LKBCOOCHDMC<DateTime>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::LKBCOOCHDMC<DateTime> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4F2A1F0", Offset = "0x4F28DF0", VA = "0x184F2A1F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, DateTime GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F2A650", Offset = "0x4F29250", VA = "0x184F2A650", Slot = "5")]
	public DateTime MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OOCHLCPBMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class IKGLKMMKICN : global::LKBCOOCHDMC<DateTimeOffset>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::LKBCOOCHDMC<DateTimeOffset> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4616430", Offset = "0x4615030", VA = "0x184616430", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, DateTimeOffset GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4616810", Offset = "0x4615410", VA = "0x184616810", Slot = "5")]
	public DateTimeOffset MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IKGLKMMKICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class CKBDOOEJHJH : global::LKBCOOCHDMC<TimeSpan>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::LKBCOOCHDMC<TimeSpan> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] BJNMJLOAGOH;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x51B47D0", Offset = "0x51B33D0", VA = "0x1851B47D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TimeSpan GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x51B4C80", Offset = "0x51B3880", VA = "0x1851B4C80", Slot = "5")]
	public TimeSpan MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CKBDOOEJHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AMCGIPIJFBN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::LKBCOOCHDMC<TDictionary>, DIAHDCBEFFK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB1A0", Offset = "0x3BA9DA0", VA = "0x183BAB1A0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TDictionary GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3BABF50", Offset = "0x3BAAB50", VA = "0x183BABF50", Slot = "5")]
	public TDictionary MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator FBNBLHOIDFC(TDictionary GPNGGDGNOJH);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GLBIKEOEKPG();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void ELGBPIMHCCH(ref TIntermediate BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DNAKJMIBDKI(ref TIntermediate COGPBFFGMCM);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected AMCGIPIJFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class BGAPMLJJMBL<TKey, TValue, TIntermediate, TDictionary> : global::AMCGIPIJFBN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x27E1360", Offset = "0x27DFF60", VA = "0x1827E1360", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> FBNBLHOIDFC(TDictionary GPNGGDGNOJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class OAJLOEOMPHC<TKey, TValue, TDictionary> : global::BGAPMLJJMBL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override TDictionary DNAKJMIBDKI(ref TDictionary COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LPIBCIKPNGO<TKey, TValue> : global::AMCGIPIJFBN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3554050", Offset = "0x3552C50", VA = "0x183554050", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Dictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override Dictionary<TKey, TValue> DNAKJMIBDKI(ref Dictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override Dictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3554090", Offset = "0x3552C90", VA = "0x183554090", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator FBNBLHOIDFC(Dictionary<TKey, TValue> GPNGGDGNOJH)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1AFA970", Offset = "0x1AF9570", VA = "0x181AFA970")]
	public LPIBCIKPNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BMFMIDMHFJH<TKey, TValue, TDictionary> : global::OAJLOEOMPHC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x23CA170", Offset = "0x23C8D70", VA = "0x1823CA170", Slot = "8")]
	protected override void ELGBPIMHCCH(ref TDictionary BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8DF0", Offset = "0x1FB79F0", VA = "0x181FB8DF0", Slot = "7")]
	protected override TDictionary GLBIKEOEKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class OBBFPEFHFML<TKey, TValue> : global::BGAPMLJJMBL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x26897C0", Offset = "0x26883C0", VA = "0x1826897C0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Dictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override Dictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override IDictionary<TKey, TValue> DNAKJMIBDKI(ref Dictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NEBLCDPLEGO<TKey, TValue> : global::OAJLOEOMPHC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x26897C0", Offset = "0x26883C0", VA = "0x1826897C0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref SortedList<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override SortedList<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class BCANJNPJIHF<TKey, TValue> : global::AMCGIPIJFBN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x26897C0", Offset = "0x26883C0", VA = "0x1826897C0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref SortedDictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1131CA0", Offset = "0x11308A0", VA = "0x181131CA0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DNAKJMIBDKI(ref SortedDictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2284510", Offset = "0x2283110", VA = "0x182284510", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5286E70", Offset = "0x5285A70", VA = "0x185286E70", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator FBNBLHOIDFC(SortedDictionary<TKey, TValue> GPNGGDGNOJH)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NMPJHANDMMD<T> : global::LKBCOOCHDMC<T>, DIAHDCBEFFK where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x33849D0", Offset = "0x33835D0", VA = "0x1833849D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3384D80", Offset = "0x3383980", VA = "0x183384D80", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public NMPJHANDMMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class MFPBAOOEFLA : global::LKBCOOCHDMC<IDictionary>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::LKBCOOCHDMC<IDictionary> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4627B40", Offset = "0x4626740", VA = "0x184627B40", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IDictionary GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4627EF0", Offset = "0x4626AF0", VA = "0x184627EF0", Slot = "5")]
	public IDictionary MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public MFPBAOOEFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class JBJNINJHBCC : global::LKBCOOCHDMC<object>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void GEGDLLMLHAA(object IDPLMKELOMN, ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG AMILKFGLHFE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::PPCMGBHHGII<KeyValuePair<object, GEGDLLMLHAA>> DKBHOLHDIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly ECLEPONANIG[] IFDALBMHBJN;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4618D50", Offset = "0x4617950", VA = "0x184618D50")]
	public JBJNINJHBCC(params ECLEPONANIG[] IFDALBMHBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4618180", Offset = "0x4616D80", VA = "0x184618180", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4618CB0", Offset = "0x46178B0", VA = "0x184618CB0", Slot = "5")]
	public object MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EMCDBMIABOM
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x51BA5F0", Offset = "0x51B91F0", VA = "0x1851BA5F0")]
	public static object JOCLFLICFCF(Type BIEGICDMJCM, out bool FKANOPEICHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x51B9CD0", Offset = "0x51B88D0", VA = "0x1851B9CD0")]
	public static object DHELENNJDGI(Type BIEGICDMJCM, out bool FKANOPEICHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class JMNKKIMDDOI<T> : global::LKBCOOCHDMC<T>, DIAHDCBEFFK, global::KKDIOMBNNDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AHCJGGBLNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public AHCJGGBLNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B9A5C0", Offset = "0x3B991C0", VA = "0x183B9A5C0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class LHFAEKDCNLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::EFJMCNIOMKI<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public LHFAEKDCNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x24FBE30", Offset = "0x24FAA30", VA = "0x1824FBE30")]
		internal void <.cctor>b__1(ref DOFDDFPOMMF writer, T value, ECLEPONANIG _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class HODJOJIDFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::KHILBEPBCPG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public HODJOJIDFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3B30E70", Offset = "0x3B2FA70", VA = "0x183B30E70")]
		internal T <.cctor>b__2(ref FHNCKNEPFID reader, ECLEPONANIG _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::CHMFILPMNGC<T> MFKEOBEMIBO;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> ACHFMDOOPEP;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::EFJMCNIOMKI<T> EEIHBDBLAOP;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::KHILBEPBCPG<T> BEHMHMAFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool LDCJGIMKIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::EFJMCNIOMKI<T> BCCEIBDABMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::KHILBEPBCPG<T> JNNNAGGGCFB;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F2E0", Offset = "0x3E4DEE0", VA = "0x183E4F2E0")]
	static JMNKKIMDDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E53080", Offset = "0x3E51C80", VA = "0x183E53080")]
	public JMNKKIMDDOI(bool LDCJGIMKIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E47F20", Offset = "0x3E46B20", VA = "0x183E47F20", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E48DD0", Offset = "0x3E479D0", VA = "0x183E48DD0", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E46D00", Offset = "0x3E45900", VA = "0x183E46D00", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E47180", Offset = "0x3E45D80", VA = "0x183E47180", Slot = "7")]
	public T CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ECEOGPMKGFN<T> : global::LKBCOOCHDMC<T[,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7160", Offset = "0x2DE5D60", VA = "0x182DE7160", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7310", Offset = "0x2DE5F10", VA = "0x182DE7310", Slot = "5")]
	public T[,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public ECEOGPMKGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DFNBCHAIBBC<T> : global::LKBCOOCHDMC<T[,,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C4B0", Offset = "0x2F1B0B0", VA = "0x182F1C4B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C6C0", Offset = "0x2F1B2C0", VA = "0x182F1C6C0", Slot = "5")]
	public T[,,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public DFNBCHAIBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class BNONLHEAPPB<T> : global::LKBCOOCHDMC<T[,,,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x23D4580", Offset = "0x23D3180", VA = "0x1823D4580", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,,,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x23D4820", Offset = "0x23D3420", VA = "0x1823D4820", Slot = "5")]
	public T[,,,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public BNONLHEAPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class FEDKDKMGEIJ<T> : global::LKBCOOCHDMC<T?>, DIAHDCBEFFK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x288FC60", Offset = "0x288E860", VA = "0x18288FC60", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x288FEF0", Offset = "0x288EAF0", VA = "0x18288FEF0", Slot = "5")]
	public T? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	public FEDKDKMGEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class OMFEEPGGBKC<T> : global::LKBCOOCHDMC<T?>, DIAHDCBEFFK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::LKBCOOCHDMC<T> GELGCEMOAIN;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x17F46E0", Offset = "0x17F32E0", VA = "0x1817F46E0")]
	public OMFEEPGGBKC(global::LKBCOOCHDMC<T> GELGCEMOAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2762A80", Offset = "0x2761680", VA = "0x182762A80")]
	public OMFEEPGGBKC(Type MMKEBLBLBOD, object[] JEGOIMOINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2761930", Offset = "0x2760530", VA = "0x182761930", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2762280", Offset = "0x2760E80", VA = "0x182762280", Slot = "5")]
	public T? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class EKCPIFCIHIF : global::LKBCOOCHDMC<sbyte>, DIAHDCBEFFK, global::KKDIOMBNNDG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly EKCPIFCIHIF BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x51B9980", Offset = "0x51B8580", VA = "0x1851B9980", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x51B99C0", Offset = "0x51B85C0", VA = "0x1851B99C0", Slot = "5")]
	public sbyte MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x51B9810", Offset = "0x51B8410", VA = "0x1851B9810", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, sbyte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x51B98D0", Offset = "0x51B84D0", VA = "0x1851B98D0", Slot = "7")]
	public sbyte CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public EKCPIFCIHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HKHFHCMGOEN : global::LKBCOOCHDMC<sbyte?>, DIAHDCBEFFK, global::KKDIOMBNNDG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly HKHFHCMGOEN BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4614700", Offset = "0x4613300", VA = "0x184614700", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4614780", Offset = "0x4613380", VA = "0x184614780", Slot = "5")]
	public sbyte? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x46145C0", Offset = "0x46131C0", VA = "0x1846145C0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, sbyte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4614640", Offset = "0x4613240", VA = "0x184614640", Slot = "7")]
	public sbyte? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HKHFHCMGOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class PCEOLPHABLO : global::LKBCOOCHDMC<sbyte[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly PCEOLPHABLO BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BDB0", Offset = "0x4F2A9B0", VA = "0x184F2BDB0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BE70", Offset = "0x4F2AA70", VA = "0x184F2BE70", Slot = "5")]
	public sbyte[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PCEOLPHABLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JKOLLKDJAMM : global::LKBCOOCHDMC<short>, DIAHDCBEFFK, global::KKDIOMBNNDG<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly JKOLLKDJAMM BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x4619570", Offset = "0x4618170", VA = "0x184619570", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4619590", Offset = "0x4618190", VA = "0x184619590", Slot = "5")]
	public short MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x46194B0", Offset = "0x46180B0", VA = "0x1846194B0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, short GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x46194F0", Offset = "0x46180F0", VA = "0x1846194F0", Slot = "7")]
	public short CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JKOLLKDJAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class NDDKHCBABID : global::LKBCOOCHDMC<short?>, DIAHDCBEFFK, global::KKDIOMBNNDG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly NDDKHCBABID BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x46289D0", Offset = "0x46275D0", VA = "0x1846289D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4628A50", Offset = "0x4627650", VA = "0x184628A50", Slot = "5")]
	public short? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4628890", Offset = "0x4627490", VA = "0x184628890", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, short? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4628910", Offset = "0x4627510", VA = "0x184628910", Slot = "7")]
	public short? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public NDDKHCBABID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class BKDCHOGCOIN : global::LKBCOOCHDMC<short[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly BKDCHOGCOIN BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x51B07A0", Offset = "0x51AF3A0", VA = "0x1851B07A0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x51B0940", Offset = "0x51AF540", VA = "0x1851B0940", Slot = "5")]
	public short[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BKDCHOGCOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class KOHBDGPBGLC : global::LKBCOOCHDMC<int>, DIAHDCBEFFK, global::KKDIOMBNNDG<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly KOHBDGPBGLC BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x46235F0", Offset = "0x46221F0", VA = "0x1846235F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4623600", Offset = "0x4622200", VA = "0x184623600", Slot = "5")]
	public int MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4623530", Offset = "0x4622130", VA = "0x184623530", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, int GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4623570", Offset = "0x4622170", VA = "0x184623570", Slot = "7")]
	public int CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KOHBDGPBGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class LBHHOBAGBFC : global::LKBCOOCHDMC<int?>, DIAHDCBEFFK, global::KKDIOMBNNDG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly LBHHOBAGBFC BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4623A10", Offset = "0x4622610", VA = "0x184623A10", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4623A80", Offset = "0x4622680", VA = "0x184623A80", Slot = "5")]
	public int? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x46238D0", Offset = "0x46224D0", VA = "0x1846238D0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, int? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4623950", Offset = "0x4622550", VA = "0x184623950", Slot = "7")]
	public int? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LBHHOBAGBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class OHLKPKCABMK : global::LKBCOOCHDMC<int[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly OHLKPKCABMK BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F27310", Offset = "0x4F25F10", VA = "0x184F27310", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F273D0", Offset = "0x4F25FD0", VA = "0x184F273D0", Slot = "5")]
	public int[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OHLKPKCABMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class IBBMODKPDIN : global::LKBCOOCHDMC<long>, DIAHDCBEFFK, global::KKDIOMBNNDG<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IBBMODKPDIN BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4614E70", Offset = "0x4613A70", VA = "0x184614E70", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x4614E90", Offset = "0x4613A90", VA = "0x184614E90", Slot = "5")]
	public long MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4614DB0", Offset = "0x46139B0", VA = "0x184614DB0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, long GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4614DF0", Offset = "0x46139F0", VA = "0x184614DF0", Slot = "7")]
	public long CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IBBMODKPDIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class CEDPOMDDPAE : global::LKBCOOCHDMC<long?>, DIAHDCBEFFK, global::KKDIOMBNNDG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly CEDPOMDDPAE BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x51B4580", Offset = "0x51B3180", VA = "0x1851B4580", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x51B4610", Offset = "0x51B3210", VA = "0x1851B4610", Slot = "5")]
	public long? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x51B4320", Offset = "0x51B2F20", VA = "0x1851B4320", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, long? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x51B4430", Offset = "0x51B3030", VA = "0x1851B4430", Slot = "7")]
	public long? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CEDPOMDDPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class IFFAMKDNCLM : global::LKBCOOCHDMC<long[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IFFAMKDNCLM BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4616070", Offset = "0x4614C70", VA = "0x184616070", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4616130", Offset = "0x4614D30", VA = "0x184616130", Slot = "5")]
	public long[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IFFAMKDNCLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class BGBKFNBIMHE : global::LKBCOOCHDMC<byte>, DIAHDCBEFFK, global::KKDIOMBNNDG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly BGBKFNBIMHE BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x51B0350", Offset = "0x51AEF50", VA = "0x1851B0350", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x51B0390", Offset = "0x51AEF90", VA = "0x1851B0390", Slot = "5")]
	public byte MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x51B01E0", Offset = "0x51AEDE0", VA = "0x1851B01E0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, byte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x51B02A0", Offset = "0x51AEEA0", VA = "0x1851B02A0", Slot = "7")]
	public byte CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BGBKFNBIMHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PJCJAOJDHJP : global::LKBCOOCHDMC<byte?>, DIAHDCBEFFK, global::KKDIOMBNNDG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly PJCJAOJDHJP BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D3C0", Offset = "0x4F2BFC0", VA = "0x184F2D3C0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D440", Offset = "0x4F2C040", VA = "0x184F2D440", Slot = "5")]
	public byte? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D280", Offset = "0x4F2BE80", VA = "0x184F2D280", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, byte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D300", Offset = "0x4F2BF00", VA = "0x184F2D300", Slot = "7")]
	public byte? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PJCJAOJDHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class GIMEBHFFGJI : global::LKBCOOCHDMC<ushort>, DIAHDCBEFFK, global::KKDIOMBNNDG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GIMEBHFFGJI BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x51C3680", Offset = "0x51C2280", VA = "0x1851C3680", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x51C36C0", Offset = "0x51C22C0", VA = "0x1851C36C0", Slot = "5")]
	public ushort MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x51C3510", Offset = "0x51C2110", VA = "0x1851C3510", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ushort GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x51C35D0", Offset = "0x51C21D0", VA = "0x1851C35D0", Slot = "7")]
	public ushort CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GIMEBHFFGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KEOBDBCHHHL : global::LKBCOOCHDMC<ushort?>, DIAHDCBEFFK, global::KKDIOMBNNDG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KEOBDBCHHHL BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x4619F10", Offset = "0x4618B10", VA = "0x184619F10", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4619F90", Offset = "0x4618B90", VA = "0x184619F90", Slot = "5")]
	public ushort? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4619DD0", Offset = "0x46189D0", VA = "0x184619DD0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ushort? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4619E50", Offset = "0x4618A50", VA = "0x184619E50", Slot = "7")]
	public ushort? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEOBDBCHHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class HKGHIPAEBFB : global::LKBCOOCHDMC<ushort[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly HKGHIPAEBFB BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4614360", Offset = "0x4612F60", VA = "0x184614360", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4614420", Offset = "0x4613020", VA = "0x184614420", Slot = "5")]
	public ushort[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HKGHIPAEBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class OKBMKALBDIH : global::LKBCOOCHDMC<uint>, DIAHDCBEFFK, global::KKDIOMBNNDG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly OKBMKALBDIH BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4F27CE0", Offset = "0x4F268E0", VA = "0x184F27CE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F27CF0", Offset = "0x4F268F0", VA = "0x184F27CF0", Slot = "5")]
	public uint MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4F27C20", Offset = "0x4F26820", VA = "0x184F27C20", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, uint GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4F27C60", Offset = "0x4F26860", VA = "0x184F27C60", Slot = "7")]
	public uint CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OKBMKALBDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class IAFGFDBCEPP : global::LKBCOOCHDMC<uint?>, DIAHDCBEFFK, global::KKDIOMBNNDG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IAFGFDBCEPP BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4614C70", Offset = "0x4613870", VA = "0x184614C70", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4614CE0", Offset = "0x46138E0", VA = "0x184614CE0", Slot = "5")]
	public uint? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4614B30", Offset = "0x4613730", VA = "0x184614B30", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, uint? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4614BB0", Offset = "0x46137B0", VA = "0x184614BB0", Slot = "7")]
	public uint? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IAFGFDBCEPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class GAGAGPPKGKI : global::LKBCOOCHDMC<uint[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly GAGAGPPKGKI BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x51C3050", Offset = "0x51C1C50", VA = "0x1851C3050", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x51C31F0", Offset = "0x51C1DF0", VA = "0x1851C31F0", Slot = "5")]
	public uint[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GAGAGPPKGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class FFGDCILLCDA : global::LKBCOOCHDMC<ulong>, DIAHDCBEFFK, global::KKDIOMBNNDG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly FFGDCILLCDA BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x51BB310", Offset = "0x51B9F10", VA = "0x1851BB310", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x51BB340", Offset = "0x51B9F40", VA = "0x1851BB340", Slot = "5")]
	public ulong MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x51BB1D0", Offset = "0x51B9DD0", VA = "0x1851BB1D0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ulong GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x51BB290", Offset = "0x51B9E90", VA = "0x1851BB290", Slot = "7")]
	public ulong CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FFGDCILLCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class GPNLDDMLCOD : global::LKBCOOCHDMC<ulong?>, DIAHDCBEFFK, global::KKDIOMBNNDG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GPNLDDMLCOD BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x51C44F0", Offset = "0x51C30F0", VA = "0x1851C44F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x51C4580", Offset = "0x51C3180", VA = "0x1851C4580", Slot = "5")]
	public ulong? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x51C4300", Offset = "0x51C2F00", VA = "0x1851C4300", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ulong? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x51C4410", Offset = "0x51C3010", VA = "0x1851C4410", Slot = "7")]
	public ulong? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GPNLDDMLCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class LBFPHILABLK : global::LKBCOOCHDMC<ulong[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly LBFPHILABLK BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x4623670", Offset = "0x4622270", VA = "0x184623670", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4623730", Offset = "0x4622330", VA = "0x184623730", Slot = "5")]
	public ulong[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LBFPHILABLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class BMNHDHCNAIF : global::LKBCOOCHDMC<float>, DIAHDCBEFFK, global::KKDIOMBNNDG<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BMNHDHCNAIF BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x51B1240", Offset = "0x51AFE40", VA = "0x1851B1240", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x51B1250", Offset = "0x51AFE50", VA = "0x1851B1250", Slot = "5")]
	public float MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x51B10E0", Offset = "0x51AFCE0", VA = "0x1851B10E0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, float GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x51B1190", Offset = "0x51AFD90", VA = "0x1851B1190", Slot = "7")]
	public float CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BMNHDHCNAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FPECBOHEELP : global::LKBCOOCHDMC<float?>, DIAHDCBEFFK, global::KKDIOMBNNDG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly FPECBOHEELP BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x51C2890", Offset = "0x51C1490", VA = "0x1851C2890", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x51C2910", Offset = "0x51C1510", VA = "0x1851C2910", Slot = "5")]
	public float? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x51C26A0", Offset = "0x51C12A0", VA = "0x1851C26A0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, float? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x51C27A0", Offset = "0x51C13A0", VA = "0x1851C27A0", Slot = "7")]
	public float? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FPECBOHEELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class JGFBPJLIMKA : global::LKBCOOCHDMC<float[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JGFBPJLIMKA BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x46190A0", Offset = "0x4617CA0", VA = "0x1846190A0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4619160", Offset = "0x4617D60", VA = "0x184619160", Slot = "5")]
	public float[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JGFBPJLIMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class JGOBLAECIJA : global::LKBCOOCHDMC<double>, DIAHDCBEFFK, global::KKDIOMBNNDG<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly JGOBLAECIJA BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4619430", Offset = "0x4618030", VA = "0x184619430", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4619440", Offset = "0x4618040", VA = "0x184619440", Slot = "5")]
	public double MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4619370", Offset = "0x4617F70", VA = "0x184619370", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, double GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x46193B0", Offset = "0x4617FB0", VA = "0x1846193B0", Slot = "7")]
	public double CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JGOBLAECIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BBMALLGOKPI : global::LKBCOOCHDMC<double?>, DIAHDCBEFFK, global::KKDIOMBNNDG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly BBMALLGOKPI BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x51AE7B0", Offset = "0x51AD3B0", VA = "0x1851AE7B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x51AE830", Offset = "0x51AD430", VA = "0x1851AE830", Slot = "5")]
	public double? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x51AE590", Offset = "0x51AD190", VA = "0x1851AE590", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, double? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x51AE6A0", Offset = "0x51AD2A0", VA = "0x1851AE6A0", Slot = "7")]
	public double? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BBMALLGOKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class OMIACEJCCGI : global::LKBCOOCHDMC<double[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly OMIACEJCCGI BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4F27E90", Offset = "0x4F26A90", VA = "0x184F27E90", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4F27F50", Offset = "0x4F26B50", VA = "0x184F27F50", Slot = "5")]
	public double[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OMIACEJCCGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class OAAPBDEIKKM : global::LKBCOOCHDMC<bool>, DIAHDCBEFFK, global::KKDIOMBNNDG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly OAAPBDEIKKM BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4F26C10", Offset = "0x4F25810", VA = "0x184F26C10", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4F26C30", Offset = "0x4F25830", VA = "0x184F26C30", Slot = "5")]
	public bool MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4F26B50", Offset = "0x4F25750", VA = "0x184F26B50", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, bool GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4F26B90", Offset = "0x4F25790", VA = "0x184F26B90", Slot = "7")]
	public bool CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OAAPBDEIKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class EBGIHEIGBBP : global::LKBCOOCHDMC<bool?>, DIAHDCBEFFK, global::KKDIOMBNNDG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly EBGIHEIGBBP BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x51B86D0", Offset = "0x51B72D0", VA = "0x1851B86D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x51B8750", Offset = "0x51B7350", VA = "0x1851B8750", Slot = "5")]
	public bool? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x51B8510", Offset = "0x51B7110", VA = "0x1851B8510", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, bool? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x51B8610", Offset = "0x51B7210", VA = "0x1851B8610", Slot = "7")]
	public bool? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public EBGIHEIGBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class CMBOMKJCNPH : global::LKBCOOCHDMC<bool[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly CMBOMKJCNPH BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x51B56C0", Offset = "0x51B42C0", VA = "0x1851B56C0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x51B5840", Offset = "0x51B4440", VA = "0x1851B5840", Slot = "5")]
	public bool[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CMBOMKJCNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class MEBDPIGKFDK : global::LKBCOOCHDMC<object>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::LKBCOOCHDMC<object> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> KBAJKKPACDI;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x46269A0", Offset = "0x46255A0", VA = "0x1846269A0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4627420", Offset = "0x4626020", VA = "0x184627420", Slot = "5")]
	public object MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public MEBDPIGKFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class FOBIEMGCBOJ : global::LKBCOOCHDMC<byte[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::LKBCOOCHDMC<byte[]> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x51BF500", Offset = "0x51BE100", VA = "0x1851BF500", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x51BF590", Offset = "0x51BE190", VA = "0x1851BF590", Slot = "5")]
	public byte[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FOBIEMGCBOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LKMJIGOAMMG : global::LKBCOOCHDMC<ArraySegment<byte>>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::LKBCOOCHDMC<ArraySegment<byte>> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4624BE0", Offset = "0x46237E0", VA = "0x184624BE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ArraySegment<byte> GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4624CA0", Offset = "0x46238A0", VA = "0x184624CA0", Slot = "5")]
	public ArraySegment<byte> MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LKMJIGOAMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class OPEPHOJBOPA : global::LKBCOOCHDMC<string>, DIAHDCBEFFK, global::KKDIOMBNNDG<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::LKBCOOCHDMC<string> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BB60", Offset = "0x4F2A760", VA = "0x184F2BB60", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, string GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BB80", Offset = "0x4F2A780", VA = "0x184F2BB80", Slot = "5")]
	public string MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BB60", Offset = "0x4F2A760", VA = "0x184F2BB60", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, string GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F2BB80", Offset = "0x4F2A780", VA = "0x184F2BB80", Slot = "7")]
	public string CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OPEPHOJBOPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NANCCGIFHGA : global::LKBCOOCHDMC<string[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly NANCCGIFHGA BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4628600", Offset = "0x4627200", VA = "0x184628600", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, string[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x46286C0", Offset = "0x46272C0", VA = "0x1846286C0", Slot = "5")]
	public string[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public NANCCGIFHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EJFNFGMCODH : global::LKBCOOCHDMC<char>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly EJFNFGMCODH BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x51B9700", Offset = "0x51B8300", VA = "0x1851B9700", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x51B9780", Offset = "0x51B8380", VA = "0x1851B9780", Slot = "5")]
	public char MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public EJFNFGMCODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class LENFAJFBFMD : global::LKBCOOCHDMC<char?>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly LENFAJFBFMD BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4623B50", Offset = "0x4622750", VA = "0x184623B50", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4623C40", Offset = "0x4622840", VA = "0x184623C40", Slot = "5")]
	public char? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LENFAJFBFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class LHGGOFFPHHH : global::LKBCOOCHDMC<char[]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly LHGGOFFPHHH BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4623DD0", Offset = "0x46229D0", VA = "0x184623DD0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4623F50", Offset = "0x4622B50", VA = "0x184623F50", Slot = "5")]
	public char[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LHGGOFFPHHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class BKOKHKHACID : global::LKBCOOCHDMC<Guid>, DIAHDCBEFFK, global::KKDIOMBNNDG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::LKBCOOCHDMC<Guid> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x51B0DA0", Offset = "0x51AF9A0", VA = "0x1851B0DA0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Guid GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x51B0D50", Offset = "0x51AF950", VA = "0x1851B0D50", Slot = "5")]
	public Guid MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x51B0D20", Offset = "0x51AF920", VA = "0x1851B0D20", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, Guid GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x51B0D50", Offset = "0x51AF950", VA = "0x1851B0D50", Slot = "7")]
	public Guid CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BKOKHKHACID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class MHOMJEAHMEC : global::LKBCOOCHDMC<decimal>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::LKBCOOCHDMC<decimal> BLGCIDCPBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool GKLLNABEMIJ;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8DB980", Offset = "0x8DA580", VA = "0x1808DB980")]
	public MHOMJEAHMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x15D7C60", Offset = "0x15D6860", VA = "0x1815D7C60")]
	public MHOMJEAHMEC(bool GKLLNABEMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4628120", Offset = "0x4626D20", VA = "0x184628120", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, decimal GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x4628270", Offset = "0x4626E70", VA = "0x184628270", Slot = "5")]
	public decimal MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class IDDCCBAHMEM : global::LKBCOOCHDMC<Uri>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::LKBCOOCHDMC<Uri> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4614F00", Offset = "0x4613B00", VA = "0x184614F00", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Uri GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4614FB0", Offset = "0x4613BB0", VA = "0x184614FB0", Slot = "5")]
	public Uri MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IDDCCBAHMEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class JLEBNNMECJD : global::LKBCOOCHDMC<Version>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::LKBCOOCHDMC<Version> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4619600", Offset = "0x4618200", VA = "0x184619600", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Version GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x46196B0", Offset = "0x46182B0", VA = "0x1846196B0", Slot = "5")]
	public Version MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JLEBNNMECJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class HBFEENACPJO<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class OLPALKONEHL : global::LKBCOOCHDMC<StringBuilder>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::LKBCOOCHDMC<StringBuilder> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4F27D60", Offset = "0x4F26960", VA = "0x184F27D60", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, StringBuilder GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F27DB0", Offset = "0x4F269B0", VA = "0x184F27DB0", Slot = "5")]
	public StringBuilder MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OLPALKONEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class JEGIEICLFPC : global::LKBCOOCHDMC<BitArray>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::LKBCOOCHDMC<BitArray> BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4618DF0", Offset = "0x46179F0", VA = "0x184618DF0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, BitArray GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4618E80", Offset = "0x4617A80", VA = "0x184618E80", Slot = "5")]
	public BitArray MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JEGIEICLFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class ADNMFDOFGCF : global::LKBCOOCHDMC<Type>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly ADNMFDOFGCF BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex NHKCDGICKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool GGBJKFMPLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool KBGDFCBFEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool DBLJOGKFHNJ;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x51ACB70", Offset = "0x51AB770", VA = "0x1851ACB70")]
	public ADNMFDOFGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x51ACB20", Offset = "0x51AB720", VA = "0x1851ACB20")]
	public ADNMFDOFGCF(bool GGBJKFMPLIP, bool KBGDFCBFEOJ, bool DBLJOGKFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x51AC840", Offset = "0x51AB440", VA = "0x1851AC840", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Type GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x51AC930", Offset = "0x51AB530", VA = "0x1851AC930", Slot = "5")]
	public Type MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
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
