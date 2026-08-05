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
		bool CanSendOrAcceptFriendRequest(FPIDACHKIAB account);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<bool> CanInviteToJoinLocalPlayer(FPIDACHKIAB account);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CanLocalPlayerJoin(FPIDACHKIAB account);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TrySendOrAcceptFriendRequest(FPIDACHKIAB account);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IsInSameRoomAsLocalPlayer(FPIDACHKIAB account);
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
		EPBKGABEMJJ PartyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		EPBKGABEMJJ PartyChatUpdated
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
		EPBKGABEMJJ NearbyPlayersUpdated
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
		bool CanInviteToParty(FPIDACHKIAB account);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void InviteToParty(FPIDACHKIAB account, NLFKICDNAEH partyJoinedSource);
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
		bool TryGetThumbnailForStoreItem(AMBIDEBMCDP storeItem, [Out] string thumbnailFilename);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Uri GetStoreItemDetailsUri(AMBIDEBMCDP storeItem);

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
		void LogItemPurchaseFunnelAnalytics(StoreItemListQueryData queryData, Uri currentUri, Uri newUri, string displayName, CGFJCDLEPGA step);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsStoreItemOwned(AMBIDEBMCDP storeItem);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		string GetStoreItemCostString(AMBIDEBMCDP storeItem);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PopulateStoreItemListQueryDataFromSourceInfo(string source, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PopulateStoreItemListQueryDataFromCustomAvatarSourceInfo(string sourceString, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<bool> IsItemEligibleForUpsell(CBOBHFCKHLA giftDrop);

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
		[GFLDJILPEIO("QueryType", AccountListQueryType.Friends)]
		public FriendAccountListQueryType FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[GFLDJILPEIO("QueryType", AccountListQueryType.Creator)]
		public CreatorAccountListQueryType CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[GFLDJILPEIO("QueryType", AccountListQueryType.RoomRelated)]
		public RoomRelatedAccountListQueryType RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int MaxResultLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[GFLDJILPEIO("QueryType", AccountListQueryType.Nearby)]
		[SerializeField]
		private bool shouldIncludeBroadcastPlayers;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string DisplayNameOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool ShouldIncludeBroadcastPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD238D0", Offset = "0xD226D0", VA = "0x180D238D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2541530", Offset = "0x2540330", VA = "0x182541530")]
		public AccountListQueryData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AccountListQueryDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3B510", Offset = "0x7E3A310", VA = "0x187E3B510")]
		public static string GetDisplayName(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3B740", Offset = "0x7E3A540", VA = "0x187E3B740")]
		public static string GetEmptyText(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7E3B8B0", Offset = "0x7E3A6B0", VA = "0x187E3B8B0")]
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
		private DFDINHBLJIH recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BEMANHJPLDJ onlineRestrictions;

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
		private FHEHDDAJNCC[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private FHEHDDAJNCC[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7E3C210", Offset = "0x7E3B010", VA = "0x187E3C210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7E3C1D0", Offset = "0x7E3AFD0", VA = "0x187E3C1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7E3BD20", Offset = "0x7E3AB20", VA = "0x187E3BD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E3BB40", Offset = "0x7E3A940", VA = "0x187E3BB40")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7E3BD60", Offset = "0x7E3AB60", VA = "0x187E3BD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BAC0", Offset = "0x7E3A8C0", VA = "0x187E3BAC0")]
		private bool ContainsPlatform(FHEHDDAJNCC platformType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BA40", Offset = "0x7E3A840", VA = "0x187E3BA40")]
		private bool ContainsInteractionCategory(string category)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		Task<AAGOGOPCHGE> GetAccountAsync(int accountId, CancellationToken token);

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
		Task<CPBBNKBIDBG> GetProgressionAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<MFKGCBJCIGC> GetReputationAsync(int accountId, CancellationToken token);

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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D410", Offset = "0x7E3C210", VA = "0x187E3D410")]
		public bool IsContextConditionPresent(bool contextActive, int currentValue = 0)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D3E0", Offset = "0x7E3C1E0", VA = "0x187E3D3E0")]
		private bool CompareIntValue(int currentValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D470", Offset = "0x7E3C270", VA = "0x187E3D470")]
		public static bool TryParseRawData(string rawData, [Out] WidgetContextCondition context)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<WidgetContextCondition> ContextList
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CA40", Offset = "0x7E3B840", VA = "0x187E3CA40")]
		public static bool TryParseRawData(string rawData, [Out] WidgetCondition condition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA66730", Offset = "0xA65530", VA = "0x180A66730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA66690", Offset = "0xA65490", VA = "0x180A66690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public List<WidgetCondition> HideConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xABBEB0", Offset = "0xABACB0", VA = "0x180ABBEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAB9B50", Offset = "0xAB8950", VA = "0x180AB9B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CC50", Offset = "0x7E3BA50", VA = "0x187E3CC50")]
		public void ProcessContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D310", Offset = "0x7E3C110", VA = "0x187E3D310")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		EPBKGABEMJJ WidgetContextChanged
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
		EPBKGABEMJJ LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		EPBKGABEMJJ OutfitsUpdated
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
		Task<List<OPAAGPPHAEP>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task LoadOutfitAsync(OPAAGPPHAEP outfitData);

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
		[Cpp2IlInjected.Address(RVA = "0x7E3C340", Offset = "0x7E3B140", VA = "0x187E3C340")]
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
		Task<BOJPGAMCGNB.NENICCODCLN> CheckFreeItemSignOnBonusEligibility(CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IRoomLoadManager
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GoToDorm();

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GoToWellKnownRoom(FEGFDDOCGPA room, [Optional] Action<IAFMGEFIAGK> onResponseCallback);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HasSufficientVersionToLoadRoom(AOJDMMEOILE room);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TryJoinRoom(AACPGJNOFJH roomDetails, EJHPEGDEELG subRoom, bool privateInstance, KMELJOLMELF loadSourceData, [Optional] GOCLDJNMENA versionTarget);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<AOJDMMEOILE>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AOJDMMEOILE> GetRoom(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<AACPGJNOFJH> GetRoomDetails(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetCCUCount(long roomId, [Out] int ccuCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IRoomSaveManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GOCLDJNMENA> GetLatestValidSaveForSubRoom(EJHPEGDEELG subRoom, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GOCLDJNMENA> GetLatestPublishedSaveForSubRoom(EJHPEGDEELG subRoom, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IRRUIvNextUIDataBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		FHEHDDAJNCC CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool PlatformSupportsSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool UGCCircuitBreaker_Room2Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		AACPGJNOFJH LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		EPBKGABEMJJ LocalPlayer_Created
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		EPBKGABEMJJ LocalPlayer_OutfitLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		EPBKGABEMJJ LocalPlayer_Destroying
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ShouldFilterDuplicatesForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task LoadOutfitAsync(OPAAGPPHAEP savedOutfitData);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IStoreItemQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<AMBIDEBMCDP>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AMBIDEBMCDP> GetStoreItem(OPNNALLJDAD unifiedItemId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsOwnedByLocalPlayer(KNCBLIHIANP giftDrop);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum RoomListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum MySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum PlayerSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum StaticListSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum DynamicAlgorithmicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum ClubhouseSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum RecRoomCreatorAcademySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum KeepsakeRoomSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public enum PlayerCreatedRoomsFilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public RoomListQuerySources QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.MyRelated)]
		public MySources MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.PlayerRelated)]
		public PlayerSources PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.StaticListSources)]
		public StaticListSources StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.DynamicAlgorithmicSources)]
		public DynamicAlgorithmicSources DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.ClubhouseRelated)]
		public ClubhouseSources ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.RecRoomCreatorAcademyRelated)]
		public RecRoomCreatorAcademySources RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[GFLDJILPEIO("QuerySource", RoomListQuerySources.KeepsakeRoomRelated)]
		public KeepsakeRoomSources KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[GFLDJILPEIO("QuerySource", PlayerSources.PlayerCreatedRooms)]
		public bool PublicOwnedRoomsOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[GFLDJILPEIO("MySource", MySources.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[GFLDJILPEIO("RequiresOtherPlayerId", true)]
		public PlayerCreatedRoomsFilterType PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[GFLDJILPEIO("StaticListSource", StaticListSources.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[GFLDJILPEIO("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[GFLDJILPEIO("DynamicAlgorithmicSource", DynamicAlgorithmicSources.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[GFLDJILPEIO("DynamicAlgorithmicSource", DynamicAlgorithmicSources.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5350", Offset = "0xAB4150", VA = "0x180AB5350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xF993B0", Offset = "0xF981B0", VA = "0x180F993B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2413A10", Offset = "0x2412810", VA = "0x182413A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCDED80", Offset = "0xCDDB80", VA = "0x180CDED80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE80190", Offset = "0xE7EF90", VA = "0x180E80190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA7FE00", Offset = "0xA7EC00", VA = "0x180A7FE00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x150D960", Offset = "0x150C760", VA = "0x18150D960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA667D0", Offset = "0xA655D0", VA = "0x180A667D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA66720", Offset = "0xA65520", VA = "0x180A66720")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E7F0", Offset = "0x7D6D5F0", VA = "0x187D6E7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E990", Offset = "0x7D6D790", VA = "0x187D6E990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA66680", Offset = "0xA65480", VA = "0x180A66680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA667E0", Offset = "0xA655E0", VA = "0x180A667E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xABC2D0", Offset = "0xABB0D0", VA = "0x180ABC2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xB0E290", Offset = "0xB0D090", VA = "0x180B0E290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB0E490", Offset = "0xB0D290", VA = "0x180B0E490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB0E4F0", Offset = "0xB0D2F0", VA = "0x180B0E4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB0E440", Offset = "0xB0D240", VA = "0x180B0E440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB28240", Offset = "0xB27040", VA = "0x180B28240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB28250", Offset = "0xB27050", VA = "0x180B28250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0D260", VA = "0x180B0E460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C5A0", Offset = "0x7E3B3A0", VA = "0x187E3C5A0")]
		public List<string> GetParsedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C3F0", Offset = "0x7E3B1F0", VA = "0x187E3C3F0")]
		public List<string> GetAllTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C750", Offset = "0x7E3B550", VA = "0x187E3C750")]
		public RoomListQueryData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class StoreItemListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum StoreItemListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Wishlist,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			StaticSource,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			DynamicSource,
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			Roomie
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum StaticSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			Storefront,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			AdCarousel,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			CustomAvatarPortfolio,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			CustomAvatarFeatured
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum DynamicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			AlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			CustomAvatarItemAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			UnifiedAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			UnifiedCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			CustomAvatarItemCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			UnifiedCrossTypeSimilarEntities
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private StoreItemListQuerySources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		[GFLDJILPEIO("Source", StoreItemListQuerySources.StaticSource)]
		private StaticSources staticSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		[GFLDJILPEIO("Source", StoreItemListQuerySources.DynamicSource)]
		private DynamicSources dynamicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[GFLDJILPEIO("Source", StoreItemListQuerySources.Search)]
		[SerializeField]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		[GFLDJILPEIO("Source", StoreItemListQuerySources.Wishlist)]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[NHKEAFBCMNN("Source", "ShowStorefrontType")]
		private MKHKBBDILNJ storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[NHKEAFBCMNN("Source", "ShowAdCarouselItemId")]
		[SerializeField]
		private int adCarouselItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[GFLDJILPEIO("Source", StoreItemListQuerySources.DynamicSource)]
		private string endpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[GFLDJILPEIO("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		private string crossTypeSimilarEntitySeedId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[GFLDJILPEIO("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		private IAANNMFGJIO? crossTypeSimilarEntitySeedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private int maxItemsToDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private bool includeRankingContext;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public StoreItemListQuerySources Source
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
			get
			{
				return default(StoreItemListQuerySources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public StaticSources StaticSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA750", Offset = "0xAA9550", VA = "0x180AAA750")]
			get
			{
				return default(StaticSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB28270", Offset = "0xB27070", VA = "0x180B28270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DynamicSources DynamicSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			get
			{
				return default(DynamicSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5A470", Offset = "0xA59270", VA = "0x180A5A470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public MKHKBBDILNJ StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA74E0", Offset = "0xAA62E0", VA = "0x180AA74E0")]
			get
			{
				return default(MKHKBBDILNJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x15C5200", Offset = "0x15C4000", VA = "0x1815C5200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int AdCarouselItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xA5C510", Offset = "0xA5B310", VA = "0x180A5C510")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5C500", Offset = "0xA5B300", VA = "0x180A5C500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string CrossTypeSimilarEntitySeedId
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA5C310", Offset = "0xA5B110", VA = "0x180A5C310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public IAANNMFGJIO? CrossTypeSimilarEntitySeedType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7E3CA20", Offset = "0x7E3B820", VA = "0x187E3CA20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7E3CA30", Offset = "0x7E3B830", VA = "0x187E3CA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5350", Offset = "0xAB4150", VA = "0x180AB5350")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xE7CB60", Offset = "0xE7B960", VA = "0x180E7CB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool IncludeRankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1DC7870", Offset = "0x1DC6670", VA = "0x181DC7870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x21B3990", Offset = "0x21B2790", VA = "0x1821B3990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public StorefrontAdCarouselItem out_StorefrontAdCarouselItem
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA5F380", Offset = "0xA5E180", VA = "0x180A5F380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FOMHJBMENLO out_GiftDropStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xA5F340", Offset = "0xA5E140", VA = "0x180A5F340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Dictionary<string, string> out_RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3B0", Offset = "0xA5E1B0", VA = "0x180A5F3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public KMJNGAEKLCL Filters
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xACBC50", Offset = "0xACAA50", VA = "0x180ACBC50")]
			[CompilerGenerated]
			get
			{
				return default(KMJNGAEKLCL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xFD3270", Offset = "0xFD2070", VA = "0x180FD3270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C950", Offset = "0x7E3B750", VA = "0x187E3C950")]
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
