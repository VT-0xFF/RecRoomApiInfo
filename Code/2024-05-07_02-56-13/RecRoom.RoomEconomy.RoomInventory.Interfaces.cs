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
public class LLDMALILIDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IGFMCCKIAOO KOCODHOGHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long PIKJCOKEANP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AOPIPJFGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67D7430", Offset = "0x67D6630", VA = "0x1867D7430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67D7440", Offset = "0x67D6640", VA = "0x1867D7440")]
	public LLDMALILIDG(IGFMCCKIAOO HCIDHCBMOPD, long KIGJDGACGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KDJEFANLPCN
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
public interface LJDHEJBKFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AGKHEGBIBIG EOIKCCPNIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JMOHOLLMHII<GAOGMPHEPHF> HIHMLBNDGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JMOHOLLMHII<Guid> KIPMCFCLICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EDFKKMBKCDD<GJDKHHDLOOC, int> LOJPKHIEHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JMOHOLLMHII<FEMNLAMPCKJ> PBPJFLGLGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JMOHOLLMHII<long> BPOAHDJOFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AGKHEGBIBIG LHAFEENPNND
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
	Task<NFMFLMAOFMP<GAOGMPHEPHF, string>> IFDJBGKOMNH(long NCFOOPOBBIJ, string IKEFBMMMAJB, string ALPNBPOHMCC, string PBMEGOIIGMD, RoomInventoryItemProperties OEENDMDOMOO, byte BHDANKLFIDC, int NHDAKDKKMHH, [Optional] List<long> GFFDLNDLIFD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<NFMFLMAOFMP<GAOGMPHEPHF, string>> PEOHLJIKCIF(Guid HLMGEPICABN, [Optional] string IKEFBMMMAJB, [Optional] string ALPNBPOHMCC, [Optional] string PBMEGOIIGMD, [Optional] List<long> GFFDLNDLIFD, [Optional] RoomInventoryItemProperties OEENDMDOMOO, [Optional] byte? BHDANKLFIDC, [Optional] int? NHDAKDKKMHH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<NFMFLMAOFMP<bool, string>> CKDFKLPHFJK(Guid HLMGEPICABN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<GAOGMPHEPHF> MFDIEGCIKIG();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<GAOGMPHEPHF> JHIEFINNCFJ();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool EKMHFDEEAMN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool IKLFDBPAPJL(Guid HLMGEPICABN, [Out] GAOGMPHEPHF KFJNFOFKPDE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool EBJMNAELIOH(string NEEEEBDNMLE, [Out] GAOGMPHEPHF KFJNFOFKPDE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<GJDKHHDLOOC> EDAMDGCFBEL();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool EEBOJIKGKLB(Guid HLMGEPICABN, [Out] GJDKHHDLOOC ACJOCHPEJIH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	long? MPHDJMOGIMC(Guid HLMGEPICABN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<int> NALPBJHHEHL(EOBANJCDGLI DBPHBPCOBKD, Guid HLMGEPICABN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<LLDMALILIDG> ENILAJLFBDI(EOBANJCDGLI DBPHBPCOBKD, Guid HLMGEPICABN, int FNNPIHCMBNJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	string EAEJGKOMNCG(IGFMCCKIAOO HCIDHCBMOPD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool MODLLDFHJJM();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<NFMFLMAOFMP<FEMNLAMPCKJ, string>> ICOKKBBFMNO(long NCFOOPOBBIJ, string IKEFBMMMAJB, RoomInventoryTagClientProperties OEENDMDOMOO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool PAJLBPKKLNC(long DENOKEIGCHA, [Out] FEMNLAMPCKJ BOHICCHHCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FDJOPGLOLHD : LJDHEJBKFHG
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIODHBBKKCD(IEnumerable<JKJNGBPDHFB> ABLFLJINGJC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GOOKLMNKGFG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GJDKHHDLOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid FDELMGBCNKO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67D6F80", Offset = "0x67D6180", VA = "0x1867D6F80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AOPIPJFGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67D6F90", Offset = "0x67D6190", VA = "0x1867D6F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long PNGGIAMLPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B0", Offset = "0x7B54B0", VA = "0x1807B62B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long AAOKNLNPINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEE0", Offset = "0x7BF0E0", VA = "0x1807BFEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? MEEIJGKLOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9940", Offset = "0x7B8B40", VA = "0x1807B9940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9930", Offset = "0x7B8B30", VA = "0x1807B9930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KGEPOHEKPML
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3230", Offset = "0x8D2430", VA = "0x1808D3230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD1D440", Offset = "0xD1C640", VA = "0x180D1D440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67D6FB0", Offset = "0x67D61B0", VA = "0x1867D6FB0")]
	public GJDKHHDLOOC(JKJNGBPDHFB MGOEGCIMFAN, bool MIPNLLJOAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1BF3BF0", Offset = "0x1BF2DF0", VA = "0x181BF3BF0")]
	public GJDKHHDLOOC(Guid HLMGEPICABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67D6D90", Offset = "0x67D5F90", VA = "0x1867D6D90")]
	internal bool GKEPGFOADJA(JKJNGBPDHFB MGOEGCIMFAN, long MMEDNFAMMLL, Action<GJDKHHDLOOC, int> AKANPMLHPBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67D6D30", Offset = "0x67D5F30", VA = "0x1867D6D30")]
	internal void CKPEMIAODPN(long HAIEEJMMMKL, Action<GJDKHHDLOOC, int> AKANPMLHPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GAOGMPHEPHF : IEquatable<GAOGMPHEPHF>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int LMLEMLLFFBL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int KFDGDBMKMMO = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int OPHMIGKNLLE = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int CKNNNPDEBDG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int COLKDPIKONL = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid FDELMGBCNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8439E0", Offset = "0x842BE0", VA = "0x1808439E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long GPFDOHKPFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xF26B70", Offset = "0xF25D70", VA = "0x180F26B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string AEEKODOKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string KDFLLMCNGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime MBOIJBJFHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AEBF90", Offset = "0x1AEB190", VA = "0x181AEBF90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime ODIAOOONANO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1B19440", Offset = "0x1B18640", VA = "0x181B19440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> LPPMHMPJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties JMDKMCNOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte HBFHPLIPOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BE190", Offset = "0x7BD390", VA = "0x1807BE190")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BE210", Offset = "0x7BD410", VA = "0x1807BE210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PKCCLILNAJO MKJPAJDIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD358A0", Offset = "0xD34AA0", VA = "0x180D358A0")]
		[CompilerGenerated]
		get
		{
			return default(PKCCLILNAJO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67D6BD0", Offset = "0x67D5DD0", VA = "0x1867D6BD0")]
	public GAOGMPHEPHF(JIBHDGFBNFF MGOEGCIMFAN, [Optional] RoomInventoryItemProperties OEENDMDOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67D6790", Offset = "0x67D5990", VA = "0x1867D6790", Slot = "4")]
	public bool Equals(GAOGMPHEPHF NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67D6910", Offset = "0x67D5B10", VA = "0x1867D6910", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67D6AF0", Offset = "0x67D5CF0", VA = "0x1867D6AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67D64A0", Offset = "0x67D56A0", VA = "0x1867D64A0")]
	private HashSet<long> BELAKDEMEFL(JIBHDGFBNFF MGOEGCIMFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JOFOPLOFJKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GJDKHHDLOOC ACJOCHPEJIH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GAOGMPHEPHF IJEJJCGJIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GJDKHHDLOOC OMHMAHJBGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67D7060", Offset = "0x67D6260", VA = "0x1867D7060")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67D70F0", Offset = "0x67D62F0", VA = "0x1867D70F0")]
	public JOFOPLOFJKJ(GAOGMPHEPHF KFJNFOFKPDE, [Optional] GJDKHHDLOOC ACJOCHPEJIH)
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
			[Cpp2IlInjected.Address(RVA = "0x67D7700", Offset = "0x67D6900", VA = "0x1867D7700")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B9910", Offset = "0x7B8B10", VA = "0x1807B9910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEE0", Offset = "0x9BC0E0", VA = "0x1809BCEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEF0", Offset = "0x9BC0F0", VA = "0x1809BCEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public KDJEFANLPCN Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
			[CompilerGenerated]
			get
			{
				return default(KDJEFANLPCN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7C2820", Offset = "0x7C1A20", VA = "0x1807C2820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB86CC0", Offset = "0xB85EC0", VA = "0x180B86CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3FD9E60", Offset = "0x3FD9060", VA = "0x183FD9E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x90D2F0", Offset = "0x90C4F0", VA = "0x18090D2F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9FB770", Offset = "0x9FA970", VA = "0x1809FB770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x67D7480", Offset = "0x67D6680", VA = "0x1867D7480", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67D7500", Offset = "0x67D6700", VA = "0x1867D7500")]
		public static RoomInventoryItemProperties GJIFFJEBAAL(RoomInventoryItemProperties OEENDMDOMOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67D76A0", Offset = "0x67D68A0", VA = "0x1867D76A0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FEMNLAMPCKJ
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const int DJJHKHGLGNM = 10;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KOJNGAEOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1380DC0", Offset = "0x137FFC0", VA = "0x181380DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public RoomInventoryTagClientProperties JMDKMCNOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool CILOMCPCPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67D63A0", Offset = "0x67D55A0", VA = "0x1867D63A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67D63C0", Offset = "0x67D55C0", VA = "0x1867D63C0")]
	public FEMNLAMPCKJ(MMHELANNNOB MGOEGCIMFAN, [Optional] RoomInventoryTagClientProperties OEENDMDOMOO)
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
			[Cpp2IlInjected.Address(RVA = "0x67D7950", Offset = "0x67D6B50", VA = "0x1867D7950")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B9910", Offset = "0x7B8B10", VA = "0x1807B9910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67D7750", Offset = "0x67D6950", VA = "0x1867D7750")]
		public void EMIHAKMAFFO(Dictionary<string, object> FOOMKMLAHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
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
