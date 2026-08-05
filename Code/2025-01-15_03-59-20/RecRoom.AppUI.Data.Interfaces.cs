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
public interface OMJBMNDENLE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> BKFBBHKLCKO(bool BAHKHONNKBA, int EAINDCGPNCK, CancellationToken CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AIDPAHIFJDL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPAOMNDEDMO(PIPCEIFGMAA MFIGDOAMPLE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCEABLLAAMA(NLMAEEICDJF CIOKBAAIBPO, BEANCEBHDPC ELONMONDCOI, bool HFOCFDLPOMD, PJONPPOEIME EDDJKDEFFLJ, [Optional] GNODDIAAKFD JMJPKINNKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JOLGMCMGLGG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<PIPCEIFGMAA>> HFOEPNJKKKE(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE, [Optional] Func<bool> PIBLGJMMGCG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PIPCEIFGMAA> NMKPCOGKEPO(long GGLEGKBAGLC, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NLMAEEICDJF> LFOPHPBGAFM(long GGLEGKBAGLC, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGMDOKHAMCF(long GGLEGKBAGLC, [Out] int AHAFONDBFBO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HNLNCDFMAHN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GNODDIAAKFD> POMFLPAMJBB(BEANCEBHDPC ELONMONDCOI, CancellationToken CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GNODDIAAKFD> ECBMKAIJANC(BEANCEBHDPC ELONMONDCOI, CancellationToken CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DLCOEACENMD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KKBIHBEKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCIDFGCEFED(RoomListQueryData GLMFHHIGGDM);
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum ECELHNAMEEF
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum AIGPNOEADDF
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum CEAAAAOKMBC
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum PFCPJPBLCNO
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum LMCEHFKEDBE
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum AKJAFKHMEIF
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum ACPAMEGJCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum IIGLKEGKFNM
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum LPPGPJKCOHF
		{
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public ECELHNAMEEF QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.MyRelated)]
		public AIGPNOEADDF MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.PlayerRelated)]
		public CEAAAAOKMBC PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.StaticListSources)]
		public PFCPJPBLCNO StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.DynamicAlgorithmicSources)]
		public LMCEHFKEDBE DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.ClubhouseRelated)]
		public AKJAFKHMEIF ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.RecRoomCreatorAcademyRelated)]
		public ACPAMEGJCEJ RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[HFJGENLBJBK("QuerySource", ECELHNAMEEF.KeepsakeRoomRelated)]
		public IIGLKEGKFNM KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[HFJGENLBJBK("MySource", AIGPNOEADDF.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[HFJGENLBJBK("RequiresOtherPlayerId", true)]
		public LPPGPJKCOHF PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[HFJGENLBJBK("StaticListSource", PFCPJPBLCNO.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[HFJGENLBJBK("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[HFJGENLBJBK("DynamicAlgorithmicSource", LMCEHFKEDBE.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[HFJGENLBJBK("DynamicAlgorithmicSource", LMCEHFKEDBE.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x99DFB0", Offset = "0x99D3B0", VA = "0x18099DFB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAB20B0", Offset = "0xAB14B0", VA = "0x180AB20B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x230E020", Offset = "0x230D420", VA = "0x18230E020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9B6920", Offset = "0x9B5D20", VA = "0x1809B6920")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9B69D0", Offset = "0x9B5DD0", VA = "0x1809B69D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CAF40", Offset = "0x8CA340", VA = "0x1808CAF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8EE380", Offset = "0x8ED780", VA = "0x1808EE380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE0", Offset = "0x8CEEE0", VA = "0x1808CFAE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC616E0", Offset = "0xC60AE0", VA = "0x180C616E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xC600C0", Offset = "0xC5F4C0", VA = "0x180C600C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB40", Offset = "0x8CEF40", VA = "0x1808CFB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB70", Offset = "0x8CEF70", VA = "0x1808CFB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA8BFE0", Offset = "0xA8B3E0", VA = "0x180A8BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA8C040", Offset = "0xA8B440", VA = "0x180A8C040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA8C2A0", Offset = "0xA8B6A0", VA = "0x180A8C2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x97C760", Offset = "0x97BB60", VA = "0x18097C760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x97C770", Offset = "0x97BB70", VA = "0x18097C770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9EBBD0", Offset = "0x9EAFD0", VA = "0x1809EBBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B020", Offset = "0x6E1A420", VA = "0x186E1B020")]
		public List<string> DFODNKBACDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B260", Offset = "0x6E1A660", VA = "0x186E1B260")]
		public List<string> IPIHOOKDNBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B270", Offset = "0x6E1A670", VA = "0x186E1B270")]
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
