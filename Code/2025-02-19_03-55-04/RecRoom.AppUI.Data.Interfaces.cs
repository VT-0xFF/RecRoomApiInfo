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
public interface KCLNGKFGMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> JPDPNBMMBLA(bool GDJGIAGNCBP, int PCJEDDEFLMO, CancellationToken IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BDANNHMJMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMCHLHNFBDG(JCOCCFMLIAE JPHOBLFNMNH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGEFBHOFGFH(BCPENJPKFJJ MDPGCFDKEND, FFBHBDHOGKB ICHBBGHLOON, bool LBHBNIFOLPE, PINBABNPMHD PJINHCHFNOH, [Optional] IPHHHIANCDI OEBHAJLKLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OJNIPBPGFNF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<JCOCCFMLIAE>> CDPNGOFDGAJ(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL, [Optional] Func<bool> FEMBNPFKOOA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JCOCCFMLIAE> JHOIPPBJCJD(long EPGJLNEAJPA, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BCPENJPKFJJ> PEAAOKBKBKB(long EPGJLNEAJPA, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNIDHMNJDAN(long EPGJLNEAJPA, [Out] int EAGLKPCKNFH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ALADGKBEPJH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IPHHHIANCDI> NJJOHGAILJB(FFBHBDHOGKB ICHBBGHLOON, CancellationToken IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IPHHHIANCDI> AHLHEHIKHPO(FFBHBDHOGKB ICHBBGHLOON, CancellationToken IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MFKFGBIAKOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GIHDHCCCKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IIFKJJCPHEL(RoomListQueryData BAHFLOKBEBD);
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FNADCICLNOF
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
		public enum HNBNHEIJJCE
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
		public enum NAPCIKIHIOC
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
		public enum HINDHGAEALD
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
		public enum NMBNOFOONJB
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
		public enum AJEBKNNEHJO
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum FBLGHLEJMLN
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
		public enum JIALGKMBEEP
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
		public enum LAKKHCDDGOO
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
		public FNADCICLNOF QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.MyRelated)]
		public HNBNHEIJJCE MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.PlayerRelated)]
		public NAPCIKIHIOC PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.StaticListSources)]
		public HINDHGAEALD StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.DynamicAlgorithmicSources)]
		public NMBNOFOONJB DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.ClubhouseRelated)]
		public AJEBKNNEHJO ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.RecRoomCreatorAcademyRelated)]
		public FBLGHLEJMLN RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[HDIPNKIBINK("QuerySource", FNADCICLNOF.KeepsakeRoomRelated)]
		public JIALGKMBEEP KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[HDIPNKIBINK("MySource", HNBNHEIJJCE.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[HDIPNKIBINK("RequiresOtherPlayerId", true)]
		public LAKKHCDDGOO PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[HDIPNKIBINK("StaticListSource", HINDHGAEALD.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[HDIPNKIBINK("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[HDIPNKIBINK("DynamicAlgorithmicSource", NMBNOFOONJB.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[HDIPNKIBINK("DynamicAlgorithmicSource", NMBNOFOONJB.CarouselEndpoint)]
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
			[Cpp2IlInjected.Address(RVA = "0xBEA7E0", Offset = "0xBE93E0", VA = "0x180BEA7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFFAD0", Offset = "0xCFE6D0", VA = "0x180CFFAD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x250AA40", Offset = "0x2509640", VA = "0x18250AA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0B0", Offset = "0xA6CCB0", VA = "0x180A6E0B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xBE8FF0", Offset = "0xBE7BF0", VA = "0x180BE8FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x961530", Offset = "0x960130", VA = "0x180961530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x97FE30", Offset = "0x97EA30", VA = "0x18097FE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230")]
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
			[Cpp2IlInjected.Address(RVA = "0x963180", Offset = "0x961D80", VA = "0x180963180")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBE900", Offset = "0xEBD500", VA = "0x180EBE900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xEBEA20", Offset = "0xEBD620", VA = "0x180EBEA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x963170", Offset = "0x961D70", VA = "0x180963170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9630D0", Offset = "0x961CD0", VA = "0x1809630D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCE2060", Offset = "0xCE0C60", VA = "0x180CE2060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCF5CF0", Offset = "0xCF48F0", VA = "0x180CF5CF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCF5D40", Offset = "0xCF4940", VA = "0x180CF5D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAC2650", Offset = "0xAC1250", VA = "0x180AC2650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCF11F0", Offset = "0xCEFDF0", VA = "0x180CF11F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBCAC00", Offset = "0xBC9800", VA = "0x180BCAC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79C30", VA = "0x180B7B030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72C23A0", Offset = "0x72C0FA0", VA = "0x1872C23A0")]
		public List<string> MNCLPDGCGGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72C2390", Offset = "0x72C0F90", VA = "0x1872C2390")]
		public List<string> AFNHBIHGDNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72C25E0", Offset = "0x72C11E0", VA = "0x1872C25E0")]
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
