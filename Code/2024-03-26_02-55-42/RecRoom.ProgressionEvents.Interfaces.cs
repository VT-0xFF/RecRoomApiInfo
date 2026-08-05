using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MCOBEOGHANH
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
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LAPOLBGJJKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO HOCJAOEAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A364EA8024A1BD", Offset = "0x0", VA = "0x9A364EC0024A1BD", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO PGGKIHAOCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24A1C18024A1BD", Offset = "0x0", VA = "0x24A1C30024A1BD", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MCOBEOGHANH BKELBOAGCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24A1C189A364FC", Offset = "0x0", VA = "0x24A1C309A364FC", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int DOEFGPLAJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A364EA8024A214", Offset = "0x0", VA = "0x9A364EC0024A214", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KMBDELFOOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x24A3338024A2E4", Offset = "0x0", VA = "0x24A3350024A2E4", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AJFBNGNBBHO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AIIDKHPPPBH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24A2438024A220", Offset = "0x0", VA = "0x24A2450024A220", Slot = "8")]
	JNFFOANFOAP<bool> AMOBMGCABHL();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24A2438983E168", Offset = "0x0", VA = "0x24A2450983E168", Slot = "9")]
	PEMLHLMJEJH FBJNDCAAACB(bool DDCCJJDKKMM = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9A3802E8024A2E4", Offset = "0x0", VA = "0x9A380300024A2E4", Slot = "10")]
	PEMLHLMJEJH IBDHMHAOJMD(int PHBDGLPBFIM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24A33389A3804C", Offset = "0x0", VA = "0x24A33509A3804C", Slot = "12")]
	void NNIJKGIGPIJ();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9A3805A8024A33B", Offset = "0x0", VA = "0x9A3805C0024A33B", Slot = "13")]
	string NGJOIGFHIPA(OFGJLJGOIJH KNNHCJOOIML);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OFGJLJGOIJH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	HubRoomName,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	ProgressionEventCurrencyName,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	EventInfoFirstPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	EventInfoFirstPanelBody,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	EventInfoSecondPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	EventInfoSecondPanelBody,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	EventInfoThirdPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	EventInfoThirdPanelBody,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TutorialFirstIntro_PressFeaturedRoomButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TutorialFirstIntro_PressChallengesButton_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TutorialFirstIntro_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TutorialFirstIntro_PressTodaysRoom_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	TutorialBackup_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	TutorialBackup_PressTodaysRoomButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	TutorialBackup_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	TutorialReward_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TutorialReward_PressViewAllRoomsButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TutorialReward_PressBackButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TutorialReward_ClaimReward_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	TutorialReward_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TutorialRewardBackup_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	TutorialRewardBackup_PressViewAllRoomsButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TutorialRewardBackup_PressBackButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TutorialRewardBackup_ClaimReward_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	TutorialRewardBackup_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ExplorePageBanner_DescriptionText,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RoomCarousel_RegularRoomsHeader,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RoomCarousel_PremiumRoomsHeader,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	MainPage_EventEnded_SpendCurrencyBeforeTimeRunsOutPrompt,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	MainPage_EventEnded_SpendCurrencyButtonText,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	MainPage_EventEnded_SpendCurrencyBonusRewardsText,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	RoomCarousel_RegularRoomsDesc,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RoomCarousel_PremiumRoomsDesc
}
namespace Cpp2IlInjected;

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
