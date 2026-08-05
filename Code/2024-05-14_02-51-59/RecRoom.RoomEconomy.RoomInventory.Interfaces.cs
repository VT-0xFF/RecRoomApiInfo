using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DOKCGLNCDHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PJDBBKDDLAO BFKFHPNHJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long IAGPAHCAHED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NLKJIMKICBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x692F8B0", Offset = "0x692E2B0", VA = "0x18692F8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x692F8C0", Offset = "0x692E2C0", VA = "0x18692F8C0")]
	public DOKCGLNCDHL(PJDBBKDDLAO LKBGEIGOHEF, long GBACAOOHJGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LPGEFMIHCGB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NOFPECFHNGP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KMHDPFOFGLH ANIADGACDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OIEIPJOEPJM<MKOHHGEECOI> FHEICOPIOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OIEIPJOEPJM<Guid> GKKICBNNFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EHCOJMJAODL<KOAGHNHGIFH, int> FKPHIHKEOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OIEIPJOEPJM<NIIHICOAOFH> BPJHFCPHAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OIEIPJOEPJM<long> IHGECOGOGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KMHDPFOFGLH HDPJEGNPBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<LGGHGMLBJFM<MKOHHGEECOI, string>> OHJAGPOAHML(long ECEDKLNOLLD, string GKDOOPOCBPP, string PIHIABBFEIL, string IOCPFJDOGIJ, RoomInventoryItemProperties FFPIOIIOFIN, byte HCLPPDPEFHM, int GLALCIBBONF, [Optional] List<long> KJABCIBMDHD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<LGGHGMLBJFM<MKOHHGEECOI, string>> JIIDNFBPECN(Guid HAKOFNAKJIO, [Optional] string GKDOOPOCBPP, [Optional] string PIHIABBFEIL, [Optional] string IOCPFJDOGIJ, [Optional] List<long> KJABCIBMDHD, [Optional] RoomInventoryItemProperties FFPIOIIOFIN, [Optional] byte? HCLPPDPEFHM, [Optional] int? GLALCIBBONF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<LGGHGMLBJFM<bool, string>> LHPEMOEDHMF(Guid HAKOFNAKJIO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<MKOHHGEECOI> FFFLHNLBANN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<MKOHHGEECOI> JCEDKIFNAJM();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool BMBPFJMAFJC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool OHDJGOPBIOC(Guid HAKOFNAKJIO, [Out] MKOHHGEECOI DNKCKAHJJKD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AGFNMJFNICD(string BDFNIHHHAJA, [Out] MKOHHGEECOI DNKCKAHJJKD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<KOAGHNHGIFH> DPAFMEJLMIF();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool AJDJGLKHIMJ(Guid HAKOFNAKJIO, [Out] KOAGHNHGIFH NEBBNNHLDNI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	long? GCAHLKCDBHE(Guid HAKOFNAKJIO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<int> JMONPMDAABG(HOPBKANDJCK NHKDHOFEECH, Guid HAKOFNAKJIO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<DOKCGLNCDHL> OJBLKLIFPKH(HOPBKANDJCK NHKDHOFEECH, Guid HAKOFNAKJIO, int BKJKKPLNCEK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	string CEOBHEMJHKF(PJDBBKDDLAO LKBGEIGOHEF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool JIILEPFCPJE();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<LGGHGMLBJFM<NIIHICOAOFH, string>> LOCIPBAOCAL(long ECEDKLNOLLD, string GKDOOPOCBPP, RoomInventoryTagClientProperties FFPIOIIOFIN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool LNIJPNGMHGN(long JDFBKOJINAE, [Out] NIIHICOAOFH NFKPOGGDDOH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ONLNGOBEGCC : NOFPECFHNGP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHAPMAMPHHA(IEnumerable<KIBOPOMHAGG> MFOIMJDLJBN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KNJINHPBCEC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KOAGHNHGIFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid MIHEPDGDNCK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x692FD40", Offset = "0x692E740", VA = "0x18692FD40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NLKJIMKICBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x692FF40", Offset = "0x692E940", VA = "0x18692FF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long DIAHEILEEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C99E0", Offset = "0x7C83E0", VA = "0x1807C99E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long CDPIGIJADNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5510", Offset = "0x7C3F10", VA = "0x1807C5510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? PFJGEKDJGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8760", Offset = "0x7C7160", VA = "0x1807C8760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C87A0", Offset = "0x7C71A0", VA = "0x1807C87A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FIGKCJMDJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2D40", Offset = "0x8E1740", VA = "0x1808E2D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD3BA40", Offset = "0xD3A440", VA = "0x180D3BA40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x692FF60", Offset = "0x692E960", VA = "0x18692FF60")]
	public KOAGHNHGIFH(KIBOPOMHAGG BLABPMDCGNK, bool GHBEGNJNLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1C25140", Offset = "0x1C23B40", VA = "0x181C25140")]
	public KOAGHNHGIFH(Guid HAKOFNAKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x692FD50", Offset = "0x692E750", VA = "0x18692FD50")]
	internal bool JACDOJBEGNB(KIBOPOMHAGG BLABPMDCGNK, long DAMOLFICEHA, Action<KOAGHNHGIFH, int> IBCHDEMHDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x692FCE0", Offset = "0x692E6E0", VA = "0x18692FCE0")]
	internal void CDDBIHCKJAI(long BDEFBKHIDGO, Action<KOAGHNHGIFH, int> IBCHDEMHDPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MKOHHGEECOI : IEquatable<MKOHHGEECOI>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OFOFAEEENAE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int ALCNOCHGNFO = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int AAPABBIBACG = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int MJEAPEIHMEE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int BLLBFCKNPIB = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid MIHEPDGDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA0", Offset = "0x85A9A0", VA = "0x18085BFA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB0", Offset = "0x85A9B0", VA = "0x18085BFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long FIADJEADKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xF407B0", Offset = "0xF3F1B0", VA = "0x180F407B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NJKCIHKELJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ABMHHDPIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C00", Offset = "0x7C8600", VA = "0x1807C9C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime HDLNAECMPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1B19980", Offset = "0x1B18380", VA = "0x181B19980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime AKBNDNNMBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x57AB620", Offset = "0x57AA020", VA = "0x1857AB620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> GPKALDAGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C6950", Offset = "0x7C5350", VA = "0x1807C6950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties JHBAEFHLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C6930", Offset = "0x7C5330", VA = "0x1807C6930")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C6910", Offset = "0x7C5310", VA = "0x1807C6910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte OFPNOANLDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B00", Offset = "0x7C8500", VA = "0x1807C9B00")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A00", Offset = "0x7C8400", VA = "0x1807C9A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GLILLNDJLFB LLKBDMEOKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD4F4C0", Offset = "0xD4DEC0", VA = "0x180D4F4C0")]
		[CompilerGenerated]
		get
		{
			return default(GLILLNDJLFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD4DDB0", Offset = "0xD4C7B0", VA = "0x180D4DDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6930740", Offset = "0x692F140", VA = "0x186930740")]
	public MKOHHGEECOI(LGMHAEDJHFL BLABPMDCGNK, [Optional] RoomInventoryItemProperties FFPIOIIOFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69301F0", Offset = "0x692EBF0", VA = "0x1869301F0", Slot = "4")]
	public bool Equals(MKOHHGEECOI HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6930010", Offset = "0x692EA10", VA = "0x186930010", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6930370", Offset = "0x692ED70", VA = "0x186930370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6930450", Offset = "0x692EE50", VA = "0x186930450")]
	private HashSet<long> LGEONJJLCFM(LGMHAEDJHFL BLABPMDCGNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class HCKLBFJJHNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KOAGHNHGIFH NEBBNNHLDNI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MKOHHGEECOI NAOHKDCCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KOAGHNHGIFH ILPJICEPLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x692F900", Offset = "0x692E300", VA = "0x18692F900")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x692F990", Offset = "0x692E390", VA = "0x18692F990")]
	public HCKLBFJJHNE(MKOHHGEECOI DNKCKAHJJKD, [Optional] KOAGHNHGIFH NEBBNNHLDNI)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6930C20", Offset = "0x692F620", VA = "0x186930C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7C8780", Offset = "0x7C7180", VA = "0x1807C8780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9CC5D0", Offset = "0x9CAFD0", VA = "0x1809CC5D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9CC5E0", Offset = "0x9CAFE0", VA = "0x1809CC5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public LPGEFMIHCGB Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
			[CompilerGenerated]
			get
			{
				return default(LPGEFMIHCGB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7CC6F0", Offset = "0x7CB0F0", VA = "0x1807CC6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB9CE20", Offset = "0xB9B820", VA = "0x180B9CE20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x40A9710", Offset = "0x40A8110", VA = "0x1840A9710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9184F0", Offset = "0x916EF0", VA = "0x1809184F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA0DBE0", Offset = "0xA0C5E0", VA = "0x180A0DBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69309A0", Offset = "0x692F3A0", VA = "0x1869309A0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6930A20", Offset = "0x692F420", VA = "0x186930A20")]
		public static RoomInventoryItemProperties JCNCJJKPAFA(RoomInventoryItemProperties FFPIOIIOFIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6930BC0", Offset = "0x692F5C0", VA = "0x186930BC0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NIIHICOAOFH
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const int BLMIGBBLJAE = 10;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LAGBIEKBMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x13A19C0", Offset = "0x13A03C0", VA = "0x1813A19C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public RoomInventoryTagClientProperties JHBAEFHLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DEGKJINIHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69308A0", Offset = "0x692F2A0", VA = "0x1869308A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69308C0", Offset = "0x692F2C0", VA = "0x1869308C0")]
	public NIIHICOAOFH(DLPOOOAIMDI BLABPMDCGNK, [Optional] RoomInventoryTagClientProperties FFPIOIIOFIN)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6930E70", Offset = "0x692F870", VA = "0x186930E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C8780", Offset = "0x7C7180", VA = "0x1807C8780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6930C70", Offset = "0x692F670", VA = "0x186930C70")]
		public void HPLJBKOFGBH(Dictionary<string, object> OONPBOKJNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
namespace Cpp2IlInjected
{
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
}
