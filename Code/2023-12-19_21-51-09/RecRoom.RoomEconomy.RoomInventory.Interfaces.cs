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
public class COFLBKIKNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OFAMABIIEKK BJMFNDMKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long CMJPMBPLDNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MHMIHDHNKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63C24B0", Offset = "0x63C10B0", VA = "0x1863C24B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63C24C0", Offset = "0x63C10C0", VA = "0x1863C24C0")]
	public COFLBKIKNHF(OFAMABIIEKK HNCONAMCFGC, long EMHEDPDPEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AJLNLCKFIPD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	NGHNHLLDGBJ KFBCPJNDPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LBFCDLOMLLJ<BJMKFOICGBG> JBHBEOHKDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LBFCDLOMLLJ<Guid> JNEBOHGBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CGINFNNBHBJ<DBALMMINIID, int> AMNPCCIBGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NGHNHLLDGBJ DJMDGLLJOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<MEPDFJNPAPE<BJMKFOICGBG, string>> CJOEFHEFAEK(long BPJLDBDKBIJ, string JEICAPDKHKI, string BKAHLJMONND, string BJFPBGNFLON, RoomInventoryItemProperties ACGMLGMLLPB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<MEPDFJNPAPE<BJMKFOICGBG, string>> KGGLFHICBKF(Guid MPMJCGCKBOF, [Optional] string JEICAPDKHKI, [Optional] string BKAHLJMONND, [Optional] string BJFPBGNFLON, [Optional] RoomInventoryItemProperties ACGMLGMLLPB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MEPDFJNPAPE<bool, string>> NBOAOAPJAKD(Guid MPMJCGCKBOF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<BJMKFOICGBG> LAMKCFIFGKB();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<BJMKFOICGBG> JLPCFMFBENO();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BPEOMJPEDCF(Guid MPMJCGCKBOF, [Out] BJMKFOICGBG PPGLCCHNBHJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool KEPJGMPNFOE(Guid MPMJCGCKBOF, [Out] DBALMMINIID PPHEDOPAPJF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<int> MLGIJLINGFB(ILLMBLKEFFI EJDJNJMKMJN, Guid MPMJCGCKBOF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<COFLBKIKNHF> JJFBPNHMNIE(ILLMBLKEFFI EJDJNJMKMJN, Guid MPMJCGCKBOF, int HECECHIOFNI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string PFPPPKHAMBH(OFAMABIIEKK HNCONAMCFGC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool NABANBKOOIA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GOJFKJHJJGI : AJLNLCKFIPD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHNBPBGMJMN(IEnumerable<AOIFMCDEGLB> LLICDFPOBMM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DBALMMINIID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid IBDKCHCINGO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63C2500", Offset = "0x63C1100", VA = "0x1863C2500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MHMIHDHNKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63C2570", Offset = "0x63C1170", VA = "0x1863C2570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long IEKKPBPCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x776510", Offset = "0x775110", VA = "0x180776510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long LJBKEPFGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x773450", Offset = "0x772050", VA = "0x180773450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? DEOIGDPNINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77F1F0", Offset = "0x77DDF0", VA = "0x18077F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77F220", Offset = "0x77DE20", VA = "0x18077F220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MEJFHDBDOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x814090", Offset = "0x812C90", VA = "0x180814090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19720A0", Offset = "0x1970CA0", VA = "0x1819720A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63C2780", Offset = "0x63C1380", VA = "0x1863C2780")]
	public DBALMMINIID(AOIFMCDEGLB DMCJEHOICMK, bool PMDIAACGMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CA3890", Offset = "0x1CA2490", VA = "0x181CA3890")]
	public DBALMMINIID(Guid MPMJCGCKBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63C2590", Offset = "0x63C1190", VA = "0x1863C2590")]
	internal bool OFENLADEDFE(AOIFMCDEGLB DMCJEHOICMK, long JINLNPALNFL, Action<DBALMMINIID, int> LMKLAPENAHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63C2510", Offset = "0x63C1110", VA = "0x1863C2510")]
	internal void GNNIFMAGLIF(long FGOBJDIDBMI, Action<DBALMMINIID, int> LMKLAPENAHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BJMKFOICGBG : IEquatable<BJMKFOICGBG>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int IPHEHHKOHGE = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int HMKFBNCDBJN = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int HKHDMDIJCJG = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int FPNEGAKAOMI = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid IBDKCHCINGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1B78D20", Offset = "0x1B77920", VA = "0x181B78D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NPDOLACIPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDFA910", Offset = "0xDF9510", VA = "0x180DFA910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string ODBDFCEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string LOLJPFLIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MLCIIMLKGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x776700", Offset = "0x775300", VA = "0x180776700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime HODBDIJAHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x773440", Offset = "0x772040", VA = "0x180773440")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x192E380", Offset = "0x192CF80", VA = "0x18192E380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime GIANGPCBNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1950EB0", Offset = "0x194FAB0", VA = "0x181950EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties BOLLIHLIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63C2390", Offset = "0x63C0F90", VA = "0x1863C2390")]
	public BJMKFOICGBG(CINIHHIPICN DMCJEHOICMK, [Optional] RoomInventoryItemProperties ACGMLGMLLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63C2130", Offset = "0x63C0D30", VA = "0x1863C2130", Slot = "4")]
	public bool Equals(BJMKFOICGBG LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63C1F50", Offset = "0x63C0B50", VA = "0x1863C1F50", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63C22B0", Offset = "0x63C0EB0", VA = "0x1863C22B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OOEOHNEBNCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DBALMMINIID PPHEDOPAPJF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BJMKFOICGBG LMANCIDHJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DBALMMINIID EPCKMLMMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63C2830", Offset = "0x63C1430", VA = "0x1863C2830")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63C28C0", Offset = "0x63C14C0", VA = "0x1863C28C0")]
	public OOEOHNEBNCM(BJMKFOICGBG PPGLCCHNBHJ, [Optional] DBALMMINIID PPHEDOPAPJF)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63C2D40", Offset = "0x63C1940", VA = "0x1863C2D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x77F1E0", Offset = "0x77DDE0", VA = "0x18077F1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D1920", Offset = "0x8D0520", VA = "0x1808D1920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D1930", Offset = "0x8D0530", VA = "0x1808D1930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63C2C10", Offset = "0x63C1810", VA = "0x1863C2C10", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63C2C40", Offset = "0x63C1840", VA = "0x1863C2C40")]
		public static RoomInventoryItemProperties KNGEGBABBHG(RoomInventoryItemProperties ACGMLGMLLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x19D2CE0", Offset = "0x19D18E0", VA = "0x1819D2CE0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class ADCMGIJINGH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63C1EF0", Offset = "0x63C0AF0", VA = "0x1863C1EF0")]
	public static int EMKJHCHHGON(long JEIBBCEGCBO)
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
