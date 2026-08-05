using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RRUI.Navigation;
using RecNet;
using RecRoom.AppUI.Data;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface IPlayerColor
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Color GetColorForType(IPlayerUIBridge.PlayerColorType colorType, Color defaultColor, Color customColor, [Out] bool useGradient);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IPlayerUIBridge : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum DeveloperDisplayModes : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			CommunityTeam,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			Developer,
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			Moderator
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum PlayerColorType
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			NAME,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			TEAM,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			PARTY,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			NAME_OR_CUSTOM_COLOR_IF_RR_PLUS,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			NAME_OR_CUSTOM_GRADIENT_IF_RR_PLUS,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			NAME_OR_CUSTOM_COLOR_IF_RR_PLUS_AND_RR_PLUS_GRADIENT
		}

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int PlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool IsInChatThreadVoiceCall
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IsInPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsNameTagVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool ShouldShowUGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		DeveloperDisplayModes DeveloperDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int UGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action OnBroadcastingStateUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action OnDeveloperDisplayUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action OnChatThreadVoiceCallStateUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action OnLocalPlayerPartyUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action OnNametagVisibilityUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action OnUGCProgressionUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action OnRecRoomPlusStateUpdated;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action OnPlayerColorUpdated;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IRRUIvNextSocialBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool CanAccessPartyChat
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool PartyChatHasUnreadUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		COOFKGJALFM PartyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		COOFKGJALFM PartyChatUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int NearbyPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int NearbyFriendsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int NearbyPartyMembersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int NearbyFriendOrPartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int NearbyUnrelatedPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		COOFKGJALFM NearbyPlayersUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<List<int>> GetPartyMemberIds(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<bool> CanGoToAnyPartyMember(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void TryGoToParty();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRRUIvNextStoreItemBridge
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetThumbnailForStoreItem(IBDLCAGKBBC storeItem, [Out] string thumbnailFilename);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Uri GetStoreItemDetailsUri(IBDLCAGKBBC storeItem);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string GetLegacySourceStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string GetLegacySourceMetadataStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Uri GetViewMoreUriFromStoreItemListQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LogItemPurchaseFunnelAnalytics(StoreItemListQueryData queryData, Uri currentUri, Uri newUri, string displayName, GPINOICMGHE step);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IsStoreItemOwned(IBDLCAGKBBC storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string GetStoreItemCostString(IBDLCAGKBBC storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PopulateStoreItemListQueryDataFromSourceInfo(string sourceString, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LogStoreEnteredAnalytics(string entrypointName);
	}
}
namespace RecRoom.AppUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum AccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		ServerSearch,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Friends,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Blocked,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Recent,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Nearby,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		RoomRelated,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		ChatThread,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PartyMembers,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Favorited,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Custom,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		LocalAndMutualBlocks
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FriendAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		All,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Online,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		OnlineInOtherRooms,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		InRoom,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		WithItemWishlisted,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		AttendingEvent,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		MutualFriends
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CreatorAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		MySubscriptions,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		TopCreators
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum RoomRelatedAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Owners,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Moderators
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AccountListQueryData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AccountListQueryType QueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[FGDKCCGIKGN("QueryType", AccountListQueryType.Friends)]
		public FriendAccountListQueryType FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[FGDKCCGIKGN("QueryType", AccountListQueryType.Creator)]
		public CreatorAccountListQueryType CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[FGDKCCGIKGN("QueryType", AccountListQueryType.RoomRelated)]
		public RoomRelatedAccountListQueryType RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int MaxResultLimit;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x21DE030", Offset = "0x21DCA30", VA = "0x1821DE030")]
		public AccountListQueryData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IRRUIvNextUIDataBridge dataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private HIKONMDAKML recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private KNMHECKNPBE onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool excludeJuniorsWithoutCreatePermissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int accountAgeMinDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int accountAgeMaxDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private HFOGFPEGOAK[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private HFOGFPEGOAK[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x76BC280", Offset = "0x76BAC80", VA = "0x1876BC280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x76BC240", Offset = "0x76BAC40", VA = "0x1876BC240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x76BBD90", Offset = "0x76BA790", VA = "0x1876BBD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76BBBB0", Offset = "0x76BA5B0", VA = "0x1876BBBB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76BBDD0", Offset = "0x76BA7D0", VA = "0x1876BBDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76BBB30", Offset = "0x76BA530", VA = "0x1876BBB30")]
		private bool ContainsPlatform(HFOGFPEGOAK platformType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x76BBAB0", Offset = "0x76BA4B0", VA = "0x1876BBAB0")]
		private bool ContainsInteractionCategory(string category)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BaseDiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IAccountQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AHDHLMDPMHH> GetAccountAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		List<int> GetAccountListForQueryData(AccountListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<MEADDAJFLDF> GetProgressionAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<KJKAKMCEIAM> GetReputationAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<bool> GetIsInfluencerAsync(int accountId, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum AppNavContentType
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		PortalSection,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PortalButton,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		WidgetPanel,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Widget
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum WidgetContextConditionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		IntComparison
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class BaseAppNavContentConfig : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public string ContentType;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BaseAppNavContentConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class WidgetSourceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string SourceMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public WidgetSourceData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class WidgetContextCondition
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private enum ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Count,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Min,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Max
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private WidgetContextConditionType conditionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ComparisonType comparisonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int comparisonValue;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string ContextKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76BD360", Offset = "0x76BBD60", VA = "0x1876BD360")]
		public bool IsContextConditionPresent(bool contextActive, int currentValue = 0)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76BD330", Offset = "0x76BBD30", VA = "0x1876BD330")]
		private bool CompareIntValue(int currentValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76BD3C0", Offset = "0x76BBDC0", VA = "0x1876BD3C0")]
		public static bool TryParseRawData(string rawData, [Out] WidgetContextCondition context)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public WidgetContextCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WidgetCondition
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly char CONTEXT_CONDITION_SEPARATOR;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string RawData
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public List<WidgetContextCondition> ContextList
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76BC990", Offset = "0x76BB390", VA = "0x1876BC990")]
		public static bool TryParseRawData(string rawData, [Out] WidgetCondition condition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public WidgetCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class WidgetConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string WidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private List<string> ShowConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private List<string> HideConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public WidgetSourceData OptionalSourceData;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public List<WidgetCondition> ShowConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BB0", Offset = "0x9B65B0", VA = "0x1809B7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B80", Offset = "0x9B6580", VA = "0x1809B7B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<WidgetCondition> HideConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB5D590", Offset = "0xB5BF90", VA = "0x180B5D590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x121EED0", Offset = "0x121D8D0", VA = "0x18121EED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76BCBA0", Offset = "0x76BB5A0", VA = "0x1876BCBA0")]
		public void ProcessContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x76BD260", Offset = "0x76BBC60", VA = "0x1876BD260")]
		public WidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class WidgetPanelConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public string PanelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public List<string> Widgets;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public WidgetPanelConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AppNavWidgetConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public List<WidgetPanelConfig> WidgetPanels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public List<WidgetConfig> WidgetConfigs;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AppNavWidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PortalButtonConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public string Route;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PortalButtonConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class PortalButtonGroupConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public List<PortalButtonConfig> Buttons;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PortalButtonGroupConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PortalPanelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string OptionalWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public List<PortalButtonGroupConfig> Sections;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PortalPanelConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface IAppNavDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		COOFKGJALFM WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<string> WidgetListForPanelChanged;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IOutfitDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		COOFKGJALFM LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<IMHNOILOHNM>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task LoadOutfitAsync(IMHNOILOHNM outfitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IRoomLoadManager
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GoToDorm();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GoToWellKnownRoom(KDOPPBMLPFM room, [Optional] Action<KHDFBKMBMAP> onResponseCallback);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HasSufficientVersionToLoadRoom(FMHJIJNHDAA room);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TryJoinRoom(AKGPNEALNMD roomDetails, HPIALGGGMCA subRoom, bool privateInstance, EOAGFHEGKOP loadSourceData, [Optional] AOPJKBPEOJP versionTarget);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<FMHJIJNHDAA>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FMHJIJNHDAA> GetRoom(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<AKGPNEALNMD> GetRoomDetails(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetCCUCount(long roomId, [Out] int ccuCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IRoomSaveManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AOPJKBPEOJP> GetLatestValidSaveForSubRoom(HPIALGGGMCA subRoom, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AOPJKBPEOJP> GetLatestPublishedSaveForSubRoom(HPIALGGGMCA subRoom, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface IRRUIvNextUIDataBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		HFOGFPEGOAK CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool UGCCircuitBreaker_Room2Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		AKGPNEALNMD LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		COOFKGJALFM LocalPlayer_Created
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		COOFKGJALFM LocalPlayer_OutfitLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		COOFKGJALFM LocalPlayer_Destroying
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ShouldFilterDuplicatesForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task LoadOutfitAsync(IMHNOILOHNM savedOutfitData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IStoreItemQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<IBDLCAGKBBC>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IBDLCAGKBBC> GetStoreItem(LMEDGHCCMPL unifiedItemId, CancellationToken token);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum RoomListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public enum MySources
		{
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum PlayerSources
		{
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum StaticListSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum DynamicAlgorithmicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum ClubhouseSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum RecRoomCreatorAcademySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum KeepsakeRoomSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum PlayerCreatedRoomsFilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public RoomListQuerySources QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.MyRelated)]
		public MySources MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.PlayerRelated)]
		public PlayerSources PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.StaticListSources)]
		public StaticListSources StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.DynamicAlgorithmicSources)]
		public DynamicAlgorithmicSources DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.ClubhouseRelated)]
		public ClubhouseSources ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.RecRoomCreatorAcademyRelated)]
		public RecRoomCreatorAcademySources RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[FGDKCCGIKGN("QuerySource", RoomListQuerySources.KeepsakeRoomRelated)]
		public KeepsakeRoomSources KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[FGDKCCGIKGN("QuerySource", PlayerSources.PlayerCreatedRooms)]
		public bool PublicOwnedRoomsOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[FGDKCCGIKGN("MySource", MySources.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[FGDKCCGIKGN("RequiresOtherPlayerId", true)]
		public PlayerCreatedRoomsFilterType PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[FGDKCCGIKGN("StaticListSource", StaticListSources.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[FGDKCCGIKGN("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[FGDKCCGIKGN("DynamicAlgorithmicSource", DynamicAlgorithmicSources.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[FGDKCCGIKGN("DynamicAlgorithmicSource", DynamicAlgorithmicSources.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCFE580", Offset = "0xCFCF80", VA = "0x180CFE580")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xDF2A20", Offset = "0xDF1420", VA = "0x180DF2A20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x266B220", Offset = "0x2669C20", VA = "0x18266B220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB4D0B0", Offset = "0xB4BAB0", VA = "0x180B4D0B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xD07E50", Offset = "0xD06850", VA = "0x180D07E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4C0", Offset = "0x9AAEC0", VA = "0x1809AC4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4B0", Offset = "0x9AAEB0", VA = "0x1809AC4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9D4D60", Offset = "0x9D3760", VA = "0x1809D4D60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1216CB0", Offset = "0x12156B0", VA = "0x181216CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BE0", Offset = "0x9B65E0", VA = "0x1809B7BE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B20", Offset = "0x9B6520", VA = "0x1809B7B20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xFDC4E0", Offset = "0xFDAEE0", VA = "0x180FDC4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xFDB510", Offset = "0xFD9F10", VA = "0x180FDB510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B50", Offset = "0x9B6550", VA = "0x1809B7B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A20", Offset = "0x9B6420", VA = "0x1809B7A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xC5B7C0", Offset = "0xC5A1C0", VA = "0x180C5B7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xDC7F50", Offset = "0xDC6950", VA = "0x180DC7F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xDD61D0", Offset = "0xDD4BD0", VA = "0x180DD61D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xDD61C0", Offset = "0xDD4BC0", VA = "0x180DD61C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xBA86E0", Offset = "0xBA70E0", VA = "0x180BA86E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xDD5050", Offset = "0xDD3A50", VA = "0x180DD5050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCB5B20", Offset = "0xCB4520", VA = "0x180CB5B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCB5B30", Offset = "0xCB4530", VA = "0x180CB5B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xC467D0", Offset = "0xC451D0", VA = "0x180C467D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x76BC560", Offset = "0x76BAF60", VA = "0x1876BC560")]
		public List<string> GetParsedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x76BC3B0", Offset = "0x76BADB0", VA = "0x1876BC3B0")]
		public List<string> GetAllTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x76BC710", Offset = "0x76BB110", VA = "0x1876BC710")]
		public RoomListQueryData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class StoreItemListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum StoreItemListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			Wishlist,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			StaticSource,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			DynamicSource
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum StaticSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			Storefront,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			AdCarousel
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum DynamicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			AlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			CustomAvatarItemAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			UnifiedAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			UnifiedCuratedList
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private StoreItemListQuerySources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[FGDKCCGIKGN("Source", StoreItemListQuerySources.StaticSource)]
		[SerializeField]
		private StaticSources staticSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		[FGDKCCGIKGN("Source", StoreItemListQuerySources.DynamicSource)]
		private DynamicSources dynamicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		[FGDKCCGIKGN("Source", StoreItemListQuerySources.Search)]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		[FGDKCCGIKGN("Source", StoreItemListQuerySources.Wishlist)]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[BDKICLNFANK("Source", "ShowStorefrontType")]
		[SerializeField]
		private DHELJFMKHFJ storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[BDKICLNFANK("Source", "ShowAdCarouselItemId")]
		[SerializeField]
		private int adCarouselItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		[FGDKCCGIKGN("Source", StoreItemListQuerySources.DynamicSource)]
		private string endpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private int maxItemsToDisplay;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public StoreItemListQuerySources Source
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
			get
			{
				return default(StoreItemListQuerySources);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public StaticSources StaticSource
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0")]
			get
			{
				return default(StaticSources);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC01120", Offset = "0xBFFB20", VA = "0x180C01120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public DynamicSources DynamicSource
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
			get
			{
				return default(DynamicSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9B5550", Offset = "0x9B3F50", VA = "0x1809B5550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9B0460", Offset = "0x9AEE60", VA = "0x1809B0460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9B5CA0", Offset = "0x9B46A0", VA = "0x1809B5CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DHELJFMKHFJ StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xBF57B0", Offset = "0xBF41B0", VA = "0x180BF57B0")]
			get
			{
				return default(DHELJFMKHFJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x12F29C0", Offset = "0x12F13C0", VA = "0x1812F29C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int AdCarouselItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FC0", Offset = "0x9B59C0", VA = "0x1809B6FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FE0", Offset = "0x9B59E0", VA = "0x1809B6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDB0", Offset = "0x9AD7B0", VA = "0x1809AEDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AED80", Offset = "0x9AD780", VA = "0x1809AED80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDD8F10", Offset = "0xDD7910", VA = "0x180DD8F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public StorefrontAdCarouselItem out_StorefrontAdCarouselItem
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4D0", Offset = "0x9AAED0", VA = "0x1809AC4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public NDHNNEOEHFD out_GiftDropStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9AC530", Offset = "0x9AAF30", VA = "0x1809AC530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9AC520", Offset = "0x9AAF20", VA = "0x1809AC520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public FFANFHDCBDL Filters
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB4D0B0", Offset = "0xB4BAB0", VA = "0x180B4D0B0")]
			[CompilerGenerated]
			get
			{
				return default(FFANFHDCBDL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xD07E50", Offset = "0xD06850", VA = "0x180D07E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76BC8F0", Offset = "0x76BB2F0", VA = "0x1876BC8F0")]
		public StoreItemListQueryData()
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
