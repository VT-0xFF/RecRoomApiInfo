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
public interface NOADEEKBJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> JPBBJOOOGCF(bool MONNIKAAGMI, int CKAENKEABLC, CancellationToken BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DOBANDLDJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCJNPBGJFEK(ADGABPOJFPO PBPEOMJKKKC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAONLEIKGBI(OAOBEPBAJLE BGDELDLHBMB, CNMPJHKKKIM PIBGHFKDAOK, bool JDNCDKFOJGA, PNIOOCKILGF IGFMGKDOOHI, [Optional] GLPOHAHMIGG AHGOPEHCPCE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BHNGCGAOKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<ADGABPOJFPO>> JMCLJIBEDPD(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM, [Optional] Func<bool> HKHONNDNJIB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ADGABPOJFPO> EEDILAMAACI(long MOMKFNIIPAA, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OAOBEPBAJLE> MJNHMHCDOJG(long MOMKFNIIPAA, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPJGJCJIKPP(long MOMKFNIIPAA, [Out] int COKGNHFKNEF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DGCJNLNOHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLPOHAHMIGG> IJOOKAJJHHH(CNMPJHKKKIM PIBGHFKDAOK, CancellationToken BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GLPOHAHMIGG> ECLIOLLNFHJ(CNMPJHKKKIM PIBGHFKDAOK, CancellationToken BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DAFHFNLOIHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BGHBLIIAENH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKJBJGIJDAF(RoomListQueryData APCBJIPDHLK);
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum GMEKJHPNFLJ
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
		public enum NMDLJHLJEPP
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
		public enum FHKBMBMKKHJ
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
		public enum BFJFGCDMKNB
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
		public enum LNKIMMFCHAC
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
		public enum KNDEMLJKCAB
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum IOKHOAGHKBI
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
		public enum EENICOPIEIK
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
		public enum BNODGNGLEAG
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
		public GMEKJHPNFLJ QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.MyRelated)]
		public NMDLJHLJEPP MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.PlayerRelated)]
		public FHKBMBMKKHJ PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.StaticListSources)]
		public BFJFGCDMKNB StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.DynamicAlgorithmicSources)]
		public LNKIMMFCHAC DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.ClubhouseRelated)]
		public KNDEMLJKCAB ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.RecRoomCreatorAcademyRelated)]
		public IOKHOAGHKBI RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[CGOLJFLDDGE("QuerySource", GMEKJHPNFLJ.KeepsakeRoomRelated)]
		public EENICOPIEIK KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[CGOLJFLDDGE("MySource", NMDLJHLJEPP.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[CGOLJFLDDGE("RequiresOtherPlayerId", true)]
		public BNODGNGLEAG PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[CGOLJFLDDGE("StaticListSource", BFJFGCDMKNB.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[CGOLJFLDDGE("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[CGOLJFLDDGE("DynamicAlgorithmicSource", LNKIMMFCHAC.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[CGOLJFLDDGE("DynamicAlgorithmicSource", LNKIMMFCHAC.CarouselEndpoint)]
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
			[Cpp2IlInjected.Address(RVA = "0xBFC380", Offset = "0xBFB580", VA = "0x180BFC380")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE9B40", Offset = "0xCE8D40", VA = "0x180CE9B40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x24E38C0", Offset = "0x24E2AC0", VA = "0x1824E38C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA56060", Offset = "0xA55260", VA = "0x180A56060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xBFDD90", Offset = "0xBFCF90", VA = "0x180BFDD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8F2240", Offset = "0x8F1440", VA = "0x1808F2240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x91AA20", Offset = "0x919C20", VA = "0x18091AA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F91E0", Offset = "0x8F83E0", VA = "0x1808F91E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEB6520", Offset = "0xEB5720", VA = "0x180EB6520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xEB6610", Offset = "0xEB5810", VA = "0x180EB6610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F9260", Offset = "0x8F8460", VA = "0x1808F9260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8F9210", Offset = "0x8F8410", VA = "0x1808F9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCEA770", Offset = "0xCE9970", VA = "0x180CEA770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCEA760", Offset = "0xCE9960", VA = "0x180CEA760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCEA7D0", Offset = "0xCE99D0", VA = "0x180CEA7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAB89E0", Offset = "0xAB7BE0", VA = "0x180AB89E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCF3C60", Offset = "0xCF2E60", VA = "0x180CF3C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBD1840", Offset = "0xBD0A40", VA = "0x180BD1840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBD1850", Offset = "0xBD0A50", VA = "0x180BD1850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB65170", Offset = "0xB64370", VA = "0x180B65170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x703DB30", Offset = "0x703CD30", VA = "0x18703DB30")]
		public List<string> GMDNIHAMGHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x703DD70", Offset = "0x703CF70", VA = "0x18703DD70")]
		public List<string> PMHOIANOPMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x703DD80", Offset = "0x703CF80", VA = "0x18703DD80")]
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
