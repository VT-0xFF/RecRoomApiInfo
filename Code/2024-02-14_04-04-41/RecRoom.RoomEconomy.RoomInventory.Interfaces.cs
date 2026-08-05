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
		[Cpp2IlInjected.Address(RVA = "0x64D07C0", Offset = "0x64CFBC0", VA = "0x1864D07C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64D07D0", Offset = "0x64CFBD0", VA = "0x1864D07D0")]
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
	KKEEGFAPLDK AFCNOHIGDGJ
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
	Task<KKHLNMGODKL<CCKHAHKJIMD, string>> DKIFPGILDLL(Guid ENGHOHIFJBB, [Optional] string OMHHPMIDNAN, [Optional] string NDBGGHMJKHH, [Optional] string EPNGDFLAIGO, [Optional] RoomInventoryItemProperties JAMEDNMIIII);

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
	bool OFGPGHELLDF(Guid ENGHOHIFJBB, [Out] IBLGCFPDBMG NFIAJHEOMDP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<int> FAAJFBOLKBG(PFJNLKLKGNM LGJIBLMCMPJ, Guid ENGHOHIFJBB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<LENLEFPMOBB> LHNFHIEOKBL(PFJNLKLKGNM LGJIBLMCMPJ, Guid ENGHOHIFJBB, int OGKNDCGCKLO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	string OIPODCKCACA(GLNOABNHEPM MNKBHKEBOPJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FKJIFENPIJP();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLFHFHDEOOJ : GHMDLIDMDLH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
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
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64D0320", Offset = "0x64CF720", VA = "0x1864D0320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HMDBDADMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x64D0300", Offset = "0x64CF700", VA = "0x1864D0300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BICDIBOOCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x79F410", Offset = "0x79E810", VA = "0x18079F410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long ONCDPKNBLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A8170", Offset = "0x7A7570", VA = "0x1807A8170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? JBMPLBDJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCD0", Offset = "0x7AB0D0", VA = "0x1807ABCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCC0", Offset = "0x7AB0C0", VA = "0x1807ABCC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NENNJKFBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8420D0", Offset = "0x8414D0", VA = "0x1808420D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19CBBA0", Offset = "0x19CAFA0", VA = "0x1819CBBA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64D0330", Offset = "0x64CF730", VA = "0x1864D0330")]
	public IBLGCFPDBMG(AJBAMMPICME NENPCPGLHBD, bool EAHLGMIALAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1A8CB90", Offset = "0x1A8BF90", VA = "0x181A8CB90")]
	public IBLGCFPDBMG(Guid ENGHOHIFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64D00B0", Offset = "0x64CF4B0", VA = "0x1864D00B0")]
	internal bool JPBFJKJIHMJ(AJBAMMPICME NENPCPGLHBD, long NONCNHOOAEO, Action<IBLGCFPDBMG, int> LFNPGJEBIHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64D02A0", Offset = "0x64CF6A0", VA = "0x1864D02A0")]
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
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1BEF8C0", Offset = "0x1BEECC0", VA = "0x181BEF8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NKPOBKBEPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE46BC0", Offset = "0xE45FC0", VA = "0x180E46BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HINAJBIGBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string BAHDIONAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79F430", Offset = "0x79E830", VA = "0x18079F430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime JPCDDEAMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79F150", Offset = "0x79E550", VA = "0x18079F150")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x19A63A0", Offset = "0x19A57A0", VA = "0x1819A63A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime PCIFBEKBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79F220", Offset = "0x79E620", VA = "0x18079F220")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19D1600", Offset = "0x19D0A00", VA = "0x1819D1600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties FEHOFHIGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79F1A0", Offset = "0x79E5A0", VA = "0x18079F1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79F190", Offset = "0x79E590", VA = "0x18079F190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x64CFF90", Offset = "0x64CF390", VA = "0x1864CFF90")]
	public CCKHAHKJIMD(ICLLOFPAKFJ NENPCPGLHBD, [Optional] RoomInventoryItemProperties JAMEDNMIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x64CFB50", Offset = "0x64CEF50", VA = "0x1864CFB50", Slot = "4")]
	public bool Equals(CCKHAHKJIMD AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x64CFCD0", Offset = "0x64CF0D0", VA = "0x1864CFCD0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x64CFEB0", Offset = "0x64CF2B0", VA = "0x1864CFEB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KHODDGPDFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IBLGCFPDBMG NFIAJHEOMDP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CCKHAHKJIMD DMHKJCJHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IBLGCFPDBMG LHFEEDPNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64D03E0", Offset = "0x64CF7E0", VA = "0x1864D03E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64D0470", Offset = "0x64CF870", VA = "0x1864D0470")]
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
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x64D09B0", Offset = "0x64CFDB0", VA = "0x1864D09B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79C180", Offset = "0x79B580", VA = "0x18079C180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90CD90", Offset = "0x90C190", VA = "0x18090CD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x90CD80", Offset = "0x90C180", VA = "0x18090CD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BJFAENJLBCA Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
			[CompilerGenerated]
			get
			{
				return default(BJFAENJLBCA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7A7070", Offset = "0x7A6470", VA = "0x1807A7070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x64D0870", Offset = "0x64CFC70", VA = "0x1864D0870", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x64D08B0", Offset = "0x64CFCB0", VA = "0x1864D08B0")]
		public static RoomInventoryItemProperties GOIMIPPOIPI(RoomInventoryItemProperties JAMEDNMIIII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A30730", Offset = "0x1A2FB30", VA = "0x181A30730")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PEHCECIIGLM
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x64D0810", Offset = "0x64CFC10", VA = "0x1864D0810")]
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
