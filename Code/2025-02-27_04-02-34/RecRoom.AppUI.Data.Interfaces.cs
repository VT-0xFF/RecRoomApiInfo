using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AppUI.Data;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LOHONBJIAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOKNFHGBHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PHPBMBFHLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NCGLOGBLLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FKDOIPNGGAF KAKCOMNOIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FKDOIPNGGAF GOBCGNFKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<int>> EFCADBKDPLL(CancellationToken LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MPMIOCOIGFM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	ServerSearch,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Friends,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Blocked,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Recent,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Nearby,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Creator,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	RoomRelated,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	ChatThread,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PartyMembers,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Favorited,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Custom,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	LocalAndMutualBlocks
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CNEECBMDDOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Online,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	OnlineInOtherRooms,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	InRoom,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	WithItemWishlisted,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	AttendingEvent,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	MutualFriends
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CAFIIBFPHBP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	MySubscriptions,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TopCreators
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LFIMEOCOPIK
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Owners,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Moderators
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AccountListQueryData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MPMIOCOIGFM QueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[FKOECLOBFCN("QueryType", MPMIOCOIGFM.Friends)]
		public CNEECBMDDOJ FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[FKOECLOBFCN("QueryType", MPMIOCOIGFM.Creator)]
		public CAFIIBFPHBP CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[FKOECLOBFCN("QueryType", MPMIOCOIGFM.RoomRelated)]
		public LFIMEOCOPIK RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int MaxResultLimit;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x202F3F0", Offset = "0x202E7F0", VA = "0x18202F3F0")]
		public AccountListQueryData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JKKPMFKNCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int JFPFICFFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DBEECBAIEKP> EBGNOICFMLO(int NJNOPMJJKAE, CancellationToken LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	List<int> GHBAKBGODIN(AccountListQueryData LLPIBDHHKEE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKIOGGKCKID(AccountListQueryData LLPIBDHHKEE, Action OCIEANDEEKC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBOAJFKPMGD(AccountListQueryData LLPIBDHHKEE, Action OCIEANDEEKC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PGEJBAPDILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public string AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public string CLEIKEPCGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public string CHNFGMLLKIP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public PGEJBAPDILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GNEPGHJKIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public string IMLCGJJGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public List<string> CCHDINFICIF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GNEPGHJKIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IKGGNJPFIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<GNEPGHJKIAO> DPMJBOJGBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public List<PGEJBAPDILH> OKKHADDOJDL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IKGGNJPFIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IHBHDLPJDGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public string HKOPNCNFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string IMLCGJJGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public string NLOEABCEBMP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IHBHDLPJDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HMHJEPGBGDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string HKOPNCNFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string IMLCGJJGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public List<IHBHDLPJDGB> FMJAKLDKGAH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public HMHJEPGBGDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KIGJGNEEDOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public List<HMHJEPGBGDA> FMJAKLDKGAH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public KIGJGNEEDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EEEFAOGBHFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FKDOIPNGGAF GKIMDPGHIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<string> IEFECFAJMNN;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<string>> JKGMDAOPEGK(string FPHLHEOFFDL, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<KIGJGNEEDOF> PNPJNKFNIJJ(CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MKDOOAILPDB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> IFBPHLLNCDL(bool GLOLKGNBEBI, int CGIGPEEEAAB, CancellationToken LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HFLHAJEFECF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FKDOIPNGGAF NAFGPAKNAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<IJBHONDDGJA>> EMGGMKLDFAM(CancellationToken LAAJFAFNFCN, bool INFPMMIMNBC = false, int CCCJCLAKKDD = -1, bool CGCBEDKHBKM = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BOIJNLEABKE(IJBHONDDGJA NKILLPHANBF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IIHOLPABEOD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIJIPDMHNJL();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIENPHFKLMF(NBOGHBPKEMA KMMJGNHILKN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MLCOAOJLAEL(ALHPBBOBFGN KMMJGNHILKN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABOEBAAEPNP(EPDFKONBMMJ OCNEFBOFEOP, KOLBKODMCOP OILMJLBENOE, bool AADHKHNEFAB, DDHAEMNNJCB IOMMMEDMKKD, [Optional] CCDAHBCPCKI CCIMNDEGKOO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CNHEGPKFIDO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<ALHPBBOBFGN>> EEPDNNLKHIC(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN, [Optional] Func<bool> MODFFFNPGHF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ALHPBBOBFGN> MIDMPFMPOEN(long FFFLOIOFAMB, CancellationToken LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EPDFKONBMMJ> CMJDMNBOIGG(long FFFLOIOFAMB, CancellationToken LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBCIOPOKDFJ(long FFFLOIOFAMB, [Out] int CJBNKLPJJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OGFOKCFEOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCDAHBCPCKI> LDJLNIAFDHG(KOLBKODMCOP OILMJLBENOE, CancellationToken LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CCDAHBCPCKI> HOPLJOFMBDH(KOLBKODMCOP OILMJLBENOE, CancellationToken LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EMKKBBONOCA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CFPMDBNKFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool OIOMAOLKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int JFPFICFFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EPDFKONBMMJ LOFGFEACKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FKDOIPNGGAF JJMLJNHCLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FKDOIPNGGAF OKEAFDDELID
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FKDOIPNGGAF KKELPPIBGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MJMKICOGPAE(RoomListQueryData LLPIBDHHKEE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task BOIJNLEABKE(IJBHONDDGJA KHMDHCGEJCA);
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum NNOBBNPHILI
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum FLCFCMECPDG
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum MPGODPOEKIL
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum DAEBENPBOFK
		{
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum PEOCOLFPIPA
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum MNJGIMHCIDB
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum EKHOFDJKCFP
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum MEEMBKNDALB
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum FJMPDELKNBO
		{
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NNOBBNPHILI QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.MyRelated)]
		public FLCFCMECPDG MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.PlayerRelated)]
		public MPGODPOEKIL PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.StaticListSources)]
		public DAEBENPBOFK StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.DynamicAlgorithmicSources)]
		public PEOCOLFPIPA DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.ClubhouseRelated)]
		public MNJGIMHCIDB ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.RecRoomCreatorAcademyRelated)]
		public EKHOFDJKCFP RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FKOECLOBFCN("QuerySource", NNOBBNPHILI.KeepsakeRoomRelated)]
		public MEEMBKNDALB KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[FKOECLOBFCN("MySource", FLCFCMECPDG.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FKOECLOBFCN("RequiresOtherPlayerId", true)]
		public FJMPDELKNBO PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[FKOECLOBFCN("StaticListSource", DAEBENPBOFK.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[FKOECLOBFCN("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[FKOECLOBFCN("DynamicAlgorithmicSource", PEOCOLFPIPA.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[FKOECLOBFCN("DynamicAlgorithmicSource", PEOCOLFPIPA.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC07FD0", Offset = "0xC073D0", VA = "0x180C07FD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCFBE70", Offset = "0xCFB270", VA = "0x180CFBE70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2536FB0", Offset = "0x25363B0", VA = "0x182536FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA60780", Offset = "0xA5FB80", VA = "0x180A60780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07950", VA = "0x180C08550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x94FD90", Offset = "0x94F190", VA = "0x18094FD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x94FD10", Offset = "0x94F110", VA = "0x18094FD10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x971C10", Offset = "0x971010", VA = "0x180971C10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x955550", Offset = "0x954950", VA = "0x180955550")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x955640", Offset = "0x954A40", VA = "0x180955640")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xEB8B70", Offset = "0xEB7F70", VA = "0x180EB8B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xEB8990", Offset = "0xEB7D90", VA = "0x180EB8990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x955620", Offset = "0x954A20", VA = "0x180955620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x955600", Offset = "0x954A00", VA = "0x180955600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCDF050", Offset = "0xCDE450", VA = "0x180CDF050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCF21F0", Offset = "0xCF15F0", VA = "0x180CF21F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF2200", Offset = "0xCF1600", VA = "0x180CF2200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF2030", VA = "0x180CF2C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBDB1F0", Offset = "0xBDA5F0", VA = "0x180BDB1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBDA600", VA = "0x180BDB200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB6EF10", Offset = "0xB6E310", VA = "0x180B6EF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x725BB80", Offset = "0x725AF80", VA = "0x18725BB80")]
		public List<string> NBDKPKBIOIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x725BB70", Offset = "0x725AF70", VA = "0x18725BB70")]
		public List<string> BBHOEPOIBLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x725BDC0", Offset = "0x725B1C0", VA = "0x18725BDC0")]
		public RoomListQueryData()
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
