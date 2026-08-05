using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IFFOMEHAGAC
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
public interface JAEAFNODPBA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO BPBLOOCAILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x23E9F789589B28", Offset = "0x0", VA = "0x23E9F909589B28", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO EDABAAGHNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9589B428023EA4A", Offset = "0x0", VA = "0x9589B440023EA4A", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IFFOMEHAGAC PNBJGKHEBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23EA4E8023EA4A", Offset = "0x0", VA = "0x23EA500023EA4A", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BNBDEFFGAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x23EA4E89589B54", Offset = "0x0", VA = "0x23EA5009589B54", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NJOMFIMEOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x95894E68023EB8C", Offset = "0x0", VA = "0x95894E80023EB8C", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PCODOOPDMCF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CIPCINIJOAK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9589B428023EAA1", Offset = "0x0", VA = "0x9589B440023EAA1", Slot = "8")]
	FJJBNKADFNG<bool> CGEBJOMHPAC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23EAD38023EAB0", Offset = "0x0", VA = "0x23EAD50023EAB0", Slot = "9")]
	PCFNKHPOHAG IBNDEBEIKNF(bool COAPAHEMJMI = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23EAD3893DD820", Offset = "0x0", VA = "0x23EAD5093DD820", Slot = "10")]
	PCFNKHPOHAG PKOLDBHEPIJ(int IFCEFJJEIPE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x23EBDB8023EB8C", Offset = "0x0", VA = "0x23EBDD0023EB8C", Slot = "12")]
	void KAOMKCGGBBI();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23EBDB89589504", Offset = "0x0", VA = "0x23EBDD09589504", Slot = "13")]
	string KGMDJABFCBA(IDLHGHDMEGG MKPKCELOBOL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IDLHGHDMEGG
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
