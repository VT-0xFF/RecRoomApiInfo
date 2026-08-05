using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Settings;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum VRMovementModeRequestPriority
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		PERMANENT,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		ROOM_SUPPORT,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CUSTOM_LOCOMOTION,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DEBUG
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JXIXCDRLVDH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PlayerType LJUNSTCVINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		PlayerType FNHWMLGAMAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool LNOQIGSODMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool WUZUFZRXAGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		ENIVEIKFIDY MJITHOVYBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AddVRMovementModeRequest(VRMovementMode movementMode, object token, VRMovementModeRequestPriority priority);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RemoveVRMovementModeRequest(object token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum PartyJoinedSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		NONE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Code,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		PartyGesture,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		ProfileScreen,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		PeopleMenuShortcut,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		InviteToPartyDialog,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		PartyInviteInChat,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		AutoRejoinPartyChat,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		InviteOnlineFriends,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PartyInviteMessage,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		OpenProfileRadialMenu,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		RemoteCommand,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		BeaconAccepted,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		BeaconOffered,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AutoMerged,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		WidgetWatch,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PlayerCard
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum PlayerType
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		UNINITIALIZED,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		VR_WALK,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		VR_TELEPORT,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		SCREEN
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum PlayerGestureRole
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		NONE = -1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		OFFERER,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ACCEPTER
	}
}
namespace RecRoom.Settings
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PlayerStatusVisibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Public,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		FriendsOnly,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		FavoriteFriendsOnly,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Offline
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum VRMovementMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		TELEPORT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		WALK
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class TSWGLCDIGXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x841BB40", Offset = "0x841A140", VA = "0x18841BB40")]
		public static PlayerType CWBWFCCOYIE(this VRMovementMode a)
		{
			return default(PlayerType);
		}
	}
}
namespace RecRoom.AppActionTypes
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[Utf8JsonSerializable]
	public class GoToRoomData
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string RoomName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public GoToRoomData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Utf8JsonSerializable]
	public class ShowRoomDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowRoomDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Utf8JsonSerializable]
	public class ShowAccountDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowAccountDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Utf8JsonSerializable]
	public class ShowMessageData
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public long MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowMessageData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Utf8JsonSerializable]
	public class ShowStorefrontData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string StorefrontUri
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowStorefrontData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Utf8JsonSerializable]
	public class ShowPurchasableItemDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowPurchasableItemDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Utf8JsonSerializable]
	public class ShowCustomAvatarItemStorePageData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xF396F0", Offset = "0xF37CF0", VA = "0x180F396F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowCustomAvatarItemStorePageData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Utf8JsonSerializable]
	public class AcceptGameInviteData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int FromAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AcceptGameInviteData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Utf8JsonSerializable]
	public class ShowEventDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public long EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowEventDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Utf8JsonSerializable]
	public class ShowInventionDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowInventionDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Utf8JsonSerializable]
	public class ShowNotificationsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Category
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int? SubCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE58D40", Offset = "0xE57340", VA = "0x180E58D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowNotificationsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Utf8JsonSerializable]
	public class ShowClubDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long ClubId
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowClubDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ChallengesSection
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		OBSOLETE_New,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Daily,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Weekly
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Utf8JsonSerializable]
	public class ShowChallengesData
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public ChallengesSection? Section
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowChallengesData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Utf8JsonSerializable]
	public class ShowPortfolioDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ShowPortfolioDetailsData()
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
