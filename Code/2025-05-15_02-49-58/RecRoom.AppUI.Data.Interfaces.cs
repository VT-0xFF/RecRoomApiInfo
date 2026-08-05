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
		int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool CanAccessPartyChat
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool PartyChatHasUnreadUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GCADBNOOJOM PartyChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		GCADBNOOJOM PartyChatUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		int NearbyPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int NearbyFriendsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int NearbyPartyMembersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int NearbyFriendOrPartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		int NearbyUnrelatedPlayersCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		GCADBNOOJOM NearbyPlayersUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<List<int>> GetPartyMemberIds(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<bool> CanGoToAnyPartyMember(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TryGoToParty();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IRRUIvNextStoreItemBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool RRPlusUpsellAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetThumbnailForStoreItem(FBAKIBIPOMC storeItem, [Out] string thumbnailFilename);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Uri GetStoreItemDetailsUri(FBAKIBIPOMC storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string GetLegacySourceStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string GetLegacySourceMetadataStringFromQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Uri GetViewMoreUriFromStoreItemListQueryData(StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LogItemPurchaseFunnelAnalytics(StoreItemListQueryData queryData, Uri currentUri, Uri newUri, string displayName, KHPHOANPFAN step);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsStoreItemOwned(FBAKIBIPOMC storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "8")]
		string GetStoreItemCostString(FBAKIBIPOMC storeItem);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PopulateStoreItemListQueryDataFromSourceInfo(string source, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PopulateStoreItemListQueryDataFromCustomAvatarSourceInfo(string sourceString, string sourceMetadata, StoreItemListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<bool> IsItemEligibleForUpsell(FOFJDAOJGHL giftDrop);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LogStoreEnteredAnalytics(string entrypointName);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
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
		[CCGNPALHOMH("QueryType", AccountListQueryType.Friends)]
		public FriendAccountListQueryType FriendAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[CCGNPALHOMH("QueryType", AccountListQueryType.Creator)]
		public CreatorAccountListQueryType CreatorAccountQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[CCGNPALHOMH("QueryType", AccountListQueryType.RoomRelated)]
		public RoomRelatedAccountListQueryType RoomRelatedQueryType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int MaxResultLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[CCGNPALHOMH("QueryType", AccountListQueryType.Nearby)]
		[SerializeField]
		private bool shouldIncludeBroadcastPlayers;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string DisplayNameOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ShouldIncludeBroadcastPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x22C3870", Offset = "0x22C1E70", VA = "0x1822C3870")]
		public AccountListQueryData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AccountListQueryDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79CDD50", Offset = "0x79CC350", VA = "0x1879CDD50")]
		public static string GetDisplayName(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79CDF80", Offset = "0x79CC580", VA = "0x1879CDF80")]
		public static string GetEmptyText(this AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79CE0F0", Offset = "0x79CC6F0", VA = "0x1879CE0F0")]
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
		private HEAKNPJEKDG recNetAccounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JPJGDPIBNOF onlineRestrictions;

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
		private KBKDLGNDCGI[] unsupportedPlatformTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private double? accountAgeInDays;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KBKDLGNDCGI[] UnsupportedPlatformTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x79CEA50", Offset = "0x79CD050", VA = "0x1879CEA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IsVRUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x79CEA10", Offset = "0x79CD010", VA = "0x1879CEA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool IsScreensUnsupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79CE560", Offset = "0x79CCB60", VA = "0x1879CE560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private double AccountAgeInDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x79CE380", Offset = "0x79CC980", VA = "0x1879CE380")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x79CE5A0", Offset = "0x79CCBA0", VA = "0x1879CE5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x79CE300", Offset = "0x79CC900", VA = "0x1879CE300")]
		private bool ContainsPlatform(KBKDLGNDCGI platformType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x79CE280", Offset = "0x79CC880", VA = "0x1879CE280")]
		private bool ContainsInteractionCategory(string category)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BaseDiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IAccountQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<INDKPHCCHHI> GetAccountAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		List<int> GetAccountListForQueryData(AccountListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<LDIOKDFMNKL> GetProgressionAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<CGPMAELHOLF> GetReputationAsync(int accountId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
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

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BaseAppNavContentConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class WidgetSourceData
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string DISCOVERY_SOURCE = "DiscoverySection";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string SourceMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public WidgetSourceData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WidgetSourceListData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public List<WidgetSourceData> Sources;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Count,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Min,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Max
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private WidgetContextConditionType conditionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private ComparisonType comparisonType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int comparisonValue;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string ContextKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79CFBF0", Offset = "0x79CE1F0", VA = "0x1879CFBF0")]
		public bool IsContextConditionPresent(bool contextActive, int currentValue = 0)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x79CFBC0", Offset = "0x79CE1C0", VA = "0x1879CFBC0")]
		private bool CompareIntValue(int currentValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x79CFC50", Offset = "0x79CE250", VA = "0x1879CFC50")]
		public static bool TryParseRawData(string rawData, [Out] WidgetContextCondition context)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public WidgetContextCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class WidgetCondition
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly char CONTEXT_CONDITION_SEPARATOR;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string RawData
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<WidgetContextCondition> ContextList
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79CF220", Offset = "0x79CD820", VA = "0x1879CF220")]
		public static bool TryParseRawData(string rawData, [Out] WidgetCondition condition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public WidgetCondition()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class WidgetConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string WidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private List<string> ShowConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<string> HideConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public WidgetSourceData OptionalSourceData;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<WidgetCondition> ShowConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public List<WidgetCondition> HideConditionList
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x79CF430", Offset = "0x79CDA30", VA = "0x1879CF430")]
		public void ProcessContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x79CFAF0", Offset = "0x79CE0F0", VA = "0x1879CFAF0")]
		public WidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WidgetPanelConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public string PanelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public bool UseProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public List<string> Widgets;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public WidgetPanelConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AppNavWidgetConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public List<WidgetPanelConfig> WidgetPanels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public List<WidgetConfig> WidgetConfigs;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AppNavWidgetConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class PortalButtonConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string Route;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PortalButtonConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PortalButtonGroupConfig : BaseAppNavContentConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public List<PortalButtonConfig> Buttons;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PortalButtonGroupConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PortalPanelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string OptionalWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public List<PortalButtonGroupConfig> Sections;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PortalPanelConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IAppNavDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		const string DISCOVERYSECTION = "DiscoverySection";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		const string SOURCELIST = "SourceList";

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		GCADBNOOJOM WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<string> WidgetListForPanelChanged;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TryGetWidgetPanelIcon(string panelId, [Out] string iconId, [Out] bool useProfilePicture);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IOutfitDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		GCADBNOOJOM LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		GCADBNOOJOM OutfitsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<int> GetTotalSavedOutfitCount(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<AGDKHFDLFEH>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task LoadOutfitAsync(AGDKHFDLFEH outfitData);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class RecRoomPlusBenefitData : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string NameForAnalytics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string Image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public string Description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int Id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x79CEB80", Offset = "0x79CD180", VA = "0x1879CEB80")]
		public RecRoomPlusBenefitData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IRecRoomPlusDataManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool HasRecRoomPlusSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<RecRoomPlusBenefitData>> GetBenefits(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PHMMJCOLJFP.IBDFMHGHLOI> CheckFreeItemSignOnBonusEligibility(CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IRoomLoadManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GoToDorm();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GoToWellKnownRoom(BBPEOGEJOCI room, [Optional] Action<OLNCOFFFBDF> onResponseCallback);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HasSufficientVersionToLoadRoom(OHMKBLJJPPO room);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TryJoinRoom(GOMNLGPHFID roomDetails, IINCMBDAHBF subRoom, bool privateInstance, LMOCJFMMFMA loadSourceData, [Optional] KADKLFOGONN versionTarget);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<OHMKBLJJPPO>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OHMKBLJJPPO> GetRoom(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GOMNLGPHFID> GetRoomDetails(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetCCUCount(long roomId, [Out] int ccuCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IRoomSaveManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KADKLFOGONN> GetLatestValidSaveForSubRoom(IINCMBDAHBF subRoom, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KADKLFOGONN> GetLatestPublishedSaveForSubRoom(IINCMBDAHBF subRoom, CancellationToken token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IRRUIvNextUIDataBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		KBKDLGNDCGI CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool PlatformSupportsSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool UGCCircuitBreaker_Room2Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		GOMNLGPHFID LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		GCADBNOOJOM LocalPlayer_Created
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		GCADBNOOJOM LocalPlayer_OutfitLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		GCADBNOOJOM LocalPlayer_Destroying
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ShouldFilterDuplicatesForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task LoadOutfitAsync(AGDKHFDLFEH savedOutfitData);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task SaveOutfitAsync(int slotIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IStoreItemQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<FBAKIBIPOMC>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FBAKIBIPOMC> GetStoreItem(LDJBIDEBIAE unifiedItemId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsOwnedByLocalPlayer(DKAFOOLLHHG giftDrop);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RoomListQueryData
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum RoomListQuerySources
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			ServerSearch,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			MyRelated,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			PlayerRelated,
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			StaticListSources,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			DynamicAlgorithmicSources,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			ClubhouseRelated,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			RecRoomCreatorAcademyRelated,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			KeepsakeRoomRelated
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum MySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			MyCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			MyCreatedDorms,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			MyFavorites,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			MyClubhouse,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			MySubscriptions,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			FriendPresence
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum PlayerSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			PlayerCreatedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			PlayerShowcaseRooms,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			RecentForOtherUser,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			TopCreators,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			MoreFromContestWinners
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum StaticListSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			Featured,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			PlaylistById,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			PlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			MyPlaylistByName,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			CreationBaseRooms
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum DynamicAlgorithmicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			Hot,
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			Recent,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			Recommended,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			ForYou,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			CarouselEndpoint,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			SimilarRooms,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			MaybeUnused_RoomSimilarity
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum ClubhouseSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			ClubhouseOptions
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum RecRoomCreatorAcademySources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			RRCALearnToCreate,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			RRCACreationTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			RRCABuildingTutorials,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			RRCACircuitsTutorials
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum KeepsakeRoomSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			AllKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			StandardKeepsakeRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			PremiumKeepsakeRooms
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public enum PlayerCreatedRoomsFilterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			OwnedAndCoOwnedRooms,
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			OwnedRoomsOnly,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			CoOwnedRoomsOnly
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public RoomListQuerySources QuerySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.MyRelated)]
		public MySources MySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.PlayerRelated)]
		public PlayerSources PlayerSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.StaticListSources)]
		public StaticListSources StaticListSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.DynamicAlgorithmicSources)]
		public DynamicAlgorithmicSources DynamicAlgorithmicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.ClubhouseRelated)]
		public ClubhouseSources ClubhouseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.RecRoomCreatorAcademyRelated)]
		public RecRoomCreatorAcademySources RRCASource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[CCGNPALHOMH("QuerySource", RoomListQuerySources.KeepsakeRoomRelated)]
		public KeepsakeRoomSources KeepsakeRoomSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[CCGNPALHOMH("QuerySource", PlayerSources.PlayerCreatedRooms)]
		public bool PublicOwnedRoomsOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[CCGNPALHOMH("MySource", MySources.MyClubhouse)]
		public bool SortMyClubsByMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[CCGNPALHOMH("RequiresOtherPlayerId", true)]
		public PlayerCreatedRoomsFilterType PlayerCreatedRoomsFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[CCGNPALHOMH("StaticListSource", StaticListSources.PlaylistById)]
		public long PlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[CCGNPALHOMH("StaticListSource", new object[] { 3, 4 })]
		public string PlaylistName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[CCGNPALHOMH("DynamicAlgorithmicSource", DynamicAlgorithmicSources.Hot)]
		public string Tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[CCGNPALHOMH("DynamicAlgorithmicSource", DynamicAlgorithmicSources.CarouselEndpoint)]
		public string CarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool ShouldFetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private List<string> parsedTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly char[] queryTagDelimiters;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private const char pinnedTagDelimiter = '#';

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int FetchStartCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int MaxNumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xE82C40", Offset = "0xE81240", VA = "0x180E82C40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2757150", Offset = "0x2755750", VA = "0x182757150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xBD3490", Offset = "0xBD1A90", VA = "0x180BD3490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xD7FF20", Offset = "0xD7E520", VA = "0x180D7FF20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string ListId
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int OtherPlayerAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public long SimilarSeedRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public (int, int)? RoomCapacityFilterBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x10A06E0", Offset = "0x109ECE0", VA = "0x1810A06E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x10A0180", Offset = "0x109E780", VA = "0x1810A0180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string DynamicListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string CuratedListName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xE59ED0", Offset = "0xE584D0", VA = "0x180E59ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool SupportsDedupe
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE692D0", Offset = "0xE678D0", VA = "0x180E692D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xE69080", Offset = "0xE67680", VA = "0x180E69080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string ResultDeduplicationKey
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string DeduplicationRemovedRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD49D80", Offset = "0xD48380", VA = "0x180D49D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD49D90", Offset = "0xD48390", VA = "0x180D49D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Dictionary<long, string> AlgorithmicRankingContextMap
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCC11E0", Offset = "0xCBF7E0", VA = "0x180CC11E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x79CEDD0", Offset = "0x79CD3D0", VA = "0x1879CEDD0")]
		public List<string> GetParsedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x79CEC20", Offset = "0x79CD220", VA = "0x1879CEC20")]
		public List<string> GetAllTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x79CEF80", Offset = "0x79CD580", VA = "0x1879CEF80")]
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
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Search,
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			Wishlist,
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			StaticSource,
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			DynamicSource
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public enum StaticSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			Storefront,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			AdCarousel,
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			CustomAvatarPortfolio,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			CustomAvatarFeatured
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum DynamicSources
		{
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			AlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			CustomAvatarItemAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			UnifiedAlgorithmicList,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			UnifiedCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			CustomAvatarItemCuratedList,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			UnifiedCrossTypeSimilarEntities
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private StoreItemListQuerySources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[CCGNPALHOMH("Source", StoreItemListQuerySources.StaticSource)]
		private StaticSources staticSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		[CCGNPALHOMH("Source", StoreItemListQuerySources.DynamicSource)]
		private DynamicSources dynamicSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		[CCGNPALHOMH("Source", StoreItemListQuerySources.Search)]
		private string searchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[CCGNPALHOMH("Source", StoreItemListQuerySources.Wishlist)]
		[SerializeField]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[FEIKHLKCJHP("Source", "ShowStorefrontType")]
		private NDHNCEHANCH storefrontType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		[FEIKHLKCJHP("Source", "ShowAdCarouselItemId")]
		private int adCarouselItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[CCGNPALHOMH("Source", StoreItemListQuerySources.DynamicSource)]
		private string endpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		[CCGNPALHOMH("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		private string crossTypeSimilarEntitySeedId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[CCGNPALHOMH("DynamicSource", DynamicSources.UnifiedCrossTypeSimilarEntities)]
		[SerializeField]
		private FAINMENMHBL? crossTypeSimilarEntitySeedType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private int maxItemsToDisplay;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public StoreItemListQuerySources Source
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			get
			{
				return default(StoreItemListQuerySources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public StaticSources StaticSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
			get
			{
				return default(StaticSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public DynamicSources DynamicSource
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			get
			{
				return default(DynamicSources);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public NDHNCEHANCH StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
			get
			{
				return default(NDHNCEHANCH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int AdCarouselItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string Endpoint
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string CrossTypeSimilarEntitySeedId
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FAINMENMHBL? CrossTypeSimilarEntitySeedType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7167380", Offset = "0x7165980", VA = "0x187167380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7167370", Offset = "0x7165970", VA = "0x187167370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int MaxNumItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xD75B10", Offset = "0xD74110", VA = "0x180D75B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public StorefrontAdCarouselItem out_StorefrontAdCarouselItem
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public JBBOJGPFFLN out_GiftDropStorefront
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public JOHNAICEDOD Filters
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060")]
			[CompilerGenerated]
			get
			{
				return default(JOHNAICEDOD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x79CF160", Offset = "0x79CD760", VA = "0x1879CF160")]
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
