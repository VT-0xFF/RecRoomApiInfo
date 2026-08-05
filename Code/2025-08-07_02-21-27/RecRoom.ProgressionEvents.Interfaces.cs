using System;
using System.Collections.Generic;
using System.Reflection;
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
	public interface WPQBSPIABVX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ProgressionEventDTO TKIVZJBFBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3B5E5E8D856168", Offset = "0x0", VA = "0x3B5E600D856168", Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ProgressionEventRecordDTO KLWDZVABOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD856166803B5F86", Offset = "0x0", VA = "0xD856168003B5F86", Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		ProgressionEventStatus TNCTTEKXWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3B60B2803B5F90", Offset = "0x0", VA = "0x3B60B4003B5F90", Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int URNWSAQJGSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3B60BE8D856168", Offset = "0x0", VA = "0x3B60C00D856168", Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int SJCZOORXTIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD8557F2803B6172", Offset = "0x0", VA = "0xD8557F4003B6172", Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		int QPBAISDEWFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3B61DA803B6180", Offset = "0x0", VA = "0x3B61DC003B6180", Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int NDRMRAQGWMR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3B61DE8D855598", Offset = "0x0", VA = "0x3B61E00D855598", Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool ZXXJFGSLAXR
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD856532803B6532", Offset = "0x0", VA = "0xD856534003B6532", Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action TFEOKZZLJWO;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action ZUCKCMLLIKM;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD8563B6803B62EC", Offset = "0x0", VA = "0xD8563B8003B62EC", Slot = "11")]
		EWYSBGHBSNQ<bool> GZIHSFSLGKG();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B640F803B62F0", Offset = "0x0", VA = "0x3B6411003B62F0", Slot = "12")]
		ZPYKPRNSTIB Refresh(bool forceUpdateCache = false);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B641E8D8563B8", Offset = "0x0", VA = "0x3B64200D8563B8", Slot = "13")]
		ZPYKPRNSTIB GRIACHVFGMG(int a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B6663803B6540", Offset = "0x0", VA = "0x3B6665003B6540", Slot = "15")]
		void RTEPNHVNMDK();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B666E8D8557F4", Offset = "0x0", VA = "0x3B66700D8557F4", Slot = "16")]
		string DCIPTHLDCIB(ProgressionEventConfigurableTextType a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD85D1EE803B66B8", Offset = "0x0", VA = "0xD85D1F0003B66B8", Slot = "17")]
		UncollectedRewardsData EDKBTYKRFEJ();
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
