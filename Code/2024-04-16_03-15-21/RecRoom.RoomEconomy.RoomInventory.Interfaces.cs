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
public class NDFDOAOPMCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PHDCLDHNIAK BNDDHIDLONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long GIHIJMKOGEP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BAIAOFFDMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6715150", Offset = "0x6714350", VA = "0x186715150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6715160", Offset = "0x6714360", VA = "0x186715160")]
	public NDFDOAOPMCH(PHDCLDHNIAK IFJGEIAONPI, long KMJOEPJMADC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MODCPCEKAKI
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
public interface KJHEKCBLHKL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DPAIEAIPOBP FFEGINJLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CNGIJFFLIEN<PHEEBFLEMOP> PNLIAFFHAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CNGIJFFLIEN<Guid> NLDODFLNHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DOEOOCEHEOD<BBBKHENCOKA, int> DKKOHDOLGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CNGIJFFLIEN<OBKGPHGNKMP> KNHLCENPMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CNGIJFFLIEN<long> ONCOADLENNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DPAIEAIPOBP DNEMOHKANKH
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
	Task<OAAHAKNOJDO<PHEEBFLEMOP, string>> EFJOGDDHAAB(long AFFIJANPBLG, string MPENHPFDCDK, string IFOILHPJELE, string MCJHBJKBBPP, RoomInventoryItemProperties MABGPNCPILM, byte NKFGLIJJHIJ, int CMIODFEAKCF, [Optional] List<long> LIGHMANKLMC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OAAHAKNOJDO<PHEEBFLEMOP, string>> AIDCMEGDLMH(Guid FDDJOMADHLB, [Optional] string MPENHPFDCDK, [Optional] string IFOILHPJELE, [Optional] string MCJHBJKBBPP, [Optional] List<long> LIGHMANKLMC, [Optional] RoomInventoryItemProperties MABGPNCPILM, [Optional] byte? NKFGLIJJHIJ, [Optional] int? CMIODFEAKCF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<OAAHAKNOJDO<bool, string>> PHADFNEGIFA(Guid FDDJOMADHLB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<PHEEBFLEMOP> OLMBMFJHGPB();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<PHEEBFLEMOP> CJCLHOKMDBP();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DIBAGEEEHCP();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool JCGAKBBDDDC(Guid FDDJOMADHLB, [Out] PHEEBFLEMOP BOAHKKDIHCO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AHGCFOILAGF(string KEGINLJHKJJ, [Out] PHEEBFLEMOP BOAHKKDIHCO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<BBBKHENCOKA> AILOCNDFKNJ();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool MDGOBKHEFFE(Guid FDDJOMADHLB, [Out] BBBKHENCOKA JEGDPNEAFHE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	long? GAOIEHBILBJ(Guid FDDJOMADHLB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<int> FDLFPHECAPN(HIKDHAMGKKP CNFKLDMHALN, Guid FDDJOMADHLB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<NDFDOAOPMCH> KLLCOFKLLOG(HIKDHAMGKKP CNFKLDMHALN, Guid FDDJOMADHLB, int PBDMEIFOAHD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	string IDJLFNOJGML(PHDCLDHNIAK IFJGEIAONPI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool LFGJJFLFJAG();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<OAAHAKNOJDO<OBKGPHGNKMP, string>> OPKOBCFGNCE(long AFFIJANPBLG, string MPENHPFDCDK, RoomInventoryTagClientProperties MABGPNCPILM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool BGLHLMOABCF(long KKLKGIBLBFN, [Out] OBKGPHGNKMP BNADPJGLCFH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGABDHLIIDD : KJHEKCBLHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBFBJGKPLJK(IEnumerable<NONKNJMDEDG> ELJKFFFPKOA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MGGADAMDFMA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BBBKHENCOKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid EKKKAOBIDOK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6714A50", Offset = "0x6713C50", VA = "0x186714A50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BAIAOFFDMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6714A60", Offset = "0x6713C60", VA = "0x186714A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long HNAGDFJNDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B7510", Offset = "0x7B6710", VA = "0x1807B7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long BDAKIHMPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF630", Offset = "0x7BE830", VA = "0x1807BF630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? FBJCDIIKHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5E0", Offset = "0x7BD7E0", VA = "0x1807BE5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE600", Offset = "0x7BD800", VA = "0x1807BE600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CHGLAFEKINC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6560", Offset = "0x8C5760", VA = "0x1808C6560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD10880", Offset = "0xD0FA80", VA = "0x180D10880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6714CD0", Offset = "0x6713ED0", VA = "0x186714CD0")]
	public BBBKHENCOKA(NONKNJMDEDG GBGDAJDFODD, bool HPBCKCCIFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B9FB50", Offset = "0x1B9ED50", VA = "0x181B9FB50")]
	public BBBKHENCOKA(Guid FDDJOMADHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6714AE0", Offset = "0x6713CE0", VA = "0x186714AE0")]
	internal bool MOLHGBBEJOJ(NONKNJMDEDG GBGDAJDFODD, long GCOMOHKHKJL, Action<BBBKHENCOKA, int> ANPFEJDCAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6714A80", Offset = "0x6713C80", VA = "0x186714A80")]
	internal void HILEOANCEMF(long BCLEPHMONPL, Action<BBBKHENCOKA, int> ANPFEJDCAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PHEEBFLEMOP : IEquatable<PHEEBFLEMOP>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int KFFNMGFJJHM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int KABEHLMLFLA = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int BDHKGPFKDMK = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int NOCKLKHPDPH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int LOHFEMHEGBF = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid EKKKAOBIDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x854310", Offset = "0x853510", VA = "0x180854310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long LBNIJAICHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xEC9920", Offset = "0xEC8B20", VA = "0x180EC9920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KDOFONMEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string IPDHIDHCLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime KMOEDLPBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2B40", Offset = "0x1AB1D40", VA = "0x181AB2B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime DLOBDLEDFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6E00", Offset = "0x1AD6000", VA = "0x181AD6E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> JCLIADCIDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF60", Offset = "0x7BB160", VA = "0x1807BBF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF40", Offset = "0x7BB140", VA = "0x1807BBF40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties FCLIHNICCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF70", Offset = "0x7BB170", VA = "0x1807BBF70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF20", Offset = "0x7BB120", VA = "0x1807BBF20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte KPJHNIKCOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FD0", Offset = "0x7C11D0", VA = "0x1807C1FD0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C20D0", Offset = "0x7C12D0", VA = "0x1807C20D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LJFEFAMPPFH BGOBLBNPHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD20B80", Offset = "0xD1FD80", VA = "0x180D20B80")]
		[CompilerGenerated]
		get
		{
			return default(LJFEFAMPPFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD1F850", Offset = "0xD1EA50", VA = "0x180D1F850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67159C0", Offset = "0x6714BC0", VA = "0x1867159C0")]
	public PHEEBFLEMOP(HOJNOKJDGFB GBGDAJDFODD, [Optional] RoomInventoryItemProperties MABGPNCPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6715470", Offset = "0x6714670", VA = "0x186715470", Slot = "4")]
	public bool Equals(PHEEBFLEMOP MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67152A0", Offset = "0x67144A0", VA = "0x1867152A0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67155F0", Offset = "0x67147F0", VA = "0x1867155F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67156D0", Offset = "0x67148D0", VA = "0x1867156D0")]
	private HashSet<long> MAKKDCDPCEP(HOJNOKJDGFB GBGDAJDFODD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NCKDOLNBJCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BBBKHENCOKA JEGDPNEAFHE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PHEEBFLEMOP KIFJEFIFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BBBKHENCOKA BJNJIELPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6714D80", Offset = "0x6713F80", VA = "0x186714D80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6714E10", Offset = "0x6714010", VA = "0x186714E10")]
	public NCKDOLNBJCP(PHEEBFLEMOP BOAHKKDIHCO, [Optional] BBBKHENCOKA JEGDPNEAFHE)
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
			[Cpp2IlInjected.Address(RVA = "0x6715DA0", Offset = "0x6714FA0", VA = "0x186715DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B7E20", Offset = "0x9B7020", VA = "0x1809B7E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B7E30", Offset = "0x9B7030", VA = "0x1809B7E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public MODCPCEKAKI Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
			[CompilerGenerated]
			get
			{
				return default(MODCPCEKAKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8870", VA = "0x1807B9670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB72710", Offset = "0xB71910", VA = "0x180B72710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3F78AB0", Offset = "0x3F77CB0", VA = "0x183F78AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9EA2D0", Offset = "0x9E94D0", VA = "0x1809EA2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6715B20", Offset = "0x6714D20", VA = "0x186715B20", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6715BA0", Offset = "0x6714DA0", VA = "0x186715BA0")]
		public static RoomInventoryItemProperties OALMEMACFAC(RoomInventoryItemProperties MABGPNCPILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6715D40", Offset = "0x6714F40", VA = "0x186715D40")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OBKGPHGNKMP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const int NNIPBKKNEAF = 10;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KHMGJKHBIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public RoomInventoryTagClientProperties FCLIHNICCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool APIMMIEKBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67151A0", Offset = "0x67143A0", VA = "0x1867151A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67151C0", Offset = "0x67143C0", VA = "0x1867151C0")]
	public OBKGPHGNKMP(EIALPBJCAHK GBGDAJDFODD, [Optional] RoomInventoryTagClientProperties MABGPNCPILM)
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
			[Cpp2IlInjected.Address(RVA = "0x6715FF0", Offset = "0x67151F0", VA = "0x186715FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6715DF0", Offset = "0x6714FF0", VA = "0x186715DF0")]
		public void GEDHMKGCDKN(Dictionary<string, object> KCFAOHEBNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
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
