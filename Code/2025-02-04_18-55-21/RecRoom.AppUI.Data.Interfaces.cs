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
public interface CALOLFCNJLO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> HHMFGFFBPOK(bool PBNBMIKBBPJ, int LIEIBKHBHEL, CancellationToken HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NPAGANPMLFE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKBDENFBPFP(PJIJPHIAAAH EFFHEJGJIEE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACAJEHDLFLC(DGCCNGNLMNC KGMCCCOKBDB, DADBLAJODHB IENBCIOOFAA, bool CJCLLIDDKED, JMKHKMHBFBD HKEKCDDGAKH, [Optional] KGAIHJLHFDH POLMBGIFLNK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KBEMJLBENNH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<PJIJPHIAAAH>> ILMIBCMGNOM(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC, [Optional] Func<bool> DEKBGKENHAJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PJIJPHIAAAH> ELNGLJPOPMC(long OGMIFIGJENM, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DGCCNGNLMNC> DEAFAHKGEGP(long OGMIFIGJENM, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCPBJNPJLND(long OGMIFIGJENM, [Out] int IPHJMBDJDJN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PPLLAFJKCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KGAIHJLHFDH> ICNGLJAJOAF(DADBLAJODHB IENBCIOOFAA, CancellationToken HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KGAIHJLHFDH> AADOCIFJPKE(DADBLAJODHB IENBCIOOFAA, CancellationToken HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BOHPGCEDCNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IOFFLNAMONC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGGHHKDEEMB(RoomListQueryData CGNDNFEKAPC);
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum GNDMLCBPAOG
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
		public enum NFJNIDIDHAC
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
		public enum MKMDJGBGICF
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
		public enum IMGKKCBAAOI
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
		public enum LKGAEMNFLBF
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
		public enum GMJGKHMEGEE
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum DDAJLJAKNLK
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
		public enum GLBBMOCOCOD
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
		public enum BJLBMBJPKBI
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
		public GNDMLCBPAOG QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.MyRelated)]
		public NFJNIDIDHAC MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.PlayerRelated)]
		public MKMDJGBGICF PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.StaticListSources)]
		public IMGKKCBAAOI StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.DynamicAlgorithmicSources)]
		public LKGAEMNFLBF DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.ClubhouseRelated)]
		public GMJGKHMEGEE ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.RecRoomCreatorAcademyRelated)]
		public DDAJLJAKNLK RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[POFEBHABCEJ("QuerySource", GNDMLCBPAOG.KeepsakeRoomRelated)]
		public GLBBMOCOCOD KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[POFEBHABCEJ("MySource", NFJNIDIDHAC.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[POFEBHABCEJ("RequiresOtherPlayerId", true)]
		public BJLBMBJPKBI PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[POFEBHABCEJ("StaticListSource", IMGKKCBAAOI.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[POFEBHABCEJ("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[POFEBHABCEJ("DynamicAlgorithmicSource", LKGAEMNFLBF.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[POFEBHABCEJ("DynamicAlgorithmicSource", LKGAEMNFLBF.CarouselEndpoint)]
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
			[Cpp2IlInjected.Address(RVA = "0xC2A540", Offset = "0xC29340", VA = "0x180C2A540")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0B410", Offset = "0xD0A210", VA = "0x180D0B410")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x250E640", Offset = "0x250D440", VA = "0x18250E640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA75F00", Offset = "0xA74D00", VA = "0x180A75F00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xC17E90", Offset = "0xC16C90", VA = "0x180C17E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8F4450", Offset = "0x8F3250", VA = "0x1808F4450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8F4220", Offset = "0x8F3020", VA = "0x1808F4220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x91D6E0", Offset = "0x91C4E0", VA = "0x18091D6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB250", VA = "0x1808FC450")]
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
			[Cpp2IlInjected.Address(RVA = "0xED8F60", Offset = "0xED7D60", VA = "0x180ED8F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xED90C0", Offset = "0xED7EC0", VA = "0x180ED90C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8FC480", Offset = "0x8FB280", VA = "0x1808FC480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8FC2E0", Offset = "0x8FB0E0", VA = "0x1808FC2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFE460", VA = "0x180CFF660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCFFCF0", Offset = "0xCFEAF0", VA = "0x180CFFCF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCFFD00", Offset = "0xCFEB00", VA = "0x180CFFD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBF3340", Offset = "0xBF2140", VA = "0x180BF3340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBF3350", Offset = "0xBF2150", VA = "0x180BF3350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB86D40", Offset = "0xB85B40", VA = "0x180B86D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x709AEB0", Offset = "0x7099CB0", VA = "0x18709AEB0")]
		public List<string> BCGNHLPPCHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x709B0F0", Offset = "0x7099EF0", VA = "0x18709B0F0")]
		public List<string> EACKJBKLNGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x709B100", Offset = "0x7099F00", VA = "0x18709B100")]
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
