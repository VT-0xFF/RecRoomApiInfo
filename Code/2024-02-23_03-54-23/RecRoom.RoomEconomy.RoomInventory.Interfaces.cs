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
public class LENLEFPMOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly GLNOABNHEPM GBBOJIONADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long OICIIFDIAGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HMDBDADMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x654ACF0", Offset = "0x65496F0", VA = "0x18654ACF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x654AD00", Offset = "0x6549700", VA = "0x18654AD00")]
	public LENLEFPMOBB(GLNOABNHEPM MNKBHKEBOPJ, long DPBEIPGOMHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BJFAENJLBCA
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
public interface GHMDLIDMDLH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KKEEGFAPLDK AMEKPIHDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PFEKNBHDJHH<CCKHAHKJIMD> KNFKDFKLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PFEKNBHDJHH<Guid> PDGIKEMMNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	APBBKGHGNMG<IBLGCFPDBMG, int> LJKNBDCFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KKEEGFAPLDK OCCFIGLHFKK
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
	Task<KKHLNMGODKL<CCKHAHKJIMD, string>> OBCMMBLNBEI(long MAONELICPNP, string OMHHPMIDNAN, string NDBGGHMJKHH, string EPNGDFLAIGO, RoomInventoryItemProperties JAMEDNMIIII);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<KKHLNMGODKL<CCKHAHKJIMD, string>> DKIFPGILDLL(Guid ENGHOHIFJBB, [Optional] string OMHHPMIDNAN, [Optional] string NDBGGHMJKHH, [Optional] string EPNGDFLAIGO, [Optional] List<long> NMBKGENKKCD, [Optional] RoomInventoryItemProperties JAMEDNMIIII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KKHLNMGODKL<bool, string>> NPJGKALFIOA(Guid ENGHOHIFJBB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<CCKHAHKJIMD> DKLPCECGHKB();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<CCKHAHKJIMD> HBIOKIHBJHJ();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IPLFPEBNHFP();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NDNCOFBINDO(Guid ENGHOHIFJBB, [Out] CCKHAHKJIMD DBMHKIPIMAE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MCBNBKFFHJJ(string LEMGBEINMJI, [Out] CCKHAHKJIMD DBMHKIPIMAE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<IBLGCFPDBMG> PLLNNJIOJGM();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool OFGPGHELLDF(Guid ENGHOHIFJBB, [Out] IBLGCFPDBMG NFIAJHEOMDP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<int> FAAJFBOLKBG(PFJNLKLKGNM LGJIBLMCMPJ, Guid ENGHOHIFJBB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<LENLEFPMOBB> LHNFHIEOKBL(PFJNLKLKGNM LGJIBLMCMPJ, Guid ENGHOHIFJBB, int OGKNDCGCKLO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OIPODCKCACA(GLNOABNHEPM MNKBHKEBOPJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool FKJIFENPIJP();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLFHFHDEOOJ : GHMDLIDMDLH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNJEJLICIME(IEnumerable<AJBAMMPICME> FLPHPNCGHFK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IBLGCFPDBMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid CEAMOGLKFNA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x654A850", Offset = "0x6549250", VA = "0x18654A850")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HMDBDADMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x654A830", Offset = "0x6549230", VA = "0x18654A830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BICDIBOOCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A9410", Offset = "0x7A7E10", VA = "0x1807A9410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long ONCDPKNBLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B2170", Offset = "0x7B0B70", VA = "0x1807B2170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? JBMPLBDJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CD0", Offset = "0x7B46D0", VA = "0x1807B5CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CC0", Offset = "0x7B46C0", VA = "0x1807B5CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NENNJKFBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84C140", Offset = "0x84AB40", VA = "0x18084C140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19E46B0", Offset = "0x19E30B0", VA = "0x1819E46B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x654A860", Offset = "0x6549260", VA = "0x18654A860")]
	public IBLGCFPDBMG(AJBAMMPICME NENPCPGLHBD, bool EAHLGMIALAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1AA59F0", Offset = "0x1AA43F0", VA = "0x181AA59F0")]
	public IBLGCFPDBMG(Guid ENGHOHIFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x654A5E0", Offset = "0x6548FE0", VA = "0x18654A5E0")]
	internal bool JPBFJKJIHMJ(AJBAMMPICME NENPCPGLHBD, long NONCNHOOAEO, Action<IBLGCFPDBMG, int> LFNPGJEBIHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x654A7D0", Offset = "0x65491D0", VA = "0x18654A7D0")]
	internal void KGFKOHBLJNC(long DDOCCIIHCAD, Action<IBLGCFPDBMG, int> LFNPGJEBIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CCKHAHKJIMD : IEquatable<CCKHAHKJIMD>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int EHHGCJOIBJI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int EFJPKLKHBFE = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int GPGNIEKMIOD = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int KBLIGJACABO = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid CEAMOGLKFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1C094C0", Offset = "0x1C07EC0", VA = "0x181C094C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NKPOBKBEPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE56B80", Offset = "0xE55580", VA = "0x180E56B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HINAJBIGBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string BAHDIONAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A9430", Offset = "0x7A7E30", VA = "0x1807A9430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime JPCDDEAMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19BEE80", Offset = "0x19BD880", VA = "0x1819BEE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime PCIFBEKBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A9220", Offset = "0x7A7C20", VA = "0x1807A9220")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19EA110", Offset = "0x19E8B10", VA = "0x1819EA110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HashSet<long> FAIIMJNGJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A91A0", Offset = "0x7A7BA0", VA = "0x1807A91A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9190", Offset = "0x7A7B90", VA = "0x1807A9190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public RoomInventoryItemProperties FEHOFHIGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9160", Offset = "0x7A7B60", VA = "0x1807A9160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A90F0", Offset = "0x7A7AF0", VA = "0x1807A90F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x654A4A0", Offset = "0x6548EA0", VA = "0x18654A4A0")]
	public CCKHAHKJIMD(ICLLOFPAKFJ NENPCPGLHBD, [Optional] RoomInventoryItemProperties JAMEDNMIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6549D70", Offset = "0x6548770", VA = "0x186549D70", Slot = "4")]
	public bool Equals(CCKHAHKJIMD AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6549EF0", Offset = "0x65488F0", VA = "0x186549EF0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x654A0D0", Offset = "0x6548AD0", VA = "0x18654A0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x654A1B0", Offset = "0x6548BB0", VA = "0x18654A1B0")]
	private HashSet<long> JPHLMINCLJB(ICLLOFPAKFJ NENPCPGLHBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KHODDGPDFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private IBLGCFPDBMG NFIAJHEOMDP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CCKHAHKJIMD DMHKJCJHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IBLGCFPDBMG LHFEEDPNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x654A910", Offset = "0x6549310", VA = "0x18654A910")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x654A9A0", Offset = "0x65493A0", VA = "0x18654A9A0")]
	public KHODDGPDFOE(CCKHAHKJIMD DBMHKIPIMAE, [Optional] IBLGCFPDBMG NFIAJHEOMDP)
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
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x654AFE0", Offset = "0x65499E0", VA = "0x18654AFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A4B80", VA = "0x1807A6180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CF0", Offset = "0x7B46F0", VA = "0x1807B5CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9183A0", Offset = "0x916DA0", VA = "0x1809183A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x918390", Offset = "0x916D90", VA = "0x180918390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BJFAENJLBCA Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
			[CompilerGenerated]
			get
			{
				return default(BJFAENJLBCA);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1070", Offset = "0x7AFA70", VA = "0x1807B1070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x654AEA0", Offset = "0x65498A0", VA = "0x18654AEA0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x654AEE0", Offset = "0x65498E0", VA = "0x18654AEE0")]
		public static RoomInventoryItemProperties GOIMIPPOIPI(RoomInventoryItemProperties JAMEDNMIIII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A49450", Offset = "0x1A47E50", VA = "0x181A49450")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MNIMDIKNONC
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const int MKJJFBCFJCP = 10;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public long LJCMLPJKDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x128B590", Offset = "0x1289F90", VA = "0x18128B590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public RoomInventoryTagClientProperties FEHOFHIGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JFOOOEHILIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x654AD40", Offset = "0x6549740", VA = "0x18654AD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x654AD60", Offset = "0x6549760", VA = "0x18654AD60")]
	public MNIMDIKNONC(OANHNGLCGCM NENPCPGLHBD, [Optional] RoomInventoryTagClientProperties JAMEDNMIIII)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x654B230", Offset = "0x6549C30", VA = "0x18654B230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A4B80", VA = "0x1807A6180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CF0", Offset = "0x7B46F0", VA = "0x1807B5CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x654B030", Offset = "0x6549A30", VA = "0x18654B030")]
		public void AKLAGPCNEOM(Dictionary<string, object> NFCAPOLGADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class PEHCECIIGLM
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x654AE40", Offset = "0x6549840", VA = "0x18654AE40")]
	public static int FEMEELBCLDH(long OBKHJBKAEPG)
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
