using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NKPHCIBMIDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly NLNKEGAABFC IKAHOBFPKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long MELIDLJEANB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AOPIEKPJIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F42AE0", Offset = "0x6F412E0", VA = "0x186F42AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F42AF0", Offset = "0x6F412F0", VA = "0x186F42AF0")]
	public NKPHCIBMIDO(NLNKEGAABFC ADPMAHMCGNH, long IHGHLPOONHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MDIDOCDAIBO
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
public interface PHKJMDHEHIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EHODCIMNDCH KGDBDLOINGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ODIOBOMGOFD<BNMMHKAMDLH> HHIPFJJALLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ODIOBOMGOFD<Guid> IPLGKAAAENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OPLNKFOLMMC<NIMKCDDGGHI, int> CLJLPIOOJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ODIOBOMGOFD<BNFEEALKANG> CANKCFEFCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ODIOBOMGOFD<long> HPDOBMIPHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EHODCIMNDCH IJNKNACIMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EHODCIMNDCH JHEECNGJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<CIKECDEKJAI<BNMMHKAMDLH, string>> INJHLLHKJGH(long DIMOGDCMBFM, string BHFPKCCDEEC, string OLBMKMHMAID, string OJJODEJMFNM, RoomInventoryItemProperties JJHPFCNOMJP, byte ACDOKGKGEAH, int KIJNHGNFMMA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<CIKECDEKJAI<BNMMHKAMDLH, string>> KKAEIAJGECH(Guid DHNCLNFPOCP, [Optional] string BHFPKCCDEEC, [Optional] string OLBMKMHMAID, [Optional] string OJJODEJMFNM, [Optional] List<long> PIFONBIFIOC, [Optional] Dictionary<string, RoomInventoryTagClientProperties> HPONPCGDNMG, [Optional] RoomInventoryItemProperties JJHPFCNOMJP, [Optional] byte? ACDOKGKGEAH, [Optional] int? KIJNHGNFMMA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<CIKECDEKJAI<bool, string>> HEOGGACBBFO(Guid DHNCLNFPOCP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<BNMMHKAMDLH> KLIDGOECBPD();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<BNMMHKAMDLH> KFKHDGECKLH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CIHOIPJPFBF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CLPNFBCFHBL(Guid DHNCLNFPOCP, [Out] BNMMHKAMDLH FECFDCIDPMC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool LJIOECPGGMF(string OEHKJKGOMPO, [Out] BNMMHKAMDLH FECFDCIDPMC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<NIMKCDDGGHI> HOCJNNPPMNE();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool PJCDPKCJHKP(Guid DHNCLNFPOCP, [Out] NIMKCDDGGHI MBNJDDENFIB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? HDDCMIKIAPN(Guid DHNCLNFPOCP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> JNMAJDICCBD(LCMANADAOPN DAFEONGKMPP, Guid DHNCLNFPOCP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<NKPHCIBMIDO> BFBBCAKMABC(LCMANADAOPN DAFEONGKMPP, Guid DHNCLNFPOCP, int KOIONGLECCC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string LJFNFIDKDHE(NLNKEGAABFC ADPMAHMCGNH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool MBNDNCMFHOK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<CIKECDEKJAI<BNFEEALKANG, string>> INHFNEPAICG(long PKPBAEEEOEJ, RoomInventoryTagClientProperties JJHPFCNOMJP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<CIKECDEKJAI<bool, string>> FGFHAHLDIFB(long PKPBAEEEOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<CIKECDEKJAI<bool, string>> IFHHDNPCHBB(long DIMOGDCMBFM, bool ACBCMPDCOIJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OLHAICNECLC();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> NPMJEMJBEMJ(long PABJOBJGALI, int LBOIMLHNNLJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CDFGIOBJNGE(long PKPBAEEEOEJ, [Out] BNFEEALKANG JEPMAPILMJD);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool DPNJDEEDAGA(long PKPBAEEEOEJ, Guid BKPEBNFBCAB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<BNFEEALKANG> OAKKKDLFBGO();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<BNFEEALKANG> IOGOHLNOIFK();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<BNFEEALKANG> BMEPBJFKEND();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<BNMMHKAMDLH> JDADOLEMIIM(long PKPBAEEEOEJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool MFAKNCPADGN(string NEBGEICDHML, [Out] IReadOnlyList<BNMMHKAMDLH> MBLCDEBJLIO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MOOGBOKLPIA : PHKJMDHEHIJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHGAIANEEGO(IEnumerable<FGEEHKDLPJA> LDHLCEBAOBF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FALHLMIIOPH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NIMKCDDGGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid CHMJHFCOOOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F429C0", Offset = "0x6F411C0", VA = "0x186F429C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AOPIEKPJIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F427B0", Offset = "0x6F40FB0", VA = "0x186F427B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long EJPDLIPEPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x856B80", Offset = "0x855380", VA = "0x180856B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long CMHGOEFDKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x858DF0", Offset = "0x8575F0", VA = "0x180858DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LPGCNDDEBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8528B0", Offset = "0x8510B0", VA = "0x1808528B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8528F0", Offset = "0x8510F0", VA = "0x1808528F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EDMDLIOPCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA348D0", Offset = "0xA330D0", VA = "0x180A348D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE9B6A0", Offset = "0xE99EA0", VA = "0x180E9B6A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F42A30", Offset = "0x6F41230", VA = "0x186F42A30")]
	public NIMKCDDGGHI(FGEEHKDLPJA NPCDBLABEFG, bool CEJOGPIFLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1D828A0", Offset = "0x1D810A0", VA = "0x181D828A0")]
	public NIMKCDDGGHI(Guid DHNCLNFPOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F427D0", Offset = "0x6F40FD0", VA = "0x186F427D0")]
	internal bool LHGGKPHIKGE(FGEEHKDLPJA NPCDBLABEFG, long ODNGJPPBDNG, Action<NIMKCDDGGHI, int> AJJCIHFGAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F429D0", Offset = "0x6F411D0", VA = "0x186F429D0")]
	internal void POAANMMILOE(long INKBPPFILPB, Action<NIMKCDDGGHI, int> AJJCIHFGAFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BNMMHKAMDLH : IEquatable<BNMMHKAMDLH>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int EIBPDEPNDMH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int LBLADOEHBJK = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int JOIHNEAGEMM = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int POPJKLFBAPF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int GFGCBGCGCEO = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid CHMJHFCOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C85B0", VA = "0x1808C9DB0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98C980", VA = "0x18098E180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long GKKIJACBHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x10742F0", Offset = "0x1072AF0", VA = "0x1810742F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string PGAAPEIPKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PCDEDLEEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x856920", Offset = "0x855120", VA = "0x180856920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime FDHMDKIPDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1C96E50", Offset = "0x1C95650", VA = "0x181C96E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime FCNALDDDGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5CECCF0", Offset = "0x5CEB4F0", VA = "0x185CECCF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> FJEBOELHECI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854B00", VA = "0x180856300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x854AF0", VA = "0x1808562F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties OLEHCIIPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x856340", Offset = "0x854B40", VA = "0x180856340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x856330", Offset = "0x854B30", VA = "0x180856330")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte HHCLOJKNPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x856900", Offset = "0x855100", VA = "0x180856900")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x856BB0", Offset = "0x8553B0", VA = "0x180856BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEBHIHOELNJ GMOFENMBBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEAF2F0", Offset = "0xEADAF0", VA = "0x180EAF2F0")]
		[CompilerGenerated]
		get
		{
			return default(IEBHIHOELNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0D0", Offset = "0xEAB8D0", VA = "0x180EAD0D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F42270", Offset = "0x6F40A70", VA = "0x186F42270")]
	public BNMMHKAMDLH(FOKEPPCFOLI NPCDBLABEFG, [Optional] RoomInventoryItemProperties JJHPFCNOMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F41B40", Offset = "0x6F40340", VA = "0x186F41B40", Slot = "4")]
	public bool Equals(BNMMHKAMDLH OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F41CC0", Offset = "0x6F404C0", VA = "0x186F41CC0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F41EA0", Offset = "0x6F406A0", VA = "0x186F41EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F41F80", Offset = "0x6F40780", VA = "0x186F41F80")]
	private HashSet<long> MIEGBKAOHOJ(FOKEPPCFOLI NPCDBLABEFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JKDCPNLLDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NIMKCDDGGHI MBNJDDENFIB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BNMMHKAMDLH HKJHCNKBBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NIMKCDDGGHI AMNCLCKGOFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F423D0", Offset = "0x6F40BD0", VA = "0x186F423D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F42460", Offset = "0x6F40C60", VA = "0x186F42460")]
	public JKDCPNLLDPO(BNMMHKAMDLH FECFDCIDPMC, [Optional] NIMKCDDGGHI MBNJDDENFIB)
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

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F42DC0", Offset = "0x6F415C0", VA = "0x186F42DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851110", VA = "0x180852910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x91FDB0", Offset = "0x91E5B0", VA = "0x18091FDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB05CA0", Offset = "0xB044A0", VA = "0x180B05CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public MDIDOCDAIBO Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10")]
			[CompilerGenerated]
			get
			{
				return default(MDIDOCDAIBO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x860F50", Offset = "0x85F750", VA = "0x180860F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C00", Offset = "0xCEF400", VA = "0x180CF0C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x44E91C0", Offset = "0x44E79C0", VA = "0x1844E91C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D560", Offset = "0xA6BD60", VA = "0x180A6D560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB42340", Offset = "0xB40B40", VA = "0x180B42340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDDAB40", Offset = "0xDD9340", VA = "0x180DDAB40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDD9820", Offset = "0xDD8020", VA = "0x180DD9820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F42B30", Offset = "0x6F41330", VA = "0x186F42B30", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F42BB0", Offset = "0x6F413B0", VA = "0x186F42BB0")]
		public static RoomInventoryItemProperties IJDMAMHKEEG(RoomInventoryItemProperties JJHPFCNOMJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F42D60", Offset = "0x6F41560", VA = "0x186F42D60")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BNFEEALKANG
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int PCFBIMLBALP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string HGPGDMHHBHK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder OOFBCDNNCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string FBEOJIKBEJF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long AAJNLDNGHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F92E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F41990", Offset = "0x6F40190", VA = "0x186F41990")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string BKMLLKACEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F41740", Offset = "0x6F3FF40", VA = "0x186F41740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties OLEHCIIPMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EMDDCLNIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F41720", Offset = "0x6F3FF20", VA = "0x186F41720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public BNFEEALKANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F41A40", Offset = "0x6F40240", VA = "0x186F41A40")]
	public BNFEEALKANG(KJCAGICBLGD NPCDBLABEFG, [Optional] RoomInventoryTagClientProperties JJHPFCNOMJP)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RoomInventoryTagClientProperties DefaultNonSortingTab
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6F43010", Offset = "0x6F41810", VA = "0x186F43010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851110", VA = "0x180852910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F42E10", Offset = "0x6F41610", VA = "0x186F42E10")]
		public void FOPKHJHMHJP(Dictionary<string, object> KKLNEJLIDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
