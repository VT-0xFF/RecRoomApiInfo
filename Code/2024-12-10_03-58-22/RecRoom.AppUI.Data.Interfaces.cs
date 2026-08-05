using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AppUI.Data;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ECFDGKNJNIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<long>> BONPHEMNLLG(bool KOPKGHEINPO, int DMENJGPBAAO, CancellationToken DGGGDIFONNG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IPLIGOLFCIB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<EKHCBLLPBBB>> LPKNAJEKAMC(RoomListQueryData JONFNMFHMHH, CancellationToken DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EKHCBLLPBBB> INGALIBDHEF(long GLOFJPFEAOO, CancellationToken DGGGDIFONNG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KBPKDCKMHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IINOPEPPNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.AppUI.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum NNODHNNDIJI
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum HHKLCGBALJE
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BDFMEOIKNOA
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum GDCDKJLHBCA
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum GGAEMBGBDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum BLELELDPHOI
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public enum BKGNGFNMBJM
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DIOAKDCIFLP
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum EHBLFOHOPGI
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public NNODHNNDIJI QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.MyRelated)]
		public HHKLCGBALJE MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.PlayerRelated)]
		public BDFMEOIKNOA PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.StaticListSources)]
		public GDCDKJLHBCA StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.DynamicAlgorithmicSources)]
		public GGAEMBGBDHJ DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.ClubhouseRelated)]
		public BLELELDPHOI ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.RecRoomCreatorAcademyRelated)]
		public BKGNGFNMBJM RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[ELBALDKMPMI("QuerySource", NNODHNNDIJI.KeepsakeRoomRelated)]
		public DIOAKDCIFLP KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[ELBALDKMPMI("MySource", HHKLCGBALJE.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ELBALDKMPMI("RequiresOtherPlayerId", true)]
		public EHBLFOHOPGI PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ELBALDKMPMI("StaticListSource", GDCDKJLHBCA.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[ELBALDKMPMI("StaticListSource", GDCDKJLHBCA.PlaylistByName)]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[ELBALDKMPMI("DynamicAlgorithmicSource", GGAEMBGBDHJ.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[ELBALDKMPMI("DynamicAlgorithmicSource", GGAEMBGBDHJ.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x13DE460", Offset = "0x13DD060", VA = "0x1813DE460")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FDF20", Offset = "0x8FCB20", VA = "0x1808FDF20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8FCF40", Offset = "0x8FBB40", VA = "0x1808FCF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x109C760", Offset = "0x109B360", VA = "0x18109C760")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xFF7870", Offset = "0xFF6470", VA = "0x180FF7870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x88E980", Offset = "0x88D580", VA = "0x18088E980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x88EA80", Offset = "0x88D680", VA = "0x18088EA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CF60", Offset = "0x6A7BB60", VA = "0x186A7CF60")]
		public List<string> FECJDMFEPIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D1A0", Offset = "0x6A7BDA0", VA = "0x186A7D1A0")]
		public List<string> LNKOOGJFBLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D1B0", Offset = "0x6A7BDB0", VA = "0x186A7D1B0")]
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
