using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Async;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum ProgressionEventStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Inactive,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CollectionGracePeriod,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Ended,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Completed
	}
}
namespace RecRoom.ProgressionEvents
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct UncollectedRewardsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int AllUncollectedRewardsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public List<int> AllUncollectedRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int FreeUncollectedRewardsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public List<int> FreeUncollectedRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PremiumUncollectedRewardsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<int> PremiumUncollectedRewards;
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface UDUOZWIETQF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ProgressionEventDTO NYTMCLSKDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ProgressionEventRecordDTO MZIRRWSFNSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		ProgressionEventStatus NNJNCKGDGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int XXRVFQWPDBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int JTHMGGIGWGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int GTBVLASJIDX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int NASMOVKQTXI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		int AFVWPZVDMQN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool FHESBLBBPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool RAOTIMJQREH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int? VUUOIAZOSWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action HIKMNREARWS;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action FVIZDIZWERC;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		EHHKMPWOBWW<bool> TWMXTQOUVEC();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		EMLXNRBUHND Refresh(bool forceUpdateCache = false);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		EMLXNRBUHND XACVSRJXEAK(int a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void FMSQZYLUZOM();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string CSXNGMVTMCR(ProgressionEventConfigurableTextType a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		UncollectedRewardsData RTRHNWEGXEV();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task QLNKPHOAIRQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum ProgressionEventConfigurableTextType
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		HubRoomName,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		ProgressionEventCurrencyName,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		EventInfoFirstPanelTitle,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		EventInfoFirstPanelBody,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		EventInfoSecondPanelTitle,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		EventInfoSecondPanelBody,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		EventInfoThirdPanelTitle,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		EventInfoThirdPanelBody,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		TutorialFirstIntro_PressFeaturedRoomButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		TutorialFirstIntro_PressChallengesButton_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		TutorialFirstIntro_PressProgressionEventChip_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TutorialFirstIntro_PressTodaysRoom_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		TutorialBackup_PressChallengesButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		TutorialBackup_PressTodaysRoomButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		TutorialBackup_PressProgressionEventChip_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		TutorialReward_PressChallengesButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		TutorialReward_PressViewAllRoomsButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		TutorialReward_PressBackButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		TutorialReward_ClaimReward_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		TutorialReward_PressProgressionEventChip_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		TutorialRewardBackup_PressChallengesButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		TutorialRewardBackup_PressViewAllRoomsButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		TutorialRewardBackup_PressBackButton_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		TutorialRewardBackup_ClaimReward_NewWatch,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		TutorialRewardBackup_PressProgressionEventChip_OldWatch,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		ExplorePageBanner_DescriptionText,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		RoomCarousel_RegularRoomsHeader,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		RoomCarousel_PremiumRoomsHeader,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		MainPage_EventEnded_SpendCurrencyBeforeTimeRunsOutPrompt,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		MainPage_EventEnded_SpendCurrencyButtonText,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		MainPage_EventEnded_SpendCurrencyBonusRewardsText,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		RoomCarousel_RegularRoomsDesc,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		RoomCarousel_PremiumRoomsDesc
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
