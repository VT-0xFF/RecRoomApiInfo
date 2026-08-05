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
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	public GBMOCCLAKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class KLJJHKCNBHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	public KLJJHKCNBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PEPIOMACPLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	public PEPIOMACPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class BLMDIMBDNNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	public BLMDIMBDNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JBFBDPNHPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x46D8830", Offset = "0x46D7630", VA = "0x1846D8830")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] EDFJLPBOOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6994C0", Offset = "0x6982C0", VA = "0x1806994C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x42DCC60", Offset = "0x42DBA60", VA = "0x1842DCC60")]
	public static global::LKBCOOCHDMC<T> ILCHNEBHGJJ<T>(this ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46DA740", Offset = "0x46D9540", VA = "0x1846DA740")]
	public static object KOFBLMMAJHF(this ECLEPONANIG MOPBAELKKDA, Type BIEGICDMJCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AKLGEGPAJHF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x514A900", Offset = "0x5149700", VA = "0x18514A900")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F07CE0", Offset = "0x4F06AE0", VA = "0x184F07CE0")]
		public static byte[] FDFMHAOFGLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F07C50", Offset = "0x4F06A50", VA = "0x184F07C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x515A6C0", Offset = "0x51594C0", VA = "0x18515A6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x515BED0", Offset = "0x515ACD0", VA = "0x18515BED0")]
	public FHNCKNEPFID(byte[] EHAMCGPFFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x515BCE0", Offset = "0x515AAE0", VA = "0x18515BCE0")]
	public FHNCKNEPFID(byte[] EHAMCGPFFID, int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x515AC10", Offset = "0x5159A10", VA = "0x18515AC10")]
	private BKIIPNGFFKI NNMMLDHIAKI(string JJPEDAIHJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5159040", Offset = "0x5157E40", VA = "0x185159040")]
	private BKIIPNGFFKI AAOJCIIPDAH(string HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5156060", Offset = "0x5154E60", VA = "0x185156060")]
	public void OKNDODPLLNL(int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6506E0", Offset = "0x64F4E0", VA = "0x1806506E0")]
	public byte[] GDIDANNFJND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D4910", Offset = "0x6D3710", VA = "0x1806D4910")]
	public int BLLADAFDHDF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x515A950", Offset = "0x5159750", VA = "0x18515A950")]
	public MNBDGEMMGMF MOOCLKPHCAO()
	{
		return default(MNBDGEMMGMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5159510", Offset = "0x5158310", VA = "0x185159510")]
	public void BMFOBKMHLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x515A350", Offset = "0x5159150", VA = "0x18515A350")]
	public bool JFIBIBKIIPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x515BAC0", Offset = "0x515A8C0", VA = "0x18515BAC0")]
	public bool OLCJIINABGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x515A6E0", Offset = "0x51594E0", VA = "0x18515A6E0")]
	public void LCFCCHJHEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5159FD0", Offset = "0x5158DD0", VA = "0x185159FD0")]
	public bool HMKFEOPMAMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x515AAD0", Offset = "0x51598D0", VA = "0x18515AAD0")]
	public bool NGMEPHKHLIO(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x515B120", Offset = "0x5159F20", VA = "0x18515B120")]
	public bool OBKBBHNCGNN(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x515A890", Offset = "0x5159690", VA = "0x18515A890")]
	public bool MKBBGKKEBBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x515A770", Offset = "0x5159570", VA = "0x18515A770")]
	public void LECJNHNEKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x515A2F0", Offset = "0x51590F0", VA = "0x18515A2F0")]
	public bool JCCOHPNHBNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5159A90", Offset = "0x5158890", VA = "0x185159A90")]
	public bool FABBNLFMFDG(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x515AB50", Offset = "0x5159950", VA = "0x18515AB50")]
	public bool NMCFMCPCBDB(ref int CGKKILDEEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x515A8F0", Offset = "0x51596F0", VA = "0x18515A8F0")]
	public bool MOFMGBPLFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x515A630", Offset = "0x5159430", VA = "0x18515A630")]
	public void KGEBHBJAGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x515BA60", Offset = "0x515A860", VA = "0x18515BA60")]
	public bool OHLPACMKPHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5159950", Offset = "0x5158750", VA = "0x185159950")]
	public void EGGFOGLBMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x515B1E0", Offset = "0x5159FE0", VA = "0x18515B1E0")]
	private void ODHKNFKBIBL(out byte[] IIIDLAGBFEE, out int BMPLOMLEEPP, out int FBELCFFBIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51599E0", Offset = "0x51587E0", VA = "0x1851599E0")]
	private static int EJOPLIGJPIC(char LEOEMBMBFBC, char GHDGKPNPOBN, char EKIHFBHEKEC, char EIEOEGFMKEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5159440", Offset = "0x5158240", VA = "0x185159440")]
	private static int BLECCDCJFOO(char IODEOJKDCNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5159850", Offset = "0x5158650", VA = "0x185159850")]
	public ArraySegment<byte> EDANADJEPFF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x515A250", Offset = "0x5159050", VA = "0x18515A250")]
	public string IMGKNGLCBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x515A800", Offset = "0x5159600", VA = "0x18515A800")]
	public string MANAPIJEGEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5159270", Offset = "0x5158070", VA = "0x185159270")]
	public ArraySegment<byte> BFNMMCFEPHM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x515A030", Offset = "0x5158E30", VA = "0x18515A030")]
	public ArraySegment<byte> HMPMOMGBNJN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5159B10", Offset = "0x5158910", VA = "0x185159B10")]
	public bool FDOGOBIIKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x515B9A0", Offset = "0x515A7A0", VA = "0x18515B9A0")]
	private static bool OFBGBKADAAF(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x515A450", Offset = "0x5159250", VA = "0x18515A450")]
	private void JJMNIGLHHNA(MNBDGEMMGMF JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5159650", Offset = "0x5158450", VA = "0x185159650")]
	public void BNGOLHFJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5159E50", Offset = "0x5158C50", VA = "0x185159E50")]
	private void GFFHNPAKJPN(int EAJOOLPCDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5159F80", Offset = "0x5158D80", VA = "0x185159F80")]
	public sbyte GKHGHCCKMDI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5159F20", Offset = "0x5158D20", VA = "0x185159F20")]
	public short GKGCAGNIFGK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x515BB80", Offset = "0x515A980", VA = "0x18515BB80")]
	public int POHKECICMGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5159D50", Offset = "0x5158B50", VA = "0x185159D50")]
	public long FJDGBGKNLND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x515A830", Offset = "0x5159630", VA = "0x18515A830")]
	public byte MIKONJDFFEM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x515BB20", Offset = "0x515A920", VA = "0x18515BB20")]
	public ushort PAAPNJDFIJA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5159660", Offset = "0x5158460", VA = "0x185159660")]
	public uint CLCMAHJMHOC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51591F0", Offset = "0x5157FF0", VA = "0x1851591F0")]
	public ulong ANPDDMDKNFL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x515A180", Offset = "0x5158F80", VA = "0x18515A180")]
	public float IJECNOKHBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5159120", Offset = "0x5157F20", VA = "0x185159120")]
	public double AINDKHMENLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x515A070", Offset = "0x5158E70", VA = "0x18515A070")]
	public ArraySegment<byte> IFDDHGFBHHP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51596C0", Offset = "0x51584C0", VA = "0x1851596C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C1850", Offset = "0x6C0650", VA = "0x1806C1850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CPGGHEFPEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x665B40", Offset = "0x664940", VA = "0x180665B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x514E860", Offset = "0x514D660", VA = "0x18514E860")]
	public BKIIPNGFFKI(string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x514E8D0", Offset = "0x514D6D0", VA = "0x18514E8D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
				public CCJENINHPJB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x853AE0", VA = "0x180854CE0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4F05640", Offset = "0x4F04440", VA = "0x184F05640")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0E300", Offset = "0x4F0D100", VA = "0x184F0E300")]
			public NLLAIECJHOI(Type BIEGICDMJCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5EA58F0", Offset = "0x5EA46F0", VA = "0x185EA58F0")]
			private static T LDEJBIHPFHF<T>(DynamicMethod IIEAKKJENEJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4F0E0B0", Offset = "0x4F0CEB0", VA = "0x184F0E0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F0BE10", Offset = "0x4F0AC10", VA = "0x184F0BE10")]
		static KCMEBGMHKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BD80", Offset = "0x4F0AB80", VA = "0x184F0BD80")]
		private static NLLAIECJHOI KAAMKKLEPKC(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BBF0", Offset = "0x4F0A9F0", VA = "0x184F0BBF0")]
		public static void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BAD0", Offset = "0x4F0A8D0", VA = "0x184F0BAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F07F30", Offset = "0x4F06D30", VA = "0x184F07F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5160090", Offset = "0x515EE90", VA = "0x185160090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MKNOGDLMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x515F290", Offset = "0x515E090", VA = "0x18515F290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5160020", Offset = "0x515EE20", VA = "0x185160020")]
	public static void PBGMGIBLABI(ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3378CC0", Offset = "0x3377AC0", VA = "0x183378CC0")]
	public static byte[] CLPGJOCDFOA<T>(T KMFLGGMLFJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3378DD0", Offset = "0x3377BD0", VA = "0x183378DD0")]
	public static byte[] CLPGJOCDFOA<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3378C30", Offset = "0x3377A30", VA = "0x183378C30")]
	public static void CLPGJOCDFOA<T>(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3379050", Offset = "0x3377E50", VA = "0x183379050")]
	public static void CLPGJOCDFOA<T>(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3378D40", Offset = "0x3377B40", VA = "0x183378D40")]
	public static void CLPGJOCDFOA<T>(Stream HPPBGHGOBLD, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3378F30", Offset = "0x3377D30", VA = "0x183378F30")]
	public static void CLPGJOCDFOA<T>(Stream HPPBGHGOBLD, T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3379490", Offset = "0x3378290", VA = "0x183379490")]
	public static ArraySegment<byte> LNHPCNIMABF<T>(T KMFLGGMLFJA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3379310", Offset = "0x3378110", VA = "0x183379310")]
	public static ArraySegment<byte> LNHPCNIMABF<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3379130", Offset = "0x3377F30", VA = "0x183379130")]
	public static string IAINPCLLFDI<T>(T GKFICKKHACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x33791B0", Offset = "0x3377FB0", VA = "0x1833791B0")]
	public static string IAINPCLLFDI<T>(T GKFICKKHACC, ECLEPONANIG MOPBAELKKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3379F80", Offset = "0x3378D80", VA = "0x183379F80")]
	public static T MNOLKCHHLIP<T>(string KKNHJNEDEHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3379E90", Offset = "0x3378C90", VA = "0x183379E90")]
	public static T MNOLKCHHLIP<T>(string KKNHJNEDEHL, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x337A7C0", Offset = "0x33795C0", VA = "0x18337A7C0")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x337A180", Offset = "0x3378F80", VA = "0x18337A180")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x337A840", Offset = "0x3379640", VA = "0x18337A840")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, int HPNBOGMLOLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x337A020", Offset = "0x3378E20", VA = "0x18337A020")]
	public static T MNOLKCHHLIP<T>(byte[] EHAMCGPFFID, int HPNBOGMLOLG, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x337A220", Offset = "0x3379020", VA = "0x18337A220")]
	public static T MNOLKCHHLIP<T>(ref FHNCKNEPFID LDNLHJMBEIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x337A590", Offset = "0x3379390", VA = "0x18337A590")]
	public static T MNOLKCHHLIP<T>(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x337A8D0", Offset = "0x33796D0", VA = "0x18337A8D0")]
	public static T MNOLKCHHLIP<T>(Stream HPPBGHGOBLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x337A320", Offset = "0x3379120", VA = "0x18337A320")]
	public static T MNOLKCHHLIP<T>(Stream HPPBGHGOBLD, ECLEPONANIG MOPBAELKKDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x515F040", Offset = "0x515DE40", VA = "0x18515F040")]
	public static string CDCAOLJEGBI(byte[] KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x515EF40", Offset = "0x515DD40", VA = "0x18515EF40")]
	public static string CDCAOLJEGBI(byte[] KKNHJNEDEHL, int HPNBOGMLOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x515F170", Offset = "0x515DF70", VA = "0x18515F170")]
	public static string CDCAOLJEGBI(string KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x515F4B0", Offset = "0x515E2B0", VA = "0x18515F4B0")]
	public static byte[] KMIPBNPKIBI(byte[] KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x515F390", Offset = "0x515E190", VA = "0x18515F390")]
	public static byte[] KMIPBNPKIBI(byte[] KKNHJNEDEHL, int HPNBOGMLOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x515F600", Offset = "0x515E400", VA = "0x18515F600")]
	public static byte[] KMIPBNPKIBI(string KKNHJNEDEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x515F740", Offset = "0x515E540", VA = "0x18515F740")]
	private static void MIOMJNAFJDI(ref FHNCKNEPFID LDNLHJMBEIM, ref DOFDDFPOMMF FHGALIAOBLC, int EMDDAPNEEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x515F2F0", Offset = "0x515E0F0", VA = "0x18515F2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D4910", Offset = "0x6D3710", VA = "0x1806D4910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5156060", Offset = "0x5154E60", VA = "0x185156060")]
	public void OKNDODPLLNL(int HPNBOGMLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5155400", Offset = "0x5154200", VA = "0x185155400")]
	public static byte[] DPEKEGKFHAB(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5155DF0", Offset = "0x5154BF0", VA = "0x185155DF0")]
	public static byte[] NKNKPMFDIPK(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x51552C0", Offset = "0x51540C0", VA = "0x1851552C0")]
	public static byte[] CNAIAJHCJCG(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5154E80", Offset = "0x5153C80", VA = "0x185154E80")]
	public static byte[] ANBKJMCPAMB(string BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x10FD750", Offset = "0x10FC550", VA = "0x1810FD750")]
	public DOFDDFPOMMF(byte[] PPGNAMOOEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51555E0", Offset = "0x51543E0", VA = "0x1851555E0")]
	public ArraySegment<byte> FDFMHAOFGLE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5155C20", Offset = "0x5154A20", VA = "0x185155C20")]
	public byte[] LMJOLBHEOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5156080", Offset = "0x5154E80", VA = "0x185156080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5156070", Offset = "0x5154E70", VA = "0x185156070")]
	public void PHCHFJPBPOA(int MMJADBDACLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5154240", Offset = "0x5153040", VA = "0x185154240")]
	public void JBKLAODHJCC(byte BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5155B40", Offset = "0x5154940", VA = "0x185155B40")]
	public void JBKLAODHJCC(byte[] BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5154E40", Offset = "0x5153C40", VA = "0x185154E40")]
	public void AIHHAKJNJBB(byte BOJBAFFJKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5155560", Offset = "0x5154360", VA = "0x185155560")]
	public void EMDHFENDCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5155D00", Offset = "0x5154B00", VA = "0x185155D00")]
	public void MJFBLGFMJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5155270", Offset = "0x5154070", VA = "0x185155270")]
	public void CLFPAFJEFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5155D50", Offset = "0x5154B50", VA = "0x185155D50")]
	public void MPADNNCKMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5155BD0", Offset = "0x51549D0", VA = "0x185155BD0")]
	public void KKDPKKBBNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5155DA0", Offset = "0x5154BA0", VA = "0x185155DA0")]
	public void NCEKAAPKDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5156000", Offset = "0x5154E00", VA = "0x185156000")]
	public void OHPIDNLMPDM(string BBEHMKMODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5155A90", Offset = "0x5154890", VA = "0x185155A90")]
	public void GFFEGFECPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5155F30", Offset = "0x5154D30", VA = "0x185155F30")]
	public void OHCAIIKBKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5155000", Offset = "0x5153E00", VA = "0x185155000")]
	public void BMMBHBNGKAB(bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51554E0", Offset = "0x51542E0", VA = "0x1851554E0")]
	public void EAFKALCKAFI(float GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x51551F0", Offset = "0x5153FF0", VA = "0x1851551F0")]
	public void BNFJECHLACP(double GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5155AE0", Offset = "0x51548E0", VA = "0x185155AE0")]
	public void HDKNFFFMDLO(byte GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5155CA0", Offset = "0x5154AA0", VA = "0x185155CA0")]
	public void MBGEIOOOPHJ(ushort GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5155B10", Offset = "0x5154910", VA = "0x185155B10")]
	public void INKIGEMMDAP(uint GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51555B0", Offset = "0x51543B0", VA = "0x1851555B0")]
	public void EODPALIIPIF(ulong GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5154FD0", Offset = "0x5153DD0", VA = "0x185154FD0")]
	public void BBNIDPFHDDO(sbyte GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5155A60", Offset = "0x5154860", VA = "0x185155A60")]
	public void FJNGIBNLCOA(short GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5155CD0", Offset = "0x5154AD0", VA = "0x185155CD0")]
	public void MCDADLDAIEM(int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5155BA0", Offset = "0x51549A0", VA = "0x185155BA0")]
	public void JMNCMAGABKG(long GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5155690", Offset = "0x5154490", VA = "0x185155690")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B15580", Offset = "0x2B14380", VA = "0x182B15580")]
		static BOJCPICAHNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private OIJDCLPFBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D5E80", Offset = "0x46D4C80", VA = "0x1846D5E80")]
	static IDDNDICPBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46D5770", Offset = "0x46D4570", VA = "0x1846D5770")]
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
	[Cpp2IlInjected.Address(RVA = "0x5153BF0", Offset = "0x51529F0", VA = "0x185153BF0")]
	public DBMEJEOCJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5153760", Offset = "0x5152560", VA = "0x185153760", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector2 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5153910", Offset = "0x5152710", VA = "0x185153910", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F174D0", Offset = "0x4F162D0", VA = "0x184F174D0")]
	public PNBENEPHLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F171F0", Offset = "0x4F15FF0", VA = "0x184F171F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector3 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4F17310", Offset = "0x4F16110", VA = "0x184F17310", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F14F00", Offset = "0x4F13D00", VA = "0x184F14F00")]
	public OPBMICDPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x46DA9E0", Offset = "0x46D97E0", VA = "0x1846DA9E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Vector4 GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F14CE0", Offset = "0x4F13AE0", VA = "0x184F14CE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DADC0", Offset = "0x46D9BC0", VA = "0x1846DADC0")]
	public KIGCAHADMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x46DA9E0", Offset = "0x46D97E0", VA = "0x1846DA9E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Quaternion GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x46DAB30", Offset = "0x46D9930", VA = "0x1846DAB30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F15900", Offset = "0x4F14700", VA = "0x184F15900")]
	public PEMLHGIEKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x46DA9E0", Offset = "0x46D97E0", VA = "0x1846DA9E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Color GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F156E0", Offset = "0x4F144E0", VA = "0x184F156E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D8360", Offset = "0x46D7160", VA = "0x1846D8360")]
	public IKIFIEFOCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46D7E90", Offset = "0x46D6C90", VA = "0x1846D7E90", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Bounds GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x46D8030", Offset = "0x46D6E30", VA = "0x1846D8030", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F15FE0", Offset = "0x4F14DE0", VA = "0x184F15FE0")]
	public PFGDOALPDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F15C30", Offset = "0x4F14A30", VA = "0x184F15C30", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Rect GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F15DA0", Offset = "0x4F14BA0", VA = "0x184F15DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4143D10", Offset = "0x4142B10", VA = "0x184143D10")]
		static CCBAFBMDFKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private MBFLFPGENDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31C4FD0", Offset = "0x31C3DD0", VA = "0x1831C4FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F08CB0", Offset = "0x4F07AB0", VA = "0x184F08CB0")]
		internal static object GGDPDDGCHAL(Type NDJEJACDKEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private MNMDCFDLAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x417E520", Offset = "0x417D320", VA = "0x18417E520")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private OECOPDMAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F10610", Offset = "0x4F0F410", VA = "0x184F10610")]
	public static void EHMHLLLMBAF(params ECLEPONANIG[] POPNGAPBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F106F0", Offset = "0x4F0F4F0", VA = "0x184F106F0")]
	public static void EHMHLLLMBAF(params DIAHDCBEFFK[] EMKJNOOCILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F10380", Offset = "0x4F0F180", VA = "0x184F10380")]
	public static void BIBMIBHFBCM(DIAHDCBEFFK[] EMKJNOOCILN, ECLEPONANIG[] POPNGAPBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3485C50", Offset = "0x3484A50", VA = "0x183485C50")]
		static CNJCKOJHKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private LHEGHLFPDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D2790", Offset = "0x46D1590", VA = "0x1846D2790")]
	internal static object GGDPDDGCHAL(Type NDJEJACDKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46D4120", Offset = "0x46D2F20", VA = "0x1846D4120")]
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
		[Cpp2IlInjected.Address(RVA = "0x2525DE0", Offset = "0x2524BE0", VA = "0x182525DE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DA380", Offset = "0x46D9180", VA = "0x1846DA380")]
	static KABDEOJOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private KABDEOJOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A88EC0", Offset = "0x3A87CC0", VA = "0x183A88EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5161410", Offset = "0x5160210", VA = "0x185161410")]
	static GJJDKMNHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private GJJDKMNHGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A82A80", Offset = "0x3A81880", VA = "0x183A82A80")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D85A0", Offset = "0x46D73A0", VA = "0x1846D85A0")]
	static IMJMANNAMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private IMJMANNAMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D17660", Offset = "0x2D16460", VA = "0x182D17660")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DA8B0", Offset = "0x46D96B0", VA = "0x1846DA8B0")]
	static KIEFALEGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private KIEFALEGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x310E470", Offset = "0x310D270", VA = "0x18310E470")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F108B0", Offset = "0x4F0F6B0", VA = "0x184F108B0")]
	static OGPLIMMAGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private OGPLIMMAGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x311C1F0", Offset = "0x311AFF0", VA = "0x18311C1F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514DD40", Offset = "0x514CB40", VA = "0x18514DD40")]
	static BEIFCJDKFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private BEIFCJDKFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBCA00", Offset = "0x2BBB800", VA = "0x182BBCA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x413ED90", Offset = "0x413DB90", VA = "0x18413ED90")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F144E0", Offset = "0x2F132E0", VA = "0x182F144E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x31450E0", Offset = "0x3143EE0", VA = "0x1831450E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D05190", Offset = "0x2D03F90", VA = "0x182D05190")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x31B4F80", Offset = "0x31B3D80", VA = "0x1831B4F80")]
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
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
	public global::LKBCOOCHDMC<T> GGDPDDGCHAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0C060", Offset = "0x4F0AE60", VA = "0x184F0C060")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0D1A0", Offset = "0x4F0BFA0", VA = "0x184F0D1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F05F10", Offset = "0x4F04D10", VA = "0x184F05F10")]
		public static MethodInfo CLPGJOCDFOA(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F061E0", Offset = "0x4F04FE0", VA = "0x184F061E0")]
		public static MethodInfo MNOLKCHHLIP(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4F06450", Offset = "0x4F05250", VA = "0x184F06450")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HFDDHAENLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4F08BD0", Offset = "0x4F079D0", VA = "0x184F08BD0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4F08C10", Offset = "0x4F07A10", VA = "0x184F08C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GFOMLFPAHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4F08230", Offset = "0x4F07030", VA = "0x184F08230")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EAHJEHDNDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F07BF0", Offset = "0x4F069F0", VA = "0x184F07BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NNDJACBLPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4F10000", Offset = "0x4F0EE00", VA = "0x184F10000")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public IPLPHBDMGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B210", Offset = "0x4F0A010", VA = "0x184F0B210")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B220", Offset = "0x4F0A020", VA = "0x184F0B220")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LNMMKAGJEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CE40", Offset = "0x4F0BC40", VA = "0x184F0CE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GMKMJOPDOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x752220", Offset = "0x751020", VA = "0x180752220")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public NINEDALDEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4F0DF90", Offset = "0x4F0CD90", VA = "0x184F0DF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public CKDJFAPEMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4F05A00", Offset = "0x4F04800", VA = "0x184F05A00")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4F05CB0", Offset = "0x4F04AB0", VA = "0x184F05CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MFNJNIHLMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1952140", Offset = "0x1950F40", VA = "0x181952140")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EEEBCKEOIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1952140", Offset = "0x1950F40", VA = "0x181952140")]
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
	[Cpp2IlInjected.Address(RVA = "0x42ED9B0", Offset = "0x42EC7B0", VA = "0x1842ED9B0")]
	public static object DBODLKDNNEM<T>(ANANODFDIKB AGJCPOHEOBI, ECLEPONANIG IJNCCJAKJOI, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x42F8DF0", Offset = "0x42F7BF0", VA = "0x1842F8DF0")]
	public static object KCKCFHGHKEK<T>(ECLEPONANIG IJNCCJAKJOI, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL, bool JLPMIGAFJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x46DB7B0", Offset = "0x46DA5B0", VA = "0x1846DB7B0")]
	private static TypeInfo BDOJKEENDPE(ANANODFDIKB AGJCPOHEOBI, Type BIEGICDMJCM, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x46E1380", Offset = "0x46E0180", VA = "0x1846E1380")]
	public static object NCENDCOIFBB(Type BIEGICDMJCM, Func<string, string> JFENHKOBMIC, bool OEPDJABOINL, bool JLPMIGAFJEJ, bool BLAHBPOEOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x46DFAA0", Offset = "0x46DE8A0", VA = "0x1846DFAA0")]
	private static Dictionary<PGBPOAOHMEE, FieldInfo> LKOENEEHEKD(TypeBuilder CNPCNGBKDBI, ANHAKGCJAHL DHBOJIINPOH, ConstructorInfo IBPPDEDMEKC, FieldBuilder NJALFMNOAPL, ILGenerator MELBLMPENNB, bool OEPDJABOINL, bool FJNLHMAPMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x46DB130", Offset = "0x46D9F30", VA = "0x1846DB130")]
	private static Dictionary<PGBPOAOHMEE, FieldInfo> AHIKKEHANPB(TypeBuilder CNPCNGBKDBI, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x46DD690", Offset = "0x46DC490", VA = "0x1846DD690")]
	private static void JDMNBMACBCI(Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB, Action JDEMAONCDFJ, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, bool OEPDJABOINL, bool FJNLHMAPMEP, int BONMOGBABJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x46E0E30", Offset = "0x46DFC30", VA = "0x1846E0E30")]
	private static void MKOKDLPOMPB(TypeInfo BIEGICDMJCM, PGBPOAOHMEE INHJAOHPFCJ, ILGenerator MELBLMPENNB, int BNNEENLPEFO, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, BGDOAOECCIG FHGALIAOBLC, BGDOAOECCIG GGGECDMHEBI, BGDOAOECCIG KMAIOPKCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x46DC240", Offset = "0x46DB040", VA = "0x1846DC240")]
	private static void BEFMGEKOLMK(Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, ILGenerator MELBLMPENNB, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, bool MGKAEDHHCAB, int BONMOGBABJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x46DF430", Offset = "0x46DE230", VA = "0x1846DF430")]
	private static void LAGLEDHAGFO(ILGenerator MELBLMPENNB, EONIPAGNNJL DHBOJIINPOH, int BNNEENLPEFO, Func<int, PGBPOAOHMEE, bool> PIOCGMOLAIP, BGDOAOECCIG LDNLHJMBEIM, BGDOAOECCIG KMAIOPKCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x46E0180", Offset = "0x46DEF80", VA = "0x1846E0180")]
	private static LocalBuilder MBBGJNBFHMO(ILGenerator MELBLMPENNB, Type BIEGICDMJCM, ANHAKGCJAHL DHBOJIINPOH, EONIPAGNNJL[] NFHEICNCFMJ, bool JHKCINPJOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x46DEBB0", Offset = "0x46DD9B0", VA = "0x1846DEBB0")]
	private static bool JINNMECLADC(ConstructorInfo DHONEMIKGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x46DF8F0", Offset = "0x46DE6F0", VA = "0x1846DF8F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD3880", Offset = "0x2BD2680", VA = "0x182BD3880")]
	public CLMDGEBICMB(byte[][] NJALFMNOAPL, object[] ACFNKICABCE, object[] HPDDDHNNNKJ, global::AGOCOFFCFAH<T> KKIKIOMPACD, global::CACKAMEIKNN<T> KMACGJHLGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3471F90", Offset = "0x3470D90", VA = "0x183471F90", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3472070", Offset = "0x3470E70", VA = "0x183472070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x314EB30", Offset = "0x314D930", VA = "0x18314EB30")]
		static DCICBPIEDCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private EBEAGAKJIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39858B0", Offset = "0x39846B0", VA = "0x1839858B0")]
		static KHOFOIIPIOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly ECLEPONANIG EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private OJCEJFJPBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD5BA0", Offset = "0x2BD49A0", VA = "0x182BD5BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A8D950", Offset = "0x3A8C750", VA = "0x183A8D950")]
			static LPBOBHJPPEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private HCOFJOPDBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private ONDKCGAIIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31A9C20", Offset = "0x31A8A20", VA = "0x1831A9C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x33157C0", Offset = "0x33145C0", VA = "0x1833157C0")]
			static EGFNLOBLPBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private CFJDEAIFBGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private BLGFOAGCBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3970110", Offset = "0x396EF10", VA = "0x183970110")]
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
			[Cpp2IlInjected.Address(RVA = "0x259D990", Offset = "0x259C790", VA = "0x18259D990")]
			static IOEAGHKDPBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private BNNNFALHJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private EPJCBPCEIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3300FE0", Offset = "0x32FFDE0", VA = "0x183300FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x25A1890", Offset = "0x25A0690", VA = "0x1825A1890")]
			static IPJJEPMFOIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private EEGDJECFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private GOKFDIDIAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F50250", Offset = "0x3F4F050", VA = "0x183F50250")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F4B5F0", Offset = "0x3F4A3F0", VA = "0x183F4B5F0")]
			static JKCADDHPNAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private GEINDHIHCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private BJMILNEOFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FE7600", Offset = "0x3FE6400", VA = "0x183FE7600")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BCFC20", Offset = "0x2BCEA20", VA = "0x182BCFC20")]
			static NELEBMCODFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private GOGDFHOMLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private FDIGDCAFECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDE0F0", Offset = "0x2BDCEF0", VA = "0x182BDE0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x306A060", Offset = "0x3068E60", VA = "0x18306A060")]
			static PDBOBIMOPHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private NPJJBBLMMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private LHLHDKCALGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D20AE0", Offset = "0x3D1F8E0", VA = "0x183D20AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x417C930", Offset = "0x417B730", VA = "0x18417C930")]
			static CIJPDLGFEFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private HCINNBDDFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private IHJNLDFHNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D8A0D0", Offset = "0x3D88ED0", VA = "0x183D8A0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F172A0", Offset = "0x2F160A0", VA = "0x182F172A0")]
			static ODJFOJAGMJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private MEBNEMNFBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private IMKLBCBNCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39C5E90", Offset = "0x39C4C90", VA = "0x1839C5E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x398E040", Offset = "0x398CE40", VA = "0x18398E040")]
			static KINCFKKDDDE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private OPMAAGAJEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private DLADNMIEPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3838EB0", Offset = "0x3837CB0", VA = "0x183838EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28B8F50", Offset = "0x28B7D50", VA = "0x1828B8F50")]
			static MHDIACEPOFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private PKDODGFHMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private LHMBFIFALOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3074CF0", Offset = "0x3073AF0", VA = "0x183074CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F54BF0", Offset = "0x3F539F0", VA = "0x183F54BF0")]
			static JLMJJDEPOEB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly ECLEPONANIG EBMHMHOHCNI;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly ECLEPONANIG[] POPNGAPBKKH;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		private DDCEDBKOKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	private EDPFLBHCIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x21C8130", Offset = "0x21C6F30", VA = "0x1821C8130", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BE9E50", Offset = "0x2BE8C50", VA = "0x182BE9E50")]
	public NKNHJAPLKAK(int BMBMFEJNLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9A60", Offset = "0x2BE8860", VA = "0x182BE9A60")]
	public void ELGBPIMHCCH(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9DC0", Offset = "0x2BE8BC0", VA = "0x182BE9DC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DA330", Offset = "0x46D9130", VA = "0x1846DA330")]
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
	[Cpp2IlInjected.Address(RVA = "0x3841CA0", Offset = "0x3840AA0", VA = "0x183841CA0")]
	public OPAADMJLBMO(int LNKIBLBMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x38409A0", Offset = "0x383F7A0", VA = "0x1838409A0")]
	public T[] FGHCNDDNPOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3840CE0", Offset = "0x383FAE0", VA = "0x183840CE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
			[DebuggerHidden]
			public NGKOJBMIPHD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4F0DE20", Offset = "0x4F0CC20", VA = "0x184F0DE20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4F0DF50", Offset = "0x4F0CD50", VA = "0x184F0DF50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4F0DEB0", Offset = "0x4F0CCB0", VA = "0x184F0DEB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AFDNADMOAPK> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4F0DEB0", Offset = "0x4F0CCB0", VA = "0x184F0DEB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public IEPHHBMNIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x752220", Offset = "0x751020", VA = "0x180752220")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x752220", Offset = "0x751020", VA = "0x180752220")]
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
			[Cpp2IlInjected.Address(RVA = "0x12235B0", Offset = "0x12223B0", VA = "0x1812235B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F05130", Offset = "0x4F03F30", VA = "0x184F05130")]
		public AFDNADMOAPK(ulong BIMCDHOFDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F04BC0", Offset = "0x4F039C0", VA = "0x184F04BC0")]
		public AFDNADMOAPK ELGBPIMHCCH(ulong BIMCDHOFDCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F04B70", Offset = "0x4F03970", VA = "0x184F04B70")]
		public AFDNADMOAPK ELGBPIMHCCH(ulong BIMCDHOFDCP, int GKFICKKHACC, string GMPCBKNNHPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F04EF0", Offset = "0x4F03CF0", VA = "0x184F04EF0")]
		public AFDNADMOAPK MKBIJINFBDG(byte[] KNNJFFBFLLC, ref int HPNBOGMLOLG, ref int KNMPCIFBGHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F04AF0", Offset = "0x4F038F0", VA = "0x184F04AF0")]
		internal static int DDLINCEEPBH(ulong[] EJLDCNGHIAK, int BNNEENLPEFO, int PMIIGNOLFGJ, ulong GKFICKKHACC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F04AC0", Offset = "0x4F038C0", VA = "0x184F04AC0", Slot = "4")]
		public int CompareTo(AFDNADMOAPK MCLIMJFDMCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F04E80", Offset = "0x4F03C80", VA = "0x184F04E80")]
		[IteratorStateMachine(typeof(NGKOJBMIPHD))]
		public IEnumerable<AFDNADMOAPK> HNOKIDCJDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F03C90", Offset = "0x4F02A90", VA = "0x184F03C90")]
		public void AOMPHOEGFJA(ILGenerator MELBLMPENNB, LocalBuilder KNNJFFBFLLC, LocalBuilder KNMPCIFBGHP, LocalBuilder BIMCDHOFDCP, Action<KeyValuePair<string, int>> AHFKDOABCIJ, Action CEGBGLEKOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F03DD0", Offset = "0x4F02BD0", VA = "0x184F03DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F0B900", Offset = "0x4F0A700", VA = "0x184F0B900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6CF620", Offset = "0x6CE420", VA = "0x1806CF620")]
		[DebuggerHidden]
		public JBJECKBFACL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B950", Offset = "0x4F0A750", VA = "0x184F0B950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B3C0", Offset = "0x4F0A1C0", VA = "0x184F0B3C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BA30", Offset = "0x4F0A830", VA = "0x184F0BA30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BA80", Offset = "0x4F0A880", VA = "0x184F0BA80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B8C0", Offset = "0x4F0A6C0", VA = "0x184F0B8C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B820", Offset = "0x4F0A620", VA = "0x184F0B820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B820", Offset = "0x4F0A620", VA = "0x184F0B820", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E3BA0", Offset = "0x46E29A0", VA = "0x1846E3BA0")]
	public KOGDNCENHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x46E3570", Offset = "0x46E2370", VA = "0x1846E3570")]
	public void ELGBPIMHCCH(byte[] EHAMCGPFFID, int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x46E39E0", Offset = "0x46E27E0", VA = "0x1846E39E0")]
	public bool KMBCPONNOJK(ArraySegment<byte> BIMCDHOFDCP, out int GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x46E3B10", Offset = "0x46E2910", VA = "0x1846E3B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x46E3740", Offset = "0x46E2540", VA = "0x1846E3740")]
	private static void KIIBOHGMPDA(IEnumerable<AFDNADMOAPK> MLODMDDPNOG, StringBuilder HBILMDLCHEA, int EMDDAPNEEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x46E3690", Offset = "0x46E2490", VA = "0x1846E3690", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x46E3690", Offset = "0x46E2490", VA = "0x1846E3690", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x46E3AA0", Offset = "0x46E28A0", VA = "0x1846E3AA0")]
	[IteratorStateMachine(typeof(JBJECKBFACL))]
	private static IEnumerable<KeyValuePair<string, int>> MIHGOPNCGDP(IEnumerable<AFDNADMOAPK> MLODMDDPNOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x46E3540", Offset = "0x46E2340", VA = "0x1846E3540")]
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
	[Cpp2IlInjected.Address(RVA = "0x5150F50", Offset = "0x514FD50", VA = "0x185150F50")]
	public static ulong FFJCNLGDCMN(byte[] EHAMCGPFFID, ref int HPNBOGMLOLG, ref int KNMPCIFBGHP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class JOJPDIPPANJ
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x46DA170", Offset = "0x46D8F70", VA = "0x1846DA170")]
	public static void PHCHFJPBPOA(ref byte[] EHAMCGPFFID, int HPNBOGMLOLG, int MMJADBDACLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x46D9F40", Offset = "0x46D8D40", VA = "0x1846D9F40")]
	public static void BDDKEINNAJH(ref byte[] EJLDCNGHIAK, int JLCKPDBPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x46DA050", Offset = "0x46D8E50", VA = "0x1846DA050")]
	public static byte[] KDBLIMPBLJN(byte[] HOGBBBFDPKI, int JLCKPDBPCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GEGFCFJAGFJ
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5161110", Offset = "0x515FF10", VA = "0x185161110")]
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
		[Cpp2IlInjected.Address(RVA = "0x33085B0", Offset = "0x33073B0", VA = "0x1833085B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3115750", Offset = "0x3114550", VA = "0x183115750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x24E8DB0", Offset = "0x24E7BB0", VA = "0x1824E8DB0")]
		[DebuggerHidden]
		public JDDMCLINGPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3114B40", Offset = "0x3113940", VA = "0x183114B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3115650", Offset = "0x3114450", VA = "0x183115650", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x34046B0", Offset = "0x34034B0", VA = "0x1834046B0")]
	public CHMFILPMNGC(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x34046E0", Offset = "0x34034E0", VA = "0x1834046E0")]
	public CHMFILPMNGC(int BPGPHKEJPBF, float NMIHKFPNGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3402A50", Offset = "0x3401850", VA = "0x183402A50")]
	public void ELGBPIMHCCH(byte[] BIMCDHOFDCP, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3400F50", Offset = "0x33FFD50", VA = "0x183400F50")]
	private bool COBHKKPEGNJ(byte[] BIMCDHOFDCP, T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3404100", Offset = "0x3402F00", VA = "0x183404100")]
	public bool GINCMLLPDOD(ArraySegment<byte> BIMCDHOFDCP, out T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3404650", Offset = "0x3403450", VA = "0x183404650")]
	private static ulong HFEBIEPOMOG(byte[] IODEOJKDCNL, int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x30B6660", Offset = "0x30B5460", VA = "0x1830B6660")]
	private static int EIDKLNIPCLK(int EFDNGGMKDGH, float NMIHKFPNGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x34044A0", Offset = "0x34032A0", VA = "0x1834044A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::CHMFILPMNGC<>.JDDMCLINGPO))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x28AD4E0", Offset = "0x28AC2E0", VA = "0x1828AD4E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x46E4AF0", Offset = "0x46E38F0", VA = "0x1846E4AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x46E4C60", Offset = "0x46E3A60", VA = "0x1846E4C60")]
	static LIDIKILGCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x46E4EE0", Offset = "0x46E3CE0", VA = "0x1846E4EE0")]
	public LIDIKILGCGM(byte[] ONEBLEMJKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x46E4B40", Offset = "0x46E3940", VA = "0x1846E4B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x46EBC40", Offset = "0x46EAA40", VA = "0x1846EBC40")]
	public NGOHDGPKKNN(ref Guid GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x46EA7F0", Offset = "0x46E95F0", VA = "0x1846EA7F0")]
	public NGOHDGPKKNN(ref ArraySegment<byte> HMLIEMNEDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x46EA660", Offset = "0x46E9460", VA = "0x1846EA660")]
	private static byte PANKMHLLLEL(byte[] EHAMCGPFFID, int MDJJLNNJDPM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x46EA550", Offset = "0x46E9350", VA = "0x1846EA550")]
	private static byte NDDMAKJOOLA(byte GHDGKPNPOBN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x46E9200", Offset = "0x46E8000", VA = "0x1846E9200")]
	public void FEBNLFJNNAM(byte[] NFMJIELOGNG, int HPNBOGMLOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class FOGHDLBJEFL
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x515EEC0", Offset = "0x515DCC0", VA = "0x18515EEC0")]
	public static bool PMLBIFINJOC(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x515D500", Offset = "0x515C300", VA = "0x18515D500")]
	public static bool EMLMMFCHINI(byte EKIHFBHEKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x515E0D0", Offset = "0x515CED0", VA = "0x18515E0D0")]
	public static sbyte GKHGHCCKMDI(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x515E060", Offset = "0x515CE60", VA = "0x18515E060")]
	public static short GKGCAGNIFGK(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x515EED0", Offset = "0x515DCD0", VA = "0x18515EED0")]
	public static int POHKECICMGP(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x515DFB0", Offset = "0x515CDB0", VA = "0x18515DFB0")]
	public static long FJDGBGKNLND(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x515EDE0", Offset = "0x515DBE0", VA = "0x18515EDE0")]
	public static byte MIKONJDFFEM(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x515EE50", Offset = "0x515DC50", VA = "0x18515EE50")]
	public static ushort PAAPNJDFIJA(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x515D480", Offset = "0x515C280", VA = "0x18515D480")]
	public static uint CLCMAHJMHOC(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x515D370", Offset = "0x515C170", VA = "0x18515D370")]
	public static ulong ANPDDMDKNFL(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x515E140", Offset = "0x515CF40", VA = "0x18515E140")]
	public static float IJECNOKHBPP(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x515D300", Offset = "0x515C100", VA = "0x18515D300")]
	public static double AINDKHMENLM(byte[] EHAMCGPFFID, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x515D570", Offset = "0x515C370", VA = "0x18515D570")]
	public static int EODPALIIPIF(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, ulong GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x515E1B0", Offset = "0x515CFB0", VA = "0x18515E1B0")]
	public static int JMNCMAGABKG(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, long GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x515DD40", Offset = "0x515CB40", VA = "0x18515DD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public OJHPBLBMBDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4F11160", Offset = "0x4F0FF60", VA = "0x184F11160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4F10D00", Offset = "0x4F0FB00", VA = "0x184F10D00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4F11250", Offset = "0x4F10050", VA = "0x184F11250")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4F112A0", Offset = "0x4F100A0", VA = "0x184F112A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F11120", Offset = "0x4F0FF20", VA = "0x184F11120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4F11070", Offset = "0x4F0FE70", VA = "0x184F11070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4F11070", Offset = "0x4F0FE70", VA = "0x184F11070", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public HKFHACCKHFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B080", Offset = "0x4F09E80", VA = "0x184F0B080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4F0AC20", Offset = "0x4F09A20", VA = "0x184F0AC20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B170", Offset = "0x4F09F70", VA = "0x184F0B170")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B1C0", Offset = "0x4F09FC0", VA = "0x184F0B1C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B040", Offset = "0x4F09E40", VA = "0x184F0B040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4F0AF90", Offset = "0x4F09D90", VA = "0x184F0AF90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4F0AF90", Offset = "0x4F09D90", VA = "0x184F0AF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x51615D0", Offset = "0x51603D0", VA = "0x1851615D0")]
	public static bool BGPBEDMIFCA(this TypeInfo BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5161690", Offset = "0x5160490", VA = "0x185161690")]
	public static bool DLBFJADMJFC(this TypeInfo BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5161910", Offset = "0x5160710", VA = "0x185161910")]
	public static IEnumerable<PropertyInfo> NKHKNEHJNAG(this Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x51617B0", Offset = "0x51605B0", VA = "0x1851617B0")]
	[IteratorStateMachine(typeof(OJHPBLBMBDM))]
	private static IEnumerable<PropertyInfo> FLLPLKOEGFI(Type BIEGICDMJCM, HashSet<string> JLFCMEJDGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x5161840", Offset = "0x5160640", VA = "0x185161840")]
	public static IEnumerable<FieldInfo> JABDJJLEKHG(this Type BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x5161540", Offset = "0x5160340", VA = "0x185161540")]
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
	[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0")]
	public static string MLEKIOIIADP(string PJBFFCCCLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x46D6450", Offset = "0x46D5250", VA = "0x1846D6450")]
	public static string BNIINNGFBOA(string PJBFFCCCLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x46D6560", Offset = "0x46D5360", VA = "0x1846D6560")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD9C70", Offset = "0x2BD8A70", VA = "0x182BD9C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C30", Offset = "0x2BD8A30", VA = "0x182BD9C30")]
		private int EONFJIOMKJN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public HGMJKEBGDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x694580", Offset = "0x693380", VA = "0x180694580")]
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
	[Cpp2IlInjected.Address(RVA = "0x30B74B0", Offset = "0x30B62B0", VA = "0x1830B74B0")]
	public PPCMGBHHGII(int BPGPHKEJPBF = 4, float NMIHKFPNGOL = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x30B6C10", Offset = "0x30B5A10", VA = "0x1830B6C10")]
	public bool NKDBGPNCFBD(Type BIMCDHOFDCP, TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x30B6B90", Offset = "0x30B5990", VA = "0x1830B6B90")]
	public bool NKDBGPNCFBD(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x30B60C0", Offset = "0x30B4EC0", VA = "0x1830B60C0")]
	private bool COBHKKPEGNJ(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK, out TValue FGDPPDEPGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x30B70F0", Offset = "0x30B5EF0", VA = "0x1830B70F0")]
	private bool PDBPLCCLOAF(NFOEMPKBOIG[] BJJJFFMEHMH, Type OLADFIEFHDG, NFOEMPKBOIG JMCIBGBLEIM, Func<Type, TValue> FOPKMMCKCMK, out TValue FGDPPDEPGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x30B6690", Offset = "0x30B5490", VA = "0x1830B6690")]
	public bool GINCMLLPDOD(Type BIMCDHOFDCP, out TValue GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x30B69D0", Offset = "0x30B57D0", VA = "0x1830B69D0")]
	public TValue KAAMKKLEPKC(Type BIMCDHOFDCP, Func<Type, TValue> FOPKMMCKCMK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x30B6660", Offset = "0x30B5460", VA = "0x1830B6660")]
	private static int EIDKLNIPCLK(int EFDNGGMKDGH, float NMIHKFPNGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x30B6D20", Offset = "0x30B5B20", VA = "0x1830B6D20")]
	private static void PDBMHFFHIGN(ref NFOEMPKBOIG NIBJLJHBBKF, NFOEMPKBOIG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x30B6D20", Offset = "0x30B5B20", VA = "0x1830B6D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x514A970", Offset = "0x5149770", VA = "0x18514A970")]
	public TypeBuilder NHJENGODLDL(string NLCIGFDKGEE, TypeAttributes MLLHCAFGHOC, Type GEOFAMNLJNK, Type[] NCOLHBJLCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x514AA40", Offset = "0x5149840", VA = "0x18514AA40")]
	public ANANODFDIKB(string GEBMPOGMOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class JMIKOBEKADH
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x46D9E70", Offset = "0x46D8C70", VA = "0x1846D9E70")]
	private static MethodInfo LFDNPDEIIDA(LambdaExpression GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x28F80B0", Offset = "0x28F6EB0", VA = "0x1828F80B0")]
	public static MethodInfo OIDJDNPFAIN<T>(Expression<Func<T>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x28F80B0", Offset = "0x28F6EB0", VA = "0x1828F80B0")]
	public static MethodInfo OIDJDNPFAIN<T, TR>(Expression<Func<T, TR>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x28F80B0", Offset = "0x28F6EB0", VA = "0x1828F80B0")]
	public static MethodInfo OIDJDNPFAIN<T>(Expression<Action<T>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x28F80B0", Offset = "0x28F6EB0", VA = "0x1828F80B0")]
	public static MethodInfo OIDJDNPFAIN<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> GOFOHEEBHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x28F8000", Offset = "0x28F6E00", VA = "0x1828F8000")]
	private static MemberInfo HBEJEGLPNIG<T>(Expression<T> GPNGGDGNOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x28F7FA0", Offset = "0x28F6DA0", VA = "0x1828F7FA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514E200", Offset = "0x514D000", VA = "0x18514E200")]
	public BGDOAOECCIG(ILGenerator MELBLMPENNB, int OJFFKHAMPMJ, bool OCFDEANOGHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x514E240", Offset = "0x514D040", VA = "0x18514E240")]
	public BGDOAOECCIG(ILGenerator MELBLMPENNB, int OJFFKHAMPMJ, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x514E0E0", Offset = "0x514CEE0", VA = "0x18514E0E0")]
	public void OCFDDABPLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class FIECBGFDONB
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x515C120", Offset = "0x515AF20", VA = "0x18515C120")]
	public static void BIGOJAJDKGK(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x515C0E0", Offset = "0x515AEE0", VA = "0x18515C0E0")]
	public static void BIGOJAJDKGK(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x515CD10", Offset = "0x515BB10", VA = "0x18515CD10")]
	public static void GHAFKHPOGHA(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x515CCD0", Offset = "0x515BAD0", VA = "0x18515CCD0")]
	public static void GHAFKHPOGHA(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x515C590", Offset = "0x515B390", VA = "0x18515C590")]
	public static void DAMGICMJNFF(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x515C680", Offset = "0x515B480", VA = "0x18515C680")]
	public static void DAMGICMJNFF(this ILGenerator MELBLMPENNB, LocalBuilder OCJCCNCGCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x515CFF0", Offset = "0x515BDF0", VA = "0x18515CFF0")]
	public static void LGOONGAKBBP(this ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x515C350", Offset = "0x515B150", VA = "0x18515C350")]
	public static void BKOMNOEFPEC(this ILGenerator MELBLMPENNB, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x515C790", Offset = "0x515B590", VA = "0x18515C790")]
	public static void EDFNEBOGMOB(this ILGenerator MELBLMPENNB, int GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x515BFF0", Offset = "0x515ADF0", VA = "0x18515BFF0")]
	public static void BAIOGHHAOHC(this ILGenerator MELBLMPENNB, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x515CF40", Offset = "0x515BD40", VA = "0x18515CF40")]
	public static void IIMCIMBCFNE(this ILGenerator MELBLMPENNB, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x515C360", Offset = "0x515B160", VA = "0x18515C360")]
	public static void CPBLONEDPCM(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x515BF70", Offset = "0x515AD70", VA = "0x18515BF70")]
	public static void AJLPANEMOIG(this ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x515CBE0", Offset = "0x515B9E0", VA = "0x18515CBE0")]
	public static void FLEAOBFOFNL(this ILGenerator MELBLMPENNB, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x515D000", Offset = "0x515BE00", VA = "0x18515D000")]
	public static void NBLBNIKJOOA(this ILGenerator MELBLMPENNB, MethodInfo FNCJNLKEPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x515D100", Offset = "0x515BF00", VA = "0x18515D100")]
	public static void PDJKCLNFHPP(this ILGenerator MELBLMPENNB, FieldInfo KMGHMIBILGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x515BEE0", Offset = "0x515ACE0", VA = "0x18515BEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public KFNGDDBHDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BF50", Offset = "0x4F0AD50", VA = "0x184F0BF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OPPFMAGEFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ABAECAAJAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4F16540", Offset = "0x4F15340", VA = "0x184F16540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FKBGOIOAGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7426F0", Offset = "0x7414F0", VA = "0x1807426F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84CB30", VA = "0x18084DD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AFDBPFCGPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x742700", Offset = "0x741500", VA = "0x180742700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x11CF880", Offset = "0x11CE680", VA = "0x1811CF880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo LPGKLPONEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo NPELOLJCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo GFJAMJDBOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x652C90", Offset = "0x651A90", VA = "0x180652C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4F167C0", Offset = "0x4F155C0", VA = "0x184F167C0")]
	protected PGBPOAOHMEE(Type BIEGICDMJCM, string NLCIGFDKGEE, string OEFLJIGICBN, bool MMLNHIIHOCM, bool MKIMJIGKCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4F16840", Offset = "0x4F15640", VA = "0x184F16840")]
	public PGBPOAOHMEE(FieldInfo DHBOJIINPOH, string NLCIGFDKGEE, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4F16610", Offset = "0x4F15410", VA = "0x184F16610")]
	public PGBPOAOHMEE(PropertyInfo DHBOJIINPOH, string NLCIGFDKGEE, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4F16310", Offset = "0x4F15110", VA = "0x184F16310")]
	private static MethodInfo DJMCNMAPCPA(MemberInfo DHBOJIINPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF9D0", Offset = "0x2DAE7D0", VA = "0x182DAF9D0")]
	public T GBPGJOFKFHE<T>(bool CFCGGLFINKD) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4F16480", Offset = "0x4F15280", VA = "0x184F16480", Slot = "4")]
	public virtual void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4F16550", Offset = "0x4F15350", VA = "0x184F16550", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5156C70", Offset = "0x5155A70", VA = "0x185156C70")]
	public EHGLNLGAPKL(string NLCIGFDKGEE, string FFMFEIJPNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5156B70", Offset = "0x5155970", VA = "0x185156B70", Slot = "4")]
	public override void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5156C30", Offset = "0x5155A30", VA = "0x185156C30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5154DA0", Offset = "0x5153BA0", VA = "0x185154DA0")]
	public DLFCMKPFNBB(string NLCIGFDKGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5154550", Offset = "0x5153350", VA = "0x185154550", Slot = "4")]
	public override void JAMOOAJEJPH(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5154620", Offset = "0x5153420", VA = "0x185154620", Slot = "5")]
	public override void KGLKKNLMJEK(ILGenerator MELBLMPENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5154660", Offset = "0x5153460", VA = "0x185154660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NLJPCHJAMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x726EF0", Offset = "0x725CF0", VA = "0x180726EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x786A00", Offset = "0x785800", VA = "0x180786A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool APGEBDOEDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E90F0", Offset = "0x7E7EF0", VA = "0x1807E90F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E9100", Offset = "0x7E7F00", VA = "0x1807E9100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo EGIIEMHKNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public PGBPOAOHMEE[] OBKIAAGHOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PGBPOAOHMEE[] MLJLECLCPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C19B0", Offset = "0x6C07B0", VA = "0x1806C19B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x514AC30", Offset = "0x5149A30", VA = "0x18514AC30")]
	public ANHAKGCJAHL(Type BIEGICDMJCM, Func<string, string> JIFKAGHKCDP, bool JLPMIGAFJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x514AB40", Offset = "0x5149940", VA = "0x18514AB40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2521280", Offset = "0x2520080", VA = "0x182521280")]
	public HDPPPAGPOAN(ulong CIGHMLHPNEM, int OBIAJGIJCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x46D4870", Offset = "0x46D3670", VA = "0x1846D4870")]
	public void LKKCEELIFBM(ref HDPPPAGPOAN MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x46D4860", Offset = "0x46D3660", VA = "0x1846D4860")]
	public static HDPPPAGPOAN JMBCMGEKCAM(ref HDPPPAGPOAN LEOEMBMBFBC, ref HDPPPAGPOAN GHDGKPNPOBN)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x46D46A0", Offset = "0x46D34A0", VA = "0x1846D46A0")]
	public void DPAGLMCLGFK(ref HDPPPAGPOAN MCLIMJFDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x46D47C0", Offset = "0x46D35C0", VA = "0x1846D47C0")]
	public static HDPPPAGPOAN HHAGGJNGCLD(ref HDPPPAGPOAN LEOEMBMBFBC, ref HDPPPAGPOAN GHDGKPNPOBN)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x46D4730", Offset = "0x46D3530", VA = "0x1846D4730")]
	public void GAFHGDAPAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x46D4770", Offset = "0x46D3570", VA = "0x1846D4770")]
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
	[Cpp2IlInjected.Address(RVA = "0x931A50", Offset = "0x930850", VA = "0x180931A50")]
	public DDFDOIEOJFN(byte[] NFMJIELOGNG, int DKGAADMNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5154240", Offset = "0x5153040", VA = "0x185154240")]
	public void OEFGJPAFBJA(byte IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x51541A0", Offset = "0x5152FA0", VA = "0x1851541A0")]
	public void OADGLMLJILG(byte[] IBEOABCOFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x51542A0", Offset = "0x51530A0", VA = "0x1851542A0")]
	public void OKAPFIKHMGE(byte[] IBEOABCOFOH, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5154340", Offset = "0x5153140", VA = "0x185154340")]
	public void OKAPFIKHMGE(byte[] IBEOABCOFOH, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5154120", Offset = "0x5152F20", VA = "0x185154120")]
	public void NMOCDNGDHHC(byte EKIHFBHEKEC, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5154020", Offset = "0x5152E20", VA = "0x185154020")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F120A0", Offset = "0x4F10EA0", VA = "0x184F120A0")]
	private static byte[] FMICAEMHFFB(int LBLAPKMJFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F12AF0", Offset = "0x4F118F0", VA = "0x184F12AF0")]
	private static byte[] MFJDOIHLMBL(int LBLAPKMJFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F117C0", Offset = "0x4F105C0", VA = "0x184F117C0")]
	public static int ADBOFBMDIGH(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, float GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F118E0", Offset = "0x4F106E0", VA = "0x184F118E0")]
	public static int ADBOFBMDIGH(ref byte[] NFMJIELOGNG, int HPNBOGMLOLG, double GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F11CA0", Offset = "0x4F10AA0", VA = "0x184F11CA0")]
	private static bool EEGNKKDGANB(byte[] NFMJIELOGNG, int PMIIGNOLFGJ, ulong HCINGBLCLMG, ulong BKHJFEJBBAJ, ulong KNMPCIFBGHP, ulong FOJOBKNJBNI, ulong MIJKDEGILOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F12BD0", Offset = "0x4F119D0", VA = "0x184F12BD0")]
	private static void MLBBBLHBGLC(uint AEGJCHOCHON, int CCGCEKIACPE, out uint EAMONKPFMKB, out int JAPDDGECJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F12180", Offset = "0x4F10F80", VA = "0x184F12180")]
	private static bool IBMCHPDKABD(HDPPPAGPOAN CCKAGBPNPHP, HDPPPAGPOAN AEPJHDKHAPL, HDPPPAGPOAN POJEPHCOPHL, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int NBOPCLGJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F11A00", Offset = "0x4F10800", VA = "0x184F11A00")]
	private static bool AKAILJAPAHO(double MINMGIMIPFB, FIBBNIKEKFG GGBPGDBFPKJ, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int EJKCOIKAGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F126A0", Offset = "0x4F114A0", VA = "0x184F126A0")]
	private static bool JEPPDKIOPPE(double MINMGIMIPFB, FIBBNIKEKFG GGBPGDBFPKJ, byte[] NFMJIELOGNG, out int PMIIGNOLFGJ, out int MLFIMNODEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F12960", Offset = "0x4F11760", VA = "0x184F12960")]
	private static bool LOKDAEGLCHE(double GKFICKKHACC, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F12CF0", Offset = "0x4F11AF0", VA = "0x184F12CF0")]
	private static bool NCIKKBIMJMP(double GKFICKKHACC, ref DDFDOIEOJFN HLCBDOBJLEA, GLMAMNLHEDH GGBPGDBFPKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F13350", Offset = "0x4F12150", VA = "0x184F13350")]
	private static void PAHDLPKJFFB(byte[] MFJBIPKGIMM, int PMIIGNOLFGJ, int MLFIMNODEGM, int GFOODILKNMI, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F11DA0", Offset = "0x4F10BA0", VA = "0x184F11DA0")]
	private static void FMHHMDANCJM(byte[] MFJBIPKGIMM, int PMIIGNOLFGJ, int OBIAJGIJCCM, ref DDFDOIEOJFN HLCBDOBJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F127B0", Offset = "0x4F115B0", VA = "0x184F127B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1365750", Offset = "0x1364550", VA = "0x181365750")]
	public NPGDCGJINPK(double EIEOEGFMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x46EC220", Offset = "0x46EB020", VA = "0x1846EC220")]
	public NPGDCGJINPK(HDPPPAGPOAN EIEOEGFMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x46EC020", Offset = "0x46EAE20", VA = "0x1846EC020")]
	public HDPPPAGPOAN OPPMPNMHHGP()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x46EBC50", Offset = "0x46EAA50", VA = "0x1846EBC50")]
	public HDPPPAGPOAN AEHNMHAPBLN()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6506E0", Offset = "0x64F4E0", VA = "0x1806506E0")]
	public ulong PBJPLBKCOIP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x46EBEA0", Offset = "0x46EACA0", VA = "0x1846EBEA0")]
	public double GGICKHOGJLP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x46EBD80", Offset = "0x46EAB80", VA = "0x1846EBD80")]
	public double CEDPJDNJFNL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x46EBF60", Offset = "0x46EAD60", VA = "0x1846EBF60")]
	public int HNEMJIFAEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x46EBFD0", Offset = "0x46EADD0", VA = "0x1846EBFD0")]
	public ulong NHIFOPMLBBI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x46EBFB0", Offset = "0x46EADB0", VA = "0x1846EBFB0")]
	public bool MLLJKNOGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x46EBF40", Offset = "0x46EAD40", VA = "0x1846EBF40")]
	public bool GOOPKBDOMPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x46EC0A0", Offset = "0x46EAEA0", VA = "0x1846EC0A0")]
	public bool PGCBBBOMFMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x46EBE20", Offset = "0x46EAC20", VA = "0x1846EBE20")]
	public bool DMBPNMFJBNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x46EC000", Offset = "0x46EAE00", VA = "0x1846EC000")]
	public int OLMNPEBDPEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x46EC0D0", Offset = "0x46EAED0", VA = "0x1846EC0D0")]
	public void PPMBGOLLFMK(out HDPPPAGPOAN NKLLPKACEDN, out HDPPPAGPOAN NJOPGKCDOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x46EBE50", Offset = "0x46EAC50", VA = "0x1846EBE50")]
	public bool GBCCIFBKPKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x46EBF30", Offset = "0x46EAD30", VA = "0x1846EBF30")]
	public double GKFICKKHACC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x46EBF90", Offset = "0x46EAD90", VA = "0x1846EBF90")]
	public static int JPDOLDFAPLN(int FMHBLLJICEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x46EBE10", Offset = "0x46EAC10", VA = "0x1846EBE10")]
	public static double CLEEEKJAEIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x46EBCE0", Offset = "0x46EAAE0", VA = "0x1846EBCE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D210", Offset = "0x66C010", VA = "0x18066D210")]
	public ELEFMLDFMOJ(float ACKCJINFPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5157790", Offset = "0x5156590", VA = "0x185157790")]
	public HDPPPAGPOAN OPPMPNMHHGP()
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0")]
	public uint OEOKALDCDDE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5157740", Offset = "0x5156540", VA = "0x185157740")]
	public int HNEMJIFAEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5157770", Offset = "0x5156570", VA = "0x185157770")]
	public uint NHIFOPMLBBI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5157760", Offset = "0x5156560", VA = "0x185157760")]
	public bool MLLJKNOGPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5157800", Offset = "0x5156600", VA = "0x185157800")]
	public void PPMBGOLLFMK(out HDPPPAGPOAN NKLLPKACEDN, out HDPPPAGPOAN NJOPGKCDOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5157700", Offset = "0x5156500", VA = "0x185157700")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F10370", Offset = "0x4F0F170", VA = "0x184F10370")]
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
	[Cpp2IlInjected.Address(RVA = "0x514EF50", Offset = "0x514DD50", VA = "0x18514EF50")]
	public static void DNHAGNBBNPH(int CCDDEDHJDAA, int PBHGLBGJLGO, out HDPPPAGPOAN EAMONKPFMKB, out int EJKCOIKAGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x514F090", Offset = "0x514DE90", VA = "0x18514F090")]
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
		[Cpp2IlInjected.Address(RVA = "0x46E8C40", Offset = "0x46E7A40", VA = "0x1846E8C40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x900840", Offset = "0x8FF640", VA = "0x180900840")]
	public MNEGMGECNBK(byte[] EHAMCGPFFID, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6945B0", Offset = "0x6933B0", VA = "0x1806945B0")]
	public int PMIIGNOLFGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x46E8BE0", Offset = "0x46E79E0", VA = "0x1846E8BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514D0B0", Offset = "0x514BEB0", VA = "0x18514D0B0")]
	private static byte[] FKHMACMBIPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x514C700", Offset = "0x514B500", VA = "0x18514C700")]
	private static MNEGMGECNBK BCHFIFOAIBL(MNEGMGECNBK NFMJIELOGNG)
	{
		return default(MNEGMGECNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x514D4C0", Offset = "0x514C2C0", VA = "0x18514D4C0")]
	private static MNEGMGECNBK KKHHGFHHLII(MNEGMGECNBK NFMJIELOGNG)
	{
		return default(MNEGMGECNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x514CFF0", Offset = "0x514BDF0", VA = "0x18514CFF0")]
	private static void FFOJMDLKNEF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, byte[] OOOGLFCLBNA, out int GIPCJMDMLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x514D600", Offset = "0x514C400", VA = "0x18514D600")]
	private static void MAJHNPEHBID(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, byte[] LKCNBGKBDIA, int PEJPJHIEDLM, out MNEGMGECNBK MHAMFBJFPDE, out int PKJPGFCHEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x514D570", Offset = "0x514C370", VA = "0x18514D570")]
	private static ulong KOEFHJEOGIJ(MNEGMGECNBK NFMJIELOGNG, out int DEOIJPIBBBF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x514C5B0", Offset = "0x514B3B0", VA = "0x18514C5B0")]
	private static void AHIDCFFKLJB(MNEGMGECNBK NFMJIELOGNG, out HDPPPAGPOAN BMBFIGGJLDD, out int CCDJDGCIHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x514D8A0", Offset = "0x514C6A0", VA = "0x18514D8A0")]
	private static bool OMFNPPNBDCN(MNEGMGECNBK MHAMFBJFPDE, int OBIAJGIJCCM, out double BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x514C7B0", Offset = "0x514B5B0", VA = "0x18514C7B0")]
	private static HDPPPAGPOAN DIIHKLMMFOI(int OBIAJGIJCCM)
	{
		return default(HDPPPAGPOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x514C960", Offset = "0x514B760", VA = "0x18514C960")]
	private static bool EELPCGOOFGF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM, out double BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x514D380", Offset = "0x514C180", VA = "0x18514D380")]
	private static bool JGEIHNJOKFM(MNEGMGECNBK MHAMFBJFPDE, int OBIAJGIJCCM, out double IKDDGAKHENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x514CED0", Offset = "0x514BCD0", VA = "0x18514CED0")]
	public static double? EILPIJLGMAF(MNEGMGECNBK NFMJIELOGNG, int OBIAJGIJCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x514D1A0", Offset = "0x514BFA0", VA = "0x18514D1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x46D5110", Offset = "0x46D3F10", VA = "0x1846D5110")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x931A50", Offset = "0x930850", VA = "0x180931A50")]
	public HMMCPBGOLOB(byte[] NFMJIELOGNG, int HPNBOGMLOLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x46D4F80", Offset = "0x46D3D80", VA = "0x1846D4F80")]
	public static HMMCPBGOLOB DIEKDAOPMKP(HMMCPBGOLOB DLIFLKHFBMM)
	{
		return default(HMMCPBGOLOB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x46D51C0", Offset = "0x46D3FC0", VA = "0x1846D51C0")]
	public static HMMCPBGOLOB PFCLMAKECFN(HMMCPBGOLOB DLIFLKHFBMM, int PMIIGNOLFGJ)
	{
		return default(HMMCPBGOLOB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x46D50A0", Offset = "0x46D3EA0", VA = "0x1846D50A0")]
	public static int KJPIPKKGFFF(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x46D4FE0", Offset = "0x46D3DE0", VA = "0x1846D4FE0")]
	public static bool IKJLJMIELNH(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x46D51A0", Offset = "0x46D3FA0", VA = "0x1846D51A0")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, HMMCPBGOLOB GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x46D4F90", Offset = "0x46D3D90", VA = "0x1846D4F90")]
	public static bool IKJLJMIELNH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x46D5150", Offset = "0x46D3F50", VA = "0x1846D5150")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x46D5150", Offset = "0x46D3F50", VA = "0x1846D5150")]
	public static bool NKIHKFGIBBG(HMMCPBGOLOB MGIINGKDNDK, byte GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x46D4F30", Offset = "0x46D3D30", VA = "0x1846D4F30")]
	public static bool ABIJJBCCMCH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x46D5000", Offset = "0x46D3E00", VA = "0x1846D5000")]
	public static bool JPGBLBGGKGH(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x46D50C0", Offset = "0x46D3EC0", VA = "0x1846D50C0")]
	public static bool LPHAHCNFNBE(HMMCPBGOLOB MGIINGKDNDK, char GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x46D5050", Offset = "0x46D3E50", VA = "0x1846D5050")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E57E0", Offset = "0x46E45E0", VA = "0x1846E57E0")]
	private static byte[] FDFMHAOFGLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x46E58D0", Offset = "0x46E46D0", VA = "0x1846E58D0")]
	private static byte[] GBKHNKGCCMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x46E6CF0", Offset = "0x46E5AF0", VA = "0x1846E6CF0")]
	public static double OKPMGHCHGCC(byte[] NFMJIELOGNG, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x46E56C0", Offset = "0x46E44C0", VA = "0x1846E56C0")]
	public static float CLBBBKDNDGC(byte[] NFMJIELOGNG, int HPNBOGMLOLG, out int PEGEKKHCPCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x46E59C0", Offset = "0x46E47C0", VA = "0x1846E59C0")]
	private static bool HFDKOBEMKBD(int IODEOJKDCNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x46E55A0", Offset = "0x46E43A0", VA = "0x1846E55A0")]
	private static bool BMHKKDIAIOB(ref HMMCPBGOLOB LBIAANDOGFM, HMMCPBGOLOB OCMAALMMILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x46E5B60", Offset = "0x46E4960", VA = "0x1846E5B60")]
	private static bool HKJEHHKCMHN(ref HMMCPBGOLOB LBIAANDOGFM, HMMCPBGOLOB OCMAALMMILB, byte[] ACCKOIDDKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x46E5780", Offset = "0x46E4580", VA = "0x1846E5780")]
	private static bool EJGJPNMOJNP(ref HMMCPBGOLOB CFABDILLBHK, byte[] IBEOABCOFOH, int HPNBOGMLOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x46E5B40", Offset = "0x46E4940", VA = "0x1846E5B40")]
	private static double HFIDKEONNBG(bool MBMLLHNGIJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x46E5C80", Offset = "0x46E4A80", VA = "0x1846E5C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B18D00", Offset = "0x2B17B00", VA = "0x182B18D00")]
	public JDMMKILJOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x24E8DB0", Offset = "0x24E7BB0", VA = "0x1824E8DB0")]
	public JDMMKILJOPO(CIIAACDLPMF HLNKAKEJJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3116330", Offset = "0x3115130", VA = "0x183116330", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3116DD0", Offset = "0x3115BD0", VA = "0x183116DD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B18D00", Offset = "0x2B17B00", VA = "0x182B18D00")]
	public BPEFBMNIBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x24E8DB0", Offset = "0x24E7BB0", VA = "0x1824E8DB0")]
	public BPEFBMNIBND(CIIAACDLPMF HLNKAKEJJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2B170D0", Offset = "0x2B15ED0", VA = "0x182B170D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, List<T> GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2B181F0", Offset = "0x2B16FF0", VA = "0x182B181F0", Slot = "5")]
	public List<T> MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EHHAFBIFONP<TElement, TIntermediate, TEnumerator, TCollection> : global::LKBCOOCHDMC<TCollection>, DIAHDCBEFFK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3319170", Offset = "0x3317F70", VA = "0x183319170", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TCollection GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3319AE0", Offset = "0x33188E0", VA = "0x183319AE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected EHHAFBIFONP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class OCMDAGJGCGH<TElement, TIntermediate, TCollection> : global::EHHAFBIFONP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2D09A00", Offset = "0x2D08800", VA = "0x182D09A00", Slot = "6")]
	protected override IEnumerator<TElement> FBNBLHOIDFC(TCollection GPNGGDGNOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1F3AB40", Offset = "0x1F39940", VA = "0x181F3AB40")]
	protected OCMDAGJGCGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class PIDEOKIODBD<TElement, TCollection> : global::OCMDAGJGCGH<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected sealed override TCollection DNAKJMIBDKI(ref TCollection COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class GCJMOAENCJA<TElement, TCollection> : global::PIDEOKIODBD<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x31AE520", Offset = "0x31AD320", VA = "0x1831AE520", Slot = "7")]
	protected override TCollection GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x31AE4B0", Offset = "0x31AD2B0", VA = "0x1831AE4B0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref TCollection BDLMAMHCIKB, int BNNEENLPEFO, TElement GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class HLAMPDEKNFM<T> : global::EHHAFBIFONP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2877ED0", Offset = "0x2876CD0", VA = "0x182877ED0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref LinkedList<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override LinkedList<T> DNAKJMIBDKI(ref LinkedList<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override LinkedList<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x3344CE0", Offset = "0x3343AE0", VA = "0x183344CE0", Slot = "6")]
	protected override LinkedList<T>.Enumerator FBNBLHOIDFC(LinkedList<T> GPNGGDGNOJH)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class BLLPJDJGIIN<T> : global::EHHAFBIFONP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2877ED0", Offset = "0x2876CD0", VA = "0x182877ED0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Queue<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override Queue<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2596F80", Offset = "0x2595D80", VA = "0x182596F80", Slot = "6")]
	protected override Queue<T>.Enumerator FBNBLHOIDFC(Queue<T> GPNGGDGNOJH)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override Queue<T> DNAKJMIBDKI(ref Queue<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IKMONGHCFLA<T> : global::EHHAFBIFONP<T, global::NKNHJAPLKAK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2596F50", Offset = "0x2595D50", VA = "0x182596F50", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2596FD0", Offset = "0x2595DD0", VA = "0x182596FD0", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2596F80", Offset = "0x2595D80", VA = "0x182596F80", Slot = "6")]
	protected override Stack<T>.Enumerator FBNBLHOIDFC(Stack<T> GPNGGDGNOJH)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2596E70", Offset = "0x2595C70", VA = "0x182596E70", Slot = "9")]
	protected override Stack<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class FCDNELIFOMD<T> : global::EHHAFBIFONP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2877ED0", Offset = "0x2876CD0", VA = "0x182877ED0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref HashSet<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override HashSet<T> DNAKJMIBDKI(ref HashSet<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override HashSet<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2596F80", Offset = "0x2595D80", VA = "0x182596F80", Slot = "6")]
	protected override HashSet<T>.Enumerator FBNBLHOIDFC(HashSet<T> GPNGGDGNOJH)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class NBANMFDDADH<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2596F50", Offset = "0x2595D50", VA = "0x182596F50", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDED0", Offset = "0x2AECCD0", VA = "0x182AEDED0", Slot = "9")]
	protected override ReadOnlyCollection<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDF60", Offset = "0x2AECD60", VA = "0x182AEDF60", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MDIOCIIBFEJ<T> : global::OCMDAGJGCGH<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2877ED0", Offset = "0x2876CD0", VA = "0x182877ED0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref List<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override List<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override IList<T> DNAKJMIBDKI(ref List<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class BIGONKJDOJL<T> : global::OCMDAGJGCGH<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2877ED0", Offset = "0x2876CD0", VA = "0x182877ED0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref List<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override List<T> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override ICollection<T> DNAKJMIBDKI(ref List<T> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JJGBPFHDOMD<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2596F50", Offset = "0x2595D50", VA = "0x182596F50", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2596FD0", Offset = "0x2595DD0", VA = "0x182596FD0", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3F46230", Offset = "0x3F45030", VA = "0x183F46230", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x28A54C0", Offset = "0x28A42C0", VA = "0x1828A54C0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x28A5780", Offset = "0x28A4580", VA = "0x1828A5780", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x51564B0", Offset = "0x51552B0", VA = "0x1851564B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IEnumerable GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5156720", Offset = "0x5155520", VA = "0x185156720", Slot = "5")]
	public IEnumerable MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5160670", Offset = "0x515F470", VA = "0x185160670", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ICollection GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x51609F0", Offset = "0x515F7F0", VA = "0x1851609F0", Slot = "5")]
	public ICollection MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5156D30", Offset = "0x5155B30", VA = "0x185156D30", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IList GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x51570A0", Offset = "0x5155EA0", VA = "0x1851570A0", Slot = "5")]
	public IList MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public EHIKLFILEGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class JLNMCCCBPOJ<T> : global::OCMDAGJGCGH<T, global::NKNHJAPLKAK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3F578D0", Offset = "0x3F566D0", VA = "0x183F578D0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref global::NKNHJAPLKAK<T> BDLMAMHCIKB, int BNNEENLPEFO, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2596FD0", Offset = "0x2595DD0", VA = "0x182596FD0", Slot = "7")]
	protected override global::NKNHJAPLKAK<T> GLBIKEOEKPG()
	{
		return default(global::NKNHJAPLKAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3F57890", Offset = "0x3F56690", VA = "0x183F57890", Slot = "9")]
	protected override IReadOnlyList<T> DNAKJMIBDKI(ref global::NKNHJAPLKAK<T> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x28BCCA0", Offset = "0x28BBAA0", VA = "0x1828BCCA0")]
	public JLNMCCCBPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JFLGIIGIKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x46D96E0", Offset = "0x46D84E0", VA = "0x1846D96E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F138C0", Offset = "0x4F126C0", VA = "0x184F138C0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, DateTime GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F13D20", Offset = "0x4F12B20", VA = "0x184F13D20", Slot = "5")]
	public DateTime MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D6B10", Offset = "0x46D5910", VA = "0x1846D6B10", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, DateTimeOffset GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x46D6EF0", Offset = "0x46D5CF0", VA = "0x1846D6EF0", Slot = "5")]
	public DateTimeOffset MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5152460", Offset = "0x5151260", VA = "0x185152460", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TimeSpan GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5152910", Offset = "0x5151710", VA = "0x185152910", Slot = "5")]
	public TimeSpan MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CKBDOOEJHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AMCGIPIJFBN<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::LKBCOOCHDMC<TDictionary>, DIAHDCBEFFK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3FEE230", Offset = "0x3FED030", VA = "0x183FEE230", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, TDictionary GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEFE0", Offset = "0x3FEDDE0", VA = "0x183FEEFE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected AMCGIPIJFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class BGAPMLJJMBL<TKey, TValue, TIntermediate, TDictionary> : global::AMCGIPIJFBN<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2D09A00", Offset = "0x2D08800", VA = "0x182D09A00", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> FBNBLHOIDFC(TDictionary GPNGGDGNOJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class OAJLOEOMPHC<TKey, TValue, TDictionary> : global::BGAPMLJJMBL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override TDictionary DNAKJMIBDKI(ref TDictionary COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LPIBCIKPNGO<TKey, TValue> : global::AMCGIPIJFBN<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3A904A0", Offset = "0x3A8F2A0", VA = "0x183A904A0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Dictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override Dictionary<TKey, TValue> DNAKJMIBDKI(ref Dictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override Dictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3A904E0", Offset = "0x3A8F2E0", VA = "0x183A904E0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator FBNBLHOIDFC(Dictionary<TKey, TValue> GPNGGDGNOJH)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x23EE090", Offset = "0x23ECE90", VA = "0x1823EE090")]
	public LPIBCIKPNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class BMFMIDMHFJH<TKey, TValue, TDictionary> : global::OAJLOEOMPHC<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2D21EF0", Offset = "0x2D20CF0", VA = "0x182D21EF0", Slot = "8")]
	protected override void ELGBPIMHCCH(ref TDictionary BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x24EC470", Offset = "0x24EB270", VA = "0x1824EC470", Slot = "7")]
	protected override TDictionary GLBIKEOEKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class OBBFPEFHFML<TKey, TValue> : global::BGAPMLJJMBL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC840", Offset = "0x2BCB640", VA = "0x182BCC840", Slot = "8")]
	protected override void ELGBPIMHCCH(ref Dictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override Dictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override IDictionary<TKey, TValue> DNAKJMIBDKI(ref Dictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NEBLCDPLEGO<TKey, TValue> : global::OAJLOEOMPHC<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC840", Offset = "0x2BCB640", VA = "0x182BCC840", Slot = "8")]
	protected override void ELGBPIMHCCH(ref SortedList<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override SortedList<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class BCANJNPJIHF<TKey, TValue> : global::AMCGIPIJFBN<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC840", Offset = "0x2BCB640", VA = "0x182BCC840", Slot = "8")]
	protected override void ELGBPIMHCCH(ref SortedDictionary<TKey, TValue> BDLMAMHCIKB, int BNNEENLPEFO, TKey BIMCDHOFDCP, TValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1617C10", Offset = "0x1616A10", VA = "0x181617C10", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DNAKJMIBDKI(ref SortedDictionary<TKey, TValue> COGPBFFGMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2877F10", Offset = "0x2876D10", VA = "0x182877F10", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GLBIKEOEKPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3D818E0", Offset = "0x3D806E0", VA = "0x183D818E0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator FBNBLHOIDFC(SortedDictionary<TKey, TValue> GPNGGDGNOJH)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NMPJHANDMMD<T> : global::LKBCOOCHDMC<T>, DIAHDCBEFFK where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9F50", Offset = "0x2BE8D50", VA = "0x182BE9F50", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA300", Offset = "0x2BE9100", VA = "0x182BEA300", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E8220", Offset = "0x46E7020", VA = "0x1846E8220", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, IDictionary GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x46E85D0", Offset = "0x46E73D0", VA = "0x1846E85D0", Slot = "5")]
	public IDictionary MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D9430", Offset = "0x46D8230", VA = "0x1846D9430")]
	public JBJNINJHBCC(params ECLEPONANIG[] IFDALBMHBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x46D8860", Offset = "0x46D7660", VA = "0x1846D8860", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x46D9390", Offset = "0x46D8190", VA = "0x1846D9390", Slot = "5")]
	public object MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EMCDBMIABOM
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5158280", Offset = "0x5157080", VA = "0x185158280")]
	public static object JOCLFLICFCF(Type BIEGICDMJCM, out bool FKANOPEICHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5157960", Offset = "0x5156760", VA = "0x185157960")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public AHCJGGBLNEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD7D0", Offset = "0x3FDC5D0", VA = "0x183FDD7D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public LHFAEKDCNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB95B0", Offset = "0x2BB83B0", VA = "0x182BB95B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public HODJOJIDFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3353E20", Offset = "0x3352C20", VA = "0x183353E20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F606F0", Offset = "0x3F5F4F0", VA = "0x183F606F0")]
	static JMNKKIMDDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F64490", Offset = "0x3F63290", VA = "0x183F64490")]
	public JMNKKIMDDOI(bool LDCJGIMKIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F59330", Offset = "0x3F58130", VA = "0x183F59330", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A1E0", Offset = "0x3F58FE0", VA = "0x183F5A1E0", Slot = "5")]
	public T MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F58110", Offset = "0x3F56F10", VA = "0x183F58110", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, T GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F58590", Offset = "0x3F57390", VA = "0x183F58590", Slot = "7")]
	public T CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class ECEOGPMKGFN<T> : global::LKBCOOCHDMC<T[,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3304C80", Offset = "0x3303A80", VA = "0x183304C80", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3304E30", Offset = "0x3303C30", VA = "0x183304E30", Slot = "5")]
	public T[,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	public ECEOGPMKGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DFNBCHAIBBC<T> : global::LKBCOOCHDMC<T[,,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3159160", Offset = "0x3157F60", VA = "0x183159160", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3159370", Offset = "0x3158170", VA = "0x183159370", Slot = "5")]
	public T[,,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	public DFNBCHAIBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class BNONLHEAPPB<T> : global::LKBCOOCHDMC<T[,,,]>, DIAHDCBEFFK
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B136E0", Offset = "0x2B124E0", VA = "0x182B136E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T[,,,] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B13980", Offset = "0x2B12780", VA = "0x182B13980", Slot = "5")]
	public T[,,,] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	public BNONLHEAPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class FEDKDKMGEIJ<T> : global::LKBCOOCHDMC<T?>, DIAHDCBEFFK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x287DE00", Offset = "0x287CC00", VA = "0x18287DE00", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x287E090", Offset = "0x287CE90", VA = "0x18287E090", Slot = "5")]
	public T? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F37750", Offset = "0x1F36550", VA = "0x181F37750")]
	public OMFEEPGGBKC(global::LKBCOOCHDMC<T> GELGCEMOAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3837150", Offset = "0x3835F50", VA = "0x183837150")]
	public OMFEEPGGBKC(Type MMKEBLBLBOD, object[] JEGOIMOINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3836000", Offset = "0x3834E00", VA = "0x183836000", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, T? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3836950", Offset = "0x3835750", VA = "0x183836950", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5157610", Offset = "0x5156410", VA = "0x185157610", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5157650", Offset = "0x5156450", VA = "0x185157650", Slot = "5")]
	public sbyte MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x51574A0", Offset = "0x51562A0", VA = "0x1851574A0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, sbyte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5157560", Offset = "0x5156360", VA = "0x185157560", Slot = "7")]
	public sbyte CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D4DE0", Offset = "0x46D3BE0", VA = "0x1846D4DE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x46D4E60", Offset = "0x46D3C60", VA = "0x1846D4E60", Slot = "5")]
	public sbyte? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x46D4CA0", Offset = "0x46D3AA0", VA = "0x1846D4CA0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, sbyte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x46D4D20", Offset = "0x46D3B20", VA = "0x1846D4D20", Slot = "7")]
	public sbyte? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F15480", Offset = "0x4F14280", VA = "0x184F15480", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, sbyte[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F15540", Offset = "0x4F14340", VA = "0x184F15540", Slot = "5")]
	public sbyte[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D9C50", Offset = "0x46D8A50", VA = "0x1846D9C50", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x46D9C70", Offset = "0x46D8A70", VA = "0x1846D9C70", Slot = "5")]
	public short MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x46D9B90", Offset = "0x46D8990", VA = "0x1846D9B90", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, short GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x46D9BD0", Offset = "0x46D89D0", VA = "0x1846D9BD0", Slot = "7")]
	public short CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E90B0", Offset = "0x46E7EB0", VA = "0x1846E90B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x46E9130", Offset = "0x46E7F30", VA = "0x1846E9130", Slot = "5")]
	public short? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x46E8F70", Offset = "0x46E7D70", VA = "0x1846E8F70", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, short? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x46E8FF0", Offset = "0x46E7DF0", VA = "0x1846E8FF0", Slot = "7")]
	public short? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514E430", Offset = "0x514D230", VA = "0x18514E430", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, short[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x514E5D0", Offset = "0x514D3D0", VA = "0x18514E5D0", Slot = "5")]
	public short[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E3CD0", Offset = "0x46E2AD0", VA = "0x1846E3CD0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x46E3CE0", Offset = "0x46E2AE0", VA = "0x1846E3CE0", Slot = "5")]
	public int MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x46E3C10", Offset = "0x46E2A10", VA = "0x1846E3C10", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, int GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x46E3C50", Offset = "0x46E2A50", VA = "0x1846E3C50", Slot = "7")]
	public int CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E40F0", Offset = "0x46E2EF0", VA = "0x1846E40F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x46E4160", Offset = "0x46E2F60", VA = "0x1846E4160", Slot = "5")]
	public int? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x46E3FB0", Offset = "0x46E2DB0", VA = "0x1846E3FB0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, int? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x46E4030", Offset = "0x46E2E30", VA = "0x1846E4030", Slot = "7")]
	public int? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F109E0", Offset = "0x4F0F7E0", VA = "0x184F109E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, int[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F10AA0", Offset = "0x4F0F8A0", VA = "0x184F10AA0", Slot = "5")]
	public int[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D5550", Offset = "0x46D4350", VA = "0x1846D5550", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x46D5570", Offset = "0x46D4370", VA = "0x1846D5570", Slot = "5")]
	public long MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x46D5490", Offset = "0x46D4290", VA = "0x1846D5490", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, long GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x46D54D0", Offset = "0x46D42D0", VA = "0x1846D54D0", Slot = "7")]
	public long CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5152210", Offset = "0x5151010", VA = "0x185152210", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x51522A0", Offset = "0x51510A0", VA = "0x1851522A0", Slot = "5")]
	public long? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5151FB0", Offset = "0x5150DB0", VA = "0x185151FB0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, long? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x51520C0", Offset = "0x5150EC0", VA = "0x1851520C0", Slot = "7")]
	public long? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D6750", Offset = "0x46D5550", VA = "0x1846D6750", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, long[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x46D6810", Offset = "0x46D5610", VA = "0x1846D6810", Slot = "5")]
	public long[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514DFE0", Offset = "0x514CDE0", VA = "0x18514DFE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x514E020", Offset = "0x514CE20", VA = "0x18514E020", Slot = "5")]
	public byte MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x514DE70", Offset = "0x514CC70", VA = "0x18514DE70", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, byte GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x514DF30", Offset = "0x514CD30", VA = "0x18514DF30", Slot = "7")]
	public byte CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F16A90", Offset = "0x4F15890", VA = "0x184F16A90", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4F16B10", Offset = "0x4F15910", VA = "0x184F16B10", Slot = "5")]
	public byte? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4F16950", Offset = "0x4F15750", VA = "0x184F16950", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, byte? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4F169D0", Offset = "0x4F157D0", VA = "0x184F169D0", Slot = "7")]
	public byte? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5161310", Offset = "0x5160110", VA = "0x185161310", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5161350", Offset = "0x5160150", VA = "0x185161350", Slot = "5")]
	public ushort MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x51611A0", Offset = "0x515FFA0", VA = "0x1851611A0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ushort GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5161260", Offset = "0x5160060", VA = "0x185161260", Slot = "7")]
	public ushort CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46DA5F0", Offset = "0x46D93F0", VA = "0x1846DA5F0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x46DA670", Offset = "0x46D9470", VA = "0x1846DA670", Slot = "5")]
	public ushort? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x46DA4B0", Offset = "0x46D92B0", VA = "0x1846DA4B0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ushort? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x46DA530", Offset = "0x46D9330", VA = "0x1846DA530", Slot = "7")]
	public ushort? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D4A40", Offset = "0x46D3840", VA = "0x1846D4A40", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ushort[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x46D4B00", Offset = "0x46D3900", VA = "0x1846D4B00", Slot = "5")]
	public ushort[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F113B0", Offset = "0x4F101B0", VA = "0x184F113B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F113C0", Offset = "0x4F101C0", VA = "0x184F113C0", Slot = "5")]
	public uint MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4F112F0", Offset = "0x4F100F0", VA = "0x184F112F0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, uint GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4F11330", Offset = "0x4F10130", VA = "0x184F11330", Slot = "7")]
	public uint CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D5350", Offset = "0x46D4150", VA = "0x1846D5350", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x46D53C0", Offset = "0x46D41C0", VA = "0x1846D53C0", Slot = "5")]
	public uint? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x46D5210", Offset = "0x46D4010", VA = "0x1846D5210", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, uint? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x46D5290", Offset = "0x46D4090", VA = "0x1846D5290", Slot = "7")]
	public uint? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5160CE0", Offset = "0x515FAE0", VA = "0x185160CE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, uint[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5160E80", Offset = "0x515FC80", VA = "0x185160E80", Slot = "5")]
	public uint[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5158FA0", Offset = "0x5157DA0", VA = "0x185158FA0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5158FD0", Offset = "0x5157DD0", VA = "0x185158FD0", Slot = "5")]
	public ulong MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5158E60", Offset = "0x5157C60", VA = "0x185158E60", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ulong GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5158F20", Offset = "0x5157D20", VA = "0x185158F20", Slot = "7")]
	public ulong CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5162180", Offset = "0x5160F80", VA = "0x185162180", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5162210", Offset = "0x5161010", VA = "0x185162210", Slot = "5")]
	public ulong? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5161F90", Offset = "0x5160D90", VA = "0x185161F90", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, ulong? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x51620A0", Offset = "0x5160EA0", VA = "0x1851620A0", Slot = "7")]
	public ulong? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E3D50", Offset = "0x46E2B50", VA = "0x1846E3D50", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ulong[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x46E3E10", Offset = "0x46E2C10", VA = "0x1846E3E10", Slot = "5")]
	public ulong[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514EED0", Offset = "0x514DCD0", VA = "0x18514EED0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x514EEE0", Offset = "0x514DCE0", VA = "0x18514EEE0", Slot = "5")]
	public float MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x514ED70", Offset = "0x514DB70", VA = "0x18514ED70", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, float GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x514EE20", Offset = "0x514DC20", VA = "0x18514EE20", Slot = "7")]
	public float CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5160520", Offset = "0x515F320", VA = "0x185160520", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x51605A0", Offset = "0x515F3A0", VA = "0x1851605A0", Slot = "5")]
	public float? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5160330", Offset = "0x515F130", VA = "0x185160330", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, float? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5160430", Offset = "0x515F230", VA = "0x185160430", Slot = "7")]
	public float? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D9780", Offset = "0x46D8580", VA = "0x1846D9780", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, float[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x46D9840", Offset = "0x46D8640", VA = "0x1846D9840", Slot = "5")]
	public float[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D9B10", Offset = "0x46D8910", VA = "0x1846D9B10", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x46D9B20", Offset = "0x46D8920", VA = "0x1846D9B20", Slot = "5")]
	public double MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x46D9A50", Offset = "0x46D8850", VA = "0x1846D9A50", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, double GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x46D9A90", Offset = "0x46D8890", VA = "0x1846D9A90", Slot = "7")]
	public double CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514C440", Offset = "0x514B240", VA = "0x18514C440", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x514C4C0", Offset = "0x514B2C0", VA = "0x18514C4C0", Slot = "5")]
	public double? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x514C220", Offset = "0x514B020", VA = "0x18514C220", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, double? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x514C330", Offset = "0x514B130", VA = "0x18514C330", Slot = "7")]
	public double? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F11560", Offset = "0x4F10360", VA = "0x184F11560", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, double[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4F11620", Offset = "0x4F10420", VA = "0x184F11620", Slot = "5")]
	public double[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F102E0", Offset = "0x4F0F0E0", VA = "0x184F102E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4F10300", Offset = "0x4F0F100", VA = "0x184F10300", Slot = "5")]
	public bool MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4F10220", Offset = "0x4F0F020", VA = "0x184F10220", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, bool GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4F10260", Offset = "0x4F0F060", VA = "0x184F10260", Slot = "7")]
	public bool CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5156360", Offset = "0x5155160", VA = "0x185156360", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x51563E0", Offset = "0x51551E0", VA = "0x1851563E0", Slot = "5")]
	public bool? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x51561A0", Offset = "0x5154FA0", VA = "0x1851561A0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, bool? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x51562A0", Offset = "0x51550A0", VA = "0x1851562A0", Slot = "7")]
	public bool? CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5153350", Offset = "0x5152150", VA = "0x185153350", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, bool[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x51534D0", Offset = "0x51522D0", VA = "0x1851534D0", Slot = "5")]
	public bool[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E7080", Offset = "0x46E5E80", VA = "0x1846E7080", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, object GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x46E7B00", Offset = "0x46E6900", VA = "0x1846E7B00", Slot = "5")]
	public object MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x515D190", Offset = "0x515BF90", VA = "0x18515D190", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, byte[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x515D220", Offset = "0x515C020", VA = "0x18515D220", Slot = "5")]
	public byte[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E52C0", Offset = "0x46E40C0", VA = "0x1846E52C0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, ArraySegment<byte> GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x46E5380", Offset = "0x46E4180", VA = "0x1846E5380", Slot = "5")]
	public ArraySegment<byte> MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F15230", Offset = "0x4F14030", VA = "0x184F15230", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, string GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4F15250", Offset = "0x4F14050", VA = "0x184F15250", Slot = "5")]
	public string MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F15230", Offset = "0x4F14030", VA = "0x184F15230", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, string GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F15250", Offset = "0x4F14050", VA = "0x184F15250", Slot = "7")]
	public string CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E8CE0", Offset = "0x46E7AE0", VA = "0x1846E8CE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, string[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x46E8DA0", Offset = "0x46E7BA0", VA = "0x1846E8DA0", Slot = "5")]
	public string[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5157390", Offset = "0x5156190", VA = "0x185157390", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5157410", Offset = "0x5156210", VA = "0x185157410", Slot = "5")]
	public char MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E4230", Offset = "0x46E3030", VA = "0x1846E4230", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char? GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x46E4320", Offset = "0x46E3120", VA = "0x1846E4320", Slot = "5")]
	public char? MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46E44B0", Offset = "0x46E32B0", VA = "0x1846E44B0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, char[] GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x46E4630", Offset = "0x46E3430", VA = "0x1846E4630", Slot = "5")]
	public char[] MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514EA30", Offset = "0x514D830", VA = "0x18514EA30", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Guid GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x514E9E0", Offset = "0x514D7E0", VA = "0x18514E9E0", Slot = "5")]
	public Guid MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x514E9B0", Offset = "0x514D7B0", VA = "0x18514E9B0", Slot = "6")]
	public void ACHHCBFIBKK(ref DOFDDFPOMMF FHGALIAOBLC, Guid GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x514E9E0", Offset = "0x514D7E0", VA = "0x18514E9E0", Slot = "7")]
	public Guid CJEAJCMAOLM(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB7E180", Offset = "0xB7CF80", VA = "0x180B7E180")]
	public MHOMJEAHMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x840180", Offset = "0x83EF80", VA = "0x180840180")]
	public MHOMJEAHMEC(bool GKLLNABEMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x46E8800", Offset = "0x46E7600", VA = "0x1846E8800", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, decimal GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x46E8950", Offset = "0x46E7750", VA = "0x1846E8950", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D55E0", Offset = "0x46D43E0", VA = "0x1846D55E0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Uri GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x46D5690", Offset = "0x46D4490", VA = "0x1846D5690", Slot = "5")]
	public Uri MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D9CE0", Offset = "0x46D8AE0", VA = "0x1846D9CE0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Version GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x46D9D90", Offset = "0x46D8B90", VA = "0x1846D9D90", Slot = "5")]
	public Version MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F11430", Offset = "0x4F10230", VA = "0x184F11430", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, StringBuilder GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4F11480", Offset = "0x4F10280", VA = "0x184F11480", Slot = "5")]
	public StringBuilder MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46D94D0", Offset = "0x46D82D0", VA = "0x1846D94D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, BitArray GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x46D9560", Offset = "0x46D8360", VA = "0x1846D9560", Slot = "5")]
	public BitArray MNOLKCHHLIP(ref FHNCKNEPFID LDNLHJMBEIM, ECLEPONANIG AMILKFGLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x514A800", Offset = "0x5149600", VA = "0x18514A800")]
	public ADNMFDOFGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x514A7B0", Offset = "0x51495B0", VA = "0x18514A7B0")]
	public ADNMFDOFGCF(bool GGBJKFMPLIP, bool KBGDFCBFEOJ, bool DBLJOGKFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x514A4D0", Offset = "0x51492D0", VA = "0x18514A4D0", Slot = "4")]
	public void CLPGJOCDFOA(ref DOFDDFPOMMF FHGALIAOBLC, Type GKFICKKHACC, ECLEPONANIG AMILKFGLHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x514A5C0", Offset = "0x51493C0", VA = "0x18514A5C0", Slot = "5")]
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
