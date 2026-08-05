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
	public interface IRRUIvNextAccountBridge
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AccountListQueryData> GetQueryDataFromWidgetSourceData(WidgetSourceData widgetSourceData);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PopulateAccountListQueryDataFromSourceInfo(string source, string sourceMetadata, AccountListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<int> GetNearbyAccountIds(bool shouldIncludeBroadcastPlayers);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<string> GetFriendlyPresence(int accountId);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CanSendOrAcceptFriendRequest(NLNOOGFPMPO account);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<bool> CanInviteToJoinLocalPlayer(NLNOOGFPMPO account);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CanLocalPlayerJoin(NLNOOGFPMPO account);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TrySendOrAcceptFriendRequest(NLNOOGFPMPO account);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IsInSameRoomAsLocalPlayer(NLNOOGFPMPO account);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRRUIvNextSocialBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool CanAccessPartyChat
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool PartyChatHasUnreadUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		HLLOFHFLNHG PartyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		HLLOFHFLNHG PartyChatUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int NearbyPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int NearbyFriendsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int NearbyPartyMembersCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int NearbyFriendOrPartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		int NearbyUnrelatedPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		HLLOFHFLNHG NearbyPlayersUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<List<int>> GetPartyMemberIds(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<bool> CanGoToAnyPartyMember(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TryGoToParty();

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool CanInviteToParty(NLNOOGFPMPO account);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void InviteToParty(NLNOOGFPMPO account, JGJFCAADGMB partyJoinedSource);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IRRUIvNextStoreItemBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool RRPlusUpsellAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetThumbnailForStoreItem(FLIIEBHJBPE storeItem, [Out] string thumbnailFilename);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Uri GetStoreItemDetailsUri(FLIIEBHJBPE storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string GetLegacySourceStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string GetLegacySourceMetadataStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Uri GetViewMoreUriFromStoreItemListQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LogItemPurchaseFunnelAnalytics(StoreItemListQueryData queryData, Uri currentUri, Uri newUri, string displayName, EHLGPNEEAGM step);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsStoreItemOwned(FLIIEBHJBPE storeItem);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		string GetStoreItemCostString(FLIIEBHJBPE storeItem);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PopulateStoreItemListQueryDataFromSourceInfo(string source, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PopulateStoreItemListQueryDataFromCustomAvatarSourceInfo(string sourceString, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<bool> IsItemEligibleForUpsell(JFGCJJJDCHI giftDrop);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LogStoreEnteredAnalytics(string entrypointName);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TryNavigateToStoreCategory(GameObject gameObject, string discoverySectionId);
	}
}
namespace RecRoom.AppUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
		LocalAndMutualBlocks,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		CuratedList
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FriendAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		All,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Online,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		OnlineInOtherRooms,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		InRoom,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		WithItemWishlisted,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		AttendingEvent,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		MutualFriends
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CreatorAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		MySubscriptions,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		TopCreators
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum RoomRelatedAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Owners,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Moderators
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AccountListQueryData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AccountListQueryType QueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[IEEHBALBFJL("QueryType", AccountListQueryType.Friends)]
		public FriendAccountListQueryType FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[IEEHBALBFJL("QueryType", AccountListQueryType.Creator)]
		public CreatorAccountListQueryType CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[IEEHBALBFJL("QueryType", AccountListQueryType.RoomRelated)]
		public RoomRelatedAccountListQueryType RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int MaxResultLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[IEEHBALBFJL("QueryType", AccountListQueryType.Nearby)]
		[SerializeField]
		private bool shouldIncludeBroadcastPlayers;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string DisplayNameOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool ShouldIncludeBroadcastPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xDB20C0", Offset = "0xDB06C0", VA = "0x180DB20C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x26C0240", Offset = "0x26BE840", VA = "0x1826C0240")]
		public AccountListQueryData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AccountListQueryDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x824AAA0", Offset = "0x82490A0", VA = "0x18824AAA0")]
		public static string GetDisplayName(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x824ACD0", Offset = "0x82492D0", VA = "0x18824ACD0")]
		public static string GetEmptyText(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x824AE40", Offset = "0x8249440", VA = "0x18824AE40")]
		public static string GetSource(this AccountListQueryData queryData)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IRRUIvNextUIDataBridge dataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ONDOEDEALJH recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CBLNFKHJKEG onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool excludeJuniorsWithoutCreatePermissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int accountAgeMinDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int accountAgeMaxDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private OBPBIHKKADB[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private OBPBIHKKADB[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x824B7A0", Offset = "0x8249DA0", VA = "0x18824B7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x824B760", Offset = "0x8249D60", VA = "0x18824B760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x824B2B0", Offset = "0x82498B0", VA = "0x18824B2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x824B0D0", Offset = "0x82496D0", VA = "0x18824B0D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x824B2F0", Offset = "0x82498F0", VA = "0x18824B2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x824B050", Offset = "0x8249650", VA = "0x18824B050")]
		private bool ContainsPlatform(OBPBIHKKADB platformType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x824AFD0", Offset = "0x82495D0", VA = "0x18824AFD0")]
		private bool ContainsInteractionCategory(string category)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BaseDiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IAccountQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MLICMFIFEJD> GetAccountAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<int>> GetAccountListForQueryData(AccountListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<KDMBNNOMHLP> GetProgressionAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<FPIOBNPNGAN> GetReputationAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<bool> GetIsInfluencerAsync(int accountId, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum AppNavContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PortalSection,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PortalButton,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		WidgetPanel,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Widget
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum WidgetContextConditionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		IntComparison
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BaseAppNavContentConfig : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string ContentType;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BaseAppNavContentConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class WidgetSourceData
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string DISCOVERY_SOURCE = "DiscoverySection";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public string Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string SourceMetadata;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public WidgetSourceData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WidgetSourceListData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public List<WidgetSourceData> Sources;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public WidgetSourceListData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class WidgetContextCondition
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Count,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			Min,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Max
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private WidgetContextConditionType conditionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComparisonType comparisonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int comparisonValue;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ContextKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x824C9A0", Offset = "0x824AFA0", VA = "0x18824C9A0")]
		public bool IsContextConditionPresent(bool contextActive, int currentValue = 0)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x824C970", Offset = "0x824AF70", VA = "0x18824C970")]
		private bool CompareIntValue(int currentValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x824CA00", Offset = "0x824B000", VA = "0x18824CA00")]
		public static bool TryParseRawData(string rawData, [Out] WidgetContextCondition context)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public WidgetContextCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class WidgetCondition
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly char CONTEXT_CONDITION_SEPARATOR;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string RawData
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<WidgetContextCondition> ContextList
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x824BFD0", Offset = "0x824A5D0", VA = "0x18824BFD0")]
		public static bool TryParseRawData(string rawData, [Out] WidgetCondition condition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public WidgetCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class WidgetConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public string WidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private List<string> ShowConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private List<string> HideConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public WidgetSourceData OptionalSourceData;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<WidgetCondition> ShowConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0400", Offset = "0xAAEA00", VA = "0x180AB0400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public List<WidgetCondition> HideConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB78DD0", Offset = "0xB773D0", VA = "0x180B78DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x824C1E0", Offset = "0x824A7E0", VA = "0x18824C1E0")]
		public void ProcessContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x824C8A0", Offset = "0x824AEA0", VA = "0x18824C8A0")]
		public WidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WidgetPanelConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string PanelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public bool UseProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public List<string> Widgets;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public WidgetPanelConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AppNavWidgetConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public List<WidgetPanelConfig> WidgetPanels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public List<WidgetConfig> WidgetConfigs;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AppNavWidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class PortalButtonConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public string Route;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PortalButtonConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PortalButtonGroupConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public List<PortalButtonConfig> Buttons;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PortalButtonGroupConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PortalPanelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public string OptionalWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public List<PortalButtonGroupConfig> Sections;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PortalPanelConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IAppNavDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		const string DISCOVERYSECTION = "DiscoverySection";

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		const string SOURCELIST = "SourceList";

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		HLLOFHFLNHG WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<string> WidgetListForPanelChanged;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TryGetWidgetPanelIcon(string panelId, [Out] string iconId, [Out] bool useProfilePicture);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IOutfitDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		HLLOFHFLNHG LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		HLLOFHFLNHG OutfitsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<int> GetTotalSavedOutfitCount(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<LPOLNBIIPNN>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task LoadOutfitAsync(LPOLNBIIPNN outfitData);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class RecRoomPlusBenefitData : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string NameForAnalytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string Image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public string Description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int Id;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x824B8D0", Offset = "0x8249ED0", VA = "0x18824B8D0")]
		public RecRoomPlusBenefitData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IRecRoomPlusDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool HasRecRoomPlusSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<RecRoomPlusBenefitData>> GetBenefits(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<OFNJPBEKMED.PNFEPNOEPLF> CheckFreeItemSignOnBonusEligibility(CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IRoomieQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomieUserFactQueryData.IContext> GetUserFacts(RoomieUserFactQueryData roomieUserFactQueryData, [Optional] RoomieUserFactQueryData.IContext roomieUserFactQueryDataContext, [Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IRoomLoadManager
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GoToDorm();

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GoToWellKnownRoom(MCFOBBOHJFJ room, [Optional] Action<OBDPKMIMLOD> onResponseCallback);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HasSufficientVersionToLoadRoom(PMAJNDFMMGO room);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TryJoinRoom(PCHMDNLFCBM roomDetails, BNKGKIJFGMN subRoom, bool privateInstance, FMDPNOIHBEO loadSourceData, [Optional] IIGDBMBANOC versionTarget);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<PMAJNDFMMGO>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PMAJNDFMMGO> GetRoom(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PCHMDNLFCBM> GetRoomDetails(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetCCUCount(long roomId, [Out] int ccuCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IRoomSaveManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IIGDBMBANOC> GetLatestValidSaveForSubRoom(BNKGKIJFGMN subRoom, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IIGDBMBANOC> GetLatestPublishedSaveForSubRoom(BNKGKIJFGMN subRoom, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUIvNextUIDataBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		OBPBIHKKADB CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool PlatformSupportsSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool UGCCircuitBreaker_Room2Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		PCHMDNLFCBM LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		HLLOFHFLNHG LocalPlayer_Created
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		HLLOFHFLNHG LocalPlayer_OutfitLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		HLLOFHFLNHG LocalPlayer_Destroying
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ShouldFilterDuplicatesForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task LoadOutfitAsync(LPOLNBIIPNN savedOutfitData);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IStoreItemQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<FLIIEBHJBPE>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FLIIEBHJBPE> GetStoreItem(OMICHIGGPNP unifiedItemId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsOwnedByLocalPlayer(NLMPGIDIMPF giftDrop);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum RoomieUserFactSortType
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		CreatedAt_Descending,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		CreatedAt_Ascending
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class RoomieUserFactQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public interface IContext
		{
			[Cpp2IlInjected.Token(Token = "0x17000035")]
			JFCNBELIIIF RoomieUserFactsDto
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			IReadOnlyList<CBBDFDBLGEK> UserFacts
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public class Context : IContext
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public JFCNBELIIIF RoomieUserFactsDto
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public IReadOnlyList<CBBDFDBLGEK> UserFacts
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public Context()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private RoomieUserFactSortType sort;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public RoomieUserFactSortType Sort
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(RoomieUserFactSortType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FD90", Offset = "0x7B5E390", VA = "0x187B5FD90")]
		public RoomieUserFactQueryData(RoomieUserFactQueryData roomieUserFactQueryData)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum RoomListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum MySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum PlayerSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public enum StaticListSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum DynamicAlgorithmicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum ClubhouseSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum RecRoomCreatorAcademySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum KeepsakeRoomSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public enum PlayerCreatedRoomsFilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public RoomListQuerySources QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.MyRelated)]
		public MySources MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.PlayerRelated)]
		public PlayerSources PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.StaticListSources)]
		public StaticListSources StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.DynamicAlgorithmicSources)]
		public DynamicAlgorithmicSources DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.ClubhouseRelated)]
		public ClubhouseSources ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.RecRoomCreatorAcademyRelated)]
		public RecRoomCreatorAcademySources RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[IEEHBALBFJL("QuerySource", RoomListQuerySources.KeepsakeRoomRelated)]
		public KeepsakeRoomSources KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[IEEHBALBFJL("QuerySource", PlayerSources.PlayerCreatedRooms)]
		public bool PublicOwnedRoomsOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[IEEHBALBFJL("MySource", MySources.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[IEEHBALBFJL("RequiresOtherPlayerId", true)]
		public PlayerCreatedRoomsFilterType PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[IEEHBALBFJL("StaticListSource", StaticListSources.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[IEEHBALBFJL("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[IEEHBALBFJL("DynamicAlgorithmicSource", DynamicAlgorithmicSources.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[IEEHBALBFJL("DynamicAlgorithmicSource", DynamicAlgorithmicSources.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC51180", Offset = "0xC4F780", VA = "0x180C51180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x101FD50", Offset = "0x101E350", VA = "0x18101FD50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x255EDF0", Offset = "0x255D3F0", VA = "0x18255EDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD6B700", Offset = "0xD69D00", VA = "0x180D6B700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1459770", Offset = "0x1457D70", VA = "0x181459770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5520", Offset = "0xAA3B20", VA = "0x180AA5520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xACE6A0", Offset = "0xACCCA0", VA = "0x180ACE6A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1613980", Offset = "0x1611F80", VA = "0x181613980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB03C0", Offset = "0xAAE9C0", VA = "0x180AB03C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB04B0", Offset = "0xAAEAB0", VA = "0x180AB04B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x817FC30", Offset = "0x817E230", VA = "0x18817FC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x817F910", Offset = "0x817DF10", VA = "0x18817F910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB0480", Offset = "0xAAEA80", VA = "0x180AB0480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB78B30", Offset = "0xB77130", VA = "0x180B78B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB78BE0", Offset = "0xB771E0", VA = "0x180B78BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB78FA0", Offset = "0xB775A0", VA = "0x180B78FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB78B50", Offset = "0xB77150", VA = "0x180B78B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xEDC6A0", Offset = "0xEDACA0", VA = "0x180EDC6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xB78FC0", Offset = "0xB775C0", VA = "0x180B78FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x824BB30", Offset = "0x824A130", VA = "0x18824BB30")]
		public List<string> GetParsedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x824B980", Offset = "0x8249F80", VA = "0x18824B980")]
		public List<string> GetAllTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x824BCE0", Offset = "0x824A2E0", VA = "0x18824BCE0")]
		public RoomListQueryData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class StoreItemListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum StoreItemListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			Wishlist,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			StaticSource,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			DynamicSource,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			Roomie
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public enum StaticSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			Storefront,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			AdCarousel,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			CustomAvatarPortfolio,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			CustomAvatarFeatured
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum DynamicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			AlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			CustomAvatarItemAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			UnifiedAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			UnifiedCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			CustomAvatarItemCuratedList,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			UnifiedCrossTypeSimilarEntities
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		private StoreItemListQuerySources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[IEEHBALBFJL("Source", StoreItemListQuerySources.StaticSource)]
		[SerializeField]
		private StaticSources staticSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[IEEHBALBFJL("Source", StoreItemListQuerySources.DynamicSource)]
		[SerializeField]
		private DynamicSources dynamicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		[IEEHBALBFJL("Source", StoreItemListQuerySources.Search)]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		[IEEHBALBFJL("Source", StoreItemListQuerySources.Wishlist)]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		[NLDDDANBILD("Source", "ShowStorefrontType")]
		private FJFAJKOFEOG storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[NLDDDANBILD("Source", "ShowAdCarouselItemId")]
		[SerializeField]
		private int adCarouselItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[IEEHBALBFJL("Source", StoreItemListQuerySources.DynamicSource)]
		[SerializeField]
		private string endpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		[IEEHBALBFJL("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		private string crossTypeSimilarEntitySeedId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		[IEEHBALBFJL("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		private GKBALCJHEAI? crossTypeSimilarEntitySeedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private int maxItemsToDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool includeRankingContext;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public StoreItemListQuerySources Source
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
			get
			{
				return default(StoreItemListQuerySources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public StaticSources StaticSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
			get
			{
				return default(StaticSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public DynamicSources DynamicSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(DynamicSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA70B0", Offset = "0xAA56B0", VA = "0x180AA70B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public FJFAJKOFEOG StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAF64A0", Offset = "0xAF4AA0", VA = "0x180AF64A0")]
			get
			{
				return default(FJFAJKOFEOG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x16E2D50", Offset = "0x16E1350", VA = "0x1816E2D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int AdCarouselItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA0E0", Offset = "0xAA86E0", VA = "0x180AAA0E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA0C0", Offset = "0xAA86C0", VA = "0x180AAA0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string CrossTypeSimilarEntitySeedId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public GKBALCJHEAI? CrossTypeSimilarEntitySeedType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x824BFB0", Offset = "0x824A5B0", VA = "0x18824BFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x824BFC0", Offset = "0x824A5C0", VA = "0x18824BFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xC51180", Offset = "0xC4F780", VA = "0x180C51180")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xF29610", Offset = "0xF27C10", VA = "0x180F29610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool IncludeRankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F192F0", Offset = "0x1F178F0", VA = "0x181F192F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x18D1E70", Offset = "0x18D0470", VA = "0x1818D1E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public StorefrontAdCarouselItem out_StorefrontAdCarouselItem
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAAED0", Offset = "0xAA94D0", VA = "0x180AAAED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public DMOLDHBFPFH out_GiftDropStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5520", Offset = "0xAA3B20", VA = "0x180AA5520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Dictionary<string, string> out_RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5730", Offset = "0xAA3D30", VA = "0x180AA5730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA54F0", Offset = "0xAA3AF0", VA = "0x180AA54F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public GGNKGHMDKCA Filters
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCD0", Offset = "0xB2C2D0", VA = "0x180B2DCD0")]
			[CompilerGenerated]
			get
			{
				return default(GGNKGHMDKCA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1679860", Offset = "0x1677E60", VA = "0x181679860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public LDEBBOOOPGC RoomieFilters
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC90", Offset = "0xB2C290", VA = "0x180B2DC90")]
			[CompilerGenerated]
			get
			{
				return default(LDEBBOOOPGC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1679C10", Offset = "0x1678210", VA = "0x181679C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x824BEE0", Offset = "0x824A4E0", VA = "0x18824BEE0")]
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
