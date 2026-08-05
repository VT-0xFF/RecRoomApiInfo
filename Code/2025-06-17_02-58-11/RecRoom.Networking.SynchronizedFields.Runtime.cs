using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBICFMGIOFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FMBAPPKDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KOHPIDEALCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GBDECDHLMJN IHIFEBCGELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BNKIPJJMMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FAJFPBEIJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NFNDLFLIHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MKJHJDBHHPK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOIKBKNMOIA();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KIBBAPOFFNC(object BECBHDDLOHA, bool NBCECJLAKKE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODJBJDKJNHM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HCEMOOLHACD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DOIAGBPPAPM<T> : HCEMOOLHACD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T MACGIJPMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJHGGKEOOCO(T OIEALMJHDLB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MKCBGACOLEL<T> : DOIAGBPPAPM<T>, HCEMOOLHACD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NOHHGHEDDJL<T> DFDJLNKHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NOHHGHEDDJL<T> JBDJKIPMEFE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE92430", Offset = "0xE90E30", VA = "0x180E92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KBKNHMHEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5492ED0", Offset = "0x54918D0", VA = "0x185492ED0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T IODCKBAILNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5493280", Offset = "0x5491C80", VA = "0x185493280", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5493A90", Offset = "0x5492490", VA = "0x185493A90", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T MACGIJPMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5493480", Offset = "0x5491E80", VA = "0x185493480", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5493390", Offset = "0x5491D90", VA = "0x185493390", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5493480", Offset = "0x5491E80", VA = "0x185493480")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5493820", Offset = "0x5492220", VA = "0x185493820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F74120", Offset = "0x4F72B20", VA = "0x184F74120", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F74100", Offset = "0x4F72B00", VA = "0x184F74100", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5493370", Offset = "0x5491D70", VA = "0x185493370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x54929A0", Offset = "0x54913A0", VA = "0x1854929A0", Slot = "10")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5494800", Offset = "0x5493200", VA = "0x185494800")]
	public MKCBGACOLEL([In] INDMLKIABEN HPGIDELCODH, T DLCCFGMOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x54936C0", Offset = "0x54920C0", VA = "0x1854936C0")]
	private void NAPDFCNLBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5492CE0", Offset = "0x54916E0", VA = "0x185492CE0", Slot = "5")]
	public void BJHGGKEOOCO(T OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5492C70", Offset = "0x5491670", VA = "0x185492C70")]
	public void BJHGGKEOOCO(T OIEALMJHDLB, bool CPBEKKPEMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F740C0", Offset = "0x4F72AC0", VA = "0x184F740C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class DNLPCBELHIB<T1, T2> : DOIAGBPPAPM<(T1, T2)>, HCEMOOLHACD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PFDBCMIKJIA<T1, T2> DFDJLNKHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PFDBCMIKJIA<T1, T2> JBDJKIPMEFE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xE92430", Offset = "0xE90E30", VA = "0x180E92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KBKNHMHEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B10180", Offset = "0x6B0EB80", VA = "0x186B10180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HNIDCJJKNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B01D90", Offset = "0x6B00790", VA = "0x186B01D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool HHKPAFCKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B10B30", Offset = "0x6B0F530", VA = "0x186B10B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) IODCKBAILNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B103A0", Offset = "0x6B0EDA0", VA = "0x186B103A0", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B12020", Offset = "0x6B10A20", VA = "0x186B12020", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) MACGIJPMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B11890", Offset = "0x6B10290", VA = "0x186B11890", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B10D90", Offset = "0x6B0F790", VA = "0x186B10D90", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B110B0", Offset = "0x6B0FAB0", VA = "0x186B110B0")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B11C40", Offset = "0x6B10640", VA = "0x186B11C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 BENODLJFPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B108A0", Offset = "0x6B0F2A0", VA = "0x186B108A0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6B10340", Offset = "0x6B0ED40", VA = "0x186B10340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 IENPBKGGKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B10C20", Offset = "0x6B0F620", VA = "0x186B10C20")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 GDLBMMNHFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6B10C20", Offset = "0x6B0F620", VA = "0x186B10C20")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B10340", Offset = "0x6B0ED40", VA = "0x186B10340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 IOCFFILBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B108E0", Offset = "0x6B0F2E0", VA = "0x186B108E0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B10830", Offset = "0x6B0F230", VA = "0x186B10830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 EDDMIKHNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B10F40", Offset = "0x6B0F940", VA = "0x186B10F40")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 NHBOFFDMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B10F40", Offset = "0x6B0F940", VA = "0x186B10F40")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B10830", Offset = "0x6B0F230", VA = "0x186B10830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F74120", Offset = "0x4F72B20", VA = "0x184F74120", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F74100", Offset = "0x4F72B00", VA = "0x184F74100", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FF60", Offset = "0x6B0E960", VA = "0x186B0FF60", Slot = "10")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B12100", Offset = "0x6B10B00", VA = "0x186B12100")]
	public DNLPCBELHIB([In] INDMLKIABEN HPGIDELCODH, T1 INJHPAEIAFF, T2 FBAGPBGDDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B11370", Offset = "0x6B0FD70", VA = "0x186B11370")]
	private void NAPDFCNLBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B11550", Offset = "0x6B0FF50", VA = "0x186B11550")]
	public void OLBKOMKIBPE(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FFD0", Offset = "0x6B0E9D0", VA = "0x186B0FFD0")]
	public void BJHGGKEOOCO(T1 KJMBICGEFEP, T2 KDEFEFLCIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B10C60", Offset = "0x6B0F660", VA = "0x186B10C60", Slot = "5")]
	private void GOJHPFNPOEP((T1, T2) GEHEADBMGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F740C0", Offset = "0x4F72AC0", VA = "0x184F740C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DMACFBAJJEM<T1, T2, T3> : DOIAGBPPAPM<(T1, T2, T3)>, HCEMOOLHACD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FBFDPAGIDNI<T1, T2, T3> DFDJLNKHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly FBFDPAGIDNI<T1, T2, T3> JBDJKIPMEFE;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE92430", Offset = "0xE90E30", VA = "0x180E92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KBKNHMHEEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5493180", Offset = "0x5491B80", VA = "0x185493180", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool HNIDCJJKNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B01D90", Offset = "0x6B00790", VA = "0x186B01D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HHKPAFCKNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B01A40", Offset = "0x6B00440", VA = "0x186B01A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FLOCDKFGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B020A0", Offset = "0x6B00AA0", VA = "0x186B020A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) IODCKBAILNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B01400", Offset = "0x6AFFE00", VA = "0x186B01400", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B02F00", Offset = "0x6B01900", VA = "0x186B02F00", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) MACGIJPMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B02B20", Offset = "0x6B01520", VA = "0x186B02B20", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B01C80", Offset = "0x6B00680", VA = "0x186B01C80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 BENODLJFPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B01720", Offset = "0x6B00120", VA = "0x186B01720")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 IENPBKGGKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B01BE0", Offset = "0x6B005E0", VA = "0x186B01BE0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 GDLBMMNHFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B01BE0", Offset = "0x6B005E0", VA = "0x186B01BE0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B013D0", Offset = "0x6AFFDD0", VA = "0x186B013D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 IOCFFILBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B01A00", Offset = "0x6B00400", VA = "0x186B01A00")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 EDDMIKHNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B01D50", Offset = "0x6B00750", VA = "0x186B01D50")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 NHBOFFDMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B01D50", Offset = "0x6B00750", VA = "0x186B01D50")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B02850", Offset = "0x6B01250", VA = "0x186B02850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 OEIFLKJGHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B02060", Offset = "0x6B00A60", VA = "0x186B02060")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 FMKLKJNPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B01BA0", Offset = "0x6B005A0", VA = "0x186B01BA0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 IKNMNPFMKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B01BA0", Offset = "0x6B005A0", VA = "0x186B01BA0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B01C50", Offset = "0x6B00650", VA = "0x186B01C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4F74120", Offset = "0x4F72B20", VA = "0x184F74120", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B011D0", Offset = "0x6AFFBD0", VA = "0x186B011D0", Slot = "10")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B030C0", Offset = "0x6B01AC0", VA = "0x186B030C0")]
	public DMACFBAJJEM([In] INDMLKIABEN HPGIDELCODH, T1 INJHPAEIAFF, T2 FBAGPBGDDLE, T3 MOBOEAGKDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B02580", Offset = "0x6B00F80", VA = "0x186B02580")]
	private void NAPDFCNLBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B02880", Offset = "0x6B01280", VA = "0x186B02880")]
	public void OLBKOMKIBPE(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B01760", Offset = "0x6B00160", VA = "0x186B01760")]
	public void EKFNOGBCLGK(T2 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B024A0", Offset = "0x6B00EA0", VA = "0x186B024A0")]
	public void KHBCPJOBGHJ(T3 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B01240", Offset = "0x6AFFC40", VA = "0x186B01240")]
	public void BJHGGKEOOCO(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, T3 ELHAKKNMNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B02000", Offset = "0x6B00A00", VA = "0x186B02000", Slot = "5")]
	private void JJELAPAIFOL((T1, T2, T3) GEHEADBMGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4F740C0", Offset = "0x4F72AC0", VA = "0x184F740C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AMCGAAFEKGK<T1, T2, T3, T4> : DOIAGBPPAPM<(T1, T2, T3, T4)>, HCEMOOLHACD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LFNBIDDFANP<T1, T2, T3, T4> DFDJLNKHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LFNBIDDFANP<T1, T2, T3, T4> JBDJKIPMEFE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE92430", Offset = "0xE90E30", VA = "0x180E92430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) MACGIJPMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4F74760", Offset = "0x4F73160", VA = "0x184F74760", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F74190", Offset = "0x4F72B90", VA = "0x184F74190", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 EDDMIKHNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4C51DE0", Offset = "0x4C507E0", VA = "0x184C51DE0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 FMKLKJNPHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4C51CE0", Offset = "0x4C506E0", VA = "0x184C51CE0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 BKINJEOLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4F74920", Offset = "0x4F73320", VA = "0x184F74920")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F74120", Offset = "0x4F72B20", VA = "0x184F74120", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F74100", Offset = "0x4F72B00", VA = "0x184F74100", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4F74B90", Offset = "0x4F73590", VA = "0x184F74B90")]
	public AMCGAAFEKGK([In] INDMLKIABEN HPGIDELCODH, T1 INJHPAEIAFF, T2 FBAGPBGDDLE, T3 MOBOEAGKDAK, T4 NMPEDGLOLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4F741E0", Offset = "0x4F72BE0", VA = "0x184F741E0")]
	private void NAPDFCNLBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4F74520", Offset = "0x4F72F20", VA = "0x184F74520")]
	public void OLBKOMKIBPE(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4F74020", Offset = "0x4F72A20", VA = "0x184F74020")]
	public void BJHGGKEOOCO(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, T3 ELHAKKNMNLD, T4 OAIKOLMDEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4F748E0", Offset = "0x4F732E0", VA = "0x184F748E0", Slot = "5")]
	private void PJABFAMEIKJ((T1, T2, T3, T4) GEHEADBMGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F740C0", Offset = "0x4F72AC0", VA = "0x184F740C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GINGKBIBHKK
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E972D0", Offset = "0x7E95CD0", VA = "0x187E972D0")]
	public static string EGOPGOJCOMH(this INDMLKIABEN HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xC63550", Offset = "0xC61F50", VA = "0x180C63550")]
	public static GPEMLBBBNLC EFOAKOKCDAF(this INDMLKIABEN HPGIDELCODH)
	{
		return default(GPEMLBBBNLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NOHHGHEDDJL<T> : JAFBLNEILJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public NOHHGHEDDJL([In] INDMLKIABEN HPGIDELCODH, T ALKDPGOIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5550700", Offset = "0x554F100", VA = "0x185550700")]
	public NOHHGHEDDJL(ENPMHDHFNFF GJIMIGJJJKI, GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T ALKDPGOIFPD, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55517B0", Offset = "0x55501B0", VA = "0x1855517B0")]
	public NOHHGHEDDJL(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T ALKDPGOIFPD, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5551B00", Offset = "0x5550500", VA = "0x185551B00")]
	public NOHHGHEDDJL(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T ALKDPGOIFPD, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PFDBCMIKJIA<T1, T2> : OKACJIJGHMA<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x575CC80", Offset = "0x575B680", VA = "0x18575CC80")]
	public PFDBCMIKJIA([In] INDMLKIABEN HPGIDELCODH, T1 KOKMCMLIINO, T2 NLPEMAAJAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x575CF60", Offset = "0x575B960", VA = "0x18575CF60")]
	public PFDBCMIKJIA(ENPMHDHFNFF GJIMIGJJJKI, GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x575E220", Offset = "0x575CC20", VA = "0x18575E220")]
	public PFDBCMIKJIA(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x575F990", Offset = "0x575E390", VA = "0x18575F990")]
	public PFDBCMIKJIA(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FBFDPAGIDNI<T1, T2, T3> : PKKAIEOIOOH<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F2D0", Offset = "0x4B2DCD0", VA = "0x184B2F2D0")]
	public FBFDPAGIDNI([In] INDMLKIABEN HPGIDELCODH, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F0F0", Offset = "0x4B2DAF0", VA = "0x184B2F0F0")]
	public FBFDPAGIDNI(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LFNBIDDFANP<T1, T2, T3, T4> : JKOCMBJPMOI<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5284EB0", Offset = "0x52838B0", VA = "0x185284EB0")]
	public LFNBIDDFANP([In] INDMLKIABEN HPGIDELCODH, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, T4 MMEOGGCODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5284F20", Offset = "0x5283920", VA = "0x185284F20")]
	public LFNBIDDFANP(ENPMHDHFNFF GJIMIGJJJKI, GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, T4 MMEOGGCODKG, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5285170", Offset = "0x5283B70", VA = "0x185285170")]
	public LFNBIDDFANP(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, T4 MMEOGGCODKG, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GJEAHIMMNDE<T1, T2, T3, T4, T5> : HPMPPPPFDPC<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4C6DC50", Offset = "0x4C6C650", VA = "0x184C6DC50")]
	public GJEAHIMMNDE(ENPMHDHFNFF GJIMIGJJJKI, GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, T4 MMEOGGCODKG, T5 FODJJGJHOJL, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4C6D6C0", Offset = "0x4C6C0C0", VA = "0x184C6D6C0")]
	public GJEAHIMMNDE(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 KOKMCMLIINO, T2 NLPEMAAJAOF, T3 DOEOJFEBAKP, T4 MMEOGGCODKG, T5 FODJJGJHOJL, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CHEEFLHFFEM<T> : JAFBLNEILJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6586390", Offset = "0x6584D90", VA = "0x186586390")]
	public CHEEFLHFFEM(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T ALKDPGOIFPD, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FOJKFAOBDFI<T1, T2> : OKACJIJGHMA<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6ECE0", Offset = "0x4B6D6E0", VA = "0x184B6ECE0")]
	public FOJKFAOBDFI(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JHMPHLNCPDL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOHHGHEDDJL<T1> FONGMEJAEBO<T1>(string KJNEHANBOBO, T1 EFIGANGHFLF, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PECLFNBPLLF : JHMPHLNCPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BPANGKBMDLE CCKCIIGAFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ENPMHDHFNFF GJIMIGJJJKI;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public PECLFNBPLLF(BPANGKBMDLE CCKCIIGAFNI, ENPMHDHFNFF CBKNCJLIBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C20FB0", Offset = "0x3C1F9B0", VA = "0x183C20FB0", Slot = "4")]
	public NOHHGHEDDJL<T1> FONGMEJAEBO<T1>(string KJNEHANBOBO, T1 EFIGANGHFLF, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHBJPDLNMGD : ENPMHDHFNFF
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId IBJKJLLCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ENPMHDHFNFF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HNPGBPIODPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OOFAJKPAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string KNDMDMFHKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool JDNJOHPAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(NJPGPEBFJKB NGGCDDHMKBK);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(NJPGPEBFJKB NGGCDDHMKBK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OMGJLCFLFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E97570", Offset = "0x7E95F70", VA = "0x187E97570")]
	public static bool HOHDMCAFOKD(this ENPMHDHFNFF GJIMIGJJJKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BPANGKBMDLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool BJLEFKIJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBILOAODCDE();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object PJBNPOFJCGJ(string KJNEHANBOBO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object FPGAOAKNDIK(GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEJHEMGCFPM(string KJNEHANBOBO, object OIEALMJHDLB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FIGADIOPBHD(GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO, object OIEALMJHDLB);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJJBPBODHGN<T>(string KJNEHANBOBO, T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECDFEGJHBBL([CanBeNull] GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBOCLAAPKLK([CanBeNull] GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T EICNNGLPOOP<T>(object PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object APPKKIEPAPO<T>(T ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FLJKDCEEHNH();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HCBKBIOFIEI();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LEPOLOPDKGA(string IOFCDGOOFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct INDMLKIABEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GBDECDHLMJN KPIDJKLDGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public ENPMHDHFNFF GJIMIGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string KJNEHANBOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GPEMLBBBNLC NADHNOKKKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool PDHLHBNICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action DMDJELFGCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public BPANGKBMDLE CCKCIIGAFNI;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E97360", Offset = "0x7E95D60", VA = "0x187E97360")]
	public INDMLKIABEN(INDMLKIABEN NDNHELJMDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E973E0", Offset = "0x7E95DE0", VA = "0x187E973E0")]
	public INDMLKIABEN(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E97310", Offset = "0x7E95D10", VA = "0x187E97310")]
	public static INDMLKIABEN ALHLPHFCPPN(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, GPEMLBBBNLC NADHNOKKKFG, [Optional] Action DMDJELFGCKJ, [Optional] BPANGKBMDLE CCKCIIGAFNI)
	{
		return default(INDMLKIABEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JDPNJKDFJLO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE870", Offset = "0x3ABD270", VA = "0x183ABE870")]
	public static NOHHGHEDDJL<T> EHFIDLONCGF<T>(this INDMLKIABEN HPGIDELCODH, T ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE720", Offset = "0x3ABD120", VA = "0x183ABE720")]
	public static PFDBCMIKJIA<T1, T2> EHFIDLONCGF<T1, T2>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE7C0", Offset = "0x3ABD1C0", VA = "0x183ABE7C0")]
	public static FBFDPAGIDNI<T1, T2, T3> EHFIDLONCGF<T1, T2, T3>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP, T3 CLOMFGCGGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEB30", Offset = "0x3ABD530", VA = "0x183ABEB30")]
	public static LFNBIDDFANP<T1, T2, T3, T4> EHFIDLONCGF<T1, T2, T3, T4>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP, T3 CLOMFGCGGNI, T4 AJOEJELFMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE870", Offset = "0x3ABD270", VA = "0x183ABE870")]
	public static MKCBGACOLEL<T> PGCFNNOCMHH<T>(this INDMLKIABEN HPGIDELCODH, T ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE720", Offset = "0x3ABD120", VA = "0x183ABE720")]
	public static DNLPCBELHIB<T1, T2> PGCFNNOCMHH<T1, T2>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE7C0", Offset = "0x3ABD1C0", VA = "0x183ABE7C0")]
	public static DMACFBAJJEM<T1, T2, T3> PGCFNNOCMHH<T1, T2, T3>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP, T3 CLOMFGCGGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEB30", Offset = "0x3ABD530", VA = "0x183ABEB30")]
	public static AMCGAAFEKGK<T1, T2, T3, T4> PGCFNNOCMHH<T1, T2, T3, T4>(this INDMLKIABEN HPGIDELCODH, T1 HPNKKFGJIIJ, T2 INOGLDKLGPP, T3 CLOMFGCGGNI, T4 AJOEJELFMNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class EALFIIPLOAE : NJPGPEBFJKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum PJDDLOICBPM
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disposed = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LastSetLocally = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Synchronizing = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ModifiedOffline = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 4
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static Stack<BPANGKBMDLE> BHHAJCHOKGA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool MHBIHNCMCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GBDECDHLMJN KPIDJKLDGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ENPMHDHFNFF GJIMIGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string KJNEHANBOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly GPEMLBBBNLC NADHNOKKKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action DMDJELFGCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected BPANGKBMDLE CKAOKOKNGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private PJDDLOICBPM FIKPCOCNDHE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static BPANGKBMDLE PCIDABHKONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E96720", Offset = "0x7E95120", VA = "0x187E96720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool LKPGAJMJHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E96CE0", Offset = "0x7E956E0", VA = "0x187E96CE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E96210", Offset = "0x7E94C10", VA = "0x187E96210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool GDLKHIDOKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E96CD0", Offset = "0x7E956D0", VA = "0x187E96CD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E96230", Offset = "0x7E94C30", VA = "0x187E96230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool NNNNLABLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E96790", Offset = "0x7E95190", VA = "0x187E96790")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7E96E10", Offset = "0x7E95810", VA = "0x187E96E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool HHMLEAKLIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E963C0", Offset = "0x7E94DC0", VA = "0x187E963C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E96150", Offset = "0x7E94B50", VA = "0x187E96150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool KDIJLCBLBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E96990", Offset = "0x7E95390", VA = "0x187E96990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int HKPMGLFBMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDC1120", Offset = "0xDBFB20", VA = "0x180DC1120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xF199B0", Offset = "0xF183B0", VA = "0x180F199B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PKHCDEJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E95F90", Offset = "0x7E94990", VA = "0x187E95F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E969E0", Offset = "0x7E953E0", VA = "0x187E969E0")]
	public static void MMDEHIPCJPI(BPANGKBMDLE OGDKCMFIDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool FODGAHKIKBJ();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E970B0", Offset = "0x7E95AB0", VA = "0x187E970B0")]
	protected EALFIIPLOAE(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, GPEMLBBBNLC NADHNOKKKFG, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E96250", Offset = "0x7E94C50", VA = "0x187E96250", Slot = "1")]
	~EALFIIPLOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E95FE0", Offset = "0x7E949E0", VA = "0x187E95FE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E96CF0", Offset = "0x7E956F0", VA = "0x187E96CF0")]
	private void OKBEILIOANC(bool LFKDLOABHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E95C20", Offset = "0x7E94620", VA = "0x187E95C20")]
	private object CNMPLHKHODO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E95D90", Offset = "0x7E94790", VA = "0x187E95D90")]
	protected void DBILOAODCDE(bool PDHLHBNICFC, object DLCCFGMOGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E95F50", Offset = "0x7E94950", VA = "0x187E95F50")]
	protected void DGDFODDEBEH(object OIEALMJHDLB, bool KJMFDLLPAPJ = true, bool NOMDPKPGBGN = false, bool CPBEKKPEMFJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E96A80", Offset = "0x7E95480", VA = "0x187E96A80")]
	protected void NCAHOFIFHMP(object OIEALMJHDLB, bool OMDNLKNDGAO, bool KJMFDLLPAPJ, bool NOMDPKPGBGN = false, bool CPBEKKPEMFJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E96D90", Offset = "0x7E95790", VA = "0x187E96D90")]
	internal void ONEMAFMMFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E966C0", Offset = "0x7E950C0", VA = "0x187E966C0")]
	private void JOGCHOIOKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E965B0", Offset = "0x7E94FB0", VA = "0x187E965B0")]
	private void JIGCMPBGPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E96540", Offset = "0x7E94F40", VA = "0x187E96540", Slot = "4")]
	private void IMHIMJMHNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E96610", Offset = "0x7E95010", VA = "0x187E96610", Slot = "5")]
	private void JJAFPGDEMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E96850", Offset = "0x7E95250", VA = "0x187E96850")]
	public bool MKMPLBEKFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E96E50", Offset = "0x7E95850", VA = "0x187E96E50")]
	public bool PLDBGDDFKOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E959F0", Offset = "0x7E943F0", VA = "0x187E959F0")]
	private bool CAFOCFLLEOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E967A0", Offset = "0x7E951A0", VA = "0x187E967A0")]
	internal void LALBNGKFHDF(object OIEALMJHDLB, int MADINDCOAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E962B0", Offset = "0x7E94CB0", VA = "0x187E962B0")]
	private void GHAGCHBPLEO(object OIEALMJHDLB, bool NOMDPKPGBGN, bool CPBEKKPEMFJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E963D0", Offset = "0x7E94DD0", VA = "0x187E963D0")]
	private bool HIEJEAGNHHL(PJDDLOICBPM KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E96E30", Offset = "0x7E95830", VA = "0x187E96E30")]
	private void PINDOANPOIN(PJDDLOICBPM KCPPNOGKMII, bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E96620", Offset = "0x7E95020", VA = "0x187E96620")]
	public static string JNFCGCFHKJB(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E95B40", Offset = "0x7E94540", VA = "0x187E95B40")]
	public static string CEOCOJNGJBP(ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E963E0", Offset = "0x7E94DE0", VA = "0x187E963E0")]
	public static bool HKNNNOGPACA(object MJGADEGDMOP, object LJDEEJKPAEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PMJJAIAGLIJ : BPANGKBMDLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> PGHKEKNHCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> EOJEEEDEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> ONIDMCHGPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> POGJJPPDDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> LCADGLCFMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<GBDECDHLMJN, Dictionary<string, object>> PAANELOFOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> GLNLINDDKCL;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> GMMOEOEIABE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int MIEDEBAMMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool BJLEFKIJJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool NCLEPPOPEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3C280F0", Offset = "0x3C26AF0", VA = "0x183C280F0", Slot = "12")]
	public void EJJBPBODHGN<T>(string KJNEHANBOBO, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E98170", Offset = "0x7E96B70", VA = "0x187E98170", Slot = "11")]
	public void FIGADIOPBHD(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO, object PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E983C0", Offset = "0x7E96DC0", VA = "0x187E983C0", Slot = "9")]
	public object FPGAOAKNDIK(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E98050", Offset = "0x7E96A50", VA = "0x187E98050", Slot = "10")]
	public void FEJHEMGCFPM(string KJNEHANBOBO, object PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E99980", Offset = "0x7E98380", VA = "0x187E99980", Slot = "8")]
	public object PJBNPOFJCGJ(string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E97ED0", Offset = "0x7E968D0", VA = "0x187E97ED0", Slot = "13")]
	public void ECDFEGJHBBL(GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E97AC0", Offset = "0x7E964C0", VA = "0x187E97AC0", Slot = "14")]
	public void DBOCLAAPKLK(GBDECDHLMJN DCMMAAEJIEE, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E975C0", Offset = "0x7E95FC0", VA = "0x187E975C0")]
	private void AEMFEJJKOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E98D90", Offset = "0x7E97790", VA = "0x187E98D90")]
	private void HLCIEOPALMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E98F50", Offset = "0x7E97950", VA = "0x187E98F50")]
	private void KIOLJIGKKMP(GBDECDHLMJN KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E97990", Offset = "0x7E96390", VA = "0x187E97990")]
	protected void BKKOBHGGIAL(GBDECDHLMJN BDMLDOEBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E97610", Offset = "0x7E96010", VA = "0x187E97610")]
	protected void AKKBIGJLFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E984B0", Offset = "0x7E96EB0", VA = "0x187E984B0")]
	protected void GAOEPIOHFBG(IDictionary<object, object> LFKOJDHNGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E97FE0", Offset = "0x7E969E0", VA = "0x187E97FE0")]
	protected void EJIJDHHDBCA(GBDECDHLMJN GKJDHMPBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E996E0", Offset = "0x7E980E0", VA = "0x187E996E0")]
	protected void NLMJDGFMOEL(GBDECDHLMJN KPIDJKLDGJJ, IDictionary<object, object> LFKOJDHNGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E98910", Offset = "0x7E97310", VA = "0x187E98910")]
	private void HDFGPAHEFLB(IDictionary<object, object> LFKOJDHNGFA, Dictionary<string, object> PMMEHOEGDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E99770", Offset = "0x7E98170", VA = "0x187E99770")]
	private static void ONPMOBILFGN(object PENJLPCOGKI, object MLCOAPMDJJE, int MADINDCOAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E99A20", Offset = "0x7E98420", VA = "0x187E99A20")]
	private static void PKPANLHLKHM(Dictionary<string, object> PMMEHOEGDGG, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E98FB0", Offset = "0x7E979B0", VA = "0x187E98FB0")]
	private static void KMEKIEPDKOK(Dictionary<string, object> PMMEHOEGDGG, string KJNEHANBOBO, EALFIIPLOAE HDJDGJMACHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E982C0", Offset = "0x7E96CC0", VA = "0x187E982C0", Slot = "17")]
	public void FLJKDCEEHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void NBIEDDFMAJK(Dictionary<object, object> PGHKEKNHCNG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E98830", Offset = "0x7E97230", VA = "0x187E98830", Slot = "18")]
	public void HCBKBIOFIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void OAMNFEGKHLM(Dictionary<object, object> ONIDMCHGPGH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E99420", Offset = "0x7E97E20", VA = "0x187E99420")]
	private void LPJBNCCOFMB(Dictionary<object, object> BABGIBHLMOF, List<string> POGDNBHDKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E97700", Offset = "0x7E96100", VA = "0x187E97700")]
	private void BECBLCIPMJL(IDictionary<object, object> LFKOJDHNGFA, [Out] int MADINDCOAAG, [Out] string[] OEEPCNFAIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E99650", Offset = "0x7E98050", VA = "0x187E99650")]
	public void MGCNKICCAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E98DE0", Offset = "0x7E977E0", VA = "0x187E98DE0")]
	public void JDFKPOKKOOC(GBDECDHLMJN KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E984C0", Offset = "0x7E96EC0", VA = "0x187E984C0")]
	public void GFDAANFDCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> HBCFGGOMMFH(bool DKMFHIOINEG, bool FAPFAGIDLKF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E99190", Offset = "0x7E97B90", VA = "0x187E99190", Slot = "19")]
	public void LEPOLOPDKGA(string IOFCDGOOFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E98EB0", Offset = "0x7E978B0", VA = "0x187E98EB0")]
	protected string JNFCGCFHKJB(GBDECDHLMJN KPIDJKLDGJJ, string KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object APPKKIEPAPO<T>(T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T EICNNGLPOOP<T>(object PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "32")]
	public virtual void DBILOAODCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E97D70", Offset = "0x7E96770", VA = "0x187E97D70", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "33")]
	protected virtual void ICNBGJPIJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E99C50", Offset = "0x7E98650", VA = "0x187E99C50")]
	protected PMJJAIAGLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JAFBLNEILJP<T1> : EALFIIPLOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 EFIGANGHFLF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 CKPALJKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1140FB0", Offset = "0x113F9B0", VA = "0x181140FB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1140FD0", Offset = "0x113F9D0", VA = "0x181140FD0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x504DD30", Offset = "0x504C730", VA = "0x18504DD30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x504C510", Offset = "0x504AF10", VA = "0x18504C510", Slot = "9")]
	protected override bool FODGAHKIKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x504ED90", Offset = "0x504D790", VA = "0x18504ED90")]
	protected JAFBLNEILJP([In] INDMLKIABEN HPGIDELCODH, T1 EFIGANGHFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x504F500", Offset = "0x504DF00", VA = "0x18504F500")]
	protected JAFBLNEILJP(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 EFIGANGHFLF, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
	public T1 IBPMNADNGOO()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5049C80", Offset = "0x5048680", VA = "0x185049C80")]
	public void DGDFODDEBEH(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5049A70", Offset = "0x5048470", VA = "0x185049A70")]
	public void DGDFODDEBEH(T1 OIEALMJHDLB, bool KJMFDLLPAPJ, bool NOMDPKPGBGN = false, bool CPBEKKPEMFJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OKACJIJGHMA<T1, T2> : EALFIIPLOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 EFIGANGHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 FBPCMPJPBFC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 CKPALJKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xF65540", Offset = "0xF63F40", VA = "0x180F65540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1140FC0", Offset = "0x113F9C0", VA = "0x181140FC0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 ABOAODHPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF5E030", Offset = "0xF5CA30", VA = "0x180F5E030", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xF666D0", Offset = "0xF650D0", VA = "0x180F666D0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 FPGJEJLILPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4D18350", Offset = "0x4D16D50", VA = "0x184D18350")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5674520", Offset = "0x5672F20", VA = "0x185674520", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x56721A0", Offset = "0x5670BA0", VA = "0x1856721A0", Slot = "9")]
	protected override bool FODGAHKIKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x56767A0", Offset = "0x56751A0", VA = "0x1856767A0")]
	protected OKACJIJGHMA([In] INDMLKIABEN HPGIDELCODH, T1 EFIGANGHFLF, T2 FBPCMPJPBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5678090", Offset = "0x5676A90", VA = "0x185678090")]
	protected OKACJIJGHMA(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
	public T1 EJJJHFHEDOE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x566DF90", Offset = "0x566C990", VA = "0x18566DF90")]
	public void BCAOIMLHJFL(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4D18350", Offset = "0x4D16D50", VA = "0x184D18350")]
	public T2 PAJBOBANJKK()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x566D370", Offset = "0x566BD70", VA = "0x18566D370")]
	public void ADAKFDPOFHO(T2 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5670B60", Offset = "0x566F560", VA = "0x185670B60")]
	public void DGDFODDEBEH(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, bool KJMFDLLPAPJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class PKKAIEOIOOH<T1, T2, T3> : EALFIIPLOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 EFIGANGHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 FBPCMPJPBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 PLOBKPMOBGB;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 CKPALJKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA17C10", Offset = "0xA16610", VA = "0x180A17C10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA17BE0", Offset = "0xA165E0", VA = "0x180A17BE0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 ABOAODHPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xFA0640", Offset = "0xF9F040", VA = "0x180FA0640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDA0", Offset = "0xF9D7A0", VA = "0x180F9EDA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 DFFFNAKNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA256C0", Offset = "0xA240C0", VA = "0x180A256C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xD17A50", Offset = "0xD16450", VA = "0x180D17A50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 DKMACHFPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 FPGJEJLILPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4D18350", Offset = "0x4D16D50", VA = "0x184D18350")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 LHGMPPFPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4D183B0", Offset = "0x4D16DB0", VA = "0x184D183B0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x57893F0", Offset = "0x5787DF0", VA = "0x1857893F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5787AC0", Offset = "0x57864C0", VA = "0x185787AC0", Slot = "9")]
	protected override bool FODGAHKIKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5789B50", Offset = "0x5788550", VA = "0x185789B50")]
	protected PKKAIEOIOOH([In] INDMLKIABEN HPGIDELCODH, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, T3 PLOBKPMOBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x578AE40", Offset = "0x5789840", VA = "0x18578AE40")]
	protected PKKAIEOIOOH(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, T3 PLOBKPMOBGB, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
	public T1 EJJJHFHEDOE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5784A50", Offset = "0x5783450", VA = "0x185784A50")]
	public void BCAOIMLHJFL(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4D18350", Offset = "0x4D16D50", VA = "0x184D18350")]
	public T2 PAJBOBANJKK()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5784330", Offset = "0x5782D30", VA = "0x185784330")]
	public void ADAKFDPOFHO(T2 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4D183B0", Offset = "0x4D16DB0", VA = "0x184D183B0")]
	public T3 PCMFDPGLHDM()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5789680", Offset = "0x5788080", VA = "0x185789680")]
	public void KBJKLCGNFKP(T3 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x57852E0", Offset = "0x5783CE0", VA = "0x1857852E0")]
	public void DGDFODDEBEH(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, T3 ELHAKKNMNLD, bool KJMFDLLPAPJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class JKOCMBJPMOI<T1, T2, T3, T4> : EALFIIPLOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 EFIGANGHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 FBPCMPJPBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 PLOBKPMOBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 HLLOBJALDCA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 CKPALJKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xE40770", Offset = "0xE3F170", VA = "0x180E40770", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xF4BFE0", Offset = "0xF4A9E0", VA = "0x180F4BFE0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 ABOAODHPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1D95600", Offset = "0x1D94000", VA = "0x181D95600", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4D13890", Offset = "0x4D12290", VA = "0x184D13890", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 DFFFNAKNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50A8470", Offset = "0x50A6E70", VA = "0x1850A8470", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50A4EE0", Offset = "0x50A38E0", VA = "0x1850A4EE0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 EGBNBANJOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x151A650", Offset = "0x1519050", VA = "0x18151A650", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x14B4360", Offset = "0x14B2D60", VA = "0x1814B4360", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 FPGJEJLILPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4D18370", Offset = "0x4D16D70", VA = "0x184D18370")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 LHGMPPFPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x50A7C40", Offset = "0x50A6640", VA = "0x1850A7C40")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 KHNCLEMLKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70480", VA = "0x180C71A80")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x50A7710", Offset = "0x50A6110", VA = "0x1850A7710", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x50A6270", Offset = "0x50A4C70", VA = "0x1850A6270", Slot = "9")]
	protected override bool FODGAHKIKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x50AA3B0", Offset = "0x50A8DB0", VA = "0x1850AA3B0")]
	protected JKOCMBJPMOI([In] INDMLKIABEN HPGIDELCODH, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, T3 PLOBKPMOBGB, T4 HLLOBJALDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x50AA460", Offset = "0x50A8E60", VA = "0x1850AA460")]
	protected JKOCMBJPMOI(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, T3 PLOBKPMOBGB, T4 HLLOBJALDCA, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
	public T1 EJJJHFHEDOE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x50A0FC0", Offset = "0x509F9C0", VA = "0x1850A0FC0")]
	public void BCAOIMLHJFL(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4D18370", Offset = "0x4D16D70", VA = "0x184D18370")]
	public T2 PAJBOBANJKK()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x50A06A0", Offset = "0x509F0A0", VA = "0x1850A06A0")]
	public void ADAKFDPOFHO(T2 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x50A7C40", Offset = "0x50A6640", VA = "0x1850A7C40")]
	public T3 PCMFDPGLHDM()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x50A8020", Offset = "0x50A6A20", VA = "0x1850A8020")]
	public void KBJKLCGNFKP(T3 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70480", VA = "0x180C71A80")]
	public T4 MFAFOCIKJIA()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x50A1BF0", Offset = "0x50A05F0", VA = "0x1850A1BF0")]
	public void BFFOMOMFFPJ(T4 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x50A35F0", Offset = "0x50A1FF0", VA = "0x1850A35F0")]
	public void DGDFODDEBEH(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, T3 ELHAKKNMNLD, T4 OAIKOLMDEKM, bool KJMFDLLPAPJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class HPMPPPPFDPC<T1, T2, T3, T4, T5> : EALFIIPLOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 EFIGANGHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 FBPCMPJPBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 PLOBKPMOBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 HLLOBJALDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 KLHIKJHELBB;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 CKPALJKIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xBD1230", Offset = "0xBCFC30", VA = "0x180BD1230", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x13437D0", Offset = "0x13421D0", VA = "0x1813437D0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 ABOAODHPAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x143C9B0", Offset = "0x143B3B0", VA = "0x18143C9B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x143B9F0", Offset = "0x143A3F0", VA = "0x18143B9F0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 DFFFNAKNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA256C0", Offset = "0xA240C0", VA = "0x180A256C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xD17A50", Offset = "0xD16450", VA = "0x180D17A50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 EGBNBANJOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA41F80", Offset = "0xA40980", VA = "0x180A41F80", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA41FE0", Offset = "0xA409E0", VA = "0x180A41FE0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 GIFHPCIFKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x165F800", Offset = "0x165E200", VA = "0x18165F800", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x165F810", Offset = "0x165E210", VA = "0x18165F810", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object BDLDJILLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4D175E0", Offset = "0x4D15FE0", VA = "0x184D175E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4D16A50", Offset = "0x4D15450", VA = "0x184D16A50", Slot = "9")]
	protected override bool FODGAHKIKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4D183D0", Offset = "0x4D16DD0", VA = "0x184D183D0")]
	protected HPMPPPPFDPC(GBDECDHLMJN KPIDJKLDGJJ, ENPMHDHFNFF GJIMIGJJJKI, string KJNEHANBOBO, T1 EFIGANGHFLF, T2 FBPCMPJPBFC, T3 PLOBKPMOBGB, T4 HLLOBJALDCA, T5 KLHIKJHELBB, GPEMLBBBNLC NADHNOKKKFG, bool PDHLHBNICFC, Action DMDJELFGCKJ, BPANGKBMDLE CCKCIIGAFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FD0", Offset = "0x4D149D0", VA = "0x184D15FD0")]
	public T1 EJJJHFHEDOE()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4D139A0", Offset = "0x4D123A0", VA = "0x184D139A0")]
	public void BCAOIMLHJFL(T1 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4D18350", Offset = "0x4D16D50", VA = "0x184D18350")]
	public T2 PAJBOBANJKK()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4D136C0", Offset = "0x4D120C0", VA = "0x184D136C0")]
	public void ADAKFDPOFHO(T2 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4D183B0", Offset = "0x4D16DB0", VA = "0x184D183B0")]
	public T3 PCMFDPGLHDM()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4D17F80", Offset = "0x4D16980", VA = "0x184D17F80")]
	public void KBJKLCGNFKP(T3 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70480", VA = "0x180C71A80")]
	public T4 MFAFOCIKJIA()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4D13D60", Offset = "0x4D12760", VA = "0x184D13D60")]
	public void BFFOMOMFFPJ(T4 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4D138B0", Offset = "0x4D122B0", VA = "0x184D138B0")]
	public T5 ALOFKIDOFJP()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4D17AB0", Offset = "0x4D164B0", VA = "0x184D17AB0")]
	public void HHJLJOAHCEA(T5 OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4D15390", Offset = "0x4D13D90", VA = "0x184D15390")]
	public void DGDFODDEBEH(T1 KJMBICGEFEP, T2 KDEFEFLCIOA, T3 ELHAKKNMNLD, T4 OAIKOLMDEKM, T5 DKEKGBGDHPO)
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
