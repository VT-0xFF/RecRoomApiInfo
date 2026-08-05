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
public class DHBNGDBFDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly EIPFOAJBCBG GJKHNPEPLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long ALDOGAGGHGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NCAGGFCJHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x677D9E0", Offset = "0x677CDE0", VA = "0x18677D9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x677D9F0", Offset = "0x677CDF0", VA = "0x18677D9F0")]
	public DHBNGDBFDNF(EIPFOAJBCBG FEADNEEPDLO, long JDBLGKLFJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MJIBGIKGNKK
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
public interface PMHKDEGFHHD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DGHHAMKHKGM LLGOKEMKNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JGNHMIKEILN<HGIANDEGHOB> HBJAMJOADNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JGNHMIKEILN<Guid> LLMENIAKNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CNCBMPDPOAH<PJBBHKPHFKM, int> GIHJIOPHPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JGNHMIKEILN<IHPELFPOLNJ> BBJBIPCEKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JGNHMIKEILN<long> KLICFGFBGND
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DGHHAMKHKGM JKAMOKIMDEN
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
	Task<OJIJNKCPBAD<HGIANDEGHOB, string>> HLGIHIBPKNJ(long NIJFNKBIOIC, string CCNKHEJHFKM, string INBGNCKHOAH, string CFBFIDEJPBK, RoomInventoryItemProperties NLBEHFCHMJB, [Optional] List<long> NPEEFOFDGIM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OJIJNKCPBAD<HGIANDEGHOB, string>> HDFNINFJNEI(Guid ILMALBAHIHG, [Optional] string CCNKHEJHFKM, [Optional] string INBGNCKHOAH, [Optional] string CFBFIDEJPBK, [Optional] List<long> NPEEFOFDGIM, [Optional] RoomInventoryItemProperties NLBEHFCHMJB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<OJIJNKCPBAD<bool, string>> HCMPKEBDKCM(Guid ILMALBAHIHG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<HGIANDEGHOB> KAAONLGEGMN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<HGIANDEGHOB> DNDPFMDJEAL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool ELFGEFENNLL();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool LKBNFDFOEOH(Guid ILMALBAHIHG, [Out] HGIANDEGHOB FJCMBEGLNNN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OKNPJOIAKOI(string FBNKEGDICAL, [Out] HGIANDEGHOB FJCMBEGLNNN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<PJBBHKPHFKM> GGCBKJGNLOL();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool IKBLKDIJJNF(Guid ILMALBAHIHG, [Out] PJBBHKPHFKM BOJJHJCJNBD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<int> CBHMKAGAPCP(MKFCBDEMMMH MLFPIJHNEAA, Guid ILMALBAHIHG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<DHBNGDBFDNF> IOKMNCFMOJK(MKFCBDEMMMH MLFPIJHNEAA, Guid ILMALBAHIHG, int GEHEIIBAMPL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	string JKECIEPIMBK(EIPFOAJBCBG FEADNEEPDLO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EKEIMMOPKOL();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<OJIJNKCPBAD<IHPELFPOLNJ, string>> GDOKCLPNJEN(long NIJFNKBIOIC, string CCNKHEJHFKM, RoomInventoryTagClientProperties NLBEHFCHMJB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FPMOLHCLNMA(long OEJLFGGBNPM, [Out] IHPELFPOLNJ OJIJDPIGGMI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCNLJONKMOI : PMHKDEGFHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFJMEKPKOBL(IEnumerable<HHBHPDEPJFI> HEJODDBLNNC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PJBBHKPHFKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid PMMMMPHCJNE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x677E860", Offset = "0x677DC60", VA = "0x18677E860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NCAGGFCJHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x677E7E0", Offset = "0x677DBE0", VA = "0x18677E7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long OMJDMNMKJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C46B0", Offset = "0x7C3AB0", VA = "0x1807C46B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long PJFOAKKGPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C1010", Offset = "0x7C0410", VA = "0x1807C1010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? CLAGKIBCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C6740", Offset = "0x7C5B40", VA = "0x1807C6740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6730", Offset = "0x7C5B30", VA = "0x1807C6730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KGIJOKMCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C66D0", Offset = "0x8C5AD0", VA = "0x1808C66D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0360", Offset = "0x1AAF760", VA = "0x181AB0360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x677EA60", Offset = "0x677DE60", VA = "0x18677EA60")]
	public PJBBHKPHFKM(HHBHPDEPJFI KEBOCBFKNEJ, bool LHOFPLDNDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B776B0", Offset = "0x1B76AB0", VA = "0x181B776B0")]
	public PJBBHKPHFKM(Guid ILMALBAHIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x677E870", Offset = "0x677DC70", VA = "0x18677E870")]
	internal bool LLBOFPOPBEE(HHBHPDEPJFI KEBOCBFKNEJ, long IMDBHCPDMAC, Action<PJBBHKPHFKM, int> GKEGOOKIKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x677E800", Offset = "0x677DC00", VA = "0x18677E800")]
	internal void GPJJCONOAGG(long LODJKABENPD, Action<PJBBHKPHFKM, int> GKEGOOKIKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HGIANDEGHOB : IEquatable<HGIANDEGHOB>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int JBIPCJNJHPJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int BJGJFGEPMIM = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int CAKHLFNDJFG = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int BKICKLOFMNA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int EOGCJKDEGHD = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid PMMMMPHCJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850900", VA = "0x180851500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long LHIMKHILIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEE46F0", Offset = "0xEE3AF0", VA = "0x180EE46F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string CPMGHEGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string HMJGPKBPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime DDKCCBBHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1A83A80", Offset = "0x1A82E80", VA = "0x181A83A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime CPPEMBIOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB6750", Offset = "0x1AB5B50", VA = "0x181AB6750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> PJMBBMLJEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties AODGCONKJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x677E160", Offset = "0x677D560", VA = "0x18677E160")]
	public HGIANDEGHOB(OPIMJBFIFIJ KEBOCBFKNEJ, [Optional] RoomInventoryItemProperties NLBEHFCHMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x677DA30", Offset = "0x677CE30", VA = "0x18677DA30", Slot = "4")]
	public bool Equals(HGIANDEGHOB MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x677DBB0", Offset = "0x677CFB0", VA = "0x18677DBB0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x677DD90", Offset = "0x677D190", VA = "0x18677DD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x677DE70", Offset = "0x677D270", VA = "0x18677DE70")]
	private HashSet<long> MAIHCOLJMML(OPIMJBFIFIJ KEBOCBFKNEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MLABOHIPKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private PJBBHKPHFKM BOJJHJCJNBD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HGIANDEGHOB FMMDDCKMFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PJBBHKPHFKM IMCFIOPLLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x677E400", Offset = "0x677D800", VA = "0x18677E400")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x677E490", Offset = "0x677D890", VA = "0x18677E490")]
	public MLABOHIPKNB(HGIANDEGHOB FJCMBEGLNNN, [Optional] PJBBHKPHFKM BOJJHJCJNBD)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x677ED90", Offset = "0x677E190", VA = "0x18677ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C6B00", Offset = "0x9C5F00", VA = "0x1809C6B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C6AF0", Offset = "0x9C5EF0", VA = "0x1809C6AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MJIBGIKGNKK Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
			[CompilerGenerated]
			get
			{
				return default(MJIBGIKGNKK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C7740", Offset = "0x7C6B40", VA = "0x1807C7740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB7C990", Offset = "0xB7BD90", VA = "0x180B7C990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3F61740", Offset = "0x3F60B40", VA = "0x183F61740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x900930", Offset = "0x8FFD30", VA = "0x180900930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F4100", Offset = "0x9F3500", VA = "0x1809F4100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x677EB10", Offset = "0x677DF10", VA = "0x18677EB10", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x677EB90", Offset = "0x677DF90", VA = "0x18677EB90")]
		public static RoomInventoryItemProperties KKNGHIBJGCG(RoomInventoryItemProperties NLBEHFCHMJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x677ED30", Offset = "0x677E130", VA = "0x18677ED30")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IHPELFPOLNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int CEILFMPMKBF = 10;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JMNMGPHLHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public RoomInventoryTagClientProperties AODGCONKJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool GGHHFPHDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x677E2A0", Offset = "0x677D6A0", VA = "0x18677E2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x677E2C0", Offset = "0x677D6C0", VA = "0x18677E2C0")]
	public IHPELFPOLNJ(KPHEPOLIKLN KEBOCBFKNEJ, [Optional] RoomInventoryTagClientProperties NLBEHFCHMJB)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x677EFE0", Offset = "0x677E3E0", VA = "0x18677EFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x677EDE0", Offset = "0x677E1E0", VA = "0x18677EDE0")]
		public void MMINADGLCIF(Dictionary<string, object> CFJODMPHEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class JFADGEGKDOH
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x677E3A0", Offset = "0x677D7A0", VA = "0x18677E3A0")]
	public static int INJLACIPJPL(long PFOIBCCNACC)
	{
		return default(int);
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
