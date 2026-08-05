using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Settings;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OUTRRPXMZMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Action EEOAFAHWERE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Action SIENZTIRQWW;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private bool JDQGFFMCCEG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89008F0", Offset = "0x88FF4F0", VA = "0x1889008F0")]
	public OUTRRPXMZMB(Action a, Action b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x89008D0", Offset = "0x88FF4D0", VA = "0x1889008D0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum VRMovementModeRequestPriority
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		PERMANENT,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		ROOM_SUPPORT,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		CUSTOM_LOCOMOTION,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		DEBUG
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface HHOQZBKHOKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PlayerType ORGCHPBJKKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		PlayerType WMVOBGZELLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool YGZRCGJHMYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool SXGBWIXQIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		AQWXMNIFQIV COWFQWTOMCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AddVRMovementModeRequest(VRMovementMode movementMode, object token, VRMovementModeRequestPriority priority);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RemoveVRMovementModeRequest(object token);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GPQTOWORXJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		string YZUZKAIZNRN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum PartyJoinedSource
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		NONE = -1,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Code,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PartyGesture,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		ProfileScreen,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		PeopleMenuShortcut,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		InviteToPartyDialog,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PartyInviteInChat,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		AutoRejoinPartyChat,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		InviteOnlineFriends,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		PartyInviteMessage,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		OpenProfileRadialMenu,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		RemoteCommand,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		BeaconAccepted,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		BeaconOffered,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		AutoMerged,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		WidgetWatch,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		PlayerCard
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PlayerType
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		UNINITIALIZED,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		VR_WALK,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		VR_TELEPORT,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SCREEN
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum PlayerGestureRole
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		NONE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		OFFERER,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		ACCEPTER
	}
}
namespace RecRoom.Settings
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum PlayerStatusVisibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Public,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		FriendsOnly,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FavoriteFriendsOnly,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Offline
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum VRMovementMode
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		TELEPORT,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		WALK
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PEHURVHLMYC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8900960", Offset = "0x88FF560", VA = "0x188900960")]
		public static PlayerType NVBCLRHIBAN(this VRMovementMode a)
		{
			return default(PlayerType);
		}
	}
}
namespace RecRoom.AppActionTypes
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Utf8JsonSerializable]
	public class GoToRoomData
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string RoomName
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GoToRoomData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Utf8JsonSerializable]
	public class ShowRoomDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowRoomDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Utf8JsonSerializable]
	public class ShowAccountDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowAccountDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Utf8JsonSerializable]
	public class ShowMessageData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowMessageData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Utf8JsonSerializable]
	public class ShowStorefrontData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string StorefrontUri
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowStorefrontData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Utf8JsonSerializable]
	public class ShowPurchasableItemDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowPurchasableItemDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Utf8JsonSerializable]
	public class ShowCustomAvatarItemStorePageData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xF212A0", Offset = "0xF1FEA0", VA = "0x180F212A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowCustomAvatarItemStorePageData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Utf8JsonSerializable]
	public class AcceptGameInviteData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int FromAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public AcceptGameInviteData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Utf8JsonSerializable]
	public class ShowEventDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public long EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowEventDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Utf8JsonSerializable]
	public class ShowInventionDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowInventionDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Utf8JsonSerializable]
	public class ShowNotificationsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string Category
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int? SubCategory
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xE6CC90", Offset = "0xE6B890", VA = "0x180E6CC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowNotificationsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Utf8JsonSerializable]
	public class ShowClubDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public long ClubId
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowClubDetailsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum ChallengesSection
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		OBSOLETE_New,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Daily,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Weekly
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Utf8JsonSerializable]
	public class ShowChallengesData
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ChallengesSection? Section
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShowChallengesData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Utf8JsonSerializable]
	public class ShowPortfolioDetailsData
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
