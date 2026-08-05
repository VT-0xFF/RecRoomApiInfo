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
		IReadOnlyList<int> GetNearbyAccountIds(bool shouldIncludeBroadcastPlayers);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRRUIvNextSocialBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool CanAccessPartyChat
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool PartyChatHasUnreadUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KFBDEOPEKLE PartyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KFBDEOPEKLE PartyChatUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		int NearbyPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int NearbyFriendsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int NearbyPartyMembersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int NearbyFriendOrPartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int NearbyUnrelatedPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		KFBDEOPEKLE NearbyPlayersUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<List<int>> GetPartyMemberIds(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<bool> CanGoToAnyPartyMember(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void TryGoToParty();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IRRUIvNextStoreItemBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool RRPlusUpsellAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetThumbnailForStoreItem(IECDCEFECPJ storeItem, [Out] string thumbnailFilename);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Uri GetStoreItemDetailsUri(IECDCEFECPJ storeItem);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string GetLegacySourceStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string GetLegacySourceMetadataStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Uri GetViewMoreUriFromStoreItemListQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LogItemPurchaseFunnelAnalytics(StoreItemListQueryData queryData, Uri currentUri, Uri newUri, string displayName, BLLEKHLBEAG step);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsStoreItemOwned(IECDCEFECPJ storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "8")]
		string GetStoreItemCostString(IECDCEFECPJ storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PopulateStoreItemListQueryDataFromSourceInfo(string source, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PopulateStoreItemListQueryDataFromCustomAvatarSourceInfo(string sourceString, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<bool> IsItemEligibleForUpsell(OJCLFNBBNMB giftDrop);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LogStoreEnteredAnalytics(string entrypointName);
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
		LocalAndMutualBlocks
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
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
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CreatorAccountListQueryType
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		MySubscriptions,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		TopCreators
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
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
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AccountListQueryData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AccountListQueryType QueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[LGPNBMAJLBN("QueryType", AccountListQueryType.Friends)]
		public FriendAccountListQueryType FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[LGPNBMAJLBN("QueryType", AccountListQueryType.Creator)]
		public CreatorAccountListQueryType CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[LGPNBMAJLBN("QueryType", AccountListQueryType.RoomRelated)]
		public RoomRelatedAccountListQueryType RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int MaxResultLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[LGPNBMAJLBN("QueryType", AccountListQueryType.Nearby)]
		private bool shouldIncludeBroadcastPlayers;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string DisplayNameOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ShouldIncludeBroadcastPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xBEB250", Offset = "0xBEA650", VA = "0x180BEB250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x222BDF0", Offset = "0x222B1F0", VA = "0x18222BDF0")]
		public AccountListQueryData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AccountListQueryDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x789C2A0", Offset = "0x789B6A0", VA = "0x18789C2A0")]
		public static string GetDisplayName(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x789C4D0", Offset = "0x789B8D0", VA = "0x18789C4D0")]
		public static string GetEmptyText(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x789C640", Offset = "0x789BA40", VA = "0x18789C640")]
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
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IRRUIvNextUIDataBridge dataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private NMOOECPHCFK recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JOLGBJEMEGL onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public string[] unsupportedPlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string[] unsupportedInteractionCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool excludeJuniors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool excludeJuniorsWithoutCreatePermissions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int accountAgeMinDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int accountAgeMaxDays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private OIGNCMMGMJK[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private OIGNCMMGMJK[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x789CFA0", Offset = "0x789C3A0", VA = "0x18789CFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x789CF60", Offset = "0x789C360", VA = "0x18789CF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x789CAB0", Offset = "0x789BEB0", VA = "0x18789CAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x789C8D0", Offset = "0x789BCD0", VA = "0x18789C8D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x789CAF0", Offset = "0x789BEF0", VA = "0x18789CAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x789C850", Offset = "0x789BC50", VA = "0x18789C850")]
		private bool ContainsPlatform(OIGNCMMGMJK platformType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x789C7D0", Offset = "0x789BBD0", VA = "0x18789C7D0")]
		private bool ContainsInteractionCategory(string category)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BaseDiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IAccountQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PDBLABCCIPH> GetAccountAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		List<int> GetAccountListForQueryData(AccountListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<AMGGGEOGOCE> GetProgressionAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<NFABDHLNBGK> GetReputationAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<bool> GetIsInfluencerAsync(int accountId, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum AppNavContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PortalSection,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PortalButton,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		WidgetPanel,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Widget
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum WidgetContextConditionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		IntComparison
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BaseAppNavContentConfig : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string ContentType;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BaseAppNavContentConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class WidgetSourceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string SourceMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public WidgetSourceData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WidgetContextCondition
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum ComparisonType
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Count,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Min,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Max
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private WidgetContextConditionType conditionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private ComparisonType comparisonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int comparisonValue;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string ContextKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x789E160", Offset = "0x789D560", VA = "0x18789E160")]
		public bool IsContextConditionPresent(bool contextActive, int currentValue = 0)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x789E130", Offset = "0x789D530", VA = "0x18789E130")]
		private bool CompareIntValue(int currentValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x789E1C0", Offset = "0x789D5C0", VA = "0x18789E1C0")]
		public static bool TryParseRawData(string rawData, [Out] WidgetContextCondition context)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public WidgetContextCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class WidgetCondition
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly char CONTEXT_CONDITION_SEPARATOR;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RawData
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<WidgetContextCondition> ContextList
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x789D790", Offset = "0x789CB90", VA = "0x18789D790")]
		public static bool TryParseRawData(string rawData, [Out] WidgetCondition condition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public WidgetCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class WidgetConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string WidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private List<string> ShowConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private List<string> HideConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public WidgetSourceData OptionalSourceData;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<WidgetCondition> ShowConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C70", Offset = "0x9D5070", VA = "0x1809D5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C20", Offset = "0x9D5020", VA = "0x1809D5C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<WidgetCondition> HideConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBB23C0", Offset = "0xBB17C0", VA = "0x180BB23C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x12684B0", Offset = "0x12678B0", VA = "0x1812684B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x789D9A0", Offset = "0x789CDA0", VA = "0x18789D9A0")]
		public void ProcessContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x789E060", Offset = "0x789D460", VA = "0x18789E060")]
		public WidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class WidgetPanelConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public string PanelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public bool UseProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public List<string> Widgets;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public WidgetPanelConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AppNavWidgetConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public List<WidgetPanelConfig> WidgetPanels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public List<WidgetConfig> WidgetConfigs;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AppNavWidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PortalButtonConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public string Route;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PortalButtonConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class PortalButtonGroupConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public List<PortalButtonConfig> Buttons;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PortalButtonGroupConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PortalPanelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public string OptionalWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public List<PortalButtonGroupConfig> Sections;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PortalPanelConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IAppNavDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		const string DISCOVERYSECTION = "DiscoverySection";

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		KFBDEOPEKLE WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<string> WidgetListForPanelChanged;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TryGetWidgetPanelIcon(string panelId, [Out] string iconId, [Out] bool useProfilePicture);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IOutfitDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		KFBDEOPEKLE LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KFBDEOPEKLE OutfitsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<int> GetTotalSavedOutfitCount(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<HDOFECNGONC>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task LoadOutfitAsync(HDOFECNGONC outfitData);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RecRoomPlusBenefitData : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string NameForAnalytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public string Image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string Description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int Id;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x789D0D0", Offset = "0x789C4D0", VA = "0x18789D0D0")]
		public RecRoomPlusBenefitData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface IRecRoomPlusDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool HasRecRoomPlusSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<RecRoomPlusBenefitData>> GetBenefits(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EDFLCCCJDLN.FBKKMLKONKD> CheckFreeItemSignOnBonusEligibility(CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IRoomLoadManager
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GoToDorm();

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GoToWellKnownRoom(CIAMKDBGCAP room, [Optional] Action<HEDFGOEBINE> onResponseCallback);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HasSufficientVersionToLoadRoom(CNCGCLBFAKP room);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TryJoinRoom(HNAJHGJKLNP roomDetails, HABMELLNJLH subRoom, bool privateInstance, ACOIAJHABAJ loadSourceData, [Optional] IFADHLGHNJJ versionTarget);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<CNCGCLBFAKP>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CNCGCLBFAKP> GetRoom(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HNAJHGJKLNP> GetRoomDetails(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetCCUCount(long roomId, [Out] int ccuCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IRoomSaveManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IFADHLGHNJJ> GetLatestValidSaveForSubRoom(HABMELLNJLH subRoom, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IFADHLGHNJJ> GetLatestPublishedSaveForSubRoom(HABMELLNJLH subRoom, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IRRUIvNextUIDataBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		OIGNCMMGMJK CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool PlatformSupportsSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool UGCCircuitBreaker_Room2Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		HNAJHGJKLNP LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		KFBDEOPEKLE LocalPlayer_Created
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		KFBDEOPEKLE LocalPlayer_OutfitLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		KFBDEOPEKLE LocalPlayer_Destroying
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ShouldFilterDuplicatesForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task LoadOutfitAsync(HDOFECNGONC savedOutfitData);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IStoreItemQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<IECDCEFECPJ>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IECDCEFECPJ> GetStoreItem(MEKHGINHFPB unifiedItemId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsOwnedByLocalPlayer(KOOMIAIMMNH giftDrop);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum RoomListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum MySources
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum PlayerSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum StaticListSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum DynamicAlgorithmicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum ClubhouseSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum RecRoomCreatorAcademySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum KeepsakeRoomSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum PlayerCreatedRoomsFilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public RoomListQuerySources QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.MyRelated)]
		public MySources MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.PlayerRelated)]
		public PlayerSources PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.StaticListSources)]
		public StaticListSources StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.DynamicAlgorithmicSources)]
		public DynamicAlgorithmicSources DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.ClubhouseRelated)]
		public ClubhouseSources ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.RecRoomCreatorAcademyRelated)]
		public RecRoomCreatorAcademySources RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[LGPNBMAJLBN("QuerySource", RoomListQuerySources.KeepsakeRoomRelated)]
		public KeepsakeRoomSources KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[LGPNBMAJLBN("QuerySource", PlayerSources.PlayerCreatedRooms)]
		public bool PublicOwnedRoomsOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[LGPNBMAJLBN("MySource", MySources.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[LGPNBMAJLBN("RequiresOtherPlayerId", true)]
		public PlayerCreatedRoomsFilterType PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[LGPNBMAJLBN("StaticListSource", StaticListSources.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[LGPNBMAJLBN("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[LGPNBMAJLBN("DynamicAlgorithmicSource", DynamicAlgorithmicSources.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[LGPNBMAJLBN("DynamicAlgorithmicSource", DynamicAlgorithmicSources.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD37CA0", Offset = "0xD370A0", VA = "0x180D37CA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xE36D60", Offset = "0xE36160", VA = "0x180E36D60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x26DE1E0", Offset = "0x26DD5E0", VA = "0x1826DE1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB8AA20", Offset = "0xB89E20", VA = "0x180B8AA20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD387B0", Offset = "0xD37BB0", VA = "0x180D387B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9CD850", Offset = "0x9CCC50", VA = "0x1809CD850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9F1B90", Offset = "0x9F0F90", VA = "0x1809F1B90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1260700", Offset = "0x125FB00", VA = "0x181260700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B60", Offset = "0x9D4F60", VA = "0x1809D5B60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AB0", Offset = "0x9D4EB0", VA = "0x1809D5AB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x103C0E0", Offset = "0x103B4E0", VA = "0x18103C0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x103B760", Offset = "0x103AB60", VA = "0x18103B760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C80", Offset = "0x9D5080", VA = "0x1809D5C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B70", Offset = "0x9D4F70", VA = "0x1809D5B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC9B070", Offset = "0xC9A470", VA = "0x180C9B070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xE0CC00", Offset = "0xE0C000", VA = "0x180E0CC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xE1C7A0", Offset = "0xE1BBA0", VA = "0x180E1C7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE1C9F0", Offset = "0xE1BDF0", VA = "0x180E1C9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xBE6830", Offset = "0xBE5C30", VA = "0x180BE6830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE18B10", Offset = "0xE17F10", VA = "0x180E18B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xD116C0", Offset = "0xD10AC0", VA = "0x180D116C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xD116D0", Offset = "0xD10AD0", VA = "0x180D116D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xC85E40", Offset = "0xC85240", VA = "0x180C85E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x789D330", Offset = "0x789C730", VA = "0x18789D330")]
		public List<string> GetParsedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x789D180", Offset = "0x789C580", VA = "0x18789D180")]
		public List<string> GetAllTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x789D4E0", Offset = "0x789C8E0", VA = "0x18789D4E0")]
		public RoomListQueryData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class StoreItemListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum StoreItemListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			Wishlist,
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			StaticSource,
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			DynamicSource
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum StaticSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			Storefront,
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			AdCarousel,
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			CustomAvatarPortfolio,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			CustomAvatarFeatured
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum DynamicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			AlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			CustomAvatarItemAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			UnifiedAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			UnifiedCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			CustomAvatarItemCuratedList
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private StoreItemListQuerySources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		[LGPNBMAJLBN("Source", StoreItemListQuerySources.StaticSource)]
		private StaticSources staticSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		[LGPNBMAJLBN("Source", StoreItemListQuerySources.DynamicSource)]
		private DynamicSources dynamicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[LGPNBMAJLBN("Source", StoreItemListQuerySources.Search)]
		[SerializeField]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[LGPNBMAJLBN("Source", StoreItemListQuerySources.Wishlist)]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		[ECCOCOHEEJA("Source", "ShowStorefrontType")]
		private DMBFOMPAHCH storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[ECCOCOHEEJA("Source", "ShowAdCarouselItemId")]
		[SerializeField]
		private int adCarouselItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[LGPNBMAJLBN("Source", StoreItemListQuerySources.DynamicSource)]
		[SerializeField]
		private string endpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private int maxItemsToDisplay;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public StoreItemListQuerySources Source
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
			get
			{
				return default(StoreItemListQuerySources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public StaticSources StaticSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB52460", Offset = "0xB51860", VA = "0x180B52460")]
			get
			{
				return default(StaticSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xC35ED0", Offset = "0xC352D0", VA = "0x180C35ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public DynamicSources DynamicSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			get
			{
				return default(DynamicSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCC0", Offset = "0x9CF0C0", VA = "0x1809CFCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DMBFOMPAHCH StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xC330B0", Offset = "0xC324B0", VA = "0x180C330B0")]
			get
			{
				return default(DMBFOMPAHCH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x133D650", Offset = "0x133CA50", VA = "0x18133D650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int AdCarouselItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8A40", VA = "0x1809D9640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9D9630", Offset = "0x9D8A30", VA = "0x1809D9630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C9240", Offset = "0x9C8640", VA = "0x1809C9240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xE1B1E0", Offset = "0xE1A5E0", VA = "0x180E1B1E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xE1C480", Offset = "0xE1B880", VA = "0x180E1C480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public StorefrontAdCarouselItem out_StorefrontAdCarouselItem
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9CD7E0", Offset = "0x9CCBE0", VA = "0x1809CD7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public MEFMPHOBFFE out_GiftDropStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9CD7F0", Offset = "0x9CCBF0", VA = "0x1809CD7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string DynamicCarouselName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9CD820", Offset = "0x9CCC20", VA = "0x1809CD820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MJFABMMHCNC Filters
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xECF790", Offset = "0xECEB90", VA = "0x180ECF790")]
			[CompilerGenerated]
			get
			{
				return default(MJFABMMHCNC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xECF770", Offset = "0xECEB70", VA = "0x180ECF770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x789D6E0", Offset = "0x789CAE0", VA = "0x18789D6E0")]
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
