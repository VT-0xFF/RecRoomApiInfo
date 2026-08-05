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
public class LNHOCGNPMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly HLFFJBNMPNJ GGIDPGJHPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long BLPIMLOHMJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CEDKKGKHIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6802040", Offset = "0x6800E40", VA = "0x186802040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6802050", Offset = "0x6800E50", VA = "0x186802050")]
	public LNHOCGNPMGD(HLFFJBNMPNJ FJMMLPMLLGC, long NJKDAMEBDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PDJPILNIIKI
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
public interface JAKCPBJNMID
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BFNGIAHHPKE ABFGPMNCENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BFFNIPDAHMM<JONOHLIDAOC> OFIAEPMEKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BFFNIPDAHMM<Guid> KKJGLEIFHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OCLIPKLKFLJ<GIEHLGCKPAL, int> FOBPENAJNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BFFNIPDAHMM<GFJHBNAEMKM> CMBOMDIEMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BFFNIPDAHMM<long> JBFAKPNJOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BFNGIAHHPKE PCJFMJGNIEH
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
	Task<PJPNKGNAEHO<JONOHLIDAOC, string>> KHJIHOBOILA(long EKMDOMOGGBC, string PHEKPMAPPHM, string HCNOEAOOGOH, string KLNOGIDHBHP, RoomInventoryItemProperties BLGIDAACNMF, byte IFADPKPOCOM, int BGJPICBMDGJ, [Optional] List<long> JFFOLOJFADH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<PJPNKGNAEHO<JONOHLIDAOC, string>> DEHBEMOEOLJ(Guid CGAGMCMIEJB, [Optional] string PHEKPMAPPHM, [Optional] string HCNOEAOOGOH, [Optional] string KLNOGIDHBHP, [Optional] List<long> JFFOLOJFADH, [Optional] RoomInventoryItemProperties BLGIDAACNMF, [Optional] byte? IFADPKPOCOM, [Optional] int? BGJPICBMDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PJPNKGNAEHO<bool, string>> BLLPJFNNHFG(Guid CGAGMCMIEJB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<JONOHLIDAOC> LGAADPNNOID();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<JONOHLIDAOC> PNKKMNABAMK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool BDPDNJKAEKD();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool GMHMCPNDBFG(Guid CGAGMCMIEJB, [Out] JONOHLIDAOC HJJJHCPLCFI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool IOEFHKBCCKG(string JLOBNDOAPNE, [Out] JONOHLIDAOC HJJJHCPLCFI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<GIEHLGCKPAL> DKEPMHFNLKM();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool FMEJOHCDBKH(Guid CGAGMCMIEJB, [Out] GIEHLGCKPAL JAKCCAIPIMG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	long? DFGBDMLCEFK(Guid CGAGMCMIEJB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<int> DCAAGIDDLIO(CMFDBPHCNJN HKNKALEJLDA, Guid CGAGMCMIEJB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<LNHOCGNPMGD> HBLIMCDHGML(CMFDBPHCNJN HKNKALEJLDA, Guid CGAGMCMIEJB, int KMDAINAHNDF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	string IJGLNIDHNIJ(HLFFJBNMPNJ FJMMLPMLLGC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool EEHLCCOIKOK();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<PJPNKGNAEHO<GFJHBNAEMKM, string>> LCMAPEMFAAM(long EKMDOMOGGBC, string PHEKPMAPPHM, RoomInventoryTagClientProperties BLGIDAACNMF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool CMPKEKIBDPM(long CGJOHAGOKMB, [Out] GFJHBNAEMKM KBPNOBCKOHC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OIBHIAPHKIJ : JAKCPBJNMID
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPABIFDIIII(IEnumerable<APCGKJDGDAF> CDOABHCFJOL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DNPJHHPNJGF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GIEHLGCKPAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OIOAADJPNMF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6801500", Offset = "0x6800300", VA = "0x186801500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CEDKKGKHIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68014E0", Offset = "0x68002E0", VA = "0x1868014E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long NGELLDPBNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BA870", Offset = "0x7B9670", VA = "0x1807BA870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long GDKKALHIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F10", Offset = "0x7B0D10", VA = "0x1807B1F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? LHOIAOOABIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5020", Offset = "0x7B3E20", VA = "0x1807B5020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5000", Offset = "0x7B3E00", VA = "0x1807B5000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IHMHNDJIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA170", Offset = "0x8B8F70", VA = "0x1808BA170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD05490", Offset = "0xD04290", VA = "0x180D05490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6801700", Offset = "0x6800500", VA = "0x186801700")]
	public GIEHLGCKPAL(APCGKJDGDAF OJFJMMOEBNL, bool DOPOJGLEMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1BD7AE0", Offset = "0x1BD68E0", VA = "0x181BD7AE0")]
	public GIEHLGCKPAL(Guid CGAGMCMIEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6801510", Offset = "0x6800310", VA = "0x186801510")]
	internal bool PHAFDIODDDG(APCGKJDGDAF OJFJMMOEBNL, long FNNGILNANOK, Action<GIEHLGCKPAL, int> GDHBKHPFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6801480", Offset = "0x6800280", VA = "0x186801480")]
	internal void HGENBDFIHBG(long MKHFBJPGEME, Action<GIEHLGCKPAL, int> GDHBKHPFPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JONOHLIDAOC : IEquatable<JONOHLIDAOC>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int MMLCAEJNEAB = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int GJKPKFMBLOC = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LNELPMMKKNF = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int CCEDOPBHHOG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int LFHMCDJBALE = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid OIOAADJPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83F150", Offset = "0x83DF50", VA = "0x18083F150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long KCKKLGOLFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xF10640", Offset = "0xF0F440", VA = "0x180F10640")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string ENDCLAAGGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string GIKKDPFHOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A0", Offset = "0x7B96A0", VA = "0x1807BA8A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime ADNPLPMJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC80D0", Offset = "0x1AC6ED0", VA = "0x181AC80D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime OKGAIPJCDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C00", Offset = "0x1AF6A00", VA = "0x181AF7C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> IGPAGOEDLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B5870", Offset = "0x7B4670", VA = "0x1807B5870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B5880", Offset = "0x7B4680", VA = "0x1807B5880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties GEIIIHNKIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B5850", Offset = "0x7B4650", VA = "0x1807B5850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B5860", Offset = "0x7B4660", VA = "0x1807B5860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte IOCEEJFAINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3A0", Offset = "0x7BC1A0", VA = "0x1807BD3A0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BD380", Offset = "0x7BC180", VA = "0x1807BD380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ENPFFMMLNID HMNOCMLJBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD23C00", Offset = "0xD22A00", VA = "0x180D23C00")]
		[CompilerGenerated]
		get
		{
			return default(ENPFFMMLNID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD22DA0", Offset = "0xD21BA0", VA = "0x180D22DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6801EE0", Offset = "0x6800CE0", VA = "0x186801EE0")]
	public JONOHLIDAOC(CKPONMAHNNB OJFJMMOEBNL, [Optional] RoomInventoryItemProperties BLGIDAACNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68017B0", Offset = "0x68005B0", VA = "0x1868017B0", Slot = "4")]
	public bool Equals(JONOHLIDAOC GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6801930", Offset = "0x6800730", VA = "0x186801930", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6801B10", Offset = "0x6800910", VA = "0x186801B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6801BF0", Offset = "0x68009F0", VA = "0x186801BF0")]
	private HashSet<long> PPNPHIBMEGK(CKPONMAHNNB OJFJMMOEBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GGELPGOJFLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GIEHLGCKPAL JAKCCAIPIMG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JONOHLIDAOC BCGGBGBHICL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GIEHLGCKPAL MBGAAKODBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68010A0", Offset = "0x67FFEA0", VA = "0x1868010A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6801130", Offset = "0x67FFF30", VA = "0x186801130")]
	public GGELPGOJFLK(JONOHLIDAOC HJJJHCPLCFI, [Optional] GIEHLGCKPAL JAKCCAIPIMG)
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
			[Cpp2IlInjected.Address(RVA = "0x6802310", Offset = "0x6801110", VA = "0x186802310")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AA900", Offset = "0x9A9700", VA = "0x1809AA900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9AA8F0", Offset = "0x9A96F0", VA = "0x1809AA8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PDJPILNIIKI Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
			[CompilerGenerated]
			get
			{
				return default(PDJPILNIIKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BAD50", VA = "0x1807BBF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB71950", Offset = "0xB70750", VA = "0x180B71950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3FEBD00", Offset = "0x3FEAB00", VA = "0x183FEBD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8F8610", Offset = "0x8F7410", VA = "0x1808F8610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9E9A40", Offset = "0x9E8840", VA = "0x1809E9A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6802090", Offset = "0x6800E90", VA = "0x186802090", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6802110", Offset = "0x6800F10", VA = "0x186802110")]
		public static RoomInventoryItemProperties OGJOLBOGFNJ(RoomInventoryItemProperties BLGIDAACNMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68022B0", Offset = "0x68010B0", VA = "0x1868022B0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GFJHBNAEMKM
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const int BKHEHCPIGHE = 10;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long ANNPLNCAJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x13693C0", Offset = "0x13681C0", VA = "0x1813693C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public RoomInventoryTagClientProperties GEIIIHNKIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FFGLBFGCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6800FA0", Offset = "0x67FFDA0", VA = "0x186800FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6800FC0", Offset = "0x67FFDC0", VA = "0x186800FC0")]
	public GFJHBNAEMKM(IFCAOLONOOH OJFJMMOEBNL, [Optional] RoomInventoryTagClientProperties BLGIDAACNMF)
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
			[Cpp2IlInjected.Address(RVA = "0x6802560", Offset = "0x6801360", VA = "0x186802560")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6802360", Offset = "0x6801160", VA = "0x186802360")]
		public void JJLACCPPFGI(Dictionary<string, object> DGENKJIDIMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
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
