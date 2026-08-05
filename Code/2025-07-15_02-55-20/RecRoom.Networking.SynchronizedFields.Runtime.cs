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
public interface ICBJEMGJGNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GCMGMCKCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JDKKFDBCLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PLCCGHEKGIM HOLHGLIJKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int OCKIFLKPPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OPGAOAJJFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BOLEBNDHBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MEHHJCBKBPO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJLLGDJKIEM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MHBFCGLGCEH(object DANCOEFIHDF, bool HHDLDNADJCJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KIEHJCPINNH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HAHDMIJJIFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMILFDFNBOJ<T> : HAHDMIJJIFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T HJCKFNNALFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALBDEGIFCDO(T CBMDPCIEEMO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MCHFFGOABPC<T> : KMILFDFNBOJ<T>, HAHDMIJJIFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BHCLHBFEPMH<T> DFILGMCPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BHCLHBFEPMH<T> FOLPEPPIDJM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF1E470", Offset = "0xF1D070", VA = "0x180F1E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MCNKIKGBKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x564D5E0", Offset = "0x564C1E0", VA = "0x18564D5E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T FEFKFGAKFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x48CE570", Offset = "0x48CD170", VA = "0x1848CE570", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x564DD40", Offset = "0x564C940", VA = "0x18564DD40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T HJCKFNNALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x564D8F0", Offset = "0x564C4F0", VA = "0x18564D8F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x564E270", Offset = "0x564CE70", VA = "0x18564E270", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x564D8F0", Offset = "0x564C4F0", VA = "0x18564D8F0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x564E180", Offset = "0x564CD80", VA = "0x18564E180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x564E200", Offset = "0x564CE00", VA = "0x18564E200", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x564DEB0", Offset = "0x564CAB0", VA = "0x18564DEB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x564E130", Offset = "0x564CD30", VA = "0x18564E130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x564E070", Offset = "0x564CC70", VA = "0x18564E070", Slot = "10")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x564E5C0", Offset = "0x564D1C0", VA = "0x18564E5C0")]
	public MCHFFGOABPC([In] IKJMDBCNGMN CBCNBAPLLJM, T KNEHBEIIHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x564E4E0", Offset = "0x564D0E0", VA = "0x18564E4E0")]
	private void OKHHHHKECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x564D220", Offset = "0x564BE20", VA = "0x18564D220", Slot = "5")]
	public void ALBDEGIFCDO(T CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x564D1B0", Offset = "0x564BDB0", VA = "0x18564D1B0")]
	public void ALBDEGIFCDO(T CBMDPCIEEMO, bool GBGMMOGHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x564D9E0", Offset = "0x564C5E0", VA = "0x18564D9E0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CPNKFPFCFHJ<T1, T2> : KMILFDFNBOJ<(T1, T2)>, HAHDMIJJIFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AOJGJKDIAKM<T1, T2> DFILGMCPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AOJGJKDIAKM<T1, T2> FOLPEPPIDJM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF1E470", Offset = "0xF1D070", VA = "0x180F1E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MCNKIKGBKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C59D10", Offset = "0x6C58910", VA = "0x186C59D10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OAFDBJPMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5889B40", Offset = "0x5888740", VA = "0x185889B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PDAHCIBJNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A9A0", Offset = "0x6C595A0", VA = "0x186C5A9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) FEFKFGAKFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C59E60", Offset = "0x6C58A60", VA = "0x186C59E60", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A240", Offset = "0x6C58E40", VA = "0x186C5A240", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) HJCKFNNALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A090", Offset = "0x6C58C90", VA = "0x186C5A090", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A760", Offset = "0x6C59360", VA = "0x186C5A760", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AB90", Offset = "0x6C59790", VA = "0x186C5AB90")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A6A0", Offset = "0x6C592A0", VA = "0x186C5A6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 OPOOHEICKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A6E0", Offset = "0x6C592E0", VA = "0x186C5A6E0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AB00", Offset = "0x6C59700", VA = "0x186C5AB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 AEMODGECDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C59AF0", Offset = "0x6C586F0", VA = "0x186C59AF0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 FBPKFBLKMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C59AF0", Offset = "0x6C586F0", VA = "0x186C59AF0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A340", Offset = "0x6C58F40", VA = "0x186C5A340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 DMPBEEBBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A7F0", Offset = "0x6C593F0", VA = "0x186C5A7F0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A590", Offset = "0x6C59190", VA = "0x186C5A590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 EDFAEFJPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C59BE0", Offset = "0x6C587E0", VA = "0x186C59BE0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 IFIPEIBKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C59BE0", Offset = "0x6C587E0", VA = "0x186C59BE0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C59E30", Offset = "0x6C58A30", VA = "0x186C59E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x564E200", Offset = "0x564CE00", VA = "0x18564E200", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x564DEB0", Offset = "0x564CAB0", VA = "0x18564DEB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A4D0", Offset = "0x6C590D0", VA = "0x186C5A4D0", Slot = "10")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C5ABD0", Offset = "0x6C597D0", VA = "0x186C5ABD0")]
	public CPNKFPFCFHJ([In] IKJMDBCNGMN CBCNBAPLLJM, T1 GKOJHJMNOBO, T2 FJEKLKMGPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A840", Offset = "0x6C59440", VA = "0x186C5A840")]
	private void OKHHHHKECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A360", Offset = "0x6C58F60", VA = "0x186C5A360")]
	public void FLFEFLMCKEL(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C59B30", Offset = "0x6C58730", VA = "0x186C59B30")]
	public void ALBDEGIFCDO(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A540", Offset = "0x6C59140", VA = "0x186C5A540", Slot = "5")]
	private void HOBNLIBNJKF((T1, T2) DNDKHMOJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x564D9E0", Offset = "0x564C5E0", VA = "0x18564D9E0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ONGPABBCDII<T1, T2, T3> : KMILFDFNBOJ<(T1, T2, T3)>, HAHDMIJJIFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MADEBPGHNGL<T1, T2, T3> DFILGMCPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MADEBPGHNGL<T1, T2, T3> FOLPEPPIDJM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF1E470", Offset = "0xF1D070", VA = "0x180F1E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MCNKIKGBKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x564D740", Offset = "0x564C340", VA = "0x18564D740", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OAFDBJPMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5889B40", Offset = "0x5888740", VA = "0x185889B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool PDAHCIBJNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x588A090", Offset = "0x5888C90", VA = "0x18588A090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool POFEFAFGDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5889CF0", Offset = "0x58888F0", VA = "0x185889CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) FEFKFGAKFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5888D20", Offset = "0x5887920", VA = "0x185888D20", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5889230", Offset = "0x5887E30", VA = "0x185889230", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) HJCKFNNALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5889030", Offset = "0x5887C30", VA = "0x185889030", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5889C60", Offset = "0x5888860", VA = "0x185889C60", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 OPOOHEICKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5889860", Offset = "0x5888460", VA = "0x185889860")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x588A170", Offset = "0x5888D70", VA = "0x18588A170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 AEMODGECDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5888A50", Offset = "0x5887650", VA = "0x185888A50")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 FBPKFBLKMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5888A50", Offset = "0x5887650", VA = "0x185888A50")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5889320", Offset = "0x5887F20", VA = "0x185889320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 DMPBEEBBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5889CB0", Offset = "0x58888B0", VA = "0x185889CB0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x58897D0", Offset = "0x58883D0", VA = "0x1858897D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 EDFAEFJPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5888CC0", Offset = "0x58878C0", VA = "0x185888CC0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 IFIPEIBKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5888CC0", Offset = "0x58878C0", VA = "0x185888CC0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5888D00", Offset = "0x5887900", VA = "0x185888D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 NODGPHGMLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5888B60", Offset = "0x5887760", VA = "0x185888B60")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5888BA0", Offset = "0x58877A0", VA = "0x185888BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 LMNILKDBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5889500", Offset = "0x5888100", VA = "0x185889500")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 CJKFHBHNAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5889500", Offset = "0x5888100", VA = "0x185889500")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5888B20", Offset = "0x5887720", VA = "0x185888B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x564E200", Offset = "0x564CE00", VA = "0x18564E200", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x564DEB0", Offset = "0x564CAB0", VA = "0x18564DEB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5889700", Offset = "0x5888300", VA = "0x185889700", Slot = "10")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x588A290", Offset = "0x5888E90", VA = "0x18588A290")]
	public ONGPABBCDII([In] IKJMDBCNGMN CBCNBAPLLJM, T1 GKOJHJMNOBO, T2 FJEKLKMGPHF, T3 NGIIFNLMLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5889EB0", Offset = "0x5888AB0", VA = "0x185889EB0")]
	private void OKHHHHKECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5889420", Offset = "0x5888020", VA = "0x185889420")]
	public void FLFEFLMCKEL(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5889540", Offset = "0x5888140", VA = "0x185889540")]
	public void GMGFPIFEPBE(T2 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5889980", Offset = "0x5888580", VA = "0x185889980")]
	public void JLEHGEJDKJC(T3 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5888A90", Offset = "0x5887690", VA = "0x185888A90")]
	public void ALBDEGIFCDO(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, T3 MBLOLKPNMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5889770", Offset = "0x5888370", VA = "0x185889770", Slot = "5")]
	private void IOPJHJNPKEL((T1, T2, T3) DNDKHMOJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x564D9E0", Offset = "0x564C5E0", VA = "0x18564D9E0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BKHAJHPEHJB<T1, T2, T3, T4> : KMILFDFNBOJ<(T1, T2, T3, T4)>, HAHDMIJJIFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly AONMADEFOCP<T1, T2, T3, T4> DFILGMCPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AONMADEFOCP<T1, T2, T3, T4> FOLPEPPIDJM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xF1E470", Offset = "0xF1D070", VA = "0x180F1E470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) HJCKFNNALFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6611DD0", Offset = "0x66109D0", VA = "0x186611DD0", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6612320", Offset = "0x6610F20", VA = "0x186612320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 EDFAEFJPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DB80", Offset = "0x4E9C780", VA = "0x184E9DB80")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 LMNILKDBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DC40", Offset = "0x4E9C840", VA = "0x184E9DC40")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 PHNOCJOPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4450000", Offset = "0x444EC00", VA = "0x184450000")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x564E200", Offset = "0x564CE00", VA = "0x18564E200", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x564DEB0", Offset = "0x564CAB0", VA = "0x18564DEB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x66127E0", Offset = "0x66113E0", VA = "0x1866127E0")]
	public BKHAJHPEHJB([In] IKJMDBCNGMN CBCNBAPLLJM, T1 GKOJHJMNOBO, T2 FJEKLKMGPHF, T3 NGIIFNLMLOP, T4 IDLODIHMCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6612490", Offset = "0x6611090", VA = "0x186612490")]
	private void OKHHHHKECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6612140", Offset = "0x6610D40", VA = "0x186612140")]
	public void FLFEFLMCKEL(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6611D80", Offset = "0x6610980", VA = "0x186611D80")]
	public void ALBDEGIFCDO(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, T3 MBLOLKPNMOC, T4 IHPDKKIPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6612250", Offset = "0x6610E50", VA = "0x186612250", Slot = "5")]
	private void HPEBFHBCDPA((T1, T2, T3, T4) DNDKHMOJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x564D9E0", Offset = "0x564C5E0", VA = "0x18564D9E0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AAAHGFJLMHA
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x824BD70", Offset = "0x824A970", VA = "0x18824BD70")]
	public static string APBHFKBHFOE(this IKJMDBCNGMN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xCE4D80", Offset = "0xCE3980", VA = "0x180CE4D80")]
	public static GIGBGNAJIDL PJBGGPPHFLE(this IKJMDBCNGMN CBCNBAPLLJM)
	{
		return default(GIGBGNAJIDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BHCLHBFEPMH<T> : GDKMFJOLOAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public BHCLHBFEPMH([In] IKJMDBCNGMN CBCNBAPLLJM, T PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6436580", Offset = "0x6435180", VA = "0x186436580")]
	public BHCLHBFEPMH(NJMPDLBKJDJ PBHLPKLGFAP, PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T PLEDLJICBFM, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6434190", Offset = "0x6432D90", VA = "0x186434190")]
	public BHCLHBFEPMH(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T PLEDLJICBFM, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6433DE0", Offset = "0x64329E0", VA = "0x186433DE0")]
	public BHCLHBFEPMH(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T PLEDLJICBFM, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AOJGJKDIAKM<T1, T2> : COFGFBBFIIB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5251AC0", Offset = "0x52506C0", VA = "0x185251AC0")]
	public AOJGJKDIAKM([In] IKJMDBCNGMN CBCNBAPLLJM, T1 IGDDMJMOOEO, T2 LKOKICPNEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5254E70", Offset = "0x5253A70", VA = "0x185254E70")]
	public AOJGJKDIAKM(NJMPDLBKJDJ PBHLPKLGFAP, PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5253A40", Offset = "0x5252640", VA = "0x185253A40")]
	public AOJGJKDIAKM(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5254260", Offset = "0x5252E60", VA = "0x185254260")]
	public AOJGJKDIAKM(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MADEBPGHNGL<T1, T2, T3> : HAIAMNDPKPA<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5647430", Offset = "0x5646030", VA = "0x185647430")]
	public MADEBPGHNGL([In] IKJMDBCNGMN CBCNBAPLLJM, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5647C40", Offset = "0x5646840", VA = "0x185647C40")]
	public MADEBPGHNGL(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AONMADEFOCP<T1, T2, T3, T4> : IIONEJMOMAJ<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5257570", Offset = "0x5256170", VA = "0x185257570")]
	public AONMADEFOCP([In] IKJMDBCNGMN CBCNBAPLLJM, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, T4 MODABBGIHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5256AE0", Offset = "0x52556E0", VA = "0x185256AE0")]
	public AONMADEFOCP(NJMPDLBKJDJ PBHLPKLGFAP, PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, T4 MODABBGIHIJ, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x52575E0", Offset = "0x52561E0", VA = "0x1852575E0")]
	public AONMADEFOCP(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, T4 MODABBGIHIJ, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KBODICMHJFN<T1, T2, T3, T4, T5> : EABDHMHMPEG<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5391ED0", Offset = "0x5390AD0", VA = "0x185391ED0")]
	public KBODICMHJFN(NJMPDLBKJDJ PBHLPKLGFAP, PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, T4 MODABBGIHIJ, T5 MIBFIPNNAPK, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5392340", Offset = "0x5390F40", VA = "0x185392340")]
	public KBODICMHJFN(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 IGDDMJMOOEO, T2 LKOKICPNEJO, T3 JGMEEKOEINA, T4 MODABBGIHIJ, T5 MIBFIPNNAPK, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PAMMMMFNDGH<T> : GDKMFJOLOAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x59B6D20", Offset = "0x59B5920", VA = "0x1859B6D20")]
	public PAMMMMFNDGH(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T PLEDLJICBFM, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AKNMLLPDAEE<T1, T2> : COFGFBBFIIB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x51832B0", Offset = "0x5181EB0", VA = "0x1851832B0")]
	public AKNMLLPDAEE(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, T1 POALADJDAND, T2 FKKKAJNOKPE, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KLGLINMOPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHCLHBFEPMH<T1> MJIKKJMCFIK<T1>(string DHCHBFGMFFD, T1 POALADJDAND, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NJMDKIODHIA : KLGLINMOPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly PMBFKFFPNEF BGPCGBJEPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NJMPDLBKJDJ PBHLPKLGFAP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
	public NJMDKIODHIA(PMBFKFFPNEF BGPCGBJEPBG, NJMPDLBKJDJ CMAJFFBJIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9770", Offset = "0x3DC8370", VA = "0x183DC9770", Slot = "4")]
	public BHCLHBFEPMH<T1> MJIKKJMCFIK<T1>(string DHCHBFGMFFD, T1 POALADJDAND, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JOCJMDNHGPE : NJMPDLBKJDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId AIGFCOAJIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NJMPDLBKJDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool AIHCABJGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool CDEKABIGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string CHGFHHJIEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool KDMGCBIPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(ODEODKBNNCJ NOMKKKJDNJF);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(ODEODKBNNCJ NOMKKKJDNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CFMPJJEMAPG
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x824BDB0", Offset = "0x824A9B0", VA = "0x18824BDB0")]
	public static bool OBNAHFICFEJ(this NJMPDLBKJDJ PBHLPKLGFAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PMBFKFFPNEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PLCCGHEKGIM ICOENGNGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool JNGMHBJLFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFHPBJMBKJO();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object CACFDGBPJEA(string DHCHBFGMFFD);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object CCNOHEPGBIE(PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FACKLLLOKEM(string DHCHBFGMFFD, object CBMDPCIEEMO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJGNJCIIBFO(PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD, object CBMDPCIEEMO);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGJOFFOHPFL<T>(string DHCHBFGMFFD, T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBGHBFLFADI([CanBeNull] PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DGFNIMHIOCM([CanBeNull] PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T DNNOJLPNMAJ<T>(object BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object BMBJLCHKAEE<T>(T PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JFIPKBHEBLK();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ADOLLLNOCJP();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GAKNKGIIIOB(string MKMPFLKICKK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IKJMDBCNGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public PLCCGHEKGIM FANAFCDPEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NJMPDLBKJDJ PBHLPKLGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string DHCHBFGMFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GIGBGNAJIDL BOGAGNBOLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool CEFLEJLPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action HFBNHPDLHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public PMBFKFFPNEF BGPCGBJEPBG;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x824D8E0", Offset = "0x824C4E0", VA = "0x18824D8E0")]
	public IKJMDBCNGMN(IKJMDBCNGMN IIOGPDPGOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x824D740", Offset = "0x824C340", VA = "0x18824D740")]
	public IKJMDBCNGMN(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x824D6F0", Offset = "0x824C2F0", VA = "0x18824D6F0")]
	public static IKJMDBCNGMN HEAKFDDJFMJ(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, GIGBGNAJIDL BOGAGNBOLIN, [Optional] Action HFBNHPDLHHL, [Optional] PMBFKFFPNEF BGPCGBJEPBG)
	{
		return default(IKJMDBCNGMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KIDFPEEIAJF
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF800", Offset = "0x3CFE400", VA = "0x183CFF800")]
	public static BHCLHBFEPMH<T> OOOFBAEEJBA<T>(this IKJMDBCNGMN CBCNBAPLLJM, T PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF6B0", Offset = "0x3CFE2B0", VA = "0x183CFF6B0")]
	public static AOJGJKDIAKM<T1, T2> OOOFBAEEJBA<T1, T2>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF750", Offset = "0x3CFE350", VA = "0x183CFF750")]
	public static MADEBPGHNGL<T1, T2, T3> OOOFBAEEJBA<T1, T2, T3>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI, T3 GNNHIHPBHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFAC0", Offset = "0x3CFE6C0", VA = "0x183CFFAC0")]
	public static AONMADEFOCP<T1, T2, T3, T4> OOOFBAEEJBA<T1, T2, T3, T4>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI, T3 GNNHIHPBHMC, T4 CKHFEJBBBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF800", Offset = "0x3CFE400", VA = "0x183CFF800")]
	public static MCHFFGOABPC<T> NDHENNHOPFL<T>(this IKJMDBCNGMN CBCNBAPLLJM, T PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF6B0", Offset = "0x3CFE2B0", VA = "0x183CFF6B0")]
	public static CPNKFPFCFHJ<T1, T2> NDHENNHOPFL<T1, T2>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF750", Offset = "0x3CFE350", VA = "0x183CFF750")]
	public static ONGPABBCDII<T1, T2, T3> NDHENNHOPFL<T1, T2, T3>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI, T3 GNNHIHPBHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFAC0", Offset = "0x3CFE6C0", VA = "0x183CFFAC0")]
	public static BKHAJHPEHJB<T1, T2, T3, T4> NDHENNHOPFL<T1, T2, T3, T4>(this IKJMDBCNGMN CBCNBAPLLJM, T1 PEFDGLICCAA, T2 CADLIOECPJI, T3 GNNHIHPBHMC, T4 CKHFEJBBBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class CMLFCJFEPEJ : ODEODKBNNCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum MKBCFJPIAAD
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
	private static Stack<PMBFKFFPNEF> HOADCGFFEHM;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool NDLKDALPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PLCCGHEKGIM FANAFCDPEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly NJMPDLBKJDJ PBHLPKLGFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string DHCHBFGMFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly GIGBGNAJIDL BOGAGNBOLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action HFBNHPDLHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected PMBFKFFPNEF ABNAAAJGNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private MKBCFJPIAAD HHPCFHFLKHA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static PMBFKFFPNEF DGIBPPAFGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x824CD80", Offset = "0x824B980", VA = "0x18824CD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool PPOBAAGGDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x824C510", Offset = "0x824B110", VA = "0x18824C510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x824D400", Offset = "0x824C000", VA = "0x18824D400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool KDNHIBCILIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x824CF60", Offset = "0x824BB60", VA = "0x18824CF60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x824BEB0", Offset = "0x824AAB0", VA = "0x18824BEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool JLIIBBOMDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x824C870", Offset = "0x824B470", VA = "0x18824C870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x824C150", Offset = "0x824AD50", VA = "0x18824C150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool ALJAHHMJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x824D080", Offset = "0x824BC80", VA = "0x18824D080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x824C8E0", Offset = "0x824B4E0", VA = "0x18824C8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA5A150", VA = "0x180A5B550", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool MMECPNMNBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x824BED0", Offset = "0x824AAD0", VA = "0x18824BED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int EGOPPPEGCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE4A4E0", Offset = "0xE490E0", VA = "0x180E4A4E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xF9C320", Offset = "0xF9AF20", VA = "0x180F9C320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string DICGCMOFCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x824CAE0", Offset = "0x824B6E0", VA = "0x18824CAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x824CB90", Offset = "0x824B790", VA = "0x18824CB90")]
	public static void HPIKKLCOOJD(PMBFKFFPNEF KBBAPBGONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AGMGAIBNKDN();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x824D4D0", Offset = "0x824C0D0", VA = "0x18824D4D0")]
	protected CMLFCJFEPEJ(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, GIGBGNAJIDL BOGAGNBOLIN, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x824C880", Offset = "0x824B480", VA = "0x18824C880", Slot = "1")]
	~CMLFCJFEPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x824C520", Offset = "0x824B120", VA = "0x18824C520", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x824D120", Offset = "0x824BD20", VA = "0x18824D120")]
	private void ONIOJAABJNE(bool CHBIILEDINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x824CDF0", Offset = "0x824B9F0", VA = "0x18824CDF0")]
	private object KOOMHLDPMJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x824BF20", Offset = "0x824AB20", VA = "0x18824BF20")]
	protected void BFHPBJMBKJO(bool CEFLEJLPFGF, object KNEHBEIIHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x824CC30", Offset = "0x824B830", VA = "0x18824CC30")]
	protected void IEFFBEILLPC(object CBMDPCIEEMO, bool PLLFMFFOMLM = true, bool AFCMBKMIDMH = false, bool GBGMMOGHNCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x824C170", Offset = "0x824AD70", VA = "0x18824C170")]
	protected void CIFAEGBPDJL(object CBMDPCIEEMO, bool LEDGCBHIHKO, bool PLLFMFFOMLM, bool AFCMBKMIDMH = false, bool GBGMMOGHNCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x824D090", Offset = "0x824BC90", VA = "0x18824D090")]
	internal void NHFBHENGOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x824CD20", Offset = "0x824B920", VA = "0x18824CD20")]
	private void JJAMAEDEFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x824CB30", Offset = "0x824B730", VA = "0x18824CB30")]
	private void HPAHELJFCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x824C0E0", Offset = "0x824ACE0", VA = "0x18824C0E0", Slot = "4")]
	private void BIJCHKNIEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x824CC70", Offset = "0x824B870", VA = "0x18824CC70", Slot = "5")]
	private void IFODCDMEJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x824C9A0", Offset = "0x824B5A0", VA = "0x18824C9A0")]
	public bool GCEMHAMAPDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x824C690", Offset = "0x824B290", VA = "0x18824C690")]
	public bool EFKHHFEKJOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x824C3C0", Offset = "0x824AFC0", VA = "0x18824C3C0")]
	private bool CJEFEANNAEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x824BE00", Offset = "0x824AA00", VA = "0x18824BE00")]
	internal void ALDKOIDDNCA(object CBMDPCIEEMO, int DAAIAALGBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x824CF70", Offset = "0x824BB70", VA = "0x18824CF70")]
	private void LGJPACECKIB(object CBMDPCIEEMO, bool AFCMBKMIDMH, bool GBGMMOGHNCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x824D110", Offset = "0x824BD10", VA = "0x18824D110")]
	private bool OEPAMIHDJGA(MKBCFJPIAAD KDCPEPKOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x824C850", Offset = "0x824B450", VA = "0x18824C850")]
	private void EKNKFLPHPBO(MKBCFJPIAAD KDCPEPKOEEE, bool BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x824CC80", Offset = "0x824B880", VA = "0x18824CC80")]
	public static string IJOCPDJBIFN(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x824D320", Offset = "0x824BF20", VA = "0x18824D320")]
	public static string PBMPLEOAIDF(NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x824D1C0", Offset = "0x824BDC0", VA = "0x18824D1C0")]
	public static bool ONLIMGCDAFC(object JPILOOHOBDJ, object MAKDDCFIOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KFGBOHKLOPE : PMBFKFFPNEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> EKLMMLNOIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> NFBLJHAHEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> GCAJFLPDBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> PAMGLEKIILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool KBLIMDOOPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> FGEJJEHPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<PLCCGHEKGIM, Dictionary<string, object>> GHOHLICENNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> MHFKNJHOAHK;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> GGDDJBHNLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int NFDIAFFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract PLCCGHEKGIM ICOENGNGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool LAJILHFCAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool JNGMHBJLFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool IPAEHMMJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE500", Offset = "0x3CFD100", VA = "0x183CFE500", Slot = "12")]
	public void GGJOFFOHPFL<T>(string DHCHBFGMFFD, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x824DCA0", Offset = "0x824C8A0", VA = "0x18824DCA0", Slot = "11")]
	public void CJGNJCIIBFO(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD, object BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x824DBA0", Offset = "0x824C7A0", VA = "0x18824DBA0", Slot = "9")]
	public object CCNOHEPGBIE(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x824E660", Offset = "0x824D260", VA = "0x18824E660", Slot = "10")]
	public void FACKLLLOKEM(string DHCHBFGMFFD, object BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x824DB00", Offset = "0x824C700", VA = "0x18824DB00", Slot = "8")]
	public object CACFDGBPJEA(string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x824FA10", Offset = "0x824E610", VA = "0x18824FA10", Slot = "13")]
	public void NBGHBFLFADI(PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x824DDF0", Offset = "0x824C9F0", VA = "0x18824DDF0", Slot = "14")]
	public void DGFNIMHIOCM(PLCCGHEKGIM EMBMBIOGHBN, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x824D960", Offset = "0x824C560", VA = "0x18824D960")]
	private void ABBCHMHLLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x824F930", Offset = "0x824E530", VA = "0x18824F930")]
	private void LJCMCBMAPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x824F560", Offset = "0x824E160", VA = "0x18824F560")]
	private void HHDFKMEAIMB(PLCCGHEKGIM FANAFCDPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x824FEA0", Offset = "0x824EAA0", VA = "0x18824FEA0")]
	protected void PKHMIDINFPO(PLCCGHEKGIM KJDJNKGGJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x824E570", Offset = "0x824D170", VA = "0x18824E570")]
	protected void EAJIGENMIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x824FFD0", Offset = "0x824EBD0", VA = "0x18824FFD0")]
	protected void PKMKIHCAPKA(IDictionary<object, object> KKHJPGAFCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x824DA90", Offset = "0x824C690", VA = "0x18824DA90")]
	protected void AGAPLGCJINN(PLCCGHEKGIM KFDOAKEPDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x824FB20", Offset = "0x824E720", VA = "0x18824FB20")]
	protected void OAJINOLMAND(PLCCGHEKGIM FANAFCDPEEP, IDictionary<object, object> KKHJPGAFCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x824EED0", Offset = "0x824DAD0", VA = "0x18824EED0")]
	private void GPFCPBHNMFJ(IDictionary<object, object> KKHJPGAFCKL, Dictionary<string, object> HICDOFLIEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x824F360", Offset = "0x824DF60", VA = "0x18824F360")]
	private static void GPOMAJAMEPL(object OIPDJFNPANE, object ABMJBIODBLM, int DAAIAALGBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x824FC80", Offset = "0x824E880", VA = "0x18824FC80")]
	private static void OGFMMPAHFPG(Dictionary<string, object> HICDOFLIEAB, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x824F5C0", Offset = "0x824E1C0", VA = "0x18824F5C0")]
	private static void HKIMEABHKFF(Dictionary<string, object> HICDOFLIEAB, string DHCHBFGMFFD, CMLFCJFEPEJ OJCGHFFCPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x824F830", Offset = "0x824E430", VA = "0x18824F830", Slot = "17")]
	public void JFIPKBHEBLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void BPNFNEEHJEL(Dictionary<object, object> EKLMMLNOIBB);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x824D9B0", Offset = "0x824C5B0", VA = "0x18824D9B0", Slot = "18")]
	public void ADOLLLNOCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void CPHOMLGEDFJ(Dictionary<object, object> GCAJFLPDBPF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x824E780", Offset = "0x824D380", VA = "0x18824E780")]
	private void FKPIAAABFAE(Dictionary<object, object> BDDBHGCPOCO, List<string> LNBCHMGJCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x824E9B0", Offset = "0x824D5B0", VA = "0x18824E9B0")]
	private void FPCADLIKGKO(IDictionary<object, object> KKHJPGAFCKL, [Out] int DAAIAALGBBK, [Out] string[] OIOIPJPHNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x824F980", Offset = "0x824E580", VA = "0x18824F980")]
	public void LPOCGEPOBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x824FBB0", Offset = "0x824E7B0", VA = "0x18824FBB0")]
	public void ODCDGOBMMNI(PLCCGHEKGIM FANAFCDPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x824E0A0", Offset = "0x824CCA0", VA = "0x18824E0A0")]
	public void DOIGAFMJBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> KGCFMFIODML(bool KJCAHELGMNK, bool LGDOJOHHLFJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x824EC40", Offset = "0x824D840", VA = "0x18824EC40", Slot = "19")]
	public void GAKNKGIIIOB(string MKMPFLKICKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x824F790", Offset = "0x824E390", VA = "0x18824F790")]
	protected string IJOCPDJBIFN(PLCCGHEKGIM FANAFCDPEEP, string DHCHBFGMFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object BMBJLCHKAEE<T>(T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T DNNOJLPNMAJ<T>(object BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "32")]
	public virtual void BFHPBJMBKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x824E410", Offset = "0x824D010", VA = "0x18824E410", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "33")]
	protected virtual void EPNKBHBJJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x824FFE0", Offset = "0x824EBE0", VA = "0x18824FFE0")]
	protected KFGBOHKLOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GDKMFJOLOAD<T1> : CMLFCJFEPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 POALADJDAND;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 FHADKEMDMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x120C3E0", Offset = "0x120AFE0", VA = "0x18120C3E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x120C400", Offset = "0x120B000", VA = "0x18120C400", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4E85810", Offset = "0x4E84410", VA = "0x184E85810", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4E843F0", Offset = "0x4E82FF0", VA = "0x184E843F0", Slot = "9")]
	protected override bool AGMGAIBNKDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4E88FD0", Offset = "0x4E87BD0", VA = "0x184E88FD0")]
	protected GDKMFJOLOAD([In] IKJMDBCNGMN CBCNBAPLLJM, T1 POALADJDAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E89130", Offset = "0x4E87D30", VA = "0x184E89130")]
	protected GDKMFJOLOAD(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 POALADJDAND, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
	public T1 LGFPFICEOKK()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4E864A0", Offset = "0x4E850A0", VA = "0x184E864A0")]
	public void IEFFBEILLPC(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E86B10", Offset = "0x4E85710", VA = "0x184E86B10")]
	public void IEFFBEILLPC(T1 CBMDPCIEEMO, bool PLLFMFFOMLM, bool AFCMBKMIDMH = false, bool GBGMMOGHNCH = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class COFGFBBFIIB<T1, T2> : CMLFCJFEPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 POALADJDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 FKKKAJNOKPE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 FHADKEMDMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xFEA940", Offset = "0xFE9540", VA = "0x180FEA940", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x120C3F0", Offset = "0x120AFF0", VA = "0x18120C3F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 FOENPLDMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xFE4D90", Offset = "0xFE3990", VA = "0x180FE4D90", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xFE9200", Offset = "0xFE7E00", VA = "0x180FE9200", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 GGFHANDGHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x48C0FE0", Offset = "0x48BFBE0", VA = "0x1848C0FE0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E100", Offset = "0x6C4CD00", VA = "0x186C4E100", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B770", Offset = "0x6C4A370", VA = "0x186C4B770", Slot = "9")]
	protected override bool AGMGAIBNKDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6C54890", Offset = "0x6C53490", VA = "0x186C54890")]
	protected COFGFBBFIIB([In] IKJMDBCNGMN CBCNBAPLLJM, T1 POALADJDAND, T2 FKKKAJNOKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6C550D0", Offset = "0x6C53CD0", VA = "0x186C550D0")]
	protected COFGFBBFIIB(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 POALADJDAND, T2 FKKKAJNOKPE, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
	public T1 HBHLOLAFEFN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CEB0", Offset = "0x6C4BAB0", VA = "0x186C4CEB0")]
	public void BNLNAJFCGHO(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x48C0FE0", Offset = "0x48BFBE0", VA = "0x1848C0FE0")]
	public T2 CNMCCMHLCLM()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ED20", Offset = "0x6C4D920", VA = "0x186C4ED20")]
	public void HJLNBEIPHBH(T2 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C52870", Offset = "0x6C51470", VA = "0x186C52870")]
	public void IEFFBEILLPC(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, bool PLLFMFFOMLM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class HAIAMNDPKPA<T1, T2, T3> : CMLFCJFEPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 POALADJDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 FKKKAJNOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 CGKFGLLGHLH;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 FHADKEMDMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA5B630", Offset = "0xA5A230", VA = "0x180A5B630", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA5B450", Offset = "0xA5A050", VA = "0x180A5B450", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 FOENPLDMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1024D40", Offset = "0x1023940", VA = "0x181024D40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1023BA0", Offset = "0x10227A0", VA = "0x181023BA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 DDAOPIFCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA77820", Offset = "0xA76420", VA = "0x180A77820", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xDA9690", Offset = "0xDA8290", VA = "0x180DA9690", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 ECAFJAOKFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 GGFHANDGHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x48C0FE0", Offset = "0x48BFBE0", VA = "0x1848C0FE0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 DDFCIILDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x48C40E0", Offset = "0x48C2CE0", VA = "0x1848C40E0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4F58EF0", Offset = "0x4F57AF0", VA = "0x184F58EF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4F57AF0", Offset = "0x4F566F0", VA = "0x184F57AF0", Slot = "9")]
	protected override bool AGMGAIBNKDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4F5C9F0", Offset = "0x4F5B5F0", VA = "0x184F5C9F0")]
	protected HAIAMNDPKPA([In] IKJMDBCNGMN CBCNBAPLLJM, T1 POALADJDAND, T2 FKKKAJNOKPE, T3 CGKFGLLGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4F5C1F0", Offset = "0x4F5ADF0", VA = "0x184F5C1F0")]
	protected HAIAMNDPKPA(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 POALADJDAND, T2 FKKKAJNOKPE, T3 CGKFGLLGHLH, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
	public T1 HBHLOLAFEFN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4F586A0", Offset = "0x4F572A0", VA = "0x184F586A0")]
	public void BNLNAJFCGHO(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x48C0FE0", Offset = "0x48BFBE0", VA = "0x1848C0FE0")]
	public T2 CNMCCMHLCLM()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4F59C50", Offset = "0x4F58850", VA = "0x184F59C50")]
	public void HJLNBEIPHBH(T2 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x48C40E0", Offset = "0x48C2CE0", VA = "0x1848C40E0")]
	public T3 MEEOEDOIEBH()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4F59590", Offset = "0x4F58190", VA = "0x184F59590")]
	public void COGIIHAAFOO(T3 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A4F0", Offset = "0x4F590F0", VA = "0x184F5A4F0")]
	public void IEFFBEILLPC(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, T3 MBLOLKPNMOC, bool PLLFMFFOMLM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class IIONEJMOMAJ<T1, T2, T3, T4> : CMLFCJFEPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 POALADJDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 FKKKAJNOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 CGKFGLLGHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 BAIDFMNEJLG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 FHADKEMDMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xF015E0", Offset = "0xF001E0", VA = "0x180F015E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xFF25F0", Offset = "0xFF11F0", VA = "0x180FF25F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 FOENPLDMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3D00", Offset = "0x1EB2900", VA = "0x181EB3D00", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x48C14D0", Offset = "0x48C00D0", VA = "0x1848C14D0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 DDAOPIFCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5081430", Offset = "0x5080030", VA = "0x185081430", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x507B140", Offset = "0x5079D40", VA = "0x18507B140", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 NKNMNKGIBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x15EBD10", Offset = "0x15EA910", VA = "0x1815EBD10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x156F360", Offset = "0x156DF60", VA = "0x18156F360", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 GGFHANDGHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x48C1000", Offset = "0x48BFC00", VA = "0x1848C1000")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 DDFCIILDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4F598A0", Offset = "0x4F584A0", VA = "0x184F598A0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 LIHAMBMBJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2011230", Offset = "0x200FE30", VA = "0x182011230")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x507BE60", Offset = "0x507AA60", VA = "0x18507BE60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5079D10", Offset = "0x5078910", VA = "0x185079D10", Slot = "9")]
	protected override bool AGMGAIBNKDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5083140", Offset = "0x5081D40", VA = "0x185083140")]
	protected IIONEJMOMAJ([In] IKJMDBCNGMN CBCNBAPLLJM, T1 POALADJDAND, T2 FKKKAJNOKPE, T3 CGKFGLLGHLH, T4 BAIDFMNEJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x50825B0", Offset = "0x50811B0", VA = "0x1850825B0")]
	protected IIONEJMOMAJ(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 POALADJDAND, T2 FKKKAJNOKPE, T3 CGKFGLLGHLH, T4 BAIDFMNEJLG, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
	public T1 HBHLOLAFEFN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x507B2D0", Offset = "0x5079ED0", VA = "0x18507B2D0")]
	public void BNLNAJFCGHO(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x48C1000", Offset = "0x48BFC00", VA = "0x1848C1000")]
	public T2 CNMCCMHLCLM()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x507E270", Offset = "0x507CE70", VA = "0x18507E270")]
	public void HJLNBEIPHBH(T2 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4F598A0", Offset = "0x4F584A0", VA = "0x184F598A0")]
	public T3 MEEOEDOIEBH()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x507D1F0", Offset = "0x507BDF0", VA = "0x18507D1F0")]
	public void COGIIHAAFOO(T3 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2011230", Offset = "0x200FE30", VA = "0x182011230")]
	public T4 JHMBAHGJDAN()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x507D830", Offset = "0x507C430", VA = "0x18507D830")]
	public void FHMCHJCAJIP(T4 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x507FDD0", Offset = "0x507E9D0", VA = "0x18507FDD0")]
	public void IEFFBEILLPC(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, T3 MBLOLKPNMOC, T4 IHPDKKIPIOD, bool PLLFMFFOMLM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class EABDHMHMPEG<T1, T2, T3, T4, T5> : CMLFCJFEPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 POALADJDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 FKKKAJNOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 CGKFGLLGHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 BAIDFMNEJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 EHPOODBPNHL;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 FHADKEMDMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xACDD50", Offset = "0xACC950", VA = "0x180ACDD50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xACDD30", Offset = "0xACC930", VA = "0x180ACDD30", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 FOENPLDMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1527EC0", Offset = "0x1526AC0", VA = "0x181527EC0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1526FA0", Offset = "0x1525BA0", VA = "0x181526FA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 DDAOPIFCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA77820", Offset = "0xA76420", VA = "0x180A77820", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xDA9690", Offset = "0xDA8290", VA = "0x180DA9690", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 NKNMNKGIBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA944F0", Offset = "0xA930F0", VA = "0x180A944F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA94550", Offset = "0xA93150", VA = "0x180A94550", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 HIKOGNGECCH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x17330E0", Offset = "0x1731CE0", VA = "0x1817330E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x17344E0", Offset = "0x17330E0", VA = "0x1817344E0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object GFFLPNHOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x48C0DE0", Offset = "0x48BF9E0", VA = "0x1848C0DE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x48BFA70", Offset = "0x48BE670", VA = "0x1848BFA70", Slot = "9")]
	protected override bool AGMGAIBNKDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x48C44B0", Offset = "0x48C30B0", VA = "0x1848C44B0")]
	protected EABDHMHMPEG(PLCCGHEKGIM FANAFCDPEEP, NJMPDLBKJDJ PBHLPKLGFAP, string DHCHBFGMFFD, T1 POALADJDAND, T2 FKKKAJNOKPE, T3 CGKFGLLGHLH, T4 BAIDFMNEJLG, T5 EHPOODBPNHL, GIGBGNAJIDL BOGAGNBOLIN, bool CEFLEJLPFGF, Action HFBNHPDLHHL, PMBFKFFPNEF BGPCGBJEPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x48C1990", Offset = "0x48C0590", VA = "0x1848C1990")]
	public T1 HBHLOLAFEFN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x48C02F0", Offset = "0x48BEEF0", VA = "0x1848C02F0")]
	public void BNLNAJFCGHO(T1 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x48C0FE0", Offset = "0x48BFBE0", VA = "0x1848C0FE0")]
	public T2 CNMCCMHLCLM()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x48C1A80", Offset = "0x48C0680", VA = "0x1848C1A80")]
	public void HJLNBEIPHBH(T2 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x48C40E0", Offset = "0x48C2CE0", VA = "0x1848C40E0")]
	public T3 MEEOEDOIEBH()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x48C13F0", Offset = "0x48BFFF0", VA = "0x1848C13F0")]
	public void COGIIHAAFOO(T3 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2011230", Offset = "0x200FE30", VA = "0x182011230")]
	public T4 JHMBAHGJDAN()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x48C1510", Offset = "0x48C0110", VA = "0x1848C1510")]
	public void FHMCHJCAJIP(T4 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x48C14F0", Offset = "0x48C00F0", VA = "0x1848C14F0")]
	public T5 EPJKCGBFLOD()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x48C3C60", Offset = "0x48C2860", VA = "0x1848C3C60")]
	public void LKKGMBLGCIO(T5 CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x48C24E0", Offset = "0x48C10E0", VA = "0x1848C24E0")]
	public void IEFFBEILLPC(T1 JMCJKEHHFGM, T2 EMPCNBGMBNJ, T3 MBLOLKPNMOC, T4 IHPDKKIPIOD, T5 HGMBMDKOOAM)
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
